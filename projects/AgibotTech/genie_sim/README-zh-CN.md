![image.png](https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/image.jpg)
<div align="center">
  <a href="https://github.com/AgibotTech/genie_sim">
    <img src="https://img.shields.io/badge/GitHub-grey?logo=GitHub" alt="GitHub">
  </a>
  <a href="https://huggingface.co/datasets/agibot-world/GenieSimAssets">
    <img src="https://img.shields.io/badge/HuggingFace-yellow?logo=HuggingFace" alt="HuggingFace">
  </a>
  <a href="https://agibot-world.com/sim-evaluation">
    <img src="https://img.shields.io/badge/Genie%20Sim%20Benchmark-blue?style=plastic" alt="Genie Sim Benchmark">
  </a>
  <a href="https://genie.agibot.com/en/geniestudio">
    <img src="https://img.shields.io/badge/Genie_Studio-green?style=flat" alt="Genie Studio">
  </a>
</div>

# 1. Genie Sim 基准测试
Genie Sim 是来自 AgiBot 的仿真框架，为开发者提供高效的数据生成能力和评测基准，以加速具身智能的发展。Genie Sim 建立了完善的闭环流程，包括轨迹生成、模型训练、基准测试和部署验证。用户可以通过这一高效的仿真工具链快速验证算法性能并优化模型。无论是简单的抓取任务还是复杂的长距离操作，Genie Sim 都能提供高度真实的仿真环境和精确的评测指标，帮助开发者高效地完成机器人技术的开发与迭代。

Genie Sim Benchmark 作为 Genie Sim 的开源评测版本，致力于为具身人工智能模型提供精准的性能测试与优化支持。

# 2. 功能特性
- 灵活且易用的仿真配置与接口
- 针对10+操作任务的仿真基准与评测任务
- 基于VR与键盘的远程操作能力
- 所有关节与末端执行器位姿的记录与回放
- 550+高保真、物理精确的3D仿真环境与资源
- 标准化评测指标，量化具身AI模型性能
- 在GO-1模型上评测，仿真到真实误差小于5%
- 支持在仿真评测中使用UniVLA基线模型

# 3. 更新记录
- [2025/6/25] v2.1
  - 为 Agibot World Challenge 2025 新增10项操作任务及其所有仿真资源
  - 在 Huggingface 上开源10项操作任务的合成数据集
  https://huggingface.co/datasets/agibot-world/AgiBotWorldChallenge-2025/tree/main/Manipulation-SimData
  - 集成 UniVLA 策略并支持模型推理仿真评测
  - 更新IK求解SDK，支持多机器人跨形态IK求解
  - 优化通信框架，仿真运行速度提升2倍
  - 更新自动评测框架，支持更复杂的长距离任务

# 4. 内容目录

## 4.1 简介
Genie Sim 的具身智能仿真基准旨在评估和推动具身AI模型的发展。这些基准提供真实的环境、多样化的任务及标准化指标，用于衡量机器人AI系统的性能，从而降低对昂贵的物理硬件和现实测试的需求，避免高风险和危险的测试场景，加速AI智能体的训练与评估过程。

## 4.2 快速开始
请参考[此页面](https://agibot-world.com/sim-evaluation/docs/#/v2)获取安装、用户指南及API参考

## 4.3 支持
<img src="https://raw.githubusercontent.com/AgibotTech/genie_sim/main/./docs/wechat.JPEG" width="30%"/>

## 4.4 TODO 列表
- [x] 发布更多长时序基准操作任务
- [x] 为每个基准任务增加更多场景与资源
- [x] 支持 Agibot World Challenge 基线模型
- [ ] 场景布局与操作轨迹泛化工具包

## 4.5 常见问题
- 当出现错误导致 isaac sim 服务器进程无响应时，如何关闭？
  在终端使用 `pkill -9 -f raise_standalone_sim` 杀掉进程
- 如何选择不同的渲染模式？
  默认渲染模式为 `RaytracedLighting(RealTime)`。对于包含透明物体的任务，请使用 `RealTimePathTracing(RealTime-2.0)` 以获得更准确的物体透视关系

## 4.6 许可与引用
本仓库所有数据和代码均遵循 Mozilla Public License 2.0
如本项目对您的研究有帮助，请按如下方式引用我们的工作。
```
@misc{2025geniesim,
  title={GenieSim},
  author={GenieSim Team},
  year={2025},
  url={https://github.com/AgibotTech/genie_sim}
}
```

## 4.7 参考文献
1. PDDL Parser (2020). Version 1.1. [源代码]. https://github.com/pucrs-automated-planning/pddl-parser.
2. BDDL. Version 1.x.x [源代码]. https://github.com/StanfordVL/bddl
3. CUROBO [源代码]. https://github.com/NVlabs/curobo
4. Isaac Lab [源代码]. https://github.com/isaac-sim/IsaacLab
5. Omni Gibson [源代码]. https://github.com/StanfordVL/OmniGibson

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---