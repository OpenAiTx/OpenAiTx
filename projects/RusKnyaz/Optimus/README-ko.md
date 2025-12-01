# Optimus

Optimus는 .net에서 완전히 구현된 헤드리스 웹 브라우저입니다.

[릴리스 노트](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/CHANGELOG.md)

## 다운로드

 - 공개 릴리스 버전은 [NuGet](https://www.nuget.org/packages/Knyaz.Optimus)에서 사용할 수 있습니다.
 - 불안정 버전은 appveyor nuget 피드에서 사용할 수 있습니다: [https://ci.appveyor.com/nuget/optimus-private](https://ci.appveyor.com/nuget/optimus-private)

## 샘플
 - 빠른 시작
 
 콘솔 애플리케이션을 만들고 코드를 붙여넣으세요:
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

 - [더 많은 코드 스니펫](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/docs/snippets.md)
 - [Prime](https://github.com/RusKnyaz/Prime) - Optimus 및 Optimus.Graphics 기반의 웹 브라우저입니다.

## 프로젝트 구조

 - Knyaz.Optimus - 웹 브라우저 구현의 메인 어셈블리 (GUI 및 렌더링 제외).
 - Knyaz.Optimus.Tests - 수용 테스트 라이브러리.
 - Knyaz.Optimus.JsTests - 간단한 Js 테스트.
 - Knyaz.Optimus.UnitTests - 순수 단위 테스트.
 - Knyaz.Optimus.WfApp - DOM 탐색기 및 로그 창이 포함된 간단한 테스트 애플리케이션.
 
## 라이선스

Optimus는 [MIT 라이선스](https://raw.githubusercontent.com/RusKnyaz/Optimus/develop/LICENSE.txt) 하에 배포됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---