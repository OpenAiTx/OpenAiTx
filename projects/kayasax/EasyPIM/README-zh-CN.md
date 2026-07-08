<p align="center">
  <img src="https://raw.githubusercontent.com/kayasax/EasyPIM/main/docs/assets/logo_transparent.svg" alt="EasyPIM logo" width="180">
  <h1 align="center">🛡️ EasyPIM</h1>
  <p align="center">
    <strong>Azure 特权身份管理的 PowerShell 自动化工具。</strong>
  </p>
  <p align="center">
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/v/easypim?label=Core&logo=powershell&color=blue" alt="Core Version"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/v/EasyPIM.Orchestrator?label=Orchestrator&logo=powershell&color=blue" alt="Orchestrator Version"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/dt/easypim?label=Core%20Downloads&color=green" alt="Core Downloads"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/dt/EasyPIM.Orchestrator?label=Orchestrator%20Downloads&color=green" alt="Orchestrator Downloads"></a>
    <a href="https://github.com/kayasax/EasyPIM/stargazers"><img src="https://img.shields.io/github/stars/kayasax/EasyPIM?style=social" alt="GitHub Stars"></a>
    <a href="https://github.com/kayasax/EasyPIM/blob/main/LICENSE"><img src="https://img.shields.io/github/license/kayasax/EasyPIM" alt="License"></a>
  </p>
</p>

---

批量强化角色策略。跨角色克隆设置。导出分配。检测配置漂移。批准或拒绝请求。从 JSON 部署完整的 PIM 模型。

**一个 PowerShell 模块覆盖 Azure 资源、Entra ID 角色和安全组** — 提供门户无法完成的 cmdlet。统一 ARM 和 Graph API，50+ 命令，支持 4 个 Azure 云环境。

