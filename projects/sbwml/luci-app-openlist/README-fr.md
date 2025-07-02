# luci-app-openlist

🗂️ Un programme de liste de fichiers prenant en charge plusieurs stockages, propulsé par Gin et Solidjs.

## Comment compiler

- Installer le paquet de développement `libfuse`.

  - ubuntu/debian :
    ```shell
    sudo apt update
    sudo apt install libfuse-dev
    ```

  - redhat :
    ```shell
    sudo yum install fuse-devel
    ```

  - arch :
    ```shell
    sudo pacman -S fuse2
    ```

- Entrez dans votre répertoire openwrt

- SnapShots officiels Openwrt

  *1. nécessite golang 1.24.x ou la dernière version (Corrige la compilation pour les branches plus anciennes d'OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. obtenir le code de luci-app-openlist & compilation*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # choisir LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # compiler luci-app-openlist
  ```

--------------

## Comment installer les paquets précompilés (LuCI2)

- Connectez-vous au terminal OpenWrt (SSH)

- Installer le paquet `curl`
  ```shell
  # pour le gestionnaire de paquets opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # pour le gestionnaire de paquets apk
  apk update
  apk add curl
  ```

- Exécuter le script d'installation (prise en charge multi-architecture)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  installation via ghproxy :
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---