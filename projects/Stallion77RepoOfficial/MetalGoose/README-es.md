<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="MetalGoose Logo" width="128" height="128">
  
  # MetalGoose
  
  **Escalado y generación de fotogramas acelerados por GPU para macOS**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [Características](#features) • [Instalación](#installation) • [Uso](#usage) • [Requisitos](#requirements) • [Compilación](#building) • [Licencia](#license)
</div>

---

## Visión general

MetalGoose es una aplicación nativa para macOS que proporciona escalado en tiempo real y generación de fotogramas para juegos y aplicaciones. Construida íntegramente con el framework Metal de Apple, ofrece una experiencia fluida y de alta FPS similar a NVIDIA DLSS o AMD FSR, pero diseñada específicamente para macOS.

## Características

### Escalado MGUP-1
- **Modo Rendimiento** — Escalado más rápido con latencia mínima
- **Modo Equilibrado** — Relación calidad/rendimiento óptima
- **Modo Calidad** — Máxima fidelidad visual
- Múltiples escalas de renderizado: Nativo, 75%, 67%, 50%, 33%
- Nitidez adaptativa al contraste (CAS)

### Generación de Fotogramas MGFG-1
- Multiplicadores de fotogramas **2x, 3x, 4x**
- Modos de generación de fotogramas **Adaptativo** o **Fijo**
- Interpolación compensada por movimiento
- Estimación de movimiento basada en flujo óptico
- Modos de calidad: Rendimiento, Equilibrado, Calidad

### Anti-Aliasing
- **FXAA** — Anti-aliasing aproximado rápido
- **SMAA** — Anti-aliasing morfológico subpixel mejorado
- **MSAA** — Anti-aliasing multisampling  
- **TAA** — Anti-aliasing temporal con historial  

### Monitoreo de Rendimiento  
- Superposición HUD en tiempo real  
- Seguimiento de FPS capturados/salida/interpolados  
- Métricas de tiempo de GPU y tiempo de cuadro  
- Monitoreo de uso de VRAM  
- Estadísticas de cuadros  

## Requisitos  

| Componente | Requisito |  
|------------|-----------|  
| **macOS**  | 26.0 (Tahoe) o superior |  
| **Chip**   | Apple Silicon (M1/M2/M3/M4) |  
| **Xcode**  | 26.0 o superior |  
| **RAM**    | Mínimo 8 GB, recomendado 16 GB |  

## Instalación  

### Descargar Versión  
1. Descargue la última versión desde [Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases)  
2. Mueva `MetalGoose.app` a `/Applications`  
3. Conceda permisos de Grabación de Pantalla y Accesibilidad cuando se le solicite  

### Compilar desde el Código Fuente  
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```
## Uso

1. **Lanzar MetalGoose**  
2. **Seleccionar objetivo**  
   - Elegir una ventana o pantalla para capturar  
3. **Configurar ajustes**  
   - Activar aumento de resolución (MGUP-1)  
   - Activar generación de fotogramas (MGFG-1)  
   - Seleccionar modo de anti-aliasing  
4. **Iniciar escalado**  
   - Hacer clic en "Iniciar" para comenzar el procesamiento  

### Atajos de teclado  

| Atajo    | Acción           |  
|----------|------------------|  
| `⌘ + T`  | Alternar escala  |  

# Códigos de error de MetalGoose  

## Interfaz de usuario (MG-UI)  
- MG-UI-002: La aplicación en primer plano es MetalGoose; el usuario debe cambiar a la ventana objetivo.  
- MG-UI-003: Ventana objetivo no encontrada para la aplicación seleccionada.  
- MG-UI-004: No se encontró pantalla.  
- MG-UI-005: Ventana a pantalla completa detectada; la pantalla virtual requiere modo ventana o sin bordes.  
- MG-UI-006: Límites de la ventana objetivo no disponibles.  
- MG-UI-007: ID de pantalla no encontrado para la pantalla objetivo.  
- MG-UI-008: Frecuencia de actualización de pantalla no disponible.  

## Motor (MG-ENG)  
- MG-ENG-001: Configuración de la tubería Metal falló.  
- MG-ENG-002: Dispositivo Metal no disponible.  
- MG-ENG-003: Cola de comandos Metal no disponible.  
- MG-ENG-004: Creación del escalador espacial MetalFX falló.  
- MG-ENG-005: Tubería de flujo óptico no disponible.  
- MG-ENG-006: Interpolación de fotogramas fallida.  
- MG-ENG-007: Tubería de anti-aliasing no disponible.  
- MG-ENG-008: Tubería de escalado no disponible.  
- MG-ENG-009: Tubería CAS no disponible.

- MG-ENG-010: Fallo en la creación de la textura IOSurface.
- MG-ENG-011: Canal de flujo óptico no disponible.
- MG-ENG-012: Recursos de flujo óptico no disponibles.
- MG-ENG-013: Canal de generación de fotogramas no disponible.

## Pantalla Virtual (MG-VD)
- MG-VD-001: Fallo en la creación de CGVirtualDisplayDescriptor.
- MG-VD-002: Fallo en la creación de CGVirtualDisplay.
- MG-VD-003: Fallo en la creación de CGVirtualDisplayMode.
- MG-VD-004: Fallo en la creación de CGVirtualDisplaySettings.
- MG-VD-005: Fallo al aplicar la configuración de pantalla virtual.
- MG-VD-006: No hay pantalla virtual activa.
- MG-VD-007: Pantalla virtual no encontrada en ScreenCaptureKit.
- MG-VD-008: Fallo al iniciar la captura en ScreenCaptureKit.
- MG-VD-009: Fallo al detener la captura en ScreenCaptureKit.
- MG-VD-010: Transmisión de ScreenCaptureKit detenida con error.

## Accesibilidad / Migración de Ventanas (MG-AX)
- MG-AX-001: Permiso de accesibilidad no concedido.
- MG-AX-002: Fallo al leer la lista de ventanas desde la API AX.
- MG-AX-003: No se encontraron ventanas para el PID objetivo.
- MG-AX-004: Fallo al crear valor de posición AX.
- MG-AX-005: Fallo al establecer la posición de la ventana AX.
- MG-AX-006: La ventana de pantalla completa no puede moverse a la pantalla virtual.
- MG-AX-007: Fallo al crear valor de tamaño AX.
- MG-AX-008: Fallo al establecer el tamaño de la ventana AX.
- MG-AX-009: Pantalla de pantalla virtual no encontrada.
- MG-AX-010: ID de ventana no encontrado para el PID objetivo.

## Superposición (MG-OV)
- MG-OV-001: Falta pantalla objetivo para la creación de superposición.
- MG-OV-002: Falta marco de ventana para la creación de superposición.
- MG-OV-003: Formato de píxel no soportado para la creación de textura de superposición.

## Enrutamiento del Ratón (MG-MO)
- MG-MO-001: Pantalla virtual no configurada para el enrutamiento del ratón.

## Licencia

Este proyecto está licenciado bajo la Licencia Pública General GNU v3.0 - consulte el archivo [LICENSE](LICENSE) para más detalles.

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---