


  
 # react-native-gallery-preview
  
  <div>
    <img align="right" height="720" src="https://raw.githubusercontent.com/chrizuuu/react-native-gallery-preview/main/example.gif">
  </div>

  **GalleryPreview** 是一个灵活的模态组件，支持完整手势操作，便于图库预览。通过使用 `Reanimated` 和 `React Native Gesture Handler`，它为 iOS 和 Android 提供流畅简洁的用户体验。
  
  ### 特性
  
  * ⚡  **流畅的手势交互和动画：** 体验流畅且响应迅速的动画和手势，为用户界面带来愉悦感受。
  * 🔍 **双击和捏合缩放：** 用户可以通过简单的双击和捏合手势轻松放大和缩小图片。
  * 👆 **下拉关闭：** 直观的下拉手势关闭图库预览，使导航更加顺畅。
  *  ↔️ **支持 RTL（从右到左）布局**
  * 📱 **支持 `iOS` 和 `Android`：** 完全兼容 iOS 和 Android 设备，确保跨平台一致的体验。
  * 📱 **兼容 `Expo`**
  ### 快速开始
  在使用 GalleryPreview 之前，您需要先安装 react-native-reanimated 和 react-native-gesture-handler。请参考以下链接获取详细安装指南：
  
  * [设置 Reanimated](https://docs.swmansion.com/react-native-reanimated/docs/fundamentals/getting-started/#installation)
  * [设置 React Native Gesture Handler](ht↔️tps://docs.swmansion.com/react-native-gesture-handler/docs/fundamentals/installation)

  依赖安装完成后，您可以将 react-native-gallery-preview 添加到项目中：
  
  ```sh
  npm install react-native-gallery-preview
  # or
  yarn add react-native-gallery-preview
  
  ```

### 示例

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

| 属性名                     | 类型                                       | 描述                                                                                                                             | 默认值                                                                                                             |
|----------------------------|-------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|
| `isVisible`                | `boolean`                                 | 控制图片查看器模态框的可见性。                                                                                                   | -                                                                                                                  |
| `onRequestClose`           | `() => void`                              | 关闭图片查看器模态框的函数。                                                                                                     | -                                                                                                                  |
| `images`                   | `ImageItemURI[]`                          | 要显示的图片 URI 数组。                                                                                                          | -                                                                                                                  |
| `initialIndex?`             | `number`                                  | 查看器打开时显示的初始图片索引。                                                                                                | `0`                                                                                                                |
| `gap?`                      | `number`                                  | 查看器中图片之间的间隙。                                                                                                        | `24`                                                                                                               |
| `simultaneousRenderedImages?` | `number`                                  | 同时渲染的图片数量，用于性能优化。                                                                                              | `6`                                                                                                                |
| `OverlayComponent?`          | `(props: GalleryOverlayProps) => React.ReactNode` | 可选组件，渲染在图片查看器之上。                                                                                              | -                                                                                                                  |
| `ImageComponent?`           | `(props: GalleryImageComponentProps) => React.JSX.Element` | 可选自定义组件，用于渲染每张图片。                                                                                             | -                                                                                                                  |
| `springConfig?`             | `SpringConfig`                            | 动画的弹簧配置。                                                                                                                 | `{ damping: 1000, mass: 1, stiffness: 250, restDisplacementThreshold: 0.02, restSpeedThreshold: 4 }`                |
| `doubleTabEnabled?`           | `boolean`                                        | 是否启用双击缩放功能。                                                                                                          | `true`                                                                                                             |
| `pinchEnabled?`               | `boolean`                                        | 是否启用捏合缩放功能。                                                                                                          | `true`                                                                                                             |
| `swipeToCloseEnabled?`        | `boolean`                                        | 是否启用滑动关闭功能。                                                                                                          | `true`                                                                                                             |
| `backgroundColor?`        | `string`                                        | 模态框、默认头部和状态栏的背景颜色。                                                                                           | `#000`                                                                                                            |
| `headerTextColor?`        | `string`                                        | 头部文本颜色。                                                                                                                  | `#fff`                                                                                                            |




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-23

---