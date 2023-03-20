namespace CV
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddHttpClient<ICvClient, CvClient>(
                client=>
                {
                    client.BaseAddress = new Uri(Environment.GetEnvironmentVariable("ServerUri") ?? "https://localhost:7289");
                    client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                }
                );

            builder.Services.AddTransient<IJobService, JobService>();

            builder.Services
                .AddBlazorise(options =>
                {
                    options.Immediate = true;
                })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            await builder.Build().RunAsync();
        }
    }
}