# Spicetify DJ Info

¡Bienvenido a la extensión Spicetify DJ Info! Esta extensión mejora tu experiencia con Spicetify proporcionando datos valiosos de análisis de cada canción, incluyendo Tonalidad, BPM, Popularidad y Año. Con esta extensión, puedes obtener una visión más profunda de tu biblioteca musical y descubrir canciones que encajen perfectamente en tu set de DJ o lista de reproducción.

## ⭐Características

- **Tonalidad:** Identifica la tonalidad de cada canción ya sea en la notación estándar (Dbm) o en el sistema Camelot (3B). El sistema Camelot simplifica la mezcla armónica al categorizar las tonalidades en grupos que son armónicamente compatibles. Esto permite transiciones más suaves entre canciones durante los sets de DJ o al crear listas de reproducción coherentes.
- **BPM ♫ (Pulsos Por Minuto):** Obtén el tempo de cada canción, que indica la velocidad o ritmo al que se reproduce la música. El BPM es útil para crear listas de reproducción con velocidades similares o para seleccionar canciones para actividades específicas.
- **Popularidad ♥:** Descubre qué tan populares son tus canciones accediendo a sus calificaciones de popularidad. Estos datos pueden ser útiles para entender la recepción general y popularidad de una pista.
- **Año:** Averigua cuándo se lanzaron tus canciones. Estos datos pueden ser útiles para crear listas de reproducción con canciones de un período específico.

![Captura de pantalla](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/playlist.png)
![Captura de pantalla](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/img/now-playing.png)

## 💻 Instalación

