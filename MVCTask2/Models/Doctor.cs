namespace MVCTask2.Models
{
    public class Doctor:BaseModel
    {
        public string ImgUrl { get; set; }
        public string FullName {  get; set; }
        public int DescriptionId { get; set; }
        public Department Department { get; set; }
    }
}
