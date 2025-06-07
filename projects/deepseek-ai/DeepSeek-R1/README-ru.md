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

## 1. Введение

Мы представляем наши модели первого поколения для рассуждения — DeepSeek-R1-Zero и DeepSeek-R1.
DeepSeek-R1-Zero, модель, обученная с помощью крупномасштабного обучения с подкреплением (RL) без предварительной дообработки с учителем (SFT), продемонстрировала выдающиеся результаты в задачах рассуждения.
Благодаря RL, DeepSeek-R1-Zero естественным образом приобрела множество мощных и интересных способностей к рассуждению.
Однако DeepSeek-R1-Zero сталкивается с такими проблемами, как бесконечное повторение, низкая читаемость и смешение языков. Чтобы решить эти проблемы и еще больше повысить производительность рассуждения,
мы представляем DeepSeek-R1, которая использует cold-start данные перед RL.
DeepSeek-R1 достигает производительности, сопоставимой с OpenAI-o1, в задачах по математике, программированию и рассуждению.
В поддержку исследовательского сообщества мы открыли исходные коды DeepSeek-R1-Zero, DeepSeek-R1 и шести плотных моделей, дистиллированных из DeepSeek-R1 на базе Llama и Qwen. DeepSeek-R1-Distill-Qwen-32B превосходит OpenAI-o1-mini по различным бенчмаркам, достигая новых рекордных результатов для плотных моделей.

**ПРИМЕЧАНИЕ: Перед запуском моделей серии DeepSeek-R1 локально мы рекомендуем ознакомиться с разделом [Рекомендации по использованию](#usage-recommendations).**

<p align="center">
  <img width="80%" src="figures/benchmark.jpg">
</p>

## 2. Краткое описание моделей

---

**Постобработка: Крупномасштабное обучение с подкреплением на базовой модели**

-  Мы непосредственно применяем обучение с подкреплением (RL) к базовой модели без предварительного этапа обучения с учителем (SFT). Такой подход позволяет модели исследовать цепочку рассуждений (CoT) для решения сложных задач, что приводит к созданию DeepSeek-R1-Zero. DeepSeek-R1-Zero демонстрирует такие способности, как самопроверка, рефлексия и генерация длинных цепочек рассуждений, что является значительным достижением для исследовательского сообщества. Примечательно, что это первое открытое исследование, подтверждающее, что возможности рассуждения LLM могут быть стимулированы только с помощью RL, без необходимости SFT. Этот прорыв открывает путь для дальнейших достижений в этой области.

-   Мы представляем наш pipeline для разработки DeepSeek-R1. Pipeline включает два этапа RL, направленных на выявление улучшенных шаблонов рассуждения и согласование с человеческими предпочтениями, а также два этапа SFT, которые задают начальные способности модели к рассуждению и нерассуждению.
    Мы считаем, что pipeline принесет пользу индустрии, создавая лучшие модели.

---

**Дистилляция: Маленькие модели тоже могут быть мощными**

-  Мы показываем, что шаблоны рассуждений крупных моделей могут быть дистиллированы в меньшие модели, что приводит к лучшей производительности по сравнению с шаблонами рассуждений, найденными через RL на маленьких моделях. Открытый исходный код DeepSeek-R1, а также его API, будут полезны исследовательскому сообществу для дистилляции лучших меньших моделей в будущем.
- Используя данные рассуждений, сгенерированные DeepSeek-R1, мы дообучили несколько плотных моделей, которые широко используются в исследовательском сообществе. Результаты оценки показывают, что дистиллированные меньшие плотные модели демонстрируют выдающиеся результаты на бенчмарках. Мы открываем исходные контрольные точки дистиллированных моделей 1.5B, 7B, 8B, 14B, 32B и 70B на базе Qwen2.5 и серии Llama3 для сообщества.

## 3. Загрузка моделей

### Модели DeepSeek-R1

<div align="center">

| **Модель** | **Всего параметров** | **Активных параметров** | **Длина контекста** | **Скачать** |
| :------------: | :------------: | :------------: | :------------: | :------------: |
| DeepSeek-R1-Zero | 671B | 37B | 128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Zero)   |
| DeepSeek-R1   | 671B | 37B |  128K   | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1)   |

</div>

DeepSeek-R1-Zero и DeepSeek-R1 обучены на базе DeepSeek-V3-Base.
Для получения дополнительной информации о архитектуре модели, пожалуйста, обратитесь к репозиторию [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3).

### Модели DeepSeek-R1-Distill

<div align="center">

