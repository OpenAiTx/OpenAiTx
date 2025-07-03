# Introdução ao Projeto
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**Torne o deployment, gerenciamento e manutenção de servidores de jogos simples e eficiente**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 Documentação](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 Site Oficial](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 Grupo QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 Visão Geral do Projeto

GameServerManager (GSManager) é uma plataforma moderna de gerenciamento de servidores de jogos baseada na tecnologia **Docker**, projetada para simplificar o deployment, gerenciamento e manutenção de servidores de jogos.

### ✨ Recursos Principais

- 🐳 **Containerização Docker** - Totalmente baseado em Docker, isolamento de ambiente, excelente compatibilidade
- 🎯 **Deployment com um clique** - Suporte para deployment rápido de vários jogos populares
- 🌐 **Interface de Gerenciamento Web** - Frontend moderno com React, intuitivo e fácil de usar
- 🔧 **Terminal em tempo real** - Terminal web integrado, suporte a execução de comandos em tempo real
- 📊 **Monitoramento de Recursos** - Monitoramento em tempo real do uso de recursos do servidor
- 🔐 **Gerenciamento de Permissões** - Sistema completo de autenticação de usuários e controle de acesso
- 🎮 **Suporte a múltiplos jogos** - Suporte a vários servidores de jogos populares da plataforma Steam
- 💾 **Persistência de Dados** - Mapeamento externo de dados e arquivos de configuração dos jogos, seguro e confiável

![Painel de Informações do Container](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 Comece Rápido

### Script de Instalação com um Clique

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> Para debian (instale o docker manualmente) e centos, utilize a instalação manual. Veja mais detalhes na documentação.

---

## 🎮 Jogos Suportados

| Nome do Jogo | Nome em Chinês | Steam ID | Download Anônimo | Status |
|--------------|----------------|----------|------------------|--------|
| **Jogos Populares** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 Suporte total |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 Suporte total |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 Suporte total |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 Suporte total |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 Suporte total |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 Suporte total |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 Suporte total |
| **Jogos de Tiro** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 Requer original |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 Suporte total |
| Squad | 战术小队 | 403240 | ✅ | 🟢 Suporte total |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 Suporte total |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 Suporte total |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 Suporte total |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 Suporte total |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 Suporte total |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 Suporte total |
| Half-Life | 半条命 | 90 | ✅ | 🟢 Suporte total |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 Suporte total |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 Suporte total |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 Requer configuração |
| **Jogos Indie** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 Suporte total |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 Requer configuração |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 Suporte total |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 Suporte total |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 Suporte total |
| **Jogos de Simulação** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 Requer configuração |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 Requer configuração |
| ECO | 生态生存 | 739590 | ✅ | 🟡 Requer configuração |

> Mais jogos serão adicionados em breve...

---

## 🏗️ Arquitetura Técnica

### Stack de Tecnologias Frontend
- **React 18** - Framework frontend moderno
- **Ant Design** - Biblioteca de componentes UI de nível corporativo
- **Monaco Editor** - Editor de código
- **Xterm.js** - Emulador de terminal web
- **Vite** - Ferramenta de build rápida

### Stack de Tecnologias Backend
- **Python 3.13** - Linguagem principal de desenvolvimento
- **Flask** - Framework web
- **Gunicorn** - Servidor WSGI
- **Docker** - Tecnologia de conteinerização
- **SteamCMD** - Ferramenta de linha de comando Steam
- **Aria2** - Gerenciador de downloads multiprotocolo

---

## 📁 Estrutura do Projeto

```
GameServerManager/
├── app/                    # Aplicação frontend
│   ├── src/               # Código-fonte React
│   ├── public/            # Recursos estáticos
│   └── package.json       # Dependências do frontend
├── server/                # Serviço backend
│   ├── api_server.py      # Servidor principal da API
│   ├── game_installer.py  # Instalador de jogos
│   ├── pty_manager.py     # Gerenciador de terminal
│   ├── auth_middleware.py # Middleware de autenticação
│   └── installgame.json   # Arquivo de configuração de jogos
├── docker-compose.yml     # Arquivo de orquestração Docker
├── Dockerfile            # Arquivo de build da imagem Docker
└── README.md             # Documentação do projeto
```

---

## 🔧 Instruções de Configuração

### Configuração de Portas
- **5000** - Interface web de administração
- **27015-27020** - Faixa de portas do servidor de jogos Steam

### Mapeamento de Volumes de Dados
- `./game_data` → `/home/steam/games` - Diretório de dados dos jogos
- `./game_file` → `/home/steam/.config` - Diretório de configuração dos jogos
- `./game_file` → `/home/steam/.local` - Diretório de saves dos jogos

### Variáveis de Ambiente
- `TZ=Asia/Shanghai` - Configuração de fuso horário
- `USE_GUNICORN=true` - Habilitar Gunicorn
- `GUNICORN_TIMEOUT=120` - Tempo limite de requisição
- `GUNICORN_PORT=5000` - Porta do serviço

---

## 🤝 Guia de Contribuição

Todas as formas de contribuição são bem-vindas!

1. **Fork** este projeto
2. Crie sua branch de funcionalidade (`git checkout -b feature/AmazingFeature`)
3. Faça o commit de suas alterações (`git commit -m 'Add some AmazingFeature'`)
4. Faça push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um **Pull Request**

---

## 📞 Suporte e Feedback

- 🐛 **Relatar Problemas**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **Grupo QQ**: 1040201322
- 📖 **Documentação Completa**: [Ver Documentação](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 Licença Open Source

Este projeto utiliza a licença open source [AGPL-3.0 license](LICENSE).

---

## 👨‍💻 Sobre o Autor

Este projeto é desenvolvido e mantido de forma independente por **又菜又爱玩的小朱**.

Se este projeto foi útil para você, deixe um ⭐ Star para apoiar!

---

## 📈 Estatísticas do Projeto

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 Torne a gestão de servidores de jogos simples e divertida!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---