## <img width=16 src="https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/spectator/src/spectator/internal/assets/lucy_spectator.svg"> Spectator

[![Package Version](https://img.shields.io/hexpm/v/spectator)](https://hex.pm/packages/spectator)
[![Hex Docs](https://img.shields.io/badge/hex-docs-ffaff3)](https://hexdocs.pm/spectator/)

Spectator 是一个用 Gleam 编写的 BEAM 观察工具，能够很好地配合 gleam_otp 进程使用。

![](https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/screenshot.png)

## 功能

到目前为止，spectator 具备以下功能：

- 以可排序的表格显示进程
- 为单个进程添加标签，便于识别
- 显示进程详情
- 显示 OTP 进程状态
- 挂起 / 恢复 OTP 进程
- 列出 ETS 表
- 查看 ETS 表内容
- 列出活动端口
- 资源间可点击链接
- 带有基础统计信息的仪表盘
- 检查其他 BEAM 节点

## 在开发中使用 Spectator

你可以将 spectator 作为依赖安装到你的项目中，并将其作为应用的一部分运行，以便在开发中检查你的应用。

```sh
gleam add spectator
```
有关如何操作的详细信息，请参见 [package README](https://hexdocs.pm/spectator/)

## 在生产环境中使用 Spectator

您可以通过将 spectator 作为独立应用运行，并通过分布式连接到您的应用运行的 erlang 节点，使用 spectator 来检查运行您已部署应用的 BEAM 节点。

独立的 spectator 应用程序可通过 `ghcr.io/jonasgruenwald/spectator` 作为 docker 镜像获得，也可通过 [releases 页面](https://github.com/JonasGruenwald/spectator/releases) 以 escript 形式获得。

仓库中包含[如何使用 spectator 检查通过 docker 部署的应用的完整示例](https://github.com/JonasGruenwald/spectator/tree/main/example#readme)。

首先，确保您的应用程序已设置 Erlang 名称和 cookie，例如通过在应用启动前设置 `ERL_FLAGS` 环境变量：


```sh
ERL_FLAGS="-name myapp@host -setcookie mycookie"
```
如果您的应用程序运行在 Docker 容器中，请将您的应用程序容器和运行 spectator 的容器放在同一个 Docker 网络中，并确保您的应用程序容器的主机名设置为您知道的值。

启动 spectator，点击应用程序右上角的“Change Target（更改目标）”。

输入您希望检查的节点的详细信息，名称应为您通过 `-sname` 设置的名称，后跟 `@`，然后是主机名。

最后，点击“Connect（连接）”，以检查您的应用程序节点。

请注意，检查目标必须设置与 spectator 相同的 Erlang cookie。就像您的应用程序一样，您可以通过 `ERL_FLAGS` 环境变量配置 spectator 的 cookie，例如 `ERL_FLAGS="-name spectator@127.0.0.1 -setcookie mycookie"`。

## 注意事项

请注意运行 spectator 可能带来的以下影响：

- **Spectator 可能会降低系统性能**  
  所有显示的进程都会在配置的时间间隔内通过 Erlang 的 `process_info/2` 函数进行探测，该函数会对被探测的进程施加临时锁定。如果进程处理大量消息，这可能会对系统性能产生影响。

- **Spectator 会动态创建原子**  
  当您选择连接到其他 Erlang 节点时，spectator 需要将您提供的节点名称转换为原子。因此，使用其用户界面有可能耗尽运行 spectator 的 BEAM 实例的内存，因为原子永远不会被垃圾回收。

- **Spectator 不包含访问控制**  
  Spectator 通过其 Web 界面暴露了其正在检查的运行时的敏感细节，当前并未限制访问。  
  如果您在生产环境中使用 spectator，您有责任保护它——确保绝不将 spectator 暴露在公共互联网中。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---