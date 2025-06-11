# Containerization

Il pacchetto Containerization consente alle applicazioni di utilizzare container Linux.  
Containerization è scritto in [Swift](https://www.swift.org) e utilizza [Virtualization.framework](https://developer.apple.com/documentation/virtualization) su Apple silicon.

Containerization fornisce API per:

- [Gestire immagini OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interagire con registri remoti](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Creare e popolare file system ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interagire con la famiglia di socket Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Creare un kernel Linux ottimizzato per tempi di avvio rapidi](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Avviare macchine virtuali leggere e gestire l’ambiente di runtime](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Avviare e interagire con processi containerizzati](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Usare Rosetta 2 per eseguire container linux/amd64 su Apple silicon.

Consulta la [documentazione API](https://apple.github.io/containerization/documentation/) per informazioni sui pacchetti Swift forniti da Containerization.

## Progettazione

Containerization esegue ogni container Linux all’interno della propria macchina virtuale leggera.  
I client possono creare indirizzi IP dedicati per ogni container per eliminare la necessità di inoltri di porta individuali.  
I container raggiungono tempi di avvio inferiori al secondo usando una [configurazione del kernel Linux ottimizzata](https://raw.githubusercontent.com/apple/containerization/main/kernel) e un filesystem root minimale con un sistema init leggero.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) è un piccolo sistema init, un sottoprogetto all’interno di Containerization.  
`vminitd` viene avviato come processo iniziale all’interno della macchina virtuale e fornisce una API GRPC tramite vsock.  
L’API consente di configurare l’ambiente di runtime e di avviare processi containerizzati.  
`vminitd` fornisce I/O, segnali ed eventi al processo chiamante quando un processo viene eseguito.

## Requisiti

È necessario un Mac Apple silicon per compilare ed eseguire Containerization.

Per compilare il pacchetto Containerization, il sistema deve avere:

- macOS 15 o versione successiva e Xcode 26 beta  
- macOS 26 beta o versione successiva

Le applicazioni create con questo pacchetto funzioneranno su macOS 15 o successivi, ma le seguenti funzionalità non sono disponibili su macOS 15:

- Networking container non isolato - con macOS 15, i container sulla stessa rete vmnet non possono comunicare tra loro

## Esempio d’uso

Per esempi di utilizzo di alcune librerie, l’eseguibile cctl è un buon punto di partenza.  
Questo strumento serve principalmente come playground per provare l’API. Contiene comandi che utilizzano alcune funzionalità principali di vari componenti, come:

1. [Manipolazione di immagini OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Accesso ai registri container](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Creazione di blocchi filesystem root](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Esecuzione di container Linux semplici](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Kernel Linux

Un kernel Linux è necessario per avviare macchine virtuali leggere su macOS.  
Containerization fornisce una configurazione kernel ottimizzata situata nella directory [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Questa directory include un ambiente di build containerizzato per compilare facilmente un kernel da usare con Containerization.

La configurazione del kernel è un set minimale di funzionalità per supportare tempi di avvio rapidi e un ambiente leggero.

Sebbene questa configurazione funzioni per la maggior parte dei carichi di lavoro, comprendiamo che alcuni richiedano funzionalità aggiuntive.  
Per questo Containerization fornisce API di prima classe per usare diverse configurazioni e versioni di kernel a livello di singolo container.  
Questo permette di sviluppare e validare container su versioni differenti del kernel.

Consulta il [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) nella directory kernel per le istruzioni su come compilare il kernel ottimizzato.

### Kernel precompilato

Se desideri usare un kernel precompilato deve includere i driver `VIRTIO` compilati direttamente nel kernel, non come moduli.

Il progetto [Kata Containers](https://github.com/kata-containers/kata-containers) fornisce un kernel ottimizzato per container con tutte le opzioni di configurazione richieste abilitate, disponibile nella pagina [releases](https://github.com/kata-containers/kata-containers/releases/).

Un’immagine kernel chiamata `vmlinux.container` si trova nella directory `/opt/kata/share/kata-containers/` degli artefatti di rilascio.

## Preparazione per compilare il pacchetto

Installa Swiftly, [Swift](https://www.swift.org) e [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Se usi un’applicazione terminale personalizzata, potrebbe essere necessario spostare questo comando da `.zprofile` a `.zshrc` (sostituisci `<USERNAME>`):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Riavvia il terminale. Assicurati che questo comando restituisca `/Users/<USERNAME>/.swiftly/bin/swift` (sostituisci `<USERNAME>`):

```bash
which swift
```

Se hai installato o usato in precedenza uno Static Linux SDK, potresti dover rimuovere versioni più vecchie dal sistema (sostituisci `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Compilare il pacchetto

Compila Containerization dalle sorgenti:

```bash
make all
```

## Testare il pacchetto

Dopo la compilazione, esegui test di base e di integrazione:

```bash
make test integration
```

È necessario un kernel per eseguire i test di integrazione.  
Se non hai un kernel locale da usare, è possibile scaricare un kernel di default con il comando `make fetch-default-kernel`.

Il download del kernel di default deve essere effettuato solo dopo una compilazione iniziale o dopo un `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization dipende da versioni specifiche di `grpc-swift` e `swift-protobuf`.  
Puoi installarli e rigenerare le interfacce RPC con:

```bash
make protos
```

## Documentazione

Genera la documentazione API per la visualizzazione locale con:

```bash
make docs
make serve-docs
```

Visualizza la documentazione eseguendo in un altro terminale:

```bash
open http://localhost:8000/documentation/
```

## Contributi

I contributi a Containerization sono benvenuti e incoraggiati. Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) per maggiori informazioni.

## Stato del progetto

La versione 0.1.0 è la prima release ufficiale di Containerization. Le versioni precedenti non garantiscono stabilità del codice sorgente.

Poiché la libreria Containerization è in sviluppo attivo, la stabilità del codice sorgente è garantita solo entro le versioni minori (ad esempio tra 0.1.1 e 0.1.2).  
Se non vuoi aggiornamenti potenzialmente incompatibili, puoi specificare la dipendenza del pacchetto usando `.upToNextMinorVersion(from: "0.1.0")`.

Versioni minori future del pacchetto potrebbero modificare queste regole secondo necessità.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---