# 剪存 - 클립보드 히스토리 관리 도구

Wails + Vue 3 + TypeScript 기반의 다중 플랫폼 클립보드 히스토리 관리 도구입니다.

## App Store에 출시됨
https://apps.apple.com/us/app/剪存/id6754015301

## 기능 특징
- [새로운 사용자 정의 스크립트 - 클릭하여 보기](https://raw.githubusercontent.com/snsogbl/clip-save/main/scriptingExample/README.md)
- 클립보드 히스토리 자동 저장
- 텍스트, 이미지, 파일 등 다양한 타입 지원
- 실시간 검색 및 필터 기능 (이미지 내 OCR 텍스트 검색 지원)
- 로컬 SQLite 데이터베이스 저장 (모든 데이터는 로컬에만 저장, 개인정보 보호 보장)
- 개인화 설정: 비밀번호 보호, 자동 정리, 단축키 설정

## 프로젝트 스크린샷

<img src="https://raw.githubusercontent.com/snsogbl/clip-save/master/screenshots/clipboard-1.png" alt="Capture" width="960">


## 기술 스택

- **백엔드**: Go + Wails v2
- **프론트엔드**: Vue 3 + TypeScript + Vite
- **데이터베이스**: SQLite3
- **클립보드**: golang.design/x/clipboard

## 의존성 설치

### 1. Wails CLI 설치하기

```bash
go install github.com/wailsapp/wails/v2/cmd/wails@latest
```

### 2. 프로젝트 의존성 설치

```bash
# Go 依赖
go mod tidy

# 前端依赖
cd frontend
npm install
```

## 开发

### 启动开发服务器

```bash
wails dev
```
이것은 핫 리로드 개발 서버를 시작합니다:  
- 백엔드 Go 코드 수정 시 자동으로 재컴파일됨  
- 프론트엔드 Vue 코드 수정 시 자동으로 핫 리로드됨  

### 개발 시 디버깅  

개발 모드에서 애플리케이션은 자동으로 개발자 도구를 엽니다. 확인할 수 있는 내용:  
- 콘솔 로그  
- 네트워크 요청  
- 프론트엔드 컴포넌트 상태  

## 빌드  

### 프로덕션 버전 빌드


```bash
wails build
```
빌드가 완료되면 실행 파일은 `build/bin/` 디렉토리에 위치하게 됩니다.

### 맞춤 스크립트 Cloudflare Pages에 배포하기

프로젝트는 Cloudflare Pages를 사용하여 온라인 스크립트 목록을 호스팅하며, 사용자가 "스크립트 마켓"에서 직접 스크립트를 설치하고 업데이트할 수 있도록 지원합니다.

#### 1. Wrangler CLI 설치하기


```bash
npm install -g wrangler
```

#### 2. Cloudflare 로그인

```bash
wrangler login
```
이렇게 하면 브라우저가 열리고 Cloudflare 계정에 로그인합니다.

#### 3. 스크립트 배포


```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```
배포가 완료된 후, 스크립트는 다음 URL을 통해 접근할 수 있습니다:
- 플러그인 목록: `https://clip-save-plugins.pages.dev/plugins.json`
- 스크립트 파일: `https://clip-save-plugins.pages.dev/{스크립트파일명}.js`

#### 4. 스크립트 업데이트

`scriptingExample` 디렉토리 내 파일을 수정할 때마다 배포 명령어를 다시 실행하세요:


```bash
wrangler pages deploy scriptingExample --project-name=clip-save-plugins
```
#### 5. 주의사항

- `plugins.json`의 `scriptUrl`이 Cloudflare Pages의 URL을 사용하도록 확인하세요  
- 배포 후 보통 몇 초 내에 적용됩니다(Cloudflare Pages 캐시 시간이 매우 짧음)  
- Cloudflare 대시보드에서 배포 이력과 로그를 확인할 수 있습니다  

### macOS 빌드 옵션


```bash
# 构建 Intel 版本
wails build -platform darwin/amd64

# 构建 Apple Silicon 版本
wails build -platform darwin/arm64

# 构建通用二进制（推荐）
wails build -platform darwin/universal
```

### Windows 빌드

```bash
wails build -platform windows/amd64
```

### Linux 빌드

```bash
wails build -platform linux/amd64
```

## 프로젝트 구조

```
.
├── main.go                      # 主程序入口
├── app.go                       # Wails 应用结构和 API
├── wails.json                   # Wails 配置文件
├── go.mod                       # Go 依赖管理
├── common/                      # 共享代码
│   ├── clipboard.go             # 剪贴板逻辑
│   ├── clipboard_darwin.go      # macOS 特定代码
│   └── db.go                    # 数据库操作
├── frontend/                    # 前端代码
│   ├── src/
│   │   ├── App.vue              # 主应用组件
│   │   ├── components/
│   │   │   └── ClipboardHistory.vue  # 剪贴板历史组件
│   │   ├── main.ts              # 前端入口
│   │   └── style.css            # 全局样式
│   ├── index.html               # HTML 模板
│   ├── package.json             # 前端依赖
│   ├── vite.config.ts           # Vite 配置
│   └── tsconfig.json            # TypeScript 配置
└── build/                       # 构建资源和输出
    ├── bin/                     # 编译后的可执行文件
    ├── appicon.png              # 应用图标
    └── darwin/                  # macOS 特定配置
```

## API 설명

### 백엔드 API (Go)

`app.go`에 정의된 메서드는 자동으로 프론트엔드에 노출됩니다:

- `SearchClipboardItems(keyword, filterType, limit)` - 클립보드 항목 검색
- `GetClipboardItems(limit)` - 클립보드 목록 가져오기
- `GetClipboardItemByID(id)` - ID로 항목 가져오기
- `CopyToClipboard(id)` - 항목을 클립보드로 복사
- `DeleteClipboardItem(id)` - 항목 삭제
- `GetStatistics()` - 통계 정보 가져오기

### 프론트엔드 호출 예시

```typescript
import { SearchClipboardItems } from '../wailsjs/go/main/App'

// 搜索剪贴板项目
const items = await SearchClipboardItems('关键词', '所有类型', 100)
```
## 사용 설명

1. 앱을 실행하면 백그라운드에서 시스템 클립보드를 자동으로 저장합니다.
2. 복사할 때마다 내용이 자동으로 기록에 저장됩니다.
3. 상단 검색창을 사용하여 기록을 빠르게 검색할 수 있습니다(이미지 내 OCR 문자 검색 지원).
4. 필터를 사용하여 유형별로 내용을 필터링할 수 있습니다(텍스트/이미지/URL 등).
5. 기록 항목을 클릭하면 세부 정보를 볼 수 있습니다.
6. 이미지 유형의 경우 "문자 추출" 버튼을 클릭하여 OCR 인식 결과를 확인할 수 있습니다.
7. "복사" 버튼을 클릭하면 내용을 클립보드에 다시 복사할 수 있습니다.
8. "삭제" 버튼을 클릭하면 기록을 삭제할 수 있습니다.

### OCR 문자 인식 기능

- **자동 인식**: 이미지를 복사하면 앱이 백그라운드에서 이미지 내 문자를 자동으로 인식합니다(macOS 10.15+).
- **스마트 검색**: 인식된 문자는 자동으로 검색 인덱스에 추가되어 키워드를 입력하면 해당 문자를 포함한 이미지를 찾을 수 있습니다.
- **수동 추출**: 이미지 상세 페이지에서 "문자 추출" 버튼을 클릭하면 완전한 OCR 인식 결과를 볼 수 있습니다.
- **지원 언어**: 중국어(간체/번체) 및 영어 인식을 지원합니다.
- **성능 최적화**: 동일한 이미지는 한 번만 인식하며 인식 결과를 자동 재사용하여 성능을 향상합니다.

## 데이터 저장

클립보드 기록은 `~/.clipsave/clipboard.db`에 저장됩니다.

데이터베이스는 자동 생성되며 다음 필드를 포함합니다:
- ID - 고유 식별자
- Content - 내용 텍스트
- ContentType - 내용 유형
- ImageData - 이미지 데이터(PNG 형식)
- Timestamp - 타임스탬프
- Source - 출처
- CharCount - 문자 수
- WordCount - 단어 수
- OCRText - OCR 인식 문자 내용(이미지 유형 전용, 검색용)

## 시스템 요구 사항

- **macOS**: 10.15 Catalina 이상 버전(OCR 기능 필요)
- **Windows**: Windows 10/11(1809 이상) + WebView2
- **Linux**: WebKit2GTK를 지원하는 배포판

- **Go**: 1.21 이상 버전
- **Node.js**: 16 이상 버전

## 개발 주의사항

### Go API 업데이트 후

`app.go`의 메서드를 수정할 때마다 프론트엔드 바인딩을 다시 생성해야 합니다:

```bash
wails generate module
```
또는 개발 모드를 사용하면 자동으로 생성됩니다:


```bash
wails dev
```
### 프론트엔드 개발

프론트엔드는 Vite + Vue 3 + TypeScript 사용:
- TypeScript 타입 검사 지원
- Composition API 사용
- Wails 바인딩 자동 임포트
- 핫 모듈 교체(HMR)

### CGO 의존성

프로젝트는 CGO(SQLite 및 클립보드 작업용)를 사용하며, 빌드시 필요:
- macOS: Xcode Command Line Tools 필요
- Windows: MinGW-w64 필요
- Linux: gcc 필요

## 자주 묻는 질문

### 1. 빌드 실패

모든 의존성이 설치되었는지 확인:

```bash
# macOS
xcode-select --install

# Windows
# 安装 MSYS2 和 MinGW-w64

# Linux
sudo apt-get install build-essential libgtk-3-dev libwebkit2gtk-4.0-dev
```
### 2. 프론트엔드에서 백엔드 API 호출 불가

`wails generate module` 명령어로 프론트엔드 바인딩이 생성되었는지 확인하세요.

## 라이선스

MIT 라이선스

## 후원 지원

💗 **작가에게 커피 한 잔을**

이 소프트웨어가 시간을 절약해주었거나(적어도 스트레스를 덜어주었다면) 작가에게 커피 ☕ 또는 맥주 🍺 한 잔을 후원해 주세요!

모든 커피 한 잔은 신기하게도 새로운 기능, 적은 버그(최대한 노력 중), 그리고 작가가 밤새 코딩할 때 정신적 지주가 됩니다.

당신의 Star ⭐ 와 기부는 제가 버그를 고치고 새 기능을 추가하는 원동력입니다(또한 커피 구매 자금이기도 합니다)!

### 위챗 스캔

![후원 코드](https://raw.githubusercontent.com/snsogbl/clip-save/main/frontend/src/assets/static/zs.png)

**"저에게 커피 한 잔 사주세요 ☕"**

### 프로젝트에 Star ⭐ 주세요

이 프로젝트가 도움이 되었다면 프로젝트에 Star ⭐ 를 눌러주세요. 그것이 저에게 가장 큰 응원입니다!

## 감사의 말씀

- [Wails](https://wails.io) - 데스크톱 애플리케이션 프레임워크
- [Vue 3](https://vuejs.org) - 점진적 JavaScript 프레임워크
- [golang.design/x/clipboard](https://github.com/golang-design/clipboard) - 크로스 플랫폼 클립보드 라이브러리
- [json-editor-vue](https://github.com/cloydlau/json-editor-vue)
- [highlight.js](https://github.com/highlightjs/highlight.js)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---