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
    <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='在 ko-fi.com 给我买杯咖啡' />
  </p>
</a>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>
<p align="center">
  一个简单的文件浏览器，诞生于我想学习 Rust 语言的愿望。
  <br>
  它与操作系统无关，并经过优化裁剪。
</p>

<br/><br/>

性能由 ["jwalk"](https://crates.io/crates/jwalk/versions) 和 ["Tauri"](https://tauri.app/) 提供。
<br/><br/>
CoDriver 不使用路径缓存来访问文件和文件夹，因此性能依赖于 Rust、磁盘速度和 CPU 的性能。

⁉️ 请记住，该软件仍在开发中，可能存在漏洞！
<br/><br/>

# 链接
- <a href="#basic-features">基本功能</a>
- <a href="#advanced-features">高级功能</a>
- <a href="#dependencies-if-not-working-instantly">依赖项</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">FTP 实现（SSHFS）</a>
- <a href="#%EF%B8%8F-language-support">语言支持</a>
- <a href="#%EF%B8%8F-known-issues">已知问题</a>
- <a href="#-todos">待办事项</a>
- <a href="#user-interface">用户界面</a>
- <a href="#speed-comparison">速度比较</a>
<br/>

## 基本功能
- 像你熟悉的那样浏览目录
- 复制 & 粘贴、删除、创建和重命名文件及文件夹
- 在“大按钮”模式、列表模式和米勒列模式之间切换
- 按 esc 关闭弹窗
- 通过 Ctrl / Cmd + G 输入路径跳转到目录
- 在列表模式中按大小、名称或最后修改时间排序项目
<br/>

## 高级功能
- 压缩文件和文件夹
  - zip
- 自动将压缩包解压到工作目录的新文件夹中
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
- 使用快捷键 LAlt + 1 / 2 / 3 | （macOS 上为 option + 1 / 2 / 3）跳转目录
  - 在设置中自行配置路径
- 按 F6 创建文件
- 按 F7 创建文件夹
- 在目录中开始输入即可即时过滤目录条目
- 双窗格视图
  - 按 F8 搜索文件
  - 按 F5 将当前选中元素复制到另一窗格
  - 按 LShift + F5 将当前选中元素移动到另一窗格
- 拖放文件到资源管理器中以复制到当前目录
- 使用 Ctrl / Cmd + LShift + M 批量重命名选中文件
  - 使用 Ctrl / Cmd + 回车 执行批量重命名
- 文件快速预览 -> 选中目录条目并按空格键。
  - 支持的文件：所有图片文件（.jpg，.png，...）、.pdf、.mp4、.json、.txt、.html
  - 其他所有项目将显示一个带有一些信息的小图块。（路径、大小、最后修改时间）
- 即时导航 -> 开始输入并自动过滤目录条目，有时<br/>
  可以更快地导航到所需位置
<br/>

## 依赖项（如果无法即时工作）

<details>
<summary>展开查看</summary>

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
<br/>

## 🖥️ FTP 集成（sshfs）
<details>
  <summary>展开查看</summary>
  <br/>
  依赖项（需要额外安装）：
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | 尚不支持 **_yet_** |

  ### 安装：
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

## 🏴‍☠️ 语言支持
- 英语
  - 选择语言的选项即将推出 ...
</details>
<br/>

## ⚠️ 已知问题：
- 在 Linux 上，拖放出窗口当前无法使用
- 在 Windows 上，您可能需要安装 [Microsoft Visual C++ 可再发行组件](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Windows 系统上的权限有点奇怪
  - 如果遇到复制元素或类似问题，您可能需要以管理员身份运行程序
- 如果程序无法启动，可能需要在 Linux 系统上安装 openssl1.1
- ~~标签页功能尚未完全完善~~
<br/>

## 📝 待办事项：
- 多语言支持
- 收藏夹
- 访问在线存储服务（Google Drive 等）
<br/>

## 用户界面

### 列表样式
![Screenshot 2024-08-13 at 19 08 02](https://github.com/user-attachments/assets/d643c7f9-44e8-4f94-a23c-69759b600c82)

### 网格样式
![Screenshot 2024-08-13 at 19 08 00](https://github.com/user-attachments/assets/b28b346a-58f3-4f7c-a23d-b19f0695bf23)

### 米勒列视图
![Screenshot 2024-08-13 at 19 08 07](https://github.com/user-attachments/assets/95ab9426-837f-492d-8139-9bf7f1f0c51e)

### 双窗格视图
![Screenshot 2024-08-13 at 19 08 25](https://github.com/user-attachments/assets/a3f9a511-5e8f-44ed-95d3-1a59e2cba05b)

## 速度比较
Windows 文件资源管理器：_39.83 秒_<br/>
CoDriver：**_0.81 秒_**

https://github.com/user-attachments/assets/17116fa5-8f43-4339-a4ff-2525e7c94ae0

Windows 文件资源管理器：_44.91 秒_ <br/>
CoDriver：**_< 0.5 秒_**

https://github.com/user-attachments/assets/169da3d0-06ac-4775-a631-5c5708ae4766

</br>

## 如何贡献
为开发 tauri v1 应用程序设置你的机器：[Tauri 先决条件](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
完成后，只需在你的机器上的某个位置执行 ```git clone https://github.com/RickyDane/CoDriver``` 或 ```gh repo clone RickyDane/CoDriver```。
</br></br>
你应该能够在该项目根目录运行 ```cargo tauri dev``` 来开始构建和运行 CoDriver。
</br>
确保已安装 tauri-cli：```cargo install tauri-cli```
</br></br>

## 星标历史

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="星标历史图表" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### 其他第三方软件
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-02

---