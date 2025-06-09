![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md)

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Przewodnik

NoteGen to wieloplatformowa aplikacja do robienia notatek w formacie `Markdown`, która wykorzystuje AI do łączenia rejestrowania i pisania, organizując rozproszoną wiedzę w czytelną notatkę.

🖥️ Oficjalna dokumentacja: [https://notegen.top](https://notegen.top)

💬 Dołącz do [Grupy WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Dlaczego warto wybrać NoteGen?

- Lekkość: [Paczka instalacyjna](https://github.com/codexu/note-gen/releases) ma **tylko 20MB**, darmowa, bez reklam i dodatkowego oprogramowania.
- Wieloplatformowość: Obsługuje Mac, Windows, Linux, a dzięki możliwościom wieloplatformowym `Tauri2` w przyszłości będzie wspierać także iOS i Androida.
- Obsługuje wiele metod rejestrowania, w tym `zrzuty ekranu`, `tekst`, `ilustracje`, `pliki`, `linki` itd., spełniając potrzeby fragmentarycznego rejestrowania w różnych scenariuszach.
- Natywne `Markdown(.md)` jako format przechowywania, bez modyfikacji, łatwy do migracji.
- Natywna praca offline, wsparcie dla synchronizacji w czasie rzeczywistym do `GitHub, prywatnych repozytoriów Gitee` z możliwością cofania historii oraz synchronizacji przez WebDAV.
- Wzbogacenie AI: Możliwość konfiguracji z ChatGPT, Gemini, Ollama, LM Studio, Grok i innymi modelami, z obsługą własnych modeli zewnętrznych.
- RAG: Twoje notatki to Twoja baza wiedzy. Obsługa modeli embedujących oraz rerankingowych.

## Zrzuty ekranu

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Rejestrowanie:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Pisanie:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Motyw:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## Od rejestrowania do pisania

Tradycyjne aplikacje do notatek zazwyczaj nie oferują funkcji rejestrowania. Użytkownicy muszą ręcznie kopiować i wklejać treści, co znacznie obniża wydajność. W przypadku rozproszonej zawartości zapisanej, wymaga to dużego nakładu pracy przy organizacji.

NoteGen jest podzielony na strony `Rejestrowanie` i `Pisanie`, których relacja wygląda następująco:

- Zarejestrowane treści można organizować w notatki i przenosić na stronę pisania w celu pogłębionej redakcji.
- Podczas pisania możesz w każdej chwili wstawiać zapisane treści.

### Rejestrowanie

Funkcja rejestrowania jest podobna do **czatbota AI**, ale podczas rozmowy można kojarzyć ją z wcześniej zapisanymi treściami, przechodząc z trybu rozmowy do trybu organizacji, aby ułożyć rejestry w czytelną notatkę.

Następujące funkcje pomocnicze pomogą Ci skuteczniej rejestrować:

- **Tagi** pozwalające rozróżnić różne scenariusze rejestrowania.
- **Persony** z obsługą własnych promptów do precyzyjnego sterowania asystentem AI.
- **Asystent schowka** automatycznie rozpoznający tekst lub obrazy w schowku i zapisujący je na Twojej liście.

### Pisanie

Część pisania podzielona jest na dwie sekcje: **Menedżer plików** i **Edytor Markdown**.

**Menedżer plików**

- Obsługa zarządzania lokalnymi plikami Markdown oraz plikami synchronizowanymi z GitHub.
- Obsługa nieograniczonej hierarchii katalogów.
- Wiele metod sortowania.

**Edytor Markdown**

- Obsługa WYSIWYG, renderowania natychmiastowego oraz podglądu podzielonego na ekranie.
- Obsługa kontroli wersji z możliwością cofania historii.
- Obsługa asysty AI dla rozmowy, kontynuacji, redagowania i tłumaczenia.
- Obsługa hostingu obrazów, przesyłania obrazów i konwersji ich do linków Markdown.
- Obsługa konwersji HTML do Markdown, automatyczna konwersja kopiowanej zawartości przeglądarki do formatu Markdown.
- Obsługa konspektów, formuł matematycznych, map myśli, wykresów, diagramów przepływu, wykresów Gantta, diagramów sekwencji, pięciolinii, multimediów, czytania głosowego, kotwic tytułowych, podświetlania i kopiowania kodu, renderowania graphviz i diagramów UML plantuml.
- Obsługa zapisywania treści lokalnie w czasie rzeczywistym, opóźnionej (10s bez edycji) automatycznej synchronizacji oraz cofania historii.

## Inne funkcje

- Wyszukiwanie globalne umożliwiające szybkie znajdowanie i przechodzenie do określonych treści.
- Zarządzanie hostingiem obrazów dla wygodnego zarządzania zawartością repozytorium obrazów.
- Motywy i wygląd z obsługą ciemnych motywów i ustawień wyglądu dla Markdown, kodu itd.
- Wsparcie dla internacjonalizacji, obecnie dostępne w języku chińskim i angielskim.

## Jak używać?

### Pobierz

Obecnie obsługuje Mac, Windows i Linux. Dzięki możliwościom Tauri2 w przyszłości będzie wspierać także iOS i Androida.

[Pobierz NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Rozszerzenie

Aplikacja do notatek może być używana bezpośrednio bez konfiguracji. Jeśli chcesz lepszych wrażeń, otwórz stronę ustawień, aby skonfigurować AI i synchronizację.

## Współtwórz

- [Przeczytaj przewodnik dla współtwórców](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Plany rozwoju](https://github.com/codexu/note-gen/issues/46)
- [Zgłaszaj błędy lub sugestie ulepszeń](https://github.com/codexu/note-gen/issues)
- [Dyskusje](https://github.com/codexu/note-gen/discussions)

## Współtwórcy

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---