# 🛡️ 탐지 엔지니어링 스타터 팩

![Discord](https://img.shields.io/discord/1332993005359202345?logo=discord)

> **탐지 엔지니어를 희망하는 분들을 위한 필수 리소스 목록입니다.**

이 스타터 팩의 목표는 압도당하지 않고 탐지 엔지니어링을 시작하는 데 도움이 되는 엄선된 리소스를 제공하는 것입니다. 이 목록은 다양한 탐지 기술에 대한 개인적인 경험을 바탕으로 작성되었습니다. 도움이 되길 바랍니다! 🚀

---

### 💬 **디스코드 참여하기**

[위협 탐지 및 보안 엔지니어링에 대해 다른 사람들과 토론해 보세요.](https://discord.gg/HAVyDtUunu)

---

## 📖 목차 <!-- omit in toc -->

<!-- TOC -->

- [🔍 공격자 기술 이해하기](#-공격자-기술-이해하기)
- [📜 탐지 규칙 알아보기](#-탐지-규칙-알아보기)
- [🛠️ 직접 시도해 보기](#-직접-시도해-보기)
  - [🔒 엔드포인트 탐지](#-엔드포인트-탐지)
  - [🌐 네트워크 탐지](#-네트워크-탐지)
  - [📂 파일 콘텐츠 탐지](#-파일-콘텐츠-탐지)
  - [📊 SIEM (보안 정보 및 이벤트 관리)](#-siem-보안-정보-및-이벤트-관리)
  - [⚙️ SOAR (보안 오케스트레이션 자동화 및 대응)](#-soar-보안-오케스트레이션-자동화-및-대응)
  - [🎭 적대자 모방](#-적대자-모방)
- [📚 유용한 개념](#-유용한-개념)
- [🧪 실습 및 교육](#-실습-및-교육)
- [📖 추가 읽을거리 및 흥미로운 프로젝트](#-추가-읽을거리-및-흥미로운-프로젝트)
- [🌟 멋진 목록](#-멋진-목록)
<!-- /TOC -->

---

## 🔍 공격자 기술 이해하기

> **공격자가 목표를 달성하는 방식을 살펴보세요.**
- [MITRE ATT&CK](https://attack.mitre.org/) - 적대자의 전술과 기술에 대한 최고의 지식 기반입니다.
- [Top 10 ATT&CK Techniques](https://top-attack-techniques.mitre-engenuity.org/) - 가장 일반적인 ATT&CK 기술을 사용자 지정하여 표시할 수 있는 페이지입니다.
- [Hacking the Cloud](https://hackingthe.cloud/) - 클라우드 중심 공격 기술을 이해하기 위한 자료 모음입니다.
- [The DFIR Report](https://thedfirreport.com/) - 방어자의 관점에서 분석하고 설명한 실제 사건 사례입니다. 개인적으로 좋아하는 자료입니다.

---

## 📜 탐지 규칙 알아보기

> **탐지 규칙이 어떻게 구성되고 적용되는지 보여주는 예제 저장소들입니다.**

- [Sigma](https://github.com/SigmaHQ/sigma) - 일반적인 탐지 서명 형식입니다.
- [Splunk Detection Rules](https://research.splunk.com/detections/) - Splunk용 탐지 규칙 모음입니다.
- [Elastic Detection Rules](https://github.com/elastic/detection-rules/tree/main/rules) - Elastic용 탐지 규칙 모음입니다.
- [Detection Studio](https://detection.studio/) - Sigma 규칙을 다른 탐지 규칙 문법으로 변환합니다.

---

## 🛠️ 직접 사용해보기

> **오픈 소스이거나 무료 티어가 포함된 도구들입니다.**

#### 🔒 엔드포인트 탐지

- [Aurora](https://www.nextron-systems.com/aurora/) - Sigma 규칙을 실행할 수 있는 에이전트입니다. Sigma 규칙을 로드하고 이벤트 로그에서 알림을 생성할 수 있습니다.
- [Velociraptor](https://github.com/Velocidex/velociraptor) - 엔드포인트 가시성을 높여주는 디지털 포렌식 및 사고 대응 도구입니다.
- [Falco](https://github.com/falcosecurity/falco) - 컨테이너 내 위협을 탐지하는 클라우드 네이티브 런타임 보안 도구입니다.
- [Sysmon](https://learn.microsoft.com/en-us/sysinternals/downloads/sysmon) - 간단한 윈도우 시스템 모니터입니다.
- [Osquery](https://www.osquery.io/) - 운영 체제 계측 프레임워크입니다.

#### 🌐 네트워크 탐지

- [Suricata](https://suricata.io/) - 네트워크 트래픽에서 의심스러운 활동을 탐지하기 위한 규칙들입니다.

#### 📂 파일 내용 탐지

- [YARA](https://github.com/virustotal/yara) - 악성코드 샘플을 식별하고 분류하기 위한 탐지 규칙입니다.

#### 📊 SIEM (보안 정보 및 이벤트 관리)

- [Elastic Stack (ELK)](https://www.elastic.co/elastic-stack) - 검색, 로깅, 분석을 위한 도구 모음입니다.
- [Wazuh](https://wazuh.com/) - 오픈 소스 보안 모니터링 플랫폼입니다.

#### ⚙️ SOAR (보안 오케스트레이션 자동화 및 대응)

- [Tines](https://www.tines.com/) - 보안 팀을 위한 코드 없는 자동화 플랫폼입니다. 빠르게 무엇이든 자동화하기에 적합합니다. 무료 등급이 있습니다.

#### 🎭 적대자 에뮬레이션

- [Adversary Emulation Library](https://github.com/center-for-threat-informed-defense/adversary_emulation_library) - 적대자 에뮬레이션 계획 라이브러리입니다.
- [MITRE Caldera](https://github.com/mitre/caldera) - 자동화된 적대자 에뮬레이션 플랫폼입니다.
- [Stratus Red Team](https://github.com/DataDog/stratus-red-team) - 클라우드에서 적대자 에뮬레이션을 위한 도구입니다.
- [Atomic Red Team](https://github.com/redcanaryco/atomic-red-team) - 간단한 적대자 에뮬레이션 테스트 라이브러리입니다.
- [TTPForge](https://github.com/facebookincubator/TTPForge) - TTP(전술, 기술 및 절차)를 생성하고 관리하는 도구입니다.

---

## 📚 유용한 개념

- [Detection Engineering Behavior Maturity Model](https://www.elastic.co/security-labs/elastic-releases-debmm) - Elastic에서 제공하는 보안 팀이 프로세스와 행동을 일관되게 성숙시키기 위한 구조화된 접근법입니다.
- [Alerting Detection Strategy (ADS) Framework](https://github.com/palantir/alerting-detection-strategy-framework/blob/master/ADS-Framework.md) - Palantir에서 제공하는 탐지 전략을 구축하기 위한 간단한 프레임워크입니다.
- [Summiting the Pyramid](https://center-for-threat-informed-defense.github.io/summiting-the-pyramid/?utm_source=ctidio&utm_medium=shortlink) - '고통의 피라미드'를 기반으로 견고한 탐지가 무엇을 의미하는지 정의하는 작업입니다.
- [Capability Abstraction](https://posts.specterops.io/capability-abstraction-fbeaeeb26384) - 제가 좋아하는 글 중 하나인 SpecterOps의 'Capability Abstraction'입니다. 위의 'Summiting the Pyramid' 프로젝트와 유사한 개념을 탐구합니다.

---

## 🧪 실습 및 교육

- [Blue Team Labs Online](https://blueteamlabs.online/) - 실습 중심의 블루 팀 교육 플랫폼입니다.
- [ACE Responder](https://www.aceresponder.com/) - 기존 사이버 방어자와 신입 모두를 위한 현실적이고 몰입감 있는 플랫폼입니다.

---

## 📖 추가 읽기 및 흥미로운 프로젝트

> **저에게 영감을 준 엄선된 자료들입니다.**

- [Detections.ai](https://detections.ai/) - AI 기반의 커뮤니티 주도 탐지 규칙 공유 및 개선 플랫폼입니다. 초대 코드 `StarterPack`을 사용하세요.
- [ACEResponder](https://x.com/ACEResponder) - 공격자 기술을 시각적으로 공유하는 X 계정입니다.

- [Detect FYI](https://detect.fyi/) - 탐지 엔지니어링에만 집중하는 Medium 출판물입니다.
- [Detection Engineering Weekly](https://www.detectionengineering.net/) - 탐지 엔지니어링에 관한 주간 뉴스레터입니다.
- [EDR Telemetry](https://www.edr-telemetry.com/) - 인기 있는 EDR 도구들을 서로 비교하는 자료입니다.
- [MITRE ATLAS](https://atlas.mitre.org/matrices/ATLAS) - AI를 위한 ATT&CK입니다.
- [Prioritizing Detection Engineering](https://medium.com/starting-up-security/prioritizing-detection-engineering-b60b46d55051) - Ryan McGeehan이 쓴 탐지 엔지니어링 우선순위 설정에 관한 잘 작성된 글입니다.
- [How Google Does It](https://cloud.google.com/transform/how-google-does-it-modernizing-threat-detection) - 구글이 대규모로 위협 탐지를 수행하는 방법입니다.
- 방어자를 위한 주목할 만한 보안 벤더 블로그:
  - [SpecterOps Blog](https://posts.specterops.io/)
  - [Google Threat Analysis Group Blog](https://blog.google/threat-analysis-group/)
  - [CrowdStrike Counter Adversary Operations Blog](https://www.crowdstrike.com/en-us/blog/category.counter-adversary-operations/)
  - [Palo Alto Networks Unit 42 Blog](https://unit42.paloaltonetworks.com/unit-42-all-articles/)
  - [Recorded Future Blog](https://www.recordedfuture.com/blog)
  - [SEKOIA Threat Research Blog](https://blog.sekoia.io/category/threat-research/)
  - [Wiz Research Blog](https://www.wiz.io/blog/tag/research)

---

## 🌟 멋진 목록

> **더 많은 자료를 원한다면, 이 멋진 목록들을 확인해 보세요.**

- [Awesome Kubernetes Threat Detection](https://github.com/jatrost/awesome-kubernetes-threat-detection) - 쿠버네티스 위협 탐지 자료 목록입니다.
- [Awesome Threat Intel Blogs](https://github.com/signalscorps/awesome-threat-intel-blogs) - 위협 인텔리전스 블로그 및 출판물 큐레이션 목록입니다.
- [Awesome Detection Engineering](https://github.com/infosecB/awesome-detection-engineering) - 탐지 엔지니어링 자료 큐레이션 목록입니다.
- [Awesome Threat Detection](https://github.com/0x4D31/awesome-threat-detection) - 위협 탐지 자료 모음입니다.
- [Awesome Detection Engineer](https://github.com/st0pp3r/awesome-detection-engineer) - 탐지 엔지니어를 위한 자료 목록입니다.
- [Blue Team Tools](https://github.com/A-poc/BlueTeam-Tools) - 블루 팀원을 위한 도구 모음입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---