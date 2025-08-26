
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Un'applicazione Rust che converte immagini di container (Docker, ecc.) in repository Git. Ogni layer del container è rappresentato come un commit Git, preservando la cronologia e la struttura dell'immagine originale.

![Dimostrazione di OCI2Git che converte l'immagine nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Funzionalità

- Analizza le immagini Docker ed estrai le informazioni sui layer
- Crea un repository Git dove ogni layer dell'immagine è rappresentato come un commit
- Supporto per layer vuoti (ENV, WORKDIR, ecc.) come commit vuoti
- Estrazione completa dei metadati in formato Markdown
- Architettura estensibile per supportare diversi motori container

## Casi d'Uso

### Differenziazione dei Layer
Durante la risoluzione di problemi nei container, puoi utilizzare le potenti funzionalità di differenziazione di Git per identificare esattamente cosa è cambiato tra due layer qualsiasi. Eseguendo `git diff` tra i commit, gli ingegneri possono vedere precisamente quali file sono stati aggiunti, modificati o eliminati, rendendo molto più semplice comprendere l'impatto di ogni istruzione Dockerfile e individuare cambiamenti problematici.
![Esempio di differenza tra layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Tracciamento dell'Origine
Utilizzando `git blame`, gli sviluppatori possono determinare rapidamente quale layer ha introdotto uno specifico file o linea di codice. Questo è particolarmente utile durante la diagnosi di problemi con file di configurazione o dipendenze. Invece di ispezionare manualmente ogni layer, puoi immediatamente tracciare l'origine di qualsiasi file fino al suo layer sorgente e all'istruzione Dockerfile corrispondente.

### Tracciamento del Ciclo di Vita dei File
OCI2Git ti permette di seguire il percorso di uno specifico file durante la storia dell'immagine del container. Puoi osservare quando un file è stato creato inizialmente, come è stato modificato nei vari layer e se/quando è stato eventualmente rimosso. Questa visione completa aiuta a comprendere l'evoluzione del file senza dover tracciare manualmente i cambiamenti tra decine di layer.

Per tracciare la cronologia di un file nella tua immagine container — incluso quando è apparso per la prima volta, è stato modificato o eliminato — puoi utilizzare questi comandi Git dopo la conversione:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Questi comandi rendono semplice tracciare la storia completa di qualsiasi file attraverso i livelli del container, senza la complessità di estrarre e confrontare manualmente i tarball dei livelli.

### Analisi Multi-Livello
Talvolta i confronti più significativi emergono esaminando le modifiche tra più livelli non consecutivi. Con OCI2Git, puoi utilizzare gli strumenti di confronto di Git per analizzare come i componenti si sono evoluti durante più fasi di build, identificando schemi che potrebbero essere invisibili osservando solo i livelli adiacenti.

### Esplorazione dei Livelli
Utilizzando `git checkout` per spostarti su uno specifico commit, puoi esaminare il filesystem del container esattamente come esisteva in quel livello. Questo permette agli sviluppatori di ispezionare lo stato preciso di file e directory in qualsiasi momento del processo di creazione dell'immagine, fornendo un contesto prezioso durante il debug o l’analisi del comportamento del container.
![Checkout a un commit precedente](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analisi Multi-Immagine

Quando si lavora con più immagini container che condividono una discendenza comune, OCI2Git crea intelligentemente dei branch solo quando le immagini effettivamente divergono. Questo ti permette di analizzare più immagini correlate in un unico repository, preservando la loro storia comune.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```

OCI2Git rileva automaticamente i layer condivisi tra le immagini e crea una struttura ramificata che riflette la loro base comune. La cronologia Git mostrerà:
- Un tronco comune che contiene tutti i layer condivisi
- Rami separati che divergono solo quando le immagini sono effettivamente diverse
- Visualizzazione chiara di dove le immagini condividono una discendenza comune rispetto a dove diventano uniche
- Gestione intelligente dei duplicati: se la stessa immagine viene processata due volte, l'algoritmo lo rileva prima del commit finale dei metadati e evita di creare un ramo duplicato

Questo approccio è particolarmente utile per:
- **Analisi della Famiglia di Immagini**: Comprendere come diverse varianti di un'immagine (diverse versioni, architetture o configurazioni) si relazionano tra loro
- **Impatto della Base Immagine**: Vedere esattamente come le modifiche a una base immagine influenzano più immagini derivate
- **Opportunità di Ottimizzazione**: Identificare componenti condivisi che potrebbero essere meglio sfruttati tra le varianti di immagine

![Struttura del repository multi-immagine che mostra base condivisa e rami divergenti](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Casi d'Uso Aggiuntivi

- **Audit di Sicurezza**: Identificare esattamente quando pacchetti vulnerabili o configurazioni sono stati introdotti e risalire alle istruzioni di build specifiche.
- **Ottimizzazione delle Immagini**: Analizzare la struttura dei layer per trovare operazioni ridondanti o file grandi che potrebbero essere consolidati, aiutando a ridurre la dimensione dell'immagine.
- **Gestione delle Dipendenze**: Monitorare quando le dipendenze sono state aggiunte, aggiornate o rimosse lungo la storia dell'immagine.
- **Miglioramento del Processo di Build**: Esaminare la composizione dei layer per ottimizzare le istruzioni Dockerfile per un miglior caching e una dimensione dell'immagine ridotta.
- **Confronto tra Immagini**: Convertire più immagini correlate in repository Git e utilizzare gli strumenti di confronto di Git per analizzare le loro differenze e somiglianze.

## Installazione

### Da Sorgente

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Da Crates.io

```bash
cargo install oci2git
```

## Utilizzo

```bash
oci2git [OPTIONS] <IMAGE>
```

Argomenti:
  `<IMAGE>`  Nome dell'immagine da convertire (es. 'ubuntu:latest') o percorso al file tar quando si usa il motore tar

Opzioni:
  `-o, --output <o>`  Directory di output per il repository Git [default: ./container_repo]
  `-e, --engine <ENGINE>`  Motore container da usare (docker, nerdctl, tar) [default: docker]
  `-h, --help`            Stampa le informazioni di aiuto
  `-V, --version`         Stampa le informazioni sulla versione

Variabili d'Ambiente:
  `TMPDIR`  Imposta questa variabile d'ambiente per cambiare la posizione predefinita usata per l'elaborazione dei dati intermedi. Questa è dipendente dalla piattaforma (es. `TMPDIR` su Unix/macOS, `TEMP` o `TMP` su Windows).

## Esempi

Utilizzo del motore Docker (predefinito):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Utilizzo di un tarball di immagini già scaricato:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Il motore tar si aspetta un tarball in formato OCI valido, che viene tipicamente creato con `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Questo creerà un repository Git in `./ubuntu-repo` contenente:
- `Image.md` - Metadati completi sull'immagine in formato Markdown
- `rootfs/` - Il contenuto del filesystem dal container

La cronologia Git riflette la cronologia dei layer del container:
- Il primo commit contiene solo il file `Image.md` con tutti i metadati
- Ogni commit successivo rappresenta un layer dell'immagine originale
- I commit includono il comando Dockerfile come messaggio di commit

## Struttura del repository

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## Requisiti

- Edizione Rust 2021
- Docker CLI (per il supporto al motore Docker)
- Git

## Licenza

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---