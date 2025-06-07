<div align="center">
 👋 大家好！
    verl 是由 <b>字节跳动 Seed 团队</b> 发起并由 verl 社区维护的强化学习训练库。
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

<h1 style="text-align: center;">verl：Volcano Engine 大语言模型强化学习库</h1>

verl 是一个为大语言模型（LLMs）设计的灵活、高效、可用于生产的强化学习训练库。

verl 是 **[HybridFlow: A Flexible and Efficient RLHF Framework](https://arxiv.org/abs/2409.19256v2)** 论文的开源实现。

verl 具有灵活易用的特性：

- **多样化 RL 算法的易扩展性**：混合控制器编程模型可灵活表达和高效执行复杂的后训练数据流。仅需几行代码即可构建 GRPO、PPO 等强化学习数据流。
- **通过模块化 API 与现有 LLM 基础设施无缝集成**：计算和数据依赖分离，可与现有 LLM 框架（如 FSDP、Megatron-LM、vLLM、SGLang 等）无缝衔接。
- **灵活的设备映射**：支持模型在不同 GPU 组上的多样部署，实现高效的资源利用与跨集群规模扩展。
- 现成集成 HuggingFace 流行模型。

verl 具有高性能：

- **业界领先的吞吐量**：集成业界前沿的大模型训练与推理引擎，强化学习吞吐性能卓越。
- **3D-HybridEngine 高效 actor 模型重分片**：消除冗余内存，极大减少训练与生成阶段切换时的通信开销。

</p>

## 最新动态

- [2025/06] verl 结合 Megatron 后端支持 [DeepSeek-671b 和 Qwen3-236b](https://verl.readthedocs.io/en/latest/perf/dpsk.html) 等超大 MoE 模型。
- [2025/06] verl 团队将于 [PyTorch Day China](https://www.lfasiallc.com/pytorch-day-china/)（6月7日，北京）带来项目最新进展，欢迎线下交流！
- [2025/05] [PF-PPO](https://arxiv.org/abs/2409.06957) 已集成进 verl！PF-PPO 通过过滤噪声奖励信号并复用高质量经验，提高策略学习效率与鲁棒性，论文被 ICML 2025 接收。
- [2025/04] 在 [ICLR 2025 Expo](https://iclr.cc/virtual/2025/calendar?filter_events=Expo+Talk+Panel&filter_rooms=)、[SCI-FM workshop](https://open-foundation-model.github.io/)、[LMSys afterparty](https://lu.ma/d23nyynm) 分享 verl 最新后训练技术和编程指南，讲稿见[这里](https://github.com/eric-haibin-lin/verl-community/tree/main/iclr25)。
- [2025/04] [Seed-Thinking-v1.5](https://github.com/ByteDance-Seed/Seed-Thinking-v1.5/blob/main/seed-thinking-v1.5.pdf) 技术报告发布！该模型通过 verl 训练，在 AIME 2024 取得 86.7 分，Codeforces 55.0，GPQA 77.3，展现出卓越的 STEM 和编程推理能力，并在多领域泛化表现突出。
- [2025/04] [VAPO](https://arxiv.org/pdf/2504.05118)（基于价值的增强型 PPO）论文发布。该方法用 Qwen-32B-base 训练，在 AIME 2024 达到 60.4 分，优于 DAPO-32B。
- [2025/03] verl v0.3.0.post1 发布！详见 [release note](https://github.com/volcengine/verl/releases/)，相较前版本实现约 [1.4 倍加速](https://tongyx361.github.io/blogs/posts/verl-intro/#/verl-flexible-and-efficient-rl-for-llms)。
- [2025/03] [DAPO](https://dapo-sia.github.io/) 开源，基于 Qwen2.5-32B 预训练模型，在 AIME 2024 取得 50 分，超越 DeepSeek GRPO（DeepSeek-R1-Zero-Qwen-32B），训练完全基于 verl，复现代码已在 `recipe/dapo`。
<details><summary>更多动态...</summary>
<ul>
  <li>[2025/05] verl 将于 [A2M 上海](https://a2m.msup.com.cn/home/?aid=4488&city=shanghai) 5/16-5/17 亮相。</li>
  <li>[2025/05] verl 将在 [GOSIM x PyTorch Day 2025](https://paris2025.gosim.org/) 展示，巴黎见！</li>
  <li>[2025/03] 在 [vLLM 北京 Meetup](https://mp.weixin.qq.com/s/n77GibL2corAtQHtVEAzfg) 和 [SGLang-LMSYS Org Meetup](https://lu.ma/ntjrr7ig)（Sunnyvale）介绍 verl 编程模型与最新进展，资料见[此处](https://github.com/eric-haibin-lin/verl-community/blob/main/slides/verl-lmsys-meetup.pdf)。</li>
  <li>[2025/03] verl（HybridFlow）将亮相 EuroSys 2025，鹿特丹见！</li>
  <li>[2025/02] verl v0.2.0.post2 发布！</li>
  <li>[2025/02] 于 <a href="https://lu.ma/ji7atxux">Bytedance/NVIDIA/Anyscale Ray Meetup</a> 展示 verl，圣何塞见！</li>
  <li>[2025/01] [豆包-1.5-pro](https://team.doubao.com/zh/special/doubao_1_5_pro) 发布，LLM & VLM 达到 SOTA 水平。RL scaling 预览模型用 verl 训练，数学榜单 OpenAI O1（AIME pass@1 70.0）。</li>
  <li>[2024/12] verl 于 Ray Forward 2024 亮相，PPT <a href="https://github.com/eric-haibin-lin/verl-community/blob/main/slides/Ray_Forward_2024_%E5%B7%AB%E9%94%A1%E6%96%8C.pdf">下载</a></li>
  <li>[2024/12] 团队于 NeurIPS 2024 展示 <a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">后训练 LLMs: 从算法到基础设施</a>，<a href="https://github.com/eric-haibin-lin/verl-data/tree/neurips">PPT</a>、<a href="https://neurips.cc/Expo/Conferences/2024/workshop/100677">视频</a>均已上线。</li>
  <li>[2024/10] verl 于 Ray Summit 亮相，<a href="https://www.youtube.com/watch?v=MrhMcXkXvJU&list=PLzTswPQNepXntmT8jr9WaNfqQ60QwW7-U&index=37">Youtube 视频</a>可观看。</li>
  <li>[2024/08] HybridFlow (verl) 被 EuroSys 2025 接收。</li>
</ul>
</details>

## 主要特性

- 训练支持 **FSDP**、**FSDP2** 和 **Megatron-LM**。
- 推理生成支持 **vLLM**、**SGLang** 和 **HF Transformers**。
- 兼容 Hugging Face Transformers 及 Modelscope Hub：[Qwen-3](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen3-8b.sh)、Qwen-2.5、Llama3.1、Gemma2、DeepSeek-LLM 等。
- 支持有监督微调。
- 强化学习支持 [PPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/)、[GRPO](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/)、[ReMax](https://raw.githubusercontent.com/volcengine/verl/main/examples/remax_trainer/)、[REINFORCE++](https://verl.readthedocs.io/en/latest/examples/config.html#algorithm)、[RLOO](https://raw.githubusercontent.com/volcengine/verl/main/examples/rloo_trainer/)、[PRIME](https://raw.githubusercontent.com/volcengine/verl/main/recipe/prime/)、[DAPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo/)、[DrGRPO](https://raw.githubusercontent.com/volcengine/verl/main/recipe/drgrpo) 等。
  - 支持基于模型的奖励与基于函数的可验证奖励，适用于数学、[代码](https://raw.githubusercontent.com/volcengine/verl/main/recipe/dapo)等领域。
  - 支持视觉-语言模型（VLM）及[多模态 RL](https://raw.githubusercontent.com/volcengine/verl/main/examples/grpo_trainer/run_qwen2_5_vl-7b.sh)，如 Qwen2.5-vl、Kimi-VL。
  - [多轮工具调用](https://raw.githubusercontent.com/volcengine/verl/main/examples/sglang_multiturn)
- LLM 对齐配方如 [自博弈偏好优化（SPPO）](https://raw.githubusercontent.com/volcengine/verl/main/recipe/sppo)
- Flash attention 2、[序列打包](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_qwen2-7b_seq_balance.sh)、[序列并行](https://raw.githubusercontent.com/volcengine/verl/main/examples/ppo_trainer/run_deepseek7b_llm_sp2.sh)（DeepSpeed Ulysses）、[LoRA](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_peft.sh)、[Liger-kernel](https://raw.githubusercontent.com/volcengine/verl/main/examples/sft/gsm8k/run_qwen_05_sp2_liger.sh)。
- 支持 671B 超大模型与数百卡训练，具备 [专家并行](https://raw.githubusercontent.com/volcengine/verl/main/pull/1467) 能力。
- 多卡 [LoRA RL](https://verl.readthedocs.io/en/latest/advance/ppo_lora.html) 节省显存。
- 支持 wandb、swanlab、mlflow、tensorboard 等实验追踪。

## 即将上线特性与变更

- 路线图 https://github.com/volcengine/verl/issues/710
- DeepSeek 671b 在 Megatron v0.11 下的优化 https://github.com/volcengine/verl/issues/708
- 多轮 rollout 与工具调用优化 https://github.com/volcengine/verl/issues/1882
- 环境交互支持 https://github.com/volcengine/verl/issues/1172
- v0.3 以来的重大变更列表 https://github.com/volcengine/verl/discussions/943，entropy_coeff 默认值为 0
- RL 的 Lora 支持 https://github.com/volcengine/verl/pull/1127

## 快速上手

<a href="https://verl.readthedocs.io/en/latest/index.html"><b>文档中心</b></a>

**快速入门：**

- [安装教程](https://verl.readthedocs.io/en/latest/start/install.html)
- [快速上手](https://verl.readthedocs.io/en/latest/start/quickstart.html)
- [编程指南](https://verl.readthedocs.io/en/latest/hybrid_flow.html)
- [verl 中的 PPO](https://verl.readthedocs.io/en/latest/algo/ppo.html)
- [verl 中的 GRPO](https://verl.readthedocs.io/en/latest/algo/grpo.html)

**PPO 示例分步运行：**

- [后训练数据准备](https://verl.readthedocs.io/en/latest/preparation/prepare_data.html)
- [奖励函数实现](https://verl.readthedocs.io/en/latest/preparation/reward_function.html)
- [PPO 示例架构](https://verl.readthedocs.io/en/latest/examples/ppo_code_architecture.html)
- [配置文件说明](https://verl.readthedocs.io/en/latest/examples/config.html)

**可复现算法基线：**

- [代码、数学 RL 性能](https://verl.readthedocs.io/en/latest/algo/baseline.html)

**代码说明与进阶扩展：**

- PPO Trainer 与 Workers
  - [PPO Ray Trainer](https://verl.readthedocs.io/en/latest/workers/ray_trainer.html)
  - [PyTorch FSDP 后端](https://verl.readthedocs.io/en/latest/workers/fsdp_workers.html)
  - [Megatron-LM 后端](https://verl.readthedocs.io/en/latest/index.html)

- 高级用法与扩展
  - [添加 FSDP 后端模型](https://verl.readthedocs.io/en/latest/advance/fsdp_extension.html)
  - [添加 Megatron-LM 后端模型](https://verl.readthedocs.io/en/latest/advance/megatron_extension.html)
  - [多轮 Rollout 支持](https://verl.readthedocs.io/en/latest/sglang_multiturn/multiturn.html)
  - [集成搜索工具](https://verl.readthedocs.io/en/latest/sglang_multiturn/search_tool_example.html)
  - [沙盒融合集成](https://verl.readthedocs.io/en/latest/examples/sandbox_fusion_example.html)
  - [分卡部署](https://raw.githubusercontent.com/volcengine/verl/main/examples/split_placement)
  - [扩展到其他 RL(HF) 算法](https://verl.readthedocs.io/en/latest/advance/dpo_extension.html)
  - [Ray API 设计教程](https://verl.readthedocs.io/en/latest/advance/placement.html)

**社区博客**

- [SGLang、verl、OpenBMB 与清华大学：多轮 RLHF 端到端突破](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/multi-turn/verl-multiturn-rollout-Release.md)
- [verl 与 ROCm 集成于 AMD GPU 上实现人类反馈强化学习](https://rocm.blogs.amd.com/artificial-intelligence/verl-large-scale/README.html)
- [veMLP x verl ：玩转强化学习训练](https://mp.weixin.qq.com/s/7nbqxk4knMGd-hQE9ls2tA)
- [使用 verl 进行 GRPO 分布式强化学习训练最佳实践](https://www.volcengine.com/docs/6459/1463942)
- [HybridFlow verl 原文浅析](https://github.com/zhaochenyang20/Awesome-ML-SYS-Tutorial/blob/main/rlhf/verl/readme.md)
- [最高提升 20 倍吞吐量！豆包大模型团队发布全新 RLHF 框架，现已开源！](https://team.doubao.com/en/blog/%E6%9C%80%E9%AB%98%E6%8F%90%E5%8D%8720%E5%80%8D%E5%90%9E%E5%90%90%E9%87%8F-%E8%B1%86%E5%8C%85%E5%A4%A7%E6%A8%A1%E5%9E%8B%E5%9B%A2%E9%98%9F%E5%8F%91%E5%B8%83%E5%85%A8%E6%96%B0-rlhf-%E6%A1%86%E6%9E%B6-%E7%8E%B0%E5%B7%B2%E5%BC%80%E6%BA%90)

## 性能调优指南

强化学习（on-policy RL）性能至关重要。我们已撰写详细的[性能调优指南](https://verl.readthedocs.io/en/latest/perf/perf_tuning.html)，帮助你优化训练效率。

## 升级到 vLLM >= v0.8.2

verl 现已支持在 FSDP 训练后端下使用 vLLM>=0.8.2。请参考[安装与说明文档](https://raw.githubusercontent.com/volcengine/verl/main/docs/README_vllm0.8.md)。请避免使用 vllm 0.7.x，该版本存在导致 OOM 和异常的已知 bug。

## 最新 SGLang 支持

verl 全面支持 SGLang，SGLang RL 团队持续开发如多轮智能体 RL、VLM RLHF、服务端 RL、部分 rollout 等功能。安装与说明详见[文档](https://verl.readthedocs.io/en/latest/workers/sglang_worker.html)。

## 升级到 FSDP2

verl 已全面支持 FSDP2！FSDP2 由 torch distributed 团队推荐，具备更优吞吐和显存占用，并可与 torch.compile 等特性组合。启用 FSDP2，只需在 verl main 设置如下选项：
```
actor_rollout_ref.ref.strategy=fsdp2
actor_rollout_ref.actor.strategy=fsdp2
critic.strategy=fsdp2 
reward_model.strategy=fsdp2 
```
此外，FSDP2 支持 CPU offload 与梯度累积兼容。可通过 `actor_rollout_ref.actor.offload_policy=True` 节省显存。详细说明见 https://github.com/volcengine/verl/pull/1026

## 支持 AMD (ROCm 内核)

verl 现已支持 FSDP 训练引擎（Megatron 支持即将上线），并可集成 vLLM、SGLang 推理引擎。安装与说明详见[AMD 教程文档](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_build_dockerfile_page.rst)，vLLM 性能调优见[此文档](https://raw.githubusercontent.com/volcengine/verl/main/docs/amd_tutorial/amd_vllm_page.rst)。

## 引用与致谢

如果本项目对您有帮助，请引用：

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

verl 受到 Nemo-Aligner、Deepspeed-chat、OpenRLHF 等项目设计启发，并获得字节跳动、Anyscale、LMSys.org、[阿里巴巴 Qwen 团队](https://github.com/QwenLM/)、上海 AI Lab、清华大学、UC Berkeley、UCLA、UIUC、香港大学、ke.com、[All Hands AI](https://www.all-hands.dev/)、[ModelBest](http://modelbest.cn/)、OpenPipe、京东 AI Lab、微软研究院、[StepFun](https://www.stepfun.com/)、亚马逊、Linkedin、美团、[Camel-AI](https://www.camel-ai.org/)、[OpenManus](https://github.com/OpenManus)、小米、Prime Intellect、NVIDIA 研究院、[百川](https://www.baichuan-ai.com/home)、[小红书](https://www.xiaohongshu.com/)、[SwissAI](https://www.swiss-ai.org/)、[Moonshot AI (Kimi)](https://www.moonshot-ai.com/)、百度、Snowflake 等众多机构采用及贡献。

## 基于 verl 的优秀开源项目

- [TinyZero](https://github.com/Jiayi-Pan/TinyZero)：**DeepSeek R1 Zero** 配方复现！[GitHub Repo stars](https://img.shields.io/github/stars/Jiayi-Pan/TinyZero)
- [SkyThought](https://github.com/NovaSky-AI/SkyThought)：NovaSky AI 团队 Sky-T1-7B 强化学习训练。[GitHub Repo stars](https://img.shields.io/github/stars/NovaSky-AI/SkyThought)
- [simpleRL-reason](https://github.com/hkust-nlp/simpleRL-reason)：SimpleRL-Zoo：开放基座模型零样本强化学习探索！[GitHub Repo stars](https://img.shields.io/github/stars/hkust-nlp/simpleRL-reason)
- [Easy-R1](https://github.com/hiyouga/EasyR1)：**多模态** RL 训练框架！[GitHub Repo stars](https://img.shields.io/github/stars/hiyouga/EasyR1)
- [OpenManus-RL](https://github.com/OpenManus/OpenManus-RL)：多智能体环境 LLM Agents RL 调优框架。[GitHub Repo stars](https://img.shields.io/github/stars/OpenManus/OpenManus-RL)
- [rllm](https://github.com/agentica-project/rllm)：[verl-pipeline](https://github.com/agentica-project/verl-pipeline) 实现异步 RL 训练！[GitHub Repo stars](https://img.shields.io/github/stars/agentica-project/rllm)
- [PRIME](https://github.com/PRIME-RL/PRIME)：隐式奖励流程强化！[GitHub Repo stars](https://img.shields.io/github/stars/PRIME-RL/PRIME)
- [RAGEN](https://github.com/ZihanWang314/ragen)：通用推理智能体训练框架！[GitHub Repo stars](https://img.shields.io/github/stars/ZihanWang314/ragen)
- [Search-R1](https://github.com/PeterGriffinJin/Search-R1)：推理与**搜索（工具调用）**交互型 LLM RL！[GitHub Repo stars](https://img.shields.io/github/stars/PeterGriffinJin/Search-R1)
- [DeepRetrieval](https://github.com/pat-jj/DeepRetrieval)：**搜索智能体** RL 训练！[GitHub Repo stars](https://img.shields.io/github/stars/pat-jj/DeepRetrieval)
- [ReSearch](https://github.com/Agent-RL/ReSearch)：LLM 搜索推理学习 RL！[GitHub Repo stars](https://img.shields.io/github/stars/Agent-RL/ReSearch)
- [Code-R1](https://github.com/ganler/code-r1)：可靠奖励代码 RL 复现！[GitHub Repo stars](https://img.shields.io/github/stars/ganler/code-r1)
- [Skywork-OR1](https://github.com/SkyworkAI/Skywork-OR1)：Skywork 开放推理系列！[GitHub Repo stars](https://img.shields.io/github/stars/SkyworkAI/Skywork-OR1)
- [ToRL](https://github.com/GAIR-NLP/ToRL)：工具集成 RL 扩展！[GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/ToRL)
- [verl-agent](https://github.com/langfengQ/verl-agent)：可扩展的长程 LLM/VLM 智能体 RL 训练框架，含新算法 **GiGPO**！[GitHub Repo stars](https://img.shields.io/github/stars/langfengQ/verl-agent)
- [PF-PPO](https://arxiv.org/abs/2409.06957)：基于奖励信号可靠性进行策略过滤的 PPO，高效鲁棒 RLHF。
- [GUI-R1](https://github.com/ritzz-ai/GUI-R1)：**GUI-R1**：面向 GUI Agent 的视觉-语言动作模型！[GitHub Repo stars](https://img.shields.io/github/stars/ritzz-ai/GUI-R1)
- [DeepResearcher](https://github.com/GAIR-NLP/DeepResearcher)：真实环境下深度科研 RL 扩展！[GitHub Repo stars](https://img.shields.io/github/stars/GAIR-NLP/DeepResearcher)
- [VAGEN](https://github.com/RAGEN-AI/VAGEN)：多轮 RL 训练 VLM 智能体！[GitHub Repo stars](https://img.shields.io/github/stars/RAGEN-AI/VAGEN)
- [ReTool](https://retool-rl.github.io/)：ReTool：大模型工具使用策略 RL，代码即将开源...
- [RM-R1](https://arxiv.org/abs/2505.02387)：推理奖励模型 RL 训练！[GitHub Repo stars](https://img.shields.io/github/stars/RM-R1-UIUC/RM-R1)
- [Absolute Zero Reasoner](https://arxiv.org/abs/2505.03335)：零人类标注数据自博弈推理框架！[GitHub Repo stars](https://img.shields.io/github/stars/LeapLabTHU/Absolute-Zero-Reasoner)
- [LUFFY](https://arxiv.org/pdf/2504.14945)：离策略引导下的推理学习！[GitHub Repo stars](https://img.shields.io/github/stars/ElliottYan/LUFFY)
- [verl-tool](https://github.com/TIGER-AI-Lab/verl-tool)：基于 verl 的统一可扩展工具智能体训练框架！[GitHub Repo stars](https://img.shields.io/github/stars/TIGER-AI-Lab/verl-tool)
- [DeepMath](https://github.com/zwhe99/DeepMath)：数学推理 DeepMath-103K 数据与系列模型！[GitHub Repo stars](https://img.shields.io/github/stars/zwhe99/DeepMath)

更多优秀项目见 [recipe](https://raw.githubusercontent.com/volcengine/verl/main/recipe/README.md)。

## 贡献指南

欢迎社区贡献！请查阅[项目路线图](https://github.com/volcengine/verl/issues/710)和[good first issue](https://github.com/volcengine/verl/issues?q=is%3Aissue%20state%3Aopen%20label%3A%22good%20first%20issue%22) 寻找你能贡献的领域。

### 代码风格与格式化

我们采用 pre-commit 工具提升代码质量。初始化方法：

```bash
pip install pre-commit
pre-commit install
```

如需本地修复 CI 错误，可手动执行：

```bash
pre-commit run
```

### 添加 CI 测试

如条件允许，请为新功能添加 CI 测试：

1. 找到最相关的 workflow yml 文件，通常对应一个 hydra 默认配置（如 `ppo_trainer`、`ppo_megatron_trainer`、`sft_trainer` 等）。
2. 如未包含，请将相关路径模式加入 paths 部分。
3. 测试脚本尽量减小工作量，可参考现有脚本。

## 关于 [字节跳动 Seed 团队](https://team.doubao.com/)

字节跳动 Seed 团队成立于 2023 年，致力于打造业界领先的 AI 基础模型，愿成为世界级研究团队，为科学与社会进步做出贡献。了解更多 Seed 团队渠道👇
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

我们正在招聘！如有兴趣参与智能体 RL 实习/全职岗位，请发 [邮件](mailto:haibin.lin@bytedance.com) 联系。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---