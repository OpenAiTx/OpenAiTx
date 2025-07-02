# luci-app-openlist

🗂️ Um programa de listagem de arquivos que suporta múltiplos armazenamentos, desenvolvido com Gin e Solidjs.

## Como compilar

- Instale o pacote de desenvolvimento `libfuse`.

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

- Entre no seu diretório do openwrt

- SnapShots oficiais do Openwrt

  *1. requer golang 1.24.x ou versão mais recente (Corrige a compilação para branches mais antigos do OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. obter o código do luci-app-openlist & compilar*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # escolha LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # compilar luci-app-openlist
  ```

--------------

## Como instalar pacotes pré-compilados (LuCI2)

- Acesse o terminal do OpenWrt (SSH)

- Instale o pacote `curl`
  ```shell
  # para o gerenciador de pacotes opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # para o gerenciador de pacotes apk
  apk update
  apk add curl
  ```

- Execute o script de instalação (Suporte multi-arquitetura)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  instalar via ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---