namespace LifeCycleExamples;

public interface IScopedService
{
    int GetRandomNumber();
}

public class ScopedService : IScopedService
{
    int randomNumber;
    public ScopedService()
    {
        Random rnd = new Random();
        randomNumber = rnd.Next();
    }

    public int GetRandomNumber()
    {
        return randomNumber;
    }
    
}