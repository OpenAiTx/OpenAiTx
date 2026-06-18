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

> **One command. Interactive. Zero fuss.**  
> Generate production-ready `Dockerfile` + `docker-compose.yml` + `README.md` for any ROS2 project — straight from your terminal or on the [webpage](https://ppswaroopa.github.io/ros2-dockergen/) here

---

## Quick Install

### From PyPI (Recommended)
```bash
pip install ros2-dockergen
```

### One-line installer (Bash)
```bash
curl -fsSL https://raw.githubusercontent.com/ppswaroopa/ros2-dockergen/main/install.sh | bash
```

---

## Features

- **Full Distribution Support**: Choose between **Jazzy**, **Humble**, and **Kilted** ROS2 distros.
- **GPU Acceleration**: Automatically configures `nvidia/cuda` base images and runtime capabilities if CUDA or TensorRT is selected.
- **User Choice**: Handles **non-root user** creation with automatic UID/GID mapping to prevent host volume permission headaches.
- **Comprehensive Tooling**: Toggle common ROS2 packages (Nav2, MoveIt2, SLAM Toolbox, MoveIt, Gazebo GZ, etc.) and dev tools (colcon, rosdep, Oh-My-Zsh, SSH, X11).
- **Complete Output**: Generates not just a `Dockerfile`, but also a matching `docker-compose.yml` and a workspace-specific `README.md` with instructions.
- **Web Parity**: Identical logic engine shared with the [Web UI](https://ppswaroopa.github.io/ros2-dockergen/).

---

## Usage

Simply run:
```bash
ros2-dockergen
```
The interactive wizard will walk you through 8 steps to configure your environment.

### Command Line Options
```bash
ros2-dockergen --help    # Show help
ros2-dockergen --version # Show version
```
---

## Local CI With `act`

To reproduce the main GitHub Actions workflow locally, install [`act`](https://nektosact.com/installation/) and run:

```bash
./scripts/run_act.sh
```

By default this runs the CI jobs one-by-one so local Docker usage stays manageable and each job's output is easy to read.

If you want the original full-workflow `act` behavior instead, run:

```bash
./scripts/run_act.sh full
```

---

## 📁 Project Structure

- `src/ros2_dockergen/`: Core Python package (CLI + Logic).
- `src/core.js`: Shared engine (ESM) for Web and Node.js.
- `index.html`: Stunning browser-based interactive generator.
- `docs/`: Visual assets and project documentation.
- `tests/`: Parity validation suite (Ensures Python/JS outputs are byte-identical).

---

## 🔗 Related Resources

- [Web Utility](https://ppswaroopa.github.io/ros2-dockergen/)
- [Official ROS Documentation](https://docs.ros.org)
- [OSRF ROS Docker Hub](https://hub.docker.com/r/osrf/ros)

---

## License

Released under the [MIT License](LICENSE).
Copyright © 2026 Pranava Swaroopa.
