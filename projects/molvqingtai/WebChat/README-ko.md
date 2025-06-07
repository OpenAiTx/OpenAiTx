<p align="center">
  <img src="https://github.com/molvqingtai/WebChat/blob/master/public/logo.png" width="200px"/>
</p>

# WebChat

[![GitHub License](https://img.shields.io/github/license/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) [![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/cpaedhbidlpnbdfegakhiamfpndhjpgf)](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf) [![GitHub Release](https://img.shields.io/github/v/release/molvqingtai/WebChat)](https://github.com/molvqingtai/WebChat/releases)

> 어떤 웹사이트에서도 누구와든 채팅하세요

이것은 탈중앙화되고 서버리스이며, WebRTC를 활용해 종단 간 암호화된 통신을 제공하는 익명 채팅 브라우저 확장 프로그램입니다. 프라이버시를 최우선으로 하며, 모든 데이터는 로컬에 저장됩니다.

목표는 모든 웹사이트에 채팅방 기능을 추가하는 것입니다. 다시는 외로움을 느끼지 않을 것입니다.

### 설치

**스토어에서 설치**

- [Chrome 웹 스토어](https://chromewebstore.google.com/detail/webchat/cpaedhbidlpnbdfegakhiamfpndhjpgf)
- [Edge 웹 스토어](https://microsoftedge.microsoft.com/addons/detail/mmfdplbomjjlgdffecapcpgjmhfhmiob)
- [Firefox 부가 기능](https://addons.mozilla.org/firefox/addon/webchat/)

**수동 설치**

1. GitHub 저장소로 이동 ([Releases](https://github.com/molvqingtai/WebChat/releases))
2. "Assets" 버튼을 클릭하고 "web-chat-\*.zip"을 선택
3. ZIP 파일을 컴퓨터의 폴더에 압축 해제
4. 브라우저에서 확장 프로그램 관리 페이지를 엽니다 (보통 chrome://extensions/)
   - "개발자 모드" 활성화
   - "압축 해제된 확장 프로그램을 로드"를 클릭하고 방금 압축 해제한 폴더 선택

### 사용 방법

확장 프로그램을 설치한 후, 모든 웹사이트의 오른쪽 하단에 유령 아이콘이 표시됩니다. 아이콘을 클릭하면 같은 사이트에 있는 다른 사람들과 즐겁게 채팅할 수 있습니다!

### 영상

https://github.com/user-attachments/assets/e7ac9b8e-1b6c-43fb-8469-7a0a2c09d450

### 거인의 어깨 위에 서서

탈중앙화 채팅이라는 좋은 아이디어 외에도, 몇몇 훌륭한 기술들을 활용하고 있습니다.

- **[remesh](https://github.com/remesh-js/remesh)**: JavaScript로 작성된 프레임워크로 DDD 원칙을 구현하여 UI와 로직의 완전한 분리를 실현합니다. UI와 독립적이기 때문에 Vue로 다시 작성하는 등 UI 부분을 쉽게 구현할 수 있습니다.

- **[shadcn/ui](https://ui.shadcn.com/)**: 아름다운 UI 라이브러리이자 무설치(no-install) 개념의 선구자로, 스타일 커스터마이징에서 탁월한 편의성을 제공합니다.

- **[wxt](https://wxt.dev/)**: 지금까지 사용해 본 브라우저 확장 프로그램 빌드용 프레임워크 중 최고입니다.

- ~~**[trystero](https://github.com/dmotz/trystero)**: 탈중앙화 통신 구현을 위한 핵심 의존성으로, IPFS, 토렌트, Nostr 등 탈중앙 네트워크에 연결할 수 있게 해줍니다.~~
- **[Artico](https://github.com/matallui/artico)**: WebRTC 기반 솔루션을 직접 만들 수 있도록 도와주는 유연한 라이브러리 모음입니다.

- **[ugly-avatar](https://github.com/txstc55/ugly-avatar)**: 멋진 랜덤 아바타를 생성할 수 있습니다.

### 후원자

WebChat은 오픈 소스 프로젝트이며, 아래 훌륭한 후원자들의 지원 덕분에 지속적으로 개발되고 있습니다.

[![Powered by DartNode](https://dartnode.com/branding/DN-Open-Source-sm.png)](https://dartnode.com "Powered by DartNode - Free VPS for Open Source")

### 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다. 자세한 내용은 [LICENSE](https://github.com/molvqingtai/WebChat/blob/master/LICENSE) 파일을 참조하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---