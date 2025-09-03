# 대형 모델 응용 개발 학습 로드맵（속성판）

본 저장소는 본인이 학습하는 🔥대형 모델 응용 개발🔥 시 정리하고 학습한 일부 자료로, 모두 핵심 내용이며 추가 확장은 없습니다. 💰취업과 돈 벌기가 최우선💰입니다. 읽어보시고 도움이 되면 🌟 star 부탁드립니다, 감사합니다!

# ✅ 안내

본 프로젝트는 대형 모델 응용 개발 RAG와 Agent 간단 데모 전시로, 모두 LangChain 프레임워크를 사용하며, 가장 기본적인 입문 과정을 포함하여, 주로 여러분의 🧐빠른 입문🧐을 돕기 위함입니다.
디렉터리 구조는 세 부분으로 나뉩니다:
- **LangChain_RAG 폴더**: RAG 관련 프로젝트 데모와 학습 자료;
- **LangChain_Agent 폴더**: Agent 관련 데모와 학습 자료;
- **Interview**: 대형 모델 RAG와 Agent 면접 필수문제.

# ✅ LangChain_RAG

본 부분은 총 **네 부분**으로 구성됩니다:
- llms-1과 llms-2는 Bilibili의 🕶️**입문 강의**🕶️로, 두 명의 업로더가 명확하고 간결하게 설명하며, 주로 입문 이해용으로 빠르게 보시면 됩니다;
- llms-3은 LangChain 공식에서 나온 RAG 튜토리얼로, 영상은 원본과 국내 번역본을 보여주며, RAG 과정의 주요 흐름과 최적화 포인트를 설명합니다. **🔥이 부분을 중점적으로 보시길 권장하며, 면접에서 많은 최적화 질문이 나옵니다🔥**;
- llms-4는 LangChain 공식에서 제공하는 **💡RAG 프로젝트💡** 예제로, 가장 기본적인 RAG 프로젝트 흐름을 포함해 즉시 실행할 수 있고 코드 구조가 매우 간단합니다.

## llms-1
### 영상 주소（전체 시리즈 시청）：
- https://www.bilibili.com/video/BV1qC4y1F7Dy
### 코드：
- 🌹코드 주소（실행 가능한 버전）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-1/
  - note（✅이 버전 다운로드 및 실행 권장✅）：본인이 실행한 코드로 일부 패키지 업데이트 포함（원저자 코드 일부 패키지 만료）
  - original：원저자 코드（원본 코드 위치, 권장하지 않음, 패키지 업데이트 필요 가능성）
