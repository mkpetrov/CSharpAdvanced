using System;

using System.Text.RegularExpressions;



/*

 * Write a program that replaces in a HTML document given as string all the tags 

 * <a href="…">…</a> with corresponding tags [URL href=…]…[/URL]. 

 * Print the result on the console.

 */

class ReplaceATag

{

    static void Main()

    {

        string input = Console.ReadLine();

        string pattern = @"<a\s+href=([^>]+)>([^<]+)</a>";

        Regex regex = new Regex(pattern);

        string replacement = "[URL href=$1]$2[/URL]";

        string result = Regex.Replace(input, pattern, replacement);

        Console.WriteLine(result);

    }

}