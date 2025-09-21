<a href="https://buymeacoffee.com/koromix" target="_blank"><img src="https://cdn.buymeacoffee.com/buttons/default-orange.png" alt="Buy Me A Coffee" height="41" width="174"></a>

# Visión general

Koffi es un módulo FFI en C rápido y fácil de usar para Node.js, con las siguientes características:

* Bajo overhead y alto rendimiento (ver [benchmarks](https://koffi.dev/benchmarks))
* Soporte para tipos de datos primitivos y agregados (estructuras y arrays de tamaño fijo), tanto por referencia (puntero) como por valor
* Funciones de Javascript pueden usarse como callbacks en C (desde la versión 1.2.0)
* Base de código bien probada para combinaciones populares de SO/arquitectura

Las siguientes combinaciones de SO y arquitecturas __están oficialmente soportadas y probadas__ actualmente:

ISA / SO           | Windows     | Linux    | macOS       | FreeBSD     | OpenBSD
------------------ | ----------- | -------- | ----------- | ----------- | --------
x86 (IA32) [^1]    | ✅ Sí       | ✅ Sí    | ⬜️ *N/A*    | ✅ Sí       | ✅ Sí
x86_64 (AMD64)     | ✅ Sí       | ✅ Sí    | ✅ Sí       | ✅ Sí       | ✅ Sí
ARM32 LE [^2]      | ⬜️ *N/A*    | ✅ Sí    | ⬜️ *N/A*    | 🟨 Probable | 🟨 Probable
ARM64 (AArch64) LE | ✅ Sí       | ✅ Sí    | ✅ Sí       | ✅ Sí       | 🟨 Probable
RISC-V 64 [^3]     | ⬜️ *N/A*    | ✅ Sí    | ⬜️ *N/A*    | 🟨 Probable | 🟨 Probable

[^1]: Se soportan las siguientes convenciones de llamada: cdecl, stdcall, MS fastcall, thiscall.
[^2]: El binario precompilado usa la ABI hard float y espera un coprocesador VFP. Compila desde el código fuente para usar Koffi con una ABI diferente (softfp, soft).
[^3]: El binario precompilado usa la ABI LP64D (float de doble precisión). La ABI LP64 está soportada teóricamente si compilas Koffi desde el código fuente pero no ha sido probada. La ABI LP64F no está soportada.

Usa los siguientes enlaces para más información:

- Documentación: https://koffi.dev/
- Registro de cambios: https://koffi.dev/changelog
- Código fuente: https://codeberg.org/Koromix/rygel/ (ver explicación abajo)

# Código fuente

Este repositorio no contiene el código de Koffi sino que solo existe como interfaz. Por razones prácticas, comencé a usar un único repositorio para todos mis proyectos en 2018 porque es más fácil de gestionar.

El código fuente está disponible aquí: https://codeberg.org/Koromix/rygel/ (en el subdirectorio *src/koffi*).

Los monorrepositorios tienen dos características clave para mí:

* Refactorización entre proyectos
* Gestión de dependencias simplificada

Puedes encontrar una justificación más detallada aquí: https://danluu.com/monorepo/

# Compilar manualmente

Koffi se construye con un envoltorio personalizado de CMake llamado CNoke, que también está en el monorrepositorio. No intentes ejecutar CMake manualmente porque fallará.

Sigue las [instrucciones de compilación documentadas](https://koffi.dev/contribute#build-from-source) para compilar Koffi desde el código fuente.

# Licencia

Este programa es software libre: puedes redistribuirlo y/o modificarlo bajo los términos de la **Licencia MIT**.

Encuentra más información aquí: https://choosealicense.com/licenses/mit/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-21

---