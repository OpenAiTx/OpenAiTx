# Avalonia プログレスリング

[![NuGet](https://img.shields.io/nuget/v/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/vpre/Deadpikle.AvaloniaProgressRing.svg?style=flat-square&label=nuget-pre)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/dt/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/github/issues/Deadpikle/AvaloniaProgressRing.svg?style=flat-square)](https://github.com/Deadpikle/AvaloniaProgressRing/issues/)


このプロジェクトは、[ModernWpf](https://github.com/Kinnara/ModernWpf) のプログレスリングをモデルにした Avalonia 用のシンプルなプログレスリングです。初期のコードとデザインは ModernWpf に感謝します！v0.8.x は Avalonia 0.9.x で動作し、v0.9.x は Avalonia 0.10.x と互換性があります。v0.10.x は Avalonia 11 Preview 2+（0.10.7+ は Avalonia 11.1+ 上でビルド）と互換性があります。v0.11.x は Avalonia 12 Preview 1 と互換性があります。

![プログレスリング GIF](https://raw.githubusercontent.com/Deadpikle/AvaloniaProgressRing/develop/img/avalonia-60-fps.gif)

## プロジェクトでの使用方法

NuGet 参照に `Deadpikle.AvaloniaProgressRing` を追加し、次に `App.xaml` の `Application.Styles` に以下を追加してください：

```xml
<StyleInclude Source="avares://AvaloniaProgressRing/Styles/ProgressRing.xaml"/>
```
あなたの`UserControl`に、次の内容を追加してください:


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

`IsActive` にバインドしてプログレスリングの表示/非表示を制御してください！

## 貢献

すべての貢献や改善を歓迎します！ご参加ありがとうございます！

## ライセンス

MIT。ありがとうございます！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-31

---