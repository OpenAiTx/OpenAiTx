# DeepSeek-R1
<!-- markdownlint-disable first-line-h1 -->
<!-- markdownlint-disable html -->
<!-- markdownlint-disable no-duplicate-header -->

<div align="center">
  <img src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/logo.svg?raw=true" width="60%" alt="DeepSeek-R1" />
</div>
<hr>
<div align="center" style="line-height: 1;">
  <a href="https://www.deepseek.com/" target="_blank"><img alt="Homepage"
    src="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/badge.svg?raw=true"/></a>
  <a href="https://chat.deepseek.com/" target="_blank"><img alt="Chat"
    src="https://img.shields.io/badge/🤖%20Chat-DeepSeek%20R1-536af5?color=536af5&logoColor=white"/></a>
  <a href="https://huggingface.co/deepseek-ai" target="_blank"><img alt="Hugging Face"
    src="https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-DeepSeek%20AI-ffc107?color=ffc107&logoColor=white"/></a>
  <br>
  <a href="https://discord.gg/Tc7c45Zzu5" target="_blank"><img alt="Discord"
    src="https://img.shields.io/badge/Discord-DeepSeek%20AI-7289da?logo=discord&logoColor=white&color=7289da"/></a>
  <a href="https://github.com/deepseek-ai/DeepSeek-V2/blob/main/figures/qr.jpeg?raw=true" target="_blank"><img alt="WeChat"
    src="https://img.shields.io/badge/WeChat-DeepSeek%20AI-brightgreen?logo=wechat&logoColor=white"/></a>
  <a href="https://twitter.com/deepseek_ai" target="_blank"><img alt="Twitter Follow"
    src="https://img.shields.io/badge/Twitter-deepseek_ai-white?logo=x&logoColor=white"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE"><img alt="License"
    src="https://img.shields.io/badge/License-MIT-f5de53?&color=f5de53"/></a>
  <br>
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Lien vers l'article</b>👁️</a>
</div>

## 1. Introduction

Nous présentons nos modèles de raisonnement de première génération, DeepSeek-R1-Zero et DeepSeek-R1.  
DeepSeek-R1-Zero, un modèle entraîné via un apprentissage par renforcement (RL) à grande échelle sans ajustement supervisé (SFT) comme étape préliminaire, a démontré des performances remarquables en raisonnement.  
Grâce au RL, DeepSeek-R1-Zero a naturellement développé de nombreux comportements de raisonnement puissants et intéressants.  
Cependant, DeepSeek-R1-Zero rencontre des problèmes tels que des répétitions infinies, une faible lisibilité et le mélange des langues. Pour résoudre ces problèmes et améliorer davantage les performances de raisonnement,  
nous introduisons DeepSeek-R1, qui intègre des données de démarrage à froid avant le RL.  
DeepSeek-R1 atteint des performances comparables à OpenAI-o1 sur les tâches de mathématiques, de code et de raisonnement.  
Pour soutenir la communauté de recherche, nous avons ouvert DeepSeek-R1-Zero, DeepSeek-R1 et six modèles denses distillés à partir de DeepSeek-R1 basés sur Llama et Qwen. DeepSeek-R1-Distill-Qwen-32B surpasse OpenAI-o1-mini sur divers benchmarks, établissant de nouveaux résultats SOTA pour les modèles denses.

