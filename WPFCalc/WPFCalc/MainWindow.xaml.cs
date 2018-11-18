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

namespace WPFCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double actualValue = 0;
        string value = "", history = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void One_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "1";
                Value_Info.Content = value;
            }
        }

        private void Two_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length<10)
            {
                value += "2";
                Value_Info.Content = value;
            }

        }

        private void Three_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "3";
                Value_Info.Content = value;
            }

        }

        private void Four_Buttom_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "4";
                Value_Info.Content = value;
            }

        }

        private void Five_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "5";
                Value_Info.Content = value;
            }

        }

        private void Six_button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "6";
                Value_Info.Content = value;
            }

        }

        private void Seven_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "7";
                Value_Info.Content = value;
            }

        }

        private void Eight_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "8";
                Value_Info.Content = value;
            }

        }

        private void Nine_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "9";
                Value_Info.Content = value;
            }

        }

        private void Zero_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += "0";
                Value_Info.Content = value;
            }

        }

        private void Point_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length < 10)
            {
                value += ",";
                Value_Info.Content = value;
            }
        }

        private void Plus_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length>0)
            {
                history += value + " + ";
                History_Info.Content = history;
                actualValue += Convert.ToDouble(value);
                value = "";
                Value_Info.Content = value;
            }

        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length > 0)
            {
                if (history.Length > 0)
                {
                    if (history[history.Length - 2] == '-')
                    {
                        history += value + " - ";
                        History_Info.Content = history;
                        actualValue -= Convert.ToDouble(value);
                        value = "";
                        Value_Info.Content = value;
                    }
                }
                else
                {
                    history += value + " - ";
                    History_Info.Content = history;
                    actualValue += Convert.ToDouble(value);
                    value = "";
                    Value_Info.Content = value;
                }
            }
        }

        private void Multyply_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length > 0)
            {
                if (history.Length > 0)
                {
                    if (history[history.Length - 2] == '*')
                    {
                        history += value + " * ";
                        History_Info.Content = history;
                        actualValue *= Convert.ToDouble(value);
                        value = "";
                        Value_Info.Content = value;
                    }
                }
                else
                {
                    history += value + " * ";
                    History_Info.Content = history;
                    actualValue += Convert.ToDouble(value);
                    value = "";
                    Value_Info.Content = value;
                }
            }
        }

        private void Divide_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length > 0)
            {
                if (history.Length > 0)
                {
                    if (history[history.Length - 2] == '/')
                    {
                        history += value + " / ";
                        History_Info.Content = history;
                        actualValue /= Convert.ToDouble(value);
                        value = "";
                        Value_Info.Content = value;
                    }
                }
                else
                {
                    history += value + " / ";
                    History_Info.Content = history;
                    actualValue += Convert.ToDouble(value);
                    value = "";
                    Value_Info.Content = value;
                }
            }
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            if (value.Length>0)
            {
                value = value.Remove(value.Length - 1);
                Value_Info.Content = value;
            }

        }

        private void C_Button_Click(object sender, RoutedEventArgs e)
        {
            value = "";
            Value_Info.Content = ' ';
        }

        private void CE_Button_Click(object sender, RoutedEventArgs e)
        {
            value = "";
            Value_Info.Content = ' ';
            history = "";
            History_Info.Content = ' ';
            actualValue = 0;
        }

        private void Ravno_Button_Click(object sender, RoutedEventArgs e)
        {
            if (history.Length>0)
            {
                if (history[history.Length - 2] == '+')
                {
                    actualValue += Convert.ToDouble(value);
                    history += value;
                    value = actualValue.ToString();
                    Value_Info.Content = value;
                    History_Info.Content = history;
                    value = "";
                }
                if (history[history.Length - 2] == '-')
                {
                    actualValue -= Convert.ToDouble(value);
                    history += value;
                    value = actualValue.ToString();
                    Value_Info.Content = value;
                    History_Info.Content = history;
                    value = "";
                }
                if (history[history.Length - 2] == '/')
                {
                    actualValue /= Convert.ToDouble(value);
                    history += value;
                    value = actualValue.ToString();
                    Value_Info.Content = value;
                    History_Info.Content = history;
                    value = "";
                }
                if (history[history.Length - 2] == '*')
                {
                    actualValue *= Convert.ToDouble(value);
                    history += value;
                    value = actualValue.ToString();
                    Value_Info.Content = value;
                    History_Info.Content = history;
                    value = "";
                }
            }
            
        }
    }
}
