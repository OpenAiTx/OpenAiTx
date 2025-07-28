
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Szczegółowy dokument] https://deepwiki.com/JetXu-LLM/llama-github

[![Wersja PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Pobrania](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licencja](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github to potężne narzędzie, które pomaga wyszukiwać (w oparciu o Agentic RAG) najbardziej istotne fragmenty kodu, zgłoszenia i informacje o repozytorium z GitHub na podstawie Twoich zapytań, przekształcając je w wartościowy kontekst wiedzy. Narzędzie to umożliwia chatbotom LLM, agentom AI oraz Auto-dev Agentom rozwiązywanie złożonych zadań programistycznych. Niezależnie od tego, czy jesteś programistą szukającym szybkich rozwiązań, czy inżynierem wdrażającym zaawansowane Auto Dev AI Agents, llama-github sprawia, że jest to łatwe i wydajne.

Jeśli podoba Ci się ten projekt lub uważasz, że ma on potencjał, prosimy o zostawienie ⭐️. Twoje wsparcie jest dla nas największą motywacją!

## Architektura
![Architektura wysokiego poziomu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalacja
```
pip install llama-github
```

## Użytkowanie

Oto prosty przykład, jak używać llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```

Aby uzyskać bardziej zaawansowane przykłady użycia, zapoznaj się z [dokumentacją](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Kluczowe funkcje

- **🔍 Inteligentne pobieranie z GitHub**: Wykorzystaj moc llama-github do pobierania najbardziej trafnych fragmentów kodu, zgłoszeń i informacji o repozytoriach z GitHub na podstawie zapytań użytkownika. Nasze zaawansowane techniki wyszukiwania zapewniają szybkie i skuteczne znajdowanie najważniejszych informacji.

- **⚡ Pamięć podręczna puli repozytoriów**: Llama-github posiada innowacyjny mechanizm pamięci podręcznej puli repozytoriów. Dzięki buforowaniu repozytoriów (w tym plików README, struktury, kodu i zgłoszeń) między wątkami, llama-github znacznie przyspiesza wydajność wyszukiwania na GitHub i minimalizuje zużycie tokenów API GitHub. Wdrażaj llama-github w środowiskach wielowątkowych bez obaw o wydajność i oszczędność zasobów.

- **🧠 Analiza pytań oparta na LLM**: Skorzystaj z najnowocześniejszych modeli językowych do analizy pytań użytkowników oraz generowania skutecznych strategii i kryteriów wyszukiwania. Llama-github inteligentnie rozkłada złożone zapytania, zapewniając dostęp do najbardziej trafnych informacji z ogromnej sieci repozytoriów GitHub.

- **📚 Kompleksowe generowanie kontekstu**: Generuj bogate, kontekstowo trafne odpowiedzi, płynnie łącząc informacje pobrane z GitHub z możliwościami rozumowania zaawansowanych modeli językowych. Llama-github doskonale radzi sobie nawet z najbardziej złożonymi i długimi pytaniami, dostarczając szczegółowych odpowiedzi wraz z szerokim kontekstem wspierającym Twoje potrzeby programistyczne.

- **🚀 Doskonałość przetwarzania asynchronicznego**: Llama-github został stworzony od podstaw, aby w pełni wykorzystać potencjał programowania asynchronicznego. Dzięki starannie zaimplementowanym mechanizmom asynchronicznym w całej bazie kodu, llama-github obsługuje wiele żądań jednocześnie, znacząco zwiększając wydajność. Przekonaj się, jak efektywnie zarządza dużym obciążeniem bez utraty szybkości i jakości.

- **🔧 Elastyczna integracja z LLM**: Łatwo integruj llama-github z różnymi dostawcami LLM, modelami embedding i reranking, dostosowując możliwości biblioteki do własnych wymagań. Nasza rozszerzalna architektura pozwala na personalizację i rozbudowę funkcjonalności llama-github, dzięki czemu płynnie dopasuje się do Twojego środowiska deweloperskiego.

- **🔒 Solidne opcje uwierzytelniania**: Llama-github obsługuje zarówno tokeny dostępu osobistego, jak i uwierzytelnianie za pomocą GitHub App, dając elastyczność integracji w różnych środowiskach programistycznych. Niezależnie od tego, czy jesteś indywidualnym deweloperem, czy pracujesz w organizacji, llama-github zapewnia bezpieczne i niezawodne mechanizmy uwierzytelniania.

- **🛠️ Logowanie i obsługa błędów**: Rozumiemy, jak ważna jest płynna obsługa i łatwe rozwiązywanie problemów. Dlatego llama-github wyposażony jest w kompleksowy system logowania i obsługi błędów. Uzyskaj wgląd w działanie biblioteki, szybko diagnozuj problemy i utrzymuj stabilny oraz niezawodny workflow deweloperski.

## 🤖 Wypróbuj naszego AI-asystenta do przeglądu PR: LlamaPReview

Jeśli uważasz, że llama-github jest przydatny, może zainteresuje Cię także nasz AI-asystent do przeglądu PR na GitHub, LlamaPReview. Został zaprojektowany, by uzupełnić Twój workflow programistyczny i dodatkowo poprawić jakość kodu.

### Kluczowe funkcje LlamaPReview:
- 🚀 Instalacja jednym kliknięciem, zero konfiguracji, pełna automatyzacja
- 💯 Obecnie darmowy - nie wymaga karty ani płatności
- 🧠 Automatyczne, AI-napędzane przeglądy PR z głębokim zrozumieniem kodu
- 🌐 Obsługa wielu języków programowania

**LlamaPReview wykorzystuje zaawansowane pobieranie kontekstu oraz analizę LLM z llama-github**, by zapewnić inteligentne, kontekstowe przeglądy kodu. To jakbyś miał starszego programistę, który zna cały kontekst repozytorium i automatycznie przegląda każdy PR!

👉 [Zainstaluj LlamaPReview teraz](https://github.com/marketplace/llamapreview/) (Darmowe)

Korzystając z llama-github do pobierania kontekstu i LlamaPReview do przeglądów kodu, tworzysz potężne, AI-wspierane środowisko deweloperskie.

## Wizja i plan rozwoju

### Wizja

Naszą wizją jest stać się kluczowym modułem w przyszłości rozwiązań opartych na AI, integrującym się z GitHub w celu umożliwienia LLM automatycznego rozwiązywania złożonych zadań programistycznych.

![Architektura wizji](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Plan rozwoju

Aby zobaczyć szczegółowy plan rozwoju projektu, odwiedź nasz [Project Roadmap](https://github.com/users/JetXu-LLM/projects/2).

## Podziękowania

Chcielibyśmy podziękować następującym projektom open-source za ich wsparcie i wkład:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Za dostarczenie podstawowego frameworka, który umożliwia wywoływanie i przetwarzanie LLM w llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Za udostępnienie API s.jina.ai oraz otwartoźródłowych modeli rerankera i embedding, które zwiększają trafność i dokładność generowanych kontekstów w llama-github.

Ich wkład był kluczowy dla rozwoju llama-github i gorąco polecamy ich projekty, jeśli szukasz innowacyjnych rozwiązań.

## Wkład w projekt

Zachęcamy do współtworzenia llama-github! Zapoznaj się z [wytycznymi dla kontrybutorów](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md), by dowiedzieć się więcej.

## Licencja

Ten projekt jest licencjonowany na zasadach licencji Apache 2.0. Szczegóły znajdziesz w pliku [LICENSE](LICENSE).

## Kontakt

W razie pytań, sugestii lub opinii, skontaktuj się z nami na [e-mail Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Dziękujemy za wybór llama-github! Mamy nadzieję, że biblioteka ulepszy Twoje doświadczenia z AI i pomoże Ci tworzyć potężne aplikacje z łatwością.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---