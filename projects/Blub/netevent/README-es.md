# netevent

Netevent es una herramienta que se puede usar para compartir dispositivos de eventos de Linux con otras
máquinas (ya sea a través de `/dev/uinput` o implementando un cliente para el mismo
protocolo por otros medios).

Originalmente simplemente volcaba las capacidades del dispositivo a stdout y después
se comportaba como ejecutar `cat /dev/input/eventX` en un modo, y en el otro
pasaba las capacidades analizadas a `/dev/uinput` y luego pasaba los eventos
directamente.

Dado que gestionar esto para múltiples dispositivos puede volverse tedioso al tener más
de un destino (y dado que los mecanismos originales de captura/alternancia/tecla rápida eran
extraños y literalmente orientados a mi caso de uso personal), netevent2 ahora extiende el
protocolo para contener paquetes que pueden contener más de un dispositivo y pueden añadir
y eliminar dispositivos sobre la marcha.

El comportamiento original tipo `cat` (aunque actualmente sin soporte de tecla rápida)
también está disponible para propósitos de depuración (y el modo `create` soporta ambas
versiones del protocolo).

La herramienta principal ahora es el `netevent daemon` que tiene un socket de comandos (un
socket unix opcionalmente abstracto) a través del cual se pueden añadir dispositivos, salidas y
teclas rápidas sobre la marcha. Véanse los ejemplos abajo.

## Compilación

* opcionalmente: `./configure --prefix=/usr`
* `make`

Aún puedes simplemente ejecutar `make` como antes. Sin embargo, para soportar los flujos de trabajo
de instalación habituales, y para distinguir entre sistemas con kernels más recientes
donde `/dev/uinput` ha sido extendido con un `UI_DEV_SETUP` `ioctl`, se ha añadido un
script `./configure` para comprobar esto y crear un `config.h`
así como un `config.mak` para PREFIX/BINDIR/... (todo lo cual también puede pasarse como
variables directamente a `make`, junto con el habitual `DESTDIR`).

## Instalación

* `make install` o `make DESTDIR=/mi/directorio/de/staging install`
O: como antes, simplemente coloca el binario `netevent` donde sea.

## Uso

Consulta la sección COMANDOS DEL DEMONIO en netevent(1) para detalles sobre los comandos usados
en los scripts de configuración a continuación.

### Ejemplos

Consulta el directorio `examples/`. Lee el ejemplo de configuración a continuación para ver cómo adaptar
las líneas de teclas rápidas para trabajar con tus dispositivos.

#### Ejemplo simple de configuración: compartir teclado y ratón con una máquina vía ssh:

Lado del host:

* Preparación: Asegúrate de que podemos acceder a los dispositivos event como usuario

    Usualmente esto significa ejecutar algo como `gpasswd -a miusuario input`

* Paso 1: Decide qué dispositivos /dev/input/eventXY pasar.

    Para nombres de archivo consistentes usa algo como:
    `/dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd`
    `/dev/input/by-id/usb-BestMouseEver-event-mouse`

* Paso 2: Decide una tecla rápida y encuentra su código de evento:

    En el ejemplo anterior queremos usar una tecla del teclado (a menos que
    tengas una cantidad insana de botones en el ratón...).
    `netevent` puede usarse para volcar eventos de forma legible, ejecuta el subcomando `show`
    en el dispositivo y presiona las teclas que quieres usar para las teclas rápidas.
    Si es el mismo teclado con el que estás escribiendo el comando, antepone un
    sleep para evitar confusión cuando netevent detecte la liberación de la tecla enter.


    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```

* Paso 3: Prepare un script de configuración para el demonio:

    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```

* Paso 4: Ejecute el demonio netevent:

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

Ahora puede enviar comandos adicionales al demonio conectándose al socket.
Por ejemplo, mediante `socat READLINE UNIX-CONNECT:netevent-command.sock`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---