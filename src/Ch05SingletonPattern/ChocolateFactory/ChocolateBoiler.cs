namespace ChocolateFactory;

public class ChocolateBoiler {
    private static ChocolateBoiler? _instance;

    private ChocolateBoiler()
    {
        IsEmpty = true;
        IsBoiled = false;
    }
    
    public static ChocolateBoiler GetInstance()
    {
        if(_instance is null)
            _instance = new ChocolateBoiler();
    
        return _instance;
    }

    public void Fill()
    {
        if(!IsEmpty) return;
        
        // fill the boiler with a milk/chocolate mixture
        Console.WriteLine("Filling Boiler...");
        
        IsEmpty = false;
        IsBoiled = false;
    }
    
    public void Drain()
    {
        if(IsEmpty) return;
        
        if(!IsBoiled) return;
        
        // drain the boiled milk and chocolate
        Console.WriteLine("Draining Boiler...");
        
        IsEmpty = true;
    }
    
    public void Boil()
    {
        if(IsEmpty) return;
        
        if(IsBoiled) return;
        
        // bring the contents to a boil
        Console.WriteLine("Boiling Boiler...");
        
        IsBoiled = true;
    }
    
    private bool IsEmpty { get; set; }
    
    private bool IsBoiled { get; set; }
}