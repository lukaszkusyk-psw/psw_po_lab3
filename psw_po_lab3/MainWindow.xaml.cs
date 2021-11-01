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

        private void DishSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_dishPresets.SelectedIndex != -1)
                tb_dishSize.Text = Calculator.DishPresets[list_dishPresets.SelectedIndex].Value.ToString();
        }

        private void AlcoholSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (list_typesPresets.SelectedIndex != -1)
                tb_alcoholPercentage.Text = Calculator.TypesPresets[list_typesPresets.SelectedIndex].Value.ToString();
        }

        private void bt_calculate_Click(object sender, RoutedEventArgs e)
        {
            double dishSize = string.IsNullOrEmpty(tb_dishSize.Text) ? 0 : Convert.ToDouble(tb_dishSize.Text);
            double alcoholPercentage = string.IsNullOrEmpty(tb_alcoholPercentage.Text) ? 0 : Convert.ToDouble(tb_alcoholPercentage.Text);
            uint quantity = string.IsNullOrEmpty(tb_quantity.Text) ? 0 : Convert.ToUInt32(tb_quantity.Text);

            result_TotalVolume.Text = Calculator.TotalVolume(dishSize, quantity) + " L";
            result_AlcoholVolume.Text = Calculator.AlcoholVolume(dishSize, alcoholPercentage, quantity) + " L";
        }

        private void bt_clearAll_Click(object sender, RoutedEventArgs e)
        {
            tb_dishSize.Clear();
            tb_alcoholPercentage.Clear();
            tb_quantity.Clear();

            list_dishPresets.SelectedItem = null;
            list_typesPresets.SelectedItem = null;

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
