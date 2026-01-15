
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

Een Claude Skills-project dat van AI jouw persoonlijke gespreksmaat maakt.

## Projectintroductie

AI Partner Chat biedt een gepersonaliseerde, contextbewuste chatervaring door gebruikersprofielen, AI-profielen en gevectoriseerde persoonlijke notities te integreren. Deze skill stelt AI in staat jouw eerdere gedachten, voorkeuren en kennisbank te onthouden en te citeren, waardoor een meer samenhangende en persoonlijke interactie ontstaat.

## Kernfuncties

### 🎭 Dubbel Profielsysteem
- **Gebruikersprofiel**: Definieer je achtergrond, expertise, interesses en communicatievoorkeuren
- **AI-profiel**: Stel de rol, communicatiestijl en interactiewijze van de AI in

### 📝 Intelligente Notitiezoekfunctie
- Indexeert automatisch je Markdown-notities
- Zoekt intelligent relevante historische gegevens op basis van de conversatie-inhoud
- Verwijst op natuurlijke wijze naar je eerdere ideeën en notities in het gesprek

### 💬 Gepersonaliseerde Conversatie
- Genereert gepersonaliseerde reacties op basis van je profiel en notities
- Behoudt de samenhang van de gesprekscontext
- Verwijst naar je ideeën als een vriend, niet op een mechanische "volgens de notitie"

## Gebruiksscenario's

Wanneer je het volgende nodig hebt:
- Gepersonaliseerde interactie in plaats van algemene antwoorden
- Contextbewuste reacties waarbij de AI je achtergrond onthoudt
- AI die je eerdere ideeën en notities onthoudt en aanhaalt
- Een doorlopende gespreksbeleving in plaats van telkens opnieuw te beginnen

## Installatie en gebruik

### Skill installeren

Kopieer dit project naar de `.claude/skills/` map in je werkdirectory:

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

### Vaardigheden gebruiken

In Claude Code kun je deze vaardigheid inschakelen door het volgende commando te sturen:

```
遵循 ai-partner-chat 对话
```

De AI-agent zal automatisch:
- De vaardigheidsconfiguratie en richtlijnen lezen
- De benodigde mapstructuur aanmaken (`notes/`, `config/`, `vector_db/` enz.)
- Initialiseren op basis van jouw behoeften

### Initialisatieproces

#### Methode één: Laat de AI automatisch aanmaken en configureren

