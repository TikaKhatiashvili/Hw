namespace HwSix
{
    using System;

    namespace SentenceCapitalizer
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                while (true)
                {
                    string input = GetInput();

                    if (input.ToLower() == "exit" || input.ToLower() == "quit")
                    {
                        Console.WriteLine("program ended. bye bye!");
                        break;
                    }

                    string result = CapitalizeSentences(input);
                    ShowResult(result);
                }
            }

            static string GetInput()
            {
                Console.WriteLine("Enter a text (or type 'exit' to stop):");
                return Console.ReadLine();
            }

            static string CapitalizeSentences(string text)
            {
                if (string.IsNullOrWhiteSpace(text))
                    return text;

                string[] sentences = text.Split('.');

                for (int i = 0; i < sentences.Length; i++)
                {
                    string sentence = sentences[i].Trim();

                    if (sentence.Length > 0)
                    {
                        sentences[i] = char.ToUpper(sentence[0]) + sentence.Substring(1);
                    }
                }

                string result = string.Join(". ", sentences).Trim();

                if (text.EndsWith("."))
                {
                    result += ".";
                }

                return result;
            }
            static void ShowResult(string result)
            {
                Console.WriteLine("\nResult:");
                Console.WriteLine(result);
            }
        }
    }
}