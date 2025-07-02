# luci-app-openlist

🗂️ Un programa de listado de archivos que soporta múltiples almacenamientos, impulsado por Gin y Solidjs.

## Cómo compilar

- Instala el paquete de desarrollo `libfuse`.

  - ubuntu/debian:
    ```shell
    sudo apt update
    sudo apt install libfuse-dev
    ```

  - redhat:
    ```shell
    sudo yum install fuse-devel
    ```

  - arch:
    ```shell
    sudo pacman -S fuse2
    ```

- Entra en tu directorio de openwrt

- SnapShots oficiales de Openwrt

  *1. requiere golang 1.24.x o la última versión (Soluciona la compilación para ramas antiguas de OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. obtener el código de luci-app-openlist y compilar*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # selecciona LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # compila luci-app-openlist
  ```

--------------

## Cómo instalar paquetes precompilados (LuCI2)

- Ingresa al terminal de OpenWrt (SSH)

- Instala el paquete `curl`
  ```shell
  # para el gestor de paquetes opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # para el gestor de paquetes apk
  apk update
  apk add curl
  ```

- Ejecuta el script de instalación (Soporte multi-arquitectura)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  instalar vía ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---