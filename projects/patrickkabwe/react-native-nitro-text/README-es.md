<div align="center">
  <h1>react-native-nitro-text</h1>
</div>

<p align="center">
  Un componente Text que es mucho más completo y eficiente tanto para iOS como para Android.
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

## Características

- Funciona tanto en iOS como en Android (actualmente vuelve a RN `Text` en Android)
- Renderizado nativo en iOS con selección suave.
- Fragmentos anidados se fusionan en una sola vista de texto nativa
- Renderizado de Markdown y HTML (próximamente).
- Soporta solo la Nueva Arquitectura

## Requisitos

- React Native v0.78.0 o superior (Fabric/Nitro Views)
- Node 18+ (se recomienda Node 20+)

## Instalación

```bash
yarn add react-native-nitro-text react-native-nitro-modules
```

iOS

```bash
cd ios && pod install && cd ..
```

Eso es todo. Ahora puedes usar el componente `NitroText` en tu aplicación.

## Uso

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

## Selección

iOS usa selección nativa. En Android, NitroText actualmente vuelve a usar `Text` de React Native.

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

## Renderizado HTML

NitroText puede analizar cadenas HTML como hijos y CSS en línea cuando pasas `renderer="html"`.

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

## Menú de selección personalizado

NitroText soporta elementos de menú personalizados que aparecen cuando se selecciona texto. Pasa una propiedad `menus` con un arreglo de elementos de menú, cada uno con un `title` y una función de devolución de llamada `action`.

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

## Soporte de Plataforma

- iOS
- Android - Por el momento `NitroText` vuelve a usar `Text` de RN.

## ¿Por qué NitroText?

Vista de texto nativa personalizada con mínima sobrecarga de JS y selección nativa en iOS. Ideal para texto con estilos complejos/anidados y listas grandes. Es un reemplazo directo para el componente `Text` de RN.

## Desarrollo

- `bun run build` — verifica tipos y compila el paquete
- `bun run codegen` — regenera las salidas de codegen
- Aplicación de ejemplo en `example/`

## Créditos

Creado con [create-nitro-module](https://github.com/patrickkabwe/create-nitro-module).

## Contribuciones

¡PRs bienvenidos! Por favor, abre un issue primero para cambios mayores.

> 💬 Para soporte rápido, únete a nuestro [canal de Discord](https://discord.gg/7KXUyHjz)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-13

---