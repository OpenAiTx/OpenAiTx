<div align="center">
 👋 Cześć wszystkim! 
    verl to biblioteka do treningu RL zainicjowana przez <b>Zespół ByteDance Seed</b> i utrzymywana przez społeczność verl.
    <br>
    <br>
</div>

<div align="center">

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="Ask DeepWiki.com" height="20"/>](https://deepwiki.com/volcengine/verl)
[![GitHub Repo stars](https://img.shields.io/github/stars/volcengine/verl)](https://github.com/volcengine/verl/stargazers)
[![Twitter](https://img.shields.io/twitter/follow/verl_project)](https://twitter.com/verl_project)
<a href="https://join.slack.com/t/verlgroup/shared_invite/zt-2w5p9o4c3-yy0x2Q56s_VlGLsJ93A6vA"><img src="https://img.shields.io/badge/Slack-verl-blueviolet?logo=slack&amp"></a>
<a href="https://arxiv.org/pdf/2409.19256"><img src="https://img.shields.io/static/v1?label=EuroSys&message=Paper&color=red"></a>
[![Documentation](https://img.shields.io/badge/documentation-blue)](https://verl.readthedocs.io/en/latest/)
<a href="https://raw.githubusercontent.com/eric-haibin-lin/verl-community/refs/heads/main/WeChat.JPG"><img src="https://img.shields.io/badge/微信-green?logo=wechat&amp"></a>

</div>

![seed logo](https://github.com/user-attachments/assets/c42e675e-497c-4508-8bb9-093ad4d1f216)

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning dla LLM</h1>

verl to elastyczna, wydajna i gotowa do produkcji biblioteka treningowa RL dla dużych modeli językowych (LLM).

verl to otwartoźródłowa wersja pracy **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl jest elastyczny i łatwy w użyciu dzięki:

- **Łatwe rozszerzanie różnorodnych algorytmów RL**: Model programowania hybrid-controller umożliwia elastyczną reprezentację i wydajne wykonywanie złożonych przepływów danych po-treningowych. Buduj przepływy danych RL, takie jak GRPO, PPO, w kilku liniach kodu.

- **Bezproblemowa integracja istniejącej infrastruktury LLM dzięki modułowym API**: Oddziela obliczenia od zależności danych, umożliwiając bezproblemową integrację z istniejącymi frameworkami LLM, takimi jak FSDP, Megatron-LM, vLLM, SGLang itd.

- **Elastyczne mapowanie urządzeń**: Obsługuje różne rozmieszczenie modeli na różnych zestawach GPU dla efektywnego wykorzystania zasobów i skalowalności na różnych rozmiarach klastrów.

- Gotowa integracja z popularnymi modelami HuggingFace

verl jest szybki dzięki:

- **Najnowocześniejszej przepustowości**: Integracje silników treningowych i inferencyjnych LLM klasy SOTA oraz najwyższa przepustowość RL.

- **Wydajnemu reshardingowi modelu aktora z 3D-HybridEngine**: Eliminuje nadmiarowość pamięci i znacząco redukuje koszty komunikacji podczas przejść między fazami treningu i generacji.

</p>

## Aktualności

- [2025/06] verl z backendem Megatron umożliwia trenowanie dużych modeli MoE takich jak [DeepSeek-671b oraz Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] Zespół verl zaprezentuje najnowsze aktualizacje projektu podczas [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) 7 czerwca. Spotkaj nasz zespół w Pekinie!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), zaakceptowany na ICML 2025, jest już wspierany w verl! PF-PPO zwiększa efektywność i odporność nauki polityki poprzez filtrowanie potencjalnie szumowych sygnałów nagrody oraz ponowne wykorzystanie wysokiej jakości doświadczeń przez bufor powtórek.
- [2025/04] Zaprezentujemy tutorial o najnowszych technikach po-treningowych i przewodnik programistyczny dla verl na [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [warsztatach SCI-FM](https://open-foundation-model.github.io/) i [LMSys afterparty](https://lu.ma/d23nyynm). Materiały dostępne [tutaj](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] Opublikowano raport techniczny [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf)! Trenowany z verl, Seed-Thinking-v1.5 osiąga 86.7 na AIME 2024, 55.0 na Codeforces i 77.3 na GPQA, wykazując doskonałe zdolności wnioskowania w zadaniach STEM i kodowania. Poza zadaniami wnioskowania, metoda wykazuje znaczną uogólnialność w różnych dziedzinach.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) opisuje naszą najnowszą metodę RL dla modeli wnioskowania. Trenowany z modelu Qwen-32B-base, VAPO osiąga 60.4 na AIME 2024, przewyższając DAPO-32B.
- [2025/03] wydano verl v0.3.0.post1! Zobacz [notatkę o wydaniu](https://github.com/volcengine/verl/releases/) po szczegóły. Osiąga [~1.4x przyspieszenie](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) względem poprzednich wersji.
- [2025/03] [DAPO](https://dapo-sia.github.io/) to otwartoźródłowy, SOTA algorytm RL, który osiąga 50 punktów na AIME 2024, bazując na modelu wstępnie wytrenowanym Qwen2.5-32B, przewyższając wcześniejsze SOTA osiągnięte przez DeepSeek's GRPO (DeepSeek-R1-Zero-Qwen-32B). Trening DAPO jest w pełni zasilany przez verl, a kod reprodukcji jest już dostępny w `recipe/dapo`.
<details><summary> więcej... </summary>
<ul>
  <li>[2025/05] verl zostanie zaprezentowany na [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) w dniach 16-17 maja.</li>
  <li>[2025/05] verl zostanie zaprezentowany na [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). Do zobaczenia w Paryżu! </li>
  <li>[2025/03] Przedstawiliśmy model programowania verl na [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) oraz [wstęp i aktualizacje verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) podczas [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) w Sunnyvale w połowie marca.</li>
  <li>[2025/03] Zaprezentujemy verl (HybridFlow) na EuroSys 2025. Do zobaczenia w Rotterdamie!</li>
  <li>[2025/02] wydano verl v0.2.0.post2!</li>
  <li>[2025/02] Przedstawiliśmy verl na <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. Do zobaczenia w San Jose!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) został wydany z wydajnością SOTA na LLM & VLM. Przeglądowy model skalowania RL został wytrenowany z verl, osiągając wydajność na poziomie OpenAI O1 na benchmarkach matematycznych (70.0 pass@1 na AIME).</li>
  <li>[2024/12] verl został zaprezentowany na Ray Forward 2024. Slajdy dostępne <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">tutaj</a></li>
  <li>[2024/12] Zespół zaprezentował <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> na NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slajdy</a> i <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">wideo</a> dostępne.</li>
  <li>[2024/10] verl został zaprezentowany na Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Wideo na Youtube</a> dostępne.</li>
  <li>[2024/08] HybridFlow (verl) został przyjęty na EuroSys 2025.</li>
</ul>   
</details>

## Kluczowe funkcje

- **FSDP**, **FSDP2** oraz **Megatron-LM** do treningu.
- **vLLM**, **SGLang** oraz **HF Transformers** do generowania rolloutów.
- Kompatybilność z Hugging Face Transformers i Modelscope Hub: [Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, itd.
- Nadzorowany fine-tuning.
- Uczenie przez wzmocnienie z [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), itd.
  - Wsparcie dla nagród modelowych oraz nagród funkcyjnych (weryfikowalne nagrody) dla matematyki, [kodowania](https://github.com/volcengine/verl/tree/main/recipe/dapo), itd.
  - Wsparcie dla modeli wizja-język (VLMs) oraz [wielomodalnego RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) z Qwen2.5-vl, Kimi-VL
  - [Wielotur z wywołaniem narzędzi](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- Przepisy dopasowania LLM, takie jak [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2, [pakowanie sekwencji](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [paralelizacja sekwencji](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) przez DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Skalowanie do modeli 671B i setek GPU dzięki [eksperckiej paralelizacji](https://github.com/volcengine/verl/pull/1467)
- Wsparcie dla wielo-GPU [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) dla oszczędności pamięci.
- Śledzenie eksperymentów z wandb, swanlab, mlflow i tensorboard.

## Nadchodzące funkcje i zmiany

- Roadmap https://github.com/volcengine/verl/issues/710
- Optymalizacje DeepSeek 671b z Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Wielotur oraz narzędzia z optymalizacjami https://github.com/volcengine/verl/issues/1882
- Interakcje środowiskowe https://github.com/volcengine/verl/issues/1172
- Lista zmian niekompatybilnych od v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff domyślnie 0
- Lora dla RL https://github.com/volcengine/verl/pull/1127 

## Rozpoczęcie pracy

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Dokumentacja</b></a>

**Szybki start:**

- [Instalacja](https://verl.readthedocs.io/en/latest/start/install.html)
- [Szybki start](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Przewodnik programowania](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO w verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO w verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Krok po kroku przykład PPO:**


- [Przygotowanie danych do po-treningu](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Implementacja funkcji nagrody dla zbioru danych](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Architektura przykładu PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Wyjaśnienie konfiguracji](https://verl.readthedocs.io/en/latest/examples/config.html)

**Reprodukowane benchmarki algorytmiczne:**

- [Wydajność RL na kodowaniu, matematyce](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Wyjaśnienie kodu i zaawansowane zastosowania (rozszerzenia):**

- Trener PPO i Workery
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- Zaawansowane użycie i rozszerzenia
  - [Dodawanie modeli z backendem FSDP](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Dodawanie modeli z backendem Megatron-LM](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Wsparcie dla wielotur rollout](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Integracja narzędzi wyszukiwania](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Integracja z Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Wdrażanie z użyciem oddzielnych zasobów GPU](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [Rozszerzanie o inne algorytmy RL(HF)](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Tutorial dotyczący projektu API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blogi ze społeczności**

- [SGLang, verl, OpenBMB i Uniwersytet Tsinghua: Pionierskie End-to-End Multi-Turn RLHF](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning from Human Feedback na GPU AMD z verl i integracją ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：praktyczne zastosowanie uczenia przez wzmocnienie](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Najlepsze praktyki GRPO w rozproszonym RL z verl](https://www.volcengine.com/docs/6459/1463942)
- [Analiza oryginalnego HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Do 20x wzrostu przepustowości! Zespół Doubao wypuszcza nowy framework RLHF, już open-source!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Przewodnik optymalizacji wydajności

Wydajność jest kluczowa dla algorytmów RL on-policy. Przygotowaliśmy szczegółowy [przewodnik optymalizacji wydajności](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html), który pomoże zoptymalizować Twoją pracę.

## Aktualizacja do vLLM >= v0.8.2

verl obsługuje teraz vLLM>=0.8.2 podczas użycia FSDP jako backendu treningowego. Zobacz [ten dokument](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) po instrukcję instalacji i więcej informacji. Unikaj vllm 0.7.x, który zawiera błędy mogące prowadzić do OOM i nieoczekiwanych błędów.

## Używaj najnowszego SGLang

SGLang jest w pełni wspierany przez verl, a grupa SGLang RL intensywnie pracuje nad budowaniem unikalnych funkcji, w tym wielotur RL agentów, VLM RLHF, RL opartych na serwerze i częściowych rolloutów. Zobacz [ten dokument](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) po instrukcję instalacji i więcej informacji.

## Aktualizacja do FSDP2

verl w pełni wdraża FSDP2! FSDP2 jest rekomendowany przez zespół torch distributed, oferując lepszą przepustowość i użycie pamięci oraz możliwość łączenia z innymi funkcjami (np. torch.compile). Aby włączyć FSDP2, po prostu użyj verl main i ustaw następujące opcje:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Ponadto, offloading CPU FSDP2 jest kompatybilny z akumulacją gradientów. Możesz go włączyć, aby zaoszczędzić pamięć przez `actor_rollout_ref.actor.offload_policy=True`. Po więcej szczegółów zobacz https://github.com/volcengine/verl/pull/1026

## Wsparcie dla AMD (ROCm Kernel)

verl obsługuje obecnie FSDP jako silnik treningowy (wsparcie Megatron wkrótce) oraz integruje się zarówno z vLLM, jak i SGLang jako silnikami inferencyjnymi. Zobacz [ten dokument](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) po instrukcję instalacji i więcej informacji oraz [ten dokument](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) po tuning wydajności vLLM dla ROCm.


## Cytowanie i podziękowania

Jeśli projekt był pomocny, prosimy o cytowanie:

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

verl jest inspirowany projektami Nemo-Aligner, Deepspeed-chat i OpenRLHF. Projekt jest wdrażany i współtworzony przez Bytedance, Anyscale, LMSys.org, [zespół Alibaba Qwen](https://github.com/QwenLM/), Shanghai AI Lab, Uniwersytet Tsinghua, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake i wielu innych.

## Świetne projekty korzystające z verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): reprodukcja przepisu **DeepSeek R1 Zero** dla zadań wnioskowania ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): RL dla Sky-T1-7B od zespołu NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: Badanie i opanowanie Zero RL dla bazowych modeli open-source ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): **Wielomodalny** framework treningowy RL ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): Framework RL dla agentów LLM w różnych środowiskach. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): asynchroniczny trening RL z [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Wzmocnienie procesu przez ukryte nagrody ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): ogólnego przeznaczenia framework treningowy agentów wnioskowania ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL z przeplatanym wnioskowaniem i wyszukiwaniem (tool-call) w LLM ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): RL trening **agenta wyszukiwania** z **wynikiem wyszukiwania** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Nauka **wnioskowania z wyszukiwaniem** dla LLM przez RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Reprodukcja R1 dla **kodu** z niezawodnymi nagrodami ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Skywork open reasoner series ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Skalowanie RL zintegrowanego z narzędziami ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Skalowalny framework treningowy dla **długoterminowych agentów LLM/VLM** wraz z nowym algorytmem **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration dla PPO bazujące na niezawodności sygnałów nagrody dla bardziej wydajnego i odpornego RLHF.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: uniwersalny model Vision-Language Action dla **agentów GUI** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Skalowanie głębokiego researchu przez RL w rzeczywistych środowiskach ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Trening agentów VLM przez wielotur RL ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: reinforcement learning dla strategicznego użycia narzędzi w LLM. Kod w przygotowaniu...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL trening modeli nagrody do wnioskowania ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Framework self-play bez ręcznie selekcjonowanych danych dla wnioskowania![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Nauka wnioskowania z off-policy![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Uniwersalny i łatwy do rozszerzania framework treningowy agentów narzędziowych na verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K dane i modele dla wnioskowania matematycznego![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

i wiele innych świetnych projektów wymienionych w [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Przewodnik kontrybucji

Wkład ze strony społeczności jest mile widziany! Sprawdź nasz [plan rozwoju projektu](https://github.com/volcengine/verl/issues/710) i [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22), by zobaczyć, gdzie możesz się przydać.

### Lintowanie i formatowanie kodu

Używamy pre-commit do poprawy jakości kodu. Aby zainicjować pre-commit, uruchom:

```bash
pip install pre-commit
pre-commit install
```

Aby rozwiązać błędy CI lokalnie, możesz ręcznie uruchomić pre-commit przez:

```bash
pre-commit run
```

### Dodawanie testów CI

Jeśli to możliwe, dodaj test(y) CI dla swojej nowej funkcji:

1. Znajdź najbardziej odpowiedni plik workflow yml, który zwykle odpowiada domyślnej konfiguracji `hydra` (np. `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, itd.).
2. Dodaj związane wzorce ścieżek do sekcji `paths`, jeśli nie są już uwzględnione.
3. Zminimalizuj obciążenie skryptów testowych (zobacz istniejące skrypty jako przykłady).

## O [Zespole ByteDance Seed](https://team.doubao.com/)

Założony w 2023, Zespół ByteDance Seed jest dedykowany tworzeniu najnowocześniejszych modeli bazowych AI w branży. Zespół dąży do zostania światowej klasy zespołem badawczym i wniesienia znaczącego wkładu w rozwój nauki i społeczeństwa. Możesz poznać zespół Bytedance Seed przez poniższe kanały👇
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

REKRUTUJEMY! Wyślij [maila](mailto:haibin.lin@bytedance.com), jeśli jesteś zainteresowany/a praktykami lub pracą w RL dla agentów.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---