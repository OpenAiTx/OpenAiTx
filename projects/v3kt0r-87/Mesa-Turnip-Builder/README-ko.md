# Freedreno Turnip Builder 

## Stable / RC Mesa  + Android NDK <br> 안정성을 위해 이 빌드를 사용하세요 ✅ 

간단한 Bash 스크립트로, **MAGISK/KERNELSU 또는 에뮬레이터용** turnip 드라이버를 빌드하는 것을 목표로 합니다.

# 새로운 점 : 🔥

**[여기를 클릭하세요](//github.com/v3kt0r-87/Mesa-Turnip-Builder/blob/main/UPDATES.md)**
 
## 로컬에서 빌드하는 방법 🤔

이 저장소를 클론하고 **BASH**를 사용하여 빌드하면 됩니다. 

``` 
bash build-turnip.sh
``` 
[노트](//github.com/v3kt0r-87/Mesa-Turnip-Builder?tab=readme-ov-file#notes-) 섹션에서 자세한 정보를 확인하세요

# 앱 호환성

| 이름                                            | 상태   | 노트                                                                                                                     |
|-------------------------------------------------|--------|--------------------------------------------------------------------------------------------------------------------------|
| 3D Mark                                         | ✅     |                                                                                                                          |
| GRID™ Autosport                                 | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함.(60fps)                                                           |
| SpongeBob SquarePants Battle For Bikini Bottom  | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함,(30 - 45 fps)                                                     |
| Carx Street                                     | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함,(30 - 45 fps)                                                     |
| Dolphin Emulator                                | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함.                                                                  |
| PPSSPP                                          | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함.                                                                  |
| EggNS                                           | ✅     | [V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함.                                                                  |
| ANGLE (com.android.angle)                       | ✅     |                                                                                                                          |
| GTA Triology-Definitive Edition                 | ✅     | [@Ryder_7777](//t.me/Ryder_7777) 테스트<br>작동함, 성능 저하.                                                          |
| Call of Duty WarZone Mobile                     | ✅     | [@SeniorFurry](//t.me/SeniorFurry) 테스트<br>작동함, 텍스처 버그, 성능 저하.                                           |
| Hitman Blood Money : Reprisal                   | ✅     | [@V3KT0R-87](//github.com/V3KT0R-87) 테스트<br>작동함, 60 fps 중간 그래픽.                                            |


### 노트 :

### 중요 : 완전한 Vulkan 1.4 지원을 위해 Android 15 (SDK 35)가 필요합니다

## Ubuntu 24.04 또는 이 기반의 다른 배포판을 사용하세요

**진행하기 전에 안정적인 인터넷 연결을 확인하세요**

**ISP가 속도를 제한할 경우 VPN을 사용하세요**

Android 버전이 ``14`` 이상인지 확인하세요. 그렇지 않으면 설치할 수 없습니다

설치 전에 최신 **MAGISK / KERNELSU**가 있는지 확인하세요


# 크레딧 🙏

### 이 프로젝트는 아래 훌륭한 분들의 도움 없이는 불가능했습니다 :
 
 **[@MrMiy4mo](//github.com/ilhan-athn7)** 터닙 빌드 스크립트를 만들고 제가 수정하고 배울 수 있게 해주셔서 감사합니다.

 
 **[@Mesa3D 팀](//gitlab.freedesktop.org/mesa/mesa)**에게 놀라운 드라이버를 제공해 주셔서 감사드리며, 이를 통해 저희 장치 성능을 더욱 향상시킬 수 있었습니다.

 **[Adreno 드라이버 지원 그룹](//t.me/adreno_driver)**에게 테스트 및 벤치마크 공유에 감사드립니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---