# 🐋 Qwen Image Integrated KSampler

[![GitHub](https://img.shields.io/badge/GitHub-luguoli-orange)](https://github.com/luguoli)
[![ComfyUI](https://img.shields.io/badge/ComfyUI-CustomNode-blue)](https://github.com/comfyanonymous/ComfyUI)

[English](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-en.md) | **[简体中文](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-zh.md)**

QwenImageIntegratedKSampler

Este es un nodo integrado de muestreo de generación de imágenes ComfyUI Qwen-Image, que soporta Z-Image. En comparación con el uso del KSampler oficial, elimina el cableado desordenado, soporta tanto la generación de texto a imagen como de imagen a imagen, soluciona los problemas de desplazamiento de los nodos oficiales, e integra cuadro de entrada de prompt, escalado automático de imágenes, limpieza automática de memoria/VRAM, generación por lotes, guardado automático y otras funciones de optimización integrales, para que mamá ya no tenga que preocuparse por mi cableado desordenado~~~~

#### ¡Si este proyecto te ayuda, por favor dale una ⭐Estrella — eso me hace saber que hay humanos usándolo!

## 🏆 Características

### 🎨 Modos de Generación Soportados
- **Z-Image**: Soporta modelo Z-Image
- **Texto a Imagen**: Genera imágenes a partir de prompts de texto
- **Imagen a Imagen**: Genera basado en imágenes de referencia, edición de imágenes, soporta hasta 5 imágenes

### ⚡ Optimizaciones Avanzadas
- **Optimizar Problemas de Desplazamiento**: Soluciona problemas de desplazamiento de los nodos oficiales, y sigue mejor las instrucciones
- **Algoritmo de Muestreo Integrado (AuraFlow)**: Integra el nodo Algoritmo de Muestreo (AuraFlow), sin cableado adicional necesario
- **Integración CFGNorm**: Integra nodo CFGNorm, sin cableado adicional necesario

### 🖼️ Procesamiento de Imágenes
- **Cuadro de Entrada de Prompt Integrado**: Integra cuadro de entrada de prompt, sin cableado adicional necesario
- **Múltiples Imágenes de Referencia**: Soporta hasta 5 imágenes de referencia para generación condicional
- **Escalado Automático de Imágenes**: Mantiene la relación de aspecto al redimensionar a dimensiones objetivo

- **Soporta Control de ControlNet**: Conexión adicional a [🐋 Qwen ControlNet Integrated Loader] para pose, profundidad y otros controles

### 🔧 Mejora de Productividad
- **Generación por Lotes**: Genera múltiples imágenes en una sola operación
- **Limpieza Automática de VRAM**: Opciones automáticas de limpieza para memoria GPU/VRAM
- **Limpieza Automática de RAM**: Opciones automáticas de limpieza para memoria RAM
- **Guardado Automático de Resultados**: Guarda automáticamente las imágenes generadas en carpeta especificada
- **Notificación Sonora de Finalización**: Reproduce aviso de audio después de completar la generación

## 🍧 Mostrar Comparación
### 🔄 Comparación de Complejidad del Flujo de Trabajo
- **❌ Flujo de trabajo sin usar [Qwen Image Integrated KSampler] (complicado, demasiados nodos, demasiados cables)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-1-en.png)
- **✅ Flujo de trabajo usando [Qwen Image Integrated KSampler] (extremadamente simple, un solo nodo, casi sin cables)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-2-en.png)

### 🖼️ Comparación del Efecto de la Imagen Generada
- **❌ Flujo de trabajo sin usar [Qwen Image Integrated KSampler] (desplazamiento y escalado evidentes)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-1.png)
- **✅ Flujo de trabajo usando [Qwen Image Integrated KSampler] (sin desplazamiento ni escalado)**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-2.png)

## 📦 Método de Instalación

### Método 1: A través de ComfyUI Manager (Recomendado)
1. Abre ComfyUI Manager en la interfaz de ComfyUI
2. Busca "ComfyUI-Qwen-Image-Integrated-KSampler"
3. Haz clic en Instalar

### Método 2: Instalación Manual
1. Navega al directorio de nodos personalizados de ComfyUI:
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   ```

2. Clona el repositorio:
   ```bash
   git clone https://github.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   or gitee repository:
   git clone https://gitee.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   ```

3. Instalar dependencias:
   ```bash
   pip install -r requirements.txt
   ```
4. Reiniciar ComfyUI

## 🚀 Método de Uso

### [Ejemplo de Flujo de Trabajo](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/workflow_example.json)

### Generación Básica de Texto a Imagen

1. Agregar el nodo "🐋 Qwen Image Integrated KSampler" al flujo de trabajo
2. Establecer `generation_mode` en "text-to-image"
3. Conectar las entradas requeridas:
   - Modelo (🤖 Model)
   - CLIP (🟡 Clip)
   - VAE (🎨 Vae)
4. Ingresar prompts positivos y negativos
5. Configurar ancho y alto (requerido para texto a imagen)
6. Configurar parámetros de muestreo (pasos, CFG, sampler, scheduler)
7. Ejecutar el flujo de trabajo

