
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

**通过无情地精简预装臃肿，将你的 GitHub Actions runner 转变为 [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ 的强大引擎。**

GitHub Actions runner 为 Nix 提供的磁盘空间十分有限——仅有约 20GB。
*Nothing but Nix* **会彻底清理**不必要的软件，为你的 Nix store 腾出 **65GB 到 130GB** 空间！💪

## 用法 🔧

在工作流程中安装 Nix **之前**添加此操作：

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
- 必须在安装 Nix 之前运行
- **macOS/Darwin 运行器**：如果在 macOS 上运行，此操作将以警告信息优雅地跳过。macOS 运行器已为 Nix 提供了足够的空间，无需此操作
- **Windows 运行器**：如果在 Windows 上运行，此操作将以警告信息优雅地跳过。Windows 运行器的文件系统结构和限制不同

## 问题：为 Nix 腾出空间 🌱

标准的 GitHub Actions 运行器中充满了你在 Nix 工作流中永远不会用到的 *“臃肿软件”*：

- 🌍 各种网页浏览器，应有尽有，非要全装！
- 🐳 Docker 镜像，占用数 GB 宝贵磁盘空间
- 💻 不必要的语言运行环境（.NET、Ruby、PHP、Java……）
- 📦 积灰的软件包管理器
- 📚 没人会看的文档

这些臃肿内容让你的 Nix 存储区只剩下 ~20GB——对于严肃的 Nix 构建来说，几乎不够用！😞

## 解决方案：只为 Nix ️❄️

**Nothing but Nix** 对 GitHub Actions 运行器采取焦土政策，通过两步攻击无情回收磁盘空间：

1. **初始切割：** 立即从 `/mnt` 释放空间，创建一个大型 `/nix` 卷（约 65GB）
2. **后台清扫：** 在你的工作流继续执行时，彻底清理无用软件，将 `/nix` 卷空间扩展至约 130GB
   - 浏览器？不要 ⛔
   - Docker 镜像？删除 🗑️
   - 语言运行环境？彻底移除 💥
   - 包管理器？彻底清除 💣
   - 文档？直接消失 ️👻

文件系统清理由 `rmz`（来自 [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) 项目）驱动——这是 `rm` 的高性能替代品，让空间回收飞快完成！⚡
   - 性能比标准 `rm` 高一个数量级
   - 并行处理删除任务，效率最大化
   - **几秒钟而不是几分钟内回收磁盘空间！** ️⏱️

最终结果？你的 GitHub Actions 运行器将拥有 **65GB 到 130GB** Nix 可用空间！😁

### 动态卷扩展
与其他方案不同，**Nothing but Nix** 会动态扩展你的 `/nix` 卷：

1. **初始卷创建（1-10秒）：**（*取决于 Hatchet Protocol*）
   - 从 `/mnt` 的空闲空间创建一个环回设备
   - 设置 RAID0 配置的 BTRFS 文件系统
   - 挂载时启用压缩和性能优化
   - 即使清理尚未开始，也能立即提供 65GB 的 `/nix`

2. **后台扩展（30-180秒）：**（*取决于 Hatchet Protocol*）
   - 执行清理操作
   - 随着冗余被消除，监控新释放的空间
   - 动态将扩展磁盘添加到 `/nix` 卷
   - 重新平衡文件系统以整合新空间

`/nix` 卷会在工作流执行期间**自动增长** 🎩🪄

### 选择你的武器：Hatchet Protocol 🪓

通过 `hatchet-protocol` 输入控制清除级别 💥：


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
当 `nix-permission-edict` 设置为 `true` 时，该操作将在挂载 `/nix` 后运行 `sudo chown -R "$(id --user)":"$(id --group)" /nix`。

### 配置 Nix 以使用 /nix/build

此操作会创建 `/nix/build`，供 Nix 派生构建使用已回收的空间。请在你的 Nix 配置中添加 `build-dir`：


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

或者使用 DeterminateSystems：

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

这会指示 Nix 在大型 BTRFS 卷上执行构建，而不是系统默认的临时目录。

## 故障排除 🔍

### 大型构建时出现“No space left on device”

如果你的构建在仅使用 Nix 的情况下仍然空间耗尽，很可能是后台清理工作在你的构建消耗可用空间之前尚未完成。这通常影响以下情况：

- 组装大型磁盘镜像的 NixOS 虚拟机测试
- 没有缓存的依赖项较多的构建
- Rust 工具链及其他大型编译

**解决方法：** 使用 `witness-carnage: true` 强制同步清理。这样可以确保所有空间在构建开始*之前*被回收：

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```
这会为你的工作流程设置增加30-180秒，但能确保在构建开始时有最大的空间可用。

现在，去利用所有那充足的Nix存储空间，构建令人惊叹的项目吧！❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---