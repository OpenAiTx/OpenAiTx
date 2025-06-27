<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **Indice dei contenuti**
### 1. [**Informazioni**](#about)
### 2. [**Come iniziare**](#getting-started)
>#### 2.1.   [**Requisiti**](#requirements)
>#### 2.2.  [**Installazione**](#installing-horusec)
### 3. [**Utilizzo**](#usage)
>#### 3.1. [**Utilizzo della CLI**](#cli-usage)
>#### 3.2. [**Utilizzo con Docker**](#using-docker)
>#### 3.3. [**Versioni precedenti**](#older-versions)
>#### 3.4. [**Utilizzo dell'applicazione Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Utilizzo con Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Utilizzo nella Pipeline**](#using-the-pipeline)
### 4. [**Documentazione**](#documentation)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Contributi**](#contributing)
### 7. [**Codice di Condotta**](#code-of-conduct)
### 8. [**Licenza**](#license)
### 9. [**Community**](#community)



<br>
<br>
<br>

# **Informazioni**
Horusec è uno strumento open source che esegue un'analisi statica del codice per identificare vulnerabilità di sicurezza durante il processo di sviluppo. Attualmente, i linguaggi supportati per l’analisi sono C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.  
Lo strumento offre opzioni per la ricerca di fughe di chiavi e vulnerabilità di sicurezza in tutti i file del tuo progetto, così come nella cronologia Git. Horusec può essere utilizzato dallo sviluppatore tramite la CLI e dal team DevSecOps nei flussi CI/CD.

