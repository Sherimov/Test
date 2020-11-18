namespace PolarCape.CollegeApp.DataModel
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int Semester { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
    }
}
