
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
      </div>
    </div>
  </details>
</div>

# llama-github

[Szczegółowy dokument] https://deepwiki.com/JetXu-LLM/llama-github

[![Wersja PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Pobrania](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Licencja](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github to zaawansowane narzędzie, które pomaga pobierać (w oparciu o Agentic RAG) najbardziej istotne fragmenty kodu, zgłoszenia i informacje o repozytoriach z GitHub na podstawie zapytań, przekształcając je w wartościowy kontekst wiedzy. Umożliwia chatbotom LLM, agentom AI oraz agentom Auto-dev rozwiązywanie złożonych zadań programistycznych. Niezależnie czy jesteś deweloperem szukającym szybkich rozwiązań, czy inżynierem wdrażającym zaawansowanych agentów Auto Dev AI, llama-github sprawia, że jest to proste i wydajne.

Jeśli podoba Ci się ten projekt lub uważasz, że ma potencjał, prosimy o przyznanie mu ⭐️. Twoje wsparcie jest dla nas największą motywacją!

## Architektura
![Architektura wysokiego poziomu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Instalacja
```
pip install llama-github
```

Aktualnie obsługiwany cel środowiska uruchomieniowego: Python `3.10+`.

## Użycie

Oto prosty przykład użycia llama-github:

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` zwraca listę słowników kontekstowych. Każdy element zawiera co najmniej `context` i `url`.

Aby uzyskać bardziej zaawansowane zastosowania i przykłady, zapoznaj się z [dokumentacją](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Przykłady gotowe do uruchomienia i niskokosztowe są dostępne także w [`examples/`](examples).

## Kluczowe cechy

- **🔍 Inteligentne pobieranie z GitHub**: Wykorzystaj moc llama-github do wyszukiwania najbardziej istotnych fragmentów kodu, zgłoszeń i informacji o repozytorium z GitHub na podstawie zapytań użytkownika. Nasze zaawansowane techniki pobierania zapewniają szybkie i efektywne odnajdywanie najtrafniejszych informacji.

- **⚡ Pamięć podręczna puli repozytoriów**: Llama-github posiada innowacyjny mechanizm pamięci podręcznej puli repozytoriów. Dzięki buforowaniu repozytoriów (w tym plików README, struktur, kodu i zgłoszeń) pomiędzy wątkami, llama-github znacząco przyspiesza efektywność wyszukiwania na GitHub i minimalizuje zużycie tokenów API GitHub.

- **🧠 Analiza pytań wspierana przez LLM**: Wykorzystaj najnowocześniejsze modele językowe do analizy pytań użytkownika i generowania skutecznych strategii oraz kryteriów wyszukiwania. Llama-github inteligentnie rozbija złożone zapytania, gwarantując pobranie najbardziej relewantnych informacji z obszernej sieci repozytoriów GitHub.

- **📚 Kompleksowe generowanie kontekstu**: Twórz bogate, kontekstowo trafne odpowiedzi poprzez płynne łączenie informacji pobranych z GitHub z możliwościami rozumowania zaawansowanych modeli językowych. Llama-github doskonale radzi sobie nawet z najbardziej złożonymi i rozbudowanymi pytaniami, dostarczając pełne i wnikliwe odpowiedzi zawierające szeroki kontekst wspierający Twoje potrzeby developerskie.

- **🚀 Doskonałość asynchronicznego przetwarzania**: Llama-github od podstaw został zbudowany z myślą o pełnym wykorzystaniu potencjału programowania asynchronicznego. Dzięki starannie zaimplementowanym mechanizmom asynchronicznym w całej bazie kodu, llama-github może obsługiwać wiele żądań jednocześnie, znacząco zwiększając ogólną wydajność.

- **🔧 Elastyczna integracja z LLM**: Łatwo zintegruj llama-github z różnymi dostawcami LLM, modelami embeddingowymi, modelami rerankingu lub wstrzykniętym modelem czatu zgodnym z LangChain, aby dostosować możliwości biblioteki do swoich konkretnych wymagań.

- **🔒 Solidne opcje uwierzytelniania**: Llama-github obsługuje zarówno tokeny dostępu osobistego, jak i uwierzytelnianie przez GitHub App, zapewniając elastyczność integracji w różnych środowiskach programistycznych. Niezależnie czy jesteś indywidualnym deweloperem, czy pracujesz w organizacji, llama-github zapewni bezpieczne i niezawodne mechanizmy uwierzytelniania.

- **🛠️ Logowanie i obsługa błędów**: Rozumiemy, jak ważne są płynne operacje i łatwe rozwiązywanie problemów. Dlatego llama-github jest wyposażony w rozbudowane mechanizmy logowania i obsługi błędów. Uzyskaj wgląd w działanie biblioteki, szybko diagnozuj problemy i utrzymuj stabilny oraz niezawodny przebieg pracy.

## 🤖 Wypróbuj naszego asystenta przeglądu PR wspieranego przez AI: LlamaPReview

Jeśli llama-github jest dla Ciebie przydatny, możesz być również zainteresowany naszym asystentem do przeglądu PR na GitHub opartym na AI, LlamaPReview. Został on zaprojektowany jako uzupełnienie Twojego procesu programistycznego i dalsze podniesienie jakości kodu.

### Kluczowe cechy LlamaPReview:
- 🚀 Instalacja jednym kliknięciem, bez konfiguracji, pełna automatyzacja
- 💯 Obecnie darmowy – nie wymaga karty kredytowej ani informacji o płatności
- 🧠 Przeglądy PR oparte na AI, automatyczne, z głębokim zrozumieniem kodu
- 🌐 Wsparcie dla wielu języków programowania

**LlamaPReview wykorzystuje zaawansowane pobieranie kontekstu i analizę LLM z llama-github**, by dostarczać inteligentne, świadome kontekstu przeglądy kodu. To jak posiadanie starszego dewelopera, który automatycznie i z pełnym kontekstem repozytorium sprawdza każdy PR!

👉 [Zainstaluj LlamaPReview teraz](https://github.com/marketplace/llamapreview/) (Darmowe)

Korzystając z llama-github do pobierania kontekstu i LlamaPReview do przeglądów kodu, możesz stworzyć potężne, wspierane przez AI środowisko developerskie.

## Wizja i plan rozwoju


### Wizja

Naszą wizją jest stać się kluczowym modułem w przyszłości rozwiązań rozwojowych opartych na AI, płynnie integrującym się z GitHub w celu umożliwienia LLM automatycznego rozwiązywania złożonych zadań programistycznych.

![Architektura Wizji](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Plan rozwoju

Aby zobaczyć historyczną wersję wcześniejszego planu rozwoju, odwiedź [Wizja i Plan rozwoju](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Podziękowania

Chcielibyśmy wyrazić wdzięczność następującym projektom open-source za ich wsparcie i wkład:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Za dostarczenie podstawowego frameworka, który umożliwia wywoływanie LLM i przetwarzanie danych w llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Za udostępnienie API s.jina.ai oraz open source rerankera i modeli embeddingowych, które zwiększają dokładność i trafność generowanych kontekstów w llama-github.

Ich wkład był kluczowy w rozwoju llama-github i gorąco polecamy zapoznać się z ich projektami, aby znaleźć jeszcze więcej innowacyjnych rozwiązań.

## Współpraca

Zapraszamy do współtworzenia llama-github! Więcej informacji znajdziesz w naszych [wytycznych dla współtwórców](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md).

## Licencja

Ten projekt jest licencjonowany na warunkach licencji Apache 2.0. Więcej informacji znajdziesz w pliku [LICENSE](LICENSE).

## Kontakt

W przypadku pytań, sugestii lub uwag prosimy o kontakt pod adresem [email Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Dziękujemy za wybór llama-github! Mamy nadzieję, że ta biblioteka usprawni Twoje doświadczenia z rozwojem AI i pomoże Ci łatwo budować zaawansowane aplikacje.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---