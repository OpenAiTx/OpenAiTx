
# Public Free Suffix：誰でも使える無料ドメイン名

**Public Free Suffix** は、様々なコミュニティを支援するために設計された非営利の無料サブドメインサービスです。私たちは以下の利用者にアクセス可能なリソースを提供することを信じています：

* **開発者向け：** プロジェクトのテスト、ステージング環境、個人開発用のサンドボックスに最適です。
* **学生向け：** 学術研究、授業プロジェクト、新技術の学習に費用の壁なく利用可能です。
* **技術者向け：** コンピュータやネットワーク技術の研究、ラボ構築、新しい設定の実験に最適なリソースです。
* **個人利用者向け：** 個人ブログ、ポートフォリオ、小規模な情熱プロジェクトを当社の準拠フレームワーク内でホストできます。

誰でも登録してここから無料ドメインを取得でき、年次更新の必要はありません。現在サービスを提供しているサフィックスは以下の通りです（sld）：

```text
pfsdns.org
nastu.net
tun.re
6ti.net
no.kg
htu.edu.kg
```
## サポートされているサードパーティDNSホスティングプラットフォーム
ユーザーによってテストおよびサポートされているサードパーティDNSサービスホスティングプラットフォーム（有料/無料）。これらのプラットフォームにまず希望するドメイン名を追加し、NSレコードを取得してからPR登録プロセスを開始する必要があります。

[<img alt="dns.he.net" title="dns.he.net" height="40px" style="margin-right:10px" src="https://dns.he.net/include/images/helogo.gif" />](https://dns.he.net/?src=PublicFreeSuffix)
[<img alt="desec.io" title="desec.io" height="40px" style="margin-right:10px" src="https://desec.io/assets/logo-CP29ePBl.svg" />](https://desec.io/?src=PublicFreeSuffix)
[<img alt="hostry.com" title="hostry.com" height="40px" src="https://hostry.com/img/logo.svg?v=1.00r3266" />](https://hostry.com/?src=PublicFreeSuffix)

## ドメイン名はどのように登録しますか？

[利用許諾ポリシー](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/acceptable-use-policy.md) | 
[プライバシーポリシー](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/privacy-policy.md) | 
[登録および利用契約](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/agreements/registration-and-use-agreement-sokg.md) | 
[予約語リスト](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/reserved_words.txt)
1. リポジトリをクローンします:

```bash
git clone https://github.com/PublicFreeSuffix/PublicFreeSuffix.git
```
独自ドメイン名用の新しいブランチを作成します:
```bash
git checkout main
git pull origin main
git checkout -b yourdomain.no.kg-request-1
```
PR（プルリクエスト）操作を行う前に—登録、更新、またはドメインのWhoisファイルの削除であっても—必ずメインブランチに戻り、最新の変更をローカル環境に同期してください。  
その後、指定されたブランチ命名規則に従って新しいブランチを作成します。変更を保存し、この新しいブランチから新しいPRを作成してください。  
ブランチ命名規則は常に特定の操作数に適応し、形式は次のようにしてください：`yourdomain.no.kg-request-{a_number_here}`。  

2. 使用可能なドメイン名を選択し、`./whois/{your-new-domain-name}.json` フォルダに新しいwhoisファイルを作成してください：
```json
{
  "registrant": "your-own-example@gmail.com",
  "domain": "mynewdomain",
  "sld": "no.kg",
  "nameservers": [
    "nameserver1.example.com",
    "nameserver2.example.com",
    "nameserver3.example.com",
    "nameserver4.example.com"
  ],
  "agree_to_agreements": {
    "registration_and_use_agreement": true,
    "acceptable_use_policy": true,
    "privacy_policy": true
  }
}
```

- `registrant`: ドメイン所有者のメールアドレス。
- `domain`: トップレベルドメインを除いたドメイン名（例："mynewdomain"）、ドメインの長さは3文字以上である必要があります。
- `sld`: 登録したいサフィックス（例："no.kg" または前述のリスト内のSLDのいずれか）。
- `nameservers`: ドメイン解決を担当するDNSサーバーのリスト、2～4台のサーバーが許可されています。
- `agree_to_agreements`: 登録および利用規約、許容使用ポリシー、プライバシーポリシーにユーザーが同意したかを示すブール値。
- このファイルの名前は必ず `{your-new-domain-name}.json` とし、ここでは `mynewdomain.no.kg.json` のようにします。

> **通知** 利用の向上と登録の独占および資源の無駄遣いを防ぐため、30日連続でウェブサイトのコンテンツが展開されていないと検出された場合、登録されたドメイン名は取り消されます。

3. 新しいドメイン名とwhoisファイルでプルリクエストを作成してください。PRの説明は[PR Description Template](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/.github/pull_request_template.md)の形式にし、タイトルは以下の形式にしてください：

```text
Registration/Update/Remove: {your-new-domain-name}.{sld}
```
1つのプルリクエストで送信できるドメイン名登録リクエストは1件のみです。

4. [メールによる自動登録者認証(ARAE)](https://raw.githubusercontent.com/PublicFreeSuffix/PublicFreeSuffix/main/AUTHORIZATION.md) の説明に従い、登録者メールの認証を完了してください。

5. ドメインの設定が完了したら、ウェブサイトやその他の用途に使用できます。

## ドメインのNS／登録者メールを更新するには？
簡単です。whoisファイルを修正し、新しいプルリクエストを作成して、再度登録者メールの認証を完了してください。

[<img title="ドメイン不正使用の報告" src="https://i.postimg.cc/Xq7VHpLs/rebuse-log.png" height="35px" />](https://forms.gle/cXkxrKbdoeBsKBQdA)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---