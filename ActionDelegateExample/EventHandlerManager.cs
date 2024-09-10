using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegateExample
{
    public class EventHandlerManager
    {
        public static event Action OnEventRaised;

        // Method to raise the event
        public static void RaiseOnEventRaised()
        {
            Action onEventRaised = OnEventRaised;
            if (onEventRaised != null)
            {
                onEventRaised();
            }

        }
    }
}
