using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.Threading;

namespace Netduino3
{
	public class Program
	{
		public static void Main()
		{
			using (var led = new OutputPort(Pins.GPIO_PIN_D13, false))
			{
				while (true)
				{
					led.Write(true); // turn on the LED
					Thread.Sleep(250); // sleep for 250ms
					led.Write(false); // turn off the LED
					Thread.Sleep(250); // sleep for 250ms
				}
			}
		}
	}
}
