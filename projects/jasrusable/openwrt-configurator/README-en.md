# OpenWrt Configurator

OpenWrt Configurator is a CLI tool and corresponding JSON config file which lets you specify the entire state of your network including UCI configuration, packages and firmware versions in a single UCI-like JSON config file which can be provisioned to your OpenWrt devices using OpenWrt Configurator.

```sh
$ openwrt-configurator provision ./network-config.json
```
The JSON config file can be conditionally composed with `.if` and/or `.overrides` keys, and implements light abstractions over device ethernet ports and Wi-Fi radios to seamlessly support configuration for multiple devices, different device models/types, as well as different device roles (Router, switch, dump-ap etc) from a single JSON config file.


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

## Features

- Store all network config for all devices in a single UCI-like JSON config file (UCI config, packages, firmware versions and more).
- Conditionally compose your JSON file to support multiple OpenWrt devices, different device models/types, and different roles (Routers, switches and dump-ap's etc).
- Light abstractions over ethernet ports and WiFi radios to keep multi-device configuration simple.
- Strict config syntax validation and logical error checking for configuration to prevent invalid configuration.
- Convert your JSON file into UCI commands for each of your OpenWrt devices.
- Provision your JSON file to your OpenWrt devices.
- JSON file migrations to keep your JSON file up-to-date with any UCI configuration changes/updates.
- Build and flash sysupgrade images to your OpenWrt devices based on your JSON config file.

## Getting started

1. Download OpenWrt Configurator from the [GitHub Releases page](https://github.com/jasrusable/openwrt-configurator/releases).

2. Download a [sample configuration file](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs).

3. Adjust your configuration file as needed.

4. Print and inspect your device UCI commands.

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

> Note: For this command to work, SSH details need to be correctly configured in the `provisioning_config` sections for each of your devices.

5. Provision configuration to your devices (Implemented with SSH).

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

> Note: For this command to work, SSH details need to be correctly configured in the `provisioning_config` sections for each of your devices.

## How it works

1. Add your devices to the JSON config file.

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
2. Specify which packages you want installed or uninstalled on your devices.


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

3. Specify your UCI configuration in JSON, and add `.if` and/or `.overrides` keys to apply configuration conditionally.

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

## Roadmap

### Short-term

- Improve README.md and add more documentation.
- Add more configuration validation and error checking.
- Improve error handling and messages.
- Add more sample configurations.
- Support firmware building and flashing.

### Long-term

- Configuration migrations.
- Reduce CLI executable size.
- Web UI for building configuration.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---