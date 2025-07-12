# Rola Ansible: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Rola Ansible instalująca serwer i/lub klienta [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) oraz wszystkie [Rozszerzenia](https://github.com/Adaptix-Framework/Extension-Kit) na hoście z systemem Linux opartym na Debianie.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Użycie

Domyślnie serwer nasłuchuje na porcie `4321` i endpointzie `/endpoint` z hasłem `pass`. Akceptowana jest dowolna nazwa użytkownika. Możesz zmienić te ustawienia za pomocą zmiennych roli, patrz poniżej.

Na komputerze klienckim uruchom polecenie `adaptixclient`, aby uruchomić GUI, a następnie zaloguj się do serwera, używając powyższych ustawień (chyba że zostały zmienione przez zmienne).

## Wymagania

Brak.

## Zmienne roli

Dostępne zmienne wymienione są poniżej wraz z domyślnymi wartościami (zobacz `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Ustaw to lub poniższe na true, w przeciwnym razie rola nic nie zrobi!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug można użyć tutaj
    ludus_adaptix_c2_go_version: 1.24.3
    # Wszystkie opcje poniżej służą do połączenia klientów GUI Adaptix z serwerem, nie agenta c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Zależności

Brak.

## Przykładowy Playbook

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
## Przykładowa konfiguracja zakresu Ludus

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
## Licencja

GPLv3

## Informacje o autorze

Ta rola została stworzona przez [Bad Sector Labs](https://github.com/badsectorlabs), dla [Ludus](https://ludus.cloud/).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---