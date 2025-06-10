# Gantt

## Instalacja

```
yarn install
```

### Uruchomienie

```
yarn run serve
```

### Opis

```
Gantt oparty na vue, umożliwiający wizualizację wykresu Gantta, może być używany do współpracy zespołowej, podziału zadań i innych scenariuszy zwinnych.

Obsługuje grupowanie
Obsługuje przeciąganie
Obsługuje rozciąganie
Obsługuje procenty
Obsługuje zakresy czasowe: dzień, tydzień, miesiąc
Obecnie obsługiwana jest tylko grupowanie jednopoziomowe. Aby uniknąć problemów z przyszłym zapotrzebowaniem na grupowanie dwu- lub wielopoziomowe, w ostatnim commicie część kodu została zrefaktoryzowana, by obsługiwać wielopoziomowe grupowanie, jednak w obecnej wersji nie zostało ono jeszcze rozwinięte.

Zalety: podczas przeciągania, rozciągania, zmiany postępu itp. dane nie są aktualizowane na bieżąco, lecz po zakończeniu operacji, co ogranicza zużycie zasobów.
      Podczas edycji, usuwania, dodawania nie jest rekurencyjnie modyfikowana cała instancja, lecz tylko zmieniana, dodawana lub usuwana jest odpowiednia część.

Trwają przygotowania do reorganizacji pod komponentyzację. Aktualnie, aby użyć w swoim projekcie, wystarczy zaimportować plik `gant.vue` z tego repozytorium.
Metody importu i eksportu danych zbiorczych są już napisane – można je po prostu skopiować!~

```

### Informacje o aktualizacjach

- Obsługa edycji
- Obsługa usuwania
- Naprawiono błąd uniemożliwiający przewijanie w pionie (dodano jednoczesne przewijanie w obu kierunkach) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Naprawiono błąd wywołany przez elementUI
- Kwestia zakresu czasowego [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Obecnie nie można uzyskać innych zakresów (np. godzinowego) poprzez zmianę konfiguracji. Niektóre ustawienia są na stałe zdefiniowane podczas inicjalizacji. W przyszłości zostanie to zmienione i udostępnione jako API.

### Zobacz przykład

Zobacz [demo](https://ggbeng1.github.io/Gantt/#/)

### Zrzut ekranu

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---