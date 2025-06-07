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
  <a href="https://github.com/deepseek-ai/DeepSeek-R1/blob/main/DeepSeek_R1.pdf"><b>Paper Link</b>👁️</a>
</div>

## 1. Introductie

We introduceren onze eerstegeneratie redeneermodellen, DeepSeek-R1-Zero en DeepSeek-R1.  
DeepSeek-R1-Zero, een model getraind via grootschalige reinforcement learning (RL) zonder supervised fine-tuning (SFT) als voorbereidende stap, toonde opmerkelijke prestaties op het gebied van redeneren.
Met RL vertoonde DeepSeek-R1-Zero van nature talloze krachtige en interessante redeneergedragingen.
Echter, DeepSeek-R1-Zero ondervindt uitdagingen zoals eindeloze herhaling, slechte leesbaarheid en taalvermenging. Om deze problemen aan te pakken en de redeneerprestaties verder te verbeteren,
introduceren we DeepSeek-R1, dat cold-start data bevat vóór RL.
DeepSeek-R1 behaalt prestaties vergelijkbaar met OpenAI-o1 op het gebied van wiskunde, code en redeneervaardigheden.  
Ter ondersteuning van de onderzoeksgemeenschap hebben we DeepSeek-R1-Zero, DeepSeek-R1 en zes dense modellen die van DeepSeek-R1 zijn afgeleid op basis van Llama en Qwen, open source gemaakt. DeepSeek-R1-Distill-Qwen-32B presteert beter dan OpenAI-o1-mini op verschillende benchmarks en behaalt nieuwe state-of-the-art resultaten voor dense modellen.

**OPMERKING: Voordat u DeepSeek-R1-seriemodellen lokaal uitvoert, raden wij aan de sectie [Gebruik aanbevelingen](#usage-recommendations) door te nemen.**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Modeloverzicht

---

**Post-Training: Grootschalige Reinforcement Learning op het Basismodel**

-  We passen direct reinforcement learning (RL) toe op het basismodel zonder te vertrouwen op supervised fine-tuning (SFT) als voorbereidende stap. Deze aanpak stelt het model in staat om chain-of-thought (CoT) te verkennen voor het oplossen van complexe problemen, wat resulteert in de ontwikkeling van DeepSeek-R1-Zero. DeepSeek-R1-Zero toont mogelijkheden zoals zelfverificatie, reflectie en het genereren van lange CoTs, wat een belangrijke mijlpaal is voor de onderzoeksgemeenschap. Opmerkelijk is dat dit het eerste open onderzoek is dat aantoont dat redeneervermogen van LLM's puur via RL kan worden gestimuleerd, zonder de noodzaak van SFT. Deze doorbraak effent het pad voor toekomstige ontwikkelingen op dit gebied.

-   We introduceren onze pijplijn om DeepSeek-R1 te ontwikkelen. De pijplijn omvat twee RL-fasen gericht op het ontdekken van verbeterde redeneerpatronen en het afstemmen op menselijke voorkeuren, evenals twee SFT-fasen die als zaad dienen voor de redeneer- en niet-redeneercapaciteiten van het model.
    Wij geloven dat de pijplijn de industrie ten goede zal komen door betere modellen te creëren. 

---

**Distillatie: Kleinere Modellen Kunnen Ook Krachtig Zijn**

-  We tonen aan dat de redeneerpatronen van grotere modellen kunnen worden gedistilleerd naar kleinere modellen, wat resulteert in betere prestaties dan de redeneerpatronen die via RL op kleine modellen zijn ontdekt. De open source DeepSeek-R1 en de bijbehorende API zullen de onderzoeksgemeenschap helpen om in de toekomst betere kleine modellen te distilleren. 
- Met de redeneerdata gegenereerd door DeepSeek-R1 hebben we verschillende dense modellen die veel worden gebruikt in de onderzoeksgemeenschap verder verfijnd. De evaluatieresultaten tonen aan dat de gedistilleerde kleinere dense modellen uitzonderlijk goed presteren op benchmarks. We stellen gedistilleerde 1.5B, 7B, 8B, 14B, 32B en 70B checkpoints op basis van Qwen2.5 en Llama3-series open source beschikbaar aan de gemeenschap.

## 3. Modeldownloads

### DeepSeek-R1 Modellen

<div align="center">

| **Model** | **#Totale Parameters** | **#Geactiveerde Parameters** | **Contextlengte** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 zijn getraind op basis van DeepSeek-V3-Base.  
Voor meer details over de modelarchitectuur, zie de [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) repository.

### DeepSeek-R1-Distill Modellen

<div align="center">

| **Model** | **Basismodel** | **Download** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

DeepSeek-R1-Distill modellen zijn verfijnd op basis van open-source modellen, met behulp van door DeepSeek-R1 gegenereerde samples.
We passen hun configs en tokenizers licht aan. Gebruik onze instellingen om deze modellen uit te voeren.

## 4. Evaluatieresultaten

### DeepSeek-R1-Evaluatie
 Voor al onze modellen is de maximale generatie-lengte ingesteld op 32.768 tokens. Voor benchmarks waarbij sampling vereist is, gebruiken we een temperatuur van $0.6$, een top-p waarde van $0.95$ en genereren we 64 antwoorden per query om pass@1 te schatten.
<div align="center">


| Categorie | Benchmark (Metriek) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Architectuur | - | - | MoE | - | - | MoE |
| | # Geactiveerde Params | - | - | 37B | - | - | 37B |
| | # Totale Params | - | - | 671B | - | - | 671B |
| Engels | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
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
| | Codeforces (Percentiel) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Opgelost) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Wiskunde | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Chinees | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Evaluatie Gedistilleerd Model


