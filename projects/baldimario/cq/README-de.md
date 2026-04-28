
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# cq - Hochleistungs-SQL-Abfrage-Engine für CSV-Dateien

 [![Cross-Build und Test (mit zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

Ein leichtgewichtiger, schneller SQL-Abfrageprozessor, geschrieben in C, der die Ausführung von SQL-Abfragen direkt auf CSV-Dateien ermöglicht, ohne dass eine Datenbank erforderlich ist. Für die vollständige Dokumentation siehe das Verzeichnis /doc.

 ![cq in Aktion](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)

## Dokumentation

- Erste Schritte: `doc/GettingStarted.md`
- Installation: `doc/Installation.md`
- Befehlszeilenschnittstelle: `doc/CLI.md`
- **TUI (Terminal-Benutzeroberfläche)**: `doc/TUI.md`
- Architektur: `doc/Architecture.md`
- Tests: `doc/Testing.md`
- Roadmap: `doc/Roadmap.md`
- Mitwirken: `doc/Contributing.md`

## Schnellstart

Build: `make`

### Befehlszeile

Führen Sie eine Beispielabfrage aus:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### Terminal-Benutzeroberfläche

Interaktive TUI starten:
`./build/cqtui data/`

Funktionen:
- Durchsuchen und Öffnen von CSV-Dateien als Tabellen
- Interaktive Ausführung von SQL-Abfragen
- Multi-Tab-Oberfläche für mehrere Tabellen
- Tastaturgesteuerte Navigation
- Keine externen Abhängigkeiten

## Beispiel-SQL-Dateien

Das Repository enthält Beispiel-SQL unter assets/ (example_between.sql, example_aggregation.sql, usw.). Siehe assets/ für Details.

## Daten- & Funktionsübersicht

- Siehe den Ordner /doc für detaillierte Abschnitte zu Datentypen, Datumsformaten, CSV-Format und mehr.

## Lizenz

MIT-Lizenz. Siehe LICENSE-Datei für Details.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---