<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Fai brillare il tuo frontend</strong> ✨
</div>

<div align="center">
  Un framework per costruire applicazioni Web in Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Disponibile su Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentazione" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Sito web
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Guida rapida
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Riferimento
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Creato con ❤︎ da
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> e
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    collaboratori
  </a>
</div>

---

## Indice

- [Funzionalità](#features)
- [Esempio](#example)
- [Filosofia](#philosophy)
- [Installazione](#installation)
- [E ora?](#where-next)
- [Supporto](#support)

## Funzionalità {#features}

- Una API **dichiarativa** e funzionale per costruire HTML. Niente template, niente macro,
  solo Gleam.

- Un’architettura ispirata a Erlang e Elm per la **gestione dello stato**.

- **Effetti collaterali gestiti** per codice prevedibile e testabile.

- Componenti universali. **Scrivi una volta, esegui ovunque**. Elm incontra Phoenix LiveView.

- Una **CLI completa** che rende facile e veloce la creazione e compilazione delle app.

- **Rendering lato server** per il templating HTML statico.

## Esempio {#example}

Lustre viene fornito con [oltre 20 esempi](https://hexdocs.pm/lustre/reference/examples.html)!
Ecco come appare:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Filosofia {#philosophy}

Lustre è un framework _opinionato_ per costruire applicazioni Web di piccole e medie dimensioni.
Lo sviluppo frontend moderno è difficile e complesso. Parte di questa complessità è necessaria,
ma molta è accidentale o deriva dall’avere troppe opzioni. Lustre condivide la filosofia di design di Gleam: dove possibile,
dovrebbe esserci solo un modo per fare le cose.

Questo significa fornire un unico sistema di gestione dello stato già incluso, modellato
su Elm ed Erlang/OTP. Apri qualsiasi applicazione Lustre e ti sentirai subito a casa.

Significa anche che incoraggiamo approcci semplici alla costruzione delle viste piuttosto che quelli complessi.
Lustre _ha_ un modo per creare componenti con stato incapsulato (qualcosa che ci è mancato molto in Elm) ma non dovrebbe essere la regola.
Preferisci semplici funzioni ai componenti con stato.

Dove i componenti _sono_ necessari, sfrutta il fatto che i componenti Lustre possono essere eseguiti _ovunque_.
Lustre ti dà gli strumenti per scrivere componenti che possono essere eseguiti all’interno di un’applicazione Lustre esistente,
esportarli come Web Component autonomi o eseguirli sul server con un runtime minimale per il patching del DOM.
Lustre chiama questi **componenti universali** e sono scritti pensando ai molteplici target di Gleam.

## Installazione {#installation}

Lustre è pubblicato su [Hex](https://hex.pm/packages/lustre)! Puoi aggiungerlo ai tuoi progetti Gleam dalla linea di comando:

```sh
gleam add lustre
```

Lustre ha anche un pacchetto companion che contiene strumenti di sviluppo che potresti voler installare:

> **Nota**: il server di sviluppo lustre_dev_tools monitora il file system per
> cambiamenti nel tuo codice Gleam e può ricaricare automaticamente il browser. Per gli utenti Linux è necessario che sia installato [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## E ora? {#where-next}

Per iniziare rapidamente con Lustre, consulta la [guida rapida](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Se preferisci vedere del codice, la directory [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
contiene una serie di piccole applicazioni che dimostrano diversi aspetti del framework.

Puoi anche leggere la documentazione e la reference delle API su
[HexDocs](https://hexdocs.pm/lustre).

## Supporto {#support}

Lustre è sviluppato principalmente da me, [Hayleigh](https://github.com/hayleigh-dot-dev),
tra due lavori. Se vuoi supportare il mio lavoro, puoi [sponsorizzarmi su GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Anche i contributi sono molto benvenuti! Se hai trovato un bug, o vuoi suggerire una funzionalità,
apri una issue o una pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---