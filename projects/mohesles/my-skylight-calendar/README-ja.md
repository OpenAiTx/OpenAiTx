
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIYスマートホームファミリーカレンダー（Skylightクローン）

![Sklylight calendar](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 はじめに

妻が最近、スマートホームカレンダー（Skylight、Cozyla、Hearth）の広告をSNSで頻繁に見かけており、300ドル以上をかけて購入しようとしていました。私はその前に、これらの製品について調査する機会をもらえないか頼みました。
ほとんどの製品が類似した機能を提供していますが、価格に大きな違いがあることに気づきました。最も重要なのは、**Home Assistant**で実装できない優れた機能は見当たらなかったことです。

**目標:** WAF（妻の受容性）を満たし、カウンタートップに置ける、スマートホームと深く連携し月額料金不要のタッチスクリーンカレンダーを作ること。

## 💡 なぜDIYなのか？

Home AssistantによるDIYを選ぶことで、SkylightやHearthディスプレイを購入するよりも多くの利点がありました：

* **月額料金不要:** 「プレミアム」機能のためのサブスクリプションを回避。
* **シームレスな統合:** 照明、家事管理（Grocy）、在宅センサーと連携。
* **古いハードウェアの再利用:** Mini PCと一般的なモニターを再活用。
* **プライバシー:** ベンダーロックインや会社のサービス終了リスクがない。

## 🛠 ハードウェア選定

現在、このダッシュボードはHD（1920x1080）ディスプレイで表示するように構築されています。

私の場合、「Skylightのように見える」「タッチスクリーン」「カウンタートップに置ける」「移動できる」という要件がありました。そのため、以下に記載するハードウェアを選択しました。
ただし、ご自身のケースに応じて、例えばタブレットなど他の機器で表示したい場合は、必要に応じて調整が必要です。

元々選定したハードウェアは、上記の理由に加え、Webカメラ・スピーカー・マイクを活用して機能拡張することも念頭に置いていました。現在はこれらのハードウェア案にはまだ着手できていないので、今なら違う構成で作るかもしれません。

* **モニター:** [HP Engage 15インチ タッチスクリーン](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor)。汎用ポータブルモニターよりも、**スピーカー・Webカメラ・マイク**内蔵で、将来的な音声操作やビデオ通話にも対応可能なため選びました。
* **コンピューター:** 旧型Mini PC（NUC/Tiny PC、Windows/Linuxのキオスクモード）、またはRaspberry Pi 4。

## ✨ 機能

* **家族全体＆個人表示:** 特定の家族メンバーのカレンダーをオン/オフ切り替え可能。
* **双方向同期:** 画面またはスマホ（Googleカレンダー）からイベント編集。
* **「イベント追加」ポップアップ:** 画面上から特定カレンダーに直接イベントを追加するカスタムUI。
* **天気＆日付:** 一目で分かる美しいヘッダー。
* **レスポンシブ:** 画面幅（モバイル/デスクトップ）に応じて日数を自動調整。

---

## ⚙️ インストールガイド

*注意: このセットアップは**YAMLパッケージ**を利用し、必要なヘルパー・スクリプト・変数を自動で作成します。手動で作成する必要はありません。*



### 1. 前提条件（HACS）

[HACS](https://hacs.xyz/) がインストールされている必要があります。以下の**フロントエンド**統合をインストールしてください：

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod`（ポップアップ動作に必須）
* `layout-card`（Sectionsビューに必須）
* `button-card`（イベント追加用ポップアップに必須）

### 2. バックエンド（頭脳）

1. Home Assistant の `configuration.yaml` ファイルを開きます。
2. パッケージを有効にするために、`homeassistant:` の下に次の行が追加されていることを確認してください：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---