# Ventoy CPIO

Un ramdisk alternativo para [Ventoy](https://github.com/ventoy/Ventoy).

La documentación está disponible [aquí](https://github.com/fnr1r/ventoy-meta/tree/main/docs)
y las versiones [aquí](https://github.com/fnr1r/ventoy-cpio/releases).

NOTA: Esto es solo una pequeña parte de mi intento por añadir un sistema de compilación razonable
a Ventoy. Un índice de todos mis proyectos relacionados con Ventoy se puede encontrar
[aquí](https://github.com/fnr1r/ventoy-meta).

## Objetivo

Crear un ramdisk de reemplazo para Ventoy

- [?] con un sistema de compilación más razonable
- [x] que sea arrancable
- [ ] funcionalmente idéntico  
  (es decir, que pueda hacer lo mismo que el oficial)
- [x] más pequeño

### No objetivos

- ❌ un ramdisk binario idéntico al oficial
  - compilar binarios idénticos con las instrucciones dadas sería casi
  imposible y en última instancia inútil
  - sin embargo, los ramdisks construidos con este proyecto deberían ser reproducibles

### Posibles cambios futuros

- Eliminar sufijos de los binarios (son molestos e inconsistentes)  
  (no requiere cambios en upstream)
- Dividir los ramdisks en x86 32-bit y 64-bit  
  (requiere cambios en grub)
- Limpiar los scripts shell en el ramdisk  
  (no requiere cambios en upstream)

## Progreso

Arranca, pero algunas funcionalidades podrían no funcionar.

### ventoy.cpio

100%, ya que literalmente solo es comprimir con xz un conjunto de archivos.

Relación de tamaño:

- du - 1 (64 / 64)
- ls -l - 1 (62976 / 62976)

### ventoy_ARCH.cpio

~75%

Todas las herramientas están aquí (en su mayoría), compiladas de una forma u otra. Ahora solo queda
la optimización.

Relación de tamaño (x86):

- du - 0.8540245566166439 (2504 / 2932)
- ls -l - 0.8624375107740045 (2561536 / 2970112)

Relación de tamaño (arm64):

- du - 0.8159806295399516 (1348 / 1652)
- ls -l - 0.8159490600363857 (1377792 / 1688576)

Relación de tamaño (mips64):

- du - 0.9816849816849817 (1072 / 1092)
- ls -l - 0.981642955484167 (1095168 / 1115648)

### vtloopex.cpio

PENDIENTE: agregar esto

## Uso

### Compilación

```sh
docker compose build
```

```sh
docker compose up
```

Pista:

Si no quieres volver a descargar los archivos cada vez que reconstruyas el contenedor,
ve a `docker/base/{dietlibc,musl,toolchains}`, revisa el script de configuración
y descarga manualmente el archivo con `wget`.

También puedes ejecutar esto para entrar al contenedor:

```sh
docker run -it --rm \
  -v ".:/build" \
  ventoy-cpio-builder:latest \
  bash
```

### Configuración

Una vez que tengas los archivos `ventoy*.cpio`:

1. Monta la segunda partición en tu USB Ventoy
1. !!! HAZ UNA COPIA DE SEGURIDAD DE LOS ARCHIVOS ORIGINALES `ventoy*.cpio` !!!
1. Copia el cpio que quieres probar. (pista: si no sabes cuál es,
  probablemente sea `ventoy_x86.cpio`)

## Mini TAREA

- Compilar con una versión más antigua de los encabezados de Linux para compatibilidad

## Notas

- [En términos de GCC](https://gcc.gnu.org/onlinedocs/gccint/Configure-Terms.html):
  - Se asume que la compilación es para *nix x86_64
  - Se asume que el host (para las herramientas de instalación de ventoy) es x86_64
  - Los objetivos son x86_64, i386, aarch64 y mips64el


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---