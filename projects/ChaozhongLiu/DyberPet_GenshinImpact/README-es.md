# DyberPet - Versión Genshin Impact

> [!IMPORTANT]
> ## ⚠️ Este repositorio ha dejado de mantenerse, por favor dirígete a la nueva versión DyberPet
>
> **La versión de DyberPet para Genshin Impact fue fusionada hace varios años en el nuevo marco [DyberPet](https://github.com/ChaozhongLiu/DyberPet).**
>
> Este repositorio ya no se actualizará ni se recomienda seguir usándolo.  
> Ahora solo necesitas llevar la carpeta de personajes para migrar a la nueva versión de DyberPet y disfrutar de más funcionalidades.
>
> 👉 **Por favor visita el nuevo repositorio: [ChaozhongLiu/DyberPet](https://github.com/ChaozhongLiu/DyberPet)**

----
[![License](https://img.shields.io/github/license/ChaozhongLiu/DyberPet.svg)](LICENSE)
![DyberPet Version](https://img.shields.io/badge/DyberPet-v0.2.2-green.svg)  
DyberPet (DyberPet) versión Genshin Impact es una mascota de escritorio basada en el marco [DyberPet](https://github.com/ChaozhongLiu/DyberPet), con el arte realizado por [@栎曦_Nuo](https://space.bilibili.com/14004864).  

🆕 La **versión con UI reestructurada** ya está disponible en la [página principal de DyberPet](https://github.com/ChaozhongLiu/DyberPet)! La nueva versión incluye respaldo de partidas, adición de personajes, una UI más amigable, ¡te invitamos a probarla y dar tu feedback!
  
Si te gusta esta mascota de escritorio, por favor haz clic en la esquina superior derecha:star:**Star**; esto nos motiva mucho a continuar desarrollando!  
Además, más personajes, objetos y funciones se irán añadiendo, sigue a [@栎曦_Nuo](https://space.bilibili.com/14004864) y este repositorio para las últimas actualizaciones.  

Si encuentras algún problema durante el uso, puedes enviarme un mensaje privado [@哦哟喔嚯](https://space.bilibili.com/39307302) o abrir un issue en la [página de Issues](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/issues).

:warning:  ~~Recientemente he estado ocupado con la graduación de doctorado y búsqueda de empleo, por lo que el marco no puede actualizarse puntualmente, lo siento mucho. Se espera reanudar correcciones y actualizaciones estables a mediados de octubre.~~ :beers:  
Actualmente se está realizando una nueva reestructuración de la UI y se están añadiendo funciones de operación más cómodas, puede que las actualizaciones sean lentas debido a la carga, ¡gracias por la comprensión!
 
  
Para la versión en **inglés y otros idiomas**, por favor consulta nuestra [versión Alpha de DyberPet](https://github.com/ChaozhongLiu/DyberPet/releases/tag/v0.3.0a).  
Por favor :star:**Star** para recibir futuras actualizaciones!



## Experiencia rápida
### Usuarios de Windows
  **Primer uso**: Descarga el repositorio [aquí](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip) localmente, descomprímelo y haz doble clic en **``DyberPet-Genshin.exe``** para ejecutarlo  
  (el programa .exe no puede moverse fuera de la carpeta, pero puedes crear un acceso directo en el escritorio)
  
  
  **Actualización de versión**: Si ya estás usando DyberPet, descarga la última versión [aquí](https://github.com/ChaozhongLiu/DyberPet_GenshinImpact/archive/refs/heads/main.zip) y sobrescribe los archivos de la versión antigua  
  (Overwrite all, the ``data`` folder will be retained, data will not be lost)
  
  **Baidu Netdisk**: [link](https://pan.baidu.com/s/1dLY0ZfFcTRySuU4tXv1-pA?pwd=bs1d) | Extraction code: bs1d  
  **Quark Netdisk**: [link](https://pan.quark.cn/s/a070df462217) | Extraction code: 7RD4

### Usuarios de Linux / MacOS
  
  **Versión beta para Mac**  
  **Quark Netdisk**: [link](https://pan.quark.cn/s/6386f4b5efc9) | Extraction code: D3VR  
  Bienvenidos a unirse al grupo para reportar bugs y dudas, ¡y obtener las últimas actualizaciones! ``233305772``  
  **P: El programa está dañado, no se puede abrir**:  
  **R:** Este es un problema de permisos de aplicaciones de terceros, no está realmente dañado. Para solucionarlo, consulta: https://macoshome.com/course/1699.html
  
  También se puede resolver con el método de [este comentario](https://www.bilibili.com/read/cv21890026) (gracias al usuario de Bilibili [@洛天依_Linux](https://space.bilibili.com/495653264))
  

## Manual de usuario
Por favor, consulta este [manual de usuario sencillo](https://raw.githubusercontent.com/ChaozhongLiu/DyberPet_GenshinImpact/main/用户手册.pdf), o mira el [video en Bilibili](https://www.bilibili.com/video/BV1fd4y1W7ht) para experimentar las funciones actuales.


## Registro de cambios

<details>
  <summary>Lista de actualizaciones de versión</summary>
  
**  **
  
**v0.2.2 - 05/03/2023**
- Modificación en la estructura de datos de acciones permanentes, corrección de errores  
- Los compañeros añadieron la determinación de acciones permanentes, que debe configurarse cuando es la mascota principal
  
**v0.2.2 - 05/03/2023**
- Nuevo personaje: Xiao  
- Se añadió la función de seguir el ratón  
- En el menú de clic derecho se añadió la opción de acción permanente, que puede cambiar la acción predeterminada en reposo; al seleccionar, no se reproducirán otras acciones al azar  
- La mochila se dividió en dos columnas: comida y coleccionables
  
**v0.2.1 - 23/02/2023**
- Optimización del mecanismo de escalado  
- Cuando la cantidad del objeto es 1, no se muestra el número
- Se optimizó el método de determinación de la lista principal de mascotas y la forma de guardar la mascota predeterminada
  
**v0.2.0 - 22/02/2023**
- Se añadió la compensación por recompensa de nivel de afecto
- Se añadieron 4 grupos de diálogos para el Errante y Nahida, que se desbloquearán en los niveles de afecto 2, 3, 4 y 5 respectivamente
  
**v0.2.0 - 19/02/2023**
- Se redujo el tamaño de Nahida
- Se corrigió un bug al abrir y cerrar el tiempo de acompañamiento al cambiar de personaje
  
**v0.2.0 - 18/02/2023**
- Nuevo personaje - Errante
- Límite máximo del nivel de afecto ajustado a 8 (¡arriba doge!)
- Se añadió la opción para seleccionar el personaje predeterminado al iniciar en la configuración
  
**v0.1.19 - 16/02/2023**
- Ahora se puede silenciar desde la configuración
- Se añadió la función de contar los días de acompañamiento y mostrar la placa conmemorativa
- Se añadió automáticamente un botón de "paso anterior" en el cuadro de diálogo (aún no implementado el material)
- Se ajustó el cálculo de longitud para caracteres chinos especiales
  
**v0.1.18 - 11/02/2023**
- Se añadió la conexión entre mascota principal y mascotas auxiliares
- Se garantizó que los objetos coleccionables no aparezcan repetidos en las caídas aleatorias
- Se organizaron los valores del sistema que pueden ser modificados
  
**v0.1.18 - 11/02/2023**
- Se corrigió el error en el botón de la mochila que se mostraba al retirar a Paimon usando el menú derecho
  
**v0.1.18 - 10/02/2023**
- Se añadió la interfaz y funciones de diálogo (material aún no implementado)
- Se añadió el atributo ``pet_limit`` a los objetos, que los limita para aparecer sólo con ciertas mascotas (preparación para futuros personajes)
  
**v0.1.17 - 06/02/2023**
- Las ranuras de la mochila para coleccionables se fijaron en la parte superior, con fondo azul claro
- Los coleccionables pueden retirarse en la mochila (por ejemplo, si Paimon se pierde por un bug, puede ser retirado desde la interfaz de la mochila)
  
**v0.1.17 - 05/02/2023**
- Se añadió el atributo ``sound_priority`` para asignar prioridad a las voces del sistema de notificaciones
- Se añadieron eventos de voz aleatorios al hacer clic
- Se añadió la biblioteca de voz de Naxida
  
**v0.1.16 - 02/02/2023**
- Se corrigió el problema del punto de anclaje en la acción de los compañeros
- Soporte completo para múltiples pantallas (en pruebas)
  
**v0.1.15 - 02/01/2023**
- Se corrigió el cambio de tamaño de Paimon al aumentar la escala de la pantalla
- Se corrigió el parpadeo al arrastrar accesorios
- Se corrigió el problema de visualización incompleta al ampliar el compañero invocado
- Se corrigió la posición de Paimon mascota al escalar bajo ciertas condiciones
  
**v0.1.15 - 01/31/2023**
- Se evitó el bug de cierre relacionado con tiempo de concentración 0 minutos 0 segundos
- Se resolvió el gran bug del objeto de estallido frenético inexpresable
- El botón de detener se desactiva inmediatamente tras ser pulsado para evitar múltiples cálculos
- Se corrigió el bug de parpadeo causado por pequeños movimientos al hacer clic rápido con el ratón
  
**v0.1.15 - 01/30/2023**
- La fuente de la barra numérica se fija en Times
- Se añadió opción para fijar ventana en la configuración
- La disminución del nivel de hambre cambia a cada 4 minutos
- Se añadieron recompensas de nivel 3 y 4 para la afinidad
- Para simplificar el proceso de actualización, la carpeta ``data`` fue eliminada y se generará automáticamente en la primera ejecución.
  
**v0.1.14 - 01/29/2023**
- El valor mínimo de aceleración por gravedad cambió a 0.01
- Se canceló el efecto del zoom de pantalla sobre el tamaño de la mascota, el usuario puede ajustar esto en la configuración
  
**v0.1.14 - 01/28/2023**
- Se corrigió el bug en la evaluación de límites al cambiar el zoom
- Se mejoró la lógica de selección de la voz de inicio
  
**v0.1.14 - 01/27/2023**
- Tras cuatro meses de desarrollo, ¡la mascota Daibo - versión Genshin Impact está oficialmente lanzada!


</details>

## Únete a nosotros  
Si también quieres desarrollar un nuevo conjunto de imágenes, movimientos y objetos para mascotas, puedes consultar el [documento de desarrollo de materiales](https://github.com/ChaozhongLiu/DyberPet/blob/main/docs/art_dev.md) que aún está en proceso, y también eres bienvenido a enviarme un mensaje privado en Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302) y a [@栎曦_Nuo](https://space.bilibili.com/14004864) para unirte a nosotros y crear juntos.

Si quieres desarrollar el marco de mascotas Dyber junto con nosotros, no dudes en enviarme un mensaje privado en Bilibili [@哦哟喔嚯](https://space.bilibili.com/39307302), ¡y enfrentemos juntos este gran desafío!

## Declaración de derechos de autor
- Los derechos de autor del material de las mascotas pertenecen a miHoYo, ¡no usar con fines comerciales!
- La división del material y el diseño de movimientos de las mascotas provienen de Bilibili [@栎曦_Nuo](https://space.bilibili.com/14004864). Por favor, indica la fuente al republicar o usar.
- Dyber Pet sigue la licencia GPL v3.0, al desarrollar o usar, por favor menciona al autor GitHub@ChaozhongLiu





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---