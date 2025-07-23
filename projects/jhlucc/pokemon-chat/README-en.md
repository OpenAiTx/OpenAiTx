📘 中文 | [English](https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/./README.en.md)

<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/11.png" alt="Icon" style="width: 27%;" />

# "KeMeng" <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/brain-removebg-preview.png" alt="Icon" style="width: 11%;" /> Domain-Specific Chat Assistant Based on Knowledge Base and Knowledge Graph

![Python](https://img.shields.io/badge/Python-3.11-blue?style=flat&logo=python)
![FastAPI](https://img.shields.io/badge/FastAPI-005571?style=flat&logo=fastapi)
![Docker](https://img.shields.io/badge/Docker-2496ED?style=flat&logo=docker&logoColor=ffffff)
![LangGraph](https://img.shields.io/badge/LangGraph-Flow-green?style=flat&logo=databricks)
![GraphRAG](https://img.shields.io/badge/GraphRAG-KG-blueviolet?style=flat)
![Agent](https://img.shields.io/badge/Agent-System-orange?style=flat)
![Vue3](https://img.shields.io/badge/Vue-3.0-4FC08D?style=flat&logo=vue.js)
![License](https://img.shields.io/github/license/bitcookies/winrar-keygen.svg?logo=github)



<img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/img.png" alt="Icon" style="width: 90%;" />



---

## 📝 Project Introduction

Pokémon, as one of the most influential IPs worldwide, possesses a vast world view setting and massive character data. With years of accumulation across games, animation, cards, movies, and other fields, its knowledge system is complex and highly structured, making it very suitable for knowledge graph modeling and intelligent Q&A scenarios.

With the development of large language models (LLM) and knowledge enhancement technologies, constructing the Pokémon universe as a **multimodal, structured, and interactive AI system** has become possible. This project builds a knowledge graph covering Pokémon characters, attributes, skills, regions, evolution paths, and other elements based on data sources like Baidu Tieba and Wikipedia, combined with large model capabilities to create a **dedicated intelligent dialogue assistant for the Pokémon world** — "KeMeng".

On this basis, we integrated **LangGraph inference flow orchestration**, **GraphRAG retrieval-augmented technology**, and **knowledge graph visualization exploration capabilities**, enabling users not only to get precise answers through natural language questions but also to intuitively explore the Pokémon world in graph form. It also supports map-based location features based on geographical location, mapping Pokémon world locations to real-world coordinates one-to-one, achieving **spatial visualization of Pokémon location knowledge** :earth_asia: .

This project aims to build a transferable, scalable, and enthusiast-oriented **domain-specific intelligent assistant template system**. You can easily migrate it to other characters (such as "Su Shi," "Finance," "Government Services," etc.) to create domain-specific intelligent assistants by simply replacing knowledge sources and graph structures to achieve high-quality semantic Q&A and visual knowledge exploration experiences.

---

## 🎯 System Architecture

Through this project's implementation, we not only completed a full vue3+fastapi project but also built an intelligent Q&A system based on the Pokémon knowledge graph. We accumulated rich practical experience in semantic structure modeling such as bert+tf-idf+rule matching mechanisms and graph fusion with generative Q&A. The system supports precise Q&A on Pokémon evolution relationships, attribute resistances, skill features, geographical distribution, etc., greatly enhancing user experience in interactive exploration.

In the future, we will continue optimizing the system's performance in multi-turn Q&A, complex graph reasoning, map navigation, and more scenarios, and expand to support more task types such as: graph-based reasoning Q&A, Pokédex auto-completion, character battle strategy recommendations, etc. Meanwhile, the knowledge graph will be continuously updated and expanded to ensure its **timeliness, completeness, and consistency**, assisting intelligent system construction and AI application expansion in the Pokémon domain.

Below is the core technical architecture diagram of this project:



 <img src="https://raw.githubusercontent.com/jhlucc/pokemon-chat/main/resources/picture/now.png" alt="Icon" style="width: 100%;" />

##  🎯 Project Features

1. Fine-tuned a Pokémon domain-specific large model based on crawled data — [KeMeng](https://huggingface.co/qwqqwq/qwen2.5-14b-instruct-pokemon-int4).
2. Constructed a Pokémon knowledge graph (Wikipedia) based on crawled data.
3. Automated annotation of training NER data using roberta+TF-IDF+rule matching to hit entities and attributes in the graph.
4. Used whisper to implement ASR functionality.
5. Implemented MCP services, such as obtaining Pokémon world locations and displaying Pokémon's corresponding real-world latitude and longitude coordinates on the frontend.
6. Extracted deepdoc from RAGflow to enhance the knowledge base's parsing and extraction capabilities.
7. Used the Langgraph framework to implement graphrag + web searcher + knowledge base intelligent agents based on own data.
8. Encapsulated an agent base class to implement multi-agent functionality.
9. Supports knowledge graph search, web search, knowledge base search, MCP search, and voice search, which can be integrated simultaneously or selected individually.

---

## 🚀 Quick Start

> **Prerequisites**: Docker / Docker Compose installed, Node.js ≥ 18, Python ≥ 3.11

1. Place data into the [resources](https://pan.baidu.com/s/1o48ankI6l9jaky5MeRqgYw?pwd=rkdy) folder

2. **Clone the repository & configure environment variables**

   ```bash
   git clone 
   cd Smart-Assistant
   cp src/.env.template src/.env   # 按需填写 API-KEY，可留空
   cp Smart-Assistant/config/settings_example.py  config/settings.py  # 填写 
   ```
3. **Install Dependencies**


   ```bash
   pip install -r requirements.txt
   ```
4. **Start Core Services**


   ```bash
   cd docker
   docker compose up -d            # Neo4j · Milvus · Whisper · MySQL 等
   ```
5. **Import Graph and Map Data**


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
7. **Start the frontend**


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