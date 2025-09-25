# ESPHome 通过 Home Assistant 控制 PC 电源

本项目包含通过 HomeAssistant 和 ESPHome ESP8266/ESP32 板远程控制 PC 电源。

我使用此项目通过 Home Assistant 远程开关我的 PC 作为 NAS 的电源，作为唤醒局域网（WOL）已知限制的替代方案。

## 功能

* 控制连接到主板的物理 PC 电源按钮（前面板）：
  * 从任何电源状态如 `断电/挂起/休眠` 开启 PC 电源（短按电源按钮行为）。
  * 操作系统的正常 `关机/挂起/休眠`（短按电源按钮行为）。
  * 强制断电（长按电源按钮行为）。
* 读取主板上的 PC 电源开/关状态。
* 无操作系统依赖。
* 前面板的电源/重置按钮保持完全功能。
* 通过 Homeassistant 进行用户授权。
* 适用于任何（微型/迷你）ATX 电脑主板。

Youtube 视频：

[![Youtube 视频](https://img.youtube.com/vi/rAcvqaPf830/0.jpg)](https://www.youtube.com/watch?v=rAcvqaPf830)

Homeassistant 截图：

![Home Assistant 截图](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ScreenshotHomeAssistant.jpg)

## 与唤醒局域网（WOL）魔术包的区别

[唤醒局域网（WOL）](https://en.wikipedia.org/wiki/Wake-on-LAN)旨在通过以太网发送所谓的“魔术包”远程开启电脑电源。此方法存在若干已知限制，而本 ESP 项目不受这些限制影响：

* 唤醒局域网（WOL）**无授权机制**！WOL 协议没有提供密码或允许特定计算机唤醒的功能。任何同一局域网内的设备均可通过发送魔术包唤醒 PC。ESP 通过 Homeassistant 进行密码保护。
* 唤醒局域网（WOL）只能从挂起或断电状态 `唤醒` PC。没有关机/挂起功能。
* 要使 Linux 机器进入 `睡眠` 状态，可以通过 SSH 连接远程 PC 并执行 `pm-suspend` 命令（通过 `sudo apt install pm-utils` 安装），参考 [Ubuntu pm-action 文档](https://manpages.ubuntu.com/manpages/jammy/man8/pm-action.8.html)。缺点：
  * 需要 SSH 登录。
  * 需要 sudo 权限。
* 当首次连接主电源到电源供应器时，唤醒局域网魔术包会被忽略，即使 BIOS 中启用了 WOL。原因是多数电脑在首次开机时禁用 WOL，需要操作系统运行后激活，PC 才会响应魔术包以唤醒电脑。参考：[Ubuntu 唤醒局域网](https://help.ubuntu.com/community/WakeOnLan)。
* 在 Docker 容器中运行 Homeassistant 的 [唤醒局域网](https://www.home-assistant.io/integrations/wake_on_lan) 无法使用桥接网络配置转发广播魔术包。它需要一个外部 Docker 容器作为桥接以转发魔术包，超出 Homeassistant 范围。目前 Homeassistant 文档中未包含此内容。

## 硬件

硬件包括一个ESP8266或ESP32和两个IO引脚，安装在PCI金属板上（见下图）。在我的案例中，我使用了一个ESP8266 NodeMCU开发板。理论上，任何ESP8266或ESP32开发板都可以用于此项目。

* 一个引脚通过生成长按或短按来控制电源按钮
* 第二个引脚读取主板电源状态。

![Hardware](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/NodeMCU.jpg)

## 原理图

我的NAS基于Intel Core I7 ASRock Z97 ATX主板，包含标准2.5mm 2x5公头接头：

![Schematic](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Schematic.png)

**ATX接口 USB 2.0：**

接口`J1`第1针是常电+5V电源，即使PC关闭电源也有电，用于为NodeMCU供电。ESP8266或ESP32通过板载3V3稳压器供电。

**ATX接口 系统面板：**

接口`J2`包含电源、重置和接地引脚：

* 电源按钮第6针。
  * 短按：开机或生成优雅关机。
  * 长按：生成硬关机。
* 重置按钮第7针。
  * 用于通过重置按钮引脚读取电源状态：
    * 高电平：开机
    * 低电平：关机
* 接地第5针。

* 引脚`D1`用于从重置引脚读取电源状态：高电平为开，低电平为关。电阻`R1`用于当IO引脚意外设置为输出时，最小化电流。
* 引脚`D2`用于拉低电源按钮以生成短按或长按。晶体管`Q1`用于ESP8266与主板之间的安全隔离。

警告：所有ATX和ESP引脚必须工作在3V3电压下。

## 下载

* [KiCad原理图 .SCH](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/kicad/ESP8266-ESPHome-PC-Power-HomeAssistant.pro)

## 接线
![Wiring](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/Wiring.jpg)

一个自制的分线板PCB可以安装在系统面板插针上，以连接电源按钮 `SW1` 和复位按钮 `SW2`。

## WiFi 稳定性

ATX 电脑机箱内有足够空间安装 ESP 板。然而，电脑机箱为金属屏蔽，会减少与基站的 WiFi 距离。建议当 WiFi 连接不稳定或距离过近时，将 ESP 放置在电脑机箱外。ESP32 可能会带来不同的 WiFi 连接稳定性，但总体上取决于环境。

ESP8266 PCB 安装在电脑机箱背面：

![ESP PC mount](https://raw.githubusercontent.com/Erriez/ESPHomePCPowerControlHomeAssistant/master/images/ESPMount.jpg)

## 软件更新

ESPHome 应用固件可以通过 USB 连接（虚拟串口）或 WiFi OTA（空中升级）进行更新。

通过 WiFi 更新固件需要在 .yaml 文件中配置 `ota`，这要求主机电脑与 ESP 之间有 WiFi 连接。当 ESP 登录到 WiFi 基站失败（例如 WiFi 凭据错误）时，OTA 更新将无法使用。这种情况下需要通过串口更新，或者通过 .yaml 文件中配置的 `ap` 回退模式进行更新。

## ESPHome

ESPHome 应用由两个 Yaml 文件组成。一个配置文件和第二个 `secrets.yaml` 用于存储密码。

文档：

* [ESPHome GPIO 开关](https://esphome.io/components/switch/gpio.html)
* [ESPHome 二进制传感器](https://esphome.io/components/binary_sensor/gpio.html)

### 项目配置

配置以下文件：
- [pc-power.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/pc-power.yaml)：配置 `platform` 和 `board`。
- [secrets.yaml](https://github.com/Erriez/ESPHomePCPowerControlHomeAssistant/blob/master/secrets.yaml)：配置 WiFi SSID 和密码

更多关于 ESPHome YAML 配置的信息，请参考 [ESPHome 文档](https://esphome.io/components/esphome.html)。

### 编程 ESP8266 或 ESP32

连接 USB 线到 ESP8266 或 ESP32 板，输入以下命令。（示例在 Ubuntu 上测试）。更多信息请参考 [ESPHome.io](https://esphome.io/guides/getting_started_command_line.html)。



```bash
# Clone this repository
$ git clone git@github.com:Erriez/ESPHomePCPowerControlHomeAssistant.git

# Install Python3 virtualenv
$ sudo apt install python3-virtualenv

# Create virtualenv
$ virtualenv venv

# Activate virtualenv
$ source venv/bin/activate

# Install ESPHome
$ pip install esphome

# Optional: Install platformio updates
$ platformio platform update
$ platformio upgrade

# Optional: Add user permission serial port
$ sudo usermod -a -G dialout <USERNAME>
$ sudo reboot now

# Check ESPHome installation
$ esphome --help

# Optional: Compile program without upload
$ esphome compile pc-power.yaml

# Upload program to ESP8266 or ESP32
$ esphome run pc-power.yaml

# Select serial port or WiFi to upload application

# Check logs
$ esphome logs pc-power.yaml
```

## Home Assistant 配置

本节介绍 Home Assistant 的配置。

### 注册 ESP 设备

* `配置 | 集成：添加集成：ESPHome`
* 选择 ESP 设备的主机名或 IP 地址。
* 输入在 `secrets.yml` | `esphome_api_password` 中配置的密码。

### Homeassistant | 编辑仪表盘 | 原始配置编辑器

通过原始编辑将 PC 电源集成添加到仪表盘：

```yaml
title: Home
views:
  - title: PC
    path: pc
    badges: []
    cards:
      - type: button
        entity: switch.pc_power_toggle
        show_name: true
      - type: button
        tap_action:
          action: none
        entity: binary_sensor.pc_power_state
        hold_action:
          action: none
      - type: button
        tap_action:
          action: toggle
        entity: switch.pc_hard_power_off
        icon_height: 40px
        show_state: false
        show_name: true
        show_icon: true
```

## 版本历史

重启 Home Assistant 即可开始使用！

### 2024年10月11日更新

ESPHome YAML 文件格式随着 [ESPHome 版本 2024.6.0](https://esphome.io/changelog/2024.6.0.html#) 发生了变化。旧格式会产生如下错误：

```
$ esphome compile ESPHomePCPowerControlHomeAssistant/pc-power.yaml
INFO ESPHome 2024.9.2
INFO Reading configuration ESPHomePCPowerControlHomeAssistant/pc-power.yaml...
Failed config

ota.unknown: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:27]

  'ota' requires a 'platform' key but it was not specified.

and:

Failed config

switch.gpio: [source ESPHomePCPowerControlHomeAssistant/pc-power.yaml:30]

  Pin 4 is used in multiple places.
```
在这种情况下，请在此项目中更新为新文件格式。

### 2022年2月13日更新

* 通过Homeassistant脚本控制的按钮引脚时序不稳定。电源引脚控制已移至ESP固件，生成更准确的时序。
* 重命名以下名称：
  * 将 `switch.pc_power_button` 重命名为 `switch.pc_power_toggle`。
  * 将 `switch.pc_power_button_long_press` 重命名为 `switch.pc_hard_power_off`。
  * 将 `switch.pc_power_sense` 重命名为 `switch.pc_power_state`。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-25

---