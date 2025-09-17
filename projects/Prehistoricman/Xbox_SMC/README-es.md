# Xbox_SMC
Volcados PIC16/Xyclops del Xbox original y bases de datos IDA con algo de ingeniería inversa realizada.

![Imagen del PIC16LC63A de un Xbox original](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Flasheo de Xyclops (XycloMod)
Ver [el directorio Xyclops y README](/Xyclops)

# Volcados
El archivo .bin para cada volcado PIC tiene los bytes intercambiados para carga correcta en IDA. Así que la primera palabra de la memoria PIC es byte_0 + byte_1 << 8.

Las bases de datos .idb de IDA contienen información sobre variables y algunas observaciones en el bloc de notas de la base de datos.

Ver esta página wiki para un desglose de las versiones SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Volcado de un Xbox DVT3. La misma palabra de configuración que P01. También tiene el ID de dispositivo quemado en el área de configuración como 0000 0000 000B 002A, a diferencia de los PIC de producción.

Carece completamente del desafío de arranque.

## D01
Volcado de un Xbox XDK BETA 2. Idéntico a P01 excepto por la ausencia del desafío de arranque. La función para calcular la respuesta esperada del desafío de arranque aún existe, pero nunca se llama.

## DXF
Volcado de un kit de depuración XDK D2. Muy similar a D01 pero con lógica de bandeja, sobrecalentamiento y arranque ligeramente diferente. El desafío de arranque falta de la misma manera que en D01.

## D2E
Volcado de un kit de desarrollo Tuscany (v1.6). El chip Xyclops está marcado como X01202-001, y carece de la línea A-A02 o A-B01 que tienen las unidades comerciales.

El código serial de depuración en FC00 coincide con el volcado comercial P2L. Hay un patrón extraño de datos desde 0x4000 hasta 0xFBFF.

## P01
Volcado de un Xbox v1.0. La palabra de configuración es 0x86:
- CP1:CP0 = 0 (Protección de código habilitada para toda la memoria)
- BODEN = 0 (Reinicio por caída de voltaje deshabilitado)
- ~PWRTE = 0 (Temporizador de encendido habilitado)
- WDTE = 1 (Temporizador watchdog habilitado)
- FOSC1:FOSC0 = 2 (Oscilador HS)

Un valor de configuración de 0x3FB6 es adecuado para clones SMC para que no tengan la protección de código activada.
## P11
Volcado de una Xbox v1.3. La misma palabra de configuración que P01.

Hay algunos pequeños cambios en P11 respecto a P01, incluyendo un comando SMBus extra (escribir 0x22), diferentes prioridades de LED y tiempos más relajados para el arranque.

Verifiqué volcado codificado de v1.3 contra v1.4 y coincidieron. Esto significa que es muy probable que tengan el mismo programa.

## P2L
Volcado de una Xbox v1.6. Revisión Xyclops A-A02. Contiene código Intel 8051 pero tiene muchos registros de función especial cuya función es desconocida.

El serial de depuración es alimentado por el código en FC00. Parece un depurador rudimentario que puede pausar la ejecución, volcar datos y escribir en registros/RAM.

# Volcado de Xyclops

El chip Xyclops tiene 3 pines para 'depuración': TXD (pin 64), RXD (pin 63) y DEBUG (pin 29). Poner el pin DEBUG en alto habilita el puerto serial en los pines TX y RX. El serial opera a 9600 baudios.

El protocolo se basa en comandos de 4 bytes que típicamente tienen el formato `<cmd>` `<byte alto de dirección>` `<byte bajo de dirección>` `<no importa>`

El comando 0x14 vuelca 64 bytes de datos BIOS a la vez y el 0x15 vuelca 64 bytes de datos de programa SMC a la vez. Un volcado de Xyclops, P2L.bin, está incluido en el repositorio. También se incluye [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) para que puedas volcar tu propia máquina.

# Metodología para volcar PIC
Descripción completa en https://wiki.recessim.com/view/PIC_Burnout

El PIC tiene su protección de código activada, por lo que todos los datos se leen como 0000. Usé un truco para obtener datos codificados en salida, descubrí el algoritmo de codificación usando un chip sacrificial, y luego usé un tipo de exploit para cambiar los datos de ROM y fijar algunos bits a valores conocidos. Luego puedo extraer la información requerida de los múltiples volcados codificados para reconstruir los datos originales.

# PICProgrammer
PICProgrammer es uno de varios proyectos Arduino para el RP2040 que usé en mi investigación. Proporciona una interfaz sencilla de línea de comandos para ejecutar operaciones ICSP (programación serial en circuito) en el PIC. Esto se prefiere sobre usar un programador específico como el PICkit por su flexibilidad y la opción de hacer cosas que el fabricante no previó.

Debes tener un buen conocimiento de electrónica y programación antes de usarlo, y revisar cuidadosamente lo que hacen los comandos antes de ejecutarlos.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-17

---