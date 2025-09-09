
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=HappyDongD&project=magic_image&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 마법 AI 그림

<div align="right">中文 | <a href="README-EN.md">English</a></div>

[![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![Next.js](https://img.shields.io/badge/Next.js-14-black.svg)](https://nextjs.org/)
[![TypeScript](https://img.shields.io/badge/TypeScript-5.0-blue.svg)](https://www.typescriptlang.org/)
[![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-3.0-38B2AC.svg)](https://tailwindcss.com/)

Next.js 기반으로 개발된 AI 그림 그리기 애플리케이션으로, 주요 기능은 다음과 같습니다:
- 🎨 다양한 AI 모델(Sora, DALL-E, GPT, GEMINI 등) 및 사용자 지정 모델 추가 지원
- 🖼️ 텍스트로 이미지 생성 및 이미지로 이미지 생성 기능, 다중 이미지 참조 및 영역 편집 지원
- 🔐 모든 데이터와 API 키를 로컬에 저장하여 개인정보 보호 강화
- 💻 웹 버전 및 데스크톱 애플리케이션 패키징 지원, 크로스 플랫폼 사용 가능

## 온라인 체험

접속 주소: [https://image-front-eight.vercel.app/](https://image-front-eight.vercel.app/)

### 애플리케이션 스크린샷

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/4.png" alt="애플리케이션 스크린샷4" width="800" style="margin-bottom: 20px"/>
      <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/5.png" alt="애플리케이션 스크린샷4" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/0.png" alt="애플리케이션 스크린샷1" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/1.png" alt="애플리케이션 스크린샷2" width="800" style="margin-bottom: 20px"/>
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/2.png" alt="애플리케이션 스크린샷3" width="800" style="margin-bottom: 20px"/>
</div>

## 기능 특징

- 🎨 다양한 AI 모델 지원
  - GPT Sora_Image 모델
  - GPT 4o_Image 모델
  - GPT Image 1 모델
  - DALL-E 3 모델
  - GEMINI 모델
  - 🆕 사용자 지정 모델(개인 모델 추가 지원)
- 🔄 다중 모델 전환
  - 다양한 모델 간 빠른 전환 지원
  - 각 모델마다 별도의 설정 옵션 제공
- ✍️ 텍스트로 이미지 생성 기능
  - 사용자 지정 프롬프트 지원
  - 이미지 비율 선택 가능
  - 다양한 이미지 크기 지원
- 🖼️ 이미지로 이미지 생성 기능
  - 이미지 편집 지원
  - 영역 마스킹 편집 지원
  - 이미지 품질 조정 지원
  - 다중 이미지 참조 지원(여러 이미지를 동시에 업로드)
- 🔒 데이터 보안
  - 생성된 모든 이미지와 히스토리는 로컬 브라우저에만 저장됨
  - 사용자 지정 API 프록시 주소 지원
  - API Key 설정 지원
- 📱 UI 디자인
  - 현대적인 사용자 인터페이스
  - 부드러운 인터랙션 경험
  - Markdown 형식 표시
  - 코드 하이라이트 지원
- 🖥️ 크로스 플랫폼 지원
  - 데스크탑 앱 패키징 지원(Windows, macOS, Linux)
  - 오프라인 사용 지원(API 인터페이스 설정 필요)

## 기술 스택

- Next.js 14
- TypeScript
- Tailwind CSS
- shadcn/ui
- React
- Tauri(데스크탑 앱 패키징)

## 로컬 개발

1. 프로젝트 클론
```bash
git clone https://github.com/HappyDongD/magic_image.git
cd magic_image
```
2. 의존성 설치

```bash
npm install
# 或
yarn install
# 或
pnpm install
```
3. 개발 서버 시작하기

```bash
npm run dev
# 或
yarn dev
# 或
pnpm dev
```
4.  [http://localhost:3000](http://localhost:3000) 에 접속

## 데스크탑 애플리케이션 패키징

본 프로젝트는 Tauri를 사용하여 데스크탑 애플리케이션을 패키징하며, Windows, macOS 및 Linux 시스템을 지원합니다.

### 환경 준비

데스크탑 애플리케이션 패키징 전에 다음 종속성을 설치해야 합니다:

1. **Rust 설치**：
   - [https://www.rust-lang.org/tools/install](https://www.rust-lang.org/tools/install) 방문
   - 안내에 따라 Rust와 Cargo 설치

2. **시스템 종속성**：
   - **Windows**: [Visual Studio C++ 빌드 도구](https://visualstudio.microsoft.com/visual-cpp-build-tools/) 설치
   - **macOS**: Xcode 명령어 도구 설치 (`xcode-select --install`)
   - **Linux**: 관련 종속성 설치, 자세한 내용은 [Tauri 문서](https://tauri.app/v1/guides/getting-started/prerequisites) 참조

### 개발 모드


```bash
# 安装 Tauri CLI
npm install -D @tauri-apps/cli

# 启动桌面应用开发模式
npm run tauri:dev
```
### 데스크탑 애플리케이션 빌드


```bash
# 构建桌面应用安装包
npm run desktop
```
빌드가 완료되면 `src-tauri/target/release/bundle` 디렉토리에서 해당 시스템의 설치 파일을 찾을 수 있습니다.

## Vercel 배포

1. 이 프로젝트를 당신의 GitHub 계정으로 Fork 합니다.

2. [Vercel](https://vercel.com)에서 새 프로젝트를 생성합니다.

3. 당신의 GitHub 저장소를 가져옵니다.

4. 배포를 클릭합니다.

## 사용 설명

1. 처음 사용할 때는 API 키를 설정해야 합니다.
   - 오른쪽 상단의 "키 설정"을 클릭합니다.
   - API 키와 기본 주소를 입력합니다.
   - 저장을 클릭합니다.
   - URL 매개변수를 통해 빠르게 설정할 수도 있습니다:

     ```
     http://localhost:3000?url=你的API地址&apikey=你的API密钥
     ```
     例如：
     ```
     http://localhost:3000?url=https%3A%2F%2Fapi.example.com&apikey=sk-xxx
     ```
     주의: URL의 특수 문자는 반드시 URL 인코딩을 해야 합니다

2. 생성 모드 선택
   - 텍스트로 이미지 생성: 텍스트 설명을 통해 이미지를 생성합니다
   - 이미지로 이미지 생성: 이미지를 업로드하여 편집합니다

3. 생성 파라미터 설정
   - AI 모델 선택(내장 모델 또는 사용자 정의 모델)
   - 이미지 비율 설정
   - 이미지 품질 조정(이미지로 이미지 생성 모드)

4. 사용자 정의 모델 관리
   - 모델 선택 박스 옆의 설정 아이콘 클릭
   - 새 모델 추가: 모델 이름, 모델 값 입력 및 모델 유형 선택
   - 모델 편집: 기존 모델의 편집 버튼 클릭
   - 모델 삭제: 기존 모델의 삭제 버튼 클릭
   - 모델 선택: 모델의 플러스 버튼을 클릭하여 즉시 해당 모델 사용

5. 모델 유형 설명
   - DALL-E 형식: 이미지 생성 인터페이스(/v1/images/generations) 사용
   - OpenAI 형식: 채팅 인터페이스(/v1/chat/completions) 사용

6. 이미지 생성
   - 프롬프트 입력
   - "이미지 생성" 버튼 클릭
   - 생성 완료까지 대기

7. 이미지 관리
   - 기록 보기
   - 생성된 이미지 다운로드
   - 기존 이미지 편집

## 주의 사항

- 모든 생성된 이미지와 기록은 로컬 브라우저에만 저장됩니다
- 프라이버시 모드 사용 또는 기기 변경 시 데이터가 손실됩니다
- 중요한 이미지는 반드시 즉시 다운로드 및 백업하세요
- API 설정은 브라우저에 안전하게 저장되며 서버로 업로드되지 않습니다
- HTTPS 사이트에서 HTTP 리소스를 불러오면 브라우저에서 차단되며, 앱이 HTTP 인터페이스를 자동으로 HTTPS로 변환합니다

## 기여 가이드

이슈 및 풀 리퀘스트 제출을 환영합니다. 프로젝트 개선에 도움을 주세요.

## 라이선스

본 프로젝트는 [Apache License 2.0](https://www.apache.org/licenses/LICENSE-2.0) 라이선스를 적용합니다.

라이선스에 따라, 다음을 할 수 있습니다:
- ✅ 상업적 사용: 소프트웨어를 상업적으로 사용할 수 있습니다
- ✅ 수정: 소프트웨어 소스 코드를 수정할 수 있습니다
- ✅ 배포: 소프트웨어를 배포할 수 있습니다
- ✅ 개인적 사용: 소프트웨어를 개인적으로 사용할 수 있습니다
- ✅ 특허 허가: 본 라이선스는 특허 허가도 제공합니다

그러나 다음 조건을 준수해야 합니다:
- 📝 라이선스 및 저작권 명시: 원본 라이선스와 저작권 명시를 포함해야 합니다
- 📝 변경 사항 명시: 원본 코드에 대한 중요한 변경을 명시해야 합니다
- 📝 상표 명시: 기여자의 상표를 사용할 수 없습니다

---

## 커피 한 잔 사주세요

이 프로젝트가 도움이 되었다면, 커피 한 잔을 사주세요 ☕️

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-pay.jpg" alt="위챗 결제 코드" width="300" />
  <p>커피 한 잔 사주세요</p>
</div>

## 연락처

질문이나 제안이 있으시면, 위챗으로 연락해 주세요:

<div align="center">
  <img src="https://raw.githubusercontent.com/HappyDongD/magic_image/master/./public/wechat-connect.jpg" alt="위챗 연락처" width="300" />
  <p>QR코드를 스캔하여 위챗 추가</p>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---