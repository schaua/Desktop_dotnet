namespace Day1.Models
{
    public class Author
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Firstname, Lastname);
        }
    }
}