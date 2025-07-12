# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Un ruolo Ansible che installa il [Framework Adaptix](https://adaptix-framework.gitbook.io/adaptix-framework) come server e/o client e tutte le [Estensioni](https://github.com/Adaptix-Framework/Extension-Kit) su un host Linux basato su Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Utilizzo

Di default il server ascolta sulla porta `4321` e sull’endpoint `/endpoint` con password `pass`. Qualsiasi username è accettato. Puoi modificare questi parametri tramite le variabili del ruolo, vedi sotto.

Sulla macchina client, esegui il comando `adaptixclient` per avviare la GUI, poi accedi al server utilizzando le impostazioni sopra (a meno che non siano state cambiate tramite variabili).

## Requisiti

Nessuno.

## Variabili del Ruolo

Le variabili disponibili sono elencate di seguito, insieme ai valori predefiniti (vedi `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Imposta questa o la seguente su true altrimenti il ruolo non farà nulla!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug può essere usato qui
    ludus_adaptix_c2_go_version: 1.24.3
    # Tutte le opzioni sottostanti sono per i client GUI Adaptix che si connettono al server, non per un agente c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Dipendenze

Nessuna.

## Esempio di Playbook

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
## Esempio di Configurazione Ludus Range

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
## Licenza

GPLv3

## Informazioni sull'autore

Questo ruolo è stato creato da [Bad Sector Labs](https://github.com/badsectorlabs), per [Ludus](https://ludus.cloud/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---