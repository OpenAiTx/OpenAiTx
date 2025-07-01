![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Sie können mein [Paper](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) lesen und wie folgt zitieren: 
> WANG, Z. (2025, 12. Mai). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zürich. https://doi.org/10.5281/zenodo.15384882

Da GitHub möglicherweise chinesische IP-Adressen blockiert, musste ich dieses Repository [hierhin](https://codeberg.org/ufo5260987423/scheme-langserver) und [hierhin](https://gitee.com/ufo5260987423/scheme-langserver) kopieren. Ich werde alle Repositories weiterhin aktualisieren, aber ich kann es nicht garantieren. Ich arbeite jetzt auch mit [XmacsLabs](https://github.com/XmacsLabs) zusammen, Sie können auch einen Fork [hier](https://github.com/XmacsLabs/scheme-langserver) finden.

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Jetzt kann VSCode scheme-langserver verwenden!** Bitte beachten Sie [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>HINWEIS: Es gibt viele, viele Bugs im scheme-langserver. Ich bin dabei, sie zu beheben und bitte die Community um Hilfe. Bitte haben Sie Geduld.

>HINWEIS: Die automatisch generierten Typinformationen finden Sie [hier](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Sie werden derzeit hauptsächlich für die Weiterentwicklung (vielleicht inkl. AKKU) und zum Debuggen verwendet.

Das Implementieren von Funktionen wie Autovervollständigung, Gehe-zu-Definition oder Dokumentation beim Hover ist ein erheblicher Aufwand beim Programmieren. Im Vergleich zu anderen Sprachen wie Java, Python, JavaScript und C werden Implementierungen des Language Server Protocols für Lisp-Sprachen jedoch quasi im Vakuum entwickelt. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) und [swish-lint](https://github.com/becls/swish-lint) basieren alle auf `repl` (Read-Eval-Print Loop) oder einem Keyword-Tokenizer statt echter Programmierung. Zum Beispiel: Wenn ein Programmierer an einem noch unfertigen Projekt arbeitet, in dem der Code nicht vollständig lauffähig ist, würden [Geiser](https://gitlab.com/emacs-geiser) oder andere nur Top-Level-Bindungsbezeichner auflisten, die durch die Prozedur `environment-symbols` (für [Chez](https://cisco.github.io/ChezScheme/)) bereitgestellt werden, oder sie vervollständigen Symbole anstelle von Bezeichnern. Das heißt, für lokale Bindungen und unfertige Codes, obwohl die Unterstützung beim Programmieren eigentlich am wichtigsten wäre, helfen [Geiser](https://gitlab.com/emacs-geiser) und ähnliche Tools nicht bei der Erkennung des gültigen Gültigkeitsbereichs eines Bezeichners. Ähnliche Probleme treten bei Gehe-zu-Definition und vielen anderen Funktionen auf.

Ein Hauptgrund ist, dass für Scheme und andere Lisp-Dialekte die umfangreichen Datensätze und flexiblen Kontrollstrukturen die Programmanalyse zu einer großen Herausforderung machen. Insbesondere das Makro: Es scheint, als wäre Scheme hauptsächlich für Genies und Meta-/Makroprogrammierung gedacht. Aber ich sage nein. Scheme kann viele interessante Dinge ermöglichen, wenn eine bessere Programmierumgebung bereitgestellt wird. Und jetzt können Sie [**HIER STARTEN**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Dieses Paket ist eine Implementierung des Language Server Protocol, die das Programmieren mit Scheme unterstützt. Es bietet Vervollständigung, Definition und Typinferenz. Diese Funktionen basieren auf statischer Codeanalyse mit dem [r6rs Standard](http://www.r6rs.org/) und einigen offensichtlichen Regeln für unfertige Codes. Dieses Paket selbst und zugehörige Bibliotheken sind veröffentlicht oder werden veröffentlicht mit [Akku](https://akkuscm.org/), einem Paketmanager für Scheme. 

Dieses Paket wurde auch mit [Chez Scheme](https://cisco.github.io/ChezScheme/) in den Versionen 9.4 und 9.5 getestet. Ein detaillierter Test für Version 10.0.0 wird nach dem Upgrade meines Laptop-Betriebssystems auf eine neuere Version durchgeführt.

Ich mache diese Open-Source-Arbeit nur in meiner Freizeit und kann viele großartige Ideen zur Community beitragen, wie z. B. die Einbettung einer Data-Flow-Analyse in scheme-langserver oder vieles mehr. Und ich bitte kontinuierlich um mehr Spenden oder Förderung. Sie können über [diese Patreon-Seite](https://www.patreon.com/PoorProgrammer/membership) oder [爱发电](https://afdian.com/a/ufo5260987423) spenden.


## Kompilierung, Installation & Konfiguration finden Sie [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Aktueller Status
Ich werde weiterhin Bugs beheben, den Code profilieren und Informationen für mein großes Buch über selbstgemachte Typinferenzsysteme sammeln. Das wird etwa 1 Jahr dauern. Weitere Entwicklungen beinhalten ein [VScode](https://code.visualstudio.com/) Plugin und Data-Flow-Analyse. Tatsächlich ist diese Open-Source-Arbeit derzeit ein Nebenjob für mich, und ich kann keinen Zeitplan garantieren.

## Release 
1.2.9 Jetzt: Viel Spaß mit der Typinferenz!

Frühere Releases finden Sie in [dieser Datei](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funktionen
1. Top-Level- und lokale Bezeichner-Vervollständigung.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Gehe-zu-Definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Kompatibel mit Paketmanager: Akku.
4. Synchronisierung von Dateiänderungen und entsprechende Indexanpassung.
5. Hover.
6. Referenzen und Dokumenthervorhebung (dokumentenbezogene Referenzen).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Dokumentsymbol.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Erkennung von *-Syntax (define-syntax, let-syntax, etc.) für lokale Bezeichnerbindungen. 
9. Plattformübergreifendes paralleles Indexieren.
10. Eigener Quellcode-Annotator zur Kompatibilität mit .sps-Dateien.
11. Peephole-Optimierung für API-Anfragen mit aussetzbaren Aufgaben.
12. Typinferenz mit einem selbst entwickelten DSL-Interpreter (darauf bin ich sehr stolz!). Sie ist nun auch in die Autovervollständigung integriert. Wie in der folgenden Abbildung zu sehen ist, stehen die "length-b" und "length-a" mit "integer?" Typ vor den anderen empfohlenen Optionen, da sie zum geforderten Parametertyp von "<=" passen. 
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Ein Test kann dies belegen, einfach `scheme --script tests/protocol/apis/test-completion.sps` ausführen und die Logdatei `scheme-langserver.log` enthält dann Ergebnisse wie:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstrakter Interpreter zum Erkennen von Bezeichnern zwischen verschiedenen Dateiendungen wie scm, ss, sps, sls und sld.

### TODOs
14. Umbenennung. 
15. Vollständige Kompatibilität mit dem [r6rs Standard](http://www.r6rs.org/).
16. Schrittweiser Makro-Expander: Eigentlich habe ich einen implementiert und wollte ihn als Schlüsselschritt zur Erkennung von Bezeichnerbindungen in selbst definierten Makros nutzen. Jetzt merke ich, dass diese Erkennung viel schwieriger ist als gedacht, und ich weiß nicht, wo der Expander nützlich sein könnte.
17. Code-Auswertung.
18. Code-Diagnose.
19. Hinzufügen von semantischer Unterstützung für andere Sprachen. Könnten Java, C, Python und viele andere Sprachen mit einem AST-Transformer unterstützt werden?
20. Extrahieren von Ausdrücken/Statements in eine Prozedur.

## TODO:Beitragen

## Debug

### Wie debuggt man
https://www.scheme.com/debug/debug.html#g1

### Ausgabelog
Nach den Hinweisen im Abschnitt [Building](#building), [Installation für Lunar Vim](#installation-for-lunarvim) und [Installation für VScode](#todo-installation-for-vscode), falls jemand entwickeln und etwas loggen möchte, ist es praktisch, `path-to-log-file` hinzuzufügen und die Datei `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` wie folgt umzuschreiben:
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
`scheme-langserver`, eine Implementierung des Language Server Protocol für Scheme
]]   ,
  },
```
### Wiederkehrende Fehleranalyse mit Log
Mit dem oben genannten [Ausgabe-Log](#output-log) können Sie mithilfe von `tests/log-debug.sps` wiederkehrende Fehler untersuchen:
1. Benennen Sie `{path-to-log}` (in der Regel `~/scheme-langserver.log`) um in `~/ready-for-analyse.log`;
2. Führen Sie `scheme --script tests/log-debug.sps` aus. Wenn Sie die Multi-Thread-Umgebung reproduzieren möchten, können Sie ebenfalls `scheme --script tests/log-debug.sps` ausführen.

## Test
Fast alle wichtigen Prozeduren und APIs sind getestet. Meine Arbeit ist zwar grob, aber nützlich. Vielleicht möchten Sie herausfinden, was ich im Verzeichnis `tests` gemacht habe, oder einfach den folgenden Befehl im `{scheme-langserver-root-directory}` ausführen:
``` bash
bash test.sh
```
>HINWEIS
Es ist schwierig, Tests in einer Multi-Thread-Umgebung durchzuführen. Daher konzentrieren sich die aktuellen Tests auf den Single-Thread-Betrieb.

## Scheme-langserver für andere Zwecke verwenden
### Script-Fu in GIMP
Script-Fu basiert auf einer interpretierten Sprache namens Scheme und funktioniert, indem es mit Funktionen arbeitet, die mit den internen Funktionen von GIMP interagieren. Am Beispiel des [Skripts auf dieser Seite](https://dalelane.co.uk/blog/?p=628) können Sie scheme-langserver mit Skriptdateien mit der Erweiterung "SCM" verwenden.

### Sonstiges

Ich interessiere mich auch für [OMN (Opusmodus Notation)](https://opusmodus.com/) und AutoLisp. Aber ich habe noch viele andere Dinge zu erledigen.

## Code-Zeilen zählen
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Ausführliche Dokumentation
1. [Scheme-langserver: Scheme-Code-Bearbeitung als zentrales Anliegen behandeln](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Auffinden von Identifier-Bindungen](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronisierung](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Typinferenz](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Veraltet, und ich schreibe derzeit ein chinesisches Buch darüber)
5. [API Analyse](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star-Verlauf

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Mitwirkende

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---