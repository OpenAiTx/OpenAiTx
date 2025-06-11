# Visage: la libreria UI incontra il creative coding

**Visage** è una libreria C++ nativa, multipiattaforma e accelerata GPU per UI e grafica 2D. Unisce la struttura di un framework UI con le funzionalità di librerie grafiche creative.

## Esempio Base Completo
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Si apre come finestra di 800 x 600 pixel
  app.runEventLoop(); // Gestisce gli eventi della finestra. Ritorna quando la finestra viene chiusa.
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

## Caratteristiche UI

- **Normalizzazione degli Eventi**  
&nbsp;&nbsp;&nbsp;Supporto multipiattaforma per la normalizzazione degli input da tastiera e mouse.

- **Normalizzazione delle Finestre**  
&nbsp;&nbsp;&nbsp;Supporto multipiattaforma per l’apertura e la gestione delle finestre.

- **Inserimento Testo**  
&nbsp;&nbsp;&nbsp;Inserimento testo Unicode con editing multi linea.

- **✨ Emoji ✨**  
&nbsp;&nbsp;&nbsp;Se ti piacciono queste cose 🤷

- **Rendering Parziale**  
&nbsp;&nbsp;&nbsp;Ridisegna solo le aree "sporche" per prestazioni ottimali.

## Caratteristiche Grafiche

- **Movimento Fluido**  
&nbsp;&nbsp;&nbsp;I nuovi frame vengono mostrati al refresh rate del monitor e le animazioni sono fluide.

- **Batching Automatico delle Forme**  
&nbsp;&nbsp;&nbsp;Raggruppa automaticamente le forme per un rendering GPU efficiente.

- **Modalità di Fusione**  
&nbsp;&nbsp;&nbsp;Supporta la fusione dei layer con modalità additive, sottrattive o disegnando una maschera personalizzata per il passaggio UI.

- **Shader**  
&nbsp;&nbsp;&nbsp;Scrivi shader una volta e transpila per Direct3D, Metal e OpenGL.

- **Effetti Inclusi**  
&nbsp;&nbsp;&nbsp;Effetti in tempo reale come sfocatura intensa e bloom.

- **Precisione Pixel**  
&nbsp;&nbsp;&nbsp;Accesso alla dimensione pixel del dispositivo per un rendering preciso senza sfocature.

## Piattaforme Supportate
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---