_本清单是一个实用且有见地的指南，用于理智地检查计算机科学论文的写作质量、结构和呈现——特别是针对会议（和期刊）投稿。虽然有些条目带有主观性，但目标是提供具体提醒并突出常见陷阱。它是一个动态文档，将根据反馈持续更新。_

---

## 1. 🎯 标题和摘要

- [ ] 1.1 标题不超过15个单词。检查泛泛而谈的措辞（例如，“一种新框架...”传达的信息较少）和过于狭窄的聚焦（可能会减少论文受众）——目标是简洁而信息丰富。
- [ ] 1.2 标题清楚反映**问题**和**解决方案**，并包含至少一个技术关键词（例如，jailbreak，OOD检测，图学习）。
- [ ] 1.3 标题避免使用罕见或模糊的缩写。像LLM、AI和ML在计算机科学领域是可接受的，但避免使用如AD（可能指广告或异常检测）等缩写。
- [ ] 1.4 摘要包括至少四个关键组成部分：(1) 问题/任务定义，(2) 提出的方法或思路，(3) 主要结果，(4) 更广泛的影响或意义（某些部分可以合并）。
- [ ] 1.5 摘要避免未定义的缩写和含糊的描述词（例如，“重要的”，“新颖的”，“最先进的”无上下文说明）。
- [ ] 1.6 加分项：摘要包含至少一个具体的、量化的结果或见解，使工作突出。例如，“我们的方法在jailbreak检测测试时实现了11.2倍的加速。”

---

## 2. 📚 引言

- [ ] 2.1 主要问题或任务在前两段内被清楚定义。
- [ ] 2.2 动机包括（a）真实世界的用例，或（b）对前人工作的引用——理想情况下两者兼备。
- [ ] 2.3 引言以对提出方法及其名称的简要概述结束。
- [ ] 2.4 贡献明确列出（例如，“（1）首次提出了...框架，（2）提供了新的数据集...，（3）在...上进行了广泛评估”）。
- [ ] 2.5 每项贡献具体且可验证——避免模糊声明如“我们提供了见解”或“我们提升了理解”。
- [ ] 2.6 加分项：第一页包含引人注目的图示——如与前人工作的对比、性能亮点或核心思想的视觉解释。

---

## 3. 🔍 相关工作

- [ ] 3.1 所有引用工作都与您的方法、基线或任务相关。
- [ ] 3.2 至少提及一篇该主题中引用次数排名前三的最新论文中的基线。
- [ ] 3.3 相关工作部分长度不超过1.5页（除非是综述类论文）。
- [ ] 3.4 可使用LLM搜索相关工作，但必须反复核查每篇论文——不要盲目信任LLM！！！
- [ ] 3.5 加分项：利用相关工作部分介绍基线算法——展示表格，证明您的方案优于现有方法。

---

## 4. 🧪 方法

- [ ] 4.1 所有符号在使用前定义。
- [ ] 4.2 每个方程都有内联解释引用（例如，“式(3)定义了...的损失”）。如果某方程未被引用，考虑将其放入内联以节省空间。
- [ ] 4.3 方法的所有模块或组件均通过文本或图示说明。
- [ ] 4.4 每个小节最好与概览图的部分对应。进入小节前添加简短的总结段落。
- [ ] 4.5 不必在正文中同时包含概览图和伪代码——将伪代码移至附录。
- [ ] 4.6 方法可在不参考附录或外部代码的情况下复现——评审者应能从正文完全理解。
- [ ] 4.7 加分项：是否能删减本节内容而不降低清晰度？大胆删减：更多数学≠更好论文。

---

## 5. 📊 实验

