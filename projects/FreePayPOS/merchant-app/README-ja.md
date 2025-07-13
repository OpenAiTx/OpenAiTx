# NFC決済端末

5つのブロックチェーンネットワークで暗号通貨決済を処理し、リアルタイムのトランザクション監視と包括的な履歴追跡を備えたマルチチェーンNFC決済端末。

## 🌐 対応ネットワーク

- **Ethereum**
- **Base** 
- **Arbitrum** 
- **Optimism** 
- **Polygon** 

### 🎯 **スマート決済優先順位**

チェーンやトークンの組み合わせを店舗側と交渉する代わりに、決済端末が自動的に処理します。まず店舗が対応し、かつユーザーが資金を持っているチェーンを特定し、以下の優先順位でETHまたはERC-20トークンによるトランザクションを送信します:

```
L2ステーブルコイン > L2その他 > L2 ETH > L1ステーブルコイン > L1その他 > L1 ETH
```
## 🚀 クイックスタート

1. **依存関係のインストール:**
   ```bash
   npm install
   ```

2. **環境設定:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **ターミナルの実行:**
   ```bash
   npm start
   ```

4. **インターフェースを開く:**
   `http://localhost:3000` にアクセスしてください
## 🏗️ アーキテクチャ

```
src/
├── server.ts                   # Expressサーバー & WebSocketハンドラー
├── app.ts                      # メインアプリケーションオーケストレーター
├── web/index.html              # 決済端末UI
├── config/index.ts             # マルチチェーン設定
└── services/
    ├── nfcService.ts           # NFCリーダー & ウォレットスキャン
    ├── alchemyService.ts       # マルチチェーン残高 & モニタリング
    ├── paymentService.ts       # 決済選択 & EIP-681生成
    ├── ethereumService.ts      # アドレス検証ユーティリティ
    └── addressProcessor.ts     # 重複処理防止
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Raspberry Piイメージのビルドを可能にする依存関係のインストール
    └── build-pi-image-osx.sh       # Raspberry Piイメージのビルド
```
## 💡 使い方

### **支払いの処理**
1. キーパッドを使って金額を入力します（セント単位: "150" = $1.50）
2. 「チャージ」をタップして支払いを開始します
3. 顧客がNFCデバイスをタップして支払いを送信します
4. リアルタイムモニタリングで取引を確認します
5. 「承認済み」メッセージとブロックエクスプローラーへのリンクが表示されます

### **取引履歴**
1. キーパッド上の📜履歴ボタンをタップします
2. すべての取引を見るか、特定の履歴を調べるためにウォレットをスキャンします
3. 「📱ウォレット履歴をスキャン」をタップし、顧客にデバイスをタップしてもらいます
4. 特定のウォレットに絞った取引履歴を閲覧します


## 🔄 支払いフロー

1. **NFC検出** → 顧客がデバイスをタップ
2. **マルチチェーン取得** → 6つ全てのチェーンでポートフォリオ分析
3. **スマート選択** → 優先システムに基づき最適な支払いトークンを選択
4. **EIP-681生成** → チェーンID付きの支払いリクエスト
5. **リアルタイムモニタリング** → WebSocket/ポーリングで取引確認
6. **履歴記録** → 取引が完全なメタデータとともに保存される
## 🛡️ トランザクション監視

- Ethereum、Base、Arbitrum、Optimism、Polygon向けの**WebSocket監視**
- **ポーリングベースの監視**によるフォールバック
- 5分後の**自動タイムアウト**
- トランザクション検証のための**ブロックエクスプローラー統合**
- **ステータストラッキング**：検出 → 確認 → 失敗

## 🍓 Raspberry Pi デプロイ

このNFC決済端末は、Raspberry Piハードウェア上で**プラグアンドプレイ型キオスク**として本番運用可能です。

### **ハードウェア要件**
- Raspberry Pi 4B（RAM 4GB以上推奨）
- 7インチ公式Raspberry Piタッチスクリーン
- **ACR1252U-M1 NFCリーダー**（特別サポート）
- 32GB以上のMicroSDカード

### **デプロイ機能**
- **ワンコマンドビルド**で起動可能なSDカードイメージを作成
- **事前設定済みWiFi**およびAPI認証情報
- フルスクリーンキオスクモードで**自動起動**
- テストアドレスでのデプロイを防ぐ**安全性バリデーション**
- **macOSおよびLinux**ビルドサポート
### **クイックデプロイ**
```bash
# デプロイスクリプトへ移動
cd scripts/rpi-deploy

# デプロイ設定
cp build-config.env.template build-config.env
# build-config.env を編集し、WiFi、APIキー、店舗アドレスを入力してください

# ブート可能イメージのビルド（macOS）
./build-pi-image-osx.sh

# 生成された nfc-terminal-<date>.img.gz ファイルを Raspberry Pi Imager でSDカードに書き込み、起動！
```

📖 **[完全なデプロイメントガイド](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---