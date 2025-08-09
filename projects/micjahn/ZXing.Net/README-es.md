# ZXing.Net 

[![N|NuGet](https://img.shields.io/nuget/v/ZXing.Net.svg)](https://www.nuget.org/packages/ZXing.Net/)
[![Build status](https://ci.appveyor.com/api/projects/status/49uvsxpw3ak9jtmm?svg=true)](https://ci.appveyor.com/project/MichaelJahn/zxing-net)
[![Donate](https://img.shields.io/badge/%F0%9F%92%99-Donate%20%2F%20Support%20Us-blue.svg)](#donate)

![ZXing.Net.Mobile Logo](https://raw.githubusercontent.com/micjahn/ZXing.Net/master/Icons/logo.jpg)

## Descripción del Proyecto
Una biblioteca que soporta la decodificación y generación de códigos de barras (como QR Code, PDF 417, EAN, UPC, Aztec, Data Matrix, Codabar) dentro de imágenes.

El proyecto es un puerto de la biblioteca lectora y generadora de códigos de barras basada en Java ZXing.  
https://github.com/zxing/zxing  
Ha sido portado a mano con muchas optimizaciones y mejoras.

Los siguientes códigos de barras son soportados por el decodificador:
UPC-A, UPC-E, EAN-8, EAN-13, Código 39, Código 93, Código 128, ITF, Codabar, MSI, RSS-14 (todas las variantes), Código QR, Data Matrix, Aztec y PDF-417.  
El codificador soporta los siguientes formatos:  
UPC-A, EAN-8, EAN-13, Código 39, Código 128, ITF, Codabar, Plessey, MSI, Código QR, PDF-417, Aztec, Data Matrix

#### Ensamblados disponibles para las siguientes plataformas:

* .Net 2.0, 3.5, 4.x, 5.0, 6.0, 7.0
* Windows RT Class Library y Componentes de Runtime (winmd)
* .NET Standard / .NET Core / UWP
* Portable Class Library
* Unity3D (.Net 2.0 compilado sin referencia a System.Drawing)
* Xamarin.Android (anteriormente Mono para Android)
* enlaces a Windows.Compatibility, CoreCompat.System.Drawing, ImageSharp, SkiaSharp, OpenCVSharp, Magick, Kinect V1 y V2, EmguCV, Eto.Forms, ZKWeb.System.Drawing
* soporte para interoperabilidad COM, puede usarse con VBA

#### Ensamblados obsoletos disponibles para las siguientes plataformas hasta la versión 0.16:
* Windows Phone 7.0, 7.1 y 8.0
* Windows CE
* Silverlight 4 y 5

La biblioteca está disponible en la [sección de lanzamientos](https://github.com/micjahn/ZXing.Net/releases) y también como [paquete NuGet](https://www.nuget.org/packages/ZXing.Net/).

#### Soporte adicional de plataforma sin binarios precompilados
La biblioteca puede compilarse para Xamarin.iOS (anteriormente MonoTouch). El archivo de proyecto y la solución están disponibles en el repositorio de código fuente.

Una versión especial para el [.Net Micro Framework](http://www.microsoft.com/netmf/) se puede encontrar en una rama separada en el repositorio de código fuente.

#### Los siguientes clientes de demostración están disponibles:

* decodificador para la línea de comandos
* codificador para la línea de comandos
* demostración de Windows Forms (demuestra la decodificación y codificación de imágenes estáticas y desde una cámara)
* demostración de Windows Service (demuestra la decodificación de imágenes estáticas)
* demostración de Windows Presentation Framework (demuestra la decodificación de imágenes estáticas)
* demostración de Windows RT (demuestra la decodificación de imágenes estáticas)
* aplicación Windows Store con HTML5/JS (demuestra la decodificación de imágenes estáticas)
* demostración Unity3D y Vuforia (demuestra la codificación de códigos de barras y la decodificación de imágenes desde una cámara con [Unity3D](http://unity3d.com/))
* demostración EmguCV (demuestra la decodificación de imágenes desde una cámara y utiliza el [framework EmguCV](http://www.emgu.com/))
* demostración OpenCV (demuestra la decodificación de imágenes desde una cámara y utiliza el [framework OpenCVSharp](https://github.com/shimat/opencvsharp/))
* demostración AForge (demuestra la decodificación de imágenes desde una cámara y utiliza el [framework AForge](http://www.aforgenet.com/))

## Agradecimientos
Muchas gracias al equipo del [proyecto zxing](https://github.com/zxing/zxing) por su gran trabajo. ¡ZXing.Net no sería posible sin su trabajo!
## Ejemplos de uso
El repositorio de código fuente incluye pequeños ejemplos para Windows Forms, Windows Phone y otros tipos de proyectos.
Ejemplos obsoletos están disponibles para las siguientes plataformas en ramas separadas:
0.16: 
* Silverlight 4 y 5,
* demostración Windows CE (demuestra la decodificación de imágenes estáticas)
* demostración Windows Phone (demuestra la decodificación de imágenes estáticas y desde una cámara)

#### pequeño ejemplo decodificando un código de barras dentro de un bitmap (.Net 2.0/3.5/4.x)
El siguiente ejemplo funciona con el framework clásico .Net hasta la versión 4.8.1:

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
#### aviso importante para plataformas objetivo .Net Standard y .Net 5.0 y superiores
Si desea probar el código de ejemplo anterior dentro de un proyecto que tenga como objetivo .Net Standard o .Net 5.0 o superior, debe agregar uno de los
paquetes nuget adicionales para una biblioteca de imágenes específica: https://www.nuget.org/packages?q=ZXing.Bindings
El paquete principal de ZXing.Net para dichas plataformas solo contiene las clases centrales que no dependen de un ensamblado específico para formatos de imagen.

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
## Se busca ayuda
¡Toda ayuda es bienvenida!
## Comentarios
¿Usas la biblioteca?
Nos encantaría que nos dejaras una breve nota sobre el uso de la biblioteca.

¿Encontraste un error?
Por favor, crea un nuevo issue aquí o inicia una discusión sobre ello si no estás seguro.

¿Usas la biblioteca y no estás satisfecho con ella?
Escríbenos un correo electrónico o inicia una discusión sobre tus problemas con ella. Intentaremos ayudarte.

Y puedes encontrarme en [Twitter](http://twitter.com/micjahn).
[![N|http://twitter.com/micjahn](https://img.shields.io/twitter/follow/espadrine.svg?style=social&label=Follow)](http://twitter.com/micjahn)
## Apóyalo
Si encuentras útil el proyecto y deseas apoyar su desarrollo futuro, siéntete libre de hacerlo mediante una donación.

## Donar

[![N|Donar](https://www.paypal.com/en_US/i/btn/btn_donateCC_LG_global.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=BYHN42UHPA86E)

Además de una donación, siempre son bienvenidos los parches, reportes de errores, comentarios y otra ayuda útil.

## Patrocinadores

Apóyanos con una donación mensual y ayúdanos a continuar nuestras actividades.  
Conviértete en patrocinador y coloca tu logo en nuestro README en Github con un enlace a tu sitio.  
* [[Conviértete en patrocinador de Github](https://github.com/sponsors/micjahn)]
* [[Conviértete en patrocinador/colaborador de Opencollective](https://opencollective.com/zxingnet)]

## Donación SIN dinero
Sería realmente, realmente genial si pudieras apoyar uno de mis proyectos sociales. Puedes apoyarlo SIN pagar dinero.  
Solo tienes que ir a la siguiente url antes de comprar algo en una tienda online soportada (como Amazon o eBay):  
http://www.bildungsspender.de/kitadorfhain  
Selecciona tu tienda online preferida y compra como siempre. La tienda online pagará una comisión a nuestro jardín de infancia por tu compra. Sin costos extra para ti. Hay 85 niños agradecidos.  
(y un desarrollador agradecido de ZXing.Net ;) )


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---