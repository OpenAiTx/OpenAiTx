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
    <em>Roombaシリーズのロボット掃除機向けにRust言語とgRPCを用いて開発されたオープンソースの自律ソフトウェア</em>
</p>

<p align="center">
  <img src="https://github.com/Sollimann/CleanIt/blob/main/resources/gifs/roomba.gif">
</p>

## Motivation

動機は、リアルタイムのクライアント・サーバー間通信ストリームを非同期gRPCで実現し、分散コンピューティングを用いながら、完全なDIY自律ソフトウェア（モーションプランニング、誘導およびモーション制御、SLAM、ミッションコントロール、2D/3D可視化など）を一から構築することです。

SLAM部分は現在進行中で、こちらにあります：https://github.com/Sollimann/Occupancy-Grid-FastSLAM/tree/main

## Contributions are welcome!

作業やアイデアで貢献したい方は、ぜひ[プロジェクトバックログ](https://github.com/Sollimann/CleanIt/projects)をご覧ください。

## Run the Roomba client and API

#### Run the server

```
$ cargo run --bin streaming-server
```

#### クライアントを実行する

```
$ cargo run --bin roomba-client
```

## 構造
 
#### プロジェクトレイアウト
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
 
#### クレート／パッケージのレイアウト
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

## 前提条件

### *ソフトウェア*

#### _Linux_
```bash
$ [sudo] apt-get install libudev-dev pkg-config
```
シリアル接続でCreateに接続するには、ユーザーのシリアル権限が必要です。権限を得るには、ユーザーをdialoutグループに追加してください：


```bash
$ [sudo] usermod -a -G dialout $USER
```

効果を反映させるには、ログアウトして再度ログインしてください。
##### _MacOs_
```bash
$ brew install *TODO*
```

### *ハードウェア*
 - iRobot Create 2（またはシリアルUSBケーブル付きのiRobot Roomba 6xxシリーズ - https://store.irobot.com/en_US/parts-and-accessories/create-accessories/communication-cable-for-create-2/4466502.html ）
 - Raspberry Pi 4（4GB）
 - Intel RealSense D435 または D435i 深度カメラ
 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---