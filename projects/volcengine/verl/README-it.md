<div align="center">
 👋 Ciao a tutti! 
    verl è una libreria di training RL iniziata dal <b>ByteDance Seed team</b> e mantenuta dalla community di verl.
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

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning per LLM</h1>

verl è una libreria di training RL flessibile, efficiente e pronta per la produzione per modelli linguistici di grandi dimensioni (LLM).

verl è la versione open-source del paper **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl è flessibile e facile da usare con:

- **Facile estensione di diversi algoritmi RL**: Il modello di programmazione hybrid-controller permette una rappresentazione flessibile ed esecuzione efficiente di dataflow complessi di post-training. Costruisci dataflow RL come GRPO, PPO in poche righe di codice.

- **Integrazione senza soluzione di continuità dell'infrastruttura LLM esistente con API modulari**: Decoupla computazione e dipendenze dai dati, abilitando l'integrazione semplice con framework LLM esistenti, come FSDP, Megatron-LM, vLLM, SGLang, ecc.

- **Mappatura flessibile dei dispositivi**: Supporta diverse allocazioni dei modelli su differenti insiemi di GPU per un uso efficiente delle risorse e scalabilità su cluster di dimensioni diverse.

- Integrazione pronta con modelli HuggingFace popolari

verl è veloce grazie a:

- **Throughput all'avanguardia**: Integrazione di motori di training e inferenza LLM SOTA e throughput RL SOTA.

- **Resharding efficiente del modello actor con 3D-HybridEngine**: Elimina ridondanza di memoria e riduce significativamente l'overhead di comunicazione durante le transizioni tra fasi di training e generazione.

</p>

## Novità

