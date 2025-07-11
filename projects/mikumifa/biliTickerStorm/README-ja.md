# 🎫 BiliTickerStorm

## ⚙️ サービス説明

| サービス名             | 説明                         | 備考         |
| ---------------------- | --------------------------- | ------------ |
| `ticket-master`        | メインコントロールサービス、タスクのスケジューリングを担当 | 単一インスタンス配置 |
| `ticket-worker`        | チケット取得ワーカー、水平スケーリング可能           | 複数インスタンス対応 |
| `gt-python`            | 画像認証コード処理サービス                       | 単一インスタンス配置 |

---

## 🚀 クイックデプロイ手順

> クラスター構築については [クラスター構築ガイド](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) を参照してください。

<details> <summary><strong>📦 リモートリポジトリからのインストール（推奨）</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Chart のインストール

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` はチケット取得設定ファイルのディレクトリで、`ticket-master` コンテナにマウントされます。チケット取得設定ファイルは https://github.com/mikumifa/biliTickerBuy を使って生成します。
> - `ticketWorker.pushplusToken` は pushplus の通知設定で、設定するとチケット取得結果の通知を受け取れます。
> - `ticketWorker.ticketInterval` はチケット取得の間隔（秒単位）で、デフォルトは 300 ミリ秒です。
> - `ticketWorker.ticketTimeStart` は定時起動の時刻で、フォーマットは `2025-05-20T13:14` です。未設定の場合はコンテナ起動時にすぐチケット取得を開始します。

### 3. Chart のアップグレード

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 ローカル Chart インストール</strong></summary>


### 1. Chart のインストール

```bash
# リポジトリをクローン
git clone https://github.com/mikumifa/biliTickerStorm
# ローカル Chart パッケージを使用
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Chart のアップグレード

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 共通コマンド</strong></summary>

### ⏹ アンインストール
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 免責事項

本プロジェクトは MIT License ライセンス規約に従い、個人の学習および研究用途のみに提供されます。本プロジェクトをいかなる商業的利益目的で使用すること、およびいかなる形態の自動購入、違法行為、または関連プラットフォーム規則違反の用途で使用することも固く禁じます。これにより生じる一切の結果については、利用者自身の責任となり、当方は一切関与いたしません。

本プロジェクトを fork する、または利用する場合は、必ず関連する法律法規および対象プラットフォームの規則を遵守してください。

## 💡 アクセス頻度と同時実行制御について
本プロジェクトは設計段階から「非侵入型」原則を厳守しており、対象サーバー（例：Bilibili）にいかなる干渉も与えないようにしています。

すべてのネットワークリクエストの間隔はユーザーが自由に設定でき、デフォルト値は通常のユーザーによる手動操作速度を模倣しています。プログラムはデフォルトでシングルスレッドで動作し、同時実行タスクはありません。リクエストが失敗した場合、プログラムは限定回数のリトライを行い、その間に適切な遅延を挟むことで高頻度のアクセスを回避します。本プロジェクトは完全にプラットフォームの公開インターフェースおよびWebページ構造に依存しており、リスク回避やAPIハイジャックなどの破壊的手法は一切含みません。
## 🛡️ プラットフォーム尊重声明

本プログラムは設計時にリクエスト頻度をできる限り制御し、Bilibili サーバーに対して明らかな負荷や影響を与えないようにしています。本プロジェクトは学習目的のみであり、大規模・高並列の能力は持たず、また悪意ある行為やサービス妨害の意図もありません。

もし本プロジェクトに Bilibili 社の合法的権益を侵害する内容が含まれている場合は、メール [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) までご連絡ください。速やかに関連内容を削除し、本リポジトリも削除いたします。ご不便をおかけすることを深くお詫び申し上げます。ご理解とご寛容に感謝いたします。

## 📄 ライセンス

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---