class Teacher : Person
{
    public string Department;
    public string MainSubject;
    public decimal BaseSalary;
    public int ExperienceYears;

    public Teacher(String FirstName, string LastName, int Age, string Email, string ID, string Department, string MainSubject, decimal BaseSalary, int ExperienceYears)
      : base(FirstName, LastName, Age, Email, ID)
    {
        this.Department = Department;
        this.MainSubject = MainSubject;
        this.BaseSalary = BaseSalary;
        this.ExperienceYears = ExperienceYears;
    }
    public void ShowTeacherInfo(string ShowBasicInfo)
    {
        System.Console.WriteLine(ShowTeacherInfo);
       
        System.Console.WriteLine($"Department: {Department}, MainSubject: {MainSubject}, BaseSalary: {BaseSalary}, Experience: {ExperienceYears}");
    }
    public void CalculateSalary()
    {
        System.Console.WriteLine(BaseSalary + (ExperienceYears*50));
    }
}