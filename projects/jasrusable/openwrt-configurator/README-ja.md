# OpenWrt コンフィギュレーター

OpenWrt コンフィギュレーターはCLIツールおよび対応するJSON設定ファイルで、UCI設定、パッケージ、ファームウェアのバージョンを含むネットワーク全体の状態を単一のUCIライクなJSON設定ファイルで指定でき、OpenWrt コンフィギュレーターを使用してOpenWrtデバイスにプロビジョニングできます。

```sh
$ openwrt-configurator provision ./network-config.json
```
JSON構成ファイルは `.if` および/または `.overrides` キーを使用して条件付きで構成でき、デバイスのイーサネットポートやWi-Fiラジオに対して軽量の抽象化を実装し、複数のデバイス、異なるデバイスモデル/タイプ、および異なるデバイスの役割（ルーター、スイッチ、ダンプAPなど）を単一のJSON構成ファイルからシームレスにサポートします。


```json
  "interface": [
    {
      ".if": "device.tag.role == 'router'", // Apply the pppoe interface to only the router.
      ".name": "wan",
      "device": "eth0",
      "proto": "pppoe",
      "username": "me@pppoe.com",
      "password": "123"
    },
    {
      ".name": "lan",
      "device": "br-lan.1",
      ".overrides": [
        {
          ".if": "device.tag.role == 'router'", // Apply a static ip to only the router.
          "override": {
            "proto": "static",
            "ipaddr": "10.0.0.1",
            "netmask": "255.255.0.0"
          }
        },
        {
          ".if": "device.tag.role != 'router'", // Apply dhcp to all non-router devices.
          "override": {
            "proto": "dhcp"
          }
        }
      ]
    },
  ]
```
## 特徴

- すべてのデバイスのネットワーク設定を単一のUCI風JSON設定ファイルに保存（UCI設定、パッケージ、ファームウェアバージョンなど）。
- 条件付きでJSONファイルを作成し、複数のOpenWrtデバイス、異なるデバイスモデル/タイプ、異なる役割（ルーター、スイッチ、ダンプAPなど）をサポート。
- 複数デバイスの設定を簡単にするためのイーサネットポートとWiFiラジオの軽量抽象化。
- 無効な設定を防ぐための厳格な設定構文検証と論理的エラーチェック。
- JSONファイルを各OpenWrtデバイス用のUCIコマンドに変換。
- JSONファイルをOpenWrtデバイスにプロビジョニング。
- UCI設定の変更/更新に対応するJSONファイルのマイグレーション。
- JSON設定ファイルに基づいたsysupgradeイメージのビルドとOpenWrtデバイスへのフラッシュ。

## はじめに

