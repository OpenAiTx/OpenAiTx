# Ansibleロール: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Debian系Linuxホスト上に[Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework)サーバーおよび/またはクライアント、さらにすべての[拡張機能](https://github.com/Adaptix-Framework/Extension-Kit)をインストールするAnsibleロールです。

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## 使用方法

デフォルトでは、サーバーはポート`4321`、エンドポイント`/endpoint`、パスワード`pass`でリッスンします。ユーザー名は任意です。これらの値はロール変数で変更できます（下記参照）。

クライアントマシンでは、`adaptixclient`コマンドを実行してGUIを起動し、上記の設定（変数で変更していない場合）でサーバーにログインしてください。

## 要件

なし。

## ロール変数

利用可能な変数は以下の通りです。デフォルト値（`defaults/main.yml`参照）も記載しています。

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # これ、または下記のいずれかをtrueにしないとロールは何もしません！
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # ここで-debugを使用できます
    ludus_adaptix_c2_go_version: 1.24.3
    # 以下の全てのオプションは、Adaptix GUIクライアントがサーバーに接続するためのものです。c2エージェント用ではありません。
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## 依存関係

なし。

## プレイブック例

```yaml
- hosts: adaptix_server_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_server: true

- hosts: adaptix_client_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_client: true    
```
## 例 Ludus レンジ構成

```yaml
ludus:
  - vm_name: "{{ range_id }}-adaptix-server"
    hostname: "{{ range_id }}-adaptix"
    template: debian-12-x64-server-template
    vlan: 99
    ip_last_octet: 1
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_server: true

  - vm_name: "{{ range_id }}-kali-1"
    hostname: "{{ range_id }}-kali-1"
    template: kali-x64-desktop-template
    vlan: 99
    ip_last_octet: 2
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_client: true
```
## ライセンス

GPLv3

## 作者情報

このロールは [Bad Sector Labs](https://github.com/badsectorlabs) によって作成され、[Ludus](https://ludus.cloud/) のためのものです。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---