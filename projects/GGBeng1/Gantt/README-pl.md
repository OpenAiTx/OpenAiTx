# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## Instalacja

```
yarn install
```

### Uruchamianie

```
yarn run serve
```

### Opis

```
Wizualizacja wykresu Gantta oparta na vue, może być używana do współpracy zespołowej, podziału zadań i innych scenariuszy zwinnych

Obsługuje grupowanie
Obsługuje przeciąganie
Obsługuje rozciąganie
Obsługuje procentowy postęp
Obsługuje zakresy czasu: dzień, tydzień, miesiąc
Obecnie zaimplementowano tylko grupowanie jednopoziomowe. Aby uniknąć problemów w przyszłości z potrzebą grupowania dwu- lub wielopoziomowego, przy ostatnim commicie przebudowano część kodu, by obsługiwać wielopoziomowe grupowanie, jednak bieżąca wersja nie zawiera tej funkcji

Zalety: Podczas przeciągania, rozciągania, zmiany postępu itp., dane nie są aktualizowane w czasie rzeczywistym, lecz po wykonaniu operacji, co redukuje zużycie zasobów
        Podczas edycji, usuwania, dodawania nie jest wykonywana rekurencyjna modyfikacja całego obiektu, lecz tylko modyfikowanych fragmentów

Trwa reorganizacja projektu, przygotowania do komponentyzacji. Obecnie, aby użyć w projekcie, wystarczy zaimportować `gant.vue` z tego repozytorium
Metody masowego importu i eksportu danych są już gotowe, wystarczy skopiować!~

```

### Informacje o aktualizacji

- Obsługa edycji
- Obsługa usuwania
- Naprawiono błąd braku możliwości przewijania w pionie (dodano jednoczesne przewijanie w dwóch kierunkach) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Naprawiono błąd spowodowany przez elementUI
- Informacje o problemach z zakresem czasu [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Obecnie nie można uzyskać innych zakresów (np. godzin) poprzez zmianę konfiguracji, ponieważ część ustawień jest sztywno ustalona podczas inicjalizacji; w przyszłości zostanie to udostępnione jako API


### Zobacz przykład

Zobacz [demo](https://ggbeng1.github.io/Gantt/#/)

### Przykładowy zrzut ekranu

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---