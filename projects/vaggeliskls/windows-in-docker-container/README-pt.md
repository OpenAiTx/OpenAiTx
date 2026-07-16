
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# 💻 Windows em Container Docker
Descubra um método inovador e eficiente de implantar o sistema operacional Windows (x64) em seu sistema Linux usando o poder do Vagrant VM, libvirt e docker-compose. Juntas, essas tecnologias ajudam a containerizar o Windows OS, permitindo que você gerencie uma instância do Windows como faria com qualquer container Docker. Essa integração perfeita aos fluxos de trabalho existentes aumenta significativamente a conveniência e otimiza a alocação de recursos.

⭐ **Não se esqueça de favoritar o projeto se ele foi útil para você!**

## 📋 Pré-requisitos

Certifique-se de que seu sistema atende aos seguintes requisitos:

- **Docker:** Versão 20 ou superior [(Instale Docker)](https://www.docker.com/)

- **SO Hospedeiro:** Linux

- **Virtualização Habilitada:**
  - Verifique com:
    - `lscpu | grep -i Virtualization`
  - O resultado indica:
    - `VT-x` → Virtualização Intel é suportada e está habilitada.
    - `AMD-V` → Virtualização AMD é suportada e está habilitada.
  - Se a virtualização não estiver habilitada, ative-a nas configurações do BIOS/UEFI.

- **`cgroup: host`** no arquivo compose é obrigatório: libvirt e os daemons que ele inicia precisam de acesso total ao cgroup, caso contrário o container não inicia em hosts cgroup v2.

## 🚀 Guia de Implantação

1. Crie/Atualize o arquivo ambiental `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Crie `docker-compose.yml`
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
3. Crie `docker-compose.override.yml` quando desejar que sua VM seja persistente
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
4. Execute: `docker compose up -d`

> **A primeira inicialização leva vários minutos** — a box Vagrant já está incorporada na imagem, mas a VM ainda precisa inicializar e executar o script de provisionamento (instalação do Chocolatey, redimensionamento do disco, ajustes no registro). Acompanhe o progresso com `docker compose logs -f`.

> Quando quiser destruir tudo, use `docker compose down -v`

![captura de tela do windows](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Acesso  

### Área de Trabalho Remota (RDP)  
Para depuração ou teste, você pode se conectar à VM usando **Área de Trabalho Remota** na porta `3389`.  

#### Software para Acesso Remoto à Área de Trabalho  
| SO       | Software |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` ou [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Conexão de Área de Trabalho Remota** integrada |

---

### SSH   
Você pode se conectar via SSH usando as credenciais do usuário **administrator** ou **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Login do Usuário
Usuários padrão baseados na imagem Vagrant são:

1. Administrador
    - Nome de usuário: Administrator
    - Senha: vagrant
2. Usuário
    - Nome de usuário: vagrant
    - Senha: vagrant

## ⚠️ Limitações

- **Apenas host Linux** — depende de `/dev/kvm` e libvirt; hosts macOS e Windows não são suportados.
- **Licença de avaliação** — a box subjacente traz uma cópia de avaliação do Windows Server 2022. A ativação expira conforme os termos de avaliação da Microsoft.
- **Sem pastas sincronizadas** — `rsync`, `smb` e `nfs` estão todos desativados no [Vagrantfile](Vagrantfile) (rsync precisa de uma instalação no Windows antes do provisionamento; pastas SMB não são suportadas com host Linux; NFS em container resulta em `no support in current kernel`).
- **Desempenho** — sem KVM aninhado disponível para o Docker (ex: numa VM na nuvem que não expõe KVM), o convidado recorre ao QEMU puro e fica várias vezes mais lento.

## 🔧 Solução de Problemas

- **`KVM acceleration is not available`** nos logs → o host não está expondo `/dev/kvm`. Verifique se a virtualização está ativada na BIOS, se o módulo `kvm` está carregado (`lsmod | grep kvm`) e se `/dev/kvm` existe no host. O script de inicialização recorre automaticamente ao QEMU; espere uma grande desaceleração.
- **Porta 3389 / 2222 já em uso** → outro serviço RDP/SSH está vinculado no host. Pare-o, ou altere o mapeamento de porta no host em `docker-compose.yml`.
- **Container encerra imediatamente** → quase sempre é um problema de cgroup ou privilégios. Confirme que `privileged: true` e `cgroup: host` estão definidos, depois confira `docker compose logs win10`.
- **`vagrant up` trava em "Waiting for domain to get an IP address"** → a rede NAT padrão do libvirt não está rodando. Reinicie o container ou execute `virsh net-start default` dentro dele.

## 📚 Leitura e Recursos Adicionais

- [Tutorial do Windows Vagrant](https://github.com/SecurityWeekly/vulhub-lab)
- [Imagem Vagrant: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant por HashiCorp](https://www.vagrantup.com/)
- [Máquina Virtual Windows em um Container Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU dentro de um container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---