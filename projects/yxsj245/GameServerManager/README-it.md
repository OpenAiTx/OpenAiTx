# Introduzione al Progetto
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Rendi il deployment, la gestione e la manutenzione dei server di gioco semplici ed efficienti**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentazione](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Sito Ufficiale](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Gruppo QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Introduzione al Progetto

GameServerManager (GSManager) è una piattaforma moderna di gestione server di gioco basata sulla tecnologia **Docker**, progettata per semplificare il deployment, la gestione e la manutenzione dei server di gioco.

### ✨ Caratteristiche Principali

- 🐳 **Containerizzazione Docker** - Completamente basato su Docker, isolamento ambientale ed eccellente compatibilità
- 🎯 **Deployment con un click** - Supporta il deployment rapido di numerosi giochi popolari
- 🌐 **Interfaccia Web di Gestione** - Frontend moderno in React, intuitivo e facile da usare
- 🔧 **Terminale in tempo reale** - Terminale web integrato, supporto all'esecuzione di comandi in tempo reale
- 📊 **Monitoraggio delle Risorse** - Monitoraggio in tempo reale dell'utilizzo delle risorse del server
- 🔐 **Gestione dei Permessi** - Sistema completo di autenticazione utenti e controllo dei permessi
- 🎮 **Supporto Multi-Gioco** - Supporta numerosi server di gioco popolari della piattaforma Steam
- 💾 **Persistenza dei Dati** - Mapping esterno di dati di gioco e file di configurazione, sicuro e affidabile

![Pannello informazioni container](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Guida Rapida

### Script di installazione automatica

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Su debian (installare docker manualmente) e centos si prega di utilizzare l'installazione manuale, vedere la documentazione

---

## 🎮 Giochi Supportati

| Nome del Gioco | Nome Cinese | Steam ID | Download Anonimo | Stato |
|---------|--------|----------|----------|------|
| **Giochi Popolari** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Supporto completo |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Supporto completo |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Supporto completo |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Supporto completo |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Supporto completo |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Supporto completo |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Supporto completo |
| **Giochi Sparatutto** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Richiede versione originale |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Supporto completo |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Supporto completo |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Supporto completo |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Supporto completo |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Supporto completo |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Supporto completo |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Supporto completo |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Supporto completo |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Supporto completo |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Supporto completo |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Supporto completo |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Richiede configurazione |
| **Giochi Indie** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Supporto completo |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Richiede configurazione |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Supporto completo |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Supporto completo |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Supporto completo |
| **Giochi di Simulazione** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Richiede configurazione |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Richiede configurazione |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Richiede configurazione |

> Il supporto a più giochi è in continuo aggiornamento...

---

## 🏗️ Architettura Tecnica

### Stack Tecnologico Frontend
- **React 18** - Framework frontend moderno
- **Ant Design** - Libreria UI a livello enterprise
- **Monaco Editor** - Editor di codice
- **Xterm.js** - Simulatore di terminale web
- **Vite** - Strumento di build veloce

### Stack Tecnologico Backend
- **Python 3.13** - Linguaggio di sviluppo principale
- **Flask** - Framework Web
- **Gunicorn** - Server WSGI
- **Docker** - Tecnologia di containerizzazione
- **SteamCMD** - Strumento da riga di comando di Steam
- **Aria2** - Downloader multi-protocollo

---

## 📁 Struttura del progetto

```
GameServerManager/
├── app/                    # Applicazione frontend
│   ├── src/               # Sorgente React
│   ├── public/            # Risorse statiche
│   └── package.json       # Dipendenze frontend
├── server/                # Servizio backend
│   ├── api_server.py      # Server API principale
│   ├── game_installer.py  # Installatore di giochi
│   ├── pty_manager.py     # Gestore terminale
│   ├── auth_middleware.py # Middleware di autenticazione
│   └── installgame.json   # File di configurazione giochi
├── docker-compose.yml     # File di orchestrazione Docker
├── Dockerfile            # File di build immagine Docker
└── README.md             # Documentazione del progetto
```

---

## 🔧 Istruzioni di configurazione

### Configurazione porte
- **5000** - Interfaccia web di gestione
- **27015-27020** - Intervallo porte server giochi Steam

### Mappatura volumi dati
- `./game_data` → `/home/steam/games` - Directory dati di gioco
- `./game_file` → `/home/steam/.config` - Directory di configurazione di gioco
- `./game_file` → `/home/steam/.local` - Directory dei salvataggi di gioco

### Variabili d'ambiente
- `TZ=Asia/Shanghai` - Impostazione del fuso orario
- `USE_GUNICORN=true` - Abilita Gunicorn
- `GUNICORN_TIMEOUT=120` - Timeout richieste
- `GUNICORN_PORT=5000` - Porta del servizio

---

## 🤝 Guida al contributo

Accogliamo con piacere ogni tipo di contributo!

1. **Fork** di questo progetto
2. Crea il tuo branch delle funzionalità (`git checkout -b feature/AmazingFeature`)
3. Fai il commit delle tue modifiche (`git commit -m 'Add some AmazingFeature'`)
4. Esegui il push del branch (`git push origin feature/AmazingFeature`)
5. Apri una **Pull Request**

---

## 📞 Supporto e feedback

- 🐛 **Segnalazione problemi**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Gruppo QQ**：1040201322
- 📖 **Documentazione dettagliata**：[Visualizza documentazione](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Licenza Open Source

Questo progetto è rilasciato sotto licenza open source [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Informazioni sull'autore

Questo progetto è sviluppato e mantenuto in modo indipendente da **又菜又爱玩的小朱**.

Se questo progetto ti è stato utile, lascia una ⭐ Star di supporto!

---

## 📈 Statistiche del progetto

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Rendere la gestione dei server di gioco semplice e divertente!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---