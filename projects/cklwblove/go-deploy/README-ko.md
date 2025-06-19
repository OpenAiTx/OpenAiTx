# Go-Deploy 배포 도구

Go 언어 기반으로 개발된 자동화 배포 도구로, SFTP 프로토콜을 통해 로컬 빌드 산출물을 원격 서버로 업로드할 수 있습니다.

## 기능 특성

- ✅ **보안 전송**: SFTP 프로토콜 사용, SSH 기반 암호화 전송
- ✅ **디렉터리 동기화**: 전체 디렉터리 구조 재귀적 업로드, 파일 계층 유지
- ✅ **지능적 생성**: 원격 디렉터리 구조 자동 생성
- ✅ **경로 자동 인식**: 실행 파일 위치를 기준으로 로컬 경로 자동 계산, 실행 디렉터리 신경 쓸 필요 없음
- ✅ **설정 파일 지원**: JSON 설정 파일 지원, 다양한 환경의 설정 관리 용이
- ✅ **파일 제외**: 와일드카드 패턴으로 불필요한 파일 업로드 제외 가능
- ✅ **자동 백업**: 업로드 전 원격 파일 자동 백업 가능
- ✅ **재시도 메커니즘**: 업로드 실패 시 자동 재시도, 성공률 향상
- ✅ **상세 통계**: 업로드 파일 수, 전송 크기, 소요 시간 및 속도 표시
- ✅ **진행 상태 표시**: 실시간 업로드 진행 및 파일 정보 표시
- ✅ **오류 처리**: 완비된 오류 처리 및 로그 출력

## 시스템 요구 사항

- Go 1.18 이상 버전
- 대상 서버는 SSH/SFTP 프로토콜 지원

## 설치 안내

### 1. 프로젝트 클론

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. Go 모듈 초기화

```bash
go mod init go-deploy
go mod tidy
```

### 3. 의존성 설치

프로그램이 자동으로 아래 의존성을 다운로드합니다:

- `github.com/pkg/sftp` - SFTP 클라이언트
- `golang.org/x/crypto/ssh` - SSH 클라이언트

## 설정 안내

프로그램은 두 가지 방식의 설정을 지원합니다:

### 1. 설정 파일 사용(권장)

`config.example.json`을 `config.json`으로 복사한 후 설정을 수정합니다:

```bash
cp config.example.json config.json
```

이후 `config.json`을 편집합니다:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### 설정 항목 설명

**server 설정**:

- `host`: SSH 서버 주소
- `port`: SSH 포트, 일반적으로 22
- `username`: SSH 사용자명
- `password`: SSH 비밀번호(운영 환경에서는 키 인증 권장)
- `timeout`: 연결 타임아웃(초)

**paths 설정**:

- `local`: 로컬 디렉터리 경로, 상대 경로 및 절대 경로 지원
- `remote`: 원격 디렉터리 경로, 반드시 절대 경로여야 함

**options 설정**:

- `backup`: 업로드 전 원격에 이미 존재하는 파일 백업 여부
- `backup_suffix`: 백업 파일의 접미사, 백업 파일 접미사는 커스텀 가능, 백업 파일이 없으면 백업 건너뜀
- `exclude_patterns`: 파일 제외 패턴, 와일드카드 지원
- `max_retries`: 업로드 실패 시 최대 재시도 횟수
- `chunk_size`: 파일 전송 블록 크기(바이트, 미구현)

### 2. 기본 설정(호환 모드)

`config.json` 파일이 없을 경우, 프로그램은 내장된 기본 설정을 사용하여 하위 호환을 유지합니다.

#### 설정 파일 우선순위

1. **명령행으로 지정한 설정 파일**: `--config` 인자로 지정한 파일
2. **기본 설정 파일**: 현재 디렉터리의 `config.json`
3. **내장 기본 설정**: 위 파일들이 없으면 프로그램 내장 설정 사용

#### 경로 처리 규칙

- **설정 파일 경로**:

  - 상대 경로: 실행 파일 위치 기준
  - 절대 경로: 지정 경로 그대로 사용
- **로컬 디렉터리 경로**:

  - 상대 경로: 실행 파일 위치 기준
  - 절대 경로: 지정 경로 그대로 사용

## 실행 안내

### 명령행 인자

프로그램은 다음 명령행 인자를 지원합니다:

```bash
# 도움말 표시
./deploy --help

# 버전 정보 표시  
./deploy --version

# 기본 설정 파일 config.json 사용
./deploy

# 지정한 설정 파일 사용
./deploy --config prod.json

# 절대 경로 설정 파일 사용
./deploy --config /path/to/config.json
```

### 개발 환경 실행

```bash
# 기본 설정 사용
go run main.go

# 지정한 설정 파일 사용
go run main.go --config test.json

# 도움말 표시
go run main.go --help
```

### 빌드 후 실행

```bash
# 빌드
go build -o deploy main.go

# 기본 설정으로 실행
./deploy

# 지정한 설정 파일로 실행
./deploy --config prod.json
```

## 패키징 안내

### 1. 로컬 플랫폼 패키징

```bash
# 현재 플랫폼의 실행 파일 빌드
go build -o deploy main.go
```

### 2. 크로스 플랫폼 패키징

#### Linux 64비트

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64비트

```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64비트

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. 빌드 최적화(파일 크기 축소)

```bash
# 디버그 정보 및 심볼 테이블 제거
go build -ldflags="-s -w" -o deploy main.go

# UPX로 압축(UPX 사전 설치 필요)
upx --best deploy
```

### 4. 일괄 빌드 스크립트

`build.sh` 스크립트 생성:

```bash
#!/bin/bash

