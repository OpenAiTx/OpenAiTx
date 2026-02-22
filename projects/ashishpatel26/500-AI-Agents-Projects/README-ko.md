# 🌟 500+ AI 에이전트 프로젝트 / 사용 사례

[![500-AI-Agents-Projects - UseCase](https://img.shields.io/badge/500--AI--Agents--Projects-UseCase-2ea44f?logo=https%3A%2F%2Fstatic-00.iconduck.com%2Fassets.00%2Frobot-emoji-2048x2044-kay057lt.png&logoColor=2ea44f)](https://github.com/ashishpatel26/500-AI-Agents-Projects)

![img](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/images/AIAgentUseCase.jpg)

산업 전반에 걸친 AI 에이전트 사용 사례를 엄선하여 실용적인 응용 사례와 구현을 위한 오픈 소스 프로젝트 링크를 제공합니다. AI 에이전트가 의료, 금융, 교육 등 다양한 산업을 어떻게 혁신하고 있는지 탐구해보세요! 🤖✨

---

## 📋 목차

- [소개](#introduction)
- [산업 사용 사례](#-industry-usecase-mindmap)
- [사용 사례 표](#use-case-table)
- [프레임워크별 사용 사례](#framework-wise-usecases)
  - [CrewAI 사용 사례](#framework-name-crewai)
  - [AutoGen 사용 사례](#framework-name-autogen)
  - [Agno 사용 사례](#framework-name-agno)
  - [Langgraph 사용 사례](#framework-name-langgraph)
- [기여하기](#contributing)
- [라이선스](#license)

---

## 🧠 소개

인공지능(AI) 에이전트는 산업 운영 방식을 혁신하고 있습니다. 개인화된 학습부터 금융 거래 봇에 이르기까지, AI 에이전트는 효율성, 혁신성, 확장성을 제공합니다. 이 저장소는 다음을 제공합니다:

- AI 에이전트가 영향을 미치고 있는 산업의 분류된 목록.
- 구현을 위한 오픈 소스 프로젝트 링크가 포함된 상세한 사용 사례.

개발자, 연구자, 비즈니스 관심자 누구든 이 저장소는 AI 에이전트 영감과 학습을 위한 최고의 자료입니다.

---

## 🏭 산업 사용 사례 마인드맵

![](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/images/industry_usecase1.png)

---

## 🧩 사용 사례 표

| 사용 사례                                   | 산업              | 설명                                                      | 코드 깃허브                                                                                                                                                                          |
| ------------------------------------------- | ----------------- | --------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| **HIA (Health Insights Agent)**       | 의료               | 의료 보고서를 분석하고 건강 인사이트를 제공합니다.          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/harshhh28/hia.git)                                                                             |
| **AI Health Assistant**               | 의료               | 환자 데이터를 사용하여 질병을 진단하고 모니터링합니다.         | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/ahmadvh/AI-Agents-for-Medical-Diagnostics.git)                                                 |
| **Automated Trading Bot**             | 금융               | 실시간 시장 분석으로 주식 거래를 자동화합니다.                | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MingyuJ666/Stockagent.git)                                                                     |
| **Virtual AI Tutor**                  | 교육               | 사용자에 맞춘 개인화된 교육을 제공합니다.                     | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/hqanhh/EduGPT.git)                                                                             |
| **24/7 AI Chatbot**                   | 고객 서비스         | 24시간 고객 문의를 처리합니다.                                | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/NirDiamant/GenAI_Agents/blob/main/all_agents_tutorials/customer_support_agent_langgraph.ipynb) |
| **Product Recommendation Agent**      | 소매               | 사용자 취향과 이력을 기반으로 제품을 추천합니다.                | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/microsoft/RecAI)                                                                               |
| **Self-Driving Delivery Agent**       | 운송               | 경로를 최적화하고 자율적으로 패키지를 배송합니다.              | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/sled-group/driVLMe)                                                                            |
| **Factory Process Monitoring Agent**  | 제조               | 생산 라인을 모니터링하고 품질 관리를 보장합니다.                | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/yuchenxia/llm4ias)                                                                             |
| **Property Pricing Agent**            | 부동산              | 시장 동향을 분석하여 부동산 가격을 산정합니다.                  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/AleksNeStu/ai-real-estate-assistant)                                                           |
| **Smart Farming Assistant**           | 농업               | 작물 건강 및 수확량 예측에 대한 인사이트를 제공합니다.          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/mohammed97ashraf/LLM_Agri_Bot)                                                                 |
| **Energy Demand Forecasting Agent**   | 에너지             | 에너지 사용량을 예측하여 그리드 관리를 최적화합니다.             | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/yecchen/MIRAI)                                                                                 |
| **Content Personalization Agent**     | 엔터테인먼트        | 사용자 취향에 맞춘 개인화된 미디어를 추천합니다.                  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/crosleythomas/MirrorGPT)                                                                       |
| **Legal Document Review Assistant**   | 법률               | 문서 검토를 자동화하고 주요 조항을 강조합니다.                   | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/firica/legalai)                                                                                |
| **Recruitment Recommendation Agent**  | 인사               | 채용 공고에 적합한 후보자를 추천합니다.                         | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/sentient-engineering/jobber)                                                                   |
| **Virtual Travel Assistant**          | 환대               | 사용자 선호에 맞춘 여행 일정 계획을 제공합니다.                  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/nirbar1985/ai-travel-agent)                                                                    |
| **AI Game Companion Agent**           | 게임               | 실시간 지원으로 플레이어 경험을 향상시킵니다.                    | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/onjas-buidl/LLM-agent-game)                                                                    |
| **Real-Time Threat Detection Agent**  | 사이버 보안          | 잠재적 위협을 식별하고 공격을 완화합니다.                        | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/NVISOsecurity/cyber-security-llm-agents)                                                       |
| **E-commerce Personal Shopper Agent** | 전자 상거래          | 고객이 좋아할 제품을 찾도록 도와줍니다.                          | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/Hoanganhvu123/ShoppingGPT)                                                                     |
| **Logistics Optimization Agent**      | 공급망              | 효율적인 배송 경로를 계획하고 재고를 관리합니다.                  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/microsoft/OptiGuide)                                                                           |
| **Vibe Hacking Agent**                | 사이버 보안          | 자율 다중 에이전트 기반 레드 팀 테스트 서비스입니다.              | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/PurpleAILAB/Decepticon) |
| **MediSuite-Ai-Agent**  | 건강 보험           | 병원/보험 청구 워크플로우 자동화를 돕는 의료 AI 에이전트입니다.  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MahmoudRabea13/MediSuite-Ai-Agent)                                         | 
| **Lina-Egyptian-Medical-Chatbot**  | 건강 보험           | 병원/보험 청구 워크플로우 자동화를 돕는 의료 AI 에이전트입니다.  | [![GitHub](https://img.shields.io/badge/Code-GitHub-black?logo=github)](https://github.com/MahmoudRabea13/MediSuite-Ai-Agent)                                         |

## 프레임워크별 사용 사례

---

### **프레임워크 이름**: **CrewAI**

| 사용 사례                         | 산업                    | 설명                                                                                      | GitHub                                                                                                                                              |
| -------------------------------- | ----------------------- | ----------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📧 이메일 자동 응답 흐름          | 🗣️ 커뮤니케이션          | 사전 정의된 기준에 따라 이메일 응답을 자동화하여 커뮤니케이션 효율성을 향상시킵니다.          | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/email_auto_responder_flow) |
| 📝 회의 보조 흐름                | 🛠️ 생산성               | 회의 일정 관리 및 안건 준비를 포함하여 회의를 조직하고 관리하는 데 도움을 줍니다.             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/meeting_assistant_flow) |
| 🔄 자기 평가 루프 흐름            | 👥 인사                  | 조직 내 자기 평가 과정을 촉진하여 성과 평가에 도움을 줍니다.                                | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/self_evaluation_loop_flow) |
| 📈 리드 점수 흐름                   | 💼 영업                  | 잠재 고객을 평가하고 점수를 매겨 영업 전략에서 우선 순위를 지정합니다.                          | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/lead-score-flow)                   |
| 📊 마케팅 전략 생성기               | 📢 마케팅                | 시장 동향과 대상 고객 데이터를 분석하여 마케팅 전략을 개발합니다.                             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/marketing_strategy)                |
| 📝 채용 공고 생성기                | 🧑‍💼 채용                | 직무 요구사항을 분석하여 채용 과정을 지원하는 채용 공고를 작성합니다.                        | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/job-posting)                      |
| 🔄 채용 워크플로우                 | 🧑‍💼 채용                | 채용 과정에 포함된 다양한 업무를 자동화하여 채용 절차를 간소화합니다.                        | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/recruitment)                      |
| 🔍 프로필과 직무 매칭             | 🧑‍💼 채용                | 후보자의 프로필을 적합한 직무와 매칭하여 채용 효율성을 높입니다.                             | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/match_profile_to_positions)          |
| 📸 인스타그램 게시물 생성기         | 📱 소셜 미디어           | 인스타그램 게시물을 자동으로 생성 및 예약하여 소셜 미디어 관리를 간소화합니다.              | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/instagram_post)                    |
| 🌐 랜딩 페이지 생성기              | 💻 웹 개발               | 웹사이트용 랜딩 페이지 생성을 자동화하여 웹 개발 업무를 지원합니다.                          | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/landing_page_generator)             |
| 🎮 게임 빌더 크루                 | 🎮 게임 개발             | 게임 제작의 일부 단계를 자동화하여 게임 개발을 지원합니다.                                  | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/game-builder-crew)                |
| 💹 주식 분석 도구                 | 💰 금융                  | 주식 시장 데이터를 분석하는 도구를 제공하여 금융 의사결정을 지원합니다.                      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/stock_analysis)                    |
| 🗺️ 여행 플래너                   | ✈️ 여행                  | 여행 일정 구성과 여행 세부사항 관리를 지원하여 여행 계획을 돕습니다.                        | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/trip_planner)                      |
| 🎁 깜짝 여행 플래너               | ✈️ 여행                  | 사용자 선호에 따라 목적지와 활동을 선정하여 깜짝 여행을 계획합니다.                         | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/surprise_trip)                     |
| 📚 흐름을 활용한 책 쓰기          | ✍️ 창작 글쓰기           | 구조화된 워크플로우와 글쓰기 지원을 제공하여 저자의 책 쓰기를 돕습니다.                     | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/flows/write_a_book_with_flows)           |
| 🎬 시나리오 작가                 | ✍️ 창작 글쓰기           | 대본 개발을 위한 템플릿과 지침을 제공하여 시나리오 작성에 도움을 줍니다.                   | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/screenplay_writer)                  |
| ✅ 마크다운 검증기               | 📄 문서화                | 마크다운 파일을 검증하여 올바른 형식과 표준 준수를 보장합니다.                            | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/markdown_validator)                 |
| 🧠 메타 퀘스트 지식              | 📚 지식 관리             | 메타 퀘스트 관련 지식을 관리 및 조직하여 정보 검색을 용이하게 합니다.                      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/meta_quest_knowledge)               |
| 🤖 NVIDIA 모델 통합              | 🤖 AI 통합               | NVIDIA AI 모델을 워크플로우에 통합하여 계산 능력을 향상시킵니다.                            | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/integrations/nvidia_models)               |
| 🗂️ 회의 준비                   | 🛠️ 생산성                | 자료 정리와 의제 설정을 통해 회의 준비를 지원합니다.                                      | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/prep-for-a-meeting)                 |
| 🛠️ 스타터 템플릿               | 🛠️ 개발                  | 새로운 프로젝트 설정 과정을 간소화하기 위한 스타터 템플릿을 제공합니다.                    | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/crews/starter_template)                   |
| 🔗 CrewAI + LangGraph 통합       | 🤖 AI 통합               | CrewAI와 LangGraph 간의 통합을 시연하여 워크플로우 자동화를 강화합니다.                   | [![GitHub](https://img.shields.io/badge/GitHub-Repository-blue)](https://github.com/crewAIInc/crewAI-examples/tree/main/integrations/CrewAI-LangGraph)             |


### **프레임워크 이름**: **Autogen**

> **코드 생성, 실행 및 디버깅**

| 사용 사례                                                                                | 산업 분야               | 설명                                                                           | 노트북                                                                                                                                                                    |
| --------------------------------------------------------------------------------------- | ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🤖 코드 생성, 실행 및 디버깅을 통한 자동화된 작업 해결                                   | 💻 소프트웨어 개발       | 코드를 생성, 실행, 디버깅하여 자동으로 작업을 해결하는 과정을 시연합니다.       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_auto_feedback_from_code_execution) |
| 🧑‍💻 검색 강화 에이전트를 이용한 자동 코드 생성 및 질문 응답                           | 💻 소프트웨어 개발       | 검색 강화 기법을 사용하여 코드를 생성하고 질문에 답변합니다.                   | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_RetrieveChat)                      |
| 🧠 Qdrant 기반 검색을 통한 자동 코드 생성 및 질문 응답                                | 💻 소프트웨어 개발       | Qdrant를 활용하여 검색 강화 에이전트 성능을 향상시킵니다.                     | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_RetrieveChat_qdrant)               |

