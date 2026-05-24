
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='在 ko-fi.com 上请我喝咖啡' />
  </a>
</p>

<br/>

<p align="center">
  一个简单的文件资源管理器，诞生于我想学习 Rust 语言的初衷。
  <br>
  它与操作系统无关，并为优化进行了精简。
</p>

<br/><br/>

该性能由 ["jwalk"](https://crates.io/crates/jwalk/versions) 和 ["Tauri"](https://tauri.app/) 实现。
<br/><br/>
CoDriver 不使用路径缓存来访问文件和文件夹，因此性能取决于 Rust、磁盘速度和 CPU 性能。

⁉️ 请注意，这款软件仍在开发中，可能包含缺陷！
<br/><br/>

# 链接
- <a href="#basic-features">基本功能</a>
- <a href="#advanced-features">高级功能</a>
- <a href="#dependencies-if-not-working-instantly">依赖项</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP 实现（SSHFS）</a>
- <a href="#%EF%B8%8F-known-issues">已知问题</a>
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

## 🖥️ FTP 集成（sshfs）
<details>
  <summary>点击展开</summary>
  <br/>
  依赖项（需要额外安装）：
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 暂不支持 **_yet_** |

  ### 安装方法：
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ 语言支持
- 英语
  - 即将提供语言选择功能 ...
</details>

## ⚠️ 已知问题：
- 在 Linux 上将文件拖拽到窗口外目前并不总是有效
- 在 Windows 上你可能需要安装 [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Windows 系统的权限有些奇怪
  - 如果遇到无法复制元素或类似问题，你可能需要以管理员身份运行程序
- 在 Linux 系统上，如果程序无法启动，可能需要安装 openssl1.1

## 📝 待办事项：
- 多语言支持
- 收藏夹
- 访问在线存储服务（如 Google Drive 等）

## 用户界面

### 列表样式
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### 网格样式
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### 米勒列视图
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### 双窗口视图
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## 如何贡献
为开发 tauri v1 应用配置你的机器： [Tauri 前置条件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
完成后只需在你的机器上运行 ```git clone https://github.com/RickyDane/CoDriver``` 或 ```gh repo clone RickyDane/CoDriver```。
</br></br>
你应该可以在项目根目录运行 ```cargo tauri dev``` 来开始构建和运行 CoDriver。
</br>
请确保已安装 tauri-cli： ```cargo install tauri-cli```
</br>

## 发布签名

macOS 发布产物必须进行签名和公证，以避免 Gatekeeper 报告已安装的应用已损坏。请参阅 [macOS 签名与公证](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) 以获取所需的 GitHub Actions 密钥和验证命令。

## Star 历史

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star 历史图表" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 其他第三方软件
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---