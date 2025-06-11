# Visage：UI 函式庫遇上創意編碼

**Visage** 是一個 GPU 加速、跨平台的 C++ 原生 UI 與 2D 圖形函式庫。它結合了 UI 框架的結構與創意圖形函式庫的功能。

## 完整基本範例
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 以 800 x 600 像素視窗開啟
  app.runEventLoop(); // 執行視窗事件。視窗關閉時返回。
  return 0;
}
```

## 範例展示
- [展示集](https://visage.dev/examples/Showcase/)
- [混合模式](https://visage.dev/examples/BlendModes/)
- [泛光效果](https://visage.dev/examples/Bloom/)
- [漸層](https://visage.dev/examples/Gradients/)
- [後置著色器效果](https://visage.dev/examples/PostEffects/)
- [即時著色器編輯](https://visage.dev/examples/LiveShaderEditing/)
- [佈局彈性](https://visage.dev/examples/Layout/)

## UI 功能

- **事件標準化**  
&nbsp;&nbsp;&nbsp;跨平台支援鍵盤與滑鼠輸入的標準化。

- **視窗標準化**  
&nbsp;&nbsp;&nbsp;跨平台支援開啟與管理視窗。

- **文字輸入**  
&nbsp;&nbsp;&nbsp;支援 Unicode 文字輸入與多行文字編輯。

- **✨ 表情符號 ✨**  
&nbsp;&nbsp;&nbsp;如果你喜歡這種東西 🤷

- **部分重繪**  
&nbsp;&nbsp;&nbsp;只重繪髒區，達到最佳效能。

## 圖形功能

- **流暢動畫**  
&nbsp;&nbsp;&nbsp;新幀以螢幕刷新率顯示，動畫順暢。

- **自動形狀批次處理**  
&nbsp;&nbsp;&nbsp;自動將形狀分組以提升 GPU 渲染效率。

- **混合模式**  
&nbsp;&nbsp;&nbsp;支援以加法、減法或繪製自訂遮罩混合圖層，讓 UI 穿透。

- **著色器**  
&nbsp;&nbsp;&nbsp;一次撰寫著色器，轉譯成 Direct3D、Metal 和 OpenGL。

- **內建效果**  
&nbsp;&nbsp;&nbsp;即時效果，如大範圍模糊與泛光。

- **像素精準**  
&nbsp;&nbsp;&nbsp;存取裝置像素大小，確保精確渲染無模糊。

## 支援平台
- **Windows**：Direct3D11
- **MacOS**：Metal  
- **Linux**：Vulkan
- **Web/Emscripten**：WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---