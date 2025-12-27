# Freedreno Turnip 构建器

## 稳定版 / RC Mesa + Android NDK <br> 使用此构建以确保稳定性 ✅

一个简单的 Bash 脚本，旨在为 **MAGISK/KERNELSU 或 模拟器** 构建 turnip 驱动

# 更新内容 : 🔥

**[点击这里](//github.com/v3kt0r-87/Mesa-Turnip-Builder/blob/main/UPDATES.md)**

## 如何本地构建 🤔

只需克隆此仓库并使用 **BASH** 进行构建

``` 
bash build-turnip.sh
``` 
请查看下方[备注](//github.com/v3kt0r-87/Mesa-Turnip-Builder?tab=readme-ov-file#notes-)部分了解更多信息

# 应用兼容性

| 名称                                            | 状态   | 备注                                                                                                                     |
|-------------------------------------------------|--------|---------------------------------------------------------------------------------------------------------------------------|
| 3D Mark                                         | ✅     |                                                                                                                           |
| GRID™ Autosport                                 | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常。(60fps)                                                          |
| 海绵宝宝：比基尼海滩大作战                      | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常,(30 - 45 fps)                                                    |
| Carx Street                                     | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常,(30 - 45 fps)                                                    |
| Dolphin Emulator                                | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常。                                                                 |
| PPSSPP                                          | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常。                                                                 |
| EggNS                                           | ✅     | 由 [V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常。                                                                 |
| ANGLE (com.android.angle)                       | ✅     |                                                                                                                           |
| GTA 三部曲-终极版                               | ✅     | 由 [@Ryder_7777](//t.me/Ryder_7777) 测试<br>运行正常，性能较差。                                                         |
| 使命召唤 战区手机版                             | ✅     | 由 [@SeniorFurry](//t.me/SeniorFurry) 测试<br>运行正常，纹理错误，性能较差。                                             |
| 杀手：血钱 重返行动                             | ✅     | 由 [@V3KT0R-87](//github.com/V3KT0R-87) 测试<br>运行正常，60fps 中等画质。                                                |


### 备注：

### 重要提示：安卓15（SDK 35）是完全支持 Vulkan 1.4 的必要条件

## 请使用 Ubuntu 24.04 或任何基于其的发行版

**请确保在操作前有稳定的网络连接**

**如果你的网络服务商限速，请使用 VPN**

确保你的安卓版本为 ``14`` 或更高，否则无法安装

安装前请确保你拥有最新的 **MAGISK / KERNELSU**


# 致谢 🙏

### 没有以下这些了不起的人，这个项目无法完成：

 **[@MrMiy4mo](//github.com/ilhan-athn7)** 感谢你创建了 turnip 构建脚本，并允许我修改和学习。

 
 **[@Mesa3D 团队](//gitlab.freedesktop.org/mesa/mesa)** 感谢他们提供如此出色的驱动程序，使我们能够进一步提升设备性能。

 **[Adreno 驱动支持组](//t.me/adreno_driver)** 感谢他们进行测试并分享基准测试结果。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---