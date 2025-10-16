Simple Config GeoIP for Quantumult X (QuantumultX), Loon, Stash 预配置文件包含 Apple News解锁规则、去广告分流规则、TikTok 解锁 Rewrite、神机分流规则和 VIP 视频解析重写, 并提供相应的快捷方式

## 简介
> + 利用 Quantumult X 和 GeoIP 特性整合多个重写配置, 剔除大部分规则以节省开销, 通过 Vercel 重定向精简规则和配置文件
- [使用方法](https://github.com/smxl/500#使用方法)
- [分流规则和重写](https://github.com/smxl/500#分流规则和重写)
- [小工具](https://github.com/smxl/500#小工具)
- [配置文件更新](https://github.com/smxl/500#配置文件更新)
- [推荐](https://github.com/smxl/500#推荐)

## 声明

Disclaimer: 部分脚本和内容由 ChatGPT 编写

本项目在多个 [Quantumult X](https://apps.apple.com/us/app/quantumult-x/id1443988620) 配置文件上进行了优化

所有内容仅供参考, 不对本项目上的任何第三方内容负责, 这些链接和内容仅供参考和方便使用, 不代表本项目对这些内容的赞同或认可

Github 地址: [https://github.com/smxl/500](https://github.com/smxl/500)

##  使用方法

1. 下载或复制配置文件

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/500.conf](https://cnn.vercel.app/500.conf)

2. Quantumult X - 風車 - 設定ファイル - ダウンロード - 貼り付け - 確定

3. Mitm - 証明書を生成 - 証明書を設定 - 証明書をインストール

4. システム - 設定 - 一般 - 情報 - 証明書を信頼

5. Quantumult X - 風車 - ノード - 引用 (サブスクリプション) - 右上追加 - ラベルとリソースパスを入力 (自分のサーバーサブスクリプションリンク)

6. Quantumult X - 風車 - その他の設定 - GeoLite2 ソース GeoIP を追加

7. GeoIP2-CN のいずれかを選択（リンクをコピーするかダウンロードしてインポート）
> - [Loyalsoldier](https://github.com/Loyalsoldier/geoip/raw/release/Country-only-cn-private.mmdb)
> - [Hackl0us](https://github.com/Hackl0us/GeoIP2-CN/raw/release/Country.mmdb)
> - [soffchen](https://github.com/soffchen/GeoIP2-CN/raw/release/Country.mmdb)

8. ご自身のサブスクリプションリンクがない場合は直接使用可能です。ご自身のサブスクリプションを使用したい場合は、設定ファイルの [server_remote] の下にある https://cnn.vercel.app/xv-sub をあなたのサブスクリプションリンクに変更してください。

9. 起動について、Quantumult X は url schema / url-schema 起動をサポートしていないため、「その他設定」-「VPN」-「常にオン」を有効にすることを推奨します。残りのスイッチは必要に応じて選択してください。

注1: 本設定ファイルのデフォルトサブスクリプションリンクは公開情報を使用しているため、プライバシー重視のユーザーには長期使用を推奨しません。~~また、本設定は公開された MITM 証明書を使用していますので、自身で生成し置き換えることを推奨します（証明書生成後、エクスポート時にパスワードを入力しなければパスフレーズをスキップ可能です）~~

注2: QX は NaïveProxy (naiveproxy) をサポートしていないため、現状のバージョンではローカルネットワーク内の OpenWRT 上で実行し、ローカルサービス ```socks5=192.168.124.124:1080, tag=LAN``` を通じて接続、ルーター側に起動スクリプト ```naive /[PATH]/config.json``` を追加することを推奨します。

## 分流ルールとリライト

tag 名|タイプ|ショートリンク|説明 - 取り消し線は無効化を示す
-|-|-|-
ads|ルール|https://cnn.vercel.app/xf-ads|広告ブロック
cn|ルール|https://cnn.vercel.app/xf-cn|中国大陸サービス直結
global|ルール|https://cnn.vercel.app/xf-global|国際サービス
hijacking|ルール|https://cnn.vercel.app/xf-hijacking|ハイジャック防止
privacy|ルール|https://cnn.vercel.app/xf-privacy|プライバシー保護
tg|ルール|https://cnn.vercel.app/xf-tg|Telegram
unbreak|ルール|https://cnn.vercel.app/xf-unbreak|ルール修正
-|-|-|-
adlite|リライト|https://cnn.vercel.app/xr-adlite|広告リライト
ads|リライト|https://cnn.vercel.app/xr-ads|広告リライト
adscript|リライト|https://cnn.vercel.app/xr-adscript|スクリプト広告ブロック
apple|リライト|https://cnn.vercel.app/xr-apple|制限されたAppleサービスの解除、天気表示を削除。iOS16対応は Scriptable/IQair/在意空气 ウィジェットで米国基準AQIを表示可能
bing|リライト|https://cnn.vercel.app/xr-bing|Safari と Edge 対応の New Bing
bili|リライト|https://cnn.vercel.app/xr-bili|Bilibili インターフェース最適化
box|リライト|https://cnn.vercel.app/xr-box|BoxJS
-|-|-|手動追加
covidsc|リライト|https://cnn.vercel.app/xr-covidsc|24時間以内の核酸検査報告 四川天府健康通 全機能 - アリペイ+微信 デフォルトオフ
covidsc|リライト|https://cnn.vercel.app/xr-covidhn|24時間以内の核酸検査報告 河南豫康码 デフォルトオフ
emby|リライト|https://cnn.vercel.app/xr-emby|Emby ロック解除、通知なし
fake|リライト|https://cnn.vercel.app/xr-fake|Fake Pro ロック解除、lk を簡略化し Spotify Pro を追加
jsc|リライト|https://cnn.vercel.app/xr-jsc|スクリプトで Cookies 取得
lk|リライト|https://cnn.vercel.app/xr-lk|海外サービス Fake VIP
upgrade|リライト|https://cnn.vercel.app/xr-upgrade|アプリのアップデートチェック遮断
res|リライト|https://cnn.vercel.app/xr-res|中国大陸向けソフト最適化
search|リライト|https://cnn.vercel.app/xr-search|DuckDuckGo 検索エンジンリライト
v|重写|https://cnn.vercel.app/xr-v|動画解析リライト

あなたの状況に応じて上記のルールやリライトを有効にするか調整できます。例：海外ソフトをほとんど使わない場合、```lk 重写 https://cnn.vercel.app/xr-lk 国外服务 Fake VIP``` のように提供されている複数のソフトのVIP/Pro解除はあなたにとって無用です。[一部のリライトは既に無効です]

同様に ```fake https://cnn.vercel.app/xr-fake Fake Pro 解锁``` はこのルールの簡略版です

2024年はiOS APIの変更により、TikTokの新バージョンはシステムの国設定と一つの分流ルールを変更するだけで使用可能です ```host-wildcard, *tiktok*, proxy```

## 小ツール

ツール|効果|リンク/補足
-|-|-
高速検索|Safariのデフォルト検索エンジンをDuckDuckGoに設定|デフォルトはGoogle、接頭2文字で他の検索エンジンを指定可能 Baidu:bd/Magi:mm/Twitter:tt/YouTube:yt/WolframAlpha:wa + スペース + キーワード

fakeリライトを有効にすると、以下のソフトが強化されます: Adguard, Day One, Draft, Documents, Lightroom, PS Express, Memrise, Spotify pro*... *は課金解除やVIP模倣の確証なしを示します

resリライトを有効にすると、以下のソフトが強化されます: ビリビリ動画, 彩雲天気, WeChat, Baidu Netdisk...

## 設定ファイル更新

500.conf

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/q](https://cnn.vercel.app/q)

## 推奨

本設定ファイルは複数のプロジェクトやサービスを参照しています。vercel.jsonでそれらを見つけられます。

元プロジェクトにアクセスしやすくするため、設定ファイル内の参照は `https://github.com/ユーザー/プロジェクト/raw/ブランチ/ディレクトリ/ファイル` の形式を使用しています。

`https://github.com/ユーザー/プロジェクト/` をコピーしてアドレスバーに貼り付け、参照プロジェクトにアクセスしてください。

--

極小テンプレート https://cnn.vercel.app はほとんどの不要設定を削除し、基本的な枠組みのみを保持しています。

ilovexjp、ILoveNucleicAcidTest などに感謝します。

AI、Web3、そしてホワイトペーパーに感謝

エンターテインメントとあなた自身に感謝します


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---