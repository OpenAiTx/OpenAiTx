# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Um Papel Ansible que instala o servidor e/ou cliente do [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) e todas as [Extensões](https://github.com/Adaptix-Framework/Extension-Kit) em um host Linux baseado em Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Uso

Por padrão, o servidor escuta na porta `4321` e endpoint `/endpoint` com a senha `pass`. Qualquer nome de usuário é aceito. Você pode alterar esses valores com variáveis do papel, veja abaixo.

Na máquina cliente, execute o comando `adaptixclient` para iniciar a GUI e então faça login no servidor usando as configurações acima (a menos que tenha alterado via variáveis).

## Requisitos

Nenhum.

## Variáveis do Papel

As variáveis disponíveis estão listadas abaixo, juntamente com os valores padrão (veja `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Defina este ou o abaixo como true ou o papel não fará nada!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug pode ser usado aqui
    ludus_adaptix_c2_go_version: 1.24.3
    # Todas as opções abaixo são para os clientes GUI do Adaptix se conectarem ao servidor, não para um agente c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Dependências

Nenhuma.

## Exemplo de Playbook

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
## Exemplo de Configuração de Faixa Ludus

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
## Licença

GPLv3

## Informações do Autor

Este papel foi criado por [Bad Sector Labs](https://github.com/badsectorlabs), para [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---