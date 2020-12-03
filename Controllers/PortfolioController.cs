using Microsoft.AspNetCore.Mvc;
namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        //for each route this controller is to handle:
        [HttpGet]       //type of request
        [Route("")]     //associated route string (exclude the leading /)
        public string Index()
        {
            return "This is my Index!";
        }
        //for each route this controller is to handle:
        [HttpGet("projects")]       //type of request
        public string Projects()
        {
            return "These are my projects";
        }
        [HttpGet("contact")]       //type of request
        public string contact()
        {
            return "This is my Contact!";
        }

    }
}