> **다중 에이전트 협업 (>3 에이전트)**

| 사용 사례                                                      | 산업 분야                 | 설명                                                       | 노트북                                                                                                                                                             |
| :------------------------------------------------------------ | :------------------------ | :--------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🤝 그룹 채팅을 통한 자동 작업 해결 (3명 멤버, 1명 매니저)        | 🤝 협업                   | 다중 에이전트 협업을 통한 그룹 작업 해결을 시연합니다.     | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat)                  |
| 📊 그룹 채팅을 통한 자동 데이터 시각화 (3명 멤버, 1명 매니저)    | 📊 데이터 분석             | 다중 에이전트 협업으로 데이터 시각화를 수행합니다.         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_vis)              |
| 🧩 그룹 채팅을 통한 복잡한 작업 자동 해결 (6명 멤버, 1명 매니저) | 🤝 협업                   | 더 큰 그룹 에이전트와 협력하여 복잡한 작업을 해결합니다.  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_research)         |
| 🧑‍💻 코딩 및 계획 에이전트를 활용한 자동 작업 해결               | 🛠️ 기획 및 개발           | 코딩과 계획 에이전트를 결합하여 효율적으로 작업을 해결합니다.| [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_planning.ipynb)             |
| 📐 그래프에 명시된 전이 경로를 활용한 자동 작업 해결             | 🤝 협업                   | 그래프 내 사전 정의된 전이 경로를 사용하여 작업을 해결합니다.| [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/docs/notebooks/agentchat_groupchat_finite_state_machine) |
| 🧠 SocietyOfMindAgent를 통한 내적 독백으로 그룹 채팅 실행               | 🧠 인지과학                  | 그룹 채팅을 사용하여 문제 해결을 위한 내적 독백을 시뮬레이션합니다.                          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_society_of_mind)            |
| 🔧 맞춤형 화자 선택 기능을 갖춘 그룹 채팅 실행                         | 🤝 협업                      | 그룹 채팅에서 화자 선택을 위한 맞춤형 기능을 구현합니다.                                    | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_customized)       |

