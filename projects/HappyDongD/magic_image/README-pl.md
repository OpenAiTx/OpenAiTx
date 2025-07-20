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

# Magiczna AI do Rysowania

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Aplikacja AI do rysowania oparta na Next.js, oferująca następujące główne funkcje:
- 🎨 Wsparcie dla wielu modeli AI (Sora, DALL-E, GPT itp.) oraz możliwość dodawania własnych modeli
- 🖼️ Funkcja generowania obrazu z tekstu i obrazu, wsparcie dla wielu obrazów referencyjnych i edycji obszarów
- 🔐 Wszystkie dane i klucze API przechowywane lokalnie, zapewniając prywatność i bezpieczeństwo
- 💻 Wersja webowa oraz możliwość spakowania jako aplikacja desktopowa, wieloplatformowość

## Wersja demonstracyjna online

Adres dostępu: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### Zrzuty ekranu aplikacji

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="应用截图4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="应用截图1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="应用截图2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="应用截图3" width="800" style="margin-bottom: 20px"/>
</div>

## Główne funkcje

- 🎨 Wsparcie dla wielu modeli AI
  - Model GPT Sora_Image
  - Model GPT 4o_Image
  - Model GPT Image 1
  - Model DALL-E 3
  - 🆕 Własny model (obsługa prywatnych modeli)
- ✍️ Generowanie obrazu z tekstu
  - Obsługa własnych promptów
  - Możliwość wyboru proporcji obrazu
  - Wsparcie dla wielu rozmiarów obrazów
- 🖼️ Generowanie obrazu z obrazu
  - Edycja obrazu
  - Edycja masek obszarów
  - Regulacja jakości obrazu
  - Wiele obrazów referencyjnych (możliwość przesłania wielu plików naraz)
- 🔒 Bezpieczeństwo danych
  - Wszystkie wygenerowane obrazy i historia zapisywane wyłącznie lokalnie w przeglądarce
  - Obsługa własnego adresu proxy API
  - Obsługa konfiguracji klucza API
- 📱 Projekt UI
  - Nowoczesny interfejs użytkownika
  - Płynna interakcja
  - Wyświetlanie w formacie Markdown
  - Wsparcie dla podświetlania składni kodu
- 🖥️ Wsparcie wieloplatformowe
  - Możliwość spakowania jako aplikacja desktopowa (Windows, macOS, Linux)
  - Możliwość pracy offline (wymagana konfiguracja API)

## Stos technologiczny

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri (pakowanie aplikacji desktopowej)

## Rozwój lokalny

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
     Uwaga: Znaki specjalne w URL muszą być zakodowane zgodnie z URL

2. Wybierz tryb generowania
   - Tekst na obraz: generuj obraz za pomocą opisu tekstowego
   - Obraz na obraz: prześlij obraz do edycji

3. Ustaw parametry generowania
   - Wybierz model AI (model wbudowany lub własny)
   - Ustaw proporcje obrazu
   - Dostosuj jakość obrazu (tryb obraz na obraz)

4. Zarządzanie własnymi modelami
   - Kliknij ikonę ustawień obok pola wyboru modelu
   - Dodaj nowy model: wpisz nazwę modelu, wartość modelu i wybierz typ modelu
   - Edytuj model: kliknij przycisk edycji przy istniejącym modelu
   - Usuń model: kliknij przycisk usuwania przy istniejącym modelu
   - Wybierz model: kliknij przycisk plusa przy modelu, aby natychmiast go użyć

5. Wyjaśnienie typów modeli
   - Format DALL-E: używa interfejsu generowania obrazów (/v1/images/generations)
   - Format OpenAI: używa interfejsu czatu (/v1/chat/completions)

6. Generowanie obrazu
   - Wpisz słowa kluczowe
   - Kliknij przycisk "Generuj obraz"
   - Poczekaj na zakończenie generowania

7. Zarządzanie obrazami
   - Przeglądaj historię
   - Pobierz wygenerowane obrazy
   - Edytuj istniejące obrazy

## Uwagi

- Wszystkie wygenerowane obrazy i historia zapisywane są tylko w lokalnej przeglądarce
- Tryb prywatny lub zmiana urządzenia spowoduje utratę danych
- Pobierz i wykonaj kopię zapasową ważnych obrazów na czas
- Konfiguracja API jest bezpiecznie przechowywana w Twojej przeglądarce i nie jest przesyłana na serwer
- Strony HTTPS blokują ładowanie zasobów HTTP, aplikacja automatycznie konwertuje interfejsy HTTP na HTTPS

## Wskazówki dotyczące współpracy

Zapraszamy do zgłaszania Issue i Pull Request, aby pomóc ulepszyć projekt.

## Licencja

Projekt objęty jest licencją [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0).

Zgodnie z licencją możesz:
- ✅ Wykorzystanie komercyjne: możesz używać oprogramowania komercyjnie
- ✅ Modyfikacje: możesz modyfikować kod źródłowy
- ✅ Dystrybucja: możesz dystrybuować oprogramowanie
- ✅ Użytek prywatny: możesz używać oprogramowania prywatnie
- ✅ Licencja patentowa: licencja ta zapewnia również licencję patentową

Ale musisz przestrzegać poniższych warunków:
- 📝 Oświadczenie licencyjne i copyright: musisz dołączyć oryginalną licencję i oświadczenie o prawach autorskich
- 📝 Oświadczenie o zmianach: musisz wskazać istotne zmiany w oryginalnym kodzie
- 📝 Oświadczenie o znakach towarowych: nie wolno używać znaków towarowych współtwórców

---

## Postaw mi kawę

Jeśli ten projekt był dla Ciebie pomocny, zapraszam do postawienia mi kawy ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="Kod płatności WeChat" width="300" />
  <p>Postaw mi kawę</p>
</div>

## Kontakt

Jeśli masz pytania lub sugestie, zapraszam do kontaktu przez WeChat:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="Kontakt WeChat" width="300" />
  <p>Zeskanuj kod QR, aby dodać na WeChat</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---