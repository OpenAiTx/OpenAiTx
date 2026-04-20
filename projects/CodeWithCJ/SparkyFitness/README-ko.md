<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

MyFitnessPal의 자가 호스팅, 프라이버시 우선 대안입니다. 영양, 운동, 신체 지표, 건강 데이터를 추적하면서 데이터에 대한 완전한 통제권을 유지하세요.

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness는 다음으로 구성된 자가 호스팅 피트니스 추적 플랫폼입니다:

- 백엔드 서버(API + 데이터 저장소)
- 웹 기반 프론트엔드
- iOS 및 Android용 네이티브 모바일 앱

타사 서비스에 의존하지 않고, 사용자가 관리하는 인프라에 건강 데이터를 저장하고 관리합니다.

## 핵심 기능

- 영양, 운동, 수분 섭취, 수면, 단식, 기분 및 신체 측정 추적
- 목표 설정 및 일일 체크인
- 대화형 차트 및 장기 보고서
- 다중 사용자 프로필 및 가족 접근 권한
- 라이트 및 다크 테마
- OIDC, TOTP, 패스키, MFA 등

## 건강 & 기기 통합

SparkyFitness는 여러 건강 및 피트니스 플랫폼에서 데이터를 동기화할 수 있습니다:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (부분적으로 테스트됨)
- **Hevy** (테스트되지 않음)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (부분적으로 테스트됨)

통합 기능은 걸음 수, 운동, 수면과 같은 활동 데이터 및 체중, 신체 측정치 등 건강 지표를 SparkyFitness 서버에 자동으로 동기화합니다.

## 선택적 AI 기능 (베타)

SparkyAI는 데이터 기록 및 진행 상황 검토를 위한 대화형 인터페이스를 제공합니다.

- 채팅을 통해 음식, 운동, 신체 통계, 걸음 수 기록
- 자동 식사 기록을 위한 음식 이미지 업로드
- 후속 조치를 위해 대화 기록을 보존합니다

참고: AI 기능은 현재 베타 버전입니다.

## 빠른 시작 (서버)

Docker Compose를 사용하여 몇 분 만에 SparkyFitness 서버를 실행하세요.

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 동영상 튜토리얼

[![동영상 보기](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

SparkyFitness(자가 호스팅 피트니스 트래커) 설치 방법을 보여주는 2분짜리 빠른 튜토리얼입니다.


## 문서

전체 설치 가이드, 구성 옵션, 개발 문서는 [문서 사이트](https://codewithcj.github.io/SparkyFitness/)를 방문하세요.

### 빠른 링크

- **[설치 가이드](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - 배포 및 구성
- **[기능 개요](https://codewithcj.github.io/SparkyFitness/features)** - 전체 기능 문서
- **[개발 워크플로우](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - 개발자 가이드 및 기여 프로세스
- **[iOS 앱 정보](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** 및 **[Android 앱 정보](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### 도움이 필요하신가요?

- Github 이슈/토론에 글을 남기세요.
- 더 빠른 답변과 다른 커뮤니티 멤버들의 도움을 원하시면 **[디스코드 참여](https://discord.gg/vcnMT5cPEA)**

## 별점 이력

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="별점 이력 차트" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## 번역

**[Weblate 번역](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">

<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="Translation status" />
</a>

## 저장소 활동

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "Repobeats analytics image")

## 기여자

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ 알려진 문제 / 베타 기능 ⚠️

SparkyFitness는 활발히 개발 중입니다.
릴리스 간에 호환성 깨짐 현상이 발생할 수 있습니다.

- 컨테이너의 자동 업데이트는 권장하지 않습니다
- 업그레이드 전에 항상 릴리스 노트를 확인하세요

다음 기능들은 현재 베타 버전이며 충분히 테스트되지 않았을 수 있습니다. 버그나 미완성 기능이 있을 수 있습니다:

- AI 챗봇
- 가족 및 친구 접근
- API 문서


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---