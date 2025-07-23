<translate-content># 사람말 번역기

## 프로젝트 소개

사람말 번역기는 Chrome 브라우저 확장 프로그램으로, 사용자가 웹페이지의 텍스트 내용을 빠르게 번역할 수 있도록 돕습니다. 보기 좋고 드래그 가능한 팝업 인터페이스를 제공하며, 실시간 번역 및 복사 기능을 지원합니다.  

현재 주요 브라우저 확장 프로그램 마켓에 등록되어 있으며, 「사람말 번역기」를 검색하거나 아래 링크를 클릭하여 다운로드 및 사용을 환영합니다.  
Chrome 브라우저: [chrome 웹 스토어](https://chromewebstore.google.com/detail/genddacnaonloeecodkncflhpcdbcmdh)  
Edge 브라우저: [Edge 확장 마켓](https://microsoftedge.microsoft.com/addons/detail/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/nfcgnclfgdeocdakoconadlbonnjaglj)  
파이어폭스 브라우저: [파이어폭스 확장 마켓](https://addons.mozilla.org/zh-CN/firefox/addon/%E4%BA%BA%E8%AF%9D%E7%BF%BB%E8%AF%91%E5%99%A8/)  

## 주요 기능

- **텍스트 선택 번역**：웹페이지에서 텍스트를 선택하면 번역이 실행됩니다
- **실시간 번역 표시**：번역 결과가 팝업 창에 실시간으로 표시됩니다
- **사고 과정 표시**：번역의 사고 과정을 표시할 수 있습니다
- **드래그 가능한 인터페이스**：팝업 창을 드래그하여 위치 조정이 가능합니다
- **복사 기능**：한 번의 클릭으로 번역 결과를 복사합니다
- **Markdown 지원**：번역 결과가 Markdown 형식 렌더링을 지원합니다

## 사용 방법

1. Chrome 브라우저에서 확장 프로그램을 설치합니다
2. 확장 아이콘-설정 클릭 후 설정 페이지에서 API 정보를 입력합니다
3. 원하는 웹페이지에서 번역할 텍스트를 선택합니다
4. 번역을 실행합니다(우클릭 메뉴 또는 단축키 이용)
5. 팝업 번역 창에서 결과를 확인합니다
6. 제목 표시줄을 드래그하여 팝업 위치를 이동할 수 있습니다
7. "번역문 복사" 버튼을 클릭하여 번역 결과를 복사합니다
8. 우측 상단 "✕" 버튼을 클릭하여 팝업을 닫습니다

## 기술 구현

### 프론트엔드 인터페이스

- 순수 JavaScript로 구축된 팝업 인터페이스
- CSS 스타일이 미려하며, 스크롤 및 드래그 등 상호작용을 지원
- 텍스트 포맷팅을 위한 커스텀 Markdown 파서 사용

### 통신 메커니즘

- Chrome 확장의 메시지 전달 메커니즘(`chrome.runtime.onMessage`) 사용
- 아래 메시지 타입 지원:
  - `showTranslationPopup`：번역 팝업 표시
  - `translate`：번역 요청 전송
  - `updateTranslation`：번역 결과 업데이트
  - `cleanup`：자원 정리

### 특징 설계

- **스타일 충돌 방지**：모든 CSS 클래스명에 `translator-` 접두사 추가
- **스마트 스크롤**：사용자가 스크롤하지 않았을 때만 자동으로 하단으로 스크롤
- **에러 처리**：완벽한 에러 처리 메커니즘과 친절한 에러 메시지 제공
- **싱글톤 패턴**：동시에 하나의 번역 팝업만 존재하도록 보장

## 프로젝트 구조
</translate-content>
```
├── content/
│   └── content.js    # 内容脚本，负责弹窗创建和交互
├── background/
│   └── background.js # 后台脚本，处理翻译请求和API调用
├── popup/
│   ├── popup.html    # 扩展弹出窗口HTML
│   ├── popup.js      # 扩展弹出窗口脚本
│   └── popup.css     # 扩展弹出窗口样式
├── options/
│   ├── options.html  # 选项页面HTML
│   ├── options.js    # 选项页面脚本
│   └── options.css   # 选项页面样式
├── assets/
│   ├── icon.png      # 扩展图标目录
├── manifest.json     # 扩展配置文件
└── README.md         # 项目说明文档
```
## 개발 주의 사항

- 확장 프로그램은 Chrome 확장 API를 사용하므로 manifest.json에 권한을 올바르게 구성해야 합니다
- 번역 기능은 백엔드 API에 의존하므로 API 키 구성이 올바른지 확인해야 합니다
- 스타일 디자인은 웹페이지 기존 스타일과의 격리를 고려하여 충돌을 방지합니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---