# Marsdev

跨平台 Sega Mega Drive / Super 32X / Sharp X68000 工具链。

English | [日本語](https://raw.githubusercontent.com/andwn/marsdev/master/README-ja.md)


## 编译与安装

### 1.1 依赖项

根据您的操作系统安装以下软件包：
  * Debian: `apt install build-essential texinfo wget`
  * RedHat: `yum install gcc gcc-c++ texinfo-tex wget`
  * Arch: `pacman -S base-devel texinfo wget`
  * Gentoo: `emerge sys-apps/texinfo net-misc/wget`
  * macOS: `xcode-select --install && brew install wget`


### 2. GCC 工具链

克隆仓库：
 - `git clone https://github.com/andwn/marsdev --recurse-submodules`
 - `cd marsdev`

---
**注意**

有两个变量控制 Marsdev 的构建和安装目录：
 - `MARS_BUILD_DIR` = (REPOSITORY_ROOT)/mars
 - `MARS_INSTALL_DIR` = /opt/toolchains/mars

如果您想更改任一目录的位置，可以使用如下导出命令：
 - `export MARS_INSTALL_DIR=/path/to/mars`

如果忘记了 `--recurse-submodules`，请运行：
 - `git submodule init && git submodule update`

此外，**强烈建议**使用类似 `-j8` 的参数，将 8 替换为您的 CPU 核心数。我在使用 `-j` 时遇到过奇怪且无法解释的问题。

本身，因此请指定一个数字。

---

您有两种构建GCC的选项：
 - `make m68k-toolchain` - 不含Newlib
 - `make m68k-toolchain-newlib` - 含Newlib

对于32X，还必须构建`sh`工具链。
选项相同，只需将上述命令中的`m68k`替换为`sh`。

如果您想使用不同的GCC版本，或构建特定语言：
 - `make m68k-toolchain-newlib GCC_VER=12.4.0 LANGS=c,c++`


### 3.（可选）SGDK

SGDK需要Java，因此请安装它。
  * Debian: `apt install openjdk-11-jre`
  * RedHat: `yum install java-11-openjdk`
  * Arch: `pacman -S jdk11-openjdk`
  * Gentoo: `emerge dev-java/openjdk`
  * macOS: `brew install java`

---
**macOS注意事项**

需要将OpenJDK添加到PATH。
 - 打开`~/.zshrc`（如果您仍使用bash，则为`~/.bashrc`）并添加以下行：
    - `export PATH="/usr/local/opt/openjdk/bin:$PATH"`
 - 重启终端或运行`source ~/.zshrc`

---

构建SGDK：
 - `make sgdk`

可以通过`SGDK_VER=<git tag>`指定SGDK的特定版本，
但我不能保证除默认版本外的版本能正常工作。
喜欢冒险并想测试最新更改的人也可以指定`SGDK_VER=master`。
### 4.1（可选）其他工具

以下目标也可用：
 - `make x68k-tools` - Sharp X68000 兼容性
 - `make mdtools-sik` - 包含 mdtiler 和一些 Echo 工具（需要 libpng）
 - `make mdtools-flamewing` - Sonic 游戏数据压缩工具（需要 boost）

 ### 4.2（实验性）LLVM

需要 cmake、ninja 和 python3：
 - Debian：`apt install cmake ninja-build python3`
 - （待办：补充其他系统）

可以构建带有 clang 的 M68k LLVM：
 - `make m68k-llvm`
 
尚未进行测试，示例/骨架项目仍需创建。


### 5. 安装

只需运行 `sudo make install`。记住环境设置脚本的路径，
并考虑将其添加到你的 ~/.bashrc（或 ~/.zshrc）。


## 示例

`examples` 目录包含各种骨架/示例项目，可作为其他项目的基础。
有关每个示例的更多信息，请阅读 [examples/README.md](https://raw.githubusercontent.com/andwn/marsdev/master/examples/README.md)。

对于其中任何一个，只需执行 `make` 应该就足够了。


## 常见问题

### 随便啦，我只是想在 Linux 上使用 SGDK

安装：


 - `sudo apt install -y git build-essential texinfo wget openjdk-11-jre`
 - `git clone https://github.com/andwn/marsdev && cd marsdev`
 - `make sgdk -j8`
 - `sudo make install`

构建：

 - 从 `examples/sgdk-skeleton` 目录中获取 makefile 并放入你的项目中。
 - `source /opt/toolchains/mars/mars.sh`
 - `make`

### 我能用 Marsdev 构建 Gendev 项目，反之亦然吗？

不太容易。你需要修改 Makefile 才能使其工作。
首先将你当前的 Makefile 与示例项目中的进行比较。
[迁移](https://raw.githubusercontent.com/andwn/marsdev/master/doc/migration.md) 文档可能会有所帮助。

### 我怎么判断我遇到的 SGDK 问题是不是由 Marsdev 引起的？

应该可以用官方 SGDK 版本直接编译你的项目。
附带的 Makefile 只是对 `make -f $GDK/makefile.gen` 的封装。

如果问题仍然存在，那就是 SGDK 的问题。如果问题解决了，那就是 Marsdev 的问题。

### 我如何在我喜欢的 IDE 中使用这个？

IDE 有很多种，而且配置路径的地方各不相同。
一般来说，你唯一需要做的就是指向头文件路径。

 * GCC 头文件：`$(MARSDEV)/m68k-elf/lib/gcc/m68k-elf/$(GCC_VER)/include`
 * SGDK 头文件：`$(MARSDEV)/m68k-elf/include`
 * Newlib 头文件：`$(MARSDEV)/m68k-elf/m68k-elf/include`
 
如果你的 IDE 允许配置构建/运行按钮的操作，只需让它运行类似下面的命令。

 * 构建：`make MARSDEV=/path/to/mars`
 * 运行：`/path/to/an/emulator out.bin`


### Windows 平台怎么办？
我强烈推荐使用 [WSL](https://learn.microsoft.com/en-us/windows/wsl/install)  
并按照 Debian 的安装说明进行操作。  
你也可以尝试使用 Dockerfile，尽管它是由其他人贡献的，  
我自己并不测试它。  
我以前使用过 [MSYS2](https://raw.githubusercontent.com/andwn/marsdev/master/doc/install_msys_legacy.md)，但它的缓慢和笨重难以言表。  

补充说明，如果你只是来使用 SGDK 并且不使用 Linux 或 macOS，  
那么我认为 Marsdev 对你帮助不大。  


### 我不喜欢安装到 /opt。我想要旧的 ~/mars 方式  

这很简单。  
1. `export MARS_BUILD_DIR=${HOME}/mars`  
2. 正常执行步骤 1 - 4  
3. 跳过安装步骤，改为将以下内容添加到你的 `~/.bashrc`：

```
export MARSDEV=${HOME}/mars
export GDK=${MARSDEV}/m68k-elf
```

### 编译这个花了这么长时间！

GCC 是个大块头，所以我们只能耐心等待。


# 待办事项

 - [ ] 完成 libdos 重要部分的移植并让 Newlib 能与之配合工作


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---