# React Native 渐隐渐变包装器

<p align="center">
  <img src="https://raw.githubusercontent.com/pioner92/rn-fade-wrapper/main/./assets/img.png" width="700" alt="React Native 渐隐渐变包装器演示" />
</p>

**`rn-fade-wrapper`** 是一个简单且高性能的 React Native 组件，能够为任何内容的边缘添加平滑且可自定义的**渐隐渐变**效果。非常适合提升可滚动容器、列表、轮播、模态框或任何溢出内容视图的用户体验。

<div align="center" style="max-width: 400px; margin: auto;">
  <a href="https://www.npmjs.com/package/rn-fade-wrapper">
    <img src="https://img.shields.io/npm/v/rn-fade-wrapper.svg" alt="npm 版本" />
  </a>
  <img src="https://img.shields.io/badge/platform-iOS-blue?logo=apple" alt="iOS" />
  <img src="https://img.shields.io/badge/platform-Android-green?logo=android" alt="Android" />
  <img src="https://img.shields.io/badge/types-TypeScript-blue?logo=typescript" alt="TypeScript" />
  <img src="https://img.shields.io/badge/license-MIT-yellow.svg" alt="MIT 许可证" />
  <a href="https://bundlephobia.com/result?p=rn-fade-wrapper">
    <img src="https://img.shields.io/bundlephobia/minzip/rn-fade-wrapper" alt="包大小" />
  </a>
</div>

---

## ✨ 特性

- ⚡ 原生渲染支持 **iOS** 和 **Android**
- 🔁 支持**垂直**和**水平**渐变方向
- 🎨 完全**可自定义的渐隐大小和颜色**（可针对每边或统一设置）
- ↕️ 可选的 `inward` 模式，实现向内容方向渐隐而非向外
- 🧩 简单的 API：即插即用包装器，属性直观
- 💪 性能优异，开销低 — 适合滚动视图和动画使用

---

## 📦 安装

```bash
yarn add rn-fade-wrapper
```

or

```bash
npm install rn-fade-wrapper
```

### Expo

该库在 Expo 中可用（使用 `expo prebuild`），无需额外配置。

---

## 📱 平台支持

| 平台     | 旧架构   | Fabric |
|----------|----------|--------|
| iOS      | ✅        | ✅      |
| Android  | ✅        | ✅      |

---

## 🚀 快速开始

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

## 🧩 属性

| 属性          | 类型                       | 默认值                     | 描述 |
|--------------|----------------------------|----------------------|-------------|
| `color`      | `string`                   | `"#ffffff"`          | 渐变色（可以是任何有效的颜色字符串） |
| `size`       | `number`                   | `20`                 | 统一的渐变大小，单位为点 |
| `style`      | `ViewStyle`                | `{ zIndex: 2 }`      | 应用于包装视图的自定义样式 |
| `inward`     | `boolean`                  | `false`              | 使渐变向内（朝向中心）而非向外淡出 |
| `sizes`      | `{ top?: number, right?: number, bottom?: number, left?: number }` | `undefined` | 每个边的特定渐变大小（覆盖 `size` 和 `orientation`） |
| `orientation`| `'horizontal' \| 'vertical'` | `'vertical'`       | 方向预设：将 `size` 应用于上下或左右 |
| `children`   | `React.ReactNode`          | —                    | 你包装的内容 |

> **注意：** `sizes` 优先于 `size` 和 `orientation`。

---

## 🎛 示例

### 🎯 自定义边 + 向内渐变：
```tsx
<FadeWrapper
  color="black"
  inward
  sizes={{ top: 20, bottom: 30 }}
>
  <FlatList ... />
</FadeWrapper>
```

### 📜 横向滚动淡出效果：
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

## 🛠 引擎内部

- **iOS:** 在原生 `UIView` 内使用 `CAGradientLayer`  
- **Android:** 使用 Canvas 在自定义 `ViewGroup` 上绘制 `LinearGradient`  
- 通过平台特定的逻辑处理布局和重新渲染以确保一致性  

---

## 💡 用户体验提示

使用 `rn-fade-wrapper` 来微妙地指示内容溢出——特别是在轮播图、滚动视图和水平滑块中。渐变效果有助于提示用户还有更多内容可滚动，提升互动体验。  

---

## 📘 许可证

MIT — 免费使用、改进和贡献 🎉  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-08

---