**REMARQUE : Avant d'exécuter localement les modèles de la série DeepSeek-R1, nous vous recommandons vivement de consulter la section [Recommandations d'utilisation](#usage-recommendations).**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Résumé du modèle

---

**Post-entraînement : Apprentissage par renforcement à grande échelle sur le modèle de base**

-  Nous appliquons directement l'apprentissage par renforcement (RL) au modèle de base sans recourir à l'ajustement supervisé (SFT) comme étape préliminaire. Cette approche permet au modèle d'explorer le raisonnement en chaîne (CoT) pour résoudre des problèmes complexes, ce qui aboutit au développement de DeepSeek-R1-Zero. DeepSeek-R1-Zero démontre des capacités telles que l'auto-vérification, la réflexion et la génération de longues chaînes de raisonnement, marquant une étape importante pour la communauté de recherche. Notamment, il s'agit de la première recherche ouverte à valider que les capacités de raisonnement des LLMs peuvent être stimulées uniquement via le RL, sans besoin de SFT. Cette avancée ouvre la voie à de futurs progrès dans ce domaine.

-   Nous présentons notre pipeline pour développer DeepSeek-R1. Le pipeline intègre deux étapes de RL visant à découvrir de meilleurs schémas de raisonnement et à s'aligner sur les préférences humaines, ainsi que deux étapes de SFT qui servent de graine pour les capacités de raisonnement et non-raisonnement du modèle.  
    Nous pensons que ce pipeline bénéficiera à l'industrie en créant de meilleurs modèles.

---

**Distillation : Les petits modèles peuvent aussi être puissants**

-  Nous démontrons que les schémas de raisonnement des modèles plus grands peuvent être distillés dans des modèles plus petits, donnant de meilleures performances que les schémas de raisonnement découverts par RL sur des petits modèles. Le DeepSeek-R1 open source, ainsi que son API, permettront à la communauté de recherche de distiller de meilleurs petits modèles à l'avenir.
-  En utilisant les données de raisonnement générées par DeepSeek-R1, nous avons affiné plusieurs modèles denses largement utilisés dans la communauté de recherche. Les résultats d'évaluation démontrent que les petits modèles denses distillés performent exceptionnellement bien sur les benchmarks. Nous publions en open source les checkpoints distillés 1.5B, 7B, 8B, 14B, 32B et 70B basés sur Qwen2.5 et la série Llama3 à la communauté.

## 3. Téléchargement des modèles

### Modèles DeepSeek-R1

<div align="center">

| **Modèle**         | **#Paramètres totaux** | **#Paramètres activés** | **Longueur du contexte** | **Télécharger** |
| :----------------: | :-------------------: | :---------------------: | :----------------------: | :-------------: |
| DeepSeek-R1-Zero   | 671B                  | 37B                     | 128K                     | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1        | 671B                  | 37B                     | 128K                     | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 sont entraînés à partir de DeepSeek-V3-Base.  
Pour plus de détails concernant l'architecture du modèle, veuillez vous référer au dépôt [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### Modèles DeepSeek-R1-Distill

<div align="center">

| **Modèle** | **Modèle de base** | **Télécharger** |
| :----------------------: | :---------------------: | :-----------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

Les modèles DeepSeek-R1-Distill sont affinés à partir de modèles open source, en utilisant des exemples générés par DeepSeek-R1.  
Nous avons légèrement modifié leurs configurations et leurs tokenizers. Veuillez utiliser notre configuration pour exécuter ces modèles.

## 4. Résultats d'évaluation

### DeepSeek-R1-Évaluation
Pour tous nos modèles, la longueur maximale de génération est fixée à 32 768 tokens. Pour les benchmarks nécessitant un échantillonnage, nous utilisons une température de $0,6$, une valeur top-p de $0,95$ et générons 64 réponses par requête pour estimer pass@1.
<div align="center">


| Catégorie | Benchmark (Métrique) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Architecture | - | - | MoE | - | - | MoE |
| | # Paramètres activés | - | - | 37B | - | - | 37B |
| | # Paramètres totaux | - | - | 671B | - | - | 671B |
| Anglais | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Code | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Résolu) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Math | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Chinois | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Évaluation des modèles distillés


<div align="center">

| Modèle                                   | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
|------------------------------------------|------------------|-------------------|-----------------|----------------------|----------------------|-------------------|
| GPT-4o-0513                          | 9.3              | 13.4              | 74.6            | 49.9                 | 32.9                 | 759               |
| Claude-3.5-Sonnet-1022             | 16.0             | 26.7                 | 78.3            | 65.0                 | 38.9                 | 717               |
| o1-mini                              | 63.6             | 80.0              | 90.0            | 60.0                 | 53.8                 | **1820**          |
| QwQ-32B-Preview                              | 44.0             | 60.0                 | 90.6            | 54.5               | 41.9                 | 1316              |
| DeepSeek-R1-Distill-Qwen-1.5B       | 28.9             | 52.7              | 83.9            | 33.8                 | 16.9                 | 954               |
| DeepSeek-R1-Distill-Qwen-7B          | 55.5             | 83.3              | 92.8            | 49.1                 | 37.6                 | 1189              |
| DeepSeek-R1-Distill-Qwen-14B         | 69.7             | 80.0              | 93.9            | 59.1                 | 53.1                 | 1481              |
| DeepSeek-R1-Distill-Qwen-32B        | **72.6**         | 83.3              | 94.3            | 62.1                 | 57.2                 | 1691              |
| DeepSeek-R1-Distill-Llama-8B         | 50.4             | 80.0              | 89.1            | 49.0                 | 39.6                 | 1205              |
| DeepSeek-R1-Distill-Llama-70B        | 70.0             | **86.7**          | **94.5**        | **65.2**             | **57.5**             | 1633              |