> **순차 다중 에이전트 채팅**

| 사용 사례                                                                      | 산업                     | 설명                                                                                | 노트북                                                                                                                                                         |
| :----------------------------------------------------------------------------- | :----------------------- | :--------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔄 단일 에이전트가 시작하는 일련의 채팅에서 다중 작업 해결                   | 🔄 워크플로우 자동화      | 단일 시작 에이전트로 순차적 작업 해결을 자동화합니다.                               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_multi_task_chats)       |
| ⏳ 단일 에이전트가 시작하는 일련의 채팅에서 비동기 다중 작업 해결            | 🔄 워크플로우 자동화      | 하나의 에이전트가 시작하는 채팅 시퀀스에서 비동기 작업 해결을 처리합니다.           | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_multi_task_async_chats) |
| 🤝 서로 다른 에이전트가 시작하는 일련의 채팅에서 다중 작업 해결              | 🔄 워크플로우 자동화      | 각 채팅을 다른 에이전트가 시작하는 순차적 작업 해결을 지원합니다.                   | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchats_sequential_chats)      |

> **중첩 채팅**

| 사용 사례                                                                     | 산업                       | 설명                                                                                 | 노트북                                                                                                                                                          |
| :----------------------------------------------------------------------------- | :------------------------- | :---------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🧠 중첩 채팅을 통한 복잡한 작업 해결                                         | 🧠 문제 해결               | 중첩 채팅을 사용하여 계층적이고 복잡한 문제를 해결합니다.                            | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat)              |
| 🔄 중첩 채팅의 순차적 사용으로 복잡한 작업 해결                             | 🧠 문제 해결               | 중첩 채팅을 이용한 순차적 작업 해결을 시연합니다.                                   | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_sequential_chats) |
| 🏭 중첩 채팅을 활용한 공급망 최적화 문제 해결을 위한 OptiGuide              | 🏭 공급망 최적화           | 중첩 채팅, 코딩 에이전트, 안전장치 에이전트를 활용한 공급망 최적화 문제 해결을 보여줍니다. | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat_optiguide)    |
| ♟️ 중첩 채팅과 도구 사용을 통한 대화형 체스                               | 🎮 게임                    | 통합 도구와 함께 대화형 체스 플레이를 위한 중첩 채팅 사용을 탐구합니다.             | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_chats_chess)      |

> **응용**

