![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Możesz przeczytać mój [artykuł](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) i zacytować go w ten sposób:
> WANG, Z. (2025, 12 maja). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Ponieważ GitHub może blokować adresy IP z Chin, musiałem skopiować to repozytorium [tutaj](https://codeberg.org/ufo5260987423/scheme-langserver) oraz [tutaj](https://gitee.com/ufo5260987423/scheme-langserver). Będę stale aktualizować wszystkie repozytoria, ale nie mogę tego zagwarantować. Obecnie współpracuję również z [XmacsLabs](https://github.com/XmacsLabs), można znaleźć fork [tutaj](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Teraz VSCode może korzystać ze scheme-langserver!** Proszę sprawdź [TUTAJ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>UWAGA: Scheme-langserver posiada bardzo dużo błędów. Wciąż je naprawiam i proszę społeczność o pomoc. Proszę o cierpliwość.

>UWAGA: automatycznie generowane informacje o typach można znaleźć [tutaj](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Obecnie są one wykorzystywane głównie do dalszego rozwoju (może z AKKU) i debugowania.

Implementacja wsparcia dla takich funkcji jak autouzupełnianie, przejście do definicji czy dokumentacja po najechaniu myszką to poważne wyzwanie programistyczne. Jednak w porównaniu z innymi językami jak java, python, javascript czy c, implementacje language server protocol dla języków lispowych powstają w próżni. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) oraz [swish-lint](https://github.com/becls/swish-lint) itp. opierają się na `repl` (Read-Eval-Print Loop) lub tokenizatorze słów kluczowych, a nie na analizie kodu. Na przykład, jeśli programista pracuje nad niedokończonym projektem, w którym kod nie jest w pełni wykonalny, [Geiser](https://gitlab.com/emacs-geiser) i inne narzędzia ukończą tylko identyfikatory wiązań na najwyższym poziomie, wymienione przez procedurę `environment-symbols` (dla [Chez](https://cisco.github.io/ChezScheme/)), lub uzupełnią symbole zamiast identyfikatorów. Oznacza to, że dla lokalnych wiązań i niedokończonego kodu – choć praca nad programowaniem powinna być priorytetem – [Geiser](https://gitlab.com/emacs-geiser) i jego odpowiedniki nie pomagają w rozpoznawaniu poprawnego zakresu identyfikatorów. Podobne problemy pojawiają się przy przejściu do definicji i innych funkcjach.

Główną przyczyną jest to, że w scheme i innych dialektach lispowych bogactwo struktur danych i elastyczność kontroli przepływu sprawiają, że analiza programu jest dużym wyzwaniem. Szczególnie makra – wydaje się, że scheme jest przeznaczony głównie dla geniuszy i programowania meta/makro. Ja jednak twierdzę, że nie. Scheme może być wykorzystywany do wielu ciekawych rzeczy, jeśli zapewni się lepsze środowisko programistyczne. Teraz możesz [**ZACZĄĆ TUTAJ**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Ten pakiet to implementacja language server protocol wspierająca programowanie w scheme. Udostępnia uzupełnianie kodu, przechodzenie do definicji i inferencję typów. Funkcje te oparte są na statycznej analizie kodu zgodnie ze [standardem r6rs](http://www.r6rs.org/) oraz oczywistymi regułami dla niedokończonego kodu. Sam pakiet i powiązane biblioteki są publikowane lub będą publikowane z [Akku](https://akkuscm.org/), czyli menedżerem pakietów dla Scheme.

Pakiet był także testowany z [Chez Scheme](https://cisco.github.io/ChezScheme/) w wersjach 9.4 i 9.5. Szczegółowe testy dla wersji 10.0.0 będą wykonane po aktualizacji mojego systemu operacyjnego.

Pracuję nad tym projektem open source w wolnym czasie i mogę wnieść do społeczności wiele świetnych pomysłów, takich jak wbudowanie analizy przepływu danych w scheme-langserver lub wiele innych rzeczy. Stale proszę również o wsparcie finansowe lub darowizny. Możesz przekazać datek poprzez [tę stronę patreona](https://www.patreon.com/PoorProgrammer/membership) lub [爱发电](https://afdian.com/a/ufo5260987423).

## Kompilacja, instalacja i konfiguracja są opisane [TUTAJ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Aktualny stan
Będę nadal naprawiać błędy, profilować kod i zbierać materiały do mojej wielkiej książki o systemie inferencji typów własnej roboty. Zajmie mi to około roku. Kolejne plany rozwoju obejmują wtyczkę do [VScode](https://code.visualstudio.com/) oraz analizę przepływu danych. W praktyce jednak traktuję ten projekt open source jako pracę dorywczą i nie mogę zagwarantować żadnego harmonogramu.

## Wydanie 
1.2.9 Teraz można korzystać z inferencji typów!

Poprzednie wydania znajdziesz w [tym pliku](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funkcjonalności
1. Uzupełnianie wiązań identyfikatorów na najwyższym i lokalnym poziomie.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Przechodzenie do definicji.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Kompatybilność z menedżerem pakietów: Akku.
4. Synchronizacja zmian plików i odpowiednia aktualizacja indeksu.
5. Wyświetlanie dokumentacji po najechaniu (hover).
6. Wyszukiwanie referencji i podświetlanie dokumentów (referencje w zakresie dokumentu).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Symbole dokumentu.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Wychwytywanie wiązań lokalnych identyfikatorów bazujące na *-syntax (define-syntax, let-syntax itd.).
9. Wieloplatformowe, równoległe indeksowanie.
10. Własnoręczny adnotator kodu źródłowego, kompatybilny z plikami .sps.
11. Optymalizacja „peephole” dla żądań API z zadaniami wstrzymywanymi.
12. Inferencja typów z użyciem własnego interpretera DSL (jestem z tego bardzo dumny!). Teraz została ona zintegrowana z autouzupełnianiem. Jak pokazano na poniższym obrazku, „length-b” i „length-a” mające typ „integer?” są wyświetlane na początku proponowanych opcji, ponieważ pasują do typu parametru wymaganego przez „<=”.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Test może to potwierdzić – wystarczy uruchomić `scheme --script tests/protocol/apis/test-completion.sps`, a plik logu `scheme-langserver.log` będzie zawierał wyniki takie jak:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstrakcyjny interpreter do wychwytywania identyfikatorów pomiędzy różnymi rozszerzeniami plików, jak scm, ss, sps, sls oraz sld.

### TODO
14. Zmiana nazw (renaming).
15. Pełna zgodność ze [standardem r6rs](http://www.r6rs.org/).
16. Krokowy ekspander makr: w zasadzie już go zaimplementowałem i chciałem, żeby był kluczowym elementem do wychwytywania wiązań identyfikatorów w makrach własnej definicji. Teraz jednak widzę, że to zadanie jest dużo trudniejsze niż sądziłem, a ekspander nie wiem, gdzie mógłby być wykorzystany.
17. Wykonywanie kodu (eval).
18. Diagnostyka kodu.
19. Dodanie wsparcia semantyki międzyjęzykowej. Czy java, c, python i inne języki mogłyby być obsłużone przez transformator AST?
20. Ekstrakcja wyrażeń/instrukcji do procedury.

## TODO: Współtworzenie 

## Debugowanie

### Jak debugować
https://www.scheme.com/debug/debug.html#g1

### Log wyjściowy
Postępując zgodnie z instrukcjami z [Budowania](#building), [Instalacji dla Lunar Vim](#installation-for-lunarvim) oraz [Instalacji dla VScode](#todo-installation-for-vscode), jeśli ktoś chce rozwijać projekt i rejestrować logi, wystarczy dodać `path-to-log-file` i nadpisać plik `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` następująco:
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
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
}
```
### Powtarzanie z logiem
Korzystając z powyższego [logu wyjściowego](#output-log), możesz użyć `tests/log-debug.sps` do powtarzania błędów:
1. Zmień nazwę pliku `{path-to-log}` (zazwyczaj `~/scheme-langserver.log`) na `~/ready-for-analyse.log`;
2. Uruchom `scheme --script tests/log-debug.sps`. Jeśli chcesz odtworzyć środowisko wielowątkowe, możesz również uruchomić `scheme --script tests/log-debug.sps`.

## Test
Prawie wszystkie kluczowe procedury i API są testowane. Moja praca jest dość surowa, ale użyteczna, może znajdziesz to, co zrobiłem w katalogu `tests` lub po prostu uruchom poniższe polecenie w `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>UWAGA
Trudno jest testować w środowisku wielowątkowym. Dlatego obecne testy skupiają się na jednym wątku.

## Użycie Scheme-langserver do innych celów
### Script-Fu w GIMP
Script-Fu opiera się na interpretowanym języku Scheme i działa poprzez używanie funkcji, które współpracują z wewnętrznymi funkcjami GIMP-a. Na przykładzie skryptu z [tej strony](https://dalelane.co.uk/blog/?p=628), możesz użyć scheme-langserver z plikiem skryptu o rozszerzeniu "SCM".

### Inne

Ciekawi mnie także [OMN (Opusmodus Notation)](https://opusmodus.com/) i AutoLisp. Ale mam jeszcze wiele do zrobienia.

## Liczenie kodu
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Szczegółowa dokumentacja
1. [Scheme-langserver: Traktowanie edycji kodu Scheme jako priorytetu](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Wychwytywanie powiązań identyfikatorów](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizacja](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Wnioskowanie typów](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Przestarzałe, pracuję nad książką po chińsku na ten temat)
5. [Analiza API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Historia gwiazdek

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Współtwórcy

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---