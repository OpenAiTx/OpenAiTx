# Chrome Debloat

Una herramienta para generar políticas para navegadores basados en Chromium (Chrome, Brave y Edge) que deshabilita funciones innecesarias, telemetría y software no deseado mientras habilita algunas mejoras en la calidad de vida.

## Características

- Intenta deshabilitar la telemetría y el reporte de uso
- Elimina funciones innecesarias y software preinstalado no deseado
- Bloquea contenido promocional y elementos de interfaz innecesarios
- Mantiene la funcionalidad del navegador mientras reduce el uso de recursos
- Preconfigura extensiones esenciales:
  - uBlock Origin
  - Cookie AutoDelete
  - Don't f*** with paste
  - I still don't care about cookies
  - SponsorBlock
  - BlockTube
  - BlankTab
  - Decentraleyes

### Navegadores compatibles

| Navegador | Windows | macOS | Linux |
|-----------|---------|-------|-------|
| Google Chrome | ✅ | ✅ | ✅ |
| Microsoft Edge | ✅ | ✅ | ✅ |
| Brave | ✅ | ✅ | ✅ |

## Inicio rápido

### Windows
1.  Descarga el archivo `.reg` para tu navegador desde [`generated/windows/`](./generated/windows/).
2.  Abre el archivo `.reg` descargado para agregar los ajustes al Registro de Windows.
3.  Reinicia tu navegador o ve a `chrome://policy` (o `edge://policy`, `brave://policy`) y haz clic en "Reload policies".

### macOS
1.  Descarga el archivo `.mobileconfig` para tu navegador desde [`generated/macos/`](./generated/macos/).
2.  Abre el archivo `.mobileconfig` descargado para iniciar la instalación del perfil.
3.  Ve a `Configuración del Sistema` > `Privacidad y Seguridad` > `Perfiles` y aprueba el nuevo perfil.
4.  Reinicia tu navegador o ve a `chrome://policy` (o `edge://policy`, `brave://policy`) y haz clic en "Reload policies".

### Linux
1.  Descargue el archivo `.json` para su navegador desde [`generated/linux/`](./generated/linux/).
2.  Mueva el archivo descargado al directorio de políticas correcto (créelo si es necesario):
    *   **Chrome:** `/etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `/etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `/etc/brave/policies/managed/brave.json`
    *   *Nota: Es posible que necesite derechos de `sudo` para hacer esto.*
3.  Reinicie su navegador o vaya a `chrome://policy` (o `edge://policy`, `brave://policy`) y haga clic en "Recargar políticas".

## Configuración Personalizada

Si desea personalizar las políticas:

1. Clone este repositorio
2. Instale las dependencias:
   ```bash
   uv sync
   ```
3. Modifique `policies.yaml` según sus necesidades  
4. Genere nuevos archivos de configuración:
   ```bash
   uv run main.py
   ```
5. Encuentra los archivos generados en el directorio `generated/`


### Desinstalación de Políticas

**Windows:**
1.  Navega al directorio [`uninstall/windows/`](./uninstall/) en este repositorio.
2.  Ejecuta el archivo `.reg` correspondiente a tu navegador (por ejemplo, `uninstall_chrome.reg`). Esto eliminará las claves del registro añadidas durante la instalación.
3.  Reinicia tu navegador o ve a `chrome://policy` (o `edge://policy`, `brave://policy`) y haz clic en "Reload policies".

**macOS:**
1.  Ve a `Configuración del Sistema` > `Privacidad y Seguridad` > `Perfiles`.
2.  Selecciona el perfil asociado con tu navegador (por ejemplo, "Chrome Debloat Policies").
3.  Haz clic en el botón '-' (menos) para eliminar el perfil.
4.  Reinicia tu navegador o ve a `chrome://policy` (o `edge://policy`, `brave://policy`) y haz clic en "Reload policies".

**Linux:**
1.  Elimina el archivo JSON de políticas del directorio específico del navegador (puede que necesites derechos de `sudo`):
    *   **Chrome:** `sudo rm /etc/opt/chrome/policies/managed/chrome.json`
    *   **Edge:** `sudo rm /etc/opt/edge/policies/managed/edge.json`
    *   **Brave:** `sudo rm /etc/brave/policies/managed/brave.json`
2.  Reinicia tu navegador o ve a `chrome://policy` (o `edge://policy`, `brave://policy`) y haz clic en "Reload policies".

## Documentación de Políticas

- [Políticas de Chrome Enterprise](https://chromeenterprise.google/policies/)
- [Políticas de Brave](https://support.brave.com/hc/en-us/articles/360039248271-Group-Policy)
- [Políticas de Microsoft Edge](https://learn.microsoft.com/en-us/deployedge/microsoft-edge-policies)

## Licencia

[Apache 2.0](./LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---