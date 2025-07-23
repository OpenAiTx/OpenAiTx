# 以太坊质押指南 #

## 介绍 ##

欢迎！

如果您想成为一名独立质押者，即以太坊网络上质押的**黄金标准**，那么这些指南适合您！

所需设备是一台运行 Ubuntu（22.04 LTS 或更高版本）的机器，配备现代 CPU、16GB 内存（32GB 更佳）和高质量的 2TB SSD（4TB 更佳）。

开始之前，请访问以下[**主网质押指南**](https://github.com/SomerEsat/ethereum-staking-guides#mainnet-staking-guides)。

如果您不确定使用哪个客户端，请选择份额最低的那个。详见：https://clientdiversity.org。下面的指南以主要的**共识客户端**（Lighthouse、Lodestar、Prysm、Nimbus 和 Teku）命名，因此您需要先选择其中一个。每个指南中都包含安装**执行客户端**的说明，质押时也需要执行客户端。建议同样选择份额最低的执行客户端。

最后，请注意主网上可能存在排队验证的情况。查看此处：https://validator-queue-monitoring.vercel.app。

Somer Esat

<br/>

## 主网质押指南 ##

使用这些指南进行以太坊主网质押。

| 指南 <img width=150/> | 更新日志 *(日-月-年)* <img width=450/> |
| :--------- | :---------- |
| [Lighthouse](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lighthouse-773f5d982e03) | <br> *20-08-24* - 添加了 Reth 执行客户端。 <br> *18-08-24* - 更新 Lighthouse 客户端至 5.3.0。 <br> *19-06-24* - 更新 Lighthouse 客户端至 5.2.0。 <br> *18-06-24* - 更新 Besu 客户端至 24.5.4。 <br> *09-06-24* - 更新 Nethermind 配置，添加修剪标志。 <br> *09-06-24* - 更新 Nethermind 配置，移除 Sync.AncientBodies/Receipts 标志。 <br> *09-06-24* - 更新 Nethermind 客户端至 1.26.0。 <br> *09-06-24* - 更新 Geth 客户端至 1.14.5。 <br> *09-06-24* - 更新 Erigon 客户端至 2.6.1。 <br> *02-06-24* - 更新 Erigon 客户端至 2.6.0。 <br> *02-06-24* - 根据[问题 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)移除 Erigon 已弃用配置标志 --externalcl。 <br> *02-06-24* - 更新 Erigon 配置，使用预编译二进制文件。 <br> *02-06-24* - 移除冗余的 Erigon 先决条件。 <br> *30-05-24* - 更新 Besu 客户端至 24.5.2 并修复 Besu 配置标志部分的断链。 <br> *30-05-24* - 更新 Besu 配置，根据[#6405](https://github.com/hyperledger/besu/pull/6405)将 X_SNAP 重命名为 SNAP。 <br> *30-05-24* - 更新 Besu 先决条件，要求 Java Runtime v21（无头）。 <br> *14-04-24* - 添加目录。 <br> *14-04-24* - Ubuntu 服务器版本升级至 22.04。 <br> 参见 [更新日志存档](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)。 |
| [Lodestar](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-lodestar-193a2553a161) | <br> *20-08-24* - 添加了 Reth 执行客户端。 <br> *11-08-24* - 修正 Lodestar 版本发布链接错误。 <br> *18-06-24* - 移除冗余的 Lodestar 先决条件（NodeJS 和 build-essential）。 <br> *18-06-24* - 更新 Lodestar 配置，使用预编译二进制文件。 <br> *18-06-24* - 更新 Lodestar 客户端至 1.19.0。 <br> *18-06-24* - 更新 Besu 客户端至 24.5.4。 <br> *18-06-24* - 更新 Nethermind 配置，添加修剪标志。 <br> *18-06-24* - 更新 Nethermind 配置，移除 Sync.AncientBodies/Receipts 标志。 <br> *18-06-24* - 更新 Nethermind 客户端至 1.26.0。 <br> *18-06-24* - 更新 Geth 客户端至 1.14.5。 <br> *18-06-24* - 更新 Erigon 客户端至 2.6.1。 <br> *02-06-24* - 更新 Erigon 客户端至 2.6.0。 <br> *02-06-24* - 根据[问题 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)移除 Erigon 已弃用配置标志 --externalcl。 <br> *02-06-24* - 更新 Erigon 配置，使用预编译二进制文件。 <br> *02-06-24* - 移除冗余的 Erigon 先决条件。 <br> *30-05-24* - 更新 Besu 客户端至 24.5.2 并修复 Besu 配置标志部分的断链。 <br> *30-05-24* - 更新 Besu 配置，根据[#6405](https://github.com/hyperledger/besu/pull/6405)将 X_SNAP 重命名为 SNAP。 <br> *30-05-24* - 更新 Besu 先决条件，要求 Java Runtime v21（无头）。 <br> *27-04-24* - 添加目录。 <br> *27-04-24* - Ubuntu 服务器版本升级至 22.04。 <br> 参见 [更新日志存档](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)。 |
| [Prysm](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-prysm-581fb1969460) | <br> *20-08-24* - 添加了 Reth 执行客户端。 <br> *24-06-24* - 更新 Prysm 客户端至 5.0.4。 <br> *19-06-24* - 更新 Prysm 客户端至 5.0.3。 <br> *18-06-24* - 更新 Besu 客户端至 24.5.4。 <br> *18-06-24* - 更新 Nethermind 配置，添加修剪标志。 <br> *18-06-24* - 更新 Nethermind 配置，移除 Sync.AncientBodies/Receipts 标志。 <br> *18-06-24* - 更新 Nethermind 客户端至 1.26.0。 <br> *18-06-24* - 更新 Geth 客户端至 1.14.5。 <br> *18-06-24* - 更新 Erigon 客户端至 2.6.1。 <br> *02-06-24* - 更新 Erigon 客户端至 2.6.0。 <br> *02-06-24* - 根据[问题 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)移除 Erigon 已弃用配置标志 --externalcl。 <br> *02-06-24* - 更新 Erigon 配置，使用预编译二进制文件。 <br> *02-06-24* - 移除冗余的 Erigon 先决条件。 <br> *30-05-24* - 更新 Besu 客户端至 24.5.2 并修复 Besu 配置标志部分的断链。 <br> *30-05-24* - 更新 Besu 配置，根据[#6405](https://github.com/hyperledger/besu/pull/6405)将 X_SNAP 重命名为 SNAP。 <br> *30-05-24* - 更新 Besu 先决条件，要求 Java Runtime v21（无头）。 <br> *27-04-24* - 添加目录。 <br> *27-04-24* - Ubuntu 服务器版本升级至 22.04。 <br> 参见 [更新日志存档](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)。 |
| [Nimbus](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-nimbus-31f56657ea8f) | <br> *20-08-24* - 添加了 Reth 执行客户端。 <br> *24-06-24* - 更新 Nimbus 客户端至 24.6.0。 <br> *19-06-24* - 更新 Nimbus 客户端至 24.5.0。 <br> *18-06-24* - 更新 Besu 客户端至 24.5.4。 <br> *18-06-24* - 更新 Nethermind 配置，添加修剪标志。 <br> *18-06-24* - 更新 Nethermind 配置，移除 Sync.AncientBodies/Receipts 标志。 <br> *18-06-24* - 更新 Nethermind 客户端至 1.26.0。 <br> *18-06-24* - 更新 Geth 客户端至 1.14.5。 <br> *18-06-24* - 更新 Erigon 客户端至 2.6.1。 <br> *02-06-24* - 更新 Erigon 客户端至 2.6.0。 <br> *02-06-24* - 根据[问题 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)移除 Erigon 已弃用配置标志 --externalcl。 <br> *02-06-24* - 更新 Erigon 配置，使用预编译二进制文件。 <br> *02-06-24* - 移除冗余的 Erigon 先决条件。 <br> *30-05-24* - 更新 Besu 客户端至 24.5.2 并修复 Besu 配置标志部分的断链。 <br> *30-05-24* - 更新 Besu 配置，根据[#6405](https://github.com/hyperledger/besu/pull/6405)将 X_SNAP 重命名为 SNAP。 <br> *30-05-24* - 更新 Besu 先决条件，要求 Java Runtime v21（无头）。 <br> *27-04-24* - 添加目录。 <br> *27-04-24* - Ubuntu 服务器版本升级至 22.04。 <br> 参见 [更新日志存档](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)。 |
| [Teku](https://someresat.medium.com/guide-to-staking-on-ethereum-ubuntu-teku-f09ecd9ef2ee) | <br> *20-08-24* - 添加了 Reth 执行客户端。 <br> *19-06-24* - 更新 Teku 先决条件，要求 Java Runtime v21（无头）。 <br> *19-06-24* - 更新 Teku 客户端至 24.6.0。 <br> *18-06-24* - 更新 Besu 客户端至 24.5.4。 <br> *18-06-24* - 更新 Nethermind 配置，添加修剪标志。 <br> *18-06-24* - 更新 Nethermind 配置，移除 Sync.AncientBodies/Receipts 标志。 <br> *18-06-24* - 更新 Nethermind 客户端至 1.26.0。 <br> *18-06-24* - 更新 Geth 客户端至 1.14.5。 <br> *18-06-24* - 更新 Erigon 客户端至 2.6.1。 <br> *02-06-24* - 更新 Erigon 客户端至 2.6.0。 <br> *02-06-24* - 根据[问题 13](https://github.com/SomerEsat/ethereum-staking-guides/issues/13)移除 Erigon 已弃用配置标志 --externalcl。 <br> *02-06-24* - 更新 Erigon 配置，使用预编译二进制文件。 <br> *02-06-24* - 移除冗余的 Erigon 先决条件。 <br> *30-05-24* - 更新 Besu 客户端至 24.5.2 并修复 Besu 配置标志部分的断链。 <br> *30-05-24* - 更新 Besu 配置，根据[#6405](https://github.com/hyperledger/besu/pull/6405)将 X_SNAP 重命名为 SNAP。 <br> *30-05-24* - 更新 Besu 先决条件，要求 Java Runtime v21（无头）。 <br> *18-05-24* - 添加目录。 <br> *18-05-24* - Ubuntu 服务器版本升级至 22.04。 <br> 参见 [更新日志存档](https://github.com/SomerEsat/ethereum-staking-guides/blob/master/ChangeLogArchive.md)。 |

<br/>

## 更新提现凭证指南 ##

质押者可使用此指南将其验证者的提现凭证从 0x00 更新为 0x01。

| 指南 | 更新日志 *(日-月-年)* <img width=450/> |
| :--------- | :---------- |
| [以太坊提现凭证配置指南](https://someresat.medium.com/guide-to-configuring-withdrawal-credentials-on-ethereum-812dce3193a) | <br> *14-04-24* - 添加目录。 <br> *12-11-23* - 修复多个断链。 <br> *16-04-23* - 修正拼写错误并在提交和广播前添加额外警告。 <br> *13-04-23* - 多项更新以提升可读性。 <br> *12-04-23* - 添加 Beaconcha.in 提交成功示例消息。 <br> *11-04-23* - 发布。 |

<br/>

## 感谢捐赠 ##

Somer.eth (0x32B74B90407309F6637245292cd90347DE658A37)

<br/>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---