# Action Hero

## 什么是 Action Hero？

Action Hero 是一种辅助工具，采用 sidecar 方式，帮助创建 AWS 的最小权限 IAM 策略。

## 为什么需要它？

通常，开发人员在使用基础设施即代码时，会先创建具有管理员访问权限的更宽松角色以便快速迭代。然而，尝试创建更细粒度的权限集合通常既痛苦又耗时。

Action Hero 提供了一种在更宽松的迭代过程中捕获所有必需权限的方法，从而更容易创建仅包含必需权限的 IAM 角色。

## 它是如何工作的？

Action Hero 使用 AWS SDK 的一个特性，称为客户端监控（Client Side Monitoring）。该特性将 AWS API 调用发送到本地的 udp 端口（默认是 31000）。

Summit Route 在这篇[文章](https://summitroute.com/blog/2020/05/25/client_side_monitoring/)中讨论了该特性（这也是此工具的灵感来源）。

## 前提条件

如上文所述，必须在运行使用 SDK 的工具的 shell 中执行 ``export AWS_CSM_ENABLED=true`` 或在配置文件中设置该变量。例如，如果您使用 terraform，则需要在运行 plan/apply 的 shell 中导出该变量。

环境变量 ``AWS_CSM_PORT`` 也可用于覆盖发送 CSM 操作的端口以及 Action Hero 监听的端口。如果使用此变量，则需要在两个 shell 中都导出。

## 安装

二进制文件可从[发布页面](https://github.com/princespaghetti/actionhero/releases)获取。

Docker 镜像也可从 [docker hub](https://hub.docker.com/r/princespaghetti/actionhero) 获取。

## 运行 Action Hero

在使用 SDK 的终端之外，打开另一个终端运行二进制文件。

``./actionhero``

或者，您也可以使用 docker 运行命令：

``docker run -e "IN_DOCKER=True" -p 127.0.0.1:31000:31000/udp --rm princespaghetti/actionhero:latest``

Ctrl+C 可用于安全终止进程

## 操作指南

请参阅此[博客文章](https://dev.to/prince_of_pasta/action-hero-to-the-rescue-creating-least-privilege-aws-iam-policies-53o2)了解该工具的示例用法。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-08

---