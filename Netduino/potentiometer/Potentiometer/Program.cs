using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SLH = SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > Blinky Properties > .NET Micro Framework" and 
 * then change the Transport type to USB.  Finally, close the Blinky properties tab to save these settings. */

namespace Potentiometer
{
    public class Program
    {
        public static void Main()
        {
            const double maxReading = 255d;

            // write your code here
            var pot = new SLH.AnalogInput(Pins.GPIO_PIN_A0);
            pot.SetRange(0, (int)maxReading);

            var led = new PWM(PWMChannels.PWM_PIN_D5, 100, 0, false);
            led.Start();

            while (true)
            {
                var reading = pot.Read();
                led.DutyCycle = reading/maxReading;
                Debug.Print("POT Reading: " + reading);
                Debug.Print("Duty Cycle: " + led.DutyCycle);
            }

        }

    }
}
