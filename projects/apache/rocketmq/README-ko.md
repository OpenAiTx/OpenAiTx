## Apache RocketMQ

[![Build Status][maven-build-image]][maven-build-url]
[![CodeCov][codecov-image]][codecov-url]
[![Maven Central][maven-central-image]][maven-central-url]
[![Release][release-image]][release-url]
[![License][license-image]][license-url]
[![Average Time to Resolve An Issue][percentage-of-issues-still-open-image]][percentage-of-issues-still-open-url]
[![Percentage of Issues Still Open][average-time-to-resolve-an-issue-image]][average-time-to-resolve-an-issue-url]
[![Twitter Follow][twitter-follow-image]][twitter-follow-url]

**[Apache RocketMQ](https://rocketmq.apache.org)은 낮은 지연 시간, 높은 성능과 신뢰성, 조 단위 용량 및 유연한 확장성을 갖춘 분산 메시징 및 스트리밍 플랫폼입니다.**


다양한 기능을 제공합니다:

* 발행/구독, 요청/응답 및 스트리밍을 포함한 메시징 패턴
* 금융 등급의 트랜잭션 메시지
* [DLedger Controller](https://raw.githubusercontent.com/apache/rocketmq/develop/docs/en/controller/quick_start.md)를 기반으로 하는 내장 장애 허용 및 고가용성 구성 옵션
* 내장된 메시지 추적 기능, opentracing도 지원
* 다목적 빅데이터 및 스트리밍 생태계 통합
* 시간 또는 오프셋에 의한 메시지 소급성
* 동일 큐 내에서 신뢰성 있는 FIFO 및 엄격한 순서 메시징
* 효율적인 풀 및 푸시 소비 모델
* 단일 큐에서 백만 단위 메시지 축적 용량
* gRPC, MQTT, JMS 및 OpenMessaging과 같은 다양한 메시징 프로토콜
* 유연한 분산 스케일아웃 배포 아키텍처
* 초고속 배치 메시지 교환 시스템
* SQL 및 태그와 같은 다양한 메시지 필터 메커니즘
* 격리 테스트 및 클라우드 격리 클러스터를 위한 도커 이미지
* 구성, 메트릭 및 모니터링을 위한 기능이 풍부한 관리 대시보드
* 인증 및 권한 부여
* 소스 및 싱크 모두를 위한 무료 오픈 소스 커넥터
* 경량 실시간 컴퓨팅
----------


## 빠른 시작

이 문단에서는 RocketMQ를 다양한 방법으로 설치하는 단계를 안내합니다.
로컬 개발 및 테스트를 위해 각 컴포넌트에 대해 하나의 인스턴스만 생성됩니다.

### RocketMQ를 로컬에서 실행하기

RocketMQ는 모든 주요 운영 체제에서 실행되며 Java JDK 버전 8 이상만 설치되어 있으면 됩니다.
확인을 위해 `java -version`을 실행하세요:
```shell
$ java -version
java version "1.8.0_121"
```
Windows 사용자는 [여기](https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip)를 클릭하여 5.3.3 RocketMQ 바이너리 릴리스를 다운로드하고,
로컬 디스크, 예를 들어 `D:\rocketmq`에 압축을 풉니다.
macOS 및 Linux 사용자는 다음 명령을 실행합니다:


```shell
# Download release from the Apache mirror
$ wget https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip

# Unpack the release
$ unzip rocketmq-all-5.3.3-bin-release.zip
```
터미널을 준비하고 추출된 `bin` 디렉토리로 이동합니다:

```shell
$ cd rocketmq-all-5.3.3-bin-release/bin
```

**1) 네임서버 시작하기**

네임서버는 `0.0.0.0:9876`에서 대기하게 됩니다. 로컬 머신에서 해당 포트가 다른 프로그램에 의해 사용 중이지 않은지 확인한 후, 다음과 같이 진행하세요.

macOS 및 Linux 사용자:
```shell
### start Name Server
$ nohup sh mqnamesrv &

### check whether Name Server is successfully started
$ tail -f ~/logs/rocketmqlogs/namesrv.log
The Name Server boot success...
```
Windows 사용자의 경우 먼저 환경 변수를 설정해야 합니다:
- 바탕화면에서 컴퓨터 아이콘을 마우스 오른쪽 버튼으로 클릭합니다.
- 컨텍스트 메뉴에서 속성을 선택합니다.
- 고급 시스템 설정 링크를 클릭합니다.
- 환경 변수 버튼을 클릭합니다.
- 환경 변수에 `ROCKETMQ_HOME="D:\rocketmq"`를 추가합니다.

그런 다음 rocketmq 디렉터리로 이동하여 입력하고 실행합니다:

```shell
$ mqnamesrv.cmd
The Name Server boot success...
```

**2) 브로커 시작하기**

