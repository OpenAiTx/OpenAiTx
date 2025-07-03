# Introducción al Proyecto
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Haz que el despliegue, la gestión y el mantenimiento de servidores de juegos sea simple y eficiente**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentación](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Sitio Oficial](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Grupo QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Descripción del Proyecto

GameServerManager (abreviado como GSManager) es una plataforma moderna de gestión de servidores de juegos basada en la tecnología **Docker**, diseñada para simplificar el despliegue, la gestión y el mantenimiento de servidores de juegos.

### ✨ Características Principales

- 🐳 **Docker Containerización** - Funciona completamente sobre Docker, aislamiento de entornos y excelente compatibilidad
- 🎯 **Despliegue con un clic** - Soporte para despliegue rápido de varios juegos populares
- 🌐 **Interfaz web de administración** - Frontend moderno en React, intuitivo y fácil de usar
- 🔧 **Terminal en tiempo real** - Terminal web incorporado, permite ejecución de comandos en tiempo real
- 📊 **Monitoreo de recursos** - Supervisión en tiempo real del uso de recursos del servidor
- 🔐 **Gestión de permisos** - Sistema completo de autenticación de usuarios y control de permisos
- 🎮 **Soporte multijuego** - Compatible con servidores de muchos juegos populares de Steam
- 💾 **Persistencia de datos** - Mapeo externo de datos de juego y archivos de configuración, seguro y fiable

![Panel de información de contenedores](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Comenzando Rápidamente

### Script de instalación con un clic

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Para debian (instalar docker manualmente) y centos, use la instalación manual, consulte la documentación

---

## 🎮 Juegos Soportados

| Nombre del Juego | Nombre en Chino | Steam ID | Descarga Anónima | Estado |
|------------------|----------------|----------|------------------|--------|
| **Juegos Populares** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Soporte completo |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Soporte completo |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Soporte completo |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Soporte completo |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Soporte completo |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Soporte completo |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Soporte completo |
| **Juegos de Disparos** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Requiere original |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Soporte completo |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Soporte completo |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Soporte completo |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Soporte completo |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Soporte completo |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Soporte completo |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Soporte completo |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Soporte completo |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Soporte completo |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Soporte completo |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Soporte completo |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Requiere configuración |
| **Juegos Indie** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Soporte completo |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Requiere configuración |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Soporte completo |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Soporte completo |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Soporte completo |
| **Simulación** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Requiere configuración |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Requiere configuración |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Requiere configuración |

> Se están agregando más juegos continuamente...

---

## 🏗️ Arquitectura Técnica

### Stack Tecnológico Frontend
- **React 18** - Framework frontend moderno
- **Ant Design** - Librería de componentes UI a nivel empresarial
- **Monaco Editor** - Editor de código
- **Xterm.js** - Emulador de terminal web
- **Vite** - Herramienta de construcción rápida

### Stack Tecnológico Backend
- **Python 3.13** - Lenguaje principal de desarrollo
- **Flask** - Framework web
- **Gunicorn** - Servidor WSGI
- **Docker** - Tecnología de contenedores
- **SteamCMD** - Herramienta de línea de comandos de Steam
- **Aria2** - Descargador multiprotocolo

---

## 📁 Estructura del proyecto

```
GameServerManager/
├── app/                    # Aplicación frontend
│   ├── src/               # Código fuente de React
│   ├── public/            # Recursos estáticos
│   └── package.json       # Dependencias frontend
├── server/                # Servicio backend
│   ├── api_server.py      # Servidor API principal
│   ├── game_installer.py  # Instalador de juegos
│   ├── pty_manager.py     # Gestor de terminales
│   ├── auth_middleware.py # Middleware de autenticación
│   └── installgame.json   # Archivo de configuración de juegos
├── docker-compose.yml     # Archivo de orquestación Docker
├── Dockerfile            # Archivo de construcción de imagen Docker
└── README.md             # Documentación del proyecto
```

---

## 🔧 Instrucciones de configuración

### Configuración de puertos
- **5000** - Interfaz web de administración
- **27015-27020** - Rango de puertos del servidor de juegos Steam

### Mapeo de volúmenes de datos
- `./game_data` → `/home/steam/games` - Directorio de datos de juegos
- `./game_file` → `/home/steam/.config` - Directorio de configuración de juegos
- `./game_file` → `/home/steam/.local` - Directorio de partidas guardadas

### Variables de entorno
- `TZ=Asia/Shanghai` - Configuración de zona horaria
- `USE_GUNICORN=true` - Habilitar Gunicorn
- `GUNICORN_TIMEOUT=120` - Tiempo de espera de solicitud
- `GUNICORN_PORT=5000` - Puerto del servicio

---

## 🤝 Guía de contribución

¡Damos la bienvenida a cualquier tipo de contribución!

1. **Haz un fork** de este proyecto
2. Crea tu rama de funcionalidad (`git checkout -b feature/AmazingFeature`)
3. Realiza tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Haz push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un **Pull Request**

---

## 📞 Soporte y feedback

- 🐛 **Reporte de problemas**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Grupo QQ**: 1040201322
- 📖 **Documentación detallada**: [Ver documentación](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Licencia

Este proyecto utiliza la licencia open source [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Sobre el autor

Este proyecto es desarrollado y mantenido de manera independiente por **又菜又爱玩的小朱**.

¡Si este proyecto te ha sido útil, por favor apóyalo con una ⭐ Star!

---

## 📈 Estadísticas del proyecto

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 ¡Haz que la gestión de servidores de juegos sea simple y divertida!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---