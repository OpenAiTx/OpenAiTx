<p align="center">
  <img src="https://raw.githubusercontent.com/kayasax/EasyPIM/main/docs/assets/logo_transparent.svg" alt="EasyPIM ロゴ" width="180">
  <h1 align="center">🛡️ EasyPIM</h1>
  <p align="center">
    <strong>Azure Privileged Identity Management のための PowerShell 自動化。</strong>
  </p>
  <p align="center">
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/v/easypim?label=Core&logo=powershell&color=blue" alt="Core バージョン"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/v/EasyPIM.Orchestrator?label=Orchestrator&logo=powershell&color=blue" alt="Orchestrator バージョン"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM"><img src="https://img.shields.io/powershellgallery/dt/easypim?label=Core%20Downloads&color=green" alt="Core ダウンロード数"></a>
    <a href="https://www.powershellgallery.com/packages/EasyPIM.Orchestrator"><img src="https://img.shields.io/powershellgallery/dt/EasyPIM.Orchestrator?label=Orchestrator%20Downloads&color=green" alt="Orchestrator ダウンロード数"></a>
    <a href="https://github.com/kayasax/EasyPIM/stargazers"><img src="https://img.shields.io/github/stars/kayasax/EasyPIM?style=social" alt="GitHub スター数"></a>
    <a href="https://github.com/kayasax/EasyPIM/blob/main/LICENSE"><img src="https://img.shields.io/github/license/kayasax/EasyPIM" alt="ライセンス"></a>
  </p>
</p>

---

ロールポリシーの一括強化。ロール間で設定をクローン。割り当てをエクスポート。構成のドリフトを検出。要求の承認または拒否。JSONから完全なPIMモデルを展開。

**Azure リソース、Entra ID ロール、セキュリティグループをカバーする単一の PowerShell モジュール** — ポータルではできないことを実現するコマンドレット群。統合された ARM と Graph API、50以上のコマンド、4つの Azure クラウド対応。

