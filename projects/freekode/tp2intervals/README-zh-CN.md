[![构建分支](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml/badge.svg)](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml)
[![发布](https://img.shields.io/github/release/freekode/tp2intervals)](https://github.com/freekode/tp2intervals/releases/latest)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E6W6XZP)

# Third Party to Intervals.icu

用于在 TrainingPeaks、TrainerRoad 和 Intervals.icu 之间同步锻炼的应用程序。

支持 MacOS（DMG）、Windows（EXE 安装程序）、Linux（AppImage）。另外还有 Docker 镜像和可执行 JAR 文件。

所有文件均可在[发布页面](https://github.com/freekode/tp2intervals/releases/latest)下载。

**仅供教育用途**

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp.png?raw=true" width="25%"><img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr.png?raw=true" width="25%">

* [功能列表](#list-of-features)
* [配置](#configuration)
    + [Intervals.icu](#intervalsicu)
    + [TrainingPeaks](#trainingpeaks)
    + [TrainerRoad](#trainerroad)
* [其他运行方式](#other-ways-to-run-the-app)
    + [可执行 JAR](#executable-jar)
    + [Docker](#docker)
* [常见问题](#faq)
    + [通用](#general)
    + [关于使用 TrainingPeaks 免费账户安排次日计划的信息](#info-regarding-scheduling-for-the-next-day-with-trainingpeaks-free-account)
* [故障排除](#troubleshooting)
    + [如何获取日志](#how-to-get-logs)
    + [如何录制 HAR 文件](#how-to-record-har-file)



**新的 Docker 镜像地址 ⚠️**

**新的镜像地址: `ghcr.io/freekode/tp2intervals`**

旧的镜像地址: `ghcr.io/freekode/tp2intervals/tp2intervals`

**TrainerRoad 更新**

我不再拥有 TrainerRoad 的访问权限。我的账户取消了订阅。我不使用该平台，而且偶尔使用时费用太高。  
要解决问题，我只能依赖你们提供的日志和 HAR 文件。

## 功能列表

**TrainingPeaks**

运动员账户  
* 在 Intervals.icu 和 TrainingPeaks 之间同步日历中的计划训练（使用免费 TP 账户同步今天和明天）  
* 从 TrainingPeaks 复制整个训练计划  
* 从 TrainingPeaks 的计划训练创建 Intervals.icu 上的训练计划或训练文件夹  

教练账户  
* 从 TrainingPeaks 复制整个训练计划和训练库  

**TrainerRoad**  
* 将 TrainerRoad 的计划训练同步到 TrainingPeaks 或 Intervals.icu 的日历中  
* 从 TrainerRoad 库复制训练到 Intervals  
* 从 TrainerRoad 的计划训练创建 Intervals.icu 上的训练计划或训练文件夹  

通过每 20 分钟检查一次你的日历，自动安排今天的训练。  
要清除已安排的任务，只需重启应用程序即可。  


## 配置  
在使用应用程序之前，你需要配置平台访问权限。  
必须有 Intervals.icu 的访问权限，访问其他平台为可选。  

收集所有必需的配置后，你可以点击确认按钮。  
如果一切正常，你将被重定向到主页。  

如果配置错误，你将看到没有访问特定平台的错误。  
请检查所有数值并重新保存配置。  

### Intervals.icu  
从 Intervals.icu 网页的[设置页面](https://intervals.icu/settings)开发者设置部分复制 API 密钥和运动员 ID。  

### TrainingPeaks
要使用 TrainingPeaks，请从请求 `https://tpapi.trainingpeaks.com/users/v3/token` 中复制所有 Cookie 并放入配置页面。  
应用程序会自动删除多余部分，只保留所需的 Cookie。请按照以下指南操作。  

应用程序需要 `Production_tpAuth` Cookie（键和值，类似 `Production_tpAuth=very_long_string`）。  
另一个指南请见[此处](https://forum.intervals.icu/t/implemented-push-workout-to-wahoo/783/87)  

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp_guide.png?raw=true">  

### TrainerRoad  
配置与 TrainingPeaks 非常相似。从请求 `https://tpapi.trainingpeaks.com/users/v3/token` 中复制所有 Cookie 并放入配置页面。  
应用程序会自动删除多余部分，只保留所需的 Cookie。请按照以下指南操作。  

应用程序需要 `SharedTrainerRoadAuth` Cookie（键和值，类似 `SharedTrainerRoadAuth=very_long_string`）。  

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr_guide.png?raw=true">  

请注意，Firefox 在开发者工具窗口中会截断长字符串。请右键点击 Cookie 值 -> 复制值。  

## 其他运行应用程序的方法  
### 可执行 JAR  
该项目带有带有 Web UI 的可执行 jar 文件。它需要 JDK 21。运行 jar 文件命令：
```shell
java -jar tp2intervals.jar
```
默认情况下，UI 可通过 `http://localhost:8080` 访问。要更改端口，请使用参数启动 jar：

```shell
java -Dserver.port=9090 -jar tp2intervals.jar
```

### Docker
每个版本也会构建 Docker 镜像

```yaml
services:
  app:
    image: ghcr.io/freekode/tp2intervals:latest
    container_name: tp2intervals
    volumes:
      - ./tp2intervals.sqlite:/tp2intervals.sqlite
    ports:
      - '8080:8080'
```
## 常见问题解答

### 通用
* TrainerRoad 中不支持 Ramp steps
* **MacOS arm64** 错误：`"tp2intervals" 已损坏，无法打开。`
  在终端运行命令 `xattr -d com.apple.quarantine /Applications/tp2intervals.app`，然后重新打开应用
* **MacOS** 应用未签名。通常需要打开两次
* **Windows** 应用会请求访问本地网络和互联网，您需要允许。毕竟它会发送 HTTP 请求
* 更多信息请访问论坛 https://forum.intervals.icu/t/tp2intervals-copy-trainingpeaks-and-trainerroad-workouts-plans-to-intervals/63375

### 关于使用 TrainingPeaks 免费账户安排第二天计划的信息
官方说如果你使用免费 TP 账户，不能为未来日期规划训练，但实际上可以。
你可以为相对于 TrainingPeaks 服务器本地时间的第二天安排训练。服务器位于 UTC-6 时区。下面是一些示例：

示例 1. 你的时区为 UTC+2，当前本地时间为 2024.05.20 06:00。此时 TP 服务器本地时间是 2024.05.19 22:00。
因此，你可以安排 2024.05.20 的训练。但不能安排 2024.05.21 的训练，2 小时后可以安排，因为 2 小时后服务器本地时间将是 2024.05.20 00:00。

示例 2. 你的时区为 UTC+12，当前本地时间为 2024.05.20 18:00。TP 服务器本地时间是 2024.05.20 00:00。此时，你可以安排 2024.05.21 的训练。

可视时间差请参见 [worldtimebuddy](https://www.worldtimebuddy.com/?pl=1&lid=206,100,756135,2193733&h=206&hf=0)

## 故障排除
为了识别任何平台的问题，用户日志非常有帮助。

请按照下面的[指南](#how-to-get-logs)收集日志。如果是 TrainerRoad 平台，尝试[录制 HAR 文件](#how-to-record-har-file)。将文件直接发送给我。

#### 如何获取日志
1. 进入配置
2. 在通用部分勾选调试模式，点击确认
3. 重现你的问题
4. 根据你的系统找到日志文件

* Linux: ~/.config/tp2intervals/logs/main.log
* MacOS: ~/Library/Logs/tp2intervals/main.log
* Windows: %USERPROFILE%\AppData\Roaming\tp2intervals\logs\main.log
* JAR: ./tp2intervals.log

#### 如何录制 HAR 文件
1. 在浏览器中打开新标签页

2. 打开开发者工具，勾选保留日志（Firefox 齿轮 -> 保留日志）

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-1.png?raw=true" width="70%">
3. 接下来的步骤非常重要，因为它们模拟了应用程序的操作。
   打开 TrainerRoad 页面，打开训练库，找到任意训练，打开训练页面（该页面包含训练步骤图表、描述、替代方案等）
4. 在开发者工具中，点击导出 HAR（Firefox - 齿轮 -> 全部保存为 HAR），保存文件并发送给我

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-2.png?raw=true" width="70%">



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---