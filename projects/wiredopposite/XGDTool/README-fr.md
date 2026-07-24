# XGDTool
<img src="https://github.com/wiredopposite/XGDTool/blob/master/resources/Screenshot.png" alt="App" width="700"/>

XGDTool est un utilitaire de disque pour OG Xbox et Xbox 360, capable de convertir des disques vers et depuis n'importe quel format grand public. Il est disponible en version GUI ou CLI.

Ce programme est encore en phase de test initiale. Si vous rencontrez un problème, veuillez le signaler dans l'onglet Issues pour aider à améliorer ce programme !

## Fonctionnalités
- Supporte la conversion entre les formats suivants :
    - ISO / XISO
    - Fichiers extraits (Xex / Xbe / HDD Ready)
    - GoD / Games on Demand
    - CCI
    - CSO
    - ZAR
- Conversion transparente, par exemple vous pouvez extraire directement une image GoD, convertir un ISO en archive ZAR, ou un répertoire extrait en archive CCI, sans écrire de fichiers temporaires. Le seul format nécessitant des fichiers temporaires est le ZAR lorsqu'il est fourni en entrée.
- Nettoyage d'image ("Partial Scrub"), supprime le bourrage aléatoire et réduit le fichier de sortie à la longueur la plus courte possible.
- Ré-autorisation d'image ("Full Scrub"), réécrit complètement la structure du disque pour obtenir la plus petite taille de fichier possible.
- Création d'image, prend vos fichiers extraits et crée une nouvelle image avec eux.
- Compression multithread pour les formats CCI et CSO.
- Traitement par lots, un dossier rempli de différents formats de jeu peut être converti en masse vers un seul format.
- Recherche automatique des fichiers fractionnés lorsqu'une seule partie est fournie en chemin d'entrée, en supposant qu'ils sont nommés dans ce format : ```nom.1.extension``` ```nom.2.extension```.
- Option de sélection de votre application/machine cible (Xemu, Xenia, OG Xbox, Xbox 360) et laissez XGDTool décider des paramètres à utiliser.
- Génération d’XBE jointe pour OG Xbox.
- Recherche dans la base de données en ligne pour un nommage précis des fichiers (peut être désactivée).

## Utilisation CLI
```XGDTool.exe <output_format> <settings_flags> <input_path> <output_directory>```

or on Linux

```XGDTool <output_format> <settings_flags> <input_path> <output_directory>```
Les indicateurs de paramètres et le répertoire de sortie sont optionnels.

### Arguments de format de sortie (mutuellement exclusifs)
- ```--extract```   Extrait tous les fichiers dans un répertoire
- ```--xiso```      Crée une image Xiso
- ```--god```       Crée une image/structure de répertoire Games on Demand
- ```--cci```       Crée une archive CCI (automatiquement divisée si trop grande pour Xbox)
- ```--cso```       Crée une archive CSO (automatiquement divisée si trop grande pour Xbox)
- ```--zar```       Crée une archive ZAR
- ```--xbe```       Génère un fichier XBE attaché, ne convertit pas le fichier d’entrée
- ```--ogxbox```    Choisit automatiquement le format et les paramètres pour OG Xbox
- ```--xbox360```   Choisit automatiquement le format et les paramètres pour Xbox 360
- ```--xemu```      Choisit automatiquement le format et les paramètres pour Xemu
- ```--xenia```     Choisit automatiquement le format et les paramètres pour Xenia

Informations :
- ```--list```      Liste le contenu du fichier d’entrée
- ```--version```   Affiche les informations de version
- ```--help```      Affiche les informations d’utilisation

### Indicateurs de paramètres
Ces arguments peuvent être empilés, bien que tous les formats de sortie ne les utilisent pas, dans ce cas l’option est ignorée. Si des paramètres contradictoires sont fournis (ex. scrub complet/partiel), le dernier sera utilisé.
- ```--partial-scrub```  Nettoie et tronque l’image de sortie, les données de remplissage aléatoires sont supprimées.
- ```--full-scrub```     Réécrit complètement l’image résultante, ce qui produira le fichier le plus petit possible.
- ```--split```          Divise le fichier XISO résultant s’il est trop grand pour OG Xbox.
- ```--rename```         Modifie le champ titre des fichiers XBE résultants selon la base de données.
- ```--attach-xbe```     Génère un fichier XBE attaché avec le fichier de sortie.
- ```--am-patch```       Modifie le champ « Média autorisé » dans les fichiers XBE résultants.
- ```--offline```        Désactive la fonctionnalité en ligne.
- ```--debug```          Active la journalisation de débogage.
- ```--quiet```          Désactive toute journalisation sauf les avertissements et erreurs.

## Compilation
Par défaut, cela compile en GUI, configurez Cmake avec ```-DENABLE_GUI=OFF``` pour compiler en CLI. Pour compiler pour x86, plusieurs modifications doivent être apportées aux fichiers CmakeLists.txt et cmake/seutp_vcpkg.cmake pour en tenir compte.

### Windows
Si vous avez Cmake et MSVC installés, cela devrait être assez simple. Le projet a été configuré pour Windows afin qu’il télécharge et compile automatiquement toutes les dépendances avec vcpkg dans le répertoire du projet en configurant avec Cmake. Cela peut prendre un certain temps selon votre vitesse internet et les spécifications de votre PC mais ne doit se faire qu’une seule fois.

Clonez ce dépôt et créez un répertoire de compilation


```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```

Configurer comme interface graphique : 
```
cmake -S .. -B . -G "Visual Studio 17 2022" -A x64
``` 
ou en ligne de commande : 
```
cmake -S .. -B . -DENABLE_GUI=OFF -G "Visual Studio 17 2022" -A x64
```
Construire

```
cmake --build . --config Release
```

### Linux
Cette application n'a pas encore été testée de manière approfondie sous Linux, Linux présente également quelques particularités avec wxWidgets, donc l'interface graphique ne ressemble pas exactement à ce qu'elle devrait être. Elle a été testée avec Clang, en plus de Clang, Make et Cmake, vous devrez installer d'autres dépendances :
```
sudo apt update
sudo apt-get install pkg-config liblz4-dev libzstd-dev libssl-dev libcurl4-openssl-dev libwxgtk3.0-gtk3-dev
```
Clonez ce dépôt et créez un répertoire build
```
git clone --recursive https://github.com/wiredopposite/XGDTool.git
cd XGDTool
mkdir build
cd build
```
Configurer comme interface graphique : 
```
cmake ..
``` 
ou en ligne de commande (CLI) : 
```
cmake -DENABLE_GUI=OFF ..
```
Construire

```
make
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---