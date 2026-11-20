using BSIT_32E1_Elective_2_Assignment_1.Data;
using Microsoft.AspNetCore.Mvc;

namespace BSIT_32E1_Elective_2_Assignment_1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(QuestionBank.All);

    public IActionResult Error() => Content("Something went wrong.");
}
