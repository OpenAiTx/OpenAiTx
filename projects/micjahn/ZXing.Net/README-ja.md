# ZXing.Net 

[![N|NuGet](https://img.shields.io/nuget/v/ZXing.Net.svg)](https://www.nuget.org/packages/ZXing.Net/)
[![Build status](https://ci.appveyor.com/api/projects/status/49uvsxpw3ak9jtmm?svg=true)](https://ci.appveyor.com/project/MichaelJahn/zxing-net)
[![Donate](https://img.shields.io/badge/%F0%9F%92%99-Donate%20%2F%20Support%20Us-blue.svg)](#donate)

![ZXing.Net.Mobile Logo](https://raw.githubusercontent.com/micjahn/ZXing.Net/master/Icons/logo.jpg)

## プロジェクト概要
画像内のバーコード（QRコード、PDF 417、EAN、UPC、Aztec、Data Matrix、Codabarなど）のデコードおよび生成をサポートするライブラリです。

本プロジェクトは、JavaベースのバーコードリーダーおよびジェネレーターライブラリZXingの移植版です。  
https://github.com/zxing/zxing  
多くの最適化および改善を加えて手作業で移植されました。

デコーダーが対応するバーコードは以下の通りです：  
UPC-A、UPC-E、EAN-8、EAN-13、Code 39、Code 93、Code 128、ITF、Codabar、MSI、RSS-14（全バリエーション）、QRコード、Data Matrix、Aztec、PDF-417。  
エンコーダーが対応するフォーマットは以下の通りです：  
UPC-A、EAN-8、EAN-13、Code 39、Code 128、ITF、Codabar、Plessey、MSI、QRコード、PDF-417、Aztec、Data Matrix

#### 以下のプラットフォーム向けにアセンブリが利用可能です：

* .Net 2.0、3.5、4.x、5.0、6.0、7.0
* Windows RT クラスライブラリおよびランタイムコンポーネント（winmd）
* .NET Standard / .NET Core / UWP
* ポータブルクラスライブラリ
* Unity3D（System.Drawing参照なしでビルドされた.Net 2.0）
* Xamarin.Android（旧Mono for Android）
* Windows.Compatibility、CoreCompat.System.Drawing、ImageSharp、SkiaSharp、OpenCVSharp、Magick、Kinect V1およびV2、EmguCV、Eto.Forms、ZKWeb.System.Drawingへのバインディング
* COM相互運用をサポートし、VBAでの使用が可能

#### 廃止されたアセンブリは以下のプラットフォーム向けにリリース0.16まで提供されていました：
* Windows Phone 7.0、7.1、8.0
* Windows CE
* Silverlight 4および5

ライブラリは[リリースセクション](https://github.com/micjahn/ZXing.Net/releases)および[NuGetパッケージ](https://www.nuget.org/packages/ZXing.Net/)として利用可能です。

#### 事前ビルド済みバイナリなしでの追加プラットフォームサポート
ライブラリはXamarin.iOS（旧MonoTouch）向けにビルド可能です。プロジェクトファイルとソリューションはソースコードリポジトリにあります。
.Net Micro Framework用の特別バージョンは、ソースコードリポジトリの別ブランチにあります。

#### 利用可能なデモクライアントは以下の通りです：

* コマンドライン用デコーダー
* コマンドライン用エンコーダー
* Windows Formsデモ（静止画像およびカメラからのデコードとエンコードを示します）
* Windowsサービスデモ（静止画像のデコードを示します）
* Windows Presentation Frameworkデモ（静止画像のデコードを示します）
* Windows RTデモ（静止画像のデコードを示します）
* HTML5/JSを使用したWindows Storeアプリ（静止画像のデコードを示します）
* Unity3DおよびVuforiaデモ（バーコードのエンコードと[Unity3D](http://unity3d.com/)を使用したカメラからの画像デコードを示します）
* EmguCVデモ（カメラからの画像デコードを示し、[EmguCVフレームワーク](http://www.emgu.com/)を使用します）
* OpenCVデモ（カメラからの画像デコードを示し、[OpenCVSharpフレームワーク](https://github.com/shimat/opencvsharp/)を使用します）
* AForgeデモ（カメラからの画像デコードを示し、[AForgeフレームワーク](http://www.aforgenet.com/)を使用します）

## 感謝
[zxingプロジェクト](https://github.com/zxing/zxing)のチームの素晴らしい仕事に多大な感謝を。ZXing.Netは皆様の貢献なしには実現しませんでした！
## 使用例
ソースコードリポジトリには、Windows Forms、Windows Phoneおよびその他のプロジェクトタイプ向けの小さな例が含まれています。
廃止された例は以下のプラットフォーム向けに別ブランチで提供されています：
0.16: 
* Silverlight 4および5、
* Windows CEデモ（静止画像のデコードを示します）
* Windows Phoneデモ（静止画像およびカメラからのデコードを示します）

#### ビットマップ内のバーコードをデコードする小さな例（.Net 2.0/3.5/4.x）
以下の例はバージョン4.8.1までのクラシックな.Netフレームワークで動作します：


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
#### .Net Standard および .Net 5.0 以上のターゲットプラットフォームに関する重要なお知らせ
上記のサンプルコードを .Net Standard または .Net 5.0 以上をターゲットとするプロジェクト内で試す場合は、
特定の画像ライブラリ用の追加の NuGet パッケージのいずれかを追加する必要があります：https://www.nuget.org/packages?q=ZXing.Bindings
これらのプラットフォーム向けの ZXing.Net のメインパッケージは、
画像フォーマット用の特定のアセンブリに依存しないコアクラスのみを含んでいます。
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
## ヘルプ募集
どんなヘルプでも歓迎します！
## フィードバック
ライブラリを使っていますか？
ライブラリの使用について簡単なコメントをいただけると嬉しいです。

バグを見つけましたか？
新しいイシューをこちらで作成するか、不確かな場合はディスカッションを始めてください。

ライブラリを使っていて満足していませんか？
メールをお送りいただくか、問題についてのディスカッションを始めてください。できるだけお手伝いします。

私のTwitterは[こちら](http://twitter.com/micjahn)で見つけられます。
[![N|http://twitter.com/micjahn](https://img.shields.io/twitter/follow/espadrine.svg?style=social&label=Follow)](http://twitter.com/micjahn)
## 支援してください
プロジェクトが役に立った場合、今後の開発を支援したい場合は寄付で支援してください。

## 寄付

[![N|Donate](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG_global.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BYHN42UHPA86E)

寄付のほかに、パッチ、バグ報告、フィードバック、その他の有用な支援も常に歓迎します！

## スポンサー

月額寄付で支援していただき、私たちの活動を継続する手助けをしてください。  
スポンサーになると、あなたのサイトへのリンク付きでGithubのREADMEにロゴを掲載します。  
* [[Githubスポンサーになる](https://github.com/sponsors/micjahn)]
* [[Opencollective バッカー/スポンサーになる](https://opencollective.com/zxingnet)]

## お金を使わない寄付
私の社会プロジェクトのいずれかを支援していただけると本当に、本当に嬉しいです。お金を払わずに支援できます。  
対応しているオンラインショップ（AmazonやeBayなど）で何かを購入する前に、以下のURLにアクセスするだけです：  
http://www.bildungsspender.de/kitadorfhain  
お好きなオンラインショップを選び、いつも通りに買い物をしてください。オンラインショップがあなたの購入に応じて私たちの幼稚園に手数料を支払います。あなたの追加費用はありません。感謝している子供が85人います。  
（そしてZXing.Netの感謝している開発者が一人います ;) ）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---