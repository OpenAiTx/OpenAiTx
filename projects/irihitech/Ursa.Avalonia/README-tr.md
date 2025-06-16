# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa, Avalonia UI ile çapraz platform uygulamalar oluşturmak için kurumsal düzeyde bir UI kütüphanesidir.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Bu proje [.NET Foundation](https://dotnetfoundation.org) tarafından desteklenmektedir.

## Başlarken

1. Ursa

Nuget paketini ekleyin:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Ursa kontrollerinin uygulamanızda görünmesi için, Ursa için tasarlanmış bir tema paketine referans vermeniz gerekmektedir.
Ursa.Themes.Semi, Semi Design'dan esinlenen bir Ursa tema paketidir. Aşağıdaki adımları izleyerek projenize ekleyebilirsiniz.

Nuget paketini ekleyin:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Stilleri uygulamaya dahil edin:
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

Artık Avalonia Uygulamanızda Ursa kontrollerini kullanabilirsiniz.
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

## Davranış Kuralları

Bu proje, topluluğumuzda beklenen davranışları açıklığa kavuşturmak için Contributor Covenant tarafından tanımlanan davranış kurallarını benimsemiştir.
Daha fazla bilgi için [.NET Foundation Davranış Kuralları](https://dotnetfoundation.org/code-of-conduct) sayfasına bakınız.

## Uyumluluk Bildirimi
Ursa şu anda hem Avalonia 11.1.x hem de 11.2.x ile uyumludur, ancak özellikle Avalonia 11.2.0'ı desteklemez.

## Uzantılar

### Prism Uzantısı
Ursa'yı Prism.Avalonia ile entegre etmeniz gerekiyorsa, Irihi.Ursa.PrismExtension paketini kullanabilirsiniz. Bu paket, Ursa Dialog'larını Prism uyumlu şekilde kullanabilmeniz için Dialog ile ilgili servisleri sağlar.

### ReactiveUI Uzantısı
Ursa'yı Avalonia.ReactiveUI ile entegre etmeniz gerekirse, Irihi.Ursa.ReactiveUIExtension paketini kullanabilirsiniz. Bu paket, UrsaWindow ve UrsaView'ın ReactiveUI sürümlerini uygular. Detay için lütfen [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) sayfasına bakınız.

## Destek

Semi Avalonia ve Ursa için sınırlı, ücretsiz topluluk desteği sunuyoruz. FeiShu (Lark) üzerinden grubumuza katılabilirsiniz.

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---