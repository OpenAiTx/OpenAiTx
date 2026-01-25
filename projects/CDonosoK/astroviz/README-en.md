# 🚀 AstroViz 🚀

<img src="https://github.com/hucebot/astroviz/blob/main/images/AstroViz.png" alt="AstroViz Image" width="800" height="500">

[![License](https://img.shields.io/badge/License-MIT--Clause-blue.svg)](https://opensource.org/licenses/MIT)
[![ROS2 Version](https://img.shields.io/badge/ROS-Humble-green)](https://docs.ros.org/en/humble/index.html)

AstroViz is the ultimate real-time data visualization suite for ROS 2 robotic missions. Built from the ground up for flexibility, clarity, and performance, AstroViz empowers roboticists, engineers, and field operators with a unified interface to monitor, control, and debug complex systems in real-time.

- 🌍 All-in-one visualization: From GPS and LiDAR to camera feeds, robot state, and motor health, AstroViz integrates multiple views into a cohesive and modern GUI.
- ⚡ High-performance: Docker-based deployment with GPU support ensures smooth operation even in data-intensive environments.
- 🛰️ Field-proven: Whether you’re launching autonomous vehicles, drones, or ground robots, AstroViz is your visual command center.

💡 Looking for a ROS 2 tool that goes beyond raw data and helps you make real-time decisions in the field?
<b>AstroViz is built for that.</b>

## Visual Overview
<table>
  <tr>
    <td colspan="2" align="center">
      <strong>DASHBOARD VIEWER</strong><br>
      <img src="https://github.com/hucebot/astroviz/blob/main/images/dashboard.gif" alt="Teleoperation Overview" width="800">
    </td>
  </tr>
</table>

For a detailed view of all implemented windows, see: [windows implemented](https://raw.githubusercontent.com/CDonosoK/astroviz/main/WINDOWS_IMPLEMENTED.md)


## Table of Contents
1. [Get Started](#get-started)
   - [Prerequisites](#prerequisites)
   - [Installation](#installation)
      - [Clone the Repository](#clone-the-repository)
      - [Build Using Docker](#build-using-docker)
      - [Run the Docker Container](#run-the-docker-container)
2. [Usage](#usage)
   - [Node Overview](#node-overview)
   - [Running Nodes](#running-nodes)
3. [Maintainer](#maintainer)
3. [License](#license)

---

## Get Started
### Prerequisites

To run this package, ensure the following dependencies are installed:
- **Git**: For version control and repository management.
- **Docker**: To streamline the environment setup and execution.
- **NVIDIA Container Toolkit** (if using an NVIDIA GPU): For hardware acceleration.


### Installation

#### Clone the Repository
Start by cloning the repository:
```bash
git clone git@github.com:hucebot/astroviz.git
```

#### Build Using Docker
This repository includes a pre-configured Docker setup for easy deployment. To build the Docker image:
1. Navigate to the `docker` directory:
   ```bash
   cd astroviz/docker
   ```
2. Run the build script:
   ```bash
   sh build.sh
   ```
   This will create a Docker image named `astroviz`.

#### Run the Docker Container
Once built, launch the container using:
```bash
sh run.sh
```
---

## Usage
### Node Overview

This package contains nodes that are designed to facilitate teleoperation and visualization of data. Each node serves a specific purpose in the teleoperation workflow:
- **gpsmap_viewer**: Visualizes GPS data on a map.
- **camera_viewer**: Displays camera feed from the robot.
- **imu_viewer**: Visualizes IMU data.
- **lidar_viewer**: Visualizes LiDAR data.
- **teleoperation_viewer**: Provides a GUI for teleoperation control.
- **dashboard_viewer**: A comprehensive dashboard that integrates various data streams and provides a unified interface for monitoring and control.
- **plot_viewer**: Displays real-time plots of various data streams.
- **grid_map_viewer**: Visualizes grid map data for navigation and planning.
- **robot_state_viewer**: Displays the current state of the robot related to the joint positions and transformations.
- **motor_state_viewer**: Monitors and visualizes the state of the robot's motors, including temperature and voltage readings.
- **record_manager_viewer**: Manages and visualizes recording sessions, allowing users to start, stop, and review recordings.

### Running Nodes
To run the nodes, you can use the following command:
```bash
ros2 run astroviz <node_name>
```
Replace `<node_name>` with the name of the node you wish to run, such as `gps_map_viewer`, `camera_viewer`, etc.

Or if you prefer to run the dashboard viewer, which integrates all functionalities:
```bash
ros2 launch astroviz dashboard_launcher.launch.py
```

## Maintainer
This package is maintained by:

**Clemente Donoso**  
Email: [clemente.donoso@inria.fr](https://raw.githubusercontent.com/CDonosoK/astroviz/main/mailto:clemente.donoso@inria.fr)
GitHub: [CDonosoK](https://github.com/CDonosoK)  

---

## License
This project is licensed under the **MIT**. See the [LICENSE](LICENSE) file for details.

---
Contributions and feedback are welcome! If you encounter any issues or have suggestions for improvements, feel free to open an issue or submit a pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-25

---