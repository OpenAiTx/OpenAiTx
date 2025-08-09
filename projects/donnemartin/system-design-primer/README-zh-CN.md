*[English](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README.md) ∙ [日本語](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-ja.md) ∙ [简体中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-Hans.md) ∙ [繁體中文](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/README-zh-TW.md) | [العَرَبِيَّة‎](https://github.com/donnemartin/system-design-primer/issues/170) ∙ [বাংলা](https://github.com/donnemartin/system-design-primer/issues/220) ∙ [Português do Brasil](https://github.com/donnemartin/system-design-primer/issues/40) ∙ [Deutsch](https://github.com/donnemartin/system-design-primer/issues/186) ∙ [ελληνικά](https://github.com/donnemartin/system-design-primer/issues/130) ∙ [עברית](https://github.com/donnemartin/system-design-primer/issues/272) ∙ [Italiano](https://github.com/donnemartin/system-design-primer/issues/104) ∙ [한국어](https://github.com/donnemartin/system-design-primer/issues/102) ∙ [فارسی](https://github.com/donnemartin/system-design-primer/issues/110) ∙ [Polski](https://github.com/donnemartin/system-design-primer/issues/68) ∙ [русский язык](https://github.com/donnemartin/system-design-primer/issues/87) ∙ [Español](https://github.com/donnemartin/system-design-primer/issues/136) ∙ [ภาษาไทย](https://github.com/donnemartin/system-design-primer/issues/187) ∙ [Türkçe](https://github.com/donnemartin/system-design-primer/issues/39) ∙ [tiếng Việt](https://github.com/donnemartin/system-design-primer/issues/127) ∙ [Français](https://github.com/donnemartin/system-design-primer/issues/250) | [Add Translation](https://github.com/donnemartin/system-design-primer/issues/28)*
**帮助[翻译](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/TRANSLATIONS.md)本指南！**

# 系统设计入门

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png">
  <br/>
</p>

## 动机

> 学习如何设计大规模系统。
>
> 准备系统设计面试。

### 学习如何设计大规模系统

学习如何设计可扩展系统将帮助你成为更优秀的工程师。

系统设计是一个广泛的主题。网络上散布着**大量关于系统设计原则的资源**。

本仓库是一个**有组织的资源集合**，帮助你学习如何构建大规模系统。

### 向开源社区学习

这是一个持续更新的开源项目。

欢迎[贡献](#contributing)！

### 准备系统设计面试

除了编码面试，系统设计是许多科技公司**技术面试流程**中的**必备环节**。

**练习常见的系统设计面试题**，并将你的结果与**示例解答**进行**比较**：讨论、代码和图表。

面试准备的其他主题：

* [学习指南](#study-guide)
* [如何应对系统设计面试题](#how-to-approach-a-system-design-interview-question)

* [系统设计面试题，**附答案**](#system-design-interview-questions-with-solutions)
* [面向对象设计面试题，**附答案**](#object-oriented-design-interview-questions-with-solutions)
* [额外的系统设计面试题](#additional-system-design-interview-questions)

## Anki 闪卡

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/zdCAkB3.png">
  <br/>
</p>

提供的 [Anki 闪卡套装](https://apps.ankiweb.net/) 使用间隔重复帮助你记忆关键的系统设计概念。

* [系统设计套装](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design.apkg)
* [系统设计练习套装](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/System%20Design%20Exercises.apkg)
* [面向对象设计练习套装](https://github.com/donnemartin/system-design-primer/tree/master/resources/flash_cards/OO%20Design.apkg)

非常适合在移动中使用。

### 编程资源：互动编程挑战

想找资源帮助准备[**编程面试**](https://github.com/donnemartin/interactive-coding-challenges)吗？

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/b4YtAEN.png">
  <br/>
</p>

看看姊妹仓库 [**互动编程挑战**](https://github.com/donnemartin/interactive-coding-challenges)，其中包含额外的 Anki 套装：

* [编程套装](https://github.com/donnemartin/interactive-coding-challenges/tree/master/anki_cards/Coding.apkg)

## 贡献

> 从社区中学习。

欢迎提交拉取请求帮助：

* 修正错误
* 改进章节
* 添加新章节
* [翻译](https://github.com/donnemartin/system-design-primer/issues/28)

需要润色的内容放置在[开发中](#under-development)。

请查看[贡献指南](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/CONTRIBUTING.md)。

## 系统设计主题索引

> 各种系统设计主题的总结，包括优缺点。**一切都是权衡**。
>
> 每个章节包含指向更深入资源的链接。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png">
  <br/>
</p>

* [系统设计主题：从这里开始](#system-design-topics-start-here)
    * [步骤 1：观看可扩展性视频讲座](#step-1-review-the-scalability-video-lecture)
    * [步骤 2：阅读可扩展性文章](#step-2-review-the-scalability-article)
    * [下一步](#next-steps)
* [性能与可扩展性](#performance-vs-scalability)
* [延迟与吞吐量](#latency-vs-throughput)
* [可用性与一致性](#availability-vs-consistency)
    * [CAP 定理](#cap-theorem)
        * [CP - 一致性和分区容错](#cp---consistency-and-partition-tolerance)
        * [AP - 可用性和分区容错](#ap---availability-and-partition-tolerance)
* [一致性模式](#consistency-patterns)
    * [弱一致性](#weak-consistency)
    * [最终一致性](#eventual-consistency)
    * [强一致性](#strong-consistency)
* [可用性模式](#availability-patterns)
    * [故障切换](#fail-over)
    * [复制](#replication)
    * [用数字看可用性](#availability-in-numbers)
* [域名系统](#domain-name-system)
* [内容分发网络](#content-delivery-network)
    * [推送型 CDN](#push-cdns)
    * [拉取型 CDN](#pull-cdns)
* [负载均衡器](#load-balancer)
    * [主动-被动](#active-passive)
    * [主动-主动](#active-active)
    * [第4层负载均衡](#layer-4-load-balancing)
    * [第7层负载均衡](#layer-7-load-balancing)
    * [水平扩展](#horizontal-scaling)
* [反向代理（网页服务器）](#reverse-proxy-web-server)
    * [负载均衡器 vs 反向代理](#load-balancer-vs-reverse-proxy)
* [应用层](#application-layer)
    * [微服务](#microservices)
    * [服务发现](#service-discovery)
* [数据库](#database)
    * [关系型数据库管理系统 (RDBMS)](#relational-database-management-system-rdbms)
        * [主从复制](#master-slave-replication)
        * [主主复制](#master-master-replication)
        * [联合](#federation)
        * [分片](#sharding)
        * [反规范化](#denormalization)
        * [SQL 调优](#sql-tuning)
    * [NoSQL](#nosql)
        * [键值存储](#key-value-store)
        * [文档存储](#document-store)
        * [宽列存储](#wide-column-store)
        * [图数据库](#graph-database)
    * [SQL 或 NoSQL](#sql-or-nosql)
* [缓存](#cache)
    * [客户端缓存](#client-caching)
    * [CDN 缓存](#cdn-caching)
    * [网页服务器缓存](#web-server-caching)
    * [数据库缓存](#database-caching)
    * [应用缓存](#application-caching)
    * [数据库查询级缓存](#caching-at-the-database-query-level)
    * [对象级缓存](#caching-at-the-object-level)
    * [何时更新缓存](#when-to-update-the-cache)
        * [旁路缓存](#cache-aside)
        * [写透](#write-through)
        * [写后（写回）](#write-behind-write-back)
        * [预刷新](#refresh-ahead)
* [异步](#asynchronism)
    * [消息队列](#message-queues)
    * [任务队列](#task-queues)
    * [反压](#back-pressure)
* [通信](#communication)
    * [传输控制协议 (TCP)](#transmission-control-protocol-tcp)
    * [用户数据报协议 (UDP)](#user-datagram-protocol-udp)
    * [远程过程调用 (RPC)](#remote-procedure-call-rpc)
    * [表现层状态转移 (REST)](#representational-state-transfer-rest)
* [安全](#security)
* [附录](#appendix)
    * [二的幂表](#powers-of-two-table)
    * [每个程序员应知的延迟数字](#latency-numbers-every-programmer-should-know)
    * [额外的系统设计面试问题](#additional-system-design-interview-questions)
    * [真实世界架构](#real-world-architectures)
    * [公司架构](#company-architectures)
    * [公司工程博客](#company-engineering-blogs)
* [开发中](#under-development)
* [鸣谢](#credits)
* [联系方式](#contact-info)
* [许可](#license)

## 学习指南

> 根据你的面试时间线建议复习的主题（短期、中期、长期）。

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/OfVllex.png)

**问：面试时，我需要知道这里的所有内容吗？**

**答：不，你不需要知道这里的所有内容来准备面试**。

面试时被问到的内容取决于以下变量：

* 你的经验有多少
* 你的技术背景是什么
* 你面试的职位是什么
* 你面试的是哪些公司
* 运气

经验更丰富的候选人通常被期望对系统设计了解更多。架构师或团队负责人可能被期望比普通贡献者知道更多。顶级科技公司很可能有一轮或多轮设计面试。

从广泛开始，在少数几个领域深入。了解一些关键系统设计主题会很有帮助。根据你的时间安排、经验、面试职位和面试公司调整以下指南。

* **时间紧张** - 目标是系统设计主题的**广度**。通过解决**一些**面试题进行练习。
* **时间适中** - 目标是系统设计主题的**广度**和**一定深度**。通过解决**许多**面试题进行练习。
* **时间充裕** - 目标是系统设计主题的**广度**和**更深的深度**。通过解决**大部分**面试题进行练习。

| | 短期 | 中期 | 长期 |
|---|---|---|---|
| 通读[系统设计主题](#index-of-system-design-topics)，对系统如何工作有一个广泛的了解 | :+1: | :+1: | :+1: |
| 阅读你面试公司的[公司工程博客](#company-engineering-blogs)中的几篇文章 | :+1: | :+1: | :+1: |
| 阅读几篇[真实世界架构](#real-world-architectures) | :+1: | :+1: | :+1: |
| 复习[如何处理系统设计面试题](#how-to-approach-a-system-design-interview-question) | :+1: | :+1: | :+1: |
| 练习[带有解答的系统设计面试题](#system-design-interview-questions-with-solutions) | 一些 | 许多 | 大部分 |
| 练习[带有解答的面向对象设计面试题](#object-oriented-design-interview-questions-with-solutions) | 一些 | 许多 | 大部分 |
| 复习[额外的系统设计面试题](#additional-system-design-interview-questions) | 一些 | 许多 | 大部分 |

## 如何处理系统设计面试题

> 如何解决系统设计面试题。

系统设计面试是一个**开放式对话**。你需要主导它。

你可以使用以下步骤来引导讨论。为了帮助巩固这个过程，使用以下步骤完成[带有解答的系统设计面试题](#system-design-interview-questions-with-solutions)部分。

### 第一步：概述用例、约束和假设

收集需求并确定问题范围。提问以澄清用例和约束。讨论假设。

* 谁将使用它？
* 他们将如何使用它？
* 有多少用户？
* 系统做什么？
* 系统的输入和输出是什么？
* 我们预计处理多少数据？
* 我们预计每秒多少请求？
* 预期的读写比例是多少？

### 第二步：创建高级设计

概述一个包含所有重要组件的高级设计。
* 绘制主要组件和连接
* 说明你的设计思路

### 第3步：设计核心组件

深入讨论每个核心组件的细节。例如，如果你被要求[设计一个URL缩短服务](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)，可以讨论：

* 生成并存储完整URL的哈希值
    * [MD5](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) 和 [Base62](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)
    * 哈希冲突
    * 使用SQL还是NoSQL
    * 数据库模式设计
* 将哈希URL转换为完整URL
    * 数据库查询
* API设计和面向对象设计

### 第4步：扩展设计

识别并解决瓶颈问题，考虑约束条件。例如，你是否需要以下方案来解决可扩展性问题？

* 负载均衡器
* 横向扩展
* 缓存
* 数据库分片

讨论潜在的解决方案和权衡。所有设计都有权衡。使用[可扩展系统设计原则](#index-of-system-design-topics)来解决瓶颈问题。

### 估算计算

你可能需要手动做一些估算。请参考[附录](#appendix)中的以下资源：

* [使用估算计算](http://highscalability.com/blog/2011/1/26/google-pro-tip-use-back-of-the-envelope-calculations-to-choo.html)
* [2的幂表](#powers-of-two-table)
* [每个程序员都该知道的延迟数字](#latency-numbers-every-programmer-should-know)

### 来源和进一步阅读

查看以下链接以更好地了解预期内容：


* [如何通过系统设计面试](https://www.palantir.com/2011/10/how-to-rock-a-systems-design-interview/)
* [系统设计面试](http://www.hiredintech.com/system-design)
* [架构与系统设计面试简介](https://www.youtube.com/watch?v=ZgdS0EUmn70)
* [系统设计模板](https://leetcode.com/discuss/career/229177/My-System-Design-Template)

## 系统设计面试题及解决方案

> 常见系统设计面试题，附示例讨论、代码及图表。
>
> 解决方案链接指向 `solutions/` 文件夹中的内容。

| 问题 | |
|---|---|
| 设计 Pastebin.com（或 Bit.ly） | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md) |
| 设计 Twitter 时间线和搜索（或 Facebook 动态和搜索） | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md) |
| 设计一个网络爬虫 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md) |
| 设计 Mint.com | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md) |
| 设计社交网络的数据结构 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md) |
| 设计搜索引擎的键值存储 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md) |
| 设计亚马逊按类别的销售排名功能 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md) |
| 设计一个可扩展至数百万用户的 AWS 系统 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md) |
| 添加系统设计题目 | [贡献](#contributing) |

### 设计 Pastebin.com（或 Bit.ly）

[查看练习及解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/pastebin/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4edXG0T.png)

### 设计 Twitter 时间线和搜索（或 Facebook 动态和搜索）

[查看练习及解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/twitter/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jrUBAF7.png)

### 设计一个网络爬虫

[查看练习及解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/web_crawler/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bWxPtQA.png)

### Design Mint.com

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/mint/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/V5q57vU.png)

### Design the data structures for a social network

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/social_graph/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/cdCv5g7.png)

### Design a key-value store for a search engine

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/query_cache/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/4j99mhe.png)

### Design Amazon's sales ranking by category feature

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/sales_rank/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/MzExP06.png)

### Design a system that scales to millions of users on AWS

[View exercise and solution](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/system_design/scaling_aws/README.md)

![Imgur](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/jj3A5N8.png)

## Object-oriented design interview questions with solutions

> Common object-oriented design interview questions with sample discussions, code, and diagrams.
>
> Solutions linked to content in the `solutions/` folder.

>**Note: This section is under development**

| Question | |
|---|---|
| 设计哈希映射 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/hash_table/hash_map.ipynb)  |
| 设计最近最少使用缓存 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/lru_cache/lru_cache.ipynb)  |
| 设计呼叫中心 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/call_center/call_center.ipynb)  |
| 设计一副牌 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/deck_of_cards/deck_of_cards.ipynb)  |
| 设计停车场 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/parking_lot/parking_lot.ipynb)  |
| 设计聊天服务器 | [解决方案](https://raw.githubusercontent.com/donnemartin/system-design-primer/master/solutions/object_oriented_design/online_chat/online_chat.ipynb)  |
| 设计循环数组 | [贡献](#contributing)  |
| 添加面向对象设计问题 | [贡献](#contributing) |

## 系统设计主题：从这里开始

系统设计新手？

首先，你需要对常见原则有基本了解，学习它们是什么、如何使用以及它们的优缺点。

### 第一步：观看可扩展性视频讲座

[哈佛可扩展性讲座](https://www.youtube.com/watch?v=-W9F__D3oY4)

* 涉及主题：
    * 纵向扩展
    * 横向扩展
    * 缓存
    * 负载均衡
    * 数据库复制
    * 数据库分区

### 第二步：阅读可扩展性文章

[可扩展性](https://web.archive.org/web/20221030091841/http://www.lecloud.net/tagged/scalability/chrono)

* 涉及主题：
    * [克隆](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
    * [数据库](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
    * [缓存](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
    * [异步](https://web.archive.org/web/20220926171507/https://www.lecloud.net/post/9699762917/scalability-for-dummies-part-4-asynchronism)

### 接下来的步骤

接下来，我们将关注高级权衡：

* **性能** 与 **可扩展性**
* **延迟** 与 **吞吐量**
* **可用性** 与 **一致性**

请记住，**一切都是权衡**。

然后我们将深入探讨更具体的主题，如 DNS、CDN 和负载均衡器。

## 性能与可扩展性

如果服务能够随着资源的增加而按比例提升**性能**，则该服务是**可扩展的**。通常，提高性能意味着处理更多的工作单位，但也可以是处理更大的工作单位，例如数据集增长时。<sup><a href=http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html>1</a></sup>

从另一个角度看性能与可扩展性：

* 如果你有**性能**问题，说明系统对单个用户来说很慢。
* 如果你有**可扩展性**问题，说明系统对单个用户很快，但在负载重时很慢。

### 资料来源及进一步阅读

* [关于可扩展性的一句话](http://www.allthingsdistributed.com/2006/03/a_word_on_scalability.html)
* [可扩展性、可用性、稳定性、模式](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)

## 延迟与吞吐量

**延迟** 是执行某个动作或产生某个结果所需的时间。

**吞吐量** 是单位时间内完成的此类动作或产生的结果数量。

通常，你应当以**最大吞吐量**和**可接受的延迟**为目标。

### 资料来源及进一步阅读

* [理解延迟与吞吐量](https://community.cadence.com/cadence_blogs_8/b/fv/posts/understanding-latency-vs-throughput)

## 可用性与一致性

### CAP 定理

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/bgLMI2u.png">
  <br/>
  <i><a href=http://robertgreiner.com/2014/08/cap-theorem-revisited>来源：CAP 定理再访</a></i>
</p>

在分布式计算系统中，你只能支持以下三项保证中的两项：

* **一致性** - 每次读取都能获得最近的写入内容，或返回错误
* **可用性** - 每个请求都会收到响应，但不保证包含最新版本的信息
* **分区容错性** - 系统即使在因网络故障导致的任意分区情况下仍能继续运行

*网络不可靠，因此你需要支持分区容错。你需要在一致性和可用性之间做出软件上的权衡。*

#### CP - 一致性和分区容错性

等待分区节点的响应可能导致超时错误。如果业务需求要求原子读写，CP 是一个不错的选择。

#### AP - 可用性和分区容错性

响应返回任何节点上最容易获得的数据版本，可能不是最新的。当分区恢复时，写操作可能需要一定时间传播。

当业务需要允许[最终一致性](#eventual-consistency)或系统需要在外部错误发生时继续工作时，AP 是一个不错的选择。

### 来源及进一步阅读

* [CAP 定理再访](http://robertgreiner.com/2014/08/cap-theorem-revisited/)
* [CAP 定理通俗介绍](http://ksat.me/a-plain-english-introduction-to-cap-theorem)
* [CAP 常见问题解答](https://github.com/henryr/cap-faq)
* [CAP 定理讲解视频](https://www.youtube.com/watch?v=k-Yaq8AHlFA)

## 一致性模式

当存在多个相同数据副本时，我们面临如何同步它们以保证客户端数据一致性的选择。回想[CAP 定理](#cap-theorem)中一致性的定义——每次读取都能获得最近的写入内容，或返回错误。

### 弱一致性

写入后，读取可能能看到也可能看不到写入内容。采取的是尽力而为的方式。

这种方式见于如 memcached 这类系统。弱一致性在实时应用场景中表现良好，如 VoIP、视频聊天和实时多人游戏。例如，如果你在通话中短暂失去信号，恢复连接后不会听到信号丢失期间的内容。

### 最终一致性

写入后，读取最终会看到该写入（通常在毫秒级内）。数据是异步复制的。

这种方法见于 DNS 和电子邮件等系统。最终一致性在高可用系统中效果良好。

### 强一致性

写入后，读取会立即看到该写入。数据是同步复制的。

这种方法见于文件系统和关系型数据库系统。强一致性适用于需要事务的系统。

### 来源及进一步阅读

* [跨数据中心的事务](http://snarfed.org/transactions_across_datacenters_io.html)

## 可用性模式

支持高可用性的两种互补模式：**故障切换** 和 **复制**。

### 故障切换

#### 主备模式

在主备故障切换中，主服务器与待命的备份服务器之间会发送心跳信号。若心跳中断，备份服务器接管主服务器的 IP 地址并恢复服务。

停机时间长短取决于备份服务器是处于“热”待命状态还是需要从“冷”待命启动。仅主服务器处理流量。

主备故障切换也可称为主从故障切换。

#### 主主模式

在主主模式中，两个服务器都在管理流量，分摊负载。

如果服务器面向公网，DNS 需要知道两个服务器的公网 IP 地址；如果服务器面向内部，应用逻辑需要知道两个服务器。

主主故障切换也可称为主主复制故障切换。

### 缺点：故障切换
* 故障切换增加了更多硬件和额外的复杂性。
* 如果活动系统在任何新写入数据复制到被动系统之前失败，可能会导致数据丢失。

### 复制

#### 主从和主主

此主题在[数据库](#database)部分中有更详细的讨论：

* [主从复制](#master-slave-replication)
* [主主复制](#master-master-replication)

### 可用性数字化

可用性通常通过正常运行时间（或停机时间）作为服务可用时间的百分比来量化。可用性通常用“9”的个数来衡量——具有99.99%可用性的服务被描述为有四个9。

#### 99.9% 可用性 - 三个9

| 时长               | 可接受的停机时间     |
|--------------------|--------------------|
| 每年停机时间       | 8小时45分57秒       |
| 每月停机时间       | 43分49.7秒          |
| 每周停机时间       | 10分4.8秒           |
| 每日停机时间       | 1分26.4秒           |

#### 99.99% 可用性 - 四个9

| 时长               | 可接受的停机时间     |
|--------------------|--------------------|
| 每年停机时间       | 52分35.7秒          |
| 每月停机时间       | 4分23秒             |
| 每周停机时间       | 1分5秒              |
| 每日停机时间       | 8.6秒               |

#### 并行与串行的可用性

如果服务由多个易失败的组件组成，服务的整体可用性取决于这些组件是串行还是并行。

###### 串行


当两个可用性低于100%的组件依次连接时，总体可用性会降低：

```
Availability (Total) = Availability (Foo) * Availability (Bar)
```
如果 `Foo` 和 `Bar` 各自的可用性都是 99.9%，它们顺序组合的总可用性将是 99.8%。

###### 并行

当两个可用性低于 100% 的组件并行时，总体可用性会提高：


```
Availability (Total) = 1 - (1 - Availability (Foo)) * (1 - Availability (Bar))
```
如果 `Foo` 和 `Bar` 都有 99.9% 的可用性，那么它们并联的总可用性将是 99.9999%。

## 域名系统

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/IOyLj4i.jpg">
  <br/>
  <i><a href=http://www.slideshare.net/srikrupa5/dns-security-presentation-issa>来源：DNS 安全演示文稿</a></i>
</p>

域名系统（DNS）将诸如 www.example.com 这样的域名转换为 IP 地址。

DNS 是分层的，顶层有少数权威服务器。您的路由器或 ISP 提供关于查找时应联系哪个 DNS 服务器的信息。低级 DNS 服务器会缓存映射，由于 DNS 传播延迟，缓存可能变得过时。DNS 结果也可以由您的浏览器或操作系统缓存一段时间，这取决于[生存时间（TTL）](https://en.wikipedia.org/wiki/Time_to_live)。

* **NS 记录（名称服务器）** - 指定您的域名/子域的 DNS 服务器。
* **MX 记录（邮件交换）** - 指定接收邮件的邮件服务器。
* **A 记录（地址）** - 指向一个 IP 地址的名称。
* **CNAME（规范名称）** - 将一个名称指向另一个名称或 `CNAME`（例如 example.com 指向 www.example.com）或指向一个 `A` 记录。

诸如 [CloudFlare](https://www.cloudflare.com/dns/) 和 [Route 53](https://aws.amazon.com/route53/) 等服务提供托管的 DNS 服务。一些 DNS 服务可以通过多种方法路由流量：

* [加权轮询](https://www.jscape.com/blog/load-balancing-algorithms)
    * 防止流量流向维护中的服务器
    * 平衡不同大小的集群
    * A/B 测试
* [基于延迟](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-latency.html)
* [基于地理位置](https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/routing-policy-geo.html)

### 缺点：DNS

* 访问 DNS 服务器会引入轻微的延迟，尽管上述缓存机制有所缓解。
* DNS 服务器管理可能很复杂，通常由[政府、ISP 和大型公司](http://superuser.com/questions/472695/who-controls-the-dns-servers/472729)管理。
* DNS 服务近期遭受过[DDoS 攻击](http://dyn.com/blog/dyn-analysis-summary-of-friday-october-21-attack/)，导致用户在不知道 Twitter IP 地址的情况下无法访问 Twitter 等网站。

### 资源及进一步阅读

* [DNS 架构](https://technet.microsoft.com/en-us/library/dd197427(v=ws.10).aspx)
* [维基百科](https://en.wikipedia.org/wiki/Domain_Name_System)
* [DNS 相关文章](https://support.dnsimple.com/categories/dns/)


## 内容分发网络

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h9TAuGI.jpg">
  <br/>
  <i><a href=https://www.creative-artworks.eu/why-use-a-content-delivery-network-cdn/>来源：为什么使用 CDN</a></i>
</p>

内容分发网络（CDN）是一种全球分布的代理服务器网络，从更靠近用户的位置提供内容。通常，静态文件如 HTML/CSS/JS、照片和视频由 CDN 提供，尽管一些 CDN 如亚马逊的 CloudFront 支持动态内容。网站的 DNS 解析会告诉客户端联系哪个服务器。

从 CDN 提供内容可以通过两种方式显著提升性能：

* 用户从离他们较近的数据中心接收内容
* 你的服务器不必处理 CDN 已满足的请求

### 推送型 CDN

推送型 CDN 在服务器内容发生变化时接收新内容。你需要全权负责内容的提供，直接上传到 CDN 并重写 URL 指向 CDN。你可以配置内容的过期时间和更新时间。内容仅在新建或更改时上传，最大限度减少流量，同时最大化存储。

流量较小或内容不常更新的网站非常适合推送型 CDN。内容只需上传到 CDN 一次，而不是定期重新拉取。

### 拉取型 CDN

拉取型 CDN 在首个用户请求内容时从你的服务器抓取新内容。你将内容保留在服务器上，并重写 URL 指向 CDN。这导致第一次请求较慢，直到内容缓存到 CDN 上。

[生存时间 (TTL)](https://en.wikipedia.org/wiki/Time_to_live) 决定内容缓存的时长。拉取型 CDN 最大化减少 CDN 上的存储空间，但如果文件过期且尚未实际更改就被拉取，会产生冗余流量。

流量较大的站点适合拉取型 CDN，因为流量更均匀分布，只有最近请求的内容保留在 CDN 上。

### 缺点：CDN

* 根据流量，CDN 费用可能较高，但这应与不使用 CDN 所产生的额外成本进行权衡。
* 如果内容在 TTL 过期前被更新，可能会出现内容过时的情况。
* CDN 需要更改静态内容的 URL 指向 CDN。

### 来源及进一步阅读

* [全球分布式内容交付](https://figshare.com/articles/Globally_distributed_content_delivery/6605972)
* [推送型与拉取型 CDN 的区别](http://www.travelblogadvice.com/technical/the-differences-between-push-and-pull-cdns/)
* [维基百科](https://en.wikipedia.org/wiki/Content_delivery_network)

## 负载均衡器

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/h81n9iK.png">
  <br/>
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>来源：可扩展系统设计模式</a></i>
</p>

负载均衡器将传入的客户端请求分发到计算资源，如应用服务器和数据库。在每种情况下，负载均衡器将计算资源的响应返回给相应的客户端。负载均衡器有效于：

* 防止请求发送到不健康的服务器
* 防止资源过载
* 有助于消除单点故障

负载均衡器可以通过硬件（昂贵）或软件实现，如 HAProxy。

其他好处包括：

* **SSL 终止** - 解密传入请求并加密服务器响应，使后端服务器无需执行这些可能耗费资源的操作
    * 消除了在每台服务器上安装 [X.509 证书](https://en.wikipedia.org/wiki/X.509) 的需求
* **会话持久性** - 如果 Web 应用不跟踪会话，则发放 Cookie 并将特定客户端的请求路由到相同实例

为防止故障，通常会设置多个负载均衡器，以 [主动-被动](#active-passive) 或 [主动-主动](#active-active) 模式运行。

负载均衡器可以基于多种指标路由流量，包括：

* 随机
* 最少负载
* 会话/Cookie
* [轮询或加权轮询](https://www.g33kinfo.com/info/round-robin-vs-weighted-round-robin-lb)
* [第 4 层](#layer-4-load-balancing)
* [第 7 层](#layer-7-load-balancing)

### 第 4 层负载均衡

第 4 层负载均衡器查看[传输层](#communication)的信息来决定如何分配请求。通常，这涉及报头中的源地址、目标 IP 地址和端口，但不包括数据包的内容。第 4 层负载均衡器将网络数据包转发到上游服务器，并执行[网络地址转换 (NAT)](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)。

### 第 7 层负载均衡
第7层负载均衡器查看[应用层](#communication)来决定如何分配请求。 这可能涉及头部、消息和Cookie的内容。 第7层负载均衡器终止网络流量，读取消息，做出负载均衡决策，然后打开与选定服务器的连接。 例如，第7层负载均衡器可以将视频流量引导到托管视频的服务器，同时将更敏感的用户计费流量引导到安全加固的服务器。

以灵活性为代价，第4层负载均衡所需的时间和计算资源比第7层少，尽管在现代通用硬件上性能影响可能很小。

### 水平扩展

负载均衡器还可以帮助进行水平扩展，提高性能和可用性。 使用通用机器进行横向扩展比使用更昂贵硬件上的单个服务器进行纵向扩展（称为**纵向扩展**）更具成本效益且可用性更高。 招聘在通用硬件上工作的技术人才也比专门的企业系统更容易。

#### 缺点：水平扩展

* 水平扩展引入复杂性并涉及服务器克隆
    * 服务器应是无状态的：不应包含任何用户相关数据，如会话或头像
    * 会话可以存储在集中式数据存储中，例如[数据库](#database)（SQL，NoSQL）或持久性[缓存](#cache)（Redis，Memcached）
* 下游服务器如缓存和数据库需要处理更多同时连接，因为上游服务器扩展

### 缺点：负载均衡器

* 如果负载均衡器资源不足或配置不当，可能成为性能瓶颈。
* 引入负载均衡器以消除单点故障会增加复杂性。
* 单个负载均衡器是单点故障，配置多个负载均衡器会进一步增加复杂性。

### 来源及进一步阅读

* [NGINX架构](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy架构指南](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [可扩展性](https://web.archive.org/web/20220530193911/https://www.lecloud.net/post/7295452622/scalability-for-dummies-part-1-clones)
* [维基百科](https://en.wikipedia.org/wiki/Load_balancing_(computing))
* [第4层负载均衡](https://www.nginx.com/resources/glossary/layer-4-load-balancing/)
* [第7层负载均衡](https://www.nginx.com/resources/glossary/layer-7-load-balancing/)
* [ELB监听器配置](http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html)

## 反向代理（网页服务器）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n41Azff.png">
  <br/>
  <i><a href=https://upload.wikimedia.org/wikipedia/commons/6/67/Reverse_proxy_h2g2bob.svg>来源：维基百科</a></i>
  <br/>
</p>

反向代理是一种网络服务器，它集中管理内部服务并向公众提供统一接口。客户端的请求被转发到能够处理该请求的服务器，反向代理再将服务器的响应返回给客户端。

额外的好处包括：

* **增强安全性** - 隐藏后端服务器的信息，黑名单IP，限制每个客户端的连接数
* **提高可扩展性和灵活性** - 客户端只看到反向代理的IP，允许您扩展服务器或更改其配置
* **SSL终止** - 解密传入请求并加密服务器响应，使后端服务器无需执行这些可能代价高昂的操作
    * 免去在每台服务器上安装[X.509证书](https://en.wikipedia.org/wiki/X.509)的需求
* **压缩** - 压缩服务器响应
* **缓存** - 返回缓存请求的响应
* **静态内容** - 直接提供静态内容
    * HTML/CSS/JS
    * 图片
    * 视频
    * 等等

### 负载均衡器与反向代理

* 当您拥有多台服务器时，部署负载均衡器非常有用。负载均衡器通常将流量路由到执行相同功能的一组服务器。
* 即使只有一台Web服务器或应用服务器，反向代理也可能有用，可以带来上一节描述的好处。
* 诸如NGINX和HAProxy等解决方案支持第7层反向代理和负载均衡。

### 缺点：反向代理

* 引入反向代理会增加复杂性。
* 单个反向代理是单点故障，配置多个反向代理（即[故障转移](https://en.wikipedia.org/wiki/Failover)）会进一步增加复杂性。

### 来源及进一步阅读

* [反向代理与负载均衡器](https://www.nginx.com/resources/glossary/reverse-proxy-vs-load-balancer/)
* [NGINX架构](https://www.nginx.com/blog/inside-nginx-how-we-designed-for-performance-scale/)
* [HAProxy架构指南](http://www.haproxy.org/download/1.2/doc/architecture.txt)
* [维基百科](https://en.wikipedia.org/wiki/Reverse_proxy)

## 应用层

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yB5SYwm.png">
  <br/>

  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>来源：架构可扩展系统简介</a></i>
</p>

将 Web 层与应用层（也称为平台层）分离，可以让你独立地扩展和配置这两个层。添加新的 API 会导致添加应用服务器，而不一定需要增加额外的 Web 服务器。**单一职责原则**主张构建小型且自治的服务协同工作。拥有小团队和小服务可以更积极地规划快速增长。

应用层的工作者还帮助实现了[异步](#asynchronism)。

### 微服务

与此相关的是[微服务](https://en.wikipedia.org/wiki/Microservices)，它可以被描述为一套独立部署的小型模块化服务。每个服务运行一个独特的进程，并通过一个定义良好、轻量级的机制进行通信，以实现业务目标。<sup><a href=https://smartbear.com/learn/api-design/what-are-microservices>1</a></sup>

例如，Pinterest 可能有以下微服务：用户资料、关注者、动态、搜索、照片上传等。

### 服务发现

诸如[Consul](https://www.consul.io/docs/index.html)、[Etcd](https://coreos.com/etcd/docs/latest)和[Zookeeper](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)等系统可以帮助服务通过跟踪注册的名称、地址和端口找到彼此。[健康检查](https://www.consul.io/intro/getting-started/checks.html)帮助验证服务完整性，通常通过[HTTP](#hypertext-transfer-protocol-http)端点完成。Consul 和 Etcd 都内置了[key-value 存储](#key-value-store)，这对于存储配置值和其他共享数据很有用。

### 缺点：应用层

* 添加一个具有松耦合服务的应用层，从架构、运维和流程视角来看需要不同的方法（相较于单体系统）。
* 微服务在部署和运维方面可能增加复杂性。

### 来源及进一步阅读

* [架构可扩展系统简介](http://lethain.com/introduction-to-architecting-systems-for-scale)
* [攻克系统设计面试](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [面向服务架构](https://en.wikipedia.org/wiki/Service-oriented_architecture)
* [Zookeeper 简介](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper)
* [构建微服务你需要知道的](https://cloudncode.wordpress.com/2016/07/22/msa-getting-started/)

## 数据库

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Xkm5CXz.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>来源：扩展到第一个一千万用户</a></i>
</p>

### 关系型数据库管理系统（RDBMS）

关系型数据库如 SQL 是以表格形式组织的数据项集合。

**ACID** 是关系型数据库[事务](https://en.wikipedia.org/wiki/Database_transaction)的一组属性。

* **原子性** - 每个事务要么全部完成，要么全部不做
* **一致性** - 任何事务都会将数据库从一个有效状态带到另一个有效状态
* **隔离性** - 并发执行事务的结果与串行执行事务的结果相同
* **持久性** - 一旦事务提交，其结果将永久保留

有许多技术可以扩展关系型数据库：**主从复制**、**主主复制**、**联合**、**分片**、**反范式设计**和**SQL 调优**。

#### 主从复制

主节点处理读写操作，将写操作复制到一个或多个从节点，从节点仅处理读操作。从节点也可以以树状结构复制到其他从节点。如果主节点离线，系统可以继续以只读模式运行，直到从节点被提升为主节点或新主节点被配置。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/C9ioGtn.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>来源：可扩展性、可用性、稳定性模式</a></i>
</p>

##### 缺点：主从复制

* 需要额外逻辑来将从节点提升为主节点。
* 有关**主从**和**主主**复制的相关点，请参见[缺点：复制](#disadvantages-replication)。

#### 主主复制

两个主节点都处理读写操作，并在写操作上相互协调。如果任一主节点宕机，系统仍可继续进行读写操作。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/krAHLGg.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>来源：可扩展性、可用性、稳定性模式</a></i>
</p>

##### 缺点：主主复制

* 你需要负载均衡器，或者需要修改应用逻辑以确定写入位置。
* 大多数主主系统要么是弱一致的（违反 ACID），要么由于同步导致写延迟增加。
* 随着写节点的增加和延迟的提高，冲突解决变得更加重要。
* 有关**主从**和**主主**复制相关的问题，请参见[缺点：复制](#disadvantages-replication)。

##### 缺点：复制

* 如果主节点在新写入数据复制到其他节点之前失败，可能会导致数据丢失。
* 写入操作会被重放到只读副本。如果写入量很大，只读副本可能会因重放写入而变得繁忙，导致读取能力下降。
* 只读从库越多，需要复制的数据越多，从而导致更大的复制延迟。
* 在某些系统中，写入主库可以生成多个线程并行写入，而只读副本仅支持单线程顺序写入。
* 复制增加了更多的硬件需求和额外的复杂性。

##### 复制的来源和进一步阅读

* [可扩展性、可用性、稳定性及模式](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [多主复制](https://en.wikipedia.org/wiki/Multi-master_replication)

#### 联邦

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/U3qV33e.png">
  <br/>
  <i><a href=https://www.youtube.com/watch?v=kKjm4ehYiMs>来源：扩展到你的第一个1000万用户</a></i>
</p>

联邦（或功能分区）按功能划分数据库。例如，不使用单一的整体数据库，而是拥有三个数据库：**论坛**、**用户**和**产品**，从而减少每个数据库的读写流量，降低复制延迟。较小的数据库意味着更多数据可以放入内存，进而因缓存局部性改进而提高缓存命中率。没有单一的中央主节点串行写入，写入可以并行进行，提高吞吐量。

##### 联邦的缺点

* 如果你的模式需要庞大的函数或表，联邦效果不佳。
* 你需要更新应用逻辑来确定读写哪个数据库。
* 从两个数据库联合查询数据更复杂，需使用[服务器链接](http://stackoverflow.com/questions/5145637/querying-data-by-joining-two-tables-in-two-database-on-different-servers)。
* 联邦增加了更多的硬件需求和额外的复杂性。

##### 联邦的来源和进一步阅读

* [扩展到你的第一个1000万用户](https://www.youtube.com/watch?v=kKjm4ehYiMs)

#### 分片

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wU8x5Id.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>来源：可扩展性、可用性、稳定性、模式</a></i>
</p>

分片（Sharding）将数据分布到不同的数据库中，使得每个数据库只能管理数据的一个子集。以用户数据库为例，随着用户数量的增加，集群中会添加更多的分片。

与[联合](#federation)的优点类似，分片带来更少的读写流量、更少的复制以及更多的缓存命中。索引大小也减少，通常这能提升性能，加快查询速度。如果某个分片宕机，其他分片仍然可以正常工作，不过你需要添加某种复制机制以避免数据丢失。像联合一样，没有单一中央主库来串行化写操作，允许你并行写入，提高吞吐量。

常见的用户表分片方式是通过用户的姓氏首字母或用户的地理位置。

##### 缺点：分片

* 你需要更新应用逻辑以支持分片，这可能导致复杂的 SQL 查询。
* 数据分布在分片中可能不均衡。例如，某个分片上的一组高频用户可能导致该分片负载增加，超过其他分片。
    * 重新平衡会增加额外复杂性。基于[一致性哈希](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)的分片函数可以减少传输的数据量。
* 跨多个分片连接数据更复杂。
* 分片增加了更多硬件需求和额外复杂性。

##### 来源及扩展阅读：分片

* [分片的到来](http://highscalability.com/blog/2009/8/6/an-unorthodox-approach-to-database-design-the-coming-of-the.html)
* [分片数据库架构](https://en.wikipedia.org/wiki/Shard_(database_architecture))
* [一致性哈希](http://www.paperplanes.de/2011/12/9/the-magic-of-consistent-hashing.html)

#### 反规范化

反规范化试图以牺牲部分写性能为代价来提升读性能。在多个表中写入冗余数据副本以避免昂贵的连接操作。一些关系型数据库管理系统（如[PostgreSQL](https://en.wikipedia.org/wiki/PostgreSQL)和Oracle）支持[物化视图](https://en.wikipedia.org/wiki/Materialized_view)，它们负责存储冗余信息并保持副本一致。

一旦数据通过[联合](#federation)和[分片](#sharding)等技术分布开来，跨数据中心管理连接操作的复杂性进一步增加。反规范化可能避免了这种复杂连接的需求。

在大多数系统中，读操作远远多于写操作，比例可能达到100:1甚至1000:1。一次复杂的数据库连接查询可能非常昂贵，花费大量时间在磁盘操作上。

##### 缺点：反规范化

* 数据被复制。
* 约束可以帮助冗余信息保持同步，但这增加了数据库设计的复杂性。
* 在写负载较重时，反规范化的数据库性能可能不如其规范化的对应版本。

###### 来源及扩展阅读：反规范化

* [反规范化](https://en.wikipedia.org/wiki/Denormalization)

#### SQL 调优

SQL 调优是一个广泛的话题，已经有许多[书籍](https://www.amazon.com/s/ref=nb_sb_noss_2?url=search-alias%3Daps&field-keywords=sql+tuning)作为参考。

进行**基准测试**和**性能分析**来模拟并发现瓶颈非常重要。

* **基准测试** - 使用如 [ab](http://httpd.apache.org/docs/2.2/programs/ab.html) 等工具模拟高负载情况。
* **性能分析** - 启用如 [慢查询日志](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html) 等工具帮助跟踪性能问题。

基准测试和性能分析可能会指引您进行以下优化。

##### 收紧数据库模式

* MySQL 将数据以连续块写入磁盘以实现快速访问。
* 对于固定长度字段使用 `CHAR` 替代 `VARCHAR`。
    * `CHAR` 实际上允许快速随机访问，而使用 `VARCHAR` 时必须找到字符串结尾后才能访问下一个。
* 对于大块文本如博客文章使用 `TEXT`。 `TEXT` 也支持布尔搜索。使用 `TEXT` 字段会在磁盘上存储一个指针，用于定位文本块。
* 对于最大可达 2^32 或 40 亿的大数字，使用 `INT`。
* 使用 `DECIMAL` 存储货币，以避免浮点表示错误。
* 避免存储大 `BLOB`，改为存储对象位置。
* `VARCHAR(255)` 是 8 位数字能计数的最大字符数，通常在某些关系数据库中最大化一个字节的使用。
* 在适用情况下设置 `NOT NULL` 约束以[提升搜索性能](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)。

##### 使用合适的索引

* 查询的列（`SELECT`、`GROUP BY`、`ORDER BY`、`JOIN`）使用索引可以更快。
* 索引通常表现为自平衡的[B树](https://en.wikipedia.org/wiki/B-tree)，保持数据排序，允许对数时间的搜索、顺序访问、插入和删除。
* 建立索引会占用更多内存空间。
* 写入速度可能变慢，因为索引也需要更新。
* 加载大量数据时，禁用索引加载数据然后重建索引可能更快。

##### 避免昂贵的连接

* 在性能要求高时进行[反规范化](#denormalization)。

##### 分区表

* 通过将热点数据放入单独的表中来拆分表，以帮助保持其在内存中的状态。

##### 调优查询缓存

* 在某些情况下，[查询缓存](https://dev.mysql.com/doc/refman/5.7/en/query-cache.html)可能导致[性能问题](https://www.percona.com/blog/2016/10/12/mysql-5-7-performance-tuning-immediately-after-installation/)。

##### 来源及进一步阅读：SQL调优

* [优化MySQL查询的技巧](http://aiddroid.com/10-tips-optimizing-mysql-queries-dont-suck/)
* [为什么VARCHAR(255)这么常用，有合理的原因吗？](http://stackoverflow.com/questions/1217466/is-there-a-good-reason-i-see-varchar255-used-so-often-as-opposed-to-another-l)
* [空值如何影响性能？](http://stackoverflow.com/questions/1017239/how-do-null-values-affect-performance-in-a-database-search)
* [慢查询日志](http://dev.mysql.com/doc/refman/5.7/en/slow-query-log.html)

### NoSQL

NoSQL 是一组以**键值存储**、**文档存储**、**宽列存储**或**图数据库**形式表示的数据项。数据是非规范化的，连接通常在应用代码中完成。大多数 NoSQL 存储缺乏真正的 ACID 事务，偏向于[最终一致性](#eventual-consistency)。

**BASE** 常用来描述 NoSQL 数据库的特性。与[CAP 定理](#cap-theorem)相比，BASE 选择可用性而非一致性。

* **基本可用** - 系统保证可用性。
* **软状态** - 系统状态可能随时间变化，即使没有输入。
* **最终一致性** - 系统将在一段时间内变为一致，前提是在此期间系统未接收输入。

除了在[SQL或NoSQL](#sql-or-nosql)之间选择外，了解哪种类型的 NoSQL 数据库最适合您的用例也很有帮助。我们将在下一节回顾**键值存储**、**文档存储**、**宽列存储**和**图数据库**。

#### 键值存储

> 抽象：哈希表

键值存储通常允许 O(1) 的读写，通常由内存或 SSD 支持。数据存储可以保持键的[字典序](https://en.wikipedia.org/wiki/Lexicographical_order)，从而高效检索键范围。键值存储可以允许与值一起存储元数据。

键值存储提供高性能，常用于简单数据模型或快速变化的数据，如内存缓存层。由于它们仅提供有限的操作集，若需要额外操作，复杂性将转移到应用层。

键值存储是更复杂系统的基础，例如文档存储，某些情况下也是图数据库。

##### 来源及进一步阅读：键值存储

* [键值数据库](https://en.wikipedia.org/wiki/Key-value_database)
* [键值存储的缺点](http://stackoverflow.com/questions/4056093/what-are-the-disadvantages-of-using-a-key-value-table-over-nullable-columns-or)
* [Redis 架构概述](http://qnimate.com/overview-of-redis-architecture/)
* [Memcached 架构](https://adayinthelifeof.nl/2011/02/06/memcache-internals/)

#### 文档存储

> 抽象：键值存储，文档作为值存储

文档存储以文档（XML、JSON、二进制等）为中心，文档存储给定对象的所有信息。文档存储提供基于文档内部结构的 API 或查询语言进行查询。*注意，许多键值存储包含处理值元数据的功能，模糊了这两种存储类型之间的界限。*

根据底层实现，文档通过集合、标签、元数据或目录进行组织。尽管文档可以被组织或分组，但文档的字段可能彼此完全不同。

一些文档存储如 [MongoDB](https://www.mongodb.com/mongodb-architecture) 和 [CouchDB](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/) 也提供类似 SQL 的语言来执行复杂查询。[DynamoDB](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) 同时支持键值和文档。

文档存储提供高度灵活性，常用于处理偶尔变更的数据。

##### 来源及进一步阅读：文档存储

* [面向文档的数据库](https://en.wikipedia.org/wiki/Document-oriented_database)
* [MongoDB 架构](https://www.mongodb.com/mongodb-architecture)
* [CouchDB 架构](https://blog.couchdb.org/2016/08/01/couchdb-2-0-architecture/)
* [Elasticsearch 架构](https://www.elastic.co/blog/found-elasticsearch-from-the-bottom-up)

#### 宽列存储

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/n16iOGk.png">
  <br/>
  <i><a href=http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html>来源：SQL & NoSQL，简史</a></i>
</p>

> 抽象：嵌套映射 `ColumnFamily<RowKey, Columns<ColKey, Value, Timestamp>>`

宽列存储的数据基本单元是列（名称/值对）。列可以分组到列族中（类似于 SQL 表）。超级列族进一步对列族进行分组。您可以通过行键独立访问每个列，具有相同行键的列组成一行。每个值包含时间戳，用于版本控制和冲突解决。

Google 推出了 [Bigtable](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) 作为首个宽列存储，影响了开源的 [HBase](https://www.edureka.co/blog/hbase-architecture/)（常用于 Hadoop 生态系统）和 Facebook 的 [Cassandra](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)。BigTable、HBase 和 Cassandra 等存储按字典序维护键，支持高效检索特定键范围。

宽列存储提供高可用性和高扩展性，常用于超大数据集。

##### 来源及进一步阅读：宽列存储

* [SQL & NoSQL，简史](http://blog.grio.com/2015/11/sql-nosql-a-brief-history.html)
* [Bigtable 架构](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf)
* [HBase 架构](https://www.edureka.co/blog/hbase-architecture/)
* [Cassandra 架构](http://docs.datastax.com/en/cassandra/3.0/cassandra/architecture/archIntro.html)

#### 图数据库

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/fNcl65g.png">
  <br/>
  <i><a href=https://en.wikipedia.org/wiki/File:GraphDatabase_PropertyGraph.png>来源：图数据库</a></i>
</p>

> 抽象：图

在图数据库中，每个节点是一个记录，每条弧是两个节点之间的关系。图数据库针对具有许多外键或多对多关系的复杂关系进行了优化。

图数据库为具有复杂关系的数据模型（如社交网络）提供高性能。它们相对较新，尚未被广泛使用；可能更难找到开发工具和资源。许多图只能通过[REST API](#representational-state-transfer-rest)访问。

##### 来源及进一步阅读：图

* [图数据库](https://en.wikipedia.org/wiki/Graph_database)
* [Neo4j](https://neo4j.com/)
* [FlockDB](https://blog.twitter.com/2010/introducing-flockdb)

#### 来源及进一步阅读：NoSQL

* [BASE 术语解释](http://stackoverflow.com/questions/3342497/explanation-of-base-terminology)
* [NoSQL 数据库调查与决策指导](https://medium.com/baqend-blog/nosql-databases-a-survey-and-decision-guidance-ea7823a822d#.wskogqenq)
* [可扩展性](https://web.archive.org/web/20220602114024/https://www.lecloud.net/post/7994751381/scalability-for-dummies-part-2-database)
* [NoSQL 入门](https://www.youtube.com/watch?v=qI_g07C_Q5I)
* [NoSQL 模式](http://horicky.blogspot.com/2009/11/nosql-patterns.html)

### SQL 或 NoSQL

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/wXGqG5f.png">
  <br/>
  <i><a href=https://www.infoq.com/articles/Transition-RDBMS-NoSQL/>来源：从关系型数据库到 NoSQL 的转变</a></i>
</p>

**SQL** 的原因：

* 结构化数据  
* 严格的模式  
* 关系型数据  
* 需要复杂的连接  
* 事务处理  
* 清晰的扩展模式  
* 更加成熟：开发者、社区、代码、工具等  
* 通过索引查找非常快  

**NoSQL** 的原因：

* 半结构化数据  
* 动态或灵活的模式  
* 非关系型数据  
* 无需复杂的连接  
* 存储大量 TB（或 PB）级数据  
* 高度数据密集型工作负载  
* 极高的 IOPS 吞吐量  

适合 NoSQL 的示例数据：

* 快速摄取点击流和日志数据  
* 排行榜或评分数据  
* 临时数据，如购物车  
* 频繁访问的（“热”）表  
* 元数据/查找表  

##### 来源及进一步阅读：SQL 或 NoSQL

* [扩展到你的第一个 1000 万用户](https://www.youtube.com/watch?v=kKjm4ehYiMs)  
* [SQL 与 NoSQL 的区别](https://www.sitepoint.com/sql-vs-nosql-differences/)  

## 缓存

<p align="center">  
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/Q6z24La.png">  
  <br/>  
  <i><a href=http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html>来源：可扩展系统设计模式</a></i>
</p>

缓存可以提高页面加载速度，并减少服务器和数据库的负载。在此模型中，调度器会首先查找请求是否已被处理过，尝试找到之前的结果返回，以节省实际执行的时间。

数据库通常受益于跨分区的读写均匀分布。热门项目可能会导致分布不均，造成瓶颈。在数据库前放置缓存可以帮助吸收不均匀的负载和流量峰值。

### 客户端缓存

缓存可以位于客户端（操作系统或浏览器）、[服务器端](#reverse-proxy-web-server)或独立的缓存层。

### CDN 缓存

[内容分发网络（CDN）](#content-delivery-network)被视为一种缓存。

### Web 服务器缓存

[反向代理](#reverse-proxy-web-server)和如 [Varnish](https://www.varnish-cache.org/) 等缓存可以直接提供静态和动态内容。Web 服务器也可以缓存请求，返回响应而无需联系应用服务器。

### 数据库缓存

数据库通常在默认配置中包含一定程度的缓存，针对通用使用场景进行优化。针对特定使用模式调整这些设置可以进一步提升性能。

### 应用缓存

内存缓存如 Memcached 和 Redis 是应用与数据存储之间的键值存储。由于数据存储在内存中，比典型的基于磁盘存储的数据库更快。内存容量有限，因此[缓存失效](https://en.wikipedia.org/wiki/Cache_algorithms)算法如[最近最少使用（LRU）](https://en.wikipedia.org/wiki/Cache_replacement_policies#Least_recently_used_(LRU))可以帮助失效“冷”条目，保持“热”数据在内存中。

Redis 具有以下额外功能：

* 持久化选项
* 内置数据结构，如有序集合和列表

缓存可以存在多个层级，归于两大类：**数据库查询**和**对象**：

* 行级缓存
* 查询级缓存
* 完整可序列化对象缓存
* 完整渲染的 HTML 缓存

通常，应尽量避免基于文件的缓存，因为这会增加克隆和自动扩展的难度。

### 数据库查询级别的缓存

每当查询数据库时，将查询哈希作为键并将结果存储到缓存中。此方法存在过期问题：

* 对于复杂查询，很难删除缓存结果
* 如果某个数据发生变化（如表中的某个单元格），需要删除所有可能包含该变化单元格的缓存查询

### 对象级别的缓存

将数据视为对象，类似于应用程序代码的处理方式。让应用程序将数据库中的数据集组装成类实例或数据结构：

* 如果底层数据发生变化，则从缓存中移除该对象
* 支持异步处理：工作线程通过消费最新缓存对象来组装对象

建议缓存的内容：

* 用户会话
* 完全渲染的网页
* 活动流
* 用户图数据

### 何时更新缓存

由于缓存中只能存储有限的数据，需要确定哪种缓存更新策略最适合您的用例。

#### Cache-aside

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/ONjORqk.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>来源：从缓存到内存数据网格简介</a></i>
</p>

应用程序负责从存储中读取和写入。缓存不直接与存储交互。应用程序执行以下操作：

* 在缓存中查找条目，导致缓存未命中
* 从数据库加载条目
* 将条目添加到缓存
* 返回条目

```python
def get_user(self, user_id):
    user = cache.get("user.{0}", user_id)
    if user is None:
        user = db.query("SELECT * FROM users WHERE user_id = {0}", user_id)
        if user is not None:
            key = "user.{0}".format(user_id)
            cache.set(key, json.dumps(user))
    return user
```
[Memcached](https://memcached.org/) 通常以这种方式使用。

随后的缓存数据读取速度很快。Cache-aside 也称为懒加载。仅缓存被请求的数据，避免缓存被未请求的数据填满。

##### 缺点：cache-aside

* 每次缓存未命中都会导致三次往返，可能引起明显延迟。
* 如果数据库中的数据被更新，缓存数据可能变得过时。该问题通过设置生存时间（TTL）来强制更新缓存条目，或使用写直达方式来缓解。
* 当节点失败时，会被一个新的空节点替换，增加了延迟。

#### 写直达（Write-through）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/0vBc0hN.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>来源：可扩展性、可用性、稳定性模式</a></i>
</p>

应用程序将缓存作为主要数据存储，读写数据时都操作缓存，缓存负责读写数据库：

* 应用程序添加/更新缓存条目
* 缓存同步写入数据存储
* 返回

应用程序代码：


```python
set_user(12345, {"foo":"bar"})
```
缓存代码：


```python
def set_user(user_id, values):
    user = db.query("UPDATE Users WHERE id = {0}", user_id, values)
    cache.set(user_id, user)
```
写入直达（Write-through）由于写操作而整体较慢，但随后读取刚写入的数据速度很快。用户在更新数据时通常对延迟更为容忍，而读取数据时则不然。缓存中的数据不会过时。

##### 缺点：写入直达

* 当由于故障或扩容创建新节点时，直到数据库中条目被更新，新节点才会缓存条目。写入直达配合缓存旁路（Cache-aside）可以缓解此问题。
* 大部分写入的数据可能永远不会被读取，可以通过设置TTL（生存时间）来最小化这种情况。

#### 写入回写（Write-behind / Write-back）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/rgSrvjG.png">
  <br/>
  <i><a href=http://www.slideshare.net/jboner/scalability-availability-stability-patterns/>来源：可扩展性、可用性、稳定性模式</a></i>
</p>

在写入回写中，应用程序执行以下操作：

* 在缓存中添加/更新条目
* 异步将条目写入数据存储，从而提升写入性能

##### 缺点：写入回写

* 如果缓存宕机且内容尚未写入数据存储，可能会导致数据丢失。
* 实现写入回写比实现缓存旁路或写入直达更复杂。

#### 预刷新（Refresh-ahead）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/kxtjqgE.png">
  <br/>
  <i><a href=http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast>来源：从缓存到内存数据网格</a></i>
</p>

您可以配置缓存，在条目过期前自动刷新任何最近访问的缓存条目。

如果缓存能够准确预测未来可能需要的条目，预刷新相比读取穿透可以减少延迟。

##### 缺点：预刷新


* 不准确地预测未来可能需要的项目可能导致性能不如没有预刷新时的表现。

### 缺点：缓存

* 需要通过[缓存失效](https://zh.wikipedia.org/wiki/缓存算法)来保持缓存与数据源（如数据库）之间的一致性。
* 缓存失效是一个难题，何时更新缓存存在额外的复杂性。
* 需要进行应用改动，如添加 Redis 或 memcached。

### 来源及进一步阅读

* [从缓存到内存数据网格](http://www.slideshare.net/tmatyashovsky/from-cache-to-in-memory-data-grid-introduction-to-hazelcast)
* [可扩展系统设计模式](http://horicky.blogspot.com/2010/10/scalable-system-design-patterns.html)
* [系统架构扩展简介](http://lethain.com/introduction-to-architecting-systems-for-scale/)
* [可扩展性、可用性、稳定性模式](http://www.slideshare.net/jboner/scalability-availability-stability-patterns/)
* [可扩展性](https://web.archive.org/web/20230126233752/https://www.lecloud.net/post/9246290032/scalability-for-dummies-part-3-cache)
* [AWS ElastiCache 策略](http://docs.aws.amazon.com/AmazonElastiCache/latest/UserGuide/Strategies.html)
* [维基百科](https://zh.wikipedia.org/wiki/Cache_(computing))

## 异步性

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/54GYsSx.png">
  <br/>
  <i><a href=http://lethain.com/introduction-to-architecting-systems-for-scale/#platform_layer>来源：系统架构扩展简介</a></i>
</p>

异步工作流有助于减少对昂贵操作的请求时间，这些操作本来会同步执行。它们还可以通过提前完成耗时工作（如定期数据聚合）来发挥作用。

### 消息队列

消息队列用于接收、存储和传递消息。如果操作太慢无法同步执行，可以使用消息队列，流程如下：

* 应用将任务发布到队列，然后通知用户任务状态
* 工作线程从队列获取任务，处理后标记任务完成

用户不会被阻塞，任务在后台处理。此期间，客户端可以执行少量处理，使任务看起来已完成。例如，发送推文时，推文可以立即显示在时间线上，但实际传递给所有关注者可能需要一些时间。

**[Redis](https://redis.io/)** 是一个简单的消息代理，但消息可能丢失。

**[RabbitMQ](https://www.rabbitmq.com/)** 很受欢迎，但需要适应 'AMQP' 协议并自行管理节点。

**[Amazon SQS](https://aws.amazon.com/sqs/)** 是托管服务，但可能存在高延迟，并且消息可能会被重复传递。

### 任务队列

任务队列接收任务及其相关数据，执行任务，然后传递结果。它们支持调度，可用于在后台运行计算密集型作业。

**[Celery](https://docs.celeryproject.org/en/stable/)** 支持调度，主要支持 Python。

### 背压

如果队列开始显著增长，队列大小可能超过内存，导致缓存未命中、磁盘读取，甚至性能更慢。[背压](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html) 通过限制队列大小来帮助维持高吞吐率和队列中作业的良好响应时间。一旦队列满了，客户端会收到服务器繁忙或 HTTP 503 状态码，提示稍后重试。客户端可以在稍后时间重试请求，可能采用[指数退避](https://en.wikipedia.org/wiki/Exponential_backoff)。

### 缺点：异步性

* 诸如廉价计算和实时工作流的用例可能更适合同步操作，因为引入队列会增加延迟和复杂性。

### 来源及进一步阅读

* [这全是数字游戏](https://www.youtube.com/watch?v=1KRYH75wgy4)
* [过载时应用背压](http://mechanical-sympathy.blogspot.com/2012/05/apply-back-pressure-when-overloaded.html)
* [Little 法则](https://en.wikipedia.org/wiki/Little%27s_law)
* [消息队列和任务队列的区别是什么？](https://www.quora.com/What-is-the-difference-between-a-message-queue-and-a-task-queue-Why-would-a-task-queue-require-a-message-broker-like-RabbitMQ-Redis-Celery-or-IronMQ-to-function)

## 通信

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/5KeocQs.jpg">
  <br/>
  <i><a href=http://www.escotal.com/osilayer.html>来源：OSI 七层模型</a></i>
</p>

### 超文本传输协议 (HTTP)

HTTP 是一种在客户端和服务器之间编码和传输数据的方法。它是一种请求/响应协议：客户端发出请求，服务器发出包含相关内容和请求完成状态信息的响应。HTTP 是自包含的，允许请求和响应通过执行负载均衡、缓存、加密和压缩的多个中间路由器和服务器。

一个基本的 HTTP 请求由动词（方法）和资源（端点）组成。以下是常见的 HTTP 动词：

| 动词 | 描述 | 幂等* | 安全 | 可缓存 |
|---|---|---|---|---|
| GET | 读取资源 | 是 | 是 | 是 |
| POST | 创建资源或触发处理数据的进程 | 否 | 否 | 如果响应包含新鲜度信息，则是 |
| PUT | 创建或替换资源 | 是 | 否 | 否 |
| PATCH | 部分更新资源 | 否 | 否 | 如果响应包含新鲜度信息，则是 |
| DELETE | 删除资源 | 是 | 否 | 否 |

* 可以多次调用而不会产生不同的结果。

HTTP 是一种应用层协议，依赖于诸如 **TCP** 和 **UDP** 之类的底层协议。

#### 来源及进一步阅读：HTTP

* [什么是 HTTP？](https://www.nginx.com/resources/glossary/http/)
* [HTTP 和 TCP 的区别](https://www.quora.com/What-is-the-difference-between-HTTP-protocol-and-TCP-protocol)
* [PUT 与 PATCH 的区别](https://laracasts.com/discuss/channels/general-discussion/whats-the-differences-between-put-and-patch?page=1)

### 传输控制协议（TCP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/JdAsdvG.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>来源：如何制作多人游戏</a></i>
</p>

TCP 是基于 [IP 网络](https://en.wikipedia.org/wiki/Internet_Protocol) 的面向连接的协议。连接通过 [握手](https://en.wikipedia.org/wiki/Handshaking) 建立和终止。所有发送的数据包都保证以原始顺序且无损坏地到达目的地，通过：

* 每个数据包的序列号和 [校验和字段](https://en.wikipedia.org/wiki/Transmission_Control_Protocol#Checksum_computation)
* [确认](https://en.wikipedia.org/wiki/Acknowledgement_(data_networks)) 数据包和自动重传

如果发送方没有收到正确响应，它将重新发送数据包。如果多次超时，连接将被断开。TCP 还实现了 [流量控制](https://en.wikipedia.org/wiki/Flow_control_(data)) 和 [拥塞控制](https://en.wikipedia.org/wiki/Network_congestion#Congestion_control)。这些保障会导致延迟，并且通常比 UDP 传输效率低。

为了确保高吞吐量，Web 服务器可以保持大量 TCP 连接打开，导致高内存使用。在 Web 服务器线程与例如 [memcached](https://memcached.org/) 服务器之间保持大量打开连接可能代价高昂。除了在适用情况下切换到 UDP，使用 [连接池](https://en.wikipedia.org/wiki/Connection_pool) 也能有所帮助。

TCP 适用于需要高可靠性但对时间要求不高的应用。一些例子包括 Web 服务器、数据库信息、SMTP、FTP 和 SSH。

在以下情况下使用 TCP 而非 UDP：

* 你需要所有数据完整无损地到达
* 你希望自动尽可能高效地利用网络吞吐量

### 用户数据报协议（UDP）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/yzDrJtA.jpg">
  <br/>
  <i><a href=http://www.wildbunny.co.uk/blog/2012/10/09/how-to-make-a-multi-player-game-part-1/>来源：如何制作多人游戏</a></i>
</p>

UDP 是无连接的。数据报（类似于数据包）仅在数据报级别被保证。数据报可能乱序到达目的地，甚至根本无法到达。UDP 不支持拥塞控制。由于缺乏 TCP 提供的保证，UDP 通常更高效。

UDP 可以广播，向子网内所有设备发送数据报。这在 [DHCP](https://zh.wikipedia.org/wiki/动态主机配置协议) 中非常有用，因为客户端尚未收到 IP 地址，因此 TCP 无法在没有 IP 地址的情况下进行流传输。

UDP 可靠性较低，但在 VoIP、视频聊天、流媒体和实时多人游戏等实时应用中表现良好。

在以下情况下使用 UDP 而非 TCP：

* 你需要最低的延迟
* 延迟的数据比数据丢失更糟
* 你想实现自己的错误纠正

#### 来源及进一步阅读：TCP 和 UDP

* [游戏编程的网络](http://gafferongames.com/networking-for-game-programmers/udp-vs-tcp/)
* [TCP 和 UDP 协议的主要区别](http://www.cyberciti.biz/faq/key-differences-between-tcp-and-udp-protocols/)
* [TCP 和 UDP 的区别](http://stackoverflow.com/questions/5970383/difference-between-tcp-and-udp)
* [传输控制协议](https://zh.wikipedia.org/wiki/传输控制协议)
* [用户数据报协议](https://zh.wikipedia.org/wiki/用户数据报协议)
* [Facebook 的 memcache 扩展](http://www.cs.bu.edu/~jappavoo/jappavoo.github.com/451/papers/memcache-fb.pdf)

### 远程过程调用（RPC）

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/iF4Mkb5.png">
  <br/>
  <i><a href=http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview>来源：破解系统设计面试</a></i>
</p>

在 RPC 中，客户端使一个过程在不同的地址空间上执行，通常是远程服务器。该过程的编码方式就像本地过程调用一样，抽象了如何与服务器通信的细节，客户端程序无需关心。远程调用通常比本地调用更慢且不那么可靠，因此区分 RPC 调用和本地调用是有帮助的。流行的 RPC 框架包括 [Protobuf](https://developers.google.com/protocol-buffers/)、[Thrift](https://thrift.apache.org/) 和 [Avro](https://avro.apache.org/docs/current/)。

RPC 是一种请求-响应协议：

* **客户端程序** - 调用客户端存根过程。参数像本地过程调用一样被压入堆栈。
* **客户端存根过程** - 将过程ID和参数封装（打包）到请求消息中。
* **客户端通信模块** - 操作系统将消息从客户端发送到服务器。
* **服务器通信模块** - 操作系统将接收到的数据包传递给服务器存根过程。
* **服务器存根过程** - 解封（解包）结果，调用与过程ID匹配的服务器过程并传递给定的参数。
* 服务器响应按照上述步骤的逆序重复执行。

示例RPC调用：

```
GET /someoperation?data=anId

POST /anotheroperation
{
  "data":"anId";
  "anotherdata": "another value"
}
```
RPC 专注于暴露行为。RPC 通常用于内部通信以提升性能，因为你可以手工编写本地调用以更好地适应你的用例。

选择本地库（即 SDK）时：

* 你知道你的目标平台。
* 你想控制你的“逻辑”如何被访问。
* 你想控制库外的错误控制方式。
* 性能和最终用户体验是你的主要关注点。

遵循 **REST** 的 HTTP API 更常用于公共 API。

#### 缺点：RPC

* RPC 客户端与服务实现紧密耦合。
* 每个新操作或用例都必须定义新的 API。
* 调试 RPC 可能很困难。
* 你可能无法开箱即用地利用现有技术。例如，可能需要额外工作来确保 [RPC 调用被适当缓存](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/) 于如 [Squid](http://www.squid-cache.org/) 等缓存服务器上。

### 表现层状态转移 (REST)

REST 是一种架构风格，强制执行客户端/服务器模型，其中客户端对服务器管理的一组资源进行操作。服务器提供资源的表现形式和可以操作或获取新资源表现形式的动作。所有通信必须是无状态且可缓存的。

RESTful 接口有四个特性：

* **识别资源（HTTP 中的 URI）** - 无论任何操作，使用相同的 URI。
* **通过表现形式改变（HTTP 中的动词）** - 使用动词、头部和主体。
* **自描述错误信息（HTTP 中的状态响应）** - 使用状态码，不要重新发明轮子。
* **[HATEOAS](http://restcookbook.com/Basics/hateoas/)（HTTP 的 HTML 界面）** - 你的 Web 服务应可在浏览器中完全访问。

REST 调用示例：


```
GET /someresources/anId

PUT /someresources/anId
{"anotherdata": "another value"}
```
REST 专注于数据的暴露。它最大限度地减少了客户端/服务器之间的耦合，通常用于公共 HTTP API。REST 通过 URI、[通过头部的表示](https://github.com/for-GET/know-your-http-well/blob/master/headers.md) 以及通过诸如 GET、POST、PUT、DELETE 和 PATCH 之类的动词来使用更通用和统一的方法暴露资源。由于是无状态的，REST 非常适合水平扩展和分区。

#### 缺点：REST

* 由于 REST 专注于数据的暴露，如果资源本身没有自然组织或以简单的层级方式访问，可能不太适用。例如，返回过去一小时内所有符合特定事件集合的更新记录不容易用路径表达。使用 REST，通常通过 URI 路径、查询参数以及可能的请求体组合来实现。
* REST 通常依赖于少数几个动词（GET、POST、PUT、DELETE 和 PATCH），有时无法满足您的用例。例如，将过期文档移动到归档文件夹可能无法很好地适应这些动词。
* 获取具有嵌套层级的复杂资源需要客户端和服务器之间多次往返以渲染单个视图，例如获取博客条目的内容及该条目的评论。对于在不稳定网络条件下运行的移动应用，这些多次往返是非常不理想的。
* 随着时间推移，API 响应中可能会添加更多字段，旧客户端会接收所有新字段，即使它们不需要，这会导致有效载荷膨胀并增加延迟。

### RPC 和 REST 调用比较

| 操作 | RPC | REST |
|---|---|---|
| 注册    | **POST** /signup | **POST** /persons |
| 辞职    | **POST** /resign<br/>{<br/>"personid": "1234"<br/>} | **DELETE** /persons/1234 |
| 读取某人 | **GET** /readPerson?personid=1234 | **GET** /persons/1234 |
| 读取某人的物品列表 | **GET** /readUsersItemsList?personid=1234 | **GET** /persons/1234/items |
| 向某人物品列表添加物品 | **POST** /addItemToUsersItemsList<br/>{<br/>"personid": "1234";<br/>"itemid": "456"<br/>} | **POST** /persons/1234/items<br/>{<br/>"itemid": "456"<br/>} |
| 更新物品    | **POST** /modifyItem<br/>{<br/>"itemid": "456";<br/>"key": "value"<br/>} | **PUT** /items/456<br/>{<br/>"key": "value"<br/>} |
| 删除物品 | **POST** /removeItem<br/>{<br/>"itemid": "456"<br/>} | **DELETE** /items/456 |

<p align="center">
  <i><a href=https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/>来源：你真的知道为什么你更喜欢 REST 而不是 RPC 吗</a></i>
</p>

#### 来源及进一步阅读：REST 和 RPC

* [你真的知道为什么你更喜欢 REST 而不是 RPC 吗](https://apihandyman.io/do-you-really-know-why-you-prefer-rest-over-rpc/)
* [什么时候 RPC 式方法比 REST 更合适？](http://programmers.stackexchange.com/a/181186)
* [REST 与 JSON-RPC](http://stackoverflow.com/questions/15056878/rest-vs-json-rpc)
* [揭穿 RPC 和 REST 的神话](https://web.archive.org/web/20170608193645/http://etherealbits.com/2012/12/debunking-the-myths-of-rpc-rest/)
* [使用 REST 的缺点是什么](https://www.quora.com/What-are-the-drawbacks-of-using-RESTful-APIs)
* [破解系统设计面试](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)
* [Thrift](https://code.facebook.com/posts/1468950976659943/)
* [为什么内部使用 REST 而不是 RPC](http://arstechnica.com/civis/viewtopic.php?t=1190508)

## 安全

本节内容需要更新。欢迎[贡献](#contributing)！

安全是一个广泛的话题。除非你有丰富的经验、安全背景，或者申请的职位需要安全知识，否则你可能只需要了解基础知识：

* 传输和存储时加密。
* 清理所有用户输入或任何暴露给用户的输入参数，以防止[XSS](https://en.wikipedia.org/wiki/Cross-site_scripting)和[SQL注入](https://en.wikipedia.org/wiki/SQL_injection)。
* 使用参数化查询以防止SQL注入。
* 使用[最小权限原则](https://en.wikipedia.org/wiki/Principle_of_least_privilege)。

### 来源及进一步阅读

* [API安全清单](https://github.com/shieldfy/API-Security-Checklist)
* [开发者安全指南](https://github.com/FallibleInc/security-guide-for-developers)
* [OWASP十大](https://www.owasp.org/index.php/OWASP_Top_Ten_Cheat_Sheet)

## 附录

有时你会被要求做“信封背面”的估算。例如，你可能需要确定从磁盘生成100个图像缩略图需要多长时间，或者一个数据结构会占用多少内存。**二的幂表**和**每个程序员都应了解的延迟数字**是很好的参考资料。

### 二的幂表


```
Power           Exact Value         Approx Value        Bytes
---------------------------------------------------------------
7                             128
8                             256
10                           1024   1 thousand           1 KB
16                         65,536                       64 KB
20                      1,048,576   1 million            1 MB
30                  1,073,741,824   1 billion            1 GB
32                  4,294,967,296                        4 GB
40              1,099,511,627,776   1 trillion           1 TB
```

#### 来源及进一步阅读

* [二的幂](https://en.wikipedia.org/wiki/Power_of_two)

### 每个程序员都应了解的延迟数字

```
Latency Comparison Numbers
--------------------------
L1 cache reference                           0.5 ns
Branch mispredict                            5   ns
L2 cache reference                           7   ns                      14x L1 cache
Mutex lock/unlock                           25   ns
Main memory reference                      100   ns                      20x L2 cache, 200x L1 cache
Compress 1K bytes with Zippy            10,000   ns       10 us
Send 1 KB bytes over 1 Gbps network     10,000   ns       10 us
Read 4 KB randomly from SSD*           150,000   ns      150 us          ~1GB/sec SSD
Read 1 MB sequentially from memory     250,000   ns      250 us
Round trip within same datacenter      500,000   ns      500 us
Read 1 MB sequentially from SSD*     1,000,000   ns    1,000 us    1 ms  ~1GB/sec SSD, 4X memory
HDD seek                            10,000,000   ns   10,000 us   10 ms  20x datacenter roundtrip
Read 1 MB sequentially from 1 Gbps  10,000,000   ns   10,000 us   10 ms  40x memory, 10X SSD
Read 1 MB sequentially from HDD     30,000,000   ns   30,000 us   30 ms 120x memory, 30X SSD
Send packet CA->Netherlands->CA    150,000,000   ns  150,000 us  150 ms

Notes
-----
1 ns = 10^-9 seconds
1 us = 10^-6 seconds = 1,000 ns
1 ms = 10^-3 seconds = 1,000 us = 1,000,000 ns
```
基于以上数字的实用指标：

* 从 HDD 顺序读取速度为 30 MB/s
* 从 1 Gbps 以太网顺序读取速度为 100 MB/s
* 从 SSD 顺序读取速度为 1 GB/s
* 从主内存顺序读取速度为 4 GB/s
* 每秒 6-7 次全球范围往返
* 数据中心内每秒 2000 次往返

#### 延迟数字可视化

![](https://camo.githubusercontent.com/77f72259e1eb58596b564d1ad823af1853bc60a3/687474703a2f2f692e696d6775722e636f6d2f6b307431652e706e67)

#### 来源及进一步阅读

* [每个程序员都该知道的延迟数字 - 1](https://gist.github.com/jboner/2841832)
* [每个程序员都该知道的延迟数字 - 2](https://gist.github.com/hellerbarde/2843375)
* [构建大型分布式系统的设计、经验与建议](http://www.cs.cornell.edu/projects/ladis2009/talks/dean-keynote-ladis2009.pdf)
* [构建大规模分布式系统的软件工程建议](https://static.googleusercontent.com/media/research.google.com/en//people/jeff/stanford-295-talk.pdf)

### 额外的系统设计面试题

> 常见系统设计面试题，附带解决资源链接。

| 问题 | 参考资料 |
|---|---|
| 设计一个类似 Dropbox 的文件同步服务 | [youtube.com](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| 设计一个类似 Google 的搜索引擎 | [queue.acm.org](http://queue.acm.org/detail.cfm?id=988407)<br/>[stackexchange.com](http://programmers.stackexchange.com/questions/38324/interview-question-how-would-you-implement-google-search)<br/>[ardendertat.com](http://www.ardendertat.com/2012/01/11/implementing-search-engines/)<br/>[stanford.edu](http://infolab.stanford.edu/~backrub/google.html) |
| 设计一个类似 Google 的可扩展网络爬虫 | [quora.com](https://www.quora.com/How-can-I-build-a-web-crawler-from-scratch) |
| 设计 Google 文档 | [code.google.com](https://code.google.com/p/google-mobwrite/)<br/>[neil.fraser.name](https://neil.fraser.name/writing/sync/) |
| 设计一个类似 Redis 的键值存储 | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| 设计一个类似 Memcached 的缓存系统 | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| 设计一个类似亚马逊的推荐系统 | [hulu.com](https://web.archive.org/web/20170406065247/http://tech.hulu.com/blog/2011/09/19/recommendation-system.html)<br/>[ijcai13.org](http://ijcai13.org/files/tutorial_slides/td3.pdf) |
| 设计一个类似 Bitly 的短链接系统 | [n00tc0d3r.blogspot.com](http://n00tc0d3r.blogspot.com/) |
| 设计一个类似 WhatsApp 的聊天应用 | [highscalability.com](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| 设计一个类似 Instagram 的图片分享系统 | [highscalability.com](http://highscalability.com/flickr-architecture)<br/>[highscalability.com](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html) |
| 设计 Facebook 新闻推送功能 | [quora.com](http://www.quora.com/What-are-best-practices-for-building-something-like-a-News-Feed)<br/>[quora.com](http://www.quora.com/Activity-Streams/What-are-the-scaling-issues-to-keep-in-mind-while-developing-a-social-network-feed)<br/>[slideshare.net](http://www.slideshare.net/danmckinley/etsy-activity-feeds-architecture) |
| 设计 Facebook 时间线功能 | [facebook.com](https://www.facebook.com/note.php?note_id=10150468255628920)<br/>[highscalability.com](http://highscalability.com/blog/2012/1/23/facebook-timeline-brought-to-you-by-the-power-of-denormaliza.html) |
| 设计 Facebook 聊天功能 | [erlang-factory.com](http://www.erlang-factory.com/upload/presentations/31/EugeneLetuchy-ErlangatFacebook.pdf)<br/>[facebook.com](https://www.facebook.com/note.php?note_id=14218138919&id=9445547199&index=0) |

| 设计一个类似 Facebook 的图搜索功能 | [facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-building-out-the-infrastructure-for-graph-search/10151347573598920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-indexing-and-ranking-in-graph-search/10151361720763920)<br/>[facebook.com](https://www.facebook.com/notes/facebook-engineering/under-the-hood-the-natural-language-interface-of-graph-search/10151432733048920) |
| 设计一个类似 CloudFlare 的内容分发网络 | [figshare.com](https://figshare.com/articles/Globally_distributed_content_delivery/6605972) |
| 设计一个类似 Twitter 的热门话题系统 | [michael-noll.com](http://www.michael-noll.com/blog/2013/01/18/implementing-real-time-trending-topics-in-storm/)<br/>[snikolov .wordpress.com](http://snikolov.wordpress.com/2012/11/14/early-detection-of-twitter-trends/) |
| 设计一个随机 ID 生成系统 | [blog.twitter.com](https://blog.twitter.com/2010/announcing-snowflake)<br/>[github.com](https://github.com/twitter/snowflake/) |
| 返回某一时间区间内的前 k 个请求 | [cs.ucsb.edu](https://www.cs.ucsb.edu/sites/default/files/documents/2005-23.pdf)<br/>[wpi.edu](http://davis.wpi.edu/xmdv/docs/EDBT11-diyang.pdf) |
| 设计一个从多个数据中心提供数据的系统 | [highscalability.com](http://highscalability.com/blog/2009/8/24/how-google-serves-data-from-multiple-datacenters.html) |
| 设计一个在线多人纸牌游戏 | [indieflashblog.com](https://web.archive.org/web/20180929181117/http://www.indieflashblog.com/how-to-create-an-asynchronous-multiplayer-game.html)<br/>[buildnewgames.com](http://buildnewgames.com/real-time-multiplayer/) |
| 设计一个垃圾回收系统 | [stuffwithstuff.com](http://journal.stuffwithstuff.com/2013/12/08/babys-first-garbage-collector/)<br/>[washington.edu](http://courses.cs.washington.edu/courses/csep521/07wi/prj/rick.pdf) |
| 设计一个 API 速率限制器 | [https://stripe.com/blog/](https://stripe.com/blog/rate-limiters) |
| 设计一个股票交易所（如 NASDAQ 或 Binance） | [Jane Street](https://youtu.be/b1e4t2k2KJY)<br/>[Golang 实现](https://around25.com/blog/building-a-trading-engine-for-a-crypto-exchange/)<br/>[Go 实现](http://bhomnick.net/building-a-simple-limit-order-in-go/) |
| 添加一个系统设计问题 | [贡献](#contributing) |

### 现实世界架构

> 关于现实世界系统设计的文章。

<p align="center">
  <img src="https://raw.githubusercontent.com/donnemartin/system-design-primer/master/images/TcUo2fw.png">
  <br/>
  <i><a href=https://www.infoq.com/presentations/Twitter-Timeline-Scalability>来源：Twitter 时间线的可扩展性</a></i>
</p>

**以下文章不要关注细枝末节，而应：**

* 识别文章中共享的原则、常用技术和模式
* 研究每个组件解决了什么问题，适用场景和局限
* 回顾所学到的经验教训

| 类型 | 系统 | 参考资料 |
|---|---|---|
| 数据处理 | **MapReduce** - Google 的分布式数据处理 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/mapreduce-osdi04.pdf) |
| 数据处理 | **Spark** - Databricks 的分布式数据处理 | [slideshare.net](http://www.slideshare.net/AGrishchenko/apache-spark-architecture) |
| 数据处理 | **Storm** - Twitter 的分布式数据处理 | [slideshare.net](http://www.slideshare.net/previa/storm-16094009) |
| | | |
| 数据存储 | **Bigtable** - Google 的分布式列式数据库 | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/chang06bigtable.pdf) |
| 数据存储 | **HBase** - Bigtable 的开源实现 | [slideshare.net](http://www.slideshare.net/alexbaranau/intro-to-hbase) |
| 数据存储 | **Cassandra** - Facebook 的分布式列式数据库 | [slideshare.net](http://www.slideshare.net/planetcassandra/cassandra-introduction-features-30103666) |
| 数据存储 | **DynamoDB** - Amazon 的文档数据库 | [harvard.edu](http://www.read.seas.harvard.edu/~kohler/class/cs239-w08/decandia07dynamo.pdf) |
| 数据存储 | **MongoDB** - 文档数据库 | [slideshare.net](http://www.slideshare.net/mdirolf/introduction-to-mongodb) |
| 数据存储 | **Spanner** - Google 的全球分布式数据库 | [research.google.com](http://research.google.com/archive/spanner-osdi2012.pdf) |
| 数据存储 | **Memcached** - 分布式内存缓存系统 | [slideshare.net](http://www.slideshare.net/oemebamo/introduction-to-memcached) |
| 数据存储 | **Redis** - 具有持久化和多种值类型的分布式内存缓存系统 | [slideshare.net](http://www.slideshare.net/dvirsky/introduction-to-redis) |
| | | |
| 文件系统 | **谷歌文件系统 (GFS)** - 分布式文件系统 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/zh-CN/us/archive/gfs-sosp2003.pdf) |
| 文件系统 | **Hadoop 文件系统 (HDFS)** - GFS 的开源实现 | [apache.org](http://hadoop.apache.org/docs/stable/hadoop-project-dist/hadoop-hdfs/HdfsDesign.html) |
| | | |
| 其他 | **Chubby** - 谷歌为松耦合分布式系统提供的锁服务 | [research.google.com](http://static.googleusercontent.com/external_content/untrusted_dlcp/research.google.com/en/us/archive/chubby-osdi06.pdf) |
| 其他 | **Dapper** - 分布式系统追踪基础设施 | [research.google.com](http://static.googleusercontent.com/media/research.google.com/en//pubs/archive/36356.pdf)
| 其他 | **Kafka** - 来自 LinkedIn 的发布/订阅消息队列 | [slideshare.net](http://www.slideshare.net/mumrah/kafka-talk-tri-hug) |
| 其他 | **Zookeeper** - 实现同步的集中式基础设施和服务 | [slideshare.net](http://www.slideshare.net/sauravhaloi/introduction-to-apache-zookeeper) |
| | 添加一个架构 | [贡献](#contributing) |

### 公司架构

| 公司 | 参考资料 |
|---|---|
| 亚马逊 | [亚马逊架构](http://highscalability.com/amazon-architecture) |
| Cinchcast | [每天生产1500小时音频](http://highscalability.com/blog/2012/7/16/cinchcast-architecture-producing-1500-hours-of-audio-every-d.html) |
| DataSift | [每秒12万条推文的实时数据挖掘](http://highscalability.com/blog/2011/11/29/datasift-architecture-realtime-datamining-at-120000-tweets-p.html) |
| Dropbox | [我们如何扩展 Dropbox](https://www.youtube.com/watch?v=PE4gwstWhmc) |
| ESPN | [每秒10万“呃呃呃”操作的运行](http://highscalability.com/blog/2013/11/4/espns-architecture-at-scale-operating-at-100000-duh-nuh-nuhs.html) |
| 谷歌 | [谷歌架构](http://highscalability.com/google-architecture) |
| Instagram | [1400万用户，数TB照片](http://highscalability.com/blog/2011/12/6/instagram-architecture-14-million-users-terabytes-of-photos.html)<br/>[Instagram的动力](http://instagram-engineering.tumblr.com/post/13649370142/what-powers-instagram-hundreds-of-instances) |
| Justin.tv | [Justin.Tv 的直播视频广播架构](http://highscalability.com/blog/2010/3/16/justintvs-live-video-broadcasting-architecture.html) |
| Facebook | [Facebook 上的 memcached 扩展](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/key-value/fb-memcached-nsdi-2013.pdf)<br/>[TAO：Facebook 社交图的分布式数据存储](https://cs.uwaterloo.ca/~brecht/courses/854-Emerging-2014/readings/data-store/tao-facebook-distributed-datastore-atc-2013.pdf)<br/>[Facebook 的照片存储](https://www.usenix.org/legacy/event/osdi10/tech/full_papers/Beaver.pdf)<br/>[Facebook 实时直播给80万同时观看者](http://highscalability.com/blog/2016/6/27/how-facebook-live-streams-to-800000-simultaneous-viewers.html) |
| Flickr | [Flickr 架构](http://highscalability.com/flickr-architecture) |
| Mailbox | [6周内从0到100万用户](http://highscalability.com/blog/2013/6/18/scaling-mailbox-from-0-to-one-million-users-in-6-weeks-and-1.html) |
| Netflix | [Netflix 全栈360度视图](http://highscalability.com/blog/2015/11/9/a-360-degree-view-of-the-entire-netflix-stack.html)<br/>[Netflix：按下播放键会发生什么？](http://highscalability.com/blog/2017/12/11/netflix-what-happens-when-you-press-play.html) |
| Pinterest | [从0到数百亿月页面浏览量](http://highscalability.com/blog/2013/4/15/scaling-pinterest-from-0-to-10s-of-billions-of-page-views-a.html)<br/>[1800万访客，10倍增长，12名员工](http://highscalability.com/blog/2012/5/21/pinterest-architecture-update-18-million-visitors-10x-growth.html) |
| Playfish | [5000万月活用户且持续增长](http://highscalability.com/blog/2010/9/21/playfishs-social-gaming-architecture-50-million-monthly-user.html) |
| PlentyOfFish | [PlentyOfFish 架构](http://highscalability.com/plentyoffish-architecture) |
| Salesforce | [每天处理13亿交易](http://highscalability.com/blog/2013/9/23/salesforce-architecture-how-they-handle-13-billion-transacti.html) |
| Stack Overflow | [Stack Overflow 架构](http://highscalability.com/blog/2009/8/5/stack-overflow-architecture.html) |
| TripAdvisor | [4000万访客，2亿动态页面浏览，30TB数据](http://highscalability.com/blog/2011/6/27/tripadvisor-architecture-40m-visitors-200m-dynamic-page-view.html) |
| Tumblr | [每月150亿页面浏览量](http://highscalability.com/blog/2012/2/13/tumblr-architecture-15-billion-page-views-a-month-and-harder.html) |
| Twitter | [让 Twitter 快1万倍](http://highscalability.com/scaling-twitter-making-twitter-10000-percent-faster)<br/>[使用 MySQL 存储每天2.5亿条推文](http://highscalability.com/blog/2011/12/19/how-twitter-stores-250-million-tweets-a-day-using-mysql.html)<br/>[1.5亿活跃用户，30万QPS，22MB/s数据流](http://highscalability.com/blog/2013/7/8/the-architecture-twitter-uses-to-deal-with-150m-active-users.html)<br/>[大规模时间线](https://www.infoq.com/presentations/Twitter-Timeline-Scalability)<br/>[Twitter 的大数据与小数据](https://www.youtube.com/watch?v=5cKTP36HVgI)<br/>[Twitter 运维：超越1亿用户的扩展](https://www.youtube.com/watch?v=z8LU0Cj6BOU)<br/>[Twitter 如何处理每秒3000张图片](http://highscalability.com/blog/2016/4/20/how-twitter-handles-3000-images-per-second.html) |
| Uber | [Uber 如何扩展其实时市场平台](http://highscalability.com/blog/2015/9/14/how-uber-scales-their-real-time-market-platform.html)<br/>[扩展 Uber 到2000名工程师、1000个服务和8000个 Git 仓库的经验教训](http://highscalability.com/blog/2016/10/12/lessons-learned-from-scaling-uber-to-2000-engineers-1000-ser.html) |
| WhatsApp | [Facebook 以190亿美元收购的 WhatsApp 架构](http://highscalability.com/blog/2014/2/26/the-whatsapp-architecture-facebook-bought-for-19-billion.html) |
| YouTube | [YouTube 可扩展性](https://www.youtube.com/watch?v=w5WVu624fY8)<br/>[YouTube 架构](http://highscalability.com/youtube-architecture) |

### 公司工程博客

> 你面试的公司的架构。
>
> 你遇到的问题可能来自同一领域。

* [Airbnb 工程](http://nerds.airbnb.com/)
* [Atlassian 开发者](https://developer.atlassian.com/blog/)
* [AWS 博客](https://aws.amazon.com/blogs/aws/)
* [Bitly 工程博客](http://word.bitly.com/)
* [Box 博客](https://blog.box.com/blog/category/engineering)
* [Cloudera 开发者博客](http://blog.cloudera.com/)
* [Dropbox 技术博客](https://tech.dropbox.com/)
* [Quora 工程](https://www.quora.com/q/quoraengineering)
* [Ebay 技术博客](http://www.ebaytechblog.com/)
* [Evernote 技术博客](https://blog.evernote.com/tech/)
* [Etsy 代码如工艺](http://codeascraft.com/)
* [Facebook 工程](https://www.facebook.com/Engineering)
* [Flickr 代码](http://code.flickr.net/)
* [Foursquare 工程博客](http://engineering.foursquare.com/)
* [GitHub 工程博客](https://github.blog/category/engineering)
* [Google 研究博客](http://googleresearch.blogspot.com/)
* [Groupon 工程博客](https://engineering.groupon.com/)
* [Heroku 工程博客](https://engineering.heroku.com/)
* [Hubspot 工程博客](http://product.hubspot.com/blog/topic/engineering)
* [High Scalability](http://highscalability.com/)
* [Instagram 工程](http://instagram-engineering.tumblr.com/)
* [Intel 软件博客](https://software.intel.com/en-us/blogs/)
* [Jane Street 技术博客](https://blogs.janestreet.com/category/ocaml/)
* [LinkedIn 工程](http://engineering.linkedin.com/blog)
* [Microsoft 工程](https://engineering.microsoft.com/)
* [Microsoft Python 工程](https://blogs.msdn.microsoft.com/pythonengineering/)
* [Netflix 技术博客](http://techblog.netflix.com/)
* [Paypal 开发者博客](https://medium.com/paypal-engineering)
* [Pinterest 工程博客](https://medium.com/@Pinterest_Engineering)
* [Reddit 博客](http://www.redditblog.com/)
* [Salesforce 工程博客](https://developer.salesforce.com/blogs/engineering/)
* [Slack 工程博客](https://slack.engineering/)
* [Spotify 实验室](https://labs.spotify.com/)
* [Stripe 工程博客](https://stripe.com/blog/engineering)
* [Twilio 工程博客](http://www.twilio.com/engineering)
* [Twitter 工程](https://blog.twitter.com/engineering/)
* [Uber 工程博客](http://eng.uber.com/)
* [Yahoo 工程博客](http://yahooeng.tumblr.com/)
* [Yelp 工程博客](http://engineeringblog.yelp.com/)
* [Zynga 工程博客](https://www.zynga.com/blogs/engineering)

#### 来源及进一步阅读

想添加博客？为了避免重复劳动，考虑将贵公司的博客添加到以下仓库：

* [kilimchoi/engineering-blogs](https://github.com/kilimchoi/engineering-blogs)

## 开发中

有兴趣添加新章节或帮助完成正在进行中的章节？[贡献](#contributing)！

* 使用 MapReduce 的分布式计算
* 一致性哈希
* 散射聚合
* [贡献](#contributing)

## 致谢

致谢和来源贯穿本仓库。

特别感谢：

* [Hired in tech](http://www.hiredintech.com/system-design/the-system-design-process/)
* [破解编码面试](https://www.amazon.com/dp/0984782850/)
* [高可扩展性](http://highscalability.com/)
* [checkcheckzz/system-design-interview](https://github.com/checkcheckzz/system-design-interview)
* [shashank88/system_design](https://github.com/shashank88/system_design)
* [mmcgrana/services-engineering](https://github.com/mmcgrana/services-engineering)
* [系统设计备忘单](https://gist.github.com/vasanthk/485d1c25737e8e72759f)
* [分布式系统阅读列表](http://dancres.github.io/Pages/)
* [破解系统设计面试](http://www.puncsky.com/blog/2016-02-13-crack-the-system-design-interview)

## 联系方式

欢迎随时联系我讨论任何问题、疑问或意见。

我的联系方式可以在我的[GitHub 页面](https://github.com/donnemartin)找到。

## 许可证

*我在此仓库中向您提供的代码和资源均遵循开源许可证。由于这是我的个人仓库，您获得的代码和资源的许可证由我本人而非我的雇主（Facebook）授权。*

    版权 2017 Donne Martin

    知识共享 署名 4.0 国际许可协议 (CC BY 4.0)

    http://creativecommons.org/licenses/by/4.0/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---