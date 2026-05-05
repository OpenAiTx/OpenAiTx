# Configurador OpenWrt

Configurador OpenWrt es una herramienta CLI y un archivo de configuración JSON correspondiente que le permite especificar todo el estado de su red, incluida la configuración UCI, paquetes y versiones de firmware en un solo archivo de configuración JSON similar a UCI que puede ser aprovisionado a sus dispositivos OpenWrt usando Configurador OpenWrt.

```sh
$ openwrt-configurator provision ./network-config.json
```

El archivo de configuración JSON puede componerse condicionalmente con claves `.if` y/o `.overrides`, e implementa abstracciones ligeras sobre los puertos Ethernet del dispositivo y radios Wi-Fi para soportar sin problemas la configuración para múltiples dispositivos, diferentes modelos/tipos de dispositivos, así como diferentes roles de dispositivos (Router, switch, dump-ap, etc.) desde un único archivo de configuración JSON.

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
## Características

- Almacena toda la configuración de red para todos los dispositivos en un solo archivo de configuración JSON tipo UCI (configuración UCI, paquetes, versiones de firmware y más).
- Composición condicional de tu archivo JSON para soportar múltiples dispositivos OpenWrt, diferentes modelos/tipos de dispositivos y diferentes roles (routers, switches y dump-ap's, etc.).
- Abstracciones ligeras sobre puertos ethernet y radios WiFi para mantener la configuración de múltiples dispositivos simple.
- Validación estricta de la sintaxis de configuración y verificación lógica de errores para evitar configuraciones inválidas.
- Convierte tu archivo JSON en comandos UCI para cada uno de tus dispositivos OpenWrt.
- Provisiona tu archivo JSON a tus dispositivos OpenWrt.
- Migraciones de archivos JSON para mantener tu archivo JSON actualizado con cualquier cambio/actualización de configuración UCI.
- Construye y flashea imágenes sysupgrade a tus dispositivos OpenWrt basadas en tu archivo de configuración JSON.

## Primeros pasos

1. Descarga OpenWrt Configurator desde la [página de lanzamientos de GitHub](https://github.com/jasrusable/openwrt-configurator/releases).

2. Descarga un [archivo de configuración de ejemplo](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs).

3. Ajusta tu archivo de configuración según sea necesario.

4. Imprime e inspecciona los comandos UCI de tu dispositivo.


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

> Nota: Para que este comando funcione, los detalles de SSH deben estar configurados correctamente en las secciones `provisioning_config` de cada uno de sus dispositivos.

5. Provisionar la configuración a sus dispositivos (Implementado con SSH).

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

> Nota: Para que este comando funcione, los detalles de SSH deben estar correctamente configurados en las secciones `provisioning_config` de cada uno de tus dispositivos.

## Cómo funciona

1. Agrega tus dispositivos al archivo de configuración JSON.

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
2. Especifique qué paquetes desea instalar o desinstalar en sus dispositivos.


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
3. Especifique su configuración UCI en JSON y agregue las claves `.if` y/o `.overrides` para aplicar la configuración de forma condicional.


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

## Hoja de ruta

### Corto plazo

- Mejorar README.md y añadir más documentación.
- Añadir más validación de configuración y comprobación de errores.
- Mejorar el manejo de errores y los mensajes.
- Añadir más configuraciones de ejemplo.
- Soportar la compilación y carga del firmware.

### Largo plazo

- Migraciones de configuración.
- Reducir el tamaño del ejecutable CLI.
- Interfaz web para construir la configuración.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---