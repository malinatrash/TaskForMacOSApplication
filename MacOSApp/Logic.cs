namespace MacOSApp
{
    public class Logic
    {
        public static string Calculate(string number)
        {
            int newNumber = int.Parse(number);
            int numberSquared = 0;
            for (int iteration = 1; iteration <= newNumber; iteration += 1)
            {
                numberSquared += (2 * iteration - 1);
            }

            return ($"{ numberSquared }");
        }
    }
}