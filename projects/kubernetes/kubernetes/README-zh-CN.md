# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes，也被称为 K8s，是一个用于跨多个主机管理[容器化应用程序]的开源系统。它为应用程序的部署、维护和扩展提供了基本机制。

Kubernetes 基于 Google 十五年来通过名为 [Borg] 的系统大规模运行生产工作负载的经验，并结合了社区中最先进的理念和实践。

Kubernetes 由云原生计算基金会（[CNCF]）托管。如果您的公司希望参与塑造容器打包、动态调度和微服务导向技术的发展，欢迎加入 CNCF。关于参与者和 Kubernetes 所起作用的详细信息，请阅读 CNCF 的[公告]。

----

## 开始使用 K8s

请参阅我们在 [kubernetes.io] 上的文档。

参加免费的 [Kubernetes 可扩展微服务] 课程。

如需在其他应用程序中将 Kubernetes 代码作为库使用，请参阅[已发布组件列表](https://git.k8s.io/kubernetes/staging/README.md)。不支持将 `k8s.io/kubernetes` 模块或 `k8s.io/kubernetes/...` 包作为库使用。

## 开始开发 K8s

[社区仓库] 提供了关于如何从源码构建 Kubernetes、如何贡献代码和文档、联系对象等所有信息。

如果你想立即构建 Kubernetes，有两种选择：

##### 你有可用的 [Go 环境]。

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### 你有可用的 [Docker 环境]。

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

完整内容请参见[开发者文档]。

## 支持

如果你需要支持，请从[故障排除指南]开始，并按照我们列出的流程操作。

如果你有疑问，可以通过[各种方式][communication]联系我们。

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## 社区会议

[日历](https://www.kubernetes.dev/resources/calendar/) 汇集了 Kubernetes 社区所有会议的时间与地点信息。

## 采用者

[用户案例研究](https://kubernetes.io/case-studies/) 网站展示了各行业组织部署/迁移到 Kubernetes 的实际案例。

## 治理

Kubernetes 项目由一套原则、价值观、政策和流程的框架进行治理，以帮助我们的社区及成员实现共同目标。

[ Kubernetes 社区 ](https://github.com/kubernetes/community/blob/master/governance.md) 是了解我们如何组织自身的起点。

[Kubernetes 指导委员会社区仓库](https://github.com/kubernetes/steering) 由 Kubernetes 指导委员会使用，负责 Kubernetes 项目的治理。

## 路线图

[Kubernetes 增强功能仓库](https://github.com/kubernetes/enhancements) 提供关于 Kubernetes 发布、特性跟踪和待办事项的相关信息。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---