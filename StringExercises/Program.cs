namespace StringExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text1 = "file";
            string text2 = "FILE";

            // Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");

            bool areequal1 = (text1 == text2);
            bool areequal2 = text1.Equals(text2,StringComparison.InvariantCultureIgnoreCase);
            bool areequal3=string.Equals(text1, text2,StringComparison.InvariantCultureIgnoreCase);

            Console.WriteLine(areequal1);
            Console.WriteLine(areequal2);
            Console.WriteLine(areequal3);

            bool contains=text1.Contains("le",StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(contains);

            string str = text1.Substring(1, 2);
            Console.WriteLine(str);
            
            for (int i = 0; i < text1.Length; i++)
            {
                string result = text1.Substring(i, 1);
                Console.WriteLine(result);
            }
            
            Console.WriteLine(text1);
            
        }
    }
}