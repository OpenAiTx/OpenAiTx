> [!TIP]  
> 더 발전된 실내 내비게이션 솔루션을 찾고 계신가요?  
> 지도 편집, 3D 뷰, 실외 지도 통합 기능을 제공하는 [OpenIndoorMaps](https://github.com/openindoormap/openindoormaps)를 사용해 보세요.

# Pathpal: 웹 기반 실내 길찾기

Pathpal은 실내 내비게이션을 혁신적으로 변화시키기 위해 설계된 혁신적인 웹 애플리케이션입니다. 인터랙티브 지도와 효율적인 경로 탐색 알고리즘을 사용하여 복잡한 실내 공간을 직관적으로 탐색할 수 있는 솔루션을 제공합니다.  
<br>  
**데모:** [Pathpal 방문하기](https://indoor-wayfinder.vercel.app)

## 목차:

- [Pathpal: 웹 기반 실내 길찾기](#pathpal-웹-기반-실내-길찾기)  
  - [목차:](#목차)  
  - [앱 소개](#앱-소개)  
  - [스크린샷](#스크린샷)  
  - [기능](#기능)  
  - [기술 스택](#기술-스택)  
  - [설치 방법](#설치-방법)  
  - [기술적 인사이트](#기술적-인사이트)  
    - [지도 기술](#지도-기술)  
    - [경로 탐색](#경로-탐색)  
    - [핵심 지도 기술](#핵심-지도-기술)  
    - [경로 그리기 및 길찾기](#경로-그리기-및-길찾기)  
    - [지도 커스터마이징](#지도-커스터마이징)  
  - [기여자](#기여자)  
  - [라이선스](#라이선스)

## 앱 소개

이 프로젝트는 인터랙티브 실내 길찾기 및 내비게이션을 위한 인터랙티브 SVG 지도와 다익스트라 알고리즘을 활용하여 관심 지점(POI)까지 최단 경로를 계산하는 졸업 프로젝트 변형판입니다. 원래 애플리케이션은 BLE 기술을 활용한 실내 위치 측정을 실험했으나, Bluetooth Web API의 실험적 특성으로 인해 이번 변형판에서는 제외되었습니다.

> [!WARNING]  
> 본 프로젝트의 백엔드는 제거되었습니다. 모든 데이터는 JSON 파일에 저장됩니다. 이 프로젝트는 프로토타입이며 상용 목적으로 사용해서는 안 됩니다. 보다 종합적인 솔루션은 제 새로운 프로젝트 [OpenIndoorMaps](https://github.com/yourusername/OpenIndoorMaps)를 확인해 주세요.

## 스크린샷

<table style="border-radius: 10px;  border: 1px solid gray;">  
  <tr >  
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-map-details.png"/></td>
   <td align="center"><h3 >클릭 시 객체 정보 표시</h3></td>
  </tr>
    <tr>
    <td align="center"><img src="https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/indoor-wayfinding.png"/></td>
    <td align="center"><h3>최단 경로 계산 시연</h3></td>
  </tr>
</table>

## 기능

- **인터랙티브 SVG 지도**: 복잡한 실내 공간을 쉽게 탐색할 수 있습니다.
- **다익스트라 경로 탐색**: 목적지까지 최단 경로를 계산합니다.
- **반응형 디자인**: 모든 기기와 화면 크기에 최적화되어 있습니다.
- **사용자 지정 POI**: 관심 지점의 이름과 카테고리를 편집할 수 있습니다.
- **핀치 투 줌**: 터치 제스처로 지도를 손쉽게 확대 및 축소할 수 있습니다.

## 기술 스택

Pathpal은 속도, 효율성 및 적응성을 위해 최신 웹 기술로 구축되었습니다:

- React
- Vite
- TypeScript
- TailwindCSS
- SVG
- 다익스트라 알고리즘

## 설치 방법

프로젝트를 실행하려면 다음 단계를 따르세요:

1. **레포지토리 복제**: 선호하는 Git 클라이언트를 사용하여 이 레포지토리를 로컬 머신에 복제하세요.

2. **Node.js 설치**: 이 프로젝트는 Node.js가 필요합니다. Node.js 버전 21이 설치되어 있지 않은 경우 [nodejs.org](https://nodejs.org/)에서 다운로드하여 설치할 수 있습니다.

3. **의존성 설치**: 터미널에서 프로젝트 디렉터리로 이동한 후 다음 명령어를 실행하여 필요한 의존성을 설치하세요:

   ```bash
   npm install
   ```
4. **애플리케이션 시작하기**: 종속 항목이 설치되면 터미널에서 다음 명령어를 실행하여 애플리케이션을 시작할 수 있습니다:


   ```bash
   npm run dev
   ```
이 명령어들을 실행한 후, 기본 웹 브라우저가 자동으로 열리며 `localhost:5173`으로 이동하여 실행 중인 애플리케이션을 확인할 수 있습니다.

## 기술적 통찰

### 지도 기술

- **SVG 포맷**: 지도는 주로 SVG 형식을 사용하며, 유연성과 상호작용 기능이 뛰어나 상세한 내비게이션에 적합합니다.
- **이미지 포맷 지원**: PNG 및 JPEG와 같은 다양한 포맷을 지도 배경으로 지원하며, 상호작용 기능은 SVG에 가장 적합합니다.

### 경로 탐색

- **경로 정의**: 지도 내 경로는 이동 가능한 루트를 나타내며, Dijkstra 알고리즘이 효율적인 경로를 계산하는 데 필수적입니다.
- **Dijkstra 알고리즘**: POI 간의 정확하고 신속한 내비게이션을 보장합니다.

### 핵심 지도 기술

- **기본 포맷으로서의 SVG**: 이 애플리케이션은 확장성과 조작 용이성 때문에 주로 SVG(Scalable Vector Graphics) 파일을 지도에 사용합니다. SVG는 실내 공간을 인터랙티브하고 동적으로 렌더링할 수 있어 상세한 내비게이션 경로에 이상적입니다.
- **다양한 이미지 포맷 지원**: 기본은 SVG이지만, 시스템은 PNG, JPEG 등 어떤 이미지 포맷도 지도 배경으로 사용할 수 있도록 설계되었습니다. 이 유연성 덕분에 개발자는 기존 평면도나 지도를 SVG로 변환하지 않고도 사용할 수 있습니다. 다만 주요 상호작용 및 내비게이션 기능은 SVG에 최적화되어 있습니다.

### 경로 그리기 및 길찾기

- **경로 그리기**: 내비게이션이 작동하려면 지도 내에 경로가 정의되어야 합니다. 이 경로는 보행 가능한 루트를 나타내며, 길찾기 알고리즘에 매우 중요합니다. SVG 파일에서는 경로를 직접 그리거나 편집할 수 있어 내비게이션 경로를 정밀하게 제어할 수 있습니다.
- **길찾기 알고리즘**: 이 애플리케이션은 지도 내 관심 지점(POI) 간 최단 경로 계산을 위해 Dijkstra 알고리즘을 사용합니다. 이 알고리즘은 지도에 그려진 경로 네트워크를 기반으로 효율적이고 정확한 내비게이션을 보장합니다.

### 지도 커스터마이징

- **편집 도구**: 개발자는 Adobe Illustrator나 Boxy SVG와 같은 벡터 그래픽 편집 도구를 사용해 SVG 지도를 수정할 수 있습니다. 이 수정 작업은 레이아웃 업데이트, 관심 지점(POI) 추가/삭제, 경로 조정 등을 포함할 수 있습니다. 아래 스크린샷에서 Boxy SVG를 사용한 지도 편집 예시를 확인하세요. SVG를 JSX로 변환할 때는 [Transform Tools](https://transform.tools/)가 유용한 리소스입니다.

![IndoorMap Editing Example](https://raw.githubusercontent.com/KnotzerIO/indoor-wayfinder/main/media/map-editing-preview.png)

## 크레딧

이 프로젝트는 제 졸업 작품에서 영감을 받았으며, 멘토, 동료 그리고 [maciejb2k의 경로 탐색 앱](https://github.com/maciejb2k/pathfinding_app)과 같은 자료들의 지원에 크게 영향을 받았습니다.

## 라이선스

Pathpal은 MIT 라이선스 하에 오픈 소스로 공개되어 있습니다. 기여와 피드백을 환영합니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-15

---