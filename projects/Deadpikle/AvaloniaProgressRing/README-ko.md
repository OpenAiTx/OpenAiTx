# Avalonia Progress Ring

[![NuGet](https://img.shields.io/nuget/v/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/vpre/Deadpikle.AvaloniaProgressRing.svg?style=flat-square&label=nuget-pre)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/dt/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/github/issues/Deadpikle/AvaloniaProgressRing.svg?style=flat-square)](https://github.com/Deadpikle/AvaloniaProgressRing/issues/)


이 프로젝트는 [ModernWpf](https://github.com/Kinnara/ModernWpf)의 프로그레스 링을 모델로 한 Avalonia용 간단한 프로그레스 링입니다. 초기 코드와 디자인은 ModernWpf에 크레딧을 드립니다! v0.8.x는 Avalonia 0.9.x에서 작동하며, v0.9.x는 Avalonia 0.10.x와 호환됩니다. v0.10.x는 Avalonia 11 Preview 2+ (0.10.7+는 Avalonia 11.1+ 빌드)와 호환됩니다. v0.11.x는 Avalonia 12 Preview 1과 호환됩니다.

![Progress Ring GIF](https://raw.githubusercontent.com/Deadpikle/AvaloniaProgressRing/develop/img/avalonia-60-fps.gif)

## 프로젝트에서 사용하기

`Deadpikle.AvaloniaProgressRing`을 NuGet 참조에 추가한 후, `App.xaml`의 `Application.Styles`에 다음을 추가하세요:

```xml
<StyleInclude Source="avares://AvaloniaProgressRing/Styles/ProgressRing.xaml"/>
```
당신의 `UserControl`에 다음을 추가하십시오:


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
`IsActive`에 바인딩하여 진행 링을 표시/숨기도록 하세요!

## 기여하기

모든 기여와 개선 사항을 환영합니다! 참여해 주셔서 감사합니다!

## 라이선스

MIT. 감사합니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-31

---