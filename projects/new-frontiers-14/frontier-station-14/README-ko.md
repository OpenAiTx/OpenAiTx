<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station은 [Space Station 14](https://github.com/space-wizards/space-station-14)를 기반으로 하여 [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) 엔진(C#로 작성됨) 위에서 구동되는 포크입니다.

이 저장소는 Frontier Station의 주요 저장소입니다.

Frontier Station을 호스팅하거나 콘텐츠를 제작하고 싶다면 이 저장소를 사용해야 합니다. 이 저장소에는 RobustToolbox와 신규 콘텐츠 팩 개발을 위한 콘텐츠 팩이 모두 포함되어 있습니다.

## 링크

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## 문서/위키

우리의 [위키](https://frontierstation.wiki.gg/)에는 Frontier Station의 콘텐츠에 대한 문서가 제공됩니다.

## 기여 방법

누구나 기여하는 것을 환영합니다. 도움이 필요하면 Discord에 참여하세요. 누구나 참여할 수 있는 [아이디어 목록](https://discord.com/channels/1123826877245694004/1127017858833068114)이 준비되어 있습니다. 도움이 필요하면 언제든 질문하세요!

현재 본 저장소에서는 게임 번역을 받고 있지 않습니다. 만약 다른 언어로 게임을 번역하고 싶다면 포크를 생성하거나 포크에 기여하는 것을 고려해 주세요.

기여를 하게 되면, 반드시 [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md) 파일의 마커 섹션을 읽어주세요.
업스트림 파일에 대한 변경사항은 반드시 해당 규정에 맞게 명확히 표시해야 합니다.

## 빌드 방법

1. 이 저장소를 클론합니다:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. 프로젝트 폴더로 이동하여 `RUN_THIS.py`를 실행해 서브모듈을 초기화하고 엔진을 로드합니다:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. 솔루션을 컴파일합니다:  

서버를 빌드하려면 `dotnet build`를 사용하세요.

[프로젝트 빌드에 대한 자세한 안내](https://docs.spacestation14.com/en/general-development/setup.html)

## 라이선스

커밋 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 이후 본 저장소에 기여된 모든 콘텐츠는 별도 명시가 없는 한 GNU Affero General Public License 버전 3.0으로 라이선스됩니다(아래의 Attributions 참고). `LICENSE-AGPLv3.txt`를 참조하세요.
커밋 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 이전에 기여된 콘텐츠는 별도 명시가 없는 한 MIT 라이선스로 라이선스됩니다. `LICENSE-MIT.txt`를 참조하세요.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0)는 2024년 7월 1일 16:04 UTC에 푸시되었습니다.

대부분의 에셋은 별도 명시가 없는 한 [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) 라이선스를 따릅니다. 에셋의 라이선스 및 저작권 정보는 메타데이터 파일에 명시되어 있습니다. 예시로 [크로우바의 메타데이터](https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json)를 참고하세요.  

일부 에셋은 비상업적 목적의 [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) 또는 유사한 비상업적 라이선스로 제공되며, 이 프로젝트를 상업적으로 사용하려면 해당 에셋을 제거해야 할 수 있습니다.

## 저작권 표시(Attributions)

다른 포크에서 콘텐츠를 가져올 경우, 저작권 표기와 머지 충돌 방지를 위해 해당 콘텐츠를 저장소의 특정 하위 폴더로 정리합니다.

이 하위 디렉터리 내의 콘텐츠는 각 포크에서 유래했으며, 수정이 포함될 수 있습니다. 이러한 수정 사항은 수정된 라인에 주석으로 표시되어 있습니다.

| 하위 디렉터리 | 포크 이름 | 포크 저장소 | 라이선스 |
|--------------|-----------|-----------------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

하위 디렉터리 없이 기능이 이식된 추가 저장소는 아래에 나열됩니다.

| 포크 이름 | 포크 저장소 | 라이선스 |
|-----------|-----------------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---