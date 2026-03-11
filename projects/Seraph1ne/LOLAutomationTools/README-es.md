# Introducción
**LOLAutomationTools** es una herramienta de extensión funcional para **League of Legends**; diseñada para ayudar a los jugadores a realizar algunas operaciones simples en el cliente en situaciones donde no pueden usar ambas manos o necesitan ausentarse temporalmente, ahorrando así algo de tiempo; el software no interfiere en exceso con la comprensión y el estilo de juego del jugador, por lo que algunas funciones aún requieren configuración manual previa (como la configuración de runas de héroes), ya que demasiadas restricciones pueden resultar tediosas y hacer perder la diversión del juego; juega de manera activa y feliz, contribuyendo a un ambiente armonioso.

# Funciones
- Selección de héroes
  - Preselección de héroes
- Bloqueo de héroes
  - Ignorar selección de equipo
  - Modo de bloqueo en grupo
- Héroe aleatorio
- Prevención de desconexión por bloqueo de héroes
- Aceptar partida
  - Aceptación de partida con retardo
- Crear partida
- Buscar partida
  - Detección de tiempo de espera en emparejamiento
- Función de intercambio
  - Intercambio de héroes en modo aleatorio
    - O solo aceptar pasivamente intercambios de otros jugadores
    - Rechazar intercambios de héroes no seleccionados
  - Intercambio de posiciones en modo indicativo
    - O aceptar pasivamente intercambios de posiciones de otros jugadores
    - Rechazar intercambios de posiciones no preseleccionadas
  - Intercambio de pisos en modo reclutamiento
    - O solo aceptar pasivamente intercambios de pisos de otros jugadores
    - Rechazar intercambios de pisos no configurados
- Omitir página de elogios
- Omitir página de desbloqueo
- Control de respuestas de chat
  - Responder mensajes de amigos al ausentarse
  - Responder invitaciones a partida al ausentarse
    - Rechazar invitaciones a partida al ausentarse
- Ventana adicional
  - Visualización de buff de equilibrio de héroes en modo entretenimiento
  - Aplicación automática de runas
  - Corrección de runas
  - Configuración independiente de héroes
- Cierre automático de partida
- Reconexión automática a partida
- Recolección automática de recompensas del pase (incluido Teamfight Tactics)
- Procesamiento de solicitudes de amistad
  - Eliminación masiva de amigos
- Carrera personalizada
  - Antecedentes de carrera
  - Avatar del invocador
  - Estado del cliente
  - Firma de estado
  - Nivel de la tarjeta de presentación
  - Puntos de logro de héroe
  - Borrar medallas equipadas
- Bloqueo de teclas funcionales
- Consulta de historial de partidas
  - Envío de historial
  - Detección de juego en equipo dentro de la partida
  - Observación de partidas de jugadores
  - Reporte de jugadores después de la partida
- Mensajes dentro de la partida
- Lista negra
- Configuración de teclas rápidas
- Configuración de temas
  - Tema oscuro/claro
  - Tema adaptable
  - Tema personalizado
  - Configuración de imagen de fondo
  - Personalización de fuente
- Funciones extendidas
  - Selección automática de cartas (Maestro de cartas)


## Selección de héroes
Antes de usar **Selección de héroes** y **Prohibición de héroes**, es necesario realizar operaciones de edición en la página de configuración (botón detrás de la opción de interruptor).

Los héroes añadidos en la configuración de línea solo se aplican en ciertos modos de juego con *posiciones preseleccionadas* (como *Clasificatoria* y *Asalto extremo*), la selección aleatoria solo se aplica en modos de *héroe aleatorio* (como *Batalla en la Grieta* y *Lucha sin fin*, la configuración de héroes prohibidos no incluye la página de configuración aleatoria), y la configuración general se aplica en todos los demás modos (excluyendo los modos mencionados anteriormente, para mantener las normas de uso). Al ejecutar la selección automática de héroes, se seguirá la configuración de **Selección de héroes**, seleccionando en orden de arriba hacia abajo.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/6aa4f1ad-28db-4bd5-a917-df4197024f5f" />

