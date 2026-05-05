# OpenWrt Configurator

OpenWrt Configurator est un outil CLI et un fichier de configuration JSON correspondant qui vous permet de spécifier l'état complet de votre réseau, y compris la configuration UCI, les paquets et les versions du firmware dans un seul fichier de configuration JSON de type UCI pouvant être déployé sur vos appareils OpenWrt à l'aide d'OpenWrt Configurator.

```sh
$ openwrt-configurator provision ./network-config.json
```

Le fichier de configuration JSON peut être composé de manière conditionnelle avec les clés `.if` et/ou `.overrides`, et implémente de légères abstractions sur les ports Ethernet des appareils et les radios Wi-Fi pour prendre en charge de manière transparente la configuration de plusieurs appareils, différents modèles/types d'appareils, ainsi que différents rôles d'appareils (routeur, commutateur, point d'accès dump, etc.) à partir d'un seul fichier de configuration JSON.

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
## Fonctionnalités

- Stockez toute la configuration réseau de tous les appareils dans un seul fichier de configuration JSON de type UCI (configuration UCI, paquets, versions du firmware et plus).
- Composez conditionnellement votre fichier JSON pour prendre en charge plusieurs appareils OpenWrt, différents modèles/types d'appareils, et différents rôles (routeurs, commutateurs et points d'accès dump, etc.).
- Abstractions légères sur les ports Ethernet et les radios WiFi pour garder la configuration multi-appareils simple.
- Validation stricte de la syntaxe de la configuration et vérification des erreurs logiques pour éviter une configuration invalide.
- Convertissez votre fichier JSON en commandes UCI pour chacun de vos appareils OpenWrt.
- Provisionnez votre fichier JSON sur vos appareils OpenWrt.
- Migrations de fichiers JSON pour maintenir votre fichier JSON à jour avec les changements/mises à jour de la configuration UCI.
- Construisez et flashez des images sysupgrade sur vos appareils OpenWrt basées sur votre fichier de configuration JSON.

## Pour commencer

1. Téléchargez OpenWrt Configurator depuis la [page des releases GitHub](https://github.com/jasrusable/openwrt-configurator/releases).

2. Téléchargez un [fichier de configuration exemple](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs).

3. Ajustez votre fichier de configuration selon vos besoins.

4. Imprimez et inspectez les commandes UCI de votre appareil.


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

> Remarque : Pour que cette commande fonctionne, les détails SSH doivent être correctement configurés dans les sections `provisioning_config` pour chacun de vos appareils.

5. Provisionnez la configuration sur vos appareils (implémenté avec SSH).

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

> Remarque : Pour que cette commande fonctionne, les détails SSH doivent être correctement configurés dans les sections `provisioning_config` pour chacun de vos appareils.

## Comment ça fonctionne

1. Ajoutez vos appareils dans le fichier de configuration JSON.

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

2. Spécifiez quels paquets vous souhaitez installer ou désinstaller sur vos appareils.

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
3. Spécifiez votre configuration UCI en JSON, et ajoutez les clés `.if` et/ou `.overrides` pour appliquer la configuration de manière conditionnelle.


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

## Feuille de route

### Court terme

- Améliorer le README.md et ajouter plus de documentation.
- Ajouter plus de validation de configuration et de vérification des erreurs.
- Améliorer la gestion des erreurs et les messages.
- Ajouter plus d’exemples de configurations.
- Supporter la compilation et le flashage du firmware.

### Long terme

- Migrations de configuration.
- Réduire la taille de l’exécutable CLI.
- Interface web pour la création de configuration.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---