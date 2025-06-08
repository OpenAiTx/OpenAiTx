# Node HL7 Client

> HL7サーバーとのシームレスな通信を可能にする、純粋なTypeScript製のNode.js用HL7クライアント。

`node-hl7-client`は、HL7ブローカー／サーバーとの高性能な通信のために構築された、軽量で依存関係のないライブラリです。適切にフォーマットされたHL7メッセージの送信、レスポンスの処理、単一およびバッチ化されたHL7メッセージ形式（MSH、BHS、FHS）の両方に対応しています。

## ✨ 特徴

* ⚡ **外部依存ゼロ** – 余計な負荷なく超高速パフォーマンス。
* 🔁 **自動再接続 & リトライ** – 接続中断時も自動で対応。
* 🧠 **TypeScript + 型定義** – モダンな開発環境向けに完全型付け。
* 🤝 **コンパニオンパッケージ利用可** – [node-hl7-server](https://www.npmjs.com/package/node-hl7-server)と組み合わせて完全なHL7ソリューションを構築可能。
* 💻 **クロスプラットフォーム対応** – Windows、macOS、Linuxで動作。
* 🧭 **標準準拠** – 型付きビルダーにより、MSH、BHS、FHSセグメントがHL7.org仕様に準拠。

## 📦 インストール

```bash
npm install node-hl7-client
```

## 📚 含まれるもの

* **HL7クライアント** – リモートHL7サーバーへの接続、メッセージ送信、レスポンス処理。
* **HL7パーサー** – 生のHL7メッセージ文字列をアクセス可能なセグメントにパース。
* **HL7ビルダー** – 有効なHL7メッセージ、バッチ、または完全なHL7バッチファイルの構築。

## 🧾 目次

1. [キーワード定義](#keyword-definitions)
2. [ドキュメント](#documentation)
3. [謝辞](#acknowledgements)
4. [ライセンス](#license)

## キーワード定義

このNPMパッケージは、患者ケアや診断に影響を及ぼす可能性のある医療アプリケーションをサポートするために設計されています。本ドキュメントおよび関連パッケージ[node-hl7-server](https://www.npmjs.com/package/node-hl7-server)では、明確さと相互運用性のため、以下の標準化された定義を使用しています。

**「MUST」**、**「MUST NOT」**、**「REQUIRED」**、**「SHALL」**、**「SHALL NOT」**、**「SHOULD」**、**「SHOULD NOT」**、**「RECOMMENDED」**、**「MAY」**、**「OPTIONAL」**などのキーワードは、ドキュメント全体で一貫して使用されます。これらの用語は、大文字でなくても同じ意味を持ちます。

* **MUST** – この単語、または**「REQUIRED」**や**「SHALL」**は、仕様上の絶対的な要件を示します。
* **MUST NOT** – この語句、または**「SHALL NOT」**は、仕様上の絶対的な禁止事項を示します。
* **SHOULD** – この単語、または**「RECOMMENDED」**は、特定の状況で無視する正当な理由があるかもしれませんが、完全な影響を理解し、慎重に検討した上で行うべきであることを意味します。
* **SHOULD NOT** – この語句、または**「NOT RECOMMENDED」**は、特定の状況でその動作が受け入れられたり有用であったりする正当な理由があるかもしれません。影響を理解し、慎重に検討したうえで実装してください。
* **MAY** – この単語、または**「OPTIONAL」**は、その項目が本当にオプションであることを意味します。特定のオプションを含まない実装でも、それを含む実装と相互運用できなければなりません（機能が制限される場合はあります）。同様に、オプションを含む実装も、含まない実装と相互運用できなければなりません（もちろんオプションで提供される特定の機能を除きます）。

## 📖 ドキュメント

APIリファレンス、使用例、詳細な設定方法についてはプロジェクトサイトをご覧ください:
🔗 [https://bugs5382.github.io/node-hl7-client/](https://bugs5382.github.io/node-hl7-client/)

## 🙏 謝辞

* [`node-rabbitmq-client`](https://github.com/cody-greene/node-rabbitmq-client) – 接続ロジックのインスピレーション。
* [`artifacthealth/hl7parser`](https://github.com/artifacthealth/hl7parser) – パーサーとビルダーの設計参考。
* 妻と娘 – その愛と忍耐、そしてインスピレーションに感謝します。

## 📄 ライセンス

MIT © [LICENSE](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---