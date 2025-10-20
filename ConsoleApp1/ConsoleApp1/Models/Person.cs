using System;
namespace Object__Class__Constructor__Inheritance__this_vs_base_keywords
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Email;
        public string ID;


        public Person(string FirstName, string LastName, int Age, string Email, string ID)
        {
            System.Console.WriteLine("ctor ise dusdu");
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Email = Email;
            this.ID = ID;
        }
        public void ShowBasicInfo()
        {
            System.Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}, Email: {Email}, ID: {ID}");
        }
        public void GetFullName()
        {
            System.Console.WriteLine(LastName + FirstName);

        }



    }
}