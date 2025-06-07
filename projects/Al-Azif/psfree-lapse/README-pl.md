# PSFree wersja 1.5.1

PSFree to zbiór exploitów dla konsoli PS4. Głównym celem repozytorium jest PS4, ale staramy się, aby rozwiązania były przenośne także na PS5.

## Funkcje

- **Automatyczne wykrywanie:** Automatycznie wykrywa typ konsoli oraz wersję oprogramowania układowego (przez [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Eksploit WebKit (PSFree):** Punkt wejścia przez przeglądarkę internetową konsoli.
- **Eksploit kernela (Lapse):** Podnosi uprawnienia do poziomu kernela.
- **Ładowarka payloadów:** Po udanym przejęciu kernela nasłuchuje na payload na porcie 9020.

## Zakres podatności

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Wspierane przez to repozytorium

Poniższa tabela wskazuje wersje firmware, dla których _aktualna wersja_ tego repozytorium zapewnia funkcjonalny i przetestowany łańcuch exploitów.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/D       | N/D       |

_Uwaga: Wsparcie dla innych wersji firmware wymienionych w tabeli „Zakres podatności” może być obecnie w trakcie prac lub było dostępne w poprzednich wersjach repozytorium. Sprawdź [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) dla informacji o wsparciu historycznym._

## Lista TODO

- [ ] Problem z czarnym ekranem/zapisywaniem w niektórych grach
- [ ] `lapse.mjs`: Ustaw tylko bity dla uprawnień JIT
- [ ] `view.mjs`: Zakłada PS4, dodać wsparcie dla PS5
- [ ] Dodaj wsparcie dla PS5

## Prawa autorskie i autorzy:

AGPL-3.0-lub-późniejsza (patrz [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). To repozytorium należy do grupy `anonymous`. Odnosimy się do anonimowych współtwórców również jako "anonymous".

## Podziękowania:

- anonymous za zrzuty kernela z oprogramowania PS4
- Sprawdź odpowiednie pliki, aby zobaczyć **dodatkowych** współtwórców. O ile nie zaznaczono inaczej, wszystko tutaj można również przypisać nam.

## Darowizny

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---