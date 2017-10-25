using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phone;
    private string _address;
    private int _id;

    private static List<Contact> _contactList = new List <Contact> {};

    public Contact (string contactName, string phoneNumber , string contactAddress)
    {
       _name = contactName;
       _phone = phoneNumber;
       _address = contactAddress;
       _contactList.Add(this);
       _id = _contactList.Count;
    }

    public string GetName()
    {
      return _name;
    }

    // public void SetName(string newName)
    // {
    //   _name = newName;
    // }

    public string GetPhone()
    {
      return _phone;
    }

    // public void SetPhone(string newPhone)
    // {
    //   _phone = newPhone;
    // }

    public string GetAddress()
    {
      return _address;
    }

    // public void SetAddress(string newAddress)
    // {
    //   _address = newAddress;
    // }

    public int GetId()
    {
      return _id;
    }

    // public void Save()
    // {
    //   _contactList.Add(this);
    // }

    public static List<Contact> GetAll()
    {
      return _contactList;
    }

    public static void ClearAll()
    {
      _contactList.Clear();
    }
  }
}
