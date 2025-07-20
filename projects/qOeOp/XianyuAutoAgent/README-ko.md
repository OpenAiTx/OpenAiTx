<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - 지능형 셴위 고객센터 챗봇 시스템

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

셴위 플랫폼을 위해 설계된 AI 자동 응대 솔루션으로, 셴위 플랫폼의 7×24시간 자동화 응대, 다중 전문가 협업 의사결정, 지능형 가격 제안 및 문맥 인식 대화를 지원합니다.

## 🎮 Playground - 빠른 체험 (설정 불필요 버전)

로컬 환경이나 Secrets 설정 불필요! **GitHub Actions 웹 페이지에서 바로 파라미터 입력** 후, 원클릭으로 셴위 챗봇을 시작하세요.

### 사용 방법
1. **이 저장소 Fork** → 오른쪽 상단의 `Fork` 버튼 클릭
2. **Action 실행**:
   - 내 저장소의 `Actions` 탭으로 이동
   - **`🚀 Run Service`** 워크플로 선택
   - **`Run workflow`** 버튼 클릭 후 파라미터 입력:
      - `API Key`: 대형 언어모델 API Key 입력(예: 알리클라우드 DashScope)
      - `Cookies`: 셴위 웹사이트의 전체 쿠키 문자열 입력
3. **실행 로그 확인**:
   - 챗봇이 시작되면 자동으로 셴위 메시지 모니터링
   - Action 로그에서 `🤖 Reply:`로 대화 내용 검색

### 주의 사항
⚠️ 임시 실행 제한에 유의하세요:
- 기본 실행 시간 **30분** (GitHub 무료 계정 기준)
- 민감 정보(쿠키 등)는 **저장되지 않으며**, 해당 실행에만 적용됩니다

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 핵심 특징

### 지능형 대화 엔진
| 기능 모듈  | 기술 구현             | 주요 특성                                                     |
| ---------- | --------------------- | ------------------------------------------------------------- |
| 문맥 인식  | 대화 이력 저장        | 경량 대화 메모리 관리, 전체 대화 이력을 LLM 문맥 입력으로 활용 |
| 전문가 라우팅 | LLM 프롬프트+규칙 라우팅 | 프롬프트 엔지니어링 기반 의도 인식 → 전문가 Agent 동적 분배, 가격협상/기술/고객센터 다중 시나리오 전환 지원 |

### 비즈니스 기능 매트릭스
| 모듈      | 구현 완료                        | 계획 중                      |
| --------- | ------------------------------- | ------------------------- |
| 핵심 엔진 | ✅ LLM 자동 응답<br>✅ 문맥 관리   | 🔄 감정 분석 강화                |
| 가격 협상 | ✅ 단계별 가격 인하 전략           | 🔄 시장 가격 비교 기능            |
| 기술 지원 | ✅ 웹 검색 통합                   | 🔄 RAG 지식베이스 강화           |

## 🚴 빠른 시작

### 환경 요구 사항
- JDK 21+
- Maven 3.9.10+

### 설치 단계

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 참여 및 기여

Issue를 통해 제안 사항을 제출하거나 PR로 코드를 기여해 주세요. [기여 가이드라인](https://contributing.md/)을 준수해 주시기 바랍니다.



## 🛡 주의 사항

⚠️ 주의: **본 프로젝트는 학습 및 교류 목적으로만 사용되며, 저작권 침해 시 작성자에게 연락하여 삭제 요청 바랍니다.**

프로젝트의 특성상 개발팀은 언제든지 **업데이트 중단** 또는 **프로젝트 삭제**를 할 수 있습니다.


## 🧸 특별 감사

본 프로젝트는 다음 오픈소스 프로젝트를 기반으로 재구성되었습니다:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - 스마트 쉬안위 고객 서비스 로봇 시스템, [@shaxiu](https://github.com/shaxiu) 와 [@cv-cat](https://github.com/cv-cat) 개발


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---