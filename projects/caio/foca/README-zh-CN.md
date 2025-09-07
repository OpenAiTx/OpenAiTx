# Foca：按您的方式发现集群成员

Foca 是构建基于 Gossip 的集群发现的基础模块。它是一个小型的 `no_std` + `alloc` 包，实现了 SWIM 协议及其有用的扩展（`SWIM+Inf.+Susp.`）。

项目：

* Git 仓库：https://caio.co/de/foca/
* 问题跟踪：https://github.com/caio/foca/issues
* CI：https://github.com/caio/foca/actions/workflows/ci.yml
* 包管理：https://crates.io/crates/foca
* 文档：https://docs.rs/foca


# 介绍

Foca 最显著的特点是它几乎不做任何事情。开箱即用，它仅提供一个可靠且高效的
[SWIM 协议][1] 实现，且对传输和身份无依赖。

了解 SWIM 的工作原理有帮助，但不是使用本库的必备条件。阅读 `Message` 枚举的文档
应能让您了解协议的工作方式，但论文本身也非常易读。

Foca 设计为适应任何类型的传输：如果您的网络允许节点间相互通信，您就可以在其上部署 Foca。
不仅总体带宽需求低，而且您还可以完全控制成员如何相互识别（参见
`./examples/identity_golf.rs`）以及消息的编码方式。


# 使用

请查看 `./examples/foca_insecure_udp_agent.rs`。它展示了一个简单的基于 tokio 的代理
可能的样子，并让您实际运行并观察 Foca 的游动。










~~~
$ cargo run --features std,tracing,bincode-codec --example foca_insecure_udp_agent -- --help
foca_insecure_udp_agent 

USAGE:
    foca_insecure_udp_agent [OPTIONS] <BIND_ADDR>

FLAGS:
    -h, --help       打印帮助信息
    -V, --version    打印版本信息

OPTIONS:
    -a, --announce <announce>    要加入的另一个 Foca 实例的地址
    -f, --filename <filename>    包含所有活动成员的文件名
    -i, --identity <identity>    集群成员用于与你通信的地址。
                                 默认是 BIND_ADDR

ARGS:
    <BIND_ADDR>    绑定的套接字地址。例如：127.0.0.1:8080
~~~

所以你可以在一个终端启动代理：
`./foca_insecure_udp_agent 127.0.0.1:8000`，并通过不同的 `BIND_ADDR` 和 `--announce` 加入任意多个其他实例。
例如：
`./foca_insecure_udp_agent 127.0.0.1:8001 -a 127.0.0.1:8000`。

代理通过 [tracing][] 的订阅者向控制台输出一些信息。
默认日志级别为 `INFO`，可以通过设置环境变量 `RUST_LOG` 并使用 [tracing_subscriber 的 EnvFilter 指令][dir] 进行自定义。


## Cargo 功能特性

每个功能都是可选的。`default` 集合始终为空。

* `std`：为 `std::net::SocketAddr*` 实现 `foca::Identity` 并暴露 `Config::new_lan` 和 `Config::new_wan`
* `tracing`：使用 [tracing][] crate 对 Foca 进行监控。高级-level




  协议交互以 `DEBUG` 跟踪的形式发出，更详细的信息可以通过 `TRACE` 级别暴露。不发出其他级别。
* `serde`：为 Foca 的公共类型派生 `Serialize` 和 `Deserialize`。
* `bincode-codec`：提供 `BincodeCodec`，一种基于 serde 的编解码器类型，底层使用 [bincode][]。
* `postcard-codec`：提供 `PostcardCodec`，一种基于 serde 的、`no_std` 友好的编解码器，底层使用 [postcard][]。
* `unstable-notifications`：提供新的通知，允许检查发送和接收的消息。


# 说明

编写此库时，主要目标是拥有一个简单且小巧的核心，便于测试、模拟和推理；主要是为了在阅读论文后更好地理解协议。

坚持这些目标自然导致实现不依赖许多操作系统功能，如硬件时钟、原子操作和线程，因此成为一个 `no_std` crate（尽管仍然需要堆分配）算是一个意外但很好的特性，我决定坚持下去。


## 与 memberlist 的比较

我避免在对自己的实现满意之前查看 [memberlist][2]。之后我做了不彻底的了解：

* memberlist 支持自定义广播，这是复杂服务发现场景中的一个非常酷的功能，所以现在 Foca 也支持传播用户数据（见 `BroadcastHandler` 文档） :-)

* 它有一个基于流的同步机制（推拉），用于成员之间的加入和周期性合并状态：这远远超出了 Foca 的职责范围，但这是一个非常有趣的想法，因此我公开了 `Foca::apply_many` 方法，允许代码



















  使用 Foca 来实现类似的功能（如果需要）。

* 其配置参数根据（当前）集群大小变化。用户可以利用 `Config::new_{lan,wan}` 以及
  `Foca::set_config` 来实现相同的效果。

# 参考文献

* 论文 [SWIM: Scalable Weakly-consistent Infection-style Process Group Membership
Protocol][1]
* HashiCorp 的 [memberlist][2]

[1]: https://www.cs.cornell.edu/projects/Quicksilver/public_pdfs/SWIM.pdf
[2]: https://github.com/hashicorp/memberlist
[bincode]: https://github.com/bincode-org/bincode
[postcard]: https://github.com/jamesmunns/postcard
[tracing]: https://docs.rs/tracing/latest/tracing/
[dir]: https://docs.rs/tracing-subscriber/0.3.17/tracing_subscriber/filter/struct.EnvFilter.html#directives

# 许可

除非另有明确说明，所有工作均遵循 Mozilla 公共许可证 2.0 版本的条款。

`examples/` 目录下的文件属于公有领域。





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---