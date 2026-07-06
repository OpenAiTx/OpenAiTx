# 🎯 MT7902 드라이버를 MT7921 드라이버의 서브 파트로 사용 (✅ 작동 중)
Mediatek mt7902 wifi 6E 칩 블루투스 및 WiFi 지원

> [!IMPORTANT]
> 리눅스 7.1 커널이 MT7902 WIFI 6E 칩을 공식 지원합니다


## 📁 저장소 복제하기
저장소를 로컬 PC에 복제하세요
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
과거 이력을 복제하고 싶지 않다면
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
## 설치


### 🚀 설치 가이드 스크립트 (우분투 기반 시스템 권장)
스크립트가 실행 가능하지 않은 경우 실행 가능하도록 만드세요

```
chmod +x ./install_guide.sh
```
이제 이 스크립트를 실행하세요
```
./install_guide.sh
```
필요할 때 자동으로 비밀번호를 요청합니다
* 이 스크립트는 펌웨어, 블루투스 및 와이파이 드라이버를 하나씩 설치하도록 안내합니다
* 리눅스 7.0 커널이 탑재된 우분투에서 테스트됨

### 🚀 간편 자동 수정 (아치 기반 시스템에 권장)
최신 커널에서 WiFi 및 블루투스를 빠르게 수정하려면 다음 단계를 따르세요:

스크립트가 실행 가능하도록 설정하세요 (이미 설정되지 않은 경우)
```
chmod +x ./fix_my_wifi.sh
```

**sudo로 자동 수정 스크립트 실행**:
```bash
sudo bash fix_my_wifi.sh
```
#### 📖 이 스크립트가 하는 일:
* **의존성 확인:** `gcc`/`clang`, `make`, `bc`, 그리고 현재 `kernel-headers`가 설치되어 있는지 확인합니다. 없으면 선호하는 패키지 관리자로 설치합니다.
* **드라이버 컴파일:** 정확한 커널 버전에 맞춰 WiFi 및 Bluetooth 드라이버를 자동으로 빌드합니다.
* **영구적인 수정:** 컴퓨터를 재시작해도 WiFi가 활성 상태를 유지하도록 시스템 서비스를 설치합니다.
* **안전성:** 기본 시스템 파일을 변경하지 않도록 모듈을 커스텀 디렉터리(`/lib/modules/mt7902_custom`)에 설치합니다.

> [!NOTE]
> 필요한 빌드 도구(컴파일러, 리눅스 헤더 등)를 다운로드하려면 처음 실행 시 인터넷 연결(이더넷 또는 휴대폰 USB 테더링)이 필요합니다.


## ✅ 테스트 완료 (작동 확인됨)
이 수정 사항은 다음 환경에서 확인 및 작동이 검증되었습니다:

* **브랜드:** ASUS
* **모델:** Vivobook Go (E1404FA), Vivobook 14 (X1404ZA)
* **칩셋:** MediaTek MT7902 (WiFi 6E)
* **커널 버전:** 6.19.0 (Linux), 6.19.11, 7.0.7
* **운영체제:** Arch, Ubuntu
* **패키지 관리자:** pacman, apt

## 지원 대상:
* **운영체제:** PM(패키지 관리자)을 지원하는 모든 OS
* **선호 패키지 관리자:** apt, pacman, dnf, zypper, nix-shell
* **커널 버전:** 6.14-7.0.7


## 🔧 사용된 펌웨어
펌웨어는 `firmware` 폴더에 저장되어 있습니다.


## 📱 블루투스 ✅ (작동됨)
> [!WARNING]
> 블루투스 드라이버가 `gen4-mt7902`와 충돌하는 경우, 이 드라이버와 간섭하지 않도록 블루투스 펌웨어를 제거하세요.
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> 이 프로젝트는 다음 펌웨어를 사용합니다:
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

블루투스를 활성화하려면 현재 커널 버전 디렉터리로 이동하세요.  
예를 들어 커널이 linux-6.16이라면 `./linux-6.16/drivers/bluetooth` 디렉터리로 이동합니다.

이 디렉터리에서 터미널을 열고 `make` 명령어로 컴파일합니다.  
두 개의 커널 모듈 `btusb.ko`와 `btmtk.ko`가 컴파일됩니다.  
장치에서 블루투스를 활성화하려면 시스템에서 btusb와 btmtk를 제거하고 이 두 파일을 설치하십시오. 명령어는 다음과 같습니다.
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
이제 블루투스가 작동하는지 확인하세요.

## 💻 WiFi ✅ (작동 중)
> [!IMPORTANT]
> 일부 제한이 있는 작동하는 저장소는 [여기](https://github.com/hmtheboy154/gen4-mt7902)에 있습니다.

최근 미디어텍에서 출시한 mt7902용 WiFi 드라이버는 `latest` 폴더 안에 있습니다.

Ubuntu를 사용 중이라면 `latest` 폴더로 이동하여 터미널에서 다음 명령어를 실행하세요.
```
make
```
모든 모듈을 컴파일하고, 압축한 후 설치합니다(원본 커널 모듈을 수정된 모듈로 교체). 다른 배포판을 사용하거나 모든 단계를 원하지 않고 코드만 컴파일하려면 터미널에서 실행하세요.

```
make module_compile
```
컴파일한 모듈을 압축하려면 터미널에서 실행하세요
```
make module_compress
```
압축된 모듈을 시스템의 커널 모듈에 설치하려면 터미널에서 실행하십시오
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---