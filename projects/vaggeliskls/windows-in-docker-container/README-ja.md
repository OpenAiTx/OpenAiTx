# 💻 Dockerコンテナ内のWindows
Vagrant VM、libvirt、docker-composeの力を利用して、Linuxシステム上でWindows OS（x64）を展開する革新的かつ効率的な方法を発見しましょう。これらの技術を組み合わせることで、Windows OSをコンテナ化し、まるでDockerコンテナを管理するかのようにWindowsインスタンスを管理できます。このシームレスな統合は既存のワークフローに大きな利便性をもたらし、リソース配分を最適化します。

⭐ **役立ったらぜひプロジェクトにスターを付けてください！**

## 📋 前提条件

システムが以下の要件を満たしていることを確認してください：

- **Docker:** バージョン20以上 [(Dockerのインストール)](https://www.docker.com/)

- **ホストOS:** Linux

- **仮想化が有効:**
  - 以下で確認:
    - `lscpu | grep -i Virtualization`
  - 出力が示す内容:
    - `VT-x` → Intel仮想化がサポートかつ有効。
    - `AMD-V` → AMD仮想化がサポートかつ有効。
  - 仮想化が有効でない場合は、BIOS/UEFI設定で有効にしてください。

- **composeファイルに`cgroup: host`が必要:** libvirtおよびそれが起動するデーモンは完全なcgroupアクセスを必要とします。さもなければcgroup v2ホスト上でコンテナが起動に失敗します。

## 🚀 展開ガイド

1. 環境ファイル `.env` を作成／更新してください。
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. `docker-compose.yml` を作成する
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. VMを永続化したい場合は、`docker-compose.override.yml`を作成してください
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. Run: `docker compose up -d`

> **初回起動には数分かかります** — Vagrantボックスは既にイメージに組み込まれていますが、VMはまだ起動してプロビジョニングスクリプト（Chocolateyのインストール、ディスクのリサイズ、レジストリの調整）を実行する必要があります。進行状況は `docker compose logs -f` で確認してください。

> すべてを破棄したい場合は `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 アクセス  

### リモートデスクトップ (RDP)  
デバッグやテストのために、ポート `3389` で**リモートデスクトップ**を使ってVMに接続できます。  

#### リモートデスクトップアクセス用ソフトウェア  
| OS       | ソフトウェア |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` または [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | 標準の **リモートデスクトップ接続** |

---

### SSH   
**administrator** または **Vagrant** ユーザーの資格情報を使ってSSHで接続できます。  

```bash
ssh <user>@<host> -p 2222
```
## 🔑 ユーザーログイン
Vagrantイメージに基づくデフォルトユーザーは以下の通りです：

1. 管理者
    - ユーザー名: Administrator
    - パスワード: vagrant
2. ユーザー
    - ユーザー名: vagrant
    - パスワード: vagrant

## ⚠️ 制限事項

- **Linuxホストのみ** — `/dev/kvm` と libvirt に依存しています。macOSやWindowsホストはサポートされていません。
- **評価版ライセンス** — ベースボックスはWindows Server 2022の評価版を搭載しています。アクティベーションはMicrosoftの評価版利用規約に従い期限切れになります。
- **同期フォルダなし** — `rsync`、`smb`、`nfs` はすべて[Vagrantfile](Vagrantfile)で無効化されています（rsyncはプロビジョニング前にWindows側でのインストールが必要；LinuxホストではSMB同期フォルダはサポートされません；コンテナ内NFSは「現在のカーネルでサポートされていません」エラーが発生します）。
- **パフォーマンス** — DockerでネストされたKVMが利用できない場合（例：KVMを公開しないクラウドVM）、ゲストは通常のQEMUにフォールバックし、数倍遅くなります。

## 🔧 トラブルシューティング

- **ログに「KVM acceleration is not available」** → ホストが`/dev/kvm`を公開していません。BIOSで仮想化が有効か、`kvm`モジュールがロードされているか（`lsmod | grep kvm`）、ホストに`/dev/kvm`が存在するか確認してください。起動スクリプトは自動的にQEMUにフォールバックしますが、大幅な遅延が発生します。
- **ポート3389 / 2222が既に使用中** → ホスト上で別のRDP/SSHサービスがバインドされています。停止するか、`docker-compose.yml`のホスト側ポートマッピングを変更してください。
- **コンテナが即時終了する** → ほぼ確実にcgroupや権限の問題です。`privileged: true`と`cgroup: host`が設定されていることを確認し、`docker compose logs win10`でログをチェックしてください。
- **`vagrant up`が「Waiting for domain to get an IP address」で停止する** → libvirtのデフォルトNATネットワークが動作していません。コンテナを再起動するか、中で`virsh net-start default`を実行してください。

## 📚 さらに読むべき資料とリソース

- [Windows Vagrant チュートリアル](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrantイメージ: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorpのVagrant](https://www.vagrantup.com/)
- [Linux Dockerコンテナ内でのWindows仮想マシン](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [コンテナ内のGPU](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---