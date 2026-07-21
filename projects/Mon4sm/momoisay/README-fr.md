# momoisay
*Un programme CLI écrit en C mettant en scène Saiba Momoi parlante de Blue Archive !!!*

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Version](https://img.shields.io/badge/version-1.2.0-green)]()

---

## Aperçu

Exemple d’utilisation animée

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## Fonctionnalités
- Art ASCII parlant de Momoi
- Art ASCII animé de Momoi
- Animation changeante libre de Momoi

## Installation

#### avertissement
Parfois, les binaires précompilés ne sont pas la dernière version comme la release. Si vous voulez vous assurer d’avoir la dernière version, vous pouvez le compiler à partir des sources. Vous pouvez vérifier les versions des binaires compilés dans les dossiers `/bin`.

### Linux
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/linux.sh
```
### MacOS
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
sudo sh ./install/mac.sh
```
### Construire à partir des sources (Dernière version)
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## Utilisation
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```

## Structure des fichiers
```
repo/
├── bin/ 
│    ├── linux/
│    │   ├── version.txt
│    │   └── momoisay
│    └── mac/
│        ├── version.txt 
│        └── momoisay
├── install/
│    ├── mac.sh
│    └── linux.sh
├── src/
│    ├── art/
│    │   ├── art.c
│    │   └── art.h
│    ├── extern/
│    │   ├── cString.c
│    │   └── cString.h
│    ├── momoisay.c
│    ├── render.c
│    ├── render.h
│    ├── speech.c
│    └── speech.h
├── Makefile
├── LICENSE
├── preview.gif
└── README.md
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---