# Visage: библиотека UI встречает креативное программирование

**Visage** — это кроссплатформенная C++ библиотека с аппаратным ускорением на GPU для нативного UI и 2D графики. Она объединяет структуру UI-фреймворка с возможностями креативных графических библиотек.

## Полный базовый пример
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Открывается окно размером 800 x 600 пикселей
  app.runEventLoop(); // Запускает обработку событий окна. Возвращается после закрытия окна.
  return 0;
}
```

## Демонстрации
- [Showcase](https://visage.dev/examples/Showcase/)
- [Blend Modes](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradients](https://visage.dev/examples/Gradients/)
- [Post Shader Effects](https://visage.dev/examples/PostEffects/)
- [Live Shader Editing](https://visage.dev/examples/LiveShaderEditing/)
- [Layout Flexing](https://visage.dev/examples/Layout/)

## Особенности UI

- **Нормализация событий**  
&nbsp;&nbsp;&nbsp;Кроссплатформенная поддержка нормализации ввода с клавиатуры и мыши.

- **Нормализация окон**  
&nbsp;&nbsp;&nbsp;Кроссплатформенная поддержка открытия и управления окнами.

- **Ввод текста**  
&nbsp;&nbsp;&nbsp;Ввод текста в формате Unicode с поддержкой многострочного редактирования.

- **✨ Эмодзи ✨**  
&nbsp;&nbsp;&nbsp;Если вам это интересно 🤷

- **Частичная отрисовка**  
&nbsp;&nbsp;&nbsp;Перерисовываются только изменённые области для оптимальной производительности.

## Особенности графики

- **Плавное движение**  
&nbsp;&nbsp;&nbsp;Новые кадры отображаются с частотой обновления монитора, а анимации плавные.

- **Автоматическая группировка фигур**  
&nbsp;&nbsp;&nbsp;Автоматически группирует фигуры для эффективного рендеринга на GPU.

- **Режимы смешивания**  
&nbsp;&nbsp;&nbsp;Поддержка смешивания слоёв с аддитивным, вычитательным режимами или с использованием масок для пропуска UI.

- **Шейдеры**  
&nbsp;&nbsp;&nbsp;Пишите шейдеры один раз и транспилируйте их для Direct3D, Metal и OpenGL.

- **Встроенные эффекты**  
&nbsp;&nbsp;&nbsp;Эффекты в реальном времени, такие как сильное размытие и свечения.

- **Точность по пикселям**  
&nbsp;&nbsp;&nbsp;Доступ к размеру пикселя устройства обеспечивает точную отрисовку без размытия.

## Поддерживаемые платформы
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---