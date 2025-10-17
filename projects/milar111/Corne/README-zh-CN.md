# 经济型无线Corne键盘制作

一个基于Corne布局的DIY无线分体键盘，成本约为25美元。该项目使用带有nrf52840芯片的ProMicro克隆板，成为传统无线分体键盘制作的经济实惠替代方案。

## 特点
- 完全无线，使用蓝牙连接
- 分体人体工学设计（Corne布局）
- 低调设计，便于携带
- 电池供电，带电源开关
- 使用ZMK固件
- 预计电池寿命：1个月以上

## 材料清单

| 组件 | 数量 | 价格（美元） | 链接 |
|-----------|----------|------------|------|
| 控制板（ProMicro nrf52840） | 2 | 6.82 | [AliExpress](https://a.aliexpress.com/_EIV3vwY) |
| 电池 | 2 | 4.20 | [AliExpress](https://a.aliexpress.com/_Eynt9TK) |
| 机械开关 | 50 | 7.47 | [AliExpress](https://a.aliexpress.com/_EGhMxEC) |
| 键帽 | 一套 | 3.79 | [选项1](https://a.aliexpress.com/_EzQyNtA) / [选项2](https://a.aliexpress.com/_EH8mNqs) |
| 二极管（1N4148） | 100 | 0.85 | [AliExpress](https://a.aliexpress.com/_EwZoG2G) |
| 滑动开关 | 2 | 0.11 | |
| 3D打印部件 | 一套 | 1.80 | 提供文件 |

**总成本**：25.04美元（不含线材和螺丝）

## 当前键位图

![image](https://github.com/user-attachments/assets/362ff580-5528-4f7a-ad09-1fa24acbc6c7)
![image](https://github.com/user-attachments/assets/3da97ceb-8e2a-43c5-a241-cf9ad4206688)
![image](https://github.com/user-attachments/assets/e262846d-57bf-43b6-b32c-b7e37d3ebb8c)
![image](https://github.com/user-attachments/assets/2a8999cc-e58c-4d51-a142-067cb7ca768c)
![image](https://github.com/user-attachments/assets/06909fd8-bb4d-4956-88a1-f5d6a8b80e5f)

## 制作说明

### 先决条件
- 基本焊接技能
- 可使用3D打印机
- 对键盘固件的基础了解
### 外壳组装
1. 打印外壳文件（STL 文件位于 `3DFiles` 目录中）
2. 注意：你可能需要调整：
   - 电池仓尺寸
   - 滑动开关孔位

### 布线
1. 以矩阵配置连接开关
2. 连接二极管：
   - 方向很重要（黑线表示阴极）
   - 使用二极管引脚连接行
   - 使用独立线连接列
3. 保持布线远离螺丝孔
4. 连接电池：
   - GND 接 GND 引脚
   - 正极连接到滑动开关侧脚之一
   - 滑动开关中间引脚连接到 RAW 引脚

### 行列引脚连接
矩阵配置使用 nRF52840 Pro Micro 克隆板上的 GPIO 引脚。以下是连接方式：

![pinout](https://github.com/user-attachments/assets/ae1bf9eb-8071-4a8f-8cac-c95a39f61f9e)

#### 行列编号说明

- **行**：两半键盘的行均从上至下编号。
- **列**：列编号均从左至右（从板背面观察，即布线面）。

⚠️ **注意**：如果你不小心把行或列焊接到了错误的引脚，不需要拆焊。映射可以在固件配置文件中修正：
- `corne.dtsi`：定义两半键盘的行。
- `corne_left.overlay`：定义左半边的列。
- `corne_right.overlay`：定义右半边的列。

#### 左半边引脚分配
- **行（连接到 `row-gpios`）**：
  - 行 0：引脚 21
  - 行 1：引脚 20
  - 行 2：引脚 19
  - 行 3：引脚 18

- **列（连接到 `col-gpios`）**：
  - 列 0：引脚 2
  - 列 1：引脚 7
  - 列 2：引脚 6
  - 列 3：引脚 5
  - 列 4：引脚 4
  - 列 5：引脚 3

#### 右半部分引脚分配
- **行（`row-gpios`）**：
  - 行 0：引脚 21
  - 行 1：引脚 20
  - 行 2：引脚 19
  - 行 3：引脚 18
- **列（`col-gpios`）**：
  - 列 0：引脚 3
  - 列 1：引脚 4
  - 列 2：引脚 5
  - 列 3：引脚 6
  - 列 4：引脚 7
  - 列 5：引脚 2

### 固件设置
此键盘使用 ZMK 固件。左半部分作为主控制器连接到您的设备。

刷写固件步骤：
1. 快速按两次复位按钮
2. 板子将以大容量存储设备出现
3. 刷写相应的固件文件

如果您从设备中遗忘了键盘且无法重新连接：
1. 刷写 `settings_reset-nice_nano_v2-zmk.uf2` 文件
2. 重新刷写常规固件
3. 配对

## 仓库结构
```
├── .github/workflows/
│   └── build.yml
├── 3DFiles/
│   ├── STEP/
│   │   └── CorneSTEP.step
│   ├── STL/
│   │   ├── Case_Left.stl
│   │   ├── Case_Right.stl
│   │   └── PlateCorne.stl
├── config/
│   ├── boards/shields/corne/
│   │   ├── corne_left.conf
│   │   ├── corne_left.overlay
│   │   ├── corne_right.conf
│   │   ├── corne_right.overlay
│   │   ├── corne.conf
│   │   ├── corne.dtsi
│   │   ├── Kconfig.defconfig
│   │   └── Kconfig.shield
│   ├── corne.keymap
│   └── west.yml
├── firmware/
│   ├── corne_left-nice_nano_v2-zmk.uf2
│   ├── corne_right-nice_nano_v2-zmk.uf2
│   └── settings_reset-nice_nano_v2-zmk.uf2
└── zephyr/
    ├── module.yml
    └── build.yaml
```

## 已知问题
- 如果电池膨胀，左侧外壳可能会出现变形问题
- 滑动开关孔可能需要根据您的组件进行调整

## 最终结果
![im1](https://github.com/user-attachments/assets/f57abe5a-585d-4f4e-b741-5c103c7af887)
![im3](https://github.com/user-attachments/assets/1ed52801-5bc1-44b9-8378-1a5e53600e92)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-17

---