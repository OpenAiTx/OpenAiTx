# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa — это корпоративная библиотека пользовательского интерфейса для создания кроссплатформенных приложений на Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Этот проект поддерживается [.NET Foundation](https://dotnetfoundation.org).

## Начало работы

1. Ursa

Добавьте пакет nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Чтобы элементы управления Ursa появились в вашем приложении, необходимо добавить пакет темы, разработанный для Ursa.
Ursa.Themes.Semi — это пакет темы для Ursa, вдохновленный Semi Design. Вы можете добавить его в свой проект, выполнив следующие шаги.

Добавьте пакет nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Добавьте стили в приложение:
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

Теперь вы можете использовать элементы управления Ursa в вашем Avalonia-приложении.
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

## Кодекс поведения

В этом проекте принят кодекс поведения Contributor Covenant для разъяснения ожидаемого поведения в нашем сообществе.
Для получения дополнительной информации см. [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Уведомление о совместимости

Ursa в настоящее время совместима с Avalonia 11.1.x и 11.2.x, но не поддерживает Avalonia 11.2.0.

## Расширения

### Prism Extension

Если вам необходимо интегрировать Ursa с Prism.Avalonia, вы можете использовать пакет Irihi.Ursa.PrismExtension. Этот пакет предоставляет сервисы, связанные с диалогами, для использования Ursa Dialogs в стиле Prism.

### ReactiveUI Extension

Если вам нужно интегрировать Ursa с Avalonia.ReactiveUI, вы можете использовать пакет Irihi.Ursa.ReactiveUIExtension. Этот пакет реализует версии UrsaWindow и UrsaView для ReactiveUI. Подробности см. на [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension).

## Поддержка

Мы предлагаем ограниченную бесплатную поддержку сообщества для Semi Avalonia и Ursa. Присоединяйтесь к нашей группе через FeiShu(Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---