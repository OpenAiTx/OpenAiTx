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

## **Inhaltsverzeichnis**
### 1. [**Über**](#about)
### 2. [**Erste Schritte**](#getting-started)
>#### 2.1.   [**Voraussetzungen**](#requirements)
>#### 2.2.  [**Installation**](#installing-horusec)
### 3. [**Verwendung**](#usage)
>#### 3.1. [**CLI-Nutzung**](#cli-usage)
>#### 3.2. [**Verwendung von Docker**](#using-docker)
>#### 3.3. [**Ältere Versionen**](#older-versions)
>#### 3.4. [**Verwendung der Horusec-Webanwendung**](#using-horusec-web-application)
>#### 3.5.  [**Verwendung mit Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Verwendung in der Pipeline**](#using-the-pipeline)
### 4. [**Dokumentation**](#documentation)       
### 5. [**Roadmap**](#roadmap)
### 6. [**Mitwirken**](#contributing)
### 7. [**Verhaltenskodex**](#code-of-conduct)
### 8. [**Lizenz**](#license)
### 9. [**Community**](#community)



<br>
<br>
<br>

# **Über**
Horusec ist ein Open-Source-Tool, das eine statische Codeanalyse durchführt, um Sicherheitslücken während des Entwicklungsprozesses zu identifizieren. Aktuell werden folgende Sprachen zur Analyse unterstützt: C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.
Das Tool bietet Optionen, um nach Schlüssel-Leaks und Sicherheitslücken in allen Dateien Ihres Projekts sowie in der Git-Historie zu suchen. Horusec kann vom Entwickler über die CLI oder vom DevSecOps-Team auf CI/CD-Mats verwendet werden.

