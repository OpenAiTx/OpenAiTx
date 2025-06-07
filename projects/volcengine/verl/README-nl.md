<div align="center">
 👋 Hallo allemaal! 
    verl is een RL-trainingsbibliotheek geïnitieerd door het <b>ByteDance Seed team</b> en onderhouden door de verl-community.
    <br>
    <br>
</div>

<div align="center">

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="Ask DeepWiki.com" height="20"/>](https://deepwiki.com/volcengine/verl)
[![GitHub Repo stars](https://img.shields.io/github/stars/volcengine/verl)](https://github.com/volcengine/verl/stargazers)
[![Twitter](https://img.shields.io/twitter/follow/verl_project)](https://twitter.com/verl_project)
<a href="https://join.slack.com/t/verlgroup/shared_invite/zt-2w5p9o4c3-yy0x2Q56s_VlGLsJ93A6vA"><img src="https://img.shields.io/badge/Slack-verl-blueviolet?logo=slack&amp"></a>
<a href="https://arxiv.org/pdf/2409.19256"><img src="https://img.shields.io/static/v1?label=EuroSys&message=Paper&color=red"></a>
[![Documentation](https://img.shields.io/badge/documentatie-blauw)](https://verl.readthedocs.io/en/latest/)
<a href="https://raw.githubusercontent.com/eric-haibin-lin/verl-community/refs/heads/main/WeChat.JPG"><img src="https://img.shields.io/badge/微信-green?logo=wechat&amp"></a>

</div>

![seed logo](https://github.com/user-attachments/assets/c42e675e-497c-4508-8bb9-093ad4d1f216)

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning voor LLMs</h1>

verl is een flexibele, efficiënte en productieklare RL-trainingsbibliotheek voor grote taalmodellen (LLMs).

verl is de open-sourceversie van het **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** paper.

verl is flexibel en eenvoudig te gebruiken dankzij:

- **Eenvoudige uitbreiding van diverse RL-algoritmes**: Het hybrid-controller programmeermodel maakt flexibele representatie en efficiënte uitvoering van complexe post-training dataflows mogelijk. Bouw RL-dataflows zoals GRPO, PPO in slechts enkele regels code.

- **Naadloze integratie van bestaande LLM-infrastructuur met modulaire API's**: Ontkoppelt rekenkundige en gegevensafhankelijkheden, waardoor naadloze integratie met bestaande LLM-frameworks zoals FSDP, Megatron-LM, vLLM, SGLang, etc. mogelijk is.

- **Flexibele device mapping**: Ondersteunt verschillende plaatsingen van modellen op diverse sets GPU's voor efficiënte resourcebenutting en schaalbaarheid over verschillende clusterformaten.

- Directe integratie met populaire HuggingFace-modellen

verl is snel dankzij:

- **State-of-the-art doorvoer**: SOTA LLM training en inference engine-integraties en SOTA RL-doorvoer.

- **Efficiënt herverdelen van actor-modellen met 3D-HybridEngine**: Elimineert geheugenredundantie en vermindert de communicatielast aanzienlijk tijdens overgangen tussen training en generatiefase.

</p>

## Nieuws

- [2025/06] verl met Megatron-backend maakt grote MoE-modellen mogelijk zoals [DeepSeek-671b en Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] verl-team zal de laatste projectupdates geven op [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) op 7 juni. Ontmoet ons dev-team in Beijing!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), geaccepteerd voor ICML 2025, wordt nu ondersteund in verl! PF-PPO verbetert de efficiëntie en robuustheid van policy learning door mogelijk ruisige reward-signalen te filteren en hoogwaardige ervaringen te hergebruiken via een replay buffer.
- [2025/04] We geven een tutorial over de nieuwste post-training technieken en programmeergids voor verl op [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) en [LMSys afterparty](https://lu.ma/d23nyynm). Presentatiematerialen beschikbaar [hier](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) technisch rapport is uitgebracht! Getraind met verl behaalt Seed-Thinking-v1.5 86.7 op AIME 2024, 55.0 op Codeforces en 77.3 op GPQA, wat uitstekende redeneervermogen in STEM en codering aantoont. Naast redeneertaken toont de methode opmerkelijke generalisatie over diverse domeinen.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) paper behandelt onze nieuwste RL-methode voor redeneermodellen. Getraind vanaf Qwen-32B-base model behaalt VAPO 60.4 op AIME 2024, beter dan DAPO-32B.
- [2025/03] verl v0.3.0.post1 is uitgebracht! Zie [releasenote](https://github.com/volcengine/verl/releases/) voor details. Het behaalt [~1.4x versnelling](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) vergeleken met eerdere versies.
- [2025/03] [DAPO](https://dapo-sia.github.io/) is het open-source SOTA RL-algoritme dat 50 punten behaalt op AIME 2024 op basis van het Qwen2.5-32B pre-trained model, waarmee het vorige SOTA van DeepSeek's GRPO (DeepSeek-R1-Zero-Qwen-32B) wordt overtroffen. DAPO's training is volledig aangedreven door verl en de reproductiecode is nu beschikbaar in `recipe/dapo`.
<details><summary> meer... </summary>
<ul>
  <li>[2025/05] verl zal worden gepresenteerd op [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) op 16/5 - 17/5.</li>
  <li>[2025/05] verl zal worden gepresenteerd op [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). Tot ziens in Parijs! </li>
  <li>[2025/03] We introduceerden het programmeermodel van verl op de [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) en [verl intro en updates](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) op de [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) in Sunnyvale medio maart.</li>
  <li>[2025/03] We presenteren verl(HybridFlow) op EuroSys 2025. Tot ziens in Rotterdam!</li>
  <li>[2025/02] verl v0.2.0.post2 is uitgebracht!</li>
  <li>[2025/02] We presenteerden verl in de <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. Tot ziens in San Jose!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) is uitgebracht met SOTA-niveau prestaties op LLM & VLM. Het RL scaling preview model is getraind met verl en bereikt OpenAI O1-niveau prestaties op wiskundige benchmarks (70.0 pass@1 op AIME).</li>
  <li>[2024/12] verl is gepresenteerd op Ray Forward 2024. Slides beschikbaar <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">hier</a></li>
  <li>[2024/12] Het team presenteerde <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> op NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slides</a> en <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">video</a> beschikbaar.</li>
  <li>[2024/10] verl is gepresenteerd op Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Youtube-video</a> beschikbaar.</li>
  <li>[2024/08] HybridFlow (verl) is geaccepteerd voor EuroSys 2025.</li>
</ul>   
</details>

## Belangrijkste Kenmerken

- **FSDP**, **FSDP2** en **Megatron-LM** voor training.
- **vLLM**, **SGLang** en **HF Transformers** voor rollout-generatie.
- Compatibel met Hugging Face Transformers en Modelscope Hub: [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, enz.
- Supervised fine-tuning.
- Reinforcement learning met [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), enz.
  - Ondersteunt model-based reward en function-based reward (verifieerbare beloning) voor wiskunde, [coderen](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo), enz.
  - Ondersteunt vision-language modellen (VLMs) en [multi-modale RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) met Qwen2.5-vl, Kimi-VL
  - [Multi-turn met tool calling](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn)
- LLM alignment recepten zoals [Self-play preference optimization (SPPO)](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) ondersteuning via DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Schaalbaar tot 671B modellen en honderden GPU's met [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Multi-gpu [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) ondersteuning om geheugen te besparen.
- Experiment tracking met wandb, swanlab, mlflow en tensorboard.

## Verwachte Functies en Wijzigingen

- Roadmap https://github.com/volcengine/verl/issues/710
- DeepSeek 671b optimalisaties met Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Multi-turn rollout en tools optimalisaties https://github.com/volcengine/verl/issues/1882
- Omgevingsinteracties https://github.com/volcengine/verl/issues/1172
- Lijst van breaking changes sinds v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff standaard op 0
- Lora voor RL https://github.com/volcengine/verl/pull/1127 

## Aan de Slag

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Documentatie</b></a>

**Snelstart:**

- [Installatie](https://verl.readthedocs.io/en/latest/start/install.html)
- [Snelstart](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Programmeerhandleiding](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO in verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO in verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Een PPO-voorbeeld stap-voor-stap uitvoeren:**


- [Data voorbereiden voor post-training](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Beloningsfunctie implementeren voor dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [PPO Voorbeeldarchitectuur](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Config Uitleg](https://verl.readthedocs.io/en/latest/examples/config.html)

**Reproduceerbare algoritme-benchmarks:**

- [RL-prestaties op coderen, wiskunde](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Voor codeuitleg en gevorderd gebruik (uitbreiding):**

- PPO Trainer en Workers
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP Backend](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM Backend](https://verl.readthedocs.io/en/latest/index.html)

- Geavanceerd gebruik en uitbreiding
  - [Voeg Modellen toe met de FSDP Backend](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Voeg Modellen toe met de Megatron-LM Backend](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Multi-turn Rollout Ondersteuning](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Zoektool Integratie](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Sandbox Fusion Integratie](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Deployen met gescheiden GPU-resources](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [Uitbreiden naar andere RL(HF) algoritmes](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API ontwerp tutorial](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blogs uit de community**

- [SGLang, verl, OpenBMB en Tsinghua University: Pionieren met End-to-End Multi-Turn RLHF](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning van Menselijke Feedback op AMD GPU's met verl en ROCm-integratie](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Spelen met reinforcement learning training](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Beste praktijken voor GRPO-distributieve reinforcement learning training met verl](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl originele tekstanalyse](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Tot 20x hogere doorvoer! Doubao groot modelteam brengt volledig nieuw RLHF-framework uit, nu open-source!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Prestatie-tuning Gids

De prestatie is essentieel voor on-policy RL-algoritmen. We hebben een gedetailleerde [prestatie-tuning gids](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) geschreven om je te helpen de prestaties te optimaliseren.

## Upgrade naar vLLM >= v0.8.2

verl ondersteunt nu vLLM>=0.8.2 bij gebruik van FSDP als trainingsbackend. Raadpleeg [dit document](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) voor de installatiehandleiding en meer informatie. Vermijd vllm 0.7.x, dit bevat bugs die kunnen leiden tot OOMs en onverwachte fouten.

## Gebruik de nieuwste SGLang

SGLang wordt volledig ondersteund door verl, en de SGLang RL Group werkt intensief aan unieke features, waaronder multi-turn agentische RL, VLM RLHF, servergebaseerde RL en gedeeltelijke rollout. Raadpleeg [dit document](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) voor installatiehandleiding en meer informatie.

## Upgrade naar FSDP2

verl omarmt FSDP2 volledig! FSDP2 wordt aanbevolen door het torch distributed team, biedt betere doorvoer en geheugengebruik, en is samenstelbaar met andere features (bijv. torch.compile). Om FSDP2 te activeren, gebruik verl main en stel de volgende opties in:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Bovendien is FSDP2 CPU offloading compatibel met graduele accumulatie. Je kunt dit inschakelen om geheugen te besparen met `actor_rollout_ref.actor.offload_policy=True`. Voor meer details, zie https://github.com/volcengine/verl/pull/1026

## AMD-ondersteuning (ROCm Kernel)

verl ondersteunt nu FSDP als training engine (Megatron-ondersteuning komt binnenkort) en integreert zowel met vLLM als SGLang als inference engines. Raadpleeg [dit document](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) voor de installatiehandleiding en meer informatie, en [dit document](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) voor vLLM prestatie-tuning voor ROCm.


## Citation en erkenning

Als je het project nuttig vindt, citeer dan:

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

verl is geïnspireerd op het ontwerp van Nemo-Aligner, Deepspeed-chat en OpenRLHF. Het project is geadopteerd en bijgedragen door Bytedance, Anyscale, LMSys.org, [Alibaba Qwen team](https://github.com/QwenLM/), Shanghai AI Lab, Tsinghua University, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake, en vele anderen.

## Geweldig werk met verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): een reproductie van het **DeepSeek R1 Zero** recept voor redeneertaken ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): RL-training voor Sky-T1-7B door het NovaSky AI team. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: Onderzoek en temmen van Zero Reinforcement Learning voor Open Base Modellen in het wild ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): **Multi-modal** RL-training framework ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): LLM Agents RL-tuning framework voor meerdere agentomgevingen. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): async RL-training met [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Procesversterking door impliciete beloningen ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): een algemeen trainingsframework voor redeneer**agenten** ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL met redeneer- en **zoek- (tool-call)** interleaved LLMs ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): RL-training van **Search Agent** met **Search/Retrieval Outcome** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Leren **re**deneer met **search** voor LLMs via reinforcement learning ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Reproductie van R1 voor **Code** met betrouwbare beloningen ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Skywork open reasoner series ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Schalen van tool-geïntegreerde RL ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Een schaalbaar trainingsframework voor **long-horizon LLM/VLM agents**, samen met een nieuw algoritme **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration voor PPO op basis van de betrouwbaarheid van reward-signalen voor efficiëntere en robuustere RLHF.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: Een generalistisch R1-stijl Vision-Language Action Model voor **GUI Agents** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Schaal diepgaand onderzoek met reinforcement learning in echte omgevingen ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Training van VLM-agenten met multi-turn reinforcement learning ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: reinforcement learning voor strategisch toolgebruik in LLMs. Code release volgt...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL training van redeneer rewardmodellen ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Een self-play framework zonder handmatig samengestelde data voor redeneren![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Leren redeneren onder off-policy begeleiding![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Een verenigd en eenvoudig uit te breiden tool-agent trainingsframework gebaseerd op verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K data en serie modellen voor wiskundig redeneren![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

en nog veel meer geweldig werk, zie [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Bijdragen Gids

Bijdragen vanuit de community zijn welkom! Bekijk onze [project roadmap](https://github.com/volcengine/verl/issues/710) en [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) om te zien waar je kunt bijdragen.

### Code Linting en Formatteren

We gebruiken pre-commit om de codekwaliteit te verbeteren. Om pre-commit te initialiseren, voer uit:

```bash
pip install pre-commit
pre-commit install
```

Om CI-fouten lokaal op te lossen, kun je pre-commit handmatig uitvoeren met:

```bash
pre-commit run
```

### CI-tests toevoegen

Indien mogelijk, voeg graag CI-test(s) toe voor je nieuwe feature:

1. Zoek het meest relevante workflow yml-bestand, wat meestal overeenkomt met een `hydra` default config (bijv. `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, enz).
2. Voeg gerelateerde padpatronen toe aan de `paths` sectie indien nog niet aanwezig.
3. Minimaliseer de workload van het testscript (zie bestaande scripts voor voorbeelden).

## Over [ByteDance Seed Team](https://team.doubao.com/)

Opgericht in 2023, is het ByteDance Seed Team toegewijd aan het creëren van de meest geavanceerde AI-basis modellen in de industrie. Het team streeft ernaar een wereldklasse onderzoeksteam te worden en een significante bijdrage te leveren aan de vooruitgang van wetenschap en samenleving. Je kunt Bytedance Seed beter leren kennen via de volgende kanalen👇
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

We ZOEKEN NIEUWE COLLEGA'S! Stuur ons een [e-mail](mailto:haibin.lin@bytedance.com) als je geïnteresseerd bent in een stage/FTE-kans in RL voor agents.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---