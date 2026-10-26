using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Form2Practicing;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void WelcomeButton_Click(object? sender, RoutedEventArgs e)
    {
        ResultBlock.Text = "Welcome to C#"; 
    }

    private void PayButton_Click(object? sender, RoutedEventArgs e)
    {
        if (CreditButton.IsChecked == true)
        {
            ResultBlock.Text = "Please proceed to card payment.....";
        }

        if (CashButton.IsChecked == true)
        {
            ResultBlock.Text = "Please pay at the counter....";
        }

        if (BankButton.IsChecked == true)
        {
            ResultBlock.Text = "Please transfer the amount to the provided account....";
        }
    }

    private void ClearButton_Click(object? sender, RoutedEventArgs e)
    {
        ResultBlock.Text = "";
        BankButton.IsChecked = false;
        CashButton.IsChecked = false;
        CreditButton.IsChecked = false;
        


    }
}