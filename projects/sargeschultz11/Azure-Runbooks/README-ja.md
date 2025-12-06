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
各ランブックフォルダーには以下が含まれています：
- メインのPowerShellスクリプト（`.ps1`）
- 権限設定用のヘルパースクリプト（`Add-GraphPermissions.ps1`）
- 詳細なドキュメント（`README.md`）

## 認証

このリポジトリ内のすべてのランブックは、Azure Automationのシステム割り当てマネージドIDを認証に使用するよう設計されており、これはAzure Automationで推奨される方法です。各フォルダーには、AutomationアカウントのマネージドIDに必要なMicrosoft Graph APIの権限を割り当てるための`Add-GraphPermissions.ps1`スクリプトが含まれています。

## はじめに

各ランブックには実装と使用法に関する詳細なドキュメントが含まれています。一般的に、これらのランブックを使用するには：

1. スクリプトをAzure Automationアカウントにインポートする
2. Automationアカウントでシステム割り当てマネージドIDを有効にする
3. 同梱の`Add-GraphPermissions.ps1`スクリプトを使用して必要なGraph APIの権限を割り当てる
4. 環境に特有の必要なパラメーターを設定する
5. ランブックをスケジュールするか、必要に応じてオンデマンドで実行する

## 利用可能なランブック

### レポート
- **デバイスコンプライアンスレポート**：Intune管理デバイスの包括的なコンプライアンスレポートを生成します。
- **検出されたアプリレポート**：管理デバイス上で検出されたアプリケーションの詳細レポートを作成します。
- **特定アプリ搭載デバイスレポート**：特定のアプリケーションがインストールされているすべてのデバイスを特定します。
- **ユーザーマネージャーレポート**：ライセンスされた内部ユーザー全員とそのマネージャー情報のレポートを生成します。
- **セキュリティ更新不足レポート**：複数のセキュリティ更新が不足しているWindowsデバイスを特定し、自動レポートを行います。
- **デバイス同期遅延レポート**：指定された期間内に同期されていないデバイスのレポートを生成します。
- **OneDrive共有アイテムレポート**：OneDrive for Businessで外部共有されたアイテムのレポートを作成します。

### デバイス管理
- **デバイスカテゴリ同期**：ユーザーの部門情報に基づいてIntuneデバイスカテゴリを自動的に同期します。
- **Autopilotグループタグ同期**：IntuneデバイスカテゴリとAutopilotデバイスグループタグを同期させます。
- **強制デバイス同期**：バッチ処理とスロットリング保護を用いて、管理対象Intuneデバイスすべてに同期コマンドを送信します。
- **IntuneからAction1カテゴリ同期**：シリアル番号を照合してIntuneデバイスカテゴリをAction1のカスタム属性に同期します。

### アラートと通知
- **デバイス同期リマインダー**：最近同期していないユーザーに自動メールリマインダーを送信します。
- **Appleトークンモニター**：Appleプッシュ通知証明書とトークンの有効期限を監視し、アラートを出します。

### ユーザー管理
- **会社属性設定**: Microsoft 365 テナント内のすべてのユーザーアカウントに一貫した会社属性を設定します。
- **Snipe-IT ユーザー同期**: Microsoft 365 テナントのメールをアンカーとして使用し、新規ユーザーには安全なパスワードを設定し、ログイン/招待のオンオフをオプションで設定して、Snipe-IT ユーザーを作成または更新します。

### サードパーティ統合
- **Action1 統合**: Intune のデバイスカテゴリを Action1 RMM のカスタム属性に同期し、プラットフォーム間で統一されたデバイス管理を実現します。

## ブランチ管理

このリポジトリはシンプルな Git ワークフローに従っています：

- `main` ブランチは安定した本番用スクリプトを含みます
- 新機能や大幅な変更には開発ブランチを作成します
- 開発作業が `main` にマージされると、通常は開発ブランチは削除されます
- このリポジトリをクローンしているユーザーは、作業完了後に開発ブランチが消える可能性があることに注意してください

特定の開発ブランチで作業している場合は、ブランチ削除の影響を受けないように自分のフォークを作成することを検討してください。

## v1.4.0 の新機能

### 新ランブック: Sync-IntuneToAction1Categories
このリリースでは Action1 RMM との新しい統合を導入し、Intune のデバイスカテゴリを Action1 のカスタム属性に自動的に同期できるようになりました。主な特徴は：

- シリアル番号を使用した Intune と Action1 間のデバイス自動マッチング
- Intune のデバイスカテゴリを設定可能な Action1 カスタム属性に同期
- 複数の Action1 リージョン（北米、ヨーロッパ、オーストラリア）をサポート
- Azure Automation の暗号化変数による安全な資格情報管理
- 変更を加えずにテスト可能な WhatIf モード
- 詳細なログと統計情報
- PSAction1 PowerShell モジュールを基盤に構築

この統合により、Microsoft Intune と Action1 RMM の両プラットフォームで一貫したデバイス分類を維持でき、より良いレポート作成、ポリシー適用、デバイス管理ワークフローが可能になります。

## ディスカッション

このリポジトリでは GitHub Discussions を有効にしており、ユーザー間の協力とサポートを促進します。ここは以下の場として最適です：

* 特定のランブックの実装に関する質問
* 成功事例や実装例の共有

* 新しいランブックのアイデアや改善案を提案する
* Azure Automationのベストプラクティスを議論する
* トラブルシューティングの支援を受ける

[Discussions](https://github.com/sargeschultz11/Azure-Runbooks/discussions) タブをチェックして会話に参加してください。一般的な質問やコミュニティとの交流にはDiscussionsを使用し、バグ報告やスクリプトの特定の問題にはIssuesを使用することを推奨します。

## 貢献について

これらのスクリプトを自身の自動化ニーズの出発点として自由に使用してください。貢献、改善、提案を歓迎します！

## ライセンス

本プロジェクトはMITライセンスのもとで提供されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---