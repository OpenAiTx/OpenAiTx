# Free Oberon 编程环境

» [free.oberon.org](https://free.oberon.org/en)

Oberon 是一种通用编程语言——Pascal 和 Modula-2 的直接后代。它比 Pascal 和 Modula 更简单且更强大。

Free Oberon 是 Oberon 编程语言的跨平台集成开发环境，采用经典的伪图形风格设计——著名的 Pascal 蓝屏界面。支持 Windows、macOS 和 Linux。

Fob 是一个方便的基于控制台的 Oberon 编译器。

![Free Oberon screenshot](http://free.oberon.org/images/screenshot.png)

![Game of Life animation in Oberon](http://free.oberon.org/images/life.gif)

*英文文本见下文。*

# Free Oberon 编程环境

Oberon 是一种通用编程语言，是 Pascal 和 Modula-2 的直接继承者。它既更简单，也比 Pascal 和 Modula 强大得多。

Free Oberon 是 Oberon 编程语言的跨平台集成开发环境，采用经典的伪图形风格设计——著名的 Pascal 蓝屏界面。提供 Windows、macOS 和 Linux 版本。

Fob 是一个 Oberon 语言的控制台编译器。

* 版本 1.1.0-alpha.7
* 里加，2023 年 1 月 11 日
* 网站：[free.oberon.org](https://free.oberon.org)

# 安装

## Linux 安装

1. 依赖：

   Allegro（开发包）、Git、GCC

   在 Debian / Ubuntu / Linux Mint 等操作系统上：
   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   или:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   在Fedora操作系统上：


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel
   ```
   在 Arch Linux 上：

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   在OpenSUSE上：

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```
2. 从网站
   [free.oberon.org](https://free.oberon.org/download)
   下载 Free Oberon 的 tar.gz 压缩包，
   并将其解压到主目录（或其他任意位置）。

   选项（最新版本）：

   在 https://github.com/kekcleader/FreeOberon.git 网站上，
   点击绿色按钮“Code”并选择“Download ZIP”，
   将压缩包解压到主目录。
   将目录 `FreeOberon-main` 重命名为 `FreeOberon`。

3. 进入解压后的目录，运行 `install.sh`。
  ```
  ./install.sh
  ```
4.（可选）在文件 `~/.bashrc` 末尾添加一行：

  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  这将允许通过命令 `fo` 启动 Free Oberon。

  要以特定语言启动 Free Oberon，请指定语言（en 或 ru）：
  ```
  ./FreeOberon --lang ru
  ```
  или
  ```
  fo --lang ru
  ```

## Windows 安装

从网站 [free.oberon.org](https://free.oberon.org) 下载压缩包，解压到路径中不含非拉丁字母的位置，然后运行 `FreeOberon.exe`。

注意。如果您想从源代码自行编译 Free Oberon Windows 版本，请参阅 [free.oberon.org](http://free.oberon.org/files/FreeOberon_v1.1.0.pdf) 上的 Free Oberon 文档附录 A。


# 使用

启动 Free Oberon，输入 Oberon 语言的程序模块代码（或打开示例程序文件，如 `Life.Mod`）。按 `F9` 编译并运行程序。
您的程序源代码文件保存在 `Programs` 子目录中，编译生成的可执行文件保存在 `bin` 子目录中。编译时，在 Linux（Windows）系统上使用脚本 `Data/bin/compile.sh`（`Data\bin\compile.bat`）。您可以修改这些脚本。

可以编写包含多个模块的程序。打开主模块，按 `F9`，Free Oberon 会自动按正确顺序编译并链接它们。

如果您编译的程序主模块文件不直接位于 `Programs` 子目录中，则编译生成的可执行文件会与其同目录，而非在 `_Build` 子目录。

如果程序某模块发现错误，该文件会被打开，错误位置和类型会被标明。要重新编译，再次切换到主模块窗口并按 `F9`。

[版本历史](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)

______


*英文*

* 版本 1.1.0-alpha.7
* 里加，2023年1月11日
* 网址: [free.oberon.org](https://free.oberon.org/en)

# 安装

## Linux 安装

1. 依赖项：

   Allegro（开发包）、Git、GCC

   在 Debian / Ubuntu / Linux Mint 等操作系统上：

   ```
   sudo apt-get update
   sudo apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   or:
   ```
   su
   apt-get update
   apt-get install -y git gcc libc-dev liballegro5-dev
   ```
   在 Fedora 操作系统上：


   ```
   sudo dnf install -y git gcc glibc-devel allegro5-devel allegro5-addon-image allegro5-addon-audio allegro5-addon-acodec allegro5-addon-dialog allegro5-devel allegro5-addon-image-devel allegro5-addon-audio-devel allegro5-addon-acodec-devel allegro5-addon-dialog-devel argro5-addon-dialog-devel
   ```
   在 Arch Linux 上：

   ```
   sudo pacman -Sy git gcc pkgconf glibc allegro
   ```
   在 openSUSE 上：

   ```
   sudo zypper install -y git gcc glibc-devel liballegro5_2-devel liballegro_audio5_2-devel liballegro_image5_2-devel liballegro_primitives5_2-devel liballegro_dialog5_2-devel liballegro_acodec5_2-devel liballegro_acodec5_2-devel liballegro_font5_2-devel
   ```

2. 从 [free.oberon.org](https://free.oberon.org/en/download) 下载 tar.gz 格式的 Free Oberon 免费版，
   并将其解压到主目录（或任何其他位置）。

   选项（边缘构建）：

   访问 https://github.com/kekcleader/FreeOberon.git，
   点击标有“Code”的绿色按钮，然后点击“Download ZIP”，
   将压缩包解压到您的主目录。
   将目录 `FreeOberon-main` 重命名为 `FreeOberon`。

3. 在解压后的目录中，运行 `install.sh`。

  ```
  ./install.sh
  ```

4.（可选）将以下行追加到文件 `~/.bashrc` 的末尾：
  ```
  alias fo='cd ~/FreeOberon;./FreeOberon'
  ```
  这将允许您使用 `fo` 命令启动 Free Oberon。

  要以特定语言运行 Free Oberon，请指定语言（en 或 ru）：
  ```
  ./FreeOberon --lang ru
  ```
  or
  ```
  fo --lang ru
  ```
## 在 Windows 上安装

从 [free.oberon.org](https://free.oberon.org/en) 下载 Free Oberon 的 ZIP 压缩包，解压到磁盘上不包含非拉丁字符的路径中，然后运行 `FreeOberon.exe`。

注意。如果您想在 Windows 下从源代码重新编译 Free Oberon，请参阅 [free.oberon.org 上 Free Oberon 文档的附录 A](https://free.oberon.org/files/FreeOberon_v1.1.0_en.pdf)。

# 使用

运行 Free Oberon，输入一个 Oberon 模块的文本（或打开一个示例程序如 `Life.Mod`），按 `F9` 编译并运行程序。  
您的程序源代码文件保存在 `Programs` 子目录中，编译后的可执行文件保存在 `bin` 子目录中。`Data/bin/compile.sh`（Linux）或 `Data\bin\compile.bat`（Windows）脚本用于编译。您可以编辑这些脚本。

您可以编写由多个模块组成的程序。打开主模块并按 `F9`，Free Oberon 会自动按正确顺序编译并链接它们。

如果编译的程序其主模块文件不直接位于 `Programs` 子目录，编译后的可执行文件将位于其旁边，而不是 `_Build` 子目录中。

如果在编译某个模块时出现错误，相关文件会被打开，错误位置和信息会被指示。要重新编译，请返回主模块窗口并按 `F9`。

[版本历史](https://raw.githubusercontent.com/kekcleader/FreeOberon/main/HISTORY.md)





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-23

---