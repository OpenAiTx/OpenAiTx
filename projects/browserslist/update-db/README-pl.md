# Aktualizacja bazy danych Browserslist

<img width="120" height="120" alt="Logo Browserslist autorstwa Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Narzędzie CLI do aktualizacji `caniuse-lite` przy użyciu bazy danych przeglądarek
z konfiguracji [Browserslist](https://github.com/browserslist/browserslist/).

Niektóre zapytania, takie jak `last 2 versions` czy `>1%`, zależą od rzeczywistych danych
z `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Sponsorowane przez Evil Martians" width="236" height="54">
</a>

## Dlaczego należy wywoływać to regularnie

`npx update-browserslist-db@latest` aktualizuje wersję `caniuse-lite`
w Twoim pliku blokady npm, yarn lub pnpm.

Aktualizacja ta dostarcza informacje o nowych przeglądarkach do narzędzi takich jak
Autoprefixer lub Babel oraz redukuje już niepotrzebne polyfille.

Musisz to robić regularnie z trzech powodów:

1. Aby używać najnowszych wersji przeglądarek i statystyk w zapytaniach takich jak
   `last 2 versions` czy `>1%`. Na przykład, jeśli utworzyłeś swój projekt
   2 lata temu i nie aktualizowałeś zależności, `last 1 version`
   zwróci przeglądarki sprzed 2 lat.
2. Aktualne dane o przeglądarkach pozwolą używać mniej polyfilli. Zmniejszy to
   rozmiar plików JS i CSS oraz poprawi wydajność strony.
3. Deduplikacja `caniuse-lite`: synchronizacja wersji w różnych narzędziach.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---