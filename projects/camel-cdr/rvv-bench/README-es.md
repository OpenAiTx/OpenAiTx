# Benchmark de vectores RISC-V

Una colección de benchmarks de vectores RISC-V (RVV) para ayudar a los desarrolladores a escribir código RVV portátil y eficiente.

Los resultados de los benchmarks pueden encontrarse en: https://camel-cdr.github.io/rvv-bench-results

## Benchmarks ([./bench/](./bench/))

Contiene varios benchmarks de diferentes implementaciones de ciertos algoritmos.

## Conteo de ciclos por instrucción ([./instructions/](./instructions/))

Mide el conteo de ciclos de las instrucciones RVV desenrollando y ejecutando en bucle la instrucción dada repetidamente.

## Primeros pasos

Comienza configurando [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk), de modo que `make` funcione y opcionalmente [./run.sh](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./run.sh), que te permite compilar y ejecutar usando `make run`.

La configuración por defecto debería funcionar con todas las compilaciones recientes de clang y no requiere una cadena de herramientas de compilación cruzada completa, porque se compila en modo freestanding.
Esto significa que solo funcionará en Linux, o en sistemas operativos compatibles con las llamadas al sistema de Linux.

En versiones recientes de Linux, los contadores de rendimiento no están expuestos por defecto, puede que tengas que ejecutar `echo 2 >/proc/sys/kernel/perf_user_access` y añadir `-DUSE_PERF_EVENT` a la línea `CFLAGS=...` en [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) (si eso no funciona, prueba con `-DUSE_PERF_EVENT_SLOW` en su lugar).

Puedes configurar [./config.mk](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./config.mk) para construir una compilación alojada o configurarlo con tu cadena de herramientas personalizada, añade la definición `-DCUSTOM_HOST` e implementa las funciones no implementadas bajo `#ifdef CUSTOM_HOST` en [./nolibc.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./nolibc.h).

XTheadVector ya no está soportado.

### Ejecutando benchmarks ([./bench/](./bench/))

Para ejecutar los benchmarks, primero revisa ([./bench/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/./bench/config.h)) y ajústalo a tu procesador (p. ej. configura `HAS_E64`). Si tarda demasiado en ejecutarse, intenta bajar `MAX_MEM`, que se usa para escalar el benchmark, y prueba con las otras constantes hasta que se ejecute en un tiempo razonable y proporcione un gráfico relativamente suave.

Ahora puedes simplemente ejecutar los benchmarks usando `make run` en el directorio ([./bench/](./bench/)), o `make` para solo compilar los ejecutables.

### Midiendo el conteo de ciclos ([./instructions/](./instructions/))

Para ejecutar la medición de conteo de ciclos, primero configura [instructions/rvv/config.h](https://raw.githubusercontent.com/camel-cdr/rvv-bench/main/instructions/rvv/config.h) para tu procesador.

Ahora puedes ejecutar la medición usando `make run` en el directorio ([./instructions/rvv/](./instructions/rvv/)), o `make` para solo compilar los ejecutables.

Para XTheadVector usa el directorio ([./instructions/xtheadvector/](./instructions/xtheadvector/)) en su lugar. (esto ya no se mantiene)
## Contribuyendo

Aquí hay algunas sugerencias de cosas que aún deben hacerse.

* contribuir con una medición de una nueva CPU en: https://github.com/camel-cdr/rvv-bench-results \
  Puedes simplemente crear un issue con un solo archivo json, que contenga todos los resultados concatenados de [./bench/](./bench/). (después de la configuración adecuada, `make run > out.json` debería funcionar). \
* implementar benchmarks no limitados por memoria
* implementar más benchmarks
* mejores mediciones del conteo de ciclos: rendimiento vs latencia (también: ¿podemos determinar la configuración del puerto de ejecución?)
* conteo de ciclos para cargas/almacenamientos
* conteo de ciclos para vsetvl

## Licencia

Este repositorio está licenciado bajo la MIT [LICENSE](LICENSE).




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---