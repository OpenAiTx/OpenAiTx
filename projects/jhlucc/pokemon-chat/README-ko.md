📘 中文 | [English](https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/./README.en.md)

<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/11.png" alt="图标" style="width: 27%;" />

# 「可萌」 <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/brain-removebg-preview.png" alt="图标" style="width: 11%;" /> 지식베이스 및 지식 그래프 기반 전용 대화 보조 도구

![Python](https://img.shields.io/badge/Python-3.11-blue?style=flat&logo=python)
![FastAPI](https://img.shields.io/badge/FastAPI-005571?style=flat&logo=fastapi)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=ffffff)
![LangGraph](https://img.shields.io/badge/LangGraph-Flow-green?style=flat&logo=databricks)
![GraphRAG](https://img.shields.io/badge/GraphRAG-KG-blueviolet?style=flat)
![Agent](https://img.shields.io/badge/Agent-System-orange?style=flat)
![Vue3](https://img.shields.io/badge/Vue-3.0-4FC08D?style=flat&logo=vue.js)
![License](https://img.shields.io/github/license/bitcookies/winrar-keygen.svg?logo=github)



<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/img.png" alt="图标" style="width: 90%;" />



---

## 📝 프로젝트 소개

포켓몬(Pokémon)은 전 세계에서 가장 영향력 있는 IP 중 하나로, 방대한 세계관 설정과 수많은 캐릭터 데이터를 보유하고 있습니다. 게임, 애니메이션, 카드, 영화 등 다양한 분야에서 쌓인 다년간의 축적으로, 그 지식 체계는 방대하고 고도로 구조화되어 있어 지식 그래프 모델링과 지능형 질의응답 시나리오에 매우 적합합니다.

대형 언어 모델(LLM)과 지식 강화 기술의 발전과 함께, 포켓몬 우주를 **멀티모달, 구조화, 상호작용 가능한 AI 시스템**으로 구축하는 것이 가능해졌습니다. 본 프로젝트는 바이두 게시판과 위키피디아 등의 데이터 소스를 기반으로 포켓몬 캐릭터, 속성, 기술, 지역, 진화 경로 등의 요소를 아우르는 지식 그래프를 구축하고, 대형 모델 능력을 결합하여 **전용 포켓몬 세계 지능형 대화 보조 도구**인 「可萌」을 만들었습니다.

이를 토대로, 우리는 **LangGraph 추론 흐름 편집**, **GraphRAG 검색 강화 기술**, 그리고 **지식 그래프 시각화 탐색 기능**을 융합하여 사용자가 자연어 질문을 통해 정확한 답변을 얻을 수 있을 뿐만 아니라 그래프 형태로 포켓몬 세계를 직관적으로 탐색할 수 있도록 했습니다. 또한 위치 기반 지도 위치 지정 기능을 지원하여 포켓몬 세계와 현실 세계 좌표를 일대일로 매핑해 **포켓몬 장소 지식의 공간 시각화**를 구현했습니다 :earth_asia: .

​        본 프로젝트는 전이 가능하고 확장 가능한, 애호가를 위한 **전용 지능형 보조 도구 템플릿 시스템**을 구축하는 데 주력하고 있으며, 지식 출처와 그래프 구조만 교체하면 다른 캐릭터(예: 「소식(苏轼)」, 「금융」, 「정무 서비스」 등)에도 쉽게 이식하여 고품질 의미 기반 질의응답과 시각화 지식 탐색 경험을 제공할 수 있습니다.

---

## 🎯 시스템 아키텍처

본 프로젝트를 구현함으로써 우리는 vue3+fastapi 기반의 완전한 프로젝트를 완성했을 뿐만 아니라 포켓몬 지식 그래프 기반의 지능형 질의응답 시스템을 구축했습니다. bert+tf-idf+규칙 매칭 메커니즘과 그래프 융합, 생성형 질의응답 등 의미 구조 모델링에 대한 풍부한 실무 경험을 축적했습니다. 시스템은 포켓몬의 진화 관계, 속성 상성, 기술 특성, 지리 분포 등 내용을 정밀하게 질의할 수 있어 대화형 탐색에서 사용자 경험을 크게 향상시킵니다.

앞으로 우리는 다중 대화, 복잡한 그래프 추론, 지도 내비게이션 등 시나리오에서 시스템 성능을 지속적으로 최적화하고, 그래프 기반 추론 질의응답, Pokédex 자동 완성, 캐릭터 전투 전략 제안 등 더 많은 지원 작업 유형을 확장할 예정입니다. 또한 지식 그래프는 **시의성, 완전성, 일관성**을 보장하기 위해 지속적으로 업데이트 및 확장되어 포켓몬 분야의 지능형 시스템 구축 및 AI 응용 확장에 기여할 것입니다.

아래는 본 프로젝트의 핵심 기술 아키텍처 도면입니다:



 <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/now.png" alt="图标" style="width: 100%;" />

##  🎯 프로젝트 특징

1. 크롤링한 데이터를 기반으로 포켓몬 전용 대형 모델인 — [可萌](https://huggingface.co/qwqqwq/qwen2.5-14b-instruct-pokemon-int4) 을 미세 조정했습니다.
2. 크롤링한 데이터를 기반으로 포켓몬 지식 그래프(위키피디아)를 구축했습니다.
3. 자동화된 NER 데이터 라벨링을 수행하며 roberta+TF-IDF+규칙 매칭을 사용해 그래프 내 엔티티와 속성을 명중시켰습니다.
4. whisper를 사용하여 ASR 기능을 구현했습니다.
5. MCP 서비스를 구현하여 포켓몬 세계 장소를 얻고, 실제 세계 좌표에 대응하는 위도경도 좌표를 프론트엔드에 표시합니다.
6. RAGflow의 deepdoc을 추출하여 지식베이스의 분석 및 추출 능력을 강화했습니다.
7. LangGraph 프레임워크를 사용해 자체 데이터를 기반으로 graphrag+ 웹 검색기 + 지식베이스 지능형 에이전트를 구현했습니다.
8. 에이전트 기본 클래스를 캡슐화하여 다중 에이전트 기능을 구현했습니다.
9. 지식 그래프 검색, 네트워크 검색, 지식베이스 검색, MCP 검색, 음성 검색을 지원하며, 동시에 통합하거나 선택적으로 사용할 수 있습니다.

---

## 🚀 빠른 시작

> **사전 요구사항**: Docker / Docker Compose, Node.js ≥ 18, Python ≥ 3.11 설치 완료

1. 데이터를 [resources](https://pan.baidu.com/s/1o48ankI6l9jaky5MeRqgYw?pwd=rkdy) 폴더에 넣으세요

2. **저장소 클론 및 환경 변수 설정**

   ```bash
   git clone 
   cd Smart-Assistant
   cp src/.env.template src/.env   # 按需填写 API-KEY，可留空
   cp Smart-Assistant/config/settings_example.py  config/settings.py  # 填写 
   ```
3. **의존성 설치**


   ```bash
   pip install -r requirements.txt
   ```
4. **핵심 서비스 시작**


   ```bash
   cd docker
   docker compose up -d            # Neo4j · Milvus · Whisper · MySQL 等
   ```
5. **그래프 및 지도 데이터 가져오기**


   ```bash
   cd scripts
   python import_graph.py          # 写入 Neo4j
   python import_pokemon_map.py    # 写入 MySQL
   ```

   

6. **启动后端服务**

   ```bash
   cd server
   python main.py                  # FastAPI + LangGraph
   cd ../src/mcp
   python mcp_server.py            # SSE 模式示例
   ```
7. **프론트엔드 시작하기**


   ```bash
   cd web
   npm install
   npm run dev
   # 浏览器访问 http://localhost:3100/
   ```

---

## 🔭 参考项目

- https://github.com/xerrors/Yuxi-Know

- https://github.com/BinNong/meet-libai

  

---

## 📄 License

本项目遵循 **MIT License**，可自由用于商业或个人项目。二次开发请保留原作者与来源信息。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---