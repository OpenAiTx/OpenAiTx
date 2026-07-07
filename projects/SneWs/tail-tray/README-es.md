# Bandeja Tail  
Menú de bandeja y UI de Tailscale para Plasma Desktop  

**Aviso** Por favor, tenga en cuenta que no tengo _ninguna_ asociación con Tailscale Inc.  

Este es un proyecto personal y no está respaldado por Tailscale Inc. de ninguna forma.  

### Características  
- [X] Controla tu conexión Tailscale desde la bandeja  
- [X] Muestra IPs  
- [X] Muestra el estado actual de conexión de tus dispositivos  
- [X] Vista general de tu red y estado de la red  
- [X] Establece y cambia tu nodo de salida Tailscale  
- [X] Manejo adecuado de múltiples cuentas  
- [X] Nodos de salida Mullvad  
- [X] Soporte para Tail drive - Funciona con soporte davfs2 + ayuda adicional para configurar davfs2 y montaje, etc.  
- [X] Envía archivos a cualquier dispositivo en tu Tailnet directamente desde el menú de la bandeja  
- [X] Recibe notificaciones y archivos de cualquier dispositivo en tu Tailnet a una ubicación predefinida en disco  
- [X] Binarios precompilados para principales distribuciones y soporte experimental para Windows  

### Licencia  
Licencia Pública General GNU v3.0 - ver [LICENSE](LICENSE) para más detalles  

### Instalación  
Por ahora, la forma más fácil y confiable de instalar esto es compilarlo desde el código fuente.  
Para ello, por favor consulte la sección Comenzando abajo.  

### Requisitos previos  
* Tailscale instalado y en ejecución - https://tailscale.com  
* davfs2 instalado y configurado (Si planeas usar Tail drives o acceder a Tail drives. Tail Tray también te ayuda a configurar esto automáticamente) - https://wiki.archlinux.org/title/Davfs2  

### Arquitecturas soportadas  
* x86_64  
* ARM64  
* Cualquier otra arquitectura que QT 6 soporte y donde puedas compilar este proyecto y donde Tailscale funcione  

### Comenzando  

### Paquetes precompilados

 * [Distros basadas en Debian / Ubuntu / Mint](https://github.com/SneWs/tail-tray/releases)
 * [RPMs para OpenSUSE y Fedora](https://software.opensuse.org/download.html?project=home%3Aayankov&package=tail-tray)
 * [NixOS](/docs/nix-os.md)
 * [Windows (¡EXPERIMENTAL! solo la última versión inestable, y sin firmar)](https://github.com/SneWs/tail-tray/releases/download/latest/Tail-Tray-Windows.zip)

### Compilar e instalar desde el código fuente
 * [En Linux](/docs/build-from-src.md)
 * [En Windows](/docs/build-from-src-windows.md)

### Acciones scriptables
Para aprender más sobre cómo escribir y usar acciones scriptables, por favor lea la [Guía de acciones scriptables](https://raw.githubusercontent.com/SneWs/tail-tray/master/docs/scriptable-actions.md)

### Participar y reportar errores
* Si desea participar en el desarrollo de este proyecto, siéntase libre de bifurcar el repositorio y enviar una solicitud de extracción.
* Errores, todos los tenemos... Por favor reporte un problema en la pestaña de issues y lo resolveremos juntos.

### Capturas de pantalla
![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/launcher.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/connected-tray.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/disconnected-tray.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/settings-ui.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/network-status.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/file-sharing.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/devices-ui.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/ui-settings.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives01.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives02.png)

![Captura de pantalla](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives03.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---