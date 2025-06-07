<div align="center">
 👋 Привет, всем! 
    verl — это библиотека для обучения с подкреплением (RL), инициированная <b>командой ByteDance Seed</b> и поддерживаемая сообществом verl.
    <br>
    <br>
</div>

<div align="center">

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="Ask DeepWiki.com" height="20"/>](https://deepwiki.com/volcengine/verl)
[![GitHub Repo stars](https://img.shields.io/github/stars/volcengine/verl)](https://github.com/volcengine/verl/stargazers)
[![Twitter](https://img.shields.io/twitter/follow/verl_project)](https://twitter.com/verl_project)
<a href="https://join.slack.com/t/verlgroup/shared_invite/zt-2w5p9o4c3-yy0x2Q56s_VlGLsJ93A6vA"><img src="https://img.shields.io/badge/Slack-verl-blueviolet?logo=slack&amp"></a>
<a href="https://arxiv.org/pdf/2409.19256"><img src="https://img.shields.io/static/v1?label=EuroSys&message=Paper&color=red"></a>
[![Документация](https://img.shields.io/badge/documentation-blue)](https://verl.readthedocs.io/en/latest/)
<a href="https://raw.githubusercontent.com/eric-haibin-lin/verl-community/refs/heads/main/WeChat.JPG"><img src="https://img.shields.io/badge/微信-green?logo=wechat&amp"></a>

</div>

![seed logo](https://github.com/user-attachments/assets/c42e675e-497c-4508-8bb9-093ad4d1f216)

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning для LLM</h1>

verl — это гибкая, эффективная и готовая к промышленному использованию библиотека RL для обучения крупных языковых моделей (LLM).

verl — это открытая версия статьи **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl отличается гибкостью и простотой:

- **Простое расширение различных RL-алгоритмов**: Гибридная модель контроллера позволяет гибко представлять и эффективно выполнять сложные пайплайны пост-обучения. Сборка RL пайплайнов, таких как GRPO, PPO, возможна в несколько строк кода.

- **Бесшовная интеграция существующей LLM-инфраструктуры с модульными API**: Разделяет вычислительные и датовые зависимости, позволяя интеграцию с существующими LLM-фреймворками, такими как FSDP, Megatron-LM, vLLM, SGLang и др.

- **Гибкое распределение устройств**: Поддерживает различные размещения моделей на разных GPU для эффективного использования ресурсов и масштабирования на кластерах разного размера.

- Готовая интеграция с популярными моделями HuggingFace

verl быстрый благодаря:

- **Передовой пропускной способности**: Интеграция с передовыми движками обучения и вывода LLM и современная производительность RL.

- **Эффективный пересчет актор-моделей с помощью 3D-HybridEngine**: Устраняет избыточность памяти и значительно снижает затраты на коммуникацию при переходах между фазами обучения и генерации.

</p>

## Новости

- [2025/06] verl с бэкендом Megatron поддерживает большие MoE-модели, такие как [DeepSeek-671b и Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] команда verl представит последние обновления проекта на [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) 7 июня. Встречайте нашу команду в Пекине!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), принятый на ICML 2025, теперь поддерживается в verl! PF-PPO повышает эффективность и надежность обучения политик, фильтруя шумные сигналы награды и повторно используя качественный опыт через replay buffer.
- [2025/04] Мы проведём туториал по современным пост-тренинговым техникам и программированию для verl на [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) и [LMSys afterparty](https://lu.ma/d23nyynm). Материалы доступны [здесь](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] Выпущен технический отчёт [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf)! Модель обучена с помощью verl, Seed-Thinking-v1.5 достигает 86.7 на AIME 2024, 55.0 на Codeforces и 77.3 на GPQA, демонстрируя отличные способности к рассуждению в STEM и программировании. Метод также показывает хорошую обобщаемость в разных доменах.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) — статья о нашем новом RL-методе для моделей рассуждения. Модель VAPO, обученная на Qwen-32B-base, достигает 60.4 на AIME 2024, опережая DAPO-32B.
- [2025/03] Выпущен verl v0.3.0.post1! См. [заметки о релизе](https://github.com/volcengine/verl/releases/). Скорость работы [~1.4x выше](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) по сравнению с предыдущими версиями.
- [2025/03] [DAPO](https://dapo-sia.github.io/) — открытый SOTA RL-алгоритм, достигающий 50 баллов на AIME 2024 на модели Qwen2.5-32B, превосходя предыдущий SOTA DeepSeek GRPO (DeepSeek-R1-Zero-Qwen-32B). DAPO обучается полностью на базе verl, код воспроизведения доступен в `recipe/dapo`.
<details><summary> ещё... </summary>
<ul>
  <li>[2025/05] verl будет представлен на [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) 16–17 мая.</li>
  <li>[2025/05] verl будет представлен на [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). Увидимся в Париже! </li>
  <li>[2025/03] Мы представили программную модель verl на [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) и [обзор verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) на [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) в Саннивейле в марте.</li>
  <li>[2025/03] Мы представим verl (HybridFlow) на EuroSys 2025. Увидимся в Роттердаме!</li>
  <li>[2025/02] Выпущен verl v0.2.0.post2!</li>
  <li>[2025/02] Мы представили verl на <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. До встречи в Сан-Хосе!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) выпущен с SOTA-уровнем производительности на LLM и VLM. RL-модель обучена с помощью verl, достигнув уровня OpenAI O1 на математических бенчмарках (70.0 pass@1 на AIME).</li>
  <li>[2024/12] verl был представлен на Ray Forward 2024. Слайды доступны <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">здесь</a></li>
  <li>[2024/12] Команда представила <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> на NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Слайды</a> и <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">видео</a> доступны.</li>
  <li>[2024/10] verl был представлен на Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Видео на Youtube</a> доступно.</li>
  <li>[2024/08] HybridFlow (verl) принят на EuroSys 2025.</li>
</ul>   
</details>

## Ключевые возможности

- **FSDP**, **FSDP2** и **Megatron-LM** для обучения.
- **vLLM**, **SGLang** и **HF Transformers** для генерации rollout.
- Совместимость с Hugging Face Transformers и Modelscope Hub: [Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM и др.
- Супервизионное дообучение.
- Обучение с подкреплением: [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), и др.
  - Поддержка моделей награды и функций награды (верифицируемая награда) для математики, [программирования](https://github.com/volcengine/verl/tree/main/recipe/dapo) и др.
  - Поддержка vision-language моделей (VLMs) и [мультимодального RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) с Qwen2.5-vl, Kimi-VL
  - [Мультиходовой RL с вызовом инструментов](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- Рецепты выравнивания LLM, например, [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) через DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Масштабируемость до моделей 671B и сотен GPU с помощью [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Мульти-GPU [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) для экономии памяти.
- Трекинг экспериментов: wandb, swanlab, mlflow и tensorboard.

## Грядущие возможности и изменения

- Дорожная карта https://github.com/volcengine/verl/issues/710
- Оптимизации DeepSeek 671b с Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Мультиходовой rollout и инструменты https://github.com/volcengine/verl/issues/1882
- Взаимодействие с окружением https://github.com/volcengine/verl/issues/1172
- Список breaking changes после v0.3 https://github.com/volcengine/verl/discussions/943, по умолчанию entropy_coeff = 0
- Lora для RL https://github.com/volcengine/verl/pull/1127 

## Быстрый старт

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Документация</b></a>

**Quickstart:**

- [Установка](https://verl.readthedocs.io/en/latest/start/install.html)
- [Быстрый старт](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Руководство по программированию](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO в verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO в verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Пошаговый запуск PPO-примера:**


- [Подготовка данных для постобучения](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Реализация функции награды для датасета](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Архитектура примера PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Объяснение конфигурации](https://verl.readthedocs.io/en/latest/examples/config.html)

**Воспроизводимые RL-базовые алгоритмы:**

- [RL-производительность на программировании и математике](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Для объяснения кода и продвинутого использования (расширение):**

- PPO Trainer и воркеры
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- Продвинутое использование и расширение
  - [Добавление моделей с FSDP Backend](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Добавление моделей с Megatron-LM Backend](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Мультиходовая поддержка rollout](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Интеграция инструментов поиска](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Интеграция Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Деплой с отдельными GPU-ресурсами](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [Расширение на другие RL(HF) алгоритмы](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Туториал по дизайну Ray API](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Блоги от сообщества**

- [SGLang, verl, OpenBMB и Университет Цинхуа: Новаторский сквозной Multi-Turn RLHF](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Обучение с подкреплением по человеческой обратной связи на AMD GPU с verl и интеграцией ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Использование обучения с подкреплением](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Лучшие практики распределённого обучения с подкреплением GRPO в verl](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl: разбор оригинала](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Увеличение пропускной способности до 20 раз! Команда Doubao выпускает новую RLHF-рамку — открытый исходный код!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Руководство по оптимизации производительности

Производительность критична для RL-алгоритмов с политикой on-policy. Мы подготовили подробное [руководство по оптимизации производительности](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html), чтобы помочь вам оптимизировать работу.

## Переход на vLLM >= v0.8.2

verl теперь поддерживает vLLM>=0.8.2 при использовании FSDP в качестве тренингового бэкенда. См. [этот документ](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) для инструкции по установке и подробностей. Избегайте использования vllm 0.7.x — там есть баги, ведущие к OOM и ошибкам.

## Используйте последнюю версию SGLang

SGLang полностью поддерживается verl, и группа SGLang RL активно разрабатывает уникальные возможности: multi-turn агентный RL, VLM RLHF, серверный RL и частичный rollout. См. [этот документ](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) для инструкции по установке и подробностей.

## Переход на FSDP2

verl полностью поддерживает FSDP2! FSDP2 рекомендован командой torch distributed, обеспечивает лучшую пропускную способность и использование памяти, а также компонуется с другими возможностями (например, torch.compile). Для включения FSDP2 используйте verl main и задайте такие параметры:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Также, FSDP2 с CPU offload совместим с градиентным накоплением. Включите `actor_rollout_ref.actor.offload_policy=True` для экономии памяти. Подробнее: https://github.com/volcengine/verl/pull/1026

## Поддержка AMD (ROCm Kernel)

verl теперь поддерживает FSDP как движок обучения (поддержка Megatron скоро), а также интеграцию с vLLM и SGLang как движками вывода. См. [этот документ](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) для установки и [этот документ](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) для настройки производительности vLLM на ROCm.


## Цитирование и благодарности

Если проект был вам полезен, пожалуйста, цитируйте:

- [HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)
- [A Framework for Training Large Language Models for Code Generation via Proximal Policy Optimization](https://i.cs.hku.hk/~cwu/papers/gmsheng-NL2Code24.pdf)

```bibtex
@article{sheng2024hybridflow,
  title   = {HybridFlow: A Flexible and Efficient RLHF Framework},
  author  = {Guangming Sheng and Chi Zhang and Zilingfeng Ye and Xibin Wu and Wang Zhang and Ru Zhang and Yanghua Peng and Haibin Lin and Chuan Wu},
  year    = {2024},
  journal = {arXiv preprint arXiv: 2409.19256}
}
```

verl вдохновлён дизайном Nemo-Aligner, Deepspeed-chat и OpenRLHF. Проект поддерживается и развивается такими компаниями и организациями, как Bytedance, Anyscale, LMSys.org, [команда Alibaba Qwen](https://github.com/QwenLM/), Shanghai AI Lab, Университет Цинхуа, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake и др.

## Лучшие проекты на базе verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): воспроизведение рецепта **DeepSeek R1 Zero** для задач рассуждения ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): RL-обучение для Sky-T1-7B от команды NovaSky AI ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: исследование и управление Zero RL для открытых моделей ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): **Мультимодальная** RL-рамка ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): RL-платформа настройки агентов LLM для нескольких сред ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): асинхронное RL-обучение с помощью [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Процессное подкрепление через неявные награды ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): универсальная рамка RL для обучения агентов рассуждения ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL с рассуждением и **поиском (tool-call)** для LLM ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): RL-обучение **поискового агента** с результатами поиска/извлечения ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): RL для обучения рассуждению с поиском для LLM ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Воспроизведение R1 для **кода** с надёжными наградами ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): серия Skywork open reasoner ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Масштабируемый RL с интеграцией инструментов ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Масштабируемая рамка обучения для **LLM/VLM-агентов с длинным горизонтом**, включая новый алгоритм **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration для PPO на основе надёжности сигналов награды для более эффективного и устойчивого RLHF.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: универсальная vision-language action модель для **GUI-агентов** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Масштабирование глубоких исследований с помощью RL в реальных средах ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Обучение VLM-агентов с multi-turn RL ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: RL для стратегического использования инструментов в LLM. Код будет опубликован...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL-обучение моделей награды для рассуждений ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Framework самоигры для рассуждений без ручной разметки данных ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Обучение рассуждению под off-policy-наставлением ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Унифицированная и легко расширяемая RL-рамка для обучения инструментальных агентов на базе verl ![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K датасет и серия моделей для математического рассуждения ![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

и многие другие проекты перечислены в [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Руководство по вкладу

Вклад от сообщества приветствуется! Пожалуйста, ознакомьтесь с нашей [дорожной картой](https://github.com/volcengine/verl/issues/710) и [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22), чтобы понять, где вы можете помочь.

### Линтинг и форматирование кода

Для повышения качества кода мы используем pre-commit. Для инициализации pre-commit выполните:

```bash
pip install pre-commit
pre-commit install
```

Чтобы локально решить CI-ошибки, выполните:

```bash
pre-commit run
```

### Добавление CI-тестов

По возможности добавляйте CI-тест(ы) для новой функции:

1. Найдите наиболее подходящий workflow yml-файл, обычно соответствующий конфигу по умолчанию hydra (например, `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer` и т.д.).
2. Добавьте соответствующие паттерны путей в секцию `paths`, если их ещё нет.
3. Минимизируйте нагрузку тестовых скриптов (см. существующие примеры).

## О [ByteDance Seed Team](https://team.doubao.com/)

Основана в 2023 году, команда ByteDance Seed занимается созданием самых продвинутых базовых AI-моделей в индустрии. Команда стремится стать мировым лидером в исследованиях и внести значимый вклад в развитие науки и общества. Познакомьтесь с ByteDance Seed по ссылкам ниже 👇
<div>
  <a href="https://team.doubao.com/">
    <img src="https://img.shields.io/badge/Website-%231e37ff?style=for-the-badge&logo=bytedance&logoColor=white"></a>
  <a href="https://github.com/user-attachments/assets/469535a8-42f2-4797-acdf-4f7a1d4a0c3e">
    <img src="https://img.shields.io/badge/WeChat-07C160?style=for-the-badge&logo=wechat&logoColor=white"></a>
 <a href="https://www.xiaohongshu.com/user/profile/668e7e15000000000303157d?xsec_token=ABl2-aqekpytY6A8TuxjrwnZskU-6BsMRE_ufQQaSAvjc%3D&xsec_source=pc_search">
    <img src="https://img.shields.io/badge/Xiaohongshu-%23FF2442?style=for-the-badge&logo=xiaohongshu&logoColor=white"></a>
  <a href="https://www.zhihu.com/org/dou-bao-da-mo-xing-tuan-dui/">
    <img src="https://img.shields.io/badge/zhihu-%230084FF?style=for-the-badge&logo=zhihu&logoColor=white"></a>

</div>
---

Мы ИЩЕМ новых коллег! Если вам интересны стажировки/работа в RL для агентов, присылайте [email](mailto:haibin.lin@bytedance.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---