> 🌐 **从这里开始 →** **[EasyPIM 采用中心](https://kayasax.github.io/EasyPIM/)** 指导您从首次安装到企业级 PIM 治理的三阶段过程。

## 🚀 快速开始

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Force

# Harden 3 Entra roles in one shot — try that in the portal
Set-PIMEntraRolePolicy -TenantID $tenantId `
    -RoleName "Global Administrator","Security Administrator","Exchange Administrator" `
    -ActivationRequirement "Justification","Ticketing","MultiFactorAuthentication" `
    -ActivationDuration "PT4H"

# Audit every eligible assignment across a subscription
Get-PIMAzureResourceEligibleAssignment -TenantID $tenantId -SubscriptionId $subId

# Deploy a full PIM model from JSON — Entra + Azure + Groups in one run
Invoke-EasyPIMOrchestrator -TenantId $tenantId -ConfigurationPath "./pim-config.json"
```

---

## ✨ 门户无法完成的事项

| | |
|---|---|
| ⚡ **批量强化角色** | 一条命令设置30个角色的多因素认证+理由说明+工单 |
| 🔄 **克隆角色设置** | 复制强化策略到其他角色/用户——无需手动重复点击 |
| 📊 **导出与导入** | 分配导出为CSV，完整配置导出为JSON——秒级审计准备 |
| 🔍 **检测策略漂移** | 比较实时状态与声明配置，生成差异报告 |
| 🏢 **CI/CD治理** | GitHub Actions 和 Azure DevOps（[事件驱动演示](https://github.com/kayasax/EasyPIM-EventDriven-Governance)） |
| ☁️ **多云支持** | 公有云、政府云、中国云、德国云——命令行工具一致 |
| 🔗 **统一的ARM + Graph** | 一个模块抽象两种API——无需切换上下文 |

---

## 📦 安装

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Scope CurrentUser
```
| 需求 | 详情 |
|---|---|
| PowerShell | 5.1+ 或 7.0+ |
| 模块 | `Az.Accounts`，`Microsoft.Graph.Authentication`（自动安装） |
| Azure 资源 | 订阅上的 `Owner` 或 `User Access Administrator` |
| Entra ID / 组 | Graph 权限：`RoleManagement.ReadWrite.Directory`，`RoleManagementPolicy.ReadWrite.Directory`，及[其他](https://github.com/kayasax/EasyPIM/wiki/Documentation) |

---

## 📖 了解更多

| | |
|---|---|
| **[🌐 采纳中心](https://kayasax.github.io/EasyPIM/)** | **三阶段旅程：快速入门、最佳实践、企业模式** |
| [📋 完整文档](https://github.com/kayasax/EasyPIM/wiki/Documentation) | 深度指南和 API 参考 |
| [🎯 用例与示例](https://github.com/kayasax/EasyPIM/wiki/Use-Cases) | 真实世界的实现场景 |
| [🏗 Orchestrator 指南](https://github.com/kayasax/EasyPIM/wiki/Invoke%E2%80%90EasyPIMOrchestrator-step%E2%80%90by%E2%80%90step-guide) | JSON 驱动工作流逐步指导 |
| [🔄 v1→v2 迁移](https://github.com/kayasax/EasyPIM/wiki/Module-Migration) | 从 v1.x 升级 |
| [📝 更新日志](https://github.com/kayasax/EasyPIM/wiki/Changelog) | 版本历史 |

---

## 🔧 两个模块，一个平台

| 模块 | 目的 | 主要命令 |
|---|---|---|
| **EasyPIM**（核心） | 直接 PIM API 管理——策略、分配、审批 | `Get-PIM*`，`Set-PIM*`，`New-PIM*` |
| **EasyPIM.Orchestrator** | JSON 工作流、漂移检测、业务规则、CI/CD | `Invoke-EasyPIMOrchestrator`，`Test-PIMPolicyDrift` |

<details>
<summary>点击展开完整命令列表（50+）</summary>

### Azure 资源角色

| 命令 | 描述 |
|---|---|
| `Get-PIMAzureResourcePolicy` | 获取角色策略设置 |
| `Set-PIMAzureResourcePolicy` | 配置激活要求、时长、审批人 |
| `Get-PIMAzureResourceEligibleAssignment` | 列出符合条件的分配 |

| `New-PIMAzureResourceEligibleAssignment` | 创建符合条件的分配 |
| `Remove-PIMAzureResourceEligibleAssignment` | 移除符合条件的分配 |
| `Get-PIMAzureResourceActiveAssignment` | 列出活动分配 |
| `New-PIMAzureResourceActiveAssignment` | 创建活动分配 |
| `Remove-PIMAzureResourceActiveAssignment` | 移除活动分配 |

### Entra ID 角色

| Cmdlet | 描述 |
|---|---|
| `Get-PIMEntraRolePolicy` | 获取 Entra 角色策略设置 |
| `Set-PIMEntraRolePolicy` | 配置激活要求、多重身份验证、审批人 |
| `Get-PIMEntraRoleEligibleAssignment` | 列出符合条件的分配 |
| `New-PIMEntraRoleEligibleAssignment` | 创建符合条件的分配 |
| `Remove-PIMEntraRoleEligibleAssignment` | 移除符合条件的分配 |
| `Get-PIMEntraRoleActiveAssignment` | 列出活动分配 |
| `New-PIMEntraRoleActiveAssignment` | 创建活动分配 |
| `Remove-PIMEntraRoleActiveAssignment` | 移除活动分配 |

### 组

| Cmdlet | 描述 |
|---|---|
| `Get-PIMGroupPolicy` | 获取组 PIM 策略设置 |
| `Set-PIMGroupPolicy` | 配置组激活要求 |
| `Get-PIMGroupEligibleAssignment` | 列出符合条件的组分配 |
| `New-PIMGroupEligibleAssignment` | 创建符合条件的组分配 |
| `Remove-PIMGroupEligibleAssignment` | 移除符合条件的组分配 |
| `Get-PIMGroupActiveAssignment` | 列出活动组分配 |
| `New-PIMGroupActiveAssignment` | 创建活动组分配 |
| `Remove-PIMGroupActiveAssignment` | 移除活动组分配 |

### 操作与工具

| Cmdlet | 描述 |
|---|---|
| `Approve-PIMPendingRequest` | 批准待处理的激活请求 |
| `Deny-PIMPendingRequest` | 拒绝待处理的激活请求 |
| `Get-PIMReport` | PIM 活动分析和审计跟踪 |
| `Backup-PIMConfiguration` | 完整的 PIM 状态备份 |
| `Restore-PIMConfiguration` | 从备份恢复 |
| `Copy-PIMRoleSettings` | 在角色之间克隆设置 |
| `Export-PIMAssignment` | 导出分配到 CSV |
| `Import-PIMAssignment` | 从 CSV 导入分配 |

### Orchestrator

| Cmdlet | 描述 |
|---|---|
| `Invoke-EasyPIMOrchestrator` | 从 JSON 部署完整的 PIM 配置 |
| `Test-PIMPolicyDrift` | 检测与声明状态的策略偏移 |
| `Test-PIMEndpointDiscovery` | 连接性和权限验证 |

</details>

---

## 🌐 覆盖范围

**3 个 PIM 范围**：Azure 资源（订阅、管理组、资源组）· Entra ID 角色 · 安全组

**4 个云**：公共 · 政府 · 中国 · 德国

---

## 🤝 相关项目

| | |
|---|---|
| **[EasyTCM](https://github.com/kayasax/EasyTCM)** | 租户配置监控 — 检测 Entra、Exchange、Intune、Teams 和合规性的配置偏移 |
| **[Event-Driven Governance](https://github.com/kayasax/EasyPIM-EventDriven-Governance)** | 生产环境 CI/CD 演示：GitHub Actions + Azure DevOps + 事件网格 |

---

## 🤝 贡献

参见 [CONTRIBUTING.md](https://raw.githubusercontent.com/kayasax/EasyPIM/main/CONTRIBUTING.md) 获取指南。

### 贡献者

- **[Loïc MICHEL](https://github.com/kayasax)** — 作者及维护者
- **[AzureStackNerd](https://github.com/AzureStackNerd)** — Azure 资源分配的 ABAC 条件支持，图范围优化
- **[Chase Dafnis](https://github.com/CHDAFNI-MSFT)** — 多云 / Azure 环境支持
- **[jeenvan](https://github.com/jeevanions)** — 编排器：数组格式及管理组范围修复

---

<p align="center">
  为 Azure 管理员社区倾心打造 ❤️<br>
  <strong>作者其他作品：<a href="https://github.com/kayasax/EasyTCM">EasyTCM</a> — M365 租户配置漂移检测</strong>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---