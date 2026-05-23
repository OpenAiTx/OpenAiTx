# Ethereal

Un sistema operativo todo en uno personalizado, escrito para velocidad, conservación de memoria y fiabilidad.\
Anteriormente conocido como reduceOS

## ¿Qué es Ethereal?

Ethereal es un proyecto con el objetivo de crear un sistema operativo completamente funcional desde cero con todos los componentes que tendría un sistema operativo moderno.

Actualmente, el proyecto está desarrollando sus etapas en modo usuario.

## Capturas de pantalla

<img width="1925" height="1078" alt="image" src="https://github.com/user-attachments/assets/5f5725af-de16-43bf-9217-6db994f9ff2e" />\
*Entorno de escritorio moderno, 1080p*

<img width="1040" height="799" alt="image" src="https://github.com/user-attachments/assets/06835253-90cd-4785-a0f8-9f0042ac3676" />\
*Entorno principal de escritorio antiguo de Ethereal con DOOM*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ygmgdlm3dowe1.png?width=1620&format=png&auto=webp&s=0473ac09024c17cefb294c8570671e415866b915)\
*Ethereal arrancando en modo depuración*

![Ethereal but REALLY on IRC](https://github.com/user-attachments/assets/fedac2c5-db99-463f-88d9-44b1a239dcdd)\
*Ethereal en el chat de Libera (#ethereal)*

![](https://preview.redd.it/ethereal-smp-enabled-usb-supporting-multitasking-kernel-v0-ahe88a85dowe1.png?width=682&format=png&auto=webp&s=b435a1e0d57a91b7d4e0479f9649960b74a22de7)\
*Ethereal ejecutando DOOM*

![fixed](https://github.com/user-attachments/assets/bfdce356-5555-436b-990d-3aad65d22dea)\
*Ethereal ejecutando un clon de neofetch hecho para él (whatarewe)*

## Características

- Núcleo completo con soporte SMP
- Gestor de ventanas personalizado (Celestial)
- Soporte USB para controladores UHCI/EHCI/xHCI
- Soporte AHCI/IDE
- Pila de red con controlador para tarjetas de red E1000 y RTL8139
- Planificador round-robin basado en prioridades con una API bien probada
- Soporte para la biblioteca C `mlibc` y su amplia variedad de funciones
- Soporte completo de ACPI con la biblioteca ACPICA (con la biblioteca MinACPI de respaldo que no tiene análisis AML)

## Estructura del proyecto

- `base`: Contiene el sistema de archivos base. Los archivos en `base/initrd` van en el ramdisk inicial (para arranques que no son LiveCD) y los archivos en `base/sysroot` van en sysroot.
- `buildscripts`: Contiene scripts de compilación para el sistema de construcción
- `conf`: Contiene archivos de configuración misceláneos, como archivos de arquitectura, configuraciones de GRUB, archivos extra de arranque, etc.
- `drivers`: Controladores para Hexahedron, copiados según su configuración.
- `external`: Contiene proyectos externos, como ACPICA. Ver Componentes Externos.
- `hexahedron`: El proyecto principal del kernel
- `libkstructures`: Contiene estructuras misceláneas del kernel, como listas/mapas hash/analizadores/lo que sea
- `libc`: Contiene mlibc

## Compilación


### Aviso ACPICA

Si usas ACPICA (está activado por defecto), debes descargar el archivo tar desde [aquí](https://downloadmirror.intel.com/834974/acpica-unix-20240927.tar.gz) y extraerlo en `external/acpica/acpica-src`

De lo contrario, puedes editar `conf/build/<arch>.mk` y poner `USE_ACPICA` a 0.  

### Compilando

Para compilar Ethereal, necesitarás una cadena de herramientas Ethereal para tu arquitectura objetivo.\
La cadena de herramientas Ethereal se puede encontrar en [el repositorio](https://github.com/sasdallas/Ethereal-Toolchain)

Otros paquetes requeridos: `grub-common`, `xorriso`, `qemu-system`, `meson`, `ninja`

Edita `buildscripts/build-arch.sh` para cambiar la arquitectura objetivo de compilación. \
Ejecutar `make all` construirá una ISO en `build-output/ethereal.iso`

Actualmente, la falta de controladores de sistema de archivos en Ethereal significa que los arranques LiveCD suelen ser la mejor opción.\
El ramdisk inicial en un LiveCD es el sysroot, y si el sistema operativo detecta el arranque, copiará el ramdisk inicial a la RAM.

## Argumentos del kernel

Muchas veces, Ethereal falla al cargar. Esto es esperado. Por favor, abre un issue en GitHub.

Puedes resolver algunos problemas usando 'e' para abrir una configuración de GRUB y agregar algunos argumentos del kernel al final de la `entrada multiboot`.\
Aquí hay una pequeña lista:

- `--debug=`: Las opciones son `console` y `none`. Si es `console`, redirigirá la salida de depuración del kernel a la pantalla. Útil para depuración
- `--noload=`: Lista separada por comas de archivos de controlador (.sys) que no se cargarán. Controladores problemáticos: usb_xhci.sys, ahci.sys, ps2.sys (si no soporta PS/2),
- `--no-acpica`: Desactiva la biblioteca ACPICA y utiliza la implementación MinACPI como alternativa. Solo útil en casos extremos.
- `--no-acpi`: Desactiva todas las implementaciones ACPI. También desactiva SMP.
- `--disable-smp`: Activa ACPI, pero desactiva SMP
- `--disable-cow`: Desactiva copy-on-write. No recomendado, pero puede ser útil en casos extremos.
- `--no-psf-font`: No carga la fuente PSF desde initrd

## Componentes externos
Ciertos componentes externos están disponibles en `external`, `libc` y otras partes del kernel. Aquí hay una lista de ellos y sus versiones:
- ACPICA UNIX* (Licencia Intel): Versión 20240927 [disponible aquí](https://www.intel.com/content/www/us/en/developer/topic-technology/open/acpica/download.html)
- biblioteca matemática libmusl (Licencia MIT): [disponible aquí](https://github.com/kraj/musl)
- freetype (licencia GPL): [disponible aquí](https://sourceforge.net/projects/freetype/)
- mlibc (licencia MIT): [Fork Ethereal disponible aquí](https://github.com/sasdallas/mlibc)
- tinf (licencia zlib): [disponible aquí](https://github.com/jibsen/tinf/)
- json-parser (licencia BSD de 2 cláusulas): [disponible aquí](https://github.com/json-parser/json-parser)
- PlutoSVG (licencia MIT): [disponible aquí](https://github.com/sammycage/plutosvg)

## Créditos

Gran parte del diseño de Ethereal fue inspirado por [ToaruOS de klange](https://github.com/klange/ToaruOS) - ¡gracias!

El diseño del gestor de memoria virtual de Ethereal y otras partes fue inspirado por [Astral de @mathewnd](https://github.com/mathewnd/Astral)

También se utilizó algo de código de Astral, acreditado donde corresponde. Se incluye un archivo de licencia en `external/`.

El logo de Ethereal y el tema Mercury fueron diseñados por la artista [ArtsySquid](https://artsycomms.carrd.co)

## Licenciamiento

Hexahedron y todos los demás componentes no externos de Ethereal están bajo los términos de la licencia BSD de 3 cláusulas (disponible en LICENSE).\
Todos los archivos, a menos que se especifique en el encabezado de copyright, están bajo esta licencia. Cualquier archivo sin encabezado de copyright NO está protegido por BSD de 3 cláusulas.

**PROBLEMAS DE LICENCIA:** Si se encuentra un archivo sin comentarios apropiados, contácteme inmediatamente (preferiblemente a través de un canal público como issues de GitHub para transparencia) directamente para resolverlo.

El objetivo de Ethereal **NUNCA** ha sido apropiarse de código, pero ha ocurrido en el pasado. ¡Por favor contácteme!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-23

---