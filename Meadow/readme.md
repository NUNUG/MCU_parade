# Meadow

The Meadow is an MCU that runs full .NET Standard libraries. This means that your code can become even more cross platform, since it can span the gammut from x86 Windows to Linux, and Arm to MCU CPUs. Truly, .NET is a versatile language. If you are unsure how to begin with micro electronics, the Meadow is the easiest platform for .NET developers to use.

You can learn more about the Meadow here: https://www.wildernesslabs.co/meadow

## Hardware
The Meadow supports 16 digital IO, 6 analog IO, SPI, I2C, UART, even CAN. It has an integrated LiPo battery charger so you can plugin one unit and charge; as well as built in microSD support.

The Meadow uses the powerful STM32F7 processor which uses WiFi and Bluetooth, runs at 216MHz, has 16MB RAM, and 32MB Flash. It can even handle running 2D graphics right from the chip.

## Programming

One party trick of the Meadow (other than being fully .NET Standard compliant) is that it can be updated over the air. If a new version of your program is needed, you don't have to bring the MCU back in to the shop, simply push out the update wirelessly. Because it has built-in WiFi, it can also connect to cloud services using provided libraries, and become an easy part of the IoT movement.

The Meadow is programmed using .NET Standard, which means it's the programming interface you're used to. Classes, modules, even NuGet are all at your disposal. Even the Netduinos still have some weird syntax for declaring pins and working with them, but the Meadow can import hardware just like modules. To use an LCD screen, for example, simply call `var lcd = new Lcd2004();` and you can control your new LCD screen. `lcd.WriteLine("Hello World");` will write your message to the screen.