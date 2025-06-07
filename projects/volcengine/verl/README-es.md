<div align="center">
 👋 ¡Hola a todos!
    verl es una librería de entrenamiento de RL iniciada por el <b>equipo Seed de ByteDance</b> y mantenida por la comunidad verl.
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

<h1 style="text-align: center;">verl: Volcano Engine Reinforcement Learning for LLMs</h1>

verl es una librería flexible, eficiente y lista para producción para el entrenamiento RL de modelos de lenguaje grande (LLMs).

verl es la versión open-source del artículo **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)**.

verl es flexible y fácil de usar con:

- **Extensión sencilla de diversos algoritmos RL**: El modelo de programación hybrid-controller permite una representación flexible y una ejecución eficiente de flujos de datos complejos de post-entrenamiento. Construye flujos de datos RL como GRPO, PPO en pocas líneas de código.

- **Integración perfecta de infra LLM existente con APIs modulares**: Desacopla dependencias de cómputo y datos, permitiendo integración fluida con frameworks de LLM existentes, como FSDP, Megatron-LM, vLLM, SGLang, etc.

- **Asignación flexible de dispositivos**: Soporta diversas ubicaciones de modelos en diferentes conjuntos de GPUs para una utilización eficiente de recursos y escalabilidad en diferentes tamaños de clúster.

- Integración lista con modelos populares de HuggingFace

verl es rápido con:

- **Rendimiento de última generación**: Integraciones de motores de entrenamiento e inferencia SOTA para LLMs y rendimiento RL SOTA.

- **Rebalanceo eficiente del modelo actor con 3D-HybridEngine**: Elimina redundancia de memoria y reduce significativamente la sobrecarga de comunicación durante las transiciones entre fases de entrenamiento y generación.

</p>

## Noticias

