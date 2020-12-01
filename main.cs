using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Input a temperature in CELSIUS:");

    int celsius = Int32.Parse(Console.ReadLine());
    double fahrenheit = (celsius * (9/5)) + 32;

    Console.WriteLine ("Fahrenheit: " + fahrenheit);
    
    if (fahrenheit < 32) {
      Console.WriteLine ("Thie temperature is below freezing temperature of 32 degrees Fahrenheit.");
    } else if (fahrenheit > 212) {
      Console.WriteLine ("This temperature is above the boiling point of 212 degrees Fahrenheit.");
    }
  }
}