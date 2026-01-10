# 16/32 비트 그레이스케일 PNG/EXR 하이트맵 생성기

실제 지형 데이터를 기반으로 고품질 16비트 그레이스케일 PNG 하이트맵 또는 16/32비트 EXR 하이트맵을 생성하는 브라우저 기반 도구입니다.

언리얼 엔진 5 및 Terrain3d, Godot4, Blender와 같은 기타 게임 엔진 또는 3D 소프트웨어에서 사실적인 지형을 만드는 데 적합합니다.

🌐 **라이브 웹사이트:** [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/L4L212G6M7)

## ⚠️ 중요 공지

일부 지도 서비스의 무료 사용 한도에 도달하기 시작하여, 자금 지원이 이루어질 때까지 사이트가 *작동하지 않을 수 있습니다*. 이 도구가 유용하다면 프로젝트 지원을 고려해 주세요!

## ✨ 기능

- **고품질 16/32비트 출력** - 8비트의 256레벨 대비 65,536/4,294,967,296 레벨의 디테일로 하이트맵 생성
- **실제 지형 데이터 사용** - [Mapzen의 글로벌 고도 서비스](https://www.mapzen.com/blog/elevation/)에서 제공하는 고품질 고도 데이터 활용
- **인터랙티브 지도 인터페이스** - 직관적인 지도 인터페이스를 통한 지형 영역 시각적 선택
- **다양한 정규화 모드** - None, Regular, Smart 정규화 중 선택하여 하이트맵 데이터 최적화
- **유연한 출력 크기** - 언리얼 엔진용 프리셋 크기 또는 최대 8129×8129 픽셀의 사용자 지정 크기 지원
- **브라우저 기반** - 설치 불필요, 웹 브라우저 내에서 완전 작동
- **실시간 미리보기** - 지도 위 오버레이로 내보내는 영역 즉시 확인 가능
- **좌표 복사 및 붙여넣기** - DMS 및 소수점 형식 등 다양한 좌표 형식 지원

## 🎯 사용 사례

- 언리얼 엔진 5/블렌더/Terrain3D 지형의 사실적 생성
- 정확한 실제 지형을 활용한 게임 개발
- 3D 모델링 및 시각화 프로젝트
- 지리 정보 시스템(GIS) 응용
- 교육 및 과학 시각화

## 🚀 빠른 시작

1. [https://manticorp.github.io/unrealheightmap/](https://manticorp.github.io/unrealheightmap/) 방문
2. 원하는 위치로 지도 탐색 또는 좌표 수동 입력
3. 내보낼 영역 정의를 위해 출력 확대 및 크기 조정(주황색 사각형으로 표시)
4. 용도에 맞는 정규화 모드 선택
5. "Generate" 버튼 클릭하여 하이트맵 생성 및 다운로드
자세한 지침은 [Documentation](https://manticorp.github.io/unrealheightmap/instructions.html) 페이지를 방문하세요.

## 📖 문서

- **[Instructions](https://manticorp.github.io/unrealheightmap/instructions.html)** - 도구 사용에 대한 종합 가이드
- **[Examples](https://manticorp.github.io/unrealheightmap/examples.html)** - 도구로 생성된 하이트맵 갤러리
- **[License Info](https://manticorp.github.io/unrealheightmap/rights.html)** - 데이터 소스 및 라이선스 정보

## 🛠️ 기술 스택

- **TypeScript** - 타입 안전 애플리케이션 코드
- **Leaflet** - 인터랙티브 지도 인터페이스
- **jQuery** - DOM 조작 및 UI 상호작용
- **UPNG.js** - PNG 인코딩/디코딩
- **Pako** - 데이터 압축
- **Webpack** - 모듈 번들링
- **Bulma** - CSS 프레임워크
- **SASS** - CSS 전처리

## 💻 개발 환경 설정

### 사전 요구 사항

- Node.js (v14 이상 권장)
- npm (Node.js에 포함)

### 설치


```bash
# Clone the repository
git clone https://github.com/manticorp/unrealheightmap.git
cd unrealheightmap

# Install dependencies
npm install
```

### 빌드 명령어

```bash
# Development build
npm run build

# Production build
npm run author

# Watch mode (auto-rebuild on changes)
npm run watch

# Run unit tests
npm test
```
### 프로젝트 구조


```
├── src/                   # Source TypeScript and SASS files
│   ├── app.ts             # Main application logic
│   ├── main.ts            # Entry point
│   ├── png.ts             # PNG processing
│   ├── processor.ts       # Web worker for image processing
│   ├── sass/              # Stylesheets
│   └── templates/         # HTML templates
├── public/                # Static assets and build output
│   ├── dist/              # Built JavaScript and CSS
│   ├── im/                # Images
│   └── examples/          # Example heightmaps
├── index.html             # Main application page
├── instructions.html      # Documentation page
├── examples.html          # Examples page
└── webpack.config.js      # Webpack configuration
```
## 🎨 예제

### 그랜드 캐년 (64km)
[도구에서 보기](https://manticorp.github.io/unrealheightmap/#latitude/36.18111652966563/longitude/-112.021/zoom/10/outputzoom/14/width/8129/height/8129)

![그랜드 캐년 예제](https://raw.githubusercontent.com/manticorp/unrealheightmap/main/public/im/grand_canyon_desserty.png)

더 많은 예제는 [예제 페이지](https://manticorp.github.io/unrealheightmap/examples.html)를 방문하세요.

## 🔧 정규화 모드

### 없음
정규화가 수행되지 않습니다. 픽셀 값은 높이를 미터 단위로 직접 나타내며(음수 값은 0으로 설정됨).

### 일반
높이 값을 전체 16비트 범위(0-65535)로 스케일하여 전체 높이맵에 걸쳐 세부 사항을 극대화합니다.

### 스마트
데이터 오류와 이상치를 처리하는 고급 모드입니다. 99.9% 구간을 사용하여 극단적인 값을 필터링하면서 1 표준편차 내의 진정한 최소/최대 값을 보존합니다.

## 📊 출력 형식

- **형식:** 16비트 그레이스케일 PNG, 16비트 EXR 또는 32비트 EXR
- **비트 깊이:** 65,536 단계의 세부 수준(2^16) 또는 4,294,967,296 단계(2^32)
- **정밀도:** 에베레스트 산(8,849m)을 약 13cm 간격으로 표현 가능 (16비트)
- **원본 데이터:** Mapzen 고도 데이터 (24비트 정밀도, 약 4mm 정확도)

## 🤝 기여

기여를 환영합니다! 이슈를 제출하거나 저장소를 포크하고 풀 리퀘스트를 생성해 주세요.

## 📄 라이선스

이 프로젝트는 MIT 라이선스 하에 제공됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

고도 데이터는 [Mapzen](https://www.mapzen.com/blog/elevation/)에서 제공하며 별도의 라이선스 조건이 있을 수 있습니다.

## 💖 지원


이 도구가 유용하다고 생각되시면, 프로젝트를 지원해 주세요:

- ☕ [Ko-fi에서 커피 한 잔 사기](https://ko-fi.com/harrymustoeplayfair)
- ⭐ 이 저장소에 별표를 주세요
- 🐦 유용할 수 있는 다른 사람들과 공유해 주세요

## 🙏 감사의 말

- 고품질 전 세계 고도 데이터를 제공해 주신 [Mapzen](https://www.mapzen.com/)
- 영감과 사용 사례를 제공해 준 [Unreal Engine](https://www.unrealengine.com/) 커뮤니티
- 이 도구의 모든 기여자와 사용자분들

## 📞 연락처

- **저자:** Harry Mustoe-Playfair
- **이메일:** harry.mustoeplayfair@gmail.com
- **GitHub:** [manticorp](https://github.com/manticorp)

---

Unreal Engine, 3D 및 게임 개발 커뮤니티를 위해 ❤️ 로 제작되었습니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-10

---