> 🌐 **ここから始める →** **[EasyPIM Adoption Hub](https://kayasax.github.io/EasyPIM/)** は、初回インストールからエンタープライズレベルの PIM ガバナンスまでを三段階で案内します。

## 🚀 クイックスタート

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

## ✨ ポータルでできないこと

| | |
|---|---|
| ⚡ **ロールの一括強化** | 30のロールに対してMFA＋正当化＋チケット発行を一括設定 |
| 🔄 **ロール設定のクローン** | 強化済みポリシーを他のロールやユーザーにコピー — 手動で再クリック不要 |
| 📊 **エクスポート＆インポート** | 割り当てをCSVに、完全設定をJSONに — 数秒で監査準備完了 |
| 🔍 **ポリシードリフト検出** | ライブ状態と宣言済み設定を比較し、差分レポートを取得 |
| 🏢 **CI/CDガバナンス** | GitHub Actions＆Azure DevOps（[イベント駆動デモ](https://github.com/kayasax/EasyPIM-EventDriven-Governance)） |
| ☁️ **マルチクラウド対応** | パブリック、政府、中国、ドイツ — どこでも同じコマンドレット |
| 🔗 **統合ARM＋Graph** | 1つのモジュールで両APIを抽象化 — コンテキスト切り替え不要 |

---

## 📦 インストール

```powershell
Install-Module EasyPIM, EasyPIM.Orchestrator -Scope CurrentUser
```
| 要件 | 詳細 |
|---|---|
| PowerShell | 5.1+ または 7.0+ |
| モジュール | `Az.Accounts`、`Microsoft.Graph.Authentication`（自動インストール） |
| Azure リソース | サブスクリプションの `Owner` または `User Access Administrator` |
| Entra ID / グループ | グラフ権限: `RoleManagement.ReadWrite.Directory`、`RoleManagementPolicy.ReadWrite.Directory`、および[その他](https://github.com/kayasax/EasyPIM/wiki/Documentation) |

---

## 📖 詳細情報

| | |
|---|---|
| **[🌐 Adoption Hub](https://kayasax.github.io/EasyPIM/)** | **3段階の旅程：クイックスタート、ベストプラクティス、エンタープライズパターン** |
| [📋 完全ドキュメント](https://github.com/kayasax/EasyPIM/wiki/Documentation) | 詳細なガイドとAPIリファレンス |
| [🎯 ユースケース＆例](https://github.com/kayasax/EasyPIM/wiki/Use-Cases) | 実際の導入シナリオ |
| [🏗 オーケストレーターガイド](https://github.com/kayasax/EasyPIM/wiki/Invoke%E2%80%90EasyPIMOrchestrator-step%E2%80%90by%E2%80%90step-guide) | JSON駆動ワークフローのステップバイステップ |
| [🔄 v1→v2 移行](https://github.com/kayasax/EasyPIM/wiki/Module-Migration) | v1.xからのアップグレード |
| [📝 変更履歴](https://github.com/kayasax/EasyPIM/wiki/Changelog) | バージョン履歴 |

---

## 🔧 2つのモジュール、1つのプラットフォーム

| モジュール | 目的 | 主なコマンド |
|---|---|---|
| **EasyPIM**（コア） | 直接PIM API管理 — ポリシー、割り当て、承認 | `Get-PIM*`、`Set-PIM*`、`New-PIM*` |
| **EasyPIM.Orchestrator** | JSONワークフロー、ドリフト検出、ビジネスルール、CI/CD | `Invoke-EasyPIMOrchestrator`、`Test-PIMPolicyDrift` |

<details>
<summary>クリックして全コマンドリストを展開（50以上）</summary>

### Azureリソースロール

| コマンドレット | 説明 |
|---|---|
| `Get-PIMAzureResourcePolicy` | ロールポリシー設定の取得 |
| `Set-PIMAzureResourcePolicy` | アクティベーション要件、期間、承認者の設定 |
| `Get-PIMAzureResourceEligibleAssignment` | 対象割り当ての一覧取得 |

| `New-PIMAzureResourceEligibleAssignment` | 適格割り当てを作成 |
| `Remove-PIMAzureResourceEligibleAssignment` | 適格割り当てを削除 |
| `Get-PIMAzureResourceActiveAssignment` | アクティブな割り当てを一覧表示 |
| `New-PIMAzureResourceActiveAssignment` | アクティブな割り当てを作成 |
| `Remove-PIMAzureResourceActiveAssignment` | アクティブな割り当てを削除 |

### Entra ID ロール

| Cmdlet | 説明 |
|---|---|
| `Get-PIMEntraRolePolicy` | Entra ロールポリシー設定を取得 |
| `Set-PIMEntraRolePolicy` | アクティベーション要件、MFA、承認者を構成 |
| `Get-PIMEntraRoleEligibleAssignment` | 適格割り当てを一覧表示 |
| `New-PIMEntraRoleEligibleAssignment` | 適格割り当てを作成 |
| `Remove-PIMEntraRoleEligibleAssignment` | 適格割り当てを削除 |
| `Get-PIMEntraRoleActiveAssignment` | アクティブな割り当てを一覧表示 |
| `New-PIMEntraRoleActiveAssignment` | アクティブな割り当てを作成 |
| `Remove-PIMEntraRoleActiveAssignment` | アクティブな割り当てを削除 |

### グループ

| Cmdlet | 説明 |
|---|---|
| `Get-PIMGroupPolicy` | グループ PIM ポリシー設定を取得 |
| `Set-PIMGroupPolicy` | グループのアクティベーション要件を構成 |
| `Get-PIMGroupEligibleAssignment` | 適格なグループ割り当てを一覧表示 |
| `New-PIMGroupEligibleAssignment` | 適格なグループ割り当てを作成 |
| `Remove-PIMGroupEligibleAssignment` | 適格なグループ割り当てを削除 |
| `Get-PIMGroupActiveAssignment` | アクティブなグループ割り当てを一覧表示 |
| `New-PIMGroupActiveAssignment` | アクティブなグループ割り当てを作成 |
| `Remove-PIMGroupActiveAssignment` | アクティブなグループ割り当てを削除 |

### 操作とユーティリティ

| Cmdlet | 説明 |
|---|---|
| `Approve-PIMPendingRequest` | 保留中のアクティベーション要求を承認 |
| `Deny-PIMPendingRequest` | 保留中のアクティベーション要求を拒否 |
| `Get-PIMReport` | PIM アクティビティ分析および監査証跡 |
| `Backup-PIMConfiguration` | PIM 状態の完全バックアップ |
| `Restore-PIMConfiguration` | バックアップから復元 |
| `Copy-PIMRoleSettings` | ロール間で設定を複製 |
| `Export-PIMAssignment` | 割り当てをCSVにエクスポート |
| `Import-PIMAssignment` | CSVから割り当てをインポート |

### オーケストレーター

| Cmdlet | 説明 |
|---|---|
| `Invoke-EasyPIMOrchestrator` | JSONから完全なPIM構成を展開 |
| `Test-PIMPolicyDrift` | 宣言された状態に対するポリシードリフトを検出 |
| `Test-PIMEndpointDiscovery` | 接続性と権限の検証 |

</details>

---

## 🌐 対応範囲

**3つのPIMスコープ**: Azureリソース（サブスクリプション、管理グループ、リソースグループ）· Entra IDロール · セキュリティグループ

**4つのクラウド**: パブリック · ガバメント · 中国 · ドイツ

---

## 🤝 関連プロジェクト

| | |
|---|---|
| **[EasyTCM](https://github.com/kayasax/EasyTCM)** | テナント構成監視 — Entra、Exchange、Intune、Teams、コンプライアンス間の構成ドリフトを検出 |
| **[Event-Driven Governance](https://github.com/kayasax/EasyPIM-EventDriven-Governance)** | 本番CI/CDデモ: GitHub Actions + Azure DevOps + Event Grid |

---

## 🤝 コントリビューション

ガイドラインは[CONTRIBUTING.md](https://raw.githubusercontent.com/kayasax/EasyPIM/main/CONTRIBUTING.md)を参照してください。

### コントリビューター

- **[Loïc MICHEL](https://github.com/kayasax)** — 著者およびメンテナ
- **[AzureStackNerd](https://github.com/AzureStackNerd)** — Azureリソース割り当てのABAC条件サポート、Graphスコープ最適化
- **[Chase Dafnis](https://github.com/CHDAFNI-MSFT)** — マルチクラウド / Azure環境サポート
- **[jeenvan](https://github.com/jeevanions)** — オーケストレーター：配列形式と管理グループスコープの修正

---

<p align="center">
  Azure管理者コミュニティのために❤️で作成<br>
  <strong>著者によるその他の作品: <a href="https://github.com/kayasax/EasyTCM">EasyTCM</a> — M365テナント構成ドリフト検出</strong>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---