#寸止 🛑

> **AI 대화 "조루" 종결자, 대화가 끝까지 이어지게**

AI 어시스턴트가 항상 대화를 일찍 끝내버려서 답답하셨나요? 분명 더 할 얘기가 많은데, "더 도와드릴 일이 있나요?"라고 말할 때가 많죠? **寸止**는 이런 문제를 전문적으로 해결합니다!

AI가 "대충 끝내려" 할 때,寸止는 즉시 대화창을 띄워 사용자가 더 깊이 있게 대화를 이어갈 수 있도록 돕습니다. 진짜로 문제가 해결될 때까지 계속할 수 있습니다.

## 🌟 핵심 특성

- 🛑 **지능형 차단**: AI가 대화를 끝내려 할 때 자동으로 계속 옵션 팝업
- 🧠 **메모리 관리**: 프로젝트별로 개발 규범 및 선호도 저장
- 🎨 **우아한 인터랙션**: Markdown 지원, 다양한 입력 방식
- ⚡ **즉시 설치 사용**: 3초 설치, 크로스플랫폼 지원

## 📸 실제 효과 보기

### 🛑 지능형 차단 팝업
![寸止弹窗演示](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/popup.png)

*AI가 대화를 끝내려 할 때,寸止의 지능형 팝업이 즉시 나타나 사전 정의된 옵션을 빠르게 선택할 수 있게 하여 대화가 더 깊이 이어집니다*
### ⚙️ 설정 관리 인터페이스
![寸止设置界面](https://raw.githubusercontent.com/imhuso/cunzhi/main/./screenshots/settings.png)

*우아한 설정 인터페이스, 메모리 관리, 기능 스위치, 테마 전환 및 스마트 프롬프트 생성 지원*

## 🚀 시작하기

### 방법 1: 빠른 설치(추천)

**macOS 사용자:**
```bash
# 3초 만에 설치, 컴파일 대기 불필요
brew tap imhuso/cunzhi && brew install cunzhi
```

> ⚠️ **문제 해결:** 404 다운로드 오류가 발생하면 다음 단계를 수행하세요:
>
> ```bash
> # 이전 tap 캐시 삭제
> brew untap imhuso/cunzhi
> # 재설치
> brew tap imhuso/cunzhi && brew install cunzhi
> ```
>
> **자주 발생하는 오류 예시:**
> ```
> curl: (56) The requested URL returned error: 404
> Error: cunzhi: Failed to download resource "cunzhi"
> Download failed: https://github.com/imhuso/cunzhi/releases/download/v0.2.0/cunzhi-cli-v0.2.4-macos-aarch64.tar.gz
> ```
>
> 이는 이전 버전의 캐시 문제로 버전 불일치가 발생할 때 주로 나타납니다. tap을 삭제 후 재설치하면 해결됩니다.

**Windows/Linux 사용자:**
방법 2의 수동 다운로드를 추천합니다. 간단하고 빠릅니다!
### 方式二：수동 다운로드

1. [Releases 페이지](https://github.com/imhuso/cunzhi/releases)에 접속
2. 시스템에 맞는 버전을 다운로드하세요:
   - 🐧 **Linux**: `cunzhi-cli-v*-linux-x86_64.tar.gz`
   - 🍎 **macOS (Intel)**: `cunzhi-cli-v*-macos-x86_64.tar.gz`
   - 🍎 **macOS (Apple Silicon)**: `cunzhi-cli-v*-macos-aarch64.tar.gz`
   - 🪟 **Windows**: `cunzhi-cli-v*-windows-x86_64.zip`

3. 압축 해제 후 `寸止`와 `等一下`를 시스템 PATH에 추가하세요

## ⚡ 빠른 시작

### 첫 번째 단계: MCP 클라이언트 설정

당신의 MCP 클라이언트(예: Claude Desktop) 설정 파일에 다음을 추가하세요:

```json
{
  "mcpServers": {
    "寸止": {
      "command": "寸止"
    }
  }
}
```
### 두 번째 단계: 설정 화면 열기

```bash
# 설정 명령어 실행
잠시만요
```

### 세 번째 단계: 프롬프트 구성

설정 화면의 "참고 프롬프트" 탭에서:
1. 자동 생성된 프롬프트 확인
2. 복사 버튼 클릭
3. 프롬프트를 당신의 AI 어시스턴트에 추가

### 네 번째 단계: 사용 시작

이제 당신의 AI 어시스턴트는 스마트 인터셉트, 메모리 관리, 팝업 상호작용 기능을 갖추게 됩니다!

> 💡 **팁**: 생성된 프롬프트를 참고하여 개인화된 수정이 가능하며, 나만의 AI 상호작용 경험을 만들 수 있습니다.
## 🤝 참여 및 기여

寸止는 오픈소스 프로젝트이며, 모든 형태의 기여를 환영합니다!

### 🐛 문제를 발견하셨나요?
- [이슈 제출](https://github.com/imhuso/cunzhi/issues)로 문제를 설명하세요
- 재현 단계와 환경 정보를 제공해주세요

### 💡 좋은 아이디어가 있으신가요?
- [토론 시작](https://github.com/imhuso/cunzhi/discussions)으로 아이디어를 공유하세요
- Pull Request를 제출하여 새로운 기능을 구현하세요

### 🛠️ 로컬 개발
```bash
git clone https://github.com/imhuso/cunzhi.git
cd cunzhi
pnpm install
pnpm tauri:dev
```
## 📞 연락처

- 🐛 **문제 피드백**：[GitHub Issues](https://github.com/imhuso/cunzhi/issues)
- 💬 **기능 토론**：[GitHub Discussions](https://github.com/imhuso/cunzhi/discussions)
- ⭐ **프로젝트가 마음에 드신다면**：Star로 응원해 주세요!

## 📄 오픈소스 라이선스

MIT License - 자유롭게 사용 가능, 기여를 환영합니다!

---

<div align="center">

**AI 대화의 "조루"와 작별 | 매번의 소통이 끝까지 이어지도록**

[⭐ Star](https://github.com/imhuso/cunzhi) · [🐛 버그 신고](https://github.com/imhuso/cunzhi/issues) · [💡 기능 요청](https://github.com/imhuso/cunzhi/discussions)

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---