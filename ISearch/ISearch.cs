using System;

namespace ISearch
{
    public interface ISearch
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
    }
    
}