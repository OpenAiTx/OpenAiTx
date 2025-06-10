<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Lassen Sie Ihr Frontend glänzen</strong> ✨
</div>

<div align="center">
  Ein Framework zum Erstellen von Webanwendungen in Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Verfügbar auf Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Dokumentation" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Webseite
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Schnellstart
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referenz
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Erstellt mit ❤︎ von
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> und
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    Mitwirkenden
  </a>
</div>

---

## Inhaltsverzeichnis

- [Funktionen](#features)
- [Beispiel](#example)
- [Philosophie](#philosophy)
- [Installation](#installation)
- [Wie geht es weiter?](#where-next)
- [Support](#support)

## Funktionen {#features}

- Eine **deklarative**, funktionale API zur Konstruktion von HTML. Keine Templates, keine Makros,
  nur Gleam.

- Eine von Erlang und Elm inspirierte Architektur zur **Zustandsverwaltung**.

- **Gemanagte Nebeneffekte** für vorhersagbaren, testbaren Code.

- Universelle Komponenten. **Einmal schreiben, überall ausführen**. Elm trifft Phoenix LiveView.

- Eine **CLI mit allem Drum und Dran**, die das Scaffolden und Erstellen von Apps zum Kinderspiel macht.

- **Serverseitiges Rendering** für statische HTML-Templates.

## Beispiel {#example}

Lustre wird mit [über 20 Beispielen](https://hexdocs.pm/lustre/reference/examples.html) geliefert!
So sieht es aus:

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

## Philosophie {#philosophy}

Lustre ist ein _meinungsstarkes_ Framework zum Erstellen von kleinen bis mittelgroßen Webanwendungen.
Moderne Frontend-Entwicklung ist schwierig und komplex. Ein Teil dieser Komplexität ist notwendig, aber vieles davon ist zufällig oder entsteht durch zu viele Optionen. Lustre verfolgt dieselbe Designphilosophie wie Gleam: Wo möglich, sollte es nur einen Weg geben, Dinge zu tun.

Das bedeutet, dass von Haus aus ein einziges Zustandsmanagementsystem mitgeliefert wird, das sich an Elm und Erlang/OTP orientiert. Öffnen Sie eine beliebige Lustre-Anwendung und Sie werden sich sofort zurechtfinden.

Das bedeutet auch, dass wir einfache Ansätze zur Ansichtserstellung gegenüber komplexen bevorzugen.
Lustre _bietet_ eine Möglichkeit, gekapselte zustandsbehaftete Komponenten zu erstellen (etwas, das wir in Elm sehr vermisst haben), aber dies sollte nicht der Standard sein. Bevorzugen Sie einfache Funktionen gegenüber zustandsbehafteten Komponenten.

Wo Komponenten _notwendig_ sind, nutzen Sie die Tatsache, dass Lustre-Komponenten _überall_ laufen können. Lustre gibt Ihnen die Werkzeuge, um Komponenten zu schreiben, die innerhalb einer bestehenden Lustre-Anwendung laufen, sie als eigenständige Web-Komponente zu exportieren oder sie mit einer minimalen Laufzeit auf dem Server für DOM-Patching auszuführen. Lustre nennt diese **universelle Komponenten** und sie sind für Gleams mehrere Zielplattformen geschrieben.

## Installation {#installation}

Lustre ist auf [Hex](https://hex.pm/packages/lustre) veröffentlicht! Sie können es Ihrer
Gleam-Projekten direkt über die Kommandozeile hinzufügen:

```sh
gleam add lustre
```

Lustre hat außerdem ein Begleitpaket mit Entwicklungstools, das Sie vielleicht installieren möchten:

> **Hinweis**: Der lustre_dev_tools Entwicklungsserver beobachtet Ihr Dateisystem auf Änderungen an Ihrem Gleam-Code und kann den Browser automatisch neu laden. Für Linux-Nutzer ist hierfür [inotify-tools]() erforderlich.

```sh
gleam add --dev lustre_dev_tools
```

## Wie geht es weiter? {#where-next}

Um schnell mit Lustre loszulegen, sehen Sie sich den [Schnellstart-Guide](https://hexdocs.pm/lustre/guide/01-quickstart.html) an.
Wenn Sie lieber Code sehen möchten, finden Sie im [Beispiele-Verzeichnis](https://github.com/lustre-labs/lustre/tree/main/examples)
eine Handvoll kleiner Anwendungen, die verschiedene Aspekte des Frameworks demonstrieren.

Sie können auch die Dokumentation und API-Referenz auf
[HexDocs](https://hexdocs.pm/lustre) durchlesen.

## Support {#support}

Lustre wird hauptsächlich von mir, [Hayleigh](https://github.com/hayleigh-dot-dev), entwickelt – neben zwei Jobs. Wenn Sie meine Arbeit unterstützen möchten, können Sie [mich auf GitHub sponsern](https://github.com/sponsors/hayleigh-dot-dev).

Auch Beiträge sind sehr willkommen! Wenn Sie einen Fehler gefunden haben oder eine Funktion vorschlagen möchten, eröffnen Sie bitte ein Issue oder einen Pull Request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---