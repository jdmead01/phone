//Create an Nokia and Galaxy classes. Both classes should extend from the Phone abstract class and implement the IRingable interface.



public class Galaxy : Phone, IRingable 
{
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        return $"{ringTone}";
    }
                
    public string Unlock() 
    {
        return $"Galaxy {versionNumber} unlocked with fingerprint scanner";
    }
    public override void DisplayInfo() 
    {
        System.Console.WriteLine("#######################");
        System.Console.WriteLine($"Galaxy {versionNumber}");
        System.Console.WriteLine($"Battery Percentage: {batteryPercentage}");
        System.Console.WriteLine($"Carrier: {carrier}");
        System.Console.WriteLine($"Ring Tone: {ringTone}");
        System.Console.WriteLine("#######################");
    }
}