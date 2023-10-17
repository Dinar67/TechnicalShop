using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TechnicalShop.Baseы;

namespace TechnicalShop.Components
{
    /// <summary>
    /// Логика взаимодействия для ItemUserControl.xaml
    /// </summary>
    public partial class ItemUserControl : UserControl
    {
        public ItemUserControl(Product product)
        {
            InitializeComponent();
            //if(product.MainImagePath == null)

            MainImage.Source = new BitmapImage(new Uri(@"/Resources/NoImage.png", UriKind.Relative));
            TitleTb.Text = product.Title;
            NewPrice.Text = product.CostDiscount;
            OldPrice.Visibility = product.CostVisibility;
            EvalutionTb.Text = product.OverideFeedback;
            OldPrice.Text = product.Cost.ToString("N0");
            BasketBt.Source = new BitmapImage(new Uri(@"/Resources/Basket.png", UriKind.Relative));
            LikeBt.Source = new BitmapImage(new Uri(@"/Resources/Heart.png", UriKind.Relative));
            StatisticBt.Source = new BitmapImage(new Uri(@"/Resources/Statistik.png", UriKind.Relative));

        }
    }
}
