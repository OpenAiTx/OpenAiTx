![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

U kunt mijn [artikel](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) lezen en als volgt citeren 
> WANG, Z. (2025, 12 mei). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Omdat GitHub mogelijk Chinese IP-adressen blokkeert, moest ik deze repository kopiëren naar [hier](https://codeberg.org/ufo5260987423/scheme-langserver) en [hier](https://gitee.com/ufo5260987423/scheme-langserver). Ik zal alle repositories blijven updaten, maar ik kan het niet garanderen. Ik werk nu ook samen met [XmacsLabs](https://github.com/XmacsLabs), je kunt ook een fork vinden [hier](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Nu kan VSCode scheme-langserver gebruiken!** Zie [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOOT: Er zitten veel, heel veel bugs in scheme-langserver. Ik ben ze aan het oplossen en vraag hulp aan de community. Wees geduldig.

>NOOT: de automatisch gegenereerde type-informatie vind je [hier](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Het wordt nu vooral gebruikt voor verdere ontwikkeling (misschien inclusief AKKU) en debugging.

Het implementeren van ondersteuning zoals autocompletion, ga naar definitie of documentatie bij hover is een aanzienlijke inspanning voor programmeren. Maar vergeleken met andere talen zoals java, python, javascript en c, zijn implementaties van het language server protocol voor lisp-talen gewoon in een vacuüm gemaakt. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) en [swish-lint](https://github.com/becls/swish-lint) enz., hun werk is allemaal gebaseerd op `repl` (Read-Eval-Print Loop) of keyword tokenizer in plaats van programmeren. Bijvoorbeeld, als een programmeur aan een onafgemaakt project werkt waarin de code niet volledig uitvoerbaar is, zullen [Geiser](https://gitlab.com/emacs-geiser) of anderen alleen top-level binding identifiers aanvullen die door de `environment-symbols` procedure (voor [Chez](https://cisco.github.io/ChezScheme/)) worden weergegeven, of symbolen aanvullen in plaats van identifiers. Dit betekent dat voor lokale bindings en onafgemaakte code, hoewel programmeren juist daar belangrijk voor zou moeten zijn, [Geiser](https://gitlab.com/emacs-geiser) en soortgenoten niet helpen bij het herkennen van de geldige scope van een identifier. Vergelijkbare gevallen komen voor met "ga naar definitie" en veel andere functionaliteiten.

Een primaire oorzaak is dat voor scheme en andere lisp-dialecten hun overvloedige datastructuren en flexibele controle-structuren programma-analyse tot een grote uitdaging maken. Vooral de macro: het lijkt erop dat scheme vooral gebruikt wordt voor geniale en meta/macro-programmering. Maar ik zeg van niet. Scheme kan veel interessante dingen doen als er een betere programmeeromgeving wordt geboden. En nu kun je [**HIER STARTEN**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Dit pakket is een implementatie van het language server protocol dat scheme-programmeren ondersteunt. Het biedt autocompletion, definitie en type inferentie. Deze functionaliteiten zijn gebaseerd op statische code-analyse met de [r6rs-standaard](http://www.r6rs.org/) en enkele duidelijke regels voor onafgemaakte code. Dit pakket zelf en verwante libraries worden gepubliceerd of zullen worden gepubliceerd met [Akku](https://akkuscm.org/), een package manager voor Scheme.

Dit pakket is ook getest met [Chez Scheme](https://cisco.github.io/ChezScheme/) versies 9.4 en 9.5. Een gedetailleerde test op versie 10.0.0 zal worden uitgevoerd nadat ik mijn laptop-OS heb geüpdatet naar een nieuwere versie.

Ik doe dit open-source werk alleen in mijn vrije tijd en ik kan veel geweldige ideeën bijdragen aan de community, zoals het integreren van data flow-analyse in scheme-langserver of veel andere dingen. En ik ben voortdurend op zoek naar meer donaties of financiering. Je kunt doneren via [deze patreonpagina](https://www.patreon.com/PoorProgrammer/membership) of via [爱发电](https://afdian.com/a/ufo5260987423).


## Compilatie, Installatie & Configuratie is [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Recente Status
Ik blijf bugs oplossen, de code profileren en informatie verzamelen voor mijn enorme boek over zelfgemaakt type-inferentiesysteem. Dit zal me ongeveer 1 jaar kosten. Verdere ontwikkelingen zijn onder meer een [VScode](https://visualstudio.com/) plugin en data flow-analyse. Maar eigenlijk zie ik dit open-source werk nu als een parttime baan, en ik kan geen planning garanderen.

## Release 
1.2.9 Nu, geniet van type inference!

Voor eerdere releases zie [dit bestand](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Functionaliteiten
1. Aanvullen van top-level en lokale identifier bindings.
![Top-level en lokale identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level en lokale identifier bindings")
2. Ga naar definitie.
![Ga naar definitie met telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Ga naar definitie met telescope.nvim")
3. Compatibel met package manager: Akku.
4. Synchroniseren van bestandswijzigingen en bijbehorende indexwijzigingen.
5. Hover.
6. Referenties en document highlight (document-gescoepte referenties).
![Vind referenties met telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Vind referenties met telescope.nvim")
7. Documentsymbool.
![Vind documentsymbolen met telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "vind documentsymbolen met telescope.nvim")
8. Vangen van *-syntax (define-syntax, let-syntax, enz.) gebaseerde lokale identifier binding.
9. Cross-platform parallel indexeren.
10. Zelfgemaakte broncode-annotator om compatibel te zijn met .sps-bestanden.
11. Peephole-optimalisatie voor API-aanvragen met onderbreekbare taken.
12. Type-inferentie met een zelfgemaakte DSL-interpreter (ik ben er erg trots op!). En nu is het geïntegreerd in de autocompletion. Zoals in de volgende afbeelding te zien is, staan "length-b" en "length-a" met het type "integer?" vooraan tussen de aanbevolen opties omdat ze overeenkomen met het parameter type dat "<=" vereist.
![Autocompletion met type-inferentie](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion met type-inferentie")
Een test kan dit resultaat bewijzen, voer gewoon `scheme --script tests/protocol/apis/test-completion.sps` uit en het logbestand `scheme-langserver.log` zal resultaten bevatten zoals:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstracte interpreter voor identifier catching over verschillende bestandsextensies zoals scm, ss, sps, sls en sld.

### TODO's
14. Hernoemen.
15. Volledig compatibel met de [r6rs-standaard](http://www.r6rs.org/).
16. Stap-voor-stap macro-expander: ik heb er eigenlijk al een geïmplementeerd en ik wilde het een belangrijke stap maken bij het vangen van identifier bindings in zelfgedefinieerde macro's. Nu merk ik dat dit vangen veel moeilijker is dan ik dacht, en ik weet niet waar de expander zou kunnen werken.
17. Code-evaluatie.
18. Code-diagnose.
19. Cross-language semantische ondersteuning toevoegen. Kunnen java, c, python en vele andere talen worden ondersteund met een AST-transformer?
20. Expressie/statement extraheren naar een procedure.

## TODO:Bijdragen

## Debuggen

### Hoe te debuggen
https://www.scheme.com/debug/debug.html#g1

### Output Log
Volg de tips uit [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) en [Installation for VScode](#todo-installation-for-vscode). Als iemand wil ontwikkelen en iets wil loggen, is het handig om `path-to-log-file` toe te voegen en het bestand `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` als volgt te herschrijven:
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
`scheme-langserver`, een language server protocol implementatie voor scheme
]]   ,
  },
}
```
### Herhalen met Log
Met bovenstaande [output log](#output-log), kun je terugkerende bugs onderzoeken met `tests/log-debug.sps`:
1. Hernoem `{path-to-log}` (meestal `~/scheme-langserver.log`) naar `~/ready-for-analyse.log`;
2. Voer `scheme --script tests/log-debug.sps` uit. Als je de multi-thread omgeving opnieuw wilt creëren, kun je ook `scheme --script tests/log-debug.sps` uitvoeren.

## Test
Bijna alle belangrijke procedures en API's zijn getest. Mijn werk is nogal ruw maar nuttig, misschien wil je zien wat ik heb gedaan in de map `tests` of voer gewoon het volgende commando uit in `{scheme-langserver-root-directory}`
```bash
bash test.sh
```
>OPMERKING
Het is lastig om te testen met een threaded omgeving. Dus, de huidige tests richten zich op één enkele thread.

## Scheme-langserver voor Andere Doeleinden Gebruiken
### Script-Fu in GIMP
Script-Fu is gebaseerd op een geïnterpreteerde taal genaamd Scheme en werkt door functies te gebruiken die interageren met de interne functies van GIMP. Aan de hand van het script op [deze pagina](https://dalelane.co.uk/blog/?p=628) kun je scheme-langserver toepassen op een scriptbestand met de extensie "SCM".

### Overige

Nou, ik ben ook geïnteresseerd in [OMN (Opusmodus Notation)](https://opusmodus.com/) en AutoLisp. Maar ik heb nog veel te doen.

## Code Tellen
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Gedetailleerd Document
1. [Scheme-langserver: Scheme Code Editing als Eerste Klas Zorg Behandelen](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Identifier bindings vangen](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchroniseren](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type-inferentie](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Verouderd, en ik schrijf er een Chinees boek over)
5. [API Analyse](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Sterren Geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Bijdragers

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---