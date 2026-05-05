# OpenWrt 配置器

OpenWrt 配置器是一个命令行工具及对应的 JSON 配置文件，允许您在单个类似 UCI 的 JSON 配置文件中指定整个网络状态，包括 UCI 配置、软件包和固件版本，并可使用 OpenWrt 配置器将其配置到您的 OpenWrt 设备上。

```sh
$ openwrt-configurator provision ./network-config.json
```
JSON 配置文件可以通过 `.if` 和/或 `.overrides` 键进行条件组合，并实现对设备以太网端口和 Wi-Fi 无线电的轻量抽象，从而无缝支持来自单个 JSON 配置文件的多设备、不同设备型号/类型以及不同设备角色（路由器、交换机、转发 AP 等）的配置。


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

## 功能特性

- 将所有设备的网络配置存储在单个类似 UCI 的 JSON 配置文件中（UCI 配置、软件包、固件版本等）。
- 有条件地组合您的 JSON 文件，以支持多个 OpenWrt 设备、不同设备型号/类型和不同角色（路由器、交换机和 dump-ap 等）。
- 对以太网端口和 WiFi 无线电进行轻量抽象，保持多设备配置简单。
- 对配置进行严格的语法验证和逻辑错误检查，防止无效配置。
- 将您的 JSON 文件转换为每个 OpenWrt 设备的 UCI 命令。
- 将您的 JSON 文件配置到 OpenWrt 设备中。
- JSON 文件迁移，保持您的 JSON 文件与任何 UCI 配置更改/更新同步。
- 基于您的 JSON 配置文件构建和刷写 sysupgrade 镜像到 OpenWrt 设备。

## 快速开始

1. 从 [GitHub Releases 页面](https://github.com/jasrusable/openwrt-configurator/releases) 下载 OpenWrt Configurator。

2. 下载一个 [示例配置文件](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs)。

3. 根据需要调整您的配置文件。

4. 打印并检查您的设备 UCI 命令。

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

> 注意：为了使该命令生效，需要在每个设备的 `provisioning_config` 部分正确配置 SSH 详情。

5. 将配置部署到您的设备（通过 SSH 实现）。

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

> 注意：要使此命令工作，必须在每个设备的 `provisioning_config` 部分正确配置 SSH 详细信息。

## 工作原理

1. 将您的设备添加到 JSON 配置文件中。

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
2. 指定您希望在设备上安装或卸载的包。


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

3. 在 JSON 中指定您的 UCI 配置，并添加 `.if` 和/或 `.overrides` 键以有条件地应用配置。

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

## 路线图

### 短期

- 改进 README.md 并添加更多文档。
- 增加更多配置验证和错误检查。
- 改进错误处理和提示信息。
- 添加更多示例配置。
- 支持固件构建和刷写。

### 长期

- 配置迁移。
- 减小 CLI 可执行文件大小。
- 用于构建配置的 Web 界面。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---