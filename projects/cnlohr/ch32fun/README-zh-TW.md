# ch32fun

一個開源的開發環境（工具、標頭、範例），適用於 [CH32V003](http://www.wch-ic.com/products/CH32V003.html)（以及 CH32V 系列中的許多其他晶片），可配合 gcc-riscv64 在 Windows（原生）、Linux 及/或 WSL 上使用。CH32V003 是一顆僅 10 美分的 RISC-V EC 核心晶片，運作時脈為 48MHz，擁有 16kB 的快閃記憶體和 2kB 的 RAM，以及多種周邊。它提供 SOP-8、QFN-20 和 SOIC 封裝。你可以在[這裡取得資料手冊](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html)。

本專案的目標是開發一套高效使用 CH32V003 的工具和環境。避免複雜的 HAL，充分發揮硬體效能！現有的 EVT 龐大，開發環境也很沉重。本專案特別避免使用 HAL，讓你可以直接參考 [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html)。相比之下，使用 ch32fun 的 blinky 僅 500 bytes，啟動更快，整體更簡單。

ch32fun 包含：
1. 使用 ch32fun 的範例，但數量不如 HAL 多。大多以 ch32v003 為主，但其中許多也相容於其他處理器。
2. 「minichlink」，使用 WCH CH-Link 與 libusb，跨平台支援。
   * STM32F042 燒錄器 [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * ESP32S2 燒錄器 [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * 官方 WCH Link-E 燒錄器
   * Arduino 介面 [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio)
   * 支援 gdbserver 風格的除錯，可用於 Visual Studio
   * 支援單線 printf 輸出（約 400kBaud）
3. 額外提供一份 libgcc，可支援非常規 risc-v 編譯鏈，位於 `misc/libgcc.a`。
4. 一個名為「ch32fun」的資料夾，包含單一自足的原始碼檔與標頭檔，用於編譯 ch32v003 應用程式。
5. 在某些系統上可「printf」回傳
6. 一個示範用的 bootloader。

## 其他系列支援

目前已實驗性支援 ch32v103、ch32v203、ch32v208、ch32v303、ch32v305 及 ch32v307。GDB 主要在 003 上測試，但在其他處理器上也可有限度運作。

## 開始使用

安裝/設定說明請參閱 [wiki 頁面](https://github.com/cnlohr/ch32fun/wiki/Installation)

## 功能特色！

###  透過燒錄介面快速「printf」除錯

這裡的快，是真的很快。通常約 36kBytes/sec。

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

你可以直接試用 debugprintf 專案，或呼叫 SetupDebugPrintf(); 然後隨意 printf()。

### 除錯支援！

透過 minichlink 內建的 gdbserver！可搭配 `gdb-multiarch` 及 Visual Studio Code 使用。

## 編譯與燒錄

```
cd examples/blink
make
```

text = 程式碼，data = 常數和初始化值，bss = 未初始化值。  
dec 是三者總和，反映程式佔用快閃記憶體的位元組數。

產生的 .bin 檔可由 minichlink 使用，.hex 檔則相容於官方 WCH 燒錄工具。

## VSCode +/- PlatformIO

注意：PlatformIO 主要用於本倉庫的 CI。雖然 PlatformIO 可在 VSCode 內撰寫與除錯 ch32fun 專案，你也可以完全不使用 PlatformIO：詳見 [template project](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode)。

本專案可配合 VSCode 與 PlatformIO 擴充套件進行建置、上傳和除錯。只需將本專案 clone 並在 VSCode 開啟，安裝 PlatformIO 擴充套件。使用 [專案環境切換器](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) 選擇特定範例，如 "blink"。

若要建立以 ch32fun 為基礎的新 PlatformIO 韌體專案，只需使用 [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) 的「新專案」精靈，並將「Framework」設為「ch32v003fun」。有[各種範例](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun)。

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

相等的 [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) 指令如下：
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

若要直接將你的程式碼加入 ch32fun 專案，請依照[說明](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53)擴展 `platformio.ini` 中的環境。

也請注意，當你在 PlatformIO 中開啟本專案時，可於 VSCode 工作列底部使用 [專案環境切換器](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) 選擇特定範例資料夾。否則，「Build」預設會編譯**所有**範例。

詳細資訊與平台安裝，請見 [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v)。

## clangd

若 C/C++ 語言伺服器 clangd 找不到 `ch32fun.h`，請先 `make clean` 清除範例，並使用 `bear -- make build` 進行一次建置，這將生成 clangd 用於尋找 makefile 指定 include 路徑的 `compile_commands.json`。  
`make clangd` 可一步完成。
`build_all_clangd.sh`（於 build scripts）可為所有範例自動處理。

## 快速參考
 * **必需**：程式燒錄/除錯用 `SWIO` 位於 `PD1`。請勿讓 PD1 同時用於多種功能。
 * **選用**：`NRST` 位於 `PD7`。非必要，在某些設定下預設為 GPIO。
 * **選用**：UART `TX` 位於 `PD5`。建議使用 SWIO 進行 `printf` 除錯。

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## 更多範例/專案？

其他第三方工具正加入大量範例等資源。更多函式庫等請參閱以下倉庫：
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## 支援

你可以在 github 提交 issue，或加入我的 Discord 伺服器 #ch32fun 頻道。目前邀請僅限私訊，請直接 @cnlohr 索取邀請連結。我的私訊開放。

### 附註/連結

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf 除錯手冊
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html 處理器手冊
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html 技術參考手冊
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html 資料手冊
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md 關於本晶片壓縮指令集的細節
 * CH32V003 有 xv 擴展，你可以用此客製化的 rvcodec.js 處理其指令碼：https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---