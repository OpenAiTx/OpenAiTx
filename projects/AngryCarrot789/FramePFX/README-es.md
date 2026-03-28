# FramePFX

FramePFX es un editor de video no lineal de código abierto, escrito en C# usando Avalonia para la interfaz de usuario.

## Remake
Actualmente estoy trabajando en una reconstrucción completa (en la rama remake). Las principales diferencias son un nuevo motor de audio, reproducción basada en audio en lugar de video, y posicionamiento basado en TimeSpan en lugar de por cuadro.

# Documentación

Aquí hay algunos enlaces a los archivos de documentación, si quieres aprender más sobre el frontend y backend

[Sistema de plugins + API de FramePFX](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md)

[Sistema de Automatización/Animación](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Automation.md)

[Sistema de comandos, menú contextual, atajos](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Command%20System%20and%20Shortcuts.md)

[Sistema de renderizado](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Rendering.md)

[Resumen del sistema de atajos](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Shortcuts.md)

[Resumen de la UI](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/TheUI.md)

# Previsualizaciones

Esta es la última versión usando Avalonia:
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-06_17.33.20.png)

Aquí hay una vista previa del proceso de exportación. El botón de exportar está en Archivo>Exportar, especificas una ruta y luego haces clic en Exportar.
Para cancelar el render solo debes hacer clic en Cancelar en el diálogo detrás de la ventana de progreso de exportación

El panel gris debajo de "Exporter: FFmpeg" contiene detalles específicos del codificador
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-07_00.13.06.png)

## ¡Interfaz gráfica personalizable!
Los temas pueden personalizarse a tu gusto. Pueden guardarse en disco y modificarse dentro de la aplicación. Los temas incorporados 
(Oscuro y Claro) no deben modificarse porque los cambios no se guardan. Debes crear una copia y modificar esa copia en su lugar
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-29_08.30.49.png)

# Compilación
FramePFX asume que todo es de 64 bits --- ¡x86/32-bit/AnyCPU no funcionarán correctamente!

Los proyectos nativos se descargan y compilan automáticamente cuando construyes los proyectos C# por primera vez,  
sin embargo, si quieres que los clips de medios y la exportación funcionen, FFmpeg debe descargarse por separado.  
Aquí está la versión específica que funciona actualmente (solo Windows):  
https://github.com/BtbN/FFmpeg-Builds/releases/download/autobuild-2024-09-30-15-36/ffmpeg-N-117275-g04182b5549-win64-gpl-shared.zip

## Descargando  
Clona el proyecto recursivamente:

`git clone --recursive https://github.com/AngryCarrot789/FramePFX`

Si quieres instalar FFmpeg para usar clips de video y exportación con FFmpeg:  
- Crea la carpeta ffmpeg en la solución: `cd FramePFX && mkdir ffmpeg`  
- Desde el archivo descargado de ffmpeg, copia las 4 carpetas y el LICENCE.txt dentro de esa nueva carpeta ffmpeg

>Debería haber 8 archivos DLL en `\FramePFX\ffmpeg\bin`, y uno de ellos debería ser avcodec-61.dll. Si no es 61, tienes la versión incorrecta de FFmpeg.  
Puedes eliminar los archivos EXE si quieres, ya que no se usan

## Construir el proyecto  
- Abre FramePFX.sln. Obtendrás un error sobre el proyecto `portaudio` que no se cargó; Ignóralo, y construye la solución yendo al menú `Build` y haciendo clic en `Build Solution`

