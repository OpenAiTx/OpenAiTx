# 🛡️ Pack de démarrage pour l'ingénierie de détection

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **Une liste d'opinions des ressources essentielles pour les ingénieurs en détection en herbe.**

Le but de ce pack de démarrage est de fournir une sélection organisée de ressources pour vous aider à débuter en ingénierie de détection sans vous sentir submergé. Cette liste est basée sur une expérience personnelle avec diverses technologies de détection. J'espère que cela vous sera utile ! 🚀

---

### 💬 **Rejoignez le Discord**

[Connectez-vous avec d'autres pour discuter de tout ce qui concerne la détection des menaces et l'ingénierie de la sécurité.](https://discord.gg/HAVyDtUunu)

---

## 📖 Contenu <!-- omit in toc -->

<!-- TOC -->

- [🔍 Comprendre les techniques des attaquants](#-comprendre-les-techniques-des-attaquants)
- [📜 Apprendre à connaître les règles de détection](#-apprendre-à-connaitre-les-règles-de-détection)
- [🛠️ Essayer par vous-même](#-essayer-par-vous-même)
  - [🔒 Détection Endpoint](#-détection-endpoint)
  - [🌐 Détection réseau](#-détection-réseau)
  - [📂 Détection du contenu des fichiers](#-détection-du-contenu-des-fichiers)
  - [📊 SIEM (Gestion des informations et des événements de sécurité)](#-siem-gestion-des-informations-et-des-événements-de-sécurité)
  - [⚙️ SOAR (Orchestration, automatisation et réponse en sécurité)](#-soar-orchestration-automatisation-et-réponse-en-sécurité)
  - [🎭 Émulation d'adversaire](#-émulation-dadversaire)
- [📚 Concepts utiles](#-concepts-utiles)
- [🧪 Laboratoires & formation](#-laboratoires--formation)
- [📖 Lectures complémentaires & projets intéressants](#-lectures-complémentaires--projets-intéressants)
- [🌟 Listes géniales](#-listes-géniales)
<!-- /TOC -->

---

## 🔍 Comprendre les techniques des attaquants

> **Voir comment les attaquants atteignent leurs objectifs.**
- [MITRE ATT&CK](https://attack.mitre.org/) - La base de connaissances n°1 des tactiques et techniques des adversaires.
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - Une page personnalisable pour afficher les techniques ATT&CK les plus courantes.
- [Hacking the Cloud](https://hackingthe.cloud/) - Une collection de ressources pour comprendre les techniques d’attaque ciblant le cloud.
- [The DFIR Report](https://thedfirreport.com/) - Incidents réels analysés et décrits avec une mentalité de défenseur. Un favori personnel.

---

## 📜 Faire Connaissance avec les Règles de Détection

> **Dépôts d’exemples montrant comment les détections sont structurées et appliquées.**

- [Sigma](https://github.com/SigmaHQ/sigma) - Le format générique de signature de détection.
- [Splunk Detection Rules](https://research.splunk.com/detections/) - Une collection de règles de détection pour Splunk.
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - Une collection de règles de détection pour Elastic.
- [Detection Studio](https://detection.studio/) - Convertir des règles Sigma en autres syntaxes de règles de détection.

---

## 🛠️ Essayer Par Vous-Même

> **Outils à manipuler qui sont soit open source, soit disposent d’un élément gratuit.**

#### 🔒 Détection Endpoint

- [Aurora](https://www.nextron-systems.com/aurora/) - Un agent capable d’exécuter des règles Sigma. Chargez vos règles Sigma et créez des alertes à partir de vos journaux d’événements.
- [Velociraptor](https://github.com/Velocidex/velociraptor) - Un outil d’investigation numérique et de réponse aux incidents qui améliore votre visibilité sur vos endpoints.
- [Falco](https://github.com/falcosecurity/falco) - Un outil de sécurité runtime natif cloud pour détecter les menaces dans les conteneurs.
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - Un simple moniteur système Windows.
- [Osquery](https://www.osquery.io/) - Un framework d’instrumentation du système d’exploitation.

#### 🌐 Détection Réseau

- [Suricata](https://suricata.io/) - Règles de détection conçues pour interroger le trafic réseau à la recherche d’activités suspectes.

#### 📂 Détection de Contenu de Fichiers

- [YARA](https://github.com/virustotal/yara) - Règles de détection pour identifier et classifier des échantillons de malwares.

#### 📊 SIEM (Gestion des Informations et Événements de Sécurité)


- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - Une suite d'outils pour la recherche, la journalisation et l'analyse.
- [Wazuh](https://wazuh.com/) - Une plateforme de surveillance de sécurité open-source.

#### ⚙️ SOAR (Orchestration, Automatisation et Réponse en Sécurité)

- [Tines](https://www.tines.com/) - Une plateforme d'automatisation sans code pour les équipes de sécurité. Idéale pour automatiser rapidement tout type de tâches. Dispose d'un niveau gratuit.

#### 🎭 Émulation d'Adversaire

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - Une bibliothèque de plans d'émulation d'adversaires.
- [MITRE Caldera](https://github.com/mitre/caldera) - Une plateforme automatisée d'émulation d'adversaires.
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - Un outil d'émulation d'adversaires dans le cloud.
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - Une bibliothèque de tests simples d'émulation d'adversaires.
- [TTPForge](https://github.com/facebookincubator/TTPForge) - Un outil pour créer et gérer des TTPs.

---

## 📚 Concepts Utiles

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - une approche structurée pour que les équipes de sécurité fassent évoluer de manière constante leurs processus et comportements, par Elastic.
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - Un cadre simple pour construire des stratégies de détection par Palantir.
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - S'appuyant sur la 'pyramide de la douleur', ce travail définit ce que signifie réellement disposer d'une détection robuste.
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - Un de mes articles préférés - 'Capability Abstraction' de SpecterOps. Explore des concepts similaires au projet 'summiting the pyramid' ci-dessus.

---

## 🧪 Laboratoires & Formations

- [Blue Team Labs Online](https://blueteamlabs.online/) - Une plateforme pour la formation pratique des équipes bleues.
- [ACE Responder](https://www.aceresponder.com/) - Une plateforme réaliste et immersive pour les cyberdéfenseurs expérimentés comme pour les débutants.

---

## 📖 Lectures Complémentaires & Projets Intéressants

> **Une sélection soigneusement choisie de ressources qui m'ont inspiré.**

- [Detections.ai](https://detections.ai/) - Une plateforme alimentée par l'IA et la communauté pour partager et améliorer les règles de détection. Utilisez le code d'invitation `StarterPack`.
- [ACEResponder](https://x.com/ACEResponder) - Un compte X partageant visuellement des techniques d'attaquants.
- [Detect FYI](https://detect.fyi/) - Une publication Medium dédiée uniquement à l'ingénierie de détection.
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - Une newsletter hebdomadaire sur l'ingénierie de détection.
- [EDR Telemetry](https://www.edr-telemetry.com/) - Une ressource qui compare les outils EDR populaires entre eux.
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - ATT&CK, mais pour l'IA.
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - Un article bien écrit de Ryan McGeehan sur la manière de penser la priorisation de vos efforts d'ingénierie de détection.
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - Comment Google réalise la détection des menaces à grande échelle.
- Blogs notables de fournisseurs de sécurité pour les défenseurs :
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 Listes Géniales

> **Si vous êtes avide de ressources supplémentaires, consultez ces listes géniales.**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - Une liste de ressources pour la détection des menaces Kubernetes.
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - Une liste sélectionnée de blogs et publications sur le renseignement sur les menaces.
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - Une liste sélectionnée de ressources en ingénierie de détection.
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - Une collection de ressources pour la détection des menaces.
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - Une liste de ressources pour les ingénieurs de détection.
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - Une collection d’outils pour les équipes bleues.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---