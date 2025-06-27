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

## **Table des matières**
### 1. [**À propos**](#about)
### 2. [**Démarrage rapide**](#getting-started)
>#### 2.1.   [**Pré-requis**](#requirements)
>#### 2.2.  [**Installation**](#installing-horusec)
### 3. [**Utilisation**](#usage)
>#### 3.1. [**Utilisation CLI**](#cli-usage)
>#### 3.2. [**Utilisation de Docker**](#using-docker)
>#### 3.3. [**Anciennes versions**](#older-versions)
>#### 3.4. [**Utilisation de l’application Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**Utilisation avec Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**Utilisation dans la Pipeline**](#using-the-pipeline)
### 4. [**Documentation**](#documentation)       
### 5. [**Feuille de route**](#roadmap)
### 6. [**Contribuer**](#contributing)
### 7. [**Code de conduite**](#code-of-conduct)
### 8. [**Licence**](#license)
### 9. [**Communauté**](#community)



<br>
<br>
<br>

# **À propos**
Horusec est un outil open source qui réalise une analyse statique de code afin d’identifier les failles de sécurité durant le processus de développement. Actuellement, les langages analysés sont C#, Java, Kotlin, Python, Ruby, Golang, Terraform, Javascript, Typescript, Kubernetes, PHP, C, HTML, JSON, Dart, Elixir, Shell, Nginx.
L’outil propose des options pour rechercher des fuites de clés et des failles de sécurité dans tous les fichiers de votre projet, ainsi que dans l’historique Git. Horusec peut être utilisé par le développeur via la CLI et par l’équipe DevSecOps sur les chaînes CI /CD.

