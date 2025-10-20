namespace bject__Class__Constructor__Inheritance__this_vs_base_keywords {
    class Administrator : Person
    {
        public string Position;
        public string Department;
        public int AccessLevel;

        public Administrator(string firstName, string lastName, int age, string email, string id,
                string position, string department, int accessLevel)
                : base(firstName, lastName, age, email, id)
        {
            this.Position = position;
            this.Department = department;
            this.AccessLevel = accessLevel;
        }
}

        public void ShowAdminInfo()
        {
            System.Console.WriteLine($"Position: {Position},Department: {Department}, Access Level: {AccessLevel} ");
        }

        public void GrantAccess(Student student)
        {
            Console.WriteLine($"Access granted to student {student.GetFullName()} (ID: {student.Id})");
        }

    }
  
