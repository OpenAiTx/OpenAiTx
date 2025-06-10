# Cheating Daddy

> [!NOTE]  
> Używaj najnowszych wersji MacOS i Windows, starsze wersje mają ograniczone wsparcie

> [!NOTE]  
> Podczas testowania nie odpowie, jeśli zadasz pytanie, musisz zasymulować, że rekruter zadaje pytanie, na które wtedy odpowie

Asystent AI w czasie rzeczywistym, który zapewnia kontekstową pomoc podczas rozmów wideo, wywiadów, prezentacji i spotkań, wykorzystując przechwytywanie ekranu i analizę dźwięku.

## Funkcje

- **Pomoc AI na żywo**: Wsparcie w czasie rzeczywistym zasilane przez Google Gemini 2.0 Flash Live
- **Przechwytywanie ekranu i dźwięku**: Analizuje to, co widzisz i słyszysz, by udzielać kontekstowych odpowiedzi
- **Wiele profili**: Rozmowa kwalifikacyjna, rozmowa handlowa, spotkanie biznesowe, prezentacja, negocjacje
- **Przezroczysta nakładka**: Okno zawsze na wierzchu, które można umieścić w dowolnym miejscu
- **Tryb przenikania kliknięć**: Umożliwia przenikanie kliknięć przez okno, gdy jest to potrzebne
- **Wieloplatformowość**: Działa na macOS, Windows i Linux (tak trochę, nie używaj, tylko do testów na razie)

## Konfiguracja

1. **Uzyskaj klucz API Gemini**: Odwiedź [Google AI Studio](https://aistudio.google.com/apikey)
2. **Zainstaluj zależności**: `npm install`
3. **Uruchom aplikację**: `npm start`

## Użytkowanie

1. Wprowadź swój klucz API Gemini w głównym oknie
2. Wybierz swój profil i język w ustawieniach
3. Kliknij "Start Session", aby rozpocząć
4. Ustaw pozycję okna za pomocą skrótów klawiaturowych
5. AI będzie udzielać pomocy na żywo w oparciu o ekran i pytania zadawane przez rekrutera

## Skróty klawiaturowe

- **Przesuwanie okna**: `Ctrl/Cmd + Strzałki` - Przesuń okno
- **Przenikanie kliknięć**: `Ctrl/Cmd + M` - Włącz/wyłącz przenikanie kliknięć
- **Zamknij/Wróć**: `Ctrl/Cmd + \` - Zamknij okno lub wróć
- **Wyślij wiadomość**: `Enter` - Wyślij tekst do AI

## Przechwytywanie dźwięku

- **macOS**: [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) dla dźwięku systemowego
- **Windows**: Przechwytywanie dźwięku przez loopback
- **Linux**: Wejście z mikrofonu

## Wymagania

- System operacyjny zgodny z Electron (macOS, Windows, Linux)
- Klucz API Gemini
- Uprawnienia do nagrywania ekranu
- Uprawnienia do mikrofonu/dźwięku

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---