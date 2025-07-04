using BlazorCleanArchitecture.Presentation.Components;
using BlazorCleanArchitecture.Presentation.Configurations;
using BlazorCleanArchitecture.Presentation.Services;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Bind ApiSettings section from appsettings.json
builder.Services.Configure<ApiSettings>(builder.Configuration.GetSection("ApiSettings"));

// Register HttpClient with BaseAddress from ApiSettings using IOptions
builder.Services.AddScoped(sp =>
{
    var options = sp.GetRequiredService<IOptions<ApiSettings>>();
    var apiUrl = options.Value.ApiUrl ?? throw new InvalidOperationException("ApiUrl is missing in configuration.");
    return new HttpClient { BaseAddress = new Uri(apiUrl) };
});

// Register ProductService
builder.Services.AddScoped<ProductService>();

// Add Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
