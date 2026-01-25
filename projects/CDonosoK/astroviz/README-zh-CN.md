# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="AstroViz Image" width="800" height="500">

[![License](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![ROS2 Version](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroViz 是 ROS 2 机器人任务的终极实时数据可视化套件。AstroViz 从零开始构建，注重灵活性、清晰度和性能，为机器人学家、工程师和现场操作员提供统一界面，以实时监控、控制和调试复杂系统。

- 🌍 一体化可视化：从 GPS 和 LiDAR 到摄像头画面、机器人状态和电机健康，AstroViz 将多种视图整合成一个统一且现代的图形界面。
- ⚡ 高性能：基于 Docker 的部署支持 GPU，确保即使在数据密集环境中也能流畅运行。
- 🛰️ 现场验证：无论是自主车辆、无人机还是地面机器人，AstroViz 都是您的视觉指挥中心。

💡 想要一个超越原始数据、帮助您在现场做出实时决策的 ROS 2 工具吗？
<b>AstroViz 就是为此而生。</b>

## 可视化概览
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>仪表板查看器</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Teleoperation Overview" width="800">
    </td>
  </tr>
</table>

有关所有已实现窗口的详细视图，请参见：[已实现窗口](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## 目录
1. [快速开始](#get-started)
   - [先决条件](#prerequisites)
   - [安装](#installation)
      - [克隆仓库](#clone-the-repository)
      - [使用 Docker 构建](#build-using-docker)
      - [运行 Docker 容器](#run-the-docker-container)
2. [使用方法](#usage)
   - [节点概览](#node-overview)
   - [运行节点](#running-nodes)
3. [维护者](#maintainer)
3. [许可](#license)

---

## 快速开始
### 前提条件

运行此软件包，请确保安装以下依赖项：
- **Git**：用于版本控制和代码库管理。
- **Docker**：简化环境搭建和运行。
- **NVIDIA 容器工具包**（如果使用 NVIDIA GPU）：用于硬件加速。


### 安装

#### 克隆代码库
首先克隆代码库：
```bash
git clone git@github.com:hucebot/astroviz.git
```

#### 使用 Docker 构建
本仓库包含预配置的 Docker 设置，便于快速部署。构建 Docker 镜像：
1. 进入 `docker` 目录：
   ```bash
   cd astroviz/docker
   ```
2. 运行构建脚本：
   ```bash
   sh build.sh
   ```
   这将创建一个名为 `astroviz` 的 Docker 镜像。

#### 运行 Docker 容器
构建完成后，使用以下命令启动容器：
```bash
sh run.sh
```
---

## 使用说明
### 节点概述

本包节点旨在促进远程操作和数据可视化。每个节点在远程操作工作流程中都有特定用途：
- **gpsmap_viewer**：在地图上可视化GPS数据。
- **camera_viewer**：显示机器人的摄像头画面。
- **imu_viewer**：可视化IMU数据。
- **lidar_viewer**：可视化激光雷达数据。
- **teleoperation_viewer**：提供远程操作控制的GUI界面。
- **dashboard_viewer**：一个集成各种数据流的综合仪表盘，提供统一的监控和控制界面。
- **plot_viewer**：显示各种数据流的实时图表。
- **grid_map_viewer**：可视化导航和规划用的网格地图数据。
- **robot_state_viewer**：显示机器人当前状态，涉及关节位置和变换。
- **motor_state_viewer**：监控并可视化机器人电机状态，包括温度和电压读数。
- **record_manager_viewer**：管理和可视化录制会话，允许用户开始、停止及回顾录制内容。

### 运行节点
要运行这些节点，您可以使用以下命令：
```bash
ros2 run astroviz <node_name>
```
将 `<node_name>` 替换为您希望运行的节点名称，例如 `gps_map_viewer`、`camera_viewer` 等。

或者，如果您更喜欢运行集成所有功能的仪表盘查看器：
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```

## 维护者
本软件包由以下人员维护：

**Clemente Donoso**  
电子邮件: [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)  
GitHub: [CDonosoK](https://github.com/CDonosoK)  

---

## 许可证
本项目采用 **MIT** 许可证。详情请参阅 [LICENSE](LICENSE) 文件。

---
欢迎贡献和反馈！如果您遇到任何问题或有改进建议，欢迎提出 issue 或提交 pull request。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---