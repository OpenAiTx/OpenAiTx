# Extensión Guided Generations para SillyTavern

Esta extensión trae todo el poder del conjunto original de "Guided Generations" Quick Reply a SillyTavern como una extensión nativa. Proporciona herramientas modulares y conscientes del contexto para moldear, refinar y guiar las respuestas de la IA, ideal para chats de rol, historia y personajes. Todas las funciones son accesibles mediante botones y menús intuitivos integrados en la interfaz de SillyTavern.

Consulte [`JSDoc.md`](https://raw.githubusercontent.com/Samueras/GuidedGenerations-Extension/main/./JSDoc.md) para documentación a nivel de código.

---

## Tabla de Contenidos
- [Características](#features)
- [Instalación](#installation)
- [Uso](#usage)
- [Configuración](#settings)
- [Solución de Problemas](#troubleshooting)
- [Licencia](#license)
- [Contribución](#contributing)

---

## Características

### 🐕 Respuesta Guiada
*Inyecta instrucciones antes de que la IA responda.*
- Escribe instrucciones y presiona 🐕.
- Tus instrucciones guían la próxima respuesta de la IA.
- [Ejemplo en Video](https://youtube.com/shorts/yxdtbF3NxW4?feature=share)

### 👈 Deslizamiento Guiado
*Regenera el último mensaje de la IA con nueva orientación.*
- Introduce nuevas instrucciones y presiona 👈 para generar un nuevo deslizamiento.
- Solo disponible si el último mensaje es de la IA.
- [Ejemplo en Video](https://youtube.com/shorts/GRQ9l_8K6-Y?feature=share)

### Suplantación (1ra: 👤, 2da: 👥, 3ra: 🗣️)
*Expande esquemas en narrativas ricas y en personaje.*
- Introduce un esquema breve, selecciona la perspectiva (alternar en configuración) y presiona el botón correspondiente (👤/👥/🗣️).
- Tu esquema se expande en un mensaje completo desde el punto de vista elegido.
- Puede ocultarse o mostrarse individualmente según configuración. Por defecto se muestra la 1ra persona.
- Ejemplos en Video:
  - [1ra Persona](https://youtube.com/shorts/FT5gv3d2kE4?feature=share)
  - [2ª Persona](https://youtube.com/shorts/80l12LrtBpQ?feature=share)
  - [3ª Persona](https://youtube.com/shorts/wWka-1URLPg?feature=share)

### 📖 Menú de Guías Persistentes
*Gestiona el contexto persistente del escenario.*
- Haz clic en el botón 📖 para abrir el menú de guías persistentes.
- Selecciona un tipo de guía (ver abajo) para generar o gestionar contexto.

**Tipos de Guías:**
  - 🗺️ Situacional: Genera contexto a partir del chat reciente o enfoque del usuario.
  - 🧠 Pensamientos: Genera pensamientos del personaje (activación automática opcional).
  - 👕 Ropa: Describe los atuendos del personaje (activación automática opcional).
  - 🧍 Estado: Detalla posiciones/estado del personaje (activación automática opcional).
  - 📜 Reglas: Define o actualiza reglas dentro de la historia.
  - ➕ Personalizado: Inyecta contexto definido por el usuario.

**Acciones de Gestión:**
  - ✏️ Editar Guías: Modifica las inyecciones de guías existentes vía ventana emergente.
  - 👁️ Mostrar Guías: Muestra todas las guías activas.
  - 🗑️ Vaciar Guías: Elimina guías seleccionadas o todas.
- La activación automática para Pensamientos, Ropa y Estado se puede alternar en la configuración.

### 🔖 Menú de Herramientas
*Accede a utilidades adicionales*
  - **🔧 Correcciones:** Edita el último mensaje de la IA con instrucciones específicas.
  - **✅ Corrector Ortográfico:** Mejora tu entrada en gramática, puntuación y fluidez.
  - **✈️ Envío Simple:** Envía la entrada como mensaje de usuario sin activar respuesta del modelo.
  - **🖋️ Editar Introducciones:** Reescribe o transforma mensajes introductorios bajo demanda.
  - **↩️ Recuperar Entrada:** Restaura la entrada previamente borrada.

---

## Instalación

1. **Instalar la Extensión:**
   - En el Gestor de Extensiones haz clic en Instalar Extensión e ingresa https://github.com/Samueras/GuidedGenerations-Extension/ como el GITHUB


---

## Uso

- Todas las funciones principales aparecen como botones junto al botón de enviar o en el menú de engranaje del lado izquierdo.  
- Las descripciones emergentes y los menús contextuales ofrecen orientación y acceso rápido a funciones avanzadas.  
- Consulte la configuración dentro de la aplicación para alternar funciones y configurar la guía automática.  
- Para detalles técnicos completos, vea [`JSDoc.md`](https://raw.githubusercontent.com/Samueras/GuidedGenerations-Extension/main/./JSDoc.md).  

---

## ⚙️ Configuración

Todas las configuraciones de la extensión se gestionan mediante el panel de Configuración de Extensiones de SillyTavern:

- **Activación Automática**: activar o desactivar la ejecución automática de:  
  - Guía de Pensamiento  
  - Guía de Estado  
  - Guía de Ropa  

- **Visibilidad de Botones**: mostrar u ocultar botones de acción:  
  - Personificación en 1ª Persona (👤)  
  - Personificación en 2ª Persona (👥)  
  - Personificación en 3ª Persona (🗣️)  
  - Respuesta Guiada (🐕)  
  - Deslizamiento Guiado (👈)  
  - Menú de Guías Persistente (📖)  

- **Rol de Inyección**: seleccionar el rol (`system`, `assistant` o `user`) usado al inyectar instrucciones.  

- **Modo Depuración**: al activarlo, muestra información detallada de depuración en la consola del navegador. Útil para resolver problemas, pero puede saturar la consola en uso normal.  

- **Preajustes**: para cada guía/herramienta (Ropa, Estado, Pensamiento, Situacional, Reglas, Personalizado, Correcciones, Corrector Ortográfico, Editar Introducciones, Personificación 1ª/2ª/3ª), elija cualquier preajuste de SillyTavern. Antes de ejecutar una guía/herramienta, la extensión cambiará a ese preajuste (y su API/modelo configurado), ejecutará la acción y luego restaurará su preajuste anterior, permitiendo distintos modelos por guía.  

- **Sobrescrituras de Prompt**: personalice la plantilla de prompt bruto para cada guía/herramienta. Use `{{input}}` para su texto de entrada y otros marcadores según se soporten. Las sobrescrituras aplican a:  
  - Prompt de Guía de Ropa  
  - Prompt de Guía de Estado  
  - Prompt de Guía de Pensamiento  
  - Prompt de Guía Situacional  
  - Prompt de Guía de Reglas  
  - Prompt de Correcciones  
  - Prompt de Corrector Ortográfico
  - Suplantar indicaciones en 1ª/2ª/3ª persona  
  - Indicaciones de respuesta guiada  
  - Indicaciones de deslizamiento guiado  

---

## Solución de problemas

- **Botones faltantes:** Asegúrate de que SillyTavern esté actualizado (v1.12.9+) y que LALib esté instalado/habilitado.  
- **Menús contextuales que no aparecen:** Intenta cambiar de chat o volver a agregar la extensión en el menú de Respuestas rápidas.  
- **Otros problemas:** Reinicia SillyTavern, verifica actualizaciones y consulta la [documentación de SillyTavern](https://github.com/SillyTavern/SillyTavern).  

---

## Licencia

Este proyecto está licenciado bajo la Licencia Pública General GNU v3.0. Consulta el archivo [LICENSE](LICENSE) para más detalles.  

---

## Contribuciones

¡Las contribuciones son bienvenidas! Envía solicitudes de extracción o abre incidencias para mejoras, nuevas funciones o documentación. Para preguntas o comentarios, abre una incidencia en este repositorio.  

---

## ❤️ Apoya el proyecto

Si encuentras útil esta extensión, por favor considera apoyar mi trabajo:  

- [☕ Cómprame un café en Ko-fi](https://ko-fi.com/samueras)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---