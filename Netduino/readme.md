# Netduino
This MCU is powered by a paired down version of .NET called .NET Micro. It was specifically created to work on micro controllers, but still allow developers to use their favorite .NET languages to program it.

## Models
You can learn more information about the Netduino 2 and 3 here: [http://developer.wildernesslabs.co/Netduino/About/](http://developer.wildernesslabs.co/Netduino/About/)

### Netduino 3

The Netduino 3 offers a stripped down model, built in Ethernet, and built in WiFi so you can pick the model that best matches your needs. Each runs the Cortex-M4 processor at 168MHz, which should be plenty of power for your project. They contain 164KB of RAM, and either 384 or 1408KB of flash. The also support microSD cards, so you can expand your storage as needed.

Pinouts include 14 digital IO (6 PWM), 6 Analog IO, SPI, I2C, UART, and more.

### Netduino 2

The Netduino 2 supports the base model and a 10Mbps Ethernet model. The base model uses the Cortex-M3 processor, while the model with Ethernet sports the same Cortex-M4 as it's younger brother. Pinouts are the same, so you may consider saving some money and using the cheaper model.

## Programming

Netduinos are programmed using .NET Micro ([http://developer.wildernesslabs.co/Netduino/Application_Fundamentals/NETMF/](http://developer.wildernesslabs.co/Netduino/Application_Fundamentals/NETMF/)), which is a paired down version of .NET. This gives an easy familiarity for anyone not sure how to start with MCUs. Developers can use familiar techniques like events and classes, and can use variables and methods just like any modern development environment.