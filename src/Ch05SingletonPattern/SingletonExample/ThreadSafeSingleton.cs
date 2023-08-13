namespace SingletonExample;

public class ThreadSafeSingleton {
    private static ThreadSafeSingleton? _instance;
    private static object _lockObj = new object(); 
    
    private ThreadSafeSingleton() { }
    
    public static ThreadSafeSingleton GetInstance()
    {
        if(_instance is null)
            lock(_lockObj)
                _instance = new ThreadSafeSingleton();
        
        return _instance;
    }
}