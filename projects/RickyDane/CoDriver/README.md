<br/>
<p align="center"><img width="700" src="https://github.com/user-attachments/assets/44295a1a-c904-407d-97af-bc1aa74baa86"/></p>
<br>
<!-- <p align="center"><a target="_blank" href="https://discord.gg/XPakYank"><img src="https://dcbadge.limes.pink/api/server/XPakYank" alt="" /></a></p> -->
<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<a href='https://ko-fi.com/rickydane'>
  <p align="center">
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Buy Me a Coffee at ko-fi.com' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  A simple file explorer that was born because I wanted to learn the Rust language.
  <br>
  It is operating system independent and trimmed for optimization.
</p>

<br/><br/>

The performance is provided by ["jwalk"](https://crates.io/crates/jwalk/versions) and ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver does not use path caching to access files and folders, so the performance is achieved by Rust, the speed of the disk and the power of the cpu.

⁉️ Keep in mind that this software is still work in progress and will contain bugs!
<br/><br/>

# Links
- <a href="#basic-features">Basic features</a>
- <a href="#advanced-features">Advanced features</a>
- <a href="#dependencies-if-not-working-instantly">Dependencies</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP implementation (SSHFS)</a>
- <a href="#%EF%B8%8F-language-support">Language support</a>
- <a href="#%EF%B8%8F-known-issues">Known issues</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">User interface</a>
- <a href="#speed-comparison">Speed comparison</a>
<br/>

## Basic features
- Navigate through directories as you know it
- Copy & Paste, delete, create and rename files and folders
- Switch between "big buttons"-, list and miller columns mode
- Close popups with esc
- Jump to a directory with Ctrl / Cmd + G by inputting a path
- Sort items in list mode by size, name or last modified
<br/>

## Advanced features
- Compress files and folders
  - zip
- Unpack archives automatically into a new folder in the working directory
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- Navigate to a directory using the shortcut LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Configure the paths yourself in the settings
- Create file with F6
- Create folder with F7
- Start typing in a directory to instantly filter dir entries
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
<br/>

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
<br/>

## 🖥️ FTP integration (sshfs)
<details>
  <summary>Expand to show</summary>
  <br/>
  Dependencies (Need to be installed additionally):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Not supported **_yet_** |

  ### Installation:
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
<br/>

## 🏴‍☠️ Language Support
- English
  - Option to choose between languages coming soon ...
</details>
<br/>

## ⚠️ Known issues:
- Drag and drop out of the window is currently not working on linux
- On windows you may have to install [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Permissions on ms-windows are a little bit strange
  - You may have to run the program as administrator if you encounter problems to copy elements or something similar
- There could be a problem you need to install openssl1.1 on linux systems, when the program does not start
- ~~Tabs are not fully worked out yet~~
<br/>

## 📝 Todos:
- Multiple languages
- Favorites
- Access online storage services (Google drive, etc.)
<br/>

## User interface

### List style
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### Grid style
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### Miller column view
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### Dual pane view
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## Speed comparison
Windows File Explorer: _39.83 sec._<br/>
CoDriver: **_0.81 sec._**

https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Windows File Explorer: _44.91 sec._<br/>
CoDriver: **_< 0.5 sec._**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## How to contribute
Setup your machine for developing tauri v1 applications: [Tauri prerequisites](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
When this is done just do ```git clone https://github.com/RickyDane/CoDriver``` or ```gh repo clone RickyDane/CoDriver``` in a location on your machine.
</br></br>
You should be able to run ```cargo tauri dev``` in the root directory of this project to start building and running CoDriver.
</br>
Be sure to have tauri-cli installed: ```cargo install tauri-cli```
</br></br>

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
