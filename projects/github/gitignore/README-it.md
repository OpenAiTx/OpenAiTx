# Una raccolta di template `.gitignore`

Questa è la raccolta di GitHub di template di file [`.gitignore`][man].  
Utilizziamo questa lista per popolare i selettori di template `.gitignore` disponibili
nell'interfaccia di GitHub.com durante la creazione di nuovi repository e file.

Per ulteriori informazioni su come funzionano i file `.gitignore` e su come utilizzarli,
le seguenti risorse sono un ottimo punto di partenza:

- Il [capitolo Ignorare i file][chapter] del libro [Pro Git][progit].
- L’[articolo Ignorare i file][help] sul sito di supporto GitHub.
- La pagina del manuale [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore  
[help]: https://help.github.com/articles/ignoring-files  
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring  
[progit]: https://git-scm.com/book

## Struttura delle cartelle

Supportiamo una raccolta di template, organizzata in questo modo:

- La cartella principale contiene template di uso comune, per aiutare gli utenti a iniziare
  con i linguaggi di programmazione e le tecnologie più popolari. Questi definiscono un insieme significativo
  di regole per aiutare a iniziare e assicurano che non vengano aggiunti al repository
  file non importanti.
- [`Global`](./Global) contiene template per vari editor, strumenti e
  sistemi operativi che possono essere utilizzati in diverse situazioni. Si consiglia
  di [aggiungerli al template globale](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  oppure di unire queste regole nei template specifici del progetto se si desidera utilizzarli in modo permanente.
- [`community`](./community) contiene template specializzati per altri linguaggi,
  strumenti e progetti popolari, che attualmente non rientrano nei template principali. Questi
  dovrebbero essere aggiunti ai template specifici del progetto quando si decide di adottare il framework o lo strumento.

## Cosa rende buono un template?

Un template dovrebbe contenere un insieme di regole per aiutare i repository Git a lavorare con uno
specifico linguaggio di programmazione, framework, strumento o ambiente.

Se non è possibile curare un insieme ristretto di regole utili per questa situazione,
allora il template non è adatto per questa raccolta.

Se un template è principalmente un elenco di file installati da una particolare versione di
un software (es. un framework PHP), può essere inserito nella cartella `community`.
Vedi la sezione [template versionati](#versioned-templates) per maggiori dettagli.

Se hai un insieme ristretto di regole, o vuoi supportare una tecnologia non
ampiamente utilizzata, e credi comunque che possa essere utile ad altri, leggi la
sezione sui [template specializzati](#specialized-templates) per maggiori dettagli.

Includi dettagli quando apri una pull request se il template è importante e visibile. Potremmo
non accettarlo immediatamente, ma potremo promuoverlo nella cartella principale in un secondo momento
in base all'interesse.

Comprendi anche che non possiamo elencare ogni strumento mai esistito.
Il nostro obiettivo è curare una raccolta dei template _più comuni e utili_,
non assicurarci di coprire ogni possibile progetto. Se scegliamo di non
includere il tuo linguaggio, strumento o progetto, non è perché non sia valido.

## Linee guida per contribuire

Ci piacerebbe che ci aiutassi a migliorare questo progetto. Per aiutarci a mantenere alta la qualità di questa raccolta,
richiediamo che i contributi rispettino le seguenti linee guida.

- **Fornisci un link alla homepage dell’applicazione o del progetto**. A meno che non sia
  estremamente popolare, è possibile che i manutentori non conoscano o non utilizzino
  il linguaggio, il framework, l’editor, l’app o il progetto a cui si applica la tua modifica.

- **Fornisci link alla documentazione** che supportino la modifica che stai apportando.
  La documentazione attuale e ufficiale che menziona i file da ignorare è la migliore.
  Se la documentazione non è disponibile, spiega nel miglior modo possibile a cosa servono
  i file ignorati.

- **Spiega perché stai apportando una modifica**. Anche se può sembrare ovvio, per favore
  aggiungi una o due frasi per dirci perché dovrebbe essere fatta la tua modifica o aggiunta.
  È particolarmente utile spiegare perché questa modifica si applica a _tutti_
  coloro che lavorano con la tecnologia in questione, non solo a te o al tuo team.

- **Considera l’ambito della tua modifica**. Se la tua modifica è specifica per un
  certo linguaggio o framework, assicurati che venga applicata al
  template relativo a quel linguaggio o framework, piuttosto che a quello di un editor, strumento o sistema operativo.

- **Modifica _un solo template_ per pull request**. Questo aiuta a mantenere le pull
  request e i feedback focalizzati su uno specifico progetto o tecnologia.

In generale, più ci aiuti a capire la modifica che stai apportando,
più probabilmente accetteremo rapidamente il tuo contributo.

## Template versionati

Alcuni template possono cambiare notevolmente tra le versioni e, se desideri contribuire
a questo repository, dobbiamo seguire questo flusso specifico:

- il template nella cartella principale deve essere la versione attualmente supportata
- il template nella cartella principale non deve avere la versione nel nome del file (cioè
  "sempreverde")
- le versioni precedenti dei template devono essere inserite in `community/`
- le versioni precedenti del template devono includere la versione nel nome del file,
  per chiarezza

Questo aiuta a garantire che gli utenti ottengano l’ultima versione (perché useranno quella nella cartella principale) ma aiuta i manutentori a supportare anche le versioni meno recenti ancora in uso.

## Template specializzati

Se hai un template che vorresti contribuire, ma non è propriamente
mainstream, considera di aggiungerlo nella cartella `community` sotto la
cartella che meglio rappresenta dove dovrebbe trovarsi.

Le regole nel tuo template specializzato dovrebbero essere specifiche per il framework o
lo strumento, e ogni template aggiuntivo dovrebbe essere menzionato in un commento nell’intestazione del template.

Ad esempio, questo template potrebbe trovarsi in `community/DotNet/InforCRM.gitignore`:

```
# template gitignore per InforCRM (precedentemente SalesLogix)
# sito web: https://www.infor.com/product-summary/cx/infor-crm/
#
# Consigliato: VisualStudio.gitignore

# Ignora file modello generati automaticamente
ModelIndex.xml
ExportedFiles.xml

# Ignora file di deploy
[Mm]odel/[Dd]eployment

# Forza l'inclusione dei SupportFiles del portale
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Workflow per contribuire

Ecco come suggeriamo di proporre una modifica a questo progetto:

1. [Forka questo progetto][fork] sul tuo account.
2. [Crea un branch][branch] per la modifica che intendi apportare.
3. Apporta le modifiche al tuo fork.
4. [Invia una pull request][pr] dal branch del tuo fork al nostro branch `main`.

Anche utilizzare l’interfaccia web per fare modifiche va bene e ti aiuterà
forkando automaticamente il progetto e suggerendoti di inviare una pull request.

[fork]: https://help.github.com/articles/fork-a-repo/  
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository  
[pr]: https://help.github.com/articles/using-pull-requests/

## Licenza

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---