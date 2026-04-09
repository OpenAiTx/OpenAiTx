# OmniDrive
版权 © 2026 Rib

## 描述
OmniDrive 是针对由日立-LG 数据存储制造的基于 MediaTek MT1959 的光盘驱动器的固件修改，提供更好、更完整的光盘读取功能，包括专有游戏光盘。

## 功能
* 支持 CD/DVD/BD 及其衍生光盘的起始区/结束区读取。
* 支持 CD/DVD/BD 及其衍生光盘的原始扇区读取（CD 为 2352 字节/扇区，DVD 为 2064 字节/扇区，BD 为 2072 字节/扇区）。
* 自定义 READ DISC RAW 命令读取光盘，带有 FUA 标志（绕过缓存）、原始寻址（CD 为 MSF，DVD/BD 为 PSN）和解扰（DVD/BD）功能。
* 能读取多种专有游戏光盘（见表格）：

| 光盘类型 | 支持情况 | 备注 |
| ---: | :---: | --- |
| CD (ROM/R/RW) | ☑️ |
| DVD (ROM/RAM/±R/±RW) | ☑️ |
| BD (ROM/R/RE) | ☑️ |
| BD-XL (R/RE) | ☑️ |
| UHD-BD | ☑️ |
| PlayStation 3 BD-ROM | ☑️ | 光盘内容加密，无法检索光盘密钥
| PlayStation 4 BD-ROM | ☑️ | 光盘内容加密，无法检索光盘密钥
| PlayStation 5 BD-ROM | ☑️ | 光盘内容加密，无法检索光盘密钥
| Xbox (XGD1) | ✅ |
| Xbox 360 (XGD2/XGD3) | ✅ |
| Xbox One/Series (XGD4) | ✅ | 光盘内容加密，无法检索光盘密钥
| GameCube (NROM)/Wii (RVL-ROM) | ✅ |
| GameCube (NR)/Wii (RVT-R) | ❓ |
| Wii U (WUP-ROM?) | ⚠️ | 可原始读取，但加扰算法当前未知 |
| Wii U (CAT-R) | ☑️ |
| Dreamcast (GD-ROM/GD-R) | ❎ | 仅能读取低密度区域 |

说明：
* ☑️ - 原生支持（无需补丁固件）
* ✅ - 通过 OmniDrive 支持
* ⚠️ - 部分支持（见备注）
* ❓ - 支持未知（需测试）
* ❎ - 当前不支持

## 构建
### 依赖项
* CMake  
* ninja  
* arm-none-eabi-gcc 工具链  
* [armips](https://github.com/Kingcom/armips)  
* Python 3  
* pycryptodome  
### 使用说明  
1. 将原厂 LG BU40N 1.00 和 ASUS BW-16D1HT 3.02 固件文件放入 `firmware` 文件夹。文件应命名如下，且具有以下校验和：  

| 文件名 | CRC32 | MD5 | SHA-1 |  
| --- | --- | --- | --- |  
| HL-DT-ST_BD-RE_BU40N_1.00.bin | `E3C1A315` | `EDB28FCD7A239281ACE26A468D382A9C` | `9C48677B155154D24A3B95A32B4A29CA02FF40B3` |  
| ASUS_BW-16D1HT_3.02.bin | `84000B21` | `97F0EEABD0B675B4363B2C4749226016` | `F8DF5B579F25DA8D4E5AA5EF79F3005DAC5EB8C7` |  
2. 创建一个 `build` 文件夹，并在该文件夹中运行 `cmake -G Ninja ..`。  
3. 运行 `ninja`。补丁固件文件将输出到 `patched_firmware` 文件夹中。  

## 刷写  
当前推荐的驱动刷写方法是使用随 [MakeMKV](https://makemkv.com/) 提供的 `sdftool`。BU40N 固件适用于所有轻薄型驱动器，BW-16D1HT 固件适用于所有台式机驱动器。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---