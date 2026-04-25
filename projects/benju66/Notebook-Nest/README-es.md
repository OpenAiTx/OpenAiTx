# NotebookLM Pro Tree

Una extensión de Chrome que transforma el NotebookLM de Google de una simple lista a un robusto Panel de Gestión de Proyectos.

Deja de desplazarte por listas interminables y planas. Organiza tus fuentes en árboles anidados, gestiona proyectos complejos con tareas avanzadas, flujos de trabajo multi-ventana y enfócate con el Modo Zen.



## Advertencias Críticas ⚠️

Desinstalar Elimina Datos: Esta extensión usa Almacenamiento Local por privacidad y velocidad. Si eliminas/desinstalas la extensión, tus carpetas y tareas serán eliminadas instantáneamente por Chrome.

Solución: Siempre usa el botón Exportar para guardar un archivo JSON de respaldo antes de reinstalar o cambiar a una nueva computadora.

Actualizaciones de Google y Confiabilidad: Esta extensión funciona "leyendo" el sitio web de NotebookLM. Si Google actualiza su sitio, esta extensión podría dejar de funcionar.

Descargo de responsabilidad: Al ser un proyecto gratuito y de código abierto mantenido en mi tiempo libre, no puedo garantizar correcciones inmediatas si Google cambia su código. Usa esta herramienta como un complemento útil, pero mantén tus datos importantes respaldados.

## Estado del Proyecto y Descargo de responsabilidad 🚧
Por favor Lee: Soy un Gerente de Proyectos de Construcción, no un desarrollador de software profesional. Construí esta herramienta porque la necesitaba para mi flujo de trabajo diario.

"Funciona en Mi Máquina": Esta actualización (v17.9) es estable para mi uso personal, pero no ha sido probada en todas las configuraciones posibles de navegador.

Funciones Experimentales: El sistema multi-ventana y los observadores DOM son complejos. Puede que encuentres errores que no he detectado.

Comentarios: Si encuentras un error, ¡por favor abre un issue en GitHub!

## Novedades en v17.9: La Suite de Productividad 🚀
Transformó NotebookLM en un espacio de trabajo multi-ventana. Esta actualización (consolidando v17.6–v17.9) trae grandes mejoras en el flujo de trabajo:

Notas Emergentes: Abre cualquier nota en una ventana flotante para referencia lado a lado mientras escribes. Las ventanas emergentes preservan el formato (solo lectura) y se sincronizan con tu tema Claro/Oscuro.

Tareas Inteligentes y Captura Rápida: Selecciona texto en cualquier nota para ver instantáneamente un botón "Crear Tarea". Esto crea una tarea vinculada directamente a esa nota fuente.

Gestión Avanzada de Tareas: Organiza tareas en Secciones Personalizadas (grupos plegables), añade Fechas de Vencimiento con opciones de selección rápida e incluye Descripciones enriquecidas.

Estabilidad Elegante: Un nuevo motor de auto-reparación que desactiva funciones específicas rotas individualmente en vez de bloquear toda la extensión si Google actualiza su código.

## Características
**Productividad y Flujo de Trabajo** 📋
*   **Flujo de trabajo multi-ventana** — Haz clic en el icono "Desplegar" en cualquier nota del panel Studio para abrirla en una ventana separada. Perfecto para configuraciones de doble monitor.

*   **Gestor de tareas integrado** — Una herramienta completa de gestión de proyectos incorporada en la interfaz:
    *   **Secciones:** Agrupa tareas por fase (por ejemplo, "Investigación", "Redacción", "Revisión").
    *   **Enlaces inteligentes:** Las tareas creadas desde notas incluyen un icono de "Enlace" que filtra tu vista hacia la fuente original.
    *   **Prioridades:** Marca tareas (Rojo/Amarillo/Azul) y ordena por Prioridad o Fecha de Entrega.

*   **"Modo Zen"** — Alterna la interfaz para ocultar el chat de IA y las barras laterales para un estudio de lectura/escritura sin distracciones.


 **Organización** 📂

*   **Carpetas anidadas** — Crea estructuras profundas para Fuentes, Notas y Artefactos Generados (Resúmenes de Audio, Preguntas Frecuentes, etc.).

*   **Fijar** — Mantén contratos o especificaciones críticas fijadas en la parte superior de tus listas.

*   **Codificación por colores** — Asigna colores a las carpetas para organización visual.

