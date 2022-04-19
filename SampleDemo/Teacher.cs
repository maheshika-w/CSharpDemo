namespace SampleDemo
{
    public record Teacher : Person
    {
        public Teacher(string firstName, string lastName, DateTime joinedOn!!)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.JoiningDate = joinedOn;
        }
        public DateTime JoiningDate { get; init; }
    }
}
