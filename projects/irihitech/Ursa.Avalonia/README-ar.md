# أورسا

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

أورسا هي مكتبة واجهات مستخدم على مستوى المؤسسات لبناء تطبيقات عبر الأنظمة باستخدام Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## مؤسسة .NET

هذا المشروع مدعوم من قبل [مؤسسة .NET](https://dotnetfoundation.org).

## ابدأ الآن

1. أورسا

أضف حزمة Nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

لجعل عناصر تحكم أورسا تظهر في تطبيقك، تحتاج إلى الإشارة إلى حزمة سمات مصممة لأورسا.
Ursa.Themes.Semi هي حزمة سمات لأورسا مستوحاة من Semi Design. يمكنك إضافتها إلى مشروعك باتباع الخطوات التالية.

أضف حزمة Nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

قم بتضمين الأنماط في التطبيق:
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

يمكنك الآن استخدام عناصر تحكم أورسا في تطبيق Avalonia الخاص بك.
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

## مدونة السلوك

هذا المشروع اعتمد مدونة السلوك المعرفة من قبل اتفاقية المساهمين لتوضيح السلوك المتوقع في مجتمعنا.
لمزيد من المعلومات راجع [مدونة السلوك لمؤسسة .NET](https://dotnetfoundation.org/code-of-conduct).

## إشعار التوافق
أورسا متوافق حالياً مع كل من Avalonia 11.1.x و 11.2.x، لكنه لا يدعم تحديداً Avalonia 11.2.0.

## الإضافات

### إضافة Prism
إذا كنت بحاجة لدمج أورسا مع Prism.Avalonia، يمكنك استخدام حزمة Irihi.Ursa.PrismExtension. توفر هذه الحزمة خدمات متعلقة بالحوار لاستخدام حوارات أورسا مع نكهة Prism.

### إضافة ReactiveUI
إذا كنت بحاجة لدمج أورسا مع Avalonia.ReactiveUI، يمكنك استخدام حزمة Irihi.Ursa.ReactiveUIExtension. تقوم هذه الحزمة بتنفيذ إصدارات ReactiveUI من UrsaWindow و UrsaView. يرجى الرجوع إلى [الويكي](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) لمزيد من التفاصيل.

## الدعم

نحن نقدم دعماً مجتمعياً مجانياً محدوداً لـ Semi Avalonia و Ursa. يرجى الانضمام إلى مجموعتنا عبر FeiShu(Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---