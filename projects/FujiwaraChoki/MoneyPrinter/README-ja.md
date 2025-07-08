# MoneyPrinter 💸

> ♥︎ スポンサー: 最高のAIチャットアプリ: [shiori.ai](https://www.shiori.ai)
---

> 𝕏 さらに、Xでフォローしてください: [@DevBySami](https://x.com/DevBySami)。

YouTube Shortsの作成を自動化します。話したい動画トピックを指定するだけです。

<a href="https://trendshift.io/repositories/7545" target="_blank"><img src="https://trendshift.io/api/badge/repositories/7545" alt="FujiwaraChoki%2FMoneyPrinter | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

> **重要** 独自のIssueを作成する前に、既存/クローズ済みのIssueを必ずご確認ください。質問のみの場合は、[discord](https://dsc.gg/fuji-community)に参加して、そちらでご質問ください。

> **🎥** 動画を[YouTube](https://youtu.be/mkZsaDA2JnA?si=pNne3MnluRVkWQbE)でご覧ください。

ローカルバージョンの手順は[こちら](https://raw.githubusercontent.com/FujiwaraChoki/MoneyPrinter/main/Local.md)をご覧ください。

## FAQ 🤔

### TikTokセッションIDの取得方法は？

ブラウザでTikTokにログインし、`sessionid`クッキーの値をコピーすることで、TikTokセッションIDを取得できます。

### ImageMagickのバイナリが検出されません

`.env`ファイルでImageMagickバイナリへのパスが正しく設定されているか確認してください。以下のようになります。

```env
IMAGEMAGICK_BINARY="C:\\Program Files\\ImageMagick-7.1.0-Q16\\magick.exe"
```

パスには、バックスラッシュ（`\\`）を2つ使用してください。1つではなく2つです。

### `playsound`がインストールできません: Wheelのビルドに失敗しました

`playsound`のインストールで問題が発生した場合は、以下のコマンドをお試しください。

```bash
pip install -U wheel
pip install -U playsound
```

解決できなかった場合は、discordで質問するか、新しいIssueを作成してください。コミュニティがサポートします。

## 寄付について 🎁

`MoneyPrinter`を気に入っていただけた場合、寄付をご希望の場合は、リポジトリ右側のボタンをクリックしてください。❤️
感謝のしるしとして、あなたの名前（および/またはロゴ）がサポーターとしてこのリポジトリに掲載されます。

## コントリビューションについて 🤝

現在、Pull Requestは受け付けていません。

## スター履歴 🌟

[![Star History Chart](https://api.star-history.com/svg?repos=FujiwaraChoki/MoneyPrinter&type=Date)](https://star-history.com/#FujiwaraChoki/MoneyPrinter&Date)

## ライセンス 📝

詳細は[`LICENSE`](LICENSE)ファイルをご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---