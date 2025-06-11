# Visage: UIライブラリとクリエイティブコーディングの融合

**Visage** は、GPUアクセラレーション対応のクロスプラットフォームC++ライブラリで、ネイティブUIと2Dグラフィックスを提供します。UIフレームワークの構造とクリエイティブグラフィックスライブラリの機能を統合しています。

## フルベーシック例
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 800 x 600ピクセルのウィンドウを開く
  app.runEventLoop(); // ウィンドウイベントを実行。ウィンドウが閉じられると戻る。
  return 0;
}
```

## デモ
- [ショーケース](https://visage.dev/examples/Showcase/)
- [ブレンドモード](https://visage.dev/examples/BlendModes/)
- [ブルーム](https://visage.dev/examples/Bloom/)
- [グラデーション](https://visage.dev/examples/Gradients/)
- [ポストシェーダーエフェクト](https://visage.dev/examples/PostEffects/)
- [ライブシェーダー編集](https://visage.dev/examples/LiveShaderEditing/)
- [レイアウトフレックス](https://visage.dev/examples/Layout/)

## UI機能

- **イベント正規化**  
&nbsp;&nbsp;&nbsp;キーボードとマウス入力のクロスプラットフォーム正規化対応。

- **ウィンドウ正規化**  
&nbsp;&nbsp;&nbsp;ウィンドウのオープンおよびハンドリングのクロスプラットフォーム対応。

- **テキスト入力**  
&nbsp;&nbsp;&nbsp;Unicodeテキスト入力と複数行テキスト編集対応。

- **✨ 絵文字 ✨**  
&nbsp;&nbsp;&nbsp;そういうのが好きな方に🤷

- **部分レンダリング**  
&nbsp;&nbsp;&nbsp;パフォーマンス最適化のため、変更があった領域のみ再描画。

## グラフィックス機能

- **滑らかな動き**  
&nbsp;&nbsp;&nbsp;モニターのリフレッシュレートに合わせて新しいフレームを表示し、アニメーションを滑らかに。

- **自動シェイプバッチ処理**  
&nbsp;&nbsp;&nbsp;GPUレンダリング効率化のため、自動的にシェイプをグループ化。

- **ブレンドモード**  
&nbsp;&nbsp;&nbsp;加算、減算やUIの透過用カスタムマスク描画によるレイヤーブレンドをサポート。

- **シェーダー**  
&nbsp;&nbsp;&nbsp;一度シェーダーを書けばDirect3D、Metal、OpenGL向けにトランスパイル可能。

- **付属エフェクト**  
&nbsp;&nbsp;&nbsp;大きなぼかしやブルームなどのリアルタイムエフェクトを含む。

- **ピクセル精度**  
&nbsp;&nbsp;&nbsp;デバイスピクセルサイズにアクセスし、ぼやけのない正確なレンダリングを実現。

## 対応プラットフォーム
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---