</div>


## 5. Site de chat & Plateforme API
Vous pouvez discuter avec DeepSeek-R1 sur le site officiel de DeepSeek : [chat.deepseek.com](https://chat.deepseek.com), et activer le bouton "DeepThink".

Nous proposons également une API compatible OpenAI sur la plateforme DeepSeek : [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Comment exécuter en local

### Modèles DeepSeek-R1

Veuillez consulter le dépôt [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) pour plus d'informations sur l'exécution locale de DeepSeek-R1.

**REMARQUE : Transformers de Hugging Face n'est pas encore directement supporté.**

### Modèles DeepSeek-R1-Distill

Les modèles DeepSeek-R1-Distill peuvent être utilisés de la même manière que les modèles Qwen ou Llama.

Par exemple, vous pouvez facilement démarrer un service avec [vLLM](https://github.com/vllm-project/vllm) :

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

Vous pouvez aussi facilement démarrer un service avec [SGLang](https://github.com/sgl-project/sglang)

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Recommandations d'utilisation

**Nous recommandons de respecter les configurations suivantes lors de l'utilisation des modèles de la série DeepSeek-R1, y compris pour les benchmarks, afin d'obtenir les performances attendues :**

1. Réglez la température entre 0,5 et 0,7 (0,6 recommandé) pour éviter les répétitions infinies ou les sorties incohérentes.
2. **Évitez d'ajouter un prompt système ; toutes les instructions doivent être contenues dans le prompt utilisateur.**
3. Pour les problèmes mathématiques, il est conseillé d'inclure une directive dans votre prompt telle que : "Veuillez raisonner étape par étape et placer votre réponse finale dans \boxed{}."
4. Lors de l'évaluation des performances du modèle, il est recommandé d'effectuer plusieurs tests et de faire la moyenne des résultats.

De plus, nous avons observé que les modèles de la série DeepSeek-R1 ont tendance à ignorer le schéma de réflexion (c'est-à-dire à sortir "\<think\>\n\n\</think\>") lors de certaines requêtes, ce qui peut affecter négativement les performances du modèle.  
**Pour garantir un raisonnement approfondi, nous recommandons de forcer le modèle à commencer sa réponse par "\<think\>\n" au début de chaque sortie.**

### Prompts officiels
Dans l'application web/app officielle DeepSeek, nous n'utilisons pas de prompts système mais concevons deux prompts spécifiques pour l'envoi de fichiers et la recherche web afin d'améliorer l'expérience utilisateur. De plus, la température dans le web/app est de 0,6.

Pour l'envoi de fichier, veuillez suivre le modèle pour créer les prompts, où {file_name}, {file_content} et {question} sont des arguments.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Pour la recherche web, {search_results}, {cur_date}, et {question} sont des arguments.

Pour une requête en chinois, nous utilisons le prompt :
```
search_answer_zh_template = \
'''# 以下内容是基于用户发送的消息的搜索结果:
{search_results}
在我给你的搜索结果中，每个结果都是[webpage X begin]...[webpage X end]格式的，X代表每篇文章的数字索引。请在适当的情况下在句子末尾引用上下文。请按照引用编号[citation:X]的格式在答案中对应部分引用上下文。如果一句话源自多个上下文，请列出所有相关的引用编号，例如[citation:3][citation:5]，切记不要将引用集中在最后返回引用编号，而是在答案对应部分列出。
在回答时，请注意以下几点：
- 今天是{cur_date}。
- 并非搜索结果的所有内容都与用户的问题密切相关，你需要结合问题，对搜索结果进行甄别、筛选。
- 对于列举类的问题（如列举所有航班信息），尽量将答案控制在10个要点以内，并告诉用户可以查看搜索来源、获得完整信息。优先提供信息完整、最相关的列举项；如非必要，不要主动告诉用户搜索结果未提供的内容。
- 对于创作类的问题（如写论文），请务必在正文的段落中引用对应的参考编号，例如[citation:3][citation:5]，不能只在文章末尾引用。你需要解读并概括用户的题目要求，选择合适的格式，充分利用搜索结果并抽取重要信息，生成符合用户要求、极具思想深度、富有创造力与专业性的答案。你的创作篇幅需要尽可能延长，对于每一个要点的论述要推测用户的意图，给出尽可能多角度的回答要点，且务必信息量大、论述详尽。
- 如果回答很长，请尽量结构化、分段落总结。如果需要分点作答，尽量控制在5个点以内，并合并相关的内容。
- 对于客观类的问答，如果问题的答案非常简短，可以适当补充一到两句相关信息，以丰富内容。
- 你需要根据用户要求和回答内容选择合适、美观的回答格式，确保可读性强。
- 你的回答应该综合多个相关网页来回答，不能重复引用一个网页。
- 除非用户要求，否则你回答的语言需要和用户提问的语言保持一致。

# 用户消息为：
{question}'''
```


Pour une requête en anglais, nous utilisons le prompt :
```
search_answer_en_template = \
'''# The following contents are the search results related to the user's message:
{search_results}
In the search results I provide to you, each result is formatted as [webpage X begin]...[webpage X end], where X represents the numerical index of each article. Please cite the context at the end of the relevant sentence when appropriate. Use the citation format [citation:X] in the corresponding part of your answer. If a sentence is derived from multiple contexts, list all relevant citation numbers, such as [citation:3][citation:5]. Be sure not to cluster all citations at the end; instead, include them in the corresponding parts of the answer.
When responding, please keep the following points in mind:
- Today is {cur_date}.
- Not all content in the search results is closely related to the user's question. You need to evaluate and filter the search results based on the question.
- For listing-type questions (e.g., listing all flight information), try to limit the answer to 10 key points and inform the user that they can refer to the search sources for complete information. Prioritize providing the most complete and relevant items in the list. Avoid mentioning content not provided in the search results unless necessary.
- For creative tasks (e.g., writing an essay), ensure that references are cited within the body of the text, such as [citation:3][citation:5], rather than only at the end of the text. You need to interpret and summarize the user's requirements, choose an appropriate format, fully utilize the search results, extract key information, and generate an answer that is insightful, creative, and professional. Extend the length of your response as much as possible, addressing each point in detail and from multiple perspectives, ensuring the content is rich and thorough.
- If the response is lengthy, structure it well and summarize it in paragraphs. If a point-by-point format is needed, try to limit it to 5 points and merge related content.
- For objective Q&A, if the answer is very brief, you may add one or two related sentences to enrich the content.
- Choose an appropriate and visually appealing format for your response based on the user's requirements and the content of the answer, ensuring strong readability.
- Your answer should synthesize information from multiple relevant webpages and avoid repeatedly citing the same webpage.
- Unless the user requests otherwise, your response should be in the same language as the user's question.

# The user's message is:
{question}'''
```

## 7. Licence
Ce dépôt de code et les poids du modèle sont licenciés sous la [Licence MIT](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).  
La série DeepSeek-R1 prend en charge l'utilisation commerciale, permet toute modification et travaux dérivés, y compris, mais sans s'y limiter, la distillation pour entraîner d'autres LLMs. Veuillez noter que :
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B et DeepSeek-R1-Distill-Qwen-32B sont dérivés de la [série Qwen-2.5](https://github.com/QwenLM/Qwen2.5), qui sont initialement sous licence [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE), et maintenant affinés avec 800k exemples sélectionnés avec DeepSeek-R1.
- DeepSeek-R1-Distill-Llama-8B est dérivé de Llama3.1-8B-Base et est initialement sous licence [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B est dérivé de Llama3.3-70B-Instruct et est initialement sous licence [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Citation
```bibtex
@misc{deepseekai2025deepseekr1incentivizingreasoningcapability,
      title={DeepSeek-R1: Incentivizing Reasoning Capability in LLMs via Reinforcement Learning}, 
      author={DeepSeek-AI},
      year={2025},
      eprint={2501.12948},
      archivePrefix={arXiv},
      primaryClass={cs.CL},
      url={https://arxiv.org/abs/2501.12948}, 
}
```

## 9. Contact
Si vous avez des questions, veuillez ouvrir une issue ou nous contacter à [service@deepseek.com](mailto:service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---