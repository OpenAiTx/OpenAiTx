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

## 1. Einführung

Wir stellen unsere erste Generation von Reasoning-Modellen vor: DeepSeek-R1-Zero und DeepSeek-R1.  
DeepSeek-R1-Zero, ein Modell, das mittels groß angelegtem Reinforcement Learning (RL) ohne vorheriges überwacht-feingetuntes Training (SFT) trainiert wurde, zeigte bemerkenswerte Leistungen im Reasoning-Bereich.  
Durch RL hat DeepSeek-R1-Zero auf natürliche Weise zahlreiche leistungsstarke und interessante Reasoning-Verhaltensweisen entwickelt.  
Allerdings stößt DeepSeek-R1-Zero auf Herausforderungen wie endlose Wiederholungen, geringe Lesbarkeit und Sprachmischungen. Um diese Probleme zu adressieren und die Reasoning-Performance weiter zu verbessern,  
führen wir DeepSeek-R1 ein, das vor dem RL Cold-Start-Daten einbindet.  
DeepSeek-R1 erreicht eine Performance, die mit OpenAI-o1 bei Mathematik-, Code- und Reasoning-Aufgaben vergleichbar ist.  
Zur Unterstützung der Forschungsgemeinschaft haben wir DeepSeek-R1-Zero, DeepSeek-R1 und sechs aus DeepSeek-R1 destillierte dichte Modelle auf Basis von Llama und Qwen als Open Source freigegeben. DeepSeek-R1-Distill-Qwen-32B übertrifft OpenAI-o1-mini in verschiedenen Benchmarks und erzielt neue State-of-the-Art-Ergebnisse für dichte Modelle.

