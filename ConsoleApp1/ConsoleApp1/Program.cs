using Object__Class__Constructor__Inheritance__this_vs_base_keywords;
namespace Object__Class__Constructor__Inheritance__this_vs_base_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ali", "Məmmədov", 20, "ali@gmail.com", "S001", "2021001", "İT", 88.5, 2);
            Student student2 = new Student("Aynur", "Əliyeva", 21, "aynur@egmail.com", "S002", "2021002", "Mühəndislik", 92.0, 3);
            Student student3 = new Student("Rəşad", "Hüseynov", 19, "reshad@egmail.com", "S003", "2021003", "Biznes", 68.5, 1);

      
            Teacher teacher1 = new Teacher("Elçin", "Quliyev", 45, "elchin@gmail.com", "T001", "Kompüter Elmləri", "OOP", 800, 15);
            Teacher teacher2 = new Teacher("Sevinc", "Hacıyeva", 38, "sevinc@gmail.com", "T002", "Riyaziyyat", "Statistika", 750, 8);

       
            Administrator admin = new Administrator("Kamran", "Əsədov", 50, "kamran@gmail.com", "A001", "Dekan", "İnformasiya Texnologiyaları", 5);

          
            double totalScholarship = 0;
            decimal totalSalary = 0;

            student1.ShowStudentInfo();
            double scholarship1 = student1.CalculateScholarship();
            Console.WriteLine($"Scholarship Amount: {scholarship1} AZN\n");
            totalScholarship += scholarship1;

    
            student2.ShowStudentInfo();
            double scholarship2 = student2.CalculateScholarship();
            Console.WriteLine($"Scholarship Amount: {scholarship2} AZN\n");
            totalScholarship += scholarship2;

            student3.ShowStudentInfo();
            double scholarship3 = student3.CalculateScholarship();
            Console.WriteLine($"Scholarship Amount: {scholarship3} AZN\n");
            totalScholarship += scholarship3;

            teacher1.ShowTeacherInfo();
            decimal salary1 = teacher1.CalculateSalary();
            Console.WriteLine($"Total Salary: {salary1} AZN\n");
            totalSalary += salary1;


             teacher2.ShowTeacherInfo();
             decimal salary2 = teacher2.CalculateSalary();
             Console.WriteLine($"Total Salary: {salary2} AZN\n");
             totalSalary += salary2;

           
            admin.ShowAdminInfo();
            Console.WriteLine();
            admin.GrantAccess(student1);
            Console.WriteLine();

            // Statistik məlumat
            Console.WriteLine("Statistics");
            Console.WriteLine($"Total Scholarship Cost: {totalScholarship} AZN");
            Console.WriteLine($"Total Salary Cost: {totalSalary} AZN");
        }
    }
}