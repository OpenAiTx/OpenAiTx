# Avalonia 进度环

[![NuGet](https://img.shields.io/nuget/v/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/vpre/Deadpikle.AvaloniaProgressRing.svg?style=flat-square&label=nuget-pre)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/dt/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/github/issues/Deadpikle/AvaloniaProgressRing.svg?style=flat-square)](https://github.com/Deadpikle/AvaloniaProgressRing/issues/)


该项目是一个简单的 Avalonia 进度环，基于 [ModernWpf](https://github.com/Kinnara/ModernWpf) 的进度环设计。感谢 ModernWpf 提供初始代码和设计！v0.8.x 适用于 Avalonia 0.9.x，v0.9.x 兼容 Avalonia 0.10.x。v0.10.x 兼容 Avalonia 11 预览版 2 及以上（0.10.7+ 版本基于 Avalonia 11.1+ 构建）。v0.11.x 兼容 Avalonia 12 预览版 1。

![进度环 GIF](https://raw.githubusercontent.com/Deadpikle/AvaloniaProgressRing/develop/img/avalonia-60-fps.gif)

## 在项目中使用

将 `Deadpikle.AvaloniaProgressRing` 添加到你的 NuGet 引用中，然后在 `App.xaml` 的 `Application.Styles` 中添加以下内容：

```xml
<StyleInclude Source="avares://AvaloniaProgressRing/Styles/ProgressRing.xaml"/>
```
在您的 `UserControl` 中，添加以下内容：


```xml
<UserControl xmlns="https://github.com/avaloniaui"
             xmlns:progRing="clr-namespace:AvaloniaProgressRing;assembly=AvaloniaProgressRing">
    <progRing:ProgressRing Width="80" 
                           Height="80"
                           IsActive="True"
                           HorizontalAlignment="Left"
                           VerticalAlignment="Top"
                           Foreground="Green"
                           Margin="10,20,0,0"/>
</UserControl>
```
确保绑定到 `IsActive` 以显示/隐藏进度环！

## 贡献

欢迎所有贡献和改进！感谢您的参与！

## 许可证

MIT。谢谢！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-31

---