| 사용 사례                                                                                     | 산업                       | 설명                                                                                   | 노트북                                                                                                                                                       |
| :--------------------------------------------------------------------------------------------- | :------------------------- | :------------------------------------------------------------------------------------ | :----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔄 새로운 데이터로부터 자동화된 지속 학습                                                     | 📊 머신러닝                | 새로운 데이터 입력으로부터 지속적으로 학습하여 적응형 AI를 구현합니다.                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_stream.ipynb)         |
| 🏭 OptiGuide - 코딩, 도구 사용, 안전장치 및 공급망 최적화를 위한 질문 응답                   | 🏭 공급망 최적화           | 코딩, 도구 사용, 안전장치를 결합한 공급망 최적화 솔루션을 강조합니다.                | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nestedchat_optiguide) |
| 🤖 AutoAnny - AutoGen으로 구축된 디스코드 봇                                               | 💬 커뮤니케이션 도구       | 향상된 상호작용을 위해 AutoGen을 사용하여 개발된 디스코드 봇을 보여줍니다.          | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/tree/main/samples/apps/auto-anny)                 |

> **도구**

| 사용 사례                                                         | 산업                         | 설명                                                                                 | 노트북                                                                                                                                                                          |
| :----------------------------------------------------------------- | :--------------------------- | :---------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| 🌐 웹 검색: 웹 정보가 필요한 작업 해결                             | 🔍 정보 검색                 | 작업 완료에 필요한 정보를 수집하기 위해 웹을 검색합니다.                             | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_web_info.ipynb)                          |
| 🔧 제공된 도구를 함수로 사용                                      | 🛠️ 도구 통합                | AutoGen에서 미리 제공된 도구를 호출 가능한 함수로 사용하는 방법을 시연합니다.         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_function_call_currency_calculator)       |
| 🔗 동기 및 비동기 함수 호출을 통한 도구 사용                      | 🛠️ 도구 통합                | AutoGen 워크플로우 내에서 동기 및 비동기 도구 사용 방법을 설명합니다.                 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_function_call_async)                     |
| 🧩 Langchain 제공 도구를 함수로 사용한 작업 해결                  | 🔍 언어 처리                 | AutoGen 내에서 작업 해결을 위해 Langchain 도구를 활용합니다.                         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_langchain.ipynb)                         |
| 📚 RAG: 검색 증강 생성이 적용된 그룹 채팅                         | 🤝 협업                     | 정보 공유를 지원하기 위해 검색 증강 생성(RAG)이 적용된 그룹 채팅을 구현합니다.       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_groupchat_RAG)                           |
| ⚙️ 함수 인셉션: 대화 중 함수 업데이트/제거                       | 🔧 개발 도구                | 대화 중 AutoGen 에이전트가 동적으로 함수를 수정할 수 있도록 합니다.                 | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_inception_function.ipynb)                |
| 🔊 Whisper와 함께하는 에이전트 채팅                              | 🎙️ 오디오 처리             | Whisper를 사용한 필사 및 번역 기능을 보여주는 AI 에이전트 기능을 시연합니다.         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_video_transcript_translate_with_whisper) |
| 📏 가이드라인을 통한 응답 제약                                   | 💡 자연어 처리              | 에이전트가 생성하는 응답을 제약하기 위해 가이던스를 사용하는 방법을 보여줍니다.      | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_guidance.ipynb)                          |
| 🌍 에이전트와 함께 웹 탐색                                          | 🌐 정보 검색                 | 에이전트를 구성하여 웹에서 정보를 탐색하고 검색하는 방법을 설명합니다.                             | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_surfer.ipynb)                            |
| 📊 SQL: Spider 벤치마크를 사용한 자연어 텍스트를 SQL 쿼리로 변환      | 💾 데이터베이스 관리          | Spider 벤치마크를 사용하여 자연어 입력을 SQL 쿼리로 변환합니다.                                  | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_sql_spider.ipynb)                        |
| 🕸️ Apify를 사용한 웹 스크래핑                                       | 🌐 데이터 수집               | AutoGen을 사용하여 Apify로 웹 스크래핑 기법을 설명합니다.                                        | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_webscraping_with_apify)                  |
| 🕷️ 웹 크롤링: Spider API로 도메인 전체 크롤링                       | 🌐 데이터 수집               | Spider API를 사용하여 도메인 전체를 크롤링하는 방법을 설명합니다.                                 | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_webcrawling_with_spider)                 |
| 💻 특별히 설계된 함수로 작업별 소프트웨어 앱 작성                    | 💻 소프트웨어 개발             | 설계된 함수를 사용하여 단계별로 소프트웨어 애플리케이션을 구축합니다.                            | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_function_call_code_writing.ipynb)        |

> **인간 개발**

| 사용 사례                                                         | 산업                       | 설명                                                                                       | 노트북                                                                                                                                                      |
| :--------------------------------------------------------------- | :------------------------- | :----------------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 💬 ChatGPT 스타일의 간단한 예제                                   | 🧠 대화형 AI               | ChatGPT 스타일의 간단한 대화 예제를 시연합니다.                                           | [![예제](https://img.shields.io/badge/View-Example-blue?logo=openai)](https://github.com/microsoft/autogen/blob/0.2/samples/simple_chat.py)                   |
| 🤖 자동 코드 생성, 실행, 디버깅 및 인간 피드백                     | 💻 소프트웨어 개발           | 인간 피드백이 통합된 코드 생성, 실행, 디버깅 워크플로우를 보여줍니다.                      | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_human_feedback.ipynb) |
| 👥 GPT-4 + 다중 인간 사용자를 통한 자동화된 작업 해결              | 🤝 협업                    | 다중 인간 사용자가 GPT-4와 협력하여 작업을 해결할 수 있도록 합니다.                        | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_two_users.ipynb)      |
| 🔄 비동기 인간 입력이 포함된 에이전트 채팅                        | 🧠 대화형 AI               | 에이전트 대화 중 비동기 인간 입력을 지원합니다.                                           | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/Async_human_input.ipynb)        |

> **에이전트 교육 및 학습**

