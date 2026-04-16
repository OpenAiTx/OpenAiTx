# gnome-gamma-tool

GNOME 및 Cinnamon에서 VCGT 테이블을 사용하여 색상 프로필을 생성함으로써 감마, 대비 및 밝기를 영구적으로 변경할 수 있는 명령줄 도구입니다.

## 면책 조항
**이 도구는 GNOME 및 Cinnamon에서만 작동합니다**. Fedora의 GNOME 42-48 및 Cinnamon에서 테스트되었으며, 이전 또는 최신 버전에서는 작동하지 않을 수 있지만 이미 생성된 프로필은 계속 작동할 것입니다.

이 방법은 다소 해킹에 가깝습니다. 색상 프로필은 원래 이렇게 사용하도록 설계되지 않았습니다. 하지만 이 사용 사례가 드물기 때문에 정당화된다고 생각합니다. 결국, 모니터가 감마를 변경하지 못하게 한다면 그건 모니터의 문제 아닐까요?

자세한 설명은 [작동 원리](#how-it-works)를 참조하세요.

**참고:** VCGT 제한으로 인해 화면 채도나 색조를 변경하는 것은 불가능하지만, [gnome-saturation-extension](https://github.com/zb3/gnome-saturation-extension)을 사용해 볼 수 있습니다(단점도 있습니다).

## 사용법
설치할 필요 없이 이 저장소를 클론하면 됩니다:
```
git clone https://github.com/zb3/gnome-gamma-tool
cd gnome-gamma-tool
```
**만약** Debian/Ubuntu를 사용 중이라면, 먼저 `gir1.2-colord-1.0` 패키지를 설치해야 할 수도 있습니다:

```
sudo apt install gir1.2-colord-1.0
```
OpenSUSE의 경우 대신 `typelib-1_0-Colord-1_0` 패키지를 설치해야 할 수 있습니다:
```
sudo zypper install typelib-1_0-Colord-1_0
```
만약 NixOS를 사용 중이라면, [이 댓글](https://github.com/zb3/gnome-gamma-tool/issues/28#issuecomment-3112277504)을 확인하세요.

그런 다음 도구를 다음과 같이 호출할 수 있습니다:
```
./gnome-gamma-tool.py
```
(이 방법이 작동하지 않으면 [여기](https://github.com/zb3/gnome-gamma-tool/issues/new)에서 새 이슈를 열어주세요)

새 프로필이 설치되면 이 도구는 안전하게 제거할 수 있습니다.


### 화면 감마 조정
`-g` 인수를 사용하면 감마 보정 값을 지정할 수 있습니다. 개별 채널에 대해 `R:G:B` 형식을 사용하여 설정할 수도 있습니다.

예를 들어:
```
./gnome-gamma-tool.py -g 0.8
```
or
```
./gnome-gamma-tool.py -g 0.8:0.8:0.8
```
### 대비 조정(또는 색상 반전)
`-c` 매개변수를 사용하여 대비를 변경할 수도 있습니다. `1`이 기본값이며, `-1`은 색상을 효과적으로 반전시킵니다. 여기서 `0` 값을 사용하지 마세요. 화면이 모두 회색으로 표시됩니다...

예를 들어:

```
./gnome-gamma-tool.py -c -1
```

항상 초기 상태에서 시작한다는 점에 유의하세요, 따라서 위 명령어는 이전의 감마 조정을 모두 취소하지만, 다양한 옵션을 조합할 수 있습니다:

```
./gnome-gamma-tool.py -g 0.8 -c 0.5
```
채널별 설정도 여기서 작동하므로, 예를 들어 파란색 채널만 반전시키고 빨간색과 녹색은 그대로 유지할 수 있습니다. 이것이 어떻게 보일지 짐작할 수 있나요? 한번 시도해 보세요:

```
./gnome-gamma-tool.py -c=1:1:-1
```
그게 기대한 것이었나요? :)

### 색온도 변경
색온도도 변경할 수 있으며, `-t` 옵션을 사용하여 온도를 지정합니다. 값은 `redshift`에서처럼 작동하며 `6500`이 중립값입니다. 이 기능은 야간 조명 기능이 작동하는 것을 막지 않으며, 단지 야간 조명 조정이 gnome-gamma-tool이 하는 작업 위에 "덧붙여" 이루어진다는 점에 유의하세요.
```
./gnome-gamma-tool.py -t 5000
```
### 밝기 조절 (약간)
이 도구로 밝기를 조절할 수도 있지만, 물리적 디스플레이 밝기를 증가시키는 것은 불가능하며 최대 밝기 값을 줄여서 감소시키는 것만 가능합니다. `-b` 옵션을 사용하여 조절할 수 있으며, `0`에서 `1` 사이의 값을 받는데 `1`이 중립값입니다:

```
./gnome-gamma-tool.py -b 0.7
```

여기에는 *최소* 밝기 값을 *증가*시킬 수 있는 또 다른 옵션이 있습니다. 이것은 `-bm` 옵션으로, 이번에는 `0`이 중립 값인 `0`부터 `1`까지의 값을 허용합니다. 다음을 수행한 후:
```
./gnome-gamma-tool.py -bm 0.3
```
출력 값은 절대 `0.3`보다 작아지지 않으므로 검정색은 실제로 회색이 되며, 흰색은 여전히 흰색이고 그 사이의 색상은 그에 맞게 곱해집니다. 또한 `-b`와 `-bm` 조합을 사용하여 색상을 반전시킬 수도 있습니다.:
```
./gnome-gamma-tool.py -b 0 -bm 1
```
그리고... 그것이 전부가 아닙니다, 왜냐하면 이것들은 `R:G:B` 표기법 덕분에 개별 채널별로도 작동하기 때문입니다. 이것은 색온도로는 달성할 수 없었던 화면을 더 녹색으로 만드는 것과 같은 새로운 가능성을 열어줍니다.:

```
./gnome-gamma-tool.py -b 1:2:1
```
위는 먼저 `0.5:1:0.5`로 변환되며, 기술적으로는 화면의 빨강과 파랑이 줄어들지만 실제로는 화면이 더 초록색으로 보이게 합니다. 유용한 기능이죠, 그렇지 않나요?


### 여러 대의 디스플레이가 있는 경우
`-d` 옵션을 사용하여 디스플레이 *인덱스*를 지정할 수 있습니다(첫 번째 디스플레이는 인덱스 `0`이며 기본값이므로 이 경우에는 이 인수를 사용할 필요가 없습니다...). 디스플레이 순서는 `설정 -> 색상` 패널과 동일합니다. 예시는 다음과 같습니다:
```
./gnome-gamma-tool.py -d 1 -g 0.7
```

`-a` 옵션을 사용하여 모든 디스플레이에 변경 사항을 적용할 수도 있습니다:
```
./gnome-gamma-tool.py -a -g 0.7
```

### 파일로 내보내기

현재 구성을 건드리지 않고 올바른 VCGT 테이블이 포함된 ICC 프로파일만 만들고 싶다면 `-o`/`--out-file` 인수를 사용할 수 있습니다. 현재 프로파일을 불러오지 않으므로, `-i`/`--in-file` 인수로 기본 프로파일을 지정하지 않으면 출력은 sRGB 프로파일이 됩니다.

그런 다음 `colormgr` 같은 도구를 사용하여 가져오고 적용할 수 있습니다.

```
# Create myprofile.icc file
python3 ./gnome-gamma-tool.py --min-brightness 0.05 --brightness 0.95 --out-file myprofile.icc

# This command will print Device ID, save it
colormgr get-devices

# This command will print Profile ID, save it
colormgr import-profile myprofile.icc

# This command will affect colors immediately
colormgr device-add-profile $displayId $profileId

# This command will remove imported profile and revert colors to original state immediately.
colormgr delete-profile $profileId
```
## 작동 원리

Mutter(GNOME의 컴포지터)는 도움을 줄 수 있는 Wayland 프로토콜을 구현하지 않으므로 `gammastep`이나 `wl-gammactl` 같은 도구는 작동하지 않습니다. 그러나 Mutter는 D-Bus를 통해 `SetCrtcGamma` 메서드를 노출하며, 이 메서드는 실제로 작동합니다. 하지만 gnome-gamma-tool이 이 방법을 사용하지 않는 이유는:
* 값이 어디에도 저장되지 않아 효과가 지속되지 않음
* 이 메서드는 이미 다른 데몬에 의해 호출되어 효과가 일시적임

이 메서드는 보통 `gsd-color` 데몬에 의해(간접적으로) 호출되며, 현재 그 인자에 영향을 줄 수 있는 두 가지가 있습니다:
* 현재 활성화된 컬러 프로파일의 VCGT 테이블(colord를 통해 가져옴)
* "야간 조명" 설정에서 파생된 색온도
(이 두 가지가 결합됨)

여기서 명백한 해결책은 `gsd-color`를 패치하여 다른 요소들(예: GSettings 속성)도 고려하게 하는 것처럼 보일 수 있으며, 그렇게 하면 `gsettings` 명령어를 통해 감마를 조정할 수 있습니다. 나중에 디스플레이 패널에 GUI를 추가할 가능성도 열립니다.

하지만 다시 말하지만, 이것이 gnome-gamma-tool이 작동하는 방식이 아닙니다. 왜냐하면 `gsd-color` 패치는 이 패치가 업스트림에 병합될 경우에만 의미가 있기 때문입니다. 그렇지 않으면 사용자(아마도 여러분도 포함해)가 커스텀 패치를 적용하고 GNOME 일부를 다시 빌드해야 하는 것은 전혀 받아들일 수 없습니다. 그래서 gnome-gamma-tool은 올바른 "VCGT" 테이블이 설정된 컬러 프로파일을 설치합니다.

`gsd-color`는 컬러 프로파일을 관리하지 않고, colord가 제공하는 API를 사용해 그것들을 관찰합니다. `gsd-color`가 프로파일을 인식하려면 다음 작업이 수행되어야 합니다:
* 특정 장치에 대해 컬러 프로파일이 활성화되어야 함
* 해당 프로파일이 설치되어 있어야 함(colord 데이터베이스에)
* 해당 프로파일이 장치와 연관되어야 함
* 해당 프로파일이 활성화되어야 함

이 모든 단계는 colord가 D-Bus를 통해 노출하는 API를 사용해 수행됩니다. gnome-gamma-tool은 새 프로파일을 처음부터 만들지 않고(단, `-o`/`--out-file`를 지정하지 않는 한) 현재 프로파일을 복제하고 VCGT 테이블만 수정합니다. 기본적으로 현재 프로파일은 EDID 데이터를 기반으로 `gsd-color`가 생성한 프로파일입니다.

`gsd-color`는 D-Bus 신호를 사용해 장치/프로파일 변경을 감지하므로, 우리의 프로파일 변경을 포착하고 결국 `SetCrtcGamma`를 호출합니다. 그게 전부입니다!

그렇다면 이 "VCGT"란 무엇인가요? VCGT(Video Card Gamma Table)는 기본적으로 색상 채널(R, G, B) 값을 매핑합니다. 예를 들어 채널 값이 `X`라면 VCGT는 이를 `Y`로 변환해야 한다고 지정합니다. 물론 모든 입력 값이 VCGT 항목을 가진 것은 아니며, 이 테이블은 256개의 항목만 있고 값은 보간됩니다(하지만 이것은 gnome-gamma-tool에서 수행하지 않습니다).

VCGT는 감마(지수 연산), 대비 및 밝기를 변경할 수 있게 하지만, 한 채널이 다른 채널에 영향을 줄 수 없기 때문에 색조는 이 방법으로 변경할 수 없습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---