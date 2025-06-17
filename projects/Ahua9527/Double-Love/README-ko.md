# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 프레임 사이에도 사랑이, 효율은 두 배

[//]: # (코드에 숨겨진 이스터에그)
<!Double Love：모든 샷에 내가 말하지 못한 프레임률이 숨어있어요 -->

[English](./README.en.md) · 简体中文 · [온라인 체험](https://double-love.ahua.space)

</div>

Double Love는 슬레이트 메타데이터의 자동화 표준화 처리를 제공합니다. 오프라인 사용을 지원합니다. 배치 처리와 로컬 처리를 통해 Adobe Premiere, Silverstack, DTG Slate와의 원활한 연동으로 메타데이터 일관성을 보장합니다. 후반 작업 워크플로의 효율을 효과적으로 향상시킵니다.

## ✨ 기능 특성

- 🎬 영화 산업화 워크플로 지원
- 📝 지능형 메타데이터 표준화 처리
- ⚡ 지연 없는 로컬 처리
- 🧩 Adobe Premiere와의 완벽한 연동

## 🚀 빠른 시작

### 기본 워크플로

1. 슬레이트 기록: DTG Slate를 사용해 인터랙티브 슬레이트 시트 생성
2. 데이터 관리: Silverstack Lab을 통해 슬레이트 데이터 가져오기
3. 파일 내보내기: Adobe Premiere Pro XML 생성
4. 표준화 처리: Double Love로 지능형 최적화 수행

예시:
- 입력 xml: `UnitA_304_20250127.xml`
- 출력 xml: `UnitA_304_20250127_Double_LOVE.xml`

### 상세 예시

#### 파일명 최적화
- 프로그램이 자동으로 씬 번호, 샷 번호, 테이크 번호의 형식을 처리합니다
- 숫자에 자동으로 앞자리에 0을 추가합니다
- 대소문자 규칙을 자동으로 처리합니다
- 불필요한 밑줄을 자동으로 정리합니다

#### 클립 명명 규칙

처리된 클립 이름은 다음 형식을 따릅니다:
```
{프로젝트_접두사}{씬}_{샷}_{테이크}{카메라}{평가}
```

- `prefix`: 사용자 정의 접두사(선택)
- `scene`: 씬 번호(3자리 숫자, 예: 001)
- `shot`: 샷 번호(2자리 숫자, 예: 01)
- `take`: 테이크 번호(2자리 숫자, 예: 01)
- `camera`: 카메라 식별(소문자 알파벳, 예: a)
- `Rating`: 평점(ok/kp/ng)

#### 평가 처리
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### DIT 정보
- 'DIT: 哆啦Ahua 🌱' 정보를 자동 추가
- 제거가 필요할 경우 직접 배포하여 사용해 주세요😁😁

#### 사용자 정의 접두사 예시

1. 접두사를 "PROJECT_A_"로 설정:
   - 입력 파일: `A304C007_250123G3`
   - 출력 파일: `PROJECT_A_004_01_07a_kp`

2. 접두사 미설정:
   - 입력 파일: `A304C007_250123G3`
   - 출력 파일: `004_01_07a_kp`

#### 시퀀스 해상도 설정 예시

1. FHD 해상도(기본값):
   - 너비: 1920
   - 높이: 1080   
2. DCI 2K 해상도(사용자 지정):
   - 너비: 2048
   - 높이: 1080   

#### 배치 처리 예시

1. 여러 파일 동시 업로드:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. 처리 완료 후 다음과 같이 출력:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ 기술 스택

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- PWA 지원

## 📦 설치 및 사용

1. 프로젝트 클론

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. 의존성 설치

```bash
npm install
```

3. 로컬 개발

```bash
npm run dev
```

4. 프로젝트 빌드

```bash
npm run build
```

## 🔒 보안 안내

- 모든 파일 처리는 브라우저 로컬에서 이루어지며, 서버로 업로드되지 않습니다
- 최대 50MB 파일 크기까지 지원합니다
- XML 형식 파일만 처리할 수 있습니다

## 🌈 개발자 안내

### 프로젝트 구조

```
Double-Love/
├── src/
│   ├── components/     # React 컴포넌트
│   ├── context/       # React Context
│   ├── utils/         # 유틸리티 함수
│   ├── styles/        # 스타일 파일
│   └── App.tsx        # 메인 앱 컴포넌트
├── public/            # 정적 리소스
└── ...설정 파일
```

## 📃 라이선스

[MIT License](LICENSE)

## 🤝 기여 안내

이슈와 Pull Request 환영합니다!

## 👨‍💻 작성자

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---