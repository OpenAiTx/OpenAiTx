# Visage: biblioteca de UI encontra programação criativa

**Visage** é uma biblioteca C++ nativa, acelerada por GPU e multiplataforma para UI e gráficos 2D. Ela combina a estrutura de um framework de UI com os recursos de bibliotecas gráficas criativas.

## Exemplo Básico Completo
```cpp
#include <visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Abre uma janela de 800 x 600 pixels
  app.runEventLoop(); // Executa eventos da janela. Retorna quando a janela é fechada.
  return 0;
}
```

## Demos
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## Recursos de UI

- **Normalização de Eventos**  
&nbsp;&nbsp;&nbsp;Suporte multiplataforma para normalização de entrada de teclado e mouse.

- **Normalização de Janela**  
&nbsp;&nbsp;&nbsp;Suporte multiplataforma para abertura e gerenciamento de janelas.

- **Entrada de texto**  
&nbsp;&nbsp;&nbsp;Entrada de texto Unicode com edição de texto multilinha.

- **✨ Emojis ✨**  
&nbsp;&nbsp;&nbsp;Se você curte esse tipo de coisa 🤷

- **Renderização Parcial**  
&nbsp;&nbsp;&nbsp;Redesenha apenas as regiões sujas para desempenho otimizado.

## Recursos Gráficos

- **Movimento fluido**  
&nbsp;&nbsp;&nbsp;Novos quadros são exibidos na taxa de atualização do monitor e as animações são suaves.

- **Agrupamento Automático de Formas**  
&nbsp;&nbsp;&nbsp;Agrupa formas automaticamente para renderização eficiente na GPU.

- **Modos de Mesclagem**  
&nbsp;&nbsp;&nbsp;Suporta mesclagem de camadas com aditivo, subtrativo ou desenhando uma máscara customizada para a UI passar.

- **Shaders**  
&nbsp;&nbsp;&nbsp;Escreva shaders uma vez e transpile para Direct3D, Metal e OpenGL.

- **Efeitos Incluídos**  
&nbsp;&nbsp;&nbsp;Efeitos em tempo real como desfoque intenso e bloom.

- **Precisão de Pixel**  
&nbsp;&nbsp;&nbsp;Acesso ao tamanho do pixel do dispositivo garante renderização precisa sem borrões.

## Plataformas Suportadas
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---