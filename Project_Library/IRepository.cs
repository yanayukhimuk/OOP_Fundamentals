using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public interface IRepository<TEntity> where TEntity : class
    {
        List<TEntity> DownloadFiles();
        void UploadFiles(List<TEntity> files);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Save();
    }
}
