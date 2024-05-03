namespace WEB_CRUD_API.Model.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public char Fraction { get; set; }

    }
}
