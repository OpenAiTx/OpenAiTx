<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=itshyao&project=proxyless-llm-websearch&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>
# 🧠 Moteur de recherche LLM sans proxy

Un outil de récupération sur le web multi-moteur LLM sans proxy, prenant en charge l’analyse de contenu d’URL et le crawling de pages web, combinant **LangGraph** et **LangGraph-MCP** pour réaliser une chaîne d'agents modulaire. Conçu pour l’appel de connaissances externes par les grands modèles de langage, il prend en charge l’acquisition et l’analyse de pages web via **Playwright + Crawl4AI**, avec gestion de la concurrence asynchrone, découpage et réorganisation des contenus.

## 🚀 Journal des mises à jour

- 🔥 2025-09-05 : Support de **langgraph-mcp**
- 🔥 2025-09-03 : Ajout du déploiement Docker, reranker intégré, support des découpeurs et rerankers personnalisés

## ✨ Aperçu des fonctionnalités

- 🌐 **Aucun proxy requis** : prise en charge des navigateurs chinois via la configuration Playwright, permettant la recherche en ligne sans proxy.
- 🔍 **Prise en charge de plusieurs moteurs de recherche** : prise en charge de Bing, Quark, Baidu, Sogou et autres moteurs principaux, pour une diversité accrue des sources d'information.
- 🤖 **Reconnaissance d'intention** : le système peut déterminer automatiquement, selon la saisie de l'utilisateur, s'il doit effectuer une recherche web ou analyser une URL.
- 🔄 **Décomposition des requêtes** : en fonction de l'intention de recherche, la requête est automatiquement divisée en plusieurs sous-tâches qui sont exécutées successivement pour améliorer la pertinence et l'efficacité de la recherche.
- ⚙️ **Architecture intelligente** : encapsulation des modules **« web_search »** et **« link_parser »** basés sur **LangGraph**.
- 🏃‍♂️ **Traitement asynchrone et concurrent des tâches** : prise en charge du traitement asynchrone et concurrent des tâches, permettant de gérer efficacement plusieurs recherches.
- 📝 **Optimisation du traitement du contenu** :

  - ✂️ **Découpage du contenu** : division du contenu long des pages web en segments.

  - 🔄 **Réordonnancement du contenu** : réorganisation intelligente pour une meilleure pertinence de l'information.

  - 🚫 **Filtrage du contenu** : suppression automatique des contenus non pertinents ou doublons.
- 🌐 **Prise en charge multiplateforme** :
  - 🐳 **Déploiement Docker pris en charge** : démarrage en un clic, construction rapide du service backend.

  - 🖥️ Interface backend FastAPI fournie, intégrable à tout système.

  - 🌍 Interface Web Gradio fournie, permettant un déploiement rapide en application visuelle.

  - 🧩[ **Prise en charge des extensions navigateur**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension) : prise en charge Edge, extension intelligente d’analyse d’URL, permettant l’analyse et l’extraction directe du contenu dans le navigateur.


![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Démarrage rapide

### Cloner le dépôt

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### Installation des dépendances

```
pip install -r requirements.txt
python -m playwright install
```

### Configuration des variables d'environnement

```
# 百炼llm
OPENAI_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
OPENAI_API_KEY=sk-xxx
MODEL_NAME=qwen-plus-latest

# 百炼embedding
EMBEDDING_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
EMBEDDING_API_KEY=sk-xxx
EMBEDDING_MODEL_NAME=text-embedding-v4

# 百炼reranker
RERANK_BASE_URL=https://dashscope.aliyuncs.com/compatible-mode/v1
RERANK_API_KEY=sk-xxx
RERANK_MODEL=gte-rerank-v2
```

### Langgraph-Agent

#### DÉMONSTRATION

```shell
python agent/demo.py
```

#### SERVEUR API

```shell
python agent/api_serve.py
```

```python
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气",
  "engine": "bing",
  "split": {
    "chunk_size": 512,
    "chunk_overlap": 128
  },
  "rerank": {
    "top_k": 5
  }
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### Gradio

```
python agent/gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

#### docker

```
docker-compose -f docker-compose-ag.yml up -d --build
```

### Langgrph-MCP

#### Démarrer le service MCP

```
python mcp/websearch.py
```

#### DÉMO

```
python mcp/demo.py
```

#### SERVEUR D'API

```
python mcp/api_serve.py
```

```
import requests

url = "http://localhost:8800/search"

data = {
  "question": "广州今日天气"
}

try:
    response = requests.post(
        url,
        json=data
    )

    if response.status_code == 200:
        print("✅ 请求成功！")
        print("响应内容：", response.json())
    else:
        print(f"❌ 请求失败，状态码：{response.status_code}")
        print("错误信息：", response.text)

except requests.exceptions.RequestException as e:
    print(f"⚠️ 请求异常：{str(e)}")
```

#### docker

```
docker-compose -f docker-compose-mcp.yml up -d --build
```

### Module personnalisé

#### Partitionnement personnalisé

```
from typing import Optional, List

class YourSplitter:
    def __init__(self, text: str, chunk_size: int = 512, chunk_overlap: int = 128):
        self.text = text
        self.chunk_size = chunk_size
        self.chunk_overlap = chunk_overlap

    def split_text(self, text: Optional[str] = None) -> List:
        # TODO: implement splitting logic
        return ["your chunk"]
```

#### Réorganisation personnalisée

```
from typing import List, Union, Tuple

class YourReranker:
    async def get_reranked_documents(
        self,
        query: Union[str, List[str]],
        documents: List[str],
    ) -> Union[
        Tuple[List[str]],
        Tuple[List[int]],
    ]:
        return ["your chunk"], ["chunk index"]
```

## 🔍 Comparaison avec les tests de recherche en ligne

Nous avons comparé le projet avec plusieurs API en ligne principales, en évaluant leurs performances sur des questions complexes.

### 🔥 Jeu de données

- Le jeu de données provient de [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) publié par Alibaba, comprenant 680 questions de haute difficulté couvrant l'éducation, les conférences académiques, les jeux et d'autres domaines.
- Le jeu de données inclut des questions en chinois et en anglais.

### 🧑‍🏫 Résultats comparatifs

| Moteur de recherche/Système | ✅ Correct | ❌ Incorrect | ⚠️ Partiellement correct |
| -------------------------- | ----------| ------------| ------------------------|
| **Volcano Ark**            | 5,00 %    | 72,21 %     | 22,79 %                 |
| **Bailian**                | 9,85 %    | 62,79 %     | 27,35 %                 |
| **Notre**                  | 19,85 %   | 47,94 %     | 32,06 %                 |
## 🙏 Remerciements

Certaines fonctionnalités de ce projet bénéficient du soutien et de l'inspiration des projets open source suivants, que nous tenons à remercier :

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph) : utilisé pour construire un cadre de chaîne d'agents modulaire, facilitant la création rapide de systèmes d'agents complexes.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai) : puissant outil d'analyse de contenu web, facilitant le crawling efficace et l'extraction de données.
- 🌐 [Playwright](https://github.com/microsoft/playwright) : outil moderne d'automatisation de navigateur, supportant le crawling web et les tests automatisés multi-navigateurs.
- 🔌 [Langchain MCP Adapters](https://github.com/langchain-ai/langchain-mcp-adapters) : utilisé pour la construction de MCP multi-chaînes.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-05

---