# momoisay
*Cで書かれたCLIプログラムで、ブルーアーカイブのセイバ・モモイが話します!!!*

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Version](https://img.shields.io/badge/version-1.2.0-green)]()

---

## プレビュー

アニメーション使用例

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## 特徴
- モモイのトーキングASCIIアート
- モモイのアニメーションASCIIアート
- モモイの自由なアニメーション変更

## インストール

#### 免責事項
時々、事前コンパイル済みのバイナリがリリースの最新バージョンではない場合があります。最新バージョンを確実に入手したい場合は、ソースからビルドしてください。コンパイル済みバイナリのバージョンは`/bin`フォルダ内で確認できます。

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
### ソースからビルド（最新バージョン）
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## 使い方
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```

## ファイル構成
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