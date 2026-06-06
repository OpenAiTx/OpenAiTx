# Montar Proton Drive en Linux usando rclone y systemd

Esta guía automatiza el proceso de montar [Proton Drive](https://proton.me/drive) en un sistema Linux usando [`rclone`](https://rclone.org/) y `systemd`.

Probado en **Arch Linux**, pero debería funcionar en la mayoría de distribuciones Linux con ajustes menores.

---

## 🔧 Características

- Monta Proton Drive al iniciar sesión vía `systemd --user`
- Usa `rclone` con `--vfs-cache-mode writes` para compatibilidad
- Habilita servicio en segundo plano con registro de actividad
- Añade soporte FUSE para montajes con `--allow-other`

---

## 🚀 Inicio Rápido

### 1. ✅ Instalar Dependencias

#### Instalar `fuse3` (requerido para montar):
```bash
sudo pacman -S fuse3
````

#### Instalar `rclone` (debe ser v1.64.0 o superior)

🔹 **Opción 1: Usar binario precompilado (recomendado)**

```bash
curl -O https://downloads.rclone.org/rclone-current-linux-amd64.zip
unzip rclone-current-linux-amd64.zip
cd rclone-*-linux-amd64
sudo cp rclone /usr/local/bin/
sudo chmod +x /usr/local/bin/rclone
```
Verificar:


```bash
rclone version
# Must be v1.64.0 or higher
```

---

### 2. 🔐 Configure Proton Drive Remote

Run:

```bash
rclone config
```

Sigue las indicaciones:

* `n` → Nuevo remoto
* Nombre: `proton`
* Tipo: `protondrive`
* Inicia sesión vía navegador cuando se solicite
* Acepta y guarda

---

### 3. 📜 Ejecutar el script de configuración

Ejecuta el script proporcionado:

```bash
chmod +x setup-proton-mount.sh
./setup-proton-mount.sh
```

El script hará:

* Crear el punto de montaje: `~/ProtonDrive`
* Escribir el servicio de usuario systemd
* Añadir `user_allow_other` a `/etc/fuse.conf` (si falta)
* Añadir al usuario al grupo `fuse` (si es necesario)
* Habilitar y arrancar el servicio de montaje

---

### 4. 🔁 Reiniciar o Cerrar sesión y volver a entrar

Si el script te añadió al grupo `fuse`, debes **cerrar sesión y volver a entrar** para que el cambio surta efecto.

---

## 🔍 Verificar montaje

Comprueba si Proton Drive está montado:

```bash
ls ~/ProtonDrive
```

Verificar el servicio systemd:

```bash
systemctl --user status rclone-proton.mount.service
```

---

## 🔁 Remount

If unmounted the Proton Drive can be remounted by:

```bash
systemctl --user restart rclone-proton.mount.service
```

Nota que Proton Drive se monta automáticamente cada vez que inicias sesión.

## 🧼 Desinstalar

Para eliminar la configuración de auto-montaje:

```bash
systemctl --user disable --now rclone-proton.mount.service
rm ~/.config/systemd/user/rclone-proton.mount.service
```

(Opcional) Elimine `~/ProtonDrive` si ya no necesita el punto de montaje.

---

## 📁 Archivos

* `setup-proton-mount.sh` — script de configuración completo
* `~/.config/systemd/user/rclone-proton.mount.service` — unidad systemd
* `~/ProtonDrive` — ubicación del montaje
* `~/.cache/rclone/rclone-proton.log` — salida de registro (opcional)

---

## 📎 Requisitos

* `rclone >= 1.64.0` con soporte para Proton Drive
* `fuse3`
* Una cuenta de Proton Drive

---

## 🛟 Solución de problemas

Si el montaje no funciona:

```bash
journalctl --user -u rclone-proton.mount.service
```

Para reiniciar el servicio manualmente:

```bash
systemctl --user restart rclone-proton.mount.service
```

---

## 📚 Referencias

* [Documentación de rclone Proton Drive](https://rclone.org/protondrive/)
* [Servicios de usuario systemd](https://wiki.archlinux.org/title/Systemd/User)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---