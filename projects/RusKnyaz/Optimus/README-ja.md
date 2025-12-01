# Optimus

Optimusは、.net上で完全に実装されたヘッドレスWebブラウザです。

[リリースノート](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## ダウンロード

 - 公開リリースバージョンは[NuGet](https://www.nuget.org/packages/Knyaz.Optimus)で入手可能です。
 - 不安定なバージョンはappveyorのnugetフィードで入手可能です: [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## サンプル
 - クイックスタート
 
 コンソールアプリケーションを作成し、以下のコードを貼り付けてください:
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


 - [さらにコードスニペット](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - Optimus と Optimus.Graphics をベースにしたウェブブラウザ。

## プロジェクト構成

 - Knyaz.Optimus - ウェブブラウザの実装を含むメインアセンブリ（GUI とレンダリングを除く）。
 - Knyaz.Optimus.Tests - 受け入れテストライブラリ。
 - Knyaz.Optimus.JsTests - シンプルな Js テスト。
 - Knyaz.Optimus.UnitTests - 純粋な単体テスト。
 - Knyaz.Optimus.WfApp - DOM エクスプローラーとログウィンドウを備えたシンプルなテストアプリケーション。
 
## ライセンス

Optimus は [MIT ライセンス](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt) の下でリリースされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---