Consulta la nostra [**Documentazione**](https://docs.horusec.io/docs/overview/) per la lista completa degli strumenti e linguaggi analizzati da Horusec.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Esempio di Output:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Come iniziare**

## **Requisiti**

- Docker

Devi avere Docker installato sulla tua macchina per eseguire Horusec con tutti gli strumenti necessari.
Se non hai Docker, abbiamo un [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` che disabiliterà la dipendenza, ma verrà persa molta della potenza dell’analisi.  
Ne consigliamo l’uso con Docker.

Se abiliti gli autori dei commit `-G true`, c’è anche una dipendenza da `git`.

## **Installazione di Horusec**
### **Mac o Linux**
```
make install
```

oppure

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Verifica l'installazione**
```bash
horusec version
```

### **Windows**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **Verifica l'installazione**
```bash
./horusec.exe version
```

### **E altro ancora**

- Puoi trovare tutti i binari con le versioni nella nostra [**pagina releases**](https://github.com/ZupIT/horusec/releases).

- Per maggiori dettagli sull’installazione, consulta la [**documentazione**](https://docs.horusec.io/docs/cli/installation) 


## **Utilizzo**
### **Utilizzo della CLI**
Per usare horusec-cli e controllare le vulnerabilità dell’applicazione, utilizza il seguente comando:
```bash
horusec start -p .
```
> Quando horusec avvia un’analisi, crea una cartella chiamata **`.horusec`**. Questa cartella serve a non modificare il tuo codice. Si consiglia di aggiungere la riga **`.horusec`** nel tuo file **`.gitignore`** in modo che questa cartella non venga inviata al tuo server git.

### **Utilizzo con Docker**
È possibile utilizzare Horusec tramite un’immagine docker **`horuszup/horusec-cli:latest`**.

Esegui il comando seguente:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Abbiamo creato un volume contenente il progetto `-v $(pwd):/src`.

Con l’immagine docker si hanno quindi due percorsi dove può trovarsi il progetto.

Il flag `-p` rappresenta il percorso del progetto all’interno del container, nel nostro esempio `/src`.
Il flag `-P` rappresenta il percorso del progetto all’esterno del container, nel nostro esempio rappresentato da `$(pwd)`,
ed è necessario anche per montare il volume `-v $(pwd):/src`.

### **Versioni precedenti**

Horusec v1 è ancora disponibile.

**ATTENZIONE:** L’endpoint con v1 sarà deprecato, aggiorna la tua CLI alla v2. Consulta maggiori dettagli nella [**documentazione**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac o Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- I vecchi binari sono disponibili a questo endpoint, inclusa l’ultima versione della v1 **`v1.10.3`**. 
- A partire dalla v2, i binari non saranno più distribuiti tramite questo endpoint, ma puoi trovarli nella [**pagina releases**](https://github.com/ZupIT/horusec/releases).

### **Utilizzo dell'applicazione Horusec-Web**
Gestisci le tue vulnerabilità tramite la nostra interfaccia web. Puoi avere una dashboard di metriche sulle vulnerabilità, controllo dei falsi positivi, token di autorizzazione, aggiornamento delle vulnerabilità e molto altro.
Consulta la sezione [**web application**](https://github.com/ZupIT/horusec-platform) per saperne di più.

Vedi l’esempio seguente, sta inviando un’analisi ai servizi web Horusec:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Consulta [**il tutorial su come creare un token di autorizzazione tramite Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**ATTENZIONE:** I nostri servizi web sono stati spostati su un [**nuovo repository**](https://github.com/ZupIT/horusec-platform). Devi aggiornare alla v2, consulta [**come migrare da v1 a v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Utilizzo con Visual Studio Code**
Puoi analizzare il tuo progetto utilizzando l’estensione Horusec per Visual Studio Code.
Per maggiori informazioni, [**consulta la documentazione**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Utilizzo nella Pipeline**
Puoi eseguire un’analisi del tuo progetto prima di effettuare il deploy nell’ambiente, garantendo la massima sicurezza per la tua organizzazione.
Per maggiori informazioni, [**consulta la documentazione**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Funzionalità**
Vedi sotto: 
- Analizza contemporaneamente 18 linguaggi con 20 diversi strumenti di sicurezza per aumentare l’accuratezza;
- Effettua ricerche storiche nel git per segreti e altri contenuti esposti;
- L’analisi è completamente configurabile, [**vedi tutte le risorse CLI disponibili**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Documentazione**
Puoi trovare la documentazione di Horusec sul nostro [**sito**](https://docs.horusec.io/docs/overview/).

## **Roadmap**
Abbiamo una [**roadmap**](ROADMAP.md) di progetto, puoi contribuire anche tu!

Horusec ha altri repository, dai un’occhiata:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Contribuire**

Sentiti libero di utilizzare, raccomandare miglioramenti o contribuire a nuove implementazioni.

Consulta la nostra [**guida per i contributori**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) per scoprire il nostro processo di sviluppo e come suggerire correzioni di bug e miglioramenti.

### **Developer Certificate of Origin - DCO**

Questa è una misura di sicurezza sia per il progetto che per gli sviluppatori. È obbligatoria.

Segui uno di questi due metodi per aggiungere il DCO ai tuoi commit:

**1. Riga di comando**  
Segui i passaggi:  
**Passo 1:** Configura il tuo ambiente git locale aggiungendo lo stesso nome e indirizzo e-mail configurati sul tuo account GitHub. Questo aiuta a firmare manualmente i commit durante revisioni e suggerimenti.

```
git config --global user.name “Nome”
git config --global user.email “email@dominio.com.br”
```
**Passo 2:** Aggiungi la riga Signed-off-by con il flag `'-s'` nel comando git commit:

```
$ git commit -s -m "Questo è il mio messaggio di commit"
```
**2. Sito web GitHub**

Puoi anche firmare manualmente i tuoi commit durante le revisioni e i suggerimenti su GitHub, segui i passaggi qui sotto:

**Passo 1:** Quando si apre la casella delle modifiche del commit, digita o incolla manualmente la tua firma nella casella dei commenti, vedi l'esempio:

```
Signed-off-by: Nome < indirizzo e-mail >
```

Per questo metodo, il tuo nome e indirizzo e-mail devono essere gli stessi registrati sul tuo account GitHub.

## **Codice di Condotta**
Si prega di seguire il [**Codice di Condotta**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) in tutte le tue interazioni con il nostro progetto.

## **Licenza**
 [**Licenza Apache 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Comunità**

Sentiti libero di contattarci a:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Se hai domande o idee, parliamone nel nostro [**Forum Zup Open Source**](https://forum.zup.com.br).


Questo progetto esiste grazie a tutti i contributori. Siete fantastici! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---