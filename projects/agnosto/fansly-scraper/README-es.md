# Fansly Scraper

> [!IMPORTANTE]
> **Actualización del Estado del Proyecto**
>
> Debido a un reciente problema de salud, este proyecto está tomando una prioridad muy baja en mi vida. Las actualizaciones y el soporte serán muy mínimos en el futuro previsible. Gracias por su comprensión.
>
> Si buscas una alternativa más activamente mantenida con una interfaz web completa, panel en vivo y reproductor VOD, y monitoreo y archivado automático en segundo plano, revisa **[Accerso](https://accesro.one)**.

> [!ADVERTENCIA]
> **‼️ Falso Positivo de Windows Defender** (literalmente no sé por qué ni de dónde vino esto)
>
> El ejecutable de Windows de este programa es frecuentemente marcado como **`Trojan:Script/Wacatac.B!ml`** por Windows Defender y otros antivirus. Esto es un **falso positivo**.
>
> **¿Por qué sucede esto?**
> El `!ml` en el nombre de detección significa que fue marcado por un modelo de Aprendizaje Automático, no por un humano. Debido a que esta es una herramienta scraper de código abierto y sin firma que realiza muchas solicitudes a internet, el sistema automatizado la marca incorrectamente como sospechosa. Esto es un problema común para muchas herramientas de línea de comandos basadas en Go y Rust.
>
> **Solución recomendada - Instalar mediante Go (debería evitar problemas con AV):**
> ```bash
> go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
> ```
>
> **Qué puedes hacer:**
> 1.  **Confiar en el programa:** Puedes desactivar temporalmente Windows Defender para descargar y ejecutar el programa, y luego agregarlo como excepción.
> 2.  **Compilar desde el código fuente:** Si tienes Go instalado, puedes compilarlo tú mismo. El programa no es marcado cuando lo compilas localmente o instalas vía Go.
>
> El código es completamente abierto para que lo inspecciones. Es seguro de usar. pero entiendo si las advertencias de AV son preocupantes.

Una herramienta todo en uno simple para descargar y monitorear contenido de creadores de Fansly.

> **⚠️ Actualmente en desarrollo** - Algunas funciones pueden no funcionar perfectamente. Ver [problemas conocidos](#known-issues) abajo.


## Requisitos

- **Opcional pero altamente recomendado**: [ffmpeg](https://ffmpeg.org/) para grabación de transmisiones en vivo y guardar videos de mayor calidad. Sigue [esta guía](https://phoenixnap.com/kb/ffmpeg-windows) para instalar en la ruta del sistema en Windows.
- **Opcional**: [mt](https://github.com/mutschler/mt) para mejores hojas de contactos

## Inicio rápido

### 1. Descarga
- **Forma fácil**: Visita la [página de descarga](https://agnosto.github.io/projects/fansly-scraper/) (detecta automáticamente tu sistema)
- **Forma manual**: Descarga desde [GitHub releases](https://github.com/agnosto/fansly-scraper/releases)
- **Instalar vía Go**:
```bash
go install github.com/agnosto/fansly-scraper/cmd/fansly-scraper@latest
```

### 2. Ejecutar el Programa
```bash
./fansly-scraper
```

En la primera ejecución, el asistente de configuración te ayuda a configurar todo. Presiona 'a' para usar el inicio de sesión automático: abre Fansly y proporciona un fragmento de una línea para pegar en la Consola de DevTools. Tu token y agente de usuario se capturan automáticamente y se guardan en la configuración.

## Uso Básico

### Modo Interactivo (Recomendado para principiantes)
```bash
./fansly-scraper
```

Desde el menú principal puedes:
- Ejecutar el asistente de configuración (elegir ubicación de guardado, inicio de sesión automático)
- Restablecer configuración (restaurar valores predeterminados, ejecutar asistente nuevamente)

### Modo de línea de comandos
```bash
# Download all content from a creator
./fansly-scraper -u {creator-name}

# Download specific content types
./fansly-scraper -u {creator-name} -d [all|timeline|messages|stories]

# Monitor for live streams
./fansly-scraper -m {creator-name}

# Start/stop monitoring
./fansly-scraper monitor [start|stop]
```

**Nota**: La monitorización en tiempo real requiere mantener la sesión del terminal activa. Para ejecutar la monitorización en segundo plano, considere usar multiplexores de terminal como [tmux](https://github.com/tmux/tmux/wiki) o [zellij](https://github.com/zellij-org/zellij) en Linux/WSL. A partir de la versión v0.6.3, puede monitorear creadores adicionales ejecutando `-m creator` en instancias de terminal separadas sin reiniciar el proceso de monitorización existente.

### Actualizar el Programa
```bash
./fansly-scraper update
```

## Hoja de Ruta del Proyecto y Configuración Avanzada

Nuestro desarrollo se rastrea públicamente en nuestro **[Hoja de Ruta del Proyecto](https://github.com/users/agnosto/projects/1)**. Puedes ver en qué estamos trabajando, qué está planeado para el futuro y contribuir a la discusión.

- **Guía de Configuración**: Consulta la **[Wiki Oficial](https://github.com/agnosto/fansly-scraper/wiki)**
- **Compilar desde el código fuente**:
  ```bash
  git clone https://github.com/agnosto/fansly-scraper && cd fansly-scraper
  go build -v -ldflags "-w -s" -o fansly-scraper ./cmd/fansly-scraper
  ```
## Contribuyendo

¡Las contribuciones son bienvenidas y muy apreciadas! Ya sea reportando un error, proponiendo una función o enviando un pull request, tu ayuda es valiosa.

![alt text](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)

![alt text](https://img.shields.io/badge/contributions-welcome-brightgreen.svg?style=flat-square)

Por favor, lee nuestras [Pautas de Contribución](https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./CONTRIBUTING.md) antes de comenzar.
Consulta la pestaña de [Issues](https://github.com/agnosto/fansly-scraper/issues) para ver si hay alguna tarea que te gustaría asumir.

## Problemas Conocidos

- **Redescarga**: Desde la versión v0.8.3, la convención para nombrar archivos cambió causando redescarga de medios.
- **Grabación de chat**: Puede ocasionalmente perder mensajes durante reconexiones
- **Usuarios de MacOS**: Puede que necesiten permitir notificaciones en [configuración del sistema](https://github.com/gen2brain/beeep/issues/67#issuecomment-2646474049)
- **Estado en vivo**: Presiona `r` en la TUI para refrescar el estado en vivo
- **Archivos duplicados**: A veces la misma imagen puede aparecer dos veces debido a la estructura de la API de Fansly
- **Formatos de fecha para nombre de archivo de livestream**: En caso de que una transmisión se interrumpa y se intente grabar de nuevo, si el formato de fecha no es lo suficientemente específico (ej., sin marca de tiempo), puede fallar al guardar la transmisión después porque ambos vods tendrán el mismo nombre, por ahora usa uno de estos: `2006-01-02_15:04:05` o `20060102_150405`

## Apoya el Proyecto

Si esta herramienta te ayuda, considera patrocinar en github:

[![Sponsor agnosto on GitHub](https://img.shields.io/badge/Sponsor-%23EA4AAA?style=for-the-badge&logo=githubsponsors)](https://github.com/sponsors/agnosto)

Alternativamente, puedes hacer una donación única vía criptomonedas:

<table>
  <tr>
    <td align="center"><strong>Bitcoin (BTC)</strong></td>
    <td align="center"><strong>Solana (SOL)</strong></td>
  </tr>
  <tr>
    <td align="center">
      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/btc_qr.png" alt="Código QR de Bitcoin" width="200"/>
      <p><code>bc1q0e78wrtc9ezp6tqv000wfewgqf2ue4tpzdk7ee</code></p>
    </td>
    <td align="center">

      <img src="https://raw.githubusercontent.com/agnosto/fansly-scraper/main/./assets/sol_qr.png" alt="Código QR de Solana" width="200"/>
      <p><code>Bv3kYZcwSTHXAQtnPddTF27D3F6Gc29v2MfFLqmGF6Gf</code></p>
    </td>
  </tr>
</table>

---

> [!CAUTION]
> **Aviso**: Esta herramienta no está afiliada con Fansly ni con Select Media LLC. Úsela bajo su propio riesgo. El desarrollador de este script no se responsabiliza por las acciones de los usuarios finales ni por cualquier consecuencia que pueda surgir en la cuenta de dichos usuarios. Úsela bajo su propio riesgo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-22

---