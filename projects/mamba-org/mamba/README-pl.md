# Mamba: Szybki, wieloplatformowy menedżer pakietów

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">część mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Menedżer pakietów <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Serwer pakietów <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` to ponowna implementacja menedżera pakietów conda w języku C++.

- równoległe pobieranie danych repozytoriów i plików pakietów z wykorzystaniem wielowątkowości
- libsolv dla znacznie szybszego rozwiązywania zależności, nowoczesna biblioteka używana w menedżerze pakietów RPM (Red Hat, Fedora, OpenSUSE)
- kluczowe części `mamba` zaimplementowane są w C++ dla maksymalnej wydajności

Jednocześnie `mamba` korzysta z tego samego parsera wiersza poleceń, kodu instalacji i deinstalacji pakietów oraz procedur weryfikacji transakcji, co `conda`, aby zapewnić maksymalną kompatybilność.

`mamba` jest częścią ekosystemu [conda-forge](https://conda-forge.org/), który obejmuje również `quetz`, otwartoźródłowy serwer pakietów `conda`.

Możesz przeczytać nasz [post ogłaszający](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` to statycznie linkowana wersja `mamba`.

Może być zainstalowana jako samodzielny plik wykonywalny bez żadnych zależności, co czyni ją idealną do zastosowań w pipeline'ach CI/CD oraz środowiskach kontenerowych.

Szczegóły znajdziesz w [dokumentacji dotyczącej `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html).

## `mamba` vs. `micromamba`

`mamba` powinna być używana, gdy:

- `libmambapy` lub `libmamba` są używane przez inne oprogramowanie w tym samym środowisku.
- W scenariuszach, gdzie wymagane są regularne aktualizacje bibliotek (zwłaszcza bezpieczeństwa).
- Środowiska skupiają się na minimalizacji zajętości dysku przez zależności.

`micromamba` powinna być używana, gdy:

- Wymagana jest pojedyncza, samodzielna aplikacja.
- Dystrybucja miniforge nie jest obecna.
- Użycie wymaga minimalnego środowiska uruchomieniowego.

## Instalacja

Zapoznaj się z [przewodnikiem instalacji mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
oraz [przewodnikiem instalacji micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) w dokumentacji.

## Dodatkowe funkcje w Mamba i Micromamba

`mamba` i `micromamba` oferują funkcje wykraczające poza standardową `conda`.

### `repoquery`

Do efektywnego przeszukiwania repozytoriów i zależności pakietów możesz użyć `mamba repoquery` lub `micromamba repoquery`.

Szczegóły znajdziesz w [dokumentacji repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery).

### Instalacja plików lock

`micromamba` może być używana do instalacji plików lock generowanych przez [conda-lock](https://conda.github.io/conda-lock/) bez konieczności instalowania `conda-lock`.

Po prostu wywołaj `micromamba create` z opcją `-f`, podając plik lock środowiska, którego nazwa kończy się na
`-lock.yml` lub `-lock.yaml`; na przykład:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (zamiennik setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) to zamiennik [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) wykorzystujący `micromamba`.

Może znacząco skrócić czas konfiguracji CI dzięki:

- Użyciu `micromamba`, której instalacja trwa około 1 sekundy.
- Buforowaniu pobieranych pakietów.
- Buforowaniu całych środowisk `conda`.

## Różnice względem `conda`

Chociaż `mamba` i `micromamba` są zazwyczaj zamiennikami dla `conda`, istnieją pewne różnice:

- `mamba` i `micromamba` nie obsługują rewizji (dyskusje: <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` i `micromamba` normalizują ciągi `MatchSpec` do najprostszej formy, podczas gdy `conda` używa bardziej rozbudowanej formy
  Może to powodować niewielkie różnice w wynikach poleceń `conda env export` i `mamba env export`.

## Instalacja deweloperska

Prosimy zapoznać się z instrukcjami zawartymi w [oficjalnej dokumentacji](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Stabilność API i ABI

Projekt Mamba stosuje [wersjonowanie semantyczne](https://semver.org/) w formie `MAJOR.MINOR.PATCH`.
Staramy się utrzymać stabilność dla użytkowników, jednak czasami musimy wprowadzać zmiany niekompatybilne wstecz,
aby ulepszyć Mamba i zmniejszyć dług techniczny.
Przyszłe wersje Mamba mogą oferować silniejsze gwarancje.

### `libmamba` (C++)

Nie jesteśmy świadomi konsumentów API C++, więc pozostawiamy sobie swobodę wprowadzania ulepszeń.
Dla `libmamba` termin _kompatybilność wsteczna ABI_ oznacza:

- _ABI kompatybilna wstecz_ oznacza, że możesz podmienić pliki binarne biblioteki bez rekompilacji
  swojego kodu z nowymi nagłówkami.
  Zachowanie będzie takie samo, z wyjątkiem (mamy nadzieję) znikających błędów i wydajności.
- _API kompatybilna wstecz_ oznacza, że musisz przekompilować swój kod z nową wersją biblioteki,
  ale nie musisz go zmieniać, tylko ponownie zbudować.
  Dotyczy to sytuacji, gdy nie używasz żadnych deklaracji uznanych za prywatne, np.
  w podprzestrzeniach nazw `detail`.
  Zachowanie będzie takie samo, z wyjątkiem (mamy nadzieję) znikających błędów i wydajności.
  Gdy deklaracje są oznaczone jako przestarzałe, ale nie usunięte i nadal działają, uznajemy je również za
  kompatybilne wstecz, ponieważ zmiana widoczna jest tylko podczas kompilacji.

Mając to na uwadze, `libmamba` oferuje następujące gwarancje:

- Wydania `PATCH` są kompatybilne wstecz API i ABI;
- Wydania `MINOR` są kompatybilne API dla deklaracji w `mamba/api`,
  Mogą łamać API poza tym miejscem i ABI wszędzie;
- Wydania `MAJOR` nie gwarantują kompatybilności.

### `libmambapy` (Python)

Dla `libmambapy` termin _API kompatybilna wstecz_ oznacza, że Twój kod w Pythonie będzie działał
tak samo z nowszą wersją `libmambapy`, o ile nie korzystałeś z deklaracji uznanych za prywatne,
np. zaczynających się od `_`.
Zachowanie będzie takie samo, z wyjątkiem (mamy nadzieję) znikających błędów i wydajności.
Gdy deklaracje są oznaczone jako przestarzałe, ale nie usunięte i nadal działają, uznajemy je również za
kompatybilne wstecz, ponieważ zmiana jest widoczna tylko przy aktywacji ostrzeżeń
`DeprecationWarning` w Pythonie, co zwykle ma miejsce tylko w trybie deweloperskim.

Mając to na uwadze, `libmambapy` oferuje następujące gwarancje:

- Wydania `PATCH` są kompatybilne wstecz API;
- Wydania `MINOR` są kompatybilne wstecz API;
- Wydania `MAJOR` nie gwarantują kompatybilności.

### `mamba` i `micromamba` (pliki wykonywalne)

Dla plików wykonywalnych termin _kompatybilność wsteczna_ dotyczy programowalnych wejść i wyjść i oznacza,
że Twój kod (w tym skrypty powłoki) będzie działał z nowszymi wersjami pliku wykonywalnego bez
modyfikacji.
Programowalne wejścia/wyjścia obejmują nazwę pliku wykonywalnego, argumenty wiersza poleceń, pliki konfiguracyjne,
zmienne środowiskowe, wyjścia JSON z linii poleceń oraz tworzone pliki.
_Nie obejmuje_ to wyjścia czy komunikatów o błędach przeznaczonych dla człowieka, a tym samym ostrzeżeń o przestarzałości
wypisywanych w takim wyjściu.

Mając to na uwadze, `mamba` i `micromamba` oferują następujące gwarancje:

- Wydania `PATCH` są kompatybilne wstecz;
- Wydania `MINOR` są kompatybilne wstecz;
- Wydania `MAJOR` nie gwarantują kompatybilności.

## Wesprzyj nas

Tylko `mamba` i `micromamba` w wersji 2.0 i wyższej są wspierane i aktywnie rozwijane.

Gałąź `1.x` jest utrzymywana wyłącznie w celu łatania krytycznych problemów bezpieczeństwa, takich jak CVE.

W przypadku pytań możesz dołączyć do nas na [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
lub na [kanale Conda](https://gitter.im/conda/conda) (zwróć uwagę, że ten projekt nie jest oficjalnie powiązany z `conda` ani Anaconda Inc.).

## Licencja

Stosujemy model współdzielonego praw autorskich, który umożliwia wszystkim współtwórcom utrzymanie praw do ich wkładu.

Oprogramowanie jest licencjonowane na licencji BSD-3-Clause. Szczegóły w pliku [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE).

---

### Dwutygodniowe spotkania deweloperów

Co dwa tygodnie odbywają się wideokonferencje, podczas których omawiamy, nad czym pracujemy i uzyskujemy wzajemny feedback.

Każdy może wziąć udział, jeśli chce poruszyć jakiś temat lub po prostu posłuchać.

- Kiedy: wtorek [16:00 CET (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Gdzie: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Co: [Notatki ze spotkań](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---