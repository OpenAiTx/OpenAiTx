# Optimus

Optimus es un navegador web sin interfaz gráfica completamente implementado en .net.

[Notas de la versión](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## Descargas

 - Las versiones públicas están disponibles en [NuGet](https://www.nuget.org/packages/Knyaz.Optimus).
 - Las versiones inestables están disponibles en el feed de nuget de appveyor aquí: [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## Ejemplos
 - Inicio rápido
 
 Crea una aplicación de consola y pega el código:
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
 
 - [Más fragmentos de código](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - el navegador web basado en Optimus y Optimus.Graphics.

## Estructura de proyectos

 - Knyaz.Optimus - El ensamblado principal con la implementación del navegador web (sin GUI ni renderizado).
 - Knyaz.Optimus.Tests - Biblioteca de pruebas de aceptación.
 - Knyaz.Optimus.JsTests - Pruebas simples de Js.
 - Knyaz.Optimus.UnitTests - Pruebas unitarias puras.
 - Knyaz.Optimus.WfApp - Aplicación de prueba simple con explorador DOM y ventana de registro.
 
## Licencia

Optimus se publica bajo la [licencia MIT](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---