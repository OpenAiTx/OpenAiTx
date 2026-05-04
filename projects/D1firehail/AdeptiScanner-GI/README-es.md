# AdeptiScanner-GI
Escáner de inventario basado en OCR para Genshin Impact, con modo manual y automático.

### _Por favor, lea las instrucciones a continuación antes de usar. El enlace de descarga para la última versión se puede encontrar [aquí](https://github.com/D1firehail/AdeptiScanner-GI/releases)_

AdeptiScanner requiere algunas herramientas producidas por Microsoft para funcionar, son comúnmente usadas en juegos, por lo que es probable que ya las tengas.
 - Si el escáner lanza un error al iniciar, puede que te falten. [Los enlaces para descargar sus instaladores se encuentran aquí](https://docs.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170#visual-studio-2015-2017-2019-and-2022). ***Necesitas ambos, x86 y x64***

## Advertencias y notas importantes
- ***Para que el modo de escaneo automatizado de este programa funcione, necesita ejecutarse como administrador.***
- Mientras uses el modo automático, el programa tomará control de tu ratón. Puedes presionar escape durante el escaneo para pausarlo. No muevas ni uses tu ratón durante el modo automático a menos que esté pausado.
- Según mi interpretación de los [TOS de Genshin](https://genshin.mihoyo.com/en/company/terms), el uso de este escáner debería estar permitido ya que no creo que cause una ventaja competitiva injusta. Hasta donde sé, nadie ha tenido problemas por usar este u otros programas similares, pero si te preocupa, te sugiero evitar el modo automático.
- AdeptiScanner se basa en valores específicos de color para identificar el contenido de la imagen
    - Cualquier cosa que cambie los colores del juego puede alterar los resultados. Ejemplos de programas/características que pueden interferir son Reshade, Luz Nocturna de Windows, F.lux, Filtros Nvidia y herramientas de compensación para daltonismo.
    - El enfoque de imagen también afecta los colores de esta manera. El ejemplo más común es el "Enfoque de Imagen Radeon" en el software AMD Radeon.

## Actualización para una nueva versión
- Hay un verificador de actualizaciones opcional dentro de la aplicación, que puede notificarte sobre actualizaciones de datos del juego y del escáner
  - Las actualizaciones de datos del juego se pueden gestionar con un solo clic
  - Las actualizaciones del escáner abrirán la página de descarga de la nueva versión y exportarán tus configuraciones para que la nueva versión pueda importarlas la próxima vez que la ejecutes
- Puedes actualizar manualmente los datos del juego reemplazando el archivo `ArtifactInfo.json` dentro de `ScannerFiles` con uno actualizado. La última versión se encuentra [aquí](https://raw.githubusercontent.com/D1firehail/AdeptiScanner-GI/master/AdeptiScanner%20GI/ScannerFiles/ArtifactInfo.json)

## Modo Arma
- El modo arma se usa igual que el modo regular (Artefacto)
- Se recomienda ordenar tu lista de armas por nivel, para evitar perder armas de baja rareza que realmente te importen
- Al usar la funcionalidad automática en modo arma, el escaneo se detendrá cuando ***todas*** las armas en una página sean idénticas a una ya escaneada, a diferencia de cuando ***una*** lo es en modo artefacto

## Importación de personajes vía enka.network
1. (opcional) Escanea tus artefactos y/o armas
   - Esto permite que AdeptiScanner muestre qué personajes tienes pero aún no has importado
2. Asegúrate de que tu vitrina de perfil esté configurada para mostrar detalles de personajes
   - Si cambiaste esta configuración, sal a la pantalla de título y luego vuelve a entrar para refrescar rápidamente los datos de tu vitrina
3. Abre la pestaña `Personajes` en AdeptiScanner, introduce tu UID y haz clic en Obtener
4. Cambia los personajes que muestras y repite desde el paso 3.
   - Si seguiste el paso 1, el cuadro de texto debajo del botón Obtener debería mostrar una lista de personajes que aún no has importado pero posees según los resultados del escaneo de artefactos/armas
   - Puedes salir a la pantalla de título y luego volver a entrar para refrescar rápidamente los datos de tu vitrina


## Cómo prepararse para el escaneo
1. Se recomienda configurar el juego en modo ventana con una resolución de 1600x900, pero no es obligatorio
   - Es probable que otras relaciones de aspecto y resoluciones funcionen, pero no se han probado con el mismo grado
   - El modo de pantalla completa funciona, pero requiere que la configuración `Avanzado` -> `Procesar funciones de manejo` esté habilitada (**Habilitado por defecto**)
2. Abra la sección de artefactos en su mochila principal y seleccione un artefacto de 5 estrellas con una descripción del artículo completa
3. Presione "Capturar"
    - Asegúrese de que la vista previa coincida con el buen ejemplo, si no es así, intente mover su cámara un poco en el juego para cambiar el fondo y repita desde el paso 2 ![algo así](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/Capture-example.png?raw=true)
5. Ingrese su nombre dentro del juego / nombre del viajero en el cuadro de texto `Nombre del Viajero`.
    - No ingresar esto hará que cualquier artefacto escaneado equipado en su Viajero se detecte incorrectamente como equipado en el personaje equivocado o no equipado en absoluto
    - Hay una configuración equivalente para el nombre del Errante

Ahora está listo para el escaneo manual o automático de artefactos

### Escaneo manual
1. Siga las instrucciones bajo `Cómo prepararse para el escaneo`. No mueva la ventana del juego ni cubra el área capturada mientras escanea
2. Seleccione el artefacto que desea escanear y presione el botón `Leer estadísticas`
    - El escáner está principalmente probado para artefactos de 4 y 5 estrellas. Aunque tiene información sobre todos los niveles de artefactos, puede no ser capaz de leer algunos de nivel inferior
3. Repita el paso 2 para cada artefacto que desee escanear manualmente

### Escaneo automatizado
- Mientras usa el modo automático, el programa tomará el control de su ratón. Puede presionar escape durante el escaneo para pausarlo.
- No mueva ni use su ratón durante el modo automático a menos que esté en pausa.
- El escaneo automatizado solo funcionará correctamente si este programa se ejecuta como administrador
- El escaneo automatizado desplazará toda su lista de artefactos, aplicando filtros en la exportación
1. Siga las instrucciones bajo `Cómo prepararse para el escaneo`
2. Desplácese por su lista de artefactos para que las **estrellas** de la **fila superior** y la **etiqueta blanca/beige** de la **fila inferior** estén **ambas completamente visibles** con un margen. ![algo así](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/scroll-example.png?raw=true)
3. Presione el botón `Iniciar Auto`
    - Durante el escaneo, puede presionar la tecla escape en su teclado para pausarlo
    - `Reanudar` hará que el escáner continúe el escaneo
    - `Detener después de procesar` hará que el escáner deje de desplazarse por nuevos artefactos inmediatamente, pero termine de procesar los ya escaneados
    - `Detener ahora` hará que el escáner salga inmediatamente del escaneo automatizado, sin guardar ningún artefacto escaneado
4. El escáner se detendrá automáticamente una vez que crea haber terminado de desplazarse por la lista de artefactos o encuentre un artefacto con estadísticas idénticas a uno previo.
   - Si esto sucede demasiado pronto (por ejemplo, debido a dos artefactos idénticos), puede desplazarse manualmente a la siguiente pantalla y presionar `Iniciar Auto`. Los resultados de la ejecución anterior no se eliminan automáticamente.

### Exportación de resultados
1. Escanee artefactos usando el escaneo manual, automático o una combinación de ambos
2. Configure la sección `Filtros de exportación` según sus deseos
    - Puede usar un archivo plantilla del formato GOOD del cual se copiará todo excepto los detalles del artefacto. Para hacer esto, coloque un json en formato GOOD en la carpeta `ScannerFiles` y renómbrelo a `ExportTemplate.json`    
    - Si desea, puede combinar los artefactos de varios jsons en formato GOOD con el botón `Avanzado` -> `Cargar archivo de artefactos`. No hay detección de duplicados al hacer esto
3. Presione el botón `Exportar resultados`, sus resultados se colocarán en un archivo con marca de tiempo en la carpeta `ScannerFiles`
    - Puede cambiar sus filtros de exportación y presionar el botón de exportar más de una vez si lo desea, cada exportación aparecerá como un archivo separado

## Información especial cuando no se ejecuta como administrador o sin funciones de manejador de procesos
<details>
  <summary> Haz clic para expandir</summary>
  
### Bajo estas condiciones, se aplican los siguientes requisitos adicionales
- No se admite genshin en modo de pantalla completa
- El proceso de captura no puede cambiar automáticamente el foco al juego, por lo que la ventana del juego no debe estar cubierta durante el proceso de captura ni en ninguna otra función que escanee la ventana del juego
- Para capturar el juego, debe estar en tu monitor principal, cubrir el centro de dicha pantalla y tener un encabezado de ventana blanco visible (se puede "falsificar" usando el bloc de notas o similar)
- Imagen de ejemplo cumpliendo estas condiciones en un monitor 1080p 
![Ejemplo de posición de ventana para monitor 1080p](https://github.com/D1firehail/AdeptiScanner-GI/blob/master/1080p-example.png?raw=true)

</details>

## Cómo contactar
- Crea un issue o pull request en este repositorio
- No he creado un discord, ya que no sé cuánto interés habrá. Si se necesita en el futuro, crearé uno
- Estoy en el [Discord Genshin Dev](https://discord.gg/CnmeBYSHaC) creado por la comunidad, mismo nombre de usuario que aquí
- También estoy en el [Discord Genshin Optimizer](https://discord.com/invite/CXUbQXyfUs). No dudes en mencionarme para problemas pequeños, pero para asuntos más largos es mejor usar el Discord de Genshin Dev o enviarme un mensaje directo

## Agradecimientos
- La importación de personajes depende de la API [Enka.Network](https://enka.network/)
- Algunas funciones utilizadas están basadas en gran medida en el código de [WFInfo](https://github.com/WFCD/WFinfo), un programa complementario basado en OCR para Warframe
- El modelo tesseract utilizado fue entrenado y proporcionado por el creador de [este programa similar](https://github.com/Andrewthe13th/Genshin_Scanner)
- El propósito principal de este escáner es importar más fácilmente tus artefactos en [Genshin Optimizer](https://frzyc.github.io/genshin-optimizer/), pero debería ser compatible con cualquier otro programa que use el formato GOOD


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-04

---