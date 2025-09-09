
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Magiczne AI Rysowanie

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Aplikacja AI do rysowania oparta na Next.js, posiadająca następujące główne funkcje:
- 🎨 Wsparcie dla wielu modeli AI (Sora, DALL-E, GPT, GEMINI itd.) oraz możliwość dodawania własnych modeli
- 🖼️ Funkcje generowania obrazów z tekstu oraz z obrazu, wsparcie dla wielu obrazów referencyjnych i edycji wybranych obszarów
- 🔐 Wszystkie dane i klucze API przechowywane lokalnie, zapewniając bezpieczeństwo prywatności
- 💻 Wsparcie dla wersji przeglądarkowej i pakowania jako aplikacja desktopowa, wieloplatformowe zastosowanie

## Doświadczenie online

Adres: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Zrzuty ekranu aplikacji

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="Zrzut ekranu 4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="Zrzut ekranu 4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="Zrzut ekranu 1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="Zrzut ekranu 2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="Zrzut ekranu 3" width="800" style="margin-bottom: 20px"/>
</div>

## Cechy funkcjonalne

- 🎨 Wsparcie dla różnych modeli AI
  - Model GPT Sora_Image
  - Model GPT 4o_Image
  - Model GPT Image 1
  - Model DALL-E 3
  - Model GEMINI
  - 🆕 Własne modele (możliwość dodania prywatnego modelu)
- 🔄 Przełączanie między modelami
  - Szybkie przełączanie pomiędzy różnymi modelami
  - Każdy model posiada indywidualne opcje konfiguracyjne
- ✍️ Funkcja generowania obrazów z tekstu
  - Obsługa własnych promptów
  - Możliwość wyboru proporcji obrazu
  - Wsparcie dla różnych rozmiarów obrazów
- 🖼️ Funkcja generowania obrazów z obrazów
  - Obsługa edycji obrazów
  - Wsparcie dla edycji wybranych obszarów maskujących
  - Możliwość regulacji jakości obrazu
  - Obsługa wielu obrazów jako referencji (jednoczesne przesyłanie wielu zdjęć)
- 🔒 Bezpieczeństwo danych
  - Wszystkie wygenerowane obrazy i historia są przechowywane wyłącznie w lokalnej przeglądarce
  - Obsługa niestandardowego adresu proxy API
  - Możliwość konfiguracji klucza API
- 📱 Projekt interfejsu użytkownika
  - Nowoczesny interfejs użytkownika
  - Płynna obsługa i interakcja
  - Wyświetlanie w formacie Markdown
  - Obsługa podświetlania składni kodu
- 🖥️ Obsługa wielu platform
  - Możliwość spakowania jako aplikacja desktopowa (Windows, macOS, Linux)
  - Obsługa pracy offline (wymaga konfiguracji interfejsu API)

## Stos technologiczny

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (pakowanie aplikacji desktopowych)

## Lokalny rozwój

