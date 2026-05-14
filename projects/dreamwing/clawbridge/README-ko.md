<div align="center">
  <img src="https://raw.githubusercontent.com/dreamwing/clawbridge/master/public/app-icon.png" width="120" alt="ClawBridge Logo" />
  <h1>ClawBridge 대시보드</h1>
  <p><strong>OpenClaw 모바일 대시보드 및 미션 컨트롤.</strong></p>

  <a href="https://clawbridge.app">
    <img src="https://img.shields.io/badge/Website-clawbridge.app-3b82f6?style=for-the-badge&logo=google-chrome&logoColor=white" alt="Website" />
  </a>
  <a href="https://github.com/openclaw/openclaw">
    <img src="https://img.shields.io/badge/OpenClaw-Compatible-22c55e?style=for-the-badge&logo=robot-framework&logoColor=white" alt="OpenClaw" />
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-fab005?style=for-the-badge" alt="License" />
  </a>
  
  <br/><br/>
  [ <strong>English</strong> | <a href="README_CN.md">简体中文</a> ]
</div>

---

**ClawBridge**는 OpenClaw 에이전트를 위한 결정적인 **모바일 대시보드**입니다. 휴대용 **미션 컨트롤** 역할을 하여 실시간 생각을 모니터링하고, 토큰 비용을 추적하며, 어디서나 백그라운드 작업을 안전하고 즉시 관리할 수 있습니다.

## ✨ 주요 기능