Sehen Sie sich unsere [**Dokumentation**](https://docs.horusec.io/docs/overview/) an. Dort finden Sie die vollständige Liste der Tools und Sprachen, die Horusec analysiert.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Beispiel eines Outputs:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Erste Schritte**

## **Voraussetzungen**

- Docker

Sie benötigen Docker auf Ihrem Rechner, um Horusec mit allen von uns verwendeten Tools auszuführen.
Falls Sie Docker nicht installiert haben, gibt es ein [**Flag**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true`, das die Abhängigkeit deaktiviert, jedoch geht dabei ein Großteil der Analyseleistung verloren.
Wir empfehlen die Verwendung mit Docker.

Wenn Sie Commit-Autoren aktivieren (`-G true`), besteht außerdem eine Abhängigkeit zu `git`.

## **Installation von Horusec**
### **Mac oder Linux**
```
make install
```

oder

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **Überprüfen Sie die Installation**
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

#### **Überprüfen Sie die Installation**
```bash
./horusec.exe version
```

### **Und mehr**

- Sie finden alle Binärdateien mit Versionen auf unserer [**Release-Seite**](https://github.com/ZupIT/horusec/releases).

- Für weitere Details zur Installation siehe [**Dokumentation**](https://docs.horusec.io/docs/cli/installation)


## **Verwendung**
### **CLI-Nutzung**
Um horusec-cli zu verwenden und Schwachstellen der Anwendung zu prüfen, nutzen Sie folgenden Befehl:
```bash
horusec start -p .
```
> Wenn horusec eine Analyse startet, wird ein Ordner namens **`.horusec`** erstellt. Dieser Ordner dient als Grundlage, um Ihren Code nicht zu verändern. Wir empfehlen, die Zeile **`.horusec`** in Ihre **`.gitignore`**-Datei aufzunehmen, sodass dieser Ordner nicht an Ihren Git-Server gesendet werden muss.

### **Verwendung von Docker**
Es ist möglich, Horusec über ein Docker-Image **`horuszup/horusec-cli:latest`** zu nutzen.

Führen Sie dazu folgenden Befehl aus:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Wir haben ein Volume mit dem Projekt erstellt `-v $(pwd):/src`.

Mit dem Docker-Image gibt es zwei Pfade, unter denen das Projekt gefunden werden kann.

Das `-p`-Flag steht für den Projektpfad innerhalb des Containers, in unserem Beispiel `/src`.
Das `-P`-Flag steht für das Projekt außerhalb des Containers, in unserem Beispiel `$(pwd)`. 
Dieser Pfad muss ebenfalls zum Mounten des Volumes `-v $(pwd):/src` übergeben werden.

### **Ältere Versionen**

Horusec v1 ist weiterhin verfügbar.

**WARNUNG:** Der Endpoint mit v1 wird eingestellt, bitte aktualisieren Sie Ihre CLI auf v2. Weitere Details finden Sie in der [**Dokumentation**](https://docs.horusec.io/docs/migrate-v1-to-v2/).

### **Mac oder Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Die älteren Binärdateien finden Sie unter diesem Endpoint, einschließlich der neuesten Version von v1 **`v1.10.3`**.
- Ab v2 werden Binärdateien nicht mehr über diesen Endpoint verteilt. Sie finden sie stattdessen auf der [**Release-Seite**](https://github.com/ZupIT/horusec/releases).

### **Verwendung der Horusec-Webanwendung**
Verwalten Sie Ihre Schwachstellen über unsere Weboberfläche. Sie erhalten ein Dashboard mit Metriken zu Ihren Schwachstellen, Kontrolle über False Positives, Autorisierungstoken, Aktualisierung von Schwachstellen und vieles mehr.
Lesen Sie im Abschnitt [**Webanwendung**](https://github.com/ZupIT/horusec-platform) weiter.

Sehen Sie sich das folgende Beispiel an, bei dem eine Analyse an die Horusec-Webdienste gesendet wird:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Lesen Sie das [**Tutorial zur Erstellung eines Autorisierungstokens über den Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**WARNUNG:** Unsere Webdienste wurden in ein [**neues Repository**](https://github.com/ZupIT/horusec-platform) verschoben. Sie müssen auf v2 umsteigen. Lesen Sie, [**wie Sie von v1 auf v2 migrieren**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Verwendung mit Visual Studio Code**
Sie können Ihr Projekt mit der Horusec Visual Studio Code-Erweiterung analysieren.
Mehr Informationen dazu finden Sie in der [**Dokumentation**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Verwendung in der Pipeline**
Sie können Ihr Projekt vor dem Deployment in Ihrer Umgebung analysieren und so maximale Sicherheit für Ihre Organisation gewährleisten.
Weitere Informationen finden Sie in der [**Dokumentation**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Funktionen**
Siehe unten:
- Analysiert gleichzeitig 18 Programmiersprachen mit 20 verschiedenen Sicherheitstools zur Steigerung der Genauigkeit;
- Durchsucht Ihre Git-Historie nach Geheimnissen und anderen exponierten Inhalten;
- Ihre Analyse ist vollständig konfigurierbar, [**alle verfügbaren CLI-Ressourcen finden Sie hier**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Dokumentation**
Die Horusec-Dokumentation finden Sie auf unserer [**Website**](https://docs.horusec.io/docs/overview/).

## **Roadmap**
Wir haben eine Projekt-[**Roadmap**](ROADMAP.md), an der Sie mitwirken können!

Horusec hat weitere Repositories, sehen Sie selbst:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Mitwirken**

Fühlen Sie sich frei, das Projekt zu verwenden, Verbesserungen vorzuschlagen oder zu neuen Implementierungen beizutragen.

Schauen Sie sich unseren [**Beitragsleitfaden**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) an, um mehr über unseren Entwicklungsprozess und darüber zu erfahren, wie Sie Fehlerbehebungen und Verbesserungen vorschlagen können.

### **Developer Certificate of Origin - DCO**

Dies ist eine Sicherheitsebene für das Projekt und die Entwickler. Es ist verpflichtend.

Befolgen Sie eine der beiden folgenden Methoden, um das DCO zu Ihren Commits hinzuzufügen:

**1. Kommandozeile**  
Befolgen Sie diese Schritte:  
**Schritt 1:** Konfigurieren Sie Ihre lokale Git-Umgebung, indem Sie denselben Namen und dieselbe E-Mail-Adresse hinzufügen, die auch in Ihrem GitHub-Konto konfiguriert sind. Dies hilft, Commits während Reviews und Vorschlägen manuell zu signieren.

```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**Schritt 2:** Fügen Sie die Signed-off-by-Zeile mit dem `'-s'`-Flag im git commit-Befehl hinzu:

```
$ git commit -s -m "Dies ist meine Commit-Nachricht"
```
**2. GitHub-Webseite**

Sie können Ihre Commits auch während GitHub-Reviews und Vorschlägen manuell signieren. Befolgen Sie dazu die folgenden Schritte:

**Schritt 1:** Wenn das Commit-Änderungen-Feld geöffnet wird, tippen oder fügen Sie Ihre Signatur manuell in das Kommentarfeld ein. Siehe folgendes Beispiel:

```
Signed-off-by: Name < E-Mail-Adresse >
```

Für diese Methode müssen Ihr Name und Ihre E-Mail-Adresse mit den in Ihrem GitHub-Konto registrierten Daten übereinstimmen.

## **Verhaltenskodex**
Bitte befolgen Sie den [**Verhaltenskodex**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) bei allen Interaktionen mit unserem Projekt.

## **Lizenz**
 [**Apache License 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Community**

Sie können uns gerne kontaktieren unter:

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Wenn Sie Fragen oder Ideen haben, diskutieren Sie mit uns im [**Zup Open Source Forum**](https://forum.zup.com.br).


Dieses Projekt existiert dank all unserer Mitwirkenden. Ihr seid großartig! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---