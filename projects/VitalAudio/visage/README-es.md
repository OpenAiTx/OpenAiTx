# Visage: la biblioteca UI se encuentra con la codificación creativa

**Visage** es una biblioteca C++ multiplataforma acelerada por GPU para UI nativa y gráficos 2D. Fusiona la estructura de un framework de UI con las características de bibliotecas creativas de gráficos.

## Ejemplo básico completo
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Se abre como una ventana de 800 x 600 píxeles
  app.runEventLoop(); // Ejecuta eventos de la ventana. Retorna cuando la ventana se cierra.
  return 0;
}
```

## Demostraciones
- [Showcase](https://visage.dev/examples/Showcase/)
- [Modos de mezcla](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Degradados](https://visage.dev/examples/Gradients/)
- [Efectos de shader posteriores](https://visage.dev/examples/PostEffects/)
- [Edición de shader en vivo](https://visage.dev/examples/LiveShaderEditing/)
- [Flexión de diseño](https://visage.dev/examples/Layout/)

## Características de UI

- **Normalización de eventos**  
&nbsp;&nbsp;&nbsp;Soporte multiplataforma para normalización de entrada de teclado y ratón.

- **Normalización de ventana**  
&nbsp;&nbsp;&nbsp;Soporte multiplataforma para abrir y manejar ventanas.

- **Entrada de texto**  
&nbsp;&nbsp;&nbsp;Entrada de texto Unicode con edición de texto multilínea.

- **✨ Emojis ✨**  
&nbsp;&nbsp;&nbsp;Si te gustan ese tipo de cosas 🤷

- **Renderizado parcial**  
&nbsp;&nbsp;&nbsp;Redibuja solo las regiones sucias para un rendimiento óptimo.

## Características gráficas

- **Movimiento fluido**  
&nbsp;&nbsp;&nbsp;Los nuevos cuadros se muestran a la tasa de refresco del monitor y las animaciones son suaves.

- **Agrupación automática de formas**  
&nbsp;&nbsp;&nbsp;Agrupa automáticamente formas para un renderizado eficiente en GPU.

- **Modos de mezcla**  
&nbsp;&nbsp;&nbsp;Soporta mezclar capas con aditivo, sustractivo o dibujando una máscara personalizada para que pase la UI.

- **Shaders**  
&nbsp;&nbsp;&nbsp;Escribe shaders una vez y transpílalos para Direct3D, Metal y OpenGL.

- **Efectos incluidos**  
&nbsp;&nbsp;&nbsp;Efectos en tiempo real como gran desenfoque y bloom.

- **Precisión de píxel**  
&nbsp;&nbsp;&nbsp;Acceso al tamaño de píxel del dispositivo para garantizar un renderizado preciso sin desenfoques.

## Plataformas soportadas
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---