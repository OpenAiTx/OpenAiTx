<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  iOSとAndroidの両方で、よりリッチで高性能なTextコンポーネント。
</p>


<div align="center">
  
https://github.com/user-attachments/assets/57f56b3f-3988-4235-af83-a5f2cfd82121

</div>

<div align="center">

[![npm version](https://img.shields.io/npm/v/react-native-nitro-text?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![Discord](https://img.shields.io/badge/Discord-Join%20Server-5865F2?style=for-the-badge&logo=discord&logoColor=white)](https://discord.gg/7KXUyHjz)
[![npm downloads](https://img.shields.io/npm/dt/react-native-nitro-text.svg?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![npm downloads](https://img.shields.io/npm/dm/react-native-nitro-text.svg?style=for-the-badge)](https://www.npmjs.org/package/react-native-nitro-text)
[![mit licence](https://img.shields.io/dub/l/vibe-d.svg?style=for-the-badge)](https://github.com/patrickkabwe/react-native-nitro-text/blob/main/LICENSE)

</div>

---

## 特徴

- iOSとAndroidの両方で動作（現在はAndroidでRNの`Text`にフォールバック）
- ネイティブiOSレンダリングで滑らかな選択。
- ネストされたフラグメントは単一のネイティブテキストビューに統合
- MarkdownおよびHTMLのレンダリング（近日対応予定）。
- 新しいアーキテクチャのみサポート

## 動作環境

- React Native v0.78.0以上（Fabric/Nitro Views）
- Node 18以上（Node 20以上推奨）

## インストール

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```
それで終わりです。これでアプリ内で `NitroText` コンポーネントを使用できます。

## 使用法


```tsx
import { NitroText as Text } from 'react-native-nitro-text'

export function Title() {
  return (
    <Text style={{ fontSize: 24, fontWeight: 'bold' }}>
      🚀 NitroText Showcase
    </Text>
  )
}
```

## 選択

iOSはネイティブの選択機能を使用します。Androidでは、NitroTextは現在React Nativeの`Text`にフォールバックしています。

```tsx
import { NitroText as Text } from 'react-native-nitro-text'

export function SelectionExample() {
  return (
    <Text selectable style={{ fontSize: 16, lineHeight: 22 }}>
      Long-press to select this text. NitroText supports smooth selection,
      even with <Text style={{ fontWeight: '600' }}>inline styles</Text> and
      longer paragraphs.
    </Text>
  )
}
```

## HTMLレンダリング

NitroTextは、`renderer="html"`を指定すると、HTML文字列の子要素やインラインCSSを解析できます。

```tsx
import { NitroText } from 'react-native-nitro-text'

export function HtmlExample() {
  const html = `
    <div>
      <h2>Renderer demo</h2>
      <p>This text comes from <strong>HTML</strong> with <em>semantic</em> tags.</p>
      <p><span style="color: #ff6347; font-weight: bold;">Inline CSS works too.</span></p>
    </div>
  `

  return <NitroText renderer="html">{html}</NitroText>
}
```

## カスタム選択メニュー

NitroTextは、テキストが選択されたときに表示されるカスタムメニュー項目をサポートしています。`menus`プロパティに、`title`と`action`コールバックを含むメニュー項目の配列を渡します。

```tsx
import { NitroText } from 'react-native-nitro-text'
import { useMemo } from 'react'

export function MenuExample() {
  const menus = useMemo(
    () => [
      { 
        title: 'Copy', 
        action: () => console.log('Copy action') 
      },
      { 
        title: 'Share', 
        action: () => console.log('Share action') 
      },
      { 
        title: 'Translate', 
        action: () => console.log('Translate action') 
      },
    ],
    []
  )

  return (
    <NitroText selectable menus={menus} style={{ fontSize: 16 }}>
      Select this text to see custom menu options appear in the selection menu.
    </NitroText>
  )
}
```

## プラットフォームサポート

- iOS
- Android - 現時点では `NitroText` は RN の `Text` にフォールバックします。

## なぜ NitroText か？

最小限のJSオーバーヘッドとネイティブiOS選択機能を備えたカスタムネイティブテキストビュー。重い/入れ子状のスタイルテキストや大規模リストに最適です。RNの `Text` コンポーネントのドロップイン置換です。

## 開発

- `bun run build` — 型チェックとパッケージのビルド
- `bun run codegen` — コード生成出力の再生成
- `example/` にサンプルアプリがあります

## クレジット

[create-nitro-module](https://github.com/patrickkabwe/create-nitro-module) でブートストラップされました。

## コントリビューション

PRは歓迎します！大きな変更はまずIssueを開いてください。

> 💬 迅速なサポートは、[Discordチャンネル](https://discord.gg/7KXUyHjz)にご参加ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---