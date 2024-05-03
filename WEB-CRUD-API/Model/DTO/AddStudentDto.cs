namespace WEB_CRUD_API.Model.DTO
{
    public class AddStudentDto
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public char Fraction { get; set; }
    }
}
