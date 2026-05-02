# Magia del Clic Derecho en Windows

Magia del Clic Derecho en Windows es un conjunto de herramientas de menú contextual (clic derecho) para administradores, usuarios avanzados y otros seres mágicos. Si te consideras un mago y quieres ahorrarte algo de tiempo y dolores de cabeza, este es el conjunto *correcto* de herramientas de menú contextual para ti.

Este pequeño paquete mágico incluye:
- opción para añadir el antiguo menú contextual en Windows 11
- robocopy para copiar y mover directorios (mucho más rápido que la copia normal)
- robocopy también funciona para copiar/mover a través de recursos compartidos en red
- pegar desde el portapapeles (con robocopy)
- SCP desde/hacia
- abrir ventanas CMD o powershell en carpetas o unidades
- ejecutar scripts como Administrador para scripts .ps1
- tomar posesión de archivos o directorios con recursión (takeown && icacls)
- opciones para arrancar en Modo Seguro
- opción para Reiniciar en Recuperación
- abrir el Panel de Control desde el Escritorio
- ejecutar programas con prioridad personalizada
- opción para siempre abrir cmd como administrador
- crear enlaces simbólicos/difíciles
- abrir "Modo Dios"
- reiniciar/apagar en x segundos
- opciones para Mover a / Enviar a carpeta (desde Windows 7)
- cerrar sesión desde el fondo de escritorio
- abrir Modo Dios
- opciones para desinstalar los cambios que hayas hecho
- deshabilitar UAC
- habilitar Rutas Largas (rutas de más de 260 caracteres)

También puedes eliminar algunas opciones del menú de clic derecho, para que tu menú no se vuelva demasiado saturado:
- Anclar a Acceso rápido
- Anclar a Pantalla de Inicio
- Incluir en Biblioteca
- Enviar a
- Compartir
- Añadir a Windows Media Player
- Escanear con Windows Defender

Otras eliminaciones:
- pestaña "Versión" dentro del explorador


TODO (la magia toma tiempo):
- takeown para archivos (.exe y otros)
- uniones de directorios para múltiples archivos/carpetas
- pwsh abierto con privilegios de administrador
- agregar otras herramientas de administrador al clic derecho en el fondo
- tus sugerencias


![Ejemplos de magia](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/RCWM.gif)


# Instalación


Para instalar las herramientas: descarga el archivo zip más reciente en releases ([aquí](https://github.com/GChuf/RCWM/releases/latest)), descomprímelo y ejecuta el script install.cmd __como administrador__ - después de eso, solo necesitarás las dos teclas más usadas: __*Y*__ y __*N*__ (y tal vez algunas otras).
Si el usuario que ejecuta los comandos RCWM no tiene privilegios de administrador, algo de la magia podría no funcionar correctamente.


# ¿Cómo funciona?

Magia, básicamente. También algo de código spaghetti.

Actualmente, la magia ocurre dentro del registro de Windows con algo de ayuda de scripts batch y powershell.

El objetivo era automatizar herramientas de línea de comandos como robocopy, para que 1) todos pudieran usarlo, y 2) ahorrara tiempo a quienes ya saben cómo usarlo. Mientras automatizaba las tareas, accidentalmente descubrí que podía automatizar mucho más de lo que pensaba - y ahora, puedes seleccionar múltiples carpetas para copiar/mover y pegarlas todas en una sola carpeta, igual que con la copia lenta y perezosa de la GUI de Windows.


# RoboCopy: Opciones para copiar y mover ítems

Copiar/Pegar y Mover Archivo/Directorio usan robocopy para hacer el trabajo. 
Tienes dos opciones: puedes copiar directorios múltiples o uno solo a la vez.

__Único__:
El archivo/carpeta (ruta del directorio) a copiar (cuando haces clic derecho en "Copiar") se escribe en el registro y __sobrescribe__ cualquier ruta de carpeta previa almacenada allí. Si especificas una nueva carpeta para copiar, la antigua (si existe) será sobrescrita.

__Múltiple__:
La lista de rutas de archivos/carpetas a copiar se __agrega__ al registro bajo las claves *HKCU:\SOFTWARE\RCWM\{rcopy || rcmov}*. Luego el script recorre un bucle en powershell para copiar todas ellas.

Por defecto, solo puedes seleccionar hasta 15 carpetas para copiar (el límite predeterminado de Windows para opciones de clic derecho es 15, puedes aumentarlo a 31 o más en el script de instalación - consulta el archivo *MultipleInvokeMinimum.reg* para más información). Copiar/mover recursivamente tampoco es un problema (puedes tener tantos subdirectorios como quieras).
Usa esta opción si planeas usar RoboCopy mucho. Puedes leer el archivo powershell rcp.ps1 para entender cómo funciona el script.

