using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Form2Practicing4;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
   /* Food: Burger (35 SAR), Pizza (29 SAR), Pasta (40 SAR).
    - Drink: Water (1 SAR), Juice (5 SAR), Coffee (8 SAR).
    - Choose one order type: Dine-in or Takeaway.
    - Add a 5 SAR packaging fee for Takeaway.
    - Place Order displays all selected items, order type, and final price.
    - Clear Order resets all controls and output.
    - Display a message if no food is selected.*/
    private void PlaceButton_Click(object? sender, RoutedEventArgs e)
    {
        int total = 0;
        if (BurgerCheckBox.IsChecked == true)
        {
            total += 35;
        }
        if (WaterCheckBox.IsChecked == true)
        {
            total += 1;
        }
        if (PastaCheckBox.IsChecked == true)
        {
            total += 40;
        }
        if (PizzaCheckBox.IsChecked == true)
        {
            total += 29;
        }
        if (CoffeeCheckBox.IsChecked == true)
        {
            total += 8;
        }
        if (JuiceCheckBox.IsChecked == true)
        {
            total += 5;
        }

        if (DineRadioButton.IsChecked == true)
        {
            ResultTextBlock.Text = Convert.ToString("Your total bill: "+ total+ " SAR");
        }
        else if (TakeRadioButton.IsChecked == true)
        {
            ResultTextBlock.Text = Convert.ToString("Your total bill with delivery fee of 5 SAR: "+ (total+5)+ " SAR");
        }
        else
        {
            ResultTextBlock.Text = Convert.ToString("Please select item and order type..");
        }
    }

    private void ClearButton_Click(object? sender, RoutedEventArgs e)
    {
        TakeRadioButton.IsChecked = false;
        DineRadioButton.IsChecked = false;
        JuiceCheckBox.IsChecked = false;
        CoffeeCheckBox.IsChecked = false;
        PizzaCheckBox.IsChecked = false;
        PastaCheckBox.IsChecked = false;
        WaterCheckBox.IsChecked = false;
        BurgerCheckBox.IsChecked = false;
        ResultTextBlock.Text = "Please select item and order type..";




    }
    
}