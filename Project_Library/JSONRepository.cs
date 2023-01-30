using LinqToDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    public class JSONRepository<T> : IRepository<T> where T : class
    {
        Newtonsoft.Json.JsonSerializer serializer;
        string readFrom;
        string writeTo;
        public JSONRepository(string readFromPath, string writeTo)
        {
            this.readFrom = readFromPath;
            serializer = new Newtonsoft.Json.JsonSerializer();
            this.writeTo = writeTo;
        }

        #region IRepository<T> Members
        public IQueryable<T> Query => throw new NotImplementedException();

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public List<T> DownloadFiles()
        {
            StreamReader reader= new StreamReader(this.readFrom);
            string json = reader.ReadToEnd();
            var list = JsonConvert.DeserializeObject<List<T>>(json);
            reader.Close();
            return list;
        }

        public void UploadFiles(List<T> files)
        {
            using (StreamWriter sw = File.CreateText(this.writeTo))
            {
                foreach (var file in files)
                {
                    serializer.Serialize(sw, file);
                }
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
