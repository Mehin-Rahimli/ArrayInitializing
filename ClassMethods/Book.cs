using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class Book
    {
        private string _name;
        private string _author;
        public bool _IsAvailable;
        public string Name
        {
            get { return _name; }
            set { value = _name; }
        }
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public bool IsAvailable
        {
            get { return _IsAvailable; }
            set { _IsAvailable = value; }
        }
        public Book(string name,string author,bool isavailable=true)
        {
            _name = name;
            _author = author;
            _IsAvailable = isavailable;
        }
        public void GetInfo()
        {
            Console.WriteLine($"BookName:{_name},Author:{_author},IsAvailable:{_IsAvailable}");
        }
    }
}
