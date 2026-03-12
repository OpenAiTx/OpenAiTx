# jordansingerbutton

一个美观且交互式的 SwiftUI 计数器组件，具有玻璃态箭头按钮和平滑动画。

## 📱 演示



## 🌿 分支

### `main` - 完整应用
包含计数功能的完整 jordansingerbutton 应用。

### `tutorial` - 箭头按钮组件
一个简洁的独立版本，专注于漂亮的箭头按钮组件。非常适合学习和分享！

**查看教程版本：**
```bash
git checkout tutorial
```

## 🚀 快速开始

### 使用箭头按钮组件

`ArrowButton` 是一个可重用的 SwiftUI 组件，创建一个美观的玻璃拟态按钮，具有：
- 多层描边的金属钢材外观
- 模糊的反射效果
- 平滑的动画
- 可自定义旋转

```swift
import SwiftUI

ArrowButton(rotation: .degrees(0))  // Pointing down
ArrowButton(rotation: .degrees(180)) // Pointing up
ArrowButton(rotation: .degrees(90))  // Pointing left
ArrowButton(rotation: .degrees(270)) // Pointing right
```

### 完整应用使用

完整的应用包含带有“今天”、“明天”、“昨天”标签的日期导航和流畅的日期过渡。

## 📁 项目结构

```
jordansingerbutton/
├── CounterView.swift          # Counter with arrow buttons (includes ArrowButton)
├── JordanSingerButtonApp.swift  # App entry point
└── Assets.xcassets/            # Arrow image asset
```

## 🎨 特性

- **玻璃拟态设计**：美观的金属钢材外观
- **流畅动画**：基于弹簧的交互动画
- **无障碍支持**：完全支持 VoiceOver
- **可定制**：轻松修改颜色、尺寸和旋转

## 📝 许可证

免费使用和修改，用于您的项目！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-12

---