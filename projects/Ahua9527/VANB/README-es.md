# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (¡Guau! ¡NB!)

VANB es una herramienta de conversión de flujos de video/audio basada en GStreamer, que soporta conversión bidireccional entre los protocolos NDI y RTMP. Permite enviar fuentes NDI a un servidor RTMP, o convertir flujos RTMP en salidas NDI.

Este proyecto es de código abierto bajo la licencia [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Plataformas compatibles

Actualmente, se soportan principalmente las siguientes plataformas:
- macOS (Apple Silicon)

## Requisitos del entorno

### Dependencias del sistema
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Pasos de instalación
1. Instalar [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Instalar GStreamer mediante Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clonar el repositorio del proyecto
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Instalar las dependencias de Python
```bash
pip install -r requirements.txt
```

5. Configurar las variables de entorno (consultar el archivo .env)
```bash
# Configurar la ruta del NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configurar la ruta del plugin de GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Modo de uso

### NDI a RTMP (transmisor)
```bash
python vanb_tx.py
```
El programa escaneará automáticamente las fuentes NDI disponibles y solicitará la dirección de envío RTMP.

### RTMP a NDI (receptor)
```bash
python vanb_rx.py
```
Tras introducir la dirección RTMP de recepción, el programa creará automáticamente una nueva salida NDI.

## Estado de desarrollo

### Funciones implementadas
- ✓ Conversión de NDI a RTMP
- ✓ Conversión de RTMP a NDI
- ✓ Adaptación automática de tasa de fotogramas y resolución
- ✓ Sincronización de audio y video
- ✓ Escaneo automático de fuentes NDI
- ✓ Nominación automática de salida NDI
- ✓ Codificación y decodificación hardware VideoToolbox

### Funciones pendientes
- ⨯ Soporte de archivos de configuración (Profile/config.json)
  - Control de parámetros de entrada y salida mediante archivo de configuración
  - Soporte de múltiples configuraciones preestablecidas de transcodificación
  - Configuración de tamaño de búfer y parámetros de latencia
  - Configuración de equilibrio entre calidad de transcodificación y rendimiento
- ⨯ Procesamiento concurrente de múltiples flujos

## Aviso de licencia

⚠️ **Aviso importante: Licencia y conformidad**

### Licencia del software

Este proyecto está licenciado bajo la [Licencia Pública General GNU v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Razones para elegir la licencia GPL-3.0:
1. Este proyecto utiliza varios plugins de GStreamer licenciados bajo GPL:
   - `x264`: Codificador de video H.264 (GPL)
   - `x265`: Codificador de video HEVC/H.265 (GPL)
   - `faad`: Decodificador de audio AAC (GPL)
2. Según la cláusula de copyleft de la GPL, el software que utilice componentes GPL también debe usar una licencia GPL
3. Elegir GPL-3.0 garantiza la compatibilidad con las licencias de todos los componentes dependientes

### Requisitos de la licencia

Al usar este proyecto, debe cumplir con los siguientes requisitos:
1. **Código abierto**: Si modifica el código de este proyecto o lo integra en su propio proyecto, debe publicar su código fuente completo
2. **Mantener la licencia**: Su proyecto debe seguir usando la licencia GPL-3.0
3. **Declaración de derechos de autor**: Debe conservar la declaración de derechos de autor y la declaración de licencia originales
4. **Notificación destacada**: Si modifica el código, debe notificar claramente los cambios realizados
5. **Concesión de patentes**: GPL-3.0 incluye cláusulas explícitas de concesión de patentes

### Licencia de componentes GStreamer
1. Este proyecto es solo para fines de desarrollo y pruebas
2. NDI® es una marca registrada de NewTek, Inc.
3. El uso de este proyecto requiere cumplir con el acuerdo de licencia de NewTek NDI® SDK
4. Antes de usar en producción, asegúrese de haber obtenido todas las licencias y autorizaciones necesarias

## Reporte de problemas

Si encuentra algún problema:
1. Verifique que las variables de entorno estén configuradas correctamente
2. Confirme que los plugins de GStreamer estén instalados correctamente
3. Revise los archivos de registro para obtener información detallada del error
4. Informe el problema a través de Issues, adjuntando registros e información del entorno

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---