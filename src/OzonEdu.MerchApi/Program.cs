// Содержит классы и интерфейсы для запуска и настройки веб-приложения

using Microsoft.AspNetCore.Hosting;
// Инфраструктура для управления жизненным циклом приложения
using Microsoft.Extensions.Hosting;
using OzonEdu.MerchApi;


CreateHostBuilder(args).Build().Run();

static IHostBuilder CreateHostBuilder(string[] args)
    => Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
        webBuilder => { webBuilder.UseStartup<Startup>(); });