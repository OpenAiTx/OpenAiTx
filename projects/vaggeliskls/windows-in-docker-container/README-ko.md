<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=vaggeliskls&project=windows-in-docker-container&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 💻 도커 컨테이너에서 윈도우
Vagrant VM, libvirt, 그리고 docker-compose의 강력한 조합을 사용하여 리눅스 시스템에서 Windows OS(x64)를 배포하는 혁신적이고 효율적인 방법을 알아보세요. 이 기술들은 Windows OS를 컨테이너화하여, 윈도우 인스턴스를 마치 다른 도커 컨테이너처럼 관리할 수 있도록 도와줍니다. 기존 워크플로우에 매끄럽게 통합되어 편의성이 크게 향상되고 자원 할당이 최적화됩니다.

⭐ **이 프로젝트가 도움이 되었다면 꼭 Star를 눌러주세요!**

## 📋 사전 준비 사항

다음 요구 사항을 시스템이 충족하는지 확인하세요:


- **Docker:** 버전 20 이상 [(Docker 설치하기)](https://www.docker.com/)

- **호스트 OS:** Linux

- **가상화 활성화됨:**
  - 다음 명령어로 확인:
    - `lscpu | grep -i Virtualization`
  - 출력 결과:
    - `VT-x` → 인텔 가상화가 지원 및 활성화됨.
    - `AMD-V` → AMD 가상화가 지원 및 활성화됨.
  - 가상화가 활성화되어 있지 않다면 BIOS/UEFI 설정에서 활성화하세요.

- compose 파일에서 **`cgroup: host`** 설정은 필수: libvirt와 해당 데몬들은 전체 cgroup 접근이 필요하며, 그렇지 않으면 cgroup v2 호스트에서 컨테이너가 시작되지 않습니다.

## 🚀 배포 가이드

1. 환경 파일 `.env`를 생성/업데이트하세요.
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. `docker-compose.yml` 생성하기
```yaml
services:
  win10:
    image: docker.io/vaggeliskls/windows-in-docker-container:latest
    platform: linux/amd64
    env_file: .env
    stdin_open: true
    tty: true
    privileged: true
    cgroup: host
    restart: always
    ports:
      - 3389:3389
      - 2222:2222
```
3. VM를 영구적으로 유지하려면 `docker-compose.override.yml`을 생성하세요
```yaml
services:
  win10:
    volumes:
      - libvirt_data:/var/lib/libvirt
      - vagrant_data:/root/.vagrant.d
      - vagrant_project:/app/.vagrant
      - libvirt_config:/etc/libvirt

volumes:
  libvirt_data:
    name: libvirt_data
  vagrant_data:
    name: vagrant_data
  vagrant_project:
    name: vagrant_project
  libvirt_config:
    name: libvirt_config
```
4. Run: `docker compose up -d`

> **첫 부팅에는 몇 분이 소요됩니다** — Vagrant 박스는 이미 이미지에 포함되어 있지만, VM은 여전히 부팅되고 프로비저닝 스크립트(Chocolatey 설치, 디스크 크기 조정, 레지스트리 수정)를 실행해야 합니다. 진행 상황은 `docker compose logs -f`로 확인하세요.

> 모든 것을 삭제하려면 `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 접근  

### 원격 데스크톱 (RDP)  
디버깅이나 테스트를 위해 포트 `3389`에서 **원격 데스크톱**을 사용하여 VM에 연결할 수 있습니다.  

#### 원격 데스크톱 접속용 소프트웨어  
| 운영체제   | 소프트웨어 |
|----------|----------------|
| **리눅스**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` 또는 [`Remmina`](https://remmina.org/) |
| **맥OS**    | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **윈도우**  | 내장된 **원격 데스크톱 연결** |

---

### SSH   
**administrator** 또는 **Vagrant** 사용자 자격증명을 사용하여 SSH로 연결할 수 있습니다.  

```bash
ssh <user>@<host> -p 2222
```
## 🔑 사용자 로그인
Vagrant 이미지 기반 기본 사용자는 다음과 같습니다:

1. 관리자
    - 사용자 이름: Administrator
    - 비밀번호: vagrant
2. 사용자
    - 사용자 이름: vagrant
    - 비밀번호: vagrant

## ⚠️ 제한 사항

- **Linux 호스트 전용** — `/dev/kvm` 및 libvirt에 의존; macOS 및 Windows 호스트는 지원하지 않습니다.
- **평가판 라이선스** — 기본 박스는 Windows Server 2022 평가판을 제공합니다. Microsoft의 평가 조건에 따라 활성화가 만료됩니다.
- **동기화 폴더 없음** — `rsync`, `smb`, `nfs` 모두 [Vagrantfile](Vagrantfile)에서 비활성화되어 있습니다 (rsync는 프로비저닝 실행 전 Windows 측 설치가 필요; SMB 동기화 폴더는 Linux 호스트에서 지원하지 않음; 컨테이너 내 NFS는 `현재 커널에서 지원하지 않음` 오류 발생).
- **성능** — Docker에 중첩 KVM이 없으면(예: KVM을 노출하지 않는 클라우드 VM) 게스트는 일반 QEMU로 대체되어 여러 배 느려집니다.

## 🔧 문제 해결

- **로그에 `KVM 가속을 사용할 수 없음` 표시** → 호스트가 `/dev/kvm`을 노출하지 않음. BIOS에서 가상화가 활성화되어 있는지, `kvm` 모듈이 로드되었는지(`lsmod | grep kvm`), 호스트에 `/dev/kvm`이 존재하는지 확인하세요. 시작 스크립트는 자동으로 QEMU로 대체되며, 큰 속도 저하가 예상됩니다.
- **포트 3389 / 2222가 이미 사용 중** → 호스트에서 다른 RDP/SSH 서비스가 바인딩되어 있습니다. 서비스를 중지하거나 `docker-compose.yml`에서 호스트 쪽 포트 매핑을 변경하세요.
- **컨테이너가 즉시 종료됨** → 거의 항상 cgroup 또는 권한 문제입니다. `privileged: true`와 `cgroup: host`가 설정되어 있는지 확인한 후 `docker compose logs win10`을 확인하세요.
- **`vagrant up`이 "도메인이 IP 주소를 받는 중"에서 멈춤** → libvirt 기본 NAT 네트워크가 실행 중이지 않습니다. 컨테이너를 재시작하거나 내부에서 `virsh net-start default`를 실행하세요.

## 📚 추가 자료 및 참고 문서

- [Windows Vagrant 튜토리얼](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant 이미지: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorp의 Vagrant](https://www.vagrantup.com/)
- [Linux Docker 컨테이너 내 Windows 가상 머신](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [컨테이너 내 GPU](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---