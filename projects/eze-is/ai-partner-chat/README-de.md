
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Ein Claude Skills Projekt, das KI zu deinem persönlichen Gesprächspartner macht.

## Projektübersicht

AI Partner Chat bietet eine personalisierte, kontextbewusste Chat-Erfahrung, indem Nutzerprofile, KI-Profile und vektorisierte persönliche Notizen integriert werden. Diese Fähigkeit ermöglicht es der KI, sich an deine früheren Gedanken, Präferenzen und Wissensdatenbanken zu erinnern und darauf Bezug zu nehmen, um eine noch kohärentere und individuellere Interaktion zu schaffen.

## Kernfunktionen

### 🎭 Doppel-Porträtsystem
- **Benutzerporträt**: Definiere deinen Hintergrund, deine Fachgebiete, Interessen und Kommunikationspräferenzen
- **KI-Porträt**: Passe die Rollenbeschreibung, den Kommunikationsstil und die Interaktionsweise der KI an

### 📝 Intelligente Notizensuche
- Automatische Indexierung deiner Markdown-Notizen
- Intelligente Suche relevanter historischer Einträge basierend auf dem Gesprächsinhalt
- Natürliche Einbindung deiner bisherigen Gedanken und Notizen in die Konversation

### 💬 Personalisierte Konversation
- Generierung personalisierter Antworten basierend auf deinem Porträt und deinen Notizen
- Erhalt der Kontext-Kohärenz im Gespräch
- Natürliche Bezugnahme auf deine Ideen wie ein Freund, nicht mechanisch „laut Aufzeichnung“

## Anwendungsfälle

Wenn du Folgendes benötigst:
- Personalisierte Kommunikation statt allgemeiner Antworten
- Kontextbewusste Antworten, bei denen die KI deinen Hintergrund kennt
- Eine KI, die sich an deine früheren Gedanken und Notizen erinnert und darauf verweist
- Eine fortlaufende Konversation, statt jedes Mal einen Neustart

## Installation und Nutzung

### Skill installieren

Kopiere dieses Projekt in den `.claude/skills/`-Ordner in deinem Arbeitsverzeichnis:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Verwendung von Fähigkeiten

In Claude Code können Sie diese Fähigkeit aktivieren, indem Sie den folgenden Befehl senden:

```
遵循 ai-partner-chat 对话
```

Der KI-Agent führt automatisch aus:
- Liest die Skill-Konfiguration und Anweisungen
- Erstellt die notwendige Verzeichnisstruktur (`notes/`, `config/`, `vector_db/` usw.)
- Initialisiert entsprechend deinen Anforderungen

### Initialisierungsprozess

#### Methode 1: Die KI automatisch erstellen und konfigurieren lassen

Bei der ersten Verwendung teile der KI einfach mit:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

Der AI-Agent wird:
1. Den Inhalt der Notizen im Verzeichnis `notes/` analysieren
2. Die Notizen intelligent in Abschnitte unterteilen und eine Vektordatenbank erstellen
3. Basierend auf den Notizen deinen Hintergrund und deine Präferenzen ableiten
4. Automatisch die Datei `config/user-persona.md` generieren und aktualisieren
5. Basierend auf deinen Merkmalen die Datei `config/ai-persona.md` empfehlen und erstellen

#### Methode 2: Manuelle Profilkonfiguration

Wenn du das Profil selbst definieren möchtest:
1. Der AI-Agent erstellt automatisch Profildateien aus Vorlagen im Verzeichnis `config/`
2. Du kannst diese Dateien manuell bearbeiten, um das Profil anzupassen
3. Danach teilst du dem AI-Agenten mit, die Vektorisierung durchzuführen

### Gespräch beginnen

Nach Abschluss der Konfiguration musst du bei jeder Nutzung einfach Folgendes senden:

```
遵循 ai-partner-chat 对话
```

Die KI wird:
- Dein Profil lesen, um deinen Hintergrund zu verstehen
- Relevante historische Notizen abrufen
- Personalisierte, kontextbezogene Antworten generieren

## Projektstruktur

### Skill-Paket-Struktur (befindet sich in `.claude/skills/ai-partner-chat/`)

