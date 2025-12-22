# NovelWeave - AI 기반 소설 작성 VSCode 확장

[English](#) | [简体中文](https://raw.githubusercontent.com/wordflowlab/novelweave/main/README.zh-CN.md)

> 🌟 AI 지원, 체계적인 방법론, 원활한 VSCode 통합으로 소설 작성 경험을 혁신하세요.
>
> 검증된 [novel-writer](https://github.com/wordflowlab/novel-writer) 방법론을 기반으로, NovelWeave는 전문 소설 작성 도구를 직접 VSCode 워크플로우에 제공합니다.

## ✨ 주요 기능

- 📝 **7단계 방법론** - 명세 기반 소설 작성 워크플로우  
- 🎨 **시각적 인터페이스** - 직관적인 사이드바, 웹뷰 패널, 통합 AI 채팅  
- 🤖 **다중 AI 지원** - Claude 4, GPT-4, Gemini Pro, 400+ AI 모델  
- 🧠 **에이전트 스킬** - 전문 작성 지식을 위한 모듈형 AI 지식 시스템  
- 📊 **프로젝트 관리** - 챕터 추적, 캐릭터 프로필, 플롯 스레드  
- 🔌 **슬래시 명령어** - novel-writer 명령어 시스템 완전 지원  
- ✅ **품질 보증** - 플롯 추적, 타임라인 관리, 일관성 검증  
- 🌐 **크로스 플랫폼** - Windows, macOS, Linux 지원  

## 🚀 빠른 시작

### 1. 설치

VSCode 마켓플레이스에서 NovelWeave를 설치하세요:

```bash
# Search "NovelWeave" in VSCode Extensions
# Or install via command:
code --install-extension novelweave.novelweave
```
### 2. 첫 번째 소설 프로젝트 만들기

1. VSCode를 열고 활동 표시줄에서 NovelWeave 아이콘을 클릭합니다  
2. "새 프로젝트"를 클릭하여 소설 프로젝트를 초기화합니다  
3. AI 모델을 선택하고 설정을 구성합니다  
4. AI 지원과 함께 글쓰기를 시작하세요!  

### 3. 7단계 방법론 사용하기

NovelWeave는 검증된 7단계 소설 창작 방법론을 구현합니다:


```
1. /constitution  → Establish core creative principles
2. /specify       → Define story requirements
3. /clarify       → Resolve ambiguities through Q&A
4. /plan          → Design technical implementation
5. /tasks         → Break down into actionable steps
6. /write         → Execute the actual writing
7. /analyze       → Validate quality and consistency
```
## 📚 7단계 방법론

### 1단계: `/constitution` - 창의적 헌법

전체 소설을 이끌어갈 타협할 수 없는 글쓰기 원칙, 스타일 가이드라인, 핵심 가치를 정의합니다.

### 2단계: `/specify` - 이야기 명세

제품 요구사항 문서(PRD)처럼, 만들고자 하는 이야기, 대상 독자, 성공 기준을 정확히 정의합니다.

### 3단계: `/clarify` - 핵심 명확화

AI가 명세서의 모호한 부분을 찾아내고, 혼란을 없애기 위해 최대 5개의 주요 질문을 생성합니다.

### 4단계: `/plan` - 창의적 계획

추상적 요구사항을 구체적인 기술적 솔루션으로 전환: 챕터 구조, 캐릭터 아크, 세계관 구축, 플롯 타임라인.

### 5단계: `/tasks` - 작업 분해

계획을 우선순위와 의존관계가 명확한 실행 가능한 글쓰기 작업들로 분해합니다.

### 6단계: `/write` - 글쓰기 실행

작업 목록에 따라 헌법 원칙과 창의적 계획을 따르며 글을 씁니다.

### 7단계: `/analyze` - 종합 검증

플롯 일관성, 타임라인 정확성, 캐릭터 발전, 창의적 원칙 준수를 검증합니다.

> 📖 **자세한 방법론**: [novel-writer 문서](https://github.com/wordflowlab/novel-writer)에서 더 알아보세요

## 🔧 NovelWeave vs novel-writer CLI

| 기능                   | novel-writer CLI       | NovelWeave VSCode                  |
| ---------------------- | ---------------------- | --------------------------------- |
| **인터페이스**         | 명령줄                 | 그래픽 UI                        |
| **설치 방법**           | `npm install -g`       | VSCode 마켓플레이스               |
| **AI 통합**             | 기본                   | 완전한 AI 채팅 및 지원           |

| **프로젝트 관리**       | 파일 시스템             | VSCode 작업공간 + UI 패널               |
| **슬래시 명령어**       | ✅                     | ✅                                   |
| **시각적 추적**         | ❌                     | ✅ (플롯, 캐릭터, 타임라인)             |
| **학습 곡선**           | CLI 숙련 필요          | 직관적인 UI                          |
| **최적 대상**           | 기술에 능숙한 작가      | 모든 작가, 특히 VSCode 사용자          |

**두 가지는 함께 작동합니다!** 자동화 및 스크립트에는 novel-writer CLI를 사용하고, NovelWeave는 시각적 인터페이스와 AI 상호작용을 제공합니다.

## 🎯 사용 사례

- **장편 소설** - 100장 이상의 복잡한 플롯 관리
- **웹 연재 글쓰기** - AI 지원과 함께 매일 꾸준한 업데이트
- **시나리오 및 대본** - 장면 관리를 통한 구조화된 스토리텔링
- **팬 픽션** - 원작과의 일관성 유지
- **창작 글쓰기** - 모든 내러티브 프로젝트에 구조화된 방법론 제공

## 📖 상세 기능

### 에이전트 스킬 시스템

NovelWeave의 혁신적인 **에이전트 스킬** 시스템은 필요 시 활성화 가능한 AI 비서의 전문 지식 모듈을 제공합니다:

- **내장 스킬** - 전문적인 글쓰기 전문 지식 포함:
    - 장르 지식 (로맨스, 미스터리, 판타지)
    - 글쓰기 기법 (대화, 장면 구조)
    - 품질 보증 (일관성 검사, 요구사항 탐지)
- **프로젝트 스킬** - `.agent/skills/` 내 팀별 가이드라인 공유
- **개인 스킬** - 재사용 가능한 개인 지식 라이브러리
- **스마트 활성화** - 작업에 따라 AI가 관련 스킬 자동 선택
- **사용자 정의 스킬** - 간단한 마크다운으로 나만의 전문 모듈 생성

> 📖 **더 알아보기**: 자세한 사용법은 [에이전트 스킬 사용자 가이드](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md)를 참조하세요.

### AI 기반 글쓰기 도우미

- **스마트 연속 작성** - 스타일에 맞는 다음 단락 AI 제안
- **캐릭터 음성 유지** - 일관된 캐릭터 성격 유지
- **플롯 제안** - 플롯 구멍 및 전개 속도 문제 해결 지원
- **스타일 분석** - 글쓰기 스타일과 가독성 피드백 제공

### 프로젝트 조직

- **챕터 관리** - 사이드바에서 챕터 탐색 및 조직화
- **캐릭터 프로필** - 캐릭터 개발 및 관계 추적
- **세계관 구축** - 설정, 규칙 및 전설 관리
- **플롯 스레드** - 여러 스토리라인 시각화 및 추적

### 품질 보증

- **일관성 검사** - 캐릭터 특성, 타임라인 및 사실 검증
- **플롯 추적** - 모든 플롯 스레드 해결 보장
- **타임라인 관리** - 연대기 정확성 검증
- **스타일 일관성** - 고유한 글쓰기 목소리 유지

## 🆕 새 소식

### v0.13.0 (최신)

- 🧠 **에이전트 스킬 시스템** - 모듈형 AI 지식 아키텍처
    - 14개의 내장 전문 작문 스킬
    - 세 단계 시스템: 확장, 프로젝트, 개인 스킬
    - 작업 맥락에 따른 스마트 자동 활성화
    - 맞춤 스킬 탐색, 관리, 생성용 완전 UI
- ✅ 향상된 품질 보증 도구
- 📚 종합 문서 및 모범 사례 가이드

### v1.0

- ✅ 7단계 완전 방법론 구현
- ✅ 다중 AI 모델 지원(400+ 모델)
- ✅ 시각적 프로젝트 관리 인터페이스
- ✅ 통합 플롯 및 캐릭터 추적
- ✅ 실시간 AI 글쓰기 지원
- ✅ 완전한 소설가 슬래시 명령어 호환

## 💡 모범 사례

1. **헌법부터 시작** - 글쓰기 전에 원칙 정의
2. **클래리파이 적극 활용** - 초기 모호성 해결로 재작성 방지
3. **과정을 신뢰** - 최상의 결과를 위해 7단계 모두 따르기
4. **반복하기** - 스토리가 발전함에 따라 이전 단계로 돌아가기  
5. **일관되게 추적하기** - 주요 챕터가 끝날 때마다 추적기 업데이트  

## 🔗 관련 자료  

### 문서  

- 📖 [에이전트 스킬 사용자 가이드](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) - 스킬 사용법 및 생성 방법  
- 🛠️ [에이전트 스킬 개발자 가이드](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-developer-guide.md) - 기술 아키텍처 및 API  
- ✍️ [스킬 작성 모범 사례](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/writing-skills-best-practices.md) - 고품질 스킬 생성  

### 커뮤니티 및 도구  

- 📦 [novel-writer CLI 도구](https://github.com/wordflowlab/novel-writer) - 명령줄 동반자  
- 📖 [7단계 방법론](https://github.com/wordflowlab/novel-writer/blob/main/METHODOLOGY.md) - 상세한 방법론 안내  
- 💬 [커뮤니티 디스코드](#) - NovelWeave를 사용하는 다른 작가들과 함께하기  
- 📺 [비디오 튜토리얼](#) - 단계별 가이드 시청하기  

## 🤝 기여하기  

기여를 환영합니다! 자세한 내용은 [기여 가이드](https://raw.githubusercontent.com/wordflowlab/novelweave/main/CONTRIBUTING.md)를 참고하세요.  

## 📄 라이선스  

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.  

## 🙏 감사의 말  

- [NovelWeave](https://github.com/NovelWeave-Org/novelweave) 아키텍처 기반  
- [novel-writer](https://github.com/wordflowlab/novel-writer)에서 제공하는 방법론  
- [Spec Kit](https://github.com/sublayerapp/spec-kit) 원칙에서 영감 받음  

---  

**NovelWeave** - AI와 스토리텔링 마스터리의 만남 ✨📚  

전 세계 작가들을 위해 ❤️와 함께 제작되었습니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---