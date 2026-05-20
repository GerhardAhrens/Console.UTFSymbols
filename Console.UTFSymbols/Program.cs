//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Lifeprojects.de">
//     Class: Program
//     Copyright © Lifeprojects.de 2026
// </copyright>
// <Template>
// 	Version 3.0.2026.2, 15.04.2026
// </Template>
//
// <author>Gerhard Ahrens - Lifeprojects.de</author>
// <email>developer@lifeprojects.de</email>
// <date>19.05.2026 10:12:14</date>
// 
// <summary>
// Konsolen Applikation mit Menü
// </summary>
//-----------------------------------------------------------------------

namespace Console.UTFSymbols
{
    /* Imports from NET Framework */
    using System;
    using System.Text;

    public class Program
    {
        public Program()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.CursorVisible = false;
        }
        
        private static void Main(string[] args)
        {
            CMenu mainMenu = new CMenu("Hauptmenü");
            mainMenu.AddItem("UTF Symbole darstellen", MenuPoint1);
            mainMenu.AddItem("UTF Symbol Viewer", MenuPoint2);
            mainMenu.AddItem("Beenden", () => ApplicationExit());
            mainMenu.Show();
        }

        private static void ApplicationExit()
        {
            Environment.Exit(0);
        }

        private static void MenuPoint1()
        {
            Console.Clear();

            Console.WriteLine($"{UTFSymbols.Get("check")}\tPrüfen");
            Console.WriteLine($"{UTFSymbols.Check.Item3}\tPrüfen");
            Console.WriteLine($"{UTFSymbols.Cross.Item3}\tKreuz");
            Console.WriteLine($"{UTFSymbols.Warning.Item3}\tWarnung");
            Console.WriteLine($"{UTFSymbols.Info.Item3}\tInformation");
            Console.WriteLine($"{UTFSymbols.Error.Item3}\tFehler");
            Console.WriteLine($"{UTFSymbols.Record.Item3}\tAufnehmen");

            Console.Wait();
        }

        private static void MenuPoint2()
        {
            Console.Title = "UTF Symbol Viewer";

            var symbols = UTFSymbols.GetAll;

            while (true)
            {
                Console.Clear();

                DrawHeader();

                Console.Write("Suche (leer = alle, ESC = Ende): ");
                string search = ReadInputWithEscape(out bool escape);

                if (escape)
                {
                    break;
                }

                Console.Clear();
                DrawHeader();

                var filtered = symbols
                    .Where(x =>
                        string.IsNullOrWhiteSpace(search) || x.Key.Contains(search, StringComparison.OrdinalIgnoreCase) || x.Key.Contains(search, StringComparison.OrdinalIgnoreCase))
                    .ToDictionary();

                PrintTable(filtered);

                Console.WriteLine();
                Console.WriteLine("ENTER = Neue Suche | ESC = Beenden");

                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                    break;
            }
        }

        private static void DrawHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.WriteLine("                UTF SYMBOL VIEWER");
            Console.WriteLine("══════════════════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine();
        }

        private static void PrintTable(Dictionary<string,(string,string,string)> symbols)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"{Pad("Name", 20)}{Pad("Unicode", 15)}" + $"" +  $"{Pad("C# Code", 20)}" + $"Symbol");

            Console.WriteLine(new string('-', 65));

            Console.ResetColor();

            foreach (var s in symbols)
            {
                Console.WriteLine(
                    $"{Pad(s.Key, 20)}" +
                    $"{Pad(s.Value.Item1, 15)}" +
                    $"{Pad(s.Value.Item2, 20)}" +
                    $"{s.Value.Item3}");
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Gefundene Symbole: {symbols.Count}");
            Console.ResetColor();
        }
        private static string Pad(string text, int length)
        {
            if (text.Length >= length)
            {
                return text.Substring(0, length - 1) + " ";
            }

            return text.PadRight(length);
        }

        private static string ReadInputWithEscape(out bool escape)
        {
            escape = false;

            var input = new StringBuilder();

            while (true)
            {
                var key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                {
                    escape = true;
                    return null;
                }

                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    return input.ToString();
                }

                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Length--;

                    Console.Write("\b \b");
                    continue;
                }

                input.Append(key.KeyChar);
                Console.Write(key.KeyChar);
            }
        }
    }

    public class UtfSymbol
    {
        public string Name { get; set; } = "";
        public string Unicode { get; set; } = "";
        public string CSharpCode { get; set; } = "";
        public string Symbol { get; set; } = "";
    }
}
