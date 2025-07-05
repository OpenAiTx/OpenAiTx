<h1 align="center">Bienvenido a&nbsp;&nbsp;Cursor Auto Helper 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-2.3.0-blue.svg?cacheSeconds=2592000" />
  <img alt="License: MIT" src="https://img.shields.io/badge/License-MIT-yellow.svg" />
  <img alt="Cursor Version" src="https://img.shields.io/badge/Cursor-0.48.x%20%E8%87%B3%201.0.0-blue.svg" />
</p>

> Herramienta de continuación automática de Cursor, reintento automático de Cursor, confirmación automática de Cursor, estadísticas de uso de Cursor, herramienta de mejora de Cursor, herramienta auxiliar de Cursor, herramienta de automatización de Cursor, configuración de temas de Cursor, Cursor Auto Continue Tool, Cursor Auto Retry Tool, Cursor Auto Confirm Tool, Cursor Usage Statistics Tool, Cursor Efficiency Tool, Cursor Automation Tool, Cursor Theme Settings, Cursor after 25 tool calls, Cursor Tool Call Limit🔧🤖🚀
> 

## 🏠 [Página principal](https://github.com/pen9un/cursor-auto-helper)

Cursor Auto Helper es una herramienta de mejora automatizada diseñada especialmente para Cursor IDE, capaz de mostrar en tiempo real el uso, manejar automáticamente el límite de 25 conversaciones, fallos de conexión de red, avisos de confirmación y otros escenarios, haciendo tu experiencia de desarrollo más fluida.

