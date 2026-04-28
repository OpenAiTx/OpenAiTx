
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - Motore SQL ad Alte Prestazioni per File CSV

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Un processore SQL leggero e veloce scritto in C che consente di eseguire query SQL direttamente su file CSV senza la necessità di un database. Per la documentazione completa, consulta la directory /doc.

 ![cq in azione](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Documentazione

- Guida introduttiva: `doc/GettingStarted.md`
- Installazione: `doc/Installation.md`
- Interfaccia a riga di comando: `doc/CLI.md`
- **TUI (Interfaccia Utente Terminale)**: `doc/TUI.md`
- Architettura: `doc/Architecture.md`
- Testing: `doc/Testing.md`
- Roadmap: `doc/Roadmap.md`
- Contributi: `doc/Contributing.md`

## Avvio rapido

Build: `make`

### Riga di comando

Esegui una query di esempio:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Interfaccia Terminale

Avvia la TUI interattiva:
`./build/cqtui data/`

Funzionalità:
- Sfoglia e apri file CSV come tabelle
- Esegui query SQL in modo interattivo
- Interfaccia multi-tab per più tabelle
- Navigazione tramite tastiera
- Nessuna dipendenza esterna

## File SQL di esempio

Il repository include esempi SQL sotto assets/ (example_between.sql, example_aggregation.sql, ecc.). Vedere assets/ per dettagli.

## Panoramica dati & funzionalità

- Consulta la cartella /doc per sezioni dettagliate su tipi di dati, formati data, formato CSV e altro.

## Licenza

Licenza MIT. Consultare il file LICENSE per i dettagli.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---