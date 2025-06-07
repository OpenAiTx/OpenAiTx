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

## 1. Introduzione

Presentiamo i nostri modelli di ragionamento di prima generazione, DeepSeek-R1-Zero e DeepSeek-R1.
DeepSeek-R1-Zero, un modello addestrato tramite apprendimento per rinforzo (RL) su larga scala senza fine-tuning supervisionato (SFT) come fase preliminare, ha dimostrato prestazioni notevoli nel ragionamento.
Con RL, DeepSeek-R1-Zero ha sviluppato naturalmente numerosi comportamenti di ragionamento potenti e interessanti.
Tuttavia, DeepSeek-R1-Zero incontra sfide quali ripetizioni infinite, scarsa leggibilità e mescolanza di lingue. Per affrontare questi problemi e migliorare ulteriormente le prestazioni di ragionamento,
presentiamo DeepSeek-R1, che incorpora dati di cold-start prima del RL.
DeepSeek-R1 raggiunge prestazioni paragonabili a OpenAI-o1 in compiti di matematica, codice e ragionamento.
Per supportare la comunità di ricerca, abbiamo open-sourciato DeepSeek-R1-Zero, DeepSeek-R1 e sei modelli densi distillati da DeepSeek-R1 basati su Llama e Qwen. DeepSeek-R1-Distill-Qwen-32B supera OpenAI-o1-mini su vari benchmark, raggiungendo nuovi risultati all'avanguardia per i modelli densi.

