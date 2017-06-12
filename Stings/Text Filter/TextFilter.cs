using System;

namespace Text_Filter
{
    class TextFilter
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var text = Console.ReadLine();

            foreach (var banWord in bannedWords)
            {
                text = text.Replace(banWord, new string('*', banWord.Length));
            }

            Console.WriteLine(text);
        }
    }
}
