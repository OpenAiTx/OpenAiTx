<p align="center">
  <img src="https://raw.githubusercontent.com/toddmaustin/mojo-v/main/./docs/MojoV-logo1.png" alt="Mojo-V Logo" width="550"/>
</p>

# Mojo-V: Computación Secreta para RISC-V

**Mojo-V** (pronunciado *“mojo-five”*) es una nueva extensión de RISC-V que introduce capacidades de programación orientadas a la privacidad para RISC-V. Mojo-V implementa computación secreta, permitiendo una ejecución segura, eficiente y sin revelar datos, sin depender de software frágil ni de la confianza del programador. Al aislar datos sensibles en registros secretos dedicados y cifrar la memoria bajo una clave de terceros, Mojo-V previene divulgaciones y garantiza una computación que es tanto ciega (sin divulgaciones directas) como silenciosa (sin filtraciones por canales laterales). El diseño se integra perfectamente en la ISA existente de RISC-V con solo un bit de modo y cuatro instrucciones nuevas, aplicadas completamente en la decodificación. Los resultados iniciales muestran velocidades de ejecución casi nativas, ofreciendo una mejora de rendimiento de más de 5-7 órdenes de magnitud en comparación con el cifrado homomórfico completo (FHE), con una hoja de ruta clara para su integración en CPUs, GPUs y aceleradores especializados.

Para saber más...
- Aquí hay un video introductorio que describe Mojo-V: https://www.youtube.com/watch?v=HUT46TcNyyM
- Diapositivas que dan una visión general del proyecto Mojo-V:  https://drive.google.com/file/d/1VVzZqYHvQgnKMgXZjg7I_cX2GzF7awSN

La especificación actual de la extensión ISA Mojo-V (versión 0.92):
- [En formato PDF.] (https://drive.google.com/file/d/1pargKATFoQdy94i6bI3P_9mfNA_GsYSw)

Para contactar a los desarrolladores de Mojo-V:
- Correo: [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

# 🧩 Plataforma de Referencia Mojo-V — Versión 0.92

## 🚧 Estado del Proyecto

La plataforma de referencia Mojo-V versión 0.92 implementa computación secreta de enteros y punto flotante usando un cifrado simétrico fijo. Mojo-V soporta tres modos de cifrado: rápido, fuerte y con prueba. En esta versión, la computación secreta de 64 bits está completamente secretizada y esta plataforma de referencia inicial puede usarse para desarrollo de software y pruebas de seguridad. Capacidades adicionales se lanzarán en versiones futuras, incluyendo soporte PKI, soporte de compilador LLVM, soporte RISC-V de 32 bits, soporte de benchmarks VIP-Bench, etc.

**Versión de la especificación:** 0.92  (noviembre 2025)  
**Contacto:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)

## Componentes actuales

1. **Especificación ISA Mojo-V v0.92**
   - publicada en `doc/`
2. **Implementación Spike (Simulador de Conjunto de Instrucciones)**
   - Mojo-V integrado en `riscv-isa-sim`, casi completo
   - Solo falta: soporte para Infraestructura de Clave Pública (PKI) (actualmente usa claves fijas con cifrado Simon-128)
   - Para ejecutar Spike con las extensiones Mojo-V activadas, añada el flag `--isa=rv64gc_zicond_zkmojov_zicntr` al ejecutar `spike`
3. **Benchmarks Bringup-Bench Mojo-V**
   - Ejemplos codificados a mano (p. ej., ordenamiento burbuja) mostrando la computación secreta funcionando en Mojo-V
   - Batería completa de pruebas de seguridad para RV64GC+Mojo-V

Nota, el resto de los benchmarks Bringup-bench NO han sido portados a Mojo-V aún.

## ⚙️ Construcción y Ejecución de la Plataforma de Referencia Mojo-V

### A. Instalar un Compilador LLVM para RISC-V
Necesitarás un compilador cruzado RISC-V basado en LLVM capaz de producir binarios `RV64GC`.

Aquí hay un buen lugar para comenzar: https://clang.llvm.org/get_started.html

### B. Clonar el Repositorio Mojo-V
```bash
git clone https://github.com/toddmaustin/mojo-v.git
cd mojo-v
```

### C. Construir el simulador RISC-V Spike con soporte Mojo-V
```bash
sudo apt-get install device-tree-compiler libboost-regex-dev libboost-system-dev
cd riscv-isa-sim
mkdir build
cd build
../configure --prefix=$RISCV
make
```

### D. Compilar y Ejecutar las Pruebas de Benchmark Mojo-V Bringup-Bench

1. **Compilar el controlador de dispositivo Spike**

   ```bash
   cd bringup-bench/target
   make
   ```

2. **Configure su compilador**

   Edite `../Makefile` y configure `TARGET_CC` para el objetivo `mojov` con la ubicación de su compilador RISC-V basado en Clang de LVM.

3. **Compilar y probar**

   ```bash
   cd ..                # go to the top-level bringup-bench directory
   make mojov-tests     # run all Mojo-V tests
   ```

   Como alternativa, puede ejecutar un punto de referencia individual entrando en su directorio y ejecutando el siguiente comando.

   ```bash
   cd ../mojov-test
   make TARGET=mojov clean build test
   ```

## 🧪 Resumen de Benchmarks de Mojo-V Bringup-Bench

| Programa | Descripción |
|:---------|:-------------|
| `mojov-test` | Ejemplo introductorio de las diapositivas |
| `mojov-test1` | Pruebas de semánticas de registros secretos y memoria cifrada |
| `mojov-test2` | Benchmark de ordenamiento burbuja de enteros data-oblivious codificado a mano con cifrado rápido de Mojo-V (int,fast) |
| `mojov-test3` | Benchmark de ordenamiento burbuja de punto flotante data-oblivious codificado a mano con cifrado rápido de Mojo-V (fp,fast) |
| `mojov-test4` | Benchmark de ordenamiento burbuja de enteros data-oblivious codificado a mano con cifrado fuerte de Mojo-V (int,strong) |
| `mojov-test5` | Benchmark de ordenamiento burbuja de punto flotante data-oblivious codificado a mano con cifrado fuerte de Mojo-V (fp,strong) |
| `mojov-pctests` | Suite de pruebas de integridad codificada a mano para RV64GC+Mojo-V que incluye pruebas positivas y negativas para el formato de cifrado portador de pruebas de Mojo-V (proofcarrying) |
| `mojov-sectests` | Suite de pruebas de seguridad codificada a mano para RV64GC+Mojo-V que incluye 130 pruebas positivas + 245 negativas == 375 en total (int,fp,fast,strong) |

Todos los benchmarks de prueba son programas en ensamblador codificados a mano que demuestran las reglas ISA y la semántica de seguridad de Mojo-V. Los otros benchmarks de Bringup-Bench aún no han sido portados a Mojo-V.

---
## Licenciamiento del Código
Todo el código relacionado con Mojo-V en este repositorio está bajo la licencia de la herramienta que modificó (por ejemplo, Spike, LLVM, Bringup-Bench). Por favor, consulte los directorios respectivos de las herramientas para detalles sobre la licencia.

---

## 💬 Preguntas y Comentarios
¡Agradecemos contribuciones, reportes de errores y sugerencias!

📧 **Correo:** [mojov-devs@umich.edu](https://raw.githubusercontent.com/toddmaustin/mojo-v/main/mailto:mojov-devs@umich.edu)  
🌐 **Página del Proyecto:** [https://github.com/toddmaustin/mojo-v](https://github.com/toddmaustin/mojo-v)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---