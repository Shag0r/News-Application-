namespace NewsApplication.Models
{
    public class News
    {
        public int newsID { get; set; }
        public string newsName { get; set;}
        public string newsDescription { get; set;} = string.Empty;
        public News()
        {
            
        }
    }
}
