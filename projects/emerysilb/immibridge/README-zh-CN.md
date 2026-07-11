<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/icon-transparent.png" alt="ImmiBridge" width="128">
</p>

<h1 align="center">ImmiBridge</h1>

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.apple.com/macos/"><img src="https://img.shields.io/badge/macOS-12.0+-blue.svg" alt="macOS"></a>
</p>

<p align="center">
  <a href="https://github.com/emerysilb/immibridge/releases/"><img src="https://img.shields.io/badge/Download-Latest%20Release-blue?style=for-the-badge" alt="Download latest release"></a>
</p>

将您的 Apple 照片库备份到按拍摄日期组织的文件夹，或直接备份到 [Immich](https://immich.app) 服务器。导出原始文件（包括 Live Photo 配对视频）和可选的渲染编辑版本。

<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/screenshot.png" alt="ImmiBridge Screenshot" width="700">
</p>

## 功能

- 导出照片到按日期组织的本地文件夹
- 直接上传到 Immich 照片服务器
- 增量、完整或镜像备份模式
- 按相册、媒体类型或日期过滤
- 暂停和恢复备份
- 定时自动备份
- 菜单栏集成
- iCloud 照片下载并带进度跟踪
- 仅元数据同步（更新元数据而不重新上传文件）
- 通过 Sparkle 自动更新

## 安装

### 下载（推荐）

1. 从 [Releases](../../releases) 页面下载 `ImmiBridge-x.x.x.dmg`
2. 打开 DMG 并将 ImmiBridge 拖动到您的应用程序文件夹中
3. 从应用程序中启动 ImmiBridge  
4. 提示时授予照片访问权限  

### 从源代码构建  

请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) 获取详细的构建说明。  

**快速开始：**

```bash
# Clone the repository
git clone https://github.com/emerysilb/immibridge.git
cd immibridge

# Open in Xcode
open ImmiBridge/ImmiBridge.xcodeproj
```

### 构建签名版本

要构建用于分发的经过公证的 DMG，您需要一个 Apple 开发者 ID 证书（每年 99 美元）。详情请参见 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md#creating-a-signed-release)。

## 使用方法

启动 ImmiBridge 并配置：

1. **源**：选择照片库和/或自定义文件夹
2. **目标**：本地文件夹和/或 Immich 服务器
3. **选项**：备份模式、过滤器、调度

### 备份模式

| 模式 | 导出内容 | 使用清单 | 从目标删除 |
|------|----------|----------|------------|
| **智能增量** | 仅新文件/已更改文件 | 是 | 否 |
| **完整** | 每次全部导出 | 否 | 否 |
| **镜像** | 仅新文件/已更改文件 | 是 | 是（孤立文件） |

### Immich 集成

连接到您的 Immich 服务器：

1. 转到 **目标** 标签页
2. 输入您的 Immich 服务器 URL（例如，`http://192.168.1.100:2283`）
3. 输入您的 API 密钥（在 Immich 的用户设置 → API 密钥中生成）
4. 点击 **测试连接**

**功能：**
- 使用 SHA1 校验和避免重复上传
- 实时照片作为配对的视频+静态图像上传
- 支持同步相册到 Immich

## 权限

首次运行时，macOS 会提示：

- **照片访问权限**：读取您的照片库所必需
- **本地网络访问**：如果您的 Immich 服务器位于本地网络中，则需要此权限

如果您拒绝了某个权限，可以在 **系统设置 → 隐私与安全** 中重新启用。

## 贡献

欢迎贡献！请参阅 [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) 了解指南。

## 许可证

MIT 许可证 - 详情请见 [LICENSE](LICENSE)。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---