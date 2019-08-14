# Phone Assignment

In this assignment, we are going to use **Abstract** classes and **Interfaces** to create 2 types of phones: Nokia and Galaxy.

***Objectives:***

* Define Classes 
* Define Interfaces 
* Implement classes that use abstract classes and interfaces

***Tasks:***

* Create a **Phone** abstract class.

```javascript
public abstract class Phone 
{
    private string _versionNumber;
    private int _batteryPercentage;
    private string _carrier;
    private string _ringTone;
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
        _versionNumber = versionNumber;
        _batteryPercentage = batteryPercentage;
        _carrier = carrier;
        _ringTone = ringTone;
}
    // abstract method. This method will be implemented by the subclasses
    public abstract void DisplayInfo();
    // public getters and setters removed for brevity. Please implement them yourself
}
```

* Create an **IRingable** interface that contains the following methods:
  * **Ring()**: This method returns a string
  * **Unlock()**: This method returns a string



***IRingable.cs***
```javascript
    public interface IRingable 
{
    // your code here
}
```

* Create an **Nokia** and **Galaxy **classes. Both classes should extend from the **Phone** abstract class and implement the **IRingable** interface.

***Nokia.cs***
```javascript
 public class Nokia : Phone, IRingable 
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        // your code here
    }
    public string Unlock() 
    {
        // your code here
    }
    public override void DisplayInfo() 
    {
        // your code here            
    }
}
```
***Galaxy.cs***
```javascript
public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        // your code here
    }
                
    public string Unlock() 
    {
        // your code here
    }
    public override void DisplayInfo() 
    {
        // your code here            
    }
}
```
* Implement the overridden methods (**Ring**, **Unlock**, **DisplayInfo**) from the Nokia and Galaxy classes according to the **Program** file below:

***Program.cs***
```javascript
class Program
{
    static void Main(string[] args)
    {
        Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Dooo do doo dooo");
        Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ringgg ring ringgg");

        s8.DisplayInfo();
        Console.WriteLine(s8.Ring());
        Console.WriteLine(s8.unlock());
        Console.WriteLine("");

        elevenHundred.DisplayInfo();
        Console.WriteLine(elevenHundred.Ring());
        Console.WriteLine(elevenHundred.unlock());
        Console.WriteLine("");
    }
}
```