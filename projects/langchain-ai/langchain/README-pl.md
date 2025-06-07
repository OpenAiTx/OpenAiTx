<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain Logo" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Release Notes](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - License](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub star chart](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Open Issues](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Open in Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Open in Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> Szukasz biblioteki JS/TS? Zobacz [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain to framework do budowania aplikacji opartych na LLM. Umożliwia łączenie
ze sobą interoperacyjnych komponentów i integracji zewnętrznych, upraszczając
tworzenie aplikacji AI — a jednocześnie chroniąc przed szybkimi zmianami
technologicznymi.

```bash
pip install -U langchain
```

Aby dowiedzieć się więcej o LangChain, zobacz
[dokumentację](https://python.langchain.com/docs/introduction/). Jeśli szukasz
bardziej zaawansowanych opcji dostosowywania lub orkiestracji agentów, sprawdź
[LangGraph](https://langchain-ai.github.io/langgraph/), nasz framework do budowania
kontrolowanych przepływów pracy agentów.

## Dlaczego warto używać LangChain?

LangChain pomaga programistom budować aplikacje zasilane LLM, oferując standardowy
interfejs dla modeli, embeddingów, baz wektorowych i innych komponentów.

Używaj LangChain do:
- **Augmentacji danych w czasie rzeczywistym**. Łatwo łącz LLM z różnorodnymi źródłami danych oraz
zewnętrznymi i wewnętrznymi systemami, korzystając z bogatej biblioteki integracji LangChain
z dostawcami modeli, narzędziami, bazami wektorowymi, retrieverami i innymi.
- **Interoperacyjności modeli**. Wymieniaj modele w miarę jak Twój zespół inżynierski
eksperymentuje, szukając najlepszego rozwiązania dla potrzeb Twojej aplikacji. Gdy branża
się rozwija, dostosowuj się szybko — abstrakcje LangChain umożliwiają ciągły rozwój
bez utraty tempa.

## Ekosystem LangChain
Chociaż framework LangChain można używać samodzielnie, integruje się on też płynnie
z każdym produktem LangChain, dając programistom pełen zestaw narzędzi do budowy aplikacji LLM.

Aby usprawnić budowę aplikacji LLM, połącz LangChain z:

- [LangSmith](http://www.langchain.com/langsmith) – Pomocny przy ewaluacji agentów i
obserwowalności. Debuguj słabo działające uruchomienia aplikacji LLM, oceniaj trajektorie agentów,
uzyskuj wgląd w produkcję i poprawiaj wydajność w czasie.
- [LangGraph](https://langchain-ai.github.io/langgraph/) – Buduj agentów, którzy mogą
niezawodnie obsługiwać złożone zadania z LangGraph, naszym niskopoziomowym frameworkiem do orkiestracji agentów.
LangGraph oferuje konfigurowalną architekturę, pamięć długoterminową oraz
przepływy pracy z udziałem człowieka — i jest wykorzystywany produkcyjnie przez firmy takie jak LinkedIn,
Uber, Klarna i GitLab.
- [LangGraph Platform](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) – Wdrażaj
i skaluj agentów bez wysiłku dzięki dedykowanej platformie wdrożeniowej dla długotrwałych, stanowych przepływów pracy.
Odkrywaj, wykorzystuj ponownie, konfiguruj i udostępniaj agentów w zespołach — oraz szybko iteruj dzięki wizualnemu prototypowaniu w
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Dodatkowe zasoby
- [Samouczki](https://python.langchain.com/docs/tutorials/): Proste przewodniki z
przykładami krok po kroku na temat rozpoczynania pracy z LangChain.
- [Przewodniki „Jak to zrobić”](https://python.langchain.com/docs/how_to/): Szybkie, praktyczne fragmenty kodu
dotyczące takich tematów jak wywoływanie narzędzi, przypadki użycia RAG i inne.
- [Przewodniki koncepcyjne](https://python.langchain.com/docs/concepts/): Wyjaśnienia kluczowych
koncepcji stojących za frameworkiem LangChain.
- [Dokumentacja API](https://python.langchain.com/api_reference/): Szczegółowy opis
poruszania się po pakietach bazowych i integracjach dla LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---