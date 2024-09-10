using System.Windows;

namespace ActionDelegateExample
{
    public class ActionMethods
    {
        public static Action NoParameterActionVariable = () => NoParameterAction();
        private static void NoParameterAction()
        {
            MessageBox.Show("Action without parameters executed.");
        }
        // Action that accepts one parameter of type RequestMessage
        public static Action<RequestMessageWithParameter> ActionWithOneParameter = (request) =>
        {
            MessageBox.Show(request.Content);
        };
        // Action that accepts two parameters: RequestMessage and an integer
        public static Action<RequestMessageWithParameter, int> ActionWithTwoParameters = (request, count) =>
        {
            MessageBox.Show($"Action with two parameters executed. Message: {request.Content}, Count: {count}");
        };
    }
}
