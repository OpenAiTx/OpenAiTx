# 🛡️ 検知エンジニアリング スターターパック

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **検知エンジニアを志す方向けの必須リソースに関する意見をまとめたリストです。**

このスターターパックの目的は、圧倒されることなく検知エンジニアリングを始めるための厳選されたリソースを提供することです。このリストは様々な検知技術の個人的な経験に基づいています。お役に立てれば幸いです！🚀

---

### 💬 **Discordに参加しよう**

[脅威検知やセキュリティエンジニアリングに関するあらゆる話題を他の人と話し合いましょう。](https://discord.gg/HAVyDtUunu)

---

## 📖 目次 <!-- omit in toc -->

<!-- TOC -->

- [🔍 攻撃者の手法を理解する](#-攻撃者の手法を理解する)
- [📜 検知ルールを知る](#-検知ルールを知る)
- [🛠️ 実際に試してみる](#-実際に試してみる)
  - [🔒 エンドポイント検知](#-エンドポイント検知)
  - [🌐 ネットワーク検知](#-ネットワーク検知)
  - [📂 ファイル内容検知](#-ファイル内容検知)
  - [📊 SIEM（セキュリティ情報およびイベント管理）](#-siemセキュリティ情報およびイベント管理)
  - [⚙️ SOAR（セキュリティオーケストレーション自動化および対応）](#-soarセキュリティオーケストレーション自動化および対応)
  - [🎭 敵対者エミュレーション](#-敵対者エミュレーション)
- [📚 役立つ概念](#-役立つ概念)
- [🧪 ラボ＆トレーニング](#-ラボ＆トレーニング)
- [📖 さらなる読書＆興味深いプロジェクト](#-さらなる読書＆興味深いプロジェクト)
- [🌟 オーサムリスト](#-オーサムリスト)
<!-- /TOC -->

---

## 🔍 攻撃者の手法を理解する

> **攻撃者がどのように目的を達成するかを見てみましょう。**
- [MITRE ATT&CK](https://attack.mitre.org/) - 敵対者の戦術と技術のナンバーワン知識ベース。
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - 最も一般的なATT&CK技術を表示するカスタマイズ可能なページ。
- [Hacking the Cloud](https://hackingthe.cloud/) - クラウドに焦点を当てた攻撃技術を理解するためのリソース集。
- [The DFIR Report](https://thedfirreport.com/) - 守備側の視点で分析・記述された実際のインシデント。個人的なお気に入り。

---

## 📜 検出ルールを知る

> **検出がどのように構成され適用されるかを示すリポジトリの例。**

- [Sigma](https://github.com/SigmaHQ/sigma) - 汎用の検出シグネチャ形式。
- [Splunk Detection Rules](https://research.splunk.com/detections/) - Splunk用の検出ルール集。
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - Elastic用の検出ルール集。
- [Detection Studio](https://detection.studio/) - Sigmaルールを他の検出ルール構文に変換。

---

## 🛠️ 自分で試す

> **オープンソースまたは無料プランがあるツール。**

#### 🔒 エンドポイント検出

- [Aurora](https://www.nextron-systems.com/aurora/) - Sigmaルールを実行可能なエージェント。Sigmaルールを読み込み、イベントログからアラートを作成。
- [Velociraptor](https://github.com/Velocidex/velociraptor) - エンドポイントの可視性を高めるデジタルフォレンジックおよびインシデント対応ツール。
- [Falco](https://github.com/falcosecurity/falco) - コンテナ内の脅威を検出するクラウドネイティブなランタイムセキュリティツール。
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - シンプルなWindowsシステムモニター。
- [Osquery](https://www.osquery.io/) - オペレーティングシステムの計測フレームワーク。

#### 🌐 ネットワーク検出

- [Suricata](https://suricata.io/) - ネットワークトラフィックを調査し疑わしい活動を検出するための検出ルール。

#### 📂 ファイル内容検出

- [YARA](https://github.com/virustotal/yara) - マルウェアサンプルの識別・分類のための検出ルール。

#### 📊 SIEM (セキュリティ情報およびイベント管理)

- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - 検索、ログ記録、分析のためのツールスイート。
- [Wazuh](https://wazuh.com/) - オープンソースのセキュリティ監視プラットフォーム。

#### ⚙️ SOAR（セキュリティオーケストレーション自動化と対応）

- [Tines](https://www.tines.com/) - セキュリティチーム向けのノーコード自動化プラットフォーム。迅速な自動化に最適。無料プランあり。

#### 🎭 敵対者エミュレーション

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - 敵対者エミュレーションプランのライブラリ。
- [MITRE Caldera](https://github.com/mitre/caldera) - 自動敵対者エミュレーションプラットフォーム。
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - クラウドでの敵対者エミュレーションツール。
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - シンプルな敵対者エミュレーションテストのライブラリ。
- [TTPForge](https://github.com/facebookincubator/TTPForge) - TTPの作成と管理のためのツール。

---

## 📚 有用な概念

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - Elasticによる、セキュリティチームがプロセスと行動を一貫して成熟させるための構造化されたアプローチ。
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - Palantirによる検出戦略構築のためのシンプルなフレームワーク。
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - 「苦痛のピラミッド」を基に、堅牢な検出の真意を定義した研究。
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - 私のお気に入りの記事の一つ、SpecterOpsによる「Capability Abstraction」。上記「Summiting the Pyramid」と似た概念を探求。

---

## 🧪 ラボ＆トレーニング

- [Blue Team Labs Online](https://blueteamlabs.online/) - 実践的なブルーチームトレーニングのプラットフォーム。
- [ACE Responder](https://www.aceresponder.com/) - 既存のサイバー防御者や初心者向けのリアルで没入型のプラットフォーム。

---

## 📖 さらなる読書＆興味深いプロジェクト

> **私にインスピレーションを与えた厳選資料。**

- [Detections.ai](https://detections.ai/) - AI駆動かつコミュニティ主導の検出ルール共有・改善プラットフォーム。招待コード「StarterPack」を使用。
- [ACEResponder](https://x.com/ACEResponder) - 攻撃者の手法を視覚的に共有するXアカウント。

- [Detect FYI](https://detect.fyi/) - 検出エンジニアリングに特化したMediumの出版物。
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - 検出エンジニアリングに関する週刊ニュースレター。
- [EDR Telemetry](https://www.edr-telemetry.com/) - 人気のEDRツールを比較するリソース。
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - AI向けのATT&CK。
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - Ryan McGeehanによる検出エンジニアリングの優先順位付けに関する良質な記事。
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - Googleが大規模に脅威検出を行う方法。
- 防御者向けの注目すべきセキュリティベンダーブログ：
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 Awesome Lists

> **もっと多くのリソースを求めているなら、これらのAwesomeリストをチェックしてください。**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - Kubernetesの脅威検出リソースのリスト。
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - 脅威インテリジェンスのブログと出版物のキュレーションリスト。
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - 検出エンジニアリングリソースのキュレーションリスト。
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - 脅威検出リソースのコレクション。
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - 検出エンジニア向けリソースのリスト。
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - ブルーチーム向けツールのコレクション。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---