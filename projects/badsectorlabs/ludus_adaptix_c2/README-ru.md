# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Ansible-роль, которая устанавливает сервер и/или клиент [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework), а также все [расширения](https://github.com/Adaptix-Framework/Extension-Kit) на хост с Linux на базе Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Использование

По умолчанию сервер слушает порт `4321` и конечную точку `/endpoint` с паролем `pass`. Принимается любое имя пользователя. Вы можете изменить эти параметры с помощью переменных роли, см. ниже.

На клиентской машине выполните команду `adaptixclient` для запуска графического интерфейса, затем войдите на сервер, используя указанные выше настройки (если они не были изменены через переменные).

## Требования

Отсутствуют.

## Переменные роли

Доступные переменные перечислены ниже вместе со значениями по умолчанию (см. `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Установите это или следующую переменную в true, иначе роль ничего не сделает!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # Здесь можно использовать -debug
    ludus_adaptix_c2_go_version: 1.24.3
    # Все параметры ниже предназначены для подключения клиентов Adaptix GUI к серверу, а не c2-агента
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Зависимости

Отсутствуют.

## Пример плейбука

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
## Пример конфигурации диапазона Ludus

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
## Лицензия

GPLv3

## Информация об авторе

Эта роль была создана [Bad Sector Labs](https://github.com/badsectorlabs) для [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---