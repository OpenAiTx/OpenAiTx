# Battman
El gestor moderno de baterías de Strayers para sus buenos y viejos dispositivos iOS.

### 🌍
[简体中文](https://raw.githubusercontent.com/Torrekie/Battman/master/docs/README-zh_CN.md)

## Capturas de pantalla
<div style="width:20%; margin: auto;" align="middle">
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Main.png?raw=true" alt="Demostración principal de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge.png?raw=true" alt="Demostración del indicador de batería de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Gas Gauge-1.png?raw=true" alt="Demostración 2 del indicador de batería de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Adapter.png?raw=true" alt="Demostración del adaptador de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive.png?raw=true" alt="Demostración inductiva de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Inductive-1.png?raw=true" alt="Demostración inductiva 2 de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Serial.png?raw=true" alt="Demostración serial de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Temperature.png?raw=true" alt="Demostración de temperatura de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingMgmt.png?raw=true" alt="Demostración de gestión de carga de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/ChargingLimit.png?raw=true" alt="Demostración del límite de carga de Battman" width="25%" height="25%" />
<img src="https://raw.githubusercontent.com/Torrekie/Battman/master/Screenshots/Thermal.png?raw=true" alt="Demostración térmica de Battman" width="25%" height="25%" />
</div>

$${\color{grey}La \space verdadera \space elegancia \space en \space el \space software \space reside \space en \space el \space arte \space de \space su \space código \space más \space que \space en \space un \space diseño \space superficial.}$$

<br />

### Ventajas
- [x] Construido puramente con Objective-C y C
- [x] UI escrita puramente con brillantes códigos Objective-C
- [x] SIN StoryBoards, SIN binarios adicionales, SIN Assets de Xcode
- [x] SIN Swift ni SwiftUI involucrados
- [x] SIN CocoaPods, SIN paquetes Swift, SIN requerimientos de código externo, SIN frameworks de terceros
- [x] Compila CON/SIN Xcode
- [x] Se construye en Linux (Sí, "necesitas Mac para hacer apps iOS" es propaganda de Apple)
- [x] Obtén y opera directamente desde/con tu hardware con los datos más profundos en bruto
- [x] Compatible con iPhone, iPad, iPod, simulador de Xcode y Macs con Apple Silicon (Si alguien dona dispositivos, incluso puedo programar para Apple Watch y Apple TV)
- [x] Altamente integrado con tu IC de indicador de batería fabricado por Texas Instruments
- [x] Muestra tanta información de energía como la proporcionada por IOPS y PowerManagement
- [x] Identifica tus adaptadores de corriente, cargadores inalámbricos o incluso tus accesorios MagSafe

### Solo Battman puede hacerlo

Lo que otras utilidades de batería hechas para iOS no han hecho  
(Al 9 de marzo de 2025 UTC+0)  
- [x] Decodificación completa de NotChargingReason (ver [not_charging_reason.h](https://raw.githubusercontent.com/Torrekie/Battman/master/Battman/battery_utils/not_charging_reason.h))  
- [x] Recuperación de información Texas Instruments Impedance Track™  
- [x] Lectura en tiempo real de corriente/voltaje de carga  
- [x] Funcionamiento perfecto en Xcode Simulator (Otras personas usan IOPS en sus apps, por lo que no funcionan en simuladores)  
- [x] Comunicación de Smart Charging (Optimized Battery Charging)  
- [x] Control del comportamiento del Modo de Bajo Consumo  
- [x] Información detallada de accesorios MagSafe conectados  
- [x] Información detallada de cables Lightning y accesorios conectados  
- [x] Lectura de todos los sensores de temperatura del hardware  

### Requisitos  

- Dispositivo con jailbreak o instalado con TrollStore  
- iOS 12+ / macOS 11+ (backports bienvenidos)  
- arm64 (A7+ teóricamente / M1+)  
- Gettext libintl (Opcional, para localizaciones)  
- GTK+ 3 (Opcional, para ejecutarse bajo gestores de ventanas basados en GTK+)  

### Descarga  

Consulta la última [Release](https://github.com/Torrekie/Battman/releases/latest) para un paquete precompilado.  

O, si deseas compilarlo tú mismo:

```bash
# On macOS, install Xcode and directly build in it
# On Linux or BSD, make sure a LLVM cross toolchain and iPhoneOS.sdk is prepared, modify Battman/Makefile if needed
# On iOS, when you using Torrekie/Comdartiwerk as bootstrap
apt install git odcctools bash clang make sed grep ld64 ldid libintl-dev iphoneos.sdk
git clone https://github.com/Torrekie/Battman
cd Battman
# If Targeting iOS 12 or ealier, download SF-Pro-Display-Regular.otf somewhere, and put it under Battman/
wget <https://LINK/OF/SF-Pro-Display-Regular.otf> -O Battman/SF-Pro-Display-Regular.otf
make -C Battman all
# Produced Battman.ipa will under $(CWD)/Battman/build/Battman.ipa
```

### Problemas Conocidos

- Battman no está realmente integrado con el hardware cuando se ejecuta en dispositivos con A7 a A10, ya que no tienen AppleSMC, en su lugar usan AppleHPM que no podemos probar.

### Dispositivos Probados
- Serie iPhone 12 (D52)
- iPad Pro 2021 3ra Gen (J51)
- iPhone XR
- iPad Air 2

Por favor, reporte [problemas](../../issues/new) si Battman no funciona correctamente en su dispositivo

### POR HACER
- [ ] Interfaz AppKit/Cocoa para macOS
- [ ] Interfaz GTK+/X11 para iOS/macOS
- [ ] Identificación automática del IC Gas Gauge
- [ ] Recolección opcional de datos (Para decodificar parámetros actualmente desconocidos)
- [x] Funciones avanzadas (interfaz AppleSMC/ApplePMGR)
- [x] Control térmico
- [ ] Ejecutar como CLI
- [ ] Ejecutar como demonio
- [x] Límite de carga
- [x] Integración inalámbrica/MagSafe
- [ ] Límite de tasa de la aplicación
- [ ] Control Jetsam
- [ ] Control del ventilador
- [ ] Accesorios Bluetooth (AirPods, etc.)

### Licencia

A partir del sábado 27 de septiembre de 2025 UTC+0, Battman usa una [licencia no libre](https://raw.githubusercontent.com/Torrekie/Battman/master/LICENSE/LICENSE.md) en lugar de MIT, ¿no me culparán si quiero ganarme la vida con esto, verdad?

## Descargo de responsabilidad

NO USAR EN PRODUCCIÓN, NO SE GARANTIZA NINGUNA GARANTÍA, USAR BAJO SU PROPIO RIESGO.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-23

---