Con suerte, luego deberías poder ejecutar y modificar los proyectos FramePFX sin problema. Este proyecto usa Avalonia 11.2.2 y .NET 8 (C# 12).

>No modifiques el proyecto portaudio porque se genera automáticamente con cmake, por lo que tus cambios pueden ser sobrescritos.

### Comandos solo para Windows

Los proyectos en la solución usan comandos de Windows como mkdir y xcopy, que pueden no funcionar en otras plataformas.  
¡Siéntete libre de crear un pull request con una solución más multiplataforma!

### Posibles problemas de construcción  
A veces, la librería nuget SkiaSharp no copia los archivos de la librería skia a la carpeta bin cuando clonas este repositorio y lo construyes. Encontré 2 soluciones:  
- Copia `\packages\SkiaSharp.2.88.7\runtimes\win-x64\native\libSkiaSharp.dll` a la carpeta bin del editor.  
- O, elimina la carpeta `packages` en el directorio de la solución, luego haz clic derecho en la solución en Visual Studio y selecciona "Clean Solution", después haz clic en Restaurar paquetes Nuget, y vuelve a construir todo.  
  Si ninguna de estas funciona, intenta desinstalar SkiaSharp en el gestor de Nuget y luego reinstalarlo. Si aún así no funciona, realmente no sé qué está pasando...

# ¡Plugins!  
¡FramePFX ahora soporta plugins! La API de plugins está muy en desarrollo, pero puede cargar plugins.  
Actualmente los plugins deben compilarse usando las mismas versiones de dependencias que usa FramePFX, ya que no usamos AssemblyLoadContext

Puedes encontrar más información aquí: [Sistema de plugins + API de FramePFX](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/docs/Plugins.md) 

### Ejemplos
El plugin `AnotherTestPlugin` añade una página de configuración de prueba (que se encuentra en `Archivo > Abrir configuración del editor`), y también añade un exportador de prueba inútil al diálogo de exportación.

Agregar la página es muy simple y se puede hacer desde el controlador `OnApplicationLoaded` del plugin:

```cs
public override async Task OnApplicationLoaded() {
    ApplicationConfigurationManager.Instance.RootEntry.AddEntry(new ConfigurationEntry() {
        DisplayName = "Test Plugin Settings", 
        Id = "config.testplugineditorsettings",
        
        // This page is just a PropertyEditor page. 
        // Completely custom xaml pages are a bit wonky at the moment, 
        // only user controls will work properly due to resource dictionaries
        Page = new TestPluginConfigurationPage()
    });
}
```
Esto resulta en:  
![](https://raw.githubusercontent.com/AngryCarrot789/FramePFX/master/FramePFX-DesktopUI_2024-12-27_03.33.53.png)  

# TODO  
### Remake de Avalonia:  
- Implementar la interfaz para la lista de Efectos que se puedan soltar en un clip/pista  
### Motor de Renderizado  
- Aunque tenemos acceso a port-audio, creo que todo el motor de renderizado necesita una revisión.  
  Anteriormente, se renderizaba audio extrayendo un número exacto de bytes de un clip basado en la  
  tasa de cuadros del proyecto. Sin embargo, esto produce muchos crujidos ya que los FPS de reproducción no son exactamente precisos.  

  También es necesario rehacer el renderizado de video, ya que el puerto de visualización suele ser bastante pequeño, pero estamos renderizando cuadros de video  
  de tamaño completo de cada clip y luego simplemente escalándolos hacia abajo. Esto no es tan malo para, digamos, rectángulos y formas primitivas básicas.  
  Sin embargo, renderizar un cuadro de video 4K desde un archivo MP4 es una tarea larga y desagradable, luego escalar a 1080p (o al MediaScale del clip)  
  y finalmente hacia el puerto de visualización (típicamente alrededor de 500x300) al final es simplemente un gran desperdicio, así que necesitamos métodos RenderFull y  
  RenderPreview, o un nuevo sistema de renderizado. La técnica actual de renderizado asíncrono no parece tan mala.  
### Motor de Automatización  
- Añadir soporte para interpolación suave (por ejemplo, una curva entre 2 fotogramas clave). Intenté hacerlo, pero tuve dificultades para entender las matemáticas para la interpolación, y también para hacer las pruebas de impacto en la interfaz de usuario.  
### Clips  
- AVMediaVideoClip es extremadamente lento para videos de alta resolución (por ejemplo, 4K tarda alrededor de 40 ms en decodificar y renderizar en pantalla),  
  y solo algunos códecs de video parecen funcionar. Muchos formatos comunes dan un error como "datos inválidos encontrados durante la decodificación".  
  No conozco mucho FFmpeg, pero espero arreglar esto en algún momento.  
- Implementar fundidos entre 2 clips  
### Sistema de Historial  
- Aún no hay funcionalidad de deshacer. Podría intentar implementarla una vez que implemente algunas de las otras funciones como audio y quizás ensamblaje acelerado por hardware del cuadro final en el renderizador.  
### Errores a corregir  
- Importar ciertos archivos de video puede causar que el renderizado falle (algún tipo de error "datos inválidos encontrados durante la decodificación")  
### Sincronización multihilo  
- Necesitamos crear bloqueos para hacer el acceso y la modificación del estado de la aplicación más seguros, especialmente ahora que el sistema de actividad funciona.  
  
  Quizás un bloqueo a nivel de aplicación para escribir en el estado de los modelos? Esto es similar a cómo funciona IntelliJ IDEA; un bloqueo mayormente de lectura, lectura-escritura.  
  Los bloqueos de escritura solo pueden adquirirse en el hilo principal (usamos el despachador para acceder allí), pero cualquier hilo puede tomar el bloqueo de lectura. Tomar el  
  bloqueo de lectura requiere bloquear hasta que no haya operaciones de escritura pendientes, y tomar el bloqueo de escritura requiere bloquear hasta que todos los lectores hayan terminado (y  
  también hay un evento disparado al intentar adquirir el bloqueo de escritura, para permitir que los lectores cancelen sus operaciones y evitar congelar la interfaz de usuario).  

## Contribuciones  
¡Las contribuciones son bienvenidas con los brazos abiertos! Simplemente crea un pull request, o un issue y luego un PR, lo que prefieras.  
Puedes encontrar información sobre cómo compilar y ejecutar/depurar la aplicación si desplazas un poco hacia arriba.  
La lista de TODO está arriba, pero también puedes buscar `// TODO:` en la base de código.


Puedes encontrar explicaciones detalladas en la carpeta docs, que explica las partes centrales del editor (como los
comandos, la automatización, etc.). Todavía hay mucho por documentar, por lo que no explica todo

La base de código no es perfecta, ¡así que siéntete libre de ayudar a intentar estandarizar las cosas!

# Licencia
Todos los archivos fuente en FramePFX están bajo la Licencia Pública General GNU versión 3.0 o posterior (GPL v3.0+).
FramePFX usa bibliotecas que tienen otras licencias, como licencias MIT/LGPL.

Si algún archivo fuente carece de aviso de copyright, se asume que está licenciado bajo la misma
licencia que FramePFX

Actualmente, las partes LGPL usadas son:
- FFmpeg.AutoGen, que está licenciado bajo la Licencia Pública General Reducida GNU versión 3.0 (LGPL v3.0)
- FFmpeg


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---