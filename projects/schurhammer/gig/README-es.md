# gig

Gig es un compilador de gleam escrito en gleam.

## Cómo usar

### Compilar y ejecutar un archivo de ejemplo:

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
- Esto compilará el archivo `samples/hello_world.gleam` a `samples/hello_world.c` y luego usará un compilador de C para crear el binario en `samples/hello_world.exe`.
- Gig añade la extensión `.exe` para evitar conflictos comunes de nombres con directorios de código fuente.

### Compilar gig:


```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```

### Compila tu proyecto usando el binario gig:

- Añade el ejecutable `gig` a tu ruta o cópialo en tu proyecto.
- Copia el directorio `patch` en tu proyecto.

```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
- Debes ejecutar gig desde el directorio raíz del proyecto.  
- Gig incluirá archivos fuente del directorio del módulo principal, el directorio `patch` y cada directorio fuente de las dependencias descargadas (es decir, `build/packages/<package_name>/src`).  
- Descarga las dependencias usando `gleam deps download`.  
- Tu módulo principal debe estar no anidado, es decir, directamente en el directorio `src`.  

### Compila tu proyecto usando gig como dependencia de ruta  

- Añade gig como dependencia de ruta en tu archivo `gleam.toml` `gig = { path = "../gig" }`.  
- Copia el directorio `patch` dentro de tu proyecto.


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```

### Banderas opcionales:

- `--release`: habilitar optimización.
- `--gc`: habilitar recolección de basura (de lo contrario no hay recolección de basura).
- `--debug`: incluir símbolos de depuración.
- `--headers`: generar archivos de cabecera para funciones FFI.
- `--compiler=name`: el nombre/ruta del compilador c.
- `-c`: solo generar el archivo c (no el binario).

> [!IMPORTANTE]
> En el caso probable de que encuentres desbordamientos de pila, aumenta el tamaño de tu pila. Estos suelen aparecer como fallos de segmentación.
>
> ```
> ulimit -s unlimited
> ```

## Dependencias Requeridas:

- Compilador C (clang parece funcionar mejor)
- Boehm GC es necesario para `--gc` (también llamado `libgc`)

## Biblioteca Estándar

Dado que gran parte de la biblioteca estándar está implementada con llamadas `@external`, no todas las funciones están disponibles en este momento.
Algunas funciones ya han sido reimplementadas con parches, ver el directorio `patch`. El compilador mostrará una advertencia si se usa una función no implementada, y se usará un "todo" como cuerpo de la función.

## Sistema de Parches

Dado que gig es un proyecto de terceros, la mayoría de las bibliotecas gleam en el ecosistema
probablemente no lo soporten. Para estas situaciones tenemos un sistema de parches que
te permite sobrescribir algunos módulos que de otro modo no funcionarían. Para hacer esto simplemente
crea un módulo llamado `x.patch.gleam` donde `x` es el nombre del módulo
que deseas parchear. El parche se fusionará con el módulo original, por lo que
solo necesitas implementar las funciones que están rotas.
Los parches pueden colocarse en el directorio `patch` o en cualquiera de los directorios de código fuente.

Para mejor soporte del lenguaje c en tu editor, puedes agregar un archivo `.clangd` y
`compile_flags.txt` a tu proyecto.

`.clangd`:

```
CompileFlags:
  Add: [-Ipatch]
```
`compile_flags.txt`: (archivo vacío)

## FFI

Puedes usar la anotación `@external(c, "", "function_name")` para definir funciones C,  
similar al FFI en gleam normal.  
Después de esto, ejecuta el compilador con la opción `--headers` para generar un archivo  
de encabezado con las declaraciones de funciones y tipos requeridas para implementar la función externa.  
Tu archivo de implementación en C debe `#include` el archivo de encabezado y debe llamarse de la  
misma manera que el archivo de encabezado.  
Preferiblemente, tus funciones deberían tener un espacio de nombres, por ejemplo, `module_name_function_name()`.

## Lista de características / tareas pendientes

### Básicos

- [x] Bool  
- [x] Int  
- [x] Float  
- [x] Formatos numéricos (distintos a decimal)  
- [x] String  
- [x] Lista  
- [x] Igualdad  
- [x] Asignaciones  
- [x] Patrones de descarte  
- [x] Inferencia de tipos  
- [x] Anotaciones de tipos  
- [x] Módulos (nota: los módulos se resuelven relativos al archivo objetivo)  
- [x] Dependencias  
- [x] Importaciones no calificadas  
- [x] Alias de tipos  
- [x] Bloques  
- [x] Constantes  
- [x] Gestión de memoria (GC/RC)

### Funciones

- [x] Funciones  
- [x] Funciones de orden superior

- [x] Funciones anónimas
- [x] Capturas de funciones
- [x] Funciones genéricas
- [x] Pipelines
- [x] Argumentos etiquetados
- [ ] Comentarios de documentación (ignorados)
- [ ] Deprecaciones (ignoradas)

### Control de flujo

- [x] Expresiones case
- [x] Patrones de variables
- [x] Patrones de constructores
- [x] Patrones de cadenas
- [x] Patrones de listas
- [x] Recursión
- [ ] Llamadas en cola (nota: el compilador c puede hacer esto por nosotros)
- [x] Múltiples sujetos
- [x] Patrones alternativos
- [x] Alias de patrones
- [x] Guards
- [ ] Verificación de exhaustividad

### Otros tipos de datos

- [x] Tuplas
- [x] Tipos personalizados
- [x] Registros
- [x] Accesores de registros
- [x] Actualizaciones de registros
- [x] Tipos personalizados genéricos
- [x] Resultados
- [ ] Arreglos de bits (soporte parcial)

### Características avanzadas

- [ ] Tipos opacos
- [x] Uso
- [x] Todo
- [x] Panic
- [x] Dejar assert
- [x] Externos

## Contribuyendo

No estoy aceptando contribuciones de código en este momento. Sin embargo, siéntase libre de crear problemas, sugerencias o discusiones.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---