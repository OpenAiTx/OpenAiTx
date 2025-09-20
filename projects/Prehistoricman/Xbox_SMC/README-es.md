
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Volcados de PIC16/Xyclops de la Xbox original y bases de datos de IDA con algo de ingeniería inversa realizada.

![Imagen del PIC16LC63A de una Xbox original](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Programación de Xyclops (XycloMod)
Consulta [el directorio Xyclops y el README](/Xyclops)

# Dumps
El archivo .bin de cada volcado de PIC tiene los bytes intercambiados para una carga correcta en IDA. Así, la primera palabra de la memoria PIC es byte_0 + byte_1 << 8.

Las bases de datos .idb de IDA contienen información sobre variables y algunas observaciones en el bloc de notas de la base de datos.

Consulta esta página de la wiki para ver un desglose de las versiones de SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Volcado de una Xbox DVT3. Tiene la misma palabra de configuración que P01. También tiene el ID de dispositivo grabado en el área de configuración como 0000 0000 000B 002A, a diferencia de los PICs de producción.

Le falta completamente el boot challenge.

## D01
Volcado de una Xbox XDK BETA 2. Idéntico a P01 excepto que le falta el boot challenge. La función para calcular la respuesta esperada del boot challenge sigue presente, pero nunca se llama.

## DXF
Volcado de un kit de depuración XDK D2. Muy similar a D01 pero con lógica de bandeja, sobrecalentamiento y arranque ligeramente diferentes. El boot challenge falta de la misma manera que en D01.

## D2E
Volcado de un kit de desarrollo Tuscany (v1.6). El chip Xyclops está marcado como X01202-001, y falta la línea A-A02 o A-B01 que tienen las unidades comerciales.

El código serial de depuración en FC00 coincide con el volcado minorista P2L. Hay un patrón extraño de datos desde 0x4000 hasta 0xFBFF.

## P01
Volcado de una Xbox v1.0. La palabra de configuración es 0x86:
- CP1:CP0 = 0 (Protección de código activada para toda la memoria)
- BODEN = 0 (Reset por caída de tensión desactivado)
- ~PWRTE = 0 (Temporizador de encendido activado)
- WDTE = 1 (Temporizador watchdog activado)
- FOSC1:FOSC0 = 2 (Oscilador HS)

Un valor de configuración de 0x3FB6 es adecuado para clones SMC para que no tengan protección de código activada.

## P11
Volcado de una Xbox v1.3. Misma palabra de configuración que P01.

Hay algunos cambios pequeños en P11 respecto a P01, incluyendo un comando SMBus adicional (escribir 0x22), diferentes prioridades de LED y tiempos más relajados para el arranque.

Verifiqué volcados cifrados de v1.3 contra v1.4 y coincidían. Esto significa que es muy probable que tengan el mismo programa.

## P2L
Extraído de una Xbox v1.6. Revisión Xyclops A-A02. Contiene código Intel 8051 pero tiene muchos registros de función especial cuya función es desconocida.

El puerto serie de depuración es controlado por el código en FC00. Parece un depurador rudimentario que puede pausar la ejecución, volcar datos y escribir en registros/RAM.

# Volcado de Xyclops

El chip Xyclops tiene 3 pines para 'depuración': TXD (pin 64), RXD (pin 63) y DEBUG (pin 29). Pon el pin DEBUG en alto para habilitar el puerto serie en los pines TX y RX. El puerto serie opera a 9600 baudios.

El protocolo se basa en comandos de 4 bytes que normalmente tienen el formato `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

El comando 0x14 vuelca 64 bytes de datos BIOS a la vez y el comando 0x15 vuelca 64 bytes de datos del programa SMC a la vez. Un volcado de Xyclops, P2L.bin, está incluido en el repositorio. También se incluye [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) para que puedas volcar tu propia máquina.

# Metodología de volcado de PIC
Informe completo en https://wiki.recessim.com/view/PIC_Burnout

El PIC tiene la protección de código habilitada, por lo que todos los datos se leen como 0000. Usé un truco para obtener datos cifrados en su lugar, descubrí el algoritmo de cifrado usando un chip sacrificado y luego utilicé una especie de exploit para cambiar los datos de la ROM y fijar algunos bits a valores conocidos. Así puedo extraer la información requerida de varios volcados cifrados para reconstruir los datos originales.

# PICProgrammer
PICProgrammer es uno de varios proyectos Arduino para el RP2040 que usé en mi investigación. Proporciona una interfaz de línea de comandos simple para ejecutar operaciones ICSP (programación serie en circuito) en el PIC. Se prefiere sobre el uso de un programador dedicado como el PICkit debido a su flexibilidad y la opción de hacer cosas que el fabricante no pretendía.

Debes tener un buen conocimiento de electrónica y programación antes de usar esto, y examinar cuidadosamente lo que hace cada comando antes de ejecutarlo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---