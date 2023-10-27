using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalShop.Pages;

namespace TechnicalShop.Components
{
    public class Navigation
    {
        public static MainWindow mainWindow = new MainWindow();

        public void NextPage(string NamePage)
        {
            if(NamePage == "Авторизация" || NamePage == "Редактирование")
            {
                App.isAdmin = false;
                App.isUser = false;
                mainWindow.ExitBtn.Visibility = System.Windows.Visibility.Collapsed;
                mainWindow.AuthBtn.Visibility = System.Windows.Visibility.Collapsed;
                if (NamePage == "Редактирование")
                    mainWindow.MainFrame.Navigate(new AddEditPage());
                else
                    mainWindow.MainFrame.Navigate(new AuthorizatePage());
            }
            else if(NamePage == "Список")
            {
                mainWindow.ExitBtn.Visibility = System.Windows.Visibility.Collapsed;
                mainWindow.AuthBtn.Visibility = System.Windows.Visibility.Collapsed;
            }

        }
    }
   
}
