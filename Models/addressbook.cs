using System;
using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _address;
    private string _phoneNumber;

    private static List<Contact> _contactList = new List<Contact> {};

    public Contact (string name, string address, string phoneNumber)
    {
       _name = name;
       _address = address;
       _phoneNumber = phoneNumber;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public void Save()
    {
      _contactList.Add(this);
    }

    public static List<Contact> GetAll()
    {
      return _contactList;
    }

    public static void ClearAll()
    {
      _contactList = new List<Contact> {};
    }
  }
}
