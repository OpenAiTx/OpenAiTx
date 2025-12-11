## ... portando OpenFIRE-Boards para EPS32

Este repositorio es un porting del proyecto original 'OpenFIRE-Boards' del TeamOpenFIRE, adaptado para funcionar en el microcontrolador ESP32S3.  
Salvo algunas adaptaciones y pequeños ajustes, el código sigue siendo en gran medida fiel al original de TeamOpenFIRE.  
El código de este repositorio también funciona en el microcontrolador RP2040.  
Cada vez que se realicen cambios en el proyecto original 'OpenFIRE-Boards' de TeamOpenFIRE, actualizaré el código de este repositorio en consecuencia.  
Agradezco sinceramente al TeamOpenFIRE por crear el proyecto 'OpenFIRE-Boards'; todo el mérito y gratitud les corresponden por su trabajo.  
Esto es simplemente una adaptación para que funcione en ESP32S3.  

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)  

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)  


## ... sigue la página original del proyecto  
## ... follows the original project page  

# OpenFIRE-Boards  
Repositorio común de placas que se comparten entre OpenFIRE Firmware &amp; Desktop App  

# OpenFIRE Shared Resources  
Este repositorio contiene recursos que pueden ser compartidos entre implementaciones del Firmware del microcontrolador y Aplicaciones destinadas a interactuar y configurarlas en un dispositivo PC.  

## `OpenFIREshared.h`  
La mitad superior de este archivo define lo siguiente que es común tanto en las implementaciones del Firmware como en la App:  
 - Definiciones de nombres de placas que el microcontrolador reportará en el acoplamiento inicial, como literales de cadena.  
 - Enumeraciones de tipos de funciones de pines, conmutadores, configuraciones, dispositivos I2C y sus configuraciones, y comandos usados en la comunicación serial entre firmware y app.  
 - Preajustes para placas definidas que se cargan al inicio, y referenciadas por las apps que muestran diseños predeterminados de placas.  

Debajo de la comprobación del preprocesador para `OF_APP` hay cadenas 'bonitas' para placas soportadas y funciones de pines, y diseños de placas que sólo usan las Apps de Escritorio para representar gráficamente pines GPIO para placas definidas, mostrando dónde deben renderizarse en relación con un vector central de la placa, y diseños alternativos para placas que la app debe presentar como opciones al usuario, si las hay.  

### `boardPresetsMap`








Las placas compatibles deben tener un nombre que corresponda a la definición `OPENFIRE_BOARD` tal como se define al inicio del archivo, seguido de un mapa de qué función debe tener cada GPIO por defecto (esto se carga cuando `OF_Prefs::toggles[OF_Const::customPins]` está configurado como *true* en las preferencias actuales de la placa). Cada GPIO que tenga el microcontrolador debe estar representado aquí, asignando `btnUnmapped` a los pines no mapeados y `unavailable` a los pines que están reservados o no expuestos al usuario. Las placas RP2040 y RP235X-A deben tener un máximo de treinta pines; tenga en cuenta que aunque el `rpipico` solo expone alrededor de 26 pines, aún considera los GPIO ocultos.

### `boardBoxPositions`
Al igual que `boardPresetsMap`, para cada `OPENFIRE_BOARD` compatible, esto presenta un mapa de aproximadamente *dónde* debería estar ubicado cada pin en la vista gráfica de la placa en la aplicación de escritorio, representado como la suma de dos valores: el izquierdo es la posición relativa como un entero positivo comenzando en 1, y el derecho es un valor enumerado que indica en qué lado de la placa deben posicionarse los elementos del pin. Añadir `posLeft`, `posRight` y `posMiddle` colocará este GPIO en el lado respectivo de la vista de la placa, y añadir `posNothing` (literalmente 0) indicará a la aplicación que no muestre este pin en absoluto, lo cual debe usarse para los pines `unavailable` en `boardPresetsMap`. La cantidad de valores debe coincidir con la cantidad de GPIO definidas en el mapa de presets.

