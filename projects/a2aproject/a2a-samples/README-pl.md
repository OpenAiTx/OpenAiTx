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

To repozytorium zawiera przykładowy kod i dema wykorzystujące [Protokół Agent2Agent (A2A)](https://goo.gle/a2a).

## Powiązane repozytoria

- [A2A](https://github.com/a2aproject/A2A) - Specyfikacja A2A i dokumentacja.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK A2A dla Pythona.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Narzędzie UI do inspekcji agentów obsługujących A2A.

## Współtworzenie

Zapraszamy do współpracy! Zobacz [Przewodnik dla współtwórców](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Uzyskiwanie pomocy

Użyj [strony zgłaszania problemów](https://github.com/a2aproject/a2a-samples/issues), aby przekazać sugestie, opinie lub zgłosić błąd.

## Zastrzeżenie

To repozytorium nie jest oficjalnie wspieranym produktem Google. Kod w tym repozytorium służy wyłącznie do celów demonstracyjnych.

Ważne: Przykładowy kod jest przeznaczony do celów demonstracyjnych i ilustruje mechanikę protokołu Agent-to-Agent (A2A). Tworząc aplikacje produkcyjne, należy traktować każdego agenta działającego poza Twoją bezpośrednią kontrolą jako potencjalnie nieufne źródło.

Wszelkie dane otrzymane od zewnętrznego agenta – w tym, ale nie tylko, jego AgentCard, wiadomości, artefakty i statusy zadań – powinny być traktowane jako nieufne wejście. Na przykład złośliwy agent może dostarczyć AgentCard zawierający spreparowane dane w polach (np. opis, nazwa, skills.description). Jeśli te dane zostaną użyte bez sanitizacji do budowania promptów dla dużego modelu językowego (LLM), może to narazić Twoją aplikację na ataki typu prompt injection. Brak odpowiedniej walidacji i sanitizacji tych danych przed użyciem może wprowadzić podatności na zagrożenia do Twojej aplikacji.

Programiści są odpowiedzialni za wdrożenie odpowiednich środków bezpieczeństwa, takich jak walidacja wejścia i bezpieczne zarządzanie poświadczeniami w celu ochrony swoich systemów i użytkowników.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---