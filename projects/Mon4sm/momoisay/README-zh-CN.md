# momoisay
*C语言编写的命令行程序，特色是来自《蓝档案》的会说话的桃井纱耶!!!*

[![License](https://img.shields.io/badge/license-GPL--3.0-blue)](LICENSE)
[![Version](https://img.shields.io/badge/version-1.2.0-green)]()

---

## 预览

动画使用示例

![Demo](https://raw.githubusercontent.com/Mon4sm/momoisay/main/preview.gif)

## 功能
- 桃井的会说话的ASCII艺术
- 桃井的动画ASCII艺术
- 桃井的自由切换动画

## 安装

#### 免责声明
有时预编译的二进制文件不是最新版本。如果你想确保获得最新版本，可以从源码编译。你可以在`/bin`文件夹中检查编译二进制文件的版本。

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
### 从源代码构建（最新版本）
```bash
git clone https://github.com/Mon4sm/Momoisay.git
cd Momoisay
make
```

## 用法
```bash
momoisay --help         # Show help
momoisay <text>         # Simple Usage
momoisay -a             # Animated Momoi with no text bubble (default version 1)
momoisay -a <version>   # Animated Momoi with no text bubble (default version 1)
momoisay -f             # Freestyle animations (This is pretty cool for ricing)
momoisay -c cyan -f     # Freestyle animations (But with custom colors!!!)
```

## 文件结构
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