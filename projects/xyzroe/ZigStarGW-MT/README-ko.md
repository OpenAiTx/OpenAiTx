# ZigStar GW 다중 도구
[![Build](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml/badge.svg)](https://github.com/xyzroe/ZigStarGW-MT/actions/workflows/build.yml)
[![GitHub version](https://img.shields.io/github/release/xyzroe/ZigStarGW-MT.svg)](https://github.com/xyzroe/ZigStarGW-MT/releases)
[![GitHub download](https://img.shields.io/github/downloads/xyzroe/ZigStarGW-MT/total.svg)](https://github.com/xyzroe/ZigStarGW-MT/latest)
[![License](https://img.shields.io/github/license/xyzroe/ZigStarGW-MT.svg)](LICENSE.txt)


> ⚠️ **보관됨 / 유지보수 중단**
>
> 이 프로젝트는 현재 보관 상태이며 추가 업데이트를 받지 않습니다.
> 
> 향상된 기능과 지속적인 지원을 제공하는 새로운 웹 기반 도구 [XZG Multi-Tool](https://github.com/xyzroe/XZG-MT)을 사용해 보시길 권장합니다. 🚀

  
이 GUI 래퍼는 처음에 Zig Star LAN GW와의 편리한 서비스 작업을 위해 설계되었으나  
현재는 제조사에 관계없이 TI CC1352/CC2538/CC2652 기반의 Zigbee 스틱 또는 게이트웨이를 지원합니다. 

다중 도구는 단일 실행 파일로 패키징되어 있습니다.  
Python 및 필요한 모듈 설치나 터미널 사용 없이 바로 다운로드 후 실행하여 시작할 수 있습니다.

## 기능:
- Zigbee 모듈의 NVRAM 메모리 읽기 / 쓰기 / 지우기
- Zigbee 모듈의 펌웨어 쓰기 / 검증 / 지우기
- 백도어 시리얼 로더가 자동으로 활성화됨
- Zigbee 모듈 또는 ESP32의 수동 재시작 가능

#### 스크린샷

<table>
<tr> 
<td width="50%">

##### 윈도우
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/win.png">
</td>
<td>

##### OS X
<img src="https://github.com/xyzroe/ZigStarGW-MT/raw/main/images/osx.png">
</td>
</tr>
</table>

## 지침:
### 1. 포트 식별
#### 네트워크 게이트웨이:
ZigStar LAN GW를 사용하는 경우 IP 주소가 자동으로 감지되며, 그렇지 않으면 게이트웨이의 IP:PORT를 입력하십시오.
#### USB 스틱:
업데이트 버튼을 클릭하여 USB 드라이브를 식별하고 드롭다운 목록에서 장치를 선택하십시오.
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-1.png"></div>


### 2.A 펌웨어 업데이트
- 디스크에서 펌웨어 *.hex 파일을 선택하십시오.
- 필요한 옵션을 선택하십시오. 보통은 지우기, 쓰기 및 확인입니다.
- IEEE 주소를 변경해야 하는 경우 입력하고 Write IEEE 체크박스를 설정하십시오.
- 선택한 프로세스를 시작하려면 "Start" 버튼을 누르십시오.

멀티툴 오른쪽에서 어떤 작업이 수행되면 기본 IEEE 주소가 해당 필드에 입력됩니다. (수동 입력하거나 이전에 읽은 주소를 대체)

*ZigStar가 아닌 게이트웨이나 USB 스틱의 경우 BSL을 수동으로 활성화해야 할 수 있습니다.  
또한, ZigStar가 아닌 게이트웨이를 사용하는 경우 Auto-BSL 체크박스를 해제해야 합니다.*
<br>  
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-2.png"></div>


### 2.B NVRAM 도구
Zigbee 네트워크에 문제가 있는 경우 NVRAM 도구가 도움이 될 수 있습니다.

- **Read** 버튼은 현재 Zigbee 모듈의 NVRAM 상태를 *.json 파일로 디스크에 저장하여 나중에 복원할 수 있습니다.
- **Write** 버튼은 저장된 NVRAM 상태가 포함된 *.json 파일을 디스크에서 읽어 Zigbee 모듈에 씁니다.
- **Erase** 버튼은 새로운 설치를 위해 Zigbee 모듈의 NVRAM을 초기화합니다.
<div align="center"><img src="https://zig-star.com/images/radio-docs/multitool/multitool-3.png"></div>

### 마음에 드시나요? ♥️
[!["Buy Me A Coffee"](https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png)](https://www.buymeacoffee.com/xyzroe)


### 기반
[zigpy/zigpy-znp](https://github.com/zigpy/zigpy-znp)  
[JelmerT/cc2538-bsl](https://github.com/JelmerT/cc2538-bsl)  

  

<br>  

xyzroe/ZigStarGW-MT is licensed under the  
##### [GNU General Public License v3.0](https://github.com/xyzroe/ZigStarGW-MT/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---