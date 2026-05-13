<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  A Text component that is much richer and performant for both iOS and Android.
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

## Features

- Works on both iOS and Android(currently fallback to RN `Text` on Android)
- Native iOS rendering with smooth selection.
- Nested fragments merge into a single native text view
- Rendering Markdown and HTML (coming soon).
- Supports only the New Architecture

## Requirements

- React Native v0.78.0 or higher (Fabric/Nitro Views)
- Node 18+ (Node 20+ recommended)

## Installation

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```

That’s it. You can now use the `NitroText` component in your app.

## Usage

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

## Selection

iOS uses native selection. On Android, NitroText currently falls back to React Native `Text`.

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

## HTML rendering

NitroText can parse HTML string children and inline CSS when you pass `renderer="html"`.

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

## Custom selection menu

NitroText supports custom menu items that appear when text is selected. Pass a `menus` prop with an array of menu items, each containing a `title` and `action` callback.

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

## Platform Support

- iOS
- Android - At the moment `NitroText` fallback to RN `Text`.

## Why NitroText?

Custom native text view with minimal JS overhead and native iOS selection. Great for heavy/nested styled text and large lists. It's a drop-in replacement for RN `Text` component.

## Development

- `bun run build` — typecheck and build the package
- `bun run codegen` — regenerate codegen outputs
- Example app in `example/`

## Credits

Bootstrapped with [create-nitro-module](https://github.com/patrickkabwe/create-nitro-module).

## Contributing

PRs welcome! Please open an issue first for major changes.

> 💬 For quick support, join our [Discord channel](https://discord.gg/7KXUyHjz)
