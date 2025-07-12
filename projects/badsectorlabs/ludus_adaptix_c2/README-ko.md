# Ansible 역할: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

Debian 기반 리눅스 호스트에 [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) 서버 및/또는 클라이언트와 모든 [확장 프로그램](https://github.com/Adaptix-Framework/Extension-Kit)을 설치하는 Ansible 역할입니다.

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## 사용법

기본적으로 서버는 포트 `4321`과 엔드포인트 `/endpoint`에서 비밀번호 `pass`로 대기합니다. 모든 사용자 이름이 허용됩니다. 이러한 값들은 역할 변수로 변경할 수 있습니다. 아래를 참조하세요.

클라이언트 머신에서 `adaptixclient` 명령어를 실행하여 GUI를 시작한 후, 위의 설정(변수로 변경하지 않은 경우)을 사용하여 서버에 로그인할 수 있습니다.

## 요구 사항

없음.

## 역할 변수

사용 가능한 변수와 기본값은 아래에 나와 있습니다( `defaults/main.yml` 참조):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # 이것 또는 아래 값을 true로 설정하지 않으면 역할이 아무것도 하지 않습니다!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug를 여기에 사용할 수 있습니다
    ludus_adaptix_c2_go_version: 1.24.3
    # 아래 모든 옵션은 Adaptix GUI 클라이언트가 서버에 연결할 때 사용하는 것이며, c2 에이전트용이 아닙니다.
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: pass
    ludus_adaptix_c2_generate_certificate: true
    ludus_adaptix_c2_common_name: localhost
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:localhost,DNS:127.0.0.1,DNS:::1"

## 종속성

없음.

## 예시 플레이북

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
## 예시 Ludus Range 구성

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
## 라이선스

GPLv3

## 작성자 정보

이 역할은 [Ludus](https://ludus.cloud/)를 위해 [Bad Sector Labs](https://github.com/badsectorlabs)에서 만들었습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---