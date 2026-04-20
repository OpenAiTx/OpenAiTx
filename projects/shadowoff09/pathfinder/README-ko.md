# 🗺️ Pathfinder

<div align="center">
  <img src="https://raw.githubusercontent.com/shadowoff09/pathfinder/master/public/banner-readme.png" alt="Pathfinder 배너" width="1280"/>
  
  Next.js 15, MapboxGL, TypeScript로 구축된 현대적이고 인터랙티브한 지도 애플리케이션입니다. Pathfinder는 실시간 날씨 데이터, 위치 검색, 사용자 정의 가능한 지도 스타일과 같은 기능으로 원활한 지도 경험을 제공합니다.

  [데모](https://link.shadowdev.xyz/r/m3tydbf12hb) · [버그 신고](https://github.com/shadowoff09/pathfinder/issues) · [기능 요청](https://github.com/shadowoff09/pathfinder/issues)
</div>

## ✨ 기능

- 🌓 다크/라이트 모드 지원
- 🏢 3D 건물 시각화
- 🔍 자동 완성 위치 검색
- 🌤️ 실시간 날씨 정보
- 📍 현재 위치 감지
- 🛰️ 거리/위성 뷰 전환
- 📱 완전 반응형 디자인
- ⌨️ 키보드 단축키 지원
- 🎨 Tailwind CSS와 shadcn/ui를 사용한 현대적인 UI

## 🚀 시작하기

### 필수 조건

- Node.js 22+
- Mapbox API 키 ([Mapbox](https://www.mapbox.com/)에서 발급)
- OpenWeather API 키 ([OpenWeather](https://openweathermap.org/api)에서 발급)
- npm 또는 yarn

### 설치

1. 저장소 클론:
```bash
git clone https://github.com/shadowoff09/pathfinder.git
cd pathfinder
```
2. 의존성 설치:

```bash
npm install
# or
yarn install
```
3. 환경 변수 설정:
   - `.env.example` 파일을 `.env.local`로 복사하세요:

     ```bash
     cp .env.example .env.local
     ```
   - `.env.local` 파일을 열고 Mapbox API 키를 추가하세요:
     ```env
     NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token_here
     NEXT_PUBLIC_WEATHER_API_KEY=your_weather_api_key_here
     ```
   - API 키를 다음에서 가져오세요:
     - [Mapbox](https://www.mapbox.com/) - 지도 기능용
     - [OpenWeather](https://openweathermap.org/api) - 날씨 데이터용

4. 개발 서버 시작:
```bash
npm run dev
# or
yarn dev
```
5. 브라우저에서 [http://localhost:3000](http://localhost:3000) 을 엽니다.

## 🎮 사용법

### 지도 탐색
- 이동: 클릭 후 드래그
- 확대/축소: 스크롤 또는 확대/축소 컨트롤 사용
- 회전: 우클릭 후 드래그
- 뷰 초기화: Ctrl+Q 키 누르기

### 기능
- 검색창을 통해 위치 검색
- 거리뷰와 위성뷰 전환
- 거리뷰 모드에서 3D 건물 보기 (줌 레벨 15 이상)
- 날씨 정보 확인 (줌 레벨 14 이상)
- 한 번의 클릭으로 현재 위치 가져오기
- 좌표를 클립보드에 복사

## 🛠️ 사용 기술

- [Next.js 15](https://nextjs.org/) - React 프레임워크
- [TypeScript](https://www.typescriptlang.org/) - 타입 안전성
- [Mapbox GL JS](https://www.mapbox.com/mapbox-gl-js) - 지도 API
- [Tailwind CSS](https://tailwindcss.com/) - 스타일링
- [shadcn/ui](https://ui.shadcn.com/) - UI 컴포넌트
- [React Map GL](https://visgl.github.io/react-map-gl/) - Mapbox GL의 React 래퍼

## 🤝 기여하기

기여를 환영합니다! Pull Request를 자유롭게 제출해 주세요. 주요 변경 사항의 경우, 변경하고자 하는 내용을 먼저 논의하기 위해 이슈를 열어 주세요.

1. 프로젝트를 포크하세요
2. 기능 브랜치 생성 (`git checkout -b feature/AmazingFeature`)
3. 변경 사항 커밋 (`git commit -m 'Add some AmazingFeature'`)
4. 브랜치에 푸시 (`git push origin feature/AmazingFeature`)
5. Pull Request를 오픈하세요

## 📝 라이선스


이 프로젝트는 MIT 라이선스에 따라 라이선스가 부여되었습니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 🙏 감사의 말씀

- 훌륭한 지도 플랫폼을 제공해 주신 [Mapbox](https://www.mapbox.com/)
- 아름다운 UI 컴포넌트를 제공해 주신 [shadcn/ui](https://ui.shadcn.com/)
- 호스팅 및 배포를 지원해 주신 [Vercel](https://vercel.com)

## 📫 연락처

X - [@shadowdev09](https://twitter.com/shadowdev09)

포트폴리오 - [https://shadowdev.xyz](https://shadowdev.xyz)

## 💖 프로젝트 지원하기

Pathfinder를 즐겨 사용하시고 개발을 지원하고 싶으시다면, 기부를 고려해 주세요:

- [PayPal로 기부하기](https://paypal.me/diogogaspar123)
- [Ko-Fi로 기부하기](ko-fi.com/shadowoff09)
- [GitHub 후원하기](https://github.com/sponsors/shadowoff09)


여러분의 기여는 프로젝트를 지속하고 기능을 개선하는 데 큰 도움이 됩니다! 지원해 주셔서 감사합니다!

---
<a href="https://www.producthunt.com/posts/pathfinder-11?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-pathfinder&#0045;11" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=915601&theme=dark&t=1740532963013" alt="Pathfinder - Navigate&#0032;Your&#0032;World&#0044;&#0032;Beautifully | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

⭐️ 이 프로젝트가 마음에 드신다면, 별을 눌러 주세요!

[![시간에 따른 스타 수](https://starchart.cc/shadowoff09/pathfinder.svg?variant=adaptive)](https://starchart.cc/shadowoff09/pathfinder)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---