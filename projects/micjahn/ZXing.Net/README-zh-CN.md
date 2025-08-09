# ZXing.Net 

[![N|NuGet](https://img.shields.io/nuget/v/ZXing.Net.svg)](https://www.nuget.org/packages/ZXing.Net/)
[![Build status](https://ci.appveyor.com/api/projects/status/49uvsxpw3ak9jtmm?svg=true)](https://ci.appveyor.com/project/MichaelJahn/zxing-net)
[![Donate](https://img.shields.io/badge/%F0%9F%92%99-Donate%20%2F%20Support%20Us-blue.svg)](#donate)

![ZXing.Net.Mobile Logo](https://raw.githubusercontent.com/micjahn/ZXing.Net/master/Icons/logo.jpg)

## 项目描述
一个支持在图像中解码和生成条形码（如二维码、PDF 417、EAN、UPC、Aztec、数据矩阵、Codabar）的库。

该项目是基于Java的条形码读取和生成库ZXing的移植。  
https://github.com/zxing/zxing  
它是手工移植的，进行了大量优化和改进。

解码器支持以下条形码：
UPC-A、UPC-E、EAN-8、EAN-13、Code 39、Code 93、Code 128、ITF、Codabar、MSI、RSS-14（所有变体）、二维码、数据矩阵、Aztec和PDF-417。
编码器支持以下格式：
UPC-A、EAN-8、EAN-13、Code 39、Code 128、ITF、Codabar、Plessey、MSI、二维码、PDF-417、Aztec、数据矩阵

#### 以下平台可用程序集：

* .Net 2.0、3.5、4.x、5.0、6.0、7.0
* Windows RT 类库和运行时组件（winmd）
* .NET Standard / .NET Core / UWP
* 便携类库
* Unity3D（基于 .Net 2.0 构建，无 System.Drawing 引用）
* Xamarin.Android（原 Mono for Android）
* Windows.Compatibility、CoreCompat.System.Drawing、ImageSharp、SkiaSharp、OpenCVSharp、Magick、Kinect V1 和 V2、EmguCV、Eto.Forms、ZKWeb.System.Drawing 绑定
* 支持 COM 互操作，可用于 VBA

#### 以下平台的过时程序集可用，直到版本0.16：
* Windows Phone 7.0、7.1 和 8.0
* Windows CE
* Silverlight 4 和 5

该库可在[发布版](https://github.com/micjahn/ZXing.Net/releases)和[NuGet包](https://www.nuget.org/packages/ZXing.Net/)中获取。

#### 无预构建二进制文件的额外平台支持
该库可为 Xamarin.iOS（原 MonoTouch）构建。项目文件和解决方案可在源码仓库中找到。
针对 [.Net 微框架](http://www.microsoft.com/netmf/) 的特殊版本可以在源码仓库的独立分支中找到。

#### 提供以下演示客户端：

* 命令行解码器
* 命令行编码器
* Windows 窗体演示（演示静态图像和摄像头的解码与编码）
* Windows 服务演示（演示静态图像的解码）
* Windows 演示框架演示（演示静态图像的解码）
* Windows RT 演示（演示静态图像的解码）
* Windows 商店应用 HTML5/JS（演示静态图像的解码）
* Unity3D 和 Vuforia 演示（演示条码编码及使用 [Unity3D](http://unity3d.com/) 从摄像头解码图像）
* EmguCV 演示（演示使用 [EmguCV 框架](http://www.emgu.com/) 从摄像头解码图像）
* OpenCV 演示（演示使用 [OpenCVSharp 框架](https://github.com/shimat/opencvsharp/) 从摄像头解码图像）
* AForge 演示（演示使用 [AForge 框架](http://www.aforgenet.com/) 从摄像头解码图像）

## 致谢
非常感谢 [zxing 项目](https://github.com/zxing/zxing) 团队的卓越贡献。没有你们的工作，ZXing.Net 无法实现！
## 使用示例
源码仓库包含了 Windows 窗体、Windows Phone 及其他项目类型的小示例。
以下平台的过时示例可在独立分支中找到：
0.16: 
* Silverlight 4 和 5，
* Windows CE 演示（演示静态图像的解码）
* Windows Phone 演示（演示静态图像及摄像头的解码）

#### 在位图中解码条码的小示例 (.Net 2.0/3.5/4.x)
以下示例适用于经典 .Net 框架至版本 4.8.1：


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
#### 针对 .Net Standard 和 .Net 5.0 及以上目标平台的重要通知
如果您想在目标为 .Net Standard 或 .Net 5.0 及更高版本的项目中尝试上述示例代码，则必须添加以下
特定图像库的额外 NuGet 包之一：https://www.nuget.org/packages?q=ZXing.Bindings
ZXing.Net 在此类平台上的主包仅包含核心类，这些类不依赖于特定的图像格式程序集。

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
## 寻求帮助
欢迎所有帮助！
## 反馈
您在使用本库吗？
如果您能给我们写一段简短的使用心得，我们将非常高兴。

您发现了一个漏洞？
请在这里创建一个新的问题，或者如果不确定，可以开启讨论。

您在使用本库但不满意？
请给我们发邮件，或者开启讨论，告诉我们您的问题。我们会尽力帮助您。

您也可以在[Twitter](http://twitter.com/micjahn)上找到我。
[![N|http://twitter.com/micjahn](https://img.shields.io/twitter/follow/espadrine.svg?style=social&label=Follow)](http://twitter.com/micjahn)
## 支持我们
如果您觉得本项目有用，并希望支持未来的发展，欢迎通过捐赠支持。

## 捐赠

[![N|Donate](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG_global.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BYHN42UHPA86E)

除了捐赠，补丁、漏洞报告、反馈和其他有用的帮助也始终受欢迎！

## 赞助商

通过每月捐赠支持我们，帮助我们继续开展工作。
成为赞助商，您的徽标将显示在我们Github的README中，并附带指向您网站的链接。
* [[成为Github赞助商](https://github.com/sponsors/micjahn)]
* [[成为Opencollective支持者/赞助商](https://opencollective.com/zxingnet)]

## 非金钱捐赠
如果您能支持我的社会项目之一，那将非常非常好。您无需支付金钱即可支持它。
您只需在购买受支持的在线商店（如Amazon或eBay）的商品前访问以下网址：  
http://www.bildungsspender.de/kitadorfhain  
选择您偏好的在线商店，像往常一样购物。该商店将为您的购买向我们的幼儿园支付佣金。您无需额外付费。有85个感激的孩子。
（还有一个感激的ZXing.Net开发者 ;) ）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---