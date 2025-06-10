# Cheating Daddy

> [!NOTE]  
> Verwenden Sie die neueste Version von MacOS und Windows, ältere Versionen werden nur eingeschränkt unterstützt

> [!NOTE]  
> Während des Testens wird keine Antwort gegeben, wenn Sie etwas fragen. Sie müssen simulieren, dass der Interviewer eine Frage stellt, die dann beantwortet wird.

Ein Echtzeit-KI-Assistent, der während Videoanrufen, Interviews, Präsentationen und Meetings kontextbezogene Hilfe bietet, indem er Bildschirmaufnahmen und Audioanalysen verwendet.

## Funktionen

- **Live-KI-Unterstützung**: Echtzeit-Hilfe mit Google Gemini 2.0 Flash Live
- **Bildschirm- & Audioaufzeichnung**: Analysiert, was Sie sehen und hören, für kontextbezogene Antworten
- **Mehrere Profile**: Interview, Verkaufsgespräch, Geschäftsmeeting, Präsentation, Verhandlung
- **Transparente Überlagerung**: Immer im Vordergrund befindliches Fenster, das beliebig positioniert werden kann
- **Click-through-Modus**: Fenster kann bei Bedarf für Klicks durchlässig gemacht werden
- **Plattformübergreifend**: Funktioniert auf macOS, Windows und Linux (irgendwie, momentan nur zu Testzwecken verwenden)

## Einrichtung

1. **Holen Sie sich einen Gemini API-Schlüssel**: Besuchen Sie [Google AI Studio](https://aistudio.google.com/apikey)
2. **Abhängigkeiten installieren**: `npm install`
3. **App starten**: `npm start`

## Verwendung

1. Geben Sie Ihren Gemini API-Schlüssel im Hauptfenster ein
2. Wählen Sie Ihr Profil und die Sprache in den Einstellungen aus
3. Klicken Sie auf "Sitzung starten", um zu beginnen
4. Positionieren Sie das Fenster mit Tastenkombinationen
5. Die KI bietet Echtzeit-Unterstützung basierend auf Ihrem Bildschirm und den Fragen des Interviewers

## Tastenkombinationen

- **Fenster verschieben**: `Ctrl/Cmd + Pfeiltasten` - Fenster verschieben
- **Click-through**: `Ctrl/Cmd + M` - Mausklick-Ereignisse umschalten
- **Schließen/Zurück**: `Ctrl/Cmd + \` - Fenster schließen oder zurückgehen
- **Nachricht senden**: `Enter` - Text an KI senden

## Audioaufzeichnung

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) für Systemaudio
- **Windows**: Loopback-Audioaufzeichnung
- **Linux**: Mikrofoneingang

## Voraussetzungen

- Elektron-kompatibles Betriebssystem (macOS, Windows, Linux)
- Gemini API-Schlüssel
- Bildschirmaufnahme-Berechtigungen
- Mikrofon-/Audio-Berechtigungen

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---