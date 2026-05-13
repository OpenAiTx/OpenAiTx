# ROS2와 Gazebo Sim Harmonic을 이용한 아커만 조향 차량 시뮬레이션

이 프로젝트는 **아커만 조향 기능**을 갖춘 맞춤형 차량의 시뮬레이션을 특징으로 하며, **ROS2**와 **Gazebo Sim Harmonic 환경**을 사용하여 개발되었습니다. 이 모델은 자율 운행을 위한 다양한 센서와 내비게이션 도구를 통합하여, 이 시뮬레이션 프레임워크에서 아커만 조향 차량을 구현한 최초 사례 중 하나입니다.

| **3D 라이다 포인트 클라우드 시각화** | **창고 환경 모델** |
| ----- | ----- |
| ![3D Point Cloud](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![Warehouse Model](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### 이 프로젝트가 마음에 드신다면, 응원의 표시로 ⭐를 눌러주세요!

## 목차

- [ROS2와 Gazebo Sim Harmonic을 이용한 아커만 조향 차량 시뮬레이션](#ros2와-gazebo-sim-harmonic을-이용한-아커만-조향-차량-시뮬레이션)
- [특징](#특징)
  - [1 아커만 조향](#1-아커만-조향)
  - [2 ROS2 통신](#2-ros2-통신)
  - [3 센서](#3-센서)
  - [4 내비게이션](#4-내비게이션)
  - [5 외부 조이스틱을 이용한 수동 제어](#5-외부-조이스틱을-이용한-수동-제어)
  - [6 시각화](#6-시각화)
- [필수 조건](#필수-조건)
- [로컬 설치](#로컬-설치)
- [도커 설치](#도커-설치)
- [사용법](#사용법)
  - [1 기본 시뮬레이션 및 수동 제어](#1-기본-시뮬레이션-및-수동-제어)
  - [2 SLAM 동시 위치추정 및 지도작성](#2-slam-동시-위치추정-및-지도작성)
  - [3 Nav2를 이용한 내비게이션](#3-nav2를-이용한-내비게이션)
- [향후 작업](#향후-작업)
- [갤러리](#갤러리)
- [TF 트리](#tf-트리)
- [별 기록](#별-기록)

## 특징

### 1. **아커만 조향**

- 정확한 조향성을 위한 현실적인 아커만 조향 역학을 적용한 맞춤형 차량 모델입니다.

### 2. **ROS2 통신**

- 모든 센서 데이터 및 제어 신호는 원활한 상호 운용성을 위해 ROS2 생태계에 완전히 통합되어 있습니다.

### 3. **센서**

- **IMU**: 방향과 각속도를 제공합니다.
- **오도메트리**: 정확한 차량 상태 피드백을 보장합니다.
- **LiDAR**: 장애물 감지 및 환경 스캔을 위해 장착되어 있습니다. 고급 인식 작업을 위한 3D 포인트 클라우드 생성을 지원합니다.
- **카메라**:
  - 전방
  - 후방
  - 좌측
  - 우측
  > **참고:** 기본적으로 전방 카메라만 ROS 2에 브리지됩니다. 모든 카메라(좌측, 우측, 후방)를 ROS 2에서 사용하려면 `saye_bringup/config/ros_gz_bridge.yaml` 파일 내 관련 카메라 섹션 앞의 `#`를 제거하여 활성화하세요 (예: `/camera/left_raw`, `/camera/right_raw`, `/camera/rear_raw`).

### 4. **내비게이션**

- **Nav2 스택**과 통합되어 자율 내비게이션을 지원합니다.
- 향상된 위치 정확도를 위한 **AMCL(Adaptive Monte Carlo Localization)** 사용.
- 실시간 맵핑과 환경 인식을 위한 **SLAM** 기술 구현.
- 최적화된 내비게이션 성능을 위한 세밀한 파라미터 조정.

### 5. **수동 제어 (외부 조이스틱 사용)**

- 시뮬레이션 환경에서 조이스틱 기반 수동 제어를 지원하여 사용자가 차량 움직임을 인터랙티브하게 테스트할 수 있습니다.

### 6. **시각화**

- **RViz2**에서 전체 모델 및 센서 데이터 시각화를 제공하여 로봇 상태 및 환경 피드백에 대한 인사이트를 제공합니다.

## 요구 사항

- **ROS2 (Humble)**
- **Gazebo Sim Harmonic**
- **RViz2**
- **Nav2**

## 로컬 설치

0. Gazebo Harmonic 및 ROS (ros_gz) 설치가 되어 있는지 확인하세요:<br>
   `sudo apt-get install ros-${ROS_DISTRO}-ros-gz`<br>
   `sudo apt-get install ros-humble-ros-gzharmonic` (휴믈 버전만 해당)<br>
   Gazebo와 ROS 설치에 대한 자세한 내용: <a href="https://gazebosim.org/docs/latest/ros_installation/">링크</a>
1. 저장소 복제:<br>
   `mkdir -p ackermann_sim/src && cd ackermann_sim/src`<br>
   `git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2`<br>`cd ..`
2. 프로젝트 빌드:
   `colcon build && source install/setup.bash`
3. 환경 변수 설정:
   ```bash
   # Set environment variables for current session
   export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/
   ```

   **영구 설정을 위해:**
   
   이러한 환경 변수를 영구적으로 설정하려면, `.bashrc` 파일에 추가하세요:
   ```bash
   # Add environment variables to .bashrc
   echo 'export GZ_SIM_RESOURCE_PATH=$GZ_SIM_RESOURCE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   echo 'export ROS_PACKAGE_PATH=$ROS_PACKAGE_PATH:/your/path/ackermann_sim/src/ackermann-vehicle-gzsim-ros2/' >> ~/.bashrc
   
   # Apply changes
   source ~/.bashrc
   ```
   > **참고:** `/your/path/`를 실제 설치 경로로 교체하세요.

## Docker 설치

Docker를 사용하여 시뮬레이션을 실행할 수도 있으며, 이는 다양한 시스템에서 일관된 환경을 보장합니다.

### 사전 요구 사항
- Docker
- NVIDIA 컨테이너 툴킷 (GPU 지원용)

### Docker로 실행하는 단계

1. 저장소를 클론합니다:

   ```bash
   mkdir -p ackermann_sim/src && cd ackermann_sim/src
   git clone https://github.com/alitekes1/ackermann-vehicle-gzsim-ros2
   cd ackermann-vehicle-gzsim-ros2
   ```
2. Docker 컨테이너 빌드 및 실행:

   ```bash
      docker run -it \
      --name ackermann_sim \
      --hostname ackermann_sim \
      --env="DISPLAY=$DISPLAY" \
      --env="QT_X11_NO_MITSHM=1" \
      --volume="/tmp/.X11-unix:/tmp/.X11-unix:rw" \
      --privileged alitekes1/ackermann_sim:latest
   ```
3. 동일한 컨테이너에 추가 터미널을 원할 경우

   ```bash
      docker exec -it ackermann_sim bash
   ```
   
> **참고:** 컨테이너 내부에서는 시뮬레이션 명령어를 정상적으로 실행할 수 있습니다.

## 사용법

### 1. 기본 시뮬레이션 및 수동 제어

1.  시뮬레이션 시작:

    ```bash
    ros2 launch saye_bringup saye_spawn.launch.py
    ```
2.  제어차:
    ```bash
    ros2 run teleop_twist_keyboard teleop_twist_keyboard
    ```

### 2. SLAM (동시 위치 추정 및 지도 작성)

-   매핑을 위해 SLAM Toolbox를 실행하려면 시뮬레이션을 시작한 후 다음을 실행합니다:
    ```bash
    ros2 launch saye_bringup slam.launch.py
    ```
    [![SLAM- Youtube](https://img.youtube.com/vi/QWcJ9TlqFOU/0.jpg)](https://www.youtube.com/watch?v=QWcJ9TlqFOU "프로젝트 소개")

### 3. Nav2를 이용한 내비게이션

-   Nav2 스택을 사용하여 자율 내비게이션 시뮬레이션을 실행하려면, 시뮬레이션 시작 후 다음 명령을 실행하세요:
    ```bash
    ros2 launch saye_bringup navigation_bringup.launch.py
    ```
    [![자율 주행 네비게이션 - 유튜브](https://img.youtube.com/vi/SJ4NrbdlNZo/0.jpg)](https://www.youtube.com/watch?v=SJ4NrbdlNZo "NAV2")

> **참고:** 위 유튜브 동영상은 4배속으로 재생됩니다. 이미지를 클릭하여 동영상에 접근할 수 있습니다.

## 향후 작업

1. **3D SLAM 지원:**
   - 고급 DRL 알고리즘을 사용하여 차량이 복잡한 시나리오를 자율적으로 처리하도록 학습합니다.
2. **향상된 기능:**
   - 추가 센서 구성 및 내비게이션 전략을 탐색합니다.
3. **3D 위치 추적과 Nav2 통합**
   - AMCL(2D) 대신 더 정확하고 견고한 알고리즘 구현.
## 갤러리

![2024-09-23 00-09-48 스크린샷.png](https://github.com/user-attachments/assets/dd5604c6-014e-4a7a-9a2f-c4dd237abb37)

### 3D LiDAR 포인트 클라우드 & 환경

| **3D LiDAR 포인트 클라우드 시각화**                               | **창고 환경 모델**                                              |
| ----------------------------------------------------------------- | --------------------------------------------------------------- |
| ![3D 포인트 클라우드](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/3d_lidar_pointcloud.png) | ![창고 모델](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/warehouse_environment.png) |

### 차량 및 내비게이션

| **Gazebo 시뮬레이터 하모닉**                                                                                                | **RViz2**                                                                                                                    |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| ![2024-09-23 00-13-03 스크린샷.png](https://github.com/user-attachments/assets/1d2b56f7-34c1-4b01-9a85-fb01ceab5bd6) | ![2024-09-23 00-09-04 스크린샷.png](https://github.com/user-attachments/assets/ba6853fd-4143-4b4d-bbc6-072895e4c75e) |
| ![2024-09-23 00-12-13 스크린샷.png](https://github.com/user-attachments/assets/477cce7b-995b-471e-a684-4d82bee0fc34) | ![2024-09-23 00-15-04 스크린샷.png](https://github.com/user-attachments/assets/bf9ad916-14a6-4b62-a799-4169a767e4dd) |
| ![alt 텍스트](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/saye.png)                                                                                        | ![alt 텍스트](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/rviz_saye.png)                                                                                       |

## TF 트리

![TF 트리](https://raw.githubusercontent.com/alitekes1/ackermann-vehicle-gzsim-ros2/main/saye_msgs/readme_files/frames.png)

---

## 스타 이력

<a href="https://www.star-history.com/#alitekes1/ackermann-vehicle-gzsim-ros2&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
   <img alt="별 히스토리 차트" src="https://api.star-history.com/svg?repos=alitekes1/ackermann-vehicle-gzsim-ros2&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---