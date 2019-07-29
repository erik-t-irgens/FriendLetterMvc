using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;


namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/")]
        public ActionResult Letter()
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = "Lina";
            myLetterVariable.Sender = "Jasmine";
            myLetterVariable.Location = "Iceland";
            myLetterVariable.Souvenir = "Cup";
            return View(myLetterVariable);
        }


        [Route("/form")]
        public ActionResult Form() { return View(); }

        [Route("/postcard")]
        public ActionResult Postcard(string recipient, string sender, string location, string souvenir)
        {
            LetterVariable myLetterVariable = new LetterVariable();
            myLetterVariable.Recipient = recipient;
            myLetterVariable.Sender = sender;
            myLetterVariable.Location = location;
            myLetterVariable.Souvenir = souvenir;
            return View(myLetterVariable);
        }

        [Route("/madlibsform")]
        public ActionResult Madlibsform() { return View(); }

        [Route("/madlibs")]
        public ActionResult Madlibs(string propNoun1, string propNoun2, string place1, string place2, string person1, string person2, string noun1, string noun2, string noun3, string verb1, string verb2, string verb3, string adj1, string adj2, string adj3)
        {
            MadLibVariable myMadLibVariable = new MadLibVariable();
            myMadLibVariable.PropNoun1 = propNoun1;
            myMadLibVariable.PropNoun2 = propNoun2;
            myMadLibVariable.Place1 = place1;
            myMadLibVariable.Place2 = place2;
            myMadLibVariable.Person1 = person1;
            myMadLibVariable.Person2 = person2;
            myMadLibVariable.Noun1 = noun1;
            myMadLibVariable.Noun2 = noun2;
            myMadLibVariable.Noun3 = noun3;
            myMadLibVariable.Verb1 = verb1;
            myMadLibVariable.Verb2 = verb2;
            myMadLibVariable.Verb3 = verb3;
            myMadLibVariable.Adj1 = adj1;
            myMadLibVariable.Adj2 = adj2;
            myMadLibVariable.Adj3 = adj3;


            return View(myMadLibVariable);
        }
    }
}