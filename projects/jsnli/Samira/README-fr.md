# Samira

Un gestionnaire de succès Steam pour Linux

![example](https://raw.githubusercontent.com/jsnli/Samira/master/./assets/screenshot.png)

## Description
Samira est une application de bureau qui vous permet de débloquer des succès et de définir des statistiques.  

## Installation et utilisation
Les versions peuvent être trouvées [ici](https://github.com/jsnli/Samira/releases).

Steam doit être en cours d'exécution et l'utilisateur doit être connecté.

Flatpak n'est pas supporté. Steam doit être installé via le gestionnaire de paquets de votre distribution ou via l'installateur de la [page officielle Steam](https://store.steampowered.com/about/).

## Compilation

Pour compiler ce projet, vous aurez besoin des [prérequis](https://tauri.app/start/prerequisites/) pour Tauri ainsi que de Rust, Node et npm.

Clonez le dépôt et installez : 
```
cd Samira && npm install
```
Tauri ne définit pas automatiquement les chemins de recherche des bibliothèques. C'est un problème connu dans Tauri et jusqu'à ce qu'une correction officielle soit disponible, nous devons les définir nous-mêmes : 

```
export LD_LIBRARY_PATH=$LD_LIBRARY_PATH:/usr/lib/libsteam_api.so
```

The `libsteam_api.so` file is available in `/assets/`.

**Dev**
```
npm run tauri dev
```
**Construire**

```
npm run tauri build
```

Sur les distributions basées sur Arch, une erreur de regroupement peut survenir à cause de Tauri et linuxdeploy utilisant le mauvais binaire `strip`. Une solution de contournement est disponible :
```
NO_STRIP=true npm run tauri build
```

## Contribution
Comme ses prédécesseurs, Samira est open source et ouverte aux contributions. N’hésitez pas à poser des questions, ouvrir des pull requests et signaler des problèmes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-16

---