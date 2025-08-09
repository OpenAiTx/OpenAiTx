# ZXing.Net 

[![N|NuGet](https://img.shields.io/nuget/v/ZXing.Net.svg)](https://www.nuget.org/packages/ZXing.Net/)
[![Build status](https://ci.appveyor.com/api/projects/status/49uvsxpw3ak9jtmm?svg=true)](https://ci.appveyor.com/project/MichaelJahn/zxing-net)
[![Donate](https://img.shields.io/badge/%F0%9F%92%99-Donate%20%2F%20Support%20Us-blue.svg)](#donate)

![ZXing.Net.Mobile Logo](https://raw.githubusercontent.com/micjahn/ZXing.Net/master/Icons/logo.jpg)

## 프로젝트 설명
이미지 내에서 바코드(예: QR 코드, PDF 417, EAN, UPC, Aztec, 데이터 매트릭스, Codabar)를 디코딩하고 생성하는 라이브러리입니다.

이 프로젝트는 자바 기반 바코드 리더 및 생성기 라이브러리 ZXing을 포팅한 것입니다.  
https://github.com/zxing/zxing  
많은 최적화와 개선을 거쳐 수작업으로 포팅되었습니다.

디코더가 지원하는 바코드는 다음과 같습니다:
UPC-A, UPC-E, EAN-8, EAN-13, Code 39, Code 93, Code 128, ITF, Codabar, MSI, RSS-14 (모든 변형), QR 코드, 데이터 매트릭스, Aztec 및 PDF-417.
인코더가 지원하는 포맷은 다음과 같습니다:
UPC-A, EAN-8, EAN-13, Code 39, Code 128, ITF, Codabar, Plessey, MSI, QR 코드, PDF-417, Aztec, 데이터 매트릭스

#### 다음 플랫폼용 어셈블리가 제공됩니다:

* .Net 2.0, 3.5, 4.x, 5.0, 6.0, 7.0
* Windows RT 클래스 라이브러리 및 런타임 컴포넌트 (winmd)
* .NET Standard / .NET Core / UWP
* 포터블 클래스 라이브러리
* Unity3D (.Net 2.0, System.Drawing 참조 없이 빌드됨)
* Xamarin.Android (이전 Mono for Android)
* Windows.Compatibility, CoreCompat.System.Drawing, ImageSharp, SkiaSharp, OpenCVSharp, Magick, Kinect V1 및 V2, EmguCV, Eto.Forms, ZKWeb.System.Drawing 바인딩
* COM 상호 운용 지원, VBA와 함께 사용 가능

#### 다음 플랫폼용 구버전 어셈블리가 0.16 릴리스까지 제공됩니다:
* Windows Phone 7.0, 7.1 및 8.0
* Windows CE
* Silverlight 4 및 5

라이브러리는 [릴리스 섹션](https://github.com/micjahn/ZXing.Net/releases)과 [NuGet 패키지](https://www.nuget.org/packages/ZXing.Net/)로도 제공됩니다.

#### 사전 빌드된 바이너리 없이 추가 플랫폼 지원
라이브러리는 Xamarin.iOS (이전 MonoTouch)용으로 빌드할 수 있습니다. 프로젝트 파일과 솔루션은 소스 코드 저장소에 있습니다.
.Net Micro Framework용 특별 버전은 소스 코드 저장소의 별도 브랜치에서 확인할 수 있습니다.

#### 다음 데모 클라이언트들이 제공됩니다:

* 명령줄용 디코더
* 명령줄용 인코더
* Windows Forms 데모 (정적 이미지와 카메라에서의 디코딩 및 인코딩 시연)
* Windows 서비스 데모 (정적 이미지 디코딩 시연)
* Windows Presentation Framework 데모 (정적 이미지 디코딩 시연)
* Windows RT 데모 (정적 이미지 디코딩 시연)
* HTML5/JS를 사용하는 Windows 스토어 앱 (정적 이미지 디코딩 시연)
* Unity3D 및 Vuforia 데모 (바코드 인코딩과 [Unity3D](http://unity3d.com/) 카메라 이미지 디코딩 시연)
* EmguCV 데모 ([EmguCV 프레임워크](http://www.emgu.com/)를 사용한 카메라 이미지 디코딩 시연)
* OpenCV 데모 ([OpenCVSharp 프레임워크](https://github.com/shimat/opencvsharp/)를 사용한 카메라 이미지 디코딩 시연)
* AForge 데모 ([AForge 프레임워크](http://www.aforgenet.com/)를 사용한 카메라 이미지 디코딩 시연)

## 감사의 말씀
훌륭한 작업을 해주신 [zxing 프로젝트](https://github.com/zxing/zxing) 팀에 깊은 감사를 드립니다. ZXing.Net은 여러분의 작업 없이는 불가능했을 것입니다!
## 사용 예제
소스 코드 저장소에는 Windows Forms, Windows Phone 및 기타 프로젝트 유형용 작은 예제들이 포함되어 있습니다.
구식 예제들은 별도 브랜치에서 다음 플랫폼용으로 제공됩니다:
0.16:
* Silverlight 4 및 5,
* Windows CE 데모 (정적 이미지 디코딩 시연)
* Windows Phone 데모 (정적 이미지 및 카메라 디코딩 시연)

#### 비트맵 내 바코드를 디코딩하는 작은 예제 (.Net 2.0/3.5/4.x)
다음 예제는 버전 4.8.1까지의 클래식 .Net 프레임워크에서 작동합니다:


```csharp
// create a barcode reader instance
IBarcodeReader reader = new BarcodeReader();
// load a bitmap
var barcodeBitmap = (Bitmap)Image.FromFile("C:\\sample-barcode-image.png");
// detect and decode the barcode inside the bitmap
var result = reader.Decode(barcodeBitmap);
// do something with the result
if (result != null)
{
   txtDecoderType.Text = result.BarcodeFormat.ToString();
   txtDecoderContent.Text = result.Text;
}
```
#### .Net Standard 및 .Net 5.0 이상 대상 플랫폼에 대한 중요 공지
위의 샘플 코드를 .Net Standard 또는 .Net 5.0 이상을 대상으로 하는 프로젝트에서 시도하려면 다음 중 하나를 추가해야 합니다
특정 이미지 라이브러리를 위한 추가 NuGet 패키지: https://www.nuget.org/packages?q=ZXing.Bindings
이러한 플랫폼용 ZXing.Net의 주요 패키지는 이미지 형식에 대한 특정 어셈블리에 의존하지 않는 핵심 클래스만 포함합니다.

```csharp
// example shows a simple decoding snippet as a .Net 8.0 console appliation which uses the ZXing.Windows.Compatibility package
using System.Drawing;
using ZXing.Windows.Compatibility;

// create a barcode reader instance
var reader = new BarcodeReader();
// load a bitmap
var barcodeBitmap = (Bitmap)Image.FromFile("C:\\sample-barcode-image.png");
// detect and decode the barcode inside the bitmap
var result = reader.Decode(barcodeBitmap);
// do something with the result
if (result != null)
{
    Console.WriteLine(result.BarcodeFormat.ToString());
    Console.WriteLine(result.Text);
}
else
{
    Console.WriteLine("No barcode found");
}
```
## 도움 요청
모든 도움을 환영합니다!
## 피드백
라이브러리를 사용하고 계신가요?
라이브러리 사용에 대한 간단한 메모를 남겨주시면 감사하겠습니다.

버그를 발견하셨나요?
새로운 이슈를 여기에서 생성하거나 확실하지 않은 경우 토론을 시작해 주세요.

라이브러리를 사용 중인데 만족하지 못하나요?
이메일을 보내주시거나 문제에 대해 토론을 시작해 주세요. 도와드리겠습니다.

그리고 저를 [트위터](http://twitter.com/micjahn)에서 찾으실 수 있습니다.
[![N|http://twitter.com/micjahn](https://img.shields.io/twitter/follow/espadrine.svg?style=social&label=Follow)](http://twitter.com/micjahn)
## 후원하기
프로젝트가 유용하다고 생각되면 향후 개발 지원을 위해 후원해 주세요.

## 기부

[![N|Donate](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG_global.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BYHN42UHPA86E)

기부 외에도 패치, 버그 리포트, 피드백 및 기타 유용한 도움은 언제나 환영합니다!

## 후원자

월간 후원으로 저희 활동을 계속할 수 있도록 도와주세요.  
후원자가 되어 Github README에 귀하의 로고와 사이트 링크를 올릴 수 있습니다.  
* [[Github 후원자가 되기](https://github.com/sponsors/micjahn)]
* [[Opencollective 후원자/서포터 되기](https://opencollective.com/zxingnet)]

## 돈 없이 하는 기부
저의 사회 프로젝트 중 하나를 지원해 주시면 정말, 정말 좋겠습니다. 금전적 지불 없이도 지원할 수 있습니다.  
지원하는 온라인 상점(아마존, 이베이 등)에서 구매하기 전에 아래 URL에 접속하기만 하면 됩니다:  
http://www.bildungsspender.de/kitadorfhain  
선호하는 온라인 상점을 선택하고 평소처럼 쇼핑하세요. 온라인 상점이 귀하의 구매에 대해 유치원에 수수료를 지불합니다. 귀하에게는 추가 비용이 없습니다. 85명의 감사한 아이들이 있습니다.  
(그리고 ZXing.Net의 한 감사한 개발자도 있지요 ;) )


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---