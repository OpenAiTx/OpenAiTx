<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

¡Si disfrutas este proyecto, considera apoyarme en Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Una extensión de nodo personalizada para ComfyUI que agrega capacidades de texto a voz (TTS) y conversión de voz (VC) utilizando la biblioteca Chatterbox.
Soporta un MÁXIMO de 40 segundos. He intentado eliminar esta limitación, pero el modelo se descompone muy mal con algo más largo que eso, así que permanece.

![Ejemplo de ChatterBox](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Instalación

1. Clona este repositorio en tu directorio custom_nodes de ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Instale las dependencias base:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Opcional) Instale el soporte para marcas de agua:

   ```bash
   pip install resemble-perth
   ```
**Nota**: El paquete `resemble-perth` puede tener problemas de compatibilidad con Python 3.12+. Si encuentras errores de importación, los nodos seguirán funcionando sin marca de agua.

## Uso

### Nodo de Texto a Voz (FL Chatterbox TTS)
- Añade el nodo "FL Chatterbox TTS" a tu flujo de trabajo
- Configura la entrada de texto y los parámetros (exageración, cfg_weight, temperatura)
- Opcionalmente proporciona un audio de referencia para clonación de voz

### Nodo de Conversión de Voz (FL Chatterbox VC)
- Añade el nodo "FL Chatterbox VC" a tu flujo de trabajo
- Conecta el audio de entrada y la voz objetivo
- Ambos nodos admiten cambio a CPU si ocurren errores de CUDA

## Registro de Cambios

### 24/06/2025
- Añadido parámetro de semilla a los nodos TTS y VC para generación reproducible
- Rango de semilla: 0 a 4.294.967.295 (entero de 32 bits)
- Permite salida de audio consistente para depuración y control de flujo de trabajo
- Marcado de agua Perth ahora es opcional para solucionar compatibilidad con Python 3.12+
- Los nodos ahora funcionan sin marca de agua si falla la importación de resemble-perth

### 31/05/2025
- Añadida carga persistente de modelos y funcionalidad de barra de progreso
- Añadido soporte para Mac (necesita ser probado, así que avísame)
- Se eliminó la biblioteca chatterbox-tts e implementado código de inferencia nativo.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---