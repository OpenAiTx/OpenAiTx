# Przykłady Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Wypróbuj w Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Język</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
    </div>
  </details>
</div>

Witamy w oficjalnych przykładach kodu i demonstracjach dla [Protokołu Agent2Agent (A2A)](https://goo.gle/a2a).

Cieszymy się, że tu jesteś! Niezależnie od tego, czy po raz pierwszy poznajesz architektury wieloagentowe, czy budujesz zaawansowane, interoperacyjne sieci agentów, to repozytorium dostarcza prostych, inspirujących i przystępnych materiałów edukacyjnych, które przyspieszą Twój rozwój.

## Dlaczego Agent2Agent?

W świecie różnorodnych frameworków i ekosystemów AI agenci potrzebują wspólnego języka, aby komunikować się, współpracować i bezpiecznie delegować zadania. Protokół A2A ustanawia ustandaryzowany, otwarty standard interoperacyjności wieloagentowej.

Nasze przykłady pokazują, jak łatwo można rozwiązywać złożone problemy wieloagentowe w różnych językach i aplikacjach hostujących.

## Szybki Start

Uruchom wszystko natychmiast, startując agenta Helloworld i komunikując się z nim za pomocą naszego hosta CLI w Pythonie.

1. **Uruchom serwer Agenta**:
   Otwórz terminal i uruchom serwer agenta Helloworld:

   ```bash
   cd samples/python/agents/helloworld
   uv run .
   ```

2. **Uruchom klienta hosta**:
   Otwórz drugie okno terminala i uruchom klienta CLI, aby wysłać zadanie do agenta:

   ```bash
   cd samples/python/agents/helloworld
   uv run test_client.py
   ```

## Struktura repozytorium

Repozytorium jest zorganizowane w kilka kluczowych katalogów według języka programowania:

| Katalog | Opis |
| --- | --- |
| [samples](/samples) | Główne przykłady A2A uporządkowane według języka programowania. |
| [samples/python](/samples/python) | Przykłady implementacji agenta w Pythonie z użyciem A2A Python SDK. |
| [samples/go](/samples/go) | Przykłady implementacji agenta w Go z użyciem A2A Go SDK. |
| [samples/dotnet](/samples/dotnet) | Przykłady implementacji agenta w C# z użyciem A2A .NET SDK. |
| [samples/java](/samples/java) | Przykłady implementacji agenta w Javie z użyciem A2A Java SDK. |
| [samples/js](/samples/js) | Przykłady implementacji agenta w Node.js z użyciem A2A JavaScript SDK. |

## Wkład w projekt

Zachęcamy do współtworzenia projektu, niezależnie od poziomu umiejętności! Jeśli masz pomysł na nowy przykład, poprawkę błędu lub ulepszenie dokumentacji, zapoznaj się z naszym [Przewodnikiem dla współtwórców](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Uzyskiwanie pomocy

Dbamy o zapewnienie przyjaznej i wspierającej społeczności. Jeśli masz pytania, uwagi lub napotkasz problemy, skontaktuj się z nami na naszej [stronie zgłaszania problemów](https://github.com/a2aproject/a2a-samples/issues).

## Powiązane repozytoria

| Repozytorium | Kategoria | Opis |
| --- | --- | --- |
| [A2A](https://github.com/a2aproject/A2A) | Specyfikacja główna | Specyfikacja A2A i dokumentacja. |
| [a2a-inspector](https://github.com/a2aproject/a2a-inspector) | Narzędzia | Narzędzie UI do inspekcji agentów zgodnych z A2A. |
| [a2a-tck](https://github.com/a2aproject/a2a-tck) | Testowanie | Zestaw testów weryfikujących zgodność z protokołem A2A. |
| [a2a-itk](https://github.com/a2aproject/a2a-itk) | Testowanie | Narzędzia do weryfikacji kompatybilności różnych implementacji SDK A2A i wersji, z użyciem modelu wieloprzeskokowego oraz różnych protokołów transportowych. |
| [a2a-python](https://github.com/a2aproject/a2a-python) | SDK (Python) | Oficjalny SDK Python dla A2A. |
| [a2a-go](https://github.com/a2aproject/a2a-go) | SDK (Go) | Oficjalny SDK Go dla A2A. |
| [a2a-java](https://github.com/a2aproject/a2a-java) | SDK (Java) | Oficjalny SDK Java dla A2A. |
| [a2a-js](https://github.com/a2aproject/a2a-js) | SDK (JavaScript) | Oficjalny SDK Node.js/JavaScript dla A2A. |
| [a2a-dotnet](https://github.com/a2aproject/a2a-dotnet) | SDK (C#/.NET) | Oficjalny SDK C#/.NET dla A2A. |
| [a2a-rs](https://github.com/a2aproject/a2a-rs) | SDK (Rust) | Oficjalny SDK Rust dla A2A. |

## Zastrzeżenie

**Ważne:** Przykładowy kod udostępniony służy celom demonstracyjnym i ilustruje mechanikę
Protokół Agent-to-Agent (A2A). Podczas tworzenia aplikacji produkcyjnych kluczowe jest traktowanie każdego agenta działającego poza Twoją bezpośrednią kontrolą jako potencjalnie nieufnej jednostki.

Wszystkie dane otrzymane od zewnętrznego agenta — w tym m.in. jego AgentCard, wiadomości,
artefakty i statusy zadań — powinny być traktowane jako nieufne dane wejściowe. Na przykład, złośliwy agent
może dostarczyć AgentCard zawierający spreparowane dane w swoich polach (np. opis, nazwa,
skills.description). Jeśli te dane zostaną użyte bez sanitizacji do konstrukcji promptów dla dużego
modelu językowego (LLM), może to narazić Twoją aplikację na ataki typu prompt injection. Niezastosowanie
właściwej walidacji i sanitizacji tych danych przed użyciem może wprowadzić luki bezpieczeństwa do
Twojej aplikacji.

> Programiści są odpowiedzialni za wdrożenie odpowiednich środków bezpieczeństwa, takich jak walidacja danych wejściowych
> oraz bezpieczne zarządzanie poświadczeniami w celu ochrony swoich systemów i użytkowników.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-21

---