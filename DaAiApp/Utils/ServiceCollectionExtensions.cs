using DaAiApp.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace DaAiApp.Utils;

public static class ServiceCollectionExtensions
{
    public static void AddCommonServices(this IServiceCollection collection)
    {
        collection.AddSingleton<MainWindowViewModel>();
    }
}