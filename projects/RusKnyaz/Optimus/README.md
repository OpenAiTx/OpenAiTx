# Optimus

Optimus is headless Web Browser fully implemented on .net.

[Release notes](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## Downloads

 - Public release versions are available on [NuGet](https://www.nuget.org/packages/Knyaz.Optimus).
 - Unstable versions are available on the appveyour nuget feed here: [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## Samples
 - Quick start
 
 Create console application and paste the code:
 ```c#
using System.Linq;
using Knyaz.Optimus;
using Knyaz.Optimus.Dom.Elements;
using Console = System.Console;

namespace ConsoleApplication1
{
	class Program
	{
		static async void Main(string[] args)
		{
			var engine = EngineBuilder.New()
			    .UseJint()// Enable JavaScripts execution.
			    .Build(); // Builds the Optimus engine.
        
			//Request the web page.
			var page = await engine.OpenUrl("http://google.com");
			//Get the document
			var document = page.Document;
			//Get DOM items
			Console.WriteLine("The first document child node is: " + document.FirstChild);
			Console.WriteLine("The first document body child node is: " + document.Body.FirstChild);
			Console.WriteLine("The first element tag name is: " + document.ChildNodes.OfType<HtmlElement>().First().TagName);
			Console.WriteLine("Whole document innerHTML length is: " + document.DocumentElement.InnerHTML.Length);
			Console.ReadKey();
		}
	}
}
```


 - [More code snippets](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - the web browser based on Optimus and Optimus.Graphics.

## Projects structure

 - Knyaz.Optimus - The main assembly with implementation of web browser (without GUI and rendering).
 - Knyaz.Optimus.Tests - Acceptance tests library.
 - Knyaz.Optimus.JsTests - Simple Js tests. 
 - Knyaz.Optimus.UnitTests - Pure unit tests.
 - Knyaz.Optimus.WfApp - Simple test application with DOM explorer and Log window.
 
## License

Optimus is released under the [MIT license](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt).
