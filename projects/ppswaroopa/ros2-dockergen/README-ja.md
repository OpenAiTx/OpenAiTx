# 🤖 ros2-dckergen

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

> **ワンコマンド。インタラクティブ。手間なし。**  
> どんなROS2プロジェクトでも、ターミナルから、または[ウェブページ](https://ppswaroopa.github.io/ros2-dockergen/)で、プロダクション対応の `Dockerfile` + `docker-compose.yml` + `README.md` を生成します。

---

## クイックインストール

### PyPIから（推奨）
```bash
pip install ros2-dockergen
```

### ワンラインインストーラー（Bash）
```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## 特徴

- **完全なディストリビューションサポート**：**Jazzy**、**Humble**、**Kilted** のROS2ディストリビューションから選択可能。
- **GPUアクセラレーション**：CUDAまたはTensorRTが選択された場合、自動的に`nvidia/cuda`ベースイメージとランタイム機能を設定。
- **ユーザー選択**：ホストボリュームの権限問題を防ぐため、自動UID/GIDマッピング付きの**非rootユーザー**作成を処理。
- **包括的ツール群**：一般的なROS2パッケージ（Nav2、MoveIt2、SLAM Toolbox、MoveIt、Gazebo GZなど）および開発ツール（colcon、rosdep、Oh-My-Zsh、SSH、X11）を切り替え可能。
- **完全な出力**：`Dockerfile`だけでなく、対応する`docker-compose.yml`とワークスペース固有の使用説明書`README.md`も生成。
- **Webとの整合性**：[Web UI](https://ppswaroopa.github.io/ros2-dockergen/)と共有される同一のロジックエンジン。

---

## 使い方

単に実行してください：
```bash
ros2-dockergen
```
インタラクティブウィザードが環境設定のための8つのステップを案内します。

### コマンドラインオプション
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## `act` を使ったローカルCI

メインのGitHub Actionsワークフローをローカルで再現するには、[`act`](https://nektosact.com/installation/) をインストールして次を実行します:

```bash
./scripts/run_act.sh
```
デフォルトでは、CIジョブを1つずつ実行するため、ローカルのDocker使用量が管理しやすくなり、各ジョブの出力も読みやすくなります。

元のフルワークフローの `act` 動作を希望する場合は、以下を実行してください：


```bash
./scripts/run_act.sh full
```

---

## 📁 プロジェクト構成

- `src/ros2_dockergen/`: コアPythonパッケージ（CLI＋ロジック）。
- `src/core.js`: WebおよびNode.js向け共有エンジン（ESM）。
- `index.html`: 洗練されたブラウザベースのインタラクティブジェネレーター。
- `docs/`: ビジュアルアセットおよびプロジェクトドキュメント。
- `tests/`: パリティ検証スイート（Python/JS出力がバイト単位で同一であることを保証）。

---

## 🔗 関連リソース

- [Webユーティリティ](https://ppswaroopa.github.io/ros2-dockergen/)
- [公式ROSドキュメント](https://docs.ros.org)
- [OSRF ROS Docker Hub](https://hub.docker.com/r/osrf/ros)

---

## ライセンス

[MITライセンス](LICENSE)の下でリリース。
Copyright © 2026 プラナヴァ・スワルーパ。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---