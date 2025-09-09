# pproftui: Perfilado interactivo de Go en tu terminal

`pproftui` es una interfaz de usuario basada en terminal para `pprof` de Go que hace que el perfilado sea interactivo, intuitivo y rápido. Está diseñado para ayudarte a identificar problemas de rendimiento sin cambiar de contexto a un navegador web y para proporcionar explicaciones integradas sobre conceptos de perfilado.

![Demo](https://raw.githubusercontent.com/Oloruntobi1/pproftui/main/./demo.gif)

---

## ¿Por qué `pproftui`?

La herramienta estándar `go tool pprof` es potente pero puede ser poco intuitiva. A menudo te quedas preguntando:
*   "¿Qué significa realmente `flat` vs `cum`?"
*   "¿Cuál de estas 100 funciones de runtime es *mi* código?"
*   "¿Cómo encuentro qué cambió entre esta versión y la anterior?"
*   "¿Por qué tengo que seguir cambiando entre mi navegador y mi código?"

`pproftui` resuelve estos problemas directamente:
*   **Vistas integradas de código fuente y gráfico:** Ve el código fuente de cualquier función o navega su gráfico de llamadas sin salir de tu terminal.
*   **Enfoque en tu código:** Resalta automáticamente las funciones de tu proyecto. Presiona `p` para ocultar instantáneamente todo el ruido del runtime y los proveedores.
*   **Comparación poderosa e intuitiva:** Compara dos perfiles para ver no solo *qué* cambió, sino *por qué*. La UI te ayuda a rastrear la fuente de una regresión a través de la pila de llamadas.
*   **Perfilado en vivo:** Apunta `pproftui` a un servicio en ejecución y observa su perfil actualizarse en tiempo real.
*   **Ayuda integrada (F1):** Obtén explicaciones claras y simples de términos de perfilado (`cpu`, `inuse_space`, `flat` vs `cum`) justo cuando las necesitas.

---

## Primeros pasos

### Instalación
```sh
go install github.com/Oloruntobi1/pproftui@latest
```

### El Recetario: Flujos de Trabajo Comunes de Perfilado

Aquí hay recetas prácticas para resolver problemas comunes de rendimiento con `pproftui`.

#### Receta 1: Investigar una Lentitud en un Binario Local
Has notado que una función es lenta. Vamos a obtener un perfil de CPU y explorarlo.

1.  **Generar el perfil:**
    ```sh
    go test -bench=. -cpuprofile=cpu.prof
    ```
2.  **Analízalo con `pproftui`:**

    ```sh
    pproftui cpu.prof
    ```
    *   Presione `c` para alternar entre la vista del código fuente y el gráfico de llamantes/llamados.
    *   Presione `F1` en cualquier momento si no está seguro del significado del tipo de perfil.

#### Receta 2: Encontrar una regresión de rendimiento (El flujo de trabajo Diff)
Sospecha que un commit reciente hizo que las cosas sean más lentas. El diffing de `pproftui` es su superpoder.

1.  **Obtenga un perfil de su rama `main`:**
    ```sh
    git checkout main
    go test -bench=. -cpuprofile=main.prof
    ```
2.  **Obtén un perfil de tu rama de características:**

    ```sh
    git checkout your-feature-branch
    go test -bench=. -cpuprofile=feature.prof
    ```
3.  **Comparar diferencias:**

    ```sh
    pproftui main.prof feature.prof
    ```
    `pproftui` ahora te mostrará el *delta*. Verde (`+`) significa que se usaron más recursos en `feature.prof`, rojo (`-`) significa menos. Usa esto para navegar por el gráfico y encontrar la función exacta que introdujo la nueva sobrecarga.

#### Receta 3: Perfilando un Servicio en Vivo
Quieres ver cómo se comporta tu aplicación bajo carga en un entorno de pruebas.

1.  **Asegúrate de que tu app exponga los endpoints de pprof.** (por ejemplo, importando `net/http/pprof`)
2.  **Ejecuta `pproftui` en modo en vivo:**
    ```sh
    # This will fetch a 5-second CPU profile every 10 seconds.
    pproftui -live="http://localhost:6060/debug/pprof/profile?seconds=5" -refresh=10s
    ```
    *   Presione `espacio` para pausar y reanudar las actualizaciones en vivo.

#### Receta 4: Cortando el Ruido
Los perfiles están llenos de código de tiempo de ejecución y de biblioteca. Aquí se explica cómo centrarse en lo que importa: **tu código.**

```sh
# Provide your project's go module path
pproftui --module-path="github.com/your/project" cpu.prof
```
*   Las funciones de tu proyecto ahora estarán marcadas con un `★`.
*   Presiona `p` para activar o desactivar el modo "Solo Proyecto", ocultando instantáneamente todo lo demás.

---

## Atajos de Teclado

| Tecla       | Acción                                               |
| :---------- | :-------------------------------------------------- |
| `↑`/`↓`     | Navegar por la lista de funciones                    |
| `t`         | Alternar tipo de perfil (`inuse_space`, `alloc_objects`) |
| `c`         | Alternar entre vista de **c**ódigo y **c**all graph |
| `p`         | Alternar filtro de código **p**royecto solamente     |
| `s`         | Ciclar orden de **s**orteo (`Self`, `Total`, `Name`) |
| `f`         | Alternar vista de **f**lame graph                     |
| `Enter`     | *En flame graph:* Acercar en la función seleccionada  |
| `Esc`       | *En flame graph:* Alejar                              |
| `F1`        | Mostrar **ayuda** detallada y explicaciones           |
| `q` / `ctrl+c`| **Q**uitar                                          |


---

## Licencia

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---