*   **📱 모바일 우선 대시보드**: 휴대폰 화면에 최적화되어 있습니다. 로그, 통계, 컨트롤을 쉽게 확인하세요.
*   **🧠 실시간 활동 피드**: 에이전트가 "생각"하고 도구를 실행하는 과정을 실시간으로 관찰하세요. 지능형 병렬 로깅(백그라운드 작업 누락 없음) 및 중복 제거 기능 포함.
*   **💰 토큰 경제**: 일간/월간 LLM 비용 및 사용 추세를 추적합니다. 비용이 어디에 쓰이는지 정확히 알 수 있습니다.
*   **🔍 [비용 제어 센터](https://raw.githubusercontent.com/dreamwing/clawbridge/master/docs/cost-control-center.md)**: 사용량을 스캔하고 절감을 계산하며 한 번의 탭으로 최적화를 적용할 수 있는 10가지 자동 진단. API 비용을 30–90% 절감합니다.
*   **📜 메모리 타임라인**: 에이전트의 일일 기록과 장기 메모리 변화를 살펴보세요.
*   **🚀 미션 컨트롤**: UI에서 크론 작업을 트리거하고, 서비스를 재시작하거나 무한 실행 스크립트를 종료할 수 있습니다.
*   **⚡ 제로 설정 원격 연결**: 
    *   **자동 포트 지정**: 3000번 포트가 바쁠 경우 사용 가능한 포트를 자동으로 찾습니다.
    *   **스마트 네트워킹**: **Tailscale/WireGuard**를 자동 감지하여 직접 안전한 접속을 지원합니다.
    *   **빠른 터널링**: VPN이 없으면 Cloudflare를 통해 임시 공개 URL을 자동 생성합니다(제로 설정).

## 🚀 설치

OpenClaw 서버(Ubuntu/Debian)에서 이 한 줄 명령어를 실행하세요:

```bash
curl -sL https://clawbridge.app/install.sh | bash
```
그게 전부입니다. 스크립트는:
1.  환경을 감지합니다 (VPN 또는 공개).
2.  보안 액세스 키를 생성합니다.
3.  바로 사용할 수 있는 URL을 제공합니다.

## 📱 사용법

### 1. 제로-설정 액세스 (기본값)
간단히 사용해보고 싶다면, 설치 프로그램이 **퀵 터널** URL을 제공합니다:
`https://<random-name>.trycloudflare.com/?key=<YOUR_KEY>`

*   **장점**: 어디서나 즉시 접속 가능.
*   **단점**: 서비스를 재시작하면 URL이 변경됩니다.

### 2. VPN 직접 액세스 (개인정보 우선)
**Tailscale** 또는 **WireGuard**가 감지되면, 설치 프로그램은 공개 터널을 건너뛰고 개인 링크를 제공합니다:
`http://<VPN_IP>:3000/?key=<YOUR_KEY>`

*   **장점**: 가장 빠른 속도, 최대 개인정보 보호.
*   **단점**: 휴대폰이 VPN에 연결되어 있어야 합니다.

### 3. 영구 공개 도메인 (고급)
`dash.yoursite.com` 같은 고정 URL을 원하십니까?
1.  [Cloudflare 대시보드 \> 네트워킹 \> 터널](https://dash.cloudflare.com/?to=/:account/tunnels)에서 **Cloudflare 터널 토큰**을 받으세요.
2.  토큰과 함께 설치 프로그램을 실행하세요:

    ```bash
    cd skills/clawbridge
    ./install.sh --token=<YOUR_TOKEN>
    ```
    *   또는 새로운 Quick Tunnel 강제 실행: `./install.sh --force-cf`
3.  설치가 완료되면 Cloudflare Tunnel의 **Public Hostname** (또는 **Routes**) 페이지로 돌아가서 **Add a public hostname**을 클릭하여 자체 도메인을 `localhost:3000`에 바인딩해 영구적으로 접근할 수 있습니다.

### 4. 도커 (컨테이너화)
ClawBridge를 도커 컨테이너로 실행할 수 있습니다. 이미지는 자동으로 [GitHub Container Registry (ghcr.io)](https://github.com/dreamwing/clawbridge/pkgs/container/clawbridge)에 게시됩니다.
```bash
docker pull ghcr.io/dreamwing/clawbridge:latest
docker run -d --name clawbridge \
  -p 3000:3000 \
  -e ACCESS_KEY=your_secret_key \
  -e OPENCLAW_STATE_DIR=/openclaw \
  -e OPENCLAW_WORKSPACE=/openclaw/workspace \
  -v ~/.openclaw:/openclaw:ro \
  -v ./data:/app/data \
  ghcr.io/dreamwing/clawbridge:latest
```
## 📱 모바일 앱 (PWA)
1.  대시보드를 Safari(iOS) 또는 Chrome(Android)에서 엽니다.
2.  "공유" -> "홈 화면에 추가"를 탭하세요.
3.  네이티브 앱처럼 실행하세요 (전체 화면, 브라우저 바 없음).

## 🛠️ 기술 스택
*   **백엔드**: Node.js (Express, WebSocket) - 경량 사이드카 프로세스.
*   **프론트엔드**: 바닐라 JS - 빌드 단계 없음, 즉시 로드.
*   **터널**: Cloudflared

## 크레딧

ClawBridge 개선에 도움을 준 커뮤니티에 특별한 감사를 드립니다:
- [@yaochao](https://github.com/yaochao) 치명적인 보안 및 이식성 문제 보고와 아키텍처 리팩토링 제안 (#1, #2, #3, #4, #5, #6, #7).
- [@斯图超哥](https://x.com/StewartLi666) Linux 호환성, IP 감지 안정성, 빠른 터널 새로고침 로직에 대한 피드백 (#12).
- [@zjy4fun](https://github.com/zjy4fun) 작업 공간 감지 수정에 대한 소중한 기여 (PR #22).
- [@chrisuhg](https://github.com/chrisuhg) 설치 및 인증 루프 문제 해결에 대한 소중한 기여 (이슈 #19).
- [@ForceConstant](https://github.com/ForceConstant) 기능 요청: 버전별 도커 이미지 (#24) (이슈 #24)에 대한 소중한 기여.

---
*MIT 라이선스. OpenClaw 커뮤니티를 위해 제작되었습니다.*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---