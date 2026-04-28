
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">Assamees</
      </div>
    </div>
  </details>
</div>

# cq - Hoge-prestatie SQL-query-engine voor CSV-bestanden

 [![Cross-Build and Test (met zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Een lichtgewicht, snelle SQL-queryprocessor geschreven in C waarmee SQL-query’s direct op CSV-bestanden kunnen worden uitgevoerd zonder dat een database nodig is. Voor volledige documentatie, zie de map /doc.

 ![cq in actie](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentatie

- Snelstartgids: `doc/GettingStarted.md`
- Installatie: `doc/Installation.md`
- Commandoregelinterface: `doc/CLI.md`
- **TUI (Terminal User Interface)**: `doc/TUI.md`
- Architectuur: `doc/Architecture.md`
- Testen: `doc/Testing.md`
- Routekaart: `doc/Roadmap.md`
- Bijdragen: `doc/Contributing.md`

## Snelstart

Bouwen: `make`

### Commandoregel

Voer een voorbeeldquery uit:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal UI

Start interactieve TUI:
`./build/cqtui data/`

Functies:
- Blader door en open CSV-bestanden als tabellen
- Voer SQL-queries interactief uit
- Multi-tab interface voor meerdere tabellen
- Navigatie met toetsenbord
- Geen externe afhankelijkheden

## Voorbeeld SQL-bestanden

De repository bevat voorbeeld-SQL onder assets/ (example_between.sql, example_aggregation.sql, enz.). Zie assets/ voor details.

## Overzicht Data & Functies

- Zie de map /doc voor gedetailleerde secties over datatypes, datumformaten, CSV-formaat, en meer.

## Licentie

MIT-licentie. Zie het LICENSE-bestand voor details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---