# ch32fun

一个开源开发环境（工具链、头文件、示例），适用于 [CH32V003](http://www.wch-ic.com/products/CH32V003.html)（以及许多其他 CH32V 系列芯片），基于 gcc-riscv64，可在 Windows（原生）、Linux 和/或 WSL 下使用。CH32V003 是一款 10 美分的 RISC-V EC 核心芯片，主频 48MHz，拥有 16kB 闪存和 2kB RAM，并配备丰富的外设。它还提供 SOP-8、QFN-20 和 SOIC 封装。你可以在[这里获取数据手册](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html)。

本项目旨在开发高效使用 CH32V003 的工具和环境。避免复杂的 HAL，释放硬件性能！现有 EVT 库体积庞大，开发环境繁重。本项目特别避免使用 HAL，使你能够直接参考 [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html)。相比之下，使用 ch32fun 的 blinky 只需 500 字节，启动更快，整体更为简洁。

ch32fun 包含内容如下：
1. 使用 ch32fun 的示例，数量不如 HAL 丰富，但大多数集中于 ch32v003，其中许多也兼容其他处理器。
2. “minichlink”，使用 WCH CH-Link 配合 libusb，支持跨平台。
   * 一个 STM32F042 编程器，[NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * 一个 ESP32S2 编程器，[esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * 官方 WCH Link-E 编程器。
   * 基于 Arduino 的接口，[Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)。
   * 支持 gdbserver 风格调试，可配合 Visual Studio 使用。
   * 支持单线 printf 调试（约 400kBaud）。
3. 附带一份 libgcc 副本，便于使用非常规 risc-v 构建链，位于 `misc/libgcc.a`。
4. 一个名为 "ch32fun" 的文件夹，包含适用于 ch32v003 的自包含源文件及头文件，可用于应用程序编译。
5. 在部分系统中支持通过 printf 返回信息。
6. 一个演示用的引导加载程序。

## 其他系列支持

目前已对 ch32v103、ch32v203、ch32v208、ch32v303、ch32v305 和 ch32v307 提供实验性支持。GDB 主要在 003 上测试，但在其他处理器上也有一定程度的支持。

## 入门指南

安装/设置说明请参见[此 wiki 页面](https://github.com/cnlohr/ch32fun/wiki/Installation)

## 特性！

###  通过编程接口实现高速 "printf" 调试

这里的“高速”是真正的快，通常约 36kBytes/秒。

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

你可以直接尝试 debugprintf 工程，或调用 SetupDebugPrintf(); 然后直接 printf() 输出信息。

### 调试支持！

通过 minichlink 内置的 gdbserver 实现！可配合 `gdb-multiarch` 以及 Visual Studio Code 使用。

## 构建与烧录

```
cd examples/blink
make
```

text = 代码，data = 常量及初始化数据，bss = 未初始化数据。  
dec 是三者之和，反映程序在 flash 中所占字节数。

生成的 .bin 文件由 minichlink 使用，.hex 文件兼容官方 WCH 烧录工具。

## VSCode +/- PlatformIO

注意：PlatformIO 一般用于本仓库的 CI。虽然 PlatformIO 可以在 VSCode 内编写和调试 ch32fun 工程，但你也可以完全不用 PlatformIO：相关内容参见[模板工程](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode)。

本项目可在 VSCode 及 PlatformIO 扩展下进行编译、上传和调试。只需克隆并在 VSCode 中打开本项目，并安装好 PlatformIO 扩展。使用[项目环境切换器](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)选择特定示例，如 "blink"。

如需基于 ch32fun 创建新的 PlatformIO 固件项目，只需使用 [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) 的“新建项目”向导，并将“Framework”设为“ch32v003fun”。有[各种示例](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun)。

![pio_proj](.github/pio_project_creation.png)

等价的 [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) 命令如下：
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

如果你希望将代码直接添加到 ch32fun 工程，请根据[说明](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53)扩展 `platformio.ini` 中的可用环境。

还请注意，当你在 PlatformIO 中打开本项目时，可以通过 VSCode 任务栏底部的[项目环境切换器](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks)选择特定示例文件夹。否则，默认情况下“Build”会编译**所有**示例。

更多细节与平台安装请参考 [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v)。

## clangd

如果 C/C++ 语言服务器 clangd 无法找到 `ch32fun.h`，需先执行 `make clean` 清理，然后用 `bear -- make build` 编译一次，生成 `compile_commands.json`，clangd 会据此找到 makefile 指定的包含路径。  
`make clangd` 可一步完成上述操作。
`build_all_clangd.sh` 在 `build scripts` 目录下可为所有示例生成。

## 快速参考
 * **必须** 用于编程/调试：`SWIO` 位于 `PD1`。请勿让 PD1 多复用其他功能。
 * **可选** `NRST` 位于 `PD7`。非必需，部分配置下默认作为 GPIO。
 * **可选** UART `TX` 在 `PD5`。建议用 SWIO 进行 `printf` 调试。

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## 更多示例/项目？

其他第三方工具提供了许多示例等。更多库请参见以下仓库：
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## 支持

你可以在 github 上提交 issue，或加入我的 Discord 服务器的 #ch32fun 频道。目前邀请为私密，如需邀请请 @cnlohr 联系我获取邀请链接。我的私信已开放。

### 脚注/链接

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf 调试手册
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html 处理器手册
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html 技术参考手册
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html 数据手册
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md 本芯片压缩 ISA 详情
 * CH32V003 支持 xv 扩展，可用此定制版 rvcodec.js 解析其指令码：https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---