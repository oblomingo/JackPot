using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightJackPot
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CheckForWinButton_Click(object sender, RoutedEventArgs e)
        {
            JackPotService.JackPotServiceSoapClient client = new SilverlightJackPot.JackPotService.JackPotServiceSoapClient();

            client.IsWinningCodeCompleted += new EventHandler<SilverlightJackPot.JackPotService.IsWinningCodeCompletedEventArgs>(client_IsWinningCodeCompleted);
            client.IsWinningCodeAsync(CodeTextBox.Text);
        }

        private void client_IsWinningCodeCompleted(object sender, JackPotService.IsWinningCodeCompletedEventArgs e)
        {
            bool result = e.Result;
            if (result)
                ResultTextBlock.Text = "You are a winner! Enter your data below and we will contact you!";
            else
                ResultTextBlock.Text = "You lose... Better luck next time!";
            
        }
    }
}
