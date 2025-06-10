# AI Screenshot Translator (AI 截图翻译工具)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Introducción

Esta herramienta, a través de una **sencilla operación de captura de pantalla**, envía la imagen al modelo de IA para el reconocimiento y traducción de texto, mostrando el resultado traducido en formato HTML interactivo en una ventana independiente.

La herramienta soporta **activación por teclas personalizadas, gestión de resultados en múltiples ventanas y funcionamiento en la bandeja del sistema**, lo que mejora en gran medida la eficiencia de traducción en el trabajo y estudio diario.

**Características de la herramienta**: 1. Traducción por captura de pantalla, iniciada con atajos de teclado; 2. Traducción y pegado de capturas, se pueden arrastrar y redimensionar libremente, se pueden crear varios grupos de fragmentos traducidos; 3. Las fórmulas pueden alternar al texto original para facilitar la copia; 4. Interfaz api personalizada

**Puntos problemáticos a resolver**: 1. La pesadez de las herramientas de traducción de documentos completos existentes en el mercado; 2. Si se copia el texto de un PDF para traducirlo, a veces los bloques de fórmulas quedan desordenados o no se pueden copiar; 3. Para los PDF escaneados como imagen, no se puede copiar el texto

# Demostración

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Visualización de ventanas

Ventana de traducción:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Ventana de configuración:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Para una introducción más detallada sobre las opciones de configuración, consulte la propia aplicación o vea en la web [提示](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Instalación

Puede optar por descargar el código fuente y ejecutarlo, o ir a la página de [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) para descargar el archivo ejecutable.

### 1. Clonar el repositorio

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Crear un entorno virtual y ejecutar

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Plan de actualizaciones

- ~~Nueva ventana gui para configuración de api, optimizando la lógica de configuración manual del archivo yaml para que sea generada automáticamente por el software (completado en v0.3.0)~~
- Nuevo sistema de almacenamiento de imágenes y fórmulas para facilitar el uso posterior (previsto para v0.4)
- (Se agradecen más sugerencias de funciones por medio de issues o contribuciones PR)

# Otros

- El icono del software proviene de [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Agradecimientos a Gemini 2.5 Flash y DeepSeek-V3-0324 por ayudarme a encontrar errores

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---