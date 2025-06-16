# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa ist eine Unternehmens-UI-Bibliothek zur Entwicklung plattformübergreifender Anwendungen mit Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Dieses Projekt wird von der [.NET Foundation](https://dotnetfoundation.org) unterstützt.

## Erste Schritte

1. Ursa

Nuget-Paket hinzufügen:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Damit Ursa-Steuerelemente in Ihrer Anwendung angezeigt werden, müssen Sie ein für Ursa entwickeltes Theme-Paket referenzieren.
Ursa.Themes.Semi ist ein Theme-Paket für Ursa, inspiriert von Semi Design. Sie können es Ihrem Projekt wie folgt hinzufügen.

Nuget-Paket hinzufügen:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Styles in der Anwendung einbinden:
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


Sie können jetzt Ursa-Steuerelemente in Ihrer Avalonia-Anwendung verwenden.
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



## Verhaltenskodex

Dieses Projekt hat den von Contributor Covenant definierten Verhaltenskodex übernommen, um das erwartete Verhalten in unserer Community klarzustellen.
Weitere Informationen finden Sie im [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Kompatibilitätshinweis
Ursa ist derzeit mit Avalonia 11.1.x und 11.2.x kompatibel, unterstützt jedoch ausdrücklich nicht Avalonia 11.2.0.

## Erweiterungen

### Prism-Erweiterung
Wenn Sie Ursa mit Prism.Avalonia integrieren möchten, können Sie das Irihi.Ursa.PrismExtension-Paket verwenden. Dieses Paket stellt Dialog-bezogene Dienste zur Verfügung, um Ursa-Dialoge im Prism-Stil zu nutzen.

### ReactiveUI-Erweiterung
Wenn Sie Ursa mit Avalonia.ReactiveUI integrieren möchten, können Sie das Irihi.Ursa.ReactiveUIExtension-Paket verwenden. Dieses Paket implementiert die ReactiveUI-Versionen von UrsaWindow und UrsaView. Details finden Sie im [Wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension).

## Support

Wir bieten eingeschränkten kostenlosen Community-Support für Semi Avalonia und Ursa an. Bitte treten Sie unserer Gruppe über FeiShu (Lark) bei.

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---