**HINWEIS: Bevor Sie die Modelle der DeepSeek-R1-Serie lokal ausführen, empfehlen wir, den Abschnitt [Nutzungsempfehlungen](#usage-recommendations) zu lesen.**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Modellübersicht

---

**Post-Training: Groß angelegtes Reinforcement Learning auf dem Basismodell**

-  Wir wenden Reinforcement Learning (RL) direkt auf das Basismodell an, ohne als vorbereitenden Schritt auf überwacht-feingetuntes Training (SFT) zurückzugreifen. Dieser Ansatz ermöglicht es dem Modell, Chain-of-Thought (CoT) zur Lösung komplexer Probleme zu erkunden, was zur Entwicklung von DeepSeek-R1-Zero geführt hat. DeepSeek-R1-Zero demonstriert Fähigkeiten wie Selbstüberprüfung, Reflexion und die Generierung langer CoTs und markiert damit einen bedeutenden Meilenstein für die Forschungsgemeinschaft. Besonders hervorzuheben ist, dass dies die erste offene Forschung ist, die bestätigt, dass Reasoning-Fähigkeiten von LLMs allein durch RL und ohne SFT gefördert werden können. Dieser Durchbruch ebnet den Weg für zukünftige Fortschritte auf diesem Gebiet.

-   Wir stellen unsere Pipeline zur Entwicklung von DeepSeek-R1 vor. Die Pipeline umfasst zwei RL-Phasen, die darauf abzielen, verbesserte Reasoning-Muster zu entdecken und sich an menschliche Präferenzen anzupassen, sowie zwei SFT-Phasen, die als Grundlage für die Reasoning- und Nicht-Reasoning-Fähigkeiten des Modells dienen.  
    Wir sind überzeugt, dass diese Pipeline der Industrie zugutekommt, indem sie bessere Modelle schafft.

---

**Distillation: Auch kleinere Modelle können leistungsstark sein**

-  Wir zeigen, dass die Reasoning-Muster größerer Modelle in kleinere Modelle destilliert werden können, was zu einer besseren Leistung im Vergleich zu durch RL auf kleinen Modellen entdeckten Reasoning-Mustern führt. Das Open-Source-Modell DeepSeek-R1 sowie dessen API werden der Forschungsgemeinschaft dabei helfen, künftig bessere kleinere Modelle zu destillieren.
- Mit den von DeepSeek-R1 generierten Reasoning-Daten haben wir mehrere dichte Modelle, die in der Forschungsgemeinschaft weit verbreitet sind, feinabgestimmt. Die Auswertungsergebnisse zeigen, dass die destillierten kleineren dichten Modelle in Benchmarks außergewöhnlich gut abschneiden. Wir veröffentlichen destillierte 1.5B-, 7B-, 8B-, 14B-, 32B- und 70B-Checkpoints auf Basis der Qwen2.5- und Llama3-Serien als Open Source für die Community.

## 3. Modelldownloads

### DeepSeek-R1-Modelle

<div align="center">

| **Modell** | **#Gesamtparameter** | **#Aktivierte Parameter** | **Kontextlänge** | **Download** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero & DeepSeek-R1 wurden auf Basis von DeepSeek-V3-Base trainiert.  
Für weitere Details zur Modellarchitektur siehe das Repository [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### DeepSeek-R1-Distill-Modelle

<div align="center">

| **Modell** | **Basismodell** | **Download** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

Die DeepSeek-R1-Distill-Modelle wurden auf Basis von Open-Source-Modellen mit von DeepSeek-R1 generierten Beispielen feinabgestimmt.
Wir haben ihre Konfigurationen und Tokenizer leicht angepasst. Bitte verwenden Sie unsere Einstellungen, um diese Modelle auszuführen.

## 4. Auswertungsergebnisse

### DeepSeek-R1-Evaluation
Für alle unsere Modelle ist die maximale Generierungslänge auf 32.768 Tokens festgelegt. Für Benchmarks, die Sampling erfordern, verwenden wir eine Temperatur von $0.6$, einen Top-p-Wert von $0.95$ und generieren 64 Antworten pro Anfrage, um pass@1 zu schätzen.
<div align="center">


| Kategorie | Benchmark (Metrik) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Architektur | - | - | MoE | - | - | MoE |
| | # Aktivierte Parameter | - | - | 37B | - | - | 37B |
| | # Gesamtparameter | - | - | 671B | - | - | 671B |
| Englisch | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
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
| | Codeforces (Perzentil) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Mathematik | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Chinesisch | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Auswertung der destillierten Modelle


<div align="center">

| Modell                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
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


## 5. Chat-Website & API-Plattform
Sie können mit DeepSeek-R1 auf der offiziellen DeepSeek-Website chatten: [chat.deepseek.com](https://chat.deepseek.com), und dabei die Schaltfläche "DeepThink" aktivieren.

Wir bieten außerdem eine OpenAI-kompatible API auf der DeepSeek-Plattform an: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Lokale Ausführung

### DeepSeek-R1-Modelle

Bitte besuchen Sie das [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) Repository für weitere Informationen zur lokalen Ausführung von DeepSeek-R1.

**HINWEIS: Hugging Face Transformers werden derzeit noch nicht direkt unterstützt.**

### DeepSeek-R1-Distill-Modelle

Die DeepSeek-R1-Distill-Modelle können auf die gleiche Weise wie Qwen- oder Llama-Modelle verwendet werden.

Zum Beispiel können Sie mit [vLLM](https://github.com/vllm-project/vllm) ganz einfach einen Service starten:

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

Sie können auch ganz einfach einen Service mit [SGLang](https://github.com/sgl-project/sglang) starten:

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Nutzungsempfehlungen

**Wir empfehlen, bei der Verwendung der DeepSeek-R1-Modelle, einschließlich Benchmarking, die folgenden Konfigurationen einzuhalten, um die erwartete Leistung zu erzielen:**

1. Setzen Sie die Temperatur im Bereich von 0,5–0,7 (0,6 empfohlen), um endlose Wiederholungen oder inkohärente Ausgaben zu vermeiden.
2. **Verzichten Sie auf einen System-Prompt; alle Anweisungen sollten im User-Prompt enthalten sein.**
3. Für mathematische Aufgaben empfiehlt es sich, im Prompt eine Direktive wie folgt einzufügen: "Bitte argumentiere Schritt für Schritt und schreibe deine Endantwort in \boxed{}."
4. Bei der Bewertung der Modellleistung empfiehlt es sich, mehrere Tests durchzuführen und die Ergebnisse zu mitteln.

Zusätzlich haben wir beobachtet, dass die DeepSeek-R1-Modelle dazu neigen, das Denk-Muster (d.h. Ausgabe von "\<think\>\n\n\</think\>") bei bestimmten Anfragen zu umgehen, was die Modellleistung beeinträchtigen kann.
**Um sicherzustellen, dass das Modell gründlich argumentiert, empfehlen wir, das Modell zu zwingen, jede Ausgabe mit "\<think\>\n" zu beginnen.**

### Offizielle Prompts
In der offiziellen DeepSeek-Webanwendung verwenden wir keine Systemprompts, sondern gestalten zwei spezifische Prompts für Datei-Upload und Websuche, um eine bessere Nutzererfahrung zu gewährleisten. Außerdem ist die Temperatur in der Web/App auf 0,6 eingestellt.

Für Datei-Uploads folgen Sie bitte der Vorlage, wobei {file_name}, {file_content} und {question} Parameter sind. 
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Für die Websuche sind {search_results}, {cur_date} und {question} Parameter.

Für chinesische Anfragen verwenden wir folgenden Prompt:
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

Für englische Anfragen verwenden wir folgenden Prompt:
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

## 7. Lizenz
Dieses Code-Repository und die Modellgewichte stehen unter der [MIT-Lizenz](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).  
Die DeepSeek-R1-Serie unterstützt kommerzielle Nutzung und erlaubt jegliche Modifikationen und abgeleitete Arbeiten, einschließlich, aber nicht beschränkt auf Destillation zum Training anderer LLMs. Bitte beachten Sie:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B und DeepSeek-R1-Distill-Qwen-32B sind abgeleitet von der [Qwen-2.5-Serie](https://github.com/QwenLM/Qwen2.5), die ursprünglich unter der [Apache 2.0 Lizenz](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE) lizenziert ist und jetzt mit 800k Beispielen, die mit DeepSeek-R1 kuratiert wurden, feingetunt wurden.
- DeepSeek-R1-Distill-Llama-8B ist abgeleitet von Llama3.1-8B-Base und ursprünglich lizenziert unter der [Llama3.1-Lizenz](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B ist abgeleitet von Llama3.3-70B-Instruct und ursprünglich lizenziert unter der [Llama3.3-Lizenz](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Zitieren
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

## 9. Kontakt
Wenn Sie Fragen haben, eröffnen Sie bitte ein Issue oder kontaktieren Sie uns unter [service@deepseek.com](mailto:service@deepseek.com).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---