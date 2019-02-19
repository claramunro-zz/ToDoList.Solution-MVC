
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Index()
      {
        Item starterItem = new Item("Add first item to To Do List");
        return View(starterItem);
      }

      [Route("/items/new")] //link route in index.cshtml. We create a new route at the path /items/new. Notice this is the same path in the link on Index.cshtml. That's how we can ensure this route is invoked when the user clicks the link.
      public ActionResult CreateForm()
      {
        return View();
      }

      [Route("/items")] //Again, notice the URL path of this route is /items. This matches the action='/items' attribute of our form exactly. Which is how we know this route will be executed when our form is submitted.
      public ActionResult Create(string description)
      {
        Item myItem = new Item(description); //We instantiate a new Item named myItem by passing the description parameter to the Item constructor. (Remember, this description will represent whatever the user provided in the <input> field with a name="description" attribute.)
        return View("Index", myItem);
      }
    //   Also, notice we never created a Create.cshtml view to correspond with our Create() route! 
    //   Instead, by passing the "Index" argument to Create()'s View() method, we were able to reuse an existing view. 
    //   This keeps code DRY, and allows us to be more specific with routes.

  }
}