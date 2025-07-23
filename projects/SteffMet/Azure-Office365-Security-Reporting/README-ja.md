# 🛡️ Azure & Office 365 セキュリティレポート

> **Azure および Office 365 環境向けの包括的な PowerShell 7 セキュリティ監査ツール**

このプロジェクトは、モジュール式の読み取り専用セキュリティ評価スクリプトを提供し、組織が Azure および Office 365 インフラストラクチャ全体のセキュリティギャップ、コンプライアンス問題、およびコスト最適化の機会を特定するのを支援します。

<div align="center">
  
![メニューレイアウトデモ](https://raw.githubusercontent.com/SteffMet/Azure-Office365-Security-Reporting/main/MenuLayout.gif)
  
</div>

### 🛡️ 新しいセキュリティレポートモジュール
| モジュール | 説明 |
|--------|-------------|
| **Azure ストレージセキュリティ** | 公開 Blob コンテナの検出、暗号化の検証、HTTPS 強制の確認、ネットワークアクセスルールの分析。 |
| **Azure Key Vault セキュリティ** | 証明書の有効期限監視、アクセス ポリシーの分析、ネットワーク制限の検証、ソフト削除/パージ保護の確認。 |
| **ネットワークセキュリティグループ (NSG)** | 危険なファイアウォールルール、インターネット公開サービス、SSH/RDP の露出、データベースポートのセキュリティを特定。 |
| **SharePoint & OneDrive セキュリティ** | 外部共有、OneDrive 利用状況、データ損失防止 (DLP) ポリシー、ゲストアクセスの分析。 |
| **構成管理** | 暗号化された資格情報の保存、オートコネクト、カスタマイズ可能なエクスポートパス、構成のバックアップ/復元をサポート。 |
| **Teams チャンネルメンバーシップの変更** | すべての Teams チャンネルの現在のメンバーシップ（ユーザーおよびゲスト）を報告。 |
| **SharePoint サイトのストレージ使用状況** | すべての SharePoint サイトのストレージ使用状況を報告し、クォータおよび使用傾向を強調表示。 |
| **Azure リソースタグのコンプライアンス** | 必須タグおよびタグ付けポリシーの遵守状況について Azure リソースを監査。 |
| **OneDrive 共有リンク監査** | OneDrive の共有リンクを監査し、外部共有ファイルおよびアクセスレベルを報告。 |

### 📈 強化されたレポート機能
- 5つの新しいタイムスタンプ付き CSV レポート。
- リスクベースのスコアリング（Critical/High/Medium/Low）。
- 各検出項目に対するセキュリティ推奨事項。
- エグゼクティブサマリーダッシュボード。

  
## 🌟 主な機能

### 🔐 Azure セキュリティ監査
- **アイデンティティ & アクセスマネジメント (IAM)**
  - 多要素認証 (MFA) 状態の分析
  - ゲストユーザーアクセスのレビューおよび報告
  - パスワード有効期限ポリシーの評価
  - 条件付きアクセス ポリシーの評価

- **🛡️ データ保護**
  - Azure VM TLS 構成分析 (Azure Resource Graph)
  - 仮想マシンのディスク暗号化状態
  - セキュリティコンプライアンスの報告

- **🏗️ インフラストラクチャセキュリティ**
  - Azure ストレージアカウントのセキュリティ構成
  - 公開 Blob コンテナの検出
  - Azure Key Vault セキュリティ評価
  - 証明書の有効期限監視
  - ネットワークセキュリティグループ (NSG) の分析
  - 危険なファイアウォールルールの検出
  - Azure リソースタグのコンプライアンス：必須タグおよび遵守状況の監査

### ☁️ Office 365 セキュリティ監査
- **📊 ライセンス管理**
  - 包括的なライセンス使用状況の分析
  - コスト最適化の推奨事項
  - 未割り当てライセンスの検出および報告

- **👤 ユーザーアカウントセキュリティ**
  - 非アクティブアカウントの検出（90日以上）
  - ライセンスはあるが非アクティブなアカウントの特定
  - セキュリティリスク評価

- **📧 メールセキュリティ**
  - メールボックス転送ルールの分析
  - 外部メール転送の検出
  - Exchange Online セキュリティ評価

- **👥 Microsoft Teams セキュリティ**
  - 外部アクセス構成のレビュー
  - 外部ユーザー/ゲストを含む Teams の報告
  - Teams のセキュリティ態勢評価
  - Teams チャンネルメンバーシップの変更：すべての Teams チャンネルの現在のメンバーシップを報告

- **📁 SharePoint & OneDrive セキュリティ**
  - SharePoint の共有設定分析
  - SharePoint サイトストレージ使用状況：すべての SharePoint サイトの使用状況を報告
  - OneDrive の使用状況およびセキュリティ監視
  - データ損失防止 (DLP) ポリシーガイダンス
  - 外部共有の検出
  - OneDrive 共有リンク監査：外部共有ファイルおよびアクセスレベルを監査

### ⚙️ 構成管理
- **設定および資格情報の保存**
  - Azure サービスプリンシパル構成
  - 自動化のための安全な資格情報保存
  - オートコネクト機能
  - カスタマイズ可能なエクスポートパス
  - 構成管理

---
### 読み取り専用操作
- ✅ **Azure または Office 365 設定の変更なし**
- ✅ **監査証跡** - すべての操作はタイムスタンプ付きでログ記録
- ✅ **安全な認証** - 最新の認証フローを使用
- ✅ **最小権限** - 読み取り権限のみを要求

### データプライバシー
- 🔒 敏感なデータは保存または送信しません
- 🔒 ファイルパスを設定可能なローカルCSVエクスポート
- 🔒 コンプライアンス監査のための包括的なログ記録
## 🚀 クイックスタート

---
### 前提条件

PowerShell 7.0以上がインストールされていることを確認してください:

```powershell
# Check PowerShell version
$PSVersionTable.PSVersion
```
### インストール

1. **リポジトリをクローンする:**

   ```bash
   git clone https://github.com/SteffMet/Azure-Office365-Security-Reporting.git
   cd Azure-Office365-Security-Reporting
   ```
2. **ランチャースクリプトを実行する（推奨）：**

   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```

   
   **または直接実行:**

   ```powershell
   # Modular version (recommended)
   .\AzureSecurityReport-Modular.ps1
   ```
## 🔑 必要な権限

### Azure AD ロール
- **推奨**: グローバルリーダーまたはセキュリティリーダー
- **最小限**: ディレクトリリーダー + 特定のオブジェクト権限

### Azure サブスクリプション権限
- **ストレージセキュリティ**: ストレージアカウント共同作成者（読み取り専用）
- **キーコンテナーセキュリティ**: キーコンテナーリーダー
- **ネットワークセキュリティ**: ネットワーク共同作成者（読み取り専用）
- **VMセキュリティ**: 仮想マシン共同作成者（読み取り専用）

### Microsoft Graph API 権限

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
### Office 365 の権限
- **Exchange Online**: 組織管理の閲覧専用
- **Microsoft Teams**: Teams 管理者（読み取り専用操作）
- **SharePoint Online**: SharePoint 管理者（読み取り専用操作）

--- 
## 🛠️ トラブルシューティング

### Microsoft Graph アセンブリの競合
「同じ名前のアセンブリが既に読み込まれています」というエラーが発生した場合：

**🔧 クイック修正オプション：**

1. **ランチャースクリプトを使用する（推奨）**：


   ```powershell
   .\Start-AzureSecurityReport.ps1
   ```
2. **修正スクリプトを使用する**:

   ```powershell
   .\Fix-GraphModules.ps1
   ```
3. **手動セッション再起動**:


   ```powershell
   # Exit PowerShell completely
   exit
   
   # Start fresh PowerShell 7 session
   pwsh
   cd "path\to\Azure-Office365-Security-Reporting"
   .\AzureSecurityReport-Modular.ps1
   ```
4. **自動再起動ヘルパー**:


   ```powershell
   .\Restart-PowerShellSession.ps1
   ```
**🔍 なぜこれが起こるのか：**  
Microsoft Graph PowerShell モジュールは、同じセッション内で複数回読み込まれると競合する可能性のある .NET アセンブリを使用しています。これは Microsoft Graph SDK の既知の制限です。

### よくある問題

| 問題 | 解決策 |
|-------|----------|
| モジュールのインポートエラー | 管理者として `Install-Module` を実行する |
| 認証失敗 | アカウントの権限を確認して再試行する |
| CSV エクスポートエラー | ファイルパスの権限を確認する |
| Graph API のレート制限 | 数分待ってから再試行する |

---  
<div align="center">

**⭐ このプロジェクトが役に立ったら、スターをお願いします！ ⭐**

❤️ を込めて [SteffMet](https://github.com/SteffMet) が作成

*最終更新日: 2025年6月28日*

</div>





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---