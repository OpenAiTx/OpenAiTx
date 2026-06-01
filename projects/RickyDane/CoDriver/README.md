
<div align="right">
  <details>
    <summary >🌐 Language</summary>
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
  A simple file explorer that was born because I wanted to learn the Rust language.
  <br>
  It is operating system independent and trimmed for optimization.
</p>

<br/><br/>

The performance is achieved by ["jwalk"](https://crates.io/crates/jwalk/versions) and ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver does not use path caching to access files and folders, so the performance is achieved by Rust, the speed of the disk and the power of the cpu.

⁉️ Keep in mind that this software is still work in progress and will contain bugs!
<br/><br/>

# Links
- <a href="#basic-features">Basic features</a>
- <a href="#advanced-features">Advanced features</a>
- <a href="#dependencies-if-not-working-instantly">Dependencies</a>
- <a href="#-ftp-sftp-integration">FTP / SFTP integration</a>
- <a href="#-known-issues">Known issues</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">User interface</a>

## Basic features
- Navigate through directories as you know it
- Copy & Paste, delete, create and rename files and folders
- Switch between grid, list and miller-columns mode
- Close popups with esc
- Directly jump to a directory with Ctrl / Cmd + G by inputting a path
- Sort items in list mode by size, name or last modified

## Advanced features
- Compress files and folders
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Unpack archives
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navigate to a directory using the shortcut LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Configure the paths yourself in the settings
- Create file with F6
- Create folder with F7
- Dual-Pane view
  - Search for files with F8
  - Copy current selected element to other pane with F5
  - Move current selected element to other pane with LShift + F5
- Drag and drop files into the explorer to copy them into the current directory
- Multi rename your selection with Ctrl / Cmd + LShift + M
  - Run multi rename with Ctrl / Cmd + Return
- File quick preview -> Select directory entry and tap the space bar.
  - Supported files: all image files (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - All other items will show a small tile with some information about it. (path, size, last modified)
- Instant navigation -> Start typing and automatically filter the directory entries making it sometimes <br/>
  much faster to navigate to a desired location

## Dependencies (If not working instantly)

<details>
<summary>Expand to show</summary>

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

#### Arch
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

## 🖥️ FTP / SFTP integration

CoDriver provides fully native, out-of-the-box support for FTP and SFTP remote connections. No external dependencies, FUSE layers, or `sshfs` mounts are required! Just connect your remote servers directly in the sidebar panel.

## 🏴‍☠️ Language Support
- English
  - Option to choose between languages coming soon ...

## ⚠️ Known issues:
- Drag and drop out of the window is currently not always working on linux
- On windows you may have to install [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Permissions on ms-windows are a little bit strange
  - You may have to run the program as administrator if you encounter problems to copy elements or something similar
- There could be a problem you need to install openssl1.1 on linux systems, when the program does not start

## 📝 Todos:
- Multiple languages
- Favorites
- Access online storage services (Google drive, etc.)

## User interface
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## How to contribute
Setup your machine for developing tauri v1 applications: [Tauri prerequisites](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
When this is done just do ```git clone https://github.com/RickyDane/CoDriver``` or ```gh repo clone RickyDane/CoDriver``` in a location on your machine.
</br></br>
You should be able to run ```cargo tauri dev``` in the root directory of this project to start building and running CoDriver.
</br>
Be sure to have tauri-cli installed: ```cargo install tauri-cli```
</br>

## Release signing

macOS release artifacts must be signed and notarized to avoid Gatekeeper reporting that the installed app is damaged. See [macOS signing and notarization](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) for required GitHub Actions secrets and verification commands.

## Star History

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Other third party software
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)
