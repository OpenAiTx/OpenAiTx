# [arXiv] On-device Sora : Permettre la génération de vidéos à partir de texte basée sur la diffusion pour appareils mobiles

* Le code est basé sur l’implémentation de [Open-Sora](https://github.com/hpcaitech/Open-Sora)

**Article** : https://arxiv.org/abs/2502.04363

Implémentation du code de [arXiv] On-device Sora : Permettre la génération de vidéos à partir de texte basée sur la diffusion pour appareils mobiles.  
Code de base référencé ->  
Open-Sora : Démocratiser la production vidéo efficace pour tous

## Introduction

Ce dépôt fournit le code pour *On-device Sora*, qui est une implémentation open-source de l’article nommé *On-device Sora : Permettre la génération de vidéos à partir de texte basée sur la diffusion pour appareils mobiles*.

### On-Device Sora  
*On-device Sora* applique le Linear Proportional Leap (LPL), la Fusion de Tokens en Dimension Temporelle (TDTM), et l’Inférence Concurrente avec Chargement Dynamique (CI-DL) pour permettre une génération vidéo efficace sur l’iPhone 15 Pro.

![On-Device_Sora](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/overview.jpg)

### Open-Sora

[Open-Sora](https://github.com/hpcaitech/Open-Sora) est un modèle de référence d’On-Device Sora, un projet open-source pour la génération vidéo, et un modèle de diffusion T2V capable de produire des vidéos à partir d’une entrée textuelle.

## Comment convertir chaque modèle en MLPackage pour On-device Sora

## Dépendances du package

### Dépendance

```
cd Device_conversion

conda create -n convert python=3.10

conda activate convert

pip install -r requirements/requirements-convert.txt

pip install -v .
```

## Conversion

### Conversion T5
```
cd t5
python3 export-t5.py
```

### Couverture STDiT
```
cd stdit3
python3 export-stdit3.py
```

### Conversion VAE
Lorsque vous exécutez `export-vae-spatial.py`, il y a une erreur qui est `Fatal Python error: PyEval_SaveThread`.
Pour résoudre cette erreur, vous ne devez exécuter qu’un seul bloc de code pour chaque partie du VAE. Commentez le reste.

```
cd vae

# for vae's temporal part
python3 export-vae-temporal.py

# for vae's spatial part
python3 export-vae-spatial.py
```

## Comment utiliser

### Requis
* Appareil Mac pour xcode
* Compte Apple pour construire et lancer l'application
* iPhone : à partir de l'iPhone 15 pro
* Version iOS : 18 ou plus
* Tous les MLPackage (T5, STDiT, VAE)

### Télécharger le MLPackage converti (si vous ne voulez pas convertir chaque modèle en MLPackage)

Vous pouvez télécharger et utiliser les modèles convertis depuis le lien suivant. [[Télécharger](https://drive.google.com/drive/folders/1L6pVi3KmyLygR_pvKofRL-21adKsEb4p?usp=sharing)]

### Exécuter l'application
* Ouvrez le projet xcode en cliquant sur On-device/On-device-Sora.xcodeproj
* Changez l'équipe (None -> Votre compte Apple) dans TARGETS/Signing&Capabilities
* Lancez l'application
### Exemples d'artefacts
![On-device-Sora-Example1](https://raw.githubusercontent.com/eai-lab/On-device-Sora/main/./Figures/On-device-Sora-Example1.gif)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---