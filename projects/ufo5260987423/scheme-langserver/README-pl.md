<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Możesz przeczytać moją [pracę](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) i cytować ją tak:
> WANG, Z. (2025, 12 maja). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Ponieważ GitHub może blokować adresy IP z Chin, musiałem skopiować to repozytorium [tutaj](https://codeberg.org/ufo5260987423/scheme-langserver) oraz [tutaj](https://gitee.com/ufo5260987423/scheme-langserver). Będę stale aktualizował wszystkie repozytoria, ale nie mogę tego zagwarantować. Współpracuję także z [XmacsLabs](https://github.com/XmacsLabs), znajdziesz fork [tutaj](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Teraz VSCode może korzystać ze scheme-langserver!** Zajrzyj [TUTAJ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>UWAGA: Scheme-langserver zawiera wiele, wiele błędów. Pracuję nad ich usuwaniem i apeluję o pomoc społeczności. Proszę o cierpliwość.

>UWAGA: automatycznie wygenerowane informacje o typach znajdziesz [tutaj](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Obecnie wykorzystywane są głównie do dalszego rozwoju (może także dla AKKU) oraz debugowania.

Implementacja wsparcia takich funkcji jak autouzupełnianie, przejście do definicji czy dokumentacja po najechaniu jest dużym wyzwaniem programistycznym. Jednak w porównaniu do innych języków jak java, python, javascript czy c, implementacje protokołu language server dla języków lispowych powstają niejako w próżni. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) oraz [swish-lint](https://github.com/becls/swish-lint) i inne – wszystkie opierają się na `repl` (Read-Eval-Print Loop) lub tokenizatorze słów kluczowych, a nie na analizie programistycznej. Przykładowo, jeśli programista pracuje nad niedokończonym projektem, w którym kod nie jest w pełni wykonywalny, [Geiser](https://gitlab.com/emacs-geiser) lub inne narzędzia będą uzupełniały jedynie identyfikatory powiązane na najwyższym poziomie, wylistowane przez procedurę `environment-symbols` (dla [Chez](https://cisco.github.io/ChezScheme/)), lub uzupełniały symbole zamiast identyfikatorów. Oznacza to, że dla lokalnych powiązań i nieukończonego kodu, mimo że analiza programistyczna jest tu najważniejsza, [Geiser](https://gitlab.com/emacs-geiser) i podobne narzędzia nie rozpoznają poprawnego zakresu identyfikatorów. Podobne przypadki występują przy przejściu do definicji i wielu innych funkcjach.

Podstawową przyczyną jest to, że dla Scheme i innych dialektów Lispa ich bogate zbiory danych i elastyczne struktury sterujące stanowią duże wyzwanie dla analizy programów. Szczególnie makra – wydaje się, że Scheme jest przeznaczony głównie dla geniuszy i do programowania meta/makro. Ale mówię: nie. Scheme pozwala na wiele ciekawych rzeczy, jeśli zapewni się lepsze środowisko programistyczne. I teraz możesz [**ZACZĄĆ TUTAJ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Ten pakiet to implementacja protokołu language server wspierająca programowanie w Scheme. Zapewnia uzupełnianie kodu, przechodzenie do definicji oraz wnioskowanie typów. Funkcjonalności te opierają się na statycznej analizie kodu według [standardu r6rs](http://www.r6rs.org/) oraz oczywistych regułach dla nieukończonego kodu. Sam pakiet i powiązane biblioteki są publikowane lub będą publikowane przez [Akku](https://akkuscm.org/), czyli menedżera pakietów dla Scheme.

Pakiet był również testowany z [Chez Scheme](https://cisco.github.io/ChezScheme/) w wersjach 9.4 i 9.5. Szczegółowe testy dla wersji 10.0.0 zostaną przeprowadzone po aktualizacji mojego systemu operacyjnego.

Pracuję nad tym projektem open source w wolnym czasie i mogę wnieść do społeczności wiele ciekawych pomysłów, takich jak integracja analizy przepływu danych z scheme-langserver czy wiele innych rzeczy. Cały czas proszę o wsparcie finansowe lub darowizny. Możesz przekazać darowiznę poprzez [stronę patreona](https://www.patreon.com/PoorProgrammer/membership) lub [爱发电](https://afdian.com/a/ufo5260987423).


## Kompilacja, Instalacja i Konfiguracja znajdują się [TUTAJ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Ostatni Status
Będę dalej naprawiać błędy, profilować kod i zbierać materiały do mojej ogromnej książki o własnoręcznym systemie wnioskowania typów. Zajmie mi to około roku. Dalszy rozwój obejmuje plugin do [VScode](https://code.visualstudio.com/) oraz analizę przepływu danych. Ale tak naprawdę, traktuję teraz to open source jako pracę dorywczą i nie mogę zagwarantować harmonogramu.

## Wydania
1.2.9 Teraz, korzystaj z wnioskowania typów!

Poprzednie wydania znajdziesz w [tym pliku](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funkcje
1. Uzupełnianie powiązań identyfikatorów na najwyższym i lokalnym poziomie.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Przejście do definicji.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Kompatybilność z menedżerem pakietów: Akku.
4. Synchronizacja zmian w plikach i odpowiednia aktualizacja indeksów.
5. Podgląd (hover).
6. Wyszukiwanie referencji i podświetlanie dokumentu (referencje w zakresie dokumentu).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Symbole dokumentu.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Wykrywanie powiązań lokalnych identyfikatorów opartych na *-syntax (define-syntax, let-syntax, itd.).
9. Wieloplatformowe, równoległe indeksowanie.
10. Autorski adnotator kodu źródłowego kompatybilny z plikami .sps.
11. Optymalizacja peephole dla żądań API z zadaniami wstrzymywanymi.
12. Wnioskowanie typów z użyciem własnego interpretera DSL (jestem z tego bardzo dumny!). Teraz zostało ono wbudowane w autouzupełnianie. Jak pokazuje poniższa ilustracja, "length-b" i "length-a" mające typ "integer?" są na początku rekomendowanych opcji, ponieważ pasują do wymaganego typu parametru dla "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Test może to potwierdzić, wystarczy uruchomić `scheme --script tests/protocol/apis/test-completion.sps` a plik logów `scheme-langserver.log` zawiera takie wyniki:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstrakcyjny interpreter do wykrywania identyfikatorów między różnymi rozszerzeniami plików, takimi jak scm, ss, sps, sls i sld.

### TODO
14. Zmiana nazw (renaming).
15. Pełna zgodność ze [standardem r6rs](http://www.r6rs.org/).
16. Krokowy ekspander makr: właściwie już taki zaimplementowałem i chciałem, żeby był kluczowym krokiem wykrywania powiązań identyfikatorów w makrach zdefiniowanych przez użytkownika. Teraz widzę, że to wykrywanie jest dużo trudniejsze niż myślałem, a ekspander nie wiem, gdzie dokładnie się sprawdzi.
17. Ewaluacja kodu.
18. Diagnostyka kodu.
19. Dodanie wsparcia semantycznego między językami. Czy można obsłużyć języki takie jak Java, C, Python i wiele innych za pomocą transformatora AST?
20. Ekstrakcja wyrażeń/instrukcji do procedury.

## TODO:Wkład

## Debugowanie

### Jak debugować
https://www.scheme.com/debug/debug.html#g1

### Log wyjściowy
Korzystając ze wskazówek z sekcji [Budowanie](#building), [Instalacja dla Lunar Vim](#installation-for-lunarvim) oraz [Instalacja dla VScode](#todo-installation-for-vscode), jeśli ktoś chce rozwijać projekt i logować pewne rzeczy, wygodnie jest dodać `ścieżka-do-pliku-logu` i nadpisać plik `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` w następujący sposób:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, implementacja language server protocol dla scheme
]]   ,
  },
}
```
### Powtarzanie z logiem
Korzystając z powyższego [logu wyjściowego](#output-log), możesz użyć `tests/log-debug.sps` do powtarzania błędów:
1. Zmień nazwę `{path-to-log}` (zwykle `~/scheme-langserver.log`) na `~/ready-for-analyse.log`;
2. Uruchom `scheme --script tests/log-debug.sps`. Jeśli chcesz odtworzyć środowisko wielowątkowe, możesz także uruchomić `scheme --script tests/log-debug.sps`.

## Testowanie
Prawie wszystkie kluczowe procedury i API są testowane. Moja praca jest dość surowa, ale użyteczna. Być może chciałbyś zobaczyć, co zrobiłem w katalogu `tests` lub po prostu uruchomić poniższe polecenie w `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>UWAGA
Trudno jest testować w środowisku wielowątkowym. Obecne testy skupiają się na pojedynczym wątku.

## Użycie Scheme-langserver do innych celów
### Script-Fu w GIMP
Script-Fu opiera się na interpretowanym języku Scheme i działa, korzystając z funkcji, które współpracują z wewnętrznymi funkcjami GIMP-a. Na przykładzie [tej strony](https://dalelane.co.uk/blog/?p=628), możesz użyć scheme-langserver z plikami skryptów z rozszerzeniem "SCM".

### Inne

Interesuję się również [OMN (Opusmodus Notation)](https://opusmodus.com/) oraz AutoLisp. Ale nadal mam wiele rzeczy do zrobienia.

## Licznik kodu
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Szczegółowa dokumentacja
1. [Scheme-langserver: Traktowanie edycji kodu Scheme jako priorytetu](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Wyłapywanie powiązań identyfikatorów](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizacja](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Wnioskowanie typów](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Przestarzałe, piszę o tym chińską książkę)
5. [Analiza API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historia gwiazdek

[![Wykres historii gwiazdek](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Współtwórcy

![Współtwórcy](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---