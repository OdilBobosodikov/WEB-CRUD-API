namespace WEB_CRUD_API.Model.DTO
{
    public class UpdateStudentDto
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public int Year { get; set; }
        public char Fraction { get; set; }
    }
}
