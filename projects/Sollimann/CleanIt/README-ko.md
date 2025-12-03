<h1 align="center">CleanIt</h1>

[![Build Status](https://github.com/Sollimann/CleanIt/actions/workflows/rust-ci.yml/badge.svg)](https://github.com/Sollimann/CleanIt/actions)
[![codecov](https://codecov.io/gh/Sollimann/CleanIt/branch/main/graph/badge.svg?token=EY3JRZN71M)](https://codecov.io/gh/Sollimann/CleanIt)
[![minimum rustc 1.45](https://img.shields.io/badge/rustc-1.45+-blue.svg)](https://rust-lang.github.io/rfcs/2495-min-rust-version.html)
[![version](https://img.shields.io/badge/version-1.0.0-blue)](https://GitHub.com/Sollimann/CleanIt/releases/)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Sollimann/CleanIt/graphs/commit-activity)
[![GitHub pull-requests](https://img.shields.io/github/issues-pr/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
[![GitHub pull-requests closed](https://img.shields.io/github/issues-pr-closed/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
![ViewCount](https://views.whatilearened.today/views/github/Sollimann/CleanIt.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

<p align="center">
    <em>Roomba 시리즈 로봇 청소기를 위한 Rust-lang 기반 gRPC 오픈소스 자율주행 소프트웨어</em>
</p>

<p align="center">
  <img src="https://github.com/Sollimann/CleanIt/blob/main/resources/gifs/roomba.gif">
</p>

## 동기

동기는 실시간 클라이언트-서버 통신 스트림을 위한 비동기 gRPC를 사용하여 상호 통신과 분산 계산을 지원하는 완전한 DIY 자율주행 소프트웨어(모션 플래닝, 안내 및 모션 제어, SLAM, 미션 제어, 2D/3D 시각화 등)를 처음부터 구축하는 것입니다.

SLAM 부분은 다음에서 진행 중입니다: https://github.com/Sollimann/Occupancy-Grid-FastSLAM/tree/main

## 기여를 환영합니다!

작업 및/또는 아이디어로 기여하고 싶다면 [프로젝트 백로그](https://github.com/Sollimann/CleanIt/projects)를 확인해 주세요.

## Roomba 클라이언트 및 API 실행하기

#### 서버 실행하기

```
$ cargo run --bin streaming-server
```

#### 클라이언트 실행

```
$ cargo run --bin roomba-client
```

## 구조
 
#### 프로젝트 레이아웃
 ```bash
 ├── Cargo.toml (workspace)
 ├── Cargo.lock
 ├── api (lib/bin)
 |   └── client
 |   └── server
 ├── autonomy (bin)
 |   └── mission
 |   └── motion
 |   └── slam
 |   └── perception
 |   └── risk
 ├── drivers (lib)
 |   └── roomba
 |   └── realsense
 |   └── rplidar
 |   └── raspberryPi
 └── proto (lib)
 |   └── roomba_service.proto
 |   └── messages.proto
 |   └── types.proto
 |   └── robot_state.proto
 |   └── map2D.proto
 ├── setup (bin)
 |   └── config
 |   └── main
 └── visualization (bin)
 |   └── urdf
 |   └── map
 |   └── camera
 ```
 
#### 크레이트/패키지 레이아웃
```bash
├── Cargo.toml
├── Cargo.lock
├── src
│   ├── main.rs
│   ├── lib.rs
│   └── bin
│       └── another_executable.rs
├── tests
│   └── some_integration_tests.rs
├── benches
│   └── simple_bench.rs
└── examples
    └── simple_example.rs
```
## 전제 조건

### *소프트웨어*

#### _리눅스_

```bash
$ [sudo] apt-get install libudev-dev pkg-config
```
시리얼을 통해 Create에 연결하려면 사용자 시리얼 권한이 필요합니다. 권한을 얻으려면 사용자를 dialout 그룹에 추가할 수 있습니다:


```bash
$ [sudo] usermod -a -G dialout $USER
```

이 변경 사항을 적용하려면 로그아웃한 후 다시 로그인하세요.
##### _MacOs_
```bash
$ brew install *TODO*
```
### *하드웨어*
 - iRobot Create 2 (또는 시리얼 USB 케이블이 있는 iRobot Roomba 6xx 시리즈 - https://store.irobot.com/en_US/parts-and-accessories/create-accessories/communication-cable-for-create-2/4466502.html )
 - Raspberry Pi 4 (4GB)
 - Intel RealSense D435 또는 D435i 깊이 카메라
 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---