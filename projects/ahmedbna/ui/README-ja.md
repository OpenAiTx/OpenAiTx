<translate-content># BNA UI 🚀

![BNA UI ヘッダー](https://cdn.jsdelivr.net/gh/ahmedbna/bna-ui-demo/bna-ui-header.png)

**B**uild **N**ative **A**pps - 美しいUIコンポーネントライブラリを備えたExpo React Nativeアプリケーション作成のための強力なCLI。

## ✨ 特徴

- 🎨 **美しいUIコンポーネント** - 事前構築されたカスタマイズ可能なモダンデザインのコンポーネント
- 🌙 **テーマサポート** - シームレスな切り替えが可能なライト／ダークモード内蔵
- 📱 **Expo Router対応** - タブとスタックナビゲーションを備えた完全なナビゲーション設定
- 🎯 **TypeScript優先** - 優れたIntelliSenseを備えたフルTypeScriptサポート
- 📦 **柔軟なパッケージマネージャー** - npm、yarn、pnpmに対応
- 🚀 **ゼロ設定** - 適切なデフォルトで秒単位で開始可能
- 🔧 **高いカスタマイズ性** - 色、間隔、コンポーネントを簡単にカスタマイズ
- 📲 **クロスプラットフォーム** - iOSとAndroidでの完璧な互換性
- ⚡ **パフォーマンス最適化** - 軽量で高速なコンポーネント
- 🎭 **アニメーション対応** - React Native Reanimatedによるスムーズなアニメーション

## 📦 インストール

```bash
# The fastest way to set up BNA UI in your Expo project:
npx bna-ui init

# Navigate to your Expo project
cd bna-app

# Start adding components
npx bna-ui add button
npx bna-ui add card
npx bna-ui add input
```
## 🎯 使用例


```tsx
import React from 'react';
import { Button } from '@/components/ui/button';
import { Card } from '@/components/ui/card';
import { Input } from '@/components/ui/input';
import { View } from '@/components/ui/view';

export default function HomeScreen() {
  return (
    <View style={{ flex: 1, padding: 20 }}>
      <Card>
        <Input placeholder='Enter your email' keyboardType='email-address' />
        <Button
          variant='success'
          onPress={() => console.log('Button pressed!')}
        >
          Get Started
        </Button>
      </Card>
    </View>
  );
}
```
## 🌙 テーマ設定

BNA UI は柔軟なテーマ設定システムを備えています：


```tsx
// theme/colors.ts
export const lightTheme = {
  colors: {
    background: '#FFFFFF',
    foreground: '#000000',
    card: '#F2F2F7',
    cardForeground: '#000000',
    popover: '#F2F2F7',
    popoverForeground: '#000000',
    primary: '#18181b',
    primaryForeground: '#FFFFFF',
    secondary: '#F2F2F7',
    secondaryForeground: '#18181b',
    muted: '#78788033',
    mutedForeground: '#71717a',
    // ... more colors
  },
};

export const darkTheme = {
  colors: {
    background: '#000000',
    foreground: '#FFFFFF',
    card: '#1C1C1E',
    cardForeground: '#FFFFFF',
    popover: '#18181b',
    popoverForeground: '#FFFFFF',
    primary: '#e4e4e7',
    primaryForeground: '#18181b',
    secondary: '#1C1C1E',
    secondaryForeground: '#FFFFFF',
    muted: '#78788033',
    mutedForeground: '#a1a1aa',
    // ... more colors
  },
};
```
## 📱 プラットフォームサポート

- ✅ **iOS** - 完全なネイティブiOSサポート
- ✅ **Android** - 完全なネイティブAndroidサポート
- ✅ **Web** - レスポンシブウェブサポート
- ✅ **Expo Go** - Expo Goでの開発
- ✅ **EAS Build** - EASによる本番ビルド

## 🛠️ 開発


```bash
# Clone the repository
git clone https://github.com/ahmedbna/bna-ui.git
cd bna-ui

# Install dependencies
npm install

# Build for production
npm run build
```
## 🤝 貢献について

貢献を歓迎します！詳細は当社の[貢献ガイド](https://raw.githubusercontent.com/ahmedbna/ui/main/CONTRIBUTING.md)をご覧ください。

1. リポジトリをフォークする
2. フィーチャーブランチを作成する（`git checkout -b feature/amazing-feature`）
3. 変更をコミットする（`git commit -m 'Add some amazing feature'`）
4. ブランチにプッシュする（`git push origin feature/amazing-feature`）
5. プルリクエストを作成する

## 📄 ライセンス

このプロジェクトはMITライセンスのもとで提供されています。詳細は[LICENSE](LICENSE)ファイルをご覧ください。

## 🔗 リンク

- 📚 **ドキュメント**: [https://ui.ahmedbna.com](https://ui.ahmedbna.com)
- 🐛 **バグ報告**: [GitHub Issues](https://github.com/ahmedbna/ui/issues)
- 💬 **Linkedin**: [@ahmedbna](https://www.linkedin.com/in/ahmedbna/)
- 𝕏 **X**: [@ahmedbnaa](https://x.com/ahmedbnaa)

## ⭐ サポート

BNA UIが役に立ったら、ぜひGitHubでスターをお願いします！とても励みになります。

[![GitHub stars](https://img.shields.io/github/stars/ahmedbna/ui?style=social)](https://github.com/ahmedbna/ui)

## 📈 統計

![GitHub package.json version](https://img.shields.io/github/package-json/v/ahmedbna/ui)
![npm](https://img.shields.io/npm/v/bna-ui)
![npm](https://img.shields.io/npm/dm/bna-ui)
![GitHub](https://img.shields.io/github/license/ahmedbna/ui)

---

❤️ を込めて [Ahmed BNA](https://github.com/ahmedbna) によって作成されました



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---