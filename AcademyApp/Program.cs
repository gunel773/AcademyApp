using AcademyApp.Business.Services;
using AcademyApp.Domain.Models;
using AcademyApp.Helper;
StudentService studentService = new();
Helper.ChangeTextColor(ConsoleColor.Green,"Academy App");
Helper.ChangeTextColor(ConsoleColor.Yellow,"Enter Number:" + 
    "1.CreateStudent  2.GetAllStudent");
EnterMenu: string menu=Console.ReadLine();
bool result = int.TryParse(menu, out int intMenu);
