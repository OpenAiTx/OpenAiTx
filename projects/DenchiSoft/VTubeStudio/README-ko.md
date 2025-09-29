# <a href="https://denchisoft.com"><img src="https://raw.githubusercontent.com/DenchiSoft/VTubeStudio/master/Images/vtube_studio_logo_nyan_2.png" width="542" /></a><br> [![License: MIT](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/DenchiSoft/VTubeStudio/blob/master/LICENSE) [![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=shield)](https://discord.gg/VTubeStudio) [![Stars](https://img.shields.io/github/stars/DenchiSoft/VTubeStudio?style=social)](https://github.com/DenchiSoft/VTubeStudio) [![Twitter Follow](https://img.shields.io/twitter/follow/VTubeStudio.svg?style=social)](https://twitter.com/VTubeStudio)


[![VTube Studio Discord](https://discordapp.com/api/guilds/652602255748497449/widget.png?style=banner2)](https://discord.gg/VTubeStudio)

## [VTube Studio 매뉴얼](https://github.com/DenchiSoft/VTubeStudio/wiki)을 찾고 계신가요?

여기에서 찾을 수 있습니다: https://github.com/DenchiSoft/VTubeStudio/wiki

## [VTube Studio 플러그인 목록](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)을 찾고 계신가요?

이 페이지를 확인하세요: https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins

## VTube Studio iPhone 앱에서 트래킹 데이터를 받는 방법을 찾는 개발자이신가요?

VTube Studio iOS 앱에서 트래킹 데이터를 요청하는 절차는 여기에서 설명되어 있습니다: https://github.com/DenchiSoft/VTubeStudioBlendshapeUDPReceiverTest

## VTube Studio 플러그인 제작 방법을 배우고 싶은 개발자이신가요?

필요한 모든 정보는 이 페이지에 있습니다. 질문이 있으면 [Discord](https://discord.gg/VTubeStudio)에서 문의하세요.

## 목차

- [일반 정보](#general-info)
- [법적 정보](#legal-info)
- [사용 가능한 플러그인 및 예제](#available-examples)
- [이벤트 API](#event-api)
- [API 세부사항](#api-details)
  - [API 권한](#api-permissions)
  - [API 서버 발견 (UDP)](#api-server-discovery-udp)
  - [인증](#authentication)
  - [이벤트 구독 및 구독 해제](#subscribing-to-and-unsubscribing-from-events)
  - [현재 VTS 통계 가져오기](#getting-current-vts-statistics)
  - [VTS 폴더 목록 가져오기](#getting-list-of-vts-folders)
  - [현재 로드된 모델 가져오기](#getting-the-currently-loaded-model)
  - [사용 가능한 VTS 모델 목록 가져오기](#getting-a-list-of-available-vts-models)
  - [ID로 VTS 모델 로드하기](#loading-a-vts-model-by-its-id)
  - [현재 로드된 VTS 모델 이동하기](#moving-the-currently-loaded-vts-model)
  - [현재 또는 다른 VTS 모델에서 사용 가능한 단축키 목록 요청하기](#requesting-list-of-hotkeys-available-in-current-or-other-vts-model)
  - [단축키 실행 요청하기](#requesting-execution-of-hotkeys)
  - [표현과 그 상태 목록 요청](#requesting-current-expression-state-list)
  - [표현 활성화/비활성화 요청](#requesting-activation-or-deactivation-of-expressions)
  - [현재 모델의 ArtMesh 목록 요청](#requesting-list-of-artmeshes-in-current-model)
  - [ArtMesh에 색상 입히기](#tint-artmeshes-with-color)
  - [장면 조명 오버레이 색상 가져오기](#getting-scene-lighting-overlay-color)
  - [트래커가 현재 얼굴을 찾았는지 확인](#checking-if-face-is-currently-found-by-tracker)
  - [사용 가능한 트래킹 파라미터 목록 요청](#requesting-list-of-available-tracking-parameters)
  - [특정 파라미터 값 가져오기 (기본 또는 사용자 정의)](#get-the-value-for-one-specific-parameter-default-or-custom)
  - [현재 모델의 모든 Live2D 파라미터 값 가져오기](#get-the-value-for-all-live2d-parameters-in-the-current-model)
  - [새 트래킹 파라미터 추가 ("사용자 정의 파라미터")](#adding-new-tracking-parameters-custom-parameters)
  - [사용자 정의 파라미터 삭제](#delete-custom-parameters)
  - [기본 또는 사용자 정의 파라미터에 데이터 입력](#feeding-in-data-for-default-or-custom-parameters)
  - [현재 로드된 VTS 모델의 물리 설정 가져오기](#getting-physics-settings-of-currently-loaded-vts-model)
  - [현재 로드된 VTS 모델의 물리 설정 덮어쓰기](#overriding-physics-settings-of-currently-loaded-vts-model)
  - [NDI 설정 가져오기 및 설정](#get-and-set-ndi-settings)
  - [사용 가능한 아이템 또는 장면 내 아이템 목록 요청](#requesting-list-of-available-items-or-items-in-scene)
  - [아이템을 장면에 로드하기](#loading-item-into-the-scene)
  - [장면에서 아이템 제거하기](#removing-item-from-the-scene)
  - [아이템 및 아이템 애니메이션 제어](#controling-items-and-item-animations)
  - [장면 내 아이템 이동](#moving-items-in-the-scene)
  - [아이템 내 모델 내 정렬 순서 설정](#set-item-within-model-sorting-order)
  - [사용자에게 ArtMesh 선택 요청](#asking-user-to-select-artmeshes)
  - [아이템을 모델에 고정하기](#pin-items-to-the-model)
  - [후처리 효과 및 상태 목록 가져오기](#get-list-of-post-processing-effects-and-state)
  - [후처리 효과 설정](#set-post-processing-effects)
  
## 일반 정보

VTube Studio에는 **공개 API**가 있습니다. 즉, 핫키를 트리거하고, 얼굴 트래킹 데이터를 입력하고, 아이템과 모델을 로드하며, 다양한 이벤트 알림을 받고, 모델 ArtMesh에 색상을 입히는 등 다양한 기능을 수행하는 플러그인/스크립트를 작성할 수 있습니다.

VTube Studio와 함께 사용할 수 있는 플러그인이나 앱을 개발하셨다면 PR을 열어 주시면 이 페이지의 목록에 추가하겠습니다.

## 법적 정보

VTube Studio용 플러그인을 자유롭게 작성, 공개 및 판매할 수 있습니다. 별도의 허가가 필요 없으며 라이선스 비용이나 로열티도 없습니다.

## 사용 가능한 예제

VTube Studio 사용자가 사용할 수 있는 플러그인을 찾고 있다면 [플러그인 목록 위키 페이지](https://github.com/DenchiSoft/VTubeStudio/wiki/Plugins)를 확인하세요.

개발자 분들께서 VTube Studio API를 앱에 쉽게 통합할 수 있도록 예제나 라이브러리를 찾고 계신다면, 아래 표를 참고해 주세요. 

:warning: **만든 것이 있으시면 여기에 포함되도록 수정된 표와 함께 풀 리퀘스트를 열어주세요!!** :warning:

| 플러그인 | 개발자 | 유형 | 설명 |
| --- | --- | --- | --- |
| [Cheers Bot](https://cheers.hawk.bar/) | [Hawkbar](https://twitter.com/HawkbarGaming) | 앱 | 채팅 참가자가 채널 포인트를 사용할 때 VTube Studio에서 동작을 트리거할 수 있는 웹 기반 Twitch 통합 플랫폼이며, 그 외 다양한 기능이 있습니다. |
| [VTubeStudioJS](https://github.com/Hawkbat/VTubeStudioJS) | [Hawkbar](https://twitter.com/HawkbarGaming) | 라이브러리 | VTube Studio WebSocket API를 구현한 다른 플러그인 작성자를 위한 JavaScript 라이브러리입니다. NodeJS와 브라우저 모두에서 호환됩니다. |
| [VTS Linker - SMB1](https://github.com/Renpona/VTStudio-Linker-SMB1) | [Renpona](https://twitter.com/renpona) | 예제 | 슈퍼 마리오 브라더스 에뮬레이터 데이터 읽기 프로토타입으로, 게임 내 상황에 따라 VTS의 Live2D 모델을 자동으로 움직이고 색상을 변경합니다. |
| [VTchaos](https://github.com/Raelice/VTchaos) | [Raelice](https://twitter.com/theraelice) | 앱 | YouTube 및 Twitch 채팅을 읽어 모델 교체, 회전, 단축키, 이동 등 vtube studio에서 간단한 채팅 명령어로 기능을 수행하는 프로그램입니다. |
| [Mix It Up](https://mixitupapp.com/) | [Mix It Up](https://twitter.com/mixitupapp) | 앱 | 채팅, 이벤트 등 다양한 기능을 제공하는 스트리밍 소프트웨어 봇입니다! |
| [VsPyYt](https://github.com/mlo40/VsPyYt) | [emlo40](https://emlo40.com) | 앱/프레임워크 | YouTube 채팅을 읽고 token.json에 저장된 명령어를 실행할 수 있는 커맨드 프롬프트 앱입니다. 또한 VTube Studio와 상호작용하는 파이썬 프로그램의 기반으로 사용할 수 있습니다. |
| [VTS-Sharp](https://github.com/FomTarro/VTS-Sharp) | [Skeletom](https://www.twitter.com/FomTarro) | 라이브러리 | VTube Studio WebSocket API를 구현한 Unity/C# 라이브러리로, 다른 플러그인 작성자가 사용할 수 있습니다. |
| [node-red-contrib-vts](https://github.com/eslym/node-red-contrib-vts) | [0nepeop1e](https://github.com/eslym) | 라이브러리 | Node-RED에서 VTube Studio와 통합하기 위한 노드를 제공하는 라이브러리 패키지입니다. |
| [VTS Mod](https://github.com/MechaWolfVtuberShin/VTS-Mod/releases/tag/vts-mod) | [MechaWolfVtuber_Shin](https://github.com/MechaWolfVtuberShin) | 앱 | 모델의 표면 색상(RGB 포함)을 변경할 수 있고, 모델의 회전도 변경할 수 있는 프로그램입니다. |
| [Tie Tools: VTS Color Editor](https://tie-tools.tiberiusx.me) | [Prof. Tiberius](https://www.twitter.com/prof_tiberius) | 앱 | 모델의 특정 부분 색상과 투명도를 상세하게 조절할 수 있는 웹 앱입니다. |
| [vtubestudio-rs](https://github.com/walfie/vtubestudio-rs) | [Walfie](https://www.twitter.com/walfieee) | 라이브러리 | VTube Studio WebSocket API를 구현한 Rust 라이브러리로, 다른 플러그인 작성자가 사용할 수 있습니다. |
| [vts-heartrate](https://skeletom-ch.itch.io/vts-heartrate) | [Skeletom](https://www.twitter.com/FomTarro) | 앱 | 실시간 심박수 데이터를 VTube Studio에 연결하여 동적 모델 색조 변경 및 심박수에 기반한 맞춤 추적 파라미터를 제공하는 플러그인입니다. |
| [vts-chameleon](https://satetsu888.github.io/vts-chameleon/) | [satetsu888](https://www.twitter.com/satetsu888) | 앱 | 색조 적용을 위한 플러그인으로, 모델의 머리카락, 피부, 유니폼 등의 색조를 변경하며 놀 수 있습니다. |
| [ViewLink](https://kawaentertainment.itch.io/viewlink) | [KawaEntertainment](https://twitter.com/kawa_entertain) | 앱 | VR 게임 스트리밍을 하고 싶지만 Live2D 모델만 있는 VTuber를 위한 프로그램으로, 별도의 복잡한 설정이나 추가 하드웨어 없이 Live2D 아바타가 VR 게임플레이에 반응하도록 할 수 있습니다! |
| [VTS Desktop Audio](https://lualucky.itch.io/vts-desktop-audio-plugin) | [Lua Lucky](https://twitter.com/LuaVLucky) | 앱 | 데스크톱 오디오를 VTS 입력 파라미터로 사용할 수 있게 하는 플러그인입니다. |
| [pyvts](https://github.com/Genteki/pyvts) | [Genteki](https://github.com/Genteki) | 라이브러리 | VTube Studio API와 상호작용하는 파이썬 라이브러리입니다. |
| [DSYS: Dummy System](https://github.com/chuigda/Project-WG/tree/master/extra/dsys) | [Chuigda](https://github.com/chuigda) | 앱 | VTS 모델 파라미터로 녹화/재생/세미 오토파일럿을 할 수 있는 간단한 플러그인입니다. |
| [SAMMIVtubeStudioExtension](https://github.com/HueVirtualCreature/SAMMIVtubeStudioExtension) | [hue](https://twitter.com/Hue_SwordDevil) | 플러그인 | 스트림 자동화 도구 [SAMMI](https://sammi.solutions/)용 플러그인입니다. |
| [Streamer.bot](https://streamer.bot) | [Streamer.bot](https://streamer.bot) | 앱 | 공식 [VTubeStudio 통합](https://docs.streamer.bot/guide/integrations/vtube-studio)을 제공하는 고급 다중 플랫폼 스트리밍 소프트웨어입니다. |
| [coovts](https://github.com/lgc2333/coovts) | [LgCookie](https://github.com/lgc2333) | 라이브러리 | 파이썬으로 VTube Studio 플러그인을 만들기 위한 또 다른 라이브러리(초기 개발 중). 완전한 타입 힌트 | 비동기 설계 | Pydantic 기반 데이터 검증 포함 |
| [VTS Terminal](https://www.nekomaido.com/plugin/vts-terminal) | [Neko Maido](https://www.nekomaido.com) | 앱 | 다양한 유틸리티를 제공하며, 단축키 트리거, 모델 위치 및 시각 효과 조정, Live2D 모델용 PDF 매뉴얼 생성이 가능한 플러그인입니다. |

# 이벤트 API

VTube Studio에서 모델 로드, 단축키 실행 등 발생하는 이벤트를 구독할 수 있는 **이벤트 API**에 대해 설명하는 별도의 위키 페이지가 있습니다. 이벤트 관련 페이지는 [여기](Events/)를 참고해 주세요.


# API 세부사항

VTube Studio 웹소켓 서버는 기본적으로 `ws://localhost:8001`에서 실행됩니다. 사용자가 앱 내에서 포트를 변경할 수도 있습니다. 웹소켓은 일반적으로 `binary`와 `text` 메시지를 지원하며, VTube Studio는 항상 `text` 메시지로 응답합니다. API로도 `text` 메시지를 보내는 것이 권장됩니다. `binary` 메시지를 보낼 경우 UTF-8 인코딩 여부를 반드시 확인하세요.

플러그인이 웹소켓 서버에 연결할 수 없다면, 사용자가 포트가 올바른지, 방화벽이나 백신 프로그램 설정 때문에 차단되지 않는지 확인하도록 안내하세요. 가장 중요한 점은 사용자가 VTube Studio에서 `"플러그인 API 접근 허용"` 옵션을 켰는지 확인하는 것입니다. 이 옵션은 VTS의 메인 설정 페이지에 있습니다.
또한 플러그인이 연결에 사용하는 포트를 설정할 수 있도록 지원해야 합니다.

연결할 수 있다면, 가장 먼저 시도할 수 있는 것은 세션 상태를 확인하는 것입니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "MyIDWithLessThan64Characters",
	"messageType": "APIStateRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"messageType": "APIStateResponse",
	"requestID": "MyIDWithLessThan64Characters",
	"data": {
		"active": true,
		"vTubeStudioVersion": "1.9.0",
		"currentSessionAuthenticated": false
	}
}
```
모든 요청에는 `"apiName" : "VTubeStudioPublicAPI"`와 사용된 API 버전이 포함되어야 하며, 첫 번째 릴리스 시점에서는 `"1.0"`이 됩니다.  
이 API 버전은 동작/페이로드에 호환되지 않는 변경이 이루어질 때까지 동일하게 유지됩니다. 이는 API에 새로운 기능(기존 페이로드에 새로운 필드 포함)이 추가되더라도 버전이 증가하지 않을 수 있음을 의미합니다. 앱이 이를 처리할 수 있도록 하고, 역직렬화 중에 알 수 없는 필드를 만나더라도 오류가 발생하지 않도록 하십시오.  

호환되지 않는 변경의 예로는 기존 필드의 이름 변경 또는 페이로드에서 완전히 제거하는 경우가 있습니다. 호환되지 않는 변경이 있을 경우, 이전 API가 그대로 사용될 수 있도록 API 버전이 증가합니다.  

모든 요청에 `"requestID"` 필드를 추가할 수 있습니다. 이는 선택 사항이지만 권장되며, 요청에 대한 응답을 식별할 수 있게 해줍니다.  
이 ID는 또한 VTube Studio 로그에서 요청 및 오류와 함께 기록됩니다. 문제가 발생하면 이 ID를 참조하여 로그에서 관련 오류를 확인할 수 있습니다.  

각 요청에 동일한 ID 또는 다른 ID를 사용할 수 있습니다. 제공되는 경우, ID는 ASCII 문자만 포함하고 최소 1자에서 최대 64자 길이여야 합니다.  
`"requestID"` 필드를 추가하지 않으면, VTube Studio가 요청에 대해 무작위로 생성된 UUID를 추가하고 응답과 함께 반환합니다.  

`"currentSessionAuthenticated"`는 현재 세션이 이미 인증되었는지 여부를 알려줍니다.  

모든 가능한 오류 ID는 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 페이지에 나열되어 있습니다.  

연결되면 클라이언트는 언제든지 현재 앱 상태에 대한 정보를 폴링할 수 있습니다.  

## API 권한  

VTube Studio API가 제공하는 특정 기능은 플러그인이 인증 후 요청해야 하는 추가 **권한** 뒤에 잠겨 있습니다. iOS 및 Android의 권한과 마찬가지로, 이는 플러그인이 임의의 이미지를 항목으로 불러오는 등 위험하거나 잠재적으로 위험한 기능을 사용할 때 사용자가 이를 이해하도록 하기 위함입니다.  

권한을 요청하면 권한이 수행하는 작업을 설명하는 팝업이 사용자에게 표시됩니다. 사용자는 이를 허용하거나 거부할 수 있습니다. 권한 요청 방법과 필요성에 대한 자세한 내용은 [permissions 페이지](Permissions/)를 확인하세요.  

[![VTube Studio Permission Request Screen](/Images/vts_api_permissions_1_transparent.png)](Permissions/)  


## API 서버 검색 (UDP)  

VTube Studio는 로컬 네트워크에서 UDP 포트 47779를 통해 API 상태를 방송합니다. 사용자가 API를 끈 경우에도 2초마다 한 번씩 방송이 이루어집니다.  
`instanceID`는 VTube Studio 인스턴스가 시작될 때 생성되는 임의의 ID입니다. 이 인스턴스가 실행되는 동안 변경되지 않으므로 두 개의 VTube Studio 인스턴스는 서로 다른 ID를 갖습니다.  

`windowTitle`은 창의 제목 텍스트입니다. Windows에서는 서로 다른 VTS 인스턴스마다 다릅니다. 두 개 이상의 인스턴스가 실행될 경우, 첫 번째 인스턴스의 제목은 `VTube Studio`, 두 번째 인스턴스는 `VTube Studio Window 2` 등이 됩니다. macOS에서는 모든 인스턴스가 `VTube Studio`라는 제목을 갖습니다.  


```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1630159656406,
	"messageType": "VTubeStudioAPIStateBroadcast",
	"requestID": "VTubeStudioAPIStateBroadcast",
	"data": {
		"active": false,
		"port": 8001,
		"instanceID": "93aa0d0494304fddb057ae8a295c4e59",
		"windowTitle": "VTube Studio"
	}
}
```

## 인증

API를 사용하기 전에 한 번 인증해야 합니다. 이를 위해 플러그인 이름과 개발자 이름을 제공해야 합니다. 두 이름 모두 3자에서 32자 사이여야 합니다.

이는 플러그인에 대한 토큰을 요청함으로써 수행됩니다. 다음 요청을 보내십시오:

**`요청`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"pluginIcon": "iVBORw0.........KGgoA="
	}
}
```

사용자가 API 액세스를 활성화한 경우, VTS 내에서 `"My Name"`의 `"My Cool Plugin"` 플러그인이 VTube Studio를 제어할 수 있도록 허용할지 묻는 팝업이 표시됩니다. `"pluginIcon"`은 선택적으로 추가할 수 있습니다. 이는 정확한 크기 128x128 픽셀의 base64로 인코딩된 PNG 또는 JPG 이미지여야 합니다. 이를 추가하면 아이콘이 사용자에게 표시되는 플러그인 액세스 요청 팝업에 사용됩니다. 사용자가 "허용"을 클릭하면 다음과 같은 응답을 받게 됩니다:

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationTokenResponse",
	"data": {
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

필드 `"authenticationToken"`은 API 인증에 사용될 토큰으로서 ASCII 문자열을 포함합니다. 최대 길이는 64자입니다.
접근이 거부되면 다음과 같은 오류가 발생합니다:

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "APIError",
	"data": {
		"errorID": 50,
		"message": "User has denied API access for your plugin."
	}
}
```
사용자는 언제든지 VTube Studio 내에서 플러그인의 API 접근 권한을 취소할 수 있습니다. 만약 그렇게 되면, 요청을 보내려고 할 때 이 오류가 발생합니다. 이 경우 다시 인증을 시도할 수 있습니다.

토큰은 한 번만 획득하면 됩니다. 이 토큰으로 현재 세션에 대해 인증할 수 있습니다. 다음 세션(예: VTS가 재시작되거나 플러그인이 어떤 이유로 VTS에 다시 연결해야 할 때)에서는 동일한 토큰을 사용해 다시 인증할 수 있으므로 토큰을 다시 얻기 위한 요청을 보낼 필요가 없으며, 사용자는 플러그인 허용 여부에 대해 한 번만 묻게 됩니다.

한 세션에 대해 인증하려면, 토큰과 함께 다음 요청을 보내십시오:

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AuthenticationRequest",
	"data": {
		"pluginName": "My Cool Plugin",
		"pluginDeveloper": "My Name",
		"authenticationToken": "adcd-123-ef09-some-token-string-abcd"
	}
}
```

`"pluginName"`과 `"pluginDeveloper"`는 토큰을 요청할 때 사용한 값과 일치해야 하며, 그렇지 않으면 인증 요청이 실패합니다.

토큰이 유효하고 사용자가 API 접근을 취소하지 않은 경우, 다음과 같은 응답을 받게 됩니다:

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AuthenticationResponse",
	"data": {
		"authenticated": true,
		"reason": "Token valid. The plugin is authenticated for the duration of this session."
	}
}
```
축하합니다, 인증되었으며 VTube Studio API를 사용할 수 있습니다.

필수 필드가 누락된 경우 오류 응답이 반환됩니다. 모든 필드가 존재하고 올바르게 형식화되었지만 토큰이 유효하지 않거나 사용자가 취소한 경우 `"authenticated"`는 `false`로 반환됩니다.

**`data` 필드에 대한 참고:** 일부 요청에는 `data` JSON 객체 필드가 포함되어 있고 일부는 포함되어 있지 않습니다. 더 쉽게 사용하기 위해 필요하지 않은 요청에도 이 필드를 포함할 수 있습니다. 비어 있거나 `null`/`undefined`로 설정해도 VTube Studio에서 무시됩니다. VTube Studio는 플러그인에서 역직렬화를 쉽게 하기 위해 모든 요청에 이 필드를 반환합니다. 응답에 데이터가 없으면 이 필드는 빈 JSON 객체를 포함합니다.

**`timestamp` 필드에 대한 참고:** 모든 응답에는 요청이 처리된 UNIX 밀리초 타임스탬프를 포함하는 `"timestamp"` 필드가 있습니다. 요청에 `"timestamp"` 필드를 포함할 수 있지만 무시됩니다.

## [이벤트](Events/) 구독 및 구독 취소

이전 API 버전에서는 로드된 모델이나 항목과 같은 정보를 플러그인이 반복해서 폴링해야 했습니다. 이제 VTube Studio는 플러그인과 관련된 무언가가 발생할 때마다 메시지를 보내는 **"이벤트"** 구독을 지원합니다. 이벤트에는 항목이 로드될 때, 트래킹이 손실/복구될 때, 모델이 클릭될 때 등 여러 알림이 포함됩니다.

이벤트에 관한 페이지는 [여기](Events/)를 참조하세요.

## 현재 VTS 통계 가져오기

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "StatisticsRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "StatisticsResponse",
	"data": {
		"uptime": 1439384,
		"framerate": 73,
		"vTubeStudioVersion": "1.9.0",
		"allowedPlugins": 7,
		"connectedPlugins": 2,
		"startedWithSteam": true,
		"windowWidth": 1031,
		"windowHeight": 812,
		"windowIsFullscreen": false
	}
}
```
`"uptime"`는 VTube Studio가 시작된 이후의 밀리초 수를 포함합니다. `"framerate"`는 현재 렌더링 FPS 값입니다. `"allowedPlugins"`는 사용자가 현재 VTube Studio 사용을 허용한 플러그인 수이며, `"connectedPlugins"`는 현재 VTube Studio API에 연결된 플러그인 수입니다. `"startedWithSteam"`은 앱이 Steam을 통해 시작된 경우 true이고, 그렇지 않은 경우(false, `.bat` 파일로 Steam 없이 VTS를 시작한 경우)입니다.

창의 너비와 높이는 픽셀 단위입니다.

## VTS 폴더 목록 가져오기

다양한 VTube Studio 폴더의 이름을 반환합니다. 이들은 게임 파일 내의 `StreamingAssets` 폴더에 있습니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "VTSFolderInfoResponse",
	"data": {
		"models": "Live2DModels",
		"backgrounds": "Backgrounds",
		"items": "Items",
		"config": "Config",
		"logs": "Logs",
		"backup": "Backup"
	}
}
```

## 현재 로드된 모델 가져오기

**`요청`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "CurrentModelRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "CurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDToIdentifyThisModelBy",
		"vtsModelName": "Model.vtube.json",
		"vtsModelIconName": "ModelIconPNGorJPG.png",
		"live2DModelName": "Model.model3.json",
		"modelLoadTime": 3021,
		"timeSinceModelLoaded": 419903,
		"numberOfLive2DParameters": 29,
		"numberOfLive2DArtmeshes": 136,
		"hasPhysicsFile": true,
		"numberOfTextures": 2,
		"textureResolution": 4096,
		"modelPosition": {
			"positionX": -0.1,
			"positionY": 0.4,
			"rotation": 9.33,
			"size": -61.9
		}
	}
}
```
`"modelLoaded"`는 모델이 현재 로드되어 있으면 `true`입니다. 모델이 로드되어 있지 않거나 모델이 현재 로드 중인 경우, 이 값은 false입니다. 이 경우 다른 모든 값은 비어 있거나(정수의 경우 0)입니다.

`"modelLoadTime"`은 현재 모델을 로드하는 데 걸린 시간(밀리초)입니다. `"timeSinceModelLoaded"`는 모델이 로드된 이후 경과한 시간(밀리초)을 포함합니다.

`"vtsModelIconName"`은 VTube Studio의 모델 선택 바에서 이 모델에 사용된 아이콘 이름을 포함합니다. 모델에 아이콘이 설정되어 있지 않으면 빈 문자열입니다. 이 요청에서 반환된 모든 파일 이름은 해당 모델 폴더를 기준으로 합니다.

`"modelPosition"` 배열에는 현재 모델의 위치, 회전 및 크기가 포함됩니다. 이러한 값을 해석하는 방법에 대한 자세한 내용은 `MoveModelRequest`를 참조하세요.

## 사용 가능한 VTS 모델 목록 가져오기

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "AvailableModelsRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "AvailableModelsResponse",
	"data": {
		"numberOfModels": 2,
		"availableModels": [
			{
				"modelLoaded": false,
				"modelName": "My First Model",
				"modelID": "UniqueIDToIdentifyThisModelBy1",
				"vtsModelName": "Model_1.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			},
			{
				"modelLoaded": true,
				"modelName": "My Second Model",
				"modelID": "UniqueIDToIdentifyThisModelBy2",
				"vtsModelName": "Model_2.vtube.json",
				"vtsModelIconName": "ModelIconPNGorJPG_1.png"
			}
		]
	}
}
```
`"modelLoaded"`는 해당 모델이 현재 VTube Studio에 로드되어 있으면 `true`, 그렇지 않으면 `false`입니다. 

## ID로 VTS 모델 로드하기

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ModelLoadRequest",
	"data": {
		"modelID": "UniqueIDOfModelToLoad"
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ModelLoadResponse",
	"data": {
		"modelID": "UniqueIDOfModelThatWasJustLoaded"
	}
}
```

이 요청은 현재 모델을 로드하거나 언로드할 수 없는 상태(예: 설정 창이 열려 있거나 모델 로드 작업이 이미 진행 중인 경우)에서는 실패하고 오류를 반환할 수 있습니다. 또한 이 요청에는 전역 2초 쿨다운이 적용됩니다.

빈 모델 ID를 전달하면 현재 로드된 모델이 언로드됩니다(모델이 로드되어 있지 않으면 아무 작업도 수행하지 않음).

## 현재 로드된 VTS 모델 이동

모델이 로드되어 있으면 위치, 회전 및 크기를 변경할 수 있습니다. 모델이 로드되어 있지 않으면 오류가 반환됩니다. 자세한 내용은 [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)를 참조하세요.

이 요청에서 필수 필드는 `"timeInSeconds"`와 `"valuesAreRelativeToModel"`입니다. `"timeInSeconds"`는 이동이 완료되는 데 걸리는 시간을 초 단위로 나타내며 0에서 2 사이의 부동 소수점 값이어야 합니다. 0으로 설정하면 모델이 지정된 위치에 즉시 나타납니다. 그 이상 값은 모델이 부드럽게 이동, 회전 및 크기 조절(페이드 인/아웃)되도록 합니다. 이동이 진행되는 동안 사용자는 모델을 직접 드래그하여 이동할 수 없습니다. 모델이 목적지에 도착한 후 약 0.5초 후에 다시 수동 이동이 가능해집니다.

진행 중인 작업이 끝나기를 기다리지 않고도 연속으로 `MoveModelRequest`를 보낼 수 있습니다. 진행 중인 요청이 있으면 중단되고 새 요청으로 대체됩니다. `"timeInSeconds"`를 0으로 설정하여 매 프레임마다 요청을 보내 이동을 완전히 제어할 수도 있습니다.

`"size"`는 -100(가장 작음)에서 +100(가장 큼) 사이의 부동 소수점 값으로 지정됩니다. `"positionX"`, `"positionY"`, `"rotation"`에 대한 자세한 내용은 다음 이미지를 참고하세요:

#### VTS 좌표계
![The VTS Coordinate System](/Images/coordinate_explanation.png)

고양이 그림의 숫자는 `"positionX"`와 `"positionY"`에 전달할 수 있는 **[X/Y]** 좌표를 나타냅니다. 예를 들어 [0/0]을 보내면 모델의 중앙이 화면 중앙에 배치됩니다. "모델의 중앙" 위치는 Live2D Cubism에서 자유롭게 설정할 수 있으며 모델마다 다를 수 있습니다. 물론 훨씬 크거나 작은 값을 보내 모델을 화면 밖으로 이동시킬 수도 있습니다. `"positionX"`와 `"positionY"` 값은 -1000에서 1000 사이여야 합니다.

원 주변의 숫자는 `"rotation"`에 설정할 수 있는 각도를 나타냅니다. 이 매개변수 값은 -360에서 360 사이여야 합니다. 각 각도에는 시계 방향 회전 시 양수, 반시계 방향 회전 시 음수 두 가지 표현이 있습니다. 어느 쪽을 사용해도 차이가 없으며, 사용자의 선택에 달려 있습니다. `CurrentModelRequest`를 보내면 응답에 모델의 위치/회전/크기가 포함되는데 이때 각도는 항상 양수 표기로 표시됩니다.

요청에 모든 값을 제공할 필요는 없습니다. 예를 들어 위치만, 회전만, 또는 다른 조합만 제공할 수 있습니다. 요청에 포함되지 않은 값은 위치/회전/크기 설정 시 무시됩니다. 이 기능을 활용하면 모델의 X 좌표만 변경하고 나머지는 그대로 둘 수 있습니다.

`"valuesAreRelativeToModel"`이 `false`로 설정되면 요청의 값이 절대값으로 간주되어 모델이 해당 위치로 이동합니다. `"valuesAreRelativeToModel"`이 `true`로 설정되면 값이 현재 모델 위치에 상대적인 값으로 간주됩니다. 예를 들어 `true`로 설정하고 회전 값만 10으로 포함하면, 현재 위치와 크기는 그대로 두고 모델이 시계 방향으로 10도 회전합니다. 이는 모델을 화면 내 위치와 상관없이 흔드는 등의 효과 구현에 매우 유용합니다.

모델을 고정된 픽셀 위치로 이동하거나 특정 픽셀 수만큼 이동하려면, 해당 좌표를 직접 계산해야 합니다. `StatisticsRequest`를 사용하여 창의 가로 및 세로 픽셀 크기를 얻어 계산할 수 있습니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "MoveModelRequest",
	"data": {
		"timeInSeconds": 0.2,
		"valuesAreRelativeToModel": false,
		"positionX": 0.1,
		"positionY": -0.7,
		"rotation": 16.3,
		"size": -22.5
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "MoveModelResponse",
	"data": { }
}
```


## 현재 또는 다른 VTS 모델에서 사용 가능한 단축키 목록 요청

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelRequest",
	"data": {
		"modelID": "Optional_UniqueIDOfModel",
		"live2DItemFileName": "Optional_Live2DItemFileName"
	}
}
```

"modelID"(및 여기서 "data" 객체 전체)는 선택 사항입니다. 제공되지 않으면 현재 모델의 단축키가 반환됩니다. 모델 ID가 제공되면 해당 모델 ID를 가진 모델의 단축키가 반환됩니다. 해당 ID를 가진 모델을 찾을 수 없으면 오류가 반환됩니다([ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs), `ModelIDNotFound` 참조).

이것은 사용 가능한 모든 Live2D 항목의 단축키도 반환할 수 있습니다. 그렇게 하려면 `"live2DItemFileName"` 필드에 항목의 파일 이름을 전달하면 됩니다. `ItemListRequest`를 사용하여 사용 가능한 모든 Live2D 항목의 (고유한) 파일 이름을 얻을 수 있습니다.

`"modelID"`와 `"live2DItemFileName"`이 모두 제공되면 `"modelID"`만 사용되며 다른 필드는 무시됩니다.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeysInCurrentModelResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"availableHotkeys": [
			{
				"name": "My first hotkey",
				"type": "ToggleExpression",
				"description": "Toggles an expression",
				"file": "myExpression_1.exp3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith1",
				"keyCombination": [],
                		"onScreenButtonID": 8
			},
			{
				"name": "My second hotkey",
				"type": "TriggerAnimation",
				"description": "Triggers an animation",
				"file": "myAnimation.motion3.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith2",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My third hotkey",
				"type": "ChangeVTSModel",
				"description": "Changes the VTS model",
				"file": "someOtherModel.vtube.json",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith3",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fourth hotkey",
				"type": "MoveModel",
				"description": "Moves the Live2D model",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith4",
				"keyCombination": [],
                		"onScreenButtonID": -1
			},
			{
				"name": "My fifth hotkey",
				"type": "Unset",
				"description": "No action set for hotkey",
				"file": "",
				"hotkeyID": "SomeUniqueIdToIdentifyHotkeyWith5",
				"keyCombination": [],
                		"onScreenButtonID": 5
			}
		]
	}
}
```
요청에 모델 ID가 지정되지 않았고 모델이 로드되지 않은 경우, `"modelLoaded"`는 false이며 `"availableHotkeys"` 배열은 비어 있습니다. ID가 지정된 경우, `"modelLoaded"` 필드는 주어진 ID의 모델이 현재 로드되어 있는지 여부에 따라 true 또는 false가 됩니다.

`"file"` 필드에는 `TriggerAnimation`, `ChangeIdleAnimation`, `ToggleExpression` 및 `ChangeVTSModel` 유형의 단축키에 대한 표현/애니메이션/모델 파일 이름이 포함됩니다. `ChangeBackground` 단축키의 경우, 파일 확장자를 제외한 배경 이름이 포함됩니다. 그 외 모든 유형에는 빈 문자열이 포함됩니다.

`"description"` 필드에는 단축키가 수행하는 작업에 대한 설명이 포함됩니다. 예를 들어, 단축키 유형이 VTube Studio에 새로 추가되어 플러그인이 알지 못하는 경우, 이 문자열을 플러그인 UI에 표시할 수 있습니다.

`"keyCombination"` 배열에는 단축키를 트리거하는 키보드(또는 마우스 키) 조합이 포함됩니다. 모든 가능한 값은 [RestrictedRawKey.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/RestrictedRawKey.cs)를 참조하세요. 배열이 비어 있으면 키 조합이 설정되지 않은 것입니다. **중요:** 보안상의 이유로 `"keyCombination"` 배열은 현재 **항상 비어 있으므로**, 이 데이터는 당분간 플러그인에서 사용할 수 없습니다. 향후 업데이트에서 다시 추가될 수 있습니다.

`"onScreenButtonID"` 필드에는 단축키를 트리거하는 모든 화면 버튼 ID가 포함됩니다(1(상단)부터 8(하단) 또는 -1). 값이 `-1`이면 이 단축키에 설정된 화면 버튼이 없습니다.

모든 단축키 유형 문자열은 [HotkeyActions.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/HotkeyAction.cs) 페이지에서 확인할 수 있습니다.

## 단축키 실행 요청

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerRequest",
	"data": {
		"hotkeyID": "HotkeyNameOrUniqueIdOfHotkeyToExecute",
		"itemInstanceID": "Optional_ItemInstanceIdOfLive2DItemToTriggerThisHotkeyFor"
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "HotkeyTriggerResponse",
	"data": {
		"hotkeyID": "UniqueIdOfHotkeyThatWasExecuted"
	}
}
```
이 명령은 `"itemInstanceID"`를 비워두거나 제공하지 않을 경우 현재 로드된 VTube Studio 모델의 핫키를 실행합니다. 해당 필드에 ID를 제공하면, 대신 지정된 Live2D 아이템 모델에서 핫키가 실행됩니다(자세한 내용은 아래 참고).

핫키는 고유 ID 또는 핫키 이름(대소문자 구분 없음)으로 실행할 수 있습니다. 동일한 이름을 가진 핫키가 여러 개일 경우, UI에 표시되는 순서대로 첫 번째 핫키만 실행됩니다. 이름이 비어 있는 핫키는 ID로만 실행할 수 있습니다.

핫키 ID나 이름을 찾을 수 없거나 핫키를 실행할 수 없는 경우 오류가 반환될 수 있습니다. 이유로는 현재 모델이 로드되지 않았거나 핫키 쿨다운이 끝나지 않은 경우(특정 핫키는 5프레임마다 한 번만 실행 가능)가 있습니다. 여러 핫키를 빠르게 연속으로 전송하면 큐에 저장됩니다. 5프레임마다 큐에서 하나의 핫키가 실행됩니다. 큐는 최대 32개의 핫키를 저장하며, 큐가 가득 찼는데 더 많은 핫키를 보내면 오류가 반환됩니다.

### Live2D 아이템에서 핫키 실행

이 요청을 사용해 Live2D 아이템 내 핫키를 실행할 수도 있습니다. Live2D 아이템에 대한 자세한 내용은 [이 페이지](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)를 참고하세요.

이를 위해 `"itemInstanceID"`를 Live2D 아이템의 인스턴스 ID로 설정하세요. 해당 인스턴스 ID를 가진 Live2D 아이템이 로드되어 있지 않으면 오류가 반환됩니다. 현재 로드된 모든 아이템의 인스턴스 ID는 `ItemListRequest`를 통해 확인할 수 있습니다.

## 현재 표정 상태 목록 요청

특정 표정 하나 또는 모든 표정의 현재 상태(활성 또는 비활성)를 가져올 수 있습니다. `"expressionFile"`을 포함하면 해당 표정의 상태만 반환됩니다. 포함하지 않거나 빈 문자열로 두면 현재 모델 내 모든 표정의 상태가 반환됩니다.

파일 이름을 포함했지만 유효하지 않거나(`.exp3.json`으로 끝나지 않음) 현재 모델에 없으면 오류가 반환됩니다(자세한 내용은 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)" 참고).

`"details"`를 true로 설정하면 응답에 더 많은 세부 정보가 포함됩니다(구체적으로 `"usedInHotkeys"`와 `"parameters"` 배열은 `"details"`가 false일 경우 비어 있습니다).

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionStateRequest",
	"data": {
		"details": true,
		"expressionFile": "myExpression_optional_1.exp3.json",
	}
}
```
`expressions` 배열은 모델이 로드되지 않은 경우 비어 있습니다. 그렇지 않으면 현재 로드된 모델에 사용 가능한 표정에 대한 정보가 포함됩니다.

`"file"` 필드는 모델 폴더에 저장된 표정의 파일 이름입니다. `"name"`은 `.exp3.json` 확장자 없이 동일한 이름입니다. `"active"`는 해당 표정이 현재 활성화되어 있는지 여부를 나타냅니다.

표정이 단축키를 사용하여 활성화된 경우, `"deactivateWhenKeyIsLetGo"` 및 `"autoDeactivateAfterSeconds"`는 해당 옵션들이 표정 단축키에 대해 활성화되었는지 여부를 알려줍니다. `"autoDeactivateAfterSeconds"`가 `true`이면 표정이 자동으로 비활성화되기까지 남은 시간이 `"secondsRemaining"`에 반환됩니다(그렇지 않으면 0입니다).

요청에서 `"details"`가 `true`로 설정된 경우 `"usedInHotkeys"` 배열에는 이 표정이 사용된 모든 단축키 목록이 포함됩니다. 또한 `"parameters"` 배열에는 표정의 내용, 즉 표정에 사용된 모든 Live2D 파라미터 ID와 목표 값이 포함됩니다.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionStateResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"expressions": [
			{
				"name": "myExpression_optional_1",
				"file": "myExpression_optional_1 .exp3.json",
				"active": false,
				"deactivateWhenKeyIsLetGo": false,
				"autoDeactivateAfterSeconds": false,
				"secondsRemaining": 0,
				"usedInHotkeys": [
					{
						"name": "Some Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith1"
					},
					{
						"name": "Some other Hotkey",
						"id": "SomeUniqueIdToIdentifyHotkeyWith2"
					}
				],
				"parameters": [
					{
						"name": "SomeLive2DParamID",
						"value": 0
					}
				]
			}
		]
	}
}
```
## 표현 활성화 또는 비활성화 요청

표현은 핫키를 통해 활성화하는 것이 권장됩니다. 그렇지 않으면 사용자가 핫키를 설정하지 않아 비활성화할 수 없는 활성화된 표현을 가지게 될 수 있기 때문입니다. 그러나 플러그인에 필요하다면 핫키를 직접 활성화하거나 비활성화할 수도 있습니다. 이는 표현 파일 이름과 표현을 활성화할지 비활성화할지를 전달하여 수행합니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ExpressionActivationRequest",
	"data": {
		"expressionFile": "myExpression_1.exp3.json",
		"fadeTime": 0.5,
		"active": true
	}
}
```
요청이 성공하면 이 빈 응답을 받게 됩니다. 파일 이름이 유효하지 않거나(`.exp3.json`으로 끝나지 않음), 현재 모델에 없거나 모델이 로드되지 않은 경우 오류가 반환됩니다(자세한 내용은 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)" 참조).  
`fadeTime` 매개변수는 0초에서 2초 사이로 제한됩니다. 기본값은 0.25입니다. 페이드 시간은 VTS 애니메이션 시스템의 제한으로 인해 페이드 인 중에만 설정할 수 있다는 점에 유의하세요. 표현을 페이드 아웃할 때는 페이드 인 시 사용된 시간과 동일한 시간이 항상 사용됩니다.  

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ExpressionActivationResponse",
	"data": { }
}
```

## 현재 모델의 ArtMesh 목록 요청

API는 `ArtMesh Name`이라는 용어를 사용하지만, 이는 실제로 Live2D Cubism Editor에서 강제하는 모델별 고유한 ArtMesh ID를 의미합니다. `ArtMesh Tags`는 ArtMesh를 선택하고 UserData 필드에 작성하여 추가할 수 있습니다. 태그를 사용하려면 `Export UserData file (userdata3.json)`을 반드시 체크해야 합니다. 그런 다음 모델을 VTube Studio Live2DModels 폴더에 복사할 때 `.userdata3.json` 파일도 포함해야 합니다.

`"artMeshTags"` 배열에 반환된 ArtMesh 태그는 중복 태그를 포함하지 않습니다.

모델이 로드되지 않은 경우 `"modelLoaded"`는 `false`이며 배열은 비어 있습니다.

**태그에 대한 참고:** 태그는 Live2D Cubism Editor의 "UserData" 필드에서 ArtMesh에 추가할 수 있습니다. 편집기에서 해당 필드에 어떤 텍스트든 추가할 수 있습니다. VTube Studio는 해당 텍스트를 공백과 줄바꿈 문자로 분할합니다. 즉, 태그 텍스트가 "my tag"라면 VTS에서는 두 개의 태그 "my"와 "tag"로 나뉩니다. 각 ArtMesh에 원하는 만큼 태그를 추가할 수 있습니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshListRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshListResponse",
	"data": {
		"modelLoaded": true,
		"numberOfArtMeshNames": 5,
		"numberOfArtMeshTags": 2,
		"artMeshNames": ["ArtMesh1", "ArtMesh2", "HairFront1", "HairFront2", "SomeArtMesh"],
		"artMeshTags": ["my_tag", "SomeOtherTag"]
	}
}
```
## Tint ArtMeshes with color

색상과 일치 기준을 제공하여 ArtMesh에 색조를 입힐 수 있습니다. 주어진 기준 중 어느 하나와 일치하는 모든 ArtMesh는 지정된 색상으로 색조가 입혀집니다. ArtMesh 색상을 초기화하려면 흰색(R=G=B=A=255)으로 색조를 입히십시오. 이 요청으로 ArtMesh를 흰색으로 만들 수는 없으며, 더 어둡게만 만들 수 있습니다.

색상 값 중 하나라도 제공하지 않거나 0-255 범위를 벗어나면 오류가 반환됩니다. 모델이 로드되지 않은 상태에서 이 요청을 보내면 오류가 반환됩니다.

선택적으로 0에서 1 사이의 `mixWithSceneLightingColor`를 제공할 수 있습니다. 제공하면 이 값이 색조 색상과 장면 조명 시스템 색상이 혼합되는 방식을 결정합니다(자세한 내용은 [여기](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay) 참조). 1로 설정하면 제공한 색상 값이 장면 조명에 의해 설정된 값을 완전히 덮어씁니다. 0으로 설정하면 장면 조명 색상이 제공한 색상을 덮어씁니다. 중간 값은 두 색상을 혼합합니다. 장면 조명이 꺼져 있으면 이 설정은 효과가 없습니다. `mixWithSceneLightingColor`를 제공하지 않으면 기본값은 1로 설정되어 제공한 색상이 장면 조명을 완전히 덮어씁니다.

`"artMeshMatcher"` 객체에 포함된 모든 배열은 선택 사항입니다. 포함하면 ArtMesh 이름이나 태그가 주어진 문자열과 정확히 일치하거나(`"nameContains"`/`"tagContains"` 배열 사용 시 포함하는 경우) 여부에 따라 ArtMesh를 선택합니다. `"artMeshNumber"` 배열은 모델 내에서의 순서에 따라 ArtMesh를 선택할 수 있게 합니다. 모델 전체에 색조를 입히려면 매처 배열을 포함하지 말고 대신 `"tintAll"`을 true로 설정하십시오.

세션이 종료되면 이 세션에서 색조가 입혀진 모든 ArtMesh는 기본값(완전 불투명한 흰색)으로 초기화됩니다. 여러 플러그인/세션이 하나의 ArtMesh 색상을 덮어쓸 경우 가장 최근 요청에 의해 설정된 색상을 갖습니다.

일치는 항상 **대소문자 구분 없이(case-insensitive)** 수행됩니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ColorTintRequest",
	"data": {
		"colorTint": {
			"colorR": 255,
			"colorG": 150,
			"colorB": 0,
			"colorA": 255,
			"mixWithSceneLightingColor": 1
		},
		"artMeshMatcher": {
			"tintAll": false,
			"artMeshNumber": [1, 3, 5],
			"nameExact": ["eye_white_left", "eye_white_right"],
			"nameContains": ["mouth"],
			"tagExact": [],
			"tagContains": ["MyTag"]
		}
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ColorTintResponse",
	"data": {
		"matchedArtMeshes": 3
	}
}
```

## 장면 조명 오버레이 색상 가져오기

VTube Studio는 화면(macOS/Windows) 또는 특정 창(Windows 전용)에서 캡처한 평균 색상으로 모델에 오버레이를 적용하는 기능을 제공합니다. 자세한 내용은 [이 문서 페이지](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)를 참조하세요.

API를 통해 장면 조명 오버레이 시스템에 대한 현재 사용자 설정 및 색상을 가져올 수 있습니다.

응답의 최상위 수준에는 조명 오버레이가 켜져 있는지 여부를 알려주는 `active` 필드가 있습니다. `itemsIncluded`가 true이면 모든 항목이 조명 오버레이의 영향을 받습니다. `isWindowCapture`가 `true`이면 VTube Studio가 창의 평균 색상을 캡처하도록 설정된 것입니다. `false`이면 화면을 캡처하도록 설정된 것입니다.

`baseBrightness`(0~100 사이), `colorBoost`(0~100 사이) 및 `smoothing`(0~60 사이)은 사용자가 UI의 슬라이더를 통해 선택할 수 있는 세 가지 값입니다. 자세한 설명은 [이 기능에 대한 문서 페이지](https://github.com/DenchiSoft/VTubeStudio/wiki/Display-Light-Overlay)를 확인하세요.

`leftCapturePart`, `middleCapturePart` 및 `rightCapturePart`는 캡처된 창 또는 화면의 각각 부분의 평균 색상을 설명합니다. 이들의 `active` 필드는 해당 화면 부분이 사용자가 활성화했는지 여부를 알려줍니다.

모든 활성화된 화면 부분에서 계산된 평균 색상은 `colorAvg` 필드(R, G, B는 0~255 사이)에 있습니다.

ArtMeshes에 오버레이될 최종 색상은 `colorOverlay` 필드(R, G, B는 0~459 사이)에 있습니다. 이 값은 255보다 큰 값을 허용합니다. 최종 색상은 다음과 같이 계산됩니다:

`colorAvg` *  (`colorBoost` / 50) + `WHITE_COLOR` * (`baseBrightness` / 100)

이로 인해 R, G, B 값이 최대 2 * 255까지 나올 수 있습니다. 값은 1.8 * 255 = 459로 제한됩니다.

조명 오버레이 시스템이 꺼져 있으면 최상위 페이로드 수준의 `active`가 `false`가 되고 모든 색상은 흰색으로 반환됩니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SceneColorOverlayInfoResponse",
	"data": {
		"active": true,
		"itemsIncluded": true,
		"isWindowCapture": false,
		"baseBrightness": 16,
		"colorBoost": 35,
		"smoothing": 6,
		"colorOverlayR": 206,
		"colorOverlayG": 150,
		"colorOverlayB": 153,
		"colorAvgR": 237,
		"colorAvgG": 157,
		"colorAvgB": 162,
		"leftCapturePart": {
			"active": true,
			"colorR": 243,
			"colorG": 231,
			"colorB": 234
		},
		"middleCapturePart": {
			"active": true,
			"colorR": 230,
			"colorG": 83,
			"colorB": 89
		},
		"rightCapturePart": {
			"active": false,
			"colorR": 235,
			"colorG": 95,
			"colorB": 101
		}
	}
}
```

## 트래커가 현재 얼굴을 찾았는지 확인하기

활성화된 트래커(네트워크/USB를 통한 스마트폰 또는 웹캠 트래커)가 현재 얼굴을 찾았는지 여부를 반환합니다.

**`요청`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "FaceFoundRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "FaceFoundResponse",
	"data": {
		"found": true
	}
}
```

## 사용 가능한 추적 매개변수 목록 요청

현재 VTube Studio에서 사용 가능한 매개변수 목록을 요청할 수 있습니다.
여기에는 모든 일반 매개변수와 플러그인에서 생성된 모든 사용자 정의 매개변수가 포함됩니다. 플러그인에서 생성된 매개변수는 VTube Studio의 매개변수 목록에서 선택할 때 해당 항목으로 표시됩니다. 또한 해당 매개변수를 생성한 플러그인의 이름도 표시됩니다.

**중요:** 이 요청은 많은 데이터를 반환할 수 있습니다. 느린 PC에서 성능 문제를 일으킬 수 있으므로 높은 빈도(60FPS 이상)로 이 요청을 보내는 것은 권장하지 않습니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InputParameterListRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InputParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"customParameters": [
			{
				"name": "MyCustomParamName1",
				"addedBy": "My Plugin Name",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName2",
				"addedBy": "My Plugin Name",
				"value": 0.833,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			},
			{
				"name": "MyCustomParamName3",
				"addedBy": "My Other Plugin Name",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		],
		"defaultParameters": [
			{
				"name": "FaceAngleX",
				"addedBy": "VTube Studio",
				"value": 45.78,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "FacePositionX",
				"addedBy": "VTube Studio",
				"value": 8.33,
				"min": -10,
				"max": 10,
				"defaultValue": 0
			}
		]
	}
}
```
**참고:** 이 예제 페이로드의 `"defaultParameters"` 배열은 완전하지 않습니다. 이 배열은 VTube Studio에서 제공하는 모든 기본 얼굴/입/기타 추적 매개변수를 포함합니다.

## 특정 매개변수 하나의 값을 가져오기, 기본 또는 사용자 정의

요청한 입력 매개변수가 존재하지 않으면 오류가 반환됩니다.

**`요청`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterValueRequest",
	"data": {
		"name": "MyCustomParamName1"
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterValueResponse",
	"data": {
		"name": "MyCustomParamName1",
		"addedBy": "My Plugin Name",
		"value": 12.4,
		"min": -30,
		"max": 30,
		"defaultValue": 0
	}
}
```
## 현재 모델에 있는 모든 Live2D 파라미터 값 가져오기

모델이 로드되지 않은 경우 오류가 발생합니다.

**`요청`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "Live2DParameterListRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "Live2DParameterListResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"parameters": [
			{
				"name": "MyLive2DParameterID1",
				"value": 12.4,
				"min": -30,
				"max": 30,
				"defaultValue": 0
			},
			{
				"name": "MyLive2DParameterID2",
				"value": 0,
				"min": 0,
				"max": 1,
				"defaultValue": 0
			}
		]
	}
}
```
모델이 로드되지 않은 경우, `"modelLoaded"`는 false이고 파라미터 배열은 비어 있습니다. 다른 모든 필드는 빈 문자열입니다.

## 새로운 트래킹 파라미터 추가 ("커스텀 파라미터")

자신만의 새로운 트래킹 파라미터를 추가하여 VTube Studio 모델에서 사용할 수 있습니다. 이를 "커스텀" 파라미터라고 합니다. 플러그인에서 추가한 후 사용자는 Live2D 파라미터 매핑의 입력값으로 해당 파라미터를 선택할 수 있습니다.

파라미터 이름은 고유해야 하며, 영숫자(공백 불가)로 4자 이상 32자 이하이어야 합니다. 새로운 트래킹 파라미터는 다음과 같이 생성됩니다:

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterCreationRequest",
	"data": {
		"parameterName": "MyNewParamName",
		"explanation": "This is my new parameter.",
		"min": -50,
		"max": 50,
		"defaultValue": 10
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterCreationResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```
요청은 매개변수 이름이 잘못된 경우 실패하고 오류를 반환할 수 있습니다.

동일한 이름의 매개변수가 다른 플러그인에 의해 이미 생성된 경우에도 실패합니다. 동일한 플러그인 이름으로 매개변수를 여러 번 생성하면 요청은 성공합니다. 이 방법으로 `min`, `max` 및 `defaultValue` 값을 덮어쓸 수도 있습니다.

최소/최대/기본값은 `-1000000`과 `1000000` 사이의 부동 소수점 숫자여야 합니다. 최소/최대 값은 실제로 매개변수에 허용되는 최소 및 최대 값이 아닙니다. 이는 이 매개변수를 사용하여 새 매개변수 매핑이 생성될 때 기본 하한 및 상한 값으로 사용되는 값입니다.

설명은 선택 사항이며, 매개변수가 수행하는 작업과 사용자가 모델에서 이를 어떻게 사용해야 하는지에 대한 짧은(256자 미만) 설명입니다. 요청 시 이를 제공하면 사용자가 이 사용자 지정 매개변수의 세부 정보를 볼 때 표시됩니다.

VTS에는 전역적으로 300개의 사용자 지정 매개변수 제한과 플러그인당 100개의 사용자 지정 매개변수 제한이 있습니다. 이를 초과하여 생성하려고 하면 오류가 반환됩니다.

생성한 사용자 지정 매개변수는 VTube Studio 구성의 일부로 `Config` 폴더에 있는 `custom_parameters.json` 파일에 저장됩니다. 이 폴더는 VTube Studio의 `StreamingAssets` 폴더 내에 위치합니다. 플러그인의 인증 토큰을 취소하면 이 플러그인이 생성한 모든 사용자 지정 매개변수도 삭제됩니다. 해당 매개변수는 이를 사용한 VTube Studio 모델에 여전히 설정되어 있지만 입력 매개변수가 더 이상 존재하지 않음을 나타내는 빨간색 텍스트로 표시됩니다. 플러그인은 언제든지 다른 토큰을 받아 이 매개변수를 다시 생성할 수 있으며 계속 작동합니다.

## 사용자 지정 매개변수 삭제

사용자 지정 매개변수를 삭제할 수 있습니다. 기본 매개변수는 삭제할 수 없습니다. 또한 이 세션을 인증하는 데 사용한 플러그인이 아닌 다른 플러그인이 생성한 매개변수는 삭제할 수 없습니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ParameterDeletionRequest",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ParameterDeletionResponse",
	"data": {
		"parameterName": "MyNewParamName"
	}
}
```

## 기본 또는 사용자 정의 매개변수에 데이터 입력

기본 또는 사용자 정의 매개변수에 데이터를 입력할 수 있습니다. 이 추적 매개변수들은 로드된 VTube Studio 모델과 로드된 [Live2D 아이템](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)의 입력값으로 사용됩니다.

페이로드는 다음과 같습니다:

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "InjectParameterDataRequest",
	"data": {
		"faceFound": false,
		"mode": "set",
		"parameterValues": [
			{
				"id": "FaceAngleX",
				"value": 12.31
			},
			{
				"id": "MyNewParamName",
				"weight": 0.8,
				"value": 0.7
			}
		]
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "InjectParameterDataResponse",
	"data": { }
}
```
하나 이상의 파라미터가 존재하지 않는 경우, 오류 페이로드가 반환됩니다.

값은 `-1000000`과 `1000000` 사이의 부동 소수점 숫자여야 합니다. 이 범위를 벗어나는 값도 오류를 반환합니다.

웹캠/iOS/Android 추적에서 해당 파라미터에 대한 값이 존재하는 경우, API에서 제공하는 값이 API를 통해 데이터를 계속 전송하는 한 그 값을 덮어씁니다.
플러그인으로 제어하려는 파라미터에 대한 데이터를 **최소 1초에 한 번씩** 다시 전송해야 합니다. 그렇지 않으면 해당 파라미터가 "손실된" 것으로 간주되어 이전에 제어하던 값으로 돌아갑니다. 다른 제어 주체가 없으면 기본값으로 돌아갑니다.

또한 0과 1 사이의 선택적 `"weight"` 파라미터를 추가할 수 있습니다. 이 파라미터는 API로 전송한 `"value"`와 얼굴 추적에서 설정된 값의 혼합 비율을 조절하는 데 사용됩니다. 예를 들어, 얼굴 추적으로 50%, API로 50% 제어할 수 있습니다. 단, 하나의 파라미터에 대해 동시에 하나의 API 플러그인만 쓸 수 있습니다. 이 기능은 API를 통해 제어를 시작할 때 파라미터가 갑자기 "튀는" 현상을 방지하기 위해 페이드 인/아웃하는 데 유용할 수 있습니다. 요청에 `"weight"` 파라미터가 포함되지 않으면 값이 1로 간주되어 대상 파라미터가 플러그인이 제공한 값으로 즉시 설정됩니다.

이 파라미터들은 일반 추적 파라미터와 유사하게 취급됩니다. 따라서 VTube Studio 파라미터 매핑에서 일반 입력으로 선택할 수 있으며 UI의 슬라이더를 통해 스무딩을 적용할 수 있습니다. 모델이 파라미터를 사용하는 동안 커스텀 파라미터를 삭제해도 문제가 발생하지 않으며 언제든지 다시 생성할 수 있습니다.

선택적으로 `"faceFound": true`를 전달할 수 있으며, 이를 통해 VTube Studio에 사용자 얼굴이 인식되었음을 알릴 수 있습니다. 이를 통해 "추적 손실" 애니메이션 재생 시점을 제어할 수 있습니다.

### 여러 플러그인으로 하나의 파라미터 제어하기

일반적으로 다른 플러그인이 이미 하나의 (기본 또는 커스텀) 파라미터를 제어하고 있으면 오류가 반환됩니다. 이는 한 번에 하나의 플러그인만 특정 파라미터를 "설정"(덮어쓰기)할 수 있기 때문이며, 이는 `"mode"` 필드에 값을 제공하지 않거나 `"set"`으로 설정했을 때의 기본 모드입니다.

대신 `"mode"` 필드를 `"add"`로 설정할 수 있습니다. 이 경우 전송한 값이 현재 파라미터 값에 더해집니다. `"weight"` 값은 이 모드에서 사용되지 않습니다. 여러 플러그인이 동시에 하나의 파라미터에 `"add"` 모드를 사용할 수 있습니다. 이 기능은 **bonk/throwing** 타입 플러그인 및 기타 용도에 유용합니다.

## 현재 로드된 VTS 모델의 물리 설정 가져오기

사용자는 VTube Studio에서 물리 설정을 사용자화할 수 있습니다. 다음 설정을 변경할 수 있습니다:

- **기본 물리 강도 (모델별):** 0(꺼짐)에서 100(최대) 사이의 정수. 기본값은 50으로 Live2D Cubism Editor와 동일한 물리 동작을 의미합니다.
- **기본 바람 강도 (모델별):** 0(꺼짐)에서 100(최대) 사이의 정수. 기본값은 0입니다.
- **물리 곱셈 계수 (물리 그룹별):** 각 물리 그룹(Live2D Cubism에서 설정 가능)에 대해 곱셈 계수를 설정할 수 있습니다. 해당 물리 그룹 처리 시 기본 물리 값에 이 값이 곱해집니다. 0에서 2 사이의 부동 소수점이며, 기본값은 1로 기본값 유지입니다.
- **바람 곱셈 계수 (물리 그룹별):** 각 물리 그룹(Live2D Cubism에서 설정 가능)에 대해 곱셈 계수를 설정할 수 있습니다. 해당 물리 그룹 처리 시 기본 바람 값에 이 값이 곱해집니다. 0에서 2 사이의 부동 소수점이며, 기본값은 1로 기본값 유지입니다.

사용자가 설정한 이 값들은 API를 통해 읽을 수 있으며 일시적으로 덮어쓸 수도 있습니다(`SetCurrentModelPhysicsRequest` 참고).

현재 로드된 모델의 값을 읽으려면 다음 요청을 사용하세요:


**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsRequest"
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "GetCurrentModelPhysicsResponse",
	"data": {
		"modelLoaded": true,
		"modelName": "My Currently Loaded Model",
		"modelID": "UniqueIDOfModel",
		"modelHasPhysics": true,
		"physicsSwitchedOn": true,
		"usingLegacyPhysics": false,
		"physicsFPSSetting": -1,
		"baseStrength": 50,
		"baseWind": 17,
		"apiPhysicsOverrideActive": false,
		"apiPhysicsOverridePluginName": "",
		"physicsGroups": [
			{
				"groupID": "PhysicsSetting1",
				"groupName": "Hair Front Physics",
				"strengthMultiplier": 1.5,
				"windMultiplier": 0.3
			},
			{
				"groupID": "PhysicsSetting2",
				"groupName": "Clothes Physics",
				"strengthMultiplier": 1,
				"windMultiplier": 2
			}
		]
	}
}
```
모델이 로드되지 않은 경우, `modelLoaded`는 `false`가 됩니다. 이 경우 다른 모든 값은 의미가 없으며 `physicsGroups` 배열은 비어 있습니다.

모델이 로드된 경우, `modelHasPhysics` 필드는 모델에 유효한 물리 설정이 있는지 여부를 알려줍니다. 일부 모델은 물리 설정이 없거나 물리 파일이 손상되어 물리 시스템이 제대로 시작되지 않을 수 있습니다. `physicsSwitchedOn`은 사용자가 VTube Studio에서 이 모델에 대해 `Use Physics` 토글을 활성화했는지 여부를 나타냅니다. `usingLegacyPhysics`는 `Legacy Physics` 토글의 상태입니다.

`physicsFPSSetting`은 이 모델의 물리 FPS 설정을 포함하며 30, 60, 120 또는 -1일 수 있는데, -1은 사용자가 `Use same FPS as app`을 선택했음을 나타냅니다.

`apiPhysicsOverrideActive` 및 `apiPhysicsOverridePluginName` 필드는 플러그인이 현재 일부 물리 설정을 재정의하고 있는지 여부를 나타냅니다. 활성 필드가 true이면 이름 필드에는 플러그인 이름이 포함됩니다. 한 번에 하나의 플러그인만 물리 시스템을 제어할 수 있습니다. 이는 `SetCurrentModelPhysicsRequest` 요청의 일부로도 설명됩니다.

`SetCurrentModelPhysicsRequest`를 사용하여 물리 또는 바람 기본값이나 승수를 재정의하는 경우, 이러한 변경 사항은 이 Get-Request에 **반영되지 않습니다**. 자체적으로 물리 재정의를 기억해야 합니다.

`physicsGroup` 배열에 대한 참고: 모든 그룹에는 ID가 있지만 모든 그룹에 이름이 있는 것은 아닙니다. 이 경우 해당 `groupName` 필드는 빈 문자열이 됩니다.

## 현재 로드된 VTS 모델의 물리 설정 재정의

이 요청을 사용하여 현재 로드된 모델의 물리 설정을 재정의할 수 있습니다. 이 API를 통해 한 플러그인이 물리 시스템의 제어권을 얻으면, 첫 번째 플러그인이 제어권을 포기할 때까지 다른 플러그인은 이 API를 사용할 수 없습니다. 이를 시도하면 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"(`SetCurrentModelPhysicsRequestPhysicsControlledByOtherPlugin`)에 명시된 해당 오류가 반환됩니다. 또한 모델이 로드되지 않았거나 제공한 물리 그룹 ID 중 하나라도 현재 모델에 존재하지 않거나 재정의 값이 누락된 경우에도 오류가 반환됩니다.

사용자가 현재 로드된 모델에 대해 물리를 끈 경우, 이 API를 사용하여 물리를 켤 수 없습니다. 물리/바람 기본값 및 승수만 이 API로 재정의할 수 있습니다.

위 `GetCurrentModelPhysicsRequest` 섹션에서 설명한 바와 같이, 물리/바람 승수 값은 0에서 2 사이여야 하며, 물리/바람 기본값은 0에서 100 사이의 정수여야 합니다(앱에서 사용자에게 표시되는 방식과 동일함). 이 범위를 벗어난 값은 자동으로 제한됩니다.

특정 물리 그룹에 대한 힘 또는 바람 승수를 설정하려면, 해당 그룹 ID와 `setBaseValue`가 false로 설정된 `strengthOverrides` 및 `windOverrides` 배열을 사용하십시오. `setBaseValue`를 true로 설정하면 제공된 값이 특정 그룹 대신 물리 힘 또는 바람의 기본값으로 설정됩니다. 이 경우 그룹 ID(`id`)를 비워 둘 수 있습니다.

일반적으로 이 API를 사용하여 설정된 값은 앱에서 사용자가 설정한 값을 재정의하는 데 사용됩니다. 실제로 사용자 UI에 표시되지 않으며 저장되지 않습니다. 이 API를 사용하여 설정된 재정의 값은 타이머(`overrideSeconds`)가 만료되면 자동으로 해제됩니다. 재정의를 유지하려면 이 요청을 반복해서 보내야 합니다.

모든 타이머가 만료되면, API는 플러그인이 물리 시스템을 제어한다고 더 이상 간주하지 않으므로 다른 플러그인이 물리 시스템 제어를 시작할 수 있습니다.

재정의 타이머 값은 0.5초에서 5초 사이여야 합니다. 이 범위를 벗어난 값은 자동으로 제한됩니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsRequest",
	"data": {
		"strengthOverrides": [
			{
				"id": "PhysicsSetting1",
				"value": 1.5,
				"setBaseValue": false,
				"overrideSeconds": 2
			}
		],
		"windOverrides": [
			{
				"id": "",
				"value": 85,
				"setBaseValue": true,
				"overrideSeconds": 5
			}
		]
	}
}
```

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "SetCurrentModelPhysicsResponse",
	"data": { }
}
```

## NDI 설정 가져오기 및 설정하기

API를 통해 현재 NDI 설정을 요청하고 변경할 수 있습니다. 이를 통해 NDI를 켜거나 끄고, 사용자 지정 고정 해상도를 설정하는 등 다양한 작업이 가능합니다.

NDI에 대한 정보와 VTube Studio에서 사용하는 방법은 다음 페이지에서 확인할 수 있습니다: https://github.com/DenchiSoft/VTubeStudio/wiki/Streaming-to-Mac-PC

`"setNewConfig"`를 `false`로 설정하면 현재 구성만 반환됩니다. 이 경우 다른 모든 필드는 무시됩니다. `true`로 설정하면 주어진 구성이 유효할 경우 설정됩니다.

`"ndiActive"`는 NDI를 켜거나 끕니다. NDI가 켜져 있으면 `"useNDI5"`는 NDI 4 대신 NDI 5를 사용합니다(저는 NDI 5 사용을 권장합니다).

`"useCustomResolution"`를 `true`로 설정하면 NDI 스트림이 더 이상 VTube Studio 창과 같은 해상도를 가지지 않고 UI를 통해 설정된 사용자 지정 해상도를 사용합니다. 이 해상도는 `"customWidthNDI"` 및 `"customHeightNDI"` 필드를 사용하여 API를 통해서도 변경할 수 있습니다. 두 값은 256에서 8192 사이여야 하며, 너비는 16의 배수, 높이는 8의 배수여야 합니다. 요청에서 두 값을 모두 `-1`로 설정하면 이들 설정을 건너뛰고 불리언 필드만 설정합니다. 이렇게 하면 예를 들어 해상도를 변경하지 않고 NDI를 켜거나 끌 수 있습니다.

NDI 해상도가 창 해상도와 다르면 VTube Studio가 자동으로 비디오 스트림을 잘라내고 크기를 조정합니다. VTube Studio는 항상 종횡비가 올바른지 확인하며, 필요 시 상단/하단 또는 좌/우 부분을 잘라냅니다.

**중요:** 이 요청에는 3초의 쿨다운 기간이 있습니다. 너무 빨리 실행하면 `NDIConfigCooldownNotOver` 유형의 오류를 반환합니다(자세한 내용은 "[ErrorID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)" 참고).

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "NDIConfigRequest",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```
응답에는 현재 설정(새 구성을 설정하도록 요청한 경우 새 설정)만 포함됩니다. 응답에서 `"setNewConfig"` 필드는 아무런 의미가 없습니다.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "NDIConfigResponse",
	"data": {
		"setNewConfig": true,
		"ndiActive": true,
		"useNDI5": true,
		"useCustomResolution": true,
		"customWidthNDI": 1024,
		"customHeightNDI": 512
	}
}
```

## 사용 가능한 아이템 목록 또는 장면 내 아이템 목록 요청

이 요청은 현재 장면에 있는 아이템 목록을 요청할 수 있습니다. 또한 Live2D 아이템, 애니메이션 폴더 등 사용자의 PC에서 로드할 수 있는 아이템 파일 목록을 요청할 수 있습니다.

현재 아이템을 로드할 수 있는 오더-스팟이 어떤 것들이 있는지 알고 싶으면 `"includeAvailableSpots"`를 `true`로 설정하세요. 그렇지 않으면 응답의 `"availableSpots"` 배열은 비어 있습니다.

현재 장면에 어떤 아이템들이 로드되어 있는지 알고 싶으면 `"includeItemInstancesInScene"`을 `true`로 설정하세요. 그렇지 않으면 응답의 `"itemInstancesInScene"` 배열은 비어 있습니다.

로드 가능한 아이템 파일이 어떤 것들이 있는지 알고 싶으면 `"includeAvailableItemFiles"`를 `true`로 설정하세요. 그렇지 않으면 응답의 `"availableItemFiles"` 배열은 비어 있습니다. **중요:** 이 옵션은 사용자의 PC에서 아이템 파일 전체 목록을 읽습니다. 이로 인해 앱이 잠시 지연될 수 있으니 `"includeAvailableItemFiles"`를 `true`로 설정한 상태로 이 요청을 자주 사용하지 마세요. 아이템 파일 목록을 새로 고쳐야 할 때만 사용하고, 그 외의 경우에는 `false`로 설정하세요.

#### 특정 아이템 필터링

특정 아이템 인스턴스 ID나 특정 파일명을 가진 아이템만 목록에 포함시키고 싶으면 각각 `"onlyItemsWithInstanceID"`와 `"onlyItemsWithFileName"` 필드에 제공할 수 있습니다.

장면에는 특정 인스턴스 ID를 가진 아이템이 최대 한 개만 있을 수 있지만, 동일한 파일명을 가진 아이템이 여러 개 있을 수 있습니다. 이는 동일한 아이템 파일을 기반으로 여러 인스턴스를 로드할 수 있기 때문입니다.

또한 **아이템 파일명은 고유**하며, 동일한 파일명이 두 개 있을 수 없습니다. 파일명은 **대소문자를 구분**하므로 특정 파일을 지정할 때는 대소문자를 변경하지 않도록 주의하세요.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemListRequest",
	"data": {
		"includeAvailableSpots": true,
		"includeItemInstancesInScene": true,
		"includeAvailableItemFiles": false,
		"onlyItemsWithFileName": "OPTIONAL_my_item_filename.png",
		"onlyItemsWithInstanceID": "OPTIONAL_InstanceIdOfItemInScene"
	}
}
```
응답의 필드는 대부분 자체 설명적이어야 합니다.

파일 이름은 아이템 파일의 이름입니다. 이는 아이템 인스턴스를 씬에 불러오는 데 사용할 수 있는 이름입니다. JPG/PNG/GIF 아이템의 경우 파일 확장자를 포함한 전체 파일 이름(경로 제외)입니다(예: "my_item.jpg"). 애니메이션 폴더의 경우 폴더 이름입니다. Live2D 아이템의 경우에도 폴더 이름입니다.

아이템 유형은 `"type"` 필드에서 찾을 수 있습니다. 가능한 값은 `PNG`, `JPG`, `GIF`, `AnimationFolder` 또는 `Live2D`입니다. 또 다른 가능한 값은 `Unknown`입니다. 이는 API가 업데이트되기 전에 VTube Studio에 다른 아이템 유형이 추가된 경우에만 발생할 수 있으므로 절대 발생하지 않아야 합니다.

`"canLoadItemsRightNow"`는 사용자가 VTube Studio에서 특정 메뉴나 대화상자를 열고 있을 경우 `false`일 수 있습니다. 이는 일반적으로 아이템 불러오기, 단축키 사용 등의 작업을 방지합니다.

`"framerate"`와 `"frameCount"`는 애니메이션 아이템(GIF 및 애니메이션 프레임 폴더)에만 제공됩니다.

`"pinnedToModel"`이 true이면 `"pinnedModelID"`에는 아이템이 고정된 모델의 모델 ID(현재 불러온 모델) 가 포함되고 `"pinnedArtMeshID"`에는 아이템이 고정된 ArtMesh의 ID가 포함됩니다.

`"includeAvailableItemFiles"`를 `true`로 설정하면 `"availableItemFiles"`에는 사용자의 `Items` 폴더 내 모든 아이템 파일 목록이 포함됩니다. 여기서 반환된 파일 이름을 사용하여 `ItemLoadRequest`를 통해 씬에 아이템을 불러올 수 있습니다.

**`응답`**

```json
{
    "apiName": "VTubeStudioPublicAPI",
    "apiVersion": "1.0",
    "timestamp": 1625405710728,
    "messageType": "ItemListResponse",
    "requestID": "SomeID",
    "data": {
        "itemsInSceneCount": 2,
        "totalItemsAllowedCount": 60,
        "canLoadItemsRightNow": true,
        "availableSpots":
	[
            -30,-29,-28,-27,-26,-25,-24,-23,-22,-21,-20,-19,-18,-17,-16,-15,-14,
            -13,-12,-11,-10,-9,-8,-7,-6,-5,-4,-3,-2,-1,3,4,5,6,7,8,9,10,11,12,13,
            14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30
        ],
        "itemInstancesInScene": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "instanceID": "18de53dc47154b00afdd382a6ebd2194",
                "order": 1,
                "type": "Live2D",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 0.0,
                "frameCount": -1,
                "currentFrame": -1,
                "pinnedToModel": true,
                "pinnedModelID": "47c71722c5304a039b0570b60a189875",
                "pinnedArtMeshID": "D_FACE_00",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "instanceID": "716cddf2e12a438ab5da05bbbf8b341c",
                "order": 2,
                "type": "AnimationFolder",
                "censored": false,
                "flipped": false,
                "locked": false,
                "smoothing": 0.0,
                "framerate": 15.0,
                "frameCount": 7,
                "currentFrame": 0,
                "pinnedToModel": false,
                "pinnedModelID": "",
                "pinnedArtMeshID": "",
                "groupName": "",
                "sceneName": "",
                "fromWorkshop": false
            }
        ],
        "availableItemFiles": [
            {
                "fileName": "Ribbon (@denchisoft)",
                "type": "Live2D",
                "loadedCount": 1
            },
            {
                "fileName": "ANIM_headpat",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "workshop_2801215328_ANIM_loading gif",
                "type": "AnimationFolder",
                "loadedCount": 0
            },
            {
                "fileName": "akari_fly (@walfieee)",
                "type": "AnimationFolder",
                "loadedCount": 1
            },
            {
                "fileName": "b_woozy (@denchisoft).png",
                "type": "PNG",
                "loadedCount": 0
            }
        ]
    }
}
```
## 씬에 아이템 로드하기

이 요청을 사용하면 씬에 아이템을 로드할 수 있습니다. 아이템은 사용자의 PC에 있는 "Items" 폴더에서 로드됩니다.

사용 가능한 아이템 파일 목록을 얻으려면 `ItemListRequest`를 사용하세요. 해당 이름들을 `"fileName"` 필드에 사용할 수 있습니다.

아이템은 `"positionX/Y"`, `"size"`, `"rotation"` 필드를 사용하여 위치/크기/회전을 조정할 수 있습니다. 이 값들을 사용하는 방법에 대한 자세한 내용은 [VTube Studio 좌표계](#the-vts-coordinate-system)를 참조하세요. 크기는 `0`과 `1` 사이여야 하며, `0.32`는 사용자가 수동으로 아이템을 로드할 때의 대략적인 "기본" 크기입니다.

플러그인은 아이템을 정리(clean up)해야 합니다. 사용자가 더 이상 접근할 수 없는 씬 밖에 아이템을 절대 남겨두면 안 됩니다. 사용자가 **"씬에 있는 모든 아이템 삭제"** 버튼을 사용해야만 제거할 수 있기 때문입니다. 이를 쉽게 하기 위해 `"unloadWhenPluginDisconnects"`를 true로 설정할 수 있습니다.

아이템에 대해 0초에서 2초 사이의 페이드 인/아웃 시간을 지정하려면 `"fadeTime"` 필드를 사용할 수 있습니다. 0으로 설정하면 아이템이 즉시 나타납니다.

씬에서 아이템이 로드될 정렬 순서는 `"order"` 필드로 지정할 수 있습니다. 만약 해당 순서가 이미 사용 중이면, 아이템은 자동으로 다음으로 높은 사용 가능한 순서에 로드되고, 만약 모든 높은 순서가 가득 차면 낮은 순서를 확인합니다. 요청한 순서가 사용 중일 경우 아이템 로드 실패를 원하면 `failIfOrderTaken`을 `true`로 설정하세요. 이 경우 `ItemOrderAlreadyTaken` 유형의 오류가 반환됩니다 ([ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 참조).

몇몇 값에는 제한이 있습니다. 크기는 `0`과 `1` 사이여야 하며, 위치는 `-1000`과 `1000` 사이여야 합니다 (`-1`/`1`은 화면 가장자리임). 페이드 시간은 `0`과 `2`초 사이여야 하고, 스무딩은 `0`과 `1` 사이여야 합니다. 제한을 초과하면 `ItemLoadValuesInvalid` 유형의 오류가 반환됩니다.

### 커스텀 데이터 아이템

플러그인은 이 요청을 사용하여 임의의 PNG/JPG/GIF 데이터를 `customDataBase64` 필드에 base64로 인코딩하여 아이템으로 로드할 수 있습니다. 사용하지 않을 경우 비워두거나 NULL로 설정하세요.

이 기능을 사용하려면 `LoadCustomImagesAsItems` 권한이 필요합니다. 권한 요청 방법은 [권한 페이지](Permissions/)를 확인하세요. 권한이 없으면 커스텀 데이터 이미지를 로드하려 할 때 오류가 반환됩니다 (`RequestRequiresPermission`, [ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 참조).

임의 데이터를 아이템으로 로드하려면 `customDataBase64`에 PNG, JPG 또는 GIF 파일의 유효한 데이터가 포함되어야 합니다. 커스텀 데이터 Live2D 아이템은 현재 지원되지 않습니다. 크기는 64에서 2048 픽셀 사이여야 하며, 데이터 크기는 5MB 미만이어야 합니다 (base64 인코딩 전 바이너리 데이터 크기). GIF 데이터는 1에서 1024 프레임 사이여야 하며 모든 프레임 크기가 같아야 합니다.

커스텀 데이터를 제공할 때 `fileName` 필드에도 파일 이름을 제공해야 합니다. `fileName`은 영숫자(하이픈 포함 가능)여야 하며 `.jpg`, `.png`, `.gif`로 끝나야 합니다. 길이는 8자 이상 32자 이하이어야 합니다.

커스텀 데이터를 로드할 때 두 가지 옵션이 있습니다:
* 커스텀 데이터 아이템을 즉시 로드
* 사용자에게 작은 팝업(아이템 썸네일 포함)을 보여주고 로드 여부를 묻기

용도에 맞게 적절한 옵션을 선택하세요. 플러그인이 사용자에게 문제를 일으킬 수 있는 이미지를 로드하지 않도록 책임져야 합니다.

즉시 아이템을 로드하려면 `customDataAskUserFirst`를 `false`로 설정하세요.

사용자에게 먼저 팝업을 보여주려면 `customDataAskUserFirst`를 `true`로 설정하세요. 이 경우 다음과 같은 팝업이 사용자에게 표시됩니다:

![Custom Image Load Popup](/Images/vts_load_custom_image_1.png)

이와 같은 팝업은 동시에 6개까지 표시할 수 있습니다(팝업은 수직으로 쌓임). 이미 6개의 팝업이 사용자에게 표시 중일 때 추가 요청은 오류를 반환합니다.

팝업을 표시할 때, 사용자가 결정을 내릴 때까지 이 요청에 대한 응답은 반환되지 않습니다. 사용자가 맞춤 데이터 항목 로드를 거부하기로 결정하면 오류가 반환됩니다(`ItemCustomDataLoadRequestRejectedByUser`). 사용자가 항목을 로드하기로 결정하면 항목이 로드되고 정상 응답이 반환됩니다. 이는 또한 해당 항목의 SHA256 해시에 따라 동일한 항목의 후속 로드 시 팝업이 발생하지 않도록 플러그인의 허용 목록에 추가합니다. 매번 팝업을 강제로 표시하려면 `customDataSkipAskingUserIfWhitelisted`를 false로 설정할 수 있습니다.

`customDataAskTimer` 필드를 사용하여 팝업의 타임아웃을 설정할 수 있습니다. 0(또는 그 이하)으로 설정하면 사용자가 확인 또는 취소를 클릭할 때까지 팝업이 무기한 표시됩니다. 다른 양의 숫자로 설정하면 팝업이 해당 초만큼 표시되며, 사용자에게 보이는 카운트다운이 표시됩니다. 사용자가 카운트다운이 끝나기 전에 결정을 내리지 않으면 항목 로드 요청은 사용자가 거부한 것으로 간주됩니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemLoadRequest",
	"data": {
		"fileName": "some_item_name.jpg",
		"positionX": 0,
		"positionY": 0.5,
		"size": 0.33,
		"rotation": 90,
		"fadeTime": 0.5,
		"order": 4,
		"failIfOrderTaken": false,
		"smoothing": 0,
		"censored": false,
		"flipped": false,
		"locked": false,
		"unloadWhenPluginDisconnects": true,
		"customDataBase64": "",
		"customDataAskUserFirst": true,
		"customDataSkipAskingUserIfWhitelisted": true,
		"customDataAskTimer": -1,
	}
}
```

응답에는 새로 로드된 항목의 인스턴스 ID가 `instanceID` 필드에 포함되어 있습니다. 또한 파일 이름도 포함되어 있습니다.

사용자 정의 데이터 항목을 로드한 경우, 파일 이름은 VTube Studio에서 생성되므로 전달한 파일 이름과 다를 수 있습니다. 해당 파일 이름을 사용하여 사용자 정의 데이터를 전달하지 않고도 해당 항목을 다시 로드하도록 요청할 수 있습니다. 그러나 VTube Studio가 재시작되면 모든 임시 파일이 삭제되며, 여기에는 사용자 정의 데이터 항목도 포함됩니다.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemLoadResponse",
	"data": {
		"instanceID": "SomeUniqueItemInstanceId",
		"fileName": "some_item_name.jpg"
	}
}
```

## 장면에서 아이템 제거하기

이 요청을 사용하여 현재 장면에 로드된 아이템을 언로드할 수 있습니다.

`"unloadAllInScene"`을 `true`로 설정하면 모든 아이템이 언로드됩니다. 이 경우 다른 모든 필드는 무시됩니다.

`"unloadAllLoadedByThisPlugin"`을 `true`로 설정하면 이 플러그인에 의해 로드된 모든 아이템이 언로드됩니다.

사용자 또는 다른 플러그인에 의해 로드된 아이템이 언로드되지 않도록 하려면 `"allowUnloadingItemsLoadedByUserOrOtherPlugins"`를 `false`로 설정하세요.

선택적 `"instanceIDs"` 및 `"fileNames"` 배열을 사용하여 특정 아이템 인스턴스 또는 특정 파일명에서 로드된 아이템 인스턴스를 요청할 수도 있습니다. 해당 아이템이 장면에 없더라도 요청은 오류를 반환하지 않습니다. 빈 배열이 포함된 응답만 반환됩니다.

사용자가 현재 VTS가 아이템을 로드/언로드하지 못하도록 하는 메뉴를 열고 있는 경우 `CannotCurrentlyUnloadItem` 유형의 오류가 반환될 수 있습니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemUnloadRequest",
    	"data": {
		"unloadAllInScene": false,
		"unloadAllLoadedByThisPlugin": false,
		"allowUnloadingItemsLoadedByUserOrOtherPlugins": true,
		"instanceIDs":
		[
			"SomeInstanceIdOfItemToUnload", "SomeOtherInstanceIdOfItemToUnload"
		],
		"fileNames":
		[
			"UnloadAllItemInstancesWithThisFileName", "SomeOtherFileName"
		]
    	}
}
```
응답에는 언로드된 항목들의 인스턴스 ID와 파일명이 포함되어 있습니다.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemUnloadResponse",
    	"data": {
		"unloadedItems":
		[
		    {
			"instanceID": "SomeInstanceId",
			"fileName": "SomeFileName"
		    },
		    {
			"instanceID": "SomeOtherInstanceId",
			"fileName": "SomeFileName"
		    }
		]
    	}
}
```

## 아이템 및 아이템 애니메이션 제어

장면 내 아이템의 특정 측면을 제어할 수 있습니다. 이 요청을 통해 아이템을 더 어둡게(검은색 오버레이), 불투명도 변경, 애니메이션 아이템의 애니메이션을 제어할 수 있습니다. 이 요청은 Live2D 아이템과 작동하지 않으며, 시도할 경우 `ItemAnimationControlUnsupportedItemType` 유형의 오류를 반환합니다 ([ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 참조). 이는 "반응형 PNG" 유형 플러그인 등에서 유용할 수 있습니다.

애니메이션 아이템의 경우 프레임 속도(초당 프레임 수)를 설정할 수 있으며, 자동으로 `0.1`과 `120` 사이로 제한됩니다. 또한 `"frame"` 필드를 사용해 수동으로 애니메이션을 특정 프레임으로 점프시킬 수 있습니다. 해당 프레임 인덱스가 유효하지 않으면 오류가 반환됩니다. 예를 들어 20 프레임인 애니메이션 아이템의 경우 유효한 프레임 인덱스는 0(첫 프레임)부터 19(마지막 프레임)까지입니다. 애니메이션 아이템의 프레임 수는 `ItemListRequest`를 통해 요청할 수 있습니다. 일반 JPG/PNG 아이템에 대해 이 작업을 시도하면 `ItemAnimationControlSimpleImageDoesNotSupportAnim` 유형의 오류가 반환됩니다.

프레임 속도, 현재 프레임, 밝기 또는 불투명도를 변경하지 않으려면 해당 필드에 `-1`을 전달할 수 있으며(필드를 생략하면 기본값이 이 값임) 변경되지 않습니다.

애니메이션을 시작/중지하려면 `"animationPlayState"` 필드를 사용합니다(`true` = 애니메이션 재생, `false` = 애니메이션 정지). 이 필드는 `"setAnimationPlayState"`를 `true`로 설정한 경우에만 사용되며, 그렇지 않으면 애니메이션 재생 상태가 변경되지 않습니다.

#### 자동 정지 프레임 사용

애니메이션이 자동으로 정지할 프레임 인덱스 목록을 `"autoStopFrames"` 배열로 설정할 수 있습니다. 이 배열은 `"setAutoStopFrames"`를 `true`로 설정한 경우에만 사용되며, 그렇지 않으면 자동 정지 프레임이 변경되지 않습니다. 자동 정지 프레임을 제거하려면 `"setAutoStopFrames"`를 `true`로 설정하고 `"autoStopFrames"`에 빈 배열을 지정하세요. 최대 1024개의 자동 정지 프레임을 설정할 수 있습니다.

애니메이션이 해당 프레임 중 하나에 도달하면 재생이 중지되며, 위에서 설명한 요청을 통해 애니메이션 재생 상태를 `true`로 설정하여 API를 통해서만 다시 시작할 수 있습니다.

**`요청`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlRequest",
	"data": {
		"itemInstanceID": "ItemInstanceId",
		"framerate": 12,
		"frame": 3,
		"brightness": 1,
		"opacity": 1,
		"setAutoStopFrames": true,
		"autoStopFrames": [0, 7, 26],
		"setAnimationPlayState": true,
		"animationPlayState": true
	}
}
```
응답에는 현재 프레임 인덱스와 애니메이션이 현재 재생 중인지 여부가 포함됩니다(애니메이션 항목에만 해당하며, 다른 항목 유형의 경우 이 필드는 무시해야 합니다).

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemAnimationControlResponse",
	"data": {
		"frame": 3,
		"animationPlaying": true
	}
}
```

## 씬 내 아이템 이동

씬 내에서 아이템을 이동할 수 있습니다. 이를 위해 `"itemsToMove"` 배열에 이동하려는 모든 아이템을 채우십시오. 응답 배열(`"movedItems"`)은 요청된 각 아이템에 대해 한 항목씩 포함하며, 해당 아이템의 이동 요청이 성공했는지 여부를 보여줍니다(`"success"` 필드 참조). 성공하지 못한 경우 `"errorID"` 필드에 오류 코드가 포함되어 무엇이 잘못되었는지 알려줍니다([ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 참조). 성공한 경우 `"success"`는 `true`이고 `"errorID"`는 `-1`입니다.

`"itemsToMove"` 배열은 최대 64개의 항목을 가질 수 있습니다. 그 이상은 무시됩니다. 배열에 중복된 아이템 인스턴스 ID가 있을 경우, 해당 ID에 대한 배열의 마지막 항목이 사용됩니다.

위치를 즉시 설정하려면(예: 매 프레임마다 새 위치를 설정할 때) `"timeInSeconds"`를 `0`으로 설정하십시오. 그렇지 않으면 이 필드를 사용하여 이동 페이드에 사용되는 시간을 설정할 수 있으며(0에서 30초 사이로 제한됨) 설정 가능합니다.

아이템의 플립 상태를 설정하려면 `"setFlip"`을 true로 설정하십시오. 그런 다음 `"flip"` 필드를 사용하여 플립 상태를 설정할 수 있습니다.

아이템의 순서를 변경하려면 `"order"` 필드를 사용할 수 있습니다. 비어있는 순서 위치로만 순서를 변경할 수 있습니다(`ItemListResponse` 참조). 순서를 변경하지 않으려면 이 필드를 -1000 이하로 설정하거나, 대안으로 아이템의 현재 순서 값을 설정할 수 있습니다. 또한 사용자가 구성 창을 열고 있을 때는 순서를 변경할 수 없습니다. 순서는 다른 매개변수처럼 페이드되지 않고(요청 시) 요청이 수신되면 즉시 변경됩니다.

이동 대상 필드(`"positionX"`, `"positionY"`, `"size"`, `"rotation"`)에 대해서는 `ItemLoadRequest` 문서를 참조하십시오. 유일한 차이점은 `ItemMoveRequest`는 주어진 값이 너무 높거나 낮아도 오류를 반환하지 않는다는 점입니다. 대신 해당 필드를 무시하려면 `-1000` 이하의 값을 설정할 수 있습니다. 이렇게 하면 이 필드는 이동에 포함되지 않고 해당 필드의 현재 값이 대신 사용됩니다.


#### 아이템 이동 전환 페이드 타입

위치/회전/크기 페이드의 이동 타입은 `"fadeMode"` 필드를 사용하여 설정할 수 있습니다. 허용되는 값은 `"linear"`, `"easeIn"`, `"easeOut"`, `"easeBoth"`, `"overshoot"`, `"zip"`입니다. 이 값들은 `"timeInSeconds"` 필드가 0보다 클 때만 사용됩니다.

이동 중에 사용자가 아이템을 클릭하거나 드래그하여 이동을 중단할 수 있게 하려면 `"userCanStop"`을 `true`로 설정하십시오. `false`로 설정하면 이동 중에는 사용자가 아이템과 상호작용할 수 없습니다.

아래는 이동 모드의 시각적 표현입니다:

![VTube Studio Movement Modes](/Images/vts_movement_modes_smooth.png)

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemMoveRequest",
	"data": {
		"itemsToMove":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"timeInSeconds": 1,
				"fadeMode": "easeOut",
				"positionX": 0.2,
				"positionY": -0.8,
				"size": 0.6,
				"rotation": 180,
				"order": -1000,
				"setFlip": true,
				"flip": false,
				"userCanStop": true
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"timeInSeconds": 0.5,
				"fadeMode": "zip",
				"positionX": 1,
				"positionY": 1,
				"size": 0.3,
				"rotation": 0,
				"order": 25,
				"setFlip": false,
				"flip": false,
				"userCanStop": false
			}
		]
	}
}
```

요청이 성공하면 요청한 모든 항목의 상태를 포함하는 응답을 받게 됩니다.

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemMoveResponse",
	"data": {
		"movedItems":
		[
			{
				"itemInstanceID": "ItemInstanceId",
				"success": true,
				"errorID": -1
			},
			{
				"itemInstanceID": "SomeOther_ItemInstanceId",
				"success": false,
				"errorID": 900
			}
		]
	}
}
```

## 모델 내 아이템 정렬 순서 설정

#### ⚠️ 이 요청은 현재 [공개 베타 브랜치](https://github.com/DenchiSoft/VTubeStudio/wiki/Joining-the-Beta)에서만 사용할 수 있습니다 ⚠️

VTube Studio는 메인 모델의 **레이어 간** 아이템을 정렬하고 고정할 수 있습니다. 이 동작에 대한 일반적인 정보는 "[레이어 간 아이템 고정](https://github.com/DenchiSoft/VTubeStudio/wiki/Between-Layer-Item-Pinning)" 페이지를 참조하세요.

특히 [Live2D 아이템](https://github.com/DenchiSoft/VTubeStudio/wiki/Live2D-Items)의 경우, **Live2D 아이템 모델**을 앞부분과 뒷부분으로 분할하여 메인 모델에 별도로 삽입할 수 있습니다.

모델 내 정렬 설정을 변경하려는 아이템을 식별하려면 `"itemInstanceID"` 필드에 해당 아이템 인스턴스 ID를 전달하세요. 해당 ID를 가진 아이템이 없으면 `ItemSortRequestInstanceIDNotFound` 오류가 반환됩니다. 로드된 모든 아이템의 인스턴스 ID를 얻으려면 `ItemListRequest`를 사용할 수 있습니다. 또한 API를 통해 아이템을 로드할 때 `ItemLoadRequest`에서 ID가 직접 반환됩니다.

이 요청에서 반환할 수 있는 모든 오류는 "[ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)"를 참조하세요.

*참고:* 일반 아이템(비-Live2D 아이템)은 "뒷부분"이나 "분할 지점"이 없으므로, 이 요청을 일반 아이템에 사용할 때는 뒷부분/분할 필드가 완전히 무시됩니다. 빈 값이나 `null`로 둘 수 있습니다. 아래 설명은 Live2D 아이템에 이 요청을 사용하는 경우를 가정합니다. 또한 VTube Studio는 뒷부분이 앞부분보다 앞으로 설정되어도 앞부분을 넘어가지 않도록 처리합니다.

아이템을 모델에 삽입하려면 `"frontOn"`을 `true`로 설정하세요. Live2D 아이템의 뒷부분을 모델 뒤쪽에 삽입하려면 `"backOn"`을 `true`로 설정할 수 있습니다(비-Live2D 아이템에는 무시됨).

분할 지점과 앞/뒤 삽입 지점은 `"splitAt"`, `"withinModelOrderFront"`, `"withinModelOrderBack"`로 설정합니다. 이 필드들이 어떻게 해석되는지는 `"setSplitPoint"`, `"setFrontOrder"`, `"setBackOrder"` 값에 따라 다릅니다.

다음 필드는 아이템 분할 지점과 삽입 지점을 설정하는 데 사용됩니다:

* `"splitAt"`: Live2D 아이템 모델을 앞부분과 뒷부분으로 분할하는 데 사용되는 분할 지점을 설정합니다.
  * 비-Live2D 아이템에는 무시됩니다.
  * `"setSplitPoint"`가 `"Unchanged"`로 설정되면 `"splitAt"` 값은 무시되고 분할 지점은 변경되지 않습니다.
  * `"setSplitPoint"`가 `"UseArtMeshID"`로 설정되면 `"splitAt"`은 Live2D 아이템 모델에 존재하는 ArtMesh ID를 기대하며, 해당 ID가 없으면 `ItemSortRequestInvalidSplitPoint` 오류를 반환합니다.
* `"withinModelOrderFront"`: 메인 모델(또는 Live2D 아이템 앞부분)에 아이템을 삽입할 위치를 설정합니다.
  * `"setFrontOrder"`가 `"Unchanged"`로 설정되면 `"withinModelOrderFront"` 값은 무시되고 앞부분 삽입 위치는 변경되지 않습니다.
  * `"setFrontOrder"`가 `"UseArtMeshID"`로 설정되면 `"withinModelOrderFront"`은 메인 Live2D 모델에 존재하는 ArtMesh ID를 기대하지만, 존재하지 않아도 현재 로드되지 않은 Live2D 모델의 ID일 수 있어 요청은 성공적으로 반환됩니다.
  * `"setFrontOrder"`가 `"UseSpecialID"`로 설정되면 `"withinModelOrderFront"`은 `"FullyInFront"` 또는 `"FullyInBack"` 중 하나를 기대하며, 이를 통해 아이템(앞부분)을 로드된 메인 모델의 완전 앞이나 뒤에 배치합니다. 다른 값은 `ItemSortRequestInvalidFrontOrder` 오류를 반환합니다.
* `"withinModelOrderBack"`: Live2D 아이템 뒷부분을 메인 모델에 삽입할 위치를 설정합니다.
  * 비-Live2D 아이템에는 무시됩니다.
  * `"setBackOrder"`가 `"Unchanged"`로 설정되면 `"withinModelOrderBack"` 값은 무시되고 뒷부분 삽입 위치는 변경되지 않습니다.
  * `"setBackOrder"`가 `"UseArtMeshID"`로 설정되면 `"withinModelOrderBack"`은 메인 Live2D 모델에 존재하는 ArtMesh ID를 기대하지만, 존재하지 않아도 현재 로드되지 않은 Live2D 모델의 ID일 수 있어 요청은 성공적으로 반환됩니다.
  * `"setBackOrder"`가 `"UseSpecialID"`로 설정되면 `"withinModelOrderBack"`은 `"FullyInBack"`을 기대하며, 이를 통해 아이템(뒷부분)을 로드된 메인 모델 뒤에 완전히 배치합니다. 다른 값은 `ItemSortRequestInvalidBackOrder` 오류를 반환합니다.

`"setSplitPoint"`, `"setFrontOrder"`, `"setBackOrder"`에 잘못된 값이 들어가면 `ItemSortRequestInvalidValueSetType` 오류가 반환됩니다.

모델 내 정렬 창이 현재 열려 있어 사용자가 수동으로 삽입 순서를 설정 중이면 `ItemSortRequestItemConfigWindowOpen` 오류가 반환됩니다.

**`요청`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemSortRequest",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"frontOn": true,
		"backOn": true,
		"setSplitPoint": "UseArtMeshID",
		"setFrontOrder": "UseArtMeshID",
		"setBackOrder": "UseSpecialID",
		"splitAt": "MyArtMeshIDInItemModel91",		
		"withinModelOrderFront": "MyArtMeshIDInMainModel73",
		"withinModelOrderBack": "FullyInBack"
	}
}
```
요청이 성공하면, 다음과 같은 응답을 받게 됩니다.

`"itemInstanceID"`는 요청한 항목의 인스턴스 ID를 반환합니다.

현재 메인 모델이 로드되어 있으면, `"modelLoaded"`는 `true`가 되고 `"modelID"`와 `"modelName"`에는 모델의 ID와 이름이 포함됩니다. 모델이 로드되어 있지 않으면 이 필드들은 비어 있습니다.

메인 모델이 로드되어 있는 경우, `"loadedModelHadRequestedFrontLayer"`와 `"loadedModelHadRequestedBackLayer"`는 제공한 앞/뒤 삽입 지점이 현재 로드된 모델에서 발견되었는지 여부를 알려줍니다. 삽입 지점이 변경되지 않았다면, 이 필드들은 `false`로 설정됩니다.

**`RESPONSE`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemSortResponse",
	"data": {
		"itemInstanceID": "b616cf51fe3444729ccbf6ee54a14d1a",
		"modelLoaded": true,
		"modelID": "d87b771d2902473bbaa0226d03ef4754",
		"modelName": "Akari",
		"loadedModelHadRequestedFrontLayer": true,
		"loadedModelHadRequestedBackLayer": true
	}
}
```

## ArtMeshes 선택 요청

이 요청을 사용하여 현재 로드된 메인 Live2D 모델의 모든 ArtMeshes를 포함하는 목록을 VTube Studio에 표시하고 사용자가 하나 이상 선택하도록 할 수 있습니다. 사용자가 ArtMeshes 선택을 완료하면 ArtMesh ID가 반환됩니다. 반환된 ArtMesh ID는 색상 틴트 적용이나 투명 처리 등 다양한 다른 API 요청에서 사용할 수 있습니다.

현재 모델이 로드되어 있지 않거나 다른 창이 열려 있는 경우, 요청은 오류를 반환합니다.

사용자는 ArtMeshes 위에 마우스를 올려 ID를 확인할 수 있으며 클릭하여 클릭 위치 아래의 모든 ArtMeshes를 필터링할 수 있습니다. 이 요청으로 표시되는 UI는 다음과 같습니다:

![API ArtMesh 선택 요청 화면](/Images/vts_request_select_artmeshes.png)

`requestedArtMeshCount` 필드를 사용해 사용자가 반드시 활성화해야 하는 ArtMeshes 수를 지정하세요. 정확히 그 수만큼 활성화될 때까지 "확인" 버튼은 비활성화됩니다. `requestedArtMeshCount`를 0 이하로 설정하면 사용자가 임의의 수(최소 1개)의 ArtMeshes를 선택하도록 요청합니다.

목록에서 미리 활성화할 ArtMeshes가 있으면 `activeArtMeshes` 목록에 해당 ArtMesh ID를 전달할 수 있습니다. 전달한 ID가 현재 모델에 없으면 오류가 반환됩니다. 현재 로드된 모델의 모든 ArtMeshes 목록이 필요하면 `ArtMeshListRequest`를 사용하세요.

위 스크린샷에서 볼 수 있듯이 목록에는 플러그인용 ArtMeshes 선택을 요청하는 기본 텍스트가 표시됩니다. 이 텍스트는 오른쪽 상단의 `?` 버튼(도움말)을 눌렀을 때 팝업으로도 나타납니다. 각각 `textOverride`와 `helpOverride` 필드를 사용하여 두 문자열을 덮어쓸 수 있습니다. 빈 문자열, null 값이거나 페이로드에서 제외하면 위 기본 메시지가 사용됩니다. 메시지를 덮어쓰려면 제공하는 문자열 길이가 4자에서 1024자 사이여야 하며, 그렇지 않으면 기본 메시지가 사용됩니다. 제공하는 문자열에서 줄바꿈은 `\n`을 사용할 수 있습니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionRequest",
	"data": {
		"textOverride": "This text is shown over the ArtMesh selection list.",
		"helpOverride": "This text is shown when the user presses the ? button."
		"requestedArtMeshCount": 5
		"activeArtMeshes": [
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```
요청이 성공하면 선택 목록이 사용자에게 표시됩니다. 즉각적인 응답은 없습니다. 응답은 사용자가 "확인" 또는 "취소" 버튼을 클릭할 때 제공됩니다. "취소" 버튼은 항상 사용할 수 있지만, 요청된 수의 ArtMeshes가 선택되어야만 "확인" 버튼이 클릭 가능해집니다.

활성화/비활성화된 ArtMeshes는 각각 `activeArtMeshes`와 `inactiveArtMeshes` 배열로 반환됩니다. 이 배열들 사이에는 **중복이 없으므로**, 해당 배열들에 있는 ArtMeshes를 합치면 모델 내 모든 ArtMeshes 목록을 얻을 수 있습니다.

사용자가 "확인"을 클릭하면 `success` 필드는 `true`가 됩니다. 사용자가 "취소"를 클릭하면 `success` 필드는 `false`가 됩니다(이 경우 `activeArtMeshes`와 `inactiveArtMeshes` 배열은 무시하는 것이 좋지만, 여전히 반환됩니다).

**`응답`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ArtMeshSelectionResponse",
	"data": {
		"success": true
		"activeArtMeshes": [
			"D_BROW_00",
			"D_EYE_BALL_03",
			"D_EYE_BALL_02",
			"D_EYE_BALL_01",
			"D_EYE_BALL_00",
			"D_EYE_11"
		],
		"inactiveArtMeshes": [
			"D_EAR_06",
			"D_BODY_00",
			"D_ARM_R_05"
		]
	}
}
```

## 모델에 아이템 고정하기

이 요청을 사용하여 장면 내 아이템을 현재 로드된 모델에 고정할 수 있습니다.

아이템을 식별하기 위한 아이템 인스턴스 ID는 `itemInstanceID` 필드에 지정해야 합니다. 아이템 고정을 해제하려면 `pin`을 `false`로 설정하면 됩니다. 이 경우 다른 정보는 제공할 필요가 없습니다. 해당 ID의 아이템이 현재 로드되어 있지 않으면 오류가 반환됩니다 ([ErrorsID.cs](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs) 참조).

아이템을 고정하려면 `pinInfo` 객체에 고정 위치를 제공해야 합니다. 아이템을 고정하는 다양한 방법이 있습니다. 예를 들어, 정확한 위치를 제공하거나 ArtMesh를 지정해 VTS가 아이템을 해당 ArtMesh의 중앙이나 무작위 위치에 고정하도록 할 수 있습니다. 구체적인 작동 방식은 아래에 설명되어 있습니다.

활성화된 `ItemMoveRequest`가 있는 아이템에 대해 `ItemPinRequest`를 보내면, `ItemMoveRequest`는 자동으로 취소됩니다.

또한, 플러그인(또는 여러 플러그인)이 동일한 아이템에 대해 같은 프레임 내에 여러 고정 요청을 보내면, 마지막으로 수신된 고정 요청만 실행되고 나머지는 무시됩니다.

### 고정 옵션

`pinInfo`에 제공된 데이터 해석 방식을 결정하는 세 가지 필드가 있습니다:

* `angleRelativeTo`: 제공된 각도는 어떻게 해석해야 하는가?
  * `RelativeToWorld`: 절대 각도. 예를 들어 0을 넘기면 아이템이 VTS 창 기준으로 각도 0에서 똑바로 고정됩니다. 아이템을 VTS 창에 대해 특정 방향으로 향하게 하고 싶을 때 사용합니다.
  * `RelativeToCurrentItemRotation`: 아이템 현재 각도에 대한 상대 각도. 0을 넘기면 아이템은 현재 각도 그대로 고정되어 회전이 변경되지 않습니다. 아이템 회전을 변경하지 않고 현재 상태로 고정하려 할 때 사용합니다.
  * `RelativeToModel`: 모델 회전에 대한 상대 각도. 0을 넘기면 사용자가 모델을 회전시켰어도 아이템이 모델 기준으로 똑바로 고정됩니다. 이 "모델 회전"은 Live2D ArtMesh 변형에 의한 회전은 포함하지 않고 VTube Studio가 전체 모델에 적용하는 실제 회전만 포함합니다. 아이템을 모델 현재 회전에 상대적인 특정 방향으로 향하게 하고 싶을 때 사용합니다.
  * `RelativeToPinPosition`: 고정 위치에 대한 상대 각도. 특정 ArtMesh 내 특정 위치에 아이템을 고정하고, 모델 회전이나 ArtMesh 변형과 상관없이 정확히 동일한 각도를 유지하려 할 때 사용합니다. 다만 원하는 효과를 얻기 위한 각도 값은 고정 위치마다 완전히 다릅니다.
* `sizeRelativeTo`:
  * `RelativeToWorld`: 절대 크기. 0(가장 작음)에서 1(가장 큼) 사이. `ItemLoadRequest` 참조.
  * `RelativeToCurrentItemSize`: 현재 아이템 크기에 대한 상대 크기. `-1`에서 `1` 사이 숫자를 넘길 수 있으며, 이는 현재 아이템 크기에 더해집니다. 크기를 변경하지 않고 현재 크기로 고정하려면 0을 넘기면 됩니다.
* `vertexPinType`:
  * `Provided`: `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2`, `vertexWeight3` 필드에 제공된 핀 위치를 사용해 지정된 ArtMesh에 아이템이 고정됩니다. 자세한 내용은 아래에서 설명합니다.
  * `Center`: 지정된 ArtMesh의 "중앙"에 아이템을 고정합니다. 공간적으로 정확한 중심은 아니며, 메시의 삼각형 목록 중 중앙에 위치한 삼각형입니다. 주어진 ArtMesh마다 항상 동일한 위치를 제공합니다.
  * `Random`: 지정된 ArtMesh 내 무작위 삼각형에 아이템이 고정됩니다.

제공된 모델 ID가 로드된 모델과 일치하지 않으면 오류가 반환됩니다. 모델 ID를 비워두면 현재 로드된 모델에 고정 시도합니다(로드된 모델이 있을 경우).

모델에 제공한 ArtMesh ID가 존재하지 않으면 오류가 반환됩니다. ArtMesh ID를 비워두면 모델 내에서 무작위 ArtMesh가 선택됩니다.

예를 들어 모델 ID와 ArtMesh ID를 모두 비워두고 `vertexPinType`을 `Random`으로 설정하면 현재 로드된 모델의 무작위 ArtMesh의 무작위 위치에 아이템이 고정됩니다.

### 특정 위치에 고정하기

`vertexPinType`을 `Provided`로 설정하면, `modelID`와 `artMeshID` 필드를 사용해 선택한 ArtMesh 상의 유효한 위치를 제공하기 위해 `vertexID1`, `vertexID2`, `vertexID3`, `vertexWeight1`, `vertexWeight2`, `vertexWeight3` 필드를 사용해야 합니다.

세 개의 버텍스 ID 필드는 주어진 ArtMesh 내 삼각형의 버텍스 ID여야 합니다. 해당 특정 삼각형 내에서 위치를 정의하려면 버텍스 가중치 필드를 사용하세요. 이 필드들은 버텍스 위치에 곱해져 삼각형 내의 위치를 정의합니다. 가중치의 합이 정확히 1이어야 한다는 점을 명심하세요. 그렇지 않으면 결과 위치가 삼각형 밖에 있게 되고(오류가 반환됩니다). 이들은 [중심 좌표계](https://en.wikipedia.org/wiki/Barycentric_coordinate_system)입니다.

이 위치 중 하나를 얻으려면 [ModelClickedEvent](https://github.com/DenchiSoft/VTubeStudio/tree/master/Events#model-clicked-event)를 사용할 수 있습니다. 이 이벤트는 모델이 클릭될 때 `ItemPinRequest`와 함께 사용할 수 있는 핀 위치를 반환합니다.

**`REQUEST`**

```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "ItemPinRequest",
	"data": {
		"pin": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"angleRelativeTo": "RelativeToModel",
		"sizeRelativeTo": "RelativeToWorld",
		"vertexPinType": "Provided",
		"pinInfo": {
			"modelID": "d87b771d2902473bbaa0226d03ef4754",
			"artMeshID": "hair_right_4",
			"angle": 23.938,
			"size": 0.33,
			"vertexID1": 17,
			"vertexID2": 9,
			"vertexID3": 55,
			"vertexWeight1": 0.25928378105163576,
			"vertexWeight2": 0.6850675940513611,
			"vertexWeight3": 0.055648624897003177
		}
	}
}
```

성공하면 응답에는 항목 ID, 항목 파일 이름 및 항목이 현재 고정되어 있는지 여부가 포함됩니다.

**`RESPONSE`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "ItemPinResponse",
	"data": {
		"isPinned": true,
		"itemInstanceID": "4a241269394f463ca16b8b21aa636568",
		"itemFileName": "my_test_item_2.png",
	}
}
```

## 후처리 효과 및 상태 목록 가져오기

**참고:** 이 문서에서는 시각 효과, VFX 및 후처리 효과 용어를 혼용하여 사용합니다.

VTube Studio는 장면에 시각 효과를 직접 추가할 수 있는 내장 후처리 기능을 제공합니다. 이 기능은 Windows와 macOS에서 사용할 수 있습니다. 자세한 내용은 ["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects) 페이지를 참조하세요.

이 요청은 후처리 시스템의 일반 상태, 모든 기존(사용자 생성) 후처리 프리셋 목록 및 현재 값(현재 후처리 상태)과 함께 사용 가능한 모든 후처리 효과 목록을 반환합니다.

`fillPostProcessingPresetsArray`를 `false`로 설정하면 응답 페이로드의 `postProcessingPresets` 배열이 비어 있게 됩니다. 후처리 프리셋 목록 요청은 디스크에서 프리셋 파일을 읽어야 하므로(비록 VTS에서 잠시 캐시되지만) 느릴 수 있습니다. 이 요청을 자주 보내는 경우 `fillPostProcessingPresetsArray`가 `true`가 아니도록 하여 디스크 I/O로 인한 지연을 방지하세요.

`fillPostProcessingEffectsArray`를 `false`로 설정하면 응답 페이로드의 `postProcessingEffects` 배열이 비어 있게 됩니다. 전체 후처리 효과 목록과 값을 필요로 하지 않는 경우, 응답 페이로드가 상당히 클 수 있으므로 `fillPostProcessingEffectsArray`를 `false`로 설정하는 것이 권장됩니다.

특정 후처리 효과에만 관심이 있다면 `effectIDFilter` 배열에 나열할 수 있습니다. 그렇지 않으면 필터를 적용하지 않으려면 배열을 비워 두세요. 현재 모든 효과 목록은 다음에서 확인할 수 있습니다: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/Effects.cs

**참고:** 이 ID들은 여러 형식으로 허용되므로 원하는 enum 스타일로 생성할 수 있습니다. 대소문자를 구분하지 않으며 `_` 또는 `-`는 무시됩니다. 예를 들어, `ChromaticAberration` 대신 `Chromatic_Aberration`, `chromatic_aberration`, `CHROMATIC_ABERRATION` 또는 자신에게 가장 적합한 스타일로 작성할 수 있습니다.

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingListRequest",
	"data":
	{
		"fillPostProcessingPresetsArray": true,
		"fillPostProcessingEffectsArray": true,
		"effectIDFilter":
		[
			"ASCII",
			"ColorGrading",
			"WeatherEffects",
			"ChromaticAberration"
		]
	}
}
```
응답에는 후처리 시스템 상태에 대한 일반 정보와 요청한 경우 `postProcessingEffects` 및 `postProcessingPresets` 배열이 포함됩니다.

`postProcessingSupported`는 플랫폼이 후처리를 지원하는지 확인하며, Windows 및 macOS에서는 항상 `true`여야 합니다. `postProcessingActive` 필드는 사용자가 후처리를 켰는지 여부를 나타냅니다. 또한 다음에 설명하는 `PostProcessingUpdateRequest` API를 통해 후처리를 켜거나 끌 수 있음을 기억하세요. 그러나 후처리 구성과 관련된 일부 창이나 팝업이 VTube Studio에서 열려 있을 경우 `PostProcessingUpdateRequest`를 사용할 수 없을 수 있습니다. 이 경우 `canSendPostProcessingUpdateRequestRightNow`는 `false`가 됩니다.

일부 제한/실험적 효과가 있습니다(자세한 내용은 ["제한/실험적 효과"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects) 참조). 사용자가 명시적으로 이러한 효과 사용을 허용해야 합니다. 사용자가 이러한 효과 사용을 허용했는지는 `restrictedEffectsAllowed` 필드에 반환됩니다.

후처리 프리셋이 활성 상태인지 여부는 `presetIsActive` 필드에 반환됩니다. 활성 상태인 경우 해당 프리셋 이름은 `activePreset` 필드에 나타나며, 그렇지 않으면 해당 필드는 비어 있습니다.

`presetCount`는 `postProcessingPresets` 배열에 있는 후처리 프리셋 수를 포함합니다. 배열을 채우도록 요청하지 않으면 `presetCount`는 0입니다.

`activeEffectCount`는 활성화된 후처리 효과의 수입니다. 효과가 "활성" 상태라는 의미는 이 절의 후반부에서 설명됩니다.

"effectCount"와 "configCount" 필드는 필터 적용 전후(필터 요청 시)에 모든 효과 및 전체 구성 수를 포함합니다.

### `postProcessingEffects` 배열

`postProcessingEffects` 배열에는 모든 효과 목록이 포함됩니다. 이는 VTube Studio의 VFX 목록에 표시되는 동일한 효과입니다. 각 효과는 강도나 색상 등 효과의 특정 측면을 구성하는 여러 "구성(configs)"을 가질 수 있습니다.

효과를 식별하는 데 사용하는 ID는 `enumID` 필드에 반환됩니다. 또한 `internalID` 필드에는 VTube Studio가 내부적으로 해당 효과에 사용하는 ID가 포함되어 있습니다. 이 ID는 후처리 프리셋 JSON 파일에서 사용되므로 대부분의 사용 사례에는 관련이 없습니다. 하지만 이 ID들은 API에서 효과를 참조할 때 사용할 수도 있습니다.

구성(config)은 모두 다음 유형 중 하나를 가집니다(`type` 필드에 반환):
* Float
* Int
* Bool
* String
* Color
* SceneItem

하나의 효과에 대한 구성은 `configEntries` 배열에 반환됩니다. 각 구성에는 `internalID`와 `enumID`도 있습니다. 모든 효과에 대한 구성 ID 및 설명은 다음에서 확인할 수 있습니다: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

하나의 구성에 대해 해당 구성 유형과 일치하는 필드만 채워집니다. 다른 필드는 비어 있거나 기본값을 가지며 무시해야 합니다. 예를 들어, float 구성 항목의 경우 `intMin`과 `colorValue` 필드는 비어 있습니다(이 경우 0과 빈 문자열). 모든 유형은 기본값을 가지며, `Float` 및 `Int` 구성은 `min`과 `max`도 가집니다.

색상이 포함된 필드에는 RGBA 16진수 형식의 문자열(예: "77CCAAFF")이 반환되며, `colorHasAlpha`는 해당 구성이 실제로 알파 채널을 가지는지 여부를 알려줍니다. `false`인 경우 알파는 항상 `FF`입니다.

`SceneItem` 유형의 구성은 본질적으로 문자열 구성과 같지만 값은 VTube Studio "Items" 폴더에 있는 항목의 파일명(.jpg 또는 .png로 끝남)이어야 합니다. 예를 들어 커스텀 입자 효과에 사용됩니다.

### 효과가 "활성" 상태로 간주되는 경우는 언제인가?



각 효과에는 `activationConfig`가 `true`로 설정된 적어도 하나의 플로트 설정(여러 개일 수도 있음)이 있습니다. 해당 효과의 설정 중 하나가 0보다 큰 값을 가지면 해당 효과는 `active`로 간주됩니다.

예를 들어, `ColorGrading` 효과의 경우 해당 설정은 `ColorGrading_Strength`가 됩니다.

**참고:** 이 응답 페이로드 예제의 `postProcessingEffects`는 많이 축약되었습니다. 필터가 적용되지 않으면 250개 이상의 효과 설정이 있어 수천 줄에 이를 수 있습니다.

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingListResponse",
	"data": {
		"postProcessingSupported": true,
		"postProcessingActive": true,
		"canSendPostProcessingUpdateRequestRightNow": true,
		"restrictedEffectsAllowed": false,
		"presetIsActive": true,
		"activePreset": "some_effects_preset_3",
		"presetCount": 70,
		"activeEffectCount": 5,
		"effectCountBeforeFilter": 29,
		"configCountBeforeFilter": 258,
		"effectCountAfterFilter": 4,
		"configCountAfterFilter": 31,
		"postProcessingEffects": [
			{
				"internalID": "color_grading",
				"enumID": "ColorGrading",
				"explanation": "Color grading",
				"effectIsActive": false,
				"effectIsRestricted": false,
				"configEntries": [
					{
						"internalID": "color_grading-strength",
						"enumID": "ColorGrading_Strength",
						"explanation": "Effect on/off",
						"type": "Float",
						"activationConfig": true,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 1.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "",
						"colorDefault": "",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					},
					{
						"internalID": "color_grading-color_filter",
						"enumID": "ColorGrading_ColorFilter",
						"explanation": "Color filter",
						"type": "color",
						"activationConfig": false,
						"floatValue": 0.0,
						"floatMin": 0.0,
						"floatMax": 0.0,
						"floatDefault": 0.0,
						"intValue": 0,
						"intMin": 0,
						"intMax": 0,
						"intDefault": 0,
						"colorValue": "FFFFFFFF",
						"colorDefault": "FFFFFFFF",
						"colorHasAlpha": false,
						"boolValue": false,
						"boolDefault": false,
						"stringValue": "",
						"stringDefault": "",
						"sceneItemValue": "",
						"sceneItemDefault": ""
					}
				]
			}
		],
		"postProcessingPresets": [
			"My Cool Preset",
			"some_effects_preset_1",
			"some_effects_preset_2",
			"some_effects_preset_3",
			"test asdf 123456",
			"blur and color grading",
		]
	}
}
```

## 후처리 효과 설정

**참고:** 이 문서에서는 시각 효과, VFX, 후처리 효과 용어를 혼용하여 사용합니다.

VTube Studio는 내장 후처리 기능을 제공하여 장면에 시각 효과를 직접 추가할 수 있습니다. 이 기능은 Windows와 macOS에서 사용할 수 있습니다. 자세한 내용은 ["Visual Effects"](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects) 페이지를 참조하세요.

`PostProcessingUpdateRequest`를 사용하여 후처리 시스템을 제어할 수 있습니다. 후처리를 켜거나 끄고, 프리셋을 로드하거나 언로드하며, 개별 설정 항목(색상, 강도 등)을 직접 세밀하게 제어할 수 있습니다.

이 업데이트는 후처리 구성 관련 창이 열려 있지 않을 때만 전송할 수 있습니다. 그렇지 않으면 `PostProcessingUpdateReqestCannotUpdateRightNow` 오류가 반환됩니다. 이 요청이 반환할 수 있는 모든 오류는 ["ErrorsID.cs"](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/ErrorID.cs)를 참조하세요.

`postProcessingOn`을 사용하여 후처리를 전역적으로 켜거나 끌 수 있습니다. 이는 VTS UI에서 후처리 토글을 전환하는 것과 동일합니다. 후처리를 끈 상태에서도 같은 요청으로 프리셋이나 개별 설정 값을 지정할 수 있습니다. 값은 설정되지만 화면에는 아무 변화가 없습니다. VTube Studio에서 후처리 구성 창을 열면 요청한 값들이 설정된 것을 확인할 수 있으며, 후처리를 켜면 해당 값들이 화면에 반영됩니다. 프리셋을 설정하고 같은 요청으로 후처리를 끈 경우, 프리셋의 모든 값은 설정되지만 UI에서 프리셋이 활성 상태로 표시되지 않습니다. 후처리를 다시 켜면 프리셋의 모든 값이 표시됩니다.

후처리 구성 항목의 값을 설정하는 방법은 두 가지입니다:
* 후처리 프리셋 설정: `setPostProcessingPreset`를 `true`로 설정하고 `presetToSet` 필드에 프리셋 이름(파일 확장자 제외)을 제공합니다. 프리셋이 없으면 `PostProcessingUpdateRequestPresetFileLoadFailed` 오류가 반환됩니다.
* 개별 구성 값 설정: `setPostProcessingValues`를 `true`로 설정하고 `postProcessingValues` 배열에 구성 키/값 목록을 제공합니다.

둘을 동시에 할 수는 없습니다: `setPostProcessingPreset`와 `setPostProcessingValues`가 모두 `true`일 경우 `PostProcessingUpdateRequestLoadingPresetAndValues` 오류가 반환됩니다. 다만 둘 다 `false`일 수는 있습니다. 이 경우 값은 설정되지 않습니다. 현재 구성을 변경하지 않고 전역적으로 후처리만 켜거나 끄고 싶을 때 유용합니다.

구성 값을 직접 변경하거나 프리셋을 통해 변경할 때, 값은 이전 값에서 새 값으로 부드럽게 페이드됩니다. 페이드 시간은 `postProcessingFadeTime` 필드에 초 단위로 지정하며 0에서 2 사이여야 합니다. 범위를 벗어나면 `PostProcessingUpdateRequestFadeTimeInvalid` 오류가 반환됩니다.

개별 값 설정 시 `setAllOtherValuesToDefault` 필드는 나머지 값(페이로드에 포함되지 않은 값)을 변경하지 않고 유지할지, 아니면 기본값으로 페이드하여 모든 언급되지 않은 효과를 끌지 결정합니다.

[제한/실험적 효과](https://github.com/DenchiSoft/VTubeStudio/wiki/Visual-Effects#restrictedexperimental-effects)를 개별 구성 값 설정 시 사용하려면, 페이로드에 `usingRestrictedEffects`를 `true`로 설정해야 합니다. 이는 실수로 해당 효과를 사용하는 것을 방지하기 위한 안전장치입니다. 그렇지 않으면 `PostProcessingUpdateRequestTriedToLoadRestrictedEffect` 오류가 반환됩니다. 또한 사용자가 VTube Studio VFX 설정에서 해당 효과 사용을 수동으로 활성화하지 않은 경우에도 이 오류가 반환됩니다. 프리셋에 제한 효과가 포함된 경우에는 오류 없이 프리셋이 완전히 로드되지만 제한 효과는 활성화되지 않습니다.

효과 구성 전체를 무작위로 설정할 수도 있습니다. 재미를 위한 기능입니다. 이를 위해 `randomizeAll`을 `true`로 설정하세요. `randomizeAll`이 `true`일 때는 페이로드에 포함된 구성 값이나 프리셋이 무시됩니다. 많은 효과가 동시에 활성화되면 무작위 잡음이 발생하므로 효과 수를 제한하고 구성 값이 너무 과하지 않도록 합니다. 이 기능은 0에서 1 사이 값을 받는 `randomizeAllChaosLevel` 필드로 제어할 수 있습니다(범위 밖 값은 클램핑됨). `0`은 1~2개의 효과가 약한 값으로 활성화되고, `1`은 화면에 완전한 혼란을 만듭니다. 좋은 효과를 위해서는 0.4~0.5 범위가 권장됩니다. 제한 효과는 `usingRestrictedEffects`가 `true`이고 사용자가 해당 효과 사용을 허용한 경우에만 무작위 설정에 포함됩니다.

### 개별 구성 값 설정 방법

후처리 구성을 세밀하게 제어하려면 `setPostProcessingValues`를 `true`로 설정하고 `postProcessingValues` 배열로 값을 설정해야 합니다. `configID`는 구성 효과 ID이며, `configValue`는 설정할 값을 문자열로 나타냅니다.

* `configID`: 구성하려는 구성의 ID입니다. [모든 구성 ID 목록](https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs)을 참조하세요. 이 ID들은 다양한 형식을 허용하므로 원하는 열거형 스타일로 만들 수 있습니다. 대소문자를 구분하지 않고, `_`나 `-`는 무시됩니다. 예를 들어 `Backlight_OutlineSize` 대신 `Backlight_Outline_Size`, `backlight_outlinesize`, `BACKLIGHT_OUTLINESIZE`, `backlight-outline_size` 등 원하는 형식으로 쓸 수 있습니다(`PostProcessingListResponse`의 `configEntries` 배열 내 `enumID` 필드 참고).
* `configValue`: 설정할 값(문자열). 부동소수점이나 정수의 경우 구성의 최소/최대 범위를 벗어나면 클램핑됩니다. 불리언 값은 대소문자를 구분하지 않아 `"True"`나 `"true"`(또는 `"TRUE"` 등)가 모두 허용됩니다.

배열에 중복 키가 있으면 `PostProcessingUpdateRequestValueListContainsDuplicates` 오류가 반환되고, 키가 유효하지 않거나 값이 올바르게 역직렬화되지 않으면 `PostProcessingUpdateRequestValueListInvalid` 오류가 반환됩니다.

**효과를 실제로 "켜는" 방법:** 효과는 여러 구성 항목을 가질 수 있습니다. 각 효과는 적어도 하나의 구성 항목을 가지며(종종 여러 개), 그 항목 값이 0보다 크면 효과가 켜집니다. `PostProcessingListResponse` 페이로드에서 해당 구성(항상 부동소수점 타입)은 `"activationConfig": true`로 표시됩니다. 모든 효과 구성 목록에서 이러한 특수 구성은 `sets_active: True`로 표시되어 있습니다. 참고: https://github.com/DenchiSoft/VTubeStudio/blob/master/Files/EffectConfigs.cs

### 일반적인 사용 조언

이 요청은 높은 빈도로, 예를 들어 매 프레임마다 보내면 안 됩니다. 값을 페이드하려면 적절한 페이드 시간을 설정하기 위해 `postProcessingFadeTime` 필드를 사용하세요. 구성 조합에 따라 빈번한 업데이트가 *괜찮을 수도* 있지만, 반드시 신중하게 테스트해야 합니다. 후처리 시스템은 드문 구성 업데이트에 최적화되어 있으므로, 플러그인을 배포하기 전에 지연 현상이 발생하는지 확인하세요. 

**`REQUEST`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateRequest",
	"data":
	{
		"postProcessingOn": true,
		"setPostProcessingPreset": false,
		"setPostProcessingValues": true,
		"presetToSet": "",
		"postProcessingFadeTime": 1.3,
		"setAllOtherValuesToDefault": true,
		"usingRestrictedEffects": false,
		"randomizeAll": false,
		"randomizeAllChaosLevel" : 0.0,
		"postProcessingValues": [
			{
				"configID": "Backlight_Strength",
				"configValue": "0.8"
			},
			{
				"configID": "Bloom_Strength",
				"configValue": "1.0"
			},
			{
				"configID": "Bloom_StreakVertical",
				"configValue": "false"
			},
			{
				"configID": "Bloom_StreakColorTint",
				"configValue": "220308FF"
			}
		]
	}
}
```

오류가 없으면 요청하신 업데이트 후 새 후처리 상태에 대한 일반 정보와 함께 다음 응답을 받게 됩니다.

**`응답`**
```json
{
	"apiName": "VTubeStudioPublicAPI",
	"apiVersion": "1.0",
	"timestamp": 1625405710728,
	"requestID": "SomeID",
	"messageType": "PostProcessingUpdateResponse",
	"data":
	{
		"postProcessingActive": true,
		"presetIsActive": false,
		"activePreset": "",
		"activeEffectCount": 2
	}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-29

---