![Envoy 标志](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[云原生高性能边缘/中间/服务代理](https://www.envoyproxy.io/)

Envoy 由 [云原生计算基金会](https://cncf.io)（CNCF）托管。如果您的公司希望参与塑造容器化、动态调度和面向微服务的技术的发展，欢迎加入 CNCF。关于参与者以及 Envoy 所扮演的角色的详细信息，请阅读 CNCF 的
[公告](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/)。

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

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce)：低频邮件列表，仅用于发布公告。
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce)：低频邮件列表，仅用于发布安全相关公告。
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users)：一般用户讨论。
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev)：Envoy 开发者讨论（API、功能设计等）。
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers)：用于联系所有核心 Envoy 维护者。
* [Twitter](https://twitter.com/EnvoyProxy/)：在 Twitter 上关注我们！
* [Slack](https://envoyproxy.slack.com/)：Slack，获取邀请请点击[这里](https://communityinviter.com/apps/envoyproxy/envoy)。
  * 注意：Slack 上对用户问题的响应为尽力而为。如需“保证”获得回复，请根据下述链接邮件主题中的指导发送邮件至 envoy-users@。

有关邮件列表使用的更多信息，请参见[此](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY)邮件主题。

## 参与贡献

参与 Envoy 开发是有趣的，且现代 C++ 并没有你想象的那么可怕，即使你没有相关经验。开始参与：

* [贡献指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [新手问题](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [使用 Docker 快速构建/测试](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [开发者指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* 建议安装 Envoy [开发支持工具链](https://github.com/envoyproxy/envoy/blob/main/support/README.md)，该工具链可自动化部分开发流程，尤其是涉及代码审查的环节。
* 如果你正在处理某个 issue，请务必告知我们，以避免重复劳动！

## 社区会议

Envoy 团队每月定期在周二上午 9 点（太平洋时间）召开两次会议。公开的 Google 日历在[这里](https://goo.gl/PkDijT)。只有在[会议纪要](https://goo.gl/5Cergb)中列出议题时才会召开会议。社区成员均可通过在会议纪要中添加议题来提出议题。维护者会确认议题的添加，或者如无已确认议题，会在预定会议时间前 24 小时内取消会议。

## 安全

### 安全审计

已经有多家第三方机构针对 Envoy 安全性进行了评估：
* 2018 年 Cure53 进行了安全审计，[完整报告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)。
* 2021 年 Ada Logics 对我们的模糊测试基础设施进行了审计，并提出改进建议，[完整报告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)。

### 漏洞报告

如果你在 Envoy 中发现了漏洞或潜在漏洞，请通过 [envoy-security](mailto:envoy-security@googlegroups.com) 告知我们。我们会发送确认邮件以确认收到你的报告，并在识别问题后（无论是否为漏洞）再发送一封邮件。

详细流程请参见我们的[完整安全发布流程](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)。

### ppc64le 构建

ppc64le 架构或使用 aws-lc 的构建不在 envoy 安全政策的覆盖范围内。ppc64le 架构目前为“尽力支持”，并未由 Envoy 维护者专门维护。

## 发布

更多详情请参见我们的[发布流程](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---