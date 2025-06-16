# Ursa

<p align="center">
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/Ursa.svg" alt="drawing" width="150" />
</p>

[![Irihi.Ursa](https://img.shields.io/nuget/v/Irihi.Ursa.svg?color=red&style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![Irihi.Ursa](https://img.shields.io/nuget/dt/Irihi.Ursa.svg?style=flat-square)](https://www.nuget.org/packages/Irihi.Ursa/)
[![GitCode](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia/star/badge.svg)](https://gitcode.com/IRIHI_Technology/Ursa.Avalonia)

Ursa è una libreria UI a livello enterprise per la creazione di applicazioni multipiattaforma con Avalonia UI.

![Demo](https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/dark-demo.jpg)

## .NET Foundation

Questo progetto è supportato dalla [.NET Foundation](https://dotnetfoundation.org).

## Per Iniziare

1. Ursa

Aggiungi il pacchetto nuget:
```bash
dotnet add package Irihi.Ursa
```

2. Ursa.Themes.Semi

Per visualizzare i controlli Ursa nella tua applicazione, devi fare riferimento a un pacchetto tema progettato per Ursa.
Ursa.Themes.Semi è un pacchetto tema per Ursa ispirato a Semi Design. Puoi aggiungerlo al tuo progetto seguendo questi passaggi.

Aggiungi il pacchetto nuget:
```bash
dotnet add package Semi.Avalonia
dotnet add package Irihi.Ursa.Themes.Semi
```

Includi gli Stili nell'applicazione:
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

Ora puoi utilizzare i controlli Ursa nella tua Applicazione Avalonia.
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

## Codice di Condotta

Questo progetto ha adottato il codice di condotta definito dal Contributor Covenant per chiarire il comportamento atteso nella nostra comunità.
Per maggiori informazioni vedi il [.NET Foundation Code of Conduct](https://dotnetfoundation.org/code-of-conduct).

## Avviso di Compatibilità
Attualmente Ursa è compatibile sia con Avalonia 11.1.x che con 11.2.x, ma specificamente non supporta Avalonia 11.2.0.

## Estensioni

### Estensione Prism
Se hai bisogno di integrare Ursa con Prism.Avalonia, puoi usare il pacchetto Irihi.Ursa.PrismExtension. Questo pacchetto fornisce servizi relativi ai Dialog per utilizzare i Dialog Ursa con le funzionalità Prism.

### Estensione ReactiveUI
Se hai bisogno di integrare Ursa con Avalonia.ReactiveUI, puoi usare il pacchetto Irihi.Ursa.ReactiveUIExtension. Questo pacchetto implementa le versioni ReactiveUI di UrsaWindow e UrsaView. Consulta la [wiki](https://github.com/irihitech/Ursa.Avalonia/wiki/Ursa-ReactiveUI-extension) per i dettagli.

## Supporto

Offriamo supporto comunitario gratuito e limitato per Semi Avalonia e Ursa. Unisciti al nostro gruppo tramite FeiShu(Lark)

<p>
    <img src="https://raw.githubusercontent.com/irihitech/Ursa.Avalonia/main/assets/community-support.png" alt="drawing" width="600" />
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-16

---