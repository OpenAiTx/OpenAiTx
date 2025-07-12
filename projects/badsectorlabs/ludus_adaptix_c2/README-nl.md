# Ansible Rol: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Een Ansible Rol die de [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) server en/of client en alle [Extensies](https://github.com/Adaptix-Framework/Extension-Kit) installeert op een Debian gebaseerde Linux host.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Gebruik

Standaard luistert de server op poort `4321` en endpoint `/endpoint` met wachtwoord `pass`. Elke gebruikersnaam wordt geaccepteerd. Je kunt deze instellingen wijzigen met rolvariabelen, zie hieronder.

Op de clientmachine voer je het commando `adaptixclient` uit om de GUI te starten en log je vervolgens in op de server met bovenstaande instellingen (tenzij gewijzigd via variabelen).

## Vereisten

Geen.

## Rolvariabelen

Beschikbare variabelen worden hieronder weergegeven, samen met de standaardwaarden (zie `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Zet deze of de onderstaande op true, anders doet de rol niets!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug kan hier gebruikt worden
    ludus_adaptix_c2_go_version: 1.24.3
    # Alle onderstaande opties zijn bedoeld voor de Adaptix GUI-clients om verbinding te maken met de server, niet voor een c2-agent
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: wachtwoord
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Afhankelijkheden

Geen.

## Voorbeeld Playbook

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
## Voorbeeld Ludus Range Configuratie

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
## Licentie

GPLv3

## Auteurinformatie

Deze rol is gemaakt door [Bad Sector Labs](https://github.com/badsectorlabs), voor [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---