# Optimus

Optimus est un navigateur Web sans interface entièrement implémenté en .net.

[Notes de version](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## Téléchargements

 - Les versions publiques sont disponibles sur [NuGet](https://www.nuget.org/packages/Knyaz.Optimus).
 - Les versions instables sont disponibles sur le flux nuget appveyor ici : [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## Exemples
 - Démarrage rapide
 
 Créez une application console et collez le code :
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

 - [Plus de fragments de code](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - le navigateur web basé sur Optimus et Optimus.Graphics.

## Structure des projets

 - Knyaz.Optimus - L'assembly principale avec l'implémentation du navigateur web (sans interface graphique ni rendu).
 - Knyaz.Optimus.Tests - Bibliothèque de tests d'acceptation.
 - Knyaz.Optimus.JsTests - Tests simples en Js.
 - Knyaz.Optimus.UnitTests - Tests unitaires purs.
 - Knyaz.Optimus.WfApp - Application de test simple avec explorateur DOM et fenêtre de journal.
 
## Licence

Optimus est publié sous la [licence MIT](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---