using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using TestRada1;
using DevExpress.XtraEditors;
using TestRada1.BUS;
namespace TestRada1
{
    public partial class frm_NewUser : Form
    {

        public frm_NewUser()
        {
            InitializeComponent();
        }
        private bool check = false;
        BUS.UserBus _userBus = new BUS.UserBus();
        DeparmentBus _departmentBus = new DeparmentBus( );
        byte[] converImageToBirany(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
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

        #region insert Customer
        private void insertCustomer()
        {
            DTO.ST_User _newUser = new DTO.ST_User();
            _newUser.user_name = txt_Name.Text;
            _newUser.user_username = txt_UserName.Text;
            _newUser.user_password = txt_Password.Text;


            if (date_BirthDay.Text != "")
            {
                DateTime date = Convert.ToDateTime(date_BirthDay.Text);
                date.ToString("yy/MM/dd");
                _newUser.user_date_of_birth = date;
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
            _newUser.user_created_date = DateTime.Now;

            _newUser.user_email = txt_Email.Text;



            _newUser.user_created = 1;

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
            Int64 boolInsertCustomer = _userBus.insertUser(_newUser);
            if (boolInsertCustomer != 0)
            {
                Messeage.success("Thêm Mới Thành Công!");

                this.Close();
            }
            else
            {
                Messeage.error("Không Thể Thêm Mới!");

            }
        }
        #endregion
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
            else if (txt_Password.Text == "")
            {
                txt_Password.Focus();
                return "Vui Lòng Nhập !";
            }
            else if (txt_RePassword.Text == "")
            {
                txt_RePassword.Focus();
                return "Vui Lòng Nhập Lại Mật Khẩu!";
            }
            else
            {
                return "true";
            }
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string check = checkNull();

                if (check == "true")
                {
                    if (txt_Password.Text == txt_RePassword.Text)
                        insertCustomer();
                    else
                        Messeage.error("Mật Khẩu Không Khớp!");
                }
                else
                {
                    Messeage.error(check);
                }
            }
            catch (Exception)
            {
                Messeage.err();
            }
        }

        private void but_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lke_Department_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frm_NewUser_Load(object sender, EventArgs e)
        {
            StyleDevxpressGridControl.autoLookUpEdit(lke_Department);

            lke_Department.Properties.ValueMember = "department_id";
            lke_Department.Properties.DisplayMember = "department_name";
            
            LoadDepartment();
        }
        private void LoadDepartment( )
        {
            lke_Department.Properties.DataSource = _departmentBus.listAll( );
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
            LoadDepartment( );
        }

        private void btn_AddCustomerGroup_Click(object sender, EventArgs e)
        {
            frm_Newdepartment frm = new frm_Newdepartment( );
            frm.FormClosed += new FormClosedEventHandler(dongformDepartment);
            frm.ShowDialog();
        }
    }
}
