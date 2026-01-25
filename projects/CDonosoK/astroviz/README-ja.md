# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="AstroViz Image" width="800" height="500">

[![License](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![ROS2 Version](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroVizはROS 2ロボットミッションのための究極のリアルタイムデータ可視化スイートです。柔軟性、明快さ、性能を念頭にゼロから構築されており、ロボティスト、エンジニア、現場オペレーターに複雑なシステムをリアルタイムで監視、制御、デバッグするための統一インターフェースを提供します。

- 🌍 オールインワン可視化：GPSやLiDARからカメラ映像、ロボット状態、モーターの健康状態まで、AstroVizは複数のビューを統合し、一体的でモダンなGUIを実現します。
- ⚡ 高性能：GPUサポート付きのDockerベース展開により、データ集約型環境でもスムーズな動作を保証します。
- 🛰️ フィールド実証済み：自律走行車、ドローン、地上ロボットのいずれであっても、AstroVizはあなたのビジュアル指令センターです。

💡 生データを超えたROS 2ツールを探していて、現場でのリアルタイム意思決定を支援したいですか？
<b>AstroVizはまさにそれのために作られています。</b>

## ビジュアル概要
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>ダッシュボードビューアー</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Teleoperation Overview" width="800">
    </td>
  </tr>
</table>

実装済み全ウィンドウの詳細については、こちらをご覧ください：[実装済みウィンドウ](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## 目次
1. [はじめに](#get-started)
   - [前提条件](#prerequisites)
   - [インストール](#installation)
      - [リポジトリのクローン](#clone-the-repository)
      - [Dockerを使ったビルド](#build-using-docker)
      - [Dockerコンテナの実行](#run-the-docker-container)
2. [使い方](#usage)
   - [ノード概要](#node-overview)
   - [ノードの実行](#running-nodes)
3. [メンテナ](#maintainer)
3. [ライセンス](#license)

---

## はじめに
### 前提条件

このパッケージを実行するには、以下の依存関係がインストールされていることを確認してください:
- **Git**: バージョン管理とリポジトリ管理のため。
- **Docker**: 環境設定と実行の簡素化のため。
- **NVIDIA Container Toolkit**（NVIDIA GPUを使用する場合）: ハードウェアアクセラレーションのため。


### インストール

#### リポジトリのクローン
まずリポジトリをクローンします:
```bash
git clone git@github.com:hucebot/astroviz.git
```

#### Dockerを使用したビルド
このリポジトリには簡単にデプロイできるように事前設定されたDocker環境が含まれています。Dockerイメージをビルドするには：
1. `docker`ディレクトリに移動します：
   ```bash
   cd astroviz/docker
   ```
2. ビルドスクリプトを実行します:
   ```bash
   sh build.sh
   ```
   これにより、`astroviz`という名前のDockerイメージが作成されます。

#### Dockerコンテナの実行
ビルドが完了したら、次のコマンドでコンテナを起動します：
```bash
sh run.sh
```
---

## 使用方法
### ノード概要

このパッケージはテレオペレーションとデータの可視化を容易にするために設計されたノード群です。各ノードはテレオペレーションのワークフローにおいて特定の役割を果たします：
- **gpsmap_viewer**：地図上にGPSデータを可視化します。
- **camera_viewer**：ロボットのカメラ映像を表示します。
- **imu_viewer**：IMUデータを可視化します。
- **lidar_viewer**：LiDARデータを可視化します。
- **teleoperation_viewer**：テレオペレーション制御用のGUIを提供します。
- **dashboard_viewer**：様々なデータストリームを統合し、監視および制御のための統一インターフェースを提供する包括的なダッシュボードです。
- **plot_viewer**：様々なデータストリームのリアルタイムプロットを表示します。
- **grid_map_viewer**：ナビゲーションおよびプランニング用のグリッドマップデータを可視化します。
- **robot_state_viewer**：関節位置や変換に関連するロボットの現在の状態を表示します。
- **motor_state_viewer**：ロボットのモーター状態（温度や電圧の読み取り値を含む）を監視および可視化します。
- **record_manager_viewer**：録画セッションを管理および可視化し、ユーザーが録画の開始、停止、レビューを行えるようにします。

### ノードの起動
ノードを起動するには、以下のコマンドを使用してください：
```bash
ros2 run astroviz <node_name>
```
実行したいノードの名前（例えば、`gps_map_viewer`、`camera_viewer`など）に`<node_name>`を置き換えてください。

または、すべての機能を統合したダッシュボードビューアを実行したい場合は：
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```

## メンテナ
このパッケージは以下の者によって管理されています：

**クレメンテ・ドノソ**  
メール: [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)  
GitHub: [CDonosoK](https://github.com/CDonosoK)  

---

## ライセンス
このプロジェクトは**MIT**ライセンスのもとで公開されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

---
ご意見やご提案を歓迎します！問題が発生した場合や改善案がある場合は、気軽にissueを開くかプルリクエストを送ってください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---