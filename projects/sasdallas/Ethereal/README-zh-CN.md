# Ethereal

一个定制的多合一操作系统，专为速度、内存节约和可靠性而编写。\
前称为 reduceOS

## 什么是 Ethereal？

Ethereal 是一个项目，目标是从零开始创建一个功能齐全的操作系统，具备现代操作系统的所有组件。

目前，该项目正在开发其用户模式阶段。

## 截图

<img width="1925" height="1078" alt="image" src="https://github.com/user-attachments/assets/5f5725af-de16-43bf-9217-6db994f9ff2e" />\
*现代 1080p 桌面环境*

<img width="1040" height="799" alt="image" src="https://github.com/user-attachments/assets/06835253-90cd-4785-a0f8-9f0042ac3676" />\
*Ethereal 旧版主桌面环境，运行 DOOM*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ygmgdlm3dowe1.png?width=1620&format=png&auto=webp&s=0473ac09024c17cefb294c8570671e415866b915)\
*Ethereal 在调试模式下启动*

![Ethereal but REALLY on IRC](https://github.com/user-attachments/assets/fedac2c5-db99-463f-88d9-44b1a239dcdd)\
*Ethereal 在 Libera 聊天室 (#ethereal)*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ahe88a85dowe1.png?width=682&format=png&auto=webp&s=b435a1e0d57a91b7d4e0479f9649960b74a22de7)\
*Ethereal 运行 DOOM*

![fixed](https://github.com/user-attachments/assets/bfdce356-5555-436b-990d-3aad65d22dea)\
*Ethereal 运行专为其制作的 neofetch 克隆程序 (whatarewe)*

## 功能

- 完全支持 SMP 的内核
- 自定义窗口管理器（Celestial）
- 支持 UHCI/EHCI/xHCI 控制器的 USB
- 支持 AHCI/IDE
- 配备 E1000 和 RTL8139 网卡驱动的网络协议栈
- 基于优先级的轮转调度器，拥有经过充分测试的 API
- 支持 `mlibc` C 库及其多种功能
- 使用 ACPICA 库的完整 ACPI 支持（备份使用不含 AML 解析的 MinACPI 库）

## 项目结构

- `base`：包含基础文件系统。`base/initrd` 中的文件放入初始内存盘（用于非 LiveCD 启动），`base/sysroot` 中的文件放入 sysroot。
- `buildscripts`：包含构建系统的构建脚本
- `conf`：包含各种配置文件，如架构文件、GRUB 配置、额外启动文件等。
- `drivers`：Hexahedron 的驱动程序，根据配置复制。
- `external`：包含外部项目，如 ACPICA。见外部组件。
- `hexahedron`：主内核项目
- `libkstructures`：包含各种内核结构，如列表/哈希映射/解析器/等
- `libc`：包含 mlibc

## 构建


### ACPICA 注意事项

如果使用 ACPICA（默认开启），必须从[这里](https://downloadmirror.intel.com/834974/acpica-unix-20240927.tar.gz)下载压缩包并解压到 `external/acpica/acpica-src`

否则，可以编辑 `conf/build/<arch>.mk` 并将 `USE_ACPICA` 设置为 0。

### 构建

要构建 Ethereal，您需要为目标架构准备 Ethereal 工具链。\
Ethereal 工具链可在[仓库](https://github.com/sasdallas/Ethereal-Toolchain)获取。

其他必需软件包：`grub-common`、`xorriso`、`qemu-system`、`meson`、`ninja`

编辑 `buildscripts/build-arch.sh` 以更改目标构建架构。\
运行 `make all` 将在 `build-output/ethereal.iso` 中生成 ISO 镜像。

目前，Ethereal 缺少文件系统驱动，通常使用 LiveCD 启动是最佳选择。\
LiveCD 中的初始内存盘即为 sysroot，若操作系统检测到启动，它将把初始内存盘复制到内存中。

## 内核参数

Ethereal 经常无法加载。这是预期内的情况。请在 GitHub 提交问题。

您可以通过按 'e' 打开 GRUB 配置，并在 `multiboot entry` 末尾添加一些内核参数来解决部分问题。
这里有一个小列表：

- `--debug=`：选项有 `console` 和 `none`。如果是 `console`，将内核调试输出重定向到屏幕。对调试很有用
- `--noload=`：以逗号分隔的驱动程序（.sys）文件列表，不加载这些驱动。问题驱动程序：usb_xhci.sys，ahci.sys，ps2.sys（如果不支持 PS/2），
- `--no-acpica`：禁用 ACPICA 库，回退到 MinACPI 实现。仅在极端情况下有用。
- `--no-acpi`：禁用所有 ACPI 实现。也会禁用 SMP。
- `--disable-smp`：启用 ACPI，但禁用 SMP
- `--disable-cow`：禁用写时复制。不推荐，但在极端情况下有用。
- `--no-psf-font`：不从 initrd 加载 PSF 字体

## 外部组件
某些外部组件位于 `external`、`libc` 及内核的其他部分。以下是它们及其版本列表：
- ACPICA UNIX*（Intel 许可证）：版本 20240927 [点击这里下载](https://www.intel.com/content/www/us/en/developer/topic-technology/open/acpica/download.html)
- libmusl 数学库（MIT 许可证）：[点击这里下载](https://github.com/kraj/musl)
- freetype（GPL 许可证）：[点击这里下载](https://sourceforge.net/projects/freetype/)
- mlibc（MIT 许可证）：[Ethereal 分支在此](https://github.com/sasdallas/mlibc)
- tinf（zlib 许可证）：[点击这里下载](https://github.com/jibsen/tinf/)
- json-parser（BSD 双条款许可证）：[点击这里下载](https://github.com/json-parser/json-parser)
- PlutoSVG（MIT 许可证）：[点击这里下载](https://github.com/sammycage/plutosvg)

## 致谢

Ethereal 的很多设计灵感来自 [klange 的 ToaruOS](https://github.com/klange/ToaruOS) - 谢谢！

Ethereal 的虚拟内存管理设计及其他部分灵感来源于 [@mathewnd 的 Astral](https://github.com/mathewnd/Astral)

部分 Astral 的代码也被使用，适当处注明出处。许可证文件包含在 `external/` 中。

Ethereal 的标志和水星主题由艺术家 [ArtsySquid](https://artsycomms.carrd.co) 设计

## 许可协议

Hexahedron 及 Ethereal 所有非外部组件均遵循 BSD 3 条款许可证（详见 LICENSE）。\
所有文件，除版权头中另有说明者，均遵循此许可证。任何无版权头的文件不受 BSD 3 条款保护。

**许可问题：** 如果发现文件缺少适当注释，请立即联系我（最好通过公共渠道如 GitHub issues 以保持透明）直接解决。

Ethereal 的目标**从未**是窃取代码，但过去确实发生过此类情况。请与我联系！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---