Bitcoin Core – drzewo integracyjne/staging
==========================================

https://bitcoincore.org

Aby uzyskać natychmiastowo używalną, binarną wersję oprogramowania Bitcoin Core, zobacz
https://bitcoincore.org/en/download/.

Czym jest Bitcoin Core?
-----------------------

Bitcoin Core łączy się z siecią peer-to-peer Bitcoina, aby pobierać i w pełni
weryfikować bloki i transakcje. Zawiera także portfel oraz graficzny interfejs użytkownika, które mogą być opcjonalnie zbudowane.

Dalsze informacje o Bitcoin Core znajdują się w [folderze doc](/doc).

Licencja
--------

Bitcoin Core jest wydany na warunkach licencji MIT. Zobacz [COPYING](COPYING), aby uzyskać więcej
informacji lub odwiedź https://opensource.org/license/MIT.

Proces rozwoju
--------------

Gałąź `master` jest regularnie budowana (zobacz `doc/build-*.md` po instrukcje) i testowana, jednak nie jest
gwarantowane, że będzie całkowicie stabilna. [Tagi](https://github.com/bitcoin/bitcoin/tags) są tworzone
regularnie na podstawie gałęzi wydaniowych, aby oznaczać nowe oficjalne, stabilne wersje Bitcoin Core.

Repozytorium https://github.com/bitcoin-core/gui jest używane wyłącznie do
rozwoju GUI. Jego gałąź master jest identyczna we wszystkich repozytoriach monotree.
Gałęzie wydaniowe i tagi nie istnieją, dlatego prosimy nie forkać
tego repozytorium, chyba że w celach rozwojowych.

Proces współtworzenia opisany jest w [CONTRIBUTING.md](CONTRIBUTING.md),
a przydatne wskazówki dla deweloperów można znaleźć w [doc/developer-notes.md](doc/developer-notes.md).

Testowanie
----------

Testowanie i przegląd kodu są wąskim gardłem rozwoju; otrzymujemy więcej pull requestów,
niż jesteśmy w stanie szybko przetestować i zrecenzować. Prosimy o cierpliwość oraz pomoc poprzez testowanie
pull requestów innych osób i pamiętaj, że jest to projekt o krytycznym znaczeniu dla bezpieczeństwa, gdzie każdy błąd może kosztować ludzi
dużo pieniędzy.

### Testy automatyczne

Zaleca się, aby deweloperzy pisali [testy jednostkowe](src/test/README.md) dla nowego kodu oraz
dodawali nowe testy jednostkowe do starego kodu. Testy jednostkowe można skompilować i uruchomić
(jeśli nie zostały wyłączone podczas generowania systemu budowania) za pomocą: `ctest`. Dalsze szczegóły dotyczące uruchamiania
i rozszerzania testów jednostkowych znajdują się w [/src/test/README.md](/src/test/README.md).

Dostępne są także [testy regresyjne i integracyjne](/test), napisane
w Pythonie.
Testy te można uruchomić (jeśli [zależności testowe](/test) są zainstalowane) za pomocą: `build/test/functional/test_runner.py`
(zakładając, że `build` to Twój katalog budowania).

Systemy CI (Continuous Integration) zapewniają, że każdy pull request jest budowany dla Windows, Linux i macOS,
a testy jednostkowe i sanity są uruchamiane automatycznie.

### Ręczne testy zapewnienia jakości (QA)

Zmiany powinny być testowane przez kogoś innego niż deweloper, który napisał dany kod.
Jest to szczególnie ważne dla dużych lub ryzykownych zmian. Warto
dodać plan testów do opisu pull requesta, jeśli testowanie zmian nie jest oczywiste.

Tłumaczenia
-----------

Zmiany tłumaczeń, jak również nowe tłumaczenia, można zgłaszać na
[stronie Transifex Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Tłumaczenia są okresowo pobierane z Transifex i scalane z repozytorium git. Szczegóły dotyczące działania tego procesu znajdują się w
[procesie tłumaczeń](doc/translation_process.md).

**Ważne**: Nie akceptujemy zmian tłumaczeń w formie pull requestów na GitHub, ponieważ kolejne
pobranie z Transifex automatycznie by je nadpisało.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---