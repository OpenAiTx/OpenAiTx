# ROS2 与 Gazebo Sim Harmonic 中的阿克曼转向车辆仿真

本项目展示了一个具备**阿克曼转向功能**的定制车辆仿真，基于**ROS2**和**Gazebo Sim Harmonic 环境**开发。该模型集成了多种传感器和导航工具，实现自主运行，是该仿真框架中首批实现阿克曼转向车辆的项目之一。

| **3D 激光雷达点云可视化** | **仓库环境模型** |
| ----- | ----- |
| ![3D Point Cloud](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Warehouse Model](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### 如果你喜欢此项目，欢迎点个⭐支持！

## 目录

- [ROS2 与 Gazebo Sim Harmonic 中的阿克曼转向车辆仿真](#ros2-与-gazebo-sim-harmonic-中的阿克曼转向车辆仿真)
- [功能](#功能)
  - [1 阿克曼转向](#1-阿克曼转向)
  - [2 ROS2 通信](#2-ros2-通信)
  - [3 传感器](#3-传感器)
  - [4 导航](#4-导航)
  - [5 使用外部手柄的手动控制](#5-使用外部手柄的手动控制)
  - [6 可视化](#6-可视化)
- [需求](#需求)
- [本地安装](#本地安装)
- [Docker 安装](#docker-安装)
- [使用方法](#使用方法)
  - [1 基本仿真与手动控制](#1-基本仿真与手动控制)
  - [2 SLAM 同时定位与地图构建](#2-slam-同时定位与地图构建)
  - [3 使用 Nav2 进行导航](#3-使用-nav2-进行导航)
- [未来工作](#未来工作)
- [画廊](#画廊)
- [TF 树](#tf-树)
- [Star 历史](#star-历史)

## 功能

### 1. **阿克曼转向**

- 一个自定义车辆模型，采用真实的阿克曼转向动力学，实现精准机动性能。

### 2. **ROS2 通信**

- 所有传感器数据和控制信号均完全集成到 ROS2 生态系统中，实现无缝互操作。

### 3. **传感器**

- **IMU**：提供姿态和角速度。
- **里程计**：确保车辆状态反馈的准确性。
- **激光雷达**：安装用于障碍物检测和环境扫描。支持生成 3D 点云，用于高级感知任务。
- **摄像头**：
  - 前置
  - 后置
  - 左侧
  - 右侧
  > **注意：** 默认情况下，只有前置摄像头桥接到 ROS 2。如果您想在 ROS 2 中使用所有摄像头（左、右、后），请移除 `saye_bringup/config/ros_gz_bridge.yaml` 中相关摄像头部分开头的 `#` 符号以激活它们（例如，`/camera/left_raw`、`/camera/right_raw`、`/camera/rear_raw`）。

### 4. **导航**

- 集成了 **Nav2 栈** 实现自主导航。
- 使用 **AMCL（自适应蒙特卡洛定位）** 提升位置精度。
- 实现了 **SLAM** 技术，用于实时地图构建和环境理解。
- 经过微调的参数，优化导航性能。

### 5. **手动控制（外接操纵杆）**

- 在仿真环境中新增了基于操纵杆的手动控制支持，用户可交互式测试车辆运动。

### 6. **可视化**

- 在 **RViz2** 中实现完整模型和传感器数据的可视化，提供机器人状态和环境反馈的洞察。

## 需求

- **ROS2（Humble）**
- **Gazebo Sim Harmonic**
- **RViz2**
- **Nav2**

## 本地安装

0. 您需要确保已安装 Gazebo Harmonic 和 ROS（ros_gz）：<br>
   `sudo apt-get install ros-${ROS_DISTRO}-ros-gz`<br>
   `sudo apt-get install ros-humble-ros-gzharmonic`（仅限Humble版本）<br>
   有关安装Gazebo和ROS的更多详情：<a href="https://gazebosim.org/docs/latest/ros_installation/">链接</a>
1. 克隆仓库：<br>
   `mkdir -p ackermann_sim/src && cd ackermann_sim/src`<br>
   `git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2`<br>`cd ..`
2. 构建项目：
   `colcon build && source install/setup.bash`
3. 设置环境变量：
   ```bash
   # Set environment variables for current session
   export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   ```

   **永久设置：**
   
   要使这些环境变量永久生效，请将它们添加到你的 `.bashrc` 文件中：
   ```bash
   # Add environment variables to .bashrc
   echo 'export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   echo 'export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   
   # Apply changes
   source ~/.bashrc
   ```

   > **注意：** 将 `/your/path/` 替换为您的实际安装路径。

## Docker 安装

您也可以使用 Docker 运行仿真，这可以确保在不同系统之间具有一致的环境。

### 前提条件
- Docker
- NVIDIA 容器工具包（用于 GPU 支持）

### 使用 Docker 运行的步骤

1. 克隆仓库：
   ```bash
   mkdir -p ackermann_sim/src && cd ackermann_sim/src
   git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2
   cd ackermann-vehicle-gzsim-ros2
   ```

2. 构建并运行 Docker 容器：
   ```bash
      docker run -it \
      --name ackermann_sim \
      --hostname ackermann_sim \
      --env="DISPLAY=$DISPLAY" \
      --env="QT_X11_NO_MITSHM=1" \
      --volume="/tmp/.X11-unix:/tmp/.X11-unix:rw" \
      --privileged alitekes1/ackermann_sim:latest
   ```
3. 如果您想为同一容器添加额外的终端

   ```bash
      docker exec -it ackermann_sim bash
   ```
   
> **注意：** 在容器内部，您可以像平常一样运行仿真命令。

## 使用方法

### 1. 基本仿真和手动控制

1.  启动仿真：

    ```bash
    ros2 launch saye_bringup saye_spawn.launch.py
    ```
2.  控制车：
    ```bash
    ros2 run teleop_twist_keyboard teleop_twist_keyboard
    ```

### 2. SLAM（同步定位与地图构建）

-   要运行 SLAM Toolbox 进行地图构建，请在启动仿真后运行以下命令：
    ```bash
    ros2 launch saye_bringup slam.launch.py
    ```
    [![SLAM- Youtube](https://img.youtube.com/vi/QWcJ9TlqFOU/0.jpg)](https://www.youtube.com/watch?v=QWcJ9TlqFOU "项目介绍")

### 3. 使用 Nav2 进行导航

-   要使用 Nav2 堆栈进行自主导航仿真，启动仿真后运行以下命令：
    ```bash
    ros2 launch saye_bringup navigation_bringup.launch.py
    ```
    [![自主导航 - Youtube](https://img.youtube.com/vi/SJ4NrbdlNZo/0.jpg)](https://www.youtube.com/watch?v=SJ4NrbdlNZo "NAV2")

> **注意：** 上述YouTube视频以4倍速播放。您可以点击图片观看视频。

## 未来工作

1. **3D SLAM 支持：**
   - 使用先进的深度强化学习算法训练车辆自主处理复杂场景。
2. **增强功能：**
   - 探索更多传感器配置和导航策略。
3. **Nav2与3D定位集成**
   - 取代AMCL（二维），实现更准确且鲁棒的算法。
## 图库

![2024-09-23 00-09-48.png截图](https://github.com/user-attachments/assets/dd5604c6-014e-4a7a-9a2f-c4dd237abb37)

### 3D激光雷达点云与环境

| **3D激光雷达点云可视化**                                        | **仓库环境模型**                                               |
| --------------------------------------------------------------- | -------------------------------------------------------------- |
| ![3D点云](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![仓库模型](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### 车辆与导航

| **Gazebo仿真谐波**                                                                                                         | **RViz2**                                                                                                                  |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| ![2024-09-23 00-13-03.png截图](https://github.com/user-attachments/assets/1d2b56f7-34c1-4b01-9a85-fb01ceab5bd6)                | ![2024-09-23 00-09-04.png截图](https://github.com/user-attachments/assets/ba6853fd-4143-4b4d-bbc6-072895e4c75e)               |
| ![2024-09-23 00-12-13.png截图](https://github.com/user-attachments/assets/477cce7b-995b-471e-a684-4d82bee0fc34)                | ![2024-09-23 00-15-04.png截图](https://github.com/user-attachments/assets/bf9ad916-14a6-4b62-a799-4169a767e4dd)               |
| ![替代文本](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/saye.png)       | ![替代文本](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/rviz_saye.png)  |

## TF树

![TF树](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/frames.png)

---

## 星标历史

<a href="https://www.star-history.com/#alitekes1/ackermann-vehicle-gzsim-ros2&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <img alt="星历史图表" src="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---