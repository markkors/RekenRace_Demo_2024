using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using RekenRace_Demo.Models;
namespace RekenRace_Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    public partial class App : Application
    {
        public static oGame Game = new oGame();

        override protected void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            Game.fillSums();
        }
    }
}