Bij eerste gebruik, vertel het direct aan de AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```

De AI-agent zal:
1. De inhoud van de notities in de map `notes/` analyseren
2. De notities intelligent opdelen op basis van het notitieformaat en een vector database aanmaken
3. Op basis van de notitie-inhoud jouw achtergrond en voorkeuren inschatten
4. Automatisch `config/user-persona.md` genereren en bijwerken
5. Aanbevelingen doen en `config/ai-persona.md` aanmaken op basis van jouw kenmerken

#### Methode 2: Handmatige profielconfiguratie

Als je het profiel zelf wilt definiëren:
1. De AI-agent maakt automatisch profielbestanden aan vanuit een sjabloon in de map `config/`
2. Je kunt deze bestanden handmatig bewerken om het profiel aan te passen
3. Vervolgens geef je de AI de opdracht om het vectorisatieproces uit te voeren

### Start het gesprek

Na de configuratie hoef je bij elk gebruik alleen het volgende te verzenden:

```
遵循 ai-partner-chat 对话
```

AI zal:
- Je profiel lezen om je achtergrond te begrijpen
- Relevante historische notities opzoeken
- Gepersonaliseerde, contextbewuste antwoorden genereren

## Projectstructuur

### Skillpakketstructuur (te vinden in `.claude/skills/ai-partner-chat/`)

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

### Gebruikersgegevensmap (bevindt zich in de hoofdmap van het project)

De AI-agent maakt de volgende structuur aan in de hoofdmap van je project:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Belangrijk**: Gebruikersdata en skillpacks zijn gescheiden, wat back-ups en migratie vergemakkelijkt.

## Werkstroom

1. **Profiel laden**: Lees gebruikers- en AI-profielen in om de interactiecontext te begrijpen
2. **Notities opvragen**: Haal de meest relevante notities op uit de vector-database op basis van de gebruikersvraag
3. **Context opbouwen**: Integreer profielinformatie, relevante notities en gespreksgeschiedenis
4. **Antwoord genereren**: Genereer een gepersonaliseerd, natuurlijk antwoord op basis van de context

## Belangrijkste kenmerken

### 🤖 AI Agent slimme segmentatie
Het systeem analyseert het daadwerkelijke formaat van elke notitie en genereert dynamisch de meest geschikte segmentatiestrategie, in plaats van vaste sjablonen te gebruiken. Dit betekent dat je notities, ongeacht hun structuur, optimaal verwerkt worden.

### 🎯 Natuurlijke verwijzingen
De AI haalt eerdere informatie net zo vloeiend aan als een herinnering, zonder geforceerde zinnen als "volgens de gegevens", maar verwerkt het natuurlijk in het gesprek.

### 📦 Data onafhankelijkheid
Al jouw data (notities, profielen, vector database) wordt opgeslagen in de hoofdmap van het project, wat back-ups, migratie of delen tussen verschillende skills eenvoudig maakt.

## Best practices

### Profielontwerp
- **Concreet en duidelijk**: Vage profielen leiden tot generieke antwoorden
- **Voorbeelden opnemen**: Toon gewenste interactiepatronen in het AI-profiel
- **Regelmatig bijwerken**: Optimaliseer het profiel voortdurend op basis van gesprekskwaliteit

### Notitiebeheer
- **Vrije structuur**: Het systeem past zich aan elke notitiestructuur aan
- **Rijke inhoud**: Diepgaande notities verbeteren de zoekresultaten
- **Tijdig bijwerken**: Voeg nieuwe notities direct toe aan de index

### Gesprekservaring
- **Natuurlijke verwijzingen**: Verwijs alleen naar notities wanneer echt relevant
- **Blijf vloeiend**: Laat verwijzingen het natuurlijke ritme van het gesprek niet verstoren
- **Focus op kwaliteit**: Geef voorrang aan betekenisvolle connecties boven kwantiteit

## Onderhoud en updates

### Nieuwe notitie toevoegen
Nadat je een nieuwe notitie in de map `notes/` hebt geplaatst, vertel dit aan de AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

De AI-agent analyseert automatisch nieuwe notities en werkt de index bij.

### Profiel bijwerken
Je kunt het profielbestand direct bewerken in de map `config/`, of het aan de AI doorgeven:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Index opnieuw opbouwen
Wanneer de structuur van notities aanzienlijk verandert, vertel het aan AI:

```
请重新初始化向量数据库
```

De AI-agent zal alle notities opnieuw analyseren en de index opnieuw opbouwen.

## Opmerkingen

- **Eerste keer uitvoeren**: Wanneer de AI-agent voor het eerst een vector-database aanmaakt, wordt het embed-model automatisch gedownload (ongeveer 4,3GB); gelieve geduldig te wachten
- **Python-omgeving**: De AI-agent maakt automatisch een virtuele omgeving aan en installeert de benodigde afhankelijkheden
- **Dataopslag**: Alle data (notities, profiel, vectorbibliotheek) wordt opgeslagen in de hoofdmap van het project, niet in de skillpack-map
- **Locatie van de skill**: Zorg ervoor dat het skillpack zich bevindt in de `.claude/skills/ai-partner-chat/` map

## Meer informatie

Raadpleeg het bestand `SKILL.md` voor gedetailleerde technische documentatie en instructies.

---

Laat AI een gesprekspartner worden die je echt begrijpt, en niet alleen een hulpmiddel.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---