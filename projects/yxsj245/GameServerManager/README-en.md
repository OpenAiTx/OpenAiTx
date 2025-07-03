# Project Introduction
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Making Game Server Deployment, Management, and Maintenance Simple and Efficient**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentation Site](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Official Website](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ Group](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Project Overview

GameServerManager (GSManager for short) is a modern game server management platform based on **Docker** technology, designed to simplify the deployment, management, and maintenance of game servers.

### ✨ Core Features

- 🐳 **Docker Containerization** - Fully Docker-based, environment isolation, excellent compatibility
- 🎯 **One-Click Deployment** - Rapid deployment for multiple popular games
- 🌐 **Web Management Interface** - Modern React frontend, intuitive and easy to use
- 🔧 **Real-Time Terminal** - Built-in web terminal supporting real-time command execution
- 📊 **Resource Monitoring** - Real-time monitoring of server resource usage
- 🔐 **Permission Management** - Comprehensive user authentication and access control system
- 🎮 **Multi-Game Support** - Supports many popular Steam game servers
- 💾 **Data Persistence** - Game data and configuration files externally mapped, safe and reliable

![Container Info Panel](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Quick Start

### One-Click Installation Script

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> For Debian (install Docker manually) and CentOS, please use manual installation. See documentation site for details.

---

## 🎮 Supported Games

| Game Name | Chinese Name | Steam ID | Anonymous Download | Status |
|-----------|-------------|----------|--------------------|--------|
| **Popular Games** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Fully Supported |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Fully Supported |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Fully Supported |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Fully Supported |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Fully Supported |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Fully Supported |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Fully Supported |
| **Shooter Games** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Requires Genuine |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Fully Supported |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Fully Supported |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Fully Supported |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Fully Supported |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Fully Supported |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Fully Supported |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Fully Supported |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Fully Supported |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Fully Supported |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Fully Supported |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Fully Supported |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Requires Configuration |
| **Indie Games** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Fully Supported |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Requires Configuration |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Fully Supported |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Fully Supported |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Fully Supported |
| **Simulation Games** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Requires Configuration |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Requires Configuration |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Requires Configuration |

> More game support is being continuously added...

---

## 🏗️ Technical Architecture

### Frontend Tech Stack
- **React 18** - Modern frontend framework
- **Ant Design** - Enterprise-level UI component library
- **Monaco Editor** - Code editor
- **Xterm.js** - Web terminal emulator
- **Vite** - Fast build tool

### Backend Tech Stack
- **Python 3.13** - Primary development language
- **Flask** - Web framework  
- **Gunicorn** - WSGI server  
- **Docker** - Containerization technology  
- **SteamCMD** - Steam command-line tool  
- **Aria2** - Multi-protocol downloader  

---

## 📁 Project Structure

```
GameServerManager/
├── app/                    # Frontend application
│   ├── src/               # React source code
│   ├── public/            # Static assets
│   └── package.json       # Frontend dependencies
├── server/                # Backend services
│   ├── api_server.py      # Main API server
│   ├── game_installer.py  # Game installer
│   ├── pty_manager.py     # Terminal manager
│   ├── auth_middleware.py # Authentication middleware
│   └── installgame.json   # Game configuration file
├── docker-compose.yml     # Docker orchestration file
├── Dockerfile            # Docker image build file
└── README.md             # Project documentation
```

---

## 🔧 Configuration Instructions

### Port Configuration
- **5000** - Web management interface
- **27015-27020** - Steam game server port range

### Data Volume Mapping
- `./game_data` → `/home/steam/games` - Game data directory
- `./game_file` → `/home/steam/.config` - Game configuration directory
- `./game_file` → `/home/steam/.local` - Game save directory

### Environment Variables
- `TZ=Asia/Shanghai` - Timezone setting
- `USE_GUNICORN=true` - Enable Gunicorn
- `GUNICORN_TIMEOUT=120` - Request timeout
- `GUNICORN_PORT=5000` - Service port

---

## 🤝 Contribution Guide

We welcome all forms of contributions!

1. **Fork** this project
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a **Pull Request**

---

## 📞 Support & Feedback

- 🐛 **Report Issues**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ Group**: 1040201322
- 📖 **Detailed Documentation**: [View Docs](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Open Source License

This project is licensed under the [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 About the Author

This project is independently developed and maintained by **又菜又爱玩的小朱**.

If this project is helpful to you, please give a ⭐ Star to support!

---

## 📈 Project Statistics

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Make game server management simple and fun!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---