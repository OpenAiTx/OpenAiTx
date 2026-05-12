<!-- # EasyNetwork [![YouTube](https://img.shields.io/badge/YouTube-FF0000?style=flat&logo=youtube&logoColor=white)](https://www.youtube.com/@EasyNetworkVPN) [![Telegram](https://img.shields.io/badge/Telegram-0088cc?style=flat&logo=telegram&logoColor=white)](https://t.me/easynetpro) -->

## VPS ホスティング

- **[AdminVPS](https://vk.cc/cRBFB3)** — プロモコード **GIT** — 60% 割引
- **[TimeWeb](https://vk.cc/cRDfn5)** — 優れた VPS ホスティング
- **[Amnezia Premium](https://vk.cc/cRBFsO)** — 完成済みソリューション、20か国分のVPS価格

## Keenetic ルーター用ルート

| タイプ | リンク |
|-----|--------|
| **グローバルルート** | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/Global) |
| **YouTube**（遅い場合） | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/Global/Youtube) |
| **ロシアのサービス** | [GitHub](https://github.com/RockBlack-VPN/ip-address/tree/main/RU-RU) |
| **ドメインルート** | [GitHub](https://github.com/v2fly/domain-list-community/tree/master/data) |

---

## OpenVPN

📖 **[OpenVPNの完全な手順](https://github.com/ryderams/OpenVPN-ru)**

### インストール

```bash
wget -O openvpn.sh https://get.vpnsetup.net/ovpn
sudo bash openvpn.sh --auto
```

### クライアント管理

**新しいクライアントを作成する**（例：`client1`）：
```bash
sudo bash openvpn.sh --addclient client1
```

**クライアントを削除する**（例：`client1`）：
```bash
sudo bash openvpn.sh --revokeclient client1
```

---

## 3X-UI

### 1. Базовый скрипт

```bash
bash <(curl -Ls https://raw.githubusercontent.com/MHSanaei/3x-ui/refs/tags/v2.6.0/install.sh)
```

### 2. 3X-UI Pro と REALITY パネル ドメイン + サブドメインが必要です。

```bash
sudo su -c "bash <(wget -qO- https://raw.githubusercontent.com/mozaroc/x-ui-pro/refs/heads/master/x-ui-pro.sh) -install yes"
```
🔧 **[3X-UI Pro 完全インストールガイド（お住まいの地域でサイトが制限されている場合があります）](https://vk.cc/cRG1KM)**

> このスクリプトは **3X-UI Pro** を以下のサポート付きでインストールします：
> - 📡 REALITY パネル
> - 🌐 WebSocket
> - 🔌 ポート443の受信接続（inbounds）

---

**すべてのスクリプトは公式GitHubリポジトリから取得されています。**




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-12

---