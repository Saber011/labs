using Microsoft.Extensions.DependencyInjection;

namespace NoteBookClient;

static class Program
{
    public static IHttpClientFactory HttpClientFactory { get; private set; }
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();
        services.AddHttpClient();
        var serviceProvider = services.BuildServiceProvider();

        HttpClientFactory = serviceProvider.GetRequiredService<IHttpClientFactory>();
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }
}