- [2025/06] verl con backend Megatron habilita modelos MoE grandes como [DeepSeek-671b y Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html).
- [2025/06] El equipo de verl presentará las últimas actualizaciones del proyecto en [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/) el 7 de junio. ¡Conoce a nuestro equipo de desarrollo en Beijing!
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957), aceptado en ICML 2025, ¡ya está soportado en verl! PF-PPO mejora la eficiencia y robustez del aprendizaje de políticas filtrando señales de recompensa potencialmente ruidosas y reutilizando experiencias de alta calidad mediante un buffer de repetición.
- [2025/04] Daremos un tutorial sobre las últimas técnicas de post-entrenamiento y guía de programación para verl en [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=), [taller SCI-FM](https://open-foundation-model.github.io/) y [LMSys afterparty](https://lu.ma/d23nyynm). Materiales de la charla disponibles [aquí](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25).
- [2025/04] ¡Se publicó el informe técnico [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf)! Entrenado con verl, Seed-Thinking-v1.5 logra 86.7 en AIME 2024, 55.0 en Codeforces y 77.3 en GPQA, demostrando excelentes capacidades de razonamiento en STEM y codificación. Más allá de tareas de razonamiento, el método demuestra notable generalización en dominios diversos.
- [2025/04] El artículo [VAPO](https://arxiv.org/pdf/2504.05118) (value-based augmented PPO) cubre nuestro método RL más reciente para modelos de razonamiento. Entrenado desde el modelo base Qwen-32B, VAPO alcanza 60.4 en AIME 2024, superando a DAPO-32B.
- [2025/03] ¡Se lanzó verl v0.3.0.post1! Consulta la [nota de lanzamiento](https://github.com/volcengine/verl/releases/) para más detalles. Logra [~1.4x de aceleración](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms) respecto a versiones anteriores.
- [2025/03] [DAPO](https://dapo-sia.github.io/) es el algoritmo RL SOTA open-source que logra 50 puntos en AIME 2024 basado en el modelo preentrenado Qwen2.5-32B, superando el SOTA anterior de GRPO de DeepSeek (DeepSeek-R1-Zero-Qwen-32B). El entrenamiento de DAPO está completamente impulsado por verl y el código de reproducción está disponible en `recipe/dapo`.
<details><summary> más... </summary>
<ul>
  <li>[2025/05] verl será presentado en [A2M Shanghai](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) el 16 y 17 de mayo.</li>
  <li>[2025/05] verl será presentado en [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/). ¡Nos vemos en París!</li>
  <li>[2025/03] Presentamos el modelo de programación de verl en el [vLLM Beijing Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) y [introducción y actualizaciones de verl](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf) en el [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig) en Sunnyvale a mediados de marzo.</li>
  <li>[2025/03] Presentaremos verl (HybridFlow) en EuroSys 2025. ¡Nos vemos en Rotterdam!</li>
  <li>[2025/02] ¡Se lanzó verl v0.2.0.post2!</li>
  <li>[2025/02] Presentamos verl en el <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a>. ¡Nos vemos en San José!</li>
  <li>[2025/01] [Doubao-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) se lanzó con rendimiento SOTA en LLM & VLM. El modelo de previsualización de escalamiento RL está entrenado usando verl, alcanzando rendimiento OpenAI O1 en benchmarks matemáticos (70.0 pass@1 en AIME).</li>
  <li>[2024/12] verl fue presentado en Ray Forward 2024. Slides disponibles <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">aquí</a></li>
  <li>[2024/12] El equipo presentó <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">Post-training LLMs: From Algorithms to Infrastructure</a> en NeurIPS 2024. <a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">Slides</a> y <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">video</a> disponibles.</li>
  <li>[2024/10] verl fue presentado en Ray Summit. <a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Video en Youtube</a> disponible.</li>
  <li>[2024/08] HybridFlow (verl) fue aceptado en EuroSys 2025.</li>
</ul>
</details>

## Características Principales

- **FSDP**, **FSDP2** y **Megatron-LM** para entrenamiento.
- **vLLM**, **SGLang** y **HF Transformers** para generación de rollouts.
- Compatible con Hugging Face Transformers y Modelscope Hub: [Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh), Qwen-2.5, Llama3.1, Gemma2, DeepSeek-LLM, etc.
- Fine-tuning supervisado.
- Aprendizaje por refuerzo con [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/), [GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/), [ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/), [REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm), [RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/), [PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/), [DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/), [DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo), etc.
  - Soporte para recompensas basadas en modelos y recompensas basadas en funciones (recompensa verificable) para matemáticas, [código](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo), etc.
  - Soporte para modelos visión-lenguaje (VLMs) y [RL multimodal](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh) con Qwen2.5-vl, Kimi-VL.
  - [Multi-turn con llamadas a herramientas](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn)
- Recetas de alineamiento LLM como [Self-play preference optimization (SPPO)](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo)
- Flash attention 2, [sequence packing](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh), [paralelismo de secuencia](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh) vía DeepSpeed Ulysses, [LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh), [Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh).
- Escala hasta modelos de 671B y cientos de GPUs con [paralelismo experto](https://github.com/volcengine/verl/pull/1467)
- Soporte RL LoRA multi-GPU [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) para ahorro de memoria.
- Seguimiento de experimentos con wandb, swanlab, mlflow y tensorboard.

## Próximas Características y Cambios

- Roadmap https://github.com/volcengine/verl/issues/710
- Optimizaciones DeepSeek 671b con Megatron v0.11 https://github.com/volcengine/verl/issues/708
- Rollout multi-turn y herramientas usando optimizaciones https://github.com/volcengine/verl/issues/1882
- Interacciones con entornos https://github.com/volcengine/verl/issues/1172
- Lista de cambios incompatibles desde v0.3 https://github.com/volcengine/verl/discussions/943, entropy_coeff por defecto en 0
- Lora para RL https://github.com/volcengine/verl/pull/1127

## Primeros Pasos

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>Documentación</b></a>

**Inicio Rápido:**

- [Instalación](https://verl.readthedocs.io/en/latest/start/install.html)
- [Inicio Rápido](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [Guía de Programación](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [PPO en verl](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [GRPO en verl](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**Ejecutando un ejemplo PPO paso a paso:**

- [Preparar Datos para Post-Entrenamiento](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [Implementar Función de Recompensa para Dataset](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [Arquitectura de Ejemplo PPO](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [Explicación de Configuración](https://verl.readthedocs.io/en/latest/examples/config.html)

**Algoritmos reproducibles baseline:**

- [Rendimiento RL en código, matemáticas](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**Para explicación de código y uso avanzado (extensión):**

- Entrenador PPO y Workers
  - [Entrenador PPO Ray](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [Backend PyTorch FSDP](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Backend Megatron-LM](https://verl.readthedocs.io/en/latest/index.html)

- Uso Avanzado y Extensión
  - [Agregar modelos con el backend FSDP](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [Agregar modelos con el backend Megatron-LM](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [Soporte Rollout Multi-turn](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [Integración de Herramientas de Búsqueda](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [Integración Sandbox Fusion](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [Despliegue usando recursos GPU separados](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [Extender a otros algoritmos RL(HF)](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Tutorial de diseño API Ray](https://verl.readthedocs.io/en/latest/advance/placement.html)

**Blogs de la comunidad**

- [SGLang, verl, OpenBMB y Universidad de Tsinghua: Pioneros en RLHF Multi-turn End-to-End](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [Reinforcement Learning from Human Feedback en GPUs AMD con verl y la integración ROCm](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：Entrenamiento RL avanzado](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [Mejores prácticas para entrenamiento GRPO distribuido con verl](https://www.volcengine.com/docs/6459/1463942)
- [Análisis del original HybridFlow verl](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [¡Hasta 20 veces más rendimiento! El equipo Doubao lanza nuevo framework RLHF, ¡ya open-source!](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## Guía de ajuste de rendimiento

El rendimiento es esencial para los algoritmos RL on-policy. Hemos escrito una [guía detallada de ajuste de rendimiento](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html) para ayudarte a optimizarlo.

## Actualización a vLLM >= v0.8.2

verl ahora soporta vLLM>=0.8.2 al usar FSDP como backend de entrenamiento. Por favor, consulta [este documento](https://raw.githubusercontent.com/volcengine/verl/main/docs/README_vllm0.8.md) para la guía de instalación y más información. Evita vllm 0.7.x, ya que contiene bugs que pueden causar OOM y errores inesperados.

## Usar SGLang más reciente

SGLang está totalmente soportado con verl, y el grupo RL de SGLang trabaja activamente en características únicas, incluyendo RL agentic multi-turn, RLHF VLM, RL basado en servidor y rollout parcial. Consulta [este documento](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html) para la guía de instalación y más información.

## Actualiza a FSDP2

¡verl ya adopta FSDP2! FSDP2 es recomendado por el equipo de torch distributed, ofreciendo mejor rendimiento y uso de memoria, y es componible con otras características (por ejemplo, torch.compile). Para habilitar FSDP2, simplemente usa verl main y configura las siguientes opciones:
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2
reward_model.strategy=fsdp2
```
Además, el offloading de CPU en FSDP2 es compatible con la acumulación de gradientes. Puedes activarlo para ahorrar memoria con `actor_rollout_ref.actor.offload_policy=True`. Para más detalles, consulta https://github.com/volcengine/verl/pull/1026

## Soporte AMD (ROCm Kernel)

verl ya soporta FSDP como motor de entrenamiento (soporte para Megatron próximamente) e integra tanto vLLM como SGLang como motores de inferencia. Consulta [este documento](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_build_dockerfile_page.rst) para la guía de instalación y más información, y [este documento](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_vllm_page.rst) para ajuste de rendimiento de vLLM para ROCm.

## Citación y agradecimientos

Si el proyecto te resulta útil, por favor cita:

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

verl se inspira en el diseño de Nemo-Aligner, Deepspeed-chat y OpenRLHF. El proyecto es adoptado y contribuido por Bytedance, Anyscale, LMSys.org, [Alibaba Qwen team](https://github.com/QwenLM/), Shanghai AI Lab, Tsinghua University, UC Berkeley, UCLA, UIUC, University of Hong Kong, ke.com, [All Hands AI](https://www.all-hands.dev/), [ModelBest](http://modelbest.cn/), OpenPipe, JD AI Lab, Microsoft Research, [StepFun](https://www.stepfun.com/), Amazon, Linkedin, Meituan, [Camel-AI](https://www.camel-ai.org/), [OpenManus](https://github.com/OpenManus), Xiaomi, Prime Intellect, NVIDIA research, [Baichuan](https://www.baichuan-ai.com/home), [RedNote](https://www.xiaohongshu.com/), [SwissAI](https://www.swiss-ai.org/), [Moonshot AI (Kimi)](https://www.moonshot-ai.com/), Baidu, Snowflake y muchos más.

## Proyectos destacados usando verl

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero): una reproducción de la receta **DeepSeek R1 Zero** para tareas de razonamiento ![GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought): Entrenamiento RL para Sky-T1-7B por el equipo NovaSky AI. ![GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason): SimpleRL-Zoo: Investigando y Domando RL Cero para modelos base abiertos en entornos reales ![GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1): Framework de entrenamiento RL **multimodal** ![GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL): Framework RL de ajuste para agentes LLM en múltiples entornos de agente. ![GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm): Entrenamiento RL asíncrono con [verl-pipeline](https://github.com/agentica-project/verl-pipeline) ![GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME): Refuerzo de procesos a través de recompensas implícitas ![GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen): Framework general para el entrenamiento de **agentes** de razonamiento ![GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1): RL con razonamiento y **búsqueda (tool-call)** intercalados en LLMs ![GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval): Entrenamiento RL de **Search Agent** con **resultado Search/Retrieval** ![GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch): Aprender a **razonar** con **búsqueda** para LLMs vía RL ![GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1): Reproduciendo R1 para **Código** con recompensas confiables ![GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1): Serie open reasoner de Skywork ![GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL): Escalando RL integrado con herramientas ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent): Framework escalable para entrenamiento de **agentes LLM/VLM de largo horizonte**, junto con el nuevo algoritmo **GiGPO** ![GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957): Filtración de políticas para PPO basada en la confiabilidad de señales de recompensa para RLHF más eficiente y robusto.
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1): **GUI-R1**: Modelo de acción visión-lenguaje generalista tipo R1 para **agentes GUI** ![GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher): Escalando investigación profunda mediante RL en entornos reales ![GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN): Entrenamiento de agentes VLM con RL multi-turn ![GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/): ReTool: aprendizaje por refuerzo para el uso estratégico de herramientas en LLMs. Próxima liberación de código...
- [RM-R1](https://arxiv.org/abs/2505.02387): Entrenamiento RL de modelos de recompensa de razonamiento ![GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335): Framework self-play sin datos curados humanos para razonamiento ![GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945): Aprendiendo a razonar bajo guía off-policy ![GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool): Unificado y fácil de extender framework de entrenamiento de agentes-herramienta basado en verl![GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath): DeepMath-103K y modelos de la serie para razonamiento matemático![GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

y muchos más trabajos destacados listados en [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md).

## Guía de Contribución

¡Las contribuciones de la comunidad son bienvenidas! Consulta nuestra [hoja de ruta](https://github.com/volcengine/verl/issues/710) y [good first issues](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) para ver dónde puedes contribuir.

### Linting y Formateo de Código

Usamos pre-commit para ayudar a mejorar la calidad del código. Para inicializar pre-commit, ejecuta:

```bash
pip install pre-commit
pre-commit install
```

Para resolver errores de CI localmente, puedes ejecutar pre-commit manualmente:

```bash
pre-commit run
```

### Agregar pruebas CI

Si es posible, por favor añade prueba(s) CI para tu nueva funcionalidad:

1. Encuentra el archivo workflow yml más relevante, que usualmente corresponde a una configuración por defecto de `hydra` (por ejemplo, `ppo_trainer`, `ppo_megatron_trainer`, `sft_trainer`, etc).
2. Añade los patrones de ruta relacionados a la sección `paths` si aún no están incluidos.
3. Minimiza la carga de trabajo de los scripts de prueba (ver ejemplos existentes).

## Sobre el [Equipo Seed de ByteDance](https://team.doubao.com/)

Fundado en 2023, el equipo Seed de ByteDance se dedica a crear los modelos de IA fundacionales más avanzados de la industria. El equipo aspira a convertirse en un equipo de investigación de clase mundial y hacer contribuciones significativas al avance de la ciencia y la sociedad. Puedes conocer mejor al equipo Seed de Bytedance a través de los siguientes canales👇
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

¡Estamos CONTRATANDO! Envíanos un [email](mailto:haibin.lin@bytedance.com) si te interesan oportunidades de prácticas o FTE en RL para agentes.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---