*   **Selección masiva** — Casillas maestras para seleccionar/deseleccionar todas las fuentes en una carpeta o en todo el cuaderno al instante.


**Búsqueda profunda** 🔍 

*   **Indexación de contenido** — Busca el texto real dentro de tus notas, no solo los títulos.

    > **Nota:** La indexación ocurre de forma pasiva cuando abres una nota.

*   **Compresión inteligente** — Utiliza compresión LZ-String para almacenar hasta 5MB de datos del índice de búsqueda localmente sin afectar el rendimiento.


**Confiabilidad** 🛡️ 

*   **Arquitectura local-primero** — Cero latencia de red. Todos los datos viven en tu dispositivo.

*   **Degradación gradual** — Si una función falla debido a una actualización del sitio web, el resto de la extensión sigue funcionando.

*   **Diálogos con estilo** — Diálogos de confirmación suaves y tematizados (no más ventanas emergentes abruptas del navegador).

> **Nota:** Cada cuaderno tiene sus propios datos independientes. Las Tareas y Carpetas creadas en "Proyecto A" no saturarán "Proyecto B."

## Instalación
### Cargar sin empaquetar (Modo desarrollador)

1.  Descarga o clona este repositorio.
2.  Abre Chrome y ve a `chrome://extensions`.
3.  Activa el **Modo desarrollador** (interruptor en la esquina superior derecha).
4.  Haz clic en **Cargar sin empaquetar**.
5.  Selecciona la carpeta que contiene estos archivos de la extensión.
6.  ¡Navega a NotebookLM y comienza a organizar!

## Uso
Una vez instalado, verás una nueva interfaz de "Panel de Proyectos" integrada en NotebookLM:

*   **Captura rápida:** Resalta texto en cualquier nota -> haz clic en el botón flotante + para convertirlo en una tarea.

*   **Ventana emergente:** Pasa el cursor sobre una nota en el panel Studio -> haz clic en el ícono de Nueva ventana.

*   **Detalles de la tarea:** Haz clic en el ícono de Descripción en una tarea para agregar notas o contexto.

*   **Acciones masivas:** Usa las casillas de las carpetas para activar o desactivar múltiples fuentes para la ventana de contexto de IA.

*   **Exportar/Importar:** Usa estos botones para respaldar tu estructura o moverla a una computadora nueva.

## Guía de almacenamiento y datos 💾 
**Dónde viven tus datos**

Debido a que la versión 17.9 prioriza la velocidad y la privacidad, tus datos se almacenan en tu dispositivo:

*   **Almacenamiento local:** Carpetas, Tareas, Configuraciones e Índice de búsqueda.

*   **Sin sincronización automática:** Las carpetas no se sincronizan automáticamente entre computadoras.

*   **Mover datos:** Para trasladar tu configuración a una laptop, usa el botón Exportar para obtener un archivo JSON y luego Importa en la nueva máquina.

> **Advertencia:** Si borras los "Datos del sitio" o las "Cookies" de Chrome, perderás tus carpetas. Realiza copias de seguridad regularmente.

## Privacidad y seguridad



**Esta extensión es Local-First:**

*   **Todos los datos se almacenan en el almacenamiento local de tu navegador.**

*   **No se envían datos de análisis ni de uso al desarrollador.**

*   **Código abierto:** Puedes inspeccionar el código para verificar que ningún dato salga de tu máquina.

Consulta [PRIVACY_POLICY.md](https://raw.githubusercontent.com/benju66/Notebook-Nest/main/PRIVACY_POLICY.md) para más detalles.

## Limitaciones conocidas

*   **Edición emergente:** Las ventanas emergentes actualmente son de solo lectura. Debes usar la ventana principal para editar texto.

*   **Subrayado:** El subrayado del contenido en una nota no es persistente (esto es un problema de Google NotebookLM, no de la extensión).

*   **Modo incógnito:** El sistema de memoria de la extensión está deshabilitado en modo incógnito.


## Contribuciones
¿Encontraste un error o tienes una solicitud de función? Abre un issue o envía un PR.

## Autor
Benju66

## Licencia
Licencia GPLv3

Este programa es software libre: puedes redistribuirlo y/o modificarlo bajo los términos de la Licencia Pública General de GNU publicada por la Free Software Foundation, ya sea la versión 3 de la Licencia, o (a tu elección) cualquier versión posterior.


Nota: Esto asegura que cualquier mejora hecha a este proyecto debe ser compartida con la comunidad.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-25

---