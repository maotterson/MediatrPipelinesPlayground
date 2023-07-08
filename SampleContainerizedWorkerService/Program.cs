using SampleContainerizedWorkerService;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        var appUrl = Environment.GetEnvironmentVariable("appUrl");
        services.AddHostedService<Worker>();
    })
    .Build();

host.Run();
