# 🛡️ Detection Engineering Starter Pack

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **An opinionated list of essential resources for aspiring Detection Engineers.**

The goal of this starter pack is to provide a curated selection of resources to help you get started in detection engineering without feeling overwhelmed. This list is based on personal experience with various detection technologies. Hope it helps! 🚀

---

### 💬 **Join the Discord**

[Connect with others to discuss all things threat detection and security engineering.](https://discord.gg/HAVyDtUunu)

---

## 📖 Contents <!-- omit in toc -->

<!-- TOC -->

- [🔍 Understanding Attacker Techniques](#-understanding-attacker-techniques)
- [📜 Getting to Know Detection Rules](#-getting-to-know-detection-rules)
- [🛠️ Trying It Out Yourself](#-trying-it-out-yourself)
  - [🔒 Endpoint Detection](#-endpoint-detection)
  - [🌐 Network Detection](#-network-detection)
  - [📂 File Content Detection](#-file-content-detection)
  - [📊 SIEM (Security Information and Event Management)](#-siem-security-information-and-event-management)
  - [⚙️ SOAR (Security Orchestration Automation and Response)](#-soar-security-orchestration-automation-and-response)
  - [🎭 Adversary Emulation](#-adversary-emulation)
- [📚 Useful Concepts](#-useful-concepts)
- [🧪 Labs & Training](#-labs--training)
- [📖 Further Reading & Interesting Projects](#-further-reading--interesting-projects)
- [🌟 Awesome Lists](#-awesome-lists)
<!-- /TOC -->

---

## 🔍 Understanding Attacker Techniques

> **See how attackers achieve their goals.**

- [MITRE ATT&CK](https://attack.mitre.org/) - The #1 knowledge base of adversary tactics and techniques.
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - A customisable page to display the most common ATT&CK techniques.
- [Hacking the Cloud](https://hackingthe.cloud/) - A collection of resources for understanding cloud-focused attack techniques.
- [The DFIR Report](https://thedfirreport.com/) - Real-world incidents analysed and described with a defender's mindset. A personal favourite.

---

## 📜 Getting to Know Detection Rules

> **Example repositories showcasing how detections are structured and applied.**

- [Sigma](https://github.com/SigmaHQ/sigma) - The generic detection signature format.
- [Splunk Detection Rules](https://research.splunk.com/detections/) - A collection of detection rules for Splunk.
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - A collection of detection rules for Elastic.
- [Detection Studio](https://detection.studio/) - Convert Sigma rules to other detection rule syntaxes.

---

## 🛠️ Trying It Out Yourself

> **Tools to play with that are either open source or have a free-tier element.**

#### 🔒 Endpoint Detection

- [Aurora](https://www.nextron-systems.com/aurora/) - An agent that can run Sigma rules. Load up your Sigma rules, and create alerts from your event logs.
- [Velociraptor](https://github.com/Velocidex/velociraptor) - A digital forensic and incident response tool that enhances your visibility into your endpoints.
- [Falco](https://github.com/falcosecurity/falco) - A cloud-native runtime security tool to detect threats within containers.
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - A simple Windows system monitor.
- [Osquery](https://www.osquery.io/) - An operating system instrumentation framework.

#### 🌐 Network Detection

- [Suricata](https://suricata.io/) - Detection rules designed to interrogate network traffic for suspicious activity.

#### 📂 File Content Detection

- [YARA](https://github.com/virustotal/yara) - Detection rules for identifying and classifying malware samples.

#### 📊 SIEM (Security Information and Event Management)

- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - A suite of tools for search, logging, and analytics.
- [Wazuh](https://wazuh.com/) - An open-source security monitoring platform.

#### ⚙️ SOAR (Security Orchestration Automation and Response)

- [Tines](https://www.tines.com/) - A no-code automation platform for security teams. Great for automating anything, quickly. Has a free tier.

#### 🎭 Adversary Emulation

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - A library of adversary emulation plans.
- [MITRE Caldera](https://github.com/mitre/caldera) - An automated adversary emulation platform.
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - A tool for adversary emulation in the cloud.
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - A library of simple adversary emulation tests.
- [TTPForge](https://github.com/facebookincubator/TTPForge) - A tool for creating and managing TTPs.

---

## 📚 Useful Concepts

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - a structured approach for security teams to consistently mature their processes and behaviors from Elastic.
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - A simple framework for building detection strategies from Palantir.
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - Building on the 'pyramid of pain', this work defines what it really means to have a robust detection.
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - One of my favourite articles - 'Capability Abstraction' from SpecterOps. Explores similar concepts to the above 'summiting the pyramid' project.

---

## 🧪 Labs & Training

- [Blue Team Labs Online](https://blueteamlabs.online/) - A platform for hands-on blue team training.
- [ACE Responder](https://www.aceresponder.com/) - A realistic and immersive platform for existing cyber defenders and newcomers alike.

---

## 📖 Further Reading & Interesting Projects

> **A handpicked selection of materials that have inspired me.**

- [Detections.ai](https://detections.ai/) - An AI-powered and community-driven platform to share & improve detection rules. Use invite code `StarterPack`.
- [ACEResponder](https://x.com/ACEResponder) - An X account sharing attacker techniques visually.
- [Detect FYI](https://detect.fyi/) - A Medium publication focused solely on detection engineering.
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - A weekly newsletter on Detection Engineering.
- [EDR Telemetry](https://www.edr-telemetry.com/) - A resource that compares popular EDR tools with one another.
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - ATT&CK, but for AI.
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - A well-written piece from Ryan McGeehan on how to think about prioritising your detection engineering efforts.
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - How Google does threat detection at massive scale.
- Notable security vendor blogs for defenders:
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 Awesome Lists

> **If you are hungry for more resources, check out these awesome lists.**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - A list of Kubernetes threat detection resources.
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - A curated list of threat intelligence blogs and publications.
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - A curated list of detection engineering resources.
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - A collection of threat detection resources.
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - A list of resources for detection engineers.
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - A collection of tools for blue teamers.
