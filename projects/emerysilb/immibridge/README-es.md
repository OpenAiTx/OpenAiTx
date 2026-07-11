<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/icon-transparent.png" alt="ImmiBridge" width="128">
</p>

<h1 align="center">ImmiBridge</h1>

<p align="center">
  <a href="https://opensource.org/licenses/MIT"><img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License: MIT"></a>
  <a href="https://www.apple.com/macos/"><img src="https://img.shields.io/badge/macOS-12.0+-blue.svg" alt="macOS"></a>
</p>

<p align="center">
  <a href="https://github.com/emerysilb/immibridge/releases/"><img src="https://img.shields.io/badge/Download-Latest%20Release-blue?style=for-the-badge" alt="Download latest release"></a>
</p>

Haz una copia de seguridad de tu biblioteca de Apple Photos en una carpeta organizada por fecha de captura, o directamente a un servidor [Immich](https://immich.app). Exporta originales (incluidos videos emparejados de Live Photo) y opcionalmente ediciones renderizadas.

<p align="center">
  <img src="https://raw.githubusercontent.com/emerysilb/immibridge/main/./assets/screenshot.png" alt="ImmiBridge Screenshot" width="700">
</p>

## Características

- Exporta fotos a carpetas locales organizadas por fecha
- Sube directamente a servidores de fotos Immich
- Modos de respaldo incremental, completo o espejo
- Filtra por álbumes, tipo de medio o fecha
- Pausa y reanuda respaldos
- Respaldos automáticos programados
- Integración en la barra de menú
- Descarga de fotos de iCloud con seguimiento de progreso
- Sincronización solo de metadatos (actualiza metadatos sin volver a subir archivos)
- Actualizaciones automáticas vía Sparkle

## Instalación

### Descargar (Recomendado)

1. Descarga `ImmiBridge-x.x.x.dmg` desde la página de [Releases](../../releases)
2. Abre el DMG y arrastra ImmiBridge a tu carpeta de Aplicaciones
3. Inicie ImmiBridge desde Aplicaciones
4. Conceda acceso a Fotos cuando se le solicite

### Compilar desde el código fuente

Consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) para obtener instrucciones detalladas de compilación.

**Inicio rápido:**

```bash
# Clone the repository
git clone https://github.com/emerysilb/immibridge.git
cd immibridge

# Open in Xcode
open ImmiBridge/ImmiBridge.xcodeproj
```
### Construcción de Versiones Firmadas

Para construir un DMG notariado para distribución, necesitas un certificado Apple Developer ID ($99/año). Consulta [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md#creating-a-signed-release) para más detalles.

## Uso

Lanza ImmiBridge y configura:

1. **Fuente**: Elige la biblioteca de Fotos y/o carpetas personalizadas
2. **Destino**: Carpeta local y/o servidor Immich
3. **Opciones**: Modo de copia de seguridad, filtros, programación

### Modos de Copia de Seguridad

| Modo | Exporta | Usa Manifiesto | Elimina del Destino |
|------|---------|----------------|---------------------|
| **Incremental Inteligente** | Solo archivos nuevos/cambiados | Sí | No |
| **Completo** | Todo, cada vez | No | No |
| **Espejo** | Solo archivos nuevos/cambiados | Sí | Sí (archivos huérfanos) |

### Integración con Immich

Para conectar con tu servidor Immich:

1. Ve a la pestaña **Destino**
2. Ingresa la URL de tu servidor Immich (ej., `http://192.168.1.100:2283`)
3. Ingresa tu clave API (genera una en Immich bajo Configuración de Usuario → Claves API)
4. Haz clic en **Probar Conexión**

**Características:**
- Usa sumas de verificación SHA1 para evitar cargas duplicadas
- Las Live Photos se suben como video + imagen fija emparejados
- Soporta sincronización de álbumes con Immich

## Permisos

En la primera ejecución, macOS solicitará:

- **Acceso a Fotos**: Requerido para leer tu biblioteca de fotos

- **Acceso a la red local**: Requerido si su servidor Immich está en su red local

Si niega un permiso, vuelva a habilitarlo en **Configuración del sistema → Privacidad y seguridad**.

## Contribuciones

¡Las contribuciones son bienvenidas! Consulte [CONTRIBUTING.md](https://raw.githubusercontent.com/emerysilb/immibridge/main/CONTRIBUTING.md) para las pautas.

## Licencia

Licencia MIT - consulte [LICENSE](LICENSE) para más detalles.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-11

---