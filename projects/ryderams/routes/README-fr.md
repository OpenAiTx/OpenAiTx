<!-- # EasyNetwork [![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=flat&logo=youtube&logoColor=white)](https://www.youtube.com/@EasyNetworkVPN) [![Telegram](https://img.shields.io/badge/Telegram-0088cc?style=flat&logo=telegram&logoColor=white)](https://t.me/easynetpro) -->

## Hébergements VPS

- **[AdminVPS](https://vk.cc/cRBFB3)** — Code promo **GIT** — réduction de 60%
- **[TimeWeb](https://vk.cc/cRDfn5)** — Excellent hébergement VPS
- **[Amnezia Premium](https://vk.cc/cRBFsO)** — Solution prête à l’emploi, 20 pays au prix d’un VPS

## Routes pour le routeur Keenetic

| Type | Lien |
|-----|--------|
| **Routes globales** | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/Global) |
| **YouTube** (si lent) | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/Global/Youtube) |
| **Services russes** | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/RU-RU) |
| **Routes de domaines** | [GitHub](https://github.com/v2fly/domain-list-community/tree/master/data) |

---

## OpenVPN

📖 **[Guide complet sur OpenVPN](https://github.com/ryderams/OpenVPN-ru)**

### Installation

```bash
wget -O openvpn.sh https://get.vpnsetup.net/ovpn
sudo bash openvpn.sh --auto
```

### Gestion des clients

**Créer un nouveau client** (par exemple, `client1`) :
```bash
sudo bash openvpn.sh --addclient client1
```

**Supprimer un client** (par exemple, `client1`) :
```bash
sudo bash openvpn.sh --revokeclient client1
```

---

## 3X-UI

### 1. Базовый скрипт

```bash
bash <(curl -Ls https://raw.githubusercontent.com/MHSanaei/3x-ui/refs/tags/v2.6.0/install.sh)
```

### 2. 3X-UI Pro avec le panneau REALITY Nécessite un domaine + sous-domaine.

```bash
sudo su -c "bash <(wget -qO- https://raw.githubusercontent.com/mozaroc/x-ui-pro/refs/heads/master/x-ui-pro.sh) -install yes"
```
🔧 **[Instructions complètes pour l'installation de 3X-UI Pro (le site peut être restreint dans votre région)](https://vk.cc/cRG1KM)**

> Ce script installe **3X-UI Pro** avec prise en charge de :
> - 📡 Panneau REALITY
> - 🌐 WebSocket
> - 🔌 Connexions entrantes (inbounds) sur le port 443

---

**Tous les scripts proviennent des dépôts GitHub officiels.**




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---