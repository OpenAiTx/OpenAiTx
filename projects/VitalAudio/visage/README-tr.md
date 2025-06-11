# Visage: UI kütüphanesi yaratıcı kodlama ile buluşuyor

**Visage**, yerel UI ve 2D grafikler için GPU hızlandırmalı, çapraz platform C++ kütüphanesidir. Bir UI çerçevesinin yapısını yaratıcı grafik kütüphanelerinin özellikleriyle birleştirir.

## Tam Temel Örnek
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 800 x 600 piksel pencere olarak açılır
  app.runEventLoop(); // Pencere olaylarını çalıştırır. Pencere kapandığında döner.
  return 0;
}
```

## Demolar
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## UI Özellikleri

- **Olay Normalizasyonu**  
&nbsp;&nbsp;&nbsp;Klavye ve fare girişi için çapraz platform destekli normalizasyon.

- **Pencere Normalizasyonu**  
&nbsp;&nbsp;&nbsp;Pencerelerin açılması ve yönetilmesi için çapraz platform destek.

- **Metin Girişi**  
&nbsp;&nbsp;&nbsp;Çok satırlı metin düzenlemeli Unicode metin girişi

- **✨ Emojiler ✨**  
&nbsp;&nbsp;&nbsp;Eğer böyle şeyleri seviyorsanız 🤷

- **Kısmi Çizim**  
&nbsp;&nbsp;&nbsp;Optimum performans için sadece değişen bölgeleri yeniden çizer.

## Grafik Özellikleri

- **Akıcı hareket**  
&nbsp;&nbsp;&nbsp;Yeni kareler monitörün yenileme hızında gösterilir ve animasyonlar pürüzsüzdür.

- **Otomatik Şekil Gruplama**  
&nbsp;&nbsp;&nbsp;Şekilleri GPU verimli çizimi için otomatik olarak gruplar.

- **Karıştırma Modları**  
&nbsp;&nbsp;&nbsp;Katmanları ekleyerek, çıkararak veya UI'nin geçiş yapması için özel bir maske çizerek karıştırmayı destekler.

- **Shaderlar**  
&nbsp;&nbsp;&nbsp;Shaderları bir kez yazın ve Direct3D, Metal ve OpenGL için dönüştürün.

- **Dahil Edilen Efektler**  
&nbsp;&nbsp;&nbsp;Büyük bulanıklık ve bloom gibi gerçek zamanlı efektler.

- **Piksel Doğruluğu**  
&nbsp;&nbsp;&nbsp;Cihaz piksel boyutuna erişim, bulanıklık olmadan hassas çizim sağlar.

## Desteklenen Platformlar
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---