| 사용 사례                                                             | 산업                       | 설명                                                                                   | 노트북                                                                                                                                                      |
| :------------------------------------------------------------------- | :------------------------- | :------------------------------------------------------------------------------------ | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📘 자동화된 채팅을 통한 에이전트 새로운 기술 교육 및 재사용           | 🎓 교육 및 훈련              | 에이전트에게 새로운 기술을 가르치고 자동화된 채팅에서 재사용할 수 있게 하는 방법을 시연합니다. | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_teaching)           |
| 🧠 코딩 외 새로운 사실, 사용자 선호 및 기술을 에이전트에게 교육       | 🎓 교육 및 훈련              | 에이전트에게 새로운 사실, 사용자 선호 및 코딩 외 기술을 가르치는 방법을 보여줍니다.       | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_teachability)         |
| 🤖 GPTAssistantAgent를 통한 OpenAI 어시스턴트 교육                   | 💻 AI 어시스턴트 개발         | GPTAssistantAgent를 사용하여 OpenAI 어시스턴트의 기능을 향상시키는 방법을 설명합니다.    | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_teachable_oai_assistants.ipynb) |
| 🔄 에이전트 최적화기: 에이전트를 에이전틱 방식으로 훈련               | 🛠️ 최적화                   | 에이전트 최적화기를 사용하여 에이전트를 에이전틱한 방식으로 효과적으로 훈련하는 방법을 설명합니다. | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_agentoptimizer.ipynb)     |

> **OpenAI 어시스턴트가 포함된 다중 에이전트 채팅**

| 사용 사례                                                  | 산업                       | 설명                                                                                  | 노트북                                                                                                                                                              |
| :-------------------------------------------------------- | :------------------------- | :----------------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🌟 AutoGen에서 OpenAI 어시스턴트와 하는 Hello-World 채팅  | 🤖 대화형 AI               | AutoGen을 사용하여 OpenAI 어시스턴트와 채팅하는 기본 예제입니다.                     | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_twoagents_basic.ipynb) |
| 🔧 함수 호출을 사용한 OpenAI 어시스턴트와 채팅             | 🔧 개발 도구                | 채팅에서 OpenAI 어시스턴트의 함수 호출 사용법을 설명합니다.                          | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_function_call.ipynb)   |
| 🧠 코드 인터프리터가 포함된 OpenAI 어시스턴트와 채팅        | 💻 소프트웨어 개발           | 채팅에서 OpenAI 어시스턴트를 코드 인터프리터로 사용하는 방법을 보여줍니다.           | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_code_interpreter.ipynb)          |
| 🔍 검색 증강과 함께하는 OpenAI 어시스턴트와 채팅            | 📚 정보 검색                | OpenAI 어시스턴트와 검색 증강 대화를 가능하게 합니다.                               | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_retrieval.ipynb)       |
| 🤝 그룹 채팅에서 OpenAI 어시스턴트                          | 🤝 협업                    | OpenAI 어시스턴트가 다른 에이전트와 그룹 채팅에서 협업하는 방법을 보여줍니다.        | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_oai_assistant_groupchat.ipynb)       |
| 🛠️ GPTAssistantAgent 기반 다중 에이전트 도구 사용          | 🔧 개발 도구                | GPTAssistantAgent를 사용한 다중 에이전트 도구 사용법을 설명합니다.                   | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/gpt_assistant_agent_function_call.ipynb)       |

> **비-OpenAI 모델**

| 사용 사례                                          | 산업      | 설명                                                                | 노트북                                                                                                                                                      |
| :------------------------------------------------ | :-------- | :----------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ♟️ 비-OpenAI 모델을 사용한 대화형 체스              | 🎮 게임    | 비-OpenAI 모델로 구현된 대화형 체스를 탐구합니다.                  | [![노트북](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_nested_chats_chess_altmodels) |
> **멀티모달 에이전트**

| 사용 사례                                     | 산업 분야           | 설명                                                                                 | 노트북                                                                                                                                                         |
| :------------------------------------------- | :------------------ | :---------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🎨 DALLE와 GPT-4V를 활용한 멀티모달 에이전트 채팅 | 🖼️ 멀티미디어 AI    | DALLE와 GPT-4V를 결합하여 멀티모달 에이전트 통신을 구현합니다.                       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_dalle_and_gpt4v.ipynb) |
| 🖌️ Llava를 활용한 멀티모달 에이전트 채팅    | 📷 이미지 처리       | Llava를 사용하여 이미지 처리와 함께 멀티모달 에이전트 대화를 가능하게 합니다.       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_lmm_llava.ipynb)       |
| 🖼️ GPT-4V를 활용한 멀티모달 에이전트 채팅    | 🖼️ 멀티미디어 AI    | GPT-4V를 활용하여 시각적 및 대화형 멀티모달 에이전트 상호작용을 제공합니다.         | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_lmm_gpt-4v.ipynb)      |

> **장기 컨텍스트 처리**

| 사용 사례                             | 산업 분야          | 설명                                                                                   | 노트북                                                                                                                                                      |
| :----------------------------------- | :----------------- | :------------------------------------------------------------------------------------ | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📜 장기 컨텍스트 처리를 기능으로 구현 | 🧠 AI 기능          | AI 워크플로우 내에서 장기 컨텍스트를 효과적으로 처리하는 기법을 시연합니다.            | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/notebooks/agentchat_transform_messages) |

> **평가 및 검증**

| 사용 사례                                                                 | 산업 분야               | 설명                                                                                     | 노트북                                                                                                                                                   |
| :------------------------------------------------------------------------- | :---------------------- | :-------------------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📊 AgentEval: LLM 기반 애플리케이션 유용성 평가를 위한 다중 에이전트 시스템 | 📈 성능 평가             | LLM 기반 애플리케이션의 성능을 평가하고 검증하기 위한 AgentEval을 소개합니다.             | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agenteval_cq_math.ipynb) |

> **자동 에이전트 구축**

| 사용 사례                                                        | 산업 분야          | 설명                                                                                   | 노트북                                                                                                                                                     |
| :-------------------------------------------------------------- | :----------------- | :------------------------------------------------------------------------------------ | :----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🏗️ AgentBuilder를 이용한 다중 에이전트 시스템 자동 구축          | 🤖 AI 개발          | AgentBuilder 도구를 사용하여 다중 에이전트 시스템을 자동으로 구축하는 방법을 설명합니다. | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/autobuild_basic.ipynb)         |
| 📚 에이전트 라이브러리로부터 다중 에이전트 시스템 자동 구축       | 🤖 AI 개발          | 사전 정의된 에이전트 라이브러리를 활용하여 다중 에이전트 시스템을 구축하는 방법을 소개합니다. | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/autobuild_agent_library.ipynb) |

