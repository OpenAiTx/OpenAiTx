# Visage: UI-Bibliothek trifft kreatives Coding

**Visage** ist eine GPU-beschleunigte, plattformübergreifende C++-Bibliothek für native UI und 2D-Grafiken. Sie verbindet die Struktur eines UI-Frameworks mit den Funktionen kreativer Grafikbibliotheken.

## Vollständiges Basisbeispiel
```cpp
#include <visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Öffnet ein Fenster mit 800 x 600 Pixeln
  app.runEventLoop(); // Führt Fensterevents aus. Rückkehr bei Fenster-Schließung.
  return 0;
}
```

## Demos
- [Showcase](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Showcase/)
- [Blend Modes](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/BlendModes/)
- [Bloom](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Bloom/)
- [Gradients](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Gradients/)
- [Post Shader Effects](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/PostEffects/)
- [Live Shader Editing](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/LiveShaderEditing/)
- [Layout Flexing](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Layout/)

## UI-Funktionen

- **Event-Normalisierung**  
&nbsp;&nbsp;&nbsp;Plattformübergreifende Unterstützung zur Normalisierung von Tastatur- und Mauseingaben.

- **Fenster-Normalisierung**  
&nbsp;&nbsp;&nbsp;Plattformübergreifende Unterstützung zum Öffnen und Verwalten von Fenstern.

- **Texteingabe**  
&nbsp;&nbsp;&nbsp;Unicode-Texteingabe mit mehrzeiliger Textbearbeitung.

- **✨ Emojis ✨**  
&nbsp;&nbsp;&nbsp;Falls du darauf stehst 🤷

- **Teilweise Darstellung**  
&nbsp;&nbsp;&nbsp;Zeichnet nur die veränderten Bereiche neu für optimale Leistung.

## Grafik-Funktionen

- **Flüssige Bewegung**  
&nbsp;&nbsp;&nbsp;Neue Frames werden mit der Bildwiederholfrequenz des Monitors angezeigt, Animationen laufen flüssig.

- **Automatisches Shape-Batching**  
&nbsp;&nbsp;&nbsp;Gruppiert Formen automatisch für effizientes GPU-Rendering.

- **Blend-Modi**  
&nbsp;&nbsp;&nbsp;Unterstützt das Mischen von Ebenen mit additiver, subtraktiver oder durch das Zeichnen einer benutzerdefinierten Maske für das UI-Durchscheinen.

- **Shader**  
&nbsp;&nbsp;&nbsp;Schreibe Shader einmal und transpiliere sie für Direct3D, Metal und OpenGL.

- **Inklusive Effekte**  
&nbsp;&nbsp;&nbsp;Echtzeiteffekte wie starker Blur und Bloom.

- **Pixelgenauigkeit**  
&nbsp;&nbsp;&nbsp;Zugriff auf die Gerätepixelgröße garantiert präzise Darstellung ohne Unschärfe.

## Unterstützte Plattformen
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---