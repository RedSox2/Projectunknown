 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Project_Unknown
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


    private bool carLeft = true;


    private async void Button_Click(object sender, RoutedEventArgs e)
    {
      if (carLeft)
      { 
        for (int i = 30; i <= 670; i++)
        {
          Thickness carThickness = Car.Margin;
          carThickness.Left = i;
          Car.Margin = carThickness;
          await Task.Delay(2);
        }

        CarButton.Content = "Make the Car Reverse";
        carLeft = !carLeft;
      }
      else
      {
        for (int i = 670; i >= 30; i--)
        {
          Thickness carThickness = Car.Margin;
          carThickness.Left = i;
          Car.Margin = carThickness;
          await Task.Delay(2);
        }

        CarButton.Content = "Make the Car Go";
        carLeft = !carLeft;
      }


    }
  }

 
}
