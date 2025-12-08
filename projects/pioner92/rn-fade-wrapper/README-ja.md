# React Native フェードグラデーションラッパー

<p align="center">
  <img src="https://raw.githubusercontent.com/pioner92/rn-fade-wrapper/main/./assets/img.png" width="700" alt="React Native フェードグラデーションラッパーデモ" />
</p>

**`rn-fade-wrapper`** は、任意のコンテンツの端に滑らかでカスタマイズ可能な **フェードグラデーション** を追加するシンプルで高性能な React Native コンポーネントです。スクロール可能なコンテナ、リスト、カルーセル、モーダル、またはオーバーフローするコンテンツを持つビューのユーザー体験を向上させるのに最適です。

<div align="center" style="max-width: 400px; margin: auto;">
  <a href="https://www.npmjs.com/package/rn-fade-wrapper">
    <img src="https://img.shields.io/npm/v/rn-fade-wrapper.svg" alt="npm バージョン" />
  </a>
  <img src="https://img.shields.io/badge/platform-iOS-blue?logo=apple" alt="iOS" />
  <img src="https://img.shields.io/badge/platform-Android-green?logo=android" alt="Android" />
  <img src="https://img.shields.io/badge/types-TypeScript-blue?logo=typescript" alt="TypeScript" />
  <img src="https://img.shields.io/badge/license-MIT-yellow.svg" alt="MIT ライセンス" />
  <a href="https://bundlephobia.com/result?p=rn-fade-wrapper">
    <img src="https://img.shields.io/bundlephobia/minzip/rn-fade-wrapper" alt="バンドルサイズ" />
  </a>
</div>

---

## ✨ 特徴

- ⚡ **iOS** と **Android** のネイティブレンダリング
- 🔁 **垂直** および **水平** グラデーション方向に対応
- 🎨 サイドごとまたは均一に設定可能な **フェードサイズと色を完全カスタマイズ**
- ↕️ 外側ではなくコンテンツ側にフェードするオプションの `inward` モード
- 🧩 シンプルなAPI：直感的なpropsで使えるラッパー
- 💪 低オーバーヘッドで高パフォーマンス — スクロールビューやアニメーションに最適

---

## 📦 インストール

```bash
yarn add rn-fade-wrapper
```

or

```bash
npm install rn-fade-wrapper
```
### Expo

このライブラリは追加の設定なしでExpo（`expo prebuild`使用時）で動作します。

---

## 📱 プラットフォームサポート

| プラットフォーム | 旧アーキテクチャ | Fabric |
|------------------|------------------|--------|
| iOS              | ✅                | ✅      |
| Android          | ✅                | ✅      |

---

## 🚀 クイックスタート


```tsx
import { FadeWrapper } from 'rn-fade-wrapper';

const MyComponent = () => {
  return (
    <FadeWrapper
      color="#ffffff"
      size={24}
      orientation="vertical"
    >
      <ScrollView>
        <Text>Fading edges example</Text>
      </ScrollView>
    </FadeWrapper>
  );
};
```

---

## 🧩 プロップス

| プロップ        | 型                         | デフォルト                 | 説明 |
|--------------|----------------------------|----------------------|-------------|
| `color`      | `string`                   | `"#ffffff"`          | フェード色（任意の有効なカラー文字列が使用可能） |
| `size`       | `number`                   | `20`                 | ポイント単位の均一なフェードサイズ |
| `style`      | `ViewStyle`                | `{ zIndex: 2 }`      | ラッパービューに適用されるカスタムスタイル |
| `inward`     | `boolean`                  | `false`              | グラデーションを外側ではなく内側（中央方向）にフェードさせる |
| `sizes`      | `{ top?: number, right?: number, bottom?: number, left?: number }` | `undefined` | 各辺ごとのフェードサイズ（`size`と`orientation`を上書き） |
| `orientation`| `'horizontal' \| 'vertical'` | `'vertical'`       | 方向のプリセット：`size`を上下または左右に適用 |
| `children`   | `React.ReactNode`          | —                    | ラップされたコンテンツ |

> **注意:** `sizes` は `size` と `orientation` より優先されます。

---

## 🎛 例

### 🎯 カスタムサイド + 内側フェード：
```tsx
<FadeWrapper
  color="black"
  inward
  sizes={{ top: 20, bottom: 30 }}
>
  <FlatList ... />
</FadeWrapper>
```

### 📜 横スクロールフェード：
```tsx
<FadeWrapper
  color="rgba(0,0,0,0.5)"
  size={16}
  orientation="horizontal"
>
  <ScrollView horizontal>
    {/* content */}
  </ScrollView>
</FadeWrapper>
```

---

## 🛠 裏側の仕組み

- **iOS:** ネイティブの `UIView` 内で `CAGradientLayer` を使用
- **Android:** カスタム `ViewGroup` 上に Canvas を使って `LinearGradient` を描画
- プラットフォーム固有のロジックでレイアウト処理と再レンダリングを実施し、一貫性を保つ

---

## 💡 UXのヒント

`rn-fade-wrapper` を使って、コンテンツのオーバーフローをさりげなく示しましょう — 特にカルーセルやスクロールビュー、横スライダーで効果的です。グラデーションは、さらにスクロールできることをユーザーに示し、エンゲージメントを向上させます。

---

## 📘 ライセンス

MIT — 無料で使用、改善、貢献が可能です 🎉



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---