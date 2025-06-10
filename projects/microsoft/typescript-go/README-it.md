# TypeScript 7

[Non sei sicuro di cosa sia? Leggi il post di annuncio!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Anteprima

Una build di anteprima è disponibile su npm come `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Usalo come useresti tsc.
```

Un’estensione di anteprima per VS Code è [disponibile nel marketplace di VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Per utilizzarla, imposta questa configurazione nelle impostazioni di VS Code:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Come Compilare ed Eseguire

Questo repository utilizza [Go 1.24 o superiore](https://go.dev/dl/), [Rust 1.85 o superiore](https://www.rust-lang.org/tools/install), [Node.js con npm](https://nodejs.org/) e [`hereby`](https://www.npmjs.com/package/hereby).

Per i test e la generazione del codice, questo repository contiene un submodule git al repository principale di TypeScript che punta al commit in fase di porting.
Quando cloni il repository, conviene clonare con i submodule:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Se hai già clonato il repository, puoi inizializzare il submodule con:

```sh
git submodule update --init --recursive
```

Con il submodule a posto e `npm ci`, puoi eseguire i task tramite `hereby`, in modo simile al repository TypeScript:

```sh
hereby build          # Verifica che il progetto compili
hereby test           # Esegui tutti i test
hereby install-tools  # Installa strumenti aggiuntivi come i linters
hereby lint           # Esegui tutti i linters
hereby format         # Formattta tutto il codice
hereby generate       # Genera tutto il codice Go (es. diagnostica, committato nel repo)
```

Task aggiuntivi sono in lavorazione.

`hereby` non è richiesto per lavorare sul repository; il normale tooling `go` (es., `go build`, `go test ./...`) funzionerà come previsto.
I task `hereby` sono forniti per comodità a chi ha familiarità con il repository TypeScript.

### Esecuzione di `tsgo`

Dopo aver eseguito `hereby build`, puoi eseguire `built/local/tsgo`, che si comporta quasi esattamente come `tsc`.

### Esecuzione del Prototipo LSP

Per eseguire il debug e avviare l’estensione VS Code senza installarla globalmente:

* Avvia VS Code nella workspace del repository (`code .`)
* Copia `.vscode/launch.template.json` in `.vscode/launch.json`
* <kbd>F5</kbd> (oppure `Debug: Start Debugging` dal command palette)

Questo avvierà una nuova istanza di VS Code che utilizza Corsa LS come backend. Se tutto è configurato correttamente, dovresti vedere "tsgo" nella barra di stato quando un file TypeScript o JavaScript è aperto:

![Screenshot del Prototipo LSP](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## Cosa Funziona Finora?

Questo è ancora un lavoro in corso e non è ancora alla piena parità di funzionalità con TypeScript. Potrebbero esserci bug. Controlla attentamente questa lista prima di aprire una nuova issue o supporre un cambiamento intenzionale.

| Funzionalità | Stato | Note |
|--------------|-------|------|
| Creazione del programma | fatto | Stessi file e risoluzione dei moduli di TS5.8. Non tutte le modalità di risoluzione sono ancora supportate. |
| Parsing/scanning | fatto | Esattamente stessi errori di sintassi di TS5.8 |
| Commandline e parsing di `tsconfig.json` | quasi fatto | Entry point leggermente diverso per ora |
| Risoluzione dei tipi | fatto | Stessi tipi di TS5.8 |
| Type checking | fatto | Stessi errori, posizioni e messaggi di TS5.8. La stampa dei tipi negli errori potrebbe essere visualizzata in modo diverso (in lavorazione) |
| Inferenza specifica JavaScript e JS Doc | non pronto | - |
| JSX | fatto | - |
| Emissione delle dichiarazioni | in lavorazione | Le funzionalità più comuni sono implementate, ma alcuni edge case e flag non sono ancora gestiti |
| Emissione (output JS) | in lavorazione | `target: esnext` ben supportato, altri target potrebbero avere lacune |
| Modalità watch | prototipo | Sorveglia i file e ricompila, ma nessuna ricontrollo incrementale |
| Modalità build / riferimenti a progetti | non pronto | - |
| Build incrementale | non pronto | - |
| Language service (LSP) | prototipo | Funzionalità minima (errori, hover, go to def). Altre funzionalità in arrivo |
| API | non pronto | - |

Definizioni:

 * **fatto** ovvero "ritenuto completo": Al momento non siamo a conoscenza di carenze o lavori importanti da completare. OK segnalare bug.
 * **in lavorazione**: attualmente in sviluppo; alcune funzionalità potrebbero funzionare, altre no. OK segnalare panics, ma niente altro per favore.
 * **prototipo**: solo proof-of-concept; non segnalare bug
 * **non pronto**: non abbiamo ancora iniziato o siamo lontani dalla prontezza, quindi non perdere tempo a provarlo.

## Altre Note

A lungo termine, ci aspettiamo che questo repository e i suoi contenuti vengano uniti in `microsoft/TypeScript`.
Di conseguenza, il repository e il tracker delle issue per typescript-go verranno eventualmente chiusi, quindi considera di conseguenza discussioni/issue.

Per un elenco dei cambiamenti intenzionali rispetto a TypeScript 5.7, vedi CHANGES.md.

## Contribuire

Questo progetto accetta contributi e suggerimenti. La maggior parte dei contributi richiede che tu accetti un
Contributor License Agreement (CLA) dichiarando che hai il diritto di, e in effetti, concederci
i diritti di utilizzare il tuo contributo. Per dettagli, visita [Contributor License Agreements](https://cla.opensource.microsoft.com).

Quando invii una pull request, un bot CLA determinerà automaticamente se devi fornire
un CLA e aggiornerà la PR di conseguenza (es. status check, commento). Segui semplicemente le istruzioni
fornite dal bot. Dovrai farlo solo una volta per tutti i repository che utilizzano il nostro CLA.

Questo progetto ha adottato il [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Per ulteriori informazioni vedi le [FAQ sul Codice di Condotta](https://opensource.microsoft.com/codeofconduct/faq/) oppure
contatta [opencode@microsoft.com](mailto:opencode@microsoft.com) per eventuali domande o commenti aggiuntivi.

## Marchi

Questo progetto potrebbe contenere marchi o loghi di progetti, prodotti o servizi. L’uso autorizzato dei marchi o loghi Microsoft è soggetto e deve rispettare le
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
L’utilizzo dei marchi o loghi Microsoft in versioni modificate di questo progetto non deve causare confusione o implicare sponsorizzazione da parte di Microsoft.
Qualsiasi utilizzo di marchi o loghi di terzi è soggetto alle politiche di tali terze parti.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---