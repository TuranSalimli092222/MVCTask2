namespace MVCTask2.Models
{
    public class Department:BaseModel
    {
        public string Title { get; set; }
        public ICollection<Doctor> Dpctors { get; set; }
    }
}
