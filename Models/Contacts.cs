using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private Address _home;
    private static List<Contact> _contacts = new List<Contact> {};
    private int _id;

    public Contact(string theName, string thePhone, Address theHome)
    {
      _name = theName;
      _phone = thePhone;
      _home = theHome;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhone()
    {
      return _phone;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }

    public static List<Contact> GetBook()
    {
      return _contacts;
    }

    public int GetId()
    {
      return _id;
    }

    public static Contact Find(int lostId)
    {
      return _contacts[lostId - 1];
    }

    public Address GetAddress()
    {
      return _home;
    }

    public static void ClearAll()
    {
      _contacts.Clear();
    }
  }
}
