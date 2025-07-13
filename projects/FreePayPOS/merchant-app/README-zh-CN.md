# NFC支付终端

一个多链NFC支付终端，可处理5个区块链网络的加密货币支付，具备实时交易监控和全面历史追踪功能。

## 🌐 支持的网络

- **以太坊（Ethereum）**
- **Base** 
- **Arbitrum** 
- **Optimism** 
- **Polygon** 

### 🎯 **智能支付优先级**

无需与商户协商链/代币组合，支付终端会自动处理。它会首先确定一个商户支持且你也有资金的链，然后按照以下优先级用ETH或ERC-20代币发起交易：

```
L2 稳定币 > L2 其他 > L2 ETH > L1 稳定币 > L1 其他 > L1 ETH
```
## 🚀 快速开始

1. **安装依赖：**
   ```bash
   npm install
   ```

2. **环境配置：**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **运行终端：**
   ```bash
   npm start
   ```

4. **打开界面：**
   访问 `http://localhost:3000`

## 🏗️ 架构

```
src/
├── server.ts                   # Express 服务器 & WebSocket 处理器
├── app.ts                      # 主应用程序协调器
├── web/index.html              # 支付终端界面
├── config/index.ts             # 多链配置
└── services/
    ├── nfcService.ts           # NFC 读卡器 & 钱包扫描
    ├── alchemyService.ts       # 多链余额 & 监控
    ├── paymentService.ts       # 支付选择 & EIP-681 生成
    ├── ethereumService.ts      # 地址验证工具
    └── addressProcessor.ts     # 防止重复处理
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # 安装依赖以支持构建树莓派镜像
    └── build-pi-image-osx.sh       # 构建树莓派镜像
```

## 💡 使用方法

### **处理支付**
1. 使用键盘输入金额（以分为单位："150" = ¥1.50）
2. 点击“收款”以发起支付
3. 顾客将NFC设备轻触以发送支付
4. 实时监控确认交易
5. 显示“已批准”消息并附带区块浏览器链接

### **交易历史**
1. 在键盘上点击📜历史按钮
2. 查看所有交易，或扫描钱包以获取特定历史记录
3. 点击“📱扫描钱包查看历史”，让顾客轻触他们的设备
4. 浏览该特定钱包的筛选交易记录


## 🔄 支付流程

1. **NFC检测** → 顾客轻触设备
2. **多链查询** → 跨6条链的资产组合分析
3. **智能选择** → 基于优先级系统的最优支付代币
4. **EIP-681生成** → 带链ID的支付请求
5. **实时监控** → 通过WebSocket/轮询方式确认交易
6. **历史记录** → 交易及全部元数据被保存
## 🛡️ 交易监控

- 针对 Ethereum、Base、Arbitrum、Optimism、Polygon 的 **WebSocket 监控**
- **基于轮询的监控** 作为备选
- **自动超时**，5 分钟后触发
- **区块浏览器集成** 用于交易验证
- **状态跟踪**：已检测 → 已确认 → 失败

## 🍓 树莓派部署

该 NFC 支付终端可作为**即插即用自助机**在树莓派硬件上进行生产部署。

### **硬件要求**
- 树莓派 4B（推荐 4GB 及以上内存）
- 7 英寸官方树莓派触摸屏
- **ACR1252U-M1 NFC 读卡器**（专门支持）
- 32GB 及以上 MicroSD 卡

### **部署特性**
- **一键构建**，生成可启动的 SD 卡镜像
- **预配置 WiFi** 和 API 凭证
- **自动启动**，全屏自助机模式
- **安全验证**，防止使用测试地址部署
- **支持 macOS 和 Linux** 构建
### **快速部署**
```bash
# 进入部署脚本目录
cd scripts/rpi-deploy

# 配置你的部署环境
cp build-config.env.template build-config.env
# 用你的 WiFi、API 密钥和商户地址编辑 build-config.env 文件

# 构建可启动镜像（macOS）
./build-pi-image-osx.sh

# 使用 Raspberry Pi Imager 将生成的 nfc-terminal-<date>.img.gz 文件写入 SD 卡并启动！
```

📖 **[完整部署指南](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---