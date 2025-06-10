<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Laat je frontend schitteren</strong> ✨
</div>

<div align="center">
  Een framework voor het bouwen van webapps in Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Beschikbaar op Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Documentatie" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Snelstart
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referentie
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Gemaakt met ❤︎ door
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> en
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    bijdragers
  </a>
</div>

---

## Inhoudsopgave

- [Functies](#features)
- [Voorbeeld](#example)
- [Filosofie](#philosophy)
- [Installatie](#installation)
- [Wat nu](#where-next)
- [Ondersteuning](#support)

## Functies {#features}

- Een **declaratieve**, functionele API voor het opbouwen van HTML. Geen templates, geen macro's, alleen Gleam.

- Een door Erlang en Elm geïnspireerde architectuur voor **statebeheer**.

- **Beheerde side-effects** voor voorspelbare, testbare code.

- Universele componenten. **Schrijf één keer, draai overal**. Elm ontmoet Phoenix LiveView.

- Een **uitgebreide CLI** die scaffolding en het bouwen van apps eenvoudig maakt.

- **Server-side rendering** voor statische HTML-templating.

## Voorbeeld {#example}

Lustre wordt geleverd met [meer dan 20 voorbeelden](https://hexdocs.pm/lustre/reference/examples.html)!
Zo ziet het eruit:

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

## Filosofie {#philosophy}

Lustre is een _eigenzinnig_ framework voor het bouwen van kleine tot middelgrote webapplicaties. Moderne frontend-ontwikkeling is moeilijk en complex. Een deel van die complexiteit is noodzakelijk, maar veel ervan is toevallig of komt voort uit het hebben van te veel keuzes. Lustre heeft dezelfde ontwerpfilosofie als Gleam: waar mogelijk, moet er maar één manier zijn om dingen te doen.

Dat betekent dat er standaard een enkel statebeheersysteem wordt meegeleverd, gemodelleerd naar Elm en Erlang/OTP. Open een Lustre-applicatie en je voelt je meteen thuis.

Het betekent ook dat we eenvoudige benaderingen voor het bouwen van views aanmoedigen boven complexe. Lustre _heeft_ een manier om ingekapselde stateful componenten te maken (iets wat we misten in Elm), maar het zou niet de standaard moeten zijn. Geef de voorkeur aan eenvoudige functies boven stateful componenten.

Waar componenten _wel_ nodig zijn, maak dan gebruik van het feit dat Lustre-componenten _overal_ kunnen draaien. Lustre geeft je de tools om componenten te schrijven die kunnen draaien binnen een bestaande Lustre-applicatie, ze te exporteren als een op zichzelf staande Web Component, of ze op de server te draaien met een minimale runtime voor het bijwerken van de DOM. Lustre noemt dit **universele componenten** en ze zijn geschreven met de verschillende doelen van Gleam in gedachten.

## Installatie {#installation}

Lustre is gepubliceerd op [Hex](https://hex.pm/packages/lustre)! Je kunt het toevoegen aan je Gleam-projecten via de command line:

```sh
gleam add lustre
```

Lustre heeft ook een hulppakket met ontwikkeltools dat je wellicht wilt installeren:

> **Let op**: de lustre_dev_tools ontwikkelserver houdt je bestandssysteem in de gaten op wijzigingen in je gleam-code en kan de browser automatisch herladen. Voor linuxgebruikers is het nodig dat [inotify-tools]() geïnstalleerd is.

```sh
gleam add --dev lustre_dev_tools
```

## Wat nu {#where-next}

Om snel aan de slag te gaan met Lustre, bekijk de [snelstartgids](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Als je liever code ziet, bevat de [examples](https://github.com/lustre-labs/lustre/tree/main/examples) map een handvol kleine applicaties die verschillende aspecten van het framework demonstreren.

Je kunt ook de documentatie en API-referentie lezen op [HexDocs](https://hexdocs.pm/lustre).

## Ondersteuning {#support}

Lustre wordt grotendeels door mij alleen gebouwd, [Hayleigh](https://github.com/hayleigh-dot-dev), naast twee banen. Als je mijn werk wilt steunen, kun je [mij sponsoren op GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Bijdragen zijn ook zeer welkom! Als je een bug hebt gevonden of een functie wilt voorstellen, open dan gerust een issue of een pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---