> **관측 가능성**

| 사용 사례                                                        | 산업 분야              | 설명                                                                                   | 노트북                                                                                                                                                |
| :-------------------------------------------------------------- | :--------------------- | :------------------------------------------------------------------------------------ | :---------------------------------------------------------------------------------------------------------------------------------------------------- |
| 📊 AgentOps를 사용하여 LLM 호출, 도구 사용, 액션 및 오류 추적    | 📈 모니터링 및 분석     | AgentOps를 활용하여 LLM 상호작용, 도구 사용 및 오류를 모니터링하는 방법을 시연합니다. | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_agentops.ipynb) |

> **향상된 추론**

| 사용 사례                                                     | 산업 분야           | 설명                                                                                     | 노트북                                                                                                                                                                      |
| :----------------------------------------------------------- | :----------------- | :-------------------------------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🔗 API 통합                                                   | 🔧 API 관리         | 문서와 코드 예제를 통해 API 사용을 통합하는 방법을 설명합니다.                          | [![Documentation](https://img.shields.io/badge/View-Documentation-blue?logo=readthedocs)](https://microsoft.github.io/autogen/docs/Use-Cases/enhanced_inference/#api-unification) |
| ⚙️ API 구성을 효과적으로 관리하는 유틸리티 함수               | 🔧 API 관리         | API 구성을 보다 효과적으로 관리할 수 있는 유틸리티 함수를 시연합니다.                  | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://microsoft.github.io/autogen/0.2/docs/topics/llm_configuration)                                |

| 💰 비용 계산                                                         | 📈 비용 관리          | LLM 상호작용을 위한 토큰 사용량 추적 및 비용 추정 방법을 소개합니다.                                               | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/agentchat_cost_token_tracking.ipynb)           |
| ⚡ 코드 생성 최적화                                                 | 📊 최적화             | LLM으로 코드 생성 성능을 향상시키기 위한 비용 효율적인 최적화 기법을 강조합니다.                                   | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/oai_completion.ipynb)                          |
| 📐 수학 최적화                                                     | 📊 최적화             | 수학 문제 해결을 위한 LLM 성능 최적화 기법을 설명합니다.                                                       | [![Notebook](https://img.shields.io/badge/View-Notebook-blue?logo=jupyter)](https://github.com/microsoft/autogen/blob/0.2/notebook/oai_chatgpt_gpt4.ipynb)                        |

### **프레임워크 이름**: **Agno**

> **사용 사례**

| 사용 사례                         | 산업 분야                                          | 설명                                                                                                                                                                                                                                               | 노트북                                                                                                                                                                                                          |
| :-------------------------------- | :------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| 🤖 지원 에이전트                 | 💻 소프트웨어 개발 / AI / 프레임워크 지원           | Agno 지원 에이전트는 개발자들이 Agno 프레임워크를 실시간 답변, 설명 및 코드 예제 제공을 통해 지원합니다.                                                                                                 | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/agno_support_agent.py)         |
| 🎥 유튜브 에이전트               | 📺 미디어 및 콘텐츠                                 | AI 도구를 사용해 유튜브 영상을 상세 요약, 타임스탬프, 주제 및 콘텐츠 분해를 생성하는 지능형 에이전트입니다.                                                                                                  | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/youtube_agent.py)              |
| 📊 금융 에이전트                 | 💼 금융                                            | 실시간 주식 시장 인사이트, 애널리스트 추천, 금융 심층 분석 및 업종별 트렌드를 제공하는 고급 AI 기반 시장 분석가입니다. AAPL, TSLA, NVDA 등 기업의 상세 분석 프롬프트를 지원합니다.                         | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/thinking_finance_agent.py)     |
| 📚 학습 파트너                 | 🎓 교육                                            | 사용자가 학습할 수 있도록 자료 검색, 질문 답변, 학습 계획 수립을 지원합니다.                                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/study_partner.py)              |
| 🛍️ 쇼핑 파트너 에이전트          | 🏬 전자상거래                                     | 아마존, 플립카트 등 신뢰받는 플랫폼에서 사용자의 선호도를 바탕으로 적합한 제품을 추천하는 제품 추천 에이전트입니다.                                                                                                  | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/shopping_partner.py)           |
| 🎓 연구 학자 에이전트             | 🧠 교육 / 연구                                    | 최신 출판물 분석, 학제간 연구 결과 종합, 인용을 포함한 체계적인 학술 보고서 작성 등 고급 학술 지원 AI 에이전트입니다.                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/research_agent_exa.py)         |
| 🧠 연구 에이전트                 | 🗞️ 미디어 및 저널리즘                           | 웹 검색과 전문 저널리즘 글쓰기를 결합한 연구 에이전트로, 심층 조사와 뉴욕타임즈 스타일의 보고서를 작성합니다.                                                                                                    | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/research_agent.py)             |
| 🍳 레시피 크리에이터             | 🍽️ 음식 및 요리                                  | 재료, 선호도, 시간 제약에 따른 맞춤형 레시피를 제공하는 AI 기반 레시피 추천 에이전트입니다.                                                                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/recipe_creator.py)             |
| 🗞️ 금융 에이전트               | 💼 금융                                            | 실시간 주식 데이터, 애널리스트 인사이트, 기업 기초 정보, 시장 뉴스를 통합한 강력한 금융 분석 에이전트입니다. Apple, Tesla, NVIDIA와 반도체, 자동차 등 업종 분석에 적합합니다.                            | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/finance_agent.py)              |
| 🧠 금융 추론 에이전트             | 📈 금융                                            | Claude-3.5 Sonnet 기반 에이전트를 사용하여 NVDA 등 주식을 추론 도구와 Yahoo Finance 데이터를 활용해 분석합니다.                                                                                          | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/reasoning_finance_agent.py)    |
| 🤖 Readme 생성 에이전트           | 💻 소프트웨어 개발                                | 리포지토리 메타데이터를 활용하여 GitHub 저장소용 고품질 README를 생성하는 에이전트입니다.                                                                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/readme_generator.py)           |
| 🎬 영화 추천 에이전트             | 🎥 엔터테인먼트                                  | Exa와 GPT-4o를 사용해 장르, 주제, 최신 평점을 분석하여 개인 맞춤형 영화 추천을 제공하는 지능형 에이전트입니다.                                                                                         | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/movie_recommedation.py)        |
| 🔍 미디어 트렌드 분석 에이전트      | 📰 미디어 및 뉴스                                 | AI 기반 에이전트와 스크래핑을 활용해 디지털 플랫폼에서 떠오르는 트렌드, 패턴, 인플루언서를 분석합니다.                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/media_trend_analysis_agent.py) |
| ⚖️ 법률 문서 분석 에이전트         | 🏛️ 법률 기술                                    | PDF URL에서 법률 문서를 분석하고, 벡터 임베딩과 GPT-4o를 활용한 지식 기반을 통해 법률 인사이트를 제공하는 AI 에이전트입니다.                                                                             | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/legal_consultant.py)           |
| 🤔 딥 지식                       | 🧠 연구                                            | 복잡한 질의를 하위 질문으로 분해하고 지식 베이스를 반복 탐색하여 포괄적인 답변을 합성하는 에이전트입니다. Agno 문서를 예시로 사용하며 심층 추론과 탐색을 위해 설계되었습니다.                             | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/deep_knowledge.py)             |
| 📚 도서 추천 에이전트             | 🧠 출판 및 미디어                                  | 문학 데이터, 독자 선호, 리뷰, 출간 정보를 기반으로 개인 맞춤형 도서 추천을 제공하는 지능형 에이전트입니다.                                                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/book_recommendation.py)        |
| 🏠 MCP 에어비앤비 에이전트        | 🛎️ 환대 산업                                    | MCP와 Llama 4를 사용하여 작업 공간 및 교통 접근성 등 필터 조건으로 에어비앤비 매물을 검색하는 AI 에이전트를 만듭니다.                                                                               | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/airbnb_mcp.py)                 |
| 🤖 지원 에이전트                 | 🧠 AI 프레임워크                                  | GPT-4o를 사용하여 하이브리드 검색과 임베디드 지식으로 Agno 프레임워크 관련 질문에 답변하는 AI 에이전트입니다.                                                                                         | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/agno-agi/agno/blob/main/cookbook/examples/agents/agno_assist.py)                |

