
# 🎫 BiliTickerStorm


## ⚙️ 服务说明

| 服务名             | 说明              | 备注    |
| --------------- | --------------- | ----- |
| `ticket-master` | 主控服务，负责调度任务     | 单实例部署 |
| `ticket-worker` | 抢票 worker，可横向扩展 | 支持多实例 |
| `gt-python`     | 图形验证码处理服务       | 单实例部署 |

---

## 🚀 快速部署步骤

> 集群搭建可以参考 [集群搭建指南](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md)。

<details> <summary><strong>📦 远程仓库安装（推荐）</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```

### 2. 安装 Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` 是抢票配置文件目录，挂载给 `ticket-master` 容器用。抢票配置文件生成使用 https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` 是plusplus 推送配置，设置后可以接收抢票结果通知。
> - `ticketWorker.ticketInterval` 是抢票间隔秒数，默认 300 毫秒。
> - `ticketWorker.ticketTimeStart` 是定时启动时间，格式为 `2025-05-20T13:14`，不填默认打开容器直接开始抢票。

### 3. 升级 Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
---
</details> 
<details> <summary><strong>📦 本地 Chart 安装</strong></summary>


### 1. 安装 Chart

```bash
# 克隆仓库
git clone https://github.com/mikumifa/biliTickerStorm
# 使用本地 Chart 包
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. 升级 Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 通用命令</strong></summary>

### ⏹ 卸载
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 免责声明

本项目遵循 MIT License 许可协议，仅供个人学习与研究使用。请勿将本项目用于任何商业牟利行为，亦严禁用于任何形式的代抢、违法行为或违反相关平台规则的用途。由此产生的一切后果均由使用者自行承担，与本人无关。

若您 fork 或使用本项目，请务必遵守相关法律法规与目标平台规则。

## 💡 关于访问频率与并发控制
本项目在设计时严格遵循「非侵入式」原则，避免对目标服务器（如 Bilibili）造成任何干扰。

所有网络请求的时间间隔均由用户自行配置，默认值模拟正常用户的手动操作速度。程序默认单线程运行，无并发任务。遇到请求失败时，程序会进行有限次数的重试，并在重试之间加入适当的延时，避免形成高频打点。项目完全依赖平台公开接口及网页结构，不含风控规避、API劫持等破坏性手段。

## 🛡️ 平台尊重声明

本程序设计时已尽可能控制请求频率，避免对 Bilibili 服务器造成任何明显负载或影响。项目仅作为学习用途，不具备大规模、高并发的能力，亦无任何恶意行为或干扰服务的企图。

如本项目中存在侵犯 Bilibili 公司合法权益的内容，请通过邮箱 [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) 与我联系，我将第一时间下架相关内容并删除本仓库。对此造成的不便，我深表歉意，感谢您的理解与包容。

## 📄 License

[MIT License](LICENSE)

