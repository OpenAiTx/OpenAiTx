# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa یک کتابخانه رابط کاربری در سطح سازمانی برای ساخت برنامه‌های چندسکویی با Avalonia UI است.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## بنیاد .NET

این پروژه توسط [.NET Foundation](https://dotnetfoundation.org) پشتیبانی می‌شود.

## شروع کار

1. Ursa

افزودن بسته nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

برای نمایش کنترل‌های Ursa در برنامه خود، باید یک بسته تم طراحی شده برای Ursa را ارجاع دهید.
Ursa.Themes.Semi یک بسته تم برای Ursa است که از Semi Design الهام گرفته شده است. می‌توانید آن را با مراحل زیر به پروژه خود اضافه کنید.

افزودن بسته nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

شامل کردن سبک‌ها در برنامه:
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


اکنون می‌توانید کنترل‌های Ursa را در برنامه Avalonia خود استفاده کنید.
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



## قوانین رفتار

این پروژه منشور رفتار تعریف‌شده توسط Contributor Covenant را برای شفاف‌سازی رفتار مورد انتظار در جامعه ما پذیرفته است.
برای اطلاعات بیشتر به [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct) مراجعه کنید.

## اطلاعیه سازگاری
Ursa در حال حاضر با هر دو نسخه Avalonia 11.1.x و 11.2.x سازگار است، اما به طور خاص از Avalonia 11.2.0 پشتیبانی نمی‌کند.

## افزونه‌ها

### افزونه Prism
اگر نیاز به یکپارچه‌سازی Ursa با Prism.Avalonia دارید، می‌توانید از بسته Irihi.Ursa.PrismExtension استفاده کنید. این بسته خدمات مربوط به Dialog را برای استفاده از Dialogهای Ursa با سبک Prism فراهم می‌کند.

### افزونه ReactiveUI
اگر نیاز به یکپارچه‌سازی Ursa با Avalonia.ReactiveUI دارید، می‌توانید از بسته Irihi.Ursa.ReactiveUIExtension استفاده کنید. این بسته نسخه‌های ReactiveUI از UrsaWindow و UrsaView را پیاده‌سازی می‌کند. لطفاً برای جزئیات به [ویکی](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) مراجعه کنید.

## پشتیبانی

ما پشتیبانی رایگان و محدودی برای Semi Avalonia و Ursa ارائه می‌دهیم. لطفاً از طریق گروه ما در FeiShu (Lark) بپیوندید.

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---