## Preselección de héroes
La lógica de ejecución de esta función es básicamente la misma que la de **Selección de héroes**, pero la diferencia es que la **Preselección de héroes** solo se aplica en modos que incluyen una fase de prohibición, como *Clasificatoria* y algunos modos de entretenimiento que requieren prohibición de héroes.

## Prohibición de héroes
**Página de configuración de héroes deshabilitados** es básicamente igual a la página de configuración de **héroes seleccionados**, solo que tiene un botón para cambiar de modo en la esquina superior derecha, al hacer clic en el botón se puede cambiar al modo de deshabilitación.

*Modo de deshabilitación normal* : La lógica de operación de este modo es la misma que la página de configuración de **héroes seleccionados**, al ejecutar la deshabilitación automática de héroes, si no hay héroes configurados para deshabilitar, se realizará un Ban vacío cuando el tiempo restante en la fase de Ban sea 0 segundos.

*Modo de deshabilitación en grupo* : Los ítems en la lista de configuración serán reemplazados por los héroes correspondientes en la configuración de **héroes seleccionados**, al seleccionar un ítem, hacer doble clic en el héroe del lado izquierdo para agregarlo al **grupo de deshabilitación** del héroe, al ejecutar la deshabilitación automática de héroes, se deshabilitará según el orden de los ítems en la configuración de **héroes seleccionados**, si ningún **grupo de deshabilitación** en la configuración de **héroes seleccionados** tiene héroes configurados para deshabilitar, se usará la lógica del modo de deshabilitación normal.

> Si está habilitada la opción *Ignorar preselección de compañeros*, al ejecutar la deshabilitación automática de héroes se omitirá la detección de preselección del equipo. No se recomienda habilitar esta opción.

## Aceptar partida
Aceptar automáticamente la partida después de encontrar una partida.

> Al habilitar la opción *Aceptar partida con retraso*, **Aceptar partida** solo se realizará automáticamente en el último segundo del conteo regresivo de aceptación.

## Crear partida
Puedes crear una partida manualmente mediante el botón **Crear partida** o activar esta opción para crear partidas automáticamente.

> *Crear partida automática* requiere seleccionar el modo de partida a crear en *Configuraciones avanzadas*, esta opción no se guardará en la configuración.

## Buscar partida
Buscar partida automáticamente, esta opción solo funciona en la sala del modo de partida y cuando eres el dueño del equipo (anfitrión).

> Si está habilitada la opción *Detección de tiempo de espera*, se buscará partida automáticamente de nuevo cuando el tiempo en la cola de emparejamiento exceda el tiempo estimado más el intervalo especificado.

## Omitir elogios
Omitir la página de elogios de los compañeros al terminar la partida.

## Omitir resultados
Omitir la espera de resultados al final de la partida (pantalla negra con carga) o la página de resultados posterior a la partida, y volver a la sala del modo de partida.

## Función de intercambio
Incluye un interruptor principal y tres interruptores independientes, además necesitas realizar otras configuraciones. En la configuración avanzada de **Función de intercambio**, puedes configurar si intercambiar héroes con compañeros en modo aleatorio o intercambiar posiciones (orden de selección de héroes) y preselección en modo reclutamiento.

*La configuración de intercambio de héroes y posiciones es relativamente simple, no se detalla aquí.*

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/361b4b19-cd72-4cb3-901f-69d49284bc11" />

En la **configuración avanzada** de **Intercambio de posiciones**, puedes configurar el orden de intercambio (es decir, las posiciones) y el modo de intercambio.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/697bed4a-2984-43f6-b747-36c7911ef99d" />

