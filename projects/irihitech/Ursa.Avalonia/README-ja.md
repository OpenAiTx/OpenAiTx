# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursaは、Avalonia UIを使用してクロスプラットフォームアプリケーションを構築するためのエンタープライズレベルのUIライブラリです。

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

このプロジェクトは [.NET Foundation](https://dotnetfoundation.org) によってサポートされています。

## はじめに

1. Ursa

Nugetパッケージを追加します:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Ursaコントロールをアプリケーションで表示するには、Ursa用に設計されたテーマパッケージを参照する必要があります。  
Ursa.Themes.Semiは、Semi DesignにインスパイアされたUrsaのテーマパッケージです。以下の手順でプロジェクトに追加できます。

Nugetパッケージを追加します:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

アプリケーションにStylesを含めます:
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

これでAvaloniaアプリケーションでUrsaコントロールが使用できます。
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

## 行動規範

このプロジェクトは、私たちのコミュニティにおける期待される行動を明確にするために、Contributor Covenantによって定義された行動規範を採用しています。  
詳細については[.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct)をご覧ください。

## 互換性に関する注意
Ursaは現在、Avalonia 11.1.xおよび11.2.xの両方と互換性がありますが、特にAvalonia 11.2.0はサポートしていません。

## 拡張機能

### Prism Extension
UrsaをPrism.Avaloniaと統合する必要がある場合は、Irihi.Ursa.PrismExtensionパッケージを使用できます。このパッケージは、PrismのスタイルでUrsa Dialogsを利用できるダイアログ関連サービスを提供します。

### ReactiveUI Extension
UrsaをAvalonia.ReactiveUIと統合する必要がある場合は、Irihi.Ursa.ReactiveUIExtensionパッケージを使用できます。このパッケージは、UrsaWindowとUrsaViewのReactiveUIバージョンを実装しています。詳細については[wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)を参照してください。

## サポート

Semi AvaloniaおよびUrsaに対して、限定的な無償コミュニティサポートを提供しています。FeiShu(Lark)を通じてグループにご参加ください。

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---