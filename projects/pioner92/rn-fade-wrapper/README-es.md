# Wrapper de degradado de desvanecimiento en React Native

<p align="center">
  <img src="https://raw.githubusercontent.com/pioner92/rn-fade-wrapper/main/./assets/img.png" width="700" alt="Demostración del wrapper de degradado de desvanecimiento en React Native" />
</p>

**`rn-fade-wrapper`** es un componente simple y de alto rendimiento para React Native que añade **degradados de desvanecimiento** suaves y personalizables a los bordes de cualquier contenido. Perfecto para mejorar la experiencia de usuario en contenedores desplazables, listas, carruseles, modales o cualquier vista con contenido desbordante.

<div align="center" style="max-width: 400px; margin: auto;">
  <a href="https://www.npmjs.com/package/rn-fade-wrapper">
    <img src="https://img.shields.io/npm/v/rn-fade-wrapper.svg" alt="versión npm" />
  </a>
  <img src="https://img.shields.io/badge/platform-iOS-blue?logo=apple" alt="iOS" />
  <img src="https://img.shields.io/badge/platform-Android-green?logo=android" alt="Android" />
  <img src="https://img.shields.io/badge/types-TypeScript-blue?logo=typescript" alt="TypeScript" />
  <img src="https://img.shields.io/badge/license-MIT-yellow.svg" alt="Licencia MIT" />
  <a href="https://bundlephobia.com/result?p=rn-fade-wrapper">
    <img src="https://img.shields.io/bundlephobia/minzip/rn-fade-wrapper" alt="Tamaño del paquete" />
  </a>
</div>

---

## ✨ Características

- ⚡ Renderizado nativo para **iOS** y **Android**
- 🔁 Soporta direcciones de degradado **vertical** y **horizontal**
- 🎨 Tamaño y color de desvanecimiento **totalmente personalizables** (por lado o uniforme)
- ↕️ Modo opcional `inward` para desvanecer **hacia el contenido** en lugar de hacia afuera
- 🧩 API simple: wrapper para usar directamente con props intuitivas
- 💪 Gran rendimiento con bajo consumo — ideal para vistas desplazables y animaciones

---

## 📦 Instalación

```bash
yarn add rn-fade-wrapper
```

or

```bash
npm install rn-fade-wrapper
```

### Expo

Esta biblioteca funciona en Expo (con `expo prebuild`) sin configuración adicional.

---

## 📱 Soporte de Plataforma

| Plataforma | Arquitectura Antigua | Fabric |
|------------|---------------------|--------|
| iOS        | ✅                   | ✅      |
| Android    | ✅                   | ✅      |

---

## 🚀 Inicio Rápido

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

## 🧩 Props

| Prop         | Tipo                       | Por defecto               | Descripción |
|--------------|----------------------------|---------------------------|-------------|
| `color`      | `string`                   | `"#ffffff"`               | Color del desvanecimiento (puede ser cualquier cadena de color válida) |
| `size`       | `number`                   | `20`                      | Tamaño uniforme del desvanecimiento en puntos |
| `style`      | `ViewStyle`                | `{ zIndex: 2 }`           | Estilo personalizado aplicado a la vista contenedora |
| `inward`     | `boolean`                  | `false`                   | Hace que el degradado se desvanezca hacia adentro (hacia el centro) en lugar de hacia afuera |
| `sizes`      | `{ top?: number, right?: number, bottom?: number, left?: number }` | `undefined` | Tamaños específicos de desvanecimiento por borde (sobrescribe `size` y `orientation`) |
| `orientation`| `'horizontal' \| 'vertical'` | `'vertical'`             | Preajuste para la dirección: aplica `size` a arriba/abajo o izquierda/derecha |
| `children`   | `React.ReactNode`          | —                         | Tu contenido envuelto |

> **Nota:** `sizes` tiene prioridad sobre `size` y `orientation`.

---

## 🎛 Ejemplos

### 🎯 Lados personalizados + desvanecimiento hacia adentro:
```tsx
<FadeWrapper
  color="black"
  inward
  sizes={{ top: 20, bottom: 30 }}
>
  <FlatList ... />
</FadeWrapper>
```

### 📜 Desvanecimiento al desplazarse horizontalmente:
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

## 🛠 Bajo el Capó

- **iOS:** Usa `CAGradientLayer` dentro de `UIView` nativo  
- **Android:** Dibuja `LinearGradient` en un `ViewGroup` personalizado usando Canvas  
- Maneja el diseño y vuelve a renderizar con lógica específica de la plataforma para consistencia

---

## 💡 Consejo de UX

Usa `rn-fade-wrapper` para indicar sutilmente el desbordamiento de contenido — especialmente en carruseles, vistas de desplazamiento y deslizadores horizontales. Los degradados ayudan a insinuar al usuario que hay más para desplazarse, mejorando la interacción.

---

## 📘 Licencia

MIT — libre para usar, mejorar y contribuir 🎉



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---