using System;
using System.Windows;
using System.Windows.Controls;


namespace UD02_Ejercicio07
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TamanoRadioBoton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton rd = (sender as RadioButton);
            if ((bool)rd.IsChecked)
                textoTextBlock.FontSize = int.Parse(rd.Tag.ToString());
        }
    }
}
