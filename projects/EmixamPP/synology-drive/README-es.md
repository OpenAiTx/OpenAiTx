# <p align=center>synology-drive</p>

Paquete RPM no oficial del cliente Synology Drive <https://www.synology.com>.

Dado que el paquete proporcionado por FlatHub no es 100% funcional y el método de convertir deb a rpm con Alien requiere mucha manipulación, decidí crear un paquete RPM limpio y 100% funcional para el cliente Synology Drive.

He incluido el explorador de archivos Nautilus como dependencia para tener acceso al menú compartir y para tener el indicador de estado de sincronización de archivos (como en Windows o Ubuntu).\
También he incluido una extensión de GNOME shell como dependencia para ver el icono en la bandeja (funciona de forma nativa con KDE).\
He creado un segundo paquete para usuarios que no usan GNOME. No contiene las dos dependencias mencionadas arriba (pueden instalarse más tarde si lo desean).



## Instalación
Si ha instalado previamente Synology Drive Client con Alien o Flatpak (es decir, desde otra fuente que no sea mi repositorio), asegúrese de desinstalarlos.

Si le gusta el proyecto, no dude en marcar el repositorio con una estrella para apoyarme, ¡gracias!

### Método 1: instalar desde el repositorio COPR (recomendado para recibir actualizaciones)
Enlace de la página: [paquete COPR](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/).

1. `sudo dnf copr enable emixampp/synology-drive`
2. Para GNOME: `sudo dnf --refresh install synology-drive`
3. Para otros entornos de escritorio: `sudo dnf --refresh install synology-drive-noextra`

### Método 2: compilar el paquete localmente (sin actualización)
1. Instalar herramientas de compilación: `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. Opcional, si desea cambiar la versión:
   1. Consulte las [notas de la versión](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) y elija la versión deseada (>= 3.2.1-13271)
   2. Edite las dos primeras líneas de `synology-drive.spec` o `synology-drive-noextra.spec`, dependiendo si usa GNOME u otro entorno de escritorio.
5. Para GNOME:
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. Para otros entornos de escritorio: 
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. Limpiar el directorio de compilación: `rm -r ~/rpmbuild`
### Experimental: compilar el paquete localmente para procesadores Aarch64/ARM64 (por ejemplo, Apple Silicon, Qualcomm Snapdragon)  
1. Instalar herramientas de compilación : `sudo dnf install rpm-build rpmdevtools`  
2. `git clone https://github.com/EmixamPP/synology-drive.git`  
3. `cd synology-drive`  
4. Opcional, si desea cambiar la versión:  
   1. Consulte las [notas de la versión](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) y elija la versión deseada (>= 3.2.1-13271)  
   2. Edite las dos primeras líneas de `synology-drive.spec` o `synology-drive-noextra.spec`, dependiendo de si está usando GNOME u otro entorno de escritorio.  
5. Para GNOME:  
   1. `spectool -g -R synology-drive-aarch64.spec`  
   2. `rpmbuild -ba synology-drive-aarch64.spec`  
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`  
6. Para otros entornos de escritorio:  
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`  
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`  
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`  
7. Limpiar directorio de compilación : `rm -r ~/rpmbuild`  
**Atención**_**: Esta solución utiliza el emulador FEX. Si está usando el emulador QEMU probablemente fallará porque binfmt_misc permite que solo un emulador se registre para binarios x86_64.  

## Información legal  
Consulte la [LICENCIA](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE).  

Este proyecto ha sido autorizado por Synology Inc.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---