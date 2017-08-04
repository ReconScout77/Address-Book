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

    [HttpGet("/addcontact")]
    public ActionResult AddContact()
    {
      return View();
    }

    [HttpPost("/addcontact/add")]
    public ActionResult NewContact()
    {
      Address newAddress = new Address(Request.Form["street-input"], Request.Form["city-input"], Request.Form["state-input"]);
      Contact newContact = new Contact(Request.Form["name-input"], Request.Form["phone-input"], newAddress);
      List<Contact> allContacts = Contact.GetBook();
      return View("Index", allContacts);
    }
  }
}
