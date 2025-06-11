# Visage: biblioteka UI spotyka kreatywne kodowanie

**Visage** to akcelerowana przez GPU, wieloplatformowa biblioteka C++ do natywnego UI i grafiki 2D. Łączy strukturę frameworka UI z funkcjami kreatywnych bibliotek graficznych.

## Pełny podstawowy przykład
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Otwiera okno o rozmiarze 800 x 600 pikseli
  app.runEventLoop(); // Uruchamia pętlę zdarzeń okna. Zwraca po zamknięciu okna.
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

## Funkcje UI

- **Normalizacja zdarzeń**  
&nbsp;&nbsp;&nbsp;Wieloplatformowe wsparcie dla normalizacji wejścia z klawiatury i myszy.

- **Normalizacja okna**  
&nbsp;&nbsp;&nbsp;Wieloplatformowe wsparcie dla otwierania i obsługi okien.

- **Wprowadzanie tekstu**  
&nbsp;&nbsp;&nbsp;Wprowadzanie tekstu Unicode z edycją wielowierszową

- **✨ Emoji ✨**  
&nbsp;&nbsp;&nbsp;Jeśli lubisz takie rzeczy 🤷

- **Częściowe renderowanie**  
&nbsp;&nbsp;&nbsp;Przerysowuje tylko zmienione obszary dla optymalnej wydajności.

## Funkcje graficzne

- **Płynny ruch**  
&nbsp;&nbsp;&nbsp;Nowe klatki wyświetlane są z częstotliwością odświeżania monitora, animacje są płynne

- **Automatyczne grupowanie kształtów**  
&nbsp;&nbsp;&nbsp;Automatycznie grupuje kształty dla efektywnego renderowania na GPU.

- **Tryby mieszania**  
&nbsp;&nbsp;&nbsp;Obsługuje mieszanie warstw poprzez dodawanie, odejmowanie lub rysowanie niestandardowej maski, przez którą UI może przechodzić

- **Shadery**  
&nbsp;&nbsp;&nbsp;Napisz shader raz i transpiluj go dla Direct3D, Metal i OpenGL

- **Dołączone efekty**  
&nbsp;&nbsp;&nbsp;Efekty w czasie rzeczywistym takie jak duże rozmycie i bloom

- **Dokładność pikseli**  
&nbsp;&nbsp;&nbsp;Dostęp do rozmiaru piksela urządzenia zapewnia precyzyjne renderowanie bez rozmycia.

## Obsługiwane platformy
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---