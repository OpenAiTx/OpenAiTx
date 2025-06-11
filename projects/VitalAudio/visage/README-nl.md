# Visage: UI-bibliotheek ontmoet creatief coderen

**Visage** is een GPU-versnelde, cross-platform C++ bibliotheek voor native UI en 2D graphics. Het combineert de structuur van een UI-framework met de functies van creatieve graphics bibliotheken.

## Volledig Basisvoorbeeld
```cpp
#include <visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Opent als een venster van 800 x 600 pixels
  app.runEventLoop(); // Voert venstergebeurtenissen uit. Keert terug wanneer het venster wordt gesloten.
  return 0;
}
```

## Demo's
- [Showcase](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Showcase/)
- [Blend Modes](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/BlendModes/)
- [Bloom](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Bloom/)
- [Gradients](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Gradients/)
- [Post Shader Effects](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/PostEffects/)
- [Live Shader Editing](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/LiveShaderEditing/)
- [Layout Flexing](https://raw.githubusercontent.com/VitalAudio/visage/main/examples/Layout/)

## UI-functies

- **Evenement Normalisatie**  
&nbsp;&nbsp;&nbsp;Cross-platform ondersteuning voor normalisatie van toetsenbord- en muisinvoer.

- **Venster Normalisatie**  
&nbsp;&nbsp;&nbsp;Cross-platform ondersteuning voor het openen en beheren van vensters.

- **Tekstinvoer**  
&nbsp;&nbsp;&nbsp;Unicode tekstinvoer met meervoudige regel tekstbewerking

- **✨ Emoji's ✨**  
&nbsp;&nbsp;&nbsp;Als je daar van houdt 🤷

- **Gedeeltelijke Rendering**  
&nbsp;&nbsp;&nbsp;Teken alleen de gewijzigde gebieden opnieuw voor optimale prestaties.

## Graphics-functies

- **Vloeiende beweging**  
&nbsp;&nbsp;&nbsp;Nieuwe frames worden getoond met de verversingssnelheid van de monitor en animaties zijn soepel

- **Automatische Shape Batching**  
&nbsp;&nbsp;&nbsp;Groeperen van vormen voor efficiënte GPU-rendering.

- **Blend Modes**  
&nbsp;&nbsp;&nbsp;Ondersteunt het mengen van lagen met additieve, subtractieve of door het tekenen van een aangepaste mask voor de UI om doorheen te gaan

- **Shaders**  
&nbsp;&nbsp;&nbsp;Schrijf shaders één keer en transpileer ze voor Direct3d, Metal en OpenGL

- **Meegeleverde Effecten**  
&nbsp;&nbsp;&nbsp;Realtime effecten zoals grote blur en bloom

- **Pixelnauwkeurigheid**  
&nbsp;&nbsp;&nbsp;Toegang tot de pixelgrootte van het apparaat zorgt voor nauwkeurige rendering zonder vervaging.

## Ondersteunde Platforms
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---