# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="AstroViz Image" width="800" height="500">

[![License](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![ROS2 Version](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroViz는 ROS 2 로봇 미션을 위한 궁극의 실시간 데이터 시각화 도구입니다. 유연성, 명확성, 성능을 위해 처음부터 설계된 AstroViz는 로봇공학자, 엔지니어, 현장 운영자에게 복잡한 시스템을 실시간으로 모니터링, 제어 및 디버깅할 수 있는 통합 인터페이스를 제공합니다.

- 🌍 올인원 시각화: GPS, LiDAR, 카메라 피드, 로봇 상태, 모터 상태 등 여러 뷰를 하나의 현대적인 GUI로 통합합니다.
- ⚡ 고성능: GPU 지원이 포함된 Docker 기반 배포로 데이터 집약적인 환경에서도 원활한 작동을 보장합니다.
- 🛰️ 현장 검증 완료: 자율주행 차량, 드론, 지상 로봇 등 어떤 경우에도 AstroViz는 시각적 지휘 센터입니다.

💡 원시 데이터 이상의 기능을 제공하며 현장에서 실시간 의사결정을 돕는 ROS 2 도구를 찾고 계신가요?
<b>AstroViz가 그 해답입니다.</b>

## 시각적 개요
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>대시보드 뷰어</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Teleoperation Overview" width="800">
    </td>
  </tr>
</table>

구현된 모든 창의 자세한 뷰는 다음을 참조하세요: [구현된 창들](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## 목차
1. [시작하기](#get-started)
   - [필수 조건](#prerequisites)
   - [설치](#installation)
      - [저장소 클론](#clone-the-repository)
      - [Docker로 빌드하기](#build-using-docker)
      - [Docker 컨테이너 실행하기](#run-the-docker-container)
2. [사용법](#usage)
   - [노드 개요](#node-overview)
   - [노드 실행](#running-nodes)
3. [유지관리자](#maintainer)
3. [라이선스](#license)

---

## 시작하기
### 사전 요구 사항

이 패키지를 실행하려면 다음 종속 항목이 설치되어 있어야 합니다:
- **Git**: 버전 관리 및 저장소 관리를 위해.
- **Docker**: 환경 설정 및 실행을 간소화하기 위해.
- **NVIDIA 컨테이너 툴킷** (NVIDIA GPU를 사용하는 경우): 하드웨어 가속을 위해.


### 설치

#### 저장소 복제
저장소를 복제하는 것부터 시작하세요:
```bash
git clone git@github.com:hucebot/astroviz.git
```
#### Docker를 사용한 빌드
이 저장소에는 손쉬운 배포를 위한 사전 구성된 Docker 설정이 포함되어 있습니다. Docker 이미지를 빌드하려면:
1. `docker` 디렉터리로 이동하십시오:

   ```bash
   cd astroviz/docker
   ```
2. 빌드 스크립트를 실행합니다:
   ```bash
   sh build.sh
   ```
   이것은 `astroviz`라는 이름의 도커 이미지를 생성합니다.

#### 도커 컨테이너 실행
빌드가 완료되면 다음 명령어로 컨테이너를 실행합니다:
```bash
sh run.sh
```
---

## 사용법
### 노드 개요

이 패키지는 원격 조작 및 데이터 시각화를 용이하게 하기 위해 설계된 노드들로 구성되어 있습니다. 각 노드는 원격 조작 워크플로우에서 특정한 목적을 수행합니다:
- **gpsmap_viewer**: 지도 위에 GPS 데이터를 시각화합니다.
- **camera_viewer**: 로봇의 카메라 영상을 표시합니다.
- **imu_viewer**: IMU 데이터를 시각화합니다.
- **lidar_viewer**: LiDAR 데이터를 시각화합니다.
- **teleoperation_viewer**: 원격 조작 제어를 위한 GUI를 제공합니다.
- **dashboard_viewer**: 다양한 데이터 스트림을 통합하고 모니터링 및 제어를 위한 통합 인터페이스를 제공하는 종합 대시보드입니다.
- **plot_viewer**: 다양한 데이터 스트림의 실시간 플롯을 표시합니다.
- **grid_map_viewer**: 내비게이션 및 계획을 위한 그리드 맵 데이터를 시각화합니다.
- **robot_state_viewer**: 조인트 위치 및 변환과 관련된 로봇의 현재 상태를 표시합니다.
- **motor_state_viewer**: 온도 및 전압 측정을 포함한 로봇 모터의 상태를 모니터링하고 시각화합니다.
- **record_manager_viewer**: 녹화 세션을 관리하고 시각화하며, 사용자가 녹화를 시작, 중지 및 검토할 수 있게 합니다.

### 노드 실행
노드를 실행하려면 다음 명령어를 사용할 수 있습니다:
```bash
ros2 run astroviz <node_name>
```
실행하려는 노드 이름을 `gps_map_viewer`, `camera_viewer` 등으로 `<node_name>` 대신 입력하세요.

또는 모든 기능이 통합된 대시보드 뷰어를 실행하려면 다음을 사용하세요:
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```
## 유지 관리자
이 패키지는 다음에 의해 유지 관리됩니다:

**Clemente Donoso**  
이메일: [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)  
GitHub: [CDonosoK](https://github.com/CDonosoK)  

---

## 라이선스
이 프로젝트는 **MIT** 라이선스 하에 배포됩니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하십시오.

---
기여와 피드백을 환영합니다! 문제가 발생하거나 개선 사항에 대한 제안이 있으면 언제든지 이슈를 열거나 풀 리퀘스트를 제출해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---