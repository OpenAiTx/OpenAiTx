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

> **一条命令。交互式。零烦恼。**  
> 为任何 ROS2 项目生成生产级别的 `Dockerfile` + `docker-compose.yml` + `README.md` — 直接在你的终端或[网页](https://ppswaroopa.github.io/ros2-dockergen/)上操作

---

## 快速安装

### 通过 PyPI（推荐）
```bash
pip install ros2-dockergen
```

### 一行安装程序（Bash）
```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## 特性

- **完整发行版支持**：可选择 **Jazzy**、**Humble** 和 **Kilted** ROS2 发行版。
- **GPU 加速**：如果选择 CUDA 或 TensorRT，自动配置 `nvidia/cuda` 基础镜像和运行时能力。
- **用户选择**：支持创建**非 root 用户**，并自动映射 UID/GID，避免宿主卷权限问题。
- **全面工具链**：可切换常用 ROS2 包（Nav2、MoveIt2、SLAM Toolbox、MoveIt、Gazebo GZ 等）和开发工具（colcon、rosdep、Oh-My-Zsh、SSH、X11）。
- **完整输出**：不仅生成 `Dockerfile`，还生成匹配的 `docker-compose.yml` 和包含说明的工作区专属 `README.md`。
- **网页同步**：与 [Web UI](https://ppswaroopa.github.io/ros2-dockergen/) 共享相同的逻辑引擎。

---

## 使用方法

只需运行：
```bash
ros2-dockergen
```
交互式向导将引导您完成8个步骤以配置您的环境。

### 命令行选项
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## 使用 `act` 进行本地持续集成

要在本地重现主要的 GitHub Actions 工作流，请安装 [`act`](https://nektosact.com/installation/) 并运行：

```bash
./scripts/run_act.sh
```
默认情况下，这会一个接一个地运行 CI 任务，以便本地 Docker 使用保持可控，并且每个任务的输出易于阅读。

如果您想要使用原始的完整工作流 `act` 行为，请运行：


```bash
./scripts/run_act.sh full
```

---

## 📁 项目结构

- `src/ros2_dockergen/`：核心 Python 包（CLI + 逻辑）。
- `src/core.js`：Web 和 Node.js 共享引擎（ESM）。
- `index.html`：炫酷的浏览器交互式生成器。
- `docs/`：视觉资源和项目文档。
- `tests/`：一致性验证套件（确保 Python/JS 输出字节完全相同）。

---

## 🔗 相关资源

- [网页工具](https://ppswaroopa.github.io/ros2-dockergen/)
- [官方 ROS 文档](https://docs.ros.org)
- [OSRF ROS Docker Hub](https://hub.docker.com/r/osrf/ros)

---

## 许可证

根据 [MIT 许可证](LICENSE) 发行。
版权所有 © 2026 Pranava Swaroopa。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-18

---