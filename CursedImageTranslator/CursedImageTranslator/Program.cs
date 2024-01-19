using Spectre.Console;
using System.Text;

try
{
	// Using UTF8 allows more capabilities for Spectre.Console.
	Console.OutputEncoding = Encoding.UTF8;
	Console.InputEncoding = Encoding.UTF8;

	// Display the header
	AnsiConsole.Write(new FigletText("Cursed Image Translator").Color(Color.Yellow));
	AnsiConsole.MarkupLine("A dumb little app for understanding images and creating cursed variants.");
	AnsiConsole.WriteLine();


	AnsiConsole.WriteLine("Press any key to exit.");
	Console.ReadKey();

}
catch (Exception ex)
{
	AnsiConsole.WriteException(ex, ExceptionFormats.ShortenEverything);
	AnsiConsole.WriteLine();
	AnsiConsole.WriteLine("Press any key to exit.");
	Console.ReadKey();
}