macOS 및 Linux 사용자용:
```shell
### start Broker
$ nohup sh bin/mqbroker -n localhost:9876 &

### check whether Broker is successfully started, eg: Broker's IP is 192.168.1.2, Broker's name is broker-a
$ tail -f ~/logs/rocketmqlogs/broker.log
The broker[broker-a, 192.169.1.2:10911] boot success...
```

Windows 사용자용:
```shell
$ mqbroker.cmd -n localhost:9876
The broker[broker-a, 192.169.1.2:10911] boot success...
```

### Docker에서 RocketMQ 실행하기

Docker 컨테이너 내에서 자신의 컴퓨터에서 RocketMQ를 실행할 수 있으며,  
컨테이너 내에서 리스닝 포트를 노출하기 위해 `host` 네트워크가 사용됩니다.

**1) NameServer 시작하기**

```shell
$ docker run -it --net=host apache/rocketmq ./mqnamesrv
```

**2) 브로커 시작하기**

```shell
$ docker run -it --net=host --mount type=bind,source=/tmp/store,target=/home/rocketmq/store apache/rocketmq ./mqbroker -n localhost:9876
```

### Kubernetes에서 RocketMQ 실행하기

[RocketMQ Operator](https://github.com/apache/rocketmq-operator)를 사용하여 Kubernetes 클러스터 내에서 RocketMQ 클러스터를 실행할 수도 있습니다.
작업을 시작하기 전에 `kubectl`과 관련 kubeconfig 파일이 기기에 설치되어 있는지 확인하세요.

**1) CRD 설치하기**
```shell
### install CRDs
$ git clone https://github.com/apache/rocketmq-operator
$ cd rocketmq-operator && make deploy

### check whether CRDs is successfully installed
$ kubectl get crd | grep rocketmq.apache.org
brokers.rocketmq.apache.org                 2022-05-12T09:23:18Z
consoles.rocketmq.apache.org                2022-05-12T09:23:19Z
nameservices.rocketmq.apache.org            2022-05-12T09:23:18Z
topictransfers.rocketmq.apache.org          2022-05-12T09:23:19Z

### check whether operator is running
$ kubectl get pods | grep rocketmq-operator
rocketmq-operator-6f65c77c49-8hwmj   1/1     Running   0          93s
```

**2) 클러스터 인스턴스 생성**
```shell
### create RocketMQ cluster resource
$ cd example && kubectl create -f rocketmq_v1alpha1_rocketmq_cluster.yaml

### check whether cluster resources is running
$ kubectl get sts
NAME                 READY   AGE
broker-0-master      1/1     107m
broker-0-replica-1   1/1     107m
name-service         1/1     107m
```

