# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa est une bibliothèque d'interface utilisateur de niveau entreprise pour la création d'applications multiplateformes avec Avalonia UI.

![Démo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Ce projet est soutenu par la [.NET Foundation](https://dotnetfoundation.org).

## Démarrer

1. Ursa

Ajouter le package NuGet :
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Pour afficher les contrôles Ursa dans votre application, vous devez référencer un package de thème conçu pour Ursa.
Ursa.Themes.Semi est un package de thème pour Ursa inspiré par Semi Design. Vous pouvez l'ajouter à votre projet en suivant les étapes ci-dessous.

Ajouter le package NuGet :
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Inclure les styles dans l’application :
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

Vous pouvez maintenant utiliser les contrôles Ursa dans votre application Avalonia.
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

## Code de conduite

Ce projet a adopté le code de conduite défini par le Contributor Covenant afin de clarifier le comportement attendu au sein de notre communauté.
Pour plus d'informations, consultez le [Code de conduite de la .NET Foundation](https://dotnetfoundation.org/code-of-conduct).

## Avis de compatibilité
Ursa est actuellement compatible avec Avalonia 11.1.x et 11.2.x, mais ne prend spécifiquement pas en charge Avalonia 11.2.0.

## Extensions

### Extension Prism
Si vous devez intégrer Ursa avec Prism.Avalonia, vous pouvez utiliser le package Irihi.Ursa.PrismExtension. Ce package fournit des services liés aux dialogues pour utiliser les dialogues Ursa avec la saveur Prism.

### Extension ReactiveUI
Si vous devez intégrer Ursa avec Avalonia.ReactiveUI, vous pouvez utiliser le package Irihi.Ursa.ReactiveUIExtension. Ce package implémente les versions ReactiveUI de UrsaWindow et UrsaView. Veuillez vous référer au [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) pour plus de détails.

## Support

Nous offrons un support communautaire gratuit et limité pour Semi Avalonia et Ursa. Veuillez rejoindre notre groupe via FeiShu (Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---