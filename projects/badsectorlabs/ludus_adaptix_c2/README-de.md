# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Eine Ansible-Rolle, die den [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) Server und/oder Client sowie alle [Erweiterungen](https://github.com/Adaptix-Framework/Extension-Kit) auf einem Debian-basierten Linux-Host installiert.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Verwendung

Standardmäßig lauscht der Server auf Port `4321` und Endpoint `/endpoint` mit dem Passwort `pass`. Jeder Benutzername wird akzeptiert. Diese Einstellungen können mit Rollenvariablen geändert werden, siehe unten.

Auf dem Client-Rechner führen Sie den Befehl `adaptixclient` aus, um die GUI zu starten, und melden sich dann mit den oben genannten Einstellungen (sofern nicht über Variablen geändert) am Server an.

## Voraussetzungen

Keine.

## Rollen-Variablen

Verfügbare Variablen sind unten aufgeführt, zusammen mit den Standardwerten (siehe `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Setzen Sie diese oder die unten stehende Variable auf true, andernfalls macht die Rolle nichts!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug kann hier verwendet werden
    ludus_adaptix_c2_go_version: 1.24.3
    # Alle unten stehenden Optionen sind für die Verbindung der Adaptix GUI-Clients zum Server, nicht für einen c2-Agenten
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Abhängigkeiten

Keine.

## Beispiel-Playbook

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
## Beispiel Ludus Range Konfiguration

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
## Lizenz

GPLv3

## Autoreninformationen

Diese Rolle wurde von [Bad Sector Labs](https://github.com/badsectorlabs) für [Ludus](https://ludus.cloud/) erstellt.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---