using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFileManager : IImageFileService
    {
        IImageFileDAL _ImageFileDAL;

        public ImageFileManager(IImageFileDAL ımageFileDAL)
        {
            _ImageFileDAL = ımageFileDAL;
        }

        public List<ImageFile> GetList()
        {
           return _ImageFileDAL.List();
        }
    }
}