### **프레임워크 이름**: **Langgraph**

> **사용 사례**

| 사용 사례                           | 산업 분야                    | 설명                                                         | 노트북                                                       |
| :--------------------------------- | :---------------------------- | :------------------------------------------------------------ | :------------------------------------------------------------ |
| 🤖 챗봇 시뮬레이션 평가             | 💻 💬 AI / 품질 보증          | 사용자 상호작용을 시뮬레이션하여 챗봇 성능을 평가하고 실제 환경에서 견고성과 신뢰성을 보장합니다.                          | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/chatbot-simulation-evaluation/agent-simulation-evaluation.ipynb) |
| 🧠 프롬프트를 통한 정보 수집        | 🧠 AI / 연구 개발             | 효과적인 정보 수집을 위해 프롬프트 기법을 활용하는 LangGraph 워크플로우 설계법을 시연합니다. 지능형 에이전트 구축을 위한 프롬프트 구조화 및 흐름 관리 방법을 보여줍니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/chatbots/information-gather-prompting.ipynb) |
| 🧠 LangGraph를 활용한 코드 어시스턴트 | 💻 소프트웨어 개발             | LangGraph를 사용해 코드 생성, 오류 검사, 반복 개선을 처리하는 그래프 기반 에이전트를 만드는 방법을 안내하며 견고하고 정확한 코딩 지원을 보장합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/code_assistant/langgraph_code_assistant.ipynb) |
| 🧑‍💼 고객 지원 에이전트             | 🧑‍💼 고객 지원 에이전트       | LangGraph를 사용해 고객 문의를 처리하고 자동화된 지원을 제공하여 사용자 경험을 향상시키는 그래프 기반 에이전트를 만드는 방법을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/customer-support/customer-support.ipynb) |
| 🔁 재시도 기능을 포함한 추출         | 🧠 AI / 데이터 추출           | LangGraph 워크플로우에서 재시도 메커니즘을 구현하여 일시적 오류를 처리하고 신뢰성을 높이는 견고한 데이터 추출 프로세스를 시연합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/extraction/retries.ipynb) |
| 🧠 다중 에이전트 워크플로우                | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph의 에이전트 감독자를 사용하여 다중 에이전트 시스템을 구축하는 방법을 보여줍니다. 여러 전문화된 에이전트를 조율하며 작업 위임과 통신 흐름을 관리하는 감독자 에이전트를 만드는 과정을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/agent_supervisor.ipynb) |
| 🧠 계층형 에이전트 팀                    | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph를 사용하여 계층형 에이전트 시스템을 구축하는 방법을 보여줍니다. 상위 감독자 에이전트를 생성하여 전문화된 하위 에이전트에 작업을 위임하고, 명확한 작업 위임과 통신으로 복잡한 워크플로우를 가능하게 하는 과정을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/hierarchical_agent_teams.ipynb) |
| 🤝 다중 에이전트 협업                   | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph를 사용하여 다중 에이전트 협업을 구현하는 방법을 보여줍니다. 여러 전문화된 에이전트가 협력하여 복잡한 작업을 수행하는 과정을 안내하며, AI 워크플로우에서 에이전트 협업의 강력함을 보여줍니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/multi_agent/multi-agent-collaboration.ipynb) |
| 🧠 계획 및 실행 에이전트                 | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph를 사용하여 "계획 및 실행" 스타일의 에이전트를 구축하는 방법을 보여줍니다. 먼저 다단계 계획을 생성하고 각 단계를 순차적으로 실행하며, 필요 시 계획을 재검토하고 수정하는 에이전트를 만드는 과정을 안내합니다. 이 접근법은 Plan-and-Solve 논문과 Baby-AGI 프로젝트에서 영감을 받아 AI 워크플로우의 장기 계획 및 작업 실행을 향상시키는 것을 목표로 합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/plan-and-execute/plan-and-execute.ipynb) |
| 🧠 SQL 에이전트                       | 🧠 AI / 데이터베이스 상호작용       | 이 튜토리얼은 SQL 데이터베이스에 대해 질문에 답할 수 있는 에이전트를 구축하는 방법을 보여줍니다. 에이전트는 사용 가능한 테이블을 가져오고, 질문과 관련성을 판단하며, 스키마를 검색하고, 쿼리를 생성, 오류 확인, 실행 후 응답을 작성합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/sql-agent.ipynb) |
| 🧠 성찰 에이전트                      | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph를 사용하여 성찰 에이전트를 구축하는 방법을 보여줍니다. 자신의 출력물을 비판하고 수정할 수 있는 에이전트를 만들어 생성된 콘텐츠의 품질과 신뢰성을 향상시키는 과정을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/reflection/reflection.ipynb)|
| 🧠 반사 에이전트                      | 🧠 AI / 워크플로우 오케스트레이션 | 이 튜토리얼은 LangGraph를 사용하여 반사 에이전트를 구축하는 방법을 보여줍니다. 자신의 행동과 결과를 반성하여 반복적인 개선과 복잡한 워크플로우에서 보다 정확한 의사결정을 가능하게 하는 에이전트를 만드는 과정을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/reflexion/reflexion.ipynb)|
| **LangGraph 에이전틱 RAG**           |                               |                                                              |                                                              |
| 🧠 **적응형 RAG**                 | 🧠 AI / 정보 검색               | 이 튜토리얼은 LangGraph를 사용하여 적응형 RAG 시스템을 구축하는 방법을 보여줍니다. 쿼리 복잡도에 따라 동적으로 검색 프로세스를 조정하여 정보 검색의 효율성과 정확성을 향상시키는 과정을 안내합니다. | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_adaptive_rag.ipynb) |
| 🧠 **적응형 RAG (로컬)**           | 🧠 AI / 정보 검색               | 이 튜토리얼은 로컬 모델을 사용하여 적응형 RAG를 구현하는 데 중점을 두며, 인터넷 연결이 제한되거나 프라이버시가 중요한 환경에서 오프라인 검색과 생성을 가능하게 합니다.                                           | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_adaptive_rag_local.ipynb) |
| 🤖 **에이전틱 RAG**               | 🤖 AI / 지능형 에이전트          | 에이전트가 응답 생성 전에 최적의 검색 전략을 결정하는 에이전틱 RAG 시스템을 구축하는 방법을 배우며, 답변의 관련성과 정확성을 향상시킵니다.                                                                          | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_agentic_rag.ipynb) |
| 🤖 **에이전틱 RAG (로컬)**         | 🤖 AI / 지능형 에이전트          | 이 튜토리얼은 에이전틱 RAG를 로컬 환경으로 확장하여 로컬 모델과 데이터 소스를 사용한 검색 및 생성 작업을 가능하게 합니다.                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_agentic_rag_local.ipynb) |
| 🧠 **교정형 RAG (CRAG)**          | 🧠 AI / 정보 검색               | 검색된 문서를 평가하고 개선하여 생성기에 전달하기 전에 더 높은 품질의 출력을 보장하는 교정형 RAG 시스템을 구현합니다.                                                                                            | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_crag.ipynb) |
| 🧠 **교정형 RAG (로컬)**          | 🧠 AI / 정보 검색               | 로컬 자원을 사용하여 오프라인 문서 평가 및 개선 프로세스를 수행하는 교정형 RAG 시스템 구축에 중점을 둡니다.                                                                                                | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_crag_local.ipynb)       |
| 🧠 **셀프 RAG**                 | 🧠 AI / 정보 검색               | 시스템이 자신의 응답을 반성하고 필요 시 추가 정보를 검색하여 생성된 콘텐츠의 정확성과 관련성을 향상시키는 셀프 RAG 구현 방법을 배웁니다.                                                              | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_self_rag.ipynb)                       |
| 🧠 **셀프 RAG (로컬)**           | 🧠 AI / 정보 검색               | 로컬 모델과 데이터 소스를 사용하여 오프라인 반성 및 검색 프로세스를 구현하는 셀프 RAG 방법을 보여줍니다.                                                                                                     | [![AI Agent Code - Python](https://img.shields.io/static/v1?label=AI+Agent+Code&message=Python&color=%23244cd1)](https://github.com/langchain-ai/langgraph/blob/main/docs/docs/tutorials/rag/langgraph_self_rag_local.ipynb)         |





---

## 🤝 기여하기

기여는 언제나 환영합니다! 🎉 다음 방법으로 참여하실 수 있습니다:

1. 저장소를 포크합니다.
2. 새로운 사용 사례를 추가하거나 기존 것을 개선합니다.
3. 변경 사항을 포함한 풀 리퀘스트를 제출합니다.

자세한 내용은 [기여 가이드라인](https://raw.githubusercontent.com/ashishpatel26/500-AI-Agents-Projects/main/CONTRIBUTING.md)을 참고하세요.

---

## 스타 히스토리

<picture>
  <source
    media="(prefers-color-scheme: dark)"
    srcset="
      https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left
    "
  />
  <source
    media="(prefers-color-scheme: light)"
    srcset="
      https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left
    "
  />
  <img
    alt="별 히스토리 차트"
    src="https://api.star-history.com/svg?repos=ashishpatel26/500-AI-Agents-Projects&type=date&legend=top-left"
  />
</picture>

---

## 📜 라이선스

이 저장소는 MIT 라이선스 하에 있습니다. 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

---

## 🚀 함께 만들어봐요!

이 저장소를 네트워크에 자유롭게 공유하고 유용하다고 생각되면 ⭐ 별을 눌러주세요. AI 에이전트 사용 사례를 위한 궁극적인 리소스를 함께 만들어 갑시다!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---