1. [GitHubリリースページ](https://github.com/jasrusable/openwrt-configurator/releases)からOpenWrt Configuratorをダウンロード。

2. [サンプル設定ファイル](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs)をダウンロード。

3. 必要に応じて設定ファイルを調整。

4. デバイスのUCIコマンドを表示して確認。


```sh
$ openwrt-configurator print-uci-commands ./network-config.json
# device my-ap
apk del --rdepends firewall firewall4
uci set system.system0=system
uci set system.system0.hostname='my-ap'
uci set system.system0.timezone='Africa/Johannesburg'
uci set network.switch0=switch
uci set network.switch0.name='switch0'
uci set network.switch0.reset='1'
uci set network.switch0.enable_vlan='1'
...
```

> 注：このコマンドを機能させるためには、各デバイスの `provisioning_config` セクションにSSHの詳細が正しく設定されている必要があります。

5. デバイスへの構成プロビジョニング（SSHを使用して実装）。

```sh
$ openwrt-configurator provision ./network-config.json
Provisioning device "my-ap" @ root@10.0.0.218
Connecting over SSH...
Connected.
Verifying device...
Verified.
Setting configuration...
Configuration set.
Provisioning completed.
...
```

> 注意: このコマンドを機能させるには、各デバイスの `provisioning_config` セクションにSSH情報が正しく設定されている必要があります。

## 仕組み

1. JSON設定ファイルにデバイスを追加します。

```json
  "devices": [
    {
      "model_id": "ubnt,edgerouter-x",
      "ipaddr": "10.0.0.1",
      "tags": { "role": "router" }, // Give the Edgerouter a tag with role of "router".
      "hostname": "my-router",
      "provisioning_config": {
        "ssh_auth": {
          "username": "root",
          "password": "123"
        }
      }
    },
    {
      "model_id": "tplink,eap245-v3",
      "ipaddr": "10.0.0.218",
      "tags": { "role": "ap" }, // Give the EAP245 a tag with role of "ap".
      "hostname": "my-ap",
      "provisioning_config": {
        "ssh_auth": {
          "username": "root",
          "password": "123"
        }
      }
    }
  ],
```
2. デバイスにインストールまたはアンインストールしたいパッケージを指定します。


```json
  "package_profiles": [
    {
      ".if": "device.tag.role == 'router'", // Install sqm and https-dns-proxy on the router.
      "packages": [
        "sqm-scripts",
        "luci-app-sqm",
        "https-dns-proxy",
        "luci-app-https-dns-proxy"
      ]
    },
    {
      ".if": "device.tag.role == 'ap'", // Uninstall firewall packages from ap's.
      "packages": ["-firewall", "-firewall4"]
    }
  ],
```

3. JSONでUCI設定を指定し、条件付きで設定を適用するために `.if` および/または `.overrides` キーを追加します。

```json
  "config": {
    "dropbear": {
      "dropbear": [
        {
          "PasswordAuth": "on",
          "RootPasswordAuth": "on",
          "Port": 22,
          "BannerFile": "/etc/banner"
        }
      ]
    },
    "system": {
      "system": [
        {
          "timezone": "Africa/Johannesburg"
        }
      ]
    },
    "interface": [
      {
        ".name": "loopback",
        "device": "lo",
        "proto": "static",
        "ipaddr": "127.0.0.1",
        "netmask": "255.0.0.0"
      },
      {
        ".if": "device.tag.role == 'router'", // Apply the pppoe interface to only the router.
        ".name": "wan",
        "device": "eth0",
        "proto": "pppoe",
        "username": "me@pppoe.com",
        "password": "123"
      },
      {
        ".name": "lan",
        "device": "br-lan.1",
        ".overrides": [
          {
            ".if": "device.tag.role == 'router'", // Apply a static ip to only the router.
            "override": {
              "proto": "static",
              "ipaddr": "10.0.0.1",
              "netmask": "255.255.0.0"
            }
          },
          {
            ".if": "device.tag.role != 'router'", // Apply dhcp to all non-router devices.
            "override": {
              "proto": "dhcp"
            }
          }
        ]
      }
    ],
    "wireless": {
      ".if": "device.tag.role == 'ap'", // Applies the entire "wireless" object to only devices with the "ap" tag set.
      "wifi-device": [
        {
          ".name": "radio0",
          "band": "2g"
        },
        {
          ".name": "radio1",
          "band": "5g"
        }
      ],
      "wifi-iface": [
        {
          "mode": "ap",
          "device": ["radio0", "radio1"],
          "network": "lan",
          "ssid": "my-ssid",
          "encryption": "psk2",
          "key": "123456789"
        },
        {
          "mode": "ap",
          "device": ["radio0", "radio1"],
          "network": "guest",
          "ssid": "my-ssid-guest",
          "encryption": "none"
        }
      ]
    }
  }
```

## ロードマップ

### 短期的

- README.md を改善し、ドキュメントを増やす。
- さらに多くの設定検証とエラーチェックを追加する。
- エラーハンドリングとメッセージを改善する。
- さらに多くのサンプル設定を追加する。
- ファームウェアのビルドとフラッシュをサポートする。

### 長期的

- 設定のマイグレーション。
- CLI実行ファイルのサイズを削減する。
- 設定構築のためのWeb UI。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---