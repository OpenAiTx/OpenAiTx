<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

Je kunt mijn [artikel](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) lezen en als volgt citeren 
> WANG, Z. (2025, 12 mei). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

Omdat GitHub mogelijk Chinese IP-adressen blokkeert, heb ik deze repository gekopieerd naar [hier](https://codeberg.org/ufo5260987423/scheme-langserver) en [hier](https://gitee.com/ufo5260987423/scheme-langserver). Ik blijf alle repositories updaten, maar ik kan het niet garanderen. Ik werk nu ook samen met [XmacsLabs](https://github.com/XmacsLabs), je kunt ook een fork vinden [hier](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Nu kan VSCode scheme-langserver gebruiken!** Zie [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>OPMERKING: Er zitten nog veel bugs in scheme-langserver. Ik ben ze aan het oplossen en vraag hulp aan de community. Wees geduldig.

>OPMERKING: je kunt de automatisch gegenereerde type-informatie [hier](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) vinden. Het wordt nu vooral gebruikt voor de volgende ontwikkelingsfase (mogelijk inclusief AKKU) en debugging.

Het implementeren van ondersteuning zoals automatisch aanvullen, naar definitie gaan of documentatie bij hover is een aanzienlijke inspanning voor programmeren. Echter, vergeleken met andere talen zoals java, python, javascript en c, is de implementatie van language server protocol voor lisp-talen in feite in een vacuüm gedaan. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) en [swish-lint](https://github.com/becls/swish-lint) enz., hun werk is allemaal gebaseerd op `repl` (Read-Eval-Print Loop) of keyword tokenizer in plaats van programmeren. Bijvoorbeeld, als een programmeur aan een onafgemaakt project werkt, waarin de code niet volledig uitvoerbaar is, zullen [Geiser](https://gitlab.com/emacs-geiser) of anderen alleen top-level binding identifiers aanvullen die door de `environment-symbols` procedure (voor [Chez](https://cisco.github.io/ChezScheme/)) worden weergegeven, of alleen symbolen aanvullen in plaats van identifiers. Dit betekent dat voor lokale bindings en onafgemaakte code, hoewel het belangrijk zou moeten zijn om programmeerondersteuning te bieden, [Geiser](https://gitlab.com/emacs-geiser) en soortgelijke tools niets helpen bij het herkennen van het geldige bereik van een identifier. Vergelijkbare gevallen doen zich voor bij 'goto definition' en vele andere functies.

Een belangrijke oorzaak is dat voor scheme en andere lisp-dialecten hun overvloedige datasets en flexibele controle structuren program analyse tot een grote uitdaging maken. Vooral de macro; het lijkt erop dat scheme vooral wordt gebruikt voor geniale en meta/macro-programmering. Maar ik zeg nee. Scheme kan veel interessante dingen doen als er een betere programmeeromgeving is. En nu kun je [**HIER STARTEN**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Dit pakket is een implementatie van het language server protocol die scheme-programmeren ondersteunt. Het biedt autocompletion, definitie en type-inferentie. Deze functionaliteiten zijn gebaseerd op statische code-analyse met de [r6rs standaard](http://www.r6rs.org/) en enkele duidelijke regels voor onafgemaakte code. Dit pakket zelf en gerelateerde libraries zijn gepubliceerd of zullen gepubliceerd worden met [Akku](https://akkuscm.org/), een package manager voor Scheme.

Dit pakket is ook getest met [Chez Scheme](https://cisco.github.io/ChezScheme/) versies 9.4 en 9.5. Een gedetailleerde test op versie 10.0.0 volgt nadat ik mijn laptop OS heb geüpgraded naar een nieuwere versie.

Ik doe dit open source werk gewoon in mijn vrije tijd en ik kan veel geweldige ideeën bijdragen aan de community, zoals het integreren van dataflow-analyse in scheme-langserver of vele andere dingen. En ik vraag continu om meer donaties of financiering. Je kunt doneren via [deze patreon pagina](https://www.patreon.com/PoorProgrammer/membership) of [爱发电](https://afdian.com/a/ufo5260987423).


## Compilatie, Installatie & Configuratie is [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Recente Status
Ik blijf bugs oplossen, de code profileren en informatie verzamelen voor mijn grote boek over een zelfgemaakt type-inferentiesysteem. Dit zal me ongeveer 1 jaar kosten. Verdere ontwikkelingen omvatten een [VScode](https://code.visualstudio.com/) plugin en dataflow-analyse. Maar eigenlijk, ik zie dit open source werk nu als een parttime baan, en ik kan geen planning garanderen.

## Release 
1.2.9 Nu, geniet van type-inferentie!

Voor eerdere releases zie [dit bestand](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Functionaliteiten
1. Aanvullen van top-level en lokale identifier bindings.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Naar definitie gaan.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatibel met package manager: Akku.
4. Synchronisatie van bestandswijzigingen en overeenkomstige indexering.
5. Hover.
6. Referenties en document highlight (document-gebaseerde referenties).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Document symbool.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Vangen van *-syntax (define-syntax, let-syntax, enz.) gebaseerde lokale identifier binding. 
9. Cross-platform parallel indexeren.
10. Zelfgemaakte broncode annotator om compatibel te zijn met .sps-bestanden.
11. Peephole-optimalisatie voor API-verzoeken met onderbreekbare taken.
12. Type-inferentie met een zelfgemaakte DSL-interpreter (ik ben er erg trots op!). En nu is het ingebed in de auto-completion. Zoals te zien is in de volgende afbeelding, staan "length-b" en "length-a" met type "integer?" vooraan in de aanbevolen opties omdat ze overeenkomen met het vereiste parametertype van "<=". 
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Een test kan dit resultaat bewijzen, voer gewoon `scheme --script tests/protocol/apis/test-completion.sps` uit en het logbestand `scheme-langserver.log` zal resultaten bevatten zoals:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstracte interpreter voor identifier-detectie tussen verschillende bestandsextensies zoals scm, ss, sps, sls en sld.

### TODOs
14. Hernoemen.
15. Volledig compatibel met [r6rs standaard](http://www.r6rs.org/).
16. Stapsgewijze macro-expander: nou, ik heb er eigenlijk een geïmplementeerd en ik wilde het tot een belangrijke stap maken voor het vastleggen van identifier binding in zelfgedefinieerde macro's. Nu zie ik dat dit vangen veel moeilijker is dan ik dacht, en ik weet niet waar de expander kan werken.
17. Code-evaluatie.
18. Code-diagnostiek.
19. Toevoegen van cross-language semantische ondersteuning. Nou, zouden Java, C, Python en vele andere talen ondersteund kunnen worden met een AST-transformator?
20. Expressies/statements extraheren naar een procedure.

## TODO:Bijdragen

## Debuggen

### Hoe te debuggen
https://www.scheme.com/debug/debug.html#g1

### Uitvoerlogboek
Volg de tips van [Bouwen](#building), [Installatie voor Lunar Vim](#installation-for-lunarvim) en [Installatie voor VScode](#todo-installation-for-vscode). Als iemand wil ontwikkelen en iets wil loggen, is het handig om `pad-naar-log-bestand` toe te voegen en het bestand `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` als volgt te herschrijven:
```lua
local util = require 'lspconfig.util'
local bin_name = '{pad-naar-uitvoerbare-bestand}'
local cmd = { bin_name ,"pad-naar-log-bestand"}

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
`scheme-langserver`, een implementatie van het language server protocol voor scheme
]]   ,
  },
}
```
### Herhalen met Log
Met bovenstaande [uitvoerlogboek](#output-log), kun je `tests/log-debug.sps` gebruiken om bugs te reproduceren:
1. Hernoem `{pad-naar-log}` (meestal `~/scheme-langserver.log`) naar `~/ready-for-analyse.log`;
2. Voer `scheme --script tests/log-debug.sps` uit. Als je de multi-thread-omgeving wilt nabootsen, kun je ook `scheme --script tests/log-debug.sps` uitvoeren.

## Testen
Bijna alle belangrijke procedures en API's zijn getest. Mijn werk is nogal grof maar bruikbaar; misschien wil je bekijken wat ik heb gedaan in de map `tests` of gewoon het volgende commando uitvoeren in `{scheme-langserver-root-directory}`
```bash
bash test.sh
```
>OPMERKING
Het is lastig om te testen met een multi-threaded omgeving. De huidige tests richten zich dus op single-thread.

## Scheme-langserver gebruiken voor andere doeleinden
### Script-Fu in GIMP
Script-Fu is gebaseerd op een geïnterpreteerde taal genaamd Scheme en werkt door functies te gebruiken die interageren met de interne functies van GIMP. Neem als voorbeeld het script van [deze pagina](https://dalelane.co.uk/blog/?p=628); je kunt scheme-langserver toepassen op scriptbestanden met de extensie "SCM".

### Overig

Nou, ik ben ook geïnteresseerd in [OMN (Opusmodus Notation)](https://opusmodus.com/) en AutoLisp. Maar ik heb nog veel te doen.

## Code-aantallen
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Gedetailleerde Documentatie
1. [Scheme-langserver: Behandel Scheme Code Editing als de First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Identifier-bindings vangen](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchroniseren](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type-inferentie](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Verouderd, en ik schrijf er een Chinees boek over)
5. [API-analyse](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Sterren-geschiedenis

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Bijdragers

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---