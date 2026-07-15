# 💻 Windows en Contenedor Docker  
Descubre un método innovador y eficiente para desplegar Windows OS (x64) en tu sistema Linux usando el poder de Vagrant VM, libvirt y docker-compose. Juntas, estas tecnologías te ayudan a contenerizar Windows OS, permitiéndote gestionar una instancia de Windows tal como lo harías con cualquier contenedor Docker. Esta integración perfecta en flujos de trabajo existentes mejora significativamente la comodidad y optimiza la asignación de recursos.  

⭐ **¡No olvides darle estrella al proyecto si te fue útil!**  

## 📋 Requisitos Previos  

Asegúrate de que tu sistema cumpla con los siguientes requisitos:  

- **Docker:** Versión 20 o superior [(Instalar Docker)](https://www.docker.com/)  

- **Sistema Operativo anfitrión:** Linux  

- **Virtualización habilitada:**  
  - Verifica con:  
    - `lscpu | grep -i Virtualization`  
  - La salida indica:  
    - `VT-x` → Virtualización Intel soportada y habilitada.  
    - `AMD-V` → Virtualización AMD soportada y habilitada.  
  - Si la virtualización no está habilitada, actívala en la configuración BIOS/UEFI.  

- **`cgroup: host`** en el archivo compose es requerido: libvirt y los demonios que genera necesitan acceso completo a cgroup, de lo contrario el contenedor no podrá iniciarse en hosts con cgroup v2.  

## 🚀 Guía de Despliegue  

1. Crea/Actualiza el archivo ambiental `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Crear `docker-compose.yml`
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. Crea `docker-compose.override.yml` cuando quieras que tu VM sea persistente
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. Ejecuta: `docker compose up -d`

> **El primer arranque tarda varios minutos** — la caja Vagrant ya está integrada en la imagen, pero la VM aún debe iniciarse y ejecutar el script de aprovisionamiento (instalación de Chocolatey, redimensionamiento del disco, ajustes del registro). Sigue el progreso con `docker compose logs -f`.

> Cuando quieras destruir todo `docker compose down -v`

![captura de pantalla de Windows](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Acceso  

### Escritorio Remoto (RDP)  
Para depurar o probar, puedes conectarte a la VM usando **Escritorio Remoto** en el puerto `3389`.  

#### Software para Acceso de Escritorio Remoto  
| SO       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` o [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Conexión a Escritorio Remoto** integrada |

---

### SSH   
Puedes conectarte vía SSH usando las credenciales del usuario **administrator** o **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Inicio de sesión de usuario
Los usuarios predeterminados basados en la imagen Vagrant son:

1. Administrador
    - Nombre de usuario: Administrator
    - Contraseña: vagrant
2. Usuario
    - Nombre de usuario: vagrant
    - Contraseña: vagrant

## ⚠️ Limitaciones

- **Solo host Linux** — depende de `/dev/kvm` y libvirt; no se soportan hosts macOS ni Windows.
- **Licencia de evaluación** — la caja base incluye una copia de evaluación de Windows Server 2022. La activación expira según los términos de evaluación de Microsoft.
- **Sin carpetas sincronizadas** — `rsync`, `smb` y `nfs` están deshabilitados en el [Vagrantfile](Vagrantfile) (rsync necesita una instalación en Windows antes de la provisión; las carpetas SMB no se soportan con host Linux; NFS en contenedor muestra `no support in current kernel`).
- **Rendimiento** — sin KVM anidado disponible para Docker (por ejemplo, en una VM en la nube que no expone KVM), el invitado usa QEMU simple y es varias veces más lento.

## 🔧 Solución de problemas

- **`KVM acceleration is not available`** en los registros → el host no está exponiendo `/dev/kvm`. Verifique que la virtualización esté habilitada en la BIOS, que el módulo `kvm` esté cargado (`lsmod | grep kvm`) y que `/dev/kvm` exista en el host. El script de inicio cae a QEMU automáticamente; espere una gran desaceleración.
- **Puerto 3389 / 2222 ya en uso** → otro servicio RDP/SSH está enlazado en el host. Deténgalo o cambie el mapeo de puertos en `docker-compose.yml`.
- **El contenedor se cierra inmediatamente** → casi siempre un problema de cgroup o privilegios. Confirme que `privileged: true` y `cgroup: host` estén configurados, luego revise `docker compose logs win10`.
- **`vagrant up` se queda en "Waiting for domain to get an IP address"`** → la red NAT por defecto de libvirt no está activa. Reinicie el contenedor o ejecute `virsh net-start default` dentro de este.

## 📚 Lecturas y recursos adicionales

- [Tutorial de Windows Vagrant](https://github.com/SecurityWeekly/vulhub-lab)
- [Imagen Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant por HashiCorp](https://www.vagrantup.com/)
- [Máquina virtual Windows en un contenedor Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU dentro de un contenedor](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---