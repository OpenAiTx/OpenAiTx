# Tema macOS para Joplin

Tema nativo con apariencia macOS para la aplicación de toma de notas [Joplin](https://joplinapp.org/) v2.2.4 y superior. También funciona en dispositivos que no son macOS.

![Tema macOS para Joplin](/images/macos-theme-for-joplin.png)

- ✨ Interfaz completamente estilizada, incluyendo todos los controles,
- 🌜 Elige entre claro, oscuro, claro con barra lateral oscura o automático (claro/oscuro basado en preferencias del sistema),
- 👌 Usa íconos nativos (solo macOS) o la familia de íconos Phosphor,
- 👨‍🎨 Fácil de personalizar vía las preferencias de Joplin.

## Instalación

- Abre las preferencias de Joplin › 'Plugins', busca 'macOS theme' e instala el tema.
- Reinicia Joplin. ¡Disfruta!

Asegúrate de configurar ‘Apariencia › Tema’ en ‘Claro’ o ‘Oscuro’. Si experimentas un parpadeo al cambiar de cuadernos, sincroniza la configuración Claro/Oscuro bajo ‘Apariencia › Tema’ con el valor seleccionado en ‘macOS theme › Apariencia’. Para más opciones de personalización, consulta abajo.

## Personalización

Después de instalar, encontrarás un ítem extra llamado 'macOS theme' en las preferencias de Joplin. Debes reiniciar Joplin para que los cambios se apliquen.

**Usuarios Mac**: Si quieres usar los íconos nativos, descarga e instala SF Pro desde el [sitio web de Apple aquí](https://developer.apple.com/fonts/).

## ¿No hay íconos?

**Usuarios Windows**: Si los íconos aparecen como cuadros vacíos o faltantes, necesitas instalar manualmente la fuente Phosphor. Descárgala en [phosphoricons.com](https://phosphoricons.com/) ([descarga directa](https://phosphoricons.com/assets/phosphor-icons.zip)), descomprime el archivo, instala `Fonts/regular/Phosphor.ttf` y reinicia Joplin.

**Usuarios Mac**: Si tienes la configuración 'Familia de íconos' en 'macOS nativo (SF Pro)', necesitas tener SF Pro instalado desde el [sitio web de Apple](https://developer.apple.com/fonts/). Nota que esto solo funciona en dispositivos macOS.

## Descargo de responsabilidad

⚠️ Joplin usa styled-components para el estilo, lo que hace muy difícil tematizar la app. Se usaron muchos trucos CSS y `!important`. Esto puede causar problemas de interfaz en futuras versiones de Joplin. Como solo es CSS, tus datos permanecen seguros y puedes revertir los estilos fácilmente.

No dudes en [crear un issue](https://github.com/ajilderda/joplin-macos-native-theme/issues) o publicar un mensaje [en el foro](https://discourse.joplinapp.org/t/plugin-macos-theme-for-joplin) si encuentras problemas.

## Ayuda, obtengo una pantalla en blanco después de instalar el plugin.

Si experimentas una pantalla en blanco tras instalar el plugin, probablemente sea por un problema con el manejo de emojis. Aquí te explicamos cómo solucionarlo:

1. Primero, localiza el directorio de configuración de Joplin:

   - macOS: `~/.config/joplin-desktop`
   - Windows: `%APPDATA%\Joplin`
   - Linux: `~/.config/Joplin`

2. Navega a la carpeta `plugins` y elimina el archivo `.jpl` del plugin de tema para macOS.
3. Reinicia Joplin.

### Prevención

Para evitar que este problema ocurra:

- En lugar de usar el diálogo "Elegir emoji..." de Joplin, añade emojis directamente en el cuadro de texto del título del cuaderno (consulta [esta discusión](https://github.com/andrejilderda/joplin-macos-native-theme/issues/96#issuecomment-1553517708) para una referencia visual).
- Ahora puedes reinstalar el plugin.

## Desarrollo

Puedes ajustar el tema a través de las preferencias de Joplin. Si quieres ir a fondo, sigue los siguientes pasos para crear tu propia versión.

Instala las dependencias:

```sh
npm install
```
Para construir el complemento:


```sh
npm run dist
```

Para actualizar el marco del complemento:

```sh
npm run update
```
Para compilar el CSS y vigilar los cambios:


```sh
npm run dev
```

El CSS generado estará disponible en: http://localhost:8080/macos-theme-for-joplin.css

## Contribuir

¡Las contribuciones (especialmente correcciones) son muy bienvenidas!

### Flujo de trabajo de desarrollo

Tener que reiniciar Joplin en cada cambio es un poco molesto. Para acelerar las cosas y acortar el ciclo de retroalimentación:

1. Ejecuta `npm run dev`. Esto vigilará los cambios en los archivos .scss y reconstruirá el CSS.
2. Activa las herramientas de desarrollo de Joplin (**Ayuda › Alternar herramientas de desarrollo**)
3. Elige uno de los dos métodos de actualización de [este gist](https://gist.github.com/andrejilderda/f6673f1b1a986b2dc0cd01607acbff26).
4. Pega y ejecuta el script en la consola de las herramientas de desarrollo para actualizar el CSS automáticamente.

Esto funciona bien la mayoría de las veces, pero ten en cuenta que en algunos casos los estilos cambiados interfieren con los estilos del plugin instalado. Para comprobar si ese es el caso, puedes asegurar un entorno limpio mediante:

1. Desinstalar el plugin del tema macOS si ya está instalado.
2. Ejecutar una compilación: `npm run build`
3. En Joplin, ve a **Plugins › Mostrar configuración avanzada**.
4. Bajo **Plugins de desarrollo**, pega la ruta a tu carpeta `dist`.
5. Reinicia Joplin para cargar tu compilación local del plugin.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-23

---