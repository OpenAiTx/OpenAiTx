# VHVR-Mod
이것은 Unity와 SteamVR을 OpenVR과 함께 사용하여 네이티브 VR 지원을 추가하는 PC 게임 Valheim용 실험적 모드입니다.

모드는 [Nexus Mods](https://www.nexusmods.com/valheim/mods/847)에서 다운로드하세요!

개발 진행 로그는 [YouTube](https://www.youtube.com/playlist?list=PL9EDvRwka57-swWbcOAq0lhIp5jSFPg-u)에서 확인하세요.

[Flatscreen to VR Modding Discord](https://discord.gg/ZFSCSDe)에 참여하세요.

## 이 패키지에는 무엇이 포함되어 있나요?
### Unity 프로젝트
이 프로젝트는 주로 모드에서 사용하는 필수 AssetBundles를 생성하는 자산 생성기이자 적절한 환경에서 SteamVR 및 Unity XR 라이브러리를 빌드하는 수단으로 존재합니다.

Unity 패키지에서 여러 자산이 생성되지만 가장 중요한 것은 다음과 같습니다:
* SteamVR 플레이어 프리팹: 이 프리팹은 SteamVR을 제대로 사용하기 위해 필요한 모든 스크립트를 포함하는 Unity 게임 오브젝트 계층구조입니다. 계층구조 내에 게임의 기본 카메라와 교체될 카메라가 포함되어 있습니다. 이 카메라는 HMD에 표시되는 입체 3D를 사용하도록 구성되어 있습니다.
* Unity 및 OpenVR 자산: 게임 시작 시 Unity의 XR 엔진을 올바르게 부트스트랩하는 데 필요한 자산입니다.
* [Amplify Occlusion](https://github.com/AmplifyCreations/AmplifyOcclusion) 그래픽 후처리기: 게임 내 SSAO 그래픽 효과 대신 더 높은 성능을 제공하는 대체품으로 사용됩니다.

### ValheimVRMod C# 프로젝트
이 프로젝트는 모드의 대부분 코드를 포함합니다. 다음 기능을 구현하는 클래스/Unity MonoBehaviour 스크립트를 포함합니다:
* Unity/OpenVR XR 엔진 초기화
* AssetBundles에서 SteamVR 프리팹 인스턴스화
* 게임의 메인 카메라를 VR 카메라로 교체하고 적절히 위치 조정
* 게임 GUI를 VR로 변환
* 모션 컨트롤 구현 (진행 중)

### 요구사항
이 모드는 [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/)이 필요합니다. BepInEx는 Unity 게임용 모드 프레임워크로, 모더가 게임 런타임에 코드를 주입할 수 있게 해줍니다. 또한 C# 라이브러리 내 기존 메서드를 패치하는 도구인 [Harmony](https://harmony.pardeike.net/articles/intro.html)도 포함합니다.

추가로 OpenVR/SteamVR을 지원하는 HMD가 필요합니다.

### 기타 정보
이 모드는 실험적이며 거의 확실히 여러 버그와 결함을 포함할 것입니다. 또한 Valheim은 현재 얼리 액세스 게임이므로, 게임에 대한 패치가 이 모드를 깨뜨릴 가능성이 높습니다. 수정 작업이 진행 중이니 인내심을 가지고 문제를 발견하면 자유롭게 신고해 주세요 :)

Valheim은 VR용으로 제작되지 않았기 때문에, 이 구현은 VR 전용 게임만큼 편안하지 않을 수 있습니다. VR로 인해 멀미가 나는 경향이 있다면 이 모드는 적합하지 않을 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---