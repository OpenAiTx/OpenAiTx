# 🤖 ros2-dockergen

<p align="center">
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/ci.yml/badge.svg" alt="CI"></a>
  <a href="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml"><img src="https://github.com/ppswaroopa/ros2-dockergen/actions/workflows/publish.yml/badge.svg" alt="Publish to PyPI"></a>
  <a href="https://pypi.org/project/ros2-dockergen/"><img src="https://img.shields.io/pypi/v/ros2-dockergen.svg" alt="PyPI version"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.python.org/downloads/"><img src="https://img.shields.io/badge/python-3.10+-blue.svg" alt="Python 3.10+"></a>
  <a href="https://ppswaroopa.github.io/ros2-dockergen/"><img src="https://img.shields.io/badge/Web-Interactive_UI-00ff88.svg" alt="Web UI"></a>
</p>

<br />
<p align="center">
  <img src="https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/docs/hero.png" alt="ROS2 DockerGen Flow" width="100%">
</p>
<br />

> **한 번의 명령. 인터랙티브. 번거로움 제로.**  
> 모든 ROS2 프로젝트에 대해 프로덕션 준비가 된 `Dockerfile` + `docker-compose.yml` + `README.md`를 터미널에서 직접 또는 [웹페이지](https://ppswaroopa.github.io/ros2-dockergen/)에서 생성하세요.

---

## 빠른 설치

### PyPI에서 (권장)
```bash
pip install ros2-dockergen
```

### 원라인 설치 프로그램 (Bash)
```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## 기능

- **전체 배포 지원**: **Jazzy**, **Humble**, 그리고 **Kilted** ROS2 배포판 중 선택 가능.
- **GPU 가속**: CUDA 또는 TensorRT를 선택하면 `nvidia/cuda` 베이스 이미지와 런타임 기능을 자동으로 구성.
- **사용자 선택**: 호스트 볼륨 권한 문제를 방지하기 위해 자동 UID/GID 매핑과 함께 **비루트 사용자** 생성 처리.
- **종합 도구**: 일반적인 ROS2 패키지(Nav2, MoveIt2, SLAM Toolbox, MoveIt, Gazebo GZ 등) 및 개발 도구(colcon, rosdep, Oh-My-Zsh, SSH, X11)를 토글 가능.
- **완벽한 출력**: `Dockerfile`뿐만 아니라 일치하는 `docker-compose.yml`과 워크스페이스 전용 `README.md`를 함께 생성.
- **웹 동등성**: [웹 UI](https://ppswaroopa.github.io/ros2-dockergen/)와 동일한 로직 엔진 공유.

---

## 사용법

간단히 실행:
```bash
ros2-dockergen
```
인터랙티브 마법사가 환경 구성을 위해 8단계를 안내합니다.

### 명령줄 옵션
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## `act`를 사용한 로컬 CI

주요 GitHub Actions 워크플로우를 로컬에서 재현하려면, [`act`](https://nektosact.com/installation/)를 설치하고 다음을 실행하세요:

```bash
./scripts/run_act.sh
```
기본적으로 이는 CI 작업을 순차적으로 실행하여 로컬 Docker 사용량을 관리 가능하게 유지하고 각 작업의 출력을 읽기 쉽게 만듭니다.

원본 전체 워크플로우 `act` 동작을 원한다면, 다음을 실행하세요:


```bash
./scripts/run_act.sh full
```

---

## 📁 프로젝트 구조

- `src/ros2_dockergen/`: 핵심 파이썬 패키지 (CLI + 로직).
- `src/core.js`: 웹 및 Node.js용 공유 엔진 (ESM).
- `index.html`: 멋진 브라우저 기반 인터랙티브 생성기.
- `docs/`: 시각 자료 및 프로젝트 문서.
- `tests/`: 동등성 검증 스위트 (파이썬/JS 출력이 바이트 단위로 동일한지 확인).

---

## 🔗 관련 자료

- [웹 유틸리티](https://ppswaroopa.github.io/ros2-dockergen/)
- [공식 ROS 문서](https://docs.ros.org)
- [OSRF ROS Docker 허브](https://hub.docker.com/r/osrf/ros)

---

## 라이선스

[MIT 라이선스](LICENSE) 하에 공개됨.
저작권 © 2026 Pranava Swaroopa.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---