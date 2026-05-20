[![Build branches](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml/badge.svg)](https://github.com/freekode/tp2intervals/actions/workflows/branch.yml)
[![release](https://img.shields.io/github/release/freekode/tp2intervals)](https://github.com/freekode/tp2intervals/releases/latest)

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/E1E6W6XZP)

# Third Party to Intervals.icu

TrainingPeaks、TrainerRoad、Intervals.icu間のワークアウト同期アプリ。

MacOS（DMG）、Windows（EXEインストーラー）、Linux（AppImage）で動作。代わりにDockerイメージと実行可能なJARもあります。

すべてのファイルは[リリースページ](https://github.com/freekode/tp2intervals/releases/latest)からダウンロード可能です。

**教育目的のみ**

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp.png?raw=true" width="25%"><img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr.png?raw=true" width="25%">

* [機能一覧](#list-of-features)
* [設定方法](#configuration)
    + [Intervals.icu](#intervalsicu)
    + [TrainingPeaks](#trainingpeaks)
    + [TrainerRoad](#trainerroad)
* [アプリの他の実行方法](#other-ways-to-run-the-app)
    + [実行可能JAR](#executable-jar)
    + [Docker](#docker)
* [よくある質問](#faq)
    + [一般](#general)
    + [TrainingPeaks無料アカウントで翌日のスケジューリングに関する情報](#info-regarding-scheduling-for-the-next-day-with-trainingpeaks-free-account)
* [トラブルシューティング](#troubleshooting)
    + [ログの取得方法](#how-to-get-logs)
    + [HARファイルの記録方法](#how-to-record-har-file)



**新しいDockerイメージの場所 ⚠️**

**新しいイメージURL: `ghcr.io/freekode/tp2intervals`**

古いイメージURL: `ghcr.io/freekode/tp2intervals/tp2intervals`

**TrainerRoadのアップデート**

私はもうTrainerRoadにアクセスできません。使用していたアカウントはサブスクリプションをキャンセルしました。プラットフォームは使っておらず、たまに問題を修正するだけのために持つには高価すぎます。
問題を修正するには、ログとHARファイルにのみ頼ることができます。

## 機能一覧

**TrainingPeaks**

アスリートアカウント
* Intervals.icuとTrainingPeaks間のカレンダーに計画されたワークアウトを同期（無料のTPアカウントで今日と明日分）
* TrainingPeaksからトレーニングプラン全体をコピー
* TrainingPeaksの計画されたワークアウトからIntervals.icuにトレーニングプランまたはワークアウトフォルダを作成

コーチアカウント
* TrainingPeaksからトレーニングプラン全体とワークアウトライブラリをコピー

**TrainerRoad**
* TrainerRoadからTrainingPeaksまたはIntervals.icuのカレンダーに計画されたワークアウトを同期
* TrainerRoadライブラリからIntervalsにワークアウトをコピー
* TrainerRoadの計画されたワークアウトからIntervals.icuにトレーニングプランまたはワークアウトフォルダを作成

カレンダーを20分ごとにチェックして今日のワークアウトを自動的にスケジュールします。
スケジュールされたジョブをクリアするには、アプリケーションを再起動してください。


## 設定
アプリケーションを使用する前にプラットフォームへのアクセスを設定する必要があります。
Intervals.icuへのアクセスは必須で、他のプラットフォームへのアクセスは任意です。

必要な設定をすべて集めたら、確認ボタンをクリックできます。
すべて問題なければ、ホームページにリダイレクトされます。

設定が間違っている場合、特定のプラットフォームへのアクセスがないというエラーが表示されます。
すべての値を確認して設定を再保存してください。

### Intervals.icu
Intervals.icuのウェブページの[設定ページ](https://intervals.icu/settings)の開発者設定セクションからAPIキーとアスリートIDをコピーしてください。

### TrainingPeaks
TrainingPeaksを使用するには、リクエスト `https://tpapi.trainingpeaks.com/users/v3/token` からすべてのクッキーをコピーし、設定ページに貼り付けてください。  
アプリは自動的に冗長な部分を削除し、必要なクッキーのみが残ります。以下のガイドに従って操作してください。  

アプリには `Production_tpAuth` クッキー（キーと値、例：`Production_tpAuth=very_long_string`）が必要です。  
別のガイドは[こちら](https://forum.intervals.icu/t/implemented-push-workout-to-wahoo/783/87)にあります。  

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tp_guide.png?raw=true">  

### TrainerRoad  
設定はTrainingPeaksと非常に似ています。リクエスト `https://tpapi.trainingpeaks.com/users/v3/token` からすべてのクッキーをコピーし、設定ページに貼り付けてください。  
アプリは自動的に冗長な部分を削除し、必要なクッキーのみが残ります。以下のガイドに従って操作してください。  

アプリには `SharedTrainerRoadAuth` クッキー（キーと値、例：`SharedTrainerRoadAuth=very_long_string`）が必要です。  

<img src="https://github.com/freekode/tp2intervals/blob/main/docs/tr_guide.png?raw=true">  

注意：Firefoxの開発者ツールウィンドウでは長い文字列が切り詰められます。クッキーの値は右クリック -> 「値をコピー」でコピーしてください。  

## その他のアプリ実行方法  
### 実行可能JAR  
このプロジェクトにはWeb UIを備えた実行可能なJARが含まれています。JDK 21が必要です。JARを実行するには：
```shell
java -jar tp2intervals.jar
```
デフォルトでは、UIは `http://localhost:8080` で利用可能です。ポートを変更するには、パラメータを指定してjarを起動してください:

```shell
java -Dserver.port=9090 -jar tp2intervals.jar
```

### Docker
Dockerイメージはすべてのリリースでビルドされます。

```yaml
services:
  app:
    image: ghcr.io/freekode/tp2intervals:latest
    container_name: tp2intervals
    volumes:
      - ./tp2intervals.sqlite:/tp2intervals.sqlite
    ports:
      - '8080:8080'
```
## FAQ

### 一般
* TrainerRoadのランプステップはサポートされていません
* **MacOS arm64** エラー: `"tp2intervals" は破損しているため開けません。`
  ターミナルでコマンド `xattr -d com.apple.quarantine /Applications/tp2intervals.app` を実行してから再度アプリを開いてください
* **MacOS** アプリは署名されていません。通常は2回開く必要があります
* **Windows** アプリはローカルネットワークとインターネットへのアクセスを求めます。許可する必要があります。すべてHTTPリクエストを行います
* 詳細はフォーラム https://forum.intervals.icu/t/tp2intervals-copy-trainingpeaks-and-trainerroad-workouts-plans-to-intervals/63375 で確認できます

### TrainingPeaks無料アカウントで翌日のスケジューリングに関する情報
公式には無料のTPアカウントでは将来の日付のワークアウトを計画できませんが、実際には可能です。
TrainingPeaksサーバーの現地時間に対して翌日のワークアウトを計画できます。サーバーはUTC-6タイムゾーンにあります。いくつか例を見てみましょう：

例1. あなたのタイムゾーンはUTC+2で現在の現地日時が2024年5月20日06:00です。つまりこの時点でTPサーバーの現地日時は2024年5月19日22:00です。
したがって、2024年5月20日のワークアウトを計画できます。しかし2024年5月21日のワークアウトは計画できません。2時間後に計画可能になります。なぜなら2時間後にサーバーの現地時間が2024年5月20日00:00になるからです。

例2. あなたのタイムゾーンはUTC+12で現在の現地日時が2024年5月20日18:00です。TPサーバーの現地日時は2024年5月20日00:00です。この時点で2024年5月21日のワークアウトを計画できます。

[worldtimebuddy](https://www.worldtimebuddy.com/?pl=1&lid=206,100,756135,2193733&h=206&hf=0)での表示される時差

## トラブルシューティング
どのプラットフォームの問題を特定するにも、ユーザーからのログが非常に役立ちます。

以下の[ガイド](#how-to-get-logs)からログを収集してください。TrainerRoadプラットフォームの場合は[HARファイルの記録](#how-to-record-har-file)も試みてください。ファイルを直接私に送ってください。

#### ログの取得方法
1. 設定に移動
2. 一般セクションでデバッグモードをチェックし、確認をクリック
3. 問題を再現
4. システムに応じたログファイルを見つける

* Linux: ~/.config/tp2intervals/logs/main.log
* MacOS: ~/Library/Logs/tp2intervals/main.log
* Windows: %USERPROFILE%\AppData\Roaming\tp2intervals\logs\main.log
* JAR: ./tp2intervals.log

#### HARファイルの記録方法
1. ブラウザで新しいタブを開く

2. デベロッパーツールを開き、「ログを保持する」（Firefoxの歯車アイコン -> ログを保持）にチェックを入れます。

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-1.png?raw=true" width="70%">
3. 次のステップは非常に重要で、アプリが行う動作をシミュレートします。
   TrainerRoadのページを開き、ワークアウトライブラリを開き、任意のワークアウトを見つけ、ワークアウトページを開きます（ワークアウトステップのチャート、説明、代替案などがあるページ）。
4. デベロッパーツールで「HARをエクスポート」をクリックします（Firefox - 歯車アイコン -> すべてをHARとして保存）、ファイルを保存して私に送ってください。

   <img src="https://github.com/freekode/tp2intervals/blob/main/docs/har-2.png?raw=true" width="70%">



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---