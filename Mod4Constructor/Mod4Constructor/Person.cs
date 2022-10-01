namespace Mod4Constructor
{
    class Person
    {

        public string Firstname;
        public string Lastname;

        public Person(string Firstname, string Lastname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
        }

        public int BirthYear;

        public Person(int BirthYear)
        {
            this.BirthYear = BirthYear;
        }

        public void GetFullName()
        {
            System.Action Person = GetFullName;
        }

        public void GetAge()
        {
            System.Action BirthYear = GetAge;
        }

    }
}
