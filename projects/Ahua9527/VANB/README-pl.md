# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (Wow!! NB)

VANB to narzędzie do konwersji strumieni wideo/audio oparte na GStreamer, obsługujące dwukierunkową konwersję między protokołami NDI i RTMP. Umożliwia przesyłanie źródeł NDI do serwera RTMP lub konwersję strumienia RTMP na wyjście NDI.

Projekt jest otwartoźródłowy na licencji [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Obsługiwane platformy

Obecnie głównie obsługiwane są następujące platformy:
- macOS (Apple Silicon)

## Wymagania środowiskowe

### Wymagania systemowe
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Kroki instalacji
1. Zainstaluj [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Zainstaluj GStreamer przez Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Sklonuj repozytorium projektu
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Zainstaluj zależności Pythona
```bash
pip install -r requirements.txt
```

5. Skonfiguruj zmienne środowiskowe (zobacz plik .env)
```bash
# Skonfiguruj ścieżkę do NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Skonfiguruj ścieżkę do wtyczek GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Sposób użycia

### NDI do RTMP (nadajnik)
```bash
python vanb_tx.py
```
Program automatycznie skanuje dostępne źródła NDI i poprosi o podanie adresu RTMP do transmisji.

### RTMP do NDI (odbiornik)
```bash
python vanb_rx.py
```
Po podaniu adresu strumienia RTMP program automatycznie utworzy nowe wyjście NDI.

## Status rozwoju

### Zaimplementowane funkcje
- ✓ Konwersja NDI na RTMP
- ✓ Konwersja RTMP na NDI
- ✓ Automatyczna adaptacja liczby klatek i rozdzielczości
- ✓ Synchronizacja audio-wideo
- ✓ Automatyczne skanowanie źródeł NDI
- ✓ Automatyczne nadawanie nazw wyjściom NDI
- ✓ Sprzętowe kodowanie/dekodowanie VideoToolbox

### Funkcje do zaimplementowania
- ⨯ Obsługa plików konfiguracyjnych (Profile/config.json)
  - Sterowanie parametrami wejścia/wyjścia przez plik konfiguracyjny
  - Obsługa różnych presetów transkodowania
  - Możliwość konfiguracji rozmiaru bufora i parametrów opóźnienia
  - Obsługa konfiguracji balansu jakości i wydajności transkodowania
- ⨯ Obsługa wielu jednoczesnych strumieni

## Deklaracja licencyjna

⚠️ **Ważna uwaga: Licencja i zgodność**

### Licencja oprogramowania

Projekt jest licencjonowany na [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Powody wyboru licencji GPL-3.0:
1. Projekt wykorzystuje wiele wtyczek GStreamer na licencji GPL:
   - `x264`: koder wideo H.264 (GPL)
   - `x265`: koder wideo HEVC/H.265 (GPL)
   - `faad`: dekoder audio AAC (GPL)
2. Zgodnie z klauzulą „zarażenia” GPL, oprogramowanie korzystające z komponentów GPL również musi być objęte licencją GPL
3. Wybór GPL-3.0 zapewnia kompatybilność z licencjami wszystkich komponentów zależnych

### Wymagania licencyjne

Korzystając z tego projektu, musisz przestrzegać następujących wymagań:
1. **Otwartość kodu**: Jeśli zmodyfikujesz kod tego projektu lub zintegrujesz go ze swoim projektem, musisz udostępnić cały swój kod źródłowy
2. **Zachowanie licencji**: Twój projekt musi pozostać na licencji GPL-3.0
3. **Oświadczenie o prawach autorskich**: Musisz zachować oryginalne oświadczenie o prawach autorskich i informacje o licencji
4. **Wyraźna adnotacja**: Jeśli zmodyfikujesz kod, musisz wyraźnie zaznaczyć wprowadzone zmiany
5. **Udzielenie patentu**: GPL-3.0 zawiera wyraźne klauzule dotyczące udzielenia patentu

### Licencje komponentów GStreamer
1. Projekt przeznaczony jest wyłącznie do celów rozwojowych i testowych
2. NDI® jest zarejestrowanym znakiem towarowym firmy NewTek, Inc.
3. Korzystanie z tego projektu wymaga przestrzegania umowy licencyjnej NewTek NDI® SDK
4. Przed użyciem w środowisku produkcyjnym upewnij się, że posiadasz wszystkie niezbędne licencje i uprawnienia

## Zgłaszanie problemów

W przypadku problemów:
1. Sprawdź, czy zmienne środowiskowe są prawidłowo skonfigurowane
2. Upewnij się, że wtyczki GStreamer są poprawnie zainstalowane
3. Sprawdź szczegółowe informacje o błędach w pliku dziennika
4. Zgłoś problem przez Issues, dołączając logi i informacje o środowisku

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---