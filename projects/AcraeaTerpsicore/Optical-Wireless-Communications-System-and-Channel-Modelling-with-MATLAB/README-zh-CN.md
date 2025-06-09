[toc]

## 概述

本仓库包含与*光无线通信系统与信道建模（MATLAB实现）*相关的源代码。

**部分原始代码存在问题并需要修改。我已进行了必要的调整，以提升其实用性和功能性。**


## MATLAB 版本

MATLAB R2024a

## 目录结构

- `util/` - 工具脚本和函数。

## 部分代码说明

以下是本仓库中部分 MATLAB 脚本的列表（并非全部）：

| 名称                      | 描述                                                                                                  |
| ------------------------ | ----------------------------------------------------------------------------------------------------- |
| `CORRECT_plot_Fig3p31.m` | gamma-gamma 概率密度函数（PDF）                                                                       |
| `CORRECT_plot_Fig3p28.m` | 对数正态分布的概率密度函数（PDF）                                                                     |
| `CORRECT_program_4p4.m`  | 程序4.4：用于仿真开关键控非归零（OOK-NRZ）比特误码率（BER）的 MATLAB 代码                             |
| `CORRECT_program_4p5.m`  | 程序4.5：使用匹配滤波器接收机仿真 OOK-NRZ BER 的 MATLAB 代码                                          |
| `CORRECT_plot_Fig4p13.m` | 程序4.10：用于计算离散脉冲间隔调制（DPIM，0保护间隔）功率谱密度（PSD）的 MATLAB 代码                  |

## 使用方法

要使用这些脚本，请确保将 `util/` 目录包含在您的 MATLAB 路径中。可以通过在 MATLAB 启动脚本中添加以下代码行，或直接在 MATLAB 命令窗口运行：

```matlab
addpath('path/to/util');
```

请将 `'path/to/util'` 替换为实际的 `util/` 目录路径。

## 贡献

欢迎通过 Fork 本仓库并提交 Pull Request 来贡献您的代码。任何增强、修复或新特性都非常欢迎。

## 鸣谢

本项目基于*光无线通信系统与信道建模（MATLAB实现）*。特别感谢原始代码的作者与贡献者。

---



### &#8627; Stargazers
[![Stargazers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/stars/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/stargazers)

### &#8627; Forkers
[![Forkers repo roster for @AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB](http://reporoster.com/forks/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB)](https://github.com/AcraeaTerpsicore/Optical-Wireless-Communications-System-and-Channel-Modelling-with-MATLAB/network/members)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---