*Modo de intercambio*:
- Solo orden objetivo: acepta solicitudes de compañeros cuya *orden* coincida con la *orden* especificada.
- Prioridad que incluye objetivo: acepta solicitudes de compañeros con *orden* ≤ la *orden* especificada.
- Orden retrasada que incluye objetivo: acepta solicitudes de compañeros con *orden* ≥ la *orden* especificada.
- Rango basado en el orden objetivo: acepta solicitudes de compañeros con *orden* ≤ (*orden especificada* - *rango*) y *orden* ≥ (*orden especificada* + *rango*).

Además, en **Configuraciones adicionales** hay dos opciones para rechazar intercambios que, cuando están **habilitadas**, rechazan automáticamente la solicitud de intercambio si el héroe o la selección del compañero no cumplen con las condiciones definidas; **de lo contrario**, no realizan ninguna acción, pudiendo decidir si aceptar el intercambio.

## Prevención de abandono en selección/ban
Al habilitar esta opción, se ejecutará la **selección o prohibición de héroe** en el último segundo de la fase BP.

> Puedes cambiar el modo de la función **Prevención de abandono en selección/ban** en la *página de configuración de funciones*.

## Respuesta automática al ausentarse
Esta opción es un interruptor principal y requiere configuraciones adicionales. En la página de configuración **Más**, puedes establecer si responder automáticamente a mensajes de amigos o invitaciones a partidas al ausentarte (ambas activadas por defecto) y configurar el texto de respuesta.

<img width="900" height="680" alt="imagen" src="https://github.com/user-attachments/assets/68f9e16f-7263-4924-954f-8e4f880a4007" />

## Ventana adicional
Al habilitar esta opción, se mostrará una **ventana adicional** en ciertas fases del cliente. Además, puedes acceder a la **página de configuración** de la ventana adicional mediante el botón junto a este interruptor, donde también puedes ver los **atributos de equilibrio** del héroe en los modos de entretenimiento disponibles actuales (si los hay) y configurar las runas y configuraciones independientes del cliente para cada modo.

Página de configuración de la **ventana adicional**</br>
<img width="900" height="680" alt="imagen" src="https://github.com/user-attachments/assets/dd7a6d53-177e-4132-b612-20aaf4a4d2e6" />
<img width="900" height="680" alt="imagen" src="https://github.com/user-attachments/assets/7675278c-5ed8-4d0d-9248-d8ef8b07201d" />

> Para añadir o actualizar configuraciones de runas de un héroe en la **página de configuración de runas**, primero debes seleccionar y guardar una página de runas en **Colección - Runas** del cliente del juego, luego cambiar la habilidad de invocador desde la esquina superior derecha y presionar el botón **Agregar configuración** o el botón *Actualizar configuración actual del juego a esta configuración* en la configuración de runas que deseas actualizar.

**Ventana adicional**</br>
<img width="388" height="650" alt="imagen" src="https://github.com/user-attachments/assets/b7a1df40-f496-4c8a-a540-54806fc8d3f4" />

## Cierre automático de partida
Simple y claro, cierra automáticamente el proceso del juego al reproducirse la animación de finalización del cristal al terminar la partida.

## Reconexión automática en partida
Intenta reconectar automáticamente cuando el juego requiera reconexión.

## Selección automática de cartas (extensión adicional)
Cuando el héroe usado en la partida actual es Maestro de Cartas, utiliza las teclas Z/X/C para seleccionar automáticamente las cartas Azul/Roja/Amarilla.

![pickCards](https://github.com/user-attachments/assets/df5aa45a-8593-44c9-8c3f-bec315552113)
> Esta función se implementa mediante procesamiento gráfico y simulación de teclado, y solo se ha probado con las dos resoluciones más comunes actualmente (1920x1080/2560x1440); otras resoluciones no funcionarán correctamente sin una configuración propia (especialmente resoluciones fuera de la relación de aspecto 16:9).  
> La detección permite cierto rango de filtros, pero se recomienda no activar filtros al usar esta función para evitar que alguna detección falle.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---