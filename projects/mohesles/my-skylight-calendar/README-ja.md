# DIYスマートホームファミリーカレンダー（Skylightクローン）

![Sklylightカレンダー](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 はじめに

妻は最近、スマートホームカレンダー（Skylight、Cozyla、Hearth）の広告にSNSで頻繁にさらされ、300ドル以上を使う準備ができていました。許可を出す前に、私に調査のチャンスをくれました。

ほとんどが似た機能を提供していることに気づきましたが、価格には大きな違いがありました。最も重要なのは、**Home Assistant**で実装できない優れた機能を見つけられなかったことです。

**目標：** 妻が受け入れやすい（WAF承認済み）、カウンタートップに置けるタッチスクリーンカレンダーで、月額料金なしでスマートホームに深く統合されること。

## 💡 なぜDIY？

Home Assistantを使ったDIYを選んだ理由は、Skylight/Hearthディスプレイを購入するよりも多くの利点があったからです。

* **月額料金なし：** 「プレミアム」機能のサブスクリプションを回避。
* **シームレスな統合：** 照明、家事（Grocy）、在宅センサーと連携。
* **古いハードウェアの再利用：** ミニPCと標準モニターを再利用。
* **プライバシー：** ベンダーロックインやサービス停止のリスクなし。

## 🛠 ハードウェアの選択

現在は任意のHD（1920x1080）ディスプレイでダッシュボードを表示するように構築しています。

私の場合は、Skylightのように見え、タッチスクリーンでカウンタートップに置け、異なる場所に移動可能なことが要求でした。したがって、以下に説明するハードウェアを選びました。
ただし、用途により異なる場合があり、例えばタブレットで表示したい場合などは調整が必要です。

私が元々使用したハードウェアは上記の要件に基づき、さらにウェブカメラ、スピーカー、マイクを使って機能拡張できることを期待して選びました。現在は、これらの追加ハードウェアのアイデアにまだ対応できていないため、振り返ると別の構成にすると思います。

* **モニター：** [HP Engage 15インチタッチスクリーン](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)。一般的なポータブルモニターよりこれを選んだ理由は、内蔵の**スピーカー、ウェブカメラ、マイク**があり、将来的な音声制御やビデオ通話に対応可能なためです。
* **コンピューター：** Windows/Linuxのキオスクモードで動作する古いミニPC（NUC/Tiny PC）またはRaspberry Pi 4。~~

## ✨ 機能

* **家族全体・個別ビュー：** 特定の家族メンバーのカレンダーの表示を切り替え可能。
* **双方向同期：** 画面上またはスマホ（Googleカレンダー）でイベントを編集可能。
* **「イベント追加」ポップアップ：** 画面から特定のカレンダーに直接イベントを追加できるカスタムUI。

* **天気と日付:** 美しく一目でわかるヘッダー。  
* **レスポンシブ:** 画面幅（モバイルとデスクトップ）に応じて日数を自動調整。

---

## ⚙️ インストールガイド

*注: このセットアップは、必要なヘルパー、スクリプト、変数を自動生成する**YAMLパッケージ**を使用します。手動で作成する必要はありません。*

### 1. 前提条件 (HACS)

[HACS](https://hacs.xyz/)がインストールされている必要があります。以下の**フロントエンド**統合をインストールしてください:

* `week-planner-card`  
* `bubble-card`  
* `config-template-card`  
* `card-mod`  
* `better-moment-card`  
* `weather-card`  
* `browser_mod`（ポップアップの動作に必要）  
* `layout-card`（セクションビューに必要）  
* `button-card`（イベント追加用ポップアップに必要）

### 2. バックエンド（頭脳部分）

1. Home Assistantの`configuration.yaml`ファイルを開きます。  
2. パッケージを有効にするために、`homeassistant:`の下に次の行が追加されていることを確認してください:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. HAの設定ディレクトリに`packages`というフォルダを作成します（まだない場合）。
4. このリポジトリから[packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml)をダウンロードします。
5. ファイルを`packages/`フォルダ内に配置します。
6. **Home Assistantを再起動します**。

### 3. カレンダー

**Googleカレンダー**または**ローカルカレンダー**を使用できます。

#### オプションA: ローカルカレンダー（最も簡単）

これは未検証です。私はGoogleカレンダーのみを使用しているためです。

1. **設定 > デバイスとサービス** に移動します。
2. **ローカルカレンダー**の統合を追加します。
3. 正確に次の名前のカレンダーを作成します：`Alice`、`Bob`、`Charlie`、`Daisy`、`Family`。
    * *これらの名前を使うと、コードはすぐに動作します！*

#### オプションB: Googleカレンダー

1. `packages/family_calendar.yaml`を開きます。
2. `add_google_calendar_event`スクリプトまでスクロールします。
3. `calendar_map`をあなたの実際のGoogleエンティティに更新します：


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### 休日の設定

Home Assistantのアップデートにより、休日はUIから追加するようになりました：

1. **設定 > デバイスとサービス > インテグレーションを追加 > Holiday** に移動します。
2. 国を選択します。
3. エンティティID（例：`calendar.holidays`）を確認します。デフォルトと異なる場合は、ダッシュボードのYAMLで更新してください。

### 4. ダッシュボード（見た目）

1. 新しいダッシュボードビューを作成します（ビュータイプを**セクション**に設定）。
2. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml)からコードをコピーします。
3. **カスタマイズ：**
   * **検索と置換：** `person.alice` を実際の家族メンバーのエンティティに置き換えます。
   * **天気：** `weather.home` をご利用の天気提供元に置き換えます。
   * **背景：** yamlの一番下の画像URLを更新します。

### ステップ5：テーマ（オプション）

特定のフォント（Ovo）を使用するには：

1. `configuration.yaml` の `frontend:` の下にこの行があることを確認してください。

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. configディレクトリ内に `themes` という名前のフォルダを作成します。  
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) をダウンロードし、そのフォルダに配置します。  
4. Home Assistantを再起動します。  
5. プロフィール（左下のユーザーアイコン）に移動し、**テーマ** を `Skylight` に変更します。  
注意：テーマは完全なものではないため、その点を考慮してください。  

---  

## 📐 仕組み（内部動作）  

### フィルターのロジック  

`week-planner-card` は特定のカレンダーを動的に非表示にする機能をネイティブにはサポートしていません。これを解決するために、正規表現フィルターとして機能する **Input Texts** を使用しています。  

* 人物のボタンをクリックすると、そのフィルターが `.*`（すべて表示）と `^$`（何も表示しない）を切り替えます。  
* `config-template-card` がこれらの変数をカレンダーカードに動的に注入します。  

### イベント作成スクリプト  

「イベント追加」ポップアップは、複数の人物およびイベントタイプ（終日イベントと時間指定イベント）のロジックを処理する単一のスクリプトを使用しています。


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## 注意事項

私の元の投稿は、どのように行うかの大まかな概要を示し、人々が自分の特定のシナリオで動作するようにコードを調整できるようにすることでした。

特にこれは、すべてのディスプレイやニーズが異なるために行いました。すべての潜在的なサイズのディスプレイやダッシュボードのために開発することはできません。したがって、私が述べたディスプレイや任意の（1920x1080）で動作するように構築されていますが、他のものにも編集可能なはずです。

ディスプレイについて話すと、私は元々それを提案したのは、Wootでセール中であり、その時点でタッチスクリーンディスプレイを入手する非常に経済的な方法だったからです。これは今では当てはまらないかもしれませんので、自分に合ったディスプレイを使用してください。タブレット、タッチスクリーン、携帯電話、何でも構いません。主に編集が必要なのはダッシュボードです。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-06

---