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

    public Contacts (string name, string address, int phonenumber)
    {
       _name = name;
       _address = address;
       _phonenumber = phonenumber;
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
      return _newPhoneNumber;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      _phoneNumber = _newPhoneNumber;
    }

    public int GetAddress()
    {
      return _address;
    }

    public void SetAddress(int newAddress)
    {
      _address = newAddress;
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
  }
}
