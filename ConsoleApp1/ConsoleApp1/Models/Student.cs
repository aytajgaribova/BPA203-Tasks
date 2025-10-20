using System.Xml;

class Student :Person
{
    public string StudentNumber;
    public string Faculty;
    public double GPA;
    public int Year;
    public Student(string FirstName, string LastName, int Age, string Email, string ID, string StudentNumber, string Faculty, double GPA, int Year)
    : base(FirstName, LastName, Age, Email, ID)
    {
        System.Console.WriteLine("ctor ise dusdu");
        this.StudentNumber = StudentNumber;
        this.Faculty = Faculty;
        this.GPA = GPA;
        this.Year = Year;
    }
    public void ShowStudentInfo( string ShowBasicInfo)
    {
        System.Console.WriteLine("StudentInfo");
        System.Console.WriteLine($"Student Number: {StudentNumber}, Faculty: {Faculty}, GPA: {GPA}, Year: {Year}");

    }
    public void CalculateScholarship()
    {
        if (GPA >= 90)
        {
            System.Console.WriteLine(500);
        }
        else if (GPA >= 80)
        {
            System.Console.WriteLine(350);
        }
        else if (GPA >= 70)
        {
            System.Console.WriteLine(200);
        }
        else
        {
            System.Console.WriteLine(0);
        }
    }
}