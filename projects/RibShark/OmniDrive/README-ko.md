# OmniDrive
Copyright © 2026 Rib

## 설명
OmniDrive는 Hitachi-LG Data Storage에서 제조한 MediaTek MT1959 기반 광디스크 드라이브용 펌웨어 수정으로, 독점 게임 디스크를 포함한 디스크를 더 완벽하고 향상된 방식으로 읽을 수 있는 기능을 제공합니다.

## 기능
* CD/DVD/BD 및 파생 제품에 대한 리드인/리드아웃 읽기.
* CD/DVD/BD 및 파생 제품에 대한 원시 섹터 읽기 (CD는 섹터당 2352 바이트, DVD는 2064 바이트, BD는 2072 바이트).
* 디스크를 읽기 위한 맞춤형 READ DISC RAW 명령, FUA(캐시 우회), 원시 주소 지정(CD는 MSF, DVD/BD는 PSN), 및 디스크램블링(DVD/BD용) 플래그 포함.
* 다양한 독점 게임 디스크를 읽을 수 있는 기능(표 참조):

| 디스크 유형 | 지원 여부 | 비고 |
| ---: | :---: | --- |
| CD (ROM/R/RW) | ☑️ |
| DVD (ROM/RAM/±R/±RW) | ☑️ |
| BD (ROM/R/RE) | ☑️ |
| BD-XL (R/RE) | ☑️ |
| UHD-BD | ☑️ |
| PlayStation 3 BD-ROM | ☑️ | 디스크 내용이 암호화되어 있으며, 디스크 키는 복구 불가
| PlayStation 4 BD-ROM | ☑️ | 디스크 내용이 암호화되어 있으며, 디스크 키는 복구 불가
| PlayStation 5 BD-ROM | ☑️ | 디스크 내용이 암호화되어 있으며, 디스크 키는 복구 불가
| Xbox (XGD1) | ✅ |
| Xbox 360 (XGD2/XGD3) | ✅ |
| Xbox One/Series (XGD4) | ✅ | 디스크 내용이 암호화되어 있으며, 디스크 키는 복구 불가
| GameCube (NROM)/Wii (RVL-ROM) | ✅ |
| GameCube (NR)/Wii (RVT-R) | ❓ |
| Wii U (WUP-ROM?) | ⚠️ | 원시 데이터로 읽을 수 있으나, 스크램블 알고리즘은 현재 미확인 |
| Wii U (CAT-R) | ☑️ |
| Dreamcast (GD-ROM/GD-R) | ❎ | 저밀도 영역만 읽을 수 있음 |

키:
* ☑️ - 기본 지원 (패치된 펌웨어 없이)
* ✅ - OmniDrive로 지원
* ⚠️ - 부분 지원 (비고 참조)
* ❓ - 지원 여부 미확인 (테스트 필요)
* ❎ - 현재 지원하지 않음

## 빌드
### 의존성
* CMake  
* ninja  
* arm-none-eabi-gcc 툴체인  
* [armips](https://github.com/Kingcom/armips)  
* Python 3  
* pycryptodome  
### 설치 방법  
1. 순정 LG BU40N 1.00 및 ASUS BW-16D1HT 3.02 펌웨어 파일을 `firmware` 폴더에 넣으십시오. 파일 이름과 체크섬은 다음과 같아야 합니다:  

| 파일 이름 | CRC32 | MD5 | SHA-1 |  
| --- | --- | --- | --- |  
| HL-DT-ST_BD-RE_BU40N_1.00.bin | `E3C1A315` | `EDB28FCD7A239281ACE26A468D382A9C` | `9C48677B155154D24A3B95A32B4A29CA02FF40B3` |  
| ASUS_BW-16D1HT_3.02.bin | `84000B21` | `97F0EEABD0B675B4363B2C4749226016` | `F8DF5B579F25DA8D4E5AA5EF79F3005DAC5EB8C7` |  
2. `build` 폴더를 생성한 후, 해당 폴더에서 `cmake -G Ninja ..` 명령을 실행하십시오.  
3. `ninja` 명령을 실행하십시오. 패치된 펌웨어 파일은 `patched_firmware` 폴더에 생성됩니다.  

## 플래싱  
현재 권장되는 드라이브 플래싱 방법은 [MakeMKV](https://makemkv.com/)에 포함된 `sdftool`을 사용하는 것입니다. BU40N 펌웨어는 모든 슬림 드라이브에서, BW-16D1HT 펌웨어는 모든 데스크탑 드라이브에서 작동합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---