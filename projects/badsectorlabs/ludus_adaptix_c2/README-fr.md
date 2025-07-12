# Rôle Ansible : [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Un rôle Ansible qui installe le serveur et/ou le client [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) ainsi que toutes les [Extensions](https://github.com/Adaptix-Framework/Extension-Kit) sur un hôte Linux basé sur Debian.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## Utilisation

Par défaut, le serveur écoute sur le port `4321` et l’endpoint `/endpoint` avec le mot de passe `pass`. N’importe quel nom d’utilisateur est accepté. Vous pouvez modifier ces paramètres avec les variables du rôle, voir ci-dessous.

Sur la machine cliente, exécutez la commande `adaptixclient` pour lancer l’interface graphique, puis connectez-vous au serveur en utilisant les paramètres ci-dessus (sauf si vous les avez modifiés via les variables).

## Prérequis

Aucun.

## Variables du rôle

Les variables disponibles sont listées ci-dessous, avec leurs valeurs par défaut (voir `defaults/main.yml`) :

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # Mettez cette variable ou celle ci-dessous à true sinon le rôle ne fera rien !
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug peut être utilisé ici
    ludus_adaptix_c2_go_version: 1.24.3
    # Toutes les options ci-dessous concernent la connexion des clients GUI Adaptix au serveur, pas un agent c2
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## Dépendances

Aucune.

## Exemple de Playbook

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
## Exemple de configuration de gamme Ludus

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
## Licence

GPLv3

## Informations sur l’auteur

Ce rôle a été créé par [Bad Sector Labs](https://github.com/badsectorlabs), pour [Ludus](https://ludus.cloud/).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---