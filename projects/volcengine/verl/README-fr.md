<div align="center">
 👋 Bonjour à tous ! 
    verl est une bibliothèque d'entraînement RL initiée par l'<b>équipe ByteDance Seed</b> et maintenue par la communauté verl.
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

<h1 style="text-align: center;">verl : Volcano Engine Reinforcement Learning pour LLMs</h1>

verl est une bibliothèque d'entraînement RL flexible, efficace et prête pour la production pour les grands modèles de langage (LLMs).

verl est la version open source de l'article **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl est flexible et facile à utiliser avec :

- **Extension facile de divers algorithmes RL** : Le modèle de programmation hybrid-controller permet une représentation flexible et une exécution efficace de flux de données complexes de post-entraînement. Construisez des flux RL tels que GRPO, PPO en quelques lignes de code.

- **Intégration transparente de l'infrastructure LLM existante avec des API modulaires** : Découple les dépendances de calcul et de données, permettant une intégration transparente avec les frameworks LLM existants, tels que FSDP, Megatron-LM, vLLM, SGLang, etc.

- **Mapping flexible des dispositifs** : Prend en charge divers placements de modèles sur différents ensembles de GPU pour une utilisation efficace des ressources et une évolutivité sur différentes tailles de clusters.

- Intégration prête à l'emploi avec les modèles populaires HuggingFace

verl est rapide avec :

- **Débit à l'état de l'art** : Intégration des moteurs d'entraînement et d'inférence SOTA pour LLM, ainsi qu'un débit RL SOTA.

- **Resharding efficace des modèles acteurs avec 3D-HybridEngine** : Élimine la redondance mémoire et réduit considérablement les surcoûts de communication lors des transitions entre les phases d'entraînement et de génération.

</p>

## Actualités

