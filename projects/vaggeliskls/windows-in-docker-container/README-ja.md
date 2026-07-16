
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 DockerコンテナでWindowsを実行
Vagrant VM、libvirt、docker-composeの力を活用し、Linuxシステム上でWindows OS（x64）を効率的かつ革新的にデプロイする方法を紹介します。これらの技術を組み合わせることで、Windows OSをコンテナ化し、Dockerコンテナと同様にWindowsインスタンスを管理できるようになります。このシームレスな統合は、既存のワークフローへの利便性を大きく向上させ、リソースの最適化も実現します。

⭐ **プロジェクトが役立った場合は、スターを付けるのをお忘れなく！**

## 📋 前提条件

システムが以下の要件を満たしていることを確認してください。

- **Docker:** バージョン20以上 [(Dockerのインストール)](https://www.docker.com/)

- **ホストOS:** Linux

- **仮想化の有効化:**
  - 以下で確認:
    - `lscpu | grep -i Virtualization`
  - 出力例:
    - `VT-x` → Intelの仮想化がサポートされており有効です。
    - `AMD-V` → AMDの仮想化がサポートされており有効です。
  - 仮想化が有効でない場合は、BIOS/UEFI設定で有効にしてください。

- **composeファイルでの`cgroup: host`**が必須: libvirtおよびそのデーモンが完全なcgroupアクセスを必要とするため、cgroup v2ホストではコンテナが起動しません。

## 🚀 デプロイガイド

1. 環境ファイル`.env`を作成/更新する
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---