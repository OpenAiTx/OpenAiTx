[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxtは、直感的かつ拡張性の高い方法で、型安全で高性能かつ本番グレードのフルスタックWebアプリケーションおよびウェブサイトをVue.jsで構築できる、無料でオープンソースのフレームワークです。

高速でSEOフレンドリー、かつスケーラブルなWebアプリケーションの構築を容易にする、さまざまな機能を提供しています。主な機能は以下の通りです：
- サーバーサイドレンダリング、静的サイト生成、ハイブリッドレンダリング、エッジサイドレンダリング
- コード分割とプリフェッチによる自動ルーティング
- データフェッチングと状態管理
- SEO最適化およびメタタグの定義
- コンポーネント、コンポーザブル、ユーティリティの自動インポート
- ゼロコンフィグでのTypeScript対応
- server/ ディレクトリでフルスタック開発
- [200以上のモジュール](https://nuxt.com/modules)で拡張可能
- 多様な[ホスティングプラットフォーム](https://nuxt.com/deploy)へのデプロイ
- ...[さらに多くの機能](https://nuxt.com) 🚀

### 目次

- 🚀 [はじめに](#getting-started)
- 💻 [Vue開発](#vue-development)
- 📖 [ドキュメント](#documentation)
- 🧩 [モジュール](#modules)
- ❤️  [貢献](#contribute)
- 🏠 [ローカル開発](#local-development)
- 🛟 [プロフェッショナルサポート](#professional-support)
- 🔗 [フォローする](#follow-us)
- ⚖️ [ライセンス](#license)

---

## <a name="getting-started">🚀 はじめに</a>

以下のコマンドで新しいスタータープロジェクトを作成できます。必要なファイルと依存関係が揃ったスタータープロジェクトが作成されます：

```bash
npm create nuxt <my-project>
```

> [!TIP]
> [nuxt.new](https://nuxt.new)もぜひご利用ください。CodeSandbox、StackBlitz、またはローカルでNuxtのスターターを数秒で立ち上げることができます。

## <a name="vue-development">💻 Vue開発</a>

シンプルで直感的、かつ強力なNuxtを使えば、理にかなった方法でVueコンポーネントを記述できます。面倒な作業はすべて自動化されているので、自信を持ってフルスタックVueアプリケーションの開発に集中できます。

`app.vue` の例：

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 ドキュメント</a>

[Nuxtドキュメント](https://nuxt.com/docs)をぜひご覧ください。フレームワークについてより深く学べる素晴らしいリソースです。導入から高度なトピックまで幅広くカバーしています。

## <a name="modules">🧩 モジュール</a>

Nuxtチームとコミュニティが作成した[モジュール一覧](https://nuxt.com/modules)を活用して、Nuxtプロジェクトをさらに強化しましょう。

## <a name="contribute">❤️ 貢献</a>

Nuxtの改善にご協力いただける方を歓迎します 💚

貢献方法の例：
- **バグ報告：** バグや問題を見つけた場合は、[バグ報告ガイド](https://nuxt.com/docs/community/reporting-bugs)を参照して、バグレポートの提出方法をご確認ください。
- **提案：** Nuxtをさらに良くするアイデアがあれば、ぜひお聞かせください！[貢献ガイド](https://nuxt.com/docs/community/contribution)で提案方法をご確認いただけます。
- **質問：** 質問やサポートが必要な場合は、[ヘルプガイド](https://nuxt.com/docs/community/getting-help)に役立つリソースが掲載されています。

## <a name="local-development">🏠 ローカル開発</a>

[ローカル開発環境のセットアップ](https://nuxt.com/docs/community/framework-contribution#setup)のドキュメントに従って、フレームワークやドキュメントへの貢献を始めましょう。

## <a name="professional-support">🛟 プロフェッショナルサポート</a>

- 技術監査・コンサルティング：[Nuxt Experts](https://nuxt.com/enterprise/support)
- カスタム開発・その他：[Nuxt Agencies Partners](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 フォローする</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ ライセンス</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---