```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Benutzer-Datenverzeichnis (im Projekt-Stammverzeichnis)

Der KI-Agent erstellt im Stammverzeichnis deines Projekts die folgende Struktur:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Wichtig**: Benutzerdaten sind von den Skill-Paketen getrennt, was die Sicherung und Migration erleichtert.

## Arbeitsablauf

1. **Laden von Profilen**: Einlesen von Benutzer- und KI-Profilen, um den Interaktionskontext zu verstehen
2. **Abrufen von Notizen**: Basierend auf der Benutzeranfrage werden die relevantesten Notizen aus der Vektordatenbank abgerufen
3. **Kontextaufbau**: Integration von Profilinformationen, relevanten Notizen und Gesprächsverlauf
4. **Antwortgenerierung**: Erzeugung personalisierter, natürlicher Antworten auf Basis des Kontexts

## Besondere Highlights

### 🤖 Intelligente Blockbildung durch AI Agent
Das System analysiert das tatsächliche Format jeder Notiz und erstellt dynamisch die optimale Blockierungsstrategie, statt vorgefertigte Vorlagen zu verwenden. Das bedeutet, dass deine Notizen unabhängig vom Format optimal verarbeitet werden.

### 🎯 Natürliche Zitation
Die KI integriert frühere Informationen wie Erinnerungen natürlich in das Gespräch, ohne künstlich „laut Protokoll“ zu sagen, sondern fließend im Dialog.

### 📦 Datenunabhängigkeit
Alle deine Daten (Notizen, Profile, Vektordatenbank) werden im Projekt-Stammverzeichnis gespeichert und können einfach gesichert, migriert oder zwischen verschiedenen Skills geteilt werden.

## Best Practices

### Profildesign
- **Konkret und eindeutig**: Unklare Profile führen zu generischen Antworten
- **Beispiele enthalten**: Zeige im KI-Profil gewünschte Interaktionsmuster
- **Regelmäßig aktualisieren**: Optimiere das Profil kontinuierlich anhand der Gesprächsqualität

### Notizverwaltung
- **Freie Formatwahl**: Das System passt sich jeder Notizstruktur an
- **Inhaltliche Tiefe**: Tiefgehende Notizen ermöglichen bessere Abrufresultate
- **Zeitnahe Updates**: Neue Notizen unbedingt in den Index aufnehmen

### Gesprächserlebnis
- **Natürliche Zitation**: Nur relevante Notizen werden wirklich zitiert
- **Flüssigkeit bewahren**: Zitate sollen den natürlichen Gesprächsfluss nicht stören
- **Qualität im Fokus**: Sinnvolle Verbindungen werden bevorzugt, nicht die Anzahl

## Wartung und Aktualisierung

### Neue Notiz hinzufügen
Nachdem Sie eine neue Notiz im Verzeichnis `notes/` abgelegt haben, informieren Sie die KI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

Die KI-Agent analysiert neue Notizen automatisch und aktualisiert den Index.

### Profil aktualisieren
Du kannst die Profil-Datei im Verzeichnis `config/` direkt bearbeiten oder der KI Folgendes mitteilen:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Index neu aufbauen
Wenn sich die Struktur der Notizen erheblich ändert, informieren Sie die KI:

```
请重新初始化向量数据库
```

Der KI-Agent wird alle Notizen neu analysieren und den Index neu erstellen.

## Hinweise

- **Erster Durchlauf**: Beim ersten Erstellen der Vektordatenbank lädt der KI-Agent automatisch das Einbettungsmodell herunter (ca. 4,3GB), bitte haben Sie Geduld
- **Python-Umgebung**: Der KI-Agent erstellt automatisch eine virtuelle Umgebung und installiert die notwendigen Abhängigkeiten
- **Datenspeicherung**: Alle Daten (Notizen, Profile, Vektordatenbank) werden im Projekt-Stammverzeichnis gespeichert, nicht im Skillpaket-Verzeichnis
- **Skill-Speicherort**: Stellen Sie sicher, dass das Skillpaket im Verzeichnis `.claude/skills/ai-partner-chat/` liegt

## Weitere Informationen

Ausführliche technische Dokumentation und Nutzungsanleitung finden Sie in der Datei `SKILL.md`.

---

Lassen Sie die KI zu einem Gesprächspartner werden, der Sie wirklich versteht – und nicht nur ein Werkzeug ist.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---