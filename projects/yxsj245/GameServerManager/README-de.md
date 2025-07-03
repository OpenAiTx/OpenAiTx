# Projektvorstellung
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Macht die Bereitstellung, Verwaltung und Wartung von Spielservern einfach und effizient**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Dokumentationsseite](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Offizielle Webseite](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ-Gruppe](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Projektübersicht

GameServerManager (kurz GSManager) ist eine moderne Plattform zur Verwaltung von Spielservern, die auf **Docker**-Technologie basiert und speziell dafür entwickelt wurde, die Bereitstellung, Verwaltung und Wartung von Spielservern zu vereinfachen.

### ✨ Kernfunktionen

- 🐳 **Docker-Containerisierung** - Läuft vollständig auf Docker, isolierte Umgebung, hervorragende Kompatibilität
- 🎯 **One-Click-Bereitstellung** - Schnelle Bereitstellung für viele beliebte Spiele
- 🌐 **Web-Administrationsoberfläche** - Moderne React-Frontend, intuitiv und benutzerfreundlich
- 🔧 **Echtzeit-Terminal** - Integriertes Web-Terminal, unterstützt Echtzeit-Befehlsausführung
- 📊 **Ressourcenüberwachung** - Überwachung der Serverressourcen in Echtzeit
- 🔐 **Rechtemanagement** - Umfassendes Benutzer-Authentifizierungs- und Rechtesystem
- 🎮 **Mehrspielesupport** - Unterstützung für viele beliebte Steam-Spieleserver
- 💾 **Datenpersistenz** - Externe Zuordnung von Spieldaten und Konfigurationsdateien, sicher und zuverlässig

![Container-Informationspanel](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Schnellstart

### One-Click-Installationsskript

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Für Debian (Docker muss selbst installiert werden) und CentOS bitte die manuelle Installation verwenden, Details siehe Dokumentationsseite

---

## 🎮 Unterstützte Spiele

| Spielname | Chinesischer Name | Steam ID | Anonymer Download | Status |
|---------|--------|----------|----------|------|
| **Beliebte Spiele** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Vollständig unterstützt |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Vollständig unterstützt |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Vollständig unterstützt |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Vollständig unterstützt |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Vollständig unterstützt |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Vollständig unterstützt |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Vollständig unterstützt |
| **Shooter** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Original erforderlich |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Vollständig unterstützt |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Vollständig unterstützt |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Vollständig unterstützt |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Vollständig unterstützt |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Vollständig unterstützt |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Vollständig unterstützt |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Vollständig unterstützt |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Vollständig unterstützt |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Vollständig unterstützt |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Vollständig unterstützt |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Vollständig unterstützt |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Konfiguration erforderlich |
| **Indie-Spiele** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Vollständig unterstützt |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Konfiguration erforderlich |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Vollständig unterstützt |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Vollständig unterstützt |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Vollständig unterstützt |
| **Simulationsspiele** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Konfiguration erforderlich |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Konfiguration erforderlich |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Konfiguration erforderlich |

> Weitere Spiele werden laufend hinzugefügt...

---

## 🏗️ Technische Architektur

### Frontend-Technologien
- **React 18** - Modernes Frontend-Framework
- **Ant Design** - Unternehmensweites UI-Komponenten-Framework
- **Monaco Editor** - Code-Editor
- **Xterm.js** - Web-Terminal-Emulator
- **Vite** - Schnelles Build-Tool

### Backend-Technologien
- **Python 3.13** - Hauptprogrammiersprache
- **Flask** – Web-Framework  
- **Gunicorn** – WSGI-Server  
- **Docker** – Container-Technologie  
- **SteamCMD** – Steam-Kommandozeilentool  
- **Aria2** – Multi-Protokoll-Downloader  

---

## 📁 Projektstruktur

```
GameServerManager/
├── app/                    # Frontend-Anwendung
│   ├── src/               # React-Quellcode
│   ├── public/            # Statische Ressourcen
│   └── package.json       # Frontend-Abhängigkeiten
├── server/                # Backend-Dienste
│   ├── api_server.py      # Haupt-API-Server
│   ├── game_installer.py  # Spiele-Installer
│   ├── pty_manager.py     # Terminal-Manager
│   ├── auth_middleware.py # Authentifizierungs-Middleware
│   └── installgame.json   # Spiele-Konfigurationsdatei
├── docker-compose.yml     # Docker-Compose-Datei
├── Dockerfile             # Docker-Image-Builddatei
└── README.md              # Projektbeschreibung
```

---

## 🔧 Konfiguration

### Port-Konfiguration
- **5000** – Web-Management-Oberfläche
- **27015-27020** – Steam-Spieleserver-Portbereich

### Datenvolumen-Mapping
- `./game_data` → `/home/steam/games` – Spiele-Datenverzeichnis
- `./game_file` → `/home/steam/.config` – Spiele-Konfigurationsverzeichnis
- `./game_file` → `/home/steam/.local` – Speicherverzeichnis für Spielstände

### Umgebungsvariablen
- `TZ=Asia/Shanghai` – Zeitzoneneinstellung
- `USE_GUNICORN=true` – Gunicorn aktivieren
- `GUNICORN_TIMEOUT=120` – Request-Timeout
- `GUNICORN_PORT=5000` – Serverport

---

## 🤝 Beitragshinweise

Wir freuen uns über jede Art von Beitrag!

1. **Fork** dieses Projekts
2. Erstelle deinen Feature-Branch (`git checkout -b feature/AmazingFeature`)
3. Committe deine Änderungen (`git commit -m 'Add some AmazingFeature'`)
4. Push auf den Branch (`git push origin feature/AmazingFeature`)
5. Eröffne eine **Pull Request**

---

## 📞 Support & Feedback

- 🐛 **Problemmeldung**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ-Gruppe**: 1040201322
- 📖 **Detaillierte Dokumentation**: [Dokumentation ansehen](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Open-Source-Lizenz

Dieses Projekt steht unter der [AGPL-3.0 license](LICENSE) Open-Source-Lizenz.

---

## 👨‍💻 Über den Autor

Dieses Projekt wird von **又菜又爱玩的小朱** eigenständig entwickelt und gepflegt.

Wenn dir dieses Projekt geholfen hat, gib bitte ein ⭐ Star zur Unterstützung!

---

## 📈 Projektstatistik

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Mache die Verwaltung von Spieleservern einfach und unterhaltsam!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---