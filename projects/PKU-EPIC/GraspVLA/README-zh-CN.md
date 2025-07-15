# GraspVLA：一个基于十亿规模合成动作数据预训练的抓取基础模型
[![arXiv](https://img.shields.io/badge/arXiv-2505.03233-df2a2a.svg)](https://arxiv.org/pdf/2505.03233)
[![Static Badge](https://img.shields.io/badge/Project-Page-a)](https://pku-epic.github.io/GraspVLA-web/)

<!-- [邓胜良](https://shengliangd.github.io/about/), [闫密](https://miyandoris.github.io/), [魏松林](https://songlin.github.io/), 马海鑫, 杨宇鑫, [陈佳怡](https://jychen18.github.io/), 张志奇, 杨涛宇, 张旭恒, [崔鹤鸣](https://i.cs.hku.hk/~heming/), [张志正](https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=en), [王鹤](https://hughw19.github.io/) -->

我们提出了一种仅使用合成数据的成本效益高的VLA模型预训练范式，实现了直接的仿真到现实迁移和机器人抓取的强零样本泛化能力。主要贡献包括：

- **SynGrasp-1B**：一个十亿帧的合成抓取数据集，涵盖240个物体类别和超过10,000个物体。

- **GraspVLA**：基于SynGrasp-1B预训练的VLA模型，实现了无需微调即可对现实抓取任务的零样本泛化。

- **统一的CoT框架**：GraspVLA将自回归感知和基于流匹配的动作生成整合到单一推理流程中，实现对合成动作数据和互联网规模语义数据的联合训练，支持开放词汇抓取。

![teaser](https://raw.githubusercontent.com/PKU-EPIC/GraspVLA/main/./figs/teaser.jpg)

待办事项：
- [ ] 发布补充材料
- [ ] 发布模型权重
- [ ] 发布SynGrasp-1B数据集

[![License](https://licensebuttons.net/l/by-nc/4.0/88x31.png)](LICENSE)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---