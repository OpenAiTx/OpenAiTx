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

## **Inhoudsopgave**
### 1. [**Over**](#over)
### 2. [**Aan de slag**](#aan-de-slag)
>#### 2.1.   [**Vereisten**](#vereisten)
>#### 2.2.  [**Installatie**](#installatie-van-horusec)
### 3. [**Gebruik**](#gebruik)
>#### 3.1. [**CLI-gebruik**](#cli-gebruik)
>#### 3.2. [**Docker gebruiken**](#docker-gebruiken)
>#### 3.3. [**Oudere versies**](#oudere-versies)
>#### 3.4. [**Horusec-Webapplicatie gebruiken**](#horusec-webapplicatie-gebruiken)
>#### 3.5.  [**Visual Studio Code gebruiken**](#visual-studio-code-gebruiken)
>#### 3.6. [**Gebruik in de Pipeline**](#gebruik-in-de-pipeline)
### 4. [**Documentatie**](#documentatie)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Bijdragen**](#bijdragen)
### 7. [**Gedragscode**](#gedragscode)
### 8. [**Licentie**](#licentie)
### 9. [**Community**](#community)



<br>
<br>
<br>

# **Over**
Horusec is een open source tool die een statische code-analyse uitvoert om beveiligingsfouten te identificeren tijdens het ontwikkelproces. Momenteel zijn de talen voor analyse C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx. 
De tool biedt opties om te zoeken naar sleutel-lekken en beveiligingsfouten in alle bestanden van je project, evenals in de Git-geschiedenis. Horusec kan worden gebruikt door de ontwikkelaar via de CLI en door het DevSecOps-team op CI/CD-mats.

