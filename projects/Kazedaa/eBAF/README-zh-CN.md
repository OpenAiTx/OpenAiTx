# eBAF - 基于 eBPF 的广告防火墙
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF 广告防火墙横幅" width="600"/>
</p>

## “你不会下载广告”
### 但你一定会屏蔽广告！

Spotify 靠着一个简单的公式建立了自己的帝国：将你的注意力变现、给艺术家支付极低的报酬，并把你自己的时间作为高级功能再卖给你。
在他们的世界里，你的聆听体验并不属于你。这是一个精心策划的市场——你的耳朵是产品，你的耐心是货币。

他们喜欢称之为“免费”套餐。
但说实话：如果你用时间来支付，这根本不算免费。

与此同时，你喜爱的艺术家——那些让平台得以存活的人——往往每次播放只能赚到几分钱的零头。Spotify 获利丰厚，广告商得到了曝光，而创作者呢？他们只分得一点残羹冷炙。

这不仅仅是跳过几个烦人的广告。
这是拒绝参与一个以剥削、分心和将注意力商品化为盈利模式的系统。

#### 这是什么？
一个优雅的小型数字反抗行为：一个干净、开源的 Spotify 广告拦截器，真正让噪音停止——字面意义上。

没有可疑的修改版，没有破解的客户端，没有伪装成自由的恶意软件。只有一个目标：让音乐自由播放，不再被广告绑架。

Spotify 并不是免费的——你用耐心来“付费”。

他们一遍又一遍地向你轰炸同样刺耳的广告，直到你放弃并订阅。不是因为你爱上了 Premium，而是因为你被磨得精疲力尽。这不是“免费增值”，而是带着歌单的心理战。

与此同时，艺术家们呢？依然收入微薄。
广告呢？更吵、更频繁。有时候真的更大声。
你呢？只是想感受音乐的氛围。

他们从你的耐心和对创作者的低报酬中获利，还假装这是唯一可持续的方式。剧透一下：并不是。他们本可以选择，但他们选择了利润率而不是人。

Spotify 想让你相信，这就是获取音乐的代价。
而我们认为，这是一场谎言。

我们不是盗版者。我们不是罪犯。我们只是觉得，应该可以划出一条界线。

这个项目的意义，不只是跳过几个广告。它是对一个体系的拒绝——这个体系认为你的沉默可以被出售，你的体验可以被打断，你的价值只有在你打开钱包时才开始。

屏蔽广告不是盗窃。<br>
偷走你的时间才是。<br>
我们不是来盗版的，我们是来选择退出的。<br>
<br>
**你不会下载一个广告，但你会屏蔽一个广告。**
## eBAF 如何工作？

eBAF（eBPF 广告防火墙）利用 eBPF（扩展伯克利数据包过滤器）的强大功能，在内核级别屏蔽不需要的广告。以下是其功能的高层次概述：

## eBAF 如何工作？

eBAF（eBPF 广告防火墙）高效利用 eBPF（扩展伯克利数据包过滤器），在内核级别屏蔽广告。以下是简要说明：

1. **数据包过滤**：
   - 检查传入的网络数据包，并使用 XDP（eXpress Data Path）阻止那些与黑名单 IP 地址匹配的数据包。

2. **动态更新**：
   - 将域名解析为 IP 地址，并动态更新黑名单，以应对广告服务器的变化。

3. **网页仪表盘**：
   - 通过用户友好的界面提供实时统计和监控。

4. **高性能**：
   - 直接在网络接口层运行，绕过内核网络协议栈，实现更快的处理速度和极低的资源占用。

eBAF 结合了高效性、透明性和易用性，提供了一套强大的广告屏蔽解决方案。
## 简单安装（推荐）
请确保已安装 git 和 curl
```bash
git --version
curl --version
```
### 安装
#### 启用 Spotify 集成（推荐）
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### 明确禁用
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### 卸载
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## 开发环境安装

运行以下命令以安装所需依赖项：

### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### 运行 eBPF 代码时修复 asm/types.h 错误
检查当前的链接
`ls -l /usr/include/asm`
查找正确的链接
`find /usr/include -name "types.h" | grep asm`
修复符号链接
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### 构建项目

要构建 eBPF Adblocker，请按照以下步骤操作：

1. 克隆仓库：
   ```bash
   git clone <repository-url>
   cd eBAF
   ```

2. 构建项目：
   ```bash
   make
   ```

3. （可选）系统范围内安装：
   ```bash
   sudo make install
   ```

4. 其他安装选项（帮助台）
    ```bash
    make help
    ````
5. 卸载
    ```bash
    make uninstall
    ````

## 使用方法

### 运行广告拦截器
    默认使用 spotify-stable.txt 作为黑名单。
    用法：ebaf [选项] [网络接口...]
    选项：
    -a, --all               在所有活动网络接口上运行
    -d, --default           仅在默认网络接口（有互联网访问权限）上运行
    -i, --interface IFACE   指定要使用的网络接口
    -D, --dash              启动 Web 仪表盘 (http://localhost:8080)
    -q, --quiet             静音模式（不输出信息）
    -h, --help              显示此帮助信息

### 配置黑名单
编辑列表以添加或移除域名。每个域名应单独占一行。注释以 `#` 开头。

## 致谢

特别感谢 ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

提供了 Spotify 广告拦截列表
## ⭐️ 支持该项目

如果您觉得 eBAF 有用，请考虑在 GitHub 上为该仓库加星！您的支持有助于提高项目的可见度并鼓励后续开发。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---