- [2025/06] verl con backend Megatron abilita grandi modelli MoE come [DeepSeek-671b e Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] Il team di verl fornirà gli ultimi aggiornamenti del progetto al [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) il 7 giugno. Incontra il nostro team di sviluppo a Pechino!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), accettato a ICML 2025, è ora supportato in verl! PF-PPO migliora l'efficienza e la robustezza dell'apprendimento della policy filtrando segnali di reward potenzialmente rumorosi e riutilizzando esperienze di alta qualità tramite un replay buffer.
- [2025/04] Terremo un tutorial sulle tecniche di post-training più recenti e una guida di programmazione per verl a [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [SCI-FM workshop](https://open-foundation-model.github.io/) e [LMSys afterparty](https://lu.ma/d23nyynm). Materiali della presentazione disponibili [qui](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] Il tech report [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) è stato rilasciato! Addestrato con verl, Seed-Thinking-v1.5 ottiene 86.7 su AIME 2024, 55.0 su Codeforces e 77.3 su GPQA, dimostrando eccellenti capacità di ragionamento in STEM e coding. Oltre ai task di ragionamento, il metodo mostra notevole generalizzazione su domini diversi.
- [2025/04] Il paper [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) copre il nostro ultimo metodo RL per modelli di ragionamento. Addestrato dal modello Qwen-32B-base, VAPO raggiunge 60.4 su AIME 2024, superando DAPO-32B.
- [2025/03] rilasciato verl v0.3.0.post1! Vedi [note di rilascio](https://github.com/volcengine/verl/releases/) per dettagli. Ottiene un [~1.4x speedup](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) rispetto alle versioni precedenti.
- [2025/03] [DAPO](https://dapo-sia.github.io/) è l'algoritmo RL SOTA open-source che ottiene 50 punti su AIME 2024 basato sul modello Qwen2.5-32B pre-addestrato, superando il precedente SOTA raggiunto da GRPO di DeepSeek (DeepSeek-R1-Zero-Qwen-32B). Il training di DAPO è completamente alimentato da verl e il codice di riproduzione è disponibile in `recipe/dapo` ora.
<details><summary> altro... </summary>
<ul>
  <li>[2025/05] verl sarà presentato a [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) il 16/5 - 17/5.</li>
  <li>[2025/05] verl sarà presentato a [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). Ci vediamo a Parigi! </li>
  <li>[2025/03] Abbiamo introdotto il modello di programmazione di verl al [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) e [presentazione e aggiornamenti di verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) al [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) a Sunnyvale a metà marzo.</li>
  <li>[2025/03] Presenteremo verl(HybridFlow) a EuroSys 2025. Ci vediamo a Rotterdam!</li>
  <li>[2025/02] rilasciata verl v0.2.0.post2!</li>
  <li>[2025/02] Abbiamo presentato verl al <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. Ci vediamo a San Jose!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) è stato rilasciato con prestazioni SOTA su LLM & VLM. Il modello di scaling RL è stato addestrato usando verl, raggiungendo prestazioni OpenAI O1-level su benchmark matematici (70.0 pass@1 su AIME).</li>
  <li>[2024/12] verl è stato presentato a Ray Forward 2024. Slide disponibili <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">qui</a></li>
  <li>[2024/12] Il team ha presentato <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> a NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slide</a> e <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">video</a> disponibili.</li>
  <li>[2024/10] verl è stato presentato a Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Video Youtube</a> disponibile.</li>
  <li>[2024/08] HybridFlow (verl) è stato accettato a EuroSys 2025.</li>
</ul>   
</details>

## Caratteristiche principali

- **FSDP**, **FSDP2** e **Megatron-LM** per il training.
- **vLLM**, **SGLang** e **HF Transformers** per la generazione rollout.
- Compatibile con Hugging Face Transformers e Modelscope Hub: [Qwen-3](https://github.com/volcengine/verl/blob/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, ecc.
- Fine-tuning supervisionato.
- Reinforcement learning con [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), ecc.
  - Supporto per reward model-based e function-based (reward verificabile) per matematica, [coding](https://github.com/volcengine/verl/tree/main/recipe/dapo), ecc.
  - Supporto per modelli vision-language (VLM) e [RL multimodale](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) con Qwen2.5-vl, Kimi-VL
  - [Multi-turn con tool calling](https://github.com/volcengine/verl/tree/main/examples/sglang_multiturn)
- Ricette di allineamento LLM come [Self-play preference optimization (SPPO)](https://github.com/volcengine/verl/tree/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) tramite DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Scala fino a modelli da 671B e centinaia di GPU con [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Supporto multi-gpu [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) per risparmiare memoria.
- Tracciamento esperimenti con wandb, swanlab, mlflow e tensorboard.

## Funzionalità e cambiamenti in arrivo

- Roadmap https://github.com/volcengine/verl/issues/710
- Ottimizzazioni DeepSeek 671b con Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Ottimizzazioni multi-turn rollout e tool usage https://github.com/volcengine/verl/issues/1882
- Interazioni con ambienti https://github.com/volcengine/verl/issues/1172
- Lista delle breaking changes dalla v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff ora di default a 0
- Lora per RL https://github.com/volcengine/verl/pull/1127 

## Per iniziare

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Documentazione</b></a>

**Quickstart:**

- [Installazione](https://verl.readthedocs.io/en/latest/start/install.html)
- [Guida rapida](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Guida alla programmazione](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO in verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO in verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Esecuzione di un esempio PPO passo per passo:**

- [Preparare i dati per il post-training](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Implementare la funzione di reward per il dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Architettura esempio PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Spiegazione della configurazione](https://verl.readthedocs.io/en/latest/examples/config.html)

**Baseline di algoritmi riproducibili:**

- [Prestazioni RL su coding, matematica](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Per spiegazioni sul codice e usi avanzati (estensioni):**

- PPO Trainer e Worker
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [Backend PyTorch FSDP](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Backend Megatron-LM](https://verl.readthedocs.io/en/latest/index.html)

- Uso avanzato ed estensioni
  - [Aggiungere modelli con backend FSDP](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Aggiungere modelli con backend Megatron-LM](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Supporto rollout multi-turn](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Integrazione Search Tool](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Integrazione Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Deployment usando risorse GPU separate](https://github.com/volcengine/verl/tree/main/examples/split_placement)
  - [Estendere ad altri algoritmi RL(HF)](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Tutorial design API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blog dalla community**

- [SGLang, verl, OpenBMB e Università di Tsinghua: Pionieri dell'RLHF Multi-Turn End-to-End](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning from Human Feedback su GPU AMD con integrazione verl e ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Sfruttare il training RL](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Best practice GRPO distribuito con verl](https://www.volcengine.com/docs/6459/1463942)
- [Analisi originale HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Fino a 20x throughput! Il team Doubao rilascia nuovo framework RLHF, ora open source!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Guida all'ottimizzazione delle prestazioni

Le prestazioni sono essenziali per algoritmi RL on-policy. Abbiamo scritto una [guida dettagliata all'ottimizzazione delle prestazioni](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) per aiutarti a ottimizzare.

## Aggiornamento a vLLM >= v0.8.2

verl ora supporta vLLM>=0.8.2 quando si usa FSDP come backend di training. Consulta [questo documento](https://github.com/volcengine/verl/blob/main/docs/README_vllm0.8.md) per la guida all'installazione e ulteriori informazioni. Evita vllm 0.7.x, che contiene bug che possono causare OOM e errori inaspettati.

## Usa l'ultima versione di SGLang

SGLang è pienamente supportato con verl, e il gruppo RL di SGLang sta lavorando attivamente su funzionalità uniche, tra cui RL agentico multi-turn, RLHF VLM, RL basato su server e rollout parziale. Consulta [questo documento](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) per installazione e dettagli.

## Aggiornamento a FSDP2

verl adotta completamente FSDP2! FSDP2 è raccomandato dal team torch distributed, offre migliore throughput e uso memoria, ed è componibile con altre funzionalità (es. torch.compile). Per abilitare FSDP2, usa semplicemente verl main e imposta queste opzioni:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
Inoltre, l'offloading CPU di FSDP2 è compatibile con l'accumulo di gradienti. Puoi attivarlo per risparmiare memoria con `actor_rollout_ref.actor.offload_policy=True`. Per maggiori dettagli, vedi https://github.com/volcengine/verl/pull/1026

## Supporto AMD (ROCm Kernel)

verl ora supporta FSDP come motore di training (supporto Megatron in arrivo) e si integra sia con vLLM che SGLang come motori di inferenza. Consulta [questo documento](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) per installazione e dettagli, e [questo documento](https://github.com/volcengine/verl/blob/main/docs/amd_tutorial/amd_vllm_page.rst) per tuning vLLM su ROCm.

## Citazioni e riconoscimenti

Se trovi utile questo progetto, per favore cita:

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

verl si ispira al design di Nemo-Aligner, Deepspeed-chat e OpenRLHF. Il progetto è adottato e contribuito da Bytedance, Anyscale, LMSys.org, [Alibaba Qwen team](https://github.com/QwenLM/), Shanghai AI Lab, Università di Tsinghua, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake, e molti altri.

## Progetti eccellenti che usano verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): una riproduzione della ricetta **DeepSeek R1 Zero** per task di ragionamento ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): RL training per Sky-T1-7B del team NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: esplorare e domare lo Zero RL per Open Base Models in the Wild ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): framework RL **multimodale** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): framework RL tuning LLM Agents per ambienti multi-agente. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): RL async con [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Process reinforcement tramite implicit rewards ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): framework agent RL per ragionamento generale ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL con ragionamento e **searching (tool-call)** interleaved LLM ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): RL training di **search agent** con **esito di ricerca/recupero** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Apprendere a **ragionare** con **Search** per LLM via RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Riproduzione di R1 per **Code** con reward affidabili ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Serie open reasoner Skywork ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Scala RL tool-integrato ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Framework scalabile per training di **LLM/VLM agent long-horizon**, con nuovo algoritmo **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Policy Filtration per PPO basato sull'affidabilità dei segnali di reward per un RLHF più efficiente e robusto.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: Generalist R1-style Vision-Language Action Model per **GUI Agents** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Scala deep research via RL in ambienti reali ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Training agent VLM con RL multi-turn ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: RL per uso strategico dei tool in LLM. Rilascio codice in corso...
- [RM-R1](https://arxiv.org/abs/2505.02387): RL training di reward model per ragionamento ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Framework self-play senza dati umani per il ragionamento![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Apprendere a ragionare con off-policy guidance![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Framework unificato ed estensibile per training tool-agent basato su verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K dati e modelli per il ragionamento matematico![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

e molti altri lavori eccellenti elencati in [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Guida al contributo

I contributi dalla community sono benvenuti! Consulta la nostra [roadmap di progetto](https://github.com/volcengine/verl/issues/710) e [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) per vedere dove puoi contribuire.

### Linting e formattazione del codice

Usiamo pre-commit per migliorare la qualità del codice. Per inizializzare pre-commit, esegui:

```bash
pip install pre-commit
pre-commit install
```

Per risolvere errori CI in locale, puoi eseguire manualmente pre-commit con:

```bash
pre-commit run
```

### Aggiunta di test CI

Se possibile, aggiungi test CI per la tua nuova funzione:

1. Trova il file workflow yml più rilevante, che di solito corrisponde a una config `hydra` di default (es. `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, ecc).
2. Aggiungi pattern di percorso relativi alla sezione `paths` se non già inclusi.
3. Minimizza il carico di lavoro degli script di test (vedi gli script esistenti per esempio).

## Informazioni su [ByteDance Seed Team](https://team.doubao.com/)

Fondato nel 2023, il ByteDance Seed Team è dedicato alla creazione dei modelli AI di base più avanzati del settore. Il team aspira a diventare un team di ricerca di livello mondiale e a contribuire in modo significativo all'avanzamento della scienza e della società. Puoi conoscere meglio Bytedance Seed tramite i seguenti canali👇
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

STIAMO ASSUMENDO! Inviaci una [email](mailto:haibin.lin@bytedance.com) se sei interessato a opportunità di internship/FTE in RL per agenti.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---