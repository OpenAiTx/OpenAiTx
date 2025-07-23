<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Jeśli podoba Ci się ten projekt, rozważ wsparcie mnie na Patreonie!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Niestandardowe rozszerzenie węzła dla ComfyUI, które dodaje funkcje zamiany tekstu na mowę (TTS) oraz konwersji głosu (VC) przy użyciu biblioteki Chatterbox.
Obsługuje MAKSYMALNIE 40 sekund. Próbowałem usunąć to ograniczenie, ale model bardzo źle sobie radzi z czymkolwiek dłuższym, więc pozostaje ono bez zmian.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Instalacja

1. Sklonuj to repozytorium do katalogu custom_nodes w Twoim ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Zainstaluj podstawowe zależności:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Opcjonalnie) Zainstaluj obsługę znakowania wodnego:

   ```bash
   pip install resemble-perth
   ```
**Uwaga**: Pakiet `resemble-perth` może mieć problemy z kompatybilnością z Pythonem 3.12+. Jeśli napotkasz błędy importu, węzły będą nadal działać bez znakowania wodnego.


## Użytkowanie

### Węzeł Text-to-Speech (FL Chatterbox TTS)
- Dodaj węzeł "FL Chatterbox TTS" do swojego workflow
- Skonfiguruj wejście tekstowe i parametry (exaggeration, cfg_weight, temperature)
- Opcjonalnie podaj próbkę dźwiękową do klonowania głosu

### Węzeł Voice Conversion (FL Chatterbox VC)
- Dodaj węzeł "FL Chatterbox VC" do swojego workflow
- Podłącz wejście audio i docelowy głos
- Oba węzły obsługują przełączenie na CPU w przypadku błędów CUDA

## Dziennik zmian

### 24.06.2025
- Dodano parametr seed do obu węzłów TTS i VC dla powtarzalnej generacji
- Zakres seed: od 0 do 4 294 967 295 (32-bitowy integer)
- Umożliwia spójny wynik audio do debugowania i kontroli workflow
- Uczyniono znakowanie wodne Perth opcjonalnym, aby naprawić problemy z Pythonem 3.12+
- Węzły teraz działają bez znakowania wodnego, jeśli import resemble-perth się nie powiedzie

### 31.05.2025
- Dodano trwałe ładowanie modelu oraz funkcjonalność paska ładowania
- Dodano wsparcie dla Mac (wymaga testów, więc piszcie do mnie)
- usunięto bibliotekę chatterbox-tts i zaimplementowano natywny kod inferencyjny.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---