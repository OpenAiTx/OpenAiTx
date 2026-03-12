# jordansingerbutton

SwiftUI向けの美しいインタラクティブなカウンターコンポーネントで、ガラスモーフィックな矢印ボタンと滑らかなアニメーションを特徴としています。

## 📱 デモ



## 🌿 ブランチ

### `main` - 完全なアプリ
カウンター機能を備えたjordansingerbuttonアプリの完全版。

### `tutorial` - 矢印ボタンコンポーネント
美しい矢印ボタンコンポーネントに特化したシンプルでスタンドアロンのバージョン。学習や共有に最適です！

**チュートリアルバージョンを見るには：**
```bash
git checkout tutorial
```

## 🚀 クイックスタート

### Arrow Button コンポーネントの使用方法

`ArrowButton` は再利用可能な SwiftUI コンポーネントで、美しいグラスモルフィックボタンを作成します：
- 多層ストロークのメタリックスチール外観
- ぼかし反射効果
- 滑らかなアニメーション
- カスタマイズ可能な回転

```swift
import SwiftUI

ArrowButton(rotation: .degrees(0))  // Pointing down
ArrowButton(rotation: .degrees(180)) // Pointing up
ArrowButton(rotation: .degrees(90))  // Pointing left
ArrowButton(rotation: .degrees(270)) // Pointing right
```

### フルアプリの使用法

完全なアプリには、「今日」、「明日」、「昨日」のラベル付きの日付ナビゲーションとスムーズな日付遷移が含まれています。

## 📁 プロジェクト構成

```
jordansingerbutton/
├── CounterView.swift          # Counter with arrow buttons (includes ArrowButton)
├── JordanSingerButtonApp.swift  # App entry point
└── Assets.xcassets/            # Arrow image asset
```

## 🎨 特徴

- **グラスモーフィックデザイン**：美しいメタリックスチールの外観
- **スムーズなアニメーション**：スプリングベースのインタラクションアニメーション
- **アクセシビリティ**：完全なVoiceOver対応
- **カスタマイズ可能**：色、サイズ、回転の簡単な変更

## 📝 ライセンス

プロジェクトでの使用および改変は無料です！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---