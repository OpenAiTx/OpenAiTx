# ROS2 と Gazebo Sim Harmonic によるアッカーマンステアリング車両シミュレーション

本プロジェクトは、**アッカーマンステアリング機能**を備えたカスタム車両のシミュレーションを、**ROS2** と **Gazebo Sim Harmonic 環境**を用いて開発したものです。モデルは自律運転のための各種センサーやナビゲーションツールを統合しており、このシミュレーションフレームワークでのアッカーマンステアリング車両の初期実装の一つとなっています。

| **3D LiDAR ポイントクラウドの可視化** | **倉庫環境モデル** |
| ----- | ----- |
| ![3D Point Cloud](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Warehouse Model](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### このプロジェクトが気に入ったら、ぜひ⭐を付けて応援してください！

## 目次

- [ROS2 と Gazebo Sim Harmonic によるアッカーマンステアリング車両シミュレーション](#ros2-と-gazebo-sim-harmonic-によるアッカーマンステアリング車両シミュレーション)
- [特徴](#特徴)
  - [1 アッカーマンステアリング](#1-アッカーマンステアリング)
  - [2 ROS2 通信](#2-ros2-通信)
  - [3 センサー](#3-センサー)
  - [4 ナビゲーション](#4-ナビゲーション)
  - [5 外部ジョイスティックによる手動制御](#5-外部ジョイスティックによる手動制御)
  - [6 可視化](#6-可視化)
- [要件](#要件)
- [ローカルインストール](#ローカルインストール)
- [Docker インストール](#docker-インストール)
- [使用方法](#使用方法)
  - [1 基本シミュレーションと手動制御](#1-基本シミュレーションと手動制御)
  - [2 SLAM 同時位置推定と地図作成](#2-slam-同時位置推定と地図作成)
  - [3 Nav2 を用いたナビゲーション](#3-nav2-を用いたナビゲーション)
- [今後の展望](#今後の展望)
- [ギャラリー](#ギャラリー)
- [TF ツリー](#tf-ツリー)
- [スター履歴](#スター履歴)

## 特徴

### 1. **アッカーマンステアリング**

- 現実的なアッカーマンステアリングダイナミクスを用いて構築されたカスタム車両モデルにより、正確な操縦性を実現。

### 2. **ROS2 通信**

- すべてのセンサーデータと制御信号は、シームレスな相互運用性のためにROS2エコシステムに完全に統合されています。

### 3. **センサー**

- **IMU**：姿勢と角速度を提供します。
- **オドメトリ**：正確な車両状態のフィードバックを保証します。
- **LiDAR**：障害物検出と環境スキャンのために搭載されています。高度な認識タスクのための3Dポイントクラウド生成をサポートします。
- **カメラ**：
  - 前面
  - 後面
  - 左側
  - 右側
  > **注意:** デフォルトでは、前面カメラのみがROS 2にブリッジされています。すべてのカメラ（左、右、後）をROS 2で使用したい場合は、`saye_bringup/config/ros_gz_bridge.yaml`の該当するカメラセクションの先頭の`#`を削除して有効化してください（例：`/camera/left_raw`、`/camera/right_raw`、`/camera/rear_raw`）。

### 4. **ナビゲーション**

- 自律ナビゲーションのために**Nav2スタック**と統合されています。
- 位置精度向上のための**AMCL（適応型モンテカルロ局所化）**。
- リアルタイムマッピングと環境理解のために**SLAM**技術を実装しています。
- 最適なナビゲーション性能のためにパラメータを微調整しています。

### 5. **マニュアルコントロール（外部ジョイスティック使用）**

- シミュレーション環境でのジョイスティックベースの手動制御をサポートし、ユーザーが車両の動きをインタラクティブにテストできるようにしました。

### 6. **可視化**

- **RViz2**での完全なモデルとセンサーデータの可視化により、ロボットの状態や環境のフィードバックを把握できます。

## 必要条件

- **ROS2 (Humble)**
- **Gazebo Sim Harmonic**
- **RViz2**
- **Nav2**

## ローカルインストール

0. Gazebo HarmonicおよびROS（ros_gz）のインストールを確認してください：<br>
   `sudo apt-get install ros-${ROS_DISTRO}-ros-gz`<br>
   `sudo apt-get install ros-humble-ros-gzharmonic`（Humbleバージョンのみ）<br>
   GazeboとROSのインストールに関する詳細はこちら：<a href="https://gazebosim.org/docs/latest/ros_installation/">リンク</a>
1. リポジトリをクローンします：<br>
   `mkdir -p ackermann_sim/src && cd ackermann_sim/src`<br>
   `git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2`<br>`cd ..`
2. プロジェクトをビルドします：
   `colcon build && source install/setup.bash`
3. 環境変数を設定します：
   ```bash
   # Set environment variables for current session
   export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   ```

   **恒久的な設定の場合：**
   
   これらの環境変数を恒久的に設定するには、`.bashrc` ファイルに追加してください：
   ```bash
   # Add environment variables to .bashrc
   echo 'export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   echo 'export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   
   # Apply changes
   source ~/.bashrc
   ```

   > **注意:** `/your/path/` を実際のインストールパスに置き換えてください。

## Dockerのインストール

Dockerを使用してシミュレーションを実行することもでき、これにより異なるシステム間で一貫した環境が保証されます。

### 前提条件
- Docker
- NVIDIAコンテナツールキット（GPUサポート用）

### Dockerでの実行手順

1. リポジトリをクローンする:
   ```bash
   mkdir -p ackermann_sim/src && cd ackermann_sim/src
   git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2
   cd ackermann-vehicle-gzsim-ros2
   ```

2. Dockerコンテナのビルドと実行：
   ```bash
      docker run -it \
      --name ackermann_sim \
      --hostname ackermann_sim \
      --env="DISPLAY=$DISPLAY" \
      --env="QT_X11_NO_MITSHM=1" \
      --volume="/tmp/.X11-unix:/tmp/.X11-unix:rw" \
      --privileged alitekes1/ackermann_sim:latest
   ```
3. 同じコンテナに追加のターミナルを使用したい場合

   ```bash
      docker exec -it ackermann_sim bash
   ```
   
> **注意:** コンテナ内では、通常通りシミュレーションコマンドを実行できます。

## 使用方法

### 1. 基本的なシミュレーションと手動制御

1.  シミュレーションを起動する:

    ```bash
    ros2 launch saye_bringup saye_spawn.launch.py
    ```
2.  制御車:
    ```bash
    ros2 run teleop_twist_keyboard teleop_twist_keyboard
    ```

### 2. SLAM（同時自己位置推定と地図作成）

-   マッピング用にSLAM Toolboxを実行するには、シミュレーション開始後に次のコマンドを起動します：
    ```bash
    ros2 launch saye_bringup slam.launch.py
    ```
    [![SLAM- Youtube](https://img.youtube.com/vi/QWcJ9TlqFOU/0.jpg)](https://www.youtube.com/watch?v=QWcJ9TlqFOU "プロジェクト紹介")

### 3. Nav2によるナビゲーション

-   自律航行のためにNav2スタックを使ってシミュレーションを実行するには、シミュレーションを開始した後に以下を起動します:
    ```bash
    ros2 launch saye_bringup navigation_bringup.launch.py
    ```
    [![自律航法 - Youtube](https://img.youtube.com/vi/SJ4NrbdlNZo/0.jpg)](https://www.youtube.com/watch?v=SJ4NrbdlNZo "NAV2")

> **注意:** 上記のYouTube動画は4倍速で再生されています。画像をクリックすると動画にアクセスできます。

## 今後の課題

1. **3D SLAM対応:**
   - 高度なDRLアルゴリズムを用いて、複雑なシナリオを自律的に処理する車両の訓練。
2. **機能強化:**
   - 追加のセンサー構成やナビゲーション戦略の検討。
3. **Nav2の3Dローカリゼーションへの統合**
   - AMCL(2D)の代わりに、より正確で堅牢なアルゴリズムの実装。
## ギャラリー

![Screenshot from 2024-09-23 00-09-48.png](https://github.com/user-attachments/assets/dd5604c6-014e-4a7a-9a2f-c4dd237abb37)

### 3D LiDARポイントクラウド & 環境

| **3D LiDARポイントクラウドの可視化**                             | **倉庫環境モデル**                                   |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| ![3D Point Cloud](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Warehouse Model](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### 車両 & ナビゲーション

| **Gazeboシミュレーション ハーモニック**                                                                                                     | **RViz2**                                                                                                                   |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| ![Screenshot from 2024-09-23 00-13-03.png](https://github.com/user-attachments/assets/1d2b56f7-34c1-4b01-9a85-fb01ceab5bd6) | ![Screenshot from 2024-09-23 00-09-04.png](https://github.com/user-attachments/assets/ba6853fd-4143-4b4d-bbc6-072895e4c75e) |
| ![Screenshot from 2024-09-23 00-12-13.png](https://github.com/user-attachments/assets/477cce7b-995b-471e-a684-4d82bee0fc34) | ![Screenshot from 2024-09-23 00-15-04.png](https://github.com/user-attachments/assets/bf9ad916-14a6-4b62-a799-4169a767e4dd) |
| ![alt text](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/saye.png)                                                                                         | ![alt text](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/rviz_saye.png)                                                                                    |

## TFツリー

![TF Tree](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/frames.png)

---

## スター履歴

<a href="https://www.star-history.com/#alitekes1/ackermann-vehicle-gzsim-ros2&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <img alt="スター履歴チャート" src="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---