Bekijk onze [**documentatie**](https://docs.horusec.io/docs/overview/), waar je de volledige lijst van tools en talen vindt waarop Horusec analyses uitvoert.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Zie een voorbeeld van de output:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Aan de slag**

## **Vereisten**

- Docker

Je moet Docker op je machine geïnstalleerd hebben om Horusec te kunnen uitvoeren met alle tools die wij gebruiken.
Als je geen Docker hebt, hebben we een [**flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` die de afhankelijkheid uitschakelt, maar hierdoor verlies je veel van de analysekracht.
Wij raden aan Horusec met Docker te gebruiken.

Als je commit-auteurs inschakelt `-G true`, is er ook een `git`-afhankelijkheid.

## **Installatie van Horusec**
### **Mac of Linux**
```
make install
```

of

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Controleer de installatie**
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

#### **Controleer de installatie**
```bash
./horusec.exe version
```

### **En meer**

- Je kunt alle binaries met versies vinden op onze [**releases pagina**](https://github.com/ZupIT/horusec/releases).

- Voor meer details over hoe te installeren, bekijk de [**documentatie**](https://docs.horusec.io/docs/cli/installation) 


## **Gebruik**
### **CLI-gebruik**
Om horusec-cli te gebruiken en kwetsbaarheden in de applicatie te controleren, gebruik je het volgende commando:
```bash
horusec start -p .
```
> Wanneer Horusec een analyse start, wordt er een map aangemaakt met de naam **`.horusec`**. Deze map zorgt ervoor dat je code niet wordt aangepast. We raden aan om de regel **`.horusec`** toe te voegen aan je **`.gitignore`** bestand zodat deze map niet naar je git-server hoeft te worden gestuurd.

### **Docker gebruiken**
Het is mogelijk om Horusec te gebruiken via een docker image **`horuszup/horusec-cli:latest`**.

Voer het volgende commando uit om dit te doen:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- We hebben een volume aangemaakt met het project `-v $(pwd):/src`.

Met het docker image hebben we uiteindelijk twee paden waar het project gevonden kan worden.

De `-p` flag geeft het projectpad binnen de container aan, in ons voorbeeld `/src`.
De `-P` flag geeft het projectpad buiten de container aan, in ons voorbeeld `$(pwd)`,
en is ook nodig om het projectpad door te geven aan het volume `-v $(pwd):/src`.

### **Oudere versies**

Horusec v1 is nog steeds beschikbaar.

**LET OP:** De endpoint met v1 zal worden uitgefaseerd, upgrade je CLI naar v2. Bekijk meer details in de [**documentatie**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac of Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- De oudere binaries zijn te vinden op deze endpoint, inclusief de laatste versie van v1 **`v1.10.3`**. 
- Vanaf v2 worden binaries niet langer via deze endpoint verspreid, maar kun je ze vinden op de [**releases pagina**](https://github.com/ZupIT/horusec/releases).

### **Horusec-Webapplicatie gebruiken**
Beheer je kwetsbaarheden via onze webinterface. Je krijgt een dashboard met statistieken over je kwetsbaarheden, controle over false positives, autorisatietokens, update van kwetsbaarheden en nog veel meer.
Zie het [**webapplicatie**](https://github.com/ZupIT/horusec-platform) gedeelte voor meer informatie.

Bekijk onderstaand voorbeeld, dit stuurt een analyse naar Horusec web services:
```bash
horusec start -p <PAD_NAAR_JE_PROJECT> -a <JOUW_AUTORISATIE_TOKEN>
```

Bekijk [**de tutorial over het aanmaken van een autorisatietoken via Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**LET OP:** Onze web services zijn verplaatst naar een [**nieuwe repository**](https://github.com/ZupIT/horusec-platform). Je moet upgraden naar v2, zie [**hoe je migreert van v1 naar v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Visual Studio Code gebruiken**
Je kunt je project analyseren met de Horusec Visual Studio Code-extensie.
Voor meer informatie, [**bekijk de documentatie**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Gebruik in de Pipeline**
Je kunt een analyse uitvoeren van je project voordat je gaat deployen in je omgeving, om maximale beveiliging in je organisatie te waarborgen.
Voor meer informatie, [**bekijk de documentatie**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Functionaliteiten**
Zie hieronder: 
- Analyseert gelijktijdig 18 talen met 20 verschillende beveiligingstools om de nauwkeurigheid te vergroten;
- Zoekt in de git-geschiedenis naar secrets en andere blootgestelde inhoud;
- Je analyse is volledig configureerbaar, [**bekijk alle beschikbare CLI-functies**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Documentatie**
Je kunt de documentatie van Horusec vinden op onze [**website**](https://docs.horusec.io/docs/overview/).

## **Roadmap**
We hebben een project [**roadmap**](https://raw.githubusercontent.com/ZupIT/horusec/main/ROADMAP.md), je kunt met ons bijdragen!

Horusec heeft andere repositories, bekijk ze:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Bijdragen**

Voel je vrij om het te gebruiken, verbeteringen aan te bevelen of bij te dragen aan nieuwe implementaties.

Bekijk onze [**bijdragengids**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) om meer te weten te komen over ons ontwikkelproces en hoe je bugfixes en verbeteringen kunt voorstellen.

### **Developer Certificate of Origin - DCO**

 Dit is een beveiligingslaag voor het project en voor de ontwikkelaars. Het is verplicht.
 
Volg een van deze twee methoden om DCO aan je commits toe te voegen:
 
**1. Commandoregel**
 Volg de stappen: 
 **Stap 1:** Configureer je lokale git-omgeving met dezelfde naam en e-mail die je op je GitHub-account hebt ingesteld. Dit helpt om commits handmatig te ondertekenen tijdens reviews en suggesties.

 ```
git config --global user.name “Naam”
git config --global user.email “email@domein.com”
```
**Stap 2:** Voeg de Signed-off-by-regel toe met de `'-s'` vlag in het git commit-commando:

```
$ git commit -s -m "Dit is mijn commitboodschap"
```
**2. GitHub-website**

Je kunt je commits ook handmatig ondertekenen tijdens GitHub-reviews en suggesties, volg de onderstaande stappen: 

**Stap 1:** Wanneer het commitwijzigingen-venster opent, typ of plak je handtekening handmatig in het commentaarvak, zie het voorbeeld:

```
Signed-off-by: Naam < e-mailadres >
```

Voor deze methode moeten je naam en e-mail hetzelfde zijn als geregistreerd op je GitHub-account.

## **Gedragscode**
Volg alstublieft de [**Gedragscode**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) bij al je interacties met ons project.

## **Licentie**
 [**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Community**

Voel je vrij om contact met ons op te nemen via:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Als je vragen of ideeën hebt, laten we chatten in ons [**Zup Open Source Forum**](https://forum.zup.com.br).


Dit project bestaat dankzij alle bijdragers. Jullie zijn geweldig! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---