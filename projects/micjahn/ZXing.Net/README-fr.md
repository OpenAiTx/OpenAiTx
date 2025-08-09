# ZXing.Net 

[![N|NuGet](https://img.shields.io/nuget/v/ZXing.Net.svg)](https://www.nuget.org/packages/ZXing.Net/)
[![Build status](https://ci.appveyor.com/api/projects/status/49uvsxpw3ak9jtmm?svg=true)](https://ci.appveyor.com/project/MichaelJahn/zxing-net)
[![Donate](https://img.shields.io/badge/%F0%9F%92%99-Donate%20%2F%20Support%20Us-blue.svg)](#donate)

![ZXing.Net.Mobile Logo](https://raw.githubusercontent.com/micjahn/ZXing.Net/master/Icons/logo.jpg)

## Description du projet
Une bibliothèque qui prend en charge le décodage et la génération de codes-barres (comme QR Code, PDF 417, EAN, UPC, Aztec, Data Matrix, Codabar) dans les images.

Le projet est un portage de la bibliothèque java de lecture et génération de codes-barres ZXing.  
https://github.com/zxing/zxing  
Il a été porté manuellement avec beaucoup d’optimisations et d’améliorations.

Les codes-barres suivants sont pris en charge par le décodeur :
UPC-A, UPC-E, EAN-8, EAN-13, Code 39, Code 93, Code 128, ITF, Codabar, MSI, RSS-14 (toutes variantes), QR Code, Data Matrix, Aztec et PDF-417.
L’encodeur supporte les formats suivants :
UPC-A, EAN-8, EAN-13, Code 39, Code 128, ITF, Codabar, Plessey, MSI, QR Code, PDF-417, Aztec, Data Matrix

#### Des assemblies sont disponibles pour les plateformes suivantes :

* .Net 2.0, 3.5, 4.x, 5.0, 6.0, 7.0
* Bibliothèque de classes Windows RT et composants d’exécution (winmd)
* .NET Standard / .NET Core / UWP
* Bibliothèque de classes portable
* Unity3D (.Net 2.0 compilé sans référence à System.Drawing)
* Xamarin.Android (anciennement Mono pour Android)
* liaisons vers Windows.Compatibility, CoreCompat.System.Drawing, ImageSharp, SkiaSharp, OpenCVSharp, Magick, Kinect V1 et V2, EmguCV, Eto.Forms, ZKWeb.System.Drawing
* support de l’interop COM, peut être utilisé avec VBA

#### Des assemblies obsolètes sont disponibles pour les plateformes suivantes jusqu’à la version 0.16 :
* Windows Phone 7.0, 7.1 et 8.0
* Windows CE
* Silverlight 4 et 5

La bibliothèque est disponible dans la [section des releases](https://github.com/micjahn/ZXing.Net/releases) ainsi que sous forme de [package NuGet](https://www.nuget.org/packages/ZXing.Net/).

#### Support supplémentaire de plateformes sans binaires précompilés
La bibliothèque peut être compilée pour Xamarin.iOS (anciennement MonoTouch). Le fichier de projet et la solution sont disponibles dans le dépôt du code source.

Une version spéciale pour le [.Net Micro Framework](http://www.microsoft.com/netmf/) se trouve dans une branche séparée du dépôt de code source.

#### Les clients de démonstration suivants sont disponibles :

* décodeur pour la ligne de commande
* encodeur pour la ligne de commande
* démo Windows Forms (démontre le décodage et l’encodage d’images statiques et depuis une caméra)
* démo Windows Service (démontre le décodage d’images statiques)
* démo Windows Presentation Framework (démontre le décodage d’images statiques)
* démo Windows RT (démontre le décodage d’images statiques)
* application Windows Store avec HTML5/JS (démontre le décodage d’images statiques)
* démo Unity3D et Vuforia (démontre l’encodage de codes-barres et le décodage d’images depuis une caméra avec [Unity3D](http://unity3d.com/))
* démo EmguCV (démontre le décodage d’images depuis une caméra et utilise le [framework EmguCV](http://www.emgu.com/))
* démo OpenCV (démontre le décodage d’images depuis une caméra et utilise le [framework OpenCVSharp](https://github.com/shimat/opencvsharp/))
* démo AForge (démontre le décodage d’images depuis une caméra et utilise le [framework AForge](http://www.aforgenet.com/))

## Remerciements
Un grand merci à l’équipe du [projet zxing](https://github.com/zxing/zxing) pour leur excellent travail. ZXing.Net ne serait pas possible sans votre travail !
## Exemples d’utilisation
Le dépôt de code source inclut de petits exemples pour Windows Forms, Windows Phone et d’autres types de projets.
Des exemples obsolètes sont disponibles pour les plateformes suivantes dans des branches séparées :
0.16 : 
* Silverlight 4 et 5,
* démo Windows CE (démontre le décodage d’images statiques)
* démo Windows Phone (démontre le décodage d’images statiques et depuis une caméra)

#### petit exemple de décodage d’un code-barres dans un bitmap (.Net 2.0/3.5/4.x)
L’exemple suivant fonctionne avec le framework .Net classique jusqu’à la version 4.8.1 :

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
#### avis important pour les plateformes cibles .Net Standard et .Net 5.0 et supérieures  
Si vous souhaitez essayer le code exemple ci-dessus dans un projet ciblant .Net Standard ou .Net 5.0 ou supérieur, vous devez ajouter l'un des  
packages nuget supplémentaires pour une bibliothèque d'images spécifique : https://www.nuget.org/packages?q=ZXing.Bindings  
Le package principal de ZXing.Net pour ces plateformes ne contient que les classes principales qui ne dépendent pas d'une assembly spécifique pour les formats d'image.  

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
## Aide recherchée
Toute aide est la bienvenue !
## Retour d'expérience
Vous utilisez la bibliothèque ?
Nous serions heureux si vous nous laissiez une courte note sur l'utilisation de la bibliothèque.

Vous avez trouvé un bug ?
Veuillez créer un nouveau ticket ici ou lancer une discussion à ce sujet si vous n'êtes pas sûr.

Vous utilisez la bibliothèque et vous n'en êtes pas satisfait ?
Écrivez-nous un e-mail s'il vous plaît ou lancez une discussion sur vos problèmes avec elle. Nous essaierons de vous aider.

Et vous pouvez me trouver sur [Twitter](http://twitter.com/micjahn).
[![N|http://twitter.com/micjahn](https://img.shields.io/twitter/follow/espadrine.svg?style=social&label=Follow)](http://twitter.com/micjahn)
## Soutenez-le
Si vous trouvez le projet utile et souhaitez soutenir son développement futur, n'hésitez pas à le faire par un don.

## Faire un don

[![N|Donate](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG_global.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BYHN42UHPA86E)

Outre un don, les correctifs, rapports de bugs, retours et autres aides utiles sont toujours les bienvenus !

## Sponsors

Soutenez-nous par un don mensuel et aidez-nous à continuer nos activités.  
Devenez sponsor et obtenez votre logo dans notre README sur Github avec un lien vers votre site.  
* [[Devenir sponsor Github](https://github.com/sponsors/micjahn)]
* [[Devenir contributeur/sponsor Opencollective](https://opencollective.com/zxingnet)]

## Don SANS argent
Ce serait vraiment, vraiment génial si vous pouviez soutenir un de mes projets sociaux. Vous pouvez le faire SANS payer d'argent.  
Il vous suffit d'aller à l'URL suivante avant d'acheter quoi que ce soit dans une boutique en ligne partenaire (comme Amazon ou eBay) :  
http://www.bildungsspender.de/kitadorfhain  
Sélectionnez votre boutique en ligne préférée et faites vos achats comme d'habitude. La boutique en ligne versera une commission à notre jardin d'enfants pour votre achat. Aucun coût supplémentaire pour vous. Il y a 85 enfants reconnaissants.  
(et un développeur reconnaissant de ZXing.Net ;) )


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---