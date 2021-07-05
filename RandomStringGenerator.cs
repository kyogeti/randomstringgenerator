using System.Linq;
using System.Text;

namespace Playground.StringPlayground
{
    public static class RandomStringGenerator
    {
        public static string Generate(int charAmount)
        {
            if (charAmount <= 0)
                throw new ArgumentException("charAmount must be higher than zero.");

            int asciiInit = 33;
            int asciiEnd = 126;
            var resultString = new StringBuilder();

            var rnd = new Random();

            while (resultString.Length < charAmount)
            {
                var tba = char.ConvertFromUtf32(rnd.Next(asciiInit, asciiEnd));
                resultString.Append(tba);
            }

            return resultString.ToString();

        }
    }
}
