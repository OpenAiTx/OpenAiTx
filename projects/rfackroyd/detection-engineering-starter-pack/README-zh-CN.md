# 🛡️ 检测工程入门包

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **一份针对有志成为检测工程师的精选必备资源清单。**

本入门包的目标是提供一份精选资源，帮助你在检测工程领域起步而不至于感到不知所措。此列表基于个人对各种检测技术的经验。希望对你有帮助！🚀

---

### 💬 **加入 Discord**

[与他人交流，讨论所有威胁检测和安全工程相关话题。](https://discord.gg/HAVyDtUunu)

---

## 📖 目录 <!-- omit in toc -->

<!-- TOC -->

- [🔍 了解攻击者技术](#-了解攻击者技术)
- [📜 认识检测规则](#-认识检测规则)
- [🛠️ 自己动手尝试](#-自己动手尝试)
  - [🔒 终端检测](#-终端检测)
  - [🌐 网络检测](#-网络检测)
  - [📂 文件内容检测](#-文件内容检测)
  - [📊 SIEM（安全信息与事件管理）](#-siem安全信息与事件管理)
  - [⚙️ SOAR（安全编排自动化与响应）](#-soar安全编排自动化与响应)
  - [🎭 对手模拟](#-对手模拟)
- [📚 有用的概念](#-有用的概念)
- [🧪 实验室与培训](#-实验室与培训)
- [📖 进一步阅读与有趣项目](#-进一步阅读与有趣项目)
- [🌟 精彩列表](#-精彩列表)
<!-- /TOC -->

---

## 🔍 了解攻击者技术

> **了解攻击者如何实现他们的目标。**
- [MITRE ATT&CK](https://attack.mitre.org/) - 对手战术和技术的第一知识库。
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - 一个可自定义页面，用于显示最常见的ATT&CK技术。
- [Hacking the Cloud](https://hackingthe.cloud/) - 一系列用于理解云端攻击技术的资源。
- [The DFIR Report](https://thedfirreport.com/) - 用防御者视角分析和描述的真实事件报告。个人最爱。

---

## 📜 了解检测规则

> **展示检测如何构建和应用的示例仓库。**

- [Sigma](https://github.com/SigmaHQ/sigma) - 通用的检测签名格式。
- [Splunk Detection Rules](https://research.splunk.com/detections/) - Splunk的检测规则集合。
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - Elastic的检测规则集合。
- [Detection Studio](https://detection.studio/) - 将Sigma规则转换为其他检测规则语法。

---

## 🛠️ 自己动手试试

> **可玩的工具，均为开源或含免费层。**

#### 🔒 端点检测

- [Aurora](https://www.nextron-systems.com/aurora/) - 一个能运行Sigma规则的代理。加载你的Sigma规则，从事件日志创建警报。
- [Velociraptor](https://github.com/Velocidex/velociraptor) - 一个数字取证和事件响应工具，增强端点的可视化。
- [Falco](https://github.com/falcosecurity/falco) - 一个云原生运行时安全工具，用于检测容器内的威胁。
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - 一个简单的Windows系统监视器。
- [Osquery](https://www.osquery.io/) - 一个操作系统检测框架。

#### 🌐 网络检测

- [Suricata](https://suricata.io/) - 用于检测网络流量中可疑活动的检测规则。

#### 📂 文件内容检测

- [YARA](https://github.com/virustotal/yara) - 用于识别和分类恶意软件样本的检测规则。

#### 📊 SIEM (安全信息和事件管理)

- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - 一套用于搜索、日志记录和分析的工具集。  
- [Wazuh](https://wazuh.com/) - 一个开源的安全监控平台。  

#### ⚙️ SOAR（安全编排自动化与响应）  

- [Tines](https://www.tines.com/) - 一个面向安全团队的无代码自动化平台。非常适合快速自动化各种任务。提供免费套餐。  

#### 🎭 对手模拟  

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - 一套对手模拟计划库。  
- [MITRE Caldera](https://github.com/mitre/caldera) - 一个自动化的对手模拟平台。  
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - 一个用于云环境对手模拟的工具。  
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - 一套简单的对手模拟测试库。  
- [TTPForge](https://github.com/facebookincubator/TTPForge) - 一个用于创建和管理TTP（战术、技术和程序）的工具。  

---  

## 📚 有用的概念  

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - Elastic提出的一个结构化方法，帮助安全团队持续提升其流程和行为的成熟度。  
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - Palantir提供的一个简单框架，用于构建检测策略。  
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - 基于“痛苦金字塔”，该作品定义了实现强健检测的真正含义。  
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - 我最喜欢的文章之一——SpecterOps的《能力抽象》。探讨了与上述“攀登金字塔”项目类似的概念。  

---  

## 🧪 实验室与培训  

- [Blue Team Labs Online](https://blueteamlabs.online/) - 一个提供实战蓝队培训的平台。  
- [ACE Responder](https://www.aceresponder.com/) - 一个为现有网络防御者及新手设计的逼真沉浸式平台。  

---  

## 📖 延伸阅读及有趣项目  

> **我精心挑选的启发性材料。**  

- [Detections.ai](https://detections.ai/) - 一个由AI驱动并由社区推动的平台，用于分享和改进检测规则。使用邀请码 `StarterPack`。  
- [ACEResponder](https://x.com/ACEResponder) - 一个在X平台上分享攻击者技术的视觉账号。

- [Detect FYI](https://detect.fyi/) - 一个专注于检测工程的Medium出版物。
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - 一份关于检测工程的每周通讯。
- [EDR Telemetry](https://www.edr-telemetry.com/) - 一个对比流行EDR工具的资源。
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - ATT&CK，但用于人工智能。
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - Ryan McGeehan撰写的一篇关于如何优先考虑检测工程工作的优秀文章。
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - 谷歌如何在大规模上进行威胁检测。
- 著名安全厂商的防御者博客：
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 精彩资源列表

> **如果你渴望更多资源，请查看这些精彩列表。**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - Kubernetes威胁检测资源列表。
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - 精选威胁情报博客和出版物列表。
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - 精选检测工程资源列表。
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - 威胁检测资源合集。
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - 检测工程师资源列表。
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - 蓝队工具合集。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---