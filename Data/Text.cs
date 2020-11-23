using System;
using System.DirectoryServices;

namespace Data
{
    public class Text
    {
        private int _id;
        private string _title;
        private string _description;
        public Text(int id, string title, string description)
        {
            _id = id;
            _title = title;
            _description = description;
        }
    }

}