# 🎫 BiliTickerStorm

## ⚙️ Service Description

| Service Name         | Description                        | Remarks          |
| -------------------- | ---------------------------------- | ---------------- |
| `ticket-master`      | Main control service, responsible for scheduling tasks | Single instance deployment |
| `ticket-worker`      | Ticket grabbing worker, horizontally scalable | Supports multiple instances |
| `gt-python`          | Graphical captcha processing service | Single instance deployment |

---

## 🚀 Quick Deployment Steps

> For cluster setup, refer to [Cluster Setup Guide](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md).

<details> <summary><strong>📦 Remote Repository Installation (Recommended)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Install the Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` is the directory for the ticketing configuration file, mounted for use by the `ticket-master` container. The ticketing configuration file can be generated using https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` is the Pushplus notification configuration. After setting, you can receive ticketing result notifications.
> - `ticketWorker.ticketInterval` is the ticketing interval in milliseconds, default is 300 milliseconds.
> - `ticketWorker.ticketTimeStart` is the scheduled start time, formatted as `2025-05-20T13:14`. If not set, ticketing will start immediately when the container starts.

### 3. Upgrade the Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details>
<details> <summary><strong>📦 Local Chart Installation</strong></summary>


### 1. Install Chart

```bash
# Clone the repository
git clone https://github.com/mikumifa/biliTickerStorm
# Use the local Chart package
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Upgrade Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 General Commands</strong></summary>

### ⏹ Uninstall
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Disclaimer

This project follows the MIT License agreement and is for personal learning and research purposes only. Do not use this project for any commercial profit-making activities, and it is strictly prohibited to use it for any form of scalping, illegal activities, or any uses that violate the rules of relevant platforms. All consequences arising from such use shall be borne by the user and are unrelated to the author.

If you fork or use this project, please be sure to comply with relevant laws, regulations, and the target platform’s rules.

## 💡 About Access Frequency and Concurrency Control
This project is designed with a strict "non-intrusive" principle to avoid causing any interference to target servers (such as Bilibili).

All network request intervals are user-configurable, with default values simulating the manual operation speed of normal users. The program runs in single-threaded mode by default, with no concurrent tasks. If a request fails, the program will retry a limited number of times, introducing appropriate delays between retries to avoid high-frequency access. The project relies entirely on publicly available platform interfaces and webpage structures, and does not include any destructive means such as risk control evasion or API hijacking.
## 🛡️ Platform Respect Statement

This program has been designed to control request frequency as much as possible, in order to avoid causing any significant load or impact on Bilibili's servers. The project is for learning purposes only, does not have large-scale or high-concurrency capabilities, and has no malicious intent or purpose to disrupt services.

If there is any content in this project that infringes upon the legitimate rights and interests of Bilibili, please contact me via email at [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). I will immediately remove the relevant content and delete this repository. I sincerely apologize for any inconvenience this may cause, and thank you for your understanding and tolerance.

## 📄 License

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---