namespace MacOSApp
{
    public class Logic
    {
        public static string Calculate(string number)
        {
            var newNumber = 0;
            if (int.Parse(number) / 1 == int.Parse(number))
            {
                newNumber = int.Parse(number);
            }

            int numberSquared = 0;
            for (int iteration = 1; iteration <= newNumber; iteration += 1)
            {
                numberSquared += (2 * iteration - 1);
            }

            return ($"{ numberSquared }");
        }
    }
}