# Azure-Runbooks 

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![PowerShell](https://img.shields.io/badge/PowerShell-7.2+-blue.svg)](https://github.com/PowerShell/PowerShell)
[![Microsoft 365](https://img.shields.io/badge/Microsoft_365-compatible-brightgreen.svg)](https://www.microsoft.com/microsoft-365)
[![Graph API](https://img.shields.io/badge/Microsoft_Graph-v1.0-blue.svg)](https://developer.microsoft.com/en-us/graph)
[![Azure](https://img.shields.io/badge/Azure_Automation-compatible-0089D6.svg)](https://azure.microsoft.com/en-us/products/automation)
[![GitHub release](https://img.shields.io/github/release/sargeschultz11/Azure-Runbooks.svg)](https://GitHub.com/sargeschultz11/Azure-Runbooks/releases/)
[![Maintenance](https://img.shields.io/badge/Maintained-yes-green.svg)](https://github.com/sargeschultz11/Azure-Runbooks)
[![Made with](https://img.shields.io/badge/Made%20with-PowerShell-1f425f.svg)](https://www.microsoft.com/powershell)

A collection of Azure Automation runbooks for Microsoft 365 and Intune management.

## Overview

This repository contains PowerShell scripts designed to be used as Azure Automation runbooks for automating various Microsoft 365 and Intune management tasks. These scripts help streamline administrative processes, maintain consistency across your environment, and reduce manual overhead.

## Repository Structure

The repository is organized into folders, with each folder containing a specific runbook solution:

```
Azure-Runbooks/
├── DeviceCategorySync/             # Sync device categories with user departments
├── Report-DiscoveredApps/          # Generate reports of discovered applications
├── Report-IntuneDeviceCompliance/  # Generate device compliance reports
├── Report-DevicesWithApp/          # Find devices with specific applications
├── Alert-DeviceSyncReminder/       # Send reminders for devices needing sync
├── Update-AutopilotDeviceGroupTags/ # Sync Autopilot group tags with Intune categories
├── Alert-IntuneAppleTokenMonitor/  # Monitor Apple token expirations
├── Report-UserManagers/            # Generate reports of users and their managers
├── Report-MissingSecurityUpdates/  # Report on devices missing security updates
├── Sync-IntuneDevices/             # Force sync all managed Intune devices
├── Report-DeviceSyncOverdue/       # Report on devices overdue for sync
├── Report-OneDriveSharedItems/     # Generate reports of shared items in OneDrive
├── Task-SetCompanyAttribute/       # Set company attribute for all users
├── Snipe-IT-UserSync/              # Sync Microsoft 365 users to Snipe-IT users
├── Sync-IntuneToAction1Categories/ # Sync Intune device categories to Action1 custom attributes
```
每个运行簿文件夹包含：  
- 主要的 PowerShell 脚本（`.ps1`）  
- 用于设置权限的辅助脚本（`Add-GraphPermissions.ps1`）  
- 详细的文档（`README.md`）  

## 认证  

本仓库中的所有运行簿均设计为使用 Azure 自动化的系统分配托管身份进行认证，这是 Azure 自动化推荐的认证方式。每个文件夹都包含一个 `Add-GraphPermissions.ps1` 脚本，帮助为您的自动化帐户的托管身份分配所需的 Microsoft Graph API 权限。  

## 快速开始  

每个运行簿都包含详细的实现和使用文档。一般而言，使用这些运行簿的步骤如下：  

1. 将脚本导入到您的 Azure 自动化帐户  
2. 在您的自动化帐户上启用系统分配托管身份  
3. 使用包含的 `Add-GraphPermissions.ps1` 脚本分配必要的 Graph API 权限  
4. 配置特定于您环境的任何必需参数  
5. 按需安排运行簿运行或手动运行  

## 可用运行簿  

### 报告  
- **设备合规性报告**：生成 Intune 管理设备的全面合规性报告。  
- **发现应用报告**：创建管理设备上发现的应用程序详细报告。  
- **特定应用设备报告**：识别所有安装了特定应用的设备。  
- **用户经理报告**：生成所有已授权内部用户及其经理信息的报告。  
- **缺失安全更新报告**：识别缺少多个安全更新的 Windows 设备并自动生成报告。  
- **设备同步逾期报告**：生成未在指定阈值内同步的设备报告。  
- **OneDrive 共享项目报告**：创建 OneDrive for Business 中外部共享项目的报告。  

### 设备管理  
- **设备类别同步**：根据用户部门信息自动同步 Intune 设备类别。  
- **Autopilot 组标签同步**：保持 Autopilot 设备组标签与 Intune 设备类别同步。  
- **强制设备同步**：对所有受管理的 Intune 设备发起同步命令，支持批处理和节流保护。  
- **Intune 到 Action1 类别同步**：通过匹配序列号将 Intune 设备类别同步到 Action1 自定义属性。  

### 警报和通知  
- **设备同步提醒**：向最近未同步设备的用户发送自动电子邮件提醒。  
- **Apple 令牌监控**：监控并提醒 Apple 推送通知证书和令牌的过期情况。


### 用户管理
- **公司属性设置**：在您的 Microsoft 365 租户中的所有用户帐户中设置一致的公司属性。
- **Snipe-IT 用户同步**：使用电子邮件作为锚点，从您的 Microsoft 365 租户创建或更新 Snipe-IT 用户，为新用户设置安全密码，并提供可选的登录/邀请切换。

### 第三方集成
- **Action1 集成**：将 Intune 设备类别同步到 Action1 RMM 自定义属性，实现跨平台的统一设备管理。

## 分支管理

本仓库遵循简化的 Git 工作流程：

- `main` 分支包含稳定的、可用于生产的脚本
- 开发分支用于新功能或重大修改
- 开发工作合并到 `main` 后，开发分支通常会被删除
- 对于已克隆此仓库的用户，请注意开发分支在工作完成后可能会消失

如果您正在使用特定的开发分支，建议创建自己的分叉，以确保分支被删除时您的工作不会受到影响。

## v1.4.0 新功能

### 新运行手册：Sync-IntuneToAction1Categories
此版本引入了与 Action1 RMM 的新集成，实现 Intune 设备类别自动同步到 Action1 自定义属性。主要功能包括：

- 通过序列号自动匹配 Intune 与 Action1 设备
- 将 Intune 设备类别同步到可配置的 Action1 自定义属性
- 支持多个 Action1 区域（北美、欧洲、澳大利亚）
- 通过 Azure Automation 加密变量进行安全凭据管理
- WhatIf 模式用于测试而不进行更改
- 全面的日志记录和统计功能
- 基于 PSAction1 PowerShell 模块构建

该集成帮助组织在 Microsoft Intune 和 Action1 RMM 平台之间保持设备分类一致，促进更好的报告、策略应用和设备管理流程。

## 讨论区

我已为本仓库启用 GitHub 讨论区，以促进用户之间的协作和支持。这里是：

* 询问关于实现特定运行手册的问题
* 分享您的成功案例和实施经验 
* 建议新的运行手册创意或改进  
* 讨论 Azure 自动化的最佳实践  
* 获取故障排除帮助  

查看[讨论](https://github.com/sargeschultz11/Azure-Runbooks/discussions)标签加入讨论。我们鼓励您使用讨论区进行一般问题和社区互动，而问题区应仅用于报告脚本的错误或具体问题。  

## 贡献  

欢迎将这些脚本作为您自动化需求的起点。我们欢迎贡献、改进和建议！  

## 许可  

本项目采用 MIT 许可证授权 - 详情请参阅[LICENSE](LICENSE)文件。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---