![Envoy 标志](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[云原生高性能边缘/中间/服务代理](https://www.envoyproxy.io/)

Envoy 由 [云原生计算基金会](https://cncf.io)（CNCF）托管。如果您的公司希望参与塑造以容器打包、动态调度和微服务为导向的技术发展，请考虑加入 CNCF。有关参与者及 Envoy 扮演的角色的详细信息，请阅读 CNCF 的[公告](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/)。

[![CII 最佳实践](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF 评分卡](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![模糊测试状态](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## 文档

* [官方文档](https://www.envoyproxy.io/)
* [常见问题](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [示例文档](https://github.com/envoyproxy/examples/)
* [博客](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310)：关于线程模型
* [博客](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5)：关于热重启
* [博客](https://medium.com/@mattklein123/envoy-stats-b65c7f363342)：关于统计架构
* [博客](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a)：关于通用数据面 API
* [博客](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1)：关于 Lyft 的 Envoy 仪表盘

## 相关项目

* [data-plane-api](https://github.com/envoyproxy/data-plane-api)：v2 API 定义的独立仓库。这是 [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/) 的只读镜像。
* [envoy-perf](https://github.com/envoyproxy/envoy-perf)：性能测试框架。
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example)：如何添加新过滤器并链接到主仓库的示例。

## 联系方式

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce)：低频邮件列表，仅用于公告通知。
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce)：低频邮件列表，仅用于安全相关公告。
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users)：用户常规讨论组。
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev)：Envoy 开发者讨论组（API、功能设计等）。
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers)：用于联系所有 Envoy 核心维护者。
* [Twitter](https://twitter.com/EnvoyProxy/)：在 Twitter 上关注我们！
* [Slack](https://envoyproxy.slack.com/)：Slack，获取邀请请点击[这里](https://communityinviter.com/apps/envoyproxy/envoy)。
  * 注意：Slack 上回复用户问题为尽力而为。如需“保证”回复，请根据以下链接讨论的建议发送邮件至 envoy-users@。

有关邮件列表使用的详细信息，请参见[此](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY)邮件讨论串。

## 贡献

为 Envoy 贡献代码很有趣，而且现代 C++ 远比你想象的容易，即使你没有经验。开始方法：

* [贡献指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [初学者问题](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [使用 Docker 快速开始构建/测试](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [开发者指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* 建议安装 Envoy [开发支持工具链](https://github.com/envoyproxy/envoy/blob/main/support/README.md)，可自动化部分开发流程，尤其是涉及代码审查的环节。
* 请确保在处理问题时告知我们，以避免重复劳动！

## 社区会议

Envoy 团队每月定期在周二上午 9 点（太平洋时间）召开两次会议。公开的 Google 日历在[这里](https://goo.gl/PkDijT)。只有在[会议记录](https://goo.gl/5Cergb)中列有议程时才会召开会议。社区任何成员都可以通过添加到会议记录中来提出议题。维护者会确认议程的新增内容，或在预定日期前 24 小时内取消会议（若无已确认议程）。

## 安全

### 安全审计

曾有多次第三方针对 Envoy 安全的评估：
* 2018 年，Cure53 进行了一次安全审计，[完整报告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)。
* 2021 年，Ada Logics 针对我们的模糊测试基础设施进行了审计并提出改进建议，[完整报告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)。

### 报告安全漏洞

如果你发现了 Envoy 的漏洞或潜在漏洞，请告知我们：[envoy-security](mailto:envoy-security@googlegroups.com)。我们会发送确认邮件以告知收到，并在识别问题后发送额外邮件（无论结果如何）。

更多详情请参见我们完整的[安全发布流程](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)。

### ppc64le 构建

ppc64le 架构或使用 aws-lc 的构建不在 envoy 安全策略覆盖范围内。ppc64le 架构目前为尽力支持，Envoy 维护者不对其进行维护。

## 发布

更多详情请参见我们的[发布流程](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---