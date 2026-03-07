# [역사적 국경](https://historicborders.app/)

역사 속 다양한 시기의 국가 경계를 시각화합니다 (기원전 2000년-1994년)

[r/dataisbeautiful](https://www.reddit.com/r/dataisbeautiful/comments/l52krh/an_app_i_made_for_visualizing_country_borders/)에서 확인할 수 있습니다.

## 스크린샷

<img width="1023" alt="screen-shot-of-app" src="https://user-images.githubusercontent.com/10817537/175097196-e746778d-241a-4bee-b406-aac294849597.png">

## 기능

### 정보 출처

이 앱은 두 가지 출처를 통해 국가 정보를 제공합니다:

1. **위키피디아** (기본값) - 위키피디아에서 실시간 정보를 가져옵니다
2. **AI 기반** - Google Gemini AI를 사용해 역사적 맥락과 함께 국가 정보를 생성합니다

푸터의 토글 버튼으로 이 출처들 간 전환이 가능합니다.

### AI 응답 캐싱

이 앱은 **Redis**를 사용해 AI 응답을 캐싱하여 성능을 향상시킵니다:

- ⚡ **즉각적인 응답** - 이전에 요청된 국가/연도에 대해
- 💰 **API 비용 절감** - Google Gemini 호출 횟수 감소
- 🔧 **스마트 만료** - 1시간 캐시 TTL로 콘텐츠 신선도 유지
- 📊 **분석 추적** - Google Analytics에서 캐시 적중/미스 비율 추적

자세한 설정 방법은 [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md)를 참조하세요.

### AI 기능 분석

이 앱은 AI 기능에 대한 사용자의 참여와 성능을 이해하기 위해 Google Analytics 추적을 포괄적으로 포함합니다:

#### 추적 이벤트

**제공자 사용:**
- `toggle_provider` - 사용자가 위키피디아와 AI 간 전환할 때
- `enable_ai` / `disable_ai` - AI 기능 활성화/비활성화
- `provider_restored` - preference가 localStorage에서 로드될 때
- `session_provider_active` - 세션별 활성 공급자

**AI 요청:**
- `request_initiated` - AI 요청 시작
- `response_success` - 성공적인 AI 응답
- `response_time_success` - 성공 요청의 응답 시간
- `response_length` - AI 응답의 문자 수
- `response_word_count` - AI 응답의 단어 수
- `request_failed` - 실패한 AI 요청
- `api_error` - 상태 코드가 포함된 API 특정 오류
- `api_key_missing` - 누락된 API 키 이벤트

**캐시 성능:**
- `cache_hit` - Redis 캐시에서 제공된 응답 (더 빠름)
- `cache_miss` - 캐시된 응답 없음, API 호출 발생
- `cache_error` - Redis 사용 불가 (API로 대체)
- `cache_write_success` - 응답이 성공적으로 캐시됨
- `cache_write_error` - 응답 캐시 실패

**콘텐츠 표시:**
- `popup_displayed` - AI 대 Wikipedia 콘텐츠 팝업 표시 시
- `content_displayed` - 콘텐츠 성공적으로 표시됨
- `content_error_displayed` - 사용자에게 오류 콘텐츠 표시됨
- `content_empty_displayed` - 빈/없는 콘텐츠 시나리오
- `popup_closed` - 사용자가 정보 팝업 닫음

**성능 지표:**
- 응답 시간 (성공/실패)
- 콘텐츠 품질 지표 (단어 수, 문자 수)
- 오류율 및 유형
- 사용자 참여 패턴

#### 분석 카테고리

모든 AI 관련 이벤트는 Google Analytics에서 쉽게 필터링할 수 있도록 `"AI Feature"` 카테고리를 사용합니다.

#### 데이터 프라이버시

분석 추적은 익명화되어 있으며 개인 정보보다는 기능 사용 패턴에 중점을 둡니다. API 키나 민감한 데이터는 추적하지 않습니다.

## 설정

### 사전 요구 사항

- Node.js 18+ 및 yarn
- Google Gemini API 키 (무료 요금제 가능)
- Google Analytics 4 속성 (선택 사항, 분석용)

### 설치

```bash
git clone https://github.com/nrgapple/historic-country-borders-app.git
cd historic-country-borders-app
yarn install
```

### 환경 변수

`.env.local` 파일을 생성하세요:

```bash
# Optional for analytics
NEXT_PUBLIC_GA_FOUR=your_google_analytics_id

# Optional for map features
NEXT_PUBLIC_MAPBOX_ACCESS_TOKEN=your_mapbox_token

# Redis for AI response caching (required for caching)
REDIS_URL=your_redis_connection_string

# Required for AI features (server-side only)
GEMINI_API_KEY=your_gemini_api_key_here
```
### API 키 받기

#### Google Gemini API (무료)

1. [Google AI Studio](https://ai.google.dev/gemini-api/docs/api-key) 방문
2. Google 계정으로 로그인
3. **"Create API Key"** 클릭
4. 생성된 키를 `.env.local` 파일에 복사

**장점:**
- ✅ 분당 60회 요청 가능 (관대한 무료 한도)
- ✅ 신용카드 불필요
- ✅ 고품질 AI 응답
- ✅ 뛰어난 역사 지식

#### Vercel Redis 캐싱용 (선택사항이지만 권장)

1. Vercel 또는 Redis 제공자에서 Redis 설정
2. 프로젝트에 `REDIS_URL` 환경 변수 추가
3. 자세한 안내는 [REDIS_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./REDIS_SETUP.md) 참고

**장점:**
- ⚡ 캐시된 콘텐츠 즉시 응답
- 💰 API 사용량 및 비용 절감
- 🔧 자동 1시간 캐시 만료
- 📊 캐시 성능 분석

#### Google Analytics 4 (선택사항)

1. [Google Analytics](https://analytics.google.com/) 방문
2. 새 GA4 속성 생성
3. 측정 ID 획득 (형식: G-XXXXXXXXXX)
4. `.env.local` 파일에 추가

### 개발 환경


```bash
yarn dev
```

앱을 보려면 [http://localhost:3000](http://localhost:3000) 을(를) 열어보세요.

### 테스트

```bash
# Run all tests
yarn test

# Run tests in watch mode
yarn test:watch

# Run specific test files
yarn test hooks/__tests__/useAI.test.tsx
```
## AI 기능 문제 해결

### 일반적인 문제

**"AI 정보에는 Gemini API 키 설정이 필요합니다"**
- `.env.local`에 Gemini API 키를 추가하세요
- 개발 서버를 재시작하세요
- 자세한 설정은 [GEMINI_SETUP.md](https://raw.githubusercontent.com/nrgapple/historic-country-borders-app/main/./GEMINI_SETUP.md)를 참고하세요

**느린 AI 응답**
- 정상 응답 시간: 1-3초
- 인터넷 연결 상태를 확인하세요
- Gemini API는 요청 제한이 있습니다 (분당 60회)

**빈 응답 또는 오류 응답**
- 임시로 위키피디아로 전환해 보세요
- 브라우저 콘솔에서 상세 오류 메시지를 확인하세요
- API 키가 유효한지 확인하세요

### 분석 대시보드

Google Analytics에서 AI 기능 분석을 보려면:

1. **이벤트** → **모든 이벤트**로 이동
2. **이벤트 카테고리** = "AI Feature"로 필터링
3. 주요 모니터링 지표:
   - `toggle_provider` - 기능 채택률
   - `response_success` 대 `request_failed` - 성공률
   - `response_time_success` - 성능
   - `content_displayed` - 사용자 참여도

### 성능 모니터링

앱은 여러 성능 지표를 추적합니다:

- **응답 시간**: AI 응답 평균 시간과 위키피디아 비교
- **성공률**: AI 요청 성공/실패 비율
- **콘텐츠 품질**: AI 응답의 단어 수 및 길이
- **사용자 참여**: AI와 위키피디아 콘텐츠에 대한 사용자 상호작용

## 기여하기

1. 저장소를 포크하세요  
2. 기능 브랜치를 만드세요  
3. 변경사항을 적용하세요  
4. 새로운 기능에 대한 테스트를 추가하세요  
5. 모든 테스트가 통과하는지 확인하세요  
6. 풀 리퀘스트를 제출하세요  

## 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE)를 참조하세요.  

## 감사의 말

- 역사적 경계 데이터 출처: [World Historical Gazetteer](https://whgazetteer.org/)  
- AI 제공: [Google Gemini](https://ai.google.dev/)  
- 지도 제공: [Mapbox](https://www.mapbox.com/)  
- 분석 도구: [Google Analytics 4](https://analytics.google.com/)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-07

---