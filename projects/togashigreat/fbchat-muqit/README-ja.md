<div align="center">

# fbchat-muqit Facebook & Messenger API

![PyPI - Python Version](https://img.shields.io/pypi/pyversions/fbchat-muqit)
![PyPI - Version](https://img.shields.io/pypi/v/fbchat-muqit)
[![License: GPLv3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)

**fbchat-muqit** は、FacebookおよびMessengerと連携するために設計された非公式の非同期Facebook Messenger APIです。非公式のAPIであるため、Facebookによってアカウントが停止された場合の責任は負いかねます。ダミーのFacebookアカウントを使用することを推奨します。詳細は[ドキュメント](http://fbchat-muqit.rtfd.io/)をご覧ください。

</div>

> [!Note]
> バージョン`1.1.31`から`1.2.0`にアップデートされ、`1.2.0`はライブラリが完全に書き直されたリライト版であり、大幅な変更が加えられています。APIは完全にドキュメント化され、使用例も更新されました。

> [!WARNING]
> `エンドツーエンド`暗号化のため、他のユーザーへのメッセージ送信はサポートされなくなりました。グループチャット、ルームチャット、およびページへのメッセージ送信は可能です。[詳細はこちら](https://about.fb.com/news/2024/03/end-to-end-encryption-on-messenger-explained/)
> また、そのユーザーアカウントが長期間非アクティブである場合は、`エンドツーエンド`暗号化が適用されないため、メッセージを送信できる可能性があります。ただし、そのアカウントが再開されると暗号化が適用されます。

## 🛠️ インストール

pipを使ってfbchat-muqitをインストールできます:

```bash
pip install fbchat-muqit

```
最新の開発版について：


```bash
pip install git+https://github.com/togashigreat/fbchat-muqit.git

```
## 📙 ドキュメンテーション

APIはドキュメント化されています。[ドキュメントを読む](http://fbchat-muqit.rtfd.io/)。
古いバージョン[1.1.31](https://fbchat-muqit.readthedocs.io/en/v1.1.31/)のドキュメントも利用可能です。

## 🔧 前提条件

- Python 3.9以上
- Facebookアカウント（使われていない古いアカウントの使用を推奨）
- Facebookアカウントのクッキー🍪

## 📖 使用例

FacebookにログインするにはFacebookアカウントのクッキーが必要です。メールとパスワードによるログインはサポートされていません。

Facebookアカウントのクッキーを取得するには、まずFacebookアカウントにログインし、ブラウザに[C3C Chrome拡張機能](https://github.com/c3cbot/c3c-ufc-utility)を追加してください。ブラウザのタブでFacebookアカウントを開き、この拡張機能を使ってアカウントのクッキーを取得します。クッキーをコピーしてjsonファイルに保存します。これらのクッキーを使ってFacebookサーバーとやり取りします。このアカウントを`Client`アカウントと呼びます。

基本的な使い方の例です。


```python
from fbchat_muqit import Client, Message, EventType

client = Client(cookies_file_path="cookies.json")

@client.event
async def on_message(message: Message):
    # To avoid spam check if sender_id is client's id or not
    if message.sender_id != client.uid:
        # echo the message
        await client.send_message(message.text, message.thread_id)

client.run()

```
コードをファイル `test.py` に保存し、コードを実行します。


```bash
python3 test.py
```

もし正常にログインできたら、別のFacebookアカウントを使ってメッセンジャーグループを作成し、両方のアカウントをグループに追加します。次に、グループにメッセージを送信すると、fbchat_muqit クライアントアカウントがすべての受信メッセージとイベントを監視します。すべてが正常に動作していれば、もう一方のアカウントから送信されたメッセージに対して絵文字で返信およびリアクションを行うはずです。

### 📄 ライセンス

本プロジェクトはデュアルライセンスモデルで配布されています：

- **BSD-3-Clause ライセンス**：コードの一部は元の [fbchat](https://github.com/fbchat-dev/fbchat) ライブラリから再利用および適応されており、BSD-3-Clause ライセンスの下で提供されています。
  詳細は [LICENSE-BSD](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE-BSD.md) をご覧ください。

- **GPL v3 ライセンス**：Muhammad MuQiT/togashigreat による新規の貢献および修正は GPL v3.0 ライセンスの下で提供されています。
  詳細は [LICENSE](https://raw.githubusercontent.com/togashigreat/fbchat-muqit/main/./LICENSE.md) をご覧ください。

### ✉️お問い合わせ

- [Facebook](https://facebook.com/muqit.dev)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---