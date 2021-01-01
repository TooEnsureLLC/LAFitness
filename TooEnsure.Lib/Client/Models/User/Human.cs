using System.ComponentModel.DataAnnotations;

namespace TooEnsure.Lib.Client.Models.User
{
    public class Human
    {
        [Required] public int SSN { get; set; }
        [Required] public string FirstName { get; set; }
        [Required] public string LastName { get; set; }
        [Required] public bool IsMale { get; set; }

        public Human()
        {
            System.Console.WriteLine("Human was borned");
        }

        public Human(int sSN, string firstName, string lastName, bool isMale)
        {
            this.SSN = sSN;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.IsMale = isMale;
        }
    }
}