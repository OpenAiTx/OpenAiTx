# 마인크래프트 서버 웹 관리 패널

**[中文版本 (중국어 버전)](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/README_CN.md)**

현대적인 UI와 종합적인 서버 관리 기능을 갖춘 **경량** 마인크래프트 서버 웹 관리 패널입니다.

**현재 지원하는 서버:**
- ✅ 마인크래프트 베드락 서버
- 마인크래프트 자바 서버

## 🚀 기능

### 🌍 마인크래프트 서버 다운로드
- **서버 다운로드** 관리 페이지에서 특정 서버 버전을 직접 다운로드 지원
- **서버 버전 전환** 원클릭 서버 버전 전환 지원

### 🎮 서버 제어
- **원클릭 시작/중지/재시작** 마인크래프트 베드락 서버
- **실시간 상태 모니터링** 서버 실행 상태 표시

### ⚙️ 설정 관리
- **모든 주요 설정 옵션 지원**:
  - 서버 이름 및 설명
  - 게임 모드 (서바이벌/크리에이티브/어드벤처)
  - 난이도 설정 (평화로움/쉬움/보통/어려움)
  - 최대 플레이어 수
  - 서버 포트 설정
  - 치트 및 화이트리스트 토글
- **서버 설정 파일 관리** `server.properties` 파일 자동 유지

### 👥 화이트리스트 관리
- **플레이어 추가/제거** 서버 접속 허용 플레이어 목록 관리
- **화이트리스트 파일 관리** `allowlist.json` 파일 자동 유지

### 🛡️ 권한 관리
- **3단계 권한 시스템**:
  - **방문자** - 기본 게임 권한
  - **회원** - 표준 플레이어 권한
  - **운영자** - 전체 관리자 권한
- **플레이어 권한 설정** 특정 플레이어에게 권한 레벨 할당
- **권한 파일 관리** `permissions.json` 파일 자동 유지 관리

### 🌍 월드 관리
- **월드 파일 업로드** `.zip` 및 `.mcworld` 형식 지원 및 자동 추출
- **월드 전환** 원클릭으로 다른 월드 활성화
- **월드 삭제** 불필요한 월드 파일 안전 삭제
- **현재 월드 식별** 현재 활성화된 월드 명확히 표시

### 🌍 리소스 팩 관리
- **리소스 파일 업로드** `.zip` 및 `.mcpack` 형식 지원
- **리소스 활성화** 원클릭으로 다른 리소스 팩 활성화
- **리소스 삭제** 불필요한 리소스 팩 안전 삭제

### 📋 서버 로그
- **실시간 로그 보기** 웹 인터페이스를 통해 Minecraft 서버 로그 실시간 모니터링
- **자동 스크롤** 최신 로그 항목으로 자동 스크롤 옵션

### 💻 명령 실행
- **직접 명령 입력** 웹 인터페이스에서 Minecraft 서버 명령 직접 실행
- **명령 기록** 이전에 실행한 명령 보기 및 재사용
- **빠른 명령** 분류된 빠른 접근 버튼을 통한 자주 사용하는 명령 접근

### 🔐 인증 및 보안
- **로그인 시스템** 비밀번호 인증으로 관리 패널 안전 접근
- **세션 관리** 보안 토큰 기반 인증으로 자동 세션 처리
- **접근 제어** 무단 접근으로부터 서버 관리 기능 보호



## 📋 시스템 요구 사항

### 서버 환경
- **운영 체제**: Windows 10 이상 또는 Ubuntu 18.04 이상 (Linux)
- **메모리**: 최소 2GB RAM
- **저장 공간**: 최소 10GB 사용 가능 공간
- **네트워크**: 8080 포트(관리 패널) 및 19132 포트(Minecraft 서버) 개방

## 🛠️ 설치 가이드