Copia `dist/djinfo.mjs` en el directorio de extensiones de tu [Spicetify](https://github.com/spicetify/spicetify-cli):

| **Plataforma** | **Ruta**                                                                             |
| -------------- | ------------------------------------------------------------------------------------ |
| **Linux**      | `~/.config/spicetify/Extensions` o `$XDG_CONFIG_HOME/.config/spicetify/Extensions/` |
| **MacOS**      | `~/.config/spicetify/Extensions` o `$SPICETIFY_CONFIG/Extensions`                   |
| **Windows**    | `%appdata%/spicetify/Extensions/`                                                   |

Después de colocar el archivo de la extensión en la carpeta correcta, ejecuta el siguiente comando para instalar la extensión:

```bash
spicetify config extensions djinfo.mjs
spicetify apply
```

O puede editar manualmente su archivo `config-xpui.ini`. Agregue los nombres de archivo de las extensiones deseadas en la clave extensions, separándolos con el carácter |.  
Ejemplo:  

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js|djinfo.mjs
```

Luego ejecute:

```bash
spicetify apply
```

**¡Puede causar problemas con las Calificaciones por Estrellas!**

## ❌ Desinstalación

Ejecute el siguiente comando para desinstalar la extensión (note el - al final):

```bash
spicetify config extensions djinfo.mjs-
spicetify apply
```

También puede editar manualmente su archivo `config-xpui.ini`. Simplemente elimine completamente el nombre del archivo de las extensiones.
Ejemplo:

```ini
[AdditionalOptions]
...
extensions = autoSkipExplicit.js|shuffle+.js|trashbin.js
```

Luego ejecuta:

```bash
spicetify apply
```

## ⚙️ Configuración

Tienes la opción de alternar la visibilidad de la información del DJ en la extensión. Por defecto, la información del DJ como la Tonalidad, BPM, Popularidad y Año se muestran para cada canción y también al lado de la canción que se está reproduciendo. Sin embargo, si prefieres una interfaz más limpia, puedes ocultar estos elementos por separado fácilmente.

Para alternar la visibilidad de la información del DJ, sigue estos pasos:

1. Abre Spotify
2. Localiza el ícono de menú en la esquina superior derecha de la interfaz (tu foto de perfil) y haz clic en el ícono
3. En el menú, encuentra la opción 'Info DJ'
4. En el submenú haz clic en el interruptor para ocultar o mostrar lo que desees
5. Haz clic en Aplicar Cambios para que tu configuración sea visible

## 📜 Registro de cambios

### V 2.4.0

- Actualizado a una API diferente
- Mejorado el estilo
- Añadidas nuevas opciones para nuevas funciones de audio

### V 2.3.3

- Corregido el spam en el registro

### V 2.3.2

- Corregido el diseño con la nueva interfaz de mezcla

### V 2.3.1

- Corregido el fallo de la API que rompía la extensión
- Eliminados Danceability y Energy porque no están disponibles en la nueva API
- Añadida una nueva interfaz para la Info DJ y mejorada la versión antigua, que aún puede usarse deshabilitando la interfaz enriquecida
- Corregido el almacenamiento en caché y migrado a un nuevo sistema que usa IndexedDB en lugar de LocalStorage
- Los nuevos colores de la tonalidad Camelot pueden personalizarse sobrescribiendo las variables CSS

### V 2.2.1

- Ahora finalmente funciona correctamente en recomendaciones
- La caché se mejoró considerablemente  
- Los datos se obtienen en lotes, solucionando la falta de datos debido a límites de tasa  
- Funciona nuevamente con la nueva interfaz de lista de reproducción  
- Mejora en el rendimiento de carga  
- Mejor registro de errores  
- Corrección de errores para #16, #23, #24 y #25  

### V 2.1.1  

- Se corrigieron los estilos en la sección de canciones recomendadas  

### V 2.1.0  

- Se añadió la opción de ver la información del DJ en la sección de canciones recomendadas  
- Se corrigió un error donde la información del DJ no aparecía en la sección de Discografía ([#2](https://github.com/L3-N0X/spicetify-dj-info/issues/2))  
- Se corrigió un error en la cola ([#9](https://github.com/L3-N0X/spicetify-dj-info/issues/9))  

### V 2.0.0  

- Mejora en el rendimiento al almacenar datos localmente para acelerar el tiempo de carga y reducir las llamadas a la API  
- Reestructuración del menú de Configuración para alternar la visibilidad de la información del DJ de forma más sencilla  

### V 1.1.0  

- Se añadió la opción para alternar Año, Popularidad, Bailabilidad y Tonalidad en la notación estándar  
- Corrección de errores  

## 🌐 Créditos y Agradecimientos  

Un gran agradecimiento a [obafgkmdh](https://github.com/obafgkmdh) y [FixeQD](https://github.com/FixeQD) por arreglar la extensión después de que la API interna fallara y por migrar toda la API a la basada en protobuf interna, además de añadir una mejor estructura de archivos con empaquetado.  

Y también gracias a [Golevka2001](https://github.com/Golevka2001) por la idea para una mejor alineación de la información del DJ en la lista de reproducción.  

Un gran agradecimiento a [duffey](https://github.com/Tetrax-10) por el código principal para mostrar algo en la lista de reproducción y el widget de reproducción actual.  

También gracias a [je09](https://github.com/je09) por contribuir con el código para mostrar tanto la notación estándar como el sistema Camelot para la tonalidad, así como la opción para mostrarlo en el lado izquierdo en reproducción actual.  

## 💬 Comentarios y Contribuciones  

Si encuentras algún problema o tienes sugerencias para mejorar esta extensión, no dudes en abrir un issue en el [repositorio de GitHub](https://github.com/L3-N0X/spicetify-dj-info). ¡Las contribuciones también son bienvenidas! Haz un fork del repositorio, realiza tus cambios y envía una pull request con tus mejoras.

## ⚖️ Licencia

Este proyecto está licenciado bajo la [Licencia MIT](https://raw.githubusercontent.com/L3-N0X/spicetify-dj-info/main/LICENSE.md). Siéntase libre de usar, modificar y distribuir el código según los términos de esta licencia.

---

¡Disfruta de una experiencia mejorada de análisis musical con la extensión Spicetify DJ Info! Si encuentras útil esta extensión, considera darle una ⭐️ en GitHub. ¡Gracias por usar DJ Info!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-06

---