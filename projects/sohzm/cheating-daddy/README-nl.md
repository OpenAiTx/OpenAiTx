# Cheating Daddy

> [!NOTE]  
> Gebruik de nieuwste versies van MacOS en Windows, oudere versies hebben beperkte ondersteuning

> [!NOTE]  
> Tijdens het testen zal het geen antwoord geven als je iets vraagt; je moet simuleren dat de interviewer een vraag stelt, die dan wordt beantwoord

Een realtime AI-assistent die contextuele hulp biedt tijdens videogesprekken, interviews, presentaties en vergaderingen met behulp van schermopname en audio-analyse.

## Functies

- **Live AI Assistentie**: Realtime hulp mogelijk gemaakt door Google Gemini 2.0 Flash Live
- **Scherm- & Audio-opname**: Analyseert wat je ziet en hoort voor contextuele antwoorden
- **Meerdere Profielen**: Interview, Sales Call, Business Meeting, Presentation, Negotiation
- **Transparante Overlay**: Altijd-bovenop venster dat overal gepositioneerd kan worden
- **Click-through Modus**: Maak het venster transparant voor muisklikken indien nodig
- **Cross-platform**: Werkt op macOS, Windows en Linux (soort van, niet gebruiken, alleen voor testen momenteel)

## Installatie

1. **Genereer een Gemini API Key**: Bezoek [Google AI Studio](https://aistudio.google.com/apikey)
2. **Installeer afhankelijkheden**: `npm install`
3. **Start de App**: `npm start`

## Gebruik

1. Voer je Gemini API-sleutel in het hoofdvenster in
2. Kies je profiel en taal in de instellingen
3. Klik op "Start Session" om te beginnen
4. Positioneer het venster met behulp van sneltoetsen
5. De AI biedt realtime assistentie op basis van je scherm en de vragen van de interviewer

## Sneltoetsen

- **Venster verplaatsen**: `Ctrl/Cmd + Pijltjestoetsen` - Verplaats venster
- **Click-through**: `Ctrl/Cmd + M` - Schakel muisgebeurtenissen in/uit
- **Sluiten/Terug**: `Ctrl/Cmd + \` - Sluit venster of ga terug
- **Bericht verzenden**: `Enter` - Stuur tekst naar AI

## Audio-opname

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) voor systeemaudio 
- **Windows**: Loopback audio-opname
- **Linux**: Microfooningang

## Vereisten

- Electron-compatibel besturingssysteem (macOS, Windows, Linux)
- Gemini API-sleutel
- Schermopname-machtigingen
- Microfoon/audio-machtigingen

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---