# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa 是一個企業級 UI 函式庫，可用於基於 Avalonia UI 構建跨平台應用程式。

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET 基金會

本專案由 [.NET 基金會](https://dotnetfoundation.org) 支持。

## 快速開始

1. Ursa

新增 nuget 套件：
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

要使 Ursa 控制元件在您的應用程式中顯示，您需要引用為 Ursa 設計的主題套件。
Ursa.Themes.Semi 是一個受 Semi Design 啟發的 Ursa 主題套件。您可以按照以下步驟將其加入您的專案。

新增 nuget 套件：
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

在應用程式中引入樣式：
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

您現在可以在 Avalonia 應用程式中使用 Ursa 控制元件了。
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

## 行為準則

本專案採用了由 Contributor Covenant 制定的行為準則，以明確我們社群中預期的行為。
如需更多資訊，請參閱 [.NET 基金會行為準則](https://dotnetfoundation.org/code-of-conduct)。

## 相容性通知
Ursa 目前支援 Avalonia 11.1.x 及 11.2.x，但特別不支援 Avalonia 11.2.0。

## 擴充功能

### Prism 擴充
如果您需要將 Ursa 與 Prism.Avalonia 整合，可以使用 Irihi.Ursa.PrismExtension 套件。該套件提供與對話框相關的服務，用於在 Prism 中使用 Ursa 對話框。

### ReactiveUI 擴充
如需將 Ursa 與 Avalonia.ReactiveUI 整合，可以使用 Irihi.Ursa.ReactiveUIExtension 套件。該套件實現了 UrsaWindow 和 UrsaView 的 ReactiveUI 版本。詳細請參考 [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)。

## 支援

我們為 Semi Avalonia 和 Ursa 提供有限的免費社群支援。請通過飛書（Lark）加入我們的社群。

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---