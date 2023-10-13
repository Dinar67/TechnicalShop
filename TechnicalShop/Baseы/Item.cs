using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TechnicalShop.Baseы
{
    public partial class Product
    {
        public string CostDiscount
        {
            get
            {
                if (Discount == 0)
                    return Cost.ToString("N0") + " ₽";
                else
                    return (Cost - (Cost * (decimal)Discount / 100)).ToString("N0") + " ₽  ";
            }
        }
        public Visibility CostVisibility
        {
            get
            {
                if (Discount == 0)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }

        public double OverideFeedback
        {
            get
            { 
                double sum = 0;

                foreach(var item in Feedback)
                {
                    sum += item.Evaluation;

                }
                return sum / Feedback.Count;

            }
        }

    }
}
