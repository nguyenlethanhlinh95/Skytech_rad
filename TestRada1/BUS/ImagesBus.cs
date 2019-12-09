using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestRada1.BUS
{
    class ImagesBus
    {
        DAO.ImagesDao _imgDao = new DAO.ImagesDao();
        public bool insertImg(DTO.ST_Image img)
        {
          return  _imgDao.insertImg(img);
        }
        public IEnumerable<Object> getAllImage()
        {
            return _imgDao.getAllImage();
        }
    }
}
