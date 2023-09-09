using System;

class user
{
  protected string username;
  protected string password;
  protected string firstName;
  protected string surname;
  public static int numberOfUsers;//This variables is accessible only through the type reference

  //Default constructor
  public user()
  {
    numberOfUsers++;
  }

  public user(string username, string password, string firstName, string surname)
  {
    this.username=username;
    this.password=password;
    this.firstName=firstName;
    this.surname=surname;
    numberOfUsers++;
  }

  public string Username
  {
    get
    {
      return username;
    }

    set 
    {
      username=value;
    }
  }

  public string Password
  {
    get
    {
      return password;
    }

    set 
    {
      password=value;
    }
  }

  public string FirstName
  {
    get
    {
      return firstName;
    }

    set 
    {
      firstName=value;
    }
  }

  public string Surname
  {
    get
    {
      return surname;
    }

    set 
    {
      surname=value;
    }
  }
}
