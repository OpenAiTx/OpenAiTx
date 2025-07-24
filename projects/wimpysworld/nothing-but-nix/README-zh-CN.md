
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**通过无情清除预装臃肿，将你的 GitHub Actions runner 变成 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 强力引擎。**

GitHub Actions runner 为 Nix 提供的磁盘空间非常有限——只有大约 20GB。
*Nothing but Nix* **会残酷地清理**不必要的软件，让你的 Nix 存储空间提升到 **65GB 到 130GB**！💪

## 用法 🔧

在工作流中安装 Nix **之前**，添加此 Action：

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```
### 要求 ️✔️

- 仅支持官方 **Ubuntu** GitHub Actions 运行器
- 必须在安装 Nix **之前** 运行

## 问题：为 Nix 的繁荣腾出空间 🌱

标准的 GitHub Actions 运行器装满了你在 Nix 工作流中永远不会用到的*“臃肿软件”*：

- 🌍 网络浏览器。很多。必须全部拥有！
- 🐳 占用数GB宝贵磁盘空间的 Docker 镜像
- 💻 不必要的语言运行时（.NET、Ruby、PHP、Java……）
- 📦 堆积数字灰尘的软件包管理器
- 📚 无人阅读的文档

这些臃肿软件只剩下大约 20GB 的空间给你的 Nix 存储——几乎不够进行严肃的 Nix 构建！😞

## 解决方案：唯有 Nix ️❄️

**唯有 Nix** 采用焦土策略对 GitHub Actions 运行器进行无情的磁盘空间回收，采用两阶段攻势：

1. **初步砍削：** 通过从 `/mnt` 夺取空闲空间，立即创建一个大型 `/nix` 卷（约 65GB）
2. **后台狂暴：** 在你的工作流继续运行时，我们无情地清除不必要的软件，将 `/nix` 卷扩展至约 130GB
   - 网络浏览器？不留 ⛔
   - Docker 镜像？清除 🗑️
   - 语言运行时？彻底销毁 💥
   - 软件包管理器？全数消灭 💣
   - 文档？蒸发 ️👻

文件系统清理由 `rmz`（来自 [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 项目）驱动——这是一个高性能的 `rm` 替代品，使空间回收速度快如闪电！⚡
   - 性能比标准 `rm` 高一个数量级
   - 并行处理删除操作以实现最大效率
   - **几秒钟内回收磁盘空间，而非几分钟！** ️⏱️

最终结果？一个拥有 **65GB 到 130GB** Nix 准备空间的 GitHub Actions 运行器！😁

### 动态卷增长

与其他方案不同，**唯有 Nix** 动态扩展你的 `/nix` 卷：

1. **初始卷创建（1-10 秒）：**（*取决于 Hatchet 协议*）
   - 从 `/mnt` 空闲空间创建环回设备
   - 设置 RAID0 配置的 BTRFS 文件系统
   - 以压缩和性能调优方式挂载
   - 立即提供 65GB `/nix`，甚至在清理开始前

2. **后台扩展（30-180 秒）：**（*取决于 Hatchet 协议*）
   - 执行清理操作
   - 监控消除臃肿后释放的新空间
   - 动态向 `/nix` 卷添加扩展磁盘
   - 重新平衡文件系统以纳入新空间

`/nix` 卷会在工作流执行期间自动**增长** 🎩🪄

### 选择你的武器：Hatchet 协议 🪓

通过 `hatchet-protocol` 输入控制灭绝程度 💥：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```
#### 协议比较 ⚖️

| 协议     | `/nix` | 描述                                             | 清理 apt   | 清理 docker | 清理 snap | 清理的文件系统          |
|----------|--------|--------------------------------------------------|------------|--------------|------------|-------------------------|
| Holster  | ~65GB  | 保持手斧套着，使用 `/mnt` 的空间                 | 否         | 否           | 否         | 无                      |
| Carve    | ~85GB  | 利用并合并 `/` 和 `/mnt` 的空闲空间              | 否         | 否           | 否         | 无                      |
| Cleave   | ~115GB | 对大型软件包进行有力且果断的裁剪                 | 最少       | 是           | 是         | `/opt` 和 `/usr/local`  |
| Rampage  | ~130GB | 无情、彻底地消除所有冗余                         | 激进       | 是           | 是         | 哇哈哈哈！ 🔥🌎          |

明智选择：
- **Holster** 当你需要运行器工具保持完全功能时
- **Carve** 保留功能性运行器工具，但为 Nix 争取所有空闲空间
- **Cleave** (*默认*) 平衡空间和功能的良好选择
- **Rampage** 当你需要最大 Nix 空间且不在意什么被破坏时 `#nix-is-life`

### 见证屠杀 🩸

默认情况下，清理过程会在后台静默执行，同时你的工作流程继续进行。但如果你想实时观看屠杀过程：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```
### 自定义安全区 🛡️

通过自定义安全区大小，控制从 Nix 存储区的占用空间：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
这些安全区定义了在空间回收过程中将被宽恕保留的空间大小（以MB为单位）：
- 默认的 `root-safe-haven` 为2048MB（2GB）
- 默认的 `mnt-safe-haven` 为1024MB（1GB）

如果您的文件系统需要更多的缓冲空间，可以增加这些值，或者减小它们以毫不留情地释放空间！😈

### 授予用户对 /nix 的所有权（Nix 权限法令）🧑‍⚖️

某些 Nix 安装程序或配置期望当前用户对 `/nix` 目录具有写权限。默认情况下，`/nix` 归 root 所有。如果您需要用户所有权（例如，对于某些不在 `/nix` 内所有操作都使用 `sudo` 的 Nix 安装脚本），可以启用 `nix-permission-edict`：


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
当 `nix-permission-edict` 设置为 `true` 时，操作将在挂载 `/nix` 后运行 `sudo chown -R "$(id --user)":"$(id --group)" /nix`。

现在，利用所有那辉煌的 Nix 存储空间去构建一些惊人的东西吧！❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---