---
## Apache RocketMQ 커뮤니티
* [RocketMQ Streams](https://github.com/apache/rocketmq-streams): Apache RocketMQ 기반의 경량 스트림 컴퓨팅 엔진입니다.
* [RocketMQ Flink](https://github.com/apache/rocketmq-flink): 데이터 스트림 및 테이블에서 소스 및 싱크 커넥터를 지원하는 Apache Flink용 Apache RocketMQ 커넥터입니다.
* [RocketMQ APIs](https://github.com/apache/rocketmq-apis): RocketMQ protobuf 프로토콜입니다.
* [RocketMQ Clients](https://github.com/apache/rocketmq-clients): gRPC/protobuf 기반 RocketMQ 클라이언트입니다.
* RocketMQ Remoting 기반 클라이언트
	 - [RocketMQ Client CPP](https://github.com/apache/rocketmq-client-cpp)
	 - [RocketMQ Client Go](https://github.com/apache/rocketmq-client-go)
	 - [RocketMQ Client Python](https://github.com/apache/rocketmq-client-python)
	 - [RocketMQ Client Nodejs](https://github.com/apache/rocketmq-client-nodejs)
* [RocketMQ Spring](https://github.com/apache/rocketmq-spring): 개발자가 Apache RocketMQ를 Spring Boot와 빠르게 통합할 수 있도록 돕는 프로젝트입니다.
* [RocketMQ Exporter](https://github.com/apache/rocketmq-exporter): Prometheus용 Apache RocketMQ 익스포터입니다.
* [RocketMQ Operator](https://github.com/apache/rocketmq-operator): Kubernetes에서 Apache RocketMQ 클러스터를 실행하는 방법을 제공합니다.
* [RocketMQ Docker](https://github.com/apache/rocketmq-docker): Apache RocketMQ용 Docker 이미지의 Git 저장소입니다.
* [RocketMQ Dashboard](https://github.com/apache/rocketmq-dashboard): Apache RocketMQ의 운영 및 유지보수 콘솔입니다.
* [RocketMQ Connect](https://github.com/apache/rocketmq-connect): Apache RocketMQ와 다른 시스템 간에 데이터를 확장 가능하고 안정적으로 스트리밍하는 도구입니다.
* [RocketMQ MQTT](https://github.com/apache/rocketmq-mqtt): IoT 장치 및 모바일 앱과 같은 단말기의 메시지를 더 잘 지원할 수 있도록 설계된 새로운 MQTT 프로토콜 아키텍처 모델입니다.
* [RocketMQ EventBridge](https://github.com/apache/rocketmq-eventbridge): 이벤트 기반 애플리케이션 구축을 쉽게 만들어줍니다.
* [RocketMQ Incubating Community Projects](https://github.com/apache/rocketmq-externals): Apache RocketMQ의 인큐베이터 커뮤니티 프로젝트로, [logappender](https://github.com/apache/rocketmq-externals/tree/master/logappender), [rocketmq-ansible](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-ansible), [rocketmq-beats-integration](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-beats-integration), [rocketmq-cloudevents-binding](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-cloudevents-binding) 등을 포함합니다.
* [RocketMQ Site](https://github.com/apache/rocketmq-site): Apache RocketMQ 웹사이트 저장소입니다.
* [RocketMQ E2E](https://github.com/apache/rocketmq-e2e): 엔드투엔드, 성능, 호환성 테스트를 포함하는 Apache RocketMQ 테스트 프로젝트입니다.


----------
## 배우기 & 연락처
* 메일링 리스트: <https://rocketmq.apache.org/about/contact/>
* 홈페이지: <https://rocketmq.apache.org>
* 문서: <https://rocketmq.apache.org/docs/quick-start/>
* 이슈: <https://github.com/apache/rocketmq/issues>
* 개선 제안서: <https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal>
* 질문하기: <https://stackoverflow.com/questions/tagged/rocketmq>
* 슬랙: <https://rocketmq-invite-automation.herokuapp.com/>


----------



## 기여하기
사소한 정리부터 [큰 신규 기능](https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal) 또는 기타 물질적 보상까지 새로운 기여를 항상 환영합니다. 자세한 내용은 [여기](http://rocketmq.apache.org/docs/how-to-contribute/)를 참조하세요.

----------
## 라이선스
[아파치 라이선스, 버전 2.0](http://www.apache.org/licenses/LICENSE-2.0.html) 저작권 (C) 아파치 소프트웨어 재단


----------
## 수출 통제 고지
이 배포판에는 암호화 소프트웨어가 포함되어 있습니다. 현재 거주 중인 국가에서는 암호화 소프트웨어의 수입, 소지, 사용 및/또는 다른 국가로의 재수출에 제한이 있을 수 있습니다.
암호화 소프트웨어를 사용하기 전에, 암호화 소프트웨어의 수입, 소지, 사용 및 재수출이 허용되는지 확인하기 위해 귀하 국가의 법률, 규정 및 정책을 반드시 확인하십시오. 자세한 내용은
<http://www.wassenaar.org/>를 참조하십시오.

미국 정부 상무부 산업안보국(BIS)은 이 소프트웨어를 비대칭 알고리즘을 사용하는 또는 수행하는 정보 보안 소프트웨어를 포함하는 수출 품목 관리 번호(ECCN) 5D002.C.1로 분류하였습니다.
이 아파치 소프트웨어 재단 배포판의 형태와 방식은 라이선스 예외 ENC 기술 소프트웨어 무제한(TSU) 예외(상세 내용은 BIS 수출 관리 규정, 섹션 740.13 참조)에 따라 객체 코드와 소스 코드 모두에 대해 수출이 가능합니다.

다음은 포함된 암호화 소프트웨어에 대한 자세한 내용입니다:

이 소프트웨어는 서비스 간 네트워크를 통해 전송되는 데이터의 인증 및 암호화와 복호화를 지원하기 위해 Apache Commons Crypto(https://commons.apache.org/proper/commons-crypto/)를 사용합니다.

[maven-build-image]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml/badge.svg
[maven-build-url]: https://github.com/apache/rocketmq/actions/workflows/maven.yaml
[codecov-image]: https://codecov.io/gh/apache/rocketmq/branch/master/graph/badge.svg
[codecov-url]: https://codecov.io/gh/apache/rocketmq
[maven-central-image]: https://maven-badges.herokuapp.com/maven-central/org.apache.rocketmq/rocketmq-all/badge.svg
[maven-central-url]: http://search.maven.org/#search%7Cga%7C1%7Corg.apache.rocketmq
[release-image]: https://img.shields.io/badge/release-download-orange.svg
[release-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[license-image]: https://img.shields.io/badge/license-Apache%202-4EB1BA.svg
[license-url]: https://www.apache.org/licenses/LICENSE-2.0.html
[average-time-to-resolve-an-issue-image]: http://isitmaintained.com/badge/resolution/apache/rocketmq.svg








[average-time-to-resolve-an-issue-url]: http://isitmaintained.com/project/apache/rocketmq
[percentage-of-issues-still-open-image]: http://isitmaintained.com/badge/open/apache/rocketmq.svg
[percentage-of-issues-still-open-url]: http://isitmaintained.com/project/apache/rocketmq
[twitter-follow-image]: https://img.shields.io/twitter/follow/ApacheRocketMQ?style=social
[twitter-follow-url]: https://twitter.com/intent/follow?screen_name=ApacheRocketMQ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---