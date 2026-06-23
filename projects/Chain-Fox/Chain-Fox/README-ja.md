<div align="center">
  <img src="https://www.chain-fox.com/logo.png" width="128" height="128">
  <h1>Chain-Fox</h1>
  <p>オート検証を備えたエージェント型チェッカーに注力しています。これが私たちの現在の焦点です。</p>
  <!-- <p>ブロックチェーンセキュリティへの自動分析の導入。</p>
  <p>XアカウントChainFoxHQはもう維持されていません。すべての更新はXアカウントChainFoxAIで公開されます。</p>
  <p>新しいCFXトークンを**Bags**でローンチします！</p>
  <p>開発者はロイヤリティの**100%**を受け取ります</p>。
  <p>さらに、収益の5%は既存のCFX保有者にステーキング報酬として分配されます。</p> -->

  [![Website](https://img.shields.io/badge/Website-Chain--Fox-blue)](https://www.chain-fox.com)
  [![Discord](https://img.shields.io/badge/Discord-Join-7289DA)](https://discord.gg/pNB3C42wjs)
  [![Telegram](https://img.shields.io/badge/Telegram-Join-26A5E4)](https://t.me/chainfox_sol)
  [![X](https://img.shields.io/badge/X-Follow-black)](https://x.com/ChainFoxAI)

  **CA:** `Fo9wJVqWYXEgsG3UKekvK1R7YVewyUGodRfBrmjaBAGS`

  **Chain-Fox**はブロックチェーンプロジェクト向けの**オールインワン自動セキュリティプラットフォーム**です。  
  最高のオープンソースチェッカーを単一のフレームワークに統合し、先進的なセキュリティを**手頃で、アクセスしやすく、スケーラブル**にしています。  
</div>

## 🎯 Chain-Foxを選ぶ理由

- セキュリティ監査は**高価で時間がかかる**。  
- 既存ツールは**断片的で統合が難しい**。  
- 多くのチームは監査を完全にスキップし、重大な脆弱性を本番環境に残してしまう。

**Chain-Foxがこれを変えます。**  
自動化された多言語のセキュリティ検出を提供し、ワークフローに簡単に統合可能 — 手動監査の高コストなしに安全なコードの提供を開発者に可能にします。

---

## 🛣️ ロードマップ

Chain-Foxはコード監査のみから、Skillsとエージェントを用いた完全なWeb3リスク分析へと進化しています。  
詳細は[ROADMAP.md](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/./ROADMAP.md)をご覧ください。  

### 短期（1ヶ月目）
- ラグプル検出（権限＋オンチェーン挙動）
- Web3ウェブサイトリスクチェック
- スキルベースの契約監査  
- コードチェッカーをエージェント化しスキル認識化  
- ベータテストとフィードバック収集  

### 中期（2ヶ月目）  
- シグナルの改善と誤検知・見逃しの削減  
- さらに多くのスキルと専門コードチェッカーを追加  
- 過去のオンチェーンパターンの追跡  
- APIドキュメントと統合  

### 長期（四半期）  
- マルチエージェントスキルシステム  
- 脅威インテリジェンスレイヤー  
- CI/CDおよびアラート連携  
- ブラウザ拡張機能（読み取り専用）  
- オープンソーススキルとコミュニティ貢献  

---  

## 📊 インパクトの証明  

- **14の高度なチェッカー**を統合（Rust、Go、Solidity、C/C++）。  
- 実プロジェクトで**200件以上のバグを発見し修正**。  
- 数分で始められる組み込みCI/CD統合ガイド。  

[検出結果](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/./detection-results/'Github Bug Report.xlsx')  
と[監査レポート](./audit_reports)で実例を確認してください。  

## 🔍 対応チェッカー  

各エコシステムの主要ツールを集約：  

| チェッカー名      | 言語       | 種類      | 検出対象                           |  
| ------------ | ---------- | --------- | ------------------------------ |  
| lockbud      | Rust       | 静的解析    | メモリ＆並行性バグ                 |  
| rudra        | Rust       | 静的解析    | メモリ安全性、分散、ライフタイムバグ   |  
| RAPx         | Rust       | 静的解析    | Use-after-free、メモリリーク         |  
| AtomVChecker | Rust       | 静的解析    | アトミック並行性バグ                 |  
| Cocoon       | Rust       | 静的解析    | 秘密情報漏洩                       |  
| MIRAI        | Rust       | 静的解析    | パニック＆正確性問題                |
| ERASan       | Rust       | 動的      | メモリアクセスバグ |
| shuttle      | Rust       | 動的      | 同時実行バグ |
| kani         | Rust       | 検証ツール | 安全性、アサーション、パニック |
| GCatch       | Go         | 静的      | 同時実行バグ |
| GFuzz        | Go         | 動的      | 同時実行バグ |
| cppcheck     | C/C++      | 静的      | 一般的なC/C++バグ |
| slither      | Solidity   | 静的      | Solidityバグ |
| PeCatch      | Solidity   | 静的      | ガス料金の非効率性 |

👉 今後の追加については[Awesome Rust Checker](https://github.com/Chain-Fox/Awesome-Rust-Checker)リストをご覧ください。  


## 🤝 参加方法

コミュニティからの貢献を歓迎します！参加方法は以下の通りです：

1. リポジトリをフォークする
2. フィーチャーブランチを作成する（`git checkout -b feature/amazing-feature`）
3. 変更をコミットする（`git commit -m 'Add some amazing feature'`）
4. ブランチにプッシュする（`git push origin feature/amazing-feature`）
5. プルリクエストを作成する

詳細は[貢献ガイドライン](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/CODE_OF_CONDUCT.md)をご覧ください。

## 📄 ライセンス

本プロジェクトはBSD 3条項ライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## 🔒 セキュリティ

セキュリティに関する問題については[セキュリティポリシー](https://raw.githubusercontent.com/Chain-Fox/Chain-Fox/main/SECURITY.md)をご参照ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-23

---