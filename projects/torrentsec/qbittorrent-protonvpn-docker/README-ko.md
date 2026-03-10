# 🏰️ qBittorrent + ProtonVPN (WireGuard) in Docker (macOS)

**Gluetun을 사용하여 ProtonVPN (WireGuard)와 함께 Docker에서 qBittorrent를 안전하게 실행하며, 전체 VPN 라우팅과 자동 포트 포워딩으로 토렌트 성능을 향상시킵니다.**

&#x20;

---

## 📌 목차

1. [개요](#overview)
2. [특징](#features)
3. [필수 조건](#prerequisites)
4. [설치 가이드](#installation-guide)
   - [Docker 설치](#install-docker)
   - [저장소 복제](#clone-the-repository)
   - [`.env` 파일 설정](#set-up-the-env-file)
   - [인증 구성](#configure-authentication)
   - [컨테이너 시작](#start-the-containers)
5. [qBittorrent 웹 UI 접속](#accessing-qbittorrent-web-ui)
6. [보안 및 모범 사례](#security--best-practices)
7. [문제 해결](#troubleshooting)
8. [라이선스](#license)
9. [기여](#contributing)
10. [지원 및 피드백](#support--feedback)

---

## 🔹 개요

이 설정은 **qBittorrent가 ProtonVPN (WireGuard)를 통해서만 연결되도록** 하며, **Gluetun**을 사용해 누출을 방지하고 보안을 강화합니다.\
또한 **포트 포워딩을 자동화**하여 토렌트 속도를 개선하고, **모든 것을 Docker 내에서 실행**하여 관리가 용이합니다.

---

## ✅ 특징

- **🔒 VPN 강제 토렌트 사용** – 누출 없이 모든 트래픽이 **VPN 내부**에서 실행됩니다.
- **⚡ 자동 포트 포워딩** – 더 나은 속도와 향상된 피어 연결을 보장합니다.
- **🌐 로컬 웹 UI 접속** – [`http://localhost:8080`](http://localhost:8080)에서 쉽게 토렌트를 제어할 수 있습니다.
- **📺 완전한 컨테이너화** – 도커를 사용하여 쉽고 빠른 배포, 업데이트 및 격리 지원.
- **🔄 복원력 있는 설정** – 컨테이너가 충돌 시 **자동 재시작**됨.
- 미완료 및 완료된 토렌트에 대해 **별도의 저장소** 사용
- **Watchtower를 사용한 컨테이너 자동 업데이트** 🛠️

---

## 🛠️ 사전 준비 사항

- **Docker Desktop** (macOS/Windows/Linux)
- **Docker Compose** (Docker Desktop에 포함)
- **ProtonVPN 계정** (WireGuard 지원을 위한 Plus 또는 Visionary 필요)

---

## 📂 설치 가이드

### **1️⃣ Docker 설치**

[여기](https://www.docker.com/products/docker-desktop/)에서 **Docker Desktop**을 다운로드하여 설치하세요.\
계속 진행하기 전에 Docker가 **실행 중**인지 확인하세요.

---

### **2️⃣ 저장소 클론**

```sh
git clone https://github.com/torrentsec/qbittorrent-protonvpn-docker.git
cd qbittorrent-protonvpn-docker
```

---

### **3️⃣ **`.env`** 파일 설정하기**

이 프로젝트는 **민감한 구성 값**을 저장하기 위해 `.env` 파일을 사용합니다 (보안을 위해 Git에서 무시됩니다).

#### **자신의 **`.env`** 파일 생성하기**

```sh
cp .env.example .env
nano .env
```

#### **다음 변수를 채우세요**

```ini
WIREGUARD_PRIVATE_KEY=your_private_key_here
SERVER_COUNTRIES="United Kingdom"
SERVER_CITIES="London"

PUID=1000
PGID=1000
TZ=Europe/London

GLUETUN_USER=your_admin_username
GLUETUN_PASS=your_admin_password

GSP_GTN_API_KEY=your_random_api_key_here
GSP_QBITTORRENT_PORT=your_forwarded_port_here
```

Save and close (`CTRL + X`, then `Y`, then `ENTER`).

---

### **4️⃣ Start the Containers**

```sh
docker-compose up -d
```
🚀 **qBittorrent가 이제 ProtonVPN을 통해 안전하게 실행 중입니다!**

---

## 📚 qBittorrent 웹 UI 접속

실행 후, 다음을 엽니다:\
📌 [**http://localhost:8080**](http://localhost:8080)\
*(기본 사용자명: admin, 비밀번호: 임시 비밀번호는 콘솔에서 확인)*

첫 로그인 후 웹 UI 비밀번호를 반드시 변경하세요. 그렇지 않으면 컨테이너가 재시작될 때마다 비밀번호가 무작위로 생성됩니다.

---

## 🛡️ 보안 및 모범 사례

1. **`.env` 파일은 비공개로 유지**

   - `.gitignore` 파일이 이미 `.env`가 GitHub에 업로드되는 것을 방지합니다.

2. **Gluetun API에 강력한 비밀번호 사용**

   - 무단 API 접근을 막기 위해 `.env`의 `GLUETUN_PASS`를 수정하세요.

3. **토렌트 전 VPN 연결 상태 확인**

   - 컨테이너 내에서 `curl ifconfig.me`를 실행하세요:

     ```sh
     docker exec -it qbittorrent curl ifconfig.me
     ```
   - ✅ **IP가 ProtonVPN과 일치하면**, 작동 중입니다.
   - ❌ **실제 IP가 표시되면, 문제가 있습니다.**

---

## 🛠️ 문제 해결

### **VPN이 실행 중인지 확인하기**

```sh
docker ps
```

Gluetun이 실행 중이 아니면, 모든 것을 다시 시작하세요:

```sh
docker-compose down && docker-compose up -d
```

### **qBittorrent이 VPN을 사용 중인지 확인하기**

```sh
docker exec -it qbittorrent curl ifconfig.me
```

🟢 IP가 ProtonVPN과 일치하면 작동 중입니다.\
🔴 실제 IP가 표시되면 문제가 있는 것입니다.

### **오류 로그 확인**

```sh
docker logs -f gluetun
```

**AUTH\_FAILED** 또는 연결 문제를 찾아보세요.

---

## 💎 라이선스

이 프로젝트는 **MIT 라이선스** 하에 있습니다 – 자세한 내용은 LICENSE 파일을 참조하세요.

---

## 💪 기여하기

기여를 환영합니다! 개선 사항이나 피드백이 있으면 이슈나 풀 리퀘스트를 자유롭게 제출하세요.

---

## 💬 지원 및 피드백

- 이 내용이 도움이 되었다면 GitHub에서 ⭐ 별을 눌러주세요!
- 피드백 및 제안은 언제나 환영합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-10

---