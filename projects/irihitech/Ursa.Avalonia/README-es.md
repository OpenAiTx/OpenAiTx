# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa es una biblioteca de interfaz de usuario de nivel empresarial para construir aplicaciones multiplataforma con Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Este proyecto es apoyado por la [.NET Foundation](https://dotnetfoundation.org).

## Comenzando

1. Ursa

Agregar el paquete nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Para que los controles de Ursa aparezcan en tu aplicación, necesitas hacer referencia a un paquete de tema diseñado para Ursa.
Ursa.Themes.Semi es un paquete de tema para Ursa inspirado en Semi Design. Puedes agregarlo a tu proyecto siguiendo los siguientes pasos.

Agregar el paquete nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Incluir estilos en la aplicación:
```xaml
<Application...
    xmlns:semi="https://irihi.tech/semi"
    xmlns:u-semi="https://irihi.tech/ursa/themes/semi"
    ....>

    <Application.Styles>
        <semi:SemiTheme Locale="zh-CN" />
        <u-semi:SemiTheme Locale="zh-CN"/>
    </Application.Styles>
```


Ahora puedes usar controles de Ursa en tu aplicación Avalonia.
```xaml
<Window
    ...
    xmlns:u="https://irihi.tech/ursa"
    ...>
    <StackPanel Margin="20">
        <u:TagInput />
    </StackPanel>
</Window>
```



## Código de Conducta

Este proyecto ha adoptado el código de conducta definido por el Contributor Covenant para aclarar el comportamiento esperado en nuestra comunidad.
Para más información consulta el [Código de Conducta de la .NET Foundation](https://dotnetfoundation.org/code-of-conduct).

## Aviso de Compatibilidad
Ursa actualmente es compatible con Avalonia 11.1.x y 11.2.x, pero específicamente no soporta Avalonia 11.2.0.

## Extensiones

### Extensión Prism
Si necesitas integrar Ursa con Prism.Avalonia, puedes usar el paquete Irihi.Ursa.PrismExtension. Este paquete provee servicios relacionados con Dialog para utilizar los diálogos de Ursa con el estilo de Prism.

### Extensión ReactiveUI
Si necesitas integrar Ursa con Avalonia.ReactiveUI, puedes usar el paquete Irihi.Ursa.ReactiveUIExtension. Este paquete implementa las versiones ReactiveUI de UrsaWindow y UrsaView. Por favor, consulta la [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) para más detalles.

## Soporte

Ofrecemos soporte comunitario gratuito y limitado para Semi Avalonia y Ursa. Por favor, únete a nuestro grupo vía FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---