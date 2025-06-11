# Visage: Perpustakaan UI bertemu dengan coding kreatif

**Visage** adalah perpustakaan C++ lintas platform yang dipercepat GPU untuk UI native dan grafik 2D. Ini menggabungkan struktur kerangka kerja UI dengan fitur perpustakaan grafik kreatif.

## Contoh Dasar Lengkap
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Membuka jendela berukuran 800 x 600 piksel
  app.runEventLoop(); // Menjalankan event jendela. Mengembalikan ketika jendela ditutup.
  return 0;
}
```

## Demo
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## Fitur UI

- **Normalisasi Event**  
&nbsp;&nbsp;&nbsp;Dukungan lintas platform untuk normalisasi input keyboard dan mouse.

- **Normalisasi Jendela**  
&nbsp;&nbsp;&nbsp;Dukungan lintas platform untuk membuka dan menangani jendela.

- **Entri Teks**  
&nbsp;&nbsp;&nbsp;Entri teks Unicode dengan pengeditan teks multi baris.

- **✨ Emoji ✨**  
&nbsp;&nbsp;&nbsp;Jika Anda menyukai hal semacam itu 🤷

- **Rendering Parsial**  
&nbsp;&nbsp;&nbsp;Menggambar ulang hanya area yang kotor untuk performa optimal.

## Fitur Grafik

- **Gerakan Halus**  
&nbsp;&nbsp;&nbsp;Frame baru ditampilkan pada kecepatan refresh monitor dan animasi berjalan mulus.

- **Pengelompokan Bentuk Otomatis**  
&nbsp;&nbsp;&nbsp;Mengelompokkan bentuk secara otomatis untuk rendering GPU yang efisien.

- **Mode Blending**  
&nbsp;&nbsp;&nbsp;Mendukung penggabungan lapisan dengan additive, subtractive, atau dengan menggambar masker khusus agar UI dapat dilalui.

- **Shader**  
&nbsp;&nbsp;&nbsp;Tulis shader sekali dan transpile untuk Direct3d, Metal, dan OpenGL.

- **Efek Termasuk**  
&nbsp;&nbsp;&nbsp;Efek waktu nyata seperti blur besar dan bloom.

- **Akurasi Piksel**  
&nbsp;&nbsp;&nbsp;Akses ke ukuran piksel perangkat memastikan rendering presisi tanpa blur.

## Platform yang Didukung
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---