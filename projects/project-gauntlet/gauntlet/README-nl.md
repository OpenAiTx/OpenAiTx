# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Web-eerste cross-platform applicatielauncher met React-gebaseerde plug-ins

> [!WAARSCHUWING]
> Launcher wordt ontwikkeld door een enkele ontwikkelaar in zijn vrije tijd.
> Veranderingen kunnen langzaam maar gestaag plaatsvinden
>
> Er zullen waarschijnlijk breaking changes zijn die worden gedocumenteerd in de [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Iets verouderde demo

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Functies

- Plugin-eerst
  - Plug-ins zijn geschreven in TypeScript
  - Uitgebreide plugin-API 
      - Maak UI-weergaven
      - Eenmalige commando's
      - Dynamisch een lijst van eenmalige commando's aanbieden
      - Snel "inline" content renderen direct onder de hoofdzoekbalk op basis van de waarde daarin
      - Content ophalen uit en toevoegen aan het klembord
  - Plug-ins worden verspreid als een aparte branch in een Git-repository, wat betekent dat plug-in distributie geen centrale
    server nodig heeft
  - Plug-in ID's zijn gewoon Git-repository URL's
  - [React](https://github.com/facebook/react)-gebaseerde UI voor plug-ins
    - Geïmplementeerd met behulp van een aangepaste React Reconciler (geen Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - Deno maakt het mogelijk om JavaScript plug-in code te sandboxen voor betere beveiliging
    - Plug-ins moeten expliciet aangeven welke permissies ze nodig hebben om te werken
    - Node.js wordt gebruikt om plug-in tooling uit te voeren, maar als plug-in ontwikkelaar schrijf je altijd code die draait op Deno
- Ontworpen met cross-platform in gedachten vanaf het begin
- Commando's en weergaven kunnen worden uitgevoerd/geopend met behulp van aangepaste globale sneltoetsen
- Aangepaste zoekalias kan worden toegewezen aan commando's of weergaven
- Ondersteuning voor aangepaste thema's
- Ingebouwde functionaliteit wordt geleverd door meegeleverde plug-ins
  - Applications: toont applicaties die op het systeem zijn geïnstalleerd in zoekresultaten
    - Plug-in houdt ook bij welke vensters bij welke applicatie horen, zodat het openen van een al geopend programma standaard het eerder gemaakte venster naar voren brengt
      - Niet alle systemen worden momenteel ondersteund. Zie [feature support](https://gauntlet.sh/docs/feature-support)
  - Calculator: toont het resultaat van wiskundige bewerkingen direct onder de hoofdzoekbalk
    - Inclusief valuta omrekenen met gebruik van wisselkoersen
    - Aangedreven door [Numbat](https://github.com/sharkdp/numbat)
- Op frecency gebaseerde volgorde van zoekresultaten
   - Frecency is een combinatie van frequentie en recentheid
   - Hoe vaker het item wordt gebruikt, hoe hoger het in de resultatenlijst zal staan, maar items die veel in het verleden zijn gebruikt, worden lager gerangschikt dan items die recent even vaak zijn gebruikt
   - Resultaten worden per woord gematcht met substring

##### OS-ondersteuning

##### Officieel
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Best-effort
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland wordt nog niet ondersteund, zie [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Aan de slag

### Installeer Gauntlet

Zie [Installatie](https://gauntlet.sh/docs/installation)

### Globale sneltoets

Hoofdvenster kan worden geopend met een globale sneltoets of CLI-commando:
- Globale sneltoets (kan worden aangepast in Instellingen)
  - Windows: <kbd>ALT</kbd> + <kbd>Spatie</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Spatie</kbd>
  - Linux Wayland
    - Globale sneltoets wordt mogelijk niet ondersteund, zie [feature support](https://gauntlet.sh/docs/feature-support)
    - Gebruik in plaats daarvan het CLI-commando en roep het aan via een windowmanager-specifieke aanpak
  - macOS: <kbd>CMD</kbd> + <kbd>Spatie</kbd>
- CLI-commando
  - `gauntlet open`

### Installeer plug-in

Plug-ins worden geïnstalleerd in de instellingen-UI. Gebruik de Git-repository URL van de plug-in om deze te installeren, bijvoorbeeld `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Maak je eigen plug-in

Zie [Aan de slag met plug-in ontwikkeling](https://gauntlet.sh/docs/plugin-development/getting-started)

## Thema's

Zie [Thema's](https://gauntlet.sh/docs/theming)

## Gauntlet bouwen

Je hebt nodig:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (niet gebruikt door het project zelf, maar vereist door een dependency)
- Op Linux: `libxkbcommon-dev` (let op: naam kan verschillen afhankelijk van distributie)

### Dev

Om dev te bouwen voer uit:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
In dev (zonder "release"-feature) zal de applicatie ALLEEN mappen binnen de projectmap gebruiken om status of cache op te slaan, om te voorkomen dat de globale installatie wordt beïnvloed

### Nog-niet-verpakt

Om een nog-niet-verpakte release-binary te bouwen, voer uit:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Verpakt
Om een OS-specifiek pakket te bouwen, voer een van de volgende uit:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Maar het uitbrengen van een nieuwe versie moet gedaan worden via GitHub Actions

## Bijdragen

Als je wilt helpen met het ontwikkelen van Gauntlet, kun je dit op meer manieren doen dan alleen door code bij te dragen:
- Een bug of UI/UX-probleem melden
- Een plug-in maken

Voor eenvoudige problemen kun je gerust zelf een issue of PR openen en het zelf aanpakken. 
Voor meer significante wijzigingen kun je het beste eerst contact opnemen met de makers op Discord (uitnodigingslink bovenaan deze README) en het bespreken.

Alle bijdragen zijn welkom.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---