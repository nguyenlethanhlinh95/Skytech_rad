using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TestRada1
{
    public partial class frm_UpdateUser : Form
    {
        public frm_UpdateUser()
        {
            InitializeComponent();
        }
        public Int64 userId { set; get; }
        private bool check = false;
        BUS.UserBus _userBus = new BUS.UserBus();
        BUS.DeparmentBus _departmentBus = new BUS.DeparmentBus( );
        byte[] converImageToBirany(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
       
        public string checkNull()
        {
            if (txt_Name.Text == "")
            {
                txt_Name.Focus();
                return "Vui Lòng Nhập Tên Người Dùng!";
            }
            else if (lke_Department.Text == lke_Department.Properties.NullText)
            {
                lke_Department.Focus();
                return "Vui Lòng Nhập Chức Vụ!";
            }
            else if (txt_UserName.Text == "")
            {
                txt_UserName.Focus();
                return "Vui Lòng Nhập Tài khoản!";
            }
            else
            {
                return "true";
            }
        }
        public void loadDepartment()
        {
            lke_Department.Properties.ValueMember = "department_id";
            lke_Department.Properties.DisplayMember = "department_name";
            lke_Department.Properties.DataSource = _departmentBus.listAll();
        }
        public void loadUser()
        { try
            {
            var user = _userBus.getUserById(userId);

            var address = user.GetType().GetProperty("user_address").GetValue(user, null);
            if ( address != null )
                txt_Address.Text = address.ToString();

            var email = user.GetType( ).GetProperty("user_email").GetValue(user, null);
            if ( email != null )
                txt_Email.Text = email.ToString( );

            var name = user.GetType().GetProperty("user_name").GetValue(user, null);
            if ( name != null )
                txt_Name.Text = name.ToString();

           
            var phone = user.GetType().GetProperty("user_phone").GetValue(user, null);
            if ( phone != null )
                txt_PhoneNumber.Text = phone.ToString();

            var username = user.GetType().GetProperty("user_username").GetValue(user, null);
            if ( username != null )
                txt_UserName.Text = username.ToString();

            var department = user.GetType().GetProperty("department_id").GetValue(user, null);
            if ( department != null )
                lke_Department.EditValue = department.ToString();
            
            var birthday = user.GetType().GetProperty("user_date_of_birth").GetValue(user, null);
            if (birthday != null)
            {
                DateTime date = Convert.ToDateTime(birthday);

                date_BirthDay.Text = date.ToShortDateString();

                
            }
            var brimary = user.GetType().GetProperty("user_image").GetValue(user, null);
            if (brimary != null)
            {
                byte[] array = (brimary as System.Data.Linq.Binary).ToArray();
                MemoryStream ms = new MemoryStream(array);
                pic_Logo.Image = Image.FromStream(ms);
            }
            var checkStatus = user.GetType().GetProperty("user_status").GetValue(user, null).ToString();
            if (checkStatus == "True")
                check_Status.Checked = true;
            else
                check_Status.Checked = false;


            var gender = user.GetType().GetProperty("user_gender").GetValue(user, null).ToString();
            if (gender.ToString() == "True")
            {
                cbb_Gender.SelectedItem = "Nam";
            }
            else
            {
                cbb_Gender.SelectedItem = "Nữ";
            }

            }
            catch (Exception)
            {
                Messeage.error("Lỗi !");
            }
        }
        private void UpdateUser_Load(object sender, EventArgs e)
        {
           
            loadUser();
            loadDepartment();
        }

        private void updateUser()
        {
            try
            {
                DTO.ST_User _newUser = new DTO.ST_User();
                _newUser.user_id = userId;
                _newUser.user_name = txt_Name.Text;
                _newUser.user_username = txt_UserName.Text;



                if (date_BirthDay.Text != "")
                {
                    DateTime dateGuarantee = Convert.ToDateTime(date_BirthDay.Text);
                    dateGuarantee.ToString("yyyy/MM/dd");
                    _newUser.user_date_of_birth = dateGuarantee;
                }


                var gender = cbb_Gender.SelectedItem;
                if (gender.ToString() == "Nam")
                {
                    _newUser.user_gender = true;
                }
                else
                {
                    _newUser.user_gender = true;
                }

                _newUser.user_phone = txt_PhoneNumber.Text;

                _newUser.user_address = txt_Address.Text;


                _newUser.user_email = txt_Email.Text;





                _newUser.user_status = check;
                // get value lookup edit customer group

                _newUser.department_id = Convert.ToInt64(lke_Department.EditValue);

                //get value picter customer pricter



                if (pic_Logo.Image != null)
                {
                    byte[] fileByte = converImageToBirany(pic_Logo.Image);
                    System.Data.Linq.Binary fileBinary = new System.Data.Linq.Binary(fileByte);
                    _newUser.user_image = fileBinary;
                }
                bool boolInsertCustomer = _userBus.updateUser(_newUser);
                if (boolInsertCustomer == true)
                {
                    Messeage.success("Cập Nhật Thành Công!");

                    this.Close();
                }
                else
                {
                    Messeage.error("Không Thể Cập Nhật!");

                }
            }
            catch (Exception)
            {
                Messeage.err();
            }
        }


        private void btn_Img_Click(object sender, EventArgs e)
        {
            string filename;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    pic_Logo.Image = Image.FromFile(filename);
                }
            }
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
           
                string check = checkNull();

                if (check == "true")
                {
                    updateUser();
                }
                else
                {
                    Messeage.error(check);
                }
            
        }

        private void check_Status_CheckedChanged(object sender, EventArgs e)
        {

            if (check == true)
            {
                check = false;
            }
            else
                check = true;
        }

        private void dongformDepartment(object sender, EventArgs e)
        {
            loadDepartment( );
        }

        private void btn_AddCustomerGroup_Click(object sender, EventArgs e)
        {
            frm_Newdepartment frm = new frm_Newdepartment( );
            frm.FormClosed += new FormClosedEventHandler(dongformDepartment);
            frm.ShowDialog( );
        }
    }
}
