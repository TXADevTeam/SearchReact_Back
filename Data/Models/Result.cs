namespace Data.Models
{
    public class Result : ISearch.ISearch
    {
        
         public Result(int id, string title, string desc)
         {
             Id = id;
             Title = title;
             Desc = desc;
         }

         public int Id { get; set; }
         public string Title { get; set; }
         public string Desc { get; set; }
    }
   
}