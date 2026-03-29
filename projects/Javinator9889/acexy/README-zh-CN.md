# `acexy` - 用 Go 编写的 AceStream 代理！⚡

[![Go 构建](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker 发布](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## 目录

- [它是如何工作的？🛠](#how-it-works-)
- [主要功能 🔗](#key-features-)
- [使用方法 📐](#usage-)
- [优化 🚀](#optimizing-)
  - [替代方案 🧃](#alternative-)
- [配置选项 ⚙](#configuration-options-)

## 它是如何工作的？🛠

该项目是围绕
[AceStream 中间件 HTTP API](https://docs.acestream.net/developers/start-playback/#using-middleware) 的一个封装，支持
[HLS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) 和
[MPEG-TS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) 流的播放。

我厌倦了 AceStream 的限制以及播放流时存在的一些问题 📽。例如，只能为 **单个客户端** 播放同一频道。要让多个客户端
播放 **不同的流**，必须为每个客户端手动添加唯一的 `pid`。如果传输过程中出现错误，**整个流都会中断**，等等。

我觉得在家庭网络中使用 AceStream，单个服务器和多个客户端共享，试图优化资源的体验非常令人沮丧。这是我使用 AceStream 的网络拓扑：

![我的网络的 AceStream 拓扑](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

存在一些问题：

* 同一时间只能有 **一个客户端** 播放同一流 🚫。
* 让每个客户端独立运行 AceStream 会浪费资源并且导致网络饱和 📉。








* 多个客户端如果拥有唯一的 `pid`（播放器ID）关联，可以播放不同的流 🔓。
* 标准的 AceStream HTTP API 对错误的容错能力不足，
  如果传输停止，所有客户端都会停止 ❌。

## 主要特性 🔗

使用 `acexy`，你将自动拥有：

* 一个单一的、集中式服务器运行 **你所有的 AceStream 流** ⛓。
* 自动为每个客户端每个流分配唯一的 `pid`（播放器ID）🪪。
* **流复用** 🕎：同一流可以 *同时在多个客户端* 上播放。
* 得益于 HTTP 中间件，实现了 **抗错误、稳健** 的流媒体传输 🛡。
* *极速、极简代理* ☄，采用 Go 语言编写！

借助此代理，现可实现如下架构：

![acexy 拓扑](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## 使用方法 📐

`acexy` 以 Docker 镜像形式发布。请确保你已安装并拥有
最新的 [Docker](https://docker.com) 镜像。

Acexy 容器将连接到 AceStream 服务器。你需要
部署一个 Docker 镜像，并将 Acexy 置于相同网络中；或者
在宿主机上运行 AceStream，并以主机网络模式运行 Acexy。

> **提示**：仓库内有一个 `docker-compose.yml` 文件，你可以直接
> 使用它来启动整个服务块。这是 **从 `v0.2.0` 版本开始推荐的配置**。

要运行服务块，首先获取 `docker-compose.yml` 文件，然后执行：





```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```

如果你不想使用 Docker Compose，假设你已经有一个
AceStream 服务器，另一种方法可以是：

```shell
docker run --network host ghcr.io/javinator9889/acexy
```

> **注意**：为了方便起见，提供了一个包含所有可调参数的 `docker-compose.yml` 文件。  
> 它应该可以直接运行，并且从 `v0.2.0` 版本起推荐使用此方式。

默认情况下，代理将以 MPEG-TS 模式工作。若要切换模式，  
必须添加 **`-m3u8` 标志** 或设置 **`ACEXY_M3U8=true` 环境变量**。

> **注意**：HLS 模式 - `ACEXY_M3U8` 或 `-m3u8` 标志 - 处于未经测试的状态。  
> 不建议使用，且不能保证其正常工作。

只有一个可用的端点：`/ace/getstream`，其参数与标准的  
[AceStream 中间件/HTTP API](https://docs.acestream.net/developers/api-reference/) 相同。  
因此，要运行一个流，只需在你喜欢的应用程序中打开以下链接——例如 VLC：




```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```

where `dd1e67078381739d14beca697356ab76d49d1a2` 是 AceStream
频道的 ID。

## 优化 🚀

运行在代理后的 AceStream 引擎有多个端口可以
暴露以优化性能。默认情况下，这些端口是：

- `8621/tcp`
- `8621/udp`

> 注意：这些端口可以通过 Docker 中的 `EXTRA_FLAGS` 变量
> 使用 `--port` 标志进行调整。

暴露这些端口应有助于获得更稳定的流媒体体验。请注意，
你还需要在网关上打开这些端口。

参考下方示例，这是运行 Docker 命令的方式：

```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```

### 替代方案 🧃

AceStream 在底层尝试使用 UPnP IGD 连接远程机器。
问题是由于 Docker 添加的桥接层导致此方法无法工作
（参见：https://docs.docker.com/engine/network/drivers/bridge/）。

如果您只运行一个 Acexy 实例和一个 AceStream 实例，
则可以安全地使用 *主机网络* 运行容器。这意味着：

- 容器**可以访问**桥接到您主网络的任何其他应用程序。
- 您**不需要**暴露任何端口。
- 性能**会略有优化**。

> 注意：此方法仅适用于 Linux 环境。更多信息请参见 https://docs.docker.com/engine/network/drivers/host/
> 。

命令非常简单明了：

```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```
这将使 AceStream 能够自由使用 UPnP。

## 配置选项 ⚙

Acexy 拥有大量配置选项，允许您自定义其行为。所有选项都有
经过测试以实现最佳体验的默认值，但您可能需要调整它们
以满足您的需求。

> **专业提示**：您可以执行 `acexy -help` 来完整查看所有可用选项。

由于 Acexy 设计为在 Docker 容器内运行，所有变量和设置均可
通过环境变量进行调整。


<table>
  <thead>
    <tr>
      <th>标志</th>
      <th>环境变量</th>
      <th>说明</th>
      <th>默认值</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>打印程序许可并退出</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>打印帮助信息并退出</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>

      <th>Acexy监听的地址。运行在<code>host</code>模式时有用。</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        AceStream中间件的协议。如果你配置了AceStream使用HTTPS，
        你需要调整这个值。
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        AceStream中间件所在的位置。如果你需要Acexy连接到不同的AceStream引擎，请修改它。
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        连接AceStream中间件的端口。如果你需要Acexy连接到不同的AceStream引擎，请修改它。
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        当Acexy以M3U8模式运行时，判断流结束的超时时间。
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>


      <th><code>ACEXY_M3U8</code></th>
      <th>
        在Acexy中启用M3U8模式。<b>警告</b>：此模式为实验性，可能无法按预期工作。
      </th>
      <th>禁用</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        在从中间件接收到空信息后，认为流已结束的超时时间。
        在M3U8模式下无效。
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        在将数据复制到播放器之前，缓冲流的<code>buffer-size</code>字节数。
        有助于播放时获得更好的稳定性。
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        等待AceStream中间件对新打开流返回响应的时间。
        除非您的网络连接非常差（例如：延迟非常高），否则此时间应尽可能短。
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **注意**：选项列表非常多，但可能已过时。如有疑问，请始终参考
> Acexy二进制文件的`-help`输出。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---