- [2025/06] verl avec backend Megatron permet de supporter de grands modèles MoE tels que [DeepSeek-671b et Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] L'équipe verl présentera les dernières avancées du projet lors du [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) le 7 juin. Rencontrez notre équipe de dev à Pékin !
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), accepté à l'ICML 2025, est désormais supporté dans verl ! PF-PPO améliore l'efficacité et la robustesse de l'apprentissage de la politique en filtrant les signaux de récompense potentiellement bruyants et en réutilisant les expériences de haute qualité via un buffer de relecture.
- [2025/04] Nous donnerons un tutoriel sur les dernières techniques de post-entraînement et le guide de programmation pour verl lors de [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [atelier SCI-FM](https://open-foundation-model.github.io/) et [LMSys afterparty](https://lu.ma/d23nyynm). Les supports de présentation sont disponibles [ici](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] Le rapport technique [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) est publié ! Entraîné avec verl, Seed-Thinking-v1.5 atteint 86.7 sur AIME 2024, 55.0 sur Codeforces et 77.3 sur GPQA, démontrant d'excellentes capacités de raisonnement en STEM et codage. Au-delà des tâches de raisonnement, la méthode démontre une généralisation notable sur divers domaines.
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) présente notre dernière méthode RL pour les modèles de raisonnement. Entraîné à partir du modèle Qwen-32B-base, VAPO atteint 60.4 sur AIME 2024, surpassant DAPO-32B.
- [2025/03] verl v0.3.0.post1 est publié ! Voir la [note de version](https://github.com/volcengine/verl/releases/) pour plus de détails. Il atteint [~1.4x d'accélération](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) par rapport aux versions précédentes.
- [2025/03] [DAPO](https://dapo-sia.github.io/) est l'algorithme RL SOTA open source qui atteint 50 points sur AIME 2024 basé sur le modèle pré-entraîné Qwen2.5-32B, surpassant le précédent SOTA de DeepSeek GRPO (DeepSeek-R1-Zero-Qwen-32B). L'entraînement de DAPO est entièrement propulsé par verl et le code de reproduction est disponible dans `recipe/dapo` maintenant.
<details><summary> plus... </summary>
<ul>
  <li>[2025/05] verl sera présenté à [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) du 16 au 17 mai.</li>
  <li>[2025/05] verl sera présenté à [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). À bientôt à Paris !</li>
  <li>[2025/03] Nous avons présenté le modèle de programmation de verl lors du [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) et [présentation et mises à jour de verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) lors du [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) à Sunnyvale mi-mars.</li>
  <li>[2025/03] Nous présenterons verl (HybridFlow) à EuroSys 2025. Rendez-vous à Rotterdam !</li>
  <li>[2025/02] verl v0.2.0.post2 est publié !</li>
  <li>[2025/02] Nous avons présenté verl lors du <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. Rendez-vous à San Jose !</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) est publié avec des performances SOTA sur LLM & VLM. Le modèle d'aperçu RL scaling a été entraîné avec verl, atteignant des performances de niveau OpenAI O1 sur les benchmarks de mathématiques (70.0 pass@1 sur AIME).</li>
  <li>[2024/12] verl a été présenté à Ray Forward 2024. Slides disponibles <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">ici</a></li>
  <li>[2024/12] L'équipe a présenté <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> à NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slides</a> et <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">vidéo</a> disponibles.</li>
  <li>[2024/10] verl a été présenté au Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Vidéo Youtube</a> disponible.</li>
  <li>[2024/08] HybridFlow (verl) est accepté à EuroSys 2025.</li>
</ul>   
</details>

## Fonctionnalités clés

- **FSDP**, **FSDP2** et **Megatron-LM** pour l'entraînement.
- **vLLM**, **SGLang** et **HF Transformers** pour la génération des rollouts.
- Compatible avec Hugging Face Transformers et Modelscope Hub : [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, etc.
- Fine-tuning supervisé.
- Apprentissage par renforcement avec [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), etc.
  - Supporte la récompense basée sur un modèle et la récompense basée sur une fonction (récompense vérifiable) pour les maths, [le codage](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo), etc.
  - Supporte les modèles vision-langage (VLMs) et [RL multi-modal](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) avec Qwen2.5-vl, Kimi-VL
  - [Multi-turn avec appel d’outils](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn)
- Recettes d'alignement LLM comme [Self-play preference optimization (SPPO)](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [sequence parallelism](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) via DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Évolue jusqu’à 671B de paramètres et des centaines de GPU avec [expert parallelism](https://github.com/volcengine/verl/pull/1467)
- Support RL LoRA multi-gpu [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) pour économiser de la mémoire.
- Suivi d'expérience avec wandb, swanlab, mlflow et tensorboard.

## Fonctionnalités et changements à venir

- Roadmap https://github.com/volcengine/verl/issues/710
- Optimisations DeepSeek 671b avec Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Multi-turn rollout et outils utilisant des optimisations https://github.com/volcengine/verl/issues/1882
- Interactions avec l'environnement https://github.com/volcengine/verl/issues/1172
- Liste des changements majeurs depuis v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff par défaut à 0
- Lora pour RL https://github.com/volcengine/verl/pull/1127 

## Démarrage rapide

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Documentation</b></a>

**Démarrage rapide :**

- [Installation](https://verl.readthedocs.io/en/latest/start/install.html)
- [Quickstart](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Guide de programmation](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO dans verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO dans verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Exécution pas à pas d'un exemple PPO :**


- [Préparer les données pour le post-entraînement](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Implémenter une fonction de récompense pour le dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Architecture d’un exemple PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Explication des configs](https://verl.readthedocs.io/en/latest/examples/config.html)

**Algorithmes de référence reproductibles :**

- [Performances RL sur le codage, les maths](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Pour l'explication du code et l'utilisation avancée (extension) :**

- PPO Trainer et Workers
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [Backend PyTorch FSDP](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Backend Megatron-LM](https://verl.readthedocs.io/en/latest/index.html)

- Utilisation avancée et extension
  - [Ajouter des modèles avec le backend FSDP](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Ajouter des modèles avec le backend Megatron-LM](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Support multi-turn rollout](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Intégration d’outils de recherche](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Intégration Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Déploiement avec répartition GPU séparée](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [Extension à d’autres algorithmes RL(HF)](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Tutoriel sur la conception d’API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blogs de la communauté**

- [SGLang, verl, OpenBMB et Université Tsinghua : Pionniers du RLHF multi-turn de bout en bout](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning from Human Feedback sur GPU AMD avec intégration verl et ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl : Jouer avec l’entraînement RL](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Meilleures pratiques pour l'entraînement RL distribué GRPO avec verl](https://www.volcengine.com/docs/6459/1463942)
- [Analyse du texte original HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [Jusqu’à 20 fois plus de débit ! L’équipe Doubao publie un nouveau framework RLHF, désormais open source !](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Guide d'optimisation des performances

La performance est essentielle pour les algorithmes RL on-policy. Nous avons rédigé un [guide détaillé d’optimisation des performances](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) pour vous aider à optimiser les performances.

## Mise à niveau vers vLLM >= v0.8.2

verl supporte désormais vLLM>=0.8.2 lorsque FSDP est utilisé comme backend d'entraînement. Veuillez consulter [ce document](https://raw.githubusercontent.com/volcengine/verl/main/docs/README_vllm0.8.md) pour le guide d'installation et plus d'informations. Évitez vllm 0.7.x, qui contient des bugs pouvant entraîner des OOM et des erreurs inattendues.

## Utilisez la dernière version de SGLang

SGLang est entièrement pris en charge avec verl, et le groupe SGLang RL travaille activement sur le développement de fonctionnalités uniques, y compris RL agentique multi-turn, VLM RLHF, RL basé serveur et rollout partiel. Veuillez consulter [ce document](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) pour le guide d'installation et plus d'informations.

## Mise à niveau vers FSDP2

verl adopte pleinement FSDP2 ! FSDP2 est recommandé par l’équipe torch distributed, offrant un meilleur débit et une meilleure gestion de la mémoire, et il est composable avec d’autres fonctionnalités (par exemple torch.compile). Pour activer FSDP2, utilisez simplement verl main et définissez les options suivantes :
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
De plus, l’offloading CPU FSDP2 est compatible avec l’accumulation de gradients. Vous pouvez l’activer pour économiser de la mémoire avec `actor_rollout_ref.actor.offload_policy=True`. Pour plus de détails, voir https://github.com/volcengine/verl/pull/1026

## Support AMD (ROCm Kernel)

verl prend maintenant en charge FSDP comme moteur d’entraînement (Megatron sera bientôt supporté) et s’intègre à la fois à vLLM et SGLang comme moteurs d’inférence. Veuillez consulter [ce document](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) pour le guide d'installation et plus d'informations, et [ce document](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_vllm_page.rst) pour l’optimisation des performances vLLM pour ROCm.

## Citation et remerciements

Si ce projet vous a été utile, merci de citer :

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

verl s’inspire du design de Nemo-Aligner, Deepspeed-chat et OpenRLHF. Le projet est adopté et contribué par Bytedance, Anyscale, LMSys.org, [équipe Alibaba Qwen](https://github.com/QwenLM/), Shanghai AI Lab, Université Tsinghua, UC Berkeley, UCLA, UIUC, Université de Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake, et bien d’autres.

## Projets remarquables utilisant verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero) : une reproduction de la recette **DeepSeek R1 Zero** pour les tâches de raisonnement ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought) : entraînement RL pour Sky-T1-7B par l’équipe NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason) : SimpleRL-Zoo : étude et adaptation du Zero RL pour les modèles open base dans la nature ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1) : framework d’entraînement RL **multi-modal** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL) : framework RL tuning d’agents LLM pour environnements multi-agents. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm) : entraînement RL asynchrone avec [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME) : renforcement de processus via récompenses implicites ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen) : framework d’entraînement d’**agent** de raisonnement polyvalent ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1) : RL avec raisonnement et **recherche (tool-call)** intercalés dans les LLMs ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval) : entraînement RL d’**agents de recherche** avec **résultats de recherche/retrieval** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch) : apprentissage du raisonnement avec recherche pour LLMs via RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1) : reproduction de R1 pour le **code** avec récompenses fiables ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1) : série open reasoner Skywork ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL) : scaling RL intégré aux outils ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent) : framework d’entraînement évolutif pour **agents LLM/VLM longue-horizon**, avec un nouvel algorithme **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957) : Policy Filtration pour PPO basée sur la fiabilité des signaux de récompense pour un RLHF plus efficace et robuste.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1) : **GUI-R1** : un modèle action Vision-Language R1 généraliste pour **agents GUI** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher) : scaling deep research via RL dans des environnements réels ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN) : entraînement d’agents VLM avec RL multi-turn ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/) : ReTool : RL pour l’utilisation stratégique d’outils dans les LLMs. Publication du code en cours...
- [RM-R1](https://arxiv.org/abs/2505.02387) : entraînement RL de modèles de récompense de raisonnement ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335) : framework self-play sans données humaines pour le raisonnement ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945) : apprendre à raisonner sous guidance off-policy ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool) : un framework unifié et facile à étendre pour l’entraînement d’agents-outils basé sur verl ![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath) : données DeepMath-103K et modèles de la série pour le raisonnement mathématique ![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

et bien d’autres projets remarquables listés dans [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).
## Guide de contribution

Les contributions de la communauté sont les bienvenues ! Consultez notre [roadmap du projet](https://github.com/volcengine/verl/issues/710) et les [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) pour savoir où contribuer.

### Linting et formatage du code

Nous utilisons pre-commit pour améliorer la qualité du code. Pour initialiser pre-commit, exécutez :

```bash
pip install pre-commit
pre-commit install
```

Pour résoudre les erreurs CI localement, vous pouvez lancer pre-commit manuellement :

```bash
pre-commit run
```

### Ajout de tests CI

Si possible, merci d’ajouter un ou plusieurs tests CI pour votre nouvelle fonctionnalité :

1. Trouvez le fichier workflow yml le plus pertinent, généralement associé à une config hydra par défaut (ex : `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, etc).
2. Ajoutez les patterns de chemin liés dans la section `paths` si ce n’est pas déjà fait.
3. Minimisez la charge de travail des scripts de test (voir les scripts existants pour des exemples).

## À propos de l’[équipe ByteDance Seed](https://team.doubao.com/)

Fondée en 2023, l’équipe ByteDance Seed s’engage à concevoir les modèles d’IA fondamentaux les plus avancés de l’industrie. L’équipe aspire à devenir une équipe de recherche de classe mondiale et à contribuer de manière significative à l’avancement de la science et de la société. Vous pouvez découvrir l’équipe ByteDance Seed via les canaux suivants👇
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

Nous RECRUTONS ! Envoyez-nous un [email](mailto:haibin.lin@bytedance.com) si vous êtes intéressé(e) par un stage ou un poste FTE en RL pour agents.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---