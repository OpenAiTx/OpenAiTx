# Optimus

Optimus 是一个完全基于 .net 实现的无头网页浏览器。

[发行说明](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## 下载

 - 公共发行版本可在 [NuGet](https://www.nuget.org/packages/Knyaz.Optimus) 获取。
 - 不稳定版本可在 appveyour nuget 源获取： [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## 示例
 - 快速开始
 
 创建控制台应用程序并粘贴以下代码：
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


 - [更多代码片段](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - 基于 Optimus 和 Optimus.Graphics 的网页浏览器。

## 项目结构

 - Knyaz.Optimus - 实现网页浏览器的主程序集（不包含 GUI 和渲染）。
 - Knyaz.Optimus.Tests - 验收测试库。
 - Knyaz.Optimus.JsTests - 简单的 Js 测试。
 - Knyaz.Optimus.UnitTests - 纯单元测试。
 - Knyaz.Optimus.WfApp - 带 DOM 探索器和日志窗口的简单测试应用。

## 许可证

Optimus 采用 [MIT 许可证](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt) 发布。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---