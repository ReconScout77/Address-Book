using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Address
  {
    private string _street;
    private string _city;
    private string _state;

    public Address(string theStreet, string theCity, string theState)
    {
      _street = theStreet;
      _city = theCity;
      _state = theState;
    }

    public string GetStreet()
    {
      return _street;
    }
    public void SetStreet(string newStreet)
    {
      _street = newStreet;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string newCity)
    {
      _city = newCity;
    }

    public string GetState()
    {
      return _state;
    }
    public void SetState(string newState)
    {
      _state = newState;
    }
  }
}
