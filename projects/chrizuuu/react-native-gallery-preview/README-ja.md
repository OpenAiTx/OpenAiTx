  
 # react-native-gallery-preview
  
  <div>
    <img align="right" height="720" src="https://raw.githubusercontent.com/chrizuuu/react-native-gallery-preview/main/example.gif">
  </div>

  **GalleryPreview** は、フルジェスチャー対応の簡単なギャラリープレビュー用の柔軟なモーダルコンポーネントです。`Reanimated` と `React Native Gesture Handler` を使用し、iOS と Android 両方でスムーズでシンプルなユーザー体験を提供します。
  
  ### 特徴
  
  * ⚡  **スムーズなジェスチャー操作とアニメーション:** 流れるようで応答性の高いアニメーションとジェスチャーによる快適なユーザーインターフェースを実現。
  * 🔍 **ダブルタップとピンチでズーム:** ユーザーは簡単なダブルタップとピンチジェスチャーで画像を自由にズームイン・アウト可能。
  * 👆 **下に引っ張って閉じる:** 直感的な下に引っ張るジェスチャーでギャラリープレビューを閉じ、ナビゲーションをスムーズに。
  *  ↔️ **RTL対応**
  * 📱 **`iOS` と `Android` 両対応:** iOS と Android デバイスの両方に完全対応し、プラットフォーム間で一貫した体験を提供。
  * 📱 **`Expo` 互換**
  ### はじめに
  GalleryPreview を使用する前に、react-native-reanimated と react-native-gesture-handler のセットアップが必要です。詳細なインストールガイドは以下のリンクを参照してください：
  
  * [Reanimated のセットアップ](https://docs.swmansion.com/react-native-reanimated/docs/fundamentals/getting-started/#installation)
  * [React Native Gesture Handler のセットアップ](ht↔️tps://docs.swmansion.com/react-native-gesture-handler/docs/fundamentals/installation)

  依存関係をインストールしたら、react-native-gallery-preview をプロジェクトに追加できます：
  



  ```sh
  npm install react-native-gallery-preview
  # or
  yarn add react-native-gallery-preview
  
  ```
### 例


```tsx
import React, { useState } from 'react';
import { Button, View } from 'react-native';
import GalleryPreview from 'react-native-gallery-preview';

export const App = () => {
  const [isVisible, setIsVisible] = useState(false);

  const images = [
    { uri: 'https://example.com/image1.jpg' },
    { uri: 'https://example.com/image2.jpg' },
    // Add more images here
  ];

  return (
    <View>
      <Button title="Open Gallery Preview" onPress={() => setIsVisible(true)} />
      <GalleryPreview
        isVisible={isVisible}
        onRequestClose={() => setIsVisible(false)}
        images={images}
      />
    </View>
  );
};
```
### Props

| Prop Name                  | Type                                      | Description                                                                                                                      | Default                                                                                                            |
|----------------------------|-------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|
| `isVisible`                | `boolean`                                 | 画像ビューアモーダルの表示・非表示を制御します。                                                                                      | -                                                                                                                  |
| `onRequestClose`           | `() => void`                              | 画像ビューアモーダルを閉じるための関数。                                                                                             | -                                                                                                                  |
| `images`                   | `ImageItemURI[]`                          | 表示する画像URIの配列。                                                                                                             | -                                                                                                                  |
| `initialIndex?`             | `number`                                  | ビューアが開かれた時に表示する画像の初期インデックス。                                                                             | `0`                                                                                                                |
| `gap?`                      | `number`                                  | ビューア内の画像間の間隔。                                                                                                         | `24`                                                                                                               |
| `simultaneousRenderedImages?` | `number`                                  | 最適化のために同時にレンダリングされる画像の数。                                                                                   | `6`                                                                                                                |                                                                                                           |
| `OverlayComponent?`          | `(props: GalleryOverlayProps) => React.ReactNode` | 画像ビューアの上にレンダリングされるオプションのコンポーネント。                                                          | -                                                                                                                  |
| `ImageComponent?`           | `(props: GalleryImageComponentProps) => React.JSX.Element` | 各画像をレンダリングするためのオプションのカスタムコンポーネント。                                                                  | -                                                                                                                  |
| `springConfig?`             | `SpringConfig`                            | アニメーションのスプリング設定。                                                                                                   | `{ damping: 1000, mass: 1, stiffness: 250, restDisplacementThreshold: 0.02, restSpeedThreshold: 4 }`                |
| `doubleTabEnabled?`           | `boolean`                                        | ダブルタップでズームする機能の有効・無効を切り替えます。                                                                            | `true`                                                                                                             |
| `pinchEnabled?`               | `boolean`                                        | ピンチ操作でズームする機能の有効・無効を切り替えます。                                                                              | `true`                                                                                                             |
| `swipeToCloseEnabled?`        | `boolean`                                        | スワイプで閉じる機能の有効・無効を切り替えます。                                                                                   | `true`                                                                                                             |
| `backgroundColor?`        | `string`                                        | モーダル、DefaultHeader、StatusBarの背景色。                                                                                         | `#000`                                                                                                             |
| `headerTextColor?`        | `string`                                        | ヘッダー内のテキストの色。                                                                                                         | `#fff`                                                                                                             |




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---