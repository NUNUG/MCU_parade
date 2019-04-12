using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > Blinky Properties > .NET Micro Framework" and 
 * then change the Transport type to USB.  Finally, close the Blinky properties tab to save these settings. */

namespace Button
{
    public class Program
    {
        public static void Main()
        {
            // write your code here
            OutputPort led = new OutputPort(Pins.GPIO_PIN_D3, false);
            var button = new InputPort(Pins.GPIO_PIN_D0, true, Port.ResistorMode.PullDown);

            while (true)
            {
                var buttonPressed = button.Read();

                led.Write(buttonPressed);
            }

        }

    }
}
