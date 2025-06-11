# 容器化

容器化包允许应用程序使用 Linux 容器。  
容器化使用 [Swift](https://www.swift.org) 编写，并在 Apple silicon 上使用 [Virtualization.framework](https://developer.apple.com/documentation/virtualization)。

容器化提供以下 API：

- [管理 OCI 镜像](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/)。
- [与远程注册表交互](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/)。
- [创建和填充 ext4 文件系统](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/)。
- [与 Netlink 套接字族交互](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/)。
- [创建用于快速启动的优化 Linux 内核](https://raw.githubusercontent.com/apple/containerization/main/kernel/)。
- [启动轻量级虚拟机并管理运行时环境](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift)。
- [启动并与容器化进程交互](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift)。
- 在 Apple silicon 上使用 Rosetta 2 运行 linux/amd64 容器。

请查看 [API 文档](https://apple.github.io/containerization/documentation/) 了解容器化提供的 Swift 包信息。

## 设计

容器化在每个 Linux 容器内运行其自身的轻量级虚拟机。客户端可以为每个容器创建专用 IP 地址，消除单独端口转发的需求。容器通过优化的 [Linux 内核配置](https://raw.githubusercontent.com/apple/containerization/main/kernel) 和带有轻量级 init 系统的最小根文件系统，实现亚秒级启动时间。

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) 是一个小型 init 系统，是容器化的一个子项目。  
`vminitd` 作为虚拟机内的初始进程启动，并通过 vsock 提供 GRPC API。  
该 API 允许配置运行时环境并启动容器化进程。  
当运行进程时，`vminitd` 向调用进程提供 I/O、信号和事件。

## 要求

您需要一台 Apple silicon Mac 来构建和运行容器化。

构建容器化包，您的系统需要满足以下条件之一：

- macOS 15 或更高版本，且使用 Xcode 26 beta
- macOS 26 beta 或更高版本

使用该包构建的应用程序将在 macOS 15 或更高版本运行，但以下功能在 macOS 15 上不可用：

- 非隔离容器网络 —— 在 macOS 15 上，同一 vmnet 网络内的容器之间无法通信

## 示例用法

有关如何使用部分库功能的示例，cctl 可执行文件是一个很好的起点。该工具的主要作用是作为 API 试验场。它包含执行各种核心功能的命令，例如：

1. [操作 OCI 镜像](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [登录容器注册表](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [创建根文件系统块](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [运行简单的 Linux 容器](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## Linux 内核

在 macOS 上启动轻量级虚拟机需要 Linux 内核。  
容器化提供了一个位于 [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) 目录下的优化内核配置。

该目录包含一个容器化构建环境，可轻松编译适用于容器化的内核。

内核配置是一组最小功能集，支持快速启动时间和轻量级环境。

虽然此配置适用于大多数工作负载，但我们理解某些工作负载可能需要额外功能。  
为解决此问题，容器化提供了一流的 API，允许按容器使用不同的内核配置和版本。  
这使得容器可以在不同内核版本间开发和验证。

请参阅 kernel 目录下的 [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) 了解如何编译优化内核。

### 预编译内核

如果您希望使用预编译内核，必须将 `VIRTIO` 驱动编译进内核，而非作为模块。

[Kata Containers](https://github.com/kata-containers/kata-containers) 项目提供了一个优化的容器内核，启用了所有必需的配置选项，详见其 [releases](https://github.com/kata-containers/kata-containers/releases/) 页面。

内核镜像 `vmlinux.container` 可在发布工件的 `/opt/kata/share/kata-containers/` 目录中找到。

## 准备构建包

安装 Swiftly、[Swift](https://www.swift.org) 和 [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html)：

```bash
make cross-prep
```

如果您使用自定义终端应用，可能需要将此命令从 `.zprofile` 移动到 `.zshrc`（替换 `<USERNAME>`）：

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

重启终端应用。确保以下命令返回 `/Users/<USERNAME>/.swiftly/bin/swift`（替换 `<USERNAME>`）：

```bash
which swift
```

如果您之前安装或使用过 Static Linux SDK，可能需要从系统中移除旧版本 SDK（替换 `<SDK-ID>`）：

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## 构建包

从源码构建容器化：

```bash
make all
```

## 测试包

构建完成后，运行基本和集成测试：

```bash
make test integration
```

运行集成测试需要内核。  
如果您本地没有内核，可以使用 `make fetch-default-kernel` 目标获取默认内核。

获取默认内核只需在初次构建后或执行 `make clean` 后执行。

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

容器化依赖特定版本的 `grpc-swift` 和 `swift-protobuf`。您可以安装它们并重新生成 RPC 接口：

```bash
make protos
```

## 文档

生成本地查看的 API 文档：

```bash
make docs
make serve-docs
```

在另一个终端运行以下命令预览文档：

```bash
open http://localhost:8000/documentation/
```

## 贡献

欢迎并鼓励对容器化的贡献。详情请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md)。

## 项目状态

版本 0.1.0 是容器化的第一个正式发布版本。早期版本不保证源代码稳定性。

由于容器化库处于积极开发中，源代码稳定性仅在小版本内保证（例如 0.1.1 与 0.1.2 之间）。如果您不希望包更新破坏源代码兼容性，可以使用 .upToNextMinorVersion(from: "0.1.0") 来指定依赖版本。

未来的小版本可能根据需要调整这些规则。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---