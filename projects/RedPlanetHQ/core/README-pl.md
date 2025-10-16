<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE: Twoja osobista warstwa pamięci dla aplikacji AI

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Dokumentacja</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Najważniejsze wyniki badań

Pamięć CORE osiąga średnią dokładność **88,24%** na zbiorze danych Locomo we wszystkich zadaniach wymagających rozumowania, znacznie przewyższając innych dostawców pamięci. Zobacz ten [blog](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) po więcej informacji.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Pytania jednokrotnego przejścia wymagają odpowiedzi na podstawie jednej sesji; (2) Pytania wielokrotnego przejścia wymagają syntezy informacji z wielu różnych sesji; (3) Pytania dotyczące wiedzy ogólnodomenowej można rozwiązać integrując informacje od rozmówcy z zewnętrzną wiedzą, taką jak zdrowy rozsądek lub fakty ze świata; (4) Pytania wymagające rozumowania czasowego można rozwiązać poprzez rozumowanie czasowe i wychwytywanie wskazówek związanych z czasem w rozmowie;

## Przegląd

**Problem** 

Programiści tracą czas na ponowne tłumaczenie kontekstu narzędziom AI. Osiągasz limit tokenów w Claude? Zaczynasz od nowa i tracisz wszystko. Przechodzisz z ChatGPT/Claude do Cursor? Znowu tłumaczysz swój kontekst. Twoje rozmowy, decyzje i spostrzeżenia znikają między sesjami. Z każdą nową aplikacją AI koszt zmiany kontekstu rośnie.

**Rozwiązanie** - **CORE** (**Contextual Observation & Recall Engine**)

CORE to otwartoźródłowa, zunifikowana i trwała warstwa pamięci dla wszystkich Twoich narzędzi AI. Twój kontekst podąża za Tobą z Cursor do Claude, ChatGPT, Claude Code. Jeden graf wiedzy zapamiętuje kto, co, kiedy i dlaczego powiedział. Połącz się raz, pamiętaj wszędzie. Przestań zarządzać kontekstem, zacznij budować.

## 🚀 Samodzielny hosting CORE
Chcesz uruchomić CORE na własnej infrastrukturze? Samodzielny hosting daje pełną kontrolę nad Twoimi danymi i wdrożeniem.

**Wymagania wstępne**:

- Zainstalowane Docker (20.10.0+) i Docker Compose (2.20.0+)
- Klucz API OpenAI

> **Uwaga dotycząca modeli open-source:** Testowaliśmy opcje OSS, takie jak Ollama i modele GPT, ale jakość ekstrakcji faktów i grafu była niewystarczająca. Aktywnie szukamy alternatyw.

### Instalacja

