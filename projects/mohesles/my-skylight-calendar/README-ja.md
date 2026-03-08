
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
* `browser_mod`（ポップアップの動作に必須）
* `layout-card`（Sectionsビューに必須）
* `button-card`（イベント追加ポップアップに必須）

*注意: 設定 → デバイス & サービスで、Browser Modが統合（タイル）として表示されていることを確認してください。HACSの下だけに表示されている場合は、統合の追加 → Browser Mod をクリックし、フローを完了してからHAを再起動してください。
HACSでのインストールはファイルをダウンロードするだけです。統合を追加することで、HAがそのアクション/エンティティを認識します。

### 2. バックエンド（頭脳部分）

1. Home Assistantで `configuration.yaml` ファイルを開きます。
2. パッケージを有効にするため、`homeassistant:` の下に次の行が追加されていることを確認してください：


   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. HAの設定ディレクトリ内に`packages`というフォルダを作成します（まだない場合）。
4. このリポジトリから [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) をダウンロードします。
5. 文字列 [ #<--- UPDATE THIS ENTITY] を検索し、カレンダーエンティティIDを自分の環境に合わせて更新します。詳細はセクション3を参照してください。
6. ファイルを`packages/`フォルダ内に配置します。
7. **Home Assistantを再起動**します。

### 3. カレンダー

**Googleカレンダー**または**ローカルカレンダー**を使用できます。

#### オプションA: カレンダー名を再利用（最も簡単）


1. **設定 > デバイス & サービス** に移動します。
2. **ローカルカレンダー**インテグレーションを追加します。
3. 以下の正確な名前でカレンダーを作成します: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`。
    * *これらの名前を使用すれば、コードはすぐに動作します！*

#### オプションB: カスタムカレンダー

1. **設定 > デバイス & サービス** に移動します。
2. **ローカルカレンダー**または**Googleカレンダー**インテグレーションを追加します。
3. **設定 > インテグレーション > ローカルカレンダー**または**Googleカレンダー**に移動し、「エントリを追加」を選択します。
4. 作成した各エントリについて、dashboard.yamlファイルを更新するためのエンティティIDを取得します。
5. `dashboard.yaml`を開きます。
6. `# <--- UPDATE THIS ENTITY` を検索します。
7. 環境に合わせてエンティティIDを更新します。


#### 祝日の設定

Home Assistantのアップデートにより、祝日はUIから追加されるようになりました：

1. **設定 > デバイス & サービス > インテグレーションを追加 > Holiday** に移動します。
2. 国を選択します。
3. エンティティID（例: `calendar.holidays`）を確認します。デフォルトと異なる場合は、dashboard YAMLで更新してください。

### 4. ダッシュボード（見た目）


1. **設定 > ダッシュボード** に移動します
2. **ダッシュボードを追加** をクリックします（「新しいダッシュボードを最初から」を選択し、「サイドバーに追加」を選択してください）。
3. 左側のメニューで新しく作成したダッシュボードを選択し、鉛筆アイコンをクリックして編集します。
5. 3つの点のアイコンを選択し、「Raw configurator editor」を選択します。
6. [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) のコードをコピーして貼り付けます。

### ステップ 5: テーマ（オプション）

特定のフォント（Ovo）の見た目を得るには：

1. `configuration.yaml` の `frontend:` の下に次の行があることを確認してください。

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. 設定ディレクトリに `themes` という名前のフォルダを作成します。
3. [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) をダウンロードし、そのフォルダに配置します。
4. File Editor を使って calbackgrd.png を /www/ フォルダにアップロードします。これはダッシュボード上で内部的に /local に変換されます。
5. Home Assistant を再起動します。
6. プロファイル（左下のユーザーアイコン）に移動し、**テーマ** を `Skylight` に変更します。
注意: このテーマは包括的ではないため、その点を考慮してください。

---

## 📐 仕組み（内部動作）

### フィルターロジック

`week-planner-card` は特定のカレンダーをその場で非表示にすることをネイティブにはサポートしていません。これを解決するために、**Input Texts** を Regex フィルターとして使用しました。

* 人物ボタンをクリックすると、そのフィルターが `.*`（すべて表示）と `^$`（何も表示しない）でトグルされます。
* `config-template-card` がこれらの変数をカレンダーカードに動的に注入します。

### イベント作成スクリプト

「イベント追加」ポップアップは、複数の人物やイベント種別（終日 vs 時間指定）のロジックを処理する単一のスクリプトを使用しています。


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---