# Projectintroductie
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Maak het uitrollen, beheren en onderhouden van game-servers eenvoudig en efficiënt**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentatie](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Officiële website](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 QQ-groep](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Projectoverzicht

GameServerManager (afgekort GSManager) is een modern beheerplatform voor game-servers gebaseerd op **Docker**-technologie, speciaal ontworpen om het uitrollen, beheren en onderhouden van game-servers te vereenvoudigen.

### ✨ Kernfuncties

- 🐳 **Docker Containerisatie** - Draait volledig op Docker, geïsoleerde omgeving, uitstekende compatibiliteit
- 🎯 **One-click Deployment** - Ondersteunt snelle uitrol van meerdere populaire games
- 🌐 **Webbeheerpaneel** - Moderne React frontend, intuïtief en gebruiksvriendelijk
- 🔧 **Realtime Terminal** - Ingebouwde webterminal, ondersteunt het uitvoeren van realtime commando's
- 📊 **Resource Monitoring** - Realtime monitoring van serverresourcegebruik
- 🔐 **Rechtenbeheer** - Uitgebreid gebruikersauthenticatie- en permissiebeheersysteem
- 🎮 **Multi-game Support** - Ondersteunt meerdere populaire Steam-game servers
- 💾 **Datapersisitentie** - Externe mapping van gamegegevens en configuratiebestanden, veilig en betrouwbaar

![Container informatiepaneel](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Snel aan de slag

### One-click installatiescript

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Gebruik voor debian (installeer docker handmatig) en centos de handmatige installatie, zie de documentatiepagina

---

## 🎮 Ondersteunde games

| Game Naam | Chinese Naam | Steam ID | Anonieme Download | Status |
|---------|--------|----------|----------|------|
| **Populaire Games** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Volledig ondersteund |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Volledig ondersteund |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Volledig ondersteund |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Volledig ondersteund |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Volledig ondersteund |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Volledig ondersteund |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Volledig ondersteund |
| **Shooter Games** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Legitieme versie vereist |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Volledig ondersteund |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Volledig ondersteund |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Volledig ondersteund |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Volledig ondersteund |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Volledig ondersteund |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Volledig ondersteund |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Volledig ondersteund |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Volledig ondersteund |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Volledig ondersteund |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Volledig ondersteund |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Volledig ondersteund |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Configuratie vereist |
| **Indie Games** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Volledig ondersteund |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Configuratie vereist |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Volledig ondersteund |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Volledig ondersteund |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Volledig ondersteund |
| **Simulatie Games** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Configuratie vereist |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Configuratie vereist |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Configuratie vereist |

> Meer game-ondersteuning wordt voortdurend toegevoegd...

---

## 🏗️ Technische architectuur

### Front-end tech stack
- **React 18** - Modern frontend framework
- **Ant Design** - Enterprise-level UI componentenbibliotheek
- **Monaco Editor** - Code editor
- **Xterm.js** - Web terminal emulator
- **Vite** - Snel bouwtool

### Back-end tech stack
- **Python 3.13** - Hoofdprogrammeertaal
- **Flask** - Webframework
- **Gunicorn** - WSGI-server
- **Docker** - Containertechnologie
- **SteamCMD** - Steam commandoregeltool
- **Aria2** - Multi-protocol downloadmanager

---

## 📁 Projectstructuur

```
GameServerManager/
├── app/                    # Frontend applicatie
│   ├── src/               # React broncode
│   ├── public/            # Statische bestanden
│   └── package.json       # Frontend afhankelijkheden
├── server/                # Backend services
│   ├── api_server.py      # Hoofd API-server
│   ├── game_installer.py  # Game installer
│   ├── pty_manager.py     # Terminal manager
│   ├── auth_middleware.py # Authenticatie-middleware
│   └── installgame.json   # Game configuratiebestand
├── docker-compose.yml     # Docker compose bestand
├── Dockerfile             # Docker image buildbestand
└── README.md              # Projectdocumentatie
```

---

## 🔧 Configuratie-uitleg

### Poortconfiguratie
- **5000** - Webbeheerinterface
- **27015-27020** - Steam game server poortenbereik

### Datavolume mapping
- `./game_data` → `/home/steam/games` - Game data directory
- `./game_file` → `/home/steam/.config` - Game configuratiemap
- `./game_file` → `/home/steam/.local` - Game opslagmap

### Omgevingsvariabelen
- `TZ=Asia/Shanghai` - Tijdzone-instelling
- `USE_GUNICORN=true` - Gunicorn inschakelen
- `GUNICORN_TIMEOUT=120` - Request timeout
- `GUNICORN_PORT=5000` - Servicepoort

---

## 🤝 Contributierichtlijnen

We verwelkomen alle vormen van bijdragen!

1. **Fork** dit project
2. Maak je feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit je wijzigingen (`git commit -m 'Add some AmazingFeature'`)
4. Push naar de branch (`git push origin feature/AmazingFeature`)
5. Open een **Pull Request**

---

## 📞 Support & Feedback

- 🐛 **Problemen melden**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **QQ-groep**: 1040201322
- 📖 **Uitgebreide documentatie**: [Bekijk documentatie](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Open Source Licentie

Dit project maakt gebruik van de [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Over de auteur

Dit project wordt zelfstandig ontwikkeld en onderhouden door **又菜又爱玩的小朱**.

Als dit project je heeft geholpen, geef dan een ⭐ Star als waardering!

---

## 📈 Projectstatistieken

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Maak game serverbeheer eenvoudig en leuk!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---