### `boardsAltPresets`
Esto es para presets alternativos opcionales de placas, que se presentan en una vista de diseño de placa como una lista desplegable de nombres de diseños alternativos. Cada `OPENFIRE_BOARD` compatible puede listarse múltiples veces, uno por cada diseño alternativo: la cadena después del nombre de la placa indica la etiqueta que se mostrará en la interfaz, seguida de un mapa con llaves de funciones GPIO del tablero idéntico a `boardPresetsMap`; se aplican las mismas convenciones y estipulaciones. Esto está principalmente destinado a coincidir con el diseño de placas adaptadoras que usan diferentes mapeos/soldaduras sugeridas para botones, como el diseño SAMCO 1.1 de `adafruitItsy` para esas placas que tiene un mapeo diferente al diseño SAMCO 2.0 predeterminado; también tenga en cuenta que la aplicación de escritorio de referencia actual soporta exportar e importar diseños personalizados.

## `boardPics/` - Vectores de placa y resaltados de pines
Este es el repositorio de vectores de placa que las aplicaciones de escritorio deben usar para las vistas de diseño de placa para representar gráficamente la placa actual conectada a la aplicación. Los vectores de placa deben exportarse como *SVG simple* (o equivalente), y añadirse al archivo de recursos `vectors.qrc`, donde el alias para cada archivo debe coincidir con los nombres definidos en la cadena `OPENFIRE_BOARD` de `OpenFIREshared.h` para la placa.

La aplicación de escritorio de referencia actual es capaz de mostrar *pines resaltados* cuando el usuario pasa el cursor sobre un elemento de pin GPIO en la interfaz. Para ello, los SVG deben modificarse de la siguiente forma (usando Inkscape como ejemplo principal de interfaz):
 1. Si no está ya hecho, agrupe todos los objetos existentes de la imagen de la placa en su propio grupo (el nombre no importa). También asegúrese de que los orificios de los pines sean transparentes debajo y no estén rellenos con un color de fondo.
 2. Cree un nuevo grupo *debajo* del grupo de la placa - de nuevo, el nombre no importa, pero para facilidad de uso debería llamarse algo como `OF`.
 3. Dentro de este nuevo grupo de resaltados, cree los elementos de resaltado sin trazo y con un relleno básico de color plano (las placas existentes usan RGBA `ebe713`, o *R253/G231/B19*).
 4. Seleccione el elemento de resaltado y vaya a la pestaña *Propiedades del objeto* (o equivalente que muestre la línea *"ID"*): cada elemento de resaltado debe tener un ID llamado `OF_pinX` - donde X == número del pin GPIO, sin cero inicial.
 5. Mientras el elemento esté seleccionado, vaya a la pestaña *Relleno y trazo* (o equivalente que muestre *"Opacidad (%)"*) y ajuste la opacidad a **0.0**.
 6. Una vez que la ubicación, el nombre y la opacidad estén correctos, guarde el archivo como un archivo ***SVG simple*** dentro del directorio `boardPics`. Asegúrese de que `vectors.qrc` tenga esta placa listada como alias de la cadena `OPENFIRE_BOARD` que configuró para este microcontrolador en `OpenFIREshared.h`!

> [!NOTA]
> Este procedimiento debe hacerse **solo** para cada pin GPIO *accesible* de la placa (es decir, los pines que serían `unavailable` en el `boardPresetsMap` no deben añadirse, ya que la aplicación los ocultará).

Una vez terminado, reconstruya la aplicación y pruebe la imagen de la placa; la forma más sencilla es usar la ventana *Ayuda->Ver placas compatibles*, y pasar el cursor sobre las etiquetas correspondientes a los GPIO.

> [!NOTA]
> - Si la imagen de la placa no se muestra en absoluto, probablemente el vector no tenga el nombre apropiado o no se haya exportado correctamente; verifique cuidadosamente que siguió correctamente el Paso 6 anterior.
> - Si la imagen de la placa se muestra, pero los resaltados no (o se muestran en pines incorrectos), probablemente necesite editar manualmente algunas líneas del SVG exportado en un editor de texto, como Notepad. Los requisitos técnicos para que los vectores funcionen - y las cosas a verificar - son:
>   - Que las líneas `id="OF_pinX"` estén *antes* de la línea `style="`.
>   - Que la línea `style="` contenga `opacity:0` dentro (preferiblemente `0` o `0.0`; no importa cuál sea, siempre que coincida).
> Consulte el siguiente ejemplo a continuación (fragmento de [`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg)) para el formato ideal general de cada elemento de resaltado:
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---