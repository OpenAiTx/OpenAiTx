<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">Englisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Französisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Spanisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Russisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Portugiesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Niederländisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polnisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">Arabisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">Persisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Vietnamesisch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Sie können meine [Abhandlung](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) lesen und wie folgt zitieren: 
> WANG, Z. (2025, 12. Mai). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zürich. https://doi.org/10.5281/zenodo.15384882

Da GitHub möglicherweise chinesische IP-Adressen blockiert, musste ich dieses Repository auf [hier](https://codeberg.org/ufo5260987423/scheme-langserver) und [hier](https://gitee.com/ufo5260987423/scheme-langserver) kopieren. Ich werde alle Repositories weiterhin aktualisieren, aber ich kann es nicht garantieren. Ich arbeite jetzt auch mit [XmacsLabs](https://github.com/XmacsLabs) zusammen, Sie finden einen Fork auch [hier](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Jetzt kann VSCode scheme-langserver verwenden!** Bitte siehe [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>HINWEIS: Es gibt viele, viele Bugs im scheme-langserver. Ich bin gerade dabei, sie zu beheben und bitte die Community um Unterstützung. Bitte haben Sie Geduld.

>HINWEIS: Die automatisch generierten Typinformationen finden Sie [hier](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Sie werden derzeit hauptsächlich für die nächste Entwicklungsstufe (vielleicht inklusive AKKU) und zum Debuggen verwendet.

Die Implementierung von Unterstützungen wie Autovervollständigung, Gehe zu Definition oder Dokumentation beim Überfahren ist ein erheblicher Aufwand beim Programmieren. Im Vergleich zu anderen Sprachen wie Java, Python, JavaScript und C werden jedoch Implementierungen des Language Server Protocols für Lisp-Sprachen quasi im Vakuum entwickelt. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) und [swish-lint](https://github.com/becls/swish-lint) basieren alle auf `repl` (Read-Eval-Print Loop) oder Schlüsselwort-Tokenizern anstelle von Programmanalyse. Wenn beispielsweise ein Programmierer an einem unfertigen Projekt arbeitet, bei dem der Code noch nicht voll lauffähig ist, würden [Geiser](https://gitlab.com/emacs-geiser) oder andere nur Top-Level-Bindungsbezeichner auflisten, die von der Prozedur `environment-symbols` (für [Chez](https://cisco.github.io/ChezScheme/)) bereitgestellt werden, oder sie vervollständigen Symbole statt Bezeichner. Das bedeutet, dass für lokale Bindungen und unfertigen Code, obwohl programmatische Unterstützung eigentlich am wichtigsten wäre, [Geiser](https://gitlab.com/emacs-geiser) und Co. keinerlei Hilfe beim Erkennen des gültigen Gültigkeitsbereichs eines Bezeichners bieten. Ähnliche Probleme treten bei "Gehe zu Definition" und vielen anderen Funktionen auf.

Ein Hauptgrund dafür ist, dass Scheme und andere Lisp-Dialekte aufgrund ihrer reichen Datensätze und flexiblen Kontrollstrukturen große Herausforderungen für die Programmanalyse darstellen. Besonders Makros – es scheint, als sei Scheme hauptsächlich für Genies und Meta/Makro-Programmierung gedacht. Aber ich sage nein. Scheme kann viele interessante Dinge ermöglichen, wenn eine bessere Programmierumgebung bereitgestellt wird. Und jetzt können Sie [**HIER STARTEN**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Dieses Paket ist eine Implementation des Language Server Protocols zur Unterstützung der Scheme-Programmierung. Es bietet Vervollständigung, Definition und Typinferenz. Diese Funktionalitäten basieren auf statischer Codeanalyse nach dem [r6rs-Standard](http://www.r6rs.org/) und einigen offensichtlichen Regeln für unfertigen Code. Dieses Paket selbst und die zugehörigen Bibliotheken werden mit [Akku](https://akkuscm.org/) veröffentlicht oder sind zur Veröffentlichung vorgesehen. Akku ist ein Paketmanager für Scheme.

Dieses Paket wurde auch mit [Chez Scheme](https://cisco.github.io/ChezScheme/) Versionen 9.4 und 9.5 getestet. Ein detaillierter Test mit Version 10.0.0 folgt nach einem Upgrade meines Laptops auf eine neuere OS-Version.

Ich mache diese Open-Source-Arbeit nur in meiner Freizeit und kann viele brillante Ideen in die Community einbringen, wie die Integration von Data-Flow-Analyse in scheme-langserver oder viele andere Dinge. Und ich bitte weiterhin um mehr Spenden oder Förderung. Sie können über [diese Patreon-Seite](https://www.patreon.com/PoorProgrammer/membership) oder [爱发电](https://afdian.com/a/ufo5260987423) spenden.


## Kompilierung, Installation & Konfiguration sind [HIER](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Aktueller Status
Ich werde weiterhin Fehler beheben, den Code profilieren und Informationen für mein großes Buch über selbstgemachte Typinferenzsysteme sammeln. Das wird etwa 1 Jahr dauern. Weitere Entwicklungen umfassen ein [VScode](https://code.visualstudio.com/) Plugin und Data-Flow-Analyse. Tatsächlich ist dieses Open-Source-Projekt für mich jetzt eine Teilzeitbeschäftigung, und ich kann keinen Zeitplan garantieren.

## Release 
1.2.9 Jetzt: Viel Spaß mit der Typinferenz!

Frühere Releases siehe [diese Datei](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funktionen
1. Vervollständigung von Top-Level- und lokalen Bezeichnerbindungen.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Gehe zu Definition.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Kompatibel mit Paketmanager: Akku.
4. Dateiänderungen und entsprechende Indexänderungen werden synchronisiert.
5. Hover.
6. Referenzen und Dokument-Hervorhebung (dokumentbasierte Referenzen).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Dokumentensymbole.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Erkennung von *-Syntax (define-syntax, let-syntax, usw.)-basierten lokalen Bezeichnerbindungen.
9. Plattformübergreifendes paralleles Indexieren.
10. Selbstentwickelter Quellcode-Annotator zur Kompatibilität mit .sps-Dateien.
11. Peephole-Optimierung für API-Anfragen mit aussetzbarer Aufgabe.
12. Typinferenz mit selbstgebautem DSL-Interpreter (darauf bin ich sehr stolz!). Und jetzt ist sie in die Autovervollständigung eingebettet. Wie die folgende Abbildung zeigt, stehen die "length-b" und "length-a" mit Typ "integer?" an der Spitze der empfohlenen Optionen, weil sie zum vom "<="-Operator geforderten Parametertyp passen.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Ein Test kann dieses Ergebnis belegen, führen Sie einfach `scheme --script tests/protocol/apis/test-completion.sps` aus und die Logdatei `scheme-langserver.log` enthält Ergebnisse wie dieses:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Abstrakter Interpreter zur Bezeichnererkennung zwischen verschiedenen Dateiendungen wie scm, ss, sps, sls und sld.

### TODOs
14. Umbenennen.
15. Volle Kompatibilität mit dem [r6rs-Standard](http://www.r6rs.org/).
16. Schrittweiser Makro-Expander: Nun, ich habe tatsächlich einen implementiert und wollte ihn als Schlüssel zum Erkennen von Bezeichnerbindungen in selbstdefinierten Makros verwenden. Jetzt merke ich, dass diese Erkennung viel schwieriger ist als gedacht, und ich weiß nicht, wo der Expander tatsächlich zum Einsatz kommen kann.
17. Code-Auswertung.
18. Code-Diagnose.
19. Hinzufügen von semantischer Unterstützung für mehrere Sprachen. Nun, könnten Java, C, Python und viele andere Sprachen mit einem AST-Transformer unterstützt werden?
20. Extrahiere Ausdrücke/Anweisungen in eine Prozedur.

## TODO:Mitwirken

## Debuggen

### Wie man debuggt
https://www.scheme.com/debug/debug.html#g1

### Ausgabelog
Folgenden Tipps aus [Build-Prozess](#building), [Installation für Lunar Vim](#installation-for-lunarvim) und [Installation für VScode](#todo-installation-for-vscode) folgend, kann jeder, der etwas entwickeln und etwas loggen möchte, bequem `path-to-log-file` hinzufügen und die Datei `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` wie folgt umschreiben:
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
`scheme-langserver`, eine Implementierung des Language Server Protocols für Scheme
]]   ,
  },
}
```
### Wiederkehrende Fehlerbehebung mit Log
Mit obigem [Ausgabelog](#output-log) kann man mit `tests/log-debug.sps` Fehler wiederholt debuggen:
1. Benenne `{path-to-log}` (meistens `~/scheme-langserver.log`) um in `~/ready-for-analyse.log`;
2. Führe `scheme --script tests/log-debug.sps` aus. Wenn du die Multi-Thread-Umgebung reproduzieren möchtest, kannst du ebenfalls `scheme --script tests/log-debug.sps` ausführen.

## Test
Fast alle wichtigen Prozeduren und APIs sind getestet. Meine Arbeit ist zwar grob, aber nützlich; vielleicht möchtest du sehen, was ich im `tests`-Verzeichnis gemacht habe, oder einfach folgenden Befehl im `{scheme-langserver-root-directory}` ausführen:
``` bash
bash test.sh
```
>HINWEIS
Tests in einer Thread-Umgebung sind schwierig durchzuführen. Daher konzentrieren sich die aktuellen Tests auf Einzel-Thread-Betrieb.

## Scheme-langserver für andere Zwecke nutzen
### Script-Fu in GIMP
Script-Fu basiert auf einer interpretierten Sprache namens Scheme und funktioniert durch die Nutzung von Funktionen, die mit den internen Funktionen von GIMP interagieren. Am Beispiel des [Skripts auf dieser Seite](https://dalelane.co.uk/blog/?p=628) kannst du scheme-langserver mit Skriptdateien mit der Erweiterung "SCM" verwenden.

### Sonstiges

Nun, ich interessiere mich auch für [OMN (Opusmodus Notation)](https://opusmodus.com/) und AutoLisp. Aber ich habe noch viele andere Aufgaben zu erledigen.

## Code-Zeilen zählen
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Ausführliche Dokumentation
1. [Scheme-langserver: Scheme-Code-Bearbeitung als Hauptanliegen behandeln](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Erkennung von Bezeichnerbindungen](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronisation](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Typinferenz](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Veraltet, und ich schreibe dafür gerade ein chinesisches Buch)
5. [API-Analyse](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star-Historie

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Mitwirkende

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---