1. Sklonuj projekt
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. Instalacja zależności

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. Uruchomienie serwera deweloperskiego

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4. Odwiedź [http://localhost:3000](http://localhost:3000)

## Pakowanie aplikacji desktopowej

Ten projekt wykorzystuje Tauri do pakowania aplikacji desktopowej, obsługując systemy Windows, macOS i Linux.

### Przygotowanie środowiska

Przed pakowaniem aplikacji desktopowej należy zainstalować następujące zależności:

1. **Instalacja Rust**:
   - Odwiedź [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install)
   - Postępuj zgodnie z instrukcjami, aby zainstalować Rust i Cargo

2. **Zależności systemowe**:
   - **Windows**: Zainstaluj [Visual Studio C++ Build Tools](https://visualstudio.microsoft.com/visual-cpp-build-tools/)
   - **macOS**: Zainstaluj narzędzia wiersza poleceń Xcode (`xcode-select --install`)
   - **Linux**: Zainstaluj odpowiednie zależności, szczegóły w [dokumentacji Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)

### Tryb deweloperski


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### Tworzenie aplikacji desktopowych


```bash
# 构建桌面应用安装包
npm run desktop
```
Po zakończeniu budowania, pakiet instalacyjny dla odpowiedniego systemu można znaleźć w katalogu `src-tauri/target/release/bundle`.

## Wdrażanie na Vercel

1. Sforkuj ten projekt do swojego konta GitHub

2. Utwórz nowy projekt na [Vercel](https://vercel.com)

3. Zaimportuj swoje repozytorium z GitHub

4. Kliknij wdrożenie

## Instrukcja użytkowania

1. Przy pierwszym użyciu należy skonfigurować klucz API
   - Kliknij "Ustawienia klucza" w prawym górnym rogu
   - Wprowadź klucz API oraz adres bazowy
   - Kliknij Zapisz
   - Możesz także szybko skonfigurować przez parametry URL:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     Uwaga: Specjalne znaki w URL muszą być zakodowane za pomocą kodowania URL

2. Wybierz tryb generowania
   - Generowanie obrazu z tekstu: tworzenie obrazów na podstawie opisu tekstowego
   - Edycja obrazu: przesyłanie obrazu do edycji

3. Ustaw parametry generowania
   - Wybierz model AI (wbudowany lub niestandardowy)
   - Ustaw proporcje obrazu
   - Dostosuj jakość obrazu (tryb edycji obrazu)

4. Zarządzanie niestandardowymi modelami
   - Kliknij ikonę ustawień obok pola wyboru modelu
   - Dodaj nowy model: wprowadź nazwę modelu, wartość modelu i wybierz typ modelu
   - Edytuj model: kliknij przycisk edycji istniejącego modelu
   - Usuń model: kliknij przycisk usuwania istniejącego modelu
   - Wybierz model: kliknij przycisk plusa przy modelu, aby go natychmiast użyć

5. Opis typów modeli
   - Format DALL-E: użyj interfejsu generowania obrazów (/v1/images/generations)
   - Format OpenAI: użyj interfejsu czatu (/v1/chat/completions)

6. Generowanie obrazu
   - Wprowadź frazę wywoławczą
   - Kliknij przycisk "Generuj obraz"
   - Poczekaj na zakończenie generowania

7. Zarządzanie obrazami
   - Przeglądaj historię
   - Pobieraj wygenerowane obrazy
   - Edytuj istniejące obrazy

## Uwagi

- Wszystkie wygenerowane obrazy i historia są przechowywane wyłącznie w lokalnej przeglądarce
- Korzystanie z trybu prywatnego lub zmiana urządzenia spowoduje utratę danych
- Proszę pobierać i tworzyć kopie zapasowe ważnych obrazów na bieżąco
- Konfiguracja API będzie bezpiecznie przechowywana w Twojej przeglądarce, nie jest wysyłana na serwer
- Strona HTTPS blokuje ładowanie zasobów HTTP, aplikacja automatycznie konwertuje adresy HTTP na HTTPS

## Przewodnik dotyczący wkładu

Zapraszamy do zgłaszania Issue oraz Pull Request w celu ulepszania projektu.

## Licencja

Ten projekt jest objęty licencją [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Zgodnie z licencją możesz:
- ✅ Zastosowanie komercyjne: możesz używać oprogramowania w celach komercyjnych
- ✅ Modyfikacje: możesz modyfikować kod źródłowy oprogramowania
- ✅ Dystrybucja: możesz rozpowszechniać oprogramowanie
- ✅ Użytek prywatny: możesz używać oprogramowania prywatnie
- ✅ Licencja patentowa: ta licencja zapewnia także licencję patentową

Ale musisz przestrzegać następujących warunków:
- 📝 Oświadczenie licencyjne i praw autorskich: musisz dołączyć oryginalne oświadczenie licencyjne i praw autorskich
- 📝 Oświadczenie o zmianach: musisz zadeklarować istotne zmiany w oryginalnym kodzie
- 📝 Oświadczenie o znakach towarowych: nie wolno używać znaków towarowych współtwórców

---

## Postaw mi kawę

Jeśli ten projekt był dla Ciebie pomocny, zapraszam do postawienia mi kawy ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Kod płatności WeChat" width="300" />
  <p>Postaw mi kawę</p>
</div>

## Dane kontaktowe

Jeśli masz jakiekolwiek pytania lub sugestie, zapraszam do kontaktu przez WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Kontakt WeChat" width="300" />
  <p>Zeskanuj kod QR, aby dodać mnie na WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---