<div align="center">

| Model                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
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


## 5. Chat Website & API Platform
U kunt chatten met DeepSeek-R1 op de officiële website van DeepSeek: [chat.deepseek.com](https://chat.deepseek.com), en zet de knop "DeepThink" aan.

We bieden ook een OpenAI-compatibele API aan op het DeepSeek Platform: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Lokaal Uitvoeren

### DeepSeek-R1 Modellen

Bezoek de [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) repository voor meer informatie over het lokaal uitvoeren van DeepSeek-R1.

**OPMERKING: Hugging Face's Transformers wordt nog niet direct ondersteund.**

### DeepSeek-R1-Distill Modellen

DeepSeek-R1-Distill modellen kunnen op dezelfde manier worden gebruikt als Qwen- of Llama-modellen.

U kunt bijvoorbeeld eenvoudig een service starten met [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

U kunt ook eenvoudig een service starten met [SGLang](https://github.com/sgl-project/sglang)

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Gebruik aanbevelingen

**Wij raden aan om de volgende configuraties te hanteren bij het gebruik van de DeepSeek-R1-seriemodellen, inclusief benchmarking, om de verwachte prestaties te bereiken:**

1. Stel de temperatuur in het bereik van 0.5-0.7 (0.6 wordt aanbevolen) om eindeloze herhalingen of incoherente output te voorkomen.
2. **Voeg geen systeem prompt toe; alle instructies moeten binnen de gebruikersprompt staan.**
3. Voor wiskundige problemen is het raadzaam om een instructie toe te voegen zoals: "Graag stap voor stap redeneren en geef je uiteindelijke antwoord in \boxed{}."
4. Bij het evalueren van de modelprestaties wordt aanbevolen om meerdere tests uit te voeren en de resultaten te middelen.

Daarnaast hebben we geconstateerd dat de DeepSeek-R1-seriemodellen de denkpatronen (d.w.z. output van "\<think\>\n\n\</think\>") soms overslaan bij bepaalde vragen, wat de prestaties negatief kan beïnvloeden.
**Om ervoor te zorgen dat het model grondig redeneert, raden we aan het model te verplichten om elk antwoord te beginnen met "\<think\>\n".**

### Officiële Prompts
In de officiële DeepSeek web/app gebruiken we geen systeem prompts, maar ontwerpen we twee specifieke prompts voor bestandsupload en webzoekopdrachten voor een betere gebruikerservaring. Daarnaast is de temperatuur in web/app ingesteld op 0.6.

Voor bestandsupload, volg het sjabloon om prompts te maken, waarbij {file_name}, {file_content} en {question} argumenten zijn.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Voor webzoekopdrachten zijn {search_results}, {cur_date} en {question} argumenten.

Voor Chinese vragen gebruiken we de prompt:
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

Voor Engelse vragen gebruiken we de prompt:
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

## 7. Licentie
Deze coderepository en de modelgewichten vallen onder de [MIT-licentie](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).
DeepSeek-R1-serie ondersteunt commercieel gebruik, staat alle aanpassingen en afgeleide werken toe, inclusief, maar niet beperkt tot, distillatie voor het trainen van andere LLM's. Let op:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B en DeepSeek-R1-Distill-Qwen-32B zijn afgeleid van de [Qwen-2.5 serie](https://github.com/QwenLM/Qwen2.5), die oorspronkelijk onder de [Apache 2.0 Licentie](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE) vallen, en nu zijn verfijnd met 800k samples samengesteld met DeepSeek-R1.
- DeepSeek-R1-Distill-Llama-8B is afgeleid van Llama3.1-8B-Base en valt oorspronkelijk onder de [Llama3.1 licentie](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B is afgeleid van Llama3.3-70B-Instruct en valt oorspronkelijk onder de [Llama3.3 licentie](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Referentie
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
Als u vragen heeft, open dan een issue of neem contact met ons op via [service@deepseek.com](mailto:service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---