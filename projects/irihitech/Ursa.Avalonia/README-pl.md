# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa to biblioteka interfejsu użytkownika klasy korporacyjnej do tworzenia wieloplatformowych aplikacji z użyciem Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Projekt jest wspierany przez [.NET Foundation](https://dotnetfoundation.org).

## Rozpoczęcie pracy

1. Ursa

Dodaj pakiet nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Aby kontrolki Ursa były widoczne w Twojej aplikacji, musisz dodać pakiet motywu zaprojektowany dla Ursa.
Ursa.Themes.Semi to pakiet motywu dla Ursa inspirowany Semi Design. Możesz dodać go do swojego projektu, wykonując poniższe kroki.

Dodaj pakiet nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Dodaj Style do aplikacji:
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


Teraz możesz używać kontrolek Ursa w swojej aplikacji Avalonia.
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



## Kodeks Postępowania

Projekt przyjął kodeks postępowania zdefiniowany przez Contributor Covenant, aby doprecyzować oczekiwane zachowania w naszej społeczności.
Więcej informacji znajdziesz w [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Informacja o kompatybilności
Ursa jest obecnie kompatybilna zarówno z Avalonia 11.1.x, jak i 11.2.x, ale nie obsługuje Avalonia 11.2.0.

## Rozszerzenia

### Rozszerzenie Prism
Jeśli chcesz zintegrować Ursa z Prism.Avalonia, możesz użyć pakietu Irihi.Ursa.PrismExtension. Pakiet ten zapewnia usługi powiązane z oknami dialogowymi, umożliwiając korzystanie z okien dialogowych Ursa w stylu Prism.

### Rozszerzenie ReactiveUI
Jeśli chcesz zintegrować Ursa z Avalonia.ReactiveUI, możesz użyć pakietu Irihi.Ursa.ReactiveUIExtension. Pakiet ten implementuje wersje ReactiveUI dla UrsaWindow i UrsaView. Szczegóły znajdziesz w [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension).

## Wsparcie

Oferujemy ograniczone, bezpłatne wsparcie społecznościowe dla Semi Avalonia i Ursa. Dołącz do naszej grupy przez FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---