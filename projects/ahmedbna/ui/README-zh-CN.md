
# BNA UI 🚀

![BNA UI Header](https://cdn.jsdelivr.net/gh/ahmedbna/bna-ui-demo/bna-ui-header.png)

**B**uild **N**ative **A**pps - 一个强大的 CLI，用于创建带有漂亮 UI 组件库的 Expo React Native 应用。

## ✨ 特性

- 🎨 **漂亮的 UI 组件** - 预构建的可定制组件，设计现代
- 🌙 **主题支持** - 内置明暗模式，过渡流畅
- 📱 **支持 Expo Router** - 完整的标签页和堆栈导航配置
- 🎯 **TypeScript 优先** - 完整支持 TypeScript，智能提示出色
- 📦 **灵活的包管理器** - 兼容 npm、yarn 或 pnpm
- 🚀 **零配置** - 使用合理默认设置，秒级启动
- 🔧 **高度可定制** - 轻松自定义颜色、间距和组件
- 📲 **跨平台** - 完美兼容 iOS 和 Android
- ⚡ **性能优化** - 轻量且快速的组件
- 🎭 **动画支持** - 使用 React Native Reanimated 实现流畅动画

## 📦 安装

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
## 🎯 使用示例


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
## 🌙 主题配置

BNA UI 配备了灵活的主题系统：


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
## 📱 平台支持

- ✅ **iOS** - 完全支持原生 iOS
- ✅ **Android** - 完全支持原生 Android
- ✅ **Web** - 响应式网页支持
- ✅ **Expo Go** - 使用 Expo Go 进行开发
- ✅ **EAS Build** - 使用 EAS 进行生产构建

## 🛠️ 开发


```bash
# Clone the repository
git clone https://github.com/ahmedbna/bna-ui.git
cd bna-ui

# Install dependencies
npm install

# Build for production
npm run build
```
## 🤝 贡献

我们欢迎贡献！详情请参阅我们的[贡献指南](https://raw.githubusercontent.com/ahmedbna/ui/main/CONTRIBUTING.md)。

1. Fork 仓库  
2. 创建你的功能分支（`git checkout -b feature/amazing-feature`）  
3. 提交你的更改（`git commit -m 'Add some amazing feature'`）  
4. 推送到分支（`git push origin feature/amazing-feature`）  
5. 打开一个拉取请求  

## 📄 许可证

本项目采用 MIT 许可证 - 详情请参阅[LICENSE](LICENSE)文件。

## 🔗 链接

- 📚 **文档**: [https://ui.ahmedbna.com](https://ui.ahmedbna.com)  
- 🐛 **错误报告**: [GitHub Issues](https://github.com/ahmedbna/ui/issues)  
- 💬 **Linkedin**: [@ahmedbna](https://www.linkedin.com/in/ahmedbna/)  
- 𝕏 **X**: [@ahmedbnaa](https://x.com/ahmedbnaa)  

## ⭐ 支持

如果你觉得 BNA UI 有帮助，请考虑在 GitHub 上给它一个星！这对我们帮助很大。

[![GitHub stars](https://img.shields.io/github/stars/ahmedbna/ui?style=social)](https://github.com/ahmedbna/ui)

## 📈 统计

![GitHub package.json version](https://img.shields.io/github/package-json/v/ahmedbna/ui)  
![npm](https://img.shields.io/npm/v/bna-ui)  
![npm](https://img.shields.io/npm/dm/bna-ui)  
![GitHub](https://img.shields.io/github/license/ahmedbna/ui)  

---

由 [Ahmed BNA](https://github.com/ahmedbna) ❤️ 制作



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---