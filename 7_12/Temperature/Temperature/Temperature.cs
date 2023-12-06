namespace Temperature
{
    public class Temperature
    {
        public static float CelsiusToFahrenheit(float tempCelsius)
        {
            return (tempCelsius * 9 / 5) + 32;
        }

        public static float FahrenheitToCelsius(float tempFahrenheit)
        {
            return (tempFahrenheit - 32) * 5 / 9;
        }

        public static float CelsiusToKelvin(float tempCelsius)
        {
            return tempCelsius + 273.15f;
        }

        public static float KelvinToCelsius(float tempKelvin)
        {
            return tempKelvin - 273.15f;
        }

        public static float KelvinToFahrenheit(float tempKelvin)
        {
            return ((tempKelvin - 273.15f) * 9 / 5) + 32;
        }

        public static float FahrenheitToKelvin(float tempFahrenheit)
        {
            return ((tempFahrenheit - 32) * 5 / 9) + 273.15f;
        }
    }
}