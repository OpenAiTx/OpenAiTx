# Wprowadzenie do projektu
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Uprość i usprawnij wdrażanie, zarządzanie oraz utrzymanie serwerów gier**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Dokumentacja](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Oficjalna strona](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Grupa QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Opis projektu

GameServerManager (w skrócie GSManager) to nowoczesna platforma do zarządzania serwerami gier oparta na technologii **Docker**, zaprojektowana w celu uproszczenia wdrażania, zarządzania i utrzymania serwerów gier.

### ✨ Kluczowe funkcje

- 🐳 **Konteneryzacja Docker** – działa w pełni na Dockerze, izolacja środowiska, doskonała kompatybilność
- 🎯 **Jedno kliknięcie do wdrożenia** – szybkie wdrażanie wielu popularnych gier
- 🌐 **Panel zarządzania Web** – nowoczesny frontend React, intuicyjny i łatwy w obsłudze
- 🔧 **Terminal na żywo** – wbudowany terminal webowy, obsługa poleceń w czasie rzeczywistym
- 📊 **Monitorowanie zasobów** – monitorowanie zużycia zasobów serwera w czasie rzeczywistym
- 🔐 **Zarządzanie uprawnieniami** – rozbudowany system uwierzytelniania i kontroli dostępu
- 🎮 **Wsparcie wielu gier** – obsługuje wiele popularnych serwerów gier na platformie Steam
- 💾 **Trwałość danych** – zewnętrzne mapowanie danych gry i plików konfiguracyjnych, bezpieczne i niezawodne

![Panel informacji o kontenerze](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Szybki start

### Skrypt instalacyjny jednym poleceniem

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Dla systemów debian (docker instalowany ręcznie) i centos zalecana jest instalacja ręczna – szczegóły w dokumentacji

---

## 🎮 Obsługiwane gry

| Nazwa gry | Nazwa chińska | Steam ID | Pobieranie anonimowe | Status |
|---------|--------|----------|----------|------|
| **Popularne gry** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Pełne wsparcie |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Pełne wsparcie |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Pełne wsparcie |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Pełne wsparcie |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Pełne wsparcie |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Pełne wsparcie |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Pełne wsparcie |
| **Gry FPS** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Wymagana licencja |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Pełne wsparcie |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Pełne wsparcie |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Pełne wsparcie |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Pełne wsparcie |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Pełne wsparcie |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Pełne wsparcie |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Pełne wsparcie |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Pełne wsparcie |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Pełne wsparcie |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Pełne wsparcie |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Pełne wsparcie |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Wymaga konfiguracji |
| **Gry indie** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Pełne wsparcie |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Wymaga konfiguracji |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Pełne wsparcie |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Pełne wsparcie |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Pełne wsparcie |
| **Symulatory** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Wymaga konfiguracji |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Wymaga konfiguracji |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Wymaga konfiguracji |

> Obsługa kolejnych gier jest stale dodawana...

---

## 🏗️ Architektura techniczna

### Stos technologiczny frontend
- **React 18** – nowoczesny framework frontendowy
- **Ant Design** – komponenty UI klasy enterprise
- **Monaco Editor** – edytor kodu
- **Xterm.js** – terminal webowy
- **Vite** – szybkie narzędzie do budowy

### Stos technologiczny backend
- **Python 3.13** – główny język programowania
- **Flask** - Framework webowy
- **Gunicorn** - Serwer WSGI
- **Docker** - Technologia konteneryzacji
- **SteamCMD** - Narzędzie wiersza poleceń Steam
- **Aria2** - Wieloprotokołowy downloader

---

## 📁 Struktura projektu

```
GameServerManager/
├── app/                    # Aplikacja frontendowa
│   ├── src/               # Źródła React
│   ├── public/            # Zasoby statyczne
│   └── package.json       # Zależności frontendu
├── server/                # Usługi backendowe
│   ├── api_server.py      # Główny serwer API
│   ├── game_installer.py  # Instalator gier
│   ├── pty_manager.py     # Menedżer terminala
│   ├── auth_middleware.py # Middleware uwierzytelniania
│   └── installgame.json   # Plik konfiguracyjny gier
├── docker-compose.yml     # Plik orkiestracji Docker
├── Dockerfile            # Plik budowania obrazu Docker
└── README.md             # Dokumentacja projektu
```

---

## 🔧 Instrukcja konfiguracji

### Konfiguracja portów
- **5000** - Interfejs zarządzania webowego
- **27015-27020** - Zakres portów serwerów gier Steam

### Mapowanie wolumenów danych
- `./game_data` → `/home/steam/games` - Katalog danych gry
- `./game_file` → `/home/steam/.config` - Katalog konfiguracji gry
- `./game_file` → `/home/steam/.local` - Katalog zapisów gry

### Zmienne środowiskowe
- `TZ=Asia/Shanghai` - Ustawienie strefy czasowej
- `USE_GUNICORN=true` - Włączenie Gunicorna
- `GUNICORN_TIMEOUT=120` - Limit czasu żądania
- `GUNICORN_PORT=5000` - Port serwera

---

## 🤝 Wskazówki dotyczące współtworzenia

Zapraszamy do każdego rodzaju wkładu!

1. **Forkuj** ten projekt
2. Utwórz swoją gałąź funkcjonalności (`git checkout -b feature/AmazingFeature`)
3. Wprowadź zmiany (`git commit -m 'Add some AmazingFeature'`)
4. Wypchnij na swoją gałąź (`git push origin feature/AmazingFeature`)
5. Otwórz **Pull Request**

---

## 📞 Wsparcie i opinie

- 🐛 **Zgłaszanie problemów**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Grupa QQ**: 1040201322
- 📖 **Szczegółowa dokumentacja**: [Zobacz dokumentację](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Licencja open source

Projekt jest udostępniany na licencji [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 O autorze

Ten projekt jest samodzielnie rozwijany i utrzymywany przez **又菜又爱玩的小朱**.

Jeśli projekt okazał się pomocny, zostaw ⭐ Star na wsparcie!

---

## 📈 Statystyki projektu

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Spraw, aby zarządzanie serwerami gier było proste i przyjemne!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---