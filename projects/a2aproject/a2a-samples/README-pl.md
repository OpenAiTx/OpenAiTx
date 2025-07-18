# Przykłady Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

To repozytorium zawiera przykłady kodu i dema wykorzystujące [Protokół Agent2Agent (A2A)](https://goo.gle/a2a).

## Powiązane repozytoria

- [A2A](https://github.com/a2aproject/A2A) - Specyfikacja A2A i dokumentacja.
- [a2a-python](https://github.com/a2aproject/a2a-python) - SDK A2A dla Pythona.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) - Narzędzie UI do inspekcji agentów obsługujących A2A.

## Współtworzenie

Wkład mile widziany! Zobacz [Przewodnik współtworzenia](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Uzyskiwanie pomocy

Prosimy korzystać z [zakładki issues](https://github.com/a2aproject/a2a-samples/issues), aby zgłaszać sugestie, uwagi lub raportować błędy.

## Zastrzeżenie

To repozytorium nie jest oficjalnie wspieranym produktem Google. Kod w tym repozytorium służy wyłącznie celom demonstracyjnym.

Ważne: Przykładowy kod ma charakter demonstracyjny i ilustruje mechanikę działania protokołu Agent-to-Agent (A2A). Tworząc aplikacje produkcyjne, należy traktować każdego agenta działającego poza bezpośrednią kontrolą jako potencjalnie nieufne źródło.

Wszelkie dane otrzymywane od zewnętrznego agenta — w tym m.in. AgentCard, wiadomości, artefakty i statusy zadań — powinny być traktowane jako dane nieufne. Przykładowo, złośliwy agent może dostarczyć AgentCard z przygotowanymi danymi w polach (np. opis, nazwa, skills.description). Jeśli dane te zostaną użyte bez sanitizacji do budowy promptów dla dużego modelu językowego (LLM), mogą narazić Twoją aplikację na ataki typu prompt injection. Brak właściwej walidacji i sanitizacji tych danych przed użyciem może wprowadzić luki bezpieczeństwa do Twojej aplikacji.

Programiści są odpowiedzialni za wdrożenie odpowiednich środków bezpieczeństwa, takich jak walidacja wejścia i bezpieczna obsługa poświadczeń, aby chronić swoje systemy i użytkowników.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---