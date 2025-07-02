<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

Puoi leggere il mio [articolo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) e citarlo così:
> WANG, Z. (2025, 12 maggio). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurigo. https://doi.org/10.5281/zenodo.15384882

Poiché GitHub potrebbe bloccare gli indirizzi IP cinesi, ho dovuto copiare questo repository anche [qui](https://codeberg.org/ufo5260987423/scheme-langserver) e [qui](https://gitee.com/ufo5260987423/scheme-langserver). Continuerò ad aggiornare tutti i repository ma non posso garantirlo. Ora collaboro anche con [XmacsLabs](https://github.com/XmacsLabs), puoi trovare una fork anche [qui](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Ora VSCode può usare scheme-langserver!** Fai riferimento [QUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTA: Ci sono moltissimi bug in scheme-langserver. Li sto correggendo e sto chiedendo aiuto alla comunità. Per favore, sii paziente.

>NOTA: puoi trovare le informazioni sui tipi generate automaticamente [qui](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Ora sono principalmente utilizzate per lo sviluppo della prossima fase (forse includendo AKKU) e il debugging.

Implementare funzionalità come autocomplete, vai alla definizione o documentazione al passaggio del mouse è uno sforzo significativo nella programmazione. Tuttavia, rispetto ad altri linguaggi come java, python, javascript e c, le implementazioni del language server protocol per i linguaggi lisp sono realizzate quasi nel vuoto. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) e [swish-lint](https://github.com/becls/swish-lint) ecc., i loro lavori sono tutti basati su `repl` (Read-Eval-Print Loop) o su un tokenizzatore di parole chiave invece che sulla programmazione. Ad esempio, se un programmatore stava scrivendo codice su un progetto non completato, in cui i codici non erano completamente eseguibili, [Geiser](https://gitlab.com/emacs-geiser) o altri completavano solo gli identificatori legati al livello superiore elencati dalla procedura `environment-symbols` (per [Chez](https://cisco.github.io/ChezScheme/)), oppure completavano simboli invece di identificatori. Questo significa che per i binding locali e i codici non completati, anche se l’impegno per la programmazione dovrebbe essere di primaria importanza, [Geiser](https://gitlab.com/emacs-geiser) e simili non aiutano affatto nel riconoscere l’ambito valido degli identificatori. Casi simili si verificano con "vai alla definizione" e molte altre funzionalità.

Una causa principale è che, per scheme e altri dialetti lisp, l'abbondanza di set di dati e la flessibilità delle strutture di controllo rendono l’analisi del programma una grande sfida. Soprattutto per le macro, sembra che scheme sia usato principalmente per la programmazione geniale e meta/macro. Ma io dico di no. Scheme può realizzare molte cose interessanti se viene fornito un ambiente di programmazione migliore. E ora puoi [**INIZIARE QUI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Questo pacchetto è un’implementazione del language server protocol che aiuta la programmazione in scheme. Fornisce completamento, definizione e inferenza dei tipi. Queste funzionalità sono basate sull’analisi statica del codice secondo lo [standard r6rs](http://www.r6rs.org/) e alcune regole ovvie per i codici non completati. Questo pacchetto e le librerie correlate sono pubblicate o saranno pubblicate con [Akku](https://akkuscm.org/), che è un package manager per Scheme.

Questo pacchetto è stato anche testato con [Chez Scheme](https://cisco.github.io/ChezScheme/) versione 9.4 e 9.5. Un test dettagliato sulla versione 10.0.0 verrà effettuato dopo l’aggiornamento del mio laptop a una versione più recente del sistema operativo.

Faccio questo lavoro open source solo nel mio tempo libero e posso contribuire molte idee brillanti alla comunità, come incorporare l’analisi del flusso dei dati in scheme-langserver o molte altre cose. E sto continuamente chiedendo donazioni o finanziamenti. Puoi donare tramite [questa pagina patreon](https://www.patreon.com/PoorProgrammer/membership) oppure tramite [爱发电](https://afdian.com/a/ufo5260987423).


## Compilazione, Installazione & Configurazione sono [QUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Stato Attuale
Continuerò a correggere bug, profilare il codice e raccogliere informazioni per il mio grande libro sui sistemi di inferenza dei tipi fatti in casa. Questo mi porterà circa 1 anno. Sviluppi futuri includono un plugin per [VScode](https://code.visualstudio.com/) e l’analisi del flusso dei dati. Ma in realtà, ora considero questo lavoro open source come un lavoro part-time e non posso garantire una tabella di marcia.

## Release 
1.2.9 Ora, divertiti con l’inferenza dei tipi!

Per le versioni precedenti fai riferimento a [questo file](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funzionalità
1. Completamento di binding di identificatori a livello superiore e locale.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Vai alla definizione.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatibile con il package manager: Akku.
4. Sincronizzazione delle modifiche ai file e aggiornamento corrispondente degli indici.
5. Hover.
6. Riferimenti e evidenziazione nel documento (riferimenti a livello di documento).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Simboli del documento.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Cattura dei binding locali basati su *-syntax (define-syntax, let-syntax, ecc.).
9. Indicizzazione parallela cross-platform.
10. Annotatore di codice sorgente auto-prodotto compatibile con file .sps.
11. Ottimizzazione peephole per richieste API con task sospendibili.
12. Inferenza dei tipi con un interprete DSL fatto in casa (ne sono molto orgoglioso!). Ora è stato integrato nell’autocompletamento. Come indicato nella figura seguente, “length-b” e “length-a” con tipo “integer?” sono davanti nelle opzioni consigliate perché possono corrispondere al tipo di parametro richiesto da “<=”.
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Un test può dimostrare questo risultato, basta eseguire `scheme --script tests/protocol/apis/test-completion.sps` e il file di log `scheme-langserver.log` conterrà risultati simili a questi:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interprete astratto per la cattura degli identificatori tra diverse estensioni di file come scm, ss, sps, sls e sld.

### DA FARE
14. Rinominare.
15. Piena compatibilità con lo [standard r6rs](http://www.r6rs.org/).
16. Espansore macro step-by-step: in realtà ne ho già implementato uno e volevo renderlo un passaggio chiave per la cattura dei binding degli identificatori nelle macro auto-definite. Ora, trovo che questa cattura sia molto più difficile di quanto pensassi, e l’espansore non so dove potrebbe funzionare.
17. Valutazione del codice.
18. Diagnostica del codice.
19. Aggiungere il supporto semantico cross-language. Beh, Java, C, Python e molti altri linguaggi possono essere supportati tramite un trasformatore AST?
20. Estrarre espressioni/istruzioni in una procedura.

## TODO:Contributi

## Debug

### Come eseguire il debug
https://www.scheme.com/debug/debug.html#g1

### Output Log
Seguendo i suggerimenti da [Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) e [Installation for VScode](#todo-installation-for-vscode), se qualcuno vuole fare un po' di sviluppo e loggare qualcosa, sarà conveniente aggiungere `path-to-log-file` e riscrivere il file `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` come segue:
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
`scheme-langserver`, un'implementazione del language server protocol per scheme
]]   ,
  },
}
```
### Ricorrenza con Log
Con il precedente [output log](#output-log), puoi usare `tests/log-debug.sps` per riprodurre i bug:
1. Rinomina `{path-to-log}` (di solito `~/scheme-langserver.log`) in `~/ready-for-analyse.log`;
2. esegui `scheme --script tests/log-debug.sps`. Se vuoi riprodurre l'ambiente multi-thread, puoi anche eseguire `scheme --script tests/log-debug.sps`.

## Test
Quasi tutte le procedure chiave e le API sono testate. Il mio lavoro è piuttosto grezzo ma utile, forse ti piacerebbe vedere cosa ho fatto nella directory `tests` o semplicemente eseguire il seguente comando nella `{scheme-langserver-root-directory}`
```bash
bash test.sh
```
>NOTA  
È difficile testare in ambiente multi-thread. Quindi, i test attuali si concentrano sul single thread.

## Usare Scheme-langserver per altri scopi
### Script-Fu in GIMP
Script-Fu si basa su un linguaggio interpretato chiamato Scheme e funziona utilizzando funzioni che interagiscono con le funzioni interne di GIMP. Prendendo come esempio lo script di [questa pagina](https://dalelane.co.uk/blog/?p=628), puoi applicare scheme-langserver con file script con estensione "SCM".

### Altro

Beh, sono anche interessato a [OMN (Opusmodus Notation)](https://opusmodus.com/) e AutoLisp. Ma ho ancora molte cose da fare.

## Conteggio del codice
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentazione dettagliata
1. [Scheme-langserver: Trattare l'editing del codice Scheme come una priorità](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Catturare i binding degli identificatori](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Sincronizzazione](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Inferenza di tipo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Deprecato, e sto scrivendo un libro in cinese su questo)
5. [Analisi API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Storico delle Stelle

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Contributori

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---