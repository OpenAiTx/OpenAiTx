# ZigStar GW 多功能工具
[![构建](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml/badge.svg)](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml)
[![GitHub 版本](https://img.shields.io/github/release/xyzroe/ZigStarGW-MT.svg)](https://github.com/xyzroe/ZigStarGW-MT/releases)
[![GitHub 下载](https://img.shields.io/github/downloads/xyzroe/ZigStarGW-MT/total.svg)](https://github.com/xyzroe/ZigStarGW-MT/latest)
[![许可证](https://img.shields.io/github/license/xyzroe/ZigStarGW-MT.svg)](LICENSE.txt)


> ⚠️ **已归档 / 不再维护**
>
> 本项目现已归档，不再接收更新。
> 
> 我诚邀您尝试新的基于网页的工具 [XZG Multi-Tool](https://github.com/xyzroe/XZG-MT)，该工具提供更强的功能和持续的支持。🚀

  
这是一个最初为方便 Zig Star LAN GW 服务工作而设计的 GUI 包装器  
但现在支持任何基于 TI CC1352/CC2538/CC2652 的 Zigbee 加密狗或网关，无论制造商如何。

多功能工具打包为单个可执行文件。  
您无需安装 Python 和所需模块，也不需要使用终端——只需下载并运行即可开始使用。

## 功能：
- 读取 / 写入 / 擦除 Zigbee 模块的 NVRAM 内存
- 写入 / 校验 / 擦除 Zigbee 模块固件
- 后门串口加载器自动开启
- 支持手动重启 Zigbee 模块或 ESP32

#### 截图

<table>
<tr> 
<td width="50%">

##### Windows
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/win.png">
</td>
<td>

##### OS X
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/osx.png">
</td>
</tr>
</table>

## 使用说明：
### 1. 识别端口
#### 网络网关：
如果您使用的是 ZigStar LAN GW，IP 地址将自动检测，否则请输入网关的 IP:PORT。
#### USB 设备：
点击更新按钮识别 USB 设备，并从下拉列表中选择您的设备。
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-1.png"></div>


### 2.A 固件更新
- 选择磁盘上的固件 *.hex 文件。
- 选择所需选项。通常为擦除、写入和验证。
- 如果需要更改 IEEE 地址，请输入并勾选“写入 IEEE”复选框。
- 按“开始”按钮开始所选的过程。

如果在多功能工具右侧执行任何操作，主 IEEE 地址将放置在相应字段中。（替换手动输入或之前读取的地址）

*对于非 ZigStar 的网关或 USB 设备，您可能需要手动启用 BSL。  
另外，如果您使用的是非 ZigStar 网关，需要取消勾选自动 BSL 复选框。*
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-2.png"></div>


### 2.B NVRAM 工具
如果您在 Zigbee 网络中遇到任何问题，NVRAM 工具可能会帮助您。

- **读取** 按钮将当前 Zigbee 模块的 NVRAM 状态保存为磁盘上的 *.json 文件以便将来恢复。
- **写入** 按钮从磁盘读取保存的 NVRAM 状态 *.json 文件并写入 Zigbee 模块。
- **擦除** 按钮清除 Zigbee 模块的 NVRAM 以进行全新安装。
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-3.png"></div>

### 喜欢 ♥️？
[!["请我喝咖啡"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/xyzroe)


### 基于
[zigpy/zigpy-znp](https://github.com/zigpy/zigpy-znp)  
[JelmerT/cc2538-bsl](https://github.com/JelmerT/cc2538-bsl)  

  

<br>  

xyzroe/ZigStarGW-MT is licensed under the  
##### [GNU General Public License v3.0](https://github.com/xyzroe/ZigStarGW-MT/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---