# 🛡️ Azure & Office 365 安全报告

> **针对 Azure 和 Office 365 环境的综合 PowerShell 7 安全审计工具**

本项目提供一个模块化的只读安全评估脚本，帮助组织识别 Azure 和 Office 365 基础设施中的安全漏洞、合规性问题及成本优化机会。

<div align="center">
  
![菜单布局演示](https://raw.githubusercontent.com/SteffMet/Azure-Office365-Security-Reporting/main/MenuLayout.gif)
  
</div>

### 🛡️ 新增安全报告模块
| 模块 | 描述 |
|--------|-------------|
| **Azure 存储安全** | 发现公共 Blob 容器，验证加密，检查 HTTPS 强制执行，分析网络访问规则。 |
| **Azure 密钥保管库安全** | 监控证书过期，分析访问策略，验证网络限制，检查软删除/清除保护。 |
| **网络安全组 (NSG)** | 识别危险的防火墙规则、互联网暴露服务、SSH/RDP 暴露及数据库端口安全。 |
| **SharePoint 和 OneDrive 安全** | 分析外部共享、OneDrive 使用情况、数据丢失防护 (DLP) 策略及访客访问。 |
| **配置管理** | 支持加密凭据存储、自动连接、自定义导出路径及配置备份/恢复。 |
| **Teams 频道成员变更** | 报告所有 Teams 频道的当前成员，包括用户和访客。 |
| **SharePoint 站点存储使用情况** | 报告所有 SharePoint 站点的存储使用情况，突出配额和使用趋势。 |
| **Azure 资源标签合规** | 审核 Azure 资源所需标签及标签策略合规性。 |
| **OneDrive 共享链接审计** | 审计 OneDrive 共享链接，报告外部共享文件及访问级别。 |

### 📈 报告增强
- 5 个新的带时间戳的 CSV 报告。
- 基于风险的评分（关键/高/中/低）。
- 每个发现的安全建议。
- 高管摘要仪表板。

  
## 🌟 主要功能

### 🔐 Azure 安全审计
- **身份与访问管理 (IAM)**
  - 多因素身份验证 (MFA) 状态分析
  - 访客用户访问审核和报告
  - 密码过期策略评估
  - 条件访问策略评估

- **🛡️ 数据保护**
  - Azure 虚拟机 TLS 配置分析（Azure 资源图）
  - 虚拟机磁盘加密状态
  - 安全合规报告

- **🏗️ 基础设施安全**
  - Azure 存储帐户安全配置
  - 发现公共 Blob 容器
  - Azure 密钥保管库安全评估
  - 证书过期监控
  - 网络安全组 (NSG) 分析
  - 危险防火墙规则检测
  - Azure 资源标签合规：审核资源所需标签及合规性

### ☁️ Office 365 安全审计
- **📊 许可证管理**
  - 全面许可证使用分析
  - 成本优化建议
  - 未分配许可证检测和报告

- **👤 用户账户安全**
  - 非活跃账户检测（90 天以上）
  - 有许可证但非活跃账户识别
  - 安全风险评估

- **📧 邮件安全**
  - 邮箱转发规则分析
  - 外部邮件转发检测
  - Exchange Online 安全评估

- **👥 Microsoft Teams 安全**
  - 外部访问配置审核
  - 包含外部用户/访客的 Teams 报告
  - Teams 安全态势评估
  - Teams 频道成员变更：报告所有 Teams 频道当前成员

- **📁 SharePoint 与 OneDrive 安全**
  - SharePoint 共享设置分析
  - SharePoint 站点存储使用情况：报告所有 SharePoint 站点的存储使用情况
  - OneDrive 使用和安全监控
  - 数据丢失防护 (DLP) 策略指导
  - 外部共享检测
  - OneDrive 共享链接审计：审计外部共享文件及访问级别

### ⚙️ 配置管理
- **设置与凭据存储**
  - Azure 服务主体配置
  - 自动化安全凭据存储
  - 自动连接功能
  - 自定义导出路径
  - 配置管理

---
### 只读操作
- ✅ **不修改** 任何 Azure 或 Office 365 配置
- ✅ **审计跟踪** - 所有操作均记录时间戳
- ✅ **安全认证** 使用现代认证流程
- ✅ **最小权限** - 仅需读取权限

### 数据隐私
- 🔒 不存储或传输敏感数据
- 🔒 本地 CSV 导出，文件路径可配置
- 🔒 全面日志记录，便于合规审计
## 🚀 快速开始

---
### 先决条件

确保已安装 PowerShell 7.0 及以上版本：</translate-content>
```powershell
# Check PowerShell version
$PSVersionTable.PSVersion
```
### 安装

1. **克隆仓库：**

   ```bash
   git clone https://github.com/SteffMet/Azure-Office365-Security-Reporting.git
   cd Azure-Office365-Security-Reporting
   ```
<translate-content>
2. **运行启动脚本（推荐）：**</translate-content>
   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
<translate-content>   
   **或者直接运行：**</translate-content>
   ```powershell
   # Modular version (recommended)
   .\AzureSecurityReport-Modular.ps1
   ```
## 🔑 所需权限

### Azure AD 角色
- **推荐**：全局读取者或安全读取者
- **最低**：目录读取者 + 特定对象权限

### Azure 订阅权限
- **存储安全**：存储帐户参与者（只读）
- **密钥保管库安全**：密钥保管库读取者
- **网络安全**：网络参与者（只读）
- **虚拟机安全**：虚拟机参与者（只读）

### Microsoft Graph API 权限

```
User.Read.All
Directory.Read.All
Policy.Read.ConditionalAccess
UserAuthenticationMethod.Read.All
Organization.Read.All
Reports.Read.All
AuditLog.Read.All
Sites.Read.All
```
<translate-content>
### Office 365 权限
- **Exchange Online**：仅查看组织管理
- **Microsoft Teams**：团队管理员（只读操作）
- **SharePoint Online**：SharePoint 管理员（只读操作）

--- 
## 🛠️ 故障排除

### Microsoft Graph 程序集冲突
如果遇到“已加载同名程序集”错误：

**🔧 快速解决方案：**

1. **使用启动脚本（推荐）**：</translate-content>
   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
2. **使用修复脚本**：

   ```powershell
   .\Fix-GraphModules.ps1
   ```
3. **手动会话重启**：</

   ```powershell
   # Exit PowerShell completely
   exit
   
   # Start fresh PowerShell 7 session
   pwsh
   cd "path\to\Azure-Office365-Security-Reporting"
   .\AzureSecurityReport-Modular.ps1
   ```
4. **自动重启助手**：</translation-content>

   ```powershell
   .\Restart-PowerShellSession.ps1
   ```
**🔍 为什么会发生这种情况：**  
Microsoft Graph PowerShell 模块使用的 .NET 程序集在同一会话中多次加载时可能会发生冲突。  
这是 Microsoft Graph SDK 已知的限制。  

### 常见问题  

| 问题 | 解决方案 |  
|-------|----------|  
| 模块导入错误 | 以管理员身份运行 `Install-Module` |  
| 认证失败 | 验证账户权限并重试 |  
| CSV 导出错误 | 检查文件路径权限 |  
| Graph API 速率限制 | 等待几分钟后重试 |  

---  
<div align="center">  

**⭐ 如果本项目对您有帮助，请考虑给个星标！⭐**  

由 [SteffMet](https://github.com/SteffMet) ❤️ 制作  

*最后更新：2025年6月28日*  

</div>




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---