**Demostración en video:** [Video de demostración de Cursor Auto Helper](https://www.bilibili.com/video/BV1cajKzCEzv/)

Con prompts de alta calidad y una buena planificación de los requerimientos del proyecto, este programa puede permitir que Cursor complete automáticamente un proyecto sin intervención humana.

> 🔒 **Compatibilidad de versiones**: Actualmente probado y desarrollado en Cursor 0.49.6 y Cursor 1.0.0, teóricamente compatible con Cursor 0.48.x - 1.0.0.

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper.png" alt="cursor-auto-helper" />

## 📖 Registro de cambios

- 2025-06-01 Lanzamiento de la versión v2.3, añade función de configuración de temas de Cursor, optimiza la estabilidad de la inyección de código, corrige la visualización de uso para coincidir con el formato oficial
- 2025-05-21 Lanzamiento de la versión v2.1, reestructura la arquitectura, soporta múltiples plataformas, añade función de visualización de uso en tiempo real, etc.
- 2025-04-25 Finalización de la versión v1.0, maneja automáticamente el límite de 25 conversaciones, fallos de conexión de red, avisos de confirmación y otros escenarios
- 2025-04-20 Inicio del proyecto

## 🌟 Mejores prácticas de Cursor Auto Helper

Nota: La siguiente documentación puede ser generada con la ayuda de IA como Cursor, pero debe ser verificada y ajustada manualmente.

**PASO 1:** Diseño detallado de los requerimientos del sistema del proyecto (cuanto más claros sean los requerimientos, mayor será la calidad del proyecto), redactar prompts de desarrollo de alta calidad para el proyecto **SYSTEM.md**

**PASO 2:** Basado en **SYSTEM.md** generar documentación de diseño de sistema de alta calidad **DESIGN.md**

**PASO 3:** Basado en **SYSTEM.md** y **DESIGN.md** generar documentación de planificación de desarrollo de alta calidad **TODOLIST.md**

**PASO 4:** Usar **Cursor Auto Helper**, especificar **SYSTEM.md**, **DESIGN.md**, **TODOLIST.md**, utilizar el prompt de retroalimentación automática, permitiendo que Cursor complete automáticamente el desarrollo del proyecto siguiendo el plan, hasta finalizarlo

**Prompt de retroalimentación automática de Cursor Auto Helper:**

```
@SYSTEM.md @DESIGN.md @TODOLIST.md Por favor, siga estrictamente el plan de desarrollo de TODOLIST para el desarrollo de las siguientes funciones, y actualice en tiempo real el registro del plan de desarrollo de TODOLIST. Después de completar cada tarea, pregúnteme "¿Desea continuar?" y cuando el proyecto esté finalizado, devuelva "El proyecto ha sido completado".
```

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/guide.png" alt="guide" />

## 🚀 Instrucciones de uso

Te invitamos a dar una estrella para apoyar el proyecto. Si tienes algún problema, por favor abre un [Issue](https://github.com/pen9un/cursor-auto-helper/issues).

### 📝 Descripción del archivo de configuración

El archivo de configuración `config.ini` **se utiliza para personalizar el comportamiento automatizado** (puede configurarse y probarse según sea necesario), admite las siguientes opciones de configuración:

#### Configuración básica
```ini
[common]
log_enable = true     # Habilitar el registro; si no desea registrar logs, cambie a false

[cursor]
path = C:\Path\To\Cursor.exe  # Ruta de instalación de Cursor IDE. El programa buscará automáticamente la ruta de Cursor. Si no se encuentra, aparecerá un aviso; solo modifique este campo.
```

#### Configuración de acciones automáticas
Cada acción automática utiliza como prefijo `nombre_de_accion.`, y admite los siguientes campos:

- `type`: Tipo de acción
  - `click`: Hacer clic en un botón
  - `input_and_submit`: Ingresar y enviar

- `text` / `text_list`: Contenido de texto a coincidir
  - `text`: Cadena única
  - `text_list`: Múltiples cadenas separadas por |; si la página contiene cualquiera, se activa

- `button_selector`: Selector CSS del botón a hacer clic (solo necesario para tipo `click`)
- `button_text`: Texto del botón (opcional, para restringir aún más el botón)
- `input_box_selector`: Selector CSS del cuadro de entrada (necesario para tipo `input_and_submit`)
- `input_content`: Contenido que se debe ingresar automáticamente
- `submit_btn_selector`: Selector CSS del botón de envío
- `delay`: Retardo antes de ejecutar la acción (milisegundos), puede usarse para esperar a que la página se renderice

##### Ejemplo de configuración
```ini
[auto_actions]
# Reintento automático al fallar la conexión
action_retry.type = "click"
action_retry.text = "Connection failed. If the problem persists, please check your internet connection or VPN"
action_retry.button_selector = "div.anysphere-secondary-button"
action_retry.button_text = "Try again"
action_retry.delay = 3000

# después de 25 llamadas a herramientas
action_continue.type = "input_and_submit"
action_continue.text_list = "agent after 25 tool calls"
action_continue.input_box_selector = ".full-input-box.undefined"
action_continue.input_content = "请继续"
action_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_continue.delay = 1000

# Confirmación automática de continuación
action_need_continue.type = "input_and_submit"
action_need_continue.text_list = "是否需要|是否继续|需要我|请告诉我"
action_need_continue.input_box_selector = ".full-input-box.undefined"
action_need_continue.input_content = "请继续后续开发，并实时记录更新开发进度"
action_need_continue.submit_btn_selector = ".codicon-arrow-up-two"
action_need_continue.delay = 1000
```

> **Nota:**
> 1. El nombre de cada acción (como `action_retry`, `action_continue`) se puede personalizar, pero todos los campos de la misma acción deben tener el mismo prefijo.
> 2. Se recomienda localizar los selectores CSS usando las herramientas de desarrollo del navegador para garantizar precisión.
> 3. Es necesario reiniciar el programa después de modificar el archivo de configuración para que los cambios tengan efecto.

## 🎯 Escenarios de aplicación

### 💼 Desarrollo de diálogos largos
- Manejo automático de la limitación de 25 diálogos, admite desarrollo continuo de diálogos largos, continúa automáticamente el flujo de diálogo, mejorando la eficiencia de desarrollo.

### 👥 Red inestable
- Detección automática de anomalías de red, reintento inteligente de conexión, recuperación automática del diálogo, garantizando la continuidad del desarrollo.

### 🏢 Escenarios de confirmación
- Reconocimiento inteligente de escenarios de confirmación, manejo automático de avisos de confirmación, reduciendo la intervención manual.

### 📚 Monitoreo de uso
- Estadísticas en tiempo real del número de diálogos, monitoreo del uso de Cursor, registro de datos de uso, optimización de la eficiencia de uso.

Visualización de uso en terminal:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-1.png" alt="cursor-auto-helper-1" />

Visualización de uso en Cursor IDE:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/cursor-auto-helper-logs.png" alt="cursor-auto-helper-logs" />

## 🌟Descripción de funciones

### 🤖Continuación automática de diálogos largos
- Manejo automático de la limitación de 25 diálogos de Cursor, soporta múltiples rondas de diálogos continuos.

### 🎨 Reintento automático de conexión
- Detección automática de fallos de conexión de red, reintento inteligente, monitoreo en tiempo real del estado de la conexión.

### 📱 Confirmación automática de avisos
- Reconocimiento inteligente de múltiples escenarios de aviso de confirmación, manejo automático de ventanas emergentes de confirmación.
- Soporta personalización de contenido de confirmación y respuestas, reduciendo la intervención manual.
- Configuración de reglas flexible, adaptándose a una variedad de procesos de desarrollo.

### 🛍️ Estadísticas de uso
- Estadísticas en tiempo real del número de diálogos y uso, registro automático de datos.
- Visualización de datos de uso, facilitando el análisis y la optimización.
- Soporta visualización de logs en color en terminal y panel de uso en IDE, mejorando la usabilidad.

### 💡 Sistema de registro
- Registro en múltiples niveles (DEBUG/INFO/SUCCESS/WARNING/ERROR/CRITICAL), salida en color en terminal.
- Archivos de registro generados automáticamente por fecha, soporta registro en archivos y panel de visualización con arrastrar y soltar.
- Panel en tiempo real para que los desarrolladores monitoricen y rastreen.

### 🔒 Compatibilidad de versiones y optimización de rendimiento
- Desarrollado sobre Cursor 0.49.6, funciones principales completamente probadas.
- Optimizado para versiones específicas, seguimiento continuo de actualizaciones de Cursor.
- Alta estabilidad, buena compatibilidad, adecuado para entornos de producción.

## 🔮Demostración de resultados

### 🤖 Continuación automática de diálogos

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-continue.png" alt="auto-continue" />

### 🚀 Demostración de finalización automática en Cursor

Desde los requisitos del proyecto hasta la implementación completa, sin intervención manual en todo el proceso:

<img src="https://raw.githubusercontent.com/pen9un/cursor-auto-helper/master/./resource/image/auto-complete.png" alt="auto-complete" />

## 🤝Autor

👤 **pen9un**

* Sitio web: https://github.com/pen9un/
* Github: [@pen9un](https://github.com/pen9un)

## ❤️Soporte

Si consideras útil este proyecto, por favor deja una pequeña estrella gratuita ⭐️⭐️

## ✨Historial de estrellas

[![Star History Chart](https://api.star-history.com/svg?repos=pen9un/cursor-auto-helper&type=Date)](https://star-history.com/#pen9un/cursor-auto-helper&Date)

## 💹 Contador de visitas

![Visitor Count](https://profile-counter.glitch.me/pen9un/count.svg) 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---