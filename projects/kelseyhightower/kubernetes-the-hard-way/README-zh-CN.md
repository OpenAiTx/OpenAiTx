# Kubernetes The Hard Way

本教程将带你一步一步手动搭建 Kubernetes。该指南并不适用于那些希望通过全自动工具快速搭建 Kubernetes 集群的用户。Kubernetes The Hard Way 旨在帮助你学习，因此我们会选择更繁琐的路径，确保你能理解集群引导过程中的每一个步骤。

> 本教程的最终结果不应视为生产可用环境，并且可能只会获得社区有限的支持，但这不应阻止你学习！

## 版权

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="知识共享许可协议" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />本作品采用<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">知识共享署名-非商业性使用-相同方式共享 4.0 国际许可协议</a>进行许可。

## 目标读者

本教程面向希望理解 Kubernetes 基础原理及其核心组件如何协作的读者。

## 集群详情

Kubernetes The Hard Way 将指导你引导一个基本的 Kubernetes 集群：所有控制平面组件运行在一个节点上，另有两个工作节点，这足以帮助你学习核心概念。

组件版本：

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## 实验步骤

本教程需要四（4）台基于 ARM64 或 AMD64 架构的虚拟机或物理机，并且这些机器处于同一网络中。

* [前置条件](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [设置跳板机](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [计算资源准备](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [准备 CA 并生成 TLS 证书](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [生成 Kubernetes 认证配置文件](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [生成数据加密配置和密钥](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [引导 etcd 集群](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [引导 Kubernetes 控制平面](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [引导 Kubernetes 工作节点](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [配置 kubectl 远程访问](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [配置 Pod 网络路由](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [冒烟测试](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [清理环境](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---