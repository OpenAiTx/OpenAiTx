# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa 是一个企业级 UI 库，用于基于 Avalonia UI 构建跨平台应用程序。

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET 基金会

该项目由[.NET 基金会](https://dotnetfoundation.org)支持。

## 快速开始

1. Ursa

添加 Nuget 包：
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

为了在您的应用程序中显示 Ursa 控件，您需要引用为 Ursa 设计的主题包。
Ursa.Themes.Semi 是一个受 Semi Design 启发为 Ursa 设计的主题包。您可以按照以下步骤将其添加到项目中。

添加 Nuget 包：
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

在应用程序中引入样式：
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

现在，您可以在 Avalonia 应用程序中使用 Ursa 控件了。
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


## 行为准则

本项目采用了由 Contributor Covenant 制定的行为准则，以明确我们社区期望的行为。
更多信息请参见[.NET 基金会行为准则](https://dotnetfoundation.org/code-of-conduct)。

## 兼容性须知
Ursa 目前兼容 Avalonia 11.1.x 和 11.2.x，但不支持 Avalonia 11.2.0。

## 扩展

### Prism 扩展
如果需要将 Ursa 与 Prism.Avalonia 集成，可以使用 Irihi.Ursa.PrismExtension 包。该包提供与对话框相关的服务，以便以 Prism 风格使用 Ursa 对话框。

### ReactiveUI 扩展
如果需要将 Ursa 与 Avalonia.ReactiveUI 集成，可以使用 Irihi.Ursa.ReactiveUIExtension 包。该包实现了 UrsaWindow 和 UrsaView 的 ReactiveUI 版本。详情请参考[wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)。

## 支持

我们为 Semi Avalonia 和 Ursa 提供有限的免费社区支持。欢迎通过飞书（Lark）加入我们的交流群。

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---