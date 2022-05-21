using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Temisto.Broker.Config;
using Temisto.Broker.Extensions;
using Temisto.Importer.Config;
using Temisto.Importer.Provider;
using Temisto.Importer.Services;

void Startup()
{
    var services = ConfigureServices();
    var config = Configuration();

    var documentProviderOptions = LoadDocumentProviderOptions(config);
    var brokerConnectionOptions = LoadBrokerConnectionOptions(config);

    services.AddSingleton(config);

    services.AddSingleton(typeof(IDocumentProviderOptions), documentProviderOptions);
    services.AddSingleton(typeof(IBrokerConnectionOptions), brokerConnectionOptions);

    services.ConfigureBrokerServices();

    Run(services);
}

IConfiguration Configuration()
{
    return new ConfigurationBuilder()
        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
        .AddEnvironmentVariables()
        .Build();
}

IServiceCollection ConfigureServices()
{
    var services = new ServiceCollection();

    services.AddScoped<IDocumentProvider, DocumentProvider>();
    services.AddScoped<IImporterService, ImporterService>();

    return services;
}

IDocumentProviderOptions LoadDocumentProviderOptions(IConfiguration configuration)
{
    var documentProviderOptions = new DocumentProviderOptions();
    configuration.GetSection("DocumentPath").Bind(documentProviderOptions);

    return documentProviderOptions;
}

IBrokerConnectionOptions LoadBrokerConnectionOptions(IConfiguration configuration)
{
    var brokerConnectionOptions = new BrokerConnectionOptions();
    configuration.GetSection("BrokerConnectionOptions").Bind(brokerConnectionOptions);

    return brokerConnectionOptions;
}

void Run(IServiceCollection services)
{
    services.BuildServiceProvider().GetRequiredService<IImporterService>().Run();
}

Startup();