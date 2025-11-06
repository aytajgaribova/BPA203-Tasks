
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {

        List<Student> students = new List<Student>
        {
            new Student(1, "Ali", "Məmmədov", 20, 85.5),
            new Student(2, "Leyla", "Həsənova", 19, 92.0),
            new Student(3, "Vüqar", "Əliyev", 21, 78.5),
            new Student(4, "Nigar", "Əhmədova", 20, 88.0),
            new Student(5, "Rəşad", "Quliyev", 22, 95.5)
        };

        foreach (var s in students)
            s.DisplayInfo();

        FileManager fm = new FileManager();

        if (fm.CheckFolderExists())
            fm.DeleteFolder();

        fm.CreateFolder();

        Console.WriteLine(fm.CheckFolderExists() ? "Qovluq yaradildi" : "Qovluq yaradilmadi");

  
        foreach (var s in students)
            fm.WriteStudentToFile(s);

        fm.WriteAllStudentsToFile(students);

   
        List<Student> readStudents = fm.ReadStudentsFromFile();
        foreach (var s in readStudents)
            s.DisplayInfo();

        fm.SerializeToJson(students);


        List<Student> fromJson = fm.DeserializeFromJson();
        foreach (var s in fromJson)
            s.DisplayInfo();

    
        Console.WriteLine(" students.txt fayl mezmunu:");
        Console.WriteLine(File.ReadAllText(fm.TextFilePath));

        Console.WriteLine(" students.json fayl mezmunu:");
        Console.WriteLine(File.ReadAllText(fm.JsonFilePath));

        Console.WriteLine("STATİSTİKA:");
        Console.WriteLine($"Ümumi tələbə sayı: {students.Count}");
        Console.WriteLine($"Orta qiymət: {students.Average(s => s.Grade):F2}");
        Console.WriteLine($"Ən yüksək qiymət: {students.Max(s => s.Grade)}");
        Console.WriteLine($"Ən aşağı qiymət: {students.Min(s => s.Grade)}");
        Console.WriteLine($"90+ qiymətli tələbə sayı: {students.Count(s => s.Grade >= 90)}");

        FileInfo txtInfo = new FileInfo(fm.TextFilePath);
        FileInfo jsonInfo = new FileInfo(fm.JsonFilePath);

        Console.WriteLine($"students.txt ölçüsü: {txtInfo.Length} bayt");
        Console.WriteLine($"students.json ölçüsü: {jsonInfo.Length} bayt");
    }
}
