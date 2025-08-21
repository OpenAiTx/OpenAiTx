## Apache RocketMQ

[![Build Status][maven-build-image]][maven-build-url]
[![CodeCov][codecov-image]][codecov-url]
[![Maven Central][maven-central-image]][maven-central-url]
[![Release][release-image]][release-url]
[![License][license-image]][license-url]
[![Average Time to Resolve An Issue][percentage-of-issues-still-open-image]][percentage-of-issues-still-open-url]
[![Percentage of Issues Still Open][average-time-to-resolve-an-issue-image]][average-time-to-resolve-an-issue-url]
[![Twitter Follow][twitter-follow-image]][twitter-follow-url]

**[Apache RocketMQ](https://rocketmq.apache.org) 是一个分布式消息和流处理平台，具有低延迟、高性能和高可靠性，支持万亿级容量和灵活的可扩展性。**


它提供多种功能：

* 消息模式包括发布/订阅、请求/响应和流处理
* 金融级事务消息
* 基于 [DLedger Controller](https://raw.githubusercontent.com/apache/rocketmq/develop/docs/en/controller/quick_start.md) 的内置容错和高可用配置选项
* 内置消息追踪能力，同时支持 opentracing
* 多样化的大数据和流处理生态系统集成
* 支持按时间或偏移量的消息回溯
* 同一队列内可靠的 FIFO 和严格顺序消息
* 高效的拉取和推送消费模型
* 单队列百万级消息积累能力
* 多种消息协议，如 gRPC、MQTT、JMS 和 OpenMessaging
* 灵活的分布式横向扩展部署架构
* 极速批量消息交换系统
* 多种消息过滤机制，如 SQL 和标签
* 用于隔离测试和云隔离集群的 Docker 镜像
* 功能丰富的管理仪表盘，用于配置、指标和监控
* 认证和授权
* 免费开源的连接器，支持源和接收端
* 轻量级实时计算
----------


## 快速开始

本段引导您通过不同方式安装 RocketMQ 的步骤。
对于本地开发和测试，每个组件只会创建一个实例。

### 本地运行 RocketMQ

RocketMQ 可在所有主要操作系统上运行，仅需安装 Java JDK 8 版本或更高版本。
要检查，请运行 `java -version`：
```shell
$ java -version
java version "1.8.0_121"
```
对于 Windows 用户，点击[此处](https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip)下载 5.3.3 版本的 RocketMQ 二进制发布包，  
将其解压到本地磁盘，例如 `D:\rocketmq`。  
对于 macOS 和 Linux 用户，执行以下命令：  


```shell
# Download release from the Apache mirror
$ wget https://dist.apache.org/repos/dist/release/rocketmq/5.3.3/rocketmq-all-5.3.3-bin-release.zip

# Unpack the release
$ unzip rocketmq-all-5.3.3-bin-release.zip
```
准备一个终端并切换到解压后的 `bin` 目录：

```shell
$ cd rocketmq-all-5.3.3-bin-release/bin
```

**1）启动NameServer**

NameServer将监听`0.0.0.0:9876`，请确保本机该端口未被其他程序占用，然后按如下操作。

对于macOS和Linux用户：
```shell
### start Name Server
$ nohup sh mqnamesrv &

### check whether Name Server is successfully started
$ tail -f ~/logs/rocketmqlogs/namesrv.log
The Name Server boot success...
```

对于Windows用户，您需要先设置环境变量：
- 在桌面上，右键点击计算机图标。
- 从上下文菜单中选择属性。
- 点击高级系统设置链接。
- 点击环境变量。
- 添加环境变量 `ROCKETMQ_HOME="D:\rocketmq"`。

然后切换到rocketmq目录，输入并运行：
```shell
$ mqnamesrv.cmd
The Name Server boot success...
```

**2）启动代理**

针对 macOS 和 Linux 用户：
```shell
### start Broker
$ nohup sh bin/mqbroker -n localhost:9876 &

### check whether Broker is successfully started, eg: Broker's IP is 192.168.1.2, Broker's name is broker-a
$ tail -f ~/logs/rocketmqlogs/broker.log
The broker[broker-a, 192.169.1.2:10911] boot success...
```

对于 Windows 用户：
```shell
$ mqbroker.cmd -n localhost:9876
The broker[broker-a, 192.169.1.2:10911] boot success...
```

### 在 Docker 中运行 RocketMQ

您可以在自己的机器上通过 Docker 容器运行 RocketMQ，  
容器中将使用 `host` 网络来暴露监听端口。

**1) 启动 NameServer**

```shell
$ docker run -it --net=host apache/rocketmq ./mqnamesrv
```

**2) 启动代理**

```shell
$ docker run -it --net=host --mount type=bind,source=/tmp/store,target=/home/rocketmq/store apache/rocketmq ./mqbroker -n localhost:9876
```

### 在 Kubernetes 中运行 RocketMQ

您也可以使用 [RocketMQ Operator](https://github.com/apache/rocketmq-operator) 在 Kubernetes 集群中运行 RocketMQ 集群。
在操作之前，请确保您的机器上已安装 `kubectl` 及相关的 kubeconfig 文件。

**1) 安装 CRDs**
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

