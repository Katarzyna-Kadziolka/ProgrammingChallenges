using System;

namespace TemperatureConverter {
    public class TemperatureConverter {
        public static Temperature FromString(string temperature) {
            return temperature switch {
                "C" => Temperature.Celsius,
                "K" => Temperature.Kelvin,
                "F" => Temperature.Fahrenheit,
                _ => throw new InvalidOperationException($"Cannot convert {temperature}")
            };
        }

        public static float Convert(Temperature from, Temperature to, float temperature) {
            switch (to) {
                case Temperature.Celsius:
                    return ToCelsius(from, temperature);
                case Temperature.Kelvin:
                    return ToKelvin(from, temperature);
                case Temperature.Fahrenheit:
                    return ToFahrenheit(from, temperature);
                default:
                    throw new ArgumentOutOfRangeException(nameof(to), to, null);
            }
        }

        private static float ToCelsius(Temperature from, float temperature) {
            switch (from) {
                case Temperature.Celsius:
                    return temperature;
                case Temperature.Kelvin:
                    return temperature - 273.15f;
                case Temperature.Fahrenheit:
                    return(temperature - 32) / 1.8f;
                default:
                    throw new ArgumentOutOfRangeException(nameof(from), from, null);
            }
        }

        private static float ToKelvin(Temperature from, float temperature) {
            switch (from) {
                case Temperature.Celsius:
                    return temperature + 273.15f;
                case Temperature.Kelvin:
                    return temperature;
                case Temperature.Fahrenheit:
                    return(temperature + 459.67f) * (5f / 9f);
                default:
                    throw new ArgumentOutOfRangeException(nameof(from), from, null);
            }
        }

        private static float ToFahrenheit(Temperature from, float temperature) {
            switch (from) {
                case Temperature.Celsius:
                    return 32 + 1.8f * temperature;
                case Temperature.Kelvin:
                    return(temperature * 1.8f) - 459.67f;
                case Temperature.Fahrenheit:
                    return temperature;
                default:
                    throw new ArgumentOutOfRangeException(nameof(@from), @from, null);
            }
        }
    }
}