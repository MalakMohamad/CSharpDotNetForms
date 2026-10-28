using Avalonia.Controls;
using Avalonia.Interactivity;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;

namespace Form2Practice5;
/* Student Welcome Form

Create a form with:
- A TextBox for the student's name.
- A TextBox for the university ID.
- A Button labeled Submit.
- A TextBlock to display the result.
Requirements: When clicked, display Welcome, [name]! in the TextBlock. 
If the name is empty, show a MessageBox or dialog asking the user to enter their name.
*/
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    

    private async void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        string stdId = StdId.Text;
        string stdName = StdName.Text;
        if (string.IsNullOrEmpty(stdId) || string.IsNullOrWhiteSpace(stdId))
        {
            ResultTextBlock.Text = "Enter the Student ID";
        }
        
        else if (string.IsNullOrEmpty(stdName) || string.IsNullOrWhiteSpace(stdName))
        {
          
            var msg = MessageBoxManager.GetMessageBoxStandard("Confirmation", "Please enter your name", ButtonEnum.Ok,
                MsBox.Avalonia.Enums.Icon.Warning);
            await msg.ShowAsync();
        }
        else
        {
            ResultTextBlock.Text = "Welcome " + stdName + "!";
        }
        
        
    }

    private async void ClearButton_Click(object? sender, RoutedEventArgs e)
    {
        var msg = MessageBoxManager.GetMessageBoxStandard("Confirmation",
            "Are you sure you want to clear the student information?", ButtonEnum.YesNo,
            MsBox.Avalonia.Enums.Icon.Question, "This will remove all the entered information");
       var removal = await msg.ShowAsync();
       
       if (removal == ButtonResult.Yes)
       {
           StdId.Text = string.Empty;
           StdName.Text = string.Empty;
           ResultTextBlock.Text = string.Empty;
       }


    }
}