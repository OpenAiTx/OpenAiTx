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
    <em>基于Rust语言，采用gRPC的Roomba系列机器人吸尘器开源自主软件</em>
</p>

<p align="center">
  <img src="https://github.com/Sollimann/CleanIt/blob/main/resources/gifs/roomba.gif">
</p>

## 动机

动机是从头构建一个完整的DIY自主软件（运动规划、导航与运动控制、SLAM、任务控制、2D/3D可视化等），并使用异步gRPC实现实时客户端-服务器通信流，用于互联和分布式计算。

SLAM部分正在开发中，地址：https://github.com/Sollimann/Occupancy-Grid-FastSLAM/tree/main

## 欢迎贡献！

如果您愿意贡献代码和/或想法，欢迎查看[项目待办事项](https://github.com/Sollimann/CleanIt/projects)

## 运行Roomba客户端和API

#### 运行服务器

```
$ cargo run --bin streaming-server
```

#### 运行客户端

```
$ cargo run --bin roomba-client
```

## 结构
 
#### 项目布局
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
 
#### 箱子/包布局
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

## 先决条件

### *软件*

#### _Linux_
```bash
$ [sudo] apt-get install libudev-dev pkg-config
```

连接到 Create 串口时需要用户串口权限。您可以将用户添加到 dialout 组以获取权限：

```bash
$ [sudo] usermod -a -G dialout $USER
```

退出并重新登录以使更改生效。
##### _MacOs_
```bash
$ brew install *TODO*
```

### *硬件*
 - iRobot Create 2（或带有串行USB线的iRobot Roomba 6xx系列 - https://store.irobot.com/en_US/parts-and-accessories/create-accessories/communication-cable-for-create-2/4466502.html）
 - Raspberry Pi 4（4GB）
 - Intel RealSense D435 或 D435i 深度相机
 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---