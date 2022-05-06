using DoggyCompanion.Service;
using Microsoft.EntityFrameworkCore;

namespace DoggyCompanion.Ui;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });


        builder.Services.AddMauiBlazorWebView();
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
#endif

        builder.Services.AddDbContext<DoggyCompanionContext>(
            options => options.UseNpgsql(
                @"Host=doggy-companion-do-user-4540780-0.b.db.ondigitalocean.com;Port=25060;Database=defaultdb;Username=doadmin;Password=AVNS_4Mxd8SD6MCBQ3PG")
        );
        return builder.Build();
    }
}