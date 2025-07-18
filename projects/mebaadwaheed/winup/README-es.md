<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![PRs Bienvenidos](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Arquitectura por Componentes](https://img.shields.io/badge/architecture-component--driven-orange)
![Aplicación de Escritorio](https://img.shields.io/badge/platform-desktop-lightgrey)
![Soporte CLI](https://img.shields.io/badge/CLI-supported-critical)
![Recarga en Vivo](https://img.shields.io/badge/live--reload-enabled-blue)

## Ejemplos de Imagen

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## ¡Asegúrate de descargar la Última Versión Estable (LSR) y no la última/LFR! LSR actual: 2.4.9

`pip install winup==2.4.9`

**Un framework ridículamente pythonico y potente para crear hermosas aplicaciones de escritorio.**

WinUp es un framework moderno de UI para Python que envuelve el poder de PySide6 (Qt) en una API simple, declarativa y amigable para desarrolladores. Está diseñado para que puedas crear aplicaciones más rápido, escribir código más limpio y disfrutar el proceso de desarrollo.

### ✨ ¡Ahora con Soporte Web!
WinUp ahora también soporta la creación de aplicaciones web totalmente interactivas y con estado usando el mismo enfoque centrado en Python y basado en componentes. El módulo web utiliza FastAPI y WebSockets internamente para llevar la simplicidad de WinUp al navegador.

[Documentación Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Aviso Legal:** El soporte web es una característica opcional. Para usarlo, debes instalar las dependencias web:
> ```bash
> pip install "winup[web]"
> ```

[Contribuir](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Registro de Cambios](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Licencia](LICENSE)

---

## ¿Por qué WinUp? (En vez de PySide6 puro o Tkinter)

El desarrollo de escritorio en Python puede sentirse torpe. WinUp fue creado para solucionar eso.

| Característica           | Forma WinUp ✨                                                                  | Forma PySide6 / Tkinter Pura 😟                                                                |
| ------------------------ | ------------------------------------------------------------------------------ | ---------------------------------------------------------------------------------------------- |
| **Layouts**              | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                     |
| **Estilos**              | `props={"background-color": "blue", "font-size": "16px"}`                      | Cadenas QSS manuales, `widget.setStyleSheet(...)`, objetos de estilo complejos.                |
| **Gestión de Estado**    | `state.bind(widget, "prop", "key")`                                            | Funciones de callback manuales, getters/setters, `StringVar()`, mucho código repetitivo.        |
| **Enlace Bidireccional** | `state.bind_two_way(input_widget, "key")`                                      | Inexistente. Requiere manejadores `on_change` manuales para actualizar estado y UI.             |
| **Herramientas Dev**     | **Recarga en Caliente integrada**, profiler de código y herramientas de ventana.| Inexistente. Reinicia toda la app por cada cambio en la UI.                                     |
| **Estructura de Código** | Componentes reutilizables y auto-contenidos con `@component`.                  | Suele llevar a clases monolíticas grandes o scripts procedimentales.                            |

**En resumen, WinUp proporciona las "características asesinas" de los frameworks web modernos (como React o Vue) para el escritorio, ahorrándote tiempo y permitiéndote enfocarte en lo que importa: la lógica de tu aplicación.**

# 🧊 WinUp vs 🧱 PyEdifice (Petición de usuario en Reddit)

| Característica                   | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Arquitectura                  | Estilo React + estado     | Estilo React + estado            |
| 🌐 Enrutamiento Integrado        | ✅ Sí (`Router(routes={...})`)        | ❌ No tiene enrutamiento integrado|
| ♻️ Ciclos de Vida                | ✅ `on_mount`, `on_unmount`, etc.     | ⚠️ Limitado (`did_mount`, etc.)   |
| 🎨 Temas / Sistema de Estilos    | ✅ Temas globales y locales           | ❌ Inyección manual de CSS         |
| 🔲 Opciones de Layout            | ✅ Fila, Columna, Grid, Stack, Flexbox| ⚠️ Mayormente Box y HBox/VBox      |
| 🎞️ Animaciones                  | ✅ Integradas (fade, scale, etc.)     | ❌ Ninguna integrada               |
| 🔁 Recarga en Caliente (LHR)     | ✅ Estable y rápida (`loadup dev`)    | ⚠️ Experimental, soporte limitado  |
| 📦 Empaquetado                   | ✅ Con LoadUp (basado en PyInstaller) | ❌ Debe integrar PyInstaller manualmente |
| 🧩 Reusabilidad de Componentes    | ✅ Alta, declarativa                  | ✅ Alta                            |

| 🛠 Herramientas para Desarrolladores | ✅ DevTools planeados, Inspector pronto  | ❌ Ninguno aún                       |
| 📱 Soporte móvil                    | ❌ Aún no                              | ❌ No soportado                      |
| 🧠 Curva de aprendizaje             | ✅ Fácil para usuarios de Python+React | ✅ Fácil pero con menos herramientas  |

> ✅ = Integrado o robusto  
> ⚠️ = Parcial o limitado  
> ❌ = Completamente ausente
---

## Funciones Principales

*   **UI Declarativa y Pythonica:** Construye diseños complejos con simples objetos `Row` y `Column` en lugar de diseños de cajas complicados.
*   **Arquitectura Basada en Componentes:** Usa el decorador `@component` para crear widgets de UI modulares y reutilizables a partir de funciones simples.
*   **Sistema de Estilos Potente:** Da estilo a tus widgets con simples diccionarios de Python usando `props`. Crea clases globales tipo "CSS" con `style.add_style_dict`.
*   **Shell de Aplicación Completa:** Crea aplicaciones profesionales con una API declarativa para `MenuBar`, `ToolBar`, `StatusBar` y `SystemTrayIcon`.
*   **Ejecución de Tareas Asíncronas:** Ejecuta operaciones de larga duración en segundo plano sin congelar tu UI usando el simple decorador `@tasks.run`.
*   **Rendimiento por Defecto:** Incluye un decorador opcional `@memo` para cachear renders de componentes y evitar cálculos innecesarios.
*   **Extensibilidad Avanzada:**
    *   **Fábrica de Widgets:** Reemplaza cualquier widget por defecto con tu propia implementación personalizada (por ejemplo, basada en C++) usando `ui.register_widget()`.
    *   **Ventanas Múltiples:** Crea y gestiona varias ventanas independientes para aplicaciones complejas como paletas de herramientas o reproductores de música.
*   **Gestión Reactiva de Estado:**
    *   **Enlace Unidireccional:** Actualiza automáticamente tu UI cuando cambian tus datos con `state.bind()`.
    *   **Enlace Bidireccional:** Sincroniza fácilmente widgets de entrada con tu estado usando `state.bind_two_way()`.
    *   **Suscripciones:** Ejecuta cualquier función en respuesta a cambios de estado con `state.subscribe()`.
*   **Herramientas Amigables para Desarrolladores:**
    *   **Recarga en Caliente:** Ve tus cambios de UI instantáneamente sin reiniciar tu app.
    *   **Perfilador:** Mide fácilmente el rendimiento de cualquier función con el decorador `@profiler.measure()`.
    *   **Herramientas de Ventana:** Centra, parpadea o gestiona la ventana de tu aplicación con facilidad.
*   **Enrutamiento Integrado:** Crea fácilmente aplicaciones multipágina con un router intuitivo y basado en estado.
*   **Capa de Datos Flexible:** Incluye conectores simples y consistentes para SQLite, PostgreSQL, MySQL, MongoDB y Firebase.

---

# Documentación

Profundiza en las funciones de WinUp:

## Conceptos Básicos
- [**Modelo de Componentes y Estilos**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Gestión de Estado**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Hooks de Ciclo de Vida**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Enrutamiento**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Posicionamiento Absoluto (Avanzado)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Herramientas de Desarrollo
- [**Recarga en Caliente en Vivo (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Perfilador de Rendimiento**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoización**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Ejecución de Tareas Asíncronas**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Componentes de UI
- [**Biblioteca Completa de Componentes**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Contribuir

WinUp es un proyecto de código abierto. ¡Las contribuciones son bienvenidas!

## Licencia

Este proyecto está licenciado bajo la Licencia MIT. Consulta **LICENSE** para más información.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---