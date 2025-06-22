<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>Chat met ALLE AI Bots Tegelijkertijd, Ontdek de Beste</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## Screenshots

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## Functies

Op Grote Taalmodellen (LLMs) gebaseerde AI-bots zijn geweldig. Hun gedrag kan echter willekeurig zijn en verschillende bots blinken uit in verschillende taken. Als je de beste ervaring wilt, probeer ze dan niet één voor één. ChatALL (Chinese naam: 齐叨) kan prompts gelijktijdig naar meerdere AI-bots sturen en helpt je om de beste resultaten te ontdekken. Het enige wat je hoeft te doen is [downloaden, installeren](https://github.com/ai-shifu/ChatALL/releases) en vragen.

### Ben jij dit?

Typische gebruikers van ChatALL zijn:

- 🤠**Gurus van LLMs**, die de beste antwoorden of creaties van LLMs willen vinden.
- 🤓**Onderzoekers van LLMs**, die intuïtief de sterke en zwakke punten van verschillende LLMs in uiteenlopende vakgebieden willen vergelijken.
- 😎**Ontwikkelaars van LLM-toepassingen**, die snel prompts willen debuggen en de best presterende foundation modellen willen vinden.

### Ondersteunde bots

| AI Bots                                                                        | Webtoegang  | API         | Opmerkingen                                  |
| ------------------------------------------------------------------------------ | ----------- | ----------- | -------------------------------------------- |
| [360 AI Brain](https://ai.360.cn/)                                             | Ja          | Geen API    |                                              |
| [Baidu ERNIE](https://yiyan.baidu.com/)                                        | Nee         | Ja          |                                              |
| [Character.AI](https://character.ai/)                                          | Ja          | Geen API    |                                              |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                      | Ja          | Geen API    | Geen login vereist                           |
| [ChatGPT](https://chatgpt.com)                                                 | Ja          | Ja          | Web Browsing, Azure OpenAI service inbegrepen|
| [Claude](https://www.anthropic.com/claude)                                     | Ja          | Ja          |                                              |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/) | Ja          | Geen API    |                                              |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                 | Nee         | Ja          |                                              |
| [Cohere Command R Models](https://cohere.com/command)                          | Nee         | Ja          |                                              |
| [Copilot](https://copilot.microsoft.com/)                                      | Ja          | Geen API    |                                              |
| [Dedao Learning Assistant](https://ai.dedao.cn/)                               | Binnenkort  | Geen API    |                                              |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                  | Ja          | Geen API    |                                              |
| [Gemini](https://gemini.google.com/)                                           | Ja          | Ja          |                                              |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)  | Ja          | Geen API    |                                              |
| [Gradio](https://gradio.app/)                                                  | Ja          | Geen API    | Voor Hugging Face space/self-gehoste modellen|
| [Groq Cloud](https://console.groq.com/docs/models)                             | Nee         | Ja          |                                              |
| [HuggingChat](https://huggingface.co/chat/)                                    | Ja          | Geen API    |                                              |
| [iFLYTEK SPARK](http://xinghuo.xfyun.cn/)                                      | Ja          | Binnenkort  |                                              |
| [Kimi](https://kimi.moonshot.cn/)                                              | Ja          | Geen API    |                                              |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                | Ja          | Geen API    |                                              |
| [MOSS](https://moss.fastnlp.top/)                                              | Ja          | Geen API    |                                              |
| [Perplexity](https://www.perplexity.ai/)                                       | Ja          | Geen API    |                                              |
| [Phind](https://www.phind.com/)                                                | Ja          | Geen API    |                                              |
| [Pi](https://pi.ai)                                                            | Ja          | Geen API    |                                              |
| [Poe](https://poe.com/)                                                        | Ja          | Binnenkort  |                                              |
| [SkyWork](https://neice.tiangong.cn/)                                          | Ja          | Binnenkort  |                                              |
| [Tongyi Qianwen](http://tongyi.aliyun.com/)                                    | Ja          | Binnenkort  |                                              |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                  | Ja          | Geen API    | Geen login vereist                           |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                           | Ja          | Geen API    |                                              |
| [xAI Grok](https://x.ai)                                                       | Nee         | Ja          |                                              |
| [YouChat](https://you.com/)                                                    | Ja          | Geen API    |                                              |
| [You](https://you.com/)                                                        | Ja          | Geen API    |                                              |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)              | Ja          | Geen API    |                                              |

Meer volgt. Stem op je favoriete bots in [deze issues](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs).

### Opmerking over betrouwbaarheid van web-verbonden bots

Web-verbonden AI-bots (die gemarkeerd zijn met "Webtoegang") zijn van nature minder betrouwbaar en hebben vaak last van stabiliteitsproblemen, omdat serviceproviders hun webinterfaces en beveiligingsmaatregelen regelmatig bijwerken. Deze webgebaseerde verbindingen zijn afhankelijk van reverse engineering en zijn moeilijk te onderhouden, waardoor ze vaak onverwachts niet meer werken. Voor een betrouwbare ervaring raden we sterk aan om waar mogelijk bots te gebruiken die API-toegang bieden.

### Overige functies

- Snelprompt-modus: stuur de volgende prompt zonder te wachten op het vorige antwoord
- Sla chatgeschiedenis lokaal op, bescherm je privacy
- Markeer het antwoord dat je goed vindt, verwijder het slechte
- Schakel op elk moment bots in of uit
- Wissel tussen één-, twee- of driekolomsweergave
- Automatische update naar de nieuwste versie
- Donkere modus (bijgedragen door @tanchekwei)
- Sneltoetsen. Druk op <kbd>Ctrl</kbd> + <kbd>/</kbd> om ze allemaal te zien (bijgedragen door @tanchekwei)
- Meerdere chats (bijgedragen door @tanchekwei)
- Proxy-instelling (bijgedragen door @msaong)
- Promptbeheer (bijgedragen door @tanchekwei)
- Ondersteunt meerdere talen (Chinees, Engels, Duits, Frans, Russisch, Vietnamees, Koreaans, Japans, Spaans, Italiaans)
- Ondersteunt Windows, macOS en Linux

Geplande functies:

Je bent welkom om aan deze functies bij te dragen.

- [ ] Front-end uitrollen naar GitHub Pages

## Privacy

Alle chatgeschiedenis, instellingen en login-gegevens worden lokaal op je computer opgeslagen.

ChatALL verzamelt anonieme gebruiksgegevens om ons te helpen het product te verbeteren. Dit omvat:

- Welke AI-bots worden geactiveerd en hoe lang de prompt is. Niet de inhoud van de prompt.
- Hoe lang het antwoord is, en welk antwoord is verwijderd/gemarkeerd. Niet de inhoud van het antwoord.

## Vereisten

ChatALL is een client, geen proxy. Daarom moet je:

1. Werkende accounts en/of API-tokens hebben voor de bots.
2. Betrouwbare netwerkverbindingen met de bots hebben.

## Download / Installeren

Download via https://github.com/ai-shifu/ChatALL/releases

### Op Windows

Download het \*-win.exe-bestand en ga verder met de installatie.

### Op macOS

Voor Apple Silicon Mac (M1, M2 CPU), download het \*-mac-arm64.dmg-bestand.

Voor andere Macs, download het \*-mac-x64.dmg-bestand.

Als je [Homebrew](https://brew.sh/) gebruikt, kun je het ook installeren met:

```bash
brew install --cask chatall
```

### Op Linux

Debian-gebaseerde distributies: Download het .deb-bestand, dubbelklik erop en installeer de software.
Arch-gebaseerde distributies: Je kunt ChatALL van de AUR [hier](https://aur.archlinux.org/packages/chatall-bin) klonen. Je kunt het handmatig installeren of met een AUR-helper zoals yay of paru.
Andere distributies: Download het .AppImage-bestand, maak het uitvoerbaar en geniet van de klik-en-start ervaring. Je kunt ook [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher) gebruiken.

## Problemen oplossen

Als je problemen ondervindt bij het gebruik van ChatALL, kun je de volgende methoden proberen om ze op te lossen:

1. **Verversen** - druk op <kbd>Ctrl</kbd> + <kbd>R</kbd> of <kbd>⌘</kbd> + <kbd>R</kbd>.
2. **Herstarten** - sluit ChatALL af en start het opnieuw.
3. **Opnieuw inloggen** - klik op de instellingenknop rechtsboven, klik vervolgens op de juiste login-/logoutlink om opnieuw in te loggen op de website.
4. **Nieuwe chat aanmaken** - klik op de knop `Nieuwe chat` en stuur de prompt opnieuw.

Als geen van bovenstaande werkt, kun je proberen **ChatALL te resetten**. Let op: dit verwijdert al je instellingen en chatgeschiedenis.

Je kunt ChatALL resetten door de volgende mappen te verwijderen:

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

Blijft het probleem bestaan? [Dien dan een issue in](https://github.com/ai-shifu/ChatALL/issues).

## Voor ontwikkelaars

### Draag een Bot bij

[De gids](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) kan je helpen.

### Uitvoeren

```bash
npm install
npm run electron:serve
```

### Bouwen

Bouwen voor je huidige platform:

```bash
npm run electron:build
```

Bouwen voor alle platformen:

```bash
npm run electron:build -- -wml --x64 --arm64
```

## Credits

### Bijdragers

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### Overigen

- GPT-4 heeft een groot deel van de code bijgedragen
- ChatGPT, Copilot en Google leverden veel oplossingen (in volgorde van relevantie)
- Geïnspireerd door [ChatHub](https://github.com/chathub-dev/chathub). Respect!

## Sponsor

Als je dit project waardeert, overweeg dan:

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---