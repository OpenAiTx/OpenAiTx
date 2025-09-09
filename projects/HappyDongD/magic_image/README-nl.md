
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Indonesisch</a>
      </div>
    </div>
  </details>
</div>

# Magische AI-schilderijen

<div align="right">中文 | <a href="README-EN.md">Engels</a></div>

[![Licentie](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Een op Next.js gebaseerde AI-beeldapplicatie met de volgende hoofdfunctionaliteiten:
- 🎨 Ondersteunt meerdere AI-modellen (Sora, DALL-E, GPT, GEMINI, enz.) en het toevoegen van aangepaste modellen
- 🖼️ Biedt tekst-naar-beeld en beeld-naar-beeld functionaliteit, ondersteunt meerdere referentiebeelden en gebiedsbewerking
- 🔐 Alle gegevens en API-sleutels worden lokaal opgeslagen, waarborgt privacy en veiligheid
- 💻 Ondersteunt webversie en desktopapplicatie packaging, cross-platform gebruik

## Online ervaring

Toegangsadres: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### App screenshots

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="App screenshot 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="App screenshot 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="App screenshot 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="App screenshot 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="App screenshot 3" width="800" style="margin-bottom: 20px"/>
</div>

## Functiekenmerken

- 🎨 Ondersteunt meerdere AI-modellen
  - GPT Sora_Image model
  - GPT 4o_Image model
  - GPT Image 1 model
  - DALL-E 3 model
  - GEMINI model
  - 🆕 Aangepaste modellen (ondersteunt toevoegen van private modellen)
- 🔄 Modellenswitch
  - Ondersteunt snel schakelen tussen verschillende modellen
  - Elk model heeft onafhankelijke configuratie-opties
- ✍️ Tekst-naar-beeld functie
  - Ondersteunt aangepaste prompts
  - Mogelijkheid tot kiezen van beeldverhouding
  - Ondersteunt verschillende beeldformaten
- 🖼️ Beeld-naar-beeld functie
  - Ondersteunt bewerken van afbeeldingen
  - Ondersteunt gebiedsmaskerbewerking
  - Ondersteunt aanpassing van beeldkwaliteit
  - Ondersteunt meerdere afbeeldingsreferenties (meerdere afbeeldingen tegelijk uploaden)
- 🔒 Gegevensbeveiliging
  - Alle gegenereerde afbeeldingen en geschiedenis worden alleen lokaal in de browser opgeslagen
  - Ondersteunt aangepaste API-proxy-adres
  - Ondersteunt API Key-configuratie
- 📱 UI-ontwerp
  - Moderne gebruikersinterface
  - Soepele interactieve ervaring
  - Weergave in Markdown-formaat
  - Ondersteuning voor code-highlighting
- 🖥️ Cross-platform ondersteuning
  - Ondersteunt verpakken als desktopapplicatie (Windows, macOS, Linux)
  - Ondersteunt offline gebruik (API-interface configuratie vereist)

## Technische stack

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (desktopapplicatieverpakking)

## Lokale ontwikkeling

1. Project klonen
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Afhankelijkheden installeren

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Start de ontwikkelserver

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Bezoek [http://localhost:3000](http://localhost:3000)

## Desktop applicatie packaging

Dit project gebruikt Tauri voor het verpakken van desktop applicaties en ondersteunt Windows, macOS en Linux systemen.

### Omgevingsvoorbereiding

Voor het verpakken van de desktop applicatie moeten de volgende afhankelijkheden worden geïnstalleerd:

1. **Rust installeren**:
   - Bezoek [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Volg de instructies om Rust en Cargo te installeren

2. **Systeemafhankelijkheden**:
   - **Windows**: Installeer [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Installeer Xcode command line tools (`xcode-select --install`)
   - **Linux**: Installeer de relevante afhankelijkheden, zie [Tauri documentatie](https://tauri.app/v1/guides/getting-started/prerequisites)

### Ontwikkelmodus


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Desktopapplicatie bouwen


```bash
# 构建桌面应用安装包
npm run desktop
```
Na het voltooien van de build kun je het installatiepakket voor het betreffende systeem vinden in de map `src-tauri/target/release/bundle`.

## Vercel Deploy

1. Fork dit project naar je eigen GitHub-account

2. Maak een nieuw project aan op [Vercel](https://vercel.com)

3. Importeer je GitHub-repository

4. Klik op Deploy

## Gebruiksaanwijzing

1. Bij eerste gebruik moet je een API-sleutel instellen
   - Klik rechtsboven op "Sleutelinstellingen"
   - Voer de API-sleutel en het basisadres in
   - Klik op Opslaan
   - Je kunt ook snel configureren via URL-parameters:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Let op: speciale tekens in de URL moeten worden gecodeerd volgens de URL-codering

2. Kies generatie modus
   - Tekst-naar-beeld: genereer een afbeelding op basis van een tekstbeschrijving
   - Beeld-naar-beeld: upload een afbeelding om deze te bewerken

3. Stel generatieparameters in
   - Kies een AI-model (ingebouwd model of aangepast model)
   - Stel de beeldverhouding in
   - Pas de beeldkwaliteit aan (beeld-naar-beeld modus)

4. Aangepast modellenbeheer
   - Klik op het instellingenpictogram naast het modelkeuzeveld
   - Nieuw model toevoegen: voer modelnaam, modelwaarde in en kies modeltype
   - Model bewerken: klik op de bewerkknop van een bestaand model
   - Model verwijderen: klik op de verwijderknop van een bestaand model
   - Model selecteren: klik op de plusknop van een model om het direct te gebruiken

5. Uitleg modeltypes
   - DALL-E formaat: gebruikt het interface voor beeldgeneratie (/v1/images/generations)
   - OpenAI formaat: gebruikt het chatinterface (/v1/chat/completions)

6. Beeld genereren
   - Voer een prompt in
   - Klik op de knop "Beeld genereren"
   - Wacht tot het genereren is voltooid

7. Beheer van afbeeldingen
   - Bekijk geschiedenis
   - Download de gegenereerde afbeeldingen
   - Bewerk bestaande afbeeldingen

## Let op

- Alle gegenereerde afbeeldingen en de geschiedenis worden alleen lokaal in uw browser opgeslagen
- Gebruik van privémodus of wisselen van apparaat kan leiden tot verlies van gegevens
- Download en back-up belangrijke afbeeldingen tijdig
- API-configuratie wordt veilig in uw browser opgeslagen en niet geüpload naar de server
- Het laden van HTTP-bronnen op HTTPS-websites wordt door de browser geblokkeerd; de applicatie converteert HTTP-interfaces automatisch naar HTTPS

## Richtlijnen voor bijdragen

Welkom om Issues en Pull Requests in te dienen om het project te verbeteren.

## Licentie

Dit project gebruikt de [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) licentie.

Volgens de licentie mag u:
- ✅ Commercieel gebruik: U mag de software commercieel gebruiken
- ✅ Wijzigen: U mag de broncode van de software wijzigen
- ✅ Verspreiden: U mag de software verspreiden
- ✅ Privégebruik: U mag de software privé gebruiken
- ✅ Octrooiverlening: Deze licentie biedt ook octrooiverlening

Maar u moet aan de volgende voorwaarden voldoen:
- 📝 Licentie- en copyrightverklaring: U moet de originele licentie en copyrightverklaring bijvoegen
- 📝 Wijzigingsverklaring: U moet belangrijke wijzigingen aan de originele code verklaren
- 📝 Merkenverklaring: U mag de handelsmerken van de bijdragers niet gebruiken

---

## Trakteer mij op een kopje koffie

Als dit project je heeft geholpen, nodig ik je uit om mij op een kopje koffie te trakteren ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="WeChat betaalcode" width="300" />
  <p>Trakteer mij op een kopje koffie</p>
</div>

## Contactinformatie

Als u vragen of suggesties heeft, neem gerust contact met mij op via WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="WeChat contactinformatie" width="300" />
  <p>Scan de QR-code om WeChat toe te voegen</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---