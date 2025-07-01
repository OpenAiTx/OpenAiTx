![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

Puoi leggere il mio [articolo](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) e citarlo così:
> WANG, Z. (2025, 12 maggio). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurigo. https://doi.org/10.5281/zenodo.15384882

Poiché GitHub potrebbe bloccare gli indirizzi IP cinesi, ho dovuto copiare questo repository [qui](https://codeberg.org/ufo5260987423/scheme-langserver) e [qui](https://gitee.com/ufo5260987423/scheme-langserver). Continuerò ad aggiornare tutti i repository ma non posso garantirlo. Ora collaboro anche con [XmacsLabs](https://github.com/XmacsLabs), puoi trovare un fork anche [qui](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**Ora, VSCode può usare scheme-langserver!** Fai riferimento [QUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>NOTA: Ci sono molti, molti bug in scheme-langserver. Li sto correggendo e sto chiedendo aiuto alla comunità. Per favore, sii paziente.

>NOTA: puoi trovare le informazioni sui tipi generate automaticamente [qui](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). Attualmente sono utilizzate principalmente per lo sviluppo della prossima fase (forse incluso AKKU) e per il debugging.

Implementare il supporto come completamento automatico, vai alla definizione o documentazione al passaggio del mouse è un impegno significativo per la programmazione. Tuttavia, rispetto ad altri linguaggi come java, python, javascript e c, le implementazioni del language server protocol per i linguaggi lisp sono state sviluppate in un vuoto. [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) e [swish-lint](https://github.com/becls/swish-lint) ecc., i loro lavori si basano tutti su `repl` (Read-Eval-Print Loop) o tokenizzatori di parole chiave invece che sulla programmazione. Ad esempio, se un programmatore stesse lavorando su un progetto non completato, in cui i codici non sono completamente eseguibili, [Geiser](https://gitlab.com/emacs-geiser) o altri completerebbero solo gli identificatori di binding di livello superiore elencati dalla procedura `environment-symbols` (per [Chez](https://cisco.github.io/ChezScheme/)), o completerebbero simboli invece di identificatori. Il che significa che per i binding locali e i codici incompleti, anche se lo sforzo per la programmazione dovrebbe essere considerato di primaria importanza, [Geiser](https://gitlab.com/emacs-geiser) e i suoi omologhi non aiutano a riconoscere lo scope valido di un identificatore. Casi simili si verificano con il vai alla definizione e molte altre funzionalità.

Una delle cause principali è che, per scheme e altri dialetti lisp, l'abbondanza di set di dati e le strutture di controllo flessibili rendono l'analisi del programma una grande sfida. Soprattutto la macro, sembra che scheme sia utilizzato principalmente per la programmazione geniale e meta/macro. Ma io dico di no. Scheme può fare molte cose interessanti se viene fornito un ambiente di programmazione migliore. E ora puoi [**INIZIARE QUI**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

Questo pacchetto è un'implementazione del language server protocol che aiuta la programmazione in scheme. Fornisce completamento, definizione e inferenza dei tipi. Queste funzionalità sono basate sull'analisi statica del codice con [standard r6rs](http://www.r6rs.org/) e alcune regole ovvie per i codici incompleti. Questo pacchetto e le librerie correlate sono pubblicate o saranno pubblicate con [Akku](https://akkuscm.org/), che è un gestore di pacchetti per Scheme.

Questo pacchetto è stato anche testato con [Chez Scheme](https://cisco.github.io/ChezScheme/) versione 9.4 e 9.5. Un test dettagliato sulla versione 10.0.0 sarà eseguito dopo l'aggiornamento del mio sistema operativo a una versione più recente.

Faccio questo lavoro open source solo nel mio tempo libero e posso contribuire con molte idee brillanti alla comunità, come integrare l'analisi del flusso di dati in scheme-langserver o molte altre cose. E sto continuamente chiedendo più donazioni o finanziamenti. Puoi donare tramite [questa pagina Patreon](https://www.patreon.com/PoorProgrammer/membership) o [爱发电](https://afdian.com/a/ufo5260987423).


## Compilazione, Installazione & Configurazione sono [QUI](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## Stato Recente
Continuerò a correggere bug, profilare il codice e raccogliere informazioni per il mio grande libro sui sistemi di inferenza dei tipi fatti in casa. Questo mi porterà circa 1 anno. Sviluppi futuri includono un plugin per [VScode](https://code.visualstudio.com/) e analisi del flusso di dati. Ma in realtà, ora considero questo lavoro open source come un lavoro part-time, e non posso garantire una tabella di marcia.

## Release 
1.2.9 Ora, goditi l'inferenza dei tipi!

Per le release precedenti fai riferimento a [questo file](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### Funzionalità
1. Completamento dei binding di identificatori di livello superiore e locale.
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. Vai alla definizione.
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. Compatibile con il gestore di pacchetti: Akku.
4. Sincronizzazione delle modifiche ai file e cambiamento degli indici corrispondenti.
5. Hover.
6. Riferimenti e evidenziazione dei documenti (riferimenti a livello di documento).
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. Simbolo del documento.
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. Cattura del binding locale degli identificatori basati su *-syntax (define-syntax, let-syntax, ecc.).
9. Indicizzazione parallela cross-platform.
10. Annotatore del codice sorgente fatto in casa per compatibilità con file .sps.
11. Ottimizzazione peephole per richieste API con task sospendibile.
12. Inferenza dei tipi con un interprete DSL fatto in casa (ne sono molto orgoglioso!). Ed ora è stato integrato nel completamento automatico. Come indicato nella figura seguente, "length-b" e "length-a" di tipo "integer?" sono in cima alle opzioni raccomandate perché possono soddisfare il tipo di parametro richiesto da "<=".
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
Un test può dimostrare questo risultato, basta eseguire `scheme --script tests/protocol/apis/test-completion.sps` e il file di log `scheme-langserver.log` conterrà risultati come questo:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. Interprete astratto per la cattura degli identificatori tra diverse estensioni di file come scm, ss, sps, sls e sld.

### TODOs
14. Rinominare.
15. Compatibilità completa con [standard r6rs](http://www.r6rs.org/).
16. Espansore macro step-by-step: in realtà ne ho già implementato uno e volevo renderlo uno step chiave per catturare il binding degli identificatori nelle macro definite dall'utente. Ora, trovo che questa cattura sia molto più difficile di quanto pensassi, e l'espansore non so dove potrebbe funzionare.
17. Eval del codice.
18. Diagnostica del codice.
19. Aggiungere supporto semantico cross-language. Beh, potrebbero essere supportati java, c, python e molti altri linguaggi con un trasformatore AST?
20. Estrarre espressioni/istruzioni in una procedura.

## TODO:Contribuire 

## Debug

### Come fare debug
https://www.scheme.com/debug/debug.html#g1

### Output Log
Seguendo i suggerimenti da [Compilazione](#building), [Installazione per Lunar Vim](#installation-for-lunarvim) e [Installazione per VScode](#todo-installation-for-vscode), se qualcuno vuole fare del development e loggare qualcosa, sarà conveniente aggiungere `path-to-log-file` e riscrivere il file `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` come segue:
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
Con il [log di output](#output-log) sopra, puoi utilizzare `tests/log-debug.sps` per ricorrere ai bug:
1. Rinomina `{path-to-log}` (di solito `~/scheme-langserver.log`) in `~/ready-for-analyse.log`;
2. esegui `scheme --script tests/log-debug.sps`. Se vuoi riprodurre l'ambiente multi-thread, è anche possibile eseguire `scheme --script tests/log-debug.sps`.

## Test
Quasi tutte le procedure chiave e le API sono testate. Il mio lavoro è solo grezzo ma utile; forse vorrai vedere cosa ho fatto nella directory `tests` oppure eseguire il seguente comando nella `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>NOTA
È difficile testare con un ambiente multi-thread. Pertanto, i test attuali si concentrano su un singolo thread.

## Usare Scheme-langserver per Altri Scopi
### Script-Fu in GIMP
Script-Fu si basa su un linguaggio interpretato chiamato Scheme, e funziona usando funzioni che interagiscono con le funzioni interne di GIMP. Prendendo come esempio lo script di [questa pagina](https://dalelane.co.uk/blog/?p=628), puoi applicare scheme-langserver a file script con estensione "SCM".

### Altri

Bene, sono anche interessato a [OMN (Opusmodus Notation)](https://opusmodus.com/) e AutoLisp. Ma ho ancora molte cose da fare.

## Conteggio del Codice
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## Documentazione Dettagliata
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [Catching identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizing](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(Obsoleto, e sto scrivendo un libro in cinese a riguardo)
5. [API Analysis](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## Collaboratori

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---