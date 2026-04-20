<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

Samohostowana, zorientowana na prywatność alternatywa dla MyFitnessPal. Śledź odżywianie, ćwiczenia, parametry ciała i dane zdrowotne, zachowując pełną kontrolę nad swoimi danymi.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness to samohostowana platforma do śledzenia postępów fitness, składająca się z:

- Serwera backendowego (API + przechowywanie danych)
- Frontendu opartego na przeglądarce internetowej
- Natywne aplikacje mobilne na iOS i Androida

Przechowuje i zarządza danymi zdrowotnymi na infrastrukturze, którą kontrolujesz, bez polegania na usługach firm trzecich.

## Kluczowe funkcje

- Śledzenie odżywiania, ćwiczeń, nawodnienia, snu, postów, nastroju i pomiarów ciała
- Ustalanie celów i codzienne odprawy
- Interaktywne wykresy i długoterminowe raporty
- Wiele profili użytkowników i dostęp dla rodziny
- Motywy jasny i ciemny
- OIDC, TOTP, Passkey, MFA itd.

## Integracje zdrowotne i sprzętowe

SparkyFitness może synchronizować dane z wielu platform zdrowotnych i fitness:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (częściowo przetestowane)
- **Hevy** (nieprzetestowane)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (częściowo przetestowane)

Integracje automatycznie synchronizują dane o aktywności, takie jak kroki, treningi i sen, wraz z parametrami zdrowotnymi, takimi jak waga i pomiary ciała, z Twoim serwerem SparkyFitness.

## Opcjonalne funkcje AI (Beta)

SparkyAI udostępnia interfejs konwersacyjny do rejestrowania danych i przeglądania postępów.

- Rejestruj jedzenie, ćwiczenia, statystyki ciała i kroki przez czat
- Przesyłaj zdjęcia posiłków do automatycznego logowania posiłków
- Zachowuje historię rozmów do dalszych działań

Uwaga: Funkcje AI są obecnie w fazie beta.

## Szybki start (Serwer)

Uruchom serwer SparkyFitness w kilka minut za pomocą Docker Compose.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```


## 🎥 Samouczek wideo

[![Obejrzyj wideo](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

Szybki 2-minutowy samouczek pokazujący jak zainstalować SparkyFitness (samohostowany tracker fitness).


## Dokumentacja

Pełne przewodniki instalacji, opcje konfiguracji i dokumentację dla deweloperów znajdziesz na naszej [Stronie Dokumentacji](https://codewithcj.github.io/SparkyFitness/).

### Szybkie linki

- **[Przewodnik instalacji](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - Wdrożenie i konfiguracje
- **[Przegląd funkcji](https://codewithcj.github.io/SparkyFitness/features)** - Pełna dokumentacja funkcji
- **[Przepływ pracy deweloperskiej](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - Przewodnik dla dewelopera i proces kontrybucji
- **[Informacje o aplikacji iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** oraz **[Informacje o aplikacji Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### Potrzebujesz pomocy?

- Zamieść pytanie w issues/dyskusji Github.
- Aby uzyskać szybszą odpowiedź i pomoc od innych członków społeczności **[Dołącz do naszego Discorda](https://discord.gg/vcnMT5cPEA)**

## Historia gwiazdek

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Wykres historii gwiazdek" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## Tłumaczenia

**[Tłumaczenia Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Status tłumaczenia" />
</a>

## Aktywność repozytorium

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Obraz analizy Repobeats")

## Współtwórcy

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ Znane problemy / Funkcje beta ⚠️

SparkyFitness jest w fazie aktywnego rozwoju.
Zmiany łamiące kompatybilność mogą wystąpić pomiędzy wydaniami.

- Automatyczna aktualizacja kontenerów nie jest zalecana
- Zawsze zapoznaj się z informacjami o wydaniu przed aktualizacją

Poniższe funkcje są obecnie w fazie beta i mogą nie być dokładnie przetestowane. Możliwe są błędy lub niekompletna funkcjonalność:

- AI Chatbot
- Dostęp dla rodziny i znajomych
- Dokumentacja API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---