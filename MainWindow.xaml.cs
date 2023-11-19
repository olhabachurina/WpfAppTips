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

namespace WpfAppTips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateTip_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double billAmount = Convert.ToDouble(billAmountTextBox.Text);
                string selectedTip = ((ComboBoxItem)tipPercentageComboBox.SelectedItem).Content.ToString();
                double tipPercentage = Convert.ToDouble(selectedTip.Substring(0, selectedTip.Length - 1)) / 100;
                double tipAmount = billAmount * tipPercentage;

                tipResultTextBlock.Text = $"Сумма чаевых: {tipAmount:F2}грн";
            }
            catch (FormatException)
            {
                tipResultTextBlock.Text = "Пожалуйста, введите корректную сумму счета.";
            }
        }
    }
}
    

