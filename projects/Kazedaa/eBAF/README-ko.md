# eBAF - eBPF 기반 광고 방화벽
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF 광고 방화벽 배너" width="600"/>
</p>

## "광고를 다운로드하지는 않을 것이다"
### 하지만 광고는 차단할 것이다!
 
Spotify는 아주 단순한 공식을 바탕으로 제국을 건설했습니다: 당신의 주의를 수익화하고, 아티스트에게는 적은 보수를 지급하며, 당신의 시간을 프리미엄 기능으로 다시 판매합니다.
그들의 세계에서 당신의 청취 경험은 당신의 것이 아닙니다. 이는 신중하게 기획된 마켓플레이스입니다 — 당신의 귀는 상품이고, 당신의 인내심이 화폐입니다.

그들은 이것을 "무료" 티어라고 부르기를 좋아합니다.
하지만 솔직해집시다: 당신이 시간을 대가로 지불하고 있다면 무료가 아닙니다.

한편, 당신이 사랑하는 아티스트들 — 이 플랫폼을 살아 있게 만드는 사람들 — 은 종종 스트림당 몇 푼도 안 되는 돈을 벌 뿐입니다. Spotify는 엄청난 이익을 얻고, 광고주는 노출을 확보하며, 창작자들은? 쥐꼬리만한 몫을 받습니다.

이것은 단순히 몇 개의 짜증나는 광고를 건너뛰는 문제가 아닙니다.
착취, 산만함, 그리고 당신의 주의를 상품화하는 시스템에 참여하지 않겠다는 거부의 의미입니다.

#### 이것이 무엇인가요?
디지털 저항의 우아하고 작은 행동: Spotify를 위한 깔끔하고 오픈 소스의 광고 차단기, 소음을 말 그대로 멈춥니다.

수상쩍은 모드도, 크랙된 클라이언트도, 자유를 가장한 악성코드도 없습니다. 오직 하나의 목표: 광고에 발목 잡히지 않고 음악이 자유롭게 흘러가게 하는 것.

Spotify는 공짜가 아닙니다 — 당신은 인내로 값을 치릅니다.

그들은 똑같이 거슬리는 광고를 반복해서 쏟아붓습니다. 결국 당신이 포기하고 구독하도록요. 프리미엄이 좋아서가 아니라, 질려버렸기 때문입니다. 이건 프리미엄(freemium)이 아니라, 재생목록을 이용한 심리전입니다.

그 사이, 아티스트들은? 여전히 제대로 보상받지 못합니다.
광고는? 더 시끄럽고, 더 자주 나오며, 때로는 진짜로 더 큽니다.
당신은? 그저 좋은 분위기를 즐기고 싶을 뿐이죠.

그들은 당신의 인내와 창작자에 대한 저임금에서 이익을 챙기면서, 그게 유일한 지속 가능한 방법인 척합니다. 스포일러: 아닙니다. 선택지가 있었지만, 사람보다 이윤을 택한 겁니다.

Spotify는 이것이 접근의 대가라고 믿게 하려 합니다.
우리는 그것이 거짓이라고 믿습니다.

우리는 해적도, 범죄자도 아닙니다. 우리는 단지 선을 그어도 괜찮다고 생각하는 평범한 사람들입니다.

이 프로젝트는 몇 개의 광고를 넘기는 문제가 아닙니다. 당신의 침묵이 팔릴 수 있고, 당신의 경험이 방해받을 수 있으며, 지갑을 열 때만 당신의 가치가 시작된다는 시스템 자체를 거부하는 것입니다.

광고를 차단하는 것은 도둑질이 아닙니다.<br>
당신의 시간을 빼앗는 게 도둑질입니다.<br>
우리는 해적질을 하려는 게 아닙니다. 우리는 거부권을 행사하려는 겁니다.<br>
<br>
**당신은 광고를 다운로드하지 않을 겁니다. 하지만 광고는 차단할 수 있습니다.**
## eBAF는 어떻게 작동합니까?

eBAF(eBPF Ad Firewall)는 eBPF(Extended Berkeley Packet Filter)의 강력한 기능을 활용하여 커널 수준에서 원치 않는 광고를 차단합니다. 다음은 그 기능에 대한 높은 수준의 개요입니다:

## eBAF는 어떻게 작동합니까?

eBAF(eBPF Ad Firewall)는 eBPF(Extended Berkeley Packet Filter)를 활용하여 커널 수준에서 효율적으로 광고를 차단합니다. 다음은 간단한 개요입니다:

1. **패킷 필터링**:
   - 수신 네트워크 패킷을 검사하고 XDP(eXpress Data Path)를 사용하여 블랙리스트에 등록된 IP 주소와 일치하는 패킷을 차단합니다.

2. **동적 업데이트**:
   - 도메인 이름을 IP 주소로 변환하고 광고 서버가 변경되어도 효과적으로 대응할 수 있도록 블랙리스트를 동적으로 업데이트합니다.

3. **웹 대시보드**:
   - 사용하기 쉬운 인터페이스를 통해 실시간 통계 및 모니터링을 제공합니다.

4. **고성능**:
   - 네트워크 인터페이스 수준에서 직접 동작하여 커널의 네트워킹 스택을 우회함으로써 더 빠른 처리 속도와 최소한의 리소스 사용을 실현합니다.

eBAF는 효율성, 투명성, 사용의 용이성을 결합하여 강력한 광고 차단 솔루션을 제공합니다.
## 간편 설치 (추천)
git과 curl이 설치되어 있는지 확인하세요
```bash
git --version
curl --version
```
### 설치
#### Spotify 연동 활성화 (추천)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### 명시적으로 비활성화
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### 제거
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## 개발 설치
필수 종속성을 설치하려면 다음 명령어를 실행하세요:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### eBPF 코드를 실행할 때 asm/types.h 오류 수정
현재 링크 확인
`ls -l /usr/include/asm`
올바른 링크 찾기
`find /usr/include -name "types.h" | grep asm`
심볼릭 링크 수정
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### 프로젝트 빌드하기

eBPF Adblocker를 빌드하려면 다음 단계를 따르세요:

1. 저장소를 클론합니다:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. 프로젝트 빌드:
   ```bash
   make
   ```

3. (선택 사항) 시스템 전체에 설치:
   ```bash
   sudo make install
   ```

4. 기타 설치 옵션 (도움말)
    ```bash
    make help
    ````
5. 제거
    ```bash
    make uninstall
    ````

## 사용법

### 광고 차단기 실행
    기본 블랙리스트로 spotify-stable.txt를 사용합니다.
    사용법: ebaf [옵션] [인터페이스...]
    옵션:
    -a, --all               모든 활성 인터페이스에서 실행
    -d, --default           기본 인터페이스(인터넷 연결된)에서만 실행
    -i, --interface IFACE   사용할 인터페이스 지정
    -D, --dash              웹 대시보드 시작 (http://localhost:8080)
    -q, --quiet             출력 억제(조용한 모드)
    -h, --help              이 도움말 메시지 표시


### 블랙리스트 설정
도메인을 추가하거나 제거하려면 목록을 편집하십시오. 각 도메인은 별도의 줄에 있어야 합니다. 주석은 `#`로 시작합니다.

## 감사의 글

특별히 감사드립니다 ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

스포티파이 차단 리스트를 제공해 주셔서 감사합니다.
## ⭐️ 프로젝트 지원하기

eBAF가 유용하다고 생각하신다면 GitHub 저장소에 스타를 눌러주세요! 여러분의 응원은 프로젝트의 가시성을 높이고 추가 개발을 장려하는 데 큰 도움이 됩니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---