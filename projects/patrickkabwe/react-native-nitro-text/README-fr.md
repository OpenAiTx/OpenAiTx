<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  Un composant Text beaucoup plus riche et performant pour iOS et Android.
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

## Fonctionnalités

- Fonctionne à la fois sur iOS et Android (actuellement retour à RN `Text` sur Android)
- Rendu natif iOS avec sélection fluide.
- Les fragments imbriqués fusionnent en une seule vue texte native
- Rendu Markdown et HTML (bientôt disponible).
- Prend en charge uniquement la Nouvelle Architecture

## Exigences

- React Native v0.78.0 ou supérieur (Fabric/Nitro Views)
- Node 18+ (Node 20+ recommandé)

## Installation

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```

C’est tout. Vous pouvez maintenant utiliser le composant `NitroText` dans votre application.

## Utilisation

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

## Sélection

iOS utilise la sélection native. Sur Android, NitroText revient actuellement à `Text` de React Native.

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

## Rendu HTML

NitroText peut analyser les chaînes HTML enfants et le CSS en ligne lorsque vous passez `renderer="html"`.

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

## Menu de sélection personnalisé

NitroText prend en charge les éléments de menu personnalisés qui apparaissent lorsque le texte est sélectionné. Passez une propriété `menus` avec un tableau d'éléments de menu, chacun contenant un `title` et un rappel `action`.

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

## Support de plateforme

- iOS  
- Android - Pour le moment `NitroText` revient à RN `Text`.

## Pourquoi NitroText ?

Vue de texte native personnalisée avec un minimum de surcharge JS et une sélection native iOS. Idéal pour un texte lourd/imbriqué stylisé et de grandes listes. C’est un remplacement direct du composant RN `Text`.

## Développement

- `bun run build` — vérifie les types et construit le package  
- `bun run codegen` — régénère les sorties du codegen  
- Application exemple dans `example/`

## Crédits

Démarré avec [create-nitro-module](https://github.com/patrickkabwe/create-nitro-module).

## Contribution

Les PR sont les bienvenues ! Veuillez ouvrir un ticket avant pour les changements majeurs.

> 💬 Pour un support rapide, rejoignez notre [canal Discord](https://discord.gg/7KXUyHjz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---