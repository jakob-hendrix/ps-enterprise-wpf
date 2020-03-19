﻿using System.Windows;
using Autofac;
using FriendOrganizer.UI.Data;
using FriendOrganizer.UI.Startup;
using FriendOrganizer.UI.ViewModel;

namespace FriendOrganizer.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            // this will create all required dependencies, assuming they have been 
            // registered in the bootstrapper
            var mainWindow = container.Resolve<MainWindow>();

            mainWindow.Show();
        }
    }
}
