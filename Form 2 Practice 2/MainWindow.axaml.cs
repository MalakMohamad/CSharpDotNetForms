using System;
using System.Text;
using System.Text.RegularExpressions;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Form2Practicing2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }


    private void TotalButtonClick_OnClick(object? sender, RoutedEventArgs e)
    {
        double discount = 0;
        double price = 0; 
        int sum = 0;
        if (DiscountRadioButton.IsChecked == true)
        {
            if (LaptopCheckBox.IsChecked == true)
            {
                sum = sum + 3000;
            }
            if (KeyboardCheckBox.IsChecked == true)
            {
                sum = sum + 150;

            }
            if (MouseCheckBox.IsChecked == true)
            {
                sum = sum + 80;

            } 
            discount = sum * 0.10;
            price = sum - discount;
            ResultTextBlock.Text = Convert.ToString("Your total with discount of 10% is: " + price + " SAR");

        }
        else if (NoDiscountRadioButton.IsChecked == true)
        {
            if (LaptopCheckBox.IsChecked == true)
            {
                sum = sum + 3000;
            }
            if (KeyboardCheckBox.IsChecked == true)
            {
                sum = sum + 150;

            }
            if (MouseCheckBox.IsChecked == true)
            {
                sum = sum + 80;

            } 
            ResultTextBlock.Text =
                "Your total without discount is: " + sum + " SAR";
        }
        else
        {
            ResultTextBlock.Text = "Please select a discount option.";
        }

     
    }

    private void ClearButtonClick_OnClick(object? sender, RoutedEventArgs e)
    {
        LaptopCheckBox.IsChecked = false;
        KeyboardCheckBox.IsChecked = false;
        MouseCheckBox.IsChecked = false;
        DiscountRadioButton.IsChecked = false;
        NoDiscountRadioButton.IsChecked = false;
        ResultTextBlock.Text = "";
    }
}