# mimotion
![ 刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Mi Fit 自動歩数偽装

> Mi Fit 自動歩数偽装

## Github Actions デプロイガイド

### 一、当リポジトリをForkする

### 二、アカウントとパスワードの設定
# 20230224追加
**CONFIG** という名前の変数を追加: Settings-->Secrets-->New secret。以下のjsonテンプレートを使用して複数アカウントを設定、メールアドレスや電話番号に対応。
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN。未使用の場合は空欄",
  "TG_USER_ID": "telegram TG_USER_ID。未使用の場合は空欄",
  "SKEY": "酷推skey。未使用の場合は空欄",
  "SCKEY": "server酱sckey。未使用の場合は空欄",
  "POSITION": "企業WeChatプッシュ通知を有効にするか。未使用の場合は空欄",
  "CORPID": "企業ID。企業WeChatにログインし「マイ企業」→「企業情報」で確認。未使用の場合は空欄",
  "CORPSECRET": "企業WeChatの自作アプリごとに異なるsecret。未使用の場合は空欄",
  "AGENTID": "企業WeChat自作アプリID（整数）。AgentId。未使用の場合は空欄",
  "TOUSER": "メッセージ受信メンバー指定。IDリスト（複数は「&#166;」区切り、最大1000名）。全員は「@all」。未使用の場合は空欄",
  "TOPARTY": "メッセージ受信部署指定。IDリスト（複数は「&#166;」区切り、最大100部署）。全員は「@all」。未使用の場合は空欄",
  "TOTAG": "メッセージ受信タグ指定。IDリスト（複数は「&#166;」区切り、最大100タグ）。全員は「@all」。未使用の場合は空欄",
  "OPEN_GET_WEATHER": "地域天気に応じて歩数を減らす機能を有効に。未使用の場合は空欄",
  "AREA": "天気取得地域を設定（有効時必須）。例：北京。未使用の場合は空欄",
  "QWEATHER": "和風天気Private KEY。申請：https://console.qweather.com/#/apps。未使用の場合は空欄",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "複数アカウントの最大歩数。上記参照",
      "min_step": "複数アカウントの最小歩数。上記参照",
      "password": "複数アカウントのパスワード。上記参照",
      "user": "複数アカウントの電話番号。上記参照"
    }
  ]
}
```
> **PAT** という名前の変数も追加: Settings-->Secrets-->New secret

| Secrets |  フォーマット  |
| -------- | ----- |
| PAT |   **PAT**は申請が必要で、値はgithub token。詳細：https://www.jianshu.com/p/bb82b3ad1d11 。repoとworkflow権限が必要、必須項目です。git pushの権限エラーを防ぐため。 |

**CONFIG**サンプル
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "複数アカウントの最大歩数。上記参照",
      "min_step": "複数アカウントの最小歩数。上記参照",
      "password": "複数アカウントのパスワード。上記参照",
      "user": "複数アカウントの電話番号。上記参照"
    }
  ]
}
```

### 三、起動時間のカスタマイズ

**random_cron.sh** を編集  
**if**文の判定時間をUTC（日本時間-8）に変更。例：北京時間8時＝UTC0時。実行したい時間-8がUTC時間となる。



## 注意事項

1. 1日7回実行されます（random_cron.shで管理、分はランダム）

2. 複数アカウントの場合、数とパスワードは必ず正確に入力してください。そうでないと利用できません！

3. 起動時間はUTC時間です！

4. server酱新規登録は[こちら](https://sct.ftqq.com/)

5. Alipayで歩数が更新されない場合、Mi Fit→設定→アカウント→アカウントログアウト→データ消去→再ログイン→サードパーティ再連携をお試しください。

6. Mi Fit自体は歩数を更新しません。連携サービスのみ同期されます！！！！！

7. ご利用時は必ず[メインブランチ](https://github.com/xunichanghuan/mimotion-run/)をForkしてください。不要なバグを防ぎます。

8. アカウントは [小米アカウント] ではなく、[Mi Fitアカウント] です。ご注意ください。

## 過去のStar数 

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---