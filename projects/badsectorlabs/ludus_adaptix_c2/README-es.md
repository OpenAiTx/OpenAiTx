# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Un rol de Ansible que instala el servidor y/o cliente del [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) y todas las [Extensiones](https://github.com/Adaptix-Framework/Extension-Kit) en un host Linux basado en Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Uso

Por defecto, el servidor escucha en el puerto `4321` y endpoint `/endpoint` con la contraseña `pass`. Se acepta cualquier nombre de usuario. Puedes cambiar estos valores usando las variables del rol, ver abajo.

En la máquina cliente, ejecuta el comando `adaptixclient` para iniciar la interfaz gráfica, y luego inicia sesión en el servidor usando la configuración anterior (a menos que se haya cambiado mediante variables).

## Requisitos

Ninguno.

## Variables del Rol

Las variables disponibles se listan a continuación, junto con sus valores predeterminados (ver `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # ¡Establece esta o la siguiente en true o el rol no hará nada!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug puede ser usado aquí
    ludus_adaptix_c2_go_version: 1.24.3
    # Todas las opciones siguientes son para que los clientes GUI de Adaptix se conecten al servidor, no para un agente c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Dependencias

Ninguna.

## Ejemplo de Playbook

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
## Ejemplo de Configuración de Rango Ludus

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
## Licencia

GPLv3

## Información del Autor

Este rol fue creado por [Bad Sector Labs](https://github.com/badsectorlabs), para [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---