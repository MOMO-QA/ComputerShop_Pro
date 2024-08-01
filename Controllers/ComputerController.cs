using ComputerShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputerShop.Controllers
{
    public class ComputerController : Controller
    {

        public   List<Computer> AllComputer = new List<Computer>();

        public void addComputers ()
        {
            for (int i =0; i< 10; i++)
            {
                Computer computer = new Computer();
                computer.ID = i;
                computer.Name = i.ToString();
                computer.Description = i.ToString();
                computer.Price = 18;
                computer.computer_Comp.CPU = i.ToString();
                computer.computer_Comp.Ram = "RAm";
                computer.computer_Comp.MotherBoard = i.ToString();
                AllComputer.Add(computer);   
            }
        }

        public ComputerController ()
        {
            addComputers ();
        }

        public IActionResult Index()
        {
            return View(AllComputer);
        }

        public IActionResult Details(int ID)
        {
             Computer c = AllComputer.FirstOrDefault(o => o.ID == ID); 
              
            return View(new ComputerDetailsVM(){
                ID = c.ID,
                Ram = c.computer_Comp.Ram
            });
        }

    }
}
