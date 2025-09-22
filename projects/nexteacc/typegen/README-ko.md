# TypeGen - 스마트 텍스트 스타일 변환 도구

TypeGen은 Next.js 기반의 현대적인 AI 구동 텍스트 스타일 변환 애플리케이션입니다. OpenAI API를 통합하여 다차원적인 작문 스타일, 구조 템플릿 및 전략 매개변수 간의 스마트 변환을 제공하며, 직관적인 드래그 앤 드롭 인터페이스를 갖추고 있습니다.

## 🎯 핵심 기능

### 스마트 텍스트 변환
- **AI 구동**: OpenAI GPT-4o-mini를 통합하여 실질적인 텍스트 스타일 변환 수행
- **28가지 스타일 필터**: 작문 어체, 구조 골격, 전파 전략의 세 가지 차원 포괄
- **스마트 글자 수 제어**: 목표 길이 설정 지원, 간결한 요약부터 상세한 확장까지 가능
- **실시간 변환**: 빠른 응답 API 처리로 원활한 사용자 경험 제공

### 직관적 인터페이스 디자인
- **드래그 앤 드롭 조작**: 스타일 필터를 텍스트 박스로 드래그하여 변환 시작
- **시각적 피드백**: 풍부한 애니메이션 효과 및 상태 표시
- **비교 표시**: 변환 전후의 양단 비교 레이아웃
- **원클릭 조작**: 결과 복사, 다른 스타일 시도, 다시 시작

## 🛠️ 기술 아키텍처

### 프론트엔드 기술 스택
- **프레임워크**: [Next.js](https://nextjs.org/) 15.5.0 (Turbopack 사용 개발)
- **UI 라이브러리**: [React](https://reactjs.org/) 19.0.0
- **스타일 시스템**: [Tailwind CSS](https://tailwindcss.com/) 4.1.11
- **애니메이션 라이브러리**: [Framer Motion](https://www.framer.com/motion/) 12.23.6
- **타입 안전성**: [TypeScript](https://www.typescriptlang.org/) 5
- **패키지 관리자**: [pnpm](https://pnpm.io/)

### 핵심 컴포넌트
- **드래그 시스템**: @dnd-kit/core 기반의 전문 드래그 인터랙션
- **스타일 관리**: clsx 및 tailwind-merge를 활용한 동적 스타일 처리
- **UI 컴포넌트**: Radix UI 기반의 맞춤형 컴포넌트 라이브러리

## 📂 프로젝트 구조

```
├── app/                           # Next.js App Router
│   ├── api/transform/route.ts     # 文本转换 API 端点
│   ├── page.tsx                   # 主应用界面
│   ├── layout.tsx                 # 根布局组件
│   └── globals.css                # 全局样式
├── components/                    # UI 组件库
│   ├── style-filter/              # 风格滤镜系统
│   │   ├── types.ts              # 类型定义
│   │   ├── filters-data.ts       # 风格数据配置
│   │   ├── filter-container.tsx  # 滤镜容器组件
│   │   └── ...                   # 动画和交互组件
│   ├── ui/                       # 基础 UI 组件
│   ├── length-control.tsx        # 字数控制滑动条
│   └── text-stats.tsx           # 文本统计显示
├── lib/                          # 业务逻辑层
│   ├── api-client.ts            # API 客户端封装
│   ├── transform-service.ts     # 转换服务核心
│   ├── openai-service.ts        # OpenAI API 集成
│   └── api-types.ts             # API 类型定义
├── public/icons/                # 风格图标资源
└── utils/                       # 工具函数
```
## 🎨 스타일 필터 일람

### 문체 스타일 (Style)

**뉴스 / 학술 / 교과서**
- AP 스타일
- APA 스타일
- IEEE 스타일
- 교과서 스타일
- 탐사 보도

**커뮤니티 / 플랫폼 문화**
- 4chan 스타일
- Reddit 스타일
- BuzzFeed
- Twitter 스타일
- Instagram 캡션
- 밈 스타일

**소설 / 창의적 글쓰기**
- 헤밍웨이 스타일

### 구조 템플릿 (Structure)

**뉴스 / 정보 구조**
- 역피라미드
- 헤드라인 중심

**목록 / 스레드 / 튜토리얼**
- 리스트클
- 스레드형
- 사용법
- 글머리 기호

**학술 / 서술 구조**
- IMRaD

### 전략 및 매개변수 (Strategy & Controls)
- 클릭베이트

- 행동 촉구
- SEO 최적화
- FOMO 유발
- 해시태그 다수 포함
- 이모지 다수 포함
- 플레시-킨케이드
- 인용 다수 포함
- 기술 용어 사용

## ⚙️ 구성 가이드

### 환경 구성
1. **OpenAI API 키 받기**
   ```bash
   # 访问 https://platform.openai.com/account/api-keys
   # 创建新的 API 密钥
   ```
2. **환경 변수 구성**

   ```bash
   cp .env.example .env.local
   ```
   `.env.local` 파일을 편집합니다:

   ```bash
   OPENAI_API_KEY=sk-proj-your_api_key_here
   OPENAI_MODEL=gpt-4o-mini                    # 可选，默认值
   OPENAI_MAX_TOKENS=2000                      # 可选，默认值
   OPENAI_TEMPERATURE=0.7                      # 可选，默认值
   API_TIMEOUT=30000                           # 可选，30秒超时
   API_MAX_RETRIES=3                           # 可选，最大重试次数
   ```
### 로컬 개발

```bash
# 安装依赖
pnpm install

# 启动开发服务器
pnpm dev

# 构建生产版本
pnpm build

# 代码检查
pnpm lint
```

## 🔧 핵심 구현

### 상태 관리
애플리케이션은 완전한 상태 머신 패턴을 사용하여 전환 흐름을 관리합니다:
- `idle`: 초기 상태, 텍스트 입력 대기
- `readyToTransform`: 텍스트 준비 완료, 변환 가능
- `transforming`: 변환 진행 중, 로딩 상태 표시
- `transformed`: 변환 완료, 결과 비교 표시

### API 통합
- **타입 안전성**: 완전한 TypeScript 타입 정의
- **오류 처리**: 계층적 오류 처리 및 사용자 친화적 오류 메시지
- **성능 최적화**: API 응답 캐싱 및 요청 중복 제거
- **재시도 메커니즘**: 네트워크 실패 시 자동 재시도

### 상호작용 경험 (데스크톱)
- **드래그 앤 드롭**: 부드러운 드래그 애니메이션 및 시각적 피드백
- **글자 수 제어**: 실시간 글자 수 통계 및 목표 길이 설정
- **결과 조작**: 원클릭 복사, 재시도 및 다시 시작
- **플랫폼 안내**: 현재 버전은 데스크톱 전용, 모바일 인터랙션 미지원

## 🚀 확장 방향

- **다국어 지원**: 국제화 지원 추가
- **일괄 처리**: 다중 텍스트 동시 변환 지원
- **사용자 정의 스타일**: 사용자 맞춤형 스타일 생성 허용
- **협업 기능**: 팀 공유 및 댓글 기능
- **데이터 분석**: 사용 통계 및 효과 분석 활용


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---