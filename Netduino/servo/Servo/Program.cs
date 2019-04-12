using System;
using System.Collections;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SLH = SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

/* NOTE: make sure you change the deployment target from the Emulator to your Netduino before running this
 * Netduino sample app.  To do this, select "Project menu > Blinky Properties > .NET Micro Framework" and 
 * then change the Transport type to USB.  Finally, close the Blinky properties tab to save these settings. */

namespace Servo
{
    public class Program
    {
        public static void Main()
        {
            const int maxValue = 25;

            // write your code here
            var pot = new SLH.AnalogInput(Pins.GPIO_PIN_A0);
            pot.SetRange(0, maxValue);

            var led = new PWM(PWMChannels.PWM_PIN_D5, 100, 0, false);
            led.Start();

            var readings = new RollingAverage(50);

            while (true)
            {
                var reading = pot.Read();
                readings.Add(reading);

                var average = readings.Average();

                led.DutyCycle = average / 100d;
                Debug.Print("POT Reading: " + reading);
                Debug.Print("Duty Cycle: " + led.DutyCycle);

                //for(int i = 0; i < 180; i++)
                //{
                //    led.DutyCycle = (i / 180.0) / 4;
                //    Thread.Sleep(15);
                //}
            }
        }
    }
}
