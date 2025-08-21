
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introduzione](#introduzione)
- [Installazione](#installazione)
  - [Chrome](#browser-basati-su-chrome)
    - [Guida Visiva](#browser-basati-su-chrome)
  - [Firefox](#browser-basati-su-firefox)
- [Come si usa](#come-si-usa)
  - [Aggiunta del tempo](#adding-time)
    - [Fondamenta](#adding-time-in-foundations)
    - [Costruttore di fluidità](#adding-time-in-fluency-builder)
  - [Validazione della lezione](#validating-lesson)
    - [Fondamenta](#validating-lesson-in-foundations)
    - [Costruttore di fluidità](#validating-lesson-in-fluency-builder)

## Introduzione

RosettaStonks è un'estensione per browser che consente di aggiungere tempo e validare
lezioni sulla piattaforma di apprendimento linguistico Rosetta Stone.

> RosettaStonks, e la tua rosetta stone diventa stonks.

## Installazione

### Browser basati su Chrome

➡️ **Nuovo nell'installazione manuale di estensioni Chrome?** Dai un'occhiata alla [Guida Visiva Passo-Passo](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — include screenshot utili! 🖼️

#### 1. Utilizzando GitHub Release

Per utilizzare l'estensione in un browser basato su Chrome, è necessario:

- scaricare il file `rosettastonks-chrome.tar.gz` dall'ultima release sul
  tuo computer.
- creare una cartella chiamata `rosettastonks` da qualche parte sul tuo computer per conservare
  l'estensione
- eseguire il seguente comando nella cartella `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Utilizzo del gestore di pacchetti nix

Invece dei comandi precedenti, se sei su un sistema nix **che supporta
flakes**, puoi eseguire i seguenti comandi, che installeranno una cartella
nel percorso `/tmp/rosettastonks` con tutti i file.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

La cartella è ora installata in `/tmp/rosettastonks/`

**Questa parte è per tutti gli utenti, indipendentemente dal fatto che si utilizzi il metodo github
o il metodo nix.**

Nel tuo browser:

- vai su `chrome://extensions`
- attiva la modalità `Developer mode`
- clicca su `Load unpacked`
- seleziona la tua cartella `rosettastonks`

### Browser basati su Firefox

- scarica il file `rosettastonks.xpi` dall'ultima release.
- in alternativa, se utilizzi il gestore di pacchetti nix con il supporto alle flake, puoi eseguire
  il seguente comando.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- vai su `about:addons` nel tuo browser
- clicca sul pulsante delle impostazioni e vai su `Debug addons`.
- clicca su `Carica componente aggiuntivo temporaneo`
- seleziona il file `/tmp/rosettastonks.xpi` nel selettore di file.

_Avviso: Questo metodo installa l'estensione solo temporaneamente, il che significa che se
chiudi il browser, il componente aggiuntivo verrà disinstallato. Questo è dovuto alle
politiche di Firefox che non permettono l'uso di estensioni non verificate._

## Come utilizzare

### Aggiunta del tempo

#### Aggiunta del tempo in Foundations

Per aggiungere tempo al prodotto `foundations`, devi andare nei tuoi esercizi e
cliccare su ignora o risolvi almeno una domanda. Una volta fatto ciò, dovrebbe apparire
un campo per il tempo nella pagina dell'estensione dove puoi aggiungere il tuo tempo.

#### Aggiunta del tempo in Fluency builder

Per aggiungere tempo al prodotto `fluency builder`, devi andare nei tuoi esercizi e
rispondere ad almeno un esercizio. Se il campo di aggiunta tempo non appare, significa
che non è stata intercettata alcuna richiesta di tempo, devi ricaricare la domanda e rispondere
nuovamente. Per avere il tempo aggiunto, devi terminare la lezione che hai usato per
aggiungere il tempo.

_Nota: Se non vedi il campo di aggiunta tempo, significa che le azioni che hai
fatto sul sito Rosetta Stone non hanno portato ad aggiungere tempo legittimo, e quindi,
devi rispondere ad altre domande._

### Validazione della lezione

#### Validazione della lezione in Foundations

Per validare una lezione, occorre iniziare una lezione e passare attraverso tutte le
domande tramite il pulsante `ignora` in basso a destra. Una volta che tutte le
domande sono state viste, cliccando il pulsante `valida lezione` dovrebbe validare
la lezione. Se non funziona, torna alla tua home page, clicca sulla stessa lezione, essa
dovrebbe chiederti `Vuoi continuare o resettare?`, puoi scegliere entrambi, e
validare la lezione di nuovo fino a quando funziona. Dovrebbe funzionare dopo un massimo di 3/4 volte.

#### Validazione della lezione in Fluency builder

Attualmente, la funzione di validazione della lezione non è disponibile su rosetta stonks.

## Compilazione dell'applicazione

### Compilazione del worker

Il worker può essere impacchettato usando il seguente comando

```
$ deno task build:worker
```

Che crea il file pacchettizzato `/dist/worker.esm.js` che è il file pacchettizzato
per il worker.

### Compilazione del frontend

Il worker può essere pacchettizzato utilizzando il seguente comando

```
$ deno task build:frontend
```

Questo crea il file pacchettizzato `/dist/frontend.esm.js` che è il file pacchettizzato
per il frontend.

## Pacchettizzazione dell'estensione

### Chrome

Per pacchettizzare l'estensione per Chrome, è possibile eseguire il seguente comando:

```
$ make chrome
```

### Firefox

Per impacchettare l'estensione per Firefox, è possibile eseguire il seguente comando:

```
$ make firefox
```

Questo produrrà `rosettastonks.xpi`, il file dell'estensione che può essere
caricato in Firefox.

📸 Preferisci contenuti visivi? Consulta la [Guida all'installazione su Chrome con immagini](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---