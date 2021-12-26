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

namespace Wpf3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string fontName = ((sender as ComboBox).SelectedItem as TextBlock).Text;

            if (textBox != null)
            {
                textBox.FontFamily = new FontFamily(fontName);
            }

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            string fontSize = ((sender as ComboBox).SelectedItem as TextBlock).Text;
            if (textBox != null)
            {
                textBox.FontSize = double.Parse(fontSize);

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool normalWeight = false;
            normalWeight = !normalWeight;
            if (normalWeight)
            {
                textBox.FontWeight = FontWeights.Bold;
            }
            else
            {
                textBox.FontWeight = FontWeights.Normal;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool normalStyle= false;
            normalStyle = !normalStyle;
            if (normalStyle)
            {
                textBox.FontStyle = FontStyles.Italic;
            }
            else
            {
                textBox.FontStyle = FontStyles.Normal;
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            bool normalDecorat = false;
            normalDecorat = !normalDecorat;
            if (normalDecorat)
            {
                textBox.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                textBox.TextDecorations = null;
            }

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            if (textBox != null)
            {
                textBox.Foreground = new SolidColorBrush(Colors.Red);
            }
        }

        
    }
}

   


