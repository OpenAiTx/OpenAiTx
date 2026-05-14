<div align="center">
  <img src="https://raw.githubusercontent.com/dreamwing/clawbridge/master/public/app-icon.png" width="120" alt="ClawBridge Logo" />
  <h1>ClawBridge 仪表盘</h1>
  <p><strong>OpenClaw 移动仪表盘与任务控制中心。</strong></p>

  <a href="https://clawbridge.app">
    <img src="https://img.shields.io/badge/Website-clawbridge.app-3b82f6?style=for-the-badge&logo=google-chrome&logoColor=white" alt="Website" />
  </a>
  <a href="https://github.com/openclaw/openclaw">
    <img src="https://img.shields.io/badge/OpenClaw-Compatible-22c55e?style=for-the-badge&logo=robot-framework&logoColor=white" alt="OpenClaw" />
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-fab005?style=for-the-badge" alt="License" />
  </a>
  
  <br/><br/>
  [ <strong>English</strong> | <a href="README_CN.md">简体中文</a> ]
</div>

---

**ClawBridge** 是 OpenClaw 代理的终极 **移动仪表盘**。它是你口袋中的 **任务控制中心**——随时随地安全且即时地监控实时思考、跟踪令牌成本及管理后台任务。

## ✨ 主要功能

*   **📱 移动优先仪表盘**：为手机屏幕优化。无需眯眼即可查看日志、统计和控制。
*   **🧠 实时活动流**：实时观看代理“思考”并执行工具。具备智能并行日志记录（不会遗漏后台任务）和去重功能。
*   **💰 令牌经济**：跟踪每日/月度大型语言模型成本和使用趋势。清楚了解资金去向。
*   **🔍 [成本控制中心](https://raw.githubusercontent.com/dreamwing/clawbridge/master/docs/cost-control-center.md)**：10 个自动诊断扫描你的使用情况，计算节省金额，并可一键应用优化。API 成本可降低 30–90%。
*   **📜 记忆时间线**：浏览代理的每日日志和长期记忆演变。
*   **🚀 任务控制中心**：可直接通过 UI 触发定时任务、重启服务或终止失控脚本。
*   **⚡ 零配置远程**： 
    *   **自动端口**：若 3000 端口被占用，自动寻找可用端口。
    *   **智能网络**：自动检测 **Tailscale/WireGuard** 实现直接安全访问。
    *   **快速隧道**：若未找到 VPN，自动通过 Cloudflare 生成临时公共 URL（零配置）。

## 🚀 安装

在你的 OpenClaw 服务器（Ubuntu/Debian）上运行此单行命令：

```bash
curl -sL https://clawbridge.app/install.sh | bash
```
就是这样。脚本将会：
1.  检测您的环境（VPN 或公共网络）。
2.  生成一个安全的访问密钥。
3.  给您一个即用型的 URL。

## 📱 使用方法

### 1. 零配置访问（默认）
如果您只是想试用，安装程序提供一个**快速隧道**URL：
`https://<random-name>.trycloudflare.com/?key=<YOUR_KEY>`

*   **优点**：随时随地即时访问。
*   **缺点**：服务重启后 URL 会改变。

### 2. VPN 直接访问（隐私优先）
如果检测到 **Tailscale** 或 **WireGuard**，安装程序会跳过公共隧道，给您一个私有链接：
`http://<VPN_IP>:3000/?key=<YOUR_KEY>`

*   **优点**：速度最快，隐私最高。
*   **缺点**：您的手机必须连接到 VPN。

### 3. 永久公共域名（高级）
想要一个固定的 URL，比如 `dash.yoursite.com`？
1.  从 [Cloudflare Dash \> 网络 \> 隧道](https://dash.cloudflare.com/?to=/:account/tunnels) 获取一个 **Cloudflare 隧道令牌**。
2.  使用该令牌运行安装程序：

    ```bash
    cd skills/clawbridge
    ./install.sh --token=<YOUR_TOKEN>
    ```
    *   或强制创建一个新的快速隧道：`./install.sh --force-cf`
3.  安装成功后，返回 Cloudflare 隧道的 **Public Hostname**（或 **Routes**）页面，点击 **Add a public hostname**，将您自己的域名绑定到 `localhost:3000`，以实现永久访问。

### 4. Docker（容器化）
您可以将 ClawBridge 作为 Docker 容器运行。镜像会自动发布到 [GitHub Container Registry (ghcr.io)](https://github.com/dreamwing/clawbridge/pkgs/container/clawbridge)。
```bash
docker pull ghcr.io/dreamwing/clawbridge:latest
docker run -d --name clawbridge \
  -p 3000:3000 \
  -e ACCESS_KEY=your_secret_key \
  -e OPENCLAW_STATE_DIR=/openclaw \
  -e OPENCLAW_WORKSPACE=/openclaw/workspace \
  -v ~/.openclaw:/openclaw:ro \
  -v ./data:/app/data \
  ghcr.io/dreamwing/clawbridge:latest
```

## 📱 移动应用 (PWA)
1.  在 Safari（iOS）或 Chrome（Android）中打开仪表板。
2.  点击“分享” -> “添加到主屏幕”。
3.  像原生应用一样启动它（全屏，无浏览器栏）。

## 🛠️ 技术栈
*   **后端**：Node.js（Express，WebSocket）- 轻量级旁车进程。
*   **前端**：原生 JS - 零构建步骤，瞬时加载。
*   **隧道**：Cloudflared

## 致谢

特别感谢我们的社区帮助改进 ClawBridge：
- [@yaochao](https://github.com/yaochao) 报告了关键的安全性和可移植性问题，并建议架构重构（#1，#2，#3，#4，#5，#6，#7）。
- [@斯图超哥](https://x.com/StewartLi666) 对 Linux 兼容性、IP 识别稳定性和快速隧道刷新逻辑提供反馈（#12）。
- [@zjy4fun](https://github.com/zjy4fun) 在工作区检测修复中提供了宝贵贡献（PR #22）。
- [@chrisuhg](https://github.com/chrisuhg) 在解决安装和认证循环问题中提供了宝贵贡献（Issue #19）。
- [@ForceConstant](https://github.com/ForceConstant) 在功能请求：版本化 Docker 镜像（#24）（Issue #24）中提供了宝贵贡献。

---
*MIT 许可证。为 OpenClaw 社区构建。*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---