- 원본 코드 위치：https://github.com/blackinkkkxi/RAG_langchain/tree/main   
- 실행 환경：langchain_hf 제외 모든 환경에서 Colab 실행 가능; Kaggle에서도 실행 가능, Kaggle 입문 참고：[무료 클라우드 컴퓨팅, 적지만 충분함——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；
## llms-2
### 영상 주소（단편 시청 가능）：
- https://www.bilibili.com/video/BV1Cp421R7Y7
### 코드：
- 🌹코드 주소（실행 가능한 버전）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-2/
  - note（✅이 버전 다운로드 및 실행 권장✅）：본인이 실행한 코드로 일부 패키지 업데이트 포함（원저자 코드 일부 패키지 만료）
  - original：원저자 코드（원본 코드 위치, 권장하지 않음, 패키지 업데이트 필요 가능성）
- 원본 코드 위치：https://github.com/owenliang/rag-retrieval/tree/main  
- 실행 환경：Kaggle 실행 가능, Kaggle 입문 참고：[무료 클라우드 컴퓨팅, 적지만 충분함——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；
## llms-3
### 영상 주소（전체 시리즈 시청）：
- 해외 원본 영상（영문）：https://www.youtube.com/playlist?list=PLfaIDFEXuae2LXbO1_PKyVJiQ23ZztA0x
- 국내 중국어 버전：https://www.bilibili.com/video/BV1dm41127jc/
### 코드：
- 🌹코드 주소（실행 가능한 버전）：https://github.com/lichuachua/llms-project/tree/main/LangChain_RAG/llms-3/
  - note（✅이 버전 다운로드 후 실행 권장✅）：본인이 코드 실행, 일부 패키지 업데이트 필요(원작자 코드 일부 패키지 만료)
  - original：원작자 코드(원 코드 주소와 동일, 권장하지 않음, 패키지 업데이트 필요할 수 있음)
  - PPT：공식 영상에 해당하는 PPT
- 코드 원주소：https://github.com/langchain-ai/rag-from-scratch/tree/main  
- 실행 플랫폼：Kaggle에서 실행, Kaggle 입문 참고：[무료 연산 자원 활용, 적지만 충분함——Kaggle](https://mp.weixin.qq.com/s/SK5VXzx2zijzjc8OYJICKA)；
## llms-4
### 코드：
- 🌹코드 주소（✅본인이 수정한 코드, 바로 실행 가능✅）：https://github.com/lichuachua/chat-langchain-study/
- 코드 원주소（실행에 문제 있음, 직접 수정 필요）：https://github.com/langchain-ai/chat-langchain
### 설명：
- langchain-chat은 공식에서 제공하는 RAG 프로젝트 예제로, 제가 추천하는 입문용 프로젝트입니다. 네티즌 요청에 따라 손쉽게 실행할 수 있는 영상도 제작했습니다.
### 참고 자료：
- https://www.bilibili.com/video/BV1eB4y1Z752/
- https://github.com/webup/agi-talks/blob/master/301-langchain-chatdoc/src/slides.md
- https://blog.langchain.dev/building-chat-langchain-2/
            

# ✅ LangChain_Agent

본 부분은 총 **두 부분**으로, Bilibili에 올라온 두 개의 간단한 Agent 데모이며, 이해하기 쉽습니다.
- AI_Agent는 OPENAI_API 기반
- QW_Agent는 QWen_API 기반


## AI_Agent
### 영상 주소：
- https://www.bilibili.com/video/BV1JV411F7Yj/
### 코드：
- 🌹코드 주소（✅본인이 수정한 코드, 바로 실행 가능✅）：https://github.com/lichuachua/llms-project/tree/main/LangChain_Agents/AI_Agent/
- 코드 원주소：https://github.com/parallel75/AI_Agent  
- 실행 플랫폼：로컬

## QW_Agent
### 영상 주소：
- https://www.bilibili.com/video/BV1QF4m177Rx/
### 설명：
- 이 프로젝트 실행 시 【Qianwen 관련 key와 api】 신청이 필요하며, 난관이 있습니다. 본인이 수정한 코드를 다운로드하는 것을 권장하며 바로 실행 가능합니다. Qianwen 최신 버전은 코드 업데이트가 필요하며, 제가 수정했습니다.
### 코드：
- 🌹코드 주소（✅본인이 수정한 코드로 바로 실행 가능✅）：https://github.com/lichuachua/llms-project/blob/main/LangChain_Agents/QW_Agent/
- 코드 원본（실행에 문제 있어 직접 수정 필요）：https://github.com/owenliang/agent
- 실행 플랫폼：로컬

# ✅ 인터뷰
이 부분은 두 부분의 인터뷰 정형문으로, 본인이 구직 기간에 수집하고 정리한 대형 모델 응용 개발 정형문입니다. 본인이 직접 테스트했으며, 이를 통해 일부 대기업 **고급 AI 연구 개발 엔지니어** 관련 직무를 찾을 수 있었습니다.
- [대형 모델 응용 개발 정형문](https://mp.weixin.qq.com/mp/appmsgalbum?__biz=Mzk1NzgzMjY3OQ==&action=getalbum&album_id=3987723560113356813&scene=126&uin=&key=&devicetype=iMac+MacBookPro18%2C3+OSX+OSX+15.4.1+build(24E263)&version=13080a10&lang=zh_CN&nettype=WIFI&ascene=78&fontScale=100)
## RAG
- 대형 모델(LLMs) RAG 검색 강화 생성 학습 / 인터뷰 중 마주칠 수 있는 지식 포인트를 상세히 소개하며, 전체 4만자 이상 분량으로 처리 절차에 따라 정리: [대형 모델 RAG 지식 노트](https://mp.weixin.qq.com/s/zmUTGAMoljXSmnoo_cBQig)
## Agent
- 대형 모델(LLMs) 지능형 에이전트 Agent 학습 / 인터뷰 중 마주칠 수 있는 지식 포인트를 상세히 소개하며, 전체 1만자 이상 분량으로 모듈별로 정리: [대형 모델 Agent 지식 노트](https://mp.weixin.qq.com/s/TSioLS_RhrX57YEnY3mkag)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-03

---