# Containerización

El paquete Containerización permite que las aplicaciones utilicen contenedores Linux.  
Containerización está escrito en [Swift](https://www.swift.org) y utiliza [Virtualization.framework](https://developer.apple.com/documentation/virtualization) en Apple silicon.

Containerización provee APIs para:

- [Gestionar imágenes OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interactuar con registros remotos](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Crear y poblar sistemas de archivos ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interactuar con la familia de sockets Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Crear un kernel Linux optimizado para tiempos rápidos de arranque](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Generar máquinas virtuales ligeras y administrar el entorno de ejecución](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Generar e interactuar con procesos containerizados](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Usar Rosetta 2 para ejecutar contenedores linux/amd64 en Apple silicon.

Por favor consulte la [documentación de la API](https://apple.github.io/containerization/documentation/) para información sobre los paquetes Swift que provee Containerización.

## Diseño

Containerización ejecuta cada contenedor Linux dentro de su propia máquina virtual ligera. Los clientes pueden crear direcciones IP dedicadas para cada contenedor para eliminar la necesidad de reenvío de puertos individual. Los contenedores logran tiempos de arranque en menos de un segundo usando una [configuración de kernel Linux optimizada](https://raw.githubusercontent.com/apple/containerization/main/kernel) y un sistema de archivos raíz minimalista con un sistema init ligero.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) es un pequeño sistema init, que es un subproyecto dentro de Containerización.  
`vminitd` se genera como proceso inicial dentro de la máquina virtual y provee una API GRPC sobre vsock.  
La API permite configurar el entorno de ejecución y lanzar procesos containerizados.  
`vminitd` provee E/S, señales y eventos al proceso que lo llama cuando un proceso se ejecuta.

## Requisitos

Se necesita un Mac con Apple silicon para compilar y ejecutar Containerización.

Para compilar el paquete Containerización, el sistema necesita:

- macOS 15 o superior y Xcode 26 beta  
- macOS 26 beta o superior

Las aplicaciones construidas usando el paquete correrán en macOS 15 o posterior, pero las siguientes características no están disponibles en macOS 15:

- Redes de contenedores no aisladas: con macOS 15, los contenedores en la misma red vmnet no pueden comunicarse entre sí.

## Ejemplo de uso

Para ejemplos de cómo usar algunas de las librerías, el ejecutable cctl es un buen punto de partida. La función principal de esta herramienta es como un espacio de prueba para la API. Contiene comandos que ejercitan algunas funcionalidades centrales de los diversos productos, tales como:

1. [Manipulación de imágenes OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Inicio de sesión en registros de contenedores](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Creación de bloques de sistema de archivos raíz](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Ejecución de contenedores Linux simples](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Kernel Linux

Se requiere un kernel Linux para generar máquinas virtuales ligeras en macOS.  
Containerización provee una configuración de kernel optimizada localizada en el directorio [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Este directorio incluye un entorno de construcción containerizado para compilar fácilmente un kernel para uso con Containerización.

La configuración del kernel es un conjunto mínimo de características para soportar tiempos rápidos de arranque y un entorno ligero.

Aunque esta configuración funciona para la mayoría de cargas de trabajo, entendemos que algunas necesitarán características adicionales.  
Para resolver esto, Containerización provee APIs de primera clase para usar diferentes configuraciones y versiones de kernel por contenedor.  
Esto permite desarrollar y validar contenedores en diferentes versiones de kernel.

Consulte el [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) en el directorio kernel para instrucciones sobre cómo compilar el kernel optimizado.

### Kernel precompilado

Si desea usar un kernel precompilado, debe tener los drivers `VIRTIO` compilados dentro del kernel, no como módulos.

El proyecto [Kata Containers](https://github.com/kata-containers/kata-containers) provee un kernel optimizado para contenedores con todas las opciones de configuración requeridas activadas, disponible en la página de [releases](https://github.com/kata-containers/kata-containers/releases/).

Una imagen de kernel llamada `vmlinux.container` puede encontrarse en el directorio `/opt/kata/share/kata-containers/` de los artefactos de la release.

## Preparar para compilar el paquete

Instale Swiftly, [Swift](https://www.swift.org) y [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Si usa una aplicación de terminal personalizada, puede que necesite mover este comando de `.zprofile` a `.zshrc` (reemplace `<USERNAME>`):

```bash
# Añadido por swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Reinicie la aplicación de terminal. Asegúrese de que este comando devuelva `/Users/<USERNAME>/.swiftly/bin/swift` (reemplace `<USERNAME>`):

```bash
which swift
```

Si ha instalado o usado anteriormente un Static Linux SDK, puede que necesite eliminar versiones antiguas del SDK del sistema (reemplace `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Compilar el paquete

Compile Containerización desde las fuentes:

```bash
make all
```

## Probar el paquete

Después de compilar, ejecute pruebas básicas e integradas:

```bash
make test integration
```

Se requiere un kernel para ejecutar las pruebas de integración.  
Si no tiene un kernel local, puede obtener uno por defecto usando el objetivo `make fetch-default-kernel`.

La descarga del kernel por defecto solo debe hacerse después de una compilación inicial o después de un `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerización depende de versiones específicas de `grpc-swift` y `swift-protobuf`. Puede instalarlos y regenerar las interfaces RPC con:

```bash
make protos
```

## Documentación

Genere la documentación de la API para visualización local con:

```bash
make docs
make serve-docs
```

Previsualice la documentación ejecutando en otra terminal:

```bash
open http://localhost:8000/documentation/
```

## Contribuciones

Las contribuciones a Containerización son bienvenidas y alentadas. Por favor consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) para más información.

## Estado del proyecto

La versión 0.1.0 es la primera versión oficial de Containerización. Versiones anteriores no garantizan estabilidad de código fuente.

Dado que la librería Containerización está en desarrollo activo, la estabilidad de código fuente solo está garantizada dentro de versiones menores (por ejemplo entre 0.1.1 y 0.1.2). Si no desea actualizaciones de paquete que potencialmente rompan el código, puede especificar la dependencia del paquete usando .upToNextMinorVersion(from: "0.1.0").

Futuras versiones menores del paquete pueden introducir cambios en estas reglas según sea necesario.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---