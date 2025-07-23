# DeckTap (LAN MVP)

<a href="https://youtu.be/pNgNUWSf7C4" title="Link Title"><img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/hero.png" alt="Alternate Text" width="600"/></a>

📡 DeckTapは、プレゼンテーションを制御するための軽量なローカルネットワークリモコンです。  
アプリのインストールは不要で、スマートフォンからPowerPoint、Keynote、PDFスライドショーをワイヤレスで操作できます。

---

## ✨ 特徴

- 📱 スマートフォンのブラウザからスライドを操作
- 🌐 ローカルWi-Fi/ホットスポットネットワーク上で動作
- 🖥 キーボードの矢印キーをシミュレートしてスライドを移動
- 🚀 最小限のセットアップ：ローカルのNode.jsサーバーを起動しQRコードをスキャン
- 🔒 インターネット不要で、**安全**かつ**プライベート**

---

## 📦 プロジェクト構成
```yaml
decktap/
├── client/            # Computer side agent
│    ├── lan.js        # LAN control
│    ├── cloud.js      # Connect cloud relay server in the future
│    └── config.js
│
├── controller/        # Mobile phone controller web page
│    └── index.html
│
├── server-cloud/      # Cloud server for remote control in the future
│    └── server.js
│
├── README.md
├── LICENSE
├── package.json
└── .gitignore
```
---

## 🔧 必要条件

### macOSの権限設定
DeckTapはキーボードイベントをシミュレートするために `@nut-tree/nut-js` を使用しています。macOSでは、ターミナルにアクセシビリティの権限を付与する必要があります：

1. **システム設定** > **プライバシーとセキュリティ** > **アクセシビリティ** を開く
2. 鍵アイコン 🔒 をクリックして変更を許可する
3. **+** ボタンをクリック
4. `Terminal.app`（またはiTerm、VS Codeなど使用しているもの）を選択
5. ターミナルアプリの横のチェックボックスをオンにする

> **注意**：これらの権限がないと、DeckTapはプレゼンテーションを操作できません。

---

## 🚀 はじめに（LANモード）
1. 依存関係をインストール：
   ```bash
   cd decktap-web && npm install && npm run build
   cd .. && npm install
   ```
2. アクセシビリティの権限を付与する（macOSのみ）：
   - [macOSの権限設定](#macos-permissions) の手順に従ってください
   - 権限を付与した後、ターミナルを再起動してください

3. サーバーを起動する：

   ```bash
   npm start
   ```
4. お使いの電話と接続する：
   - お使いの電話をコンピュータと同じWiFiネットワーク（vlanなしのプライベートWiFiのみ対応、キャンパスネットワークでは動作しません）に接続してください
   - 電話のブラウザで表示されたURLを開くか、QRコードをスキャンしてください
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/computer-client.png" width="600">
   - プレゼンテーションのコントロールを開始します（左右の手モード切替には👉を使用）
   - <img src="https://raw.githubusercontent.com/Rico00121/decktap/main/./images/phone-controller.png" width="300" >
  

---

## ~🖱️ スタンドアロン配布クイックスタート~（未対応、将来的にElectronクライアントを開発予定）

DeckTapの**スタンドアロン実行可能バージョン**（`decktap-macos`、`decktap-win.exe`、`decktap-linux`など）を受け取った場合、Node.jsや依存関係をインストールせずに直接実行できます。

### 手順
1. **macOS / Linuxユーザー：**
   - 初回実行前に実行権限を付与してください（1回のみ必要）：

     ```bash
     chmod +x decktap-macos
     ```
   - Run:
     ```bash
     ./decktap-macos
     ```
2. **Windowsユーザー：**
   - コマンドプロンプトで実行してください：

     ```bat
     decktap-win.exe
     ```
3. **macOSでの初回実行:** ターミナルの指示に従ってアクセシビリティ権限を付与してください（上記の[macOSの権限](#macos-permissions)参照）。

4. **QRコードをスキャンするか、表示されたURLを携帯で開いてプレゼンテーションの操作を開始してください！**

---

> 実行できない、権限が不十分、ページにアクセスできないなどの問題が発生した場合は、ターミナルのエラーメッセージを開発者に送ってサポートを受けてください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---