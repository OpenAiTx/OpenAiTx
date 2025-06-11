# Visage：UI 库遇上创意编码

**Visage** 是一个 GPU 加速的跨平台 C++ 库，用于原生 UI 和 2D 图形。它将 UI 框架的结构与创意图形库的功能融合在一起。

## 完整基础示例
```cpp
#include <visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 以 800 x 600 像素窗口打开
  app.runEventLoop(); // 运行窗口事件。窗口关闭时返回。
  return 0;
}
```

## 演示
- [展示](https://visage.dev/examples/Showcase/)
- [混合模式](https://visage.dev/examples/BlendModes/)
- [泛光](https://visage.dev/examples/Bloom/)
- [渐变](https://visage.dev/examples/Gradients/)
- [后期着色器效果](https://visage.dev/examples/PostEffects/)
- [实时着色器编辑](https://visage.dev/examples/LiveShaderEditing/)
- [布局弹性](https://visage.dev/examples/Layout/)

## UI 特性

- **事件归一化**  
&nbsp;&nbsp;&nbsp;跨平台支持键盘和鼠标输入归一化。

- **窗口归一化**  
&nbsp;&nbsp;&nbsp;跨平台支持打开和处理窗口。

- **文本输入**  
&nbsp;&nbsp;&nbsp;支持 Unicode 文本输入和多行文本编辑。

- **✨ 表情符号 ✨**  
&nbsp;&nbsp;&nbsp;如果你喜欢这种东西 🤷

- **局部渲染**  
&nbsp;&nbsp;&nbsp;仅重绘脏区域，实现最佳性能。

## 图形特性

- **流畅运动**  
&nbsp;&nbsp;&nbsp;新帧以显示器刷新率显示，动画流畅。

- **自动形状批处理**  
&nbsp;&nbsp;&nbsp;自动对形状进行分组，提升 GPU 渲染效率。

- **混合模式**  
&nbsp;&nbsp;&nbsp;支持使用加法、减法或绘制自定义遮罩来混合图层，实现 UI 透传。

- **着色器**  
&nbsp;&nbsp;&nbsp;编写一次着色器，自动转译到 Direct3D、Metal 和 OpenGL。

- **内置效果**  
&nbsp;&nbsp;&nbsp;实时效果，如大范围模糊和泛光。

- **像素精度**  
&nbsp;&nbsp;&nbsp;访问设备像素大小，确保精确渲染无模糊。

## 支持平台
- **Windows**：Direct3D11
- **MacOS**：Metal  
- **Linux**：Vulkan
- **Web/Emscripten**：WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---