1. Sklonuj repozytorium:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Skonfiguruj zmienne środowiskowe w `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Uruchom usługę
```
docker-compose up -d
```

Po wdrożeniu możesz skonfigurować swoich dostawców AI (OpenAI, Anthropic) i zacząć budować swój graf pamięci.

👉 [Zobacz kompletny przewodnik po self-hostingu](https://docs.heysol.ai/self-hosting/docker)

Uwaga: Próbowaliśmy modeli open-source takich jak Ollama czy GPT OSS, ale generowanie faktów nie było dobre, nadal pracujemy nad poprawą tego i wtedy dodamy wsparcie dla modeli OSS.

## 🚀 CORE Cloud
**Zbuduj swój zunifikowany graf pamięci w 5 minut:**

Nie chcesz zarządzać infrastrukturą? CORE Cloud pozwala natychmiastowo zbudować osobisty system pamięci — bez konfiguracji, bez serwerów, po prostu pamięć, która działa.

1. **Zarejestruj się** na [core.heysol.ai](https://core.heysol.ai) i załóż konto
2. **Wizualizuj swój graf pamięci** i zobacz jak CORE automatycznie tworzy powiązania między faktami
3. **Przetestuj** — zapytaj „Co wiesz o mnie?” w sekcji rozmów
4. Połącz się ze swoimi narzędziami:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) — kodowanie z kontekstem
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) — kodowanie w terminalu z pamięcią
   - [Dodaj rozszerzenie do przeglądarki](https://docs.heysol.ai/providers/browser-extension) — przenieś swoją pamięć na każdą stronę internetową
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) — automatyczne dodawanie kontekstu projektu

## 🧩 Kluczowe funkcje

### 🧠 **Zunifikowana, przenośna pamięć**: 
Dodawaj i przypominaj sobie swoją pamięć na **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS Kiro, VS Code i Roo Code** za pomocą MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Temporalny + Urealniony Graf Wiedzy**: 

Zapamiętaj historię każdego faktu — śledź kto co powiedział, kiedy i dlaczego, z bogatymi powiązaniami i pełną proweniencją, a nie tylko płaskim magazynem

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Rozszerzenie przeglądarki**: 

Zapisuj rozmowy i treści z ChatGPT, Grok, Gemini, Twittera, YouTube, postów na blogach i dowolnej strony internetowej bezpośrednio do pamięci CORE.

**Jak korzystać z rozszerzenia**
1. [Pobierz rozszerzenie](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) ze sklepu Chrome Web Store.
2. Zaloguj się do [panelu CORE](https://core.heysol.ai)
   - Przejdź do Ustawień (lewy dolny róg)
   - Przejdź do Klucza API → Wygeneruj nowy klucz → Nazwij go „extension.”
3. Otwórz rozszerzenie, wklej swój klucz API i zapisz.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Rozmowa z pamięcią**: 
Zadawaj pytania takie jak „Jakie są moje preferencje pisania?” i uzyskaj natychmiastowe odpowiedzi z połączonej wiedzy

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Automatyczna synchronizacja z aplikacji**:

Automatycznie pobieraj istotny kontekst z Linear, Slack, Notion, GitHub i innych połączonych aplikacji do pamięci CORE

📖 **[Zobacz wszystkie integracje](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Pełna lista obsługiwanych usług i ich funkcji

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **MCP Integration Hub**: 

Połącz Linear, Slack, GitHub, Notion z CORE raz—potem korzystaj ze wszystkich ich narzędzi w Claude, Cursor lub dowolnym kliencie MCP za pomocą jednego URL


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Jak CORE tworzy pamięć

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

Pipeline pobierania danych CORE składa się z czterech faz zaprojektowanych do wychwytywania zmieniającego się kontekstu:

1. **Normalizacja**: Łączy nowe informacje z ostatnim kontekstem, dzieli długie dokumenty na spójne fragmenty zachowując odniesienia krzyżowe oraz standaryzuje terminy, dzięki czemu gdy CORE wydobywa wiedzę, pracuje już na czystym, zkontekstualizowanym wejściu, a nie chaotycznym tekście.
2. **Ekstrakcja**: Wydobywa znaczenie ze znormalizowanego tekstu, identyfikując encje (osoby, narzędzia, projekty, koncepcje), przekształcając je w stwierdzenia z kontekstem, źródłem i czasem oraz mapując relacje. Przykład: „Napisaliśmy CORE w Next.js” staje się: Encje (Core, Next.js), Stwierdzenie (CORE został opracowany przy użyciu Next.js), Relacja (został opracowany przy użyciu).
3. **Rozwiązanie**: Wykrywa sprzeczności, śledzi zmiany preferencji i zachowuje wiele perspektyw z pochodzeniem zamiast je nadpisywać, dzięki czemu pamięć odzwierciedla całą Twoją drogę, a nie tylko najnowszy stan.
4. **Integracja grafu**: Łączy encje, stwierdzenia i epizody w temporalny graf wiedzy, który wiąże fakty z ich kontekstem i historią, zamieniając odizolowane dane w żywą sieć wiedzy, którą agenci mogą faktycznie wykorzystać.

Rezultat: Zamiast płaskiej bazy danych, CORE daje Ci pamięć, która rośnie i zmienia się razem z Tobą – zachowując kontekst, ewolucję i własność, aby agenci mogli z niej faktycznie korzystać.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Jak CORE przypomina sobie z pamięci

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Gdy zadasz CORE pytanie, nie tylko przeszukuje tekst – zagłębia się w cały Twój graf wiedzy, aby znaleźć najbardziej użyteczne odpowiedzi.

1. **Wyszukiwanie**: CORE przeszukuje pamięć z wielu perspektyw jednocześnie – wyszukiwanie po słowach kluczowych dla dokładnych trafień, wyszukiwanie semantyczne dla powiązanych idei nawet jeśli są inaczej sformułowane, oraz przechodzenie po grafie, aby podążać za powiązanymi koncepcjami.
2. **Ponowna ocena**: Odzyskane wyniki są sortowane na nowo, by wyróżnić te najbardziej istotne i zróżnicowane, dzięki czemu nie widzisz tylko oczywistych trafień, ale również głębsze powiązania.
3. **Filtrowanie**: CORE stosuje inteligentne filtry na podstawie czasu, wiarygodności i siły relacji, więc trafia do Ciebie tylko najbardziej znacząca wiedza.
4. **Wynik**: Otrzymujesz zarówno fakty (jasne stwierdzenia), jak i epizody (oryginalny kontekst, z którego pochodzą), więc przypomnienie jest zawsze osadzone w kontekście, czasie i historii.

Rezultat: CORE nie tylko przypomina fakty – przywołuje je w odpowiednim kontekście, czasie i historii, dzięki czemu agenci mogą odpowiadać tak, jak Ty byś pamiętał.

## Dokumentacja

Poznaj naszą dokumentację, aby w pełni wykorzystać możliwości CORE

- [Podstawowe pojęcia](https://docs.heysol.ai/concepts/memory_graph)
- [Samodzielny hosting](https://docs.heysol.ai/self-hosting/overview)
- [Połączenie Core MCP z Claude](https://docs.heysol.ai/providers/claude)
- [Połączenie Core MCP z Cursor](https://docs.heysol.ai/providers/cursor)
- [Połączenie Core MCP z Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Połączenie Core MCP z Codex](https://docs.heysol.ai/providers/codex) 

- [Podstawowe pojęcia](https://docs.heysol.ai/overview)
- [Referencja API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Bezpieczeństwo

CORE traktuje bezpieczeństwo poważnie. Wdrażamy branżowe standardy ochrony danych:

- **Szyfrowanie danych**: Wszystkie dane w tranzycie (TLS 1.3) i w spoczynku (AES-256)
- **Uwierzytelnianie**: OAuth 2.0 oraz uwierzytelnianie za pomocą magicznego linku
- **Kontrola dostępu**: Izolacja na poziomie przestrzeni roboczej i uprawnienia oparte na rolach
- **Zgłaszanie podatności**: Prosimy zgłaszać problemy związane z bezpieczeństwem na harshith@poozle.dev

Aby uzyskać szczegółowe informacje o bezpieczeństwie, zobacz naszą [Politykę Bezpieczeństwa](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Wsparcie

Masz pytania lub uwagi? Jesteśmy tutaj, aby pomóc:

- Discord: [Dołącz do kanału core-support](https://discord.gg/YGUZcvDjUa)
- Dokumentacja: [docs.heysol.ai](https://docs.heysol.ai)
- Email: manik@poozle.dev

## Wytyczne dotyczące użytkowania

**Przechowuj:**

- Historię rozmów
- Preferencje użytkownika
- Kontekst zadania
- Materiały referencyjne

**Nie przechowuj:**

- Danych wrażliwych (PII)
- Poświadczeń
- Logów systemowych
- Danych tymczasowych

## 👥 Współtwórcy

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---