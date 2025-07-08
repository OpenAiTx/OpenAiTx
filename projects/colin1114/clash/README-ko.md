이 프로젝트의 CDN 가속 및 보안 보호는 Tencent EdgeOne의 후원을 받았습니다.

[![image](https://github.com/user-attachments/assets/059fed87-d415-41b0-a575-2423bf2d77e2)](https://edgeone.ai/?from=github)

이 프로젝트의 저자는 colin1114입니다.

# 🚀 Clash 구독 변환기

다양한 프록시 구독 링크를 Clash 구성 형식으로 변환할 수 있는 미려하고 강력한 온라인 도구입니다. Cloudflare Workers & Pages를 통한 자동 배포를 지원하며, 빠르고 안정적인 구독 변환 서비스를 제공합니다.

## ✨ 기능 특성

- 🎨 **미려한 현대적 인터페이스** - 그라데이션 배경과 카드형 디자인 적용
- 🔄 **다중 프로토콜 지원** - V2Ray, VLESS, Shadowsocks, Trojan 등 주요 프로토콜 지원
- ☁️ **클라우드 배포** - Cloudflare Workers를 통한 글로벌 CDN 가속
- 📱 **반응형 디자인** - 데스크톱과 모바일 모두 완벽 대응
- ⚡ **빠른 변환** - 실시간으로 구독 링크를 Clash 구성으로 변환
- 📋 **스마트 복사** - 생성된 YAML 구성을 원클릭 복사, 다양한 브라우저 호환
- 📡 **구독 링크 생성** - Clash에서 직접 가져올 수 있는 구독 링크 자동 생성
- 🌐 **온라인 YAML 접근** - 다양한 YAML 파일 접근 방식 제공:
  - 📡 구독 링크: Clash 클라이언트 자동 업데이트 지원
  - 🔗 온라인 보기: 브라우저에서 직접 구성 내용 확인
  - 💾 파일 다운로드: .yaml 파일을 로컬로 다운로드
  - ⚡ 빠른 접근: 간소화된 다운로드 링크
- 🔧 **UTF-8 지원** - 한글 노드명과 구성 완벽 지원
- 🆓 **완전 무료** - Cloudflare 무료 서비스 기반, 사용 제한 없음

## 📁 프로젝트 구조

```
clash/
├── index.html              # 프론트엔드 페이지
├── worker.js               # Cloudflare Worker 백엔드 코드
├── wrangler.jsonc          # Wrangler 설정 파일
├── _headers                # Cloudflare Pages HTTP 헤더 설정
├── .github/
│   └── workflows/
│       └── deploy.yml      # GitHub Actions 배포 설정
├── README.md              # 프로젝트 설명 문서
└── package.json           # 프로젝트 설정 파일
```

## 🚀 빠른 시작

### 방법 1: 로컬 실행

1. **프로젝트 클론**
   ```bash
   git clone <repository-url>
   cd clash
   ```

2. **로컬 서버 실행**
   ```bash
   # Python 사용
   python -m http.server 8000
   
   # 또는 Node.js 사용
   npx serve .
   ```

3. **애플리케이션 접속**
   - 브라우저에서 `http://localhost:8000` 접속
   - 로컬 환경에서는 예시 구성이 표시됨

### 방법 2: Cloudflare Workers 배포

#### 단계 1: Worker 생성

1. [Cloudflare Workers](https://workers.cloudflare.com/) 접속
2. Cloudflare 계정 가입/로그인
3. "Create a Worker" 클릭
4. `worker.js`의 코드를 에디터에 모두 복사
5. "Save and Deploy" 클릭

#### 단계 2: Wrangler CLI로 배포

```bash
# Wrangler CLI 설치
npm install -g wrangler

# Cloudflare 로그인
wrangler login

# Worker 배포
npm run deploy:worker
```

#### 단계 3: 도메인 설정(선택 사항)

1. Worker 설정에서 커스텀 도메인 추가
2. 또는 Cloudflare에서 제공하는 기본 도메인 사용

### 방법 3: Cloudflare Pages 배포

#### 옵션 A: GitHub 연동(추천)

1. **저장소 준비**
   - 코드를 GitHub 저장소에 푸시
   - 모든 필수 파일이 포함되어 있는지 확인
2. **Pages 프로젝트 생성**
   - [Cloudflare Pages](https://pages.cloudflare.com/) 방문
   - GitHub 저장소 연결
   - 프로젝트 저장소 선택

3. **빌드 설정**
   - 빌드 명령어: 비워두거나 `echo "No build required"`
   - 빌드 출력 디렉터리: `/` (루트 디렉터리)
   - 환경 변수: 설정 불필요

#### 옵션 B: 직접 업로드

```bash
# Wrangler Pages로 배포
npm run deploy:pages
```

## 🛠️ 기술 아키텍처

### 프론트엔드 기술 스택
- **HTML5** - 현대적인 마크업 언어
- **CSS3** - 반응형 디자인 및 애니메이션 효과
- **Vanilla JavaScript** - 경량 프론트엔드 상호작용

### 백엔드 기술 스택
- **Cloudflare Workers** - 엣지 컴퓨팅 플랫폼
- **Web APIs** - 표준 Fetch API 및 응답 처리

### 지원 프로토콜 형식
- **VMess** - V2Ray 표준 프로토콜
- **VLESS** - V2Ray 경량 프로토콜 (Reality 지원)
- **Shadowsocks** - 고전적인 프록시 프로토콜
- **Trojan** - 최신 프록시 프로토콜

### API 엔드포인트
- `GET /` - 메인 페이지
- `POST /convert` - 구독 변환 API
- `GET /clash/{config-id}` - YAML 구성 파일 가져오기 (구독 링크)
- `GET /yaml/{config-id}` - YAML 구성 파일 다운로드
- `OPTIONS /*` - CORS 사전 요청

## 📖 사용 가이드

### 기본 사용법

1. **구독 링크 입력**
   - 프록시 구독 링크를 입력란에 붙여넣기
   - Base64 인코딩된 구독 링크 지원

2. **구성 이름 설정**
   - 구성 파일에 사용자 지정 이름 선택 가능
   - 기본값은 "My Clash Config"

3. **구성 변환**
   - "구독 변환" 버튼 클릭
   - 변환 완료까지 대기

4. **구성 사용**
   - 생성된 YAML 구성 복사
   - Clash 클라이언트에 가져와서 사용

5. **구독 링크 사용(추천)**
   - 생성된 구독 링크 복사
   - Clash 클라이언트에서 구독 추가
   - 구성 자동 동기화, 수동 업데이트 불필요

### 고급 구성

생성된 Clash 구성에는 다음과 같은 기능이 포함됩니다:

- **프록시 그룹 정책**
  - 🚀 노드 선택 - 수동 프록시 선택
  - ♻️ 자동 선택 - 지연 테스트 자동 선택
  - 🎯 글로벌 직결 - 직접 연결

- **DNS 구성**
  - DNS 해석 활성화
  - fake-ip 모드 지원
  - 국내외 DNS 분기

- **라우팅 규칙**
  - 로컬 주소 직접 연결
  - 국내 IP 직접 연결
  - 기타 트래픽 프록시 경유

## 🔧 배포 문제 해결

### 자주 묻는 질문

#### 1. Wrangler에서 엔트리 포인트를 찾을 수 없음
**오류 메시지**: `Missing entry-point to Worker script`

**해결 방법**: 
- 프로젝트 루트에 `wrangler.jsonc` 파일이 있는지 확인
- `wrangler.jsonc`의 `main` 필드가 `worker.js`를 가리키는지 확인

#### 2. GitHub Actions 배포 실패
**해결 방법**:
- GitHub 저장소 설정에 다음 Secrets 추가:
  - `CLOUDFLARE_API_TOKEN`: Cloudflare API 토큰
  - `CLOUDFLARE_ACCOUNT_ID`: Cloudflare 계정 ID

#### 3. Pages 빌드 실패
**해결 방법**:
- 빌드 명령어를 비워두거나 `echo "No build required"`로 설정
- 빌드 출력 디렉토리가 `/`로 설정되어 있는지 확인

### 배포 구성 파일 설명

- **`wrangler.jsonc`**: Worker 배포를 위한 Wrangler CLI 설정
- **`_headers`**: Cloudflare Pages HTTP 헤더 설정
- **`.github/workflows/deploy.yml`**: GitHub Actions 자동 배포 설정

## 🔧 커스텀 설정

### 프록시 그룹 수정

`worker.js`의 `convertToClash` 함수에서 프록시 그룹을 커스터마이즈할 수 있습니다:

```javascript
'proxy-groups': [
  {
    name: '🚀 노드 선택',
    type: 'select',
    proxies: ['♻️ 자동 선택', '🎯 글로벌 직결', ...proxyNames]
  },
  // 더 많은 프록시 그룹 추가...
]
```

### 커스텀 라우팅 규칙

`rules` 배열을 수정하여 커스텀 라우팅 규칙을 추가할 수 있습니다:

```javascript
rules: [
  'DOMAIN-SUFFIX,youtube.com,🚀 노드 선택',
  'DOMAIN-SUFFIX,local,DIRECT',
  // 더 많은 규칙 추가...
]
```

## 📊 성능 특성

- **글로벌 CDN** - Cloudflare의 전세계 엣지 노드 커버리지
- **빠른 응답** - 평균 응답 시간 < 100ms
- **높은 가용성** - 99.9% 서비스 가용성
- **무료 할당량** - 하루 100,000회 요청

## 🔒 보안 안내

- **데이터 프라이버시** - 구독 데이터는 변환 과정에서만 사용되며 저장되지 않음
- **HTTPS 암호화** - 모든 통신은 HTTPS로 암호화됨
- **오픈소스 투명성** - 전체 소스코드 공개, 직접 감사 가능

## 🤝 기여 가이드

Issue 및 Pull Request 환영합니다!

1. 본 저장소를 포크(Fork)합니다
2. 기능 브랜치 생성 (`git checkout -b feature/AmazingFeature`)
3. 변경사항 커밋 (`git commit -m 'Add some AmazingFeature'`)
4. 브랜치로 푸시 (`git push origin feature/AmazingFeature`)
5. Pull Request 생성

## 📝 변경 로그

### v1.1.0
- ✅ VLESS 프로토콜 지원 추가(Reality 보안 전송 포함)
- ✅ 프로토콜 호환성 개선

### v1.0.0
- ✅ 기본 구독 변환 기능
- ✅ 미려한 사용자 인터페이스
- ✅ Cloudflare Workers 지원
- ✅ 다중 프로토콜 지원(VMess, Shadowsocks, Trojan)
- ✅ 반응형 디자인
- ✅ 원클릭 복사 기능

## 📞 지원 및 피드백

사용 중 문제가 있거나 제안이 있다면 아래 절차를 따라주세요:

1. 본 README 문서 참고
2. [Issue](../../issues) 등록
3. [Discussion](../../discussions) 시작

## 📄 라이선스

이 프로젝트는 MIT 라이선스를 따릅니다 - 자세한 내용은 [LICENSE](LICENSE) 파일 참고

## 🙏 감사의 말씀

- [Cloudflare Workers](https://workers.cloudflare.com/) - 엣지 컴퓨팅 플랫폼 제공
- [Clash](https://github.com/Dreamacro/clash) - 뛰어난 프록시 클라이언트
- 모든 기여자 및 사용자 여러분의 지원

---
⭐ 이 프로젝트가 도움이 되었다면 Star를 눌러주세요!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---