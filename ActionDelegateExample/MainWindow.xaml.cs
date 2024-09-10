using System.Windows;


namespace ActionDelegateExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
            EventHandlerManager.OnEventRaised += EventHandlerManager_OnEventRaised;
            SwitchCaseUse.UseOfSwithCaseWithTuple("Sanjay","Kumar");
        }

        private void EventHandlerManager_OnEventRaised()
        {
            MessageBox.Show("Event handled by Subscriber");
        }

        private void BtnNoParameter_Click(object sender, RoutedEventArgs e)
        {
            ActionMethods.NoParameterActionVariable();
        }

        private void BtnWithSingleParameter_Click(object sender, RoutedEventArgs e)
        {
            // Create a RequestMessage
            RequestMessageWithParameter message = new RequestMessageWithParameter { Content = "This is a single parameter request." };
            ActionMethods.ActionWithOneParameter(message);
        }

        private void BtnMultipleParameter_Click(object sender, RoutedEventArgs e)
        {
            // Create a RequestMessage
            RequestMessageWithParameter message = new RequestMessageWithParameter { Content = "This is a multiple parameter request." };

            // Invoke the Action with RequestMessage and an integer
            ActionMethods.ActionWithTwoParameters(message, 42);
        }

        private void BtnCallEvenHandlingParameter_Click(object sender, RoutedEventArgs e)
        {
            EventHandlerManager.RaiseOnEventRaised();
            EventHandlerManager.OnEventRaised += EventHandlerManager_OnEventRaised;
        }

        private void BtnCallbackParameter_Click(object sender, RoutedEventArgs e)
        {
            MessageHandler handler = new MessageHandler();

            // Define the callback action that will handle the RequestMessage after processing
            Action<RequestMessageWithParameter> callback = (request) =>
            {
                MessageBox.Show($"Callback executed. Message content: {request.Content}");
            };

            // Call the method with a message and the callback action
            handler.ProcessRequest("Hello, this is a sample request!", callback);
        }
    }
}