using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

    // Input: List down the prime minister of Make a dictionary with the year and details of the prime minister
    Dictionary<int, string> primeMinisters = new Dictionary<int, string>();

    primeMinisters.Add(1998, "Atal Bihari Vajpayee");
    primeMinisters.Add(2014, "Narendra Modi");
    primeMinisters.Add(2004, "Manmohan Singh");

    // Find the Prime minister of 2004.
    string findPm = primeMinisters[2004];
    Console.WriteLine("(1). The prime minister of 2004:  " + findPm);
    Console.WriteLine();

    // Add the current prime minister in the dictionary.
    primeMinisters.Add(2019, "Narendra Damodar Das Modi");
    Console.WriteLine("(2). Addition of Current Prime Minister Done.");
    Console.WriteLine();

    //Sort the dictionary by year.
    var sortedPM = primeMinisters.OrderBy(pm => pm.Key);
    Console.WriteLine("(3). After Sorting the Dictionary is as Follows: ");
     foreach (KeyValuePair<int, string> pm in sortedPM)
    {
        Console.WriteLine(pm.Key + " - " + pm.Value);
    }

   
  }
}