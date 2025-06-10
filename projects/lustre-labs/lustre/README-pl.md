<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Spraw, aby Twój frontend lśnił</strong> ✨
</div>

<div align="center">
  Framework do budowania aplikacji webowych w Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Dostępne na Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Dokumentacja" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Strona internetowa
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Szybki start
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referencje
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Stworzone z ❤︎ przez
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> oraz
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    współtwórców
  </a>
</div>

---

## Spis treści

- [Funkcje](#features)
- [Przykład](#example)
- [Filozofia](#philosophy)
- [Instalacja](#installation)
- [Co dalej](#where-next)
- [Wsparcie](#support)

## Funkcje {#features}

- **Deklaratywne**, funkcyjne API do konstruowania HTML. Bez szablonów, bez makr,
  tylko Gleam.

- Architektura inspirowana Erlangiem i Elm do **zarządzania stanem**.

- **Zarządzane efekty uboczne** dla przewidywalnego, testowalnego kodu.

- Uniwersalne komponenty. **Napisz raz, uruchom gdziekolwiek**. Elm spotyka Phoenix LiveView.

- **CLI z kompletem narzędzi**, które ułatwia szkieletowanie i budowanie aplikacji.

- **Renderowanie po stronie serwera** do statycznego szablonowania HTML.

## Przykład {#example}

Lustre zawiera [ponad 20 przykładów](https://hexdocs.pm/lustre/reference/examples.html)!
Oto jak to wygląda:

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

## Filozofia {#philosophy}

Lustre to _opiniotwórczy_ framework do budowania małych i średnich aplikacji webowych.
Współczesny frontend jest trudny i złożony. Część tej złożoności jest konieczna, ale wiele z niej jest przypadkowa lub wynika z nadmiaru opcji. Lustre wyznaje tę samą filozofię co Gleam: tam, gdzie to możliwe, powinna być tylko jedna droga do wykonania zadania.

Oznacza to, że dostarczany jest jeden system zarządzania stanem, inspirowany Elm oraz Erlang/OTP. Otwórz dowolną aplikację Lustre i poczuj się jak u siebie.

Oznacza to także, że zachęcamy do stosowania prostych podejść do budowania widoków zamiast złożonych rozwiązań. Lustre _posiada_ sposób na tworzenie hermetycznych, stanowych komponentów (czego bardzo brakowało nam w Elm), ale nie powinno to być domyślne rozwiązanie. Preferuj proste funkcje zamiast komponentów stanowych.

Gdy komponenty _są_ potrzebne, wykorzystaj fakt, że komponenty Lustre mogą działać _gdziekolwiek_. Lustre daje narzędzia do pisania komponentów, które mogą działać wewnątrz istniejącej aplikacji Lustre, być eksportowane jako samodzielny Web Component lub uruchamiane na serwerze z minimalnym środowiskiem do aktualizacji DOM. Lustre nazywa je **komponentami uniwersalnymi** i są one pisane z myślą o wielu targetach Gleam.

## Instalacja {#installation}

Lustre jest opublikowany na [Hex](https://hex.pm/packages/lustre)! Możesz dodać go do swojego projektu Gleam z linii poleceń:

```sh
gleam add lustre
```

Lustre posiada także dodatkowy pakiet z narzędziami deweloperskimi, który możesz chcieć zainstalować:

> **Uwaga**: serwer developerski lustre_dev_tools obserwuje Twój system plików pod kątem zmian w kodzie gleam i może automatycznie przeładować przeglądarkę. Na Linuksie wymaga to zainstalowania [inotify-tools]().

```sh
gleam add --dev lustre_dev_tools
```

## Co dalej {#where-next}

Aby szybko rozpocząć pracę z Lustre, zapoznaj się z [przewodnikiem szybkiego startu](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Jeśli wolisz zobaczyć kod, katalog [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
zawiera kilka małych aplikacji demonstrujących różne aspekty frameworka.

Możesz również przejrzeć dokumentację i referencje API na [HexDocs](https://hexdocs.pm/lustre).

## Wsparcie {#support}

Lustre jest w większości rozwijany przeze mnie, [Hayleigh](https://github.com/hayleigh-dot-dev), po godzinach, obok dwóch etatów. Jeśli chcesz wesprzeć moją pracę, możesz [wesprzeć mnie na GitHubie](https://github.com/sponsors/hayleigh-dot-dev).

Wkład jest również bardzo mile widziany! Jeśli znalazłeś błąd lub chcesz zaproponować funkcjonalność, otwórz zgłoszenie lub pull request.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---