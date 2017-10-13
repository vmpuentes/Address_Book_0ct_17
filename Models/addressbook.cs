using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private int _phonenumber;

    private static List<Contacts> _contactList = new List<Contact> {};

    public Car (string name, string _address, int _phonenumber)
    {
       _name = name;
       _addres = addres;
       _phonenumber = phonenumber;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetName()
    {
      return _newName;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      // if (newP >= 0) {
      //   _price = newPrice;
      // }
      // else {
      //   Console.WriteLine("The price for this item is not valid.");
      // }
    }

    public int GetPhoneNumber()
    {
      return _phonenumber;
    }

    public void SetAddress(int newAddress)
    {
      _address = newAddress;
    }
    public int GetAddress()
    {
      return _address;
    }

    public void Save()
    {
      _contacList.Add(this);
    }

    public static List<Contact> GetAll()
    {
      return _contactList;
    }

    public static void ClearAll()
    {
      _contactList = new List<Contacts> {};
    }

    public bool MaxPrice(int maximumPossiblePrice)
    {
    
    }
  }
}
