using System.Collections.Generic;
using System;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _contactName;
    private int _phoneNumber;
    private string _contactAddress;

    private static List<Contact> _contactList = new List<Contact> {};

    public Contact (string contactName, int phoneNumber , string contactAddress)
    {
       _contactName = contactName;
        _phonenumber = phonenumber;
       _contactAddress = contactAddress;

    }

    public string GetContactName()
    {
      return _name;
    }

    public void SetContactName(string newContactName)
    {
      _contactName = newContactName;
    }

    public string GetPhoneNumber()
    {
      return _newPhoneNumber;
    }

    public void SetPhoneNumber(int newPhoneNumber)
    {
      _PhoneNumber = _newPhoneNumber;
    }

    public int GetContactAddress()
    {
      return _contactAddress;
    }

    public void SetContactAddress(int newContactAddress)
    {
      _contactAddress = newContactAddress;
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
      _contactList = new List<Contact> {};
    }
  }
}