### Generación de Imagen a Imagen

1. Agregar el nodo al flujo de trabajo
2. Establecer `generation_mode` en "image-to-image"
3. Conectar al menos una imagen de referencia (🖼️ Image1)
4. Opcionalmente agregar hasta 4 imágenes de referencia adicionales
5. Ingresar prompts positivos/negativos e instrucciones
6. Establecer ancho/alto objetivo para escalado (opcional)
7. Configurar otros parámetros según sea necesario
8. Ejecutar el flujo de trabajo

### Control de ControlNet

1. Agregar el nodo [🐋 Qwen ControlNet Integrated Loader], conectar a [📦 ControlNet Data]

2. Conectar imágenes de control de pose y profundidad

3. Seleccionar modelo ControlNet, establecer tipo de control y fuerza

4. Ejecutar el flujo de trabajo


![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/3-en.png)

### Funciones Avanzadas

- **Gestión de Memoria**: Habilitar opciones de limpieza de GPU/CPU para mejorar la eficiencia de recursos
- **Procesamiento por Lotes**: Establecer batch_size > 1 para generación múltiple de imágenes
- **Guardado Automático**: Especificar carpeta de salida para guardado automático
- **Ajuste AuraFlow**: Ajustar auraflow_shift para balancear velocidad y calidad
- **Mejora CFG**: Estabilizador para CFG

## ⚠️ Notas

### 📝 Requisitos de Uso
- **Modo Texto a Imagen**: Debe establecer ancho (Width) y alto (Height), son parámetros obligatorios
- **Modo Imagen a Imagen**: Debe proporcionar al menos una imagen de referencia (Image1), soporta hasta 5 imágenes de referencia (Image1-Image5)

### 🎛️ Sugerencias para Configuración de Parámetros
- **Tamaño de Lote**: Elegir entre 1-10, ajustar según memoria GPU, se recomienda comenzar pruebas desde 1
- **Resolución (Ancho/Alto)**: Debe ser múltiplo de 8, rango 0-16384, se recomienda comenzar pruebas con resoluciones bajas (como 512x512)
- **Pasos de Muestreo**: Modelos Qwen recomiendan 4-20 pasos, demasiado alto puede aumentar tiempo de cálculo sin mejorar calidad
- **Valor CFG**: Rango 0-100, por defecto 1.0, se recomienda rango 1.0-7.0
- **Fuerza de Reducción de Ruido**: Rango 0-1, por defecto 1.0, puede disminuirse apropiadamente en modo imagen a imagen
- **Desplazamiento AuraFlow**: Rango 0-100, por defecto 3.0, usado para balancear velocidad y calidad de generación
- **Fuerza de Normalización CFG**: Rango 0-100, por defecto 1.0, estabilizador para CFG

### 🔧 Procesamiento de Imagen
- **Escalado Automático**: En texto a imagen se deben ingresar ancho y alto, en imagen a imagen se rellena para escalar automáticamente imágenes de referencia manteniendo proporción, configurar ancho o alto en 0 deshabilita el escalado
- **Orden de Imágenes de Referencia**: Soporta hasta 5 imágenes de referencia, procesadas en orden Image1-Image5, Image1 es la imagen principal
- **Formato de Imagen**: Soporta formatos estándar de entrada de imagen, maneja automáticamente dimensiones por lote

### 💾 Gestión de Memoria
- **Limpieza de Memoria GPU**: Habilitar opción enable_clean_gpu_memory, limpia VRAM automáticamente antes y después de la generación
- **Limpieza de Memoria CPU**: Habilitar enable_clean_cpu_memory_after_finish, limpia RAM tras completar generación (incluye caché de archivos, procesos, librerías dinámicas)
- Para generación continua a gran escala, se recomienda mantener siempre habilitadas opciones de limpieza para evitar desbordamiento de memoria

### 💾 Guardado Automático
- **Carpeta de Salida**: Configurar auto_save_output_folder para habilitar función de guardado automático, dejar en blanco para deshabilitar, soporta rutas absolutas y relativas
- **Nombrado de Archivos**: output_filename_prefix prefijo personalizado, por defecto "auto_save"
- El formato de guardado es PNG, el nombre de archivo incluye semilla y número de lote (ej.: auto_save_123456_00000.png)

### 🔊 Función de Notificación
- **Notificación Sonora**: Solo soportada en sistemas Windows

## 📝 Registro de Actualizaciones
### v1.0.6:
- **Script de Localización Añadido:** A partir de ComfyUI v0.3.68, los archivos de idioma chino dejaron de ser válidos. Se añadió un script de localización automática, haga doble clic en [自动汉化节点.bat] y reinicie ComfyUI, requiere instalar el plugin ComfyUI-DD-Translation


## 📞 Contacto para Personalización Especial 📞
- Autor: @luguoli（墙上的向日葵）
- Correo del Autor: luguoli@vip.qq.com


---

**Hecho con ❤️ para la comunidad de ComfyUI**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---