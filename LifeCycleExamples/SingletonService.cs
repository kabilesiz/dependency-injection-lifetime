namespace LifeCycleExamples;
public interface ISingletonService
{
    int GetRandomNumber();
}

public class SingletonService : ISingletonService
{
    int randomNumber;
    public SingletonService()
    {
        Random rnd = new Random();
        randomNumber = rnd.Next();
    }

    public int GetRandomNumber()
    {
        return randomNumber;
    }
}