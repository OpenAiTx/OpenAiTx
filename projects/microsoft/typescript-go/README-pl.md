# TypeScript 7

[Nie wiesz, co to jest? Przeczytaj wpis ogłaszający!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Wersja zapoznawcza

Wersja zapoznawcza jest dostępna na npm jako `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Używaj tego jak tsc.
```

Wersja zapoznawcza rozszerzenia VS Code jest [dostępna w marketplace VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Aby z tego korzystać, ustaw w ustawieniach VS Code:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Jak zbudować i uruchomić

To repozytorium używa [Go 1.24 lub wyższego](https://go.dev/dl/), [Rust 1.85 lub wyższego](https://www.rust-lang.org/tools/install), [Node.js z npm](https://nodejs.org/) oraz [`hereby`](https://www.npmjs.com/package/hereby).

Do testów i generowania kodu repozytorium zawiera podmoduł git do głównego repozytorium TypeScript wskazujący na commit, który jest portowany.
Podczas klonowania najlepiej sklonować z podmodułami:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Jeśli już sklonowałeś repozytorium, możesz zainicjować podmoduł poleceniem:

```sh
git submodule update --init --recursive
```

Po dodaniu podmodułu i wykonaniu `npm ci`, możesz uruchamiać zadania za pomocą `hereby`, podobnie jak w repozytorium TypeScript:

```sh
hereby build          # Sprawdź, czy projekt się buduje
hereby test           # Uruchom wszystkie testy
hereby install-tools  # Zainstaluj dodatkowe narzędzia, np. lintery
hereby lint           # Uruchom wszystkie lintery
hereby format         # Sformatuj cały kod
hereby generate       # Wygeneruj cały kod Go (np. diagnostyka, zatwierdzona do repo)
```

Dodatkowe zadania są w trakcie opracowywania.

`hereby` nie jest wymagany do pracy z repozytorium; zwykłe narzędzia `go` (np. `go build`, `go test ./...`) będą działać zgodnie z oczekiwaniami.
Zadania `hereby` są dostępne dla wygody osób zaznajomionych z repozytorium TypeScript.

### Uruchamianie `tsgo`

Po wykonaniu `hereby build` możesz uruchomić `built/local/tsgo`, które zachowuje się prawie tak samo jak `tsc`.

### Uruchamianie prototypu LSP

Aby debugować i uruchomić rozszerzenie VS Code bez instalowania go globalnie:

* Uruchom VS Code w katalogu repozytorium (`code .`)
* Skopiuj `.vscode/launch.template.json` do `.vscode/launch.json`
* <kbd>F5</kbd> (lub `Debug: Start Debugging` z palety poleceń)

Spowoduje to uruchomienie nowej instancji VS Code, która używa Corsa LS jako backendu. Jeśli wszystko jest poprawnie skonfigurowane, powinieneś zobaczyć "tsgo" na pasku stanu po otwarciu pliku TypeScript lub JavaScript:

![Zrzut ekranu prototypu LSP](.github/ls-screenshot.png)


## Co działa do tej pory?

To nadal projekt w toku i nie osiągnął jeszcze pełnej zgodności funkcjonalnej z TypeScript. Mogą występować błędy. Proszę sprawdzić tę listę przed zgłoszeniem nowego problemu lub założeniem, że zaszła zamierzona zmiana.

| Funkcja | Status | Uwagi |
|---------|--------|-------|
| Tworzenie programu | done | Takie same pliki i rozwiązywanie modułów jak TS5.8. Nie wszystkie tryby rozwiązywania obsługiwane. |
| Parsowanie/skanowanie | done | Dokładnie te same błędy składniowe co TS5.8 |
| Wiersz poleceń i parsowanie `tsconfig.json` | mostly done | Punkt wejścia tymczasowo nieco inny |
| Rozwiązywanie typów | done | Takie same typy jak TS5.8 |
| Sprawdzanie typów | done | Takie same błędy, lokalizacje i komunikaty jak TS5.8. Printback typów w błędach może być inny (w trakcie) |
| Wnioskowanie specyficzne dla JavaScript i JS Doc | not ready | - |
| JSX | done | - |
| Emitowanie deklaracji | in progress | Najczęstsze funkcje obsługiwane, ale niektóre przypadki brzegowe i flagi funkcji jeszcze nie |
| Emitowanie (wyjście JS) | in progress | `target: esnext` dobrze obsługiwany, inne mogą mieć braki |
| Tryb watch | prototype | Obserwuje pliki i przebudowuje, ale bez przyrostowego sprawdzania |
| Tryb build / referencje projektów | not ready | - |
| Budowa przyrostowa | not ready | - |
| Serwis językowy (LSP) | prototype | Minimalna funkcjonalność (błędy, podpowiedzi, przejdź do definicji). Więcej funkcji wkrótce |
| API | not ready | - |

Definicje:

 * **done** czyli „uważane za ukończone”: Nie jesteśmy obecnie świadomi żadnych braków lub większych prac do wykonania. Można zgłaszać błędy
 * **in progress**: obecnie rozwijane; niektóre funkcje mogą działać, inne nie. Można zgłaszać panic, ale nic więcej prosimy
 * **prototype**: tylko proof-of-concept; nie zgłaszać błędów
 * **not ready**: albo nawet nie zaczęte, albo na tyle daleko od gotowości, że nie warto się tym teraz zajmować

## Inne uwagi

Docelowo spodziewamy się, że to repozytorium i jego zawartość zostaną scalone z `microsoft/TypeScript`.
W rezultacie repozytorium i tracker problemów typescript-go zostaną ostatecznie zamknięte, więc traktuj dyskusje/problemy odpowiednio.

Listę zamierzonych zmian względem TypeScript 5.7 znajdziesz w CHANGES.md.

## Współtworzenie

Ten projekt zachęca do współtworzenia i sugestii. Większość kontrybucji wymaga zaakceptowania
Umowy Licencyjnej Współtwórcy (CLA), deklarującej, że masz prawo do przekazania kontrybucji i rzeczywiście to robisz,
przyznając nam prawo do jej wykorzystania. Szczegóły znajdziesz na stronie [Contributor License Agreements](https://cla.opensource.microsoft.com).

Gdy wysyłasz pull request, bot CLA automatycznie sprawdzi, czy musisz wypełnić CLA i odpowiednio oznaczy PR (np. status check, komentarz). Po prostu postępuj zgodnie z instrukcjami
przekazanymi przez bota. Musisz to zrobić tylko raz dla wszystkich repozytoriów korzystających z naszego CLA.

Projekt przyjął [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Więcej informacji znajdziesz w [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) lub
kontaktując się pod adresem [opencode@microsoft.com](mailto:opencode@microsoft.com) w przypadku dodatkowych pytań lub uwag.

## Znaki towarowe

Projekt może zawierać znaki towarowe lub logotypy projektów, produktów lub usług. Użycie znaków towarowych lub logotypów Microsoft jest dozwolone i musi być zgodne z
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Użycie znaków towarowych lub logotypów Microsoft w zmodyfikowanych wersjach projektu nie może powodować dezorientacji ani sugerować sponsorowania przez Microsoft.
Użycie znaków towarowych lub logotypów stron trzecich podlega polityce tych stron.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---