# 빌드 디렉터리 생성
mkdir -p builds

# 각 플랫폼별 빌드
echo "Linux 64비트 버전 빌드 중..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "Windows 64비트 버전 빌드 중..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "macOS 64비트 버전 빌드 중..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "macOS ARM64 버전 빌드 중..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "빌드 완료!"
ls -la builds/
```

스크립트 실행:

```bash
chmod +x build.sh
./build.sh
```

## 사용 예시

### 도움말 표시

```bash
$ ./deploy --help
Go-Deploy 배포 도구

사용법: ./deploy [옵션]

옵션:
  -config string
        설정 파일 경로 (default "config.json")
  -help
        도움말 표시
  -version
        버전 정보 표시

예시:
  ./deploy                           # 기본 설정파일 config.json 사용
  ./deploy --config prod.json        # 지정된 설정파일 사용
  ./deploy --config /path/to/config.json  # 절대경로 설정파일 사용
```

### 지정된 설정파일 사용

```bash
$ ./deploy --config prod.json
배포 프로그램 실행 시작...
설정 파일 읽기 시도: /path/to/go-deploy/prod.json
설정 파일 사용 중...
로컬 디렉터리 /path/to/project/dist 존재함
SSH 서버에 연결 중...
SSH 서버 연결 성공
...
```

### 설정 파일 사용

```bash
$ ./deploy
배포 프로그램 실행 시작...
설정 파일 읽기 시도: /path/to/go-deploy/config.json
설정 파일 사용 중...
로컬 디렉터리 /path/to/project/unpackage/dist/build/web 존재함
SSH 서버에 연결 중...
SSH 서버 연결 성공
SFTP 클라이언트 생성 중...
SFTP 클라이언트 생성 성공
원격 디렉터리로 업로드 준비 중: /opt/xsoft/nginx/html/app/dist
디렉터리 업로드 시작...
로컬 디렉터리 순회 시작: /path/to/project/unpackage/dist/build/web
디렉터리 생성: /opt/xsoft/nginx/html/app/dist
파일 static/js/app.js.map 제외됨, 업로드 건너뜀
백업 생성: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
파일 업로드: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
파일 .DS_Store 제외됨, 업로드 건너뜀
파일 업로드: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
업로드 실패(시도 1/3): 네트워크 오류
파일 재업로드 시도(2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
파일 업로드: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
디렉터리 업로드 성공!
통계 정보:
  - 업로드 파일 수: 485
  - 생성된 디렉터리 수: 18
  - 전송 크기: 25.8 MB
  - 업로드 소요 시간: 38.5s
  - 총 소요 시간: 39.2s
  - 전송 속도: 0.67 MB/s
```

## 주의사항

1. **보안**:

   - 운영 환경에서는 비밀번호 인증 대신 SSH 키 인증 권장
   - 현재 `ssh.InsecureIgnoreHostKey()` 사용, 운영 환경에서는 호스트 키 검증 필요
2. **네트워크**:

   - 로컬에서 대상 서버의 22번 포트 접근 가능해야 함
   - 전송 속도는 네트워크 대역폭 및 서버 성능에 따라 다름
3. **권한**:

   - SSH 사용자가 대상 디렉터리에 쓰기 권한이 있어야 함
   - 필요 시 sudo 권한 필요
4. **경로**:

   - 로컬 경로는 실행 파일 위치 기준으로 자동 계산, 실행 디렉터리 신경 쓸 필요 없음
   - 원격 경로는 절대경로 사용

## 문제 해결

### 자주 발생하는 문제

1. **연결 시간 초과**

   ```
   SSH 서버 연결 실패: dial tcp: i/o timeout
   ```

   - 서버 주소 및 포트 확인
   - 네트워크 연결 상태 확인
   - 방화벽 설정 확인
2. **인증 실패**

   ```
   로그인 실패: ssh: handshake failed
   ```

   - 사용자명 및 비밀번호 확인
   - SSH 서비스가 실행 중인지 확인
   - SSH 설정 확인
3. **권한 오류**

   ```
   디렉터리 생성 실패: permission denied
   ```

   - 대상 디렉터리에 대한 사용자 쓰기 권한 확인
   - sudo 사용 또는 디렉터리 소유자 변경 필요할 수 있음
4. **로컬 디렉터리 없음**

   ```
   오류: 로컬 디렉터리 /path/to/unpackage/dist/build/web 존재하지 않음
   ```

   - 로컬 빌드 완료 여부 확인
   - 프로젝트 디렉터리 구조가 올바른지 확인
   - 프로그램이 경로를 자동 계산하므로 작업 디렉터리 수동 변경 불필요

## 개발 안내

### 프로젝트 구조

```
go-deploy/
├── main.go                 # 메인 프로그램 파일
├── go.mod                  # Go 모듈 파일  
├── go.sum                  # 의존성 검증 파일
```
├── README.md               # 자세한 설명 문서  
├── Makefile                # 빌드 도구  
├── build.sh                # 일괄 패키징 스크립트  
├── install.sh              # 원클릭 설치 스크립트  
└── config.example.json     # 설정 파일 예시  
```

### 주요 함수

- `main()` - 메인 함수, 연결 처리 및 업로드 호출
- `uploadDirectory()` - 디렉토리 재귀 업로드
- `uploadFile()` - 단일 파일 업로드
- `mkdirAll()` - 원격 디렉토리 재귀 생성

## 라이선스

MIT License

## 기여

Issue와 Pull Request 제출을 환영합니다!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---