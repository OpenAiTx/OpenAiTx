<translate-content># OpenSpot 뮤직 🎶

<p align="center">
 <img width="100" alt="OpenSpot 로고" src="https://github.com/user-attachments/assets/9f56500d-d950-48c6-a362-bcbc74be88cb" />
</p>

<h3 align="center">무한한 음악으로 가는 관문 - 크로스 플랫폼 음악 스트리밍</h3>

<p align="center">
  <strong>모든 기기에서 광고 없이, 로그인 없이 무료로 고음질 음악을 스트리밍하고 다운로드하세요.</strong>
</p>

<p align="center">
  <a href="https://github.com/BlackHatDevX/openspot-music-app/stargazers">
    <img src="https://img.shields.io/github/stars/BlackHatDevX/openspot-music-app?style=for-the-badge&color=ffd700" alt="Stars">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/network/members">
    <img src="https://img.shields.io/github/forks/BlackHatDevX/openspot-music-app?style=for-the-badge&color=84b4a3" alt="Forks">
  </a>
  <a href="https://github.com/BlackHatDevX/openspot-music-app/issues">
    <img src="https://img.shields.io/github/issues/BlackHatDevX/openspot-music-app?style=for-the-badge&color=f38ba8" alt="Issues">
  </a>
</p>

---

## 📱📺 두 개의 놀라운 앱, 하나의 저장소

이 저장소에는 **두 개의 완전한 음악 스트리밍 애플리케이션**이 포함되어 있습니다:

### 🎵 **OpenSpot 모바일** (React Native + Expo)
- **플랫폼**: Android, iOS
- **위치**: `openspot-music-mobile/`
- **특징**: 오프라인 다운로드, 백그라운드 재생, 지속 상태를 지원하는 네이티브 모바일 경험

### 🖥️ **OpenSpot 데스크탑** (Electron + React)
- **플랫폼**: macOS, Windows, Linux
- **위치**: `openspot-music-electron/`
- **특징**: 전역 오디오 제어, 창 관리, 로컬 저장소 기능이 포함된 데스크탑 최적화 인터페이스

---

## ✨ 주요 기능 (양쪽 앱 모두)

- **🎵 고음질 스트리밍**: 좋아하는 트랙을 최고의 품질로 감상하세요
- **💾 오프라인 다운로드**: 음악을 기기에 직접 저장하여 오프라인 청취 가능
- **❤️ 좋아요 & 컬렉션**: 노래에 좋아요를 눌러 개인 컬렉션을 만드세요
- **🔄 백그라운드 재생**: 다른 앱 사용 중에도 계속 듣기
- **🚫 로그인 불필요**: 바로 시작하세요! 계정이나 가입이 필요 없습니다
- **💾 지속 상태 저장**: 좋아요 누른 곡과 최근 재생한 트랙이 앱 재시작 후에도 저장됩니다
- **🎨 아름다운 UI**: 각 플랫폼에 맞춘 깔끔하고 현대적인 인터페이스
- **🆓 완전 무료 & 광고 없음**: 비용이나 광고 없이 끊김 없는 음악 감상

---

## 📱 모바일 앱 (React Native + Expo)

### 스크린샷

![Android 앱](https://github.com/user-attachments/assets/5a48d1e1-c862-4cea-9d0a-a29606ac5b74)

### 다운로드 링크

- **Android APK**: [OpenSpot-2.0.2-release.apk](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot-2.0.2-release.apk)
- **iOS**: 곧 출시 예정 (TestFlight)

### 개발 환경 설정

```bash
cd openspot-music-app
cd openspot-music-mobile/
npm install
npx expo start
```
### 프로덕션 빌드


```bash
cd openspot-music-app/

# Development Build
eas build --platform android --profile development

# Preview Build (APK)
eas build --platform android --profile preview

# Production Build
eas build --platform android --profile production
```
---

## 🖥️ 데스크톱 앱 (Electron + React)

### 스크린샷

![macOS 앱](https://github.com/user-attachments/assets/1cb18d3f-4986-4eb2-9cd2-1b606fbf31db)

### 다운로드 링크

- **macOS DMG**: [OpenSpot.Music-2.0.2-arm64.dmg](https://github.com/BlackHatDevX/openspot-music-app/releases/download/v2.0.2/OpenSpot.Music-2.0.2-arm64.dmg)
- **Windows EXE**: 곧 제공 예정!
- **Linux DEB**: 곧 제공 예정!

### 개발 환경 설정


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
### 프로덕션 빌드


```bash
cd openspot-music-app/
cd openspot-music-electron/
npm run build
npm run electron-pack
```
---


## 💻 기술 스택

### 모바일 앱
- **프레임워크**: [React Native](https://reactnative.dev/) 와 [Expo](https://expo.dev/)
- **내비게이션**: [Expo Router](https://expo.github.io/router/)
- **오디오**: [Expo AV](https://docs.expo.dev/versions/latest/sdk/av/)
- **빌드**: [EAS Build](https://docs.expo.dev/build/introduction/)

### 데스크탑 앱
- **프레임워크**: [Electron](https://www.electronjs.org/) + [React](https://reactjs.org/)
- **UI**: [Material-UI](https://mui.com/)
- **상태 관리**: React Context + useReducer
- **저장소**: [electron-store](https://github.com/sindresorhus/electron-store)
- **빌드**: [electron-builder](https://www.electron.build/)

### 공통
- **언어**: [TypeScript](https://www.typescriptlang.org/)
- **패키지 매니저**: npm/yarn

---

## 🚀 빠른 시작

### 모바일 개발용

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-mobile/
npm install
npx expo start
```
### 데스크탑 개발용

```bash
git clone https://github.com/BlackHatDevX/openspot-music-app.git
cd openspot-music-app/
cd openspot-music-electron/
npm install
npm run electron-dev
```
---

## 🤝 기여하기

두 앱 모두에 대한 기여를 환영합니다!
## 📞 커뮤니티 & 지원

- **텔레그램**: [Openspot Music](https://telegram.dog/Openspot_Music)
- **이슈**: [GitHub Issues](https://github.com/BlackHatDevX/openspot-music-app/issues)

## 👤 저자 & 연락처

**Jash Gro**

- **링크드인**: [https://linkedin.com/in/jash-gro/](https://linkedin.com/in/jash-gro/)
- **포트폴리오**: [https://bit.ly/jashgro](https://bit.ly/jashgro)
- **텔레그램**: [https://telegram.dog/deveIoper_x](https://telegram.dog/deveIoper_x)
- **GitHub**: [https://github.com/BlackHatDevX](https://github.com/BlackHatDevX)

## 📄 라이선스

이 프로젝트는 오픈 소스이며 MIT 라이선스 하에 배포됩니다. 자세한 내용은 `LICENSE` 파일을 참조하세요.

---

<p align="center">
  <strong>⭐ 이 프로젝트가 마음에 드시면 별점을 주세요! ⭐</strong>
  <br />
  <em>여러분의 지원은 모두를 위한 멋진 무료 음악 앱 개발을 계속하는 데 큰 힘이 됩니다.</em>
</p> 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---