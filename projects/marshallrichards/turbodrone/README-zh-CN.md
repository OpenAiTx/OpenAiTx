# Turbodrone
反向工程API和客户端，用于从电脑控制亚马逊上畅销的约50美元“玩具”无人机，替代它们附带的闭源移动应用程序。

![S20 Drone Short Clip](https://raw.githubusercontent.com/marshallrichards/turbodrone/master/docs/images/s20-drone-short-clip-small.gif)

## 介绍
如今，亚马逊上有非常便宜的“玩具”无人机，基本上是早期DJI Mavic的简化克隆版。只需约50美元，即可拥有1080p摄像头用于第一人称视角（FPV）和录像，配备微型向下光流传感器用于定位和高度保持，并且开箱即用的飞行配置非常优秀。这类无人机唯一的问题是它们运行闭源固件，并且只能通过定制的移动应用控制。我觉得将这些无人机从它们的“监狱”中解放出来很酷，因此编写了一个API和客户端，通过反向工程移动应用的工作方式来访问视频流并向无人机发送控制命令。这样，你就可以将一架功能强大的50美元“玩具”无人机变成可以编程控制并用于各种应用和实验的设备。

## 硬件
* WiFi摄像头无人机（按推荐顺序排列）：

    | 品牌       | 型号           | 兼容性      | 购买链接                                                     | 备注  |
    |------------|----------------|-------------|-------------------------------------------------------------|-------|
    | Karuisrc   | K417           | 已测试      | [Amazon](https://www.amazon.com/Electric-Adjustable-AIdrones-Quadcopter-Beginners/dp/B0CYPSJ34H/) | 我目前最喜欢的。列表中唯一配备无刷电机的！制造质量非常棒。 |
    | Loiley     | S29            | 已测试      | [Amazon](https://www.amazon.com/Beginners-Altitude-Gestures-Adjustable-Batteries/dp/B0CFDVKJKC)      | 最佳制造质量，配备舵机可倾斜摄像头（API尚未实现）           |
    | Hiturbo    | S20            | 已测试      | [Amazon](https://www.amazon.com/dp/B0BBVZ849G), [备用Amazon链接](https://www.amazon.com/Beginners-Foldable-Quadcopter-Gestures-Batteries/dp/B0D8LK1KJ3) | 原始测试平台，制造质量优良                             |
    | FlyVista   | V88            | 已测试      | [Amazon](https://www.amazon.com/dp/B0D5CXY6X8)                                                    |       |
    | ?          | D16/GT3/V66    | 已测试      | 价格最低的 [Aliexpress](https://www.aliexpress.us/item/3256808590663347.html), [Amazon](https://www.amazon.com/THOAML-Batteries-Altitude-Headless-360%C2%B0Flip/dp/B0F1D6F62J/) | 体积比DJI Neo小20%。仅适合室内飞行。               |
    | 多品牌     | E58            | 已测试      | [Amazon](https://www.amazon.com/Foldable-Quadcopter-Beginners-Batteries-Waypoints/dp/B09KV8L7WN/)    |       |
    | 多品牌     | E88/E88 Pro    | 疑似        | [Amazon](https://www.amazon.com/Foldable-Camera-Quadcopter-Altitude-Beginner/dp/B0DZCLFQXN)          |       |
    | 多品牌     | E99/E99 Pro    | 疑似        | [Amazon](https://www.amazon.com/LJN53-Foldable-Drone-Dual-Cameras/dp/B0DRH9C6RF)                    |       |
    | Swifsen    | A35            | 疑似        | [Amazon](https://a.co/d/bqKvloz)                                                               | 非常小的“玩具”无人机                             |
    | 未知       | LSRC-S1S       | 疑似        |                                                                                               | 在另一个针对WiFi UAV应用的反向工程项目中提及          |
    | Velcase   | S101           | 待完成      | [Amazon](https://www.amazon.com/Foldable-Beginners-Quadcopter-Carrying-Positioning/dp/B0CH341G5F/) | 制造质量较低，电池和螺旋桨比S29和S20小              |
    | Redrie    | X29            | 待完成      | [Amazon](https://www.amazon.com/Adults-1080P-Foldable-Altitude-Auto-Follow-Batteries/dp/B0CZQKNYL5)  | 目前正在处理此型号                               |

    _**已测试** 表示该无人机已通过turbodrone实际运行，确保兼容性。_

  _**疑似** 表示该无人机的APK似乎使用了与已测试无人机相同的软件包和库。_

  _**待完成** 表示该APK使用不同的数据包和协议，需要在API中作为新实现添加。_

* WiFi网卡（[推荐 ALFA Network AWUS036ACM](https://www.amazon.com/Network-AWUS036ACM-Long-Range-Wide-Coverage-High-Sensitivity/dp/B08BJS8FXD)或类似产品）
  * 无人机会广播自己的WiFi网络，因此你的电脑需要连接到该网络。
  * 这不是严格必要的，因为你可以使用电脑内置的WiFi无线网卡连接无人机的网络，但使用独立网卡可以在飞行时保持电脑联网。

## 设置
切换到 `backend` 目录

```
cd backend
```
添加虚拟环境 (venv)

```
python -m venv venv
source venv/bin/activate
```
安装依赖项

```
pip install -r requirements.txt
```
_如果_你使用的是 Windows 系统，你需要手动安装 `curses` 库。

```
pip install windows-curses
```

打开一个新的终端窗口并安装前端依赖项。  
_确保你已安装 Node.js 20 及以上版本。_
```
cd frontend
npm install
```

确保已插入WiFi加密狗，飞行器已开启，连接到“BRAND-MODEL-XXXXXX”网络后再继续。

在`backend`目录中创建一个`.env`文件。根据您拥有的飞行器类型添加DRONE_TYPE：
```
# For "com.vison.macrochip" (s2x) based drones like S20 and S29:
DRONE_TYPE=s2x
# For WiFi UAV-based drones like V88 and D16:
# DRONE_TYPE=wifi_uav 
```
启动后端：  

```
uvicorn web_server:app
```

在另一个终端中，启动前端网页客户端：
```
npm run dev
```
打开位于 `http://localhost:5173` 的网页客户端，您应该能看到无人机的视频画面并能够控制它。

要通过游戏手柄控制，插入手柄并移动摇杆以便被检测到，然后按切换按钮在键盘和手柄控制之间切换。

确保在安全区域飞行，最好是在户外且风力较小的地方。请注意，“降落”按钮 _当前_ 更像是一个紧急停止按钮，会立即停止无人机电机。

## 状态
重新连接逻辑最近已解决。

视频画面：稳定。

控制：通过网页客户端大幅改进。基于WiFi的无人机实现仍需细化调整。

网页客户端：支持多种输入设备，如键盘、游戏手柄和ThinkPad TrackPoint鼠标（笑）。

正在努力增加支持来自[亚马逊畅销无人机列表](https://www.amazon.com/best-selling-drones/s?k=best+selling+drones)的更多无人机。

## 贡献
要为新的“玩具”无人机贡献支持，请在镜像站点下载该无人机使用的APK，并通过 [jadx](https://github.com/skylot/jadx) 反编译为Java文件开始逆向工程。
接着，查看 `AndroidManifest.xml`，寻找应用程序的入口类。查找明确提到的端口使用或协议使用，如TCP或UDP。这些应用大多数会在嵌入APK中的本地C++库中完成实际的通信和视频处理。您可以使用Ghidra等工具反编译本地库，看看能否发现有用信息。对于视频处理，您需要弄清它使用的格式，例如JPEG、YUV等，以及是否使用压缩，图像帧从数据包重组时的字节结构。
此外，Wireshark是理解应用发送和接收的原始数据包的好帮手。观看此[视频](https://x.com/marshallrichrds/status/1923165437698670818)，了解为Hiturbo S20无人机添加支持时的逆向工程过程。

一旦搞清楚了RC和视频的协议与处理，制作一个小型测试程序并将其添加到 `experimental` 目录，以便其他人可以尝试。
之后，您可以开发一个兼容现有后端架构的实现；示例包括 `s2x` 和 `wifi_uav` 的逆向实现。

## 实验性支持
对于支持有限且尚未完全集成到Turbodrone的无人机和应用，请参见 `experimental` 目录。






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---