| **Модель** | **Базовая модель** | **Скачать** |
| :------------: | :------------: | :------------: |
| DeepSeek-R1-Distill-Qwen-1.5B  | [Qwen2.5-Math-1.5B](https://huggingface.co/Qwen/Qwen2.5-Math-1.5B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-1.5B)   |
| DeepSeek-R1-Distill-Qwen-7B  | [Qwen2.5-Math-7B](https://huggingface.co/Qwen/Qwen2.5-Math-7B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-7B)   |
| DeepSeek-R1-Distill-Llama-8B  | [Llama-3.1-8B](https://huggingface.co/meta-llama/Llama-3.1-8B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-8B)   |
| DeepSeek-R1-Distill-Qwen-14B   | [Qwen2.5-14B](https://huggingface.co/Qwen/Qwen2.5-14B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-14B)   |
|DeepSeek-R1-Distill-Qwen-32B  | [Qwen2.5-32B](https://huggingface.co/Qwen/Qwen2.5-32B) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Qwen-32B)   |
| DeepSeek-R1-Distill-Llama-70B  | [Llama-3.3-70B-Instruct](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct) | [🤗 HuggingFace](https://huggingface.co/deepseek-ai/DeepSeek-R1-Distill-Llama-70B)   |

</div>

Модели DeepSeek-R1-Distill дообучены на базе открытых моделей с использованием примеров, сгенерированных DeepSeek-R1.
Мы немного изменили их конфигурации и токенизаторы. Пожалуйста, используйте наши настройки для запуска этих моделей.

## 4. Результаты оценки

### Оценка DeepSeek-R1
Для всех наших моделей максимальная длина генерации установлена на 32 768 токенов. Для бенчмарков, требующих сэмплирования, мы используем температуру $0.6$, top-p значение $0.95$ и генерируем 64 ответа на каждый запрос для оценки pass@1.
<div align="center">


| Категория | Бенчмарк (метрика) | Claude-3.5-Sonnet-1022 | GPT-4o 0513 | DeepSeek V3 | OpenAI o1-mini | OpenAI o1-1217 | DeepSeek R1 |
|----------|-------------------|----------------------|------------|--------------|----------------|------------|--------------|
| | Архитектура | - | - | MoE | - | - | MoE |
| | Активных параметров | - | - | 37B | - | - | 37B |
| | Всего параметров | - | - | 671B | - | - | 671B |
| Английский | MMLU (Pass@1) | 88.3 | 87.2 | 88.5 | 85.2 | **91.8** | 90.8 |
| | MMLU-Redux (EM) | 88.9 | 88.0 | 89.1 | 86.7 | - | **92.9** |
| | MMLU-Pro (EM) | 78.0 | 72.6 | 75.9 | 80.3 | - | **84.0** |
| | DROP (3-shot F1) | 88.3 | 83.7 | 91.6 | 83.9 | 90.2 | **92.2** |
| | IF-Eval (Prompt Strict) | **86.5** | 84.3 | 86.1 | 84.8 | - | 83.3 |
| | GPQA-Diamond (Pass@1) | 65.0 | 49.9 | 59.1 | 60.0 | **75.7** | 71.5 |
| | SimpleQA (Correct) | 28.4 | 38.2 | 24.9 | 7.0 | **47.0** | 30.1 |
| | FRAMES (Acc.) | 72.5 | 80.5 | 73.3 | 76.9 | - | **82.5** |
| | AlpacaEval2.0 (LC-winrate) | 52.0 | 51.1 | 70.0 | 57.8 | - | **87.6** |
| | ArenaHard (GPT-4-1106) | 85.2 | 80.4 | 85.5 | 92.0 | - | **92.3** |
| Код | LiveCodeBench (Pass@1-COT) | 33.8 | 34.2 | - | 53.8 | 63.4 | **65.9** |
| | Codeforces (Percentile) | 20.3 | 23.6 | 58.7 | 93.4 | **96.6** | 96.3 |
| | Codeforces (Rating) | 717 | 759 | 1134 | 1820 | **2061** | 2029 |
| | SWE Verified (Resolved) | **50.8** | 38.8 | 42.0 | 41.6 | 48.9 | 49.2 |
| | Aider-Polyglot (Acc.) | 45.3 | 16.0 | 49.6 | 32.9 | **61.7** | 53.3 |
| Математика | AIME 2024 (Pass@1) | 16.0 | 9.3 | 39.2 | 63.6 | 79.2 | **79.8** |
| | MATH-500 (Pass@1) | 78.3 | 74.6 | 90.2 | 90.0 | 96.4 | **97.3** |
| | CNMO 2024 (Pass@1) | 13.1 | 10.8 | 43.2 | 67.6 | - | **78.8** |
| Китайский | CLUEWSC (EM) | 85.4 | 87.9 | 90.9 | 89.9 | - | **92.8** |
| | C-Eval (EM) | 76.7 | 76.0 | 86.5 | 68.9 | - | **91.8** |
| | C-SimpleQA (Correct) | 55.4 | 58.7 | **68.0** | 40.3 | - | 63.7 |

</div>


### Оценка дистиллированных моделей


<div align="center">

| Модель                                    | AIME 2024 pass@1 | AIME 2024 cons@64 | MATH-500 pass@1 | GPQA Diamond pass@1 | LiveCodeBench pass@1 | CodeForces rating |
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


## 5. Чат-сайт и API-платформа
Вы можете общаться с DeepSeek-R1 на официальном сайте DeepSeek: [chat.deepseek.com](https://chat.deepseek.com), переключив кнопку "DeepThink"

Мы также предоставляем OpenAI-совместимый API на платформе DeepSeek: [platform.deepseek.com](https://platform.deepseek.com/)

## 6. Как запустить локально

### Модели DeepSeek-R1

Пожалуйста, посетите репозиторий [DeepSeek-V3](https://github.com/deepseek-ai/DeepSeek-V3) для получения дополнительной информации о запуске DeepSeek-R1 локально.

**ПРИМЕЧАНИЕ: Прямая поддержка Hugging Face Transformers пока отсутствует.**

### Модели DeepSeek-R1-Distill

Модели DeepSeek-R1-Distill можно использовать так же, как модели Qwen или Llama.

Например, вы можете легко запустить сервис с помощью [vLLM](https://github.com/vllm-project/vllm):

```shell
vllm serve deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --tensor-parallel-size 2 --max-model-len 32768 --enforce-eager
```

Вы также можете легко запустить сервис с помощью [SGLang](https://github.com/sgl-project/sglang)

```bash
python3 -m sglang.launch_server --model deepseek-ai/DeepSeek-R1-Distill-Qwen-32B --trust-remote-code --tp 2
```

### Рекомендации по использованию

**Мы рекомендуем придерживаться следующих конфигураций при использовании моделей серии DeepSeek-R1, включая бенчмаркинг, чтобы достичь ожидаемой производительности:**

1. Установите температуру в диапазоне 0.5–0.7 (рекомендуется 0.6), чтобы избежать бесконечных повторений или несвязных выводов.
2. **Избегайте добавления системного промпта; все инструкции должны быть включены в пользовательский промпт.**
3. Для математических задач рекомендуется добавить в промпт инструкцию: "Пожалуйста, рассуждайте шаг за шагом и поместите окончательный ответ в \boxed{}."
4. При оценке производительности модели рекомендуется проводить несколько тестов и усреднять результаты.

Кроме того, мы обнаружили, что модели серии DeepSeek-R1 склонны пропускать шаблон мышления (то есть выводить "\<think\>\n\n\</think\>") при ответе на определённые запросы, что может отрицательно сказаться на производительности модели.
**Чтобы гарантировать, что модель выполняет тщательное рассуждение, рекомендуется принудительно начинать ответ модели с "\<think\>\n" в начале каждого вывода.**

### Официальные промпты
В официальном веб/мобильном приложении DeepSeek мы не используем системные промпты, но разработали два специальных промпта для загрузки файлов и веб-поиска для лучшего пользовательского опыта. Кроме того, температура в веб/приложении составляет 0.6.

Для загрузки файла, пожалуйста, используйте следующий шаблон для создания промптов, где {file_name}, {file_content} и {question} — аргументы.
```
file_template = \
"""[file name]: {file_name}
[file content begin]
{file_content}
[file content end]
{question}"""
```

Для веб-поиска {search_results}, {cur_date} и {question} являются аргументами.

Для китайских запросов мы используем следующий промпт:
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

Для английских запросов мы используем следующий промпт:
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

## 7. Лицензия
Этот репозиторий кода и веса моделей лицензированы по [лицензии MIT](https://github.com/deepseek-ai/DeepSeek-R1/blob/main/LICENSE).
Серия DeepSeek-R1 поддерживает коммерческое использование, разрешает любые модификации и производные работы, включая, но не ограничиваясь, дистилляцией для обучения других LLM. Обратите внимание:
- DeepSeek-R1-Distill-Qwen-1.5B, DeepSeek-R1-Distill-Qwen-7B, DeepSeek-R1-Distill-Qwen-14B и DeepSeek-R1-Distill-Qwen-32B основаны на [серии Qwen-2.5](https://github.com/QwenLM/Qwen2.5), которая изначально лицензирована по [лицензии Apache 2.0](https://huggingface.co/Qwen/Qwen2.5-1.5B/blob/main/LICENSE), и теперь дообучена на 800 тыс. примерах, собранных с помощью DeepSeek-R1.
- DeepSeek-R1-Distill-Llama-8B основана на Llama3.1-8B-Base и изначально лицензирована по [лицензии Llama3.1](https://huggingface.co/meta-llama/Llama-3.1-8B/blob/main/LICENSE).
- DeepSeek-R1-Distill-Llama-70B основана на Llama3.3-70B-Instruct и изначально лицензирована по [лицензии Llama3.3](https://huggingface.co/meta-llama/Llama-3.3-70B-Instruct/blob/main/LICENSE).

## 8. Цитирование
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

## 9. Контакты
Если у вас есть вопросы, пожалуйста, создайте issue или свяжитесь с нами по адресу [service@deepseek.com](mailto:service@deepseek.com).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---