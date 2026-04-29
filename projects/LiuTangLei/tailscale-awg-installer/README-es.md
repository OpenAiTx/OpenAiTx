# Tailscale con Amnezia-WG 2.0 (v1.88.2+)

[![GitHub Release](https://img.shields.io/github/v/release/LiuTangLei/tailscale)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![Platform Support](https://img.shields.io/badge/platform-Linux%20|%20macOS%20|%20Windows%20|%20OpenWrt%20|%20Android-blue)](https://github.com/LiuTangLei/tailscale/releases/latest)
[![License](https://img.shields.io/badge/license-BSD--3--Clause-green)](LICENSE)

Cliente Tailscale mejorado con ofuscación Amnezia-WG 2.0: tráfico basura, firmas de protocolo y disfraz de apretón de manos/cabecera para resistir DPI y bloqueos. Hasta que habilites las configuraciones AWG, se comporta como el Tailscale estándar.

Idiomas: [English](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/README.md) | [中文](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-zh.md) | [فارسی](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-fa.md) | [Русский](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-ru.md)

Para la documentación de AWG v1.5, vea [doc/README-awg-v1.5.md](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/README-awg-v1.5.md).

## Instalación

| Plataforma | Comando / Acción |
| --- | --- |
| Linux | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh \| bash` |
| macOS* | `curl -fsSL https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh \| bash` |
| Windows (PowerShell Admin) | `iwr -useb https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1 \| iex` |
| OpenWrt | Ver [Instalación en OpenWrt](#openwrt-installation) |
| Android | Descargar APK desde [releases](https://github.com/LiuTangLei/tailscale-android/releases) |

- macOS: el instalador usa solo CLI `tailscaled`. Si se detecta la app oficial Tailscale.app, se te pedirá eliminarla para evitar conflictos.
- Android actualmente solo soporta sincronización de configuración AWG. Usa el botón Sincronizar dentro de la app.

![Ejemplo de sincronización AWG en Android](https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/doc/sync1.jpg)

## Docker Compose

El repositorio incluye `docker-compose.yml` para ejecutar `tailscaled` con soporte AWG.

- El estado se guarda en `./tailscale-state` junto al archivo compose, por lo que el estado del nodo y las configuraciones AWG sobreviven a reinicios del contenedor y del host.
- Si actualizas desde el antiguo montaje de enlace `/var/lib/tailscale:/var/lib/tailscale`, copia primero el estado existente:

```bash
docker compose down
cp -a /var/lib/tailscale ./tailscale-state
# update docker-compose.yml
docker compose up -d
```

Flujo básico:

1. Inicie el servicio: `docker compose up -d`
2. Autentíquese dentro del contenedor: `docker compose exec tailscaled tailscale up`
3. Ejecute los comandos AWG de la misma manera, por ejemplo: `docker compose exec tailscaled tailscale awg sync`

Si utiliza Headscale, agregue `--login-server https://your-headscale-domain` a `tailscale up`.

Alias opcional del host:

```bash
alias tailscale='docker exec -it tailscaled tailscale'
```

Ese alias solo se aplica a la shell actual. Para conservarlo después de un reinicio o una nueva sesión de terminal, agrégalo a `~/.bashrc` o `~/.zshrc` y recarga tu shell.

## Instalación de OpenWrt

Comando predeterminado:

```bash
wget -O /usr/bin/install.sh https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install_en.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

Comando mirror para regiones con acceso restringido a GitHub:

```bash
wget -O /usr/bin/install.sh https://ghfast.top/https://raw.githubusercontent.com/LiuTangLei/openwrt-tailscale-awg/main/install.sh && chmod +x /usr/bin/install.sh && /usr/bin/install.sh
```

Este script es un fork de [GuNanOvO/openwrt-tailscale](https://github.com/GuNanOvO/openwrt-tailscale).

## Espejos

Si GitHub está lento o bloqueado, puedes alojar un espejo de prefijo como `https://tu-sitio-espejo.com`:

```bash
# Linux
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-linux.sh | bash -s -- --mirror https://your-mirror-site.com

# macOS
curl -fsSL https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-macos.sh | bash -s -- --mirror https://your-mirror-site.com
```

```powershell
# Windows
$scriptContent = (iwr -useb https://your-mirror-site.com/https://raw.githubusercontent.com/LiuTangLei/tailscale-awg-installer/main/install-windows.ps1).Content; $scriptBlock = [scriptblock]::Create($scriptContent); & $scriptBlock -MirrorPrefix 'https://your-mirror-site.com/'
```

Si PowerShell bloquea la ejecución, use `Set-ExecutionPolicy RemoteSigned` o `Bypass -Scope Process`.

## Inicio rápido

Consejo: `tailscale amnezia-wg` es lo mismo que `tailscale awg`.

1. Inicie sesión:

```bash
# Official control server
tailscale up

# Headscale
tailscale up --login-server https://your-headscale-domain
```

2. Configure AWG:

```bash
tailscale awg set
```

Presione Enter en el aviso de auto-generación para generar valores recomendados para todo excepto `i1`-`i5`.

3. En otros dispositivos, sincronice la misma configuración AWG desde este nodo ya configurado:

- Escritorio: ejecute `tailscale awg sync` en el otro dispositivo
- Android: toque Sincronizar en la aplicación del otro dispositivo

4. Verifique o restablezca cuando sea necesario:

```bash
tailscale awg get
tailscale awg reset
```

## Preajustes de Configuración

| Objetivo | Ejemplo | Compatibilidad |
| --- | --- | --- |
| Tráfico basura básico | `tailscale awg set '{"jc":4,"jmin":64,"jmax":256}'` | Funciona con pares estándar de Tailscale |
| Tráfico basura + firmas | `tailscale awg set '{"jc":2,"jmin":64,"jmax":128,"i1":"<b 0x40><r 12>"}'` | Funciona con pares estándar de Tailscale |
| Simulación de handshake | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0}'` | Todos los nodos AWG deben usar el mismo `s1`-`s4` |
| Simulación completa | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000}}'` | Todos los nodos AWG deben usar el mismo `s1`-`s4` y `h1`-`h4` |
| Simulación completa + firmas | `tailscale awg set '{"s1":10,"s2":15,"s3":8,"s4":0,"h1":{"min":100000,"max":200000},"h2":{"min":300000,"max":350000},"h3":{"min":400000,"max":450000},"h4":{"min":500000,"max":550000},"i1":"<b 0xc0><r 32><c><t>"}'` | `i1`-`i5` pueden variar por nodo; `s1`-`s4` y `h1`-`h4` deben coincidir |

## Referencia de Parámetros

- `jc` con `jmin` y `jmax`: cuenta de paquetes basura y rango de tamaño.
- `i1`-`i5`: cadena CPS opcional (Firma de Protocolo Personalizado) para paquetes que imitan protocolos personalizados.
- `s1`-`s4`: campos de relleno o prefijo del handshake; todos los nodos AWG deben coincidir.
- `h1`-`h4`: rangos de campos de encabezado en la forma `{"min": bajo, "max": alto}`; se deben establecer los cuatro o ninguno. Los rangos no deben superponerse y todos los nodos AWG deben coincidir.

Cuentas muy grandes de basura o cadenas largas de firmas aumentan la latencia y el uso de ancho de banda.

## Soporte de Plataforma

| Plataforma | Arquitectura | Estado |
| --- | --- | --- |
| Linux | x86_64, ARM64 | ✅ Completo |
| macOS | Intel, Apple Silicon | ✅ Completo |
| Windows | x86_64, ARM64 | ✅ Instalador |
| OpenWrt | Varias | ✅ Script |
| Android | ARM64, ARM | ✅ APK (AWG solo sincronización) |

## Avanzado: Firmas de Protocolo CPS

CPS significa Firma de Protocolo Personalizado. Permite ensamblar paquetes de ofuscación personalizados que pueden imitar encabezados de protocolos arbitrarios; no está limitado a un protocolo específico.

Formato CPS:

```text
i{n} = <tag1><tag2>...<tagN>
```

Etiquetas:

- `<b 0xHEX>`: bytes estáticos
- `<r N>`: bytes aleatorios seguros
- `<c>`: contador
- `<t>`: marca de tiempo

Ejemplo:

```text
i1 = <b 0xf6ab3267fa><c><b 0xf6ab><t><r 10>
```
Si `i1` no está configurado, se omiten `i2`-`i5`.

## Solución de problemas

Verifique la instalación:


```bash
tailscale version
tailscale awg get
```

Si la conectividad se interrumpe, restablezca a WireGuard estándar y comience desde una configuración simple:

```bash
tailscale awg reset
tailscale awg set '{"jc":2,"jmin":64,"jmax":128}'
sudo journalctl -u tailscaled -f
```

En Windows PowerShell, prefiera la configuración interactiva para evitar problemas de escape JSON:

```powershell
tailscale awg set
```
## Enlaces y Soporte

- Lanzamientos: <https://github.com/LiuTangLei/tailscale/releases>
- APK para Android: <https://github.com/LiuTangLei/tailscale-android/releases>
- Problemas con el instalador: <https://github.com/LiuTangLei/tailscale-awg-installer/issues>
- Documentación Amnezia-WG: <https://docs.amnezia.org/documentation/instructions/new-amneziawg-selfhosted/#how-to-extract-a-protocol-signature-for-amneziawg-manually>

## Licencia

Licencia BSD de 3 cláusulas, igual que el Tailscale original.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---