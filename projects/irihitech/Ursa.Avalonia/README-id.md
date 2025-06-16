# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa adalah pustaka UI tingkat enterprise untuk membangun aplikasi lintas platform dengan Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Proyek ini didukung oleh [.NET Foundation](https://dotnetfoundation.org).

## Memulai

1. Ursa

Tambahkan paket nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Agar kontrol Ursa muncul di aplikasi Anda, Anda perlu mereferensikan paket tema yang dirancang untuk Ursa.
Ursa.Themes.Semi adalah paket tema untuk Ursa yang terinspirasi oleh Semi Design. Anda dapat menambahkannya ke proyek Anda dengan langkah-langkah berikut.

Tambahkan paket nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Sertakan Styles di aplikasi:
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

Sekarang Anda dapat menggunakan kontrol Ursa di Aplikasi Avalonia Anda.
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

## Kode Etik

Proyek ini telah mengadopsi kode etik yang didefinisikan oleh Contributor Covenant untuk memperjelas perilaku yang diharapkan dalam komunitas kami.
Untuk informasi lebih lanjut, lihat [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Pemberitahuan Kompatibilitas
Ursa saat ini kompatibel dengan Avalonia 11.1.x dan 11.2.x, namun secara spesifik tidak mendukung Avalonia 11.2.0.

## Ekstensi

### Ekstensi Prism
Jika Anda perlu mengintegrasikan Ursa dengan Prism.Avalonia, Anda dapat menggunakan paket Irihi.Ursa.PrismExtension. Paket ini menyediakan layanan terkait Dialog untuk memanfaatkan Ursa Dialogs dengan rasa Prism.

### Ekstensi ReactiveUI
Jika perlu mengintegrasikan Ursa dengan Avalonia.ReactiveUI, Anda dapat menggunakan paket Irihi.Ursa.ReactiveUIExtension. Paket ini mengimplementasikan versi ReactiveUI dari UrsaWindow dan UrsaView. Silakan lihat [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) untuk detailnya.

## Dukungan

Kami menawarkan dukungan komunitas gratis terbatas untuk Semi Avalonia dan Ursa. Silakan bergabung dengan grup kami melalui FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---