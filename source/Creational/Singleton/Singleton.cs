namespace Singleton;

public sealed class Singleton
{
    private static Singleton _instance;

    private static readonly object InstanceLock = new();

    public static Singleton Instance
    {
        get
        {
            if (_instance is not null) return _instance;

            lock (InstanceLock)
            {
                _instance ??= new Singleton();
            }

            return _instance;
        }
    }

    private Singleton() { }
}
