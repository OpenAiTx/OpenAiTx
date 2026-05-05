# OpenWrt 구성 도구

OpenWrt 구성 도구는 CLI 도구이자 해당 JSON 구성 파일로, UCI 구성, 패키지 및 펌웨어 버전을 포함한 네트워크 전체 상태를 단일 UCI 유사 JSON 구성 파일로 지정할 수 있으며, OpenWrt 구성 도구를 사용하여 OpenWrt 장치에 프로비저닝할 수 있습니다.

```sh
$ openwrt-configurator provision ./network-config.json
```
JSON 구성 파일은 `.if` 및/또는 `.overrides` 키를 사용하여 조건부로 구성할 수 있으며, 장치 이더넷 포트 및 Wi-Fi 라디오에 대한 경량 추상화를 구현하여 단일 JSON 구성 파일에서 여러 장치, 서로 다른 장치 모델/유형 및 서로 다른 장치 역할(라우터, 스위치, 덤프-AP 등)에 대한 구성을 원활하게 지원합니다.


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
## 기능

- 모든 장치의 네트워크 구성을 단일 UCI 유사 JSON 구성 파일에 저장 (UCI 구성, 패키지, 펌웨어 버전 등 포함).
- 조건부로 JSON 파일을 구성하여 여러 OpenWrt 장치, 다양한 장치 모델/유형, 및 다양한 역할(라우터, 스위치, 덤프 AP 등)을 지원.
- 다중 장치 구성을 간단하게 유지하기 위한 이더넷 포트 및 WiFi 라디오에 대한 경량 추상화.
- 잘못된 구성을 방지하기 위한 엄격한 구성 구문 검증 및 논리 오류 검사.
- JSON 파일을 각 OpenWrt 장치용 UCI 명령으로 변환.
- JSON 파일을 OpenWrt 장치에 프로비저닝.
- UCI 구성 변경/업데이트에 맞춰 JSON 파일을 최신 상태로 유지하기 위한 JSON 파일 마이그레이션.
- JSON 구성 파일을 기반으로 OpenWrt 장치에 sysupgrade 이미지 빌드 및 플래시.

## 시작하기

1. [GitHub 릴리즈 페이지](https://github.com/jasrusable/openwrt-configurator/releases)에서 OpenWrt Configurator 다운로드.

2. [샘플 구성 파일](https://github.com/jasrusable/openwrt-configurator/tree/main/sampleConfigs) 다운로드.

3. 필요에 따라 구성 파일 조정.

4. 장치 UCI 명령 출력 및 검사.


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
> 참고: 이 명령이 작동하려면 각 장치의 `provisioning_config` 섹션에 SSH 세부 정보가 올바르게 구성되어 있어야 합니다.

5. 장치에 구성 프로비저닝 (SSH로 구현).


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
> 참고: 이 명령이 작동하려면 각 장치의 `provisioning_config` 섹션에 SSH 정보가 올바르게 구성되어 있어야 합니다.

## 작동 방식

1. JSON 구성 파일에 장치를 추가합니다.


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

2. 장치에 설치하거나 제거하려는 패키지를 지정하십시오.

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

3. JSON 형식으로 UCI 구성을 지정하고, 조건부로 구성을 적용하기 위해 `.if` 및/또는 `.overrides` 키를 추가하세요.

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
## 로드맵

### 단기

- README.md 개선 및 문서 추가.
- 구성 유효성 검사 및 오류 검증 추가.
- 오류 처리 및 메시지 개선.
- 샘플 구성 추가.
- 펌웨어 빌드 및 플래싱 지원.

### 장기

- 구성 마이그레이션.
- CLI 실행 파일 크기 축소.
- 구성 빌드를 위한 웹 UI.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-05

---