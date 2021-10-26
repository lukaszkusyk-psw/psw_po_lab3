using System.Text.RegularExpressions;
using System.Windows.Input;

namespace psw_po_lab3
{
    class Validation
    {
        public static void DoubleValidation(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9|.]");
            e.Handled = regex.IsMatch(e.Text);
        }

        public static void UintValidation(TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
