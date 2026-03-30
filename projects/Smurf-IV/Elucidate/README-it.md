
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Descrizione del Progetto](#project-description)
- [Requisiti di Sistema:](#os-requirements)
- [Domande Frequenti](#faqs)
- [roadmap](#roadmap)
- [Screenshot](#screenshots)

## Descrizione del Progetto

Elucidate è un'interfaccia grafica per Windows (GUI) che funge da front-end per l'applicazione SnapRAID a riga di comando.

*Questo progetto continua l'unione dell'ottimo lavoro svolto da me e da altri collaboratori.

## Requisiti di Sistema

- Sistema Operativo Windows
- Runtime .Net 4.8.0
- SnapRaid versione 11.5 o inferiore
- 10MB di spazio libero sull'unità di destinazione

## Domande Frequenti

**D**: Che cos'è SnapRAID?<br/>
**R**: SnapRAID è un motore software-defined per la parità snapshot per sistemi operativi Windows e Linux. Al livello più basilare, offre protezione al contenuto di un file-system sotto la sua gestione calcolando gli hash dei file componenti e memorizzando i risultati in un file di parità. In caso di guasto completo del disco fisso, questo file di parità può essere utilizzato per ricostruire i dati persi. Per tutti i dettagli, visita la [comparazione ufficiale dei motori di protezione dei file di SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**D**: Perché una GUI, la riga di comando funziona!<br/>
**R**: L'obiettivo più ampio è creare una GUI completa di funzionalità con ulteriori strumenti di gestione progettati per aiutare l'utente a mantenere un ambiente SnapRAID funzionante. A volte, i ‘punti e clicca’ sono più semplici per un principiante. La documentazione tecnica di SnapRAID e la sua profonda configurabilità possono scoraggiare chi cerca di provarlo!

**D**: Sono ancora incerto, c'è altro?<br/>
**R**: Sì, dai un'occhiata alla [documentazione](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) per immagini, ecc.

**D**: Quindi quali sono gli "Obiettivi Più Ampi"?<br/>
**R**: Vedi la __Roadmap__ qui sotto per una panoramica completa.

## Roadmap

- [x] Fase I
  - [x] Tentativo di mantenere il supporto minimo per l'ultima versione di SnapRAID. - __In corso.__
  - [x] Facilità d'uso
  - [x] SnapRAID ha tre comandi, quindi rendiamoli semplici da usare per un principiante 
  - [x] Indicatore(i) di progresso 
  - [x] Logging "Interattivo" e diretto nel log. 
  - [x] Avvio automatico all'accesso dell'utente 
  - [x] Suggerimenti per guidare •	

- [x] Fase II Richieste di funzionalità per la Fase II
  - [x] Pausa, Cambio priorità, Interrompi.
  - [x] Estensione dei comandi - "Consentire parametri extra rispetto ai valori predefiniti utilizzati."
  - [x] Pianificazione 
    - Rimosso, utilizzare la CommandLine
  - [x] Vista grafica dei dati protetti.

- [ ] Fase III (Ripresa da marzo 2017 in poi)
  - [x] Nuovo compilatore e .Net 4.7.x	
  - [x] Interfaccia a riga di comando
  - [ ] Nuovo layout tramite Krypton Toolkit / Navigator / ecc.
    - In corso
  - [ ] Traduzioni 
  - [x] Nuovi comandi
  - [ ] Mailer con report di stato
  - [ ] Documentare i passaggi di test
    - In corso
  - [ ] Aggiungere alla documentazione / Aggiornare le immagini
    - In corso
  - [ ] Aggiungere report degli errori su _Windows EventLog_
  - [x] Aggiungere _ExceptionLess_ per il reporting online delle eccezioni
  - [x] Mostrare ciò che potrebbe essere recuperato.

- [ ] Fase IV (nuovi comandi SnapRAID ?) 
  - [ ] Guida estesa al recupero disco - guide interattive ecc.
  - [ ] Notificare all’utente se la versione di SnapRAID è obsoleta
  - [ ] Interpretare i log di SnapRAID (usati dalle modifiche sotto)
  - [ ] Fornire lo stato dell’array dopo l’esecuzione di un comando
  - [ ] Modificare il comando sync per includere un diff iniziale
  - [ ] Modificare il comando sync per mostrare un avviso se il diff ha riportato problemi oltre una soglia
  - [ ] Aggiungere impostazioni configurabili dall’utente per i requisiti di soglia di sync


## Screenshot

![Vista iniziale](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Modulo Impostazioni](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Puoi aiutare? 
- Cerchiamo tester (tutte le piattaforme .Net)
- Può aiutare a tradurre
- Guide / interfaccia utente
- Qualsiasi altra idea :-)
- Sviluppatori per le idee


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---