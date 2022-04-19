namespace LifeCycleExamples;

public interface ITransientService
{
    int GetRandomNumber();
}

public class TransientService : ITransientService
{
    int randomNumber;
    public TransientService()
    {
        Random rnd = new Random();
        randomNumber = rnd.Next();
    }

    public int GetRandomNumber()
    {
        return randomNumber;
    }
    
}