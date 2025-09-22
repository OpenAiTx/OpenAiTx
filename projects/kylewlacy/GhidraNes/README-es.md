# GhidraNes

Una extensión de Ghidra para soportar el desensamblado y análisis de ROMs de NES.

![Desensamblado de Ghidra mostrando una función decompilada de un archivo llamado "game.nes"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## Características

- Importar ROMs de NES en el formato iNES. Se soportan los siguientes mappers:
    - PRG ROM fija de 16K/32K
        - [NROM](https://www.nesdev.org/wiki/NROM) (mapper 0)
        - [CNROM](https://www.nesdev.org/wiki/CNROM) (mappers 3, 185)
        - [CPROM](https://www.nesdev.org/wiki/CPROM) (mapper 13)
    - PRG ROM bancable de 16K
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1) (mapper 1, incluye también el mapper 16)
        - [UxROM](https://www.nesdev.org/wiki/UxROM) (mapper 2)
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4) (mapper 10)
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512) (mapper 30)
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068) (mappers 67, 68)
        - Mapper misceláneo [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - PRG ROM bancable de 32K
        - [AxROM](https://www.nesdev.org/wiki/AxROM) (mapper 7)
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034) (mapper 34)
        - [GxROM](https://www.nesdev.org/wiki/GxROM) (mapper 66)
        - Mappers misceláneos [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - PRG ROM bancable de 8K
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119) (mappers 4, 118, 119)
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019) (mapper 19)
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4) (mappers 21, 22, 23, 25)
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1) (mappers 64, 158)
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7) (mapper 69)
        - [DxROM](https://www.nesdev.org/wiki/DxROM) (mapper [206](https://www.nesdev.org/wiki/INES_Mapper_206))
        - Mappers misceláneos [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- Añade etiquetas y bloques de memoria en el desensamblado, ¡haciendo más fácil navegar por una ROM desensamblada!

## Instalación

1. Instalar una versión compatible de Java y Ghidra (Java 21+).
2. Descargar la última [versión de GhidraNes](https://github.com/kylewlacy/GhidraNes/releases). ¡Asegúrate de que la versión descargada coincida con tu versión de Ghidra!
3. Ve a "Archivo" > "Instalar Extensiones...". Haz clic en "+" en la esquina superior derecha y elige el archivo Zip de GhidraNes. Haz clic en "OK" para instalar la extensión.
4. Reinicia Ghidra.

## Uso

1. En Ghidra, crea un nuevo proyecto siguiendo el asistente en "Archivo" > "Nuevo Proyecto...".
2. Arrastra y suelta una ROM iNES `.nes` en el proyecto. Configura el formato como "NES ROM" y haz clic en "OK".
3. Haz doble clic en la ROM dentro del proyecto para abrir el CodeBrowser de Ghidra.
4. Analiza el archivo cuando se te solicite (o ve a "Análisis" > "Análisis Automático..."). Deja las configuraciones por defecto y haz clic en "Analizar".
5. ¡Listo, el juego será desensamblado! En el lado izquierdo, bajo "Árbol de Símbolos" > "Funciones", abre `reset` para saltar al vector de reinicio (donde comienza la ejecución), o `vblank` para saltar al vector NMI (donde la ejecución va durante el VBlank).

## Notas

### Cambio de bancos

GhidraNes asigna cada banco de la ROM a su propio bloque de memoria, pero no hay un análisis de flujo de control implementado que maneje el cambio de bancos automáticamente. En su lugar, el manejo del cambio de bancos en el desensamblado es un proceso manual. Toma esta función como ejemplo:

![Desensamblado de Ghidra mostrando una función "reset" que consiste en "LDA #0x0", "STA DAT_8000", y "JMP (0xfffc)=>reset". La margen muestra esta función como un bucle infinito](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)

Esta función desensamblada está haciendo un cambio de banco: la escritura a `DAT_8000` cambia el PRG ROM al banco 0 en este caso. Casos como este pueden corregirse en Ghidra usando los siguientes pasos:

1. Haz clic derecho en la instrucción `JMP`
2. Haz clic en "Referencias > Agregar/Editar (R)"
3. Haz doble clic en el operando de destino
4. En el campo "A Dirección", cambia el desplegable izquierdo de "RAM:" al banco de memoria apropiado ("PRG0::" para este ejemplo)
5. Haz clic en "Actualizar"

El desensamblado ahora debería mostrar un salto al banco correcto:

![Desensamblado de Ghidra mostrando la misma función "reset", pero la instrucción "JMP" ahora va a "(0xfffc)=>LAB_PRG0__ffaf"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)

> Nota: Cualquier instrucción de escritura (por ejemplo, `STA`/`STX`/`STY`, `INC`/`DEC`) a un registro del mapeador causará que el flujo de control cambie si el banco que contiene el código actualmente en ejecución es cambiado. Para corregir esto:
>
> 1. Haz clic derecho en la instrucción de escritura
> 2. Elige `Continuación`>`Establecer...`
> 3. Recuerda el valor en la caja de desplazamiento de dirección
> 4. Selecciona `Usuario`, y elige el nuevo banco del menú desplegable.
> 5.  Establece la caja de desplazamiento de dirección al valor del paso 3 (ya que el PC seguirá siendo la instrucción "siguiente" en el nuevo banco).
>
>Esto debería ayudar con el análisis y la descompilación para que puedan "seguir" el cambio de banco.
Por defecto, las ROMs con tamaños de bloque PRG de menos de 32K se crean con una dirección base de `0x8000` excepto para el último banco, que estará en la dirección "más alta" para ese banco (los bloques de 8K estarán en `0xe000`, los de 16K en `0xc000`).  Puede usar el diálogo `Opciones...` al cargar para establecer la dirección de cada banco si sabe de antemano dónde debería estar cada banco.  Si luego determina que la suposición fue incorrecta y no quiere volver a importar la ROM, puede cambiar la base del banco usando la ventana Mapa de Memoria:

1. Seleccione el menú `Ventana`>`Mapa de Memoria` si no lo tiene abierto ya.
2. Seleccione la fila con el banco que desea cambiar.
3. Seleccione el icono de cruz azul ("Mover un bloque a otra dirección") en la barra de título de la ventana Mapa de Memoria.
4. Cambie la "Nueva Dirección de Inicio" a la dirección base correcta. La "Nueva Dirección de Fin" debería actualizarse automáticamente en función del tamaño del bloque.
5. Seleccione "Aceptar" y el banco se actualizará.

## Desarrollo

### Desarrollo con Eclipse

1. Instale Java y Ghidra.
2. Instale Eclipse.
3. Instale el plugin GhidraDev para Eclipse. Las instrucciones se encuentran en el directorio de instalación de Ghidra, bajo `Extensions/Eclipse/GhidraDev/GhidraDev_README.html`.
4. En Eclipse, abra el repositorio GhidraNes yendo a "Archivo" > "Abrir proyectos desde sistema de archivos...". Haga clic en "Directorio", luego elija este repositorio (la carpeta _principal_ que contiene este archivo `README.md` y el subdirectorio `GhidraNes`). Finalmente, haga clic en "Finalizar".
5. Abra "GhidraDev" > "Vincular Ghidra...". Añada su instalación de Ghidra, haga clic en "Siguiente >", luego seleccione "GhidraNes" como proyecto Java. Haga clic en "Finalizar".
6. Vaya a "Ejecutar" > "Ejecutar como" > "Ghidra" para ejecutar Ghidra con la extensión GhidraNes.

### Construir una versión desde Eclipse

**NOTA:** Asegúrese de que el proyecto Eclipse GhidraNes esté configurado con la versión _más antigua_ de Java que se desea soportar. ¡Usar una versión posterior de Java puede causar problemas de compatibilidad!

1. Instale Gradle (con [SDKMAN](https://sdkman.io/), esto se puede hacer con `sdk install gradle`).
2. En Eclipse, abra "GhidraDev" > "Exportar" > "Extensión de módulo Ghidra...". Elija "GhidraNes" como proyecto, haga clic en "Siguiente >", luego seleccione "Directorio de instalación local:" y navegue hasta su directorio de instalación de Gradle (con SDKMAN, estará en `~/.sdkman/candidates/gradle/$GRADLE_VERSION`). Haga clic en "Finalizar".
3. El archivo zip construido se guardará en el directorio `GhidraNes/dist/`. Consulte la sección "Instalación" para detalles sobre cómo instalar el zip generado.

### Desarrollo con otro editor (como VS Code)

1. Instale Java y Ghidra.
2. Configure los ajustes del JDK en su editor.
    - Para VSCode: Siga la guía oficial ["Comenzando con Java en VS Code"](https://code.visualstudio.com/docs/java/java-tutorial).
3. Copie el archivo `GhidraNes/gradle.properties.example` a `GhidraNes/gradle.properties` y configure el directorio de instalación de Ghidra según sea necesario.
4. Importe el repositorio GhidraNes como proyecto Java (la carpeta _principal_ que contiene este archivo `README.md` y el subdirectorio `GhidraNes`).

### Construir una versión con Gradle

1. Cambie al subdirectorio interno `GhidraNes`: `cd GhidraNes/GhidraNes`
2. Ejecute `gradle buildExtension`

    - Si el archivo `gradle.properties` no ha sido configurado, las propiedades pueden pasarse directamente a Gradle, por ejemplo, `gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. El archivo zip generado se guardará en el directorio `GhidraNes/dist/`. Consulte la sección "Instalación" para obtener detalles sobre cómo instalar el zip generado.

## Publicar una versión

1. Actualice `CHANGELOG.md` como un nuevo commit
2. Cree una etiqueta para la nueva versión. La etiqueta y el nombre de la versión deben llamarse `vYYYYMMDD` según la fecha actual [en UTC](https://www.utctime.net/) (por ejemplo, `v20250520`)
3. Empuje la etiqueta. Esto activará el ["workflow de GH Actions 'Release'"](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml), que creará un nuevo [borrador de versión](https://github.com/kylewlacy/GhidraNes/releases) con notas de lanzamiento y activos de compilación después de unos minutos
4. Verifique que los activos de compilación estén correctos, ajuste o añada a las notas de la versión si es necesario, ¡y publique!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---