- [ ] 5.1 使用至少3个数据集（除非论文介绍新数据集）。
- [ ] 5.2 比较至少3种基线方法。它们是最先进的吗？说明选择这些基线的理由。
- [ ] 5.3 包含至少1项消融实验。
- [ ] 5.4 适当时报告标准差或置信区间。
- [ ] 5.5 描述硬件环境、软件库和超参数设置。
- [ ] 5.6 解释负面结果（如有），不忽略——失败案例也有价值。
- [ ] 5.7 明确定义并说明评估指标。
- [ ] 5.8 所有图表均在正文中被引用。
- [ ] 5.9 除了展示数据和宣称“表现良好”，至少提供一项更深入的见解或分析（例如，为什么有效，哪里失败）。
- [ ] 5.10 加分项：考虑他人复现的难易程度？如果有“作弊技巧”，请删除。

---

## 6. 🧾 写作质量与风格

- [ ] 6.1 所有缩写首次出现时定义（即使是ML、LLM等）——避免反复定义。
- [ ] 6.2 句子长度不超过25个单词且无逗号或句号的情况。
- [ ] 6.3 每段不超过10行。
- [ ] 6.4 被动语态使用率低于总句数的30%。
- [ ] 6.5 加分项：注意论文是否充斥华丽的LLM词汇，如encompass、intricate等？

---

## 7. 🖼️ 图表

- [ ] 7.1 每个图表配有不少于两行的标题，包含解释或背景。不要仅放置无说明——评审会迷失。
- [ ] 7.2 图中字体大小不小于8pt，所有标签完整可见（无裁剪）。
- [ ] 7.3 绘图颜色在黑白打印时仍可区分——部分评审会打印论文。
- [ ] 7.4 结果中提及的每种方法均出现在图例或表头。
- [ ] 7.5 图表尽量置于页面顶部，而非正文中间或底部（软性规定，提升可读性）。
- [ ] 7.6 图表无冗余——各自提供新的或互补信息。
- [ ] 加分项：所有图表均为**无损格式**（如矢量图的PDF）。绝不允许低分辨率图片。


















---

## 8. 🧱 结构与格式

- [ ] 8.1 所有 LaTeX 警告和错误框均已解决。
- [ ] 8.2 章节标题遵循标准论文结构（例如，引言、方法、实验等）。
- [ ] 8.3 所有附录章节在正文中均有明确引用（例如，“附录 B.2 显示……”）。
- [ ] 8.4 论文中无**孤行**——避免单行章节标题或短行出现在栏的顶部/底部。
- [ ] 8.5 不允许连续放置两个图表，中间必须有解释性文字。




---

## 9. 📎 参考文献

- [ ] 9.1 所有参考文献均符合目标刊物的格式要求。
- [ ] 9.2 所使用的所有数据集、工具包和模型均已被引用。
- [ ] 9.3 至少引用了一篇目标刊物（会议/期刊）的论文。
- [ ] 9.4 自引比例 ≤ 20%。
- [ ] 9.5 BibTeX 文件已去重并检查拼写。




---

## 10. 🛑 引用合理性检查（大型语言模型生成风险）

- [ ] 10.1 所有引用均已**人工核实存在**——标题、作者、刊物和年份与真实发表论文匹配。
- [ ] 10.2 不包含来自大型语言模型工具的虚构引用。
- [ ] 10.3 若引用由 ChatGPT、Copilot 等生成，已在**Google Scholar**、**Semantic Scholar**或出版商网站交叉核对。




---

## 11. 🧠 提交前的合理性检查

- [ ] 11.1 PDF 在 Overleaf/TeX 中编译无错误或错误框。
- [ ] 11.2 文件名符合提交指南格式（例如，匿名时无下划线或作者名）。
- [ ] 11.3 元数据、补充文件或文件名中无作者身份信息。检查代码仓库和图片。
- [ ] 11.4 论文长度符合页数限制，包括参考文献和附录（如计入）。
- [ ] 11.5 论文已由非作者名单中的人通读，无需停顿求解。
- [ ] 11.6 所有合著者均已列出并适当致谢——这点常被忽视。
- [ ] 11.7 额外提示：提交后，从不同设备和操作系统（如 Mac、Windows）登录，验证上传版本渲染正确。


---

_此清单为 [`cs-paper-checklist`](https://github.com/yzhao062/cs-paper-checklist) 项目的一部分。欢迎通过 PR 贡献。_

---






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---