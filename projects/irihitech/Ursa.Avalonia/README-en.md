# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa is an enterprise-level UI library for building cross-platform applications with Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

This project is supported by the [.NET Foundation](https://dotnetfoundation.org).

## Get Started

1. Ursa

Add the NuGet package:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

To make Ursa controls appear in your application, you need to reference a theme package designed for Ursa.
Ursa.Themes.Semi is a theme package for Ursa inspired by Semi Design. You can add it to your project by following these steps.

Add the NuGet packages:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Include Styles in your application:
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

You can now use Ursa controls in your Avalonia Application.
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

## Code of Conduct

This project has adopted the code of conduct defined by the Contributor Covenant to clarify expected behavior in our community.
For more information see the [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Compatibility Notice

Ursa currently is compatible with both Avalonia 11.1.x and 11.2.x, but specifically does not support Avalonia 11.2.0.

## Extensions

### Prism Extension

If you need to integrate Ursa with Prism.Avalonia, you can use the Irihi.Ursa.PrismExtension package. This package provides dialog-related services to utilize Ursa Dialogs with Prism flavor. 

### ReactiveUI Extension

If you need to integrate Ursa with Avalonia.ReactiveUI, you can use the Irihi.Ursa.ReactiveUIExtension package. This package implements the ReactiveUI versions of UrsaWindow and UrsaView. Please refer to the [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) for details. 

## Support

We offer limited free community support for Semi Avalonia and Ursa. Please join our group via FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---