**2) 创建集群实例**
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
## Apache RocketMQ 社区
* [RocketMQ Streams](https://github.com/apache/rocketmq-streams)：基于 Apache RocketMQ 的轻量级流计算引擎。
* [RocketMQ Flink](https://github.com/apache/rocketmq-flink)：支持数据流和表中的源和汇连接器的 Apache Flink 的 Apache RocketMQ 连接器。
* [RocketMQ APIs](https://github.com/apache/rocketmq-apis)：RocketMQ protobuf 协议。
* [RocketMQ Clients](https://github.com/apache/rocketmq-clients)：基于 gRPC/protobuf 的 RocketMQ 客户端。
* 基于 RocketMQ Remoting 的客户端
	 - [RocketMQ Client CPP](https://github.com/apache/rocketmq-client-cpp)
	 - [RocketMQ Client Go](https://github.com/apache/rocketmq-client-go)
	 - [RocketMQ Client Python](https://github.com/apache/rocketmq-client-python)
	 - [RocketMQ Client Nodejs](https://github.com/apache/rocketmq-client-nodejs)
* [RocketMQ Spring](https://github.com/apache/rocketmq-spring)：帮助开发者快速将 Apache RocketMQ 与 Spring Boot 集成的项目。
* [RocketMQ Exporter](https://github.com/apache/rocketmq-exporter)：用于 Prometheus 的 Apache RocketMQ 导出器。
* [RocketMQ Operator](https://github.com/apache/rocketmq-operator)：提供在 Kubernetes 上运行 Apache RocketMQ 集群的方式。
* [RocketMQ Docker](https://github.com/apache/rocketmq-docker)：Apache RocketMQ Docker 镜像的 Git 仓库。
* [RocketMQ Dashboard](https://github.com/apache/rocketmq-dashboard)：Apache RocketMQ 的运维控制台。
* [RocketMQ Connect](https://github.com/apache/rocketmq-connect)：用于在 Apache RocketMQ 与其他系统之间可扩展且可靠地流式传输数据的工具。
* [RocketMQ MQTT](https://github.com/apache/rocketmq-mqtt)：一种新的 MQTT 协议架构模型，基于此 Apache RocketMQ 能更好地支持来自物联网设备和移动应用等终端的消息。
* [RocketMQ EventBridge](https://github.com/apache/rocketmq-eventbridge)：EventBridge 使构建事件驱动应用更容易。
* [RocketMQ 孵化社区项目](https://github.com/apache/rocketmq-externals)：Apache RocketMQ 的孵化社区项目，包括 [logappender](https://github.com/apache/rocketmq-externals/tree/master/logappender)、[rocketmq-ansible](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-ansible)、[rocketmq-beats-integration](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-beats-integration)、[rocketmq-cloudevents-binding](https://github.com/apache/rocketmq-externals/tree/master/rocketmq-cloudevents-binding) 等。
* [RocketMQ Site](https://github.com/apache/rocketmq-site)：Apache RocketMQ 网站的仓库。
* [RocketMQ E2E](https://github.com/apache/rocketmq-e2e)：用于测试 Apache RocketMQ 的项目，包括端到端、性能、兼容性测试。


----------
## 学习及联系我们
* 邮件列表：<https://rocketmq.apache.org/about/contact/>
* 主页：<https://rocketmq.apache.org>
* 文档：<https://rocketmq.apache.org/docs/quick-start/>
* 问题追踪：<https://github.com/apache/rocketmq/issues>
* 改进提案：<https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal>
* 提问：<https://stackoverflow.com/questions/tagged/rocketmq>
* Slack：<https://rocketmq-invite-automation.herokuapp.com/>


----------




## 贡献
我们始终欢迎新的贡献，无论是微不足道的清理，[重大新功能](https://github.com/apache/rocketmq/wiki/RocketMQ-Improvement-Proposal)还是其他物质奖励，更多详情请见[这里](http://rocketmq.apache.org/docs/how-to-contribute/)。

----------
## 许可证
[Apache 许可证，版本 2.0](http://www.apache.org/licenses/LICENSE-2.0.html) 版权所有 (C) Apache 软件基金会


----------
## 出口管制声明
本发行版包含加密软件。您当前所在国家可能对加密软件的进口、持有、使用和/或向其他国家的再出口有限制。
在使用任何加密软件之前，请检查您所在国家关于加密软件的进口、持有、使用和再出口的法律、法规和政策，以确定是否允许。详情见
<http://www.wassenaar.org/>。

美国商务部工业与安全局（BIS）已将本软件归类为出口商品控制编号（ECCN）5D002.C.1，该类别包括使用或执行非对称算法的加密功能的信息安全软件。
Apache 软件基金会以此形式和方式发布的软件符合出口许可例外 ENC 技术软件无限制（TSU）例外条件（参见 BIS 出口管理条例，第 740.13 条），
适用于目标代码和源代码。

以下提供有关所含加密软件的更多详细信息：

本软件使用 Apache Commons Crypto (https://commons.apache.org/proper/commons-crypto/) 来支持认证，以及服务间通过网络传输数据的加密和解密。

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