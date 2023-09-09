using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
  
  {
    user aUser = new user("asmith123","smith","Adam","Smith");
    user bUser = new user("bjones123","jones","Bob","Jones");
    user cUser = new user("cjohnson123","johnson","Carol","Johnson");

    Console.WriteLine("The number of users created is "+user.numberOfUsers);

    user [] userListArray = new user[3];

    userListArray[0]= aUser;
    userListArray[1]= bUser;
    userListArray[2]= cUser;

    for(int i =0;i<userListArray.Length;i++)
    {
      if(userListArray[i].Username=="asmith123")
      {
        Console.WriteLine("First Name:\t{0}\nSurname:\t{1}", userListArray[i].FirstName, userListArray[i].Surname);
      }
    }  
  }
}
