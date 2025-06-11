<h1 align="center">ModernZ - Een Strakke Alternatieve OSC voor mpv</h1>

Een strakke en moderne OSC voor [mpv](https://mpv.io/), dit project is een fork van ModernX ontworpen om functionaliteit te verbeteren door meer functies toe te voegen, terwijl de kernstandaarden van mpv's OSC behouden blijven.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Installatie »</strong></a>
  <br>
  <a href="#configuration">Configuratie</a>
  ·
  <a href="#controls">Bediening</a>
  ·
  <a href="#interactive-menus">Interactieve Menu's</a>
  ·
  <a href="#translations">OSC Taal</a>
  ·
  <a href="#extras">Extra Scripts</a>
</p>

## Functies

- 🎨 Modern, aanpasbare interface [[opties](#configuration)]
- 📷 Afbeeldingweergavemodus met zoombediening [[details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Knoppen: downloaden, afspeellijst, snelheidsregeling, screenshot, pin, lus, cache en meer. [[details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Interactieve menu's voor afspeellijst, ondertitels, hoofdstukken, audiotracks en audioapparaten [[details](#interactive-menus)]
- 🌐 Meertalige ondersteuning met JSON [locale](#translations) integratie
- ⌨️ Configureerbare bediening [[details](#controls)]
- 🖼️ Videominiatuurvoorbeelden met [thumbfast](https://github.com/po5/thumbfast)

## Aanpassing

Je kunt het pictogramthema veranderen naar `fluent` of `material` om aan je smaak en stijl te voldoen door de `icon_theme` optie te gebruiken in je `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Niet fan van witte knoppen en tekst? Je hebt volledige controle om kleuren en knopindelingen aan te passen zodat ze perfect jouw stijl weerspiegelen.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Zie de sectie [Kleuraanpassing](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) in de configuratiehandleiding voor details over hoe je kleuren en knoppen kunt aanpassen.

## Interactieve Menu's

ModernZ ondersteunt mpv's ingebouwde console/select ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) voor afspeellijst, ondertitels, hoofdstuknavigatie en meer.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Installatie

1. **Schakel Stock OSC uit**

   - Voeg `osc=no` toe in je `mpv.conf`

2. **Bestanden kopiëren**

   - Plaats `modernz.lua` in je mpv scripts map
   - Plaats `fluent-system-icons.ttf` en `material-design-icons.ttf` in je mpv fonts map
   - (OPTIONEEL) Plaats `thumbfast.lua` in je mpv scripts map

3. **Locaties**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%gebruikersnaam%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Mapstructuur** [[mpv handleiding](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (optioneel)
   ```

## Configuratie

1. Maak `modernz.conf` aan in de `/script-opts` map om instellingen aan te passen

   - [Download standaard modernz.conf](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Voorbeeld van een korte configuratie:

   ```EditorConfig
   # Kleur van de seekbar (hex formaat)
   seekbarfg_color=#B7410E

   # Interface opties
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Voor een volledige lijst met opties, [bekijk de gedetailleerde lijst hier](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Bediening

### Knopinteracties

- Linkerklik: Primaire actie
- Rechterklik: Secundaire actie
- Middenklik/Shift+Linkerklik: Alternatieve actie

> [!NOTE]
> Middenklik voert dezelfde functie uit als `Shift+linkermuisknop`, wat gebruik met één hand mogelijk maakt

Voor een volledige lijst van interacties, bekijk de [Knopinteracties Handleiding](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Toetsencombinaties

ModernZ stelt standaard geen toetsencombinaties in om conflicten met je huidige setup te vermijden. Je kunt zelf toetsencombinaties toevoegen in `input.conf` als je dat wilt:

```
w   script-binding modernz/progress-toggle           # Wissel voortgangsbalk
x   script-message-to modernz osc-show               # Toon OSC
y   script-message-to modernz osc-visibility cycle   # Wissel zichtbaarheid modi
z   script-message-to modernz osc-idlescreen         # Wissel idle scherm
```

## Vertalingen

ModernZ is momenteel beschikbaar in het Engels, maar je kunt het eenvoudig naar je voorkeurstaal omzetten! Zo doe je dat:

1. **Download het locale pakket:**

Pak het [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) bestand uit deze repository. Dit bestand bevat vertalingen voor verschillende talen.

2. **Voeg de locales toe aan mpv:**

Kopieer het gedownloade `modernz-locale.json` bestand naar de `/script-opts` map van mpv.

3. **Kies je taal:**

Er zijn twee manieren om je voorkeurstaal in te stellen:

- **Aanbevolen:** Gebruik het `modernz.conf` bestand

  ```ini
  # Voorbeeld configuratie in modernz.conf
  # Stel taal in op Vereenvoudigd Chinees
  language=zh
  ```

- **Alternatief:** Bewerk het `modernz.lua` script

  Open `modernz.lua` en zoek het `user_opts` gedeelte vlak aan het begin. Verander de `language` waarde naar jouw voorkeurscode:

  ```lua
  local user_opts = {
      -- Algemeen
      language = "en",  -- Verander dit naar jouw gewenste taalcode
      ...
  }
  ```

**Meer informatie nodig?**

Voor een volledige lijst beschikbare talen, richtlijnen voor bijdragen en uitgebreide vertaaldocumentatie, ga naar de [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extras

De volgende scripts heb ik geschreven en onderhoud ik, voel je vrij ze te gebruiken als ze nuttig voor je zijn.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Een simpel script dat een indicator toont bij pauze

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Een simpel mpv script om `ytdl-format` (yt-dlp) automatisch te wijzigen voor opgegeven domeinen.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Een simpel mpv script om 4:3 beeldverhouding van videobestanden/streams automatisch om te zetten naar 16:9.

Voor nog meer nuttige scripts, bekijk de [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts). Het biedt een breed scala aan door de community bijgedragen scripts om je mpv-ervaring te verbeteren.

## Geschiedenis

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - geforkt van [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - geforkt van [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - geforkt van [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Waarom weer een fork?**

- Om veel functies toe te voegen: [Kleuraanpassing](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Opties](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) en [Locale Integratie](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Om console en select te integreren in de osc, wat mpv inspireerde om het toe te passen in de stock osc. [ref [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Om een speciale lay-out voor afbeeldingen toe te voegen. [[details](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Om het project volledig opnieuw te doen zodat het voldoet aan de stock osc standaarden van mpv, om compatibiliteit te garanderen
- Om oude bugs en overbodigheden in de code te verwijderen
    - Wat het andere `Modern` forks mogelijk maakt om ModernZ als basis te gebruiken, zoals [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Referentie](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

In essentie, om de oorsprong van `modern-osc` te onderhouden en nieuw leven in te blazen.
Dat gezegd hebbende, ModernZ gebruikt nog steeds delen van de oude code, en elke vorige en huidige fork-auteur en bijdrager verdient erkenning (inclusief de standaard osc van mpv), daarom worden ze in detail genoemd.

#### Credits:

- Lettertype: UI Fluent System Icons [[details](https://github.com/microsoft/fluentui-system-icons)] [[lettertypebestand](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Lettertype aangepast door [Xurdejl](https://github.com/Xurdejl) voor gebruik op ModernZ osc
- [mpv](https://github.com/mpv-player/mpv) en hun [osc.lua](https://raw.githubusercontent.com/Samillion/ModernZ/main/player/lua/osc.lua), aangezien ModernZ osc is gebaseerd op de standaard osc en updates daarvan toepast
- Alle moderne osc oorsprong en hun forks zoals genoemd in [geschiedenis](#history)
- Alle [bijdragers](https://github.com/Samillion/ModernZ/graphs/contributors), testers en gebruikers die direct of indirect hebben geholpen met ModernZ osc ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---