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

namespace psw_po_lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < Calculator.DishPresets.Count; i++)
            {
                list_dishPresets.Items.Add(Calculator.DishPresets[i].Name);
            }

            for (int i = 0; i < Calculator.DishPresets.Count; i++)
            {
                list_typesPresets.Items.Add(Calculator.TypesPresets[i].Name);
            }
        }

        private void bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            result_TotalVolume.Text = Calculator.TotalVolume(Convert.ToDouble(tb_dishSize.Text), Convert.ToUInt32(tb_quantity.Text)).ToString();
            result_AlcoholVolume.Text = Calculator.AlcoholVolume(Convert.ToDouble(tb_dishSize.Text), Convert.ToDouble(tb_alcoholPercentage.Text), Convert.ToUInt32(tb_quantity.Text)).ToString();
        }

        private void bt_clearAll_Click(object sender, RoutedEventArgs e)
        {
            tb_dishSize.Clear();
            tb_alcoholPercentage.Clear();
            tb_quantity.Clear();

            result_TotalVolume.Text = "";
            result_AlcoholVolume.Text = "";
        }

        private void PreviewValidation(object sender, TextCompositionEventArgs e)
        {
            Validation.DoubleValidation(e);
        }

        private void QuantityValidation(object sender, TextCompositionEventArgs e)
        {
            Validation.UintValidation(e);
        }
    }
}
