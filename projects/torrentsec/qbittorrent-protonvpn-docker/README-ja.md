# 🏰️ qBittorrent + ProtonVPN（WireGuard）をDockerで実行（macOS）

**Gluetunを使用してProtonVPN（WireGuard）経由でqBittorrentをDocker内で安全に実行し、完全なVPNルーティングと自動ポートフォワーディングを実現してトレントのパフォーマンスを向上させます。**

&#x20;

---

## 📌 目次

1. [概要](#overview)
2. [特徴](#features)
3. [前提条件](#prerequisites)
4. [インストールガイド](#installation-guide)
   - [Dockerのインストール](#install-docker)
   - [リポジトリのクローン](#clone-the-repository)
   - [`.env`ファイルの設定](#set-up-the-env-file)
   - [認証の設定](#configure-authentication)
   - [コンテナの起動](#start-the-containers)
5. [qBittorrent Web UIへのアクセス](#accessing-qbittorrent-web-ui)
6. [セキュリティとベストプラクティス](#security--best-practices)
7. [トラブルシューティング](#troubleshooting)
8. [ライセンス](#license)
9. [貢献](#contributing)
10. [サポートとフィードバック](#support--feedback)

---

## 🔹 概要

このセットアップは**qBittorrentがProtonVPN（WireGuard）経由のみで接続する**ことを保証し、**Gluetun**を用いてリークを防ぎセキュリティを強化します。\
さらに、**ポートフォワーディングを自動化**してトレント速度を向上させ、**すべてをDocker内で実行**することで管理を簡単にします。

---

## ✅ 特徴

- **🔒 VPN強制トレント** – リークなし、すべての通信がVPN内で実行されます。
- **⚡ 自動ポートフォワーディング** – 速度向上とピア接続の改善を保証します。
- **🌐 ローカルWeb UIアクセス** – [`http://localhost:8080`](http://localhost:8080)から簡単にトレントを管理可能。
- **📺 完全コンテナ化** – Dockerを使用して簡単にデプロイ、更新、および分離を実現。
- **🔄 耐障害性のあるセットアップ** – 何かがクラッシュした場合、コンテナは**自動再起動**します。
- 不完全および完了したトレント用に**別々のストレージ**を使用。
- **Watchtowerを使ったコンテナの自動更新** 🛠️

---

## 🛠️ 前提条件

- **Docker Desktop**（macOS/Windows/Linux）
- **Docker Compose**（Docker Desktopに同梱）
- **ProtonVPNアカウント**（WireGuardサポートにはPlusまたはVisionaryが必要）

---

## 📂 インストールガイド

### **1️⃣ Dockerのインストール**

[こちら](https://www.docker.com/products/docker-desktop/)から**Docker Desktop**をダウンロードしてインストールしてください。\
続行する前にDockerが**起動している**ことを確認してください。

---

### **2️⃣ リポジトリをクローン**

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ **`.env`** ファイルの設定**

このプロジェクトでは、**機密設定値**を保存するために `.env` ファイルを使用します（セキュリティのためGitによって無視されます）。

#### **あなたの **`.env`** ファイルを作成する**

```sh
cp .env.example .env
nano .env
```

#### **以下の変数を入力してください**

```ini
WIREGUARD_PRIVATE_KEY=your_private_key_here
SERVER_COUNTRIES="United Kingdom"
SERVER_CITIES="London"

PUID=1000
PGID=1000
TZ=Europe/London

GLUETUN_USER=your_admin_username
GLUETUN_PASS=your_admin_password

GSP_GTN_API_KEY=your_random_api_key_here
GSP_QBITTORRENT_PORT=your_forwarded_port_here
```

Save and close (`CTRL + X`, then `Y`, then `ENTER`).

---

### **4️⃣ Start the Containers**

```sh
docker-compose up -d
```

🚀 **qBittorrentはProtonVPNを通じて安全に稼働中です！**

---

## 📚 qBittorrent Web UIへのアクセス

起動後、以下を開いてください：\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(デフォルトのユーザー名：admin、パスワード：コンソールで一時パスワードを確認)*

初回ログイン後は必ずWeb UIのパスワードを変更してください。そうしないと、コンテナ再起動ごとにパスワードがランダム生成されます。

---

## 🛡️ セキュリティとベストプラクティス

1. **`.env`を非公開に保つこと**

   - `.gitignore`ファイルは**すでに `.env` がGitHubにアップロードされるのを防いでいます。**

2. **Gluetun APIには強力なパスワードを使用する**

   - **`.env`内の `GLUETUN_PASS` を変更し、無許可のAPIアクセスを防ぎましょう。**

3. **トレントを始める前にVPN接続を確認する**

   - コンテナ内で `curl ifconfig.me` を実行してください：
     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **IPがProtonVPNと一致する場合、正常に動作しています。**
   - ❌ **実際のIPが表示される場合は、問題があります。**

---

## 🛠️ トラブルシューティング

### **VPNが動作しているか確認する**

```sh
docker ps
```

もしGluetunが起動していない場合は、すべてを再起動してください：

```sh
docker-compose down && docker-compose up -d
```

### **qBittorrentがVPNを使用していることを確認する**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 IPがProtonVPNと一致していれば、正常に動作しています。\
🔴 実際のIPが表示されている場合は、何か問題があります。

### **エラーログの確認**

```sh
docker logs -f gluetun
```

**AUTH_FAILED** または接続の問題を探してください。

---

## 💎 ライセンス

このプロジェクトは **MITライセンス** の下でライセンスされています。詳細は LICENSE ファイルをご覧ください。

---

## 💪 貢献

貢献は歓迎します！改善点やフィードバックがあれば、Issue またはプルリクエストを送ってください。

---

## 💬 サポート＆フィードバック

- 役に立った場合は、GitHubで⭐スターを付けてください！
- フィードバックや提案はいつでも歓迎します。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---