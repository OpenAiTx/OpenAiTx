![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon2Nobg.png)

# Fastdock

모던한 디자인의 간단한 웹 기반 Docker 컨테이너 관리 인터페이스입니다. 이 애플리케이션은 아름다운 웹 인터페이스를 통해 이동 중에도 Docker 컨테이너를 빠르고 직관적으로 시작하고 중지할 수 있는 방법을 제공합니다.

🎯 [라이브 데모](https://fastdock.salvatoremusumeci.com)

![Fastdock 인터페이스](https://raw.githubusercontent.com/totovr46/fastdock/main/fast-demo.png)
![Fastdock iOS 인터페이스](https://raw.githubusercontent.com/totovr46/fastdock/main/iphone.png)

## ⚠️ 보안 안내

**이 애플리케이션은 내부 사용 전용으로 설계되었으며 VPN 뒤나 안전한 네트워크 환경에서 배포되어야 합니다.**

* 인증 또는 권한 부여 메커니즘 없음
* Docker 데몬에 직접 접근
* 고급 검증 없는 파일 업로드 기능
* 개발/스테이징 환경에만 적합

## ✨ 기능

* **실시간 컨테이너 관리**: Docker 컨테이너 시작 및 중지
* **멀티 서버 관리**: 단일 인터페이스에서 여러 서버의 Docker 컨테이너 관리
* **서버 선택기**: 로컬 및 원격 서버 간 빠른 전환
* **서버 추가/편집/삭제**: 사용자 지정 이름, 주소, 포트로 원격 서버 구성
* **서버 인식 표시**: 컨테이너 카드에 속한 서버 표시
* **사용자 지정 컨테이너 아이콘**: 더 나은 시각적 식별을 위한 아이콘 업로드
* **컨테이너 이름 변경**: 컨테이너에 사용자 지정 이름 할당
* **반응형 디자인**: 데스크톱, 태블릿, 모바일 장치에서 원활하게 작동

## 🚀 빠른 시작

### 사전 요구사항

* Node.js >= 16.0.0
* Docker 데몬 실행 중
* Docker 소켓 접근 가능 (`/var/run/docker.sock`)

### 설치

1. **레포지토리 클론**

```bash
git clone https://github.com/totovr46/fastdock.git
cd fastdock
```
2. **의존성 설치**


```bash
npm install
```
3. **애플리케이션 시작하기**


```bash
npm start
```
4. **인터페이스 접속하기**
   브라우저를 열고 `http://serverIP:3080` 으로 이동하세요.

## 📋 API 엔드포인트

### 컨테이너 작업

* `GET /api/containers` - 선택된 서버의 모든 컨테이너 목록 조회
* `POST /api/containers/:id/start` - 컨테이너 시작
* `POST /api/containers/:id/stop` - 컨테이너 중지
* `GET /api/containers/name/:name` - 이름으로 컨테이너 검색

### 컨테이너 설정

* `POST /api/containers/settings/:id` - 컨테이너 설정 업데이트 (이름, 아이콘)
* `GET /api/containers/settings` - 모든 컨테이너 설정 조회

### 서버 관리

* `GET /api/servers` - 구성된 원격 서버 목록 조회
* `POST /api/servers` - 새 서버 추가
* `PUT /api/servers/:id` - 기존 서버 수정
* `DELETE /api/servers/:id` - 서버 제거

## 🛠️ 개발

### 프로젝트 구조


```
fastdock/
├── server.js                  # Main server file
├── package.json              # Dependencies and scripts
├── public/
│   ├── index.html            # Main web interface
│   ├── assets/               # Uploaded container icons
│   ├── containerSettings.json # Container customization data
│   └── servers.json          # Stored remote server configurations
└── README.md
```
## 🔧 구성

### 환경 변수

* `PORT` - 서버 포트 (기본값: 3080), server.js 파일에서 원하는 대로 변경할 수 있습니다

### 도커 소켓

애플리케이션은 도커 소켓에 대한 접근 권한이 필요합니다. 도커가 실행 중이며 소켓에 접근할 수 있는지 확인하세요:

**Linux/macOS:**


```bash
ls -la /var/run/docker.sock
```
**윈도우 (WSL):**


```bash
# Ensure Docker Desktop is running
docker ps
```
## 🚦 사용법

### 기본 작업

1. **서버 선택**: 드롭다운 메뉴를 사용하여 로컬 또는 원격 서버 선택
2. **컨테이너 보기**: 선택한 서버의 모든 컨테이너 확인
3. **시작/중지**: 버튼을 사용하여 컨테이너를 평소처럼 관리
4. **컨테이너 편집**: 연필 아이콘을 클릭하여 이름 또는 아이콘 변경

### 컨테이너 맞춤 설정

1. 컨테이너 카드의 편집 아이콘(연필)을 클릭
2. 맞춤 아이콘 업로드(이미지 파일만 가능)
3. 더 쉬운 식별을 위한 맞춤 이름 설정
4. "저장"을 클릭하여 변경 사항 적용

### 서버 관리

1. 서버 선택 드롭다운 클릭
2. "서버 추가"를 선택하여 새 원격 Docker 서버 구성
3. 기존 서버 관리를 위해 편집 또는 삭제 옵션 사용
4. 서버 데이터는 저장되며 시작 시 자동으로 로드됨

### 상태 표시기

* 🟢 **초록색**: 컨테이너 실행 중
* 🔴 **빨간색**: 컨테이너 중지됨

## 🔐 보안 고려사항

### 네트워크 보안

* **VPN 뒤에 배포**: 애플리케이션이 안전한 VPN 연결을 통해서만 접근 가능하도록 함
* **내부 네트워크**: 신뢰할 수 있는 내부 네트워크에서만 사용

### 파일 업로드 보안

* 컨테이너 아이콘은 이미지 파일만 허용
* 파일은 `public/assets/` 디렉토리에 저장됨

### Docker 접근

* 애플리케이션은 Docker 소켓 접근 권한 필요
* 모든 VPN 사용자는 컨테이너 관리 권한을 가짐
* Docker 소켓 보안 모범 사례 고려

## 🚨 제한 사항

* **사용자 인증 없음**: 모든 사용자가 동일한 접근 권한 보유
* **감사 로깅 없음**: 컨테이너 작업 로그 기록 안 함
* **로컬 저장소**: 설정이 로컬 JSON 파일에 저장됨
* **단일 인스턴스**: 다중 인스턴스 배포용 아님

## 🛌 다중 서버 지원

**v1.1.0**부터 FastDock은 여러 Docker 호스트의 컨테이너 관리를 지원합니다. 주요 내용:

* 맞춤 이름, 주소, 포트로 서버 추가 가능
* 드롭다운 선택기를 사용해 서버 간 전환
* 서버별 컨테이너 보기 및 관리
* 각 컨테이너는 소속 서버 표시
* 단일 서버 설정과 완전한 하위 호환성 유지
* 서버 목록 및 설정은 로컬에 저장됨

## 🤝 기여 방법

1. 저장소를 포크하세요
2. 기능 브랜치 생성 (`git checkout -b feature/amazing-feature`)
3. 변경사항 커밋 (`git commit -m 'Add amazing feature'`)
4. 브랜치에 푸시 (`git push origin feature/amazing-feature`)
5. 풀 리퀘스트 오픈

---

**⚠️ 중요**: 이 애플리케이션은 Docker 컨테이너에 직접 접근을 제공합니다. 신뢰할 수 있는 사용자가 있는 안전하고 통제된 환경에서만 사용하세요.
![icon](https://raw.githubusercontent.com/totovr46/fastdock/main/Icon.png)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---