using System;
using System.Linq;

namespace TemperatureConverter
{
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Welcome in Temperature Converter!\n" +
                              "C = Celsius\n" +
                              "K = Kelvin\n" +
                              "F = Fahrenheit");
            string startTemperatureLetter;
            string destinationTemperatureLetter;
            string[] supportedTemperatures = new string[]{"C", "K", "F"};
            float endTemperature;
            float temperature;

            do {
                Console.WriteLine("Please, choose from letters above. You would like to change temperature from: ");
                startTemperatureLetter = Console.ReadLine();
            } while (!supportedTemperatures.Contains(startTemperatureLetter));

            Temperature startTemperature = TemperatureConverter.FromString(startTemperatureLetter);

            do {
                Console.WriteLine("to: ");
                destinationTemperatureLetter = Console.ReadLine();
            } while (!supportedTemperatures.Contains(destinationTemperatureLetter));

            Temperature destinationTemperature = TemperatureConverter.FromString(destinationTemperatureLetter);


            do {
                Console.WriteLine("Please, write a value of temperature: ");
                if (float.TryParse(Console.ReadLine(), out temperature)) {
                    break;
                };
            } while (true);

            endTemperature = TemperatureConverter.Convert(startTemperature, destinationTemperature, temperature);
            Console.WriteLine(endTemperature);

        }
    }
}
