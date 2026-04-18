

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/extension/icon128.png" width="72" alt="TerminalStart アイコン">
</p>

<h1 align="center">TerminalStart</h1>

<p align="center">
  集中と速度のために作られた、レトロ風モジュラー新規タブダッシュボード。
</p>

<p align="center">
  <a href="https://thecsir.github.io/TerminalStart/">ライブデモ</a>
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/mainPage.png" width="900" alt="TerminalStart プレビュー">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/TheCSir/TerminalStart/main/docs/settingsPage.png" width="900" alt="TerminalStart 設定">
</p>

---


## Edge / Chrome にインストール

1. `edge://extensions`（または `chrome://extensions`）を開く
2. **デベロッパーモード**を有効にする
3. **パッケージ化されていない拡張機能を読み込む**をクリック
4. `extension` フォルダを選択する


## Todoist 連携

個人用APIトークンを使ってTodoウィジェットをTodoistと同期。

1. **設定 > 詳細設定 > Todoウィジェット**に移動
2. **Todoistと同期を有効化**  
3. APIトークンを貼り付けます（設定 > 統合 > 開発者 - [todoist.com](https://todoist.com)）  
4. プロンプトが表示されたらホスト権限を付与してください  

**期限日** — タスク作成時に自然言語で日付を追加可能：  

| 入力 | タスク | 期限 |  
|---|---|---|  
| `meet john tomorrow at 2pm` | meet john | 明日午後2時 |  
| `buy groceries next monday` | buy groceries | 次の月曜日 |  
| `call mom every friday` | call mom | 毎週金曜日 |  
| `submit report jan 15` | submit report | 1月15日 |  

TodoistのNLPが解析を処理します。ローカルモードでは時間のみの構文（例：`standup 9am`）もサポートしています。  

## ビルド  

### 必要条件  

* Node.js v16以上  
* Python 3  

### 手順  

1. 依存関係をインストール：

```
npm install
```

2. ビルド：

```
npm run build
```
ビルドスクリプトはアセットを自動的に`extension/`フォルダーに同期します。

3. パッケージ:


```
python scripts/package_addon.py
```
出力: `terminal-start-v1.0.0.zip`

### テスト


```
npx playwright test
```

Chromiumを使用して拡張機能に対してe2eテストを実行します。

## 注意事項

- 設定は右上のセクションにカーソルを合わせてください。
- APIトークンはブラウザ内にローカルで保存され、Todoist API以外の場所には一切送信されません。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-18

---