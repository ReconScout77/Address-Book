using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      List<Contact> currentBook = Contact.GetBook();
      return View(currentBook);
    }

    [HttpGet("/contact")]
    public ActionResult AddContact()
    {
      return View();
    }

    [HttpPost("/contact/new")]
    public ActionResult NewContact()
    {
      Address newAddress = new Address(Request.Form["street-input"], Request.Form["city-input"], Request.Form["state-input"]);
      Contact newContact = new Contact(Request.Form["name-input"], Request.Form["phone-input"], newAddress);
      return View(newContact);
    }

    [HttpGet("/contact/{id}")]
    public ActionResult ContactDetails(int id)
    {
      Contact chosenContact = Contact.Find(id);
      return View(chosenContact);
    }

    [HttpPost("/contacts/clear")]
    public ActionResult ClearContacts()
    {
      Contact.ClearAll();
      return View();
    }
  }
}
