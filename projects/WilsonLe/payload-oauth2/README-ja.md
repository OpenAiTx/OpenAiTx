# Payload OAuth2 プラグイン

<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-brightgreen.svg" alt="ソフトウェアライセンス" />
</a>
<a href="https://github.com/wilsonle/payload-oauth2/issues">
  <img src="https://img.shields.io/github/issues/wilsonle/payload-oauth2.svg" alt="課題" />
</a>
<a href="https://npmjs.org/package/payload-oauth2">
  <img src="https://img.shields.io/npm/v/payload-oauth2.svg?style=flat-squar" alt="NPM" />
</a>

# 特徴

- ✅ Payload v3 と互換性あり
- 🔐 任意のプロバイダーでOAuth2を設定可能
- ✨ 依存関係ゼロ
- ⚙ 高度にカスタマイズ可能

# 統合

技術的にはこのプラグインはすべての一般的なOAuth2プロバイダーで動作するはずです。ここではテスト済みのプロバイダーの一覧を示します:

| プロバイダー | ステータス                                                                                                                                                                                             | 例                             |
| -------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------ |
| Google   | [![Test Google OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml)    | [設定](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/google.ts)  |
| Zitadel  | [![Test Zitadel OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml) | [設定](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/zitadel.ts) |
| Apple    | テスト未実装                                                                                                                                                                                           | [設定](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/apple.ts)   |

# インストール

```
npm install payload-oauth2
yarn install payload-oauth2
pnpm install payload-oauth2
```

もし冒険心があり、プラグインを自分で管理したい場合は、`src` ディレクトリをペイロードプロジェクトにコピーしてください。

# 貢献

貢献やフィードバックを歓迎します。

実行するには：

1. プロジェクトをクローンします。
2. `pnpm install`
3. `pnpm dev`

# ライセンス

MITライセンス (MIT)。詳細は[ライセンスファイル](LICENSE)をご覧ください。

# クレジット

このパッケージは [Payload Plugin OAuth](https://github.com/thgh/payload-plugin-oauth) に触発されました。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---