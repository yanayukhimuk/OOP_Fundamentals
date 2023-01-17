using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Library
{
    internal class Book : IPublication
    {
        private int _id;
        private int _pagesCount;
        private string _title;
        private string _author;
        public int Id => _id;
        public DateTime DatePublished => throw new NotImplementedException();

        public PublicationType Type => throw new NotImplementedException();

        public int PagesCount
        {
            get { return _pagesCount; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Pages count can't be negative.");
                _pagesCount = value;
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                if (value == null)
                    throw new NullReferenceException("The title cannot be null.");
                _title = value;
            }
        } 

        public string Author
        {
            get { return _author; }
            set
            {
                if (value == null)
                    throw new NullReferenceException("The author cannot be null.");
                _author = value;
            }
        }
    }
}
