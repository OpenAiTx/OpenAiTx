<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  一个在 iOS 和 Android 上都更加丰富且高性能的文本组件。
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

## 功能

- 支持 iOS 和 Android（当前在 Android 上回退使用 RN 的 `Text`）
- 原生 iOS 渲染，支持流畅的文本选择。
- 嵌套片段合并为单个原生文本视图
- 支持渲染 Markdown 和 HTML（即将推出）。
- 仅支持新架构

## 需求

- React Native v0.78.0 或更高版本（Fabric/Nitro 视图）
- Node 18+（推荐 Node 20+）

## 安装

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```
就是这样。你现在可以在你的应用中使用 `NitroText` 组件了。

## 使用方法


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

## 选择

iOS 使用原生选择。 在 Android 上，NitroText 当前回退到 React Native 的 `Text`。

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

## HTML 渲染

当您传入 `renderer="html"` 时，NitroText 可以解析 HTML 字符串子元素和内联 CSS。

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

## 自定义选择菜单

NitroText 支持在选中文本时出现的自定义菜单项。传入一个包含菜单项数组的 `menus` 属性，每个菜单项包含一个 `title` 和 `action` 回调。

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

## 平台支持

- iOS  
- Android - 目前 `NitroText` 回退到 RN `Text`。

## 为什么选择 NitroText？

自定义原生文本视图，具有最小的 JS 开销和原生 iOS 选择功能。非常适合重度/嵌套样式文本和大型列表。它是 RN `Text` 组件的替代品。

## 开发

- `bun run build` — 类型检查并构建包  
- `bun run codegen` — 重新生成代码生成输出  
- 示例应用位于 `example/`  

## 致谢

基于 [create-nitro-module](https://github.com/patrickkabwe/create-nitro-module) 启动。

## 贡献

欢迎 PR！重大更改请先提出 issue。

> 💬 如需快速支持，请加入我们的 [Discord 频道](https://discord.gg/7KXUyHjz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---