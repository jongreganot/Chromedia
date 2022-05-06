using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Chromedia.Business.BusinessLogic;
using Chromedia.Business.BusinessLogic.Interfaces;
using Chromedia.DataAccess;
using Chromedia.DataAccess.Dtos;
using Chromedia.WPF.ViewModels;
using Microsoft.Extensions.DependencyInjection;

namespace Chromedia.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            var collection = new ServiceCollection();
            collection.AddTransient<IArticleService, ArticleService>();
            collection.AddTransient<IArticleLogic>(provider => new ArticleLogic(provider.GetRequiredService<IArticleService>()));

            ServiceProvider = collection.BuildServiceProvider();

            var mainWindow = new MainWindow();
            mainWindow.DataContext = new MainViewModel(ServiceProvider.GetRequiredService<IArticleLogic>());
            mainWindow.Show();
        }
    }
}
