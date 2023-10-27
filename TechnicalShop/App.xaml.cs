using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TechnicalShop.Baseы;

namespace TechnicalShop
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static HardwareSho1Entities db = new HardwareSho1Entities();
        public static bool isAdmin = false;
        public static bool isUser = false;
    }
}
