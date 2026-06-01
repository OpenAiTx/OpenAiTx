
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  一个简单的文件管理器，诞生于我想学习 Rust 语言的初衷。
  <br>
  它与操作系统无关，并针对优化进行了精简。
</p>

<br/><br/>

性能得益于 ["jwalk"](https://crates.io/crates/jwalk/versions) 和 ["Tauri"](https://tauri.app/)。
<br/><br/>
CoDriver 不使用路径缓存来访问文件和文件夹，因此性能依赖于 Rust、本地磁盘速度和 CPU 性能。

⁉️ 请注意，此软件仍在开发中，可能包含错误！
<br/><br/>

# 链接
- <a href="#basic-features">基本功能</a>
- <a href="#advanced-features">高级功能</a>
- <a href="#dependencies-if-not-working-instantly">依赖项</a>
- <a href="#-ftp-sftp-integration">FTP / SFTP 集成</a>
- <a href="#-known-issues">已知问题</a>
- <a href="#-todos">待办事项</a>
- <a href="#user-interface">用户界面</a>

## 基本功能
- 按照你的习惯浏览目录
- 复制 & 粘贴、删除、新建和重命名文件及文件夹
- 在网格、列表和米勒列模式之间切换
- 按 esc 关闭弹窗
- 使用 Ctrl / Cmd + G 输入路径直接跳转到目录
- 在列表模式下按大小、名称或最后修改时间排序项目

## 高级功能
- 压缩文件和文件夹
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- 解压归档文件
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- 使用快捷键 LAlt + 1 / 2 / 3 导航到目录 | (macOS option + 1 / 2 / 3)
  - 在设置中自行配置路径
- 使用 F6 新建文件
- 使用 F7 新建文件夹
- 双窗口视图
  - 使用 F8 搜索文件
  - 使用 F5 将当前选中元素复制到另一窗口
  - 使用 LShift + F5 将当前选中元素移动到另一窗口
- 拖放文件到资源管理器，将其复制到当前目录
- 使用 Ctrl / Cmd + LShift + M 批量重命名所选内容
  - 使用 Ctrl / Cmd + 回车执行批量重命名
- 文件快速预览 -> 选择目录条目并按空格键
  - 支持的文件：所有图片文件（.jpg、.png 等）、.pdf、.mp4、.json、.txt、.html
  - 其他所有项目将显示带有部分信息的小图块（路径、大小、最后修改时间）
- 即时导航 -> 开始输入即可自动筛选目录条目，有时<br/>
  能更快地导航到目标位置

## 依赖项（如果未能立即运行）

<details>
<summary>点击展开</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### 架构
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ FTP / SFTP 集成

CoDriver 提供完全原生、开箱即用的 FTP 和 SFTP 远程连接支持。无需外部依赖、FUSE 层或 `sshfs` 挂载！只需在侧边栏面板中直接连接您的远程服务器即可。

## 🏴‍☠️ 语言支持
- 英语
  - 很快将提供多语言选择功能 ...

## ⚠️ 已知问题：
- 在 Linux 上，拖拽出窗口目前并不总是有效
- 在 Windows 上，您可能需要安装 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- 在 ms-windows 上权限有些奇怪
  - 如果遇到复制元素等问题，您可能需要以管理员身份运行程序
- 在 Linux 系统上，如果程序无法启动，可能需要安装 openssl1.1

## 📝 待办事项：
- 多语言支持
- 收藏夹
- 访问在线存储服务（Google Drive 等）

## 用户界面
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## 如何贡献
为开发 tauri v1 应用配置您的开发环境：[Tauri 前置条件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
完成后，只需在本地任意位置执行 ```git clone https://github.com/RickyDane/CoDriver``` 或 ```gh repo clone RickyDane/CoDriver```。
</br></br>
您应该可以在项目根目录下运行 ```cargo tauri dev``` 来开始构建和运行 CoDriver。
</br>
请确保已安装 tauri-cli：```cargo install tauri-cli```
</br>

## 发布签名

macOS 发布产物必须进行签名和公证，以避免 Gatekeeper 报告已安装的应用已损坏。请参阅 [macOS 签名与公证](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) 了解所需的 GitHub Actions 密钥和验证命令。

## Star 历史

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 其他第三方软件
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-01

---