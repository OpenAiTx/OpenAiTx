<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>为各种用途打造的高速、模块化闪电网络实现，采用 Rust 编写。</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">项目主页</a>
  </h4>
</div>

## Crates

以下是目前支持的所有 crate 列表：

| Crate       | 描述                                   | 版本     |
|:------------|:--------------------------------------:|---------:|
| lampod-cli  | Lampo Daemon 守护进程的命令行界面，用于运行守护进程 | _无关_ |
| lampo-cli   | 简单的 Lampo 命令行界面，用于与守护进程交互 | _无关_ |

## 安装方法

要安装所有依赖项和 Lampo 可执行文件，你需要先安装 rust，然后运行以下命令：

```
make install
```

在你拥有 `lampod-cli` 和 `lampo-cli` 后，可以运行以下命令，以 signet 模式启动 Lampo：

```
➜  ~ lampod-cli --network signet
✓ 钱包已生成，请安全保存以下助记词
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
请妥善保存你的钱包助记词，然后可以通过 `--restore-wallet` 参数恢复钱包。
如果没有保存助记词，下次启动 Lampo 时你的资金将会丢失！

请注意，你需要在路径 `~/.lampo/signet` 下拥有 `lampo.conf` 配置文件。运行以下命令使用示例配置文件：

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

然后你可以通过以下命令查询节点信息：

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### 与 core lightning 进行集成测试：

请确保你已在开发者模式下编译 core-lightning。安装指南可参阅 [这里](https://docs.corelightning.org/docs/installation)。

可通过以下命令运行集成测试：

```
make integration
```

## 贡献指南

请阅读我们的[贡献指南](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md)。

## 社区

为了保持沟通的清晰，我们选择了特定的交流渠道：
- 开发者请加入我们的 [Zulip](https://lampo-dev.zulipchat.com/)。
- 社区成员欢迎加入我们的 [Twitter 社区](https://twitter.com/i/communities/1736414802849706087) 分享你的见解。
- 技术问题和功能请求，请参与我们的 GitHub 讨论区。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---