### 빠른 시작 (권장)
1. **사전 빌드된 릴리스 다운로드**:
   - [릴리스](https://github.com/ckfanzhe/bedrock-easy-server/releases) 페이지에서 운영 체제에 맞는 버전을 다운로드하세요
   - Windows용 `minecraft-server-manager-windows.exe`
   - Linux용 `minecraft-server-manager-linux`

2. **애플리케이션 실행**:

   ```bash
   # For Linux
   chmod +x minecraft-server-manager-linux
   ./minecraft-server-manager-linux
   
   # For Windows
   minecraft-server-manager-windows.exe
   ```

### 도커 배포

1. **도커 직접 사용 (권장)**:
   ```bash
   # Create data directory for persistent storage
   mkdir -p data
   
   # Run the container using the published image
   docker run -d \
     --name minecraft-easyserver \
     -p 8080:8080 \
     -p 19132:19132/udp \
     -p 19133:19133/udp \
     -v ./data:/data/bedrock-server \
     -v ./config:/data/config \
     ifanzhe/minecraft-easyserver:latest
   ```

2. **Docker Compose 사용하기**:
   ```bash
   # Create docker-compose.yml file
   cat > docker-compose.yml << EOF
   version: '3.8'
   services:
     minecraft-server-manager:
       image: ifanzhe/minecraft-easyserver:latest
       container_name: minecraft-easyserver
       ports:
         - "8080:8080"
         - "19132:19132/udp"
         - "19133:19133/udp"
       volumes:
         - ./data:/data/bedrock-server
         - ./config:/data/config
       environment:
         - TZ=Asia/Shanghai
       restart: unless-stopped
       healthcheck:
         test: ["CMD", "curl", "-f", "http://localhost:8080"]
         interval: 30s
         timeout: 10s
         retries: 3
   EOF
   
   # Start with Docker Compose
   docker-compose up -d
   ```
3. **애플리케이션 접속**:
   - 브라우저를 열고 다음 주소로 접속: `http://localhost:8080`
   - 서버 데이터는 `./data` 디렉토리에 저장됩니다

### 소스에서 빌드하기 (개발자용)

1. **사전 요구사항**:
   - Go 1.21 이상
   - Node.js 16+ 및 npm (프론트엔드 컴파일용)

2. **저장소 복제**:

   ```bash
   git clone https://github.com/ckfanzhe/bedrock-easy-server.git
   cd minecraft-easy-server
   ```

3. **모든 플랫폼 빌드 (권장)**:
   ```bash
   chmod +x build.sh
   ./build.sh
   ```
   이 스크립트는 다음을 수행합니다:
   - 프론트엔드 의존성 설치 (`npm install`)
   - Vue.js 프론트엔드 빌드 (`npm run build`)
   - 빌드된 자산을 embed 디렉터리에 복사
   - 임베디드 프론트엔드와 함께 모든 플랫폼용 Go 바이너리 컴파일

4. **수동 빌드 단계** (단계별로 진행하려는 경우):
   ```bash
   # Build frontend first
   cd minecraft-easyserver-web
   npm install
   npm run build
   cd ..
   
   # Copy frontend build output
   rm -rf web/*
   cp -r minecraft-easyserver-web/dist/* web/
   
   # Build Go binary
   go build -o minecraft-server-manager
   ```
**참고**: 빌드 과정에는 이제 모든 Vue.js 컴포넌트, 스타일 및 자산을 번들링하는 webpack을 이용한 프론트엔드 컴파일이 포함되며, 최적화된 파일들은 단일 파일 배포를 위해 Go 바이너리에 내장됩니다.

## 🚀 사용 가이드

### 관리 패널 시작

1. **애플리케이션 실행**:

   ```bash
   # For Linux
   ./minecraft-server-manager-linux
   
   # For Windows double-click to run
   minecraft-server-manager-windows.exe
   ```
2. **접근 관리 인터페이스**:
   - 브라우저를 열고 방문: `http://localhost:8080`
   - 관리 패널이 자동으로 로드됩니다

## 🔥 방화벽 설정

### Windows 방화벽
일부 시스템에서는 서버가 실행 중인 동일한 기기에서 클라이언트를 사용해 서버에 연결하려면, Minecraft 클라이언트를 UWP 루프백 제한에서 제외해야 합니다:


```powershell
CheckNetIsolation.exe LoopbackExempt -a -p=S-1-15-2-1958404141-86561845-1752920682-3514627264-368642714-62675701-733520436
```
방화벽에서 다음 포트가 열려 있는지 확인하세요:  
- **8080**: 관리 패널 접속 포트  
- **19132**: Minecraft Bedrock 서버 기본 포트  
- **19133**: Minecraft Bedrock 서버 IPv6 포트  

## 📝 추가 정보  

### TODO 예정 기능  
- ✅ 원클릭 mcpackage 모드 가져오기 지원  
- ✅ 리눅스 운영체제 지원  
- ✅ Bedrock 서버 실시간 로그 보기  
- ✅ 웹 인터페이스를 통한 Bedrock 서버 직접 명령 실행  
- 🔄 플레이어 온라인 상태 모니터링  
- ✅ 서버 성능 모니터링  
- 🔄 자동 월드 백업 기능  
- ✅ 다국어 인터페이스 지원  
- 🔄 자바 서버 지원 - Minecraft Java Edition 서버 지원  
- ✅ 도커 지원 - 컨테이너화된 배포 지원  

## 🤝 기여  

이슈 보고, 기능 제안, 코드 기여를 환영합니다!  

### 개발 환경 설정  
1. 프로젝트 저장소를 포크하세요  
2. 기능 브랜치 생성: `git checkout -b feature/new-feature`  
3. 변경 사항 커밋: `git commit -am 'Add new feature'`  
4. 브랜치 푸시: `git push origin feature/new-feature`  
5. 풀 리퀘스트 생성  

### 코드 기준  
- Go 표준 코드 포맷 사용  
- 적절한 주석 및 문서 추가  
- 코드가 테스트를 통과하도록 보장  
- 프로젝트 아키텍처 패턴 준수  

## 📄 라이선스  

이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 🙏 감사의 글

- [Gin Web Framework](https://gin-gonic.com/) - 고성능 Go 웹 프레임워크  
- [Tailwind CSS](https://tailwindcss.com/) - 유틸리티 우선 CSS 프레임워크  
- [Font Awesome](https://fontawesome.com/) - 아이콘 라이브러리  
- [Minecraft Bedrock](https://www.minecraft.net/) - 게임 서버  

## 👀 관리 패널 미리보기  
> 일부 기능의 스크린샷이며, 더 많은 기능은 직접 체험해 보시기 바랍니다.  

![Login Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-login.png)  
![Dashboard Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-dashboard.png)  
![Performance Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-performance.png)  
![Server Download Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-version.png)  
![Resource Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-resource.png)  
![Worlds Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-worlds.png)  
![Cmd Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-cmd.png)  
![Server Config Panel Preview](https://raw.githubusercontent.com/ckfanzhe/minecraft-easyserver/main/docs/resources/en-server-config.png)  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---