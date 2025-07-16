# Quick Prompt

<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

Een krachtige browserextensie, gericht op promptbeheer en snel invoeren. Helpt gebruikers bij het creëren, beheren en organiseren van een promptbibliotheek en het snel invoegen van vooraf ingestelde prompts in elk invoerveld op een webpagina, waardoor de efficiëntie wordt verhoogd.

> Omdat browserextensies alleen voor webpagina's werken, is er een identieke [Raycast-extensie](https://github.com/wenyuanw/quick-prompt-raycast) open source gemaakt. Compatibel met het dataformaat van de browserextensie, ondersteunt naadloze migratie via dezelfde JSON-data.

## ✨ Functies

- 📚 **Promptbeheer**: Eenvoudig je promptbibliotheek aanmaken, bewerken en beheren
- 🚀 **Snel invoeren**: Snel de promptkiezer activeren in elk webinvoerveld met `/p`
- ⌨️ Ondersteunt sneltoetsconfiguratie voor het openen van de promptkiezer & het opslaan van geselecteerde tekst als prompt
- 📑 Ondersteunt het direct opslaan van geselecteerde tekst als prompt via het contextmenu (rechtermuisknop)
- 🎯 Ondersteunt aangepaste prompts, inclusief categorie, titel, inhoud, labels en variabelen
- 🧑‍💻 **Variabelenondersteuning**: In prompts kun je variabelen gebruiken in de vorm `{{variabelenaam}}`, waarbij je bij gebruik een waarde kunt invullen
- 💾 **Databack-up**: Ondersteunt exporteren en importeren van de promptbibliotheek, handig voor migratie en back-up tussen apparaten
- 🔗 **Notion-synchronisatie**: Ondersteunt synchronisatie van de promptbibliotheek met een Notion-database
- 🔍 Ondersteunt zoeken en filteren van prompts
- 🌙 Past zich automatisch aan het lichte of donkere systeemthema aan

## ⚠️ Bekende problemen

- Op de Doubao-website (doubao.com) kan het voorkomen dat `/p` niet wordt verwijderd uit sommige invoervelden nadat de promptkiezer is geactiveerd. Geen zorgen, samen met mijn trouwe partner Cursor werk ik dag en nacht aan een oplossing, hopelijk is het snel gefixt!

## 🚀 Gebruiksaanwijzing

1. **Snel activeren**: Typ `/p` in elk tekstinvoerveld op een webpagina om de promptkiezer te activeren
2. **Promptkiezer openen met sneltoets**: Gebruik `Ctrl+Shift+P` (Windows/Linux) of `Command+Shift+P` (macOS) om de promptkiezer te openen
3. **Prompt selecteren**: Klik op de gewenste prompt in de pop-upkiezer; deze wordt automatisch ingevoegd in het huidige invoerveld
4. **Snel prompt opslaan**: Selecteer tekst en gebruik `Ctrl+Shift+S` (Windows/Linux) of `Command+Shift+S` (macOS) om snel op te slaan als prompt
5. **Opslaan via contextmenu**: Selecteer tekst, klik met de rechtermuisknop en kies "Deze prompt opslaan" om de selectie als prompt te bewaren
6. **Promptbibliotheek exporteren**: Klik op de knop "Exporteren" in het beheerscherm om alle prompts als JSON-bestand lokaal op te slaan
7. **Promptbibliotheek importeren**: Klik op de knop "Importeren" in het beheerscherm om prompts vanuit een lokaal JSON-bestand te importeren (ondersteunt samenvoegen of overschrijven van bestaande prompts)

## 📸 Interfacevoorbeeld

Quick Prompt biedt een intuïtieve, gebruiksvriendelijke interface, zodat je prompts eenvoudig kunt beheren en toepassen.

### Promptkiezer

![Promptkiezer](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![Promptkiezer](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

Gebruik de `/p` snelcode of sneltoets om in elk invoerveld snel de promptkiezer te openen, zodat je eenvoudig prompts kunt kiezen en invoegen.

### Promptbeheerpagina

![Promptbeheer](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

Op de beheerpagina kun je nieuwe prompts aanmaken, bestaande bewerken, labels toevoegen en categorieën beheren. De interface is overzichtelijk en gebruiksvriendelijk.

### Opslaan via contextmenu

![Opslaan via contextmenu](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

Selecteer eenvoudigweg tekst op een webpagina, klik met de rechtermuisknop en sla deze direct op als prompt voor meer efficiëntie.

### Promptvariabelen invoeren

![Promptvariabelen pop-up](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

Prompts ondersteunen variabelen; na selectie verschijnt een pop-up om de juiste waarde voor de variabelen in te voeren.

## ⚙️ Aangepaste configuratie

1. Klik op het extensiepictogram en klik vervolgens op de knop "Beheer prompts"

2. Op de beheerderspagina kun je:
   - Nieuwe prompts toevoegen
   - Bestaande prompts bewerken
   - Onnodige prompts verwijderen
   - Labels toevoegen om prompts te categoriseren
   - De promptbibliotheek exporteren voor een back-up
   - Eerder geback-upte promptbibliotheken importeren

## 📦 Installatiehandleiding

### Installeren via de Chrome Web Store

Nu beschikbaar in de Chrome Web Store! [Klik hier om te downloaden en te installeren](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### Downloaden via GitHub Releases

1. Ga naar de [GitHub Releases pagina](https://github.com/wenyuanw/quick-prompt/releases)
2. Download het nieuwste gebouwde plug-inpakket
3. Pak het gedownloade bestand uit
4. Installeer de gebouwde extensie volgens de onderstaande instructies

### Bouwen vanuit de broncode

1. Clone de repository
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. Afhankelijkheden installeren
   ```bash
   pnpm install
   ```
3. Ontwikkeling en bouw

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### Het installeren van de gebouwde extensie

#### Chrome / Edge
1. Open de extensiebeheerpagina (`chrome://extensions` of `edge://extensions`)
2. Schakel "Ontwikkelaarsmodus" in
3. Klik op "Uitgepakte extensie laden"
4. Selecteer de `.output/chrome-mv3/` map van het project

#### Firefox
1. Open `about:debugging`
2. Klik op "Deze Firefox"
3. Klik op "Tijdelijke add-on laden"
4. Selecteer het bestand `manifest.json` in de map `.output/firefox-mv2/` van het project

## 📄 Licentie

MIT

## 🤝 Richtlijnen voor bijdragen

Pull Requests en Issues zijn van harte welkom!

1. Fork deze repository
2. Maak je feature branch (`git checkout -b feature/amazing-feature`)
3. Commit je wijzigingen (`git commit -m 'Add some amazing feature'`)
4. Push naar de branch (`git push origin feature/amazing-feature`)
5. Open een Pull Request

## 👏 Overzicht van bijdragers

Bedankt aan alle ontwikkelaars die aan dit project bijdragen!

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Sterren-geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---