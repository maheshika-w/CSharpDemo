namespace SampleDemo
{
    public record Student : Person
    {
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public int Grade { get; set; }
    }
}
