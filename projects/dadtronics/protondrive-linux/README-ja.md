# rclone と systemd を使って Linux で Proton Drive をマウントする方法

このガイドは、Linux システムで [`rclone`](https://rclone.org/) と `systemd` を使って [Proton Drive](https://proton.me/drive) をマウントするプロセスを自動化します。

**Arch Linux** でテスト済みですが、ほとんどの Linux ディストリビューションで少しの調整で動作するはずです。

---

## 🔧 特徴

- `systemd --user` を通じてログイン時に Proton Drive をマウント
- 互換性のために `--vfs-cache-mode writes` オプションを使った `rclone`
- ロギング付きのバックグラウンドサービスを有効化
- `--allow-other` マウント用の FUSE サポートを追加

---

## 🚀 クイックスタート

### 1. ✅ 依存関係のインストール

#### `fuse3` のインストール（マウントに必要）：
```bash
sudo pacman -S fuse3
````

#### `rclone` をインストールする（バージョン v1.64.0 以降が必要）

🔹 **オプション1：事前にコンパイルされたバイナリを使用する（推奨）**

```bash
curl -O https://downloads.rclone.org/rclone-current-linux-amd64.zip
unzip rclone-current-linux-amd64.zip
cd rclone-*-linux-amd64
sudo cp rclone /usr/local/bin/
sudo chmod +x /usr/local/bin/rclone
```

検証:

```bash
rclone version
# Must be v1.64.0 or higher
```

---

### 2. 🔐 Configure Proton Drive Remote

Run:

```bash
rclone config
```

プロンプトに従ってください：

* `n` → 新しいリモート
* 名前：`proton`
* タイプ：`protondrive`
* プロンプトが表示されたらブラウザでログイン
* 承認して保存

---

### 3. 📜 セットアップスクリプトの実行

提供されたスクリプトを実行してください：

```bash
chmod +x setup-proton-mount.sh
./setup-proton-mount.sh
```
スクリプトは以下を実行します：

* マウントポイントを作成：`~/ProtonDrive`
* systemd ユーザーサービスを作成
* `/etc/fuse.conf` に `user_allow_other` を追加（存在しない場合）
* ユーザーを `fuse` グループに追加（必要に応じて）
* マウントサービスを有効化して起動

---

### 4. 🔁 再起動またはログアウト/ログイン

スクリプトがあなたを `fuse` グループに追加した場合、変更を反映させるために**ログアウトして再ログイン**する必要があります。

---

## 🔍 マウントの確認

Proton Drive がマウントされているか確認してください：


```bash
ls ~/ProtonDrive
```

systemdサービスを確認する:

```bash
systemctl --user status rclone-proton.mount.service
```

---

## 🔁 Remount

If unmounted the Proton Drive can be remounted by:

```bash
systemctl --user restart rclone-proton.mount.service
```

ログインするたびに Proton Drive が自動的にマウントされることに注意してください。

## 🧼 アンインストール

自動マウントの設定を解除するには：

```bash
systemctl --user disable --now rclone-proton.mount.service
rm ~/.config/systemd/user/rclone-proton.mount.service
```

(Optional) マウントポイントが不要になった場合は `~/ProtonDrive` を削除してください。

---

## 📁 ファイル

* `setup-proton-mount.sh` — 完全なセットアップスクリプト
* `~/.config/systemd/user/rclone-proton.mount.service` — systemdユニット
* `~/ProtonDrive` — マウント場所
* `~/.cache/rclone/rclone-proton.log` — ログ出力（任意）

---

## 📎 要件

* Proton Driveサポート付きの `rclone >= 1.64.0`
* `fuse3`
* Proton Driveアカウント

---

## 🛟 トラブルシューティング

マウントが動作しない場合：

```bash
journalctl --user -u rclone-proton.mount.service
```
サービスを手動で再起動するには：


```bash
systemctl --user restart rclone-proton.mount.service
```

---

## 📚 参考文献

* [rclone Proton Drive ドキュメント](https://rclone.org/protondrive/)
* [systemd ユーザーサービス](https://wiki.archlinux.org/title/Systemd/User)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---