**NOTA: Prima di eseguire localmente i modelli della serie DeepSeek-R1, consigliamo vivamente di consultare la sezione [Raccomandazioni d'Uso](#usage-recommendations).**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Riepilogo del Modello

---

**Post-Training: Apprendimento per Rinforzo su Larga Scala sul Modello Base**

-  Applichiamo direttamente l'apprendimento per rinforzo (RL) al modello base senza ricorrere al fine-tuning supervisionato (SFT) come fase preliminare. Questo approccio permette al modello di esplorare chain-of-thought (CoT) per risolvere problemi complessi, portando allo sviluppo di DeepSeek-R1-Zero. DeepSeek-R1-Zero dimostra capacità come auto-verifica, riflessione e generazione di lunghi CoT, segnando un traguardo significativo per la comunità di ricerca. In particolare, è la prima ricerca aperta a validare che le capacità di ragionamento degli LLM possono essere incentivate puramente tramite RL, senza la necessità di SFT. Questa svolta apre la strada a futuri sviluppi in questo settore.

-   Presentiamo la nostra pipeline per sviluppare DeepSeek-R1. La pipeline incorpora due fasi RL mirate a scoprire schemi di ragionamento migliorati e allinearsi con le preferenze umane, oltre a due fasi SFT che fungono da seme per le capacità di ragionamento e non ragionamento del modello.
    Riteniamo che la pipeline porterà benefici all'industria creando modelli migliori.

---

**Distillazione: Anche i Modelli più Piccoli Possono Essere Potenti**

-  Dimostriamo che gli schemi di ragionamento dei modelli più grandi possono essere distillati in modelli più piccoli, ottenendo prestazioni migliori rispetto agli schemi di ragionamento scoperti tramite RL su modelli piccoli. Il DeepSeek-R1 open source, così come la sua API, saranno utili alla comunità di ricerca per distillare in futuro modelli piccoli migliori.
- Utilizzando i dati di ragionamento generati da DeepSeek-R1, abbiamo fine-tunato diversi modelli densi ampiamente utilizzati nella comunità di ricerca. I risultati della valutazione dimostrano che i modelli densi distillati più piccoli si comportano eccezionalmente bene nei benchmark. Rilasciamo open source checkpoint distillati 1.5B, 7B, 8B, 14B, 32B e 70B basati sulle serie Qwen2.5 e Llama3 alla comunità.

## 3. Download dei Modelli

### Modelli DeepSeek-R1

<div align="center">

| **Modello** | **#Parametri Totali** | **#Parametri Attivati** | **Lunghezza Contesto** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 sono addestrati sulla base di DeepSeek-V3-Base.
Per maggiori dettagli sull'architettura del modello, consultare il repository [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### Modelli DeepSeek-R1-Distill

<div align="center">

| **Modello** | **Modello Base** | **Download** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

I modelli DeepSeek-R1-Distill sono fine-tunati su modelli open-source, utilizzando campioni generati da DeepSeek-R1.
Abbiamo modificato leggermente le loro configurazioni e tokenizer. Si prega di utilizzare le nostre impostazioni per eseguire questi modelli.

## 4. Risultati della Valutazione

### DeepSeek-R1-Evaluation
Per tutti i nostri modelli, la lunghezza massima di generazione è impostata a 32.768 token. Per i benchmark che richiedono campionamento, utilizziamo una temperatura di $0.6$, un valore top-p di $0.95$ e generiamo 64 risposte per query per stimare pass@1.
<div align="center">


| Categoria | Benchmark (Metrica) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Architettura | - | - | MoE | - | - | MoE |
| | # Parametri Attivati | - | - | 37B | - | - | 37B |
| | # Parametri Totali | - | - | 671B | - | - | 671B |
| Inglese | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Codice | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Matematica | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Cinese | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Valutazione dei Modelli Distillati

<div align="center">

| Modello                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
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

## 5. Sito Chat & Piattaforma API
Puoi chattare con DeepSeek-R1 sul sito ufficiale di DeepSeek: [chat.deepseek.com](https://chat.deepseek.com), e attivare il pulsante "DeepThink".

Forniamo anche una API compatibile OpenAI sulla piattaforma DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Come Eseguire Localmente

### Modelli DeepSeek-R1

Visita il repository [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) per maggiori informazioni sull'esecuzione locale di DeepSeek-R1.

**NOTA: Hugging Face Transformers non è ancora supportato direttamente.**

### Modelli DeepSeek-R1-Distill

I modelli DeepSeek-R1-Distill possono essere utilizzati allo stesso modo dei modelli Qwen o Llama.

Ad esempio, puoi avviare facilmente un servizio usando [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

Puoi anche avviare facilmente un servizio usando [SGLang](https://github.com/sgl-project/sglang)

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Raccomandazioni d'Uso

**Raccomandiamo di attenersi alle seguenti configurazioni durante l'utilizzo dei modelli della serie DeepSeek-R1, inclusi i benchmark, per ottenere le prestazioni attese:**

1. Impostare la temperatura nell'intervallo 0.5-0.7 (0.6 è raccomandato) per evitare ripetizioni infinite o output incoerenti.
2. **Evitare di aggiungere un prompt di sistema; tutte le istruzioni devono essere contenute nel prompt dell'utente.**
3. Per problemi matematici, si consiglia di includere una direttiva nel prompt come: "Per favore ragiona passo dopo passo e inserisci la risposta finale all'interno di \boxed{}."
4. Durante la valutazione delle prestazioni del modello, si raccomanda di condurre più test e fare una media dei risultati.

Inoltre, abbiamo osservato che i modelli della serie DeepSeek-R1 tendono a saltare il pattern di pensiero (cioè l'output di "\<think\>\n\n\</think\>") quando rispondono a determinate query, il che può influire negativamente sulle prestazioni del modello.
**Per assicurarsi che il modello effettui un ragionamento approfondito, si consiglia di forzare il modello a iniziare ogni risposta con "\<think\>\n" all'inizio di ogni output.**

### Prompt Ufficiali
Nella versione web/app ufficiale di DeepSeek non utilizziamo prompt di sistema, ma progettiamo due prompt specifici per il caricamento file e la ricerca web per una migliore esperienza utente. Inoltre, la temperatura in web/app è 0.6.

Per il caricamento file, segui il template per creare i prompt, dove {file_name}, {file_content} e {question} sono argomenti.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Per la Ricerca Web, {search_results}, {cur_date} e {question} sono argomenti.

Per query in cinese, usiamo il prompt:
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

Per query in inglese, usiamo il prompt:
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

## 7. Licenza
Questo repository di codice e i pesi del modello sono rilasciati con licenza [MIT License](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).
La serie DeepSeek-R1 supporta l'uso commerciale e consente qualsiasi modifica e opera derivata, inclusa, ma non limitata a, distillazione per l'addestramento di altri LLM. Si noti che:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B e DeepSeek-R1-Distill-Qwen-32B sono derivati dalla [serie Qwen-2.5](https://github.com/QwenLM/Qwen2.5), originariamente rilasciata con licenza [Apache 2.0 License](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE), e ora fine-tunati con 800k campioni curati con DeepSeek-R1.
- DeepSeek-R1-Distill-Llama-8B è derivato da Llama3.1-8B-Base ed è originariamente rilasciato con licenza [Llama3.1 license](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B è derivato da Llama3.3-70B-Instruct ed è originariamente rilasciato con licenza [Llama3.3 license](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Citazione
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

## 9. Contatti
Se hai domande, apri una issue o contattaci a [service@deepseek.com](mailto:service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---