<h1 align="center">Master Duel Community Chinese Translation Patch</h1>
<div align="center">

![GitHub releases](https://img.shields.io/github/v/release/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub license](https://img.shields.io/github/license/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub Gist last commit](https://img.shields.io/github/gist/last-commit/de53fb59b1c63a8be98539e04aba5d42?style=flat-square&label=metadata%20version)
![GitHub download count](https://img.shields.io/github/downloads/mikualpha/master-duel-chinese-switch/total?style=flat-square)

[Original Project Address](https://gitee.com/fetiss/master-duel-chinese-switch) | [Original Release Page](https://www.bilibili.com/read/cv21869124) | [API Source](https://ygocdb.com/)
  
</div>

Since the version released in early May 2023, MD changed the way cache files are called, causing the original translation patch to become invalid, so modifications have been made based on the original project.

This project is based on the work of authors [@叶lf](https://space.bilibili.com/23834819) / [@Timelic](https://space.bilibili.com/8664322), with gratitude! Also thanks to [@拓王神](https://space.bilibili.com/483116312) for support on the data parsing part.

## Usage
Go to the [Releases page](https://github.com/mikualpha/master-duel-chinese-switch/releases) to download `MDTR_vx.x.x.exe`, and refer to this project's [Wiki](https://github.com/mikualpha/master-duel-chinese-switch/wiki) page for usage.

## About the Project
This project is open source under the `AGPL-3.0` license. Any distribution or modification must comply with the [open source license](https://www.chinasona.org/gnu/agpl-3.0-cn.html). The Release page of this project is the only official release source; there are no official groups, no executable files published on third-party platforms, and no purchase, donation, or reward payment channels provided on third-party platforms. Beware of Trojan viruses or scams.

If errors or crashes occur, issues can be submitted. **Contributions via PRs are welcome~**

**If you find this project helpful, please consider giving it a `Star`, thank you~**

## Development
This project uses `UnityPy` for unpacking and `flet` for the interface. The build environment is `Python 3.10`.

<div align="center">
  <img src="https://raw.githubusercontent.com/mikualpha/master-duel-chinese-switch/master/./images/display.png" width="400">
</div>

#### Preparation

```
pip install -r requirements.txt
```

#### 开发

无界面

```
python3 index.py
```
flet Interface


```
flet run interface.py
```

#### 打包

PowerShell:

```
./release.ps1
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---