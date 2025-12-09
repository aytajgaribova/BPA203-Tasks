using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller


{
List<Student> students= new List<Student>
{
    new Student{Id=1, Name="Aytac", Age=19},
    new Student{Id=2, Name="Fidan", Age=19},
    new Student{Id=3, Name="Kenan", Age=19},
};




    public IActionResult Index(){

        // ViewBag.Student=students;
        // ViewData["Students"]= students;
        TempData["Name"]="Kayla";

        return View();
} 

[Route("korporativ-satislar")]
public IActionResult CorporativeSales()
    {
        return View();
    }
}