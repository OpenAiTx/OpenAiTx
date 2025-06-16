# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa는 Avalonia UI로 크로스 플랫폼 애플리케이션을 구축하기 위한 엔터프라이즈 수준의 UI 라이브러리입니다.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET 재단

이 프로젝트는 [.NET Foundation](https://dotnetfoundation.org)의 지원을 받습니다.

## 시작하기

1. Ursa

Nuget 패키지 추가:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Ursa 컨트롤을 애플리케이션에 표시하려면 Ursa를 위해 설계된 테마 패키지를 참조해야 합니다.
Ursa.Themes.Semi는 Semi Design에서 영감을 받은 Ursa용 테마 패키지입니다. 아래 단계에 따라 프로젝트에 추가할 수 있습니다.

Nuget 패키지 추가:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

애플리케이션에 스타일 포함:
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

이제 Avalonia 애플리케이션에서 Ursa 컨트롤을 사용할 수 있습니다.
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

## 행동 강령(Code of Conduct)

이 프로젝트는 Contributor Covenant에서 정의한 행동 강령을 채택하여 커뮤니티 내에서 기대되는 행동을 명확히 했습니다.
자세한 내용은 [.NET Foundation 행동 강령](https://dotnetfoundation.org/code-of-conduct)을 참고하세요.

## 호환성 안내
Ursa는 현재 Avalonia 11.1.x 및 11.2.x와 호환되지만, Avalonia 11.2.0은 지원하지 않습니다.

## 확장 기능

### Prism 확장
Ursa를 Prism.Avalonia와 통합하려면 Irihi.Ursa.PrismExtension 패키지를 사용할 수 있습니다. 이 패키지는 Prism 스타일의 Ursa Dialog를 사용할 수 있도록 Dialog 관련 서비스를 제공합니다.

### ReactiveUI 확장
Ursa를 Avalonia.ReactiveUI와 통합하려면 Irihi.Ursa.ReactiveUIExtension 패키지를 사용할 수 있습니다. 이 패키지는 UrsaWindow와 UrsaView의 ReactiveUI 버전을 구현합니다. 자세한 내용은 [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension)를 참고하세요.

## 지원

Semi Avalonia 및 Ursa에 대해 제한적인 무료 커뮤니티 지원을 제공합니다. FeiShu(Lark)를 통해 저희 그룹에 참여해 주세요.

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---