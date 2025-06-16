# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa é uma biblioteca de interface do usuário de nível empresarial para construir aplicações multiplataforma com Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Este projeto é suportado pela [.NET Foundation](https://dotnetfoundation.org).

## Primeiros Passos

1. Ursa

Adicione o pacote NuGet:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Para que os controles Ursa apareçam na sua aplicação, você precisa referenciar um pacote de tema projetado para o Ursa.
Ursa.Themes.Semi é um pacote de tema para Ursa inspirado no Semi Design. Você pode adicioná-lo ao seu projeto seguindo os passos abaixo.

Adicione o pacote NuGet:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Inclua os estilos na aplicação:
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


Agora você pode usar os controles Ursa na sua aplicação Avalonia.
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



## Código de Conduta

Este projeto adotou o código de conduta definido pelo Contributor Covenant para esclarecer o comportamento esperado em nossa comunidade.
Para mais informações, veja o [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Aviso de Compatibilidade
Atualmente, o Ursa é compatível com Avalonia 11.1.x e 11.2.x, mas especificamente não suporta Avalonia 11.2.0.

## Extensões

### Extensão Prism
Se você precisa integrar o Ursa com o Prism.Avalonia, pode usar o pacote Irihi.Ursa.PrismExtension. Este pacote fornece serviços relacionados a Diálogos para utilizar os Diálogos Ursa com o estilo Prism.

### Extensão ReactiveUI
Se precisar integrar o Ursa com Avalonia.ReactiveUI, você pode usar o pacote Irihi.Ursa.ReactiveUIExtension. Este pacote implementa as versões ReactiveUI de UrsaWindow e UrsaView. Consulte o [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) para mais detalhes.

## Suporte

Oferecemos suporte comunitário gratuito e limitado para Semi Avalonia e Ursa. Por favor, junte-se ao nosso grupo via FeiShu(Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---