# Ansible 角色: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

一個 Ansible 角色，可在基於 Debian 的 Linux 主機上安裝 [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) 伺服器和/或客戶端以及所有 [擴充套件](https://github.com/Adaptix-Framework/Extension-Kit)。

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## 使用方式

預設情況下，伺服器監聽埠為 `4321`，端點為 `/endpoint`，密碼為 `pass`。任何使用者名稱皆可接受。您可以透過角色變數更改這些設置，詳見下文。

在客戶端機器上，執行指令 `adaptixclient` 以啟動 GUI，然後使用上述（除非經由變數更改）設定登入伺服器。

## 需求

無。

## 角色變數

可用變數如下，並附有預設值（參見 `defaults/main.yml`）：

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # 這個或下方的必須設為 true，否則角色不會執行任何操作！
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # 這裡可以使用 -debug
    ludus_adaptix_c2_go_version: 1.24.3
    # 以下所有選項均供 Adaptix GUI 客戶端連接至伺服器之用，並非用於 c2 agent
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## 相依性

無。

## 範例 Playbook

```yaml
- hosts: adaptix_server_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_server: true

- hosts: adaptix_client_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_client: true    
```
## 範例 Ludus Range 設定

```yaml
ludus:
  - vm_name: "{{ range_id }}-adaptix-server"
    hostname: "{{ range_id }}-adaptix"
    template: debian-12-x64-server-template
    vlan: 99
    ip_last_octet: 1
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_server: true

  - vm_name: "{{ range_id }}-kali-1"
    hostname: "{{ range_id }}-kali-1"
    template: kali-x64-desktop-template
    vlan: 99
    ip_last_octet: 2
    ram_gb: 4
    cpus: 2
    linux: true
    roles:
      - badsectorlabs.ludus_adaptix_c2
    role_vars:
      ludus_adaptix_c2_install_client: true
```
## 授權

GPLv3

## 作者資訊

此角色由 [Bad Sector Labs](https://github.com/badsectorlabs) 為 [Ludus](https://ludus.cloud/) 所創建。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---