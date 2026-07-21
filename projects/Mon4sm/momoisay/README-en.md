# momoisay
*A CLI program written in C featuring talking Saiba Momoi from Blue Archive!!!*

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Version](https://img.shields.io/badge/version-1.2.0-green)]()

---

## Preview

Example of animated usage

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## Features
- Talking ASCII art of Momoi
- Animated ASCII art of Momoi
- Freestyle changing animation of Momoi

## Installation

#### disclaimer
Sometimes the precompiled binaries are not the latest version as the release. If you want to make sure that you got the latest version, you can built it from source. You can check the versions of the compiled binaries in the `/bin` folders.

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
### Build from source (Latest Version)
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## Usage
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```

## File Structure
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