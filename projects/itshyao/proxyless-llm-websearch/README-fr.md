
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

# 🧠 Moteur de recherche web LLM sans proxy

Un outil de recherche web multi-moteurs pour LLM sans proxy, prenant en charge l’analyse de contenu d’URL et le crawling de pages web, combiné à LangGraph pour implémenter une chaîne d’agents modulaire. Conçu spécifiquement pour l’appel de connaissances externes par les grands modèles de langage, il prend en charge la récupération et l’analyse de pages via **Playwright + Crawl4AI**, la concurrence asynchrone, le découpage et le réordonnancement de contenu.

## ✨ Aperçu des fonctionnalités

- 🌐 **Sans proxy** : prise en charge du navigateur domestique via la configuration Playwright, permet la recherche web sans proxy.
- 🔍 **Prise en charge multi-moteurs de recherche** : compatible avec Bing, Quark, Baidu, Sogou et autres moteurs principaux, pour une diversité accrue des sources d’information.
- 🤖 **Reconnaissance d’intention** : le système peut déterminer automatiquement, selon la saisie de l’utilisateur, s’il faut effectuer une recherche web ou analyser une URL.
- 🔄 **Décomposition des requêtes** : selon l’intention de recherche, décompose automatiquement la requête en sous-tâches exécutées successivement, améliorant ainsi la pertinence et l’efficacité de la recherche.
- ⚙️ **Architecture agent** : encapsulation des agents **« web_search »** et **« link_parser »** basée sur **LangGraph**.
- 🏃‍♂️ **Traitement asynchrone et parallèle** : gère efficacement plusieurs tâches de recherche grâce au traitement asynchrone et concurrent.
- 📝 **Optimisation du traitement de contenu** :

  - ✂️ **Découpage de contenu** : le contenu long des pages web est découpé par section.

  - 🔄 **Réordonnancement du contenu** : réorganisation intelligente pour améliorer la pertinence de l’information.

  - 🚫 **Filtrage du contenu** : suppression automatique du contenu non pertinent ou dupliqué.
- 🌐 **Prise en charge multi-plateforme** :

  - 🖥️ API backend FastAPI, intégrable à tout système.

  - 🌍 Interface web Gradio, déploiement rapide en application visuelle.
  
  - 🧩[ **Prise en charge d’extension navigateur**](https://github.com/itshyao/proxyless-llm-websearch/tree/main/extension) : compatible Edge, offre un plugin intelligent d’analyse d’URL, permettant l’analyse et l’extraction de contenu web directement dans le navigateur.
  

![workflow](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/workflow.png)

![framework](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/framework.png)

## ⚡ Démarrage rapide

### 1. Cloner le dépôt

```bash
git clone https://github.com/itshyao/proxyless-llm-websearch.git
cd proxyless-llm-websearch
```

### 2. Installer les dépendances

```
pip install -r requirements.txt
python -m playwright install
```

### 3. Démarrage rapide

#### Configuration des variables d'environnement

```
OPENAI_API_KEY=xxx
OPENAI_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
MODEL_NAME=deepseek-v3-250324

EMBEDDING_MODEL_NAME=doubao-embedding-large-text-240915
EMBEDDING_API_KEY=xxx
EMBEDDING_BASE_URL=https://ark.cn-beijing.volces.com/api/v3
```

#### démo

```python
'''
python demo.py
'''

from pools import BrowserPool, CrawlerPool
from agent import ToolsGraph
import asyncio

async def main():
    browser_pool = BrowserPool(pool_size=1)
    crawler_pool = CrawlerPool(pool_size=1)
    
    graph = ToolsGraph(browser_pool, crawler_pool, engine="bing")

    await browser_pool._create_browser_instance(headless=True)
    await crawler_pool._get_instance()

    result = await graph.run("广州今日天气")

    await browser_pool.cleanup()
    await crawler_pool.cleanup()

    print(result)

if __name__ == "__main__":
    asyncio.run(main())
```

#### API backend

```python
'''
python api_serve.py
'''
import requests

url = "http://localhost:8000/search"

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

#### démonstration_gradio

```
python gradio_demo.py
```

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio1.png)

![gradio](https://raw.githubusercontent.com/itshyao/proxyless-llm-websearch/main/img/gradio2.png)

## 🔍 Comparaison avec les tests de recherche en ligne

Nous avons comparé le projet avec certaines API en ligne grand public afin d’évaluer ses performances sur des questions complexes.

### 🔥 Jeu de données

- Le jeu de données provient de [WebWalkerQA](https://huggingface.co/datasets/callanwu/WebWalkerQA) publié par Alibaba, comprenant 680 questions difficiles couvrant l’éducation, les conférences académiques, les jeux, etc.
- Le jeu de données comprend des questions en chinois et en anglais.

### 🧑‍🏫 Résultats de la comparaison

| Moteur de recherche/système | ✅ Correct | ❌ Incorrect | ⚠️ Partiellement correct |
| --------------------------- | --------- | ----------- | ----------------------- |
| **Volcano Ark**             | 5,00%     | 72,21%      | 22,79%                  |
| **Bailian**                 | 9,85%     | 62,79%      | 27,35%                  |
| **Notre**                   | 19,85%    | 47,94%      | 32,06%                  |

## 🙏 Remerciements

Certaines fonctionnalités de ce projet bénéficient du soutien et de l’inspiration des projets open source suivants, que nous remercions ici :

- 🧠 [LangGraph](https://github.com/langchain-ai/langgraph) : pour la construction d’un cadre modulaire de chaînes d’agents intelligents.
- 🕷 [Crawl4AI](https://github.com/unclecode/crawl4ai) : un puissant outil d’analyse de contenu web.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---