Consultez notre [**documentation**](https://docs.horusec.io/docs/overview/), vous y trouverez la liste complète des outils et langages analysés par Horusec.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **Exemple de résultat :**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **Démarrage rapide**

## **Pré-requis**

- Docker

Vous devez avoir Docker installé sur votre machine pour exécuter Horusec avec tous les outils que nous utilisons.
Si vous n’avez pas Docker, nous disposons d’une [**option**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` qui désactive la dépendance, mais vous perdez alors une grande partie de la puissance d’analyse.
Nous recommandons de l’utiliser avec Docker.

Si vous activez les auteurs de commit `-G true`, il existe également une dépendance à `git`.

## **Installation de Horusec**
### **Mac ou Linux**
```
make install
```

ou

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/main/deployments/scripts/install.sh | bash -s latest
```

#### **Vérifier l’installation**
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

#### **Vérifier l’installation**
```bash
./horusec.exe version
```

### **Et plus encore**

- Vous pouvez trouver tous les binaires et leurs versions sur notre [**page de releases**](https://github.com/ZupIT/horusec/releases).

- Pour plus de détails sur l’installation, consultez la [**documentation**](https://docs.horusec.io/docs/cli/installation) 


## **Utilisation**
### **Utilisation CLI**
Pour utiliser horusec-cli et vérifier les vulnérabilités de l’application, utilisez la commande suivante :
```bash
horusec start -p .
```
> Lorsque Horusec démarre une analyse, il crée un dossier appelé **`.horusec`**. Ce dossier sert de base pour ne pas modifier votre code. Nous vous recommandons d’ajouter la ligne **`.horusec`** à votre fichier **`.gitignore`** afin que ce dossier ne soit pas envoyé à votre serveur git.

### **Utilisation de Docker**
Il est possible d’utiliser Horusec via une image docker **`horuszup/horusec-cli:latest`**.

Exécutez la commande suivante :
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- Nous avons créé un volume contenant le projet `-v $(pwd):/src`.

Avec l’image docker, il y a donc deux chemins où le projet peut être trouvé.

L’option `-p` représente le chemin du projet à l’intérieur du conteneur, dans notre exemple `/src`.
L’option `-P` représente le chemin du projet à l’extérieur du conteneur, dans notre exemple `$(pwd)`, 
qui sera également nécessaire pour monter le volume `-v $(pwd):/src`.

### **Anciennes versions**

La version v1 de Horusec est toujours disponible.

**ATTENTION :** L’endpoint v1 sera déprécié, veuillez mettre à jour votre CLI vers la v2. Consultez plus de détails dans la [**documentation**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **Mac ou Linux**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **Windows**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- Les anciens binaires peuvent être trouvés à cette adresse, y compris la dernière version de la v1 **`v1.10.3`**.
- À partir de la v2, les binaires ne seront plus distribués via ce endpoint, vous pouvez les trouver sur la [**page de releases**](https://github.com/ZupIT/horusec/releases).

### **Utilisation de l’application Horusec-Web**
Gérez vos vulnérabilités via notre interface web. Vous pouvez disposer d’un tableau de bord sur les métriques des vulnérabilités, gérer les faux positifs, le jeton d’autorisation, la mise à jour des vulnérabilités et bien plus encore.
Voir la section [**application web**](https://github.com/ZupIT/horusec-platform) pour en savoir plus.

Voici un exemple d’envoi d’une analyse aux services web Horusec :
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

Consultez [**le tutoriel pour créer un jeton d’autorisation via Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**ATTENTION :** Nos services web ont été déplacés vers un [**nouveau dépôt**](https://github.com/ZupIT/horusec-platform). Vous devez passer à la v2, consultez [**comment migrer de la v1 à la v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **Utilisation avec Visual Studio Code**
Vous pouvez analyser votre projet avec l’extension Visual Studio Code de Horusec.
Pour plus d’informations, [**consultez la documentation**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **Utilisation dans la Pipeline**
Vous pouvez analyser votre projet avant de lancer le déploiement dans votre environnement pour garantir une sécurité maximale dans votre organisation.
Pour plus d’informations, [**consultez la documentation**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **Fonctionnalités**
Voir ci-dessous : 
- Analyse simultanée de 18 langages avec 20 outils de sécurité différents pour une meilleure précision ;
- Recherche dans l’historique git pour les secrets et autres contenus exposés ;
- Votre analyse est entièrement configurable, [**voir toutes les options CLI disponibles**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **Documentation**
Vous pouvez trouver la documentation de Horusec sur notre [**site web**](https://docs.horusec.io/docs/overview/).

## **Feuille de route**
Nous avons une [**feuille de route**](ROADMAP.md), vous pouvez y contribuer !

Horusec dispose d’autres dépôts, découvrez-les :

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **Contribuer**

N'hésitez pas à utiliser, recommander des améliorations ou contribuer à de nouvelles implémentations.

Consultez notre [**guide de contribution**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) pour en savoir plus sur notre processus de développement, comment suggérer des corrections de bugs et des améliorations.

### **Certificat de l’Auteur du Code - DCO**

Ceci est une couche de sécurité pour le projet et pour les développeurs. C'est obligatoire.

Suivez l’une de ces deux méthodes pour ajouter le DCO à vos commits :

**1. Ligne de commande**  
Suivez les étapes :  
**Étape 1 :** Configurez votre environnement git local en ajoutant le même nom et e-mail que ceux configurés sur votre compte GitHub. Cela aide à signer les commits manuellement lors des revues et suggestions.

```
git config --global user.name “Nom”
git config --global user.email “email@domaine.com.br”
```
**Étape 2 :** Ajoutez la ligne Signed-off-by avec le flag `'-s'` dans la commande git commit :

```
$ git commit -s -m "Ceci est mon message de commit"
```
**2. Site web GitHub**

Vous pouvez également signer manuellement vos commits lors des revues et suggestions sur GitHub, suivez les étapes ci-dessous :

**Étape 1 :** Lorsque la boîte de modification du commit s’ouvre, tapez ou collez manuellement votre signature dans la boîte de commentaire, voir l’exemple :

```
Signed-off-by: Nom < adresse e-mail >
```

Pour cette méthode, votre nom et e-mail doivent être identiques à ceux enregistrés sur votre compte GitHub.

## **Code de Conduite**
Merci de respecter le [**Code de Conduite**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) lors de toutes vos interactions avec notre projet.

## **Licence**
[**Licence Apache 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **Communauté**

N'hésitez pas à nous contacter :

- [**GitHub Issues**](https://github.com/ZupIT/horusec/issues)
- Si vous avez des questions ou des idées, discutons-en sur notre [**Forum Open Source Zup**](https://forum.zup.com.br).

Ce projet existe grâce à tous les contributeurs. Vous êtes géniaux ! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---