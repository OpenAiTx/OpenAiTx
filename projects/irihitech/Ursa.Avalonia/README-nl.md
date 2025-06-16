# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa is een UI-bibliotheek op ondernemingsniveau voor het bouwen van cross-platform applicaties met Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Dit project wordt ondersteund door de [.NET Foundation](https://dotnetfoundation.org).

## Aan de slag

1. Ursa

Voeg het NuGet-pakket toe:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Om Ursa-componenten zichtbaar te maken in je applicatie, moet je verwijzen naar een themapakket dat voor Ursa is ontworpen.
Ursa.Themes.Semi is een themapakket voor Ursa geïnspireerd op Semi Design. Je kunt het aan je project toevoegen door de volgende stappen te volgen.

Voeg de NuGet-pakketten toe:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Voeg stijlen toe aan de applicatie:
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

Je kunt nu Ursa-componenten gebruiken in je Avalonia-toepassing.
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

## Gedragscode

Dit project heeft de gedragscode aangenomen zoals gedefinieerd door de Contributor Covenant om het verwachte gedrag in onze gemeenschap te verduidelijken.
Voor meer informatie zie de [.NET Foundation Gedragscode](https://dotnetfoundation.org/code-of-conduct).

## Compatibiliteitsmelding
Ursa is momenteel compatibel met zowel Avalonia 11.1.x als 11.2.x, maar ondersteunt specifiek Avalonia 11.2.0 niet.

## Extensies

### Prism-extensie
Als je Ursa wilt integreren met Prism.Avalonia, kun je het Irihi.Ursa.PrismExtension-pakket gebruiken. Dit pakket biedt dialooggerelateerde services om Ursa Dialogs met Prism te gebruiken.

### ReactiveUI-extensie
Als je Ursa wilt integreren met Avalonia.ReactiveUI, kun je het Irihi.Ursa.ReactiveUIExtension-pakket gebruiken. Dit pakket implementeert de ReactiveUI-versies van UrsaWindow en UrsaView. Zie de [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) voor meer details.

## Ondersteuning

We bieden beperkte gratis community-ondersteuning voor Semi Avalonia en Ursa. Sluit je aan bij onze groep via FeiShu (Lark).

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---