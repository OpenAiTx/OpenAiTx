# 💻 Windows dans un conteneur Docker  
Découvrez une méthode innovante et efficace pour déployer Windows OS (x64) sur votre système Linux en utilisant la puissance de Vagrant VM, libvirt et docker-compose. Ensemble, ces technologies vous aident à containeriser Windows OS, vous permettant de gérer une instance Windows comme vous le feriez pour n’importe quel conteneur Docker. Cette intégration transparente dans les flux de travail existants améliore considérablement la commodité et optimise l’allocation des ressources.  

⭐ **N’oubliez pas de mettre une étoile au projet s’il vous a aidé !**  

## 📋 Prérequis  

Assurez-vous que votre système répond aux exigences suivantes :  

- **Docker :** Version 20 ou supérieure [(Installer Docker)](https://www.docker.com/)  

- **OS hôte :** Linux  

- **Virtualisation activée :**  
  - Vérifiez avec :  
    - `lscpu | grep -i Virtualization`  
  - La sortie indique :  
    - `VT-x` → La virtualisation Intel est prise en charge et activée.  
    - `AMD-V` → La virtualisation AMD est prise en charge et activée.  
  - Si la virtualisation n’est pas activée, activez-la dans les paramètres BIOS/UEFI.  

- **`cgroup: host`** dans le fichier compose est requis : libvirt et les démons qu’il lance ont besoin d’un accès complet aux cgroups, sinon le conteneur ne démarre pas sur les hôtes avec cgroup v2.  

## 🚀 Guide de déploiement  

1. Créez/Mettre à jour le fichier environnemental `.env`
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. Créez `docker-compose.yml`
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
3. Créez `docker-compose.override.yml` lorsque vous souhaitez que votre machine virtuelle soit persistante
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
4. Exécutez : `docker compose up -d`

> **Le premier démarrage prend plusieurs minutes** — la boîte Vagrant est déjà intégrée dans l’image, mais la VM doit encore démarrer et exécuter le script de provisionnement (installation de Chocolatey, redimensionnement du disque, modifications du registre). Suivez la progression avec `docker compose logs -f`.

> Lorsque vous souhaitez tout détruire, utilisez `docker compose down -v`

![capture d'écran Windows](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 Accès  

### Bureau à distance (RDP)  
Pour le débogage ou les tests, vous pouvez vous connecter à la VM via **Bureau à distance** sur le port `3389`.  

#### Logiciels pour l'accès Bureau à distance  
| OS       | Logiciel |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` ou [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | **Connexion Bureau à distance** intégrée |

---

### SSH   
Vous pouvez vous connecter via SSH en utilisant les identifiants de l’utilisateur **administrator** ou **Vagrant**.  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 Connexion utilisateur
Les utilisateurs par défaut basés sur l'image Vagrant sont :

1. Administrateur
    - Nom d'utilisateur : Administrator
    - Mot de passe : vagrant
2. Utilisateur
    - Nom d'utilisateur : vagrant
    - Mot de passe : vagrant

## ⚠️ Limitations

- **Linux uniquement** — dépend de `/dev/kvm` et libvirt ; les hôtes macOS et Windows ne sont pas supportés.
- **Licence d’évaluation** — la boîte sous-jacente inclut une copie d’évaluation de Windows Server 2022. L’activation expire selon les conditions d’évaluation de Microsoft.
- **Pas de dossiers synchronisés** — `rsync`, `smb` et `nfs` sont tous désactivés dans le [Vagrantfile](Vagrantfile) (rsync nécessite une installation côté Windows avant le provisionnement ; les dossiers SMB ne sont pas supportés avec un hôte Linux ; NFS dans le conteneur affiche `no support in current kernel`).
- **Performance** — sans KVM imbriqué disponible pour Docker (par exemple sur une VM cloud qui n’expose pas KVM), l’invité revient à QEMU simple et est plusieurs fois plus lent.

## 🔧 Dépannage

- **`KVM acceleration is not available`** dans les logs → l’hôte n’expose pas `/dev/kvm`. Vérifiez que la virtualisation est activée dans le BIOS, que le module `kvm` est chargé (`lsmod | grep kvm`), et que `/dev/kvm` existe sur l’hôte. Le script de démarrage revient automatiquement à QEMU ; attendez un ralentissement important.
- **Port 3389 / 2222 déjà utilisé** → un autre service RDP/SSH est lié sur l’hôte. Arrêtez-le ou modifiez le mappage de port côté hôte dans `docker-compose.yml`.
- **Le conteneur se ferme immédiatement** → presque toujours un problème de cgroup ou de privilèges. Confirmez que `privileged: true` et `cgroup: host` sont définis, puis vérifiez `docker compose logs win10`.
- **`vagrant up` bloque à "Waiting for domain to get an IP address"`** → le réseau NAT par défaut de libvirt ne fonctionne pas. Redémarrez le conteneur ou lancez `virsh net-start default` depuis l’intérieur.

## 📚 Lectures complémentaires et ressources

- [Tutoriel Windows Vagrant](https://github.com/SecurityWeekly/vulhub-lab)
- [Image Vagrant : peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant par HashiCorp](https://www.vagrantup.com/)
- [Machine virtuelle Windows dans un conteneur Docker Linux](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU dans un conteneur](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-15

---