Copiar (múltiples) versus Mover (único):

![Único vs Múltiples](https://raw.githubusercontent.com/GChuf/RCWM/magic/img/sm.gif)

# RoboCopy: otras opciones

También puedes pegar carpetas que seleccionaste con ctrl+c. La opción se llama "Pegar desde portapapeles".
Además, también puedes usar la opción de espejo (/MIR) para reflejar un directorio. Esto solo funciona si reflejas el directorio en algún lugar donde ya existe un directorio con el mismo nombre.

# Errores conocidos

- TakeOwn no funciona correctamente al hacer clic derecho en una gran cantidad de carpetas (los permisos de algunas carpetas no se cambian - por lo que necesitas hacerlo dos veces).
Cambiar la propiedad de grandes cantidades de carpetas recursivas funciona bien, sin embargo.
- Ejecutar con Prioridad no mostrará el menú para elegir con qué prioridad ejecutar un programa - por favor reporta si esto te sucede.
- rmdir y robocopy a veces necesitan privilegios de administrador (robocopy lanza error 5) - si experimentas esto, takeown o siempre ejecutar cmd como admin ayudará.

# Pruebas
RoboCopy es mucho más rápido para copiar una gran cantidad de archivos pequeños.
RmDir (del y rd) también es más rápido que el borrado "estándar" y que la opción /MIR de robocopy cuando se usa un directorio vacío.

Resultados de pruebas en mi máquina con disco SSD:
Información de carpeta: 1.73GB / 12 089 archivos
- rcopy/copia normal: 43s/91s
- rmdir/borrado normal: ~ 3s/4.5s

Los resultados pueden variar según tu computadora y disco - pero donde haya muchos archivos pequeños, deberías beneficiarte.

# Seguridad

RCWM v2 tuvo algunos problemas debido al script ps2exe, y su salida siendo marcada por antivirus.
Ahora he dejado de usar ps2exe.

Todos los archivos .exe están verificados y marcados como seguros por virus total (los archivos se usan para guardar rutas de carpetas en el registro bajo HKCU):

[rcwm-single.exe](https://www.virustotal.com/gui/url/3f1d93268323b721b956ac7a015e80a68768fedf34adbbb022b660c06b7f2efb?nocache=1)



[rcwm-multiple.exe](https://www.virustotal.com/gui/url/bcf252d68d68198eb304682dc070f0bed0b14fa159add7e6766c3c41b1feff86?nocache=1)

[RCWMInit.exe](https://www.virustotal.com/gui/url-analysis/u-13bb952212b2d23dce18713803085437b31180b593acb4f4f2d13753269e2db3-21bd70f1?nocache=1)

# Contribuir

Siempre puedes crear un PR o abrir un nuevo issue, respecto a errores o sugerencias.

# Soporte

El objetivo del proyecto es facilitar la vida a los demás.

Marcar el proyecto con estrella ayuda a que más personas lo conozcan.

Si quieres, puedes invitarme a un ~~café~~ cerveza:

- paypal.me: paypal.me/gchuf

- btc: 16BRUTbKu3tSuS9SudCoP7qHreNs6sAp8d

- eth: 0x75240bb1d3fac69954e980ec53d1c93a2d140389

- ltc: LWtm2gXdr29HhaiaXytnaz799RwYbxhz2d

# Créditos

Los archivos para Arrancar en Modo Seguro y Ejecutar con Prioridad fueron fuertemente influenciados por Shawn Brink en [tenforums.com](https://www.tenforums.com/tutorials/1977-windows-10-tutorial-index.html)

Los archivos TakeOwn.reg para Tomar Posesión fueron fuertemente influenciados por Vishal Gupta en [AskVG.com](https://www.askvg.com/) y Shawn Brink.

La opción Reiniciar en Recuperación fue encontrada en algún lugar de Internet hace un tiempo. Desafortunadamente, no recuerdo quién es el autor original.

La idea de Ejecutar script como Administrador fue encontrada aquí: https://ss64.com/ps/syntax-elevate.html

Cambié y adapté todos esos archivos, pero sus ideas y las implementaciones iniciales merecen el crédito.

Todo lo demás es trabajo propio, con la ayuda de Internet.

# Descargas

![Downloads](https://img.shields.io/github/downloads/GChuf/RCWM/total?label=TotalDownloads)

![Downloads-Latest](https://img.shields.io/github/downloads/GChuf/RCWM/latest/total?label=LatestReleaseDownloads)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-02

---