using LifeCycleExamples;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ITransientService, TransientService>();
builder.Services.AddScoped<IScopedService, ScopedService>();
builder.Services.AddSingleton<ISingletonService, SingletonService>();
var app = builder.Build();

app.MapGet("/", (
    ITransientService firstTransient, ITransientService secondTransient,
    IScopedService firstScoped, IScopedService secondScoped,
    ISingletonService firstSingleton, ISingletonService secondSingleton)
    => new List<Response>()
    {
        new Response()
        {
            RandomNumber = firstTransient.GetRandomNumber(),
            ServiceType = nameof(firstTransient)
        },
        new Response()
        {
            RandomNumber = secondTransient.GetRandomNumber(),
            ServiceType = nameof(secondTransient)
        },
        new Response()
        {
            RandomNumber = firstScoped.GetRandomNumber(),
            ServiceType = nameof(firstScoped)
        },
        new Response()
        {
            RandomNumber = secondScoped.GetRandomNumber(),
            ServiceType = nameof(secondScoped)
        },
        new Response()
        {
            RandomNumber = firstSingleton.GetRandomNumber(),
            ServiceType = nameof(firstSingleton)
        },
        new Response()
        {
            RandomNumber = secondSingleton.GetRandomNumber(),
            ServiceType = nameof(secondSingleton)
        }
    }
);

app.Run();

public class Response
{
    public string ServiceType { get; set; }
    public int RandomNumber { get; set; }
    
}