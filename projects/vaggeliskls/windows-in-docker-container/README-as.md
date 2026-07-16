
<div align="right">
  <details>
    <summary >🌐 ভাষা</summary>
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

# 💻 ডকাৰ কণ্টেইনাৰত উইণ্ড’জ
Vagrant VM, libvirt, আৰু docker-compose ৰ শক্তি ব্যৱহাৰ কৰি আপোনাৰ লিনাক্স ছিষ্টেমত Windows OS (x64) ডিপ্লয় কৰাৰ এটা উদ্ভাৱনী আৰু কাৰ্যকৰী পদ্ধতি আৱিষ্কাৰ কৰক। এই সকলো প্ৰযুক্তিয়ে একেলগ হৈ Windows OS কণ্টেইনাৰাইজ কৰিবলৈ সহায় কৰে, যাৰ দ্বাৰা আপুনি যিকোনো ডকাৰ কণ্টেইনাৰৰ দৰে এটা উইণ্ড’জ ইনষ্টেন্স ব্যৱস্থাপনা কৰিব পাৰে। এই নিৰবিচ্ছিন্ন সংহতিয়ে বিদ্যমান কৰ্মপ্রবাহত সুবিধা বৃদ্ধি কৰে আৰু সম্পদৰ উত্তম ব্যৱহাৰ নিশ্চিত কৰে।

⭐ **প্ৰকল্পটোৱে আপোনাক সহায় কৰিলে অনুগ্ৰহ কৰি ষ্টাৰ দিয়ক!**

## 📋 পূৰ্বশর্তসমূহ

আপোনাৰ ছিষ্টেমে তলত উল্লেখ কৰা শর্তসমূহ পূৰণ কৰিছে নিশ্চিত কৰক:

- **ডকৰ:** সংস্কৰণ ২০ বা তাতকৈ ওপৰ [(ডকৰ সংস্থাপন কৰক)](https://www.docker.com/)

- **হোস্ট অপাৰেটিং ছিষ্টেম:** লিনাক্স

- **Virtualization সক্ৰিয় কৰা:**
  - পৰীক্ষা কৰিবলৈ:
    - `lscpu | grep -i Virtualization`
  - আউটপুটত দেখুৱাব:
    - `VT-x` → Intel virtualization সমৰ্থিত আৰু সক্ৰিয়।
    - `AMD-V` → AMD virtualization সমৰ্থিত আৰু সক্ৰিয়।
  - যদি virtualization সক্ৰিয় হোৱা নাই, BIOS/UEFI ছেটিংছত সক্ৰিয় কৰক।

- **`cgroup: host`** compose file-ত প্ৰয়োজন: libvirt আৰু ইয়াৰ দ্বাৰা চালিত daemons-এ সম্পূৰ্ণ cgroup accessৰ আৱশ্যকতা থাকে, নহ'লে cgroup v2 হোস্টত container আৰম্ভ হ'ব নোৱাৰে।

## 🚀 স্থাপন গাইড

1. পৰিবেশ ফাইল `.env` সৃষ্টি/আপডেট কৰক
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. `docker-compose.yml` সৃষ্টি কৰক
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
3. আপোনাৰ VM স্থায়ী হ’বলৈ চাইলে `docker-compose.override.yml` সৃষ্টি কৰক
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
4. চলাও: `docker compose up -d`

> **প্ৰথমবাৰৰ বাবে বুট কৰিবলৈ কেইমিনিটমান লাগিব** — Vagrant বক্সটো ইতিমধ্যে ইমেজত সংযোজিত আছে, কিন্তু VM-টো এতিয়াও বুট হ’ব লাগে আৰু প্ৰভিশনিং স্ক্ৰিপ্ট চলাব লাগে (Chocolatey ইনষ্টল, ডিস্ক ৰিসাইজ, ৰেজিষ্ট্ৰী টুইক)। অগ্ৰগতি পৰ্যবেক্ষণ কৰিবলৈ ব্যৱহাৰ কৰক `docker compose logs -f`।

> সকলো ধ্বংস কৰিব বিচাৰিলে ব্যৱহাৰ কৰক `docker compose down -v`

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 এক্সেছ  

### ৰিম’ট ডেস্কটপ (RDP)  
ডিবাগিং বা পৰীক্ষাৰ বাবে, আপুনি **Remote Desktop** ব্যৱহাৰ কৰি VM-টোত `3389` প’ৰ্টৰ জৰিয়তে সংযোগ কৰিব পাৰে।  

#### ৰিম’ট ডেস্কটপ এক্সেছৰ বাবে ছফ্টৱেৰ  
| অপাৰেটিং চিষ্টেম | ছফ্টৱেৰ |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` বা [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | অন্তর্নিহিত **Remote Desktop Connection** |

---

### SSH   
আপুনি **administrator** বা **Vagrant** ব্যৱহাৰকাৰীৰ শংসাপত্ৰ ব্যৱহাৰ কৰি SSH-ৰ জৰিয়তে সংযোগ কৰিব পাৰে।  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 ব্যৱহাৰকাৰী লগইন
Vagrant ইমেজৰ আধাৰত ডিফ'ল্ট ব্যৱহাৰকাৰীসমূহ হৈছে:

1. প্ৰশাসক (Administrator)
    - ব্যৱহাৰকাৰী নাম: Administrator
    - পাছৱৰ্ড: vagrant
2. ব্যৱহাৰকাৰী (User)
    - ব্যৱহাৰকাৰী নাম: vagrant
    - পাছৱৰ্ড: vagrant

## ⚠️ সীমাবদ্ধতা

- **কেৱল Linux হোস্ট** — ই `/dev/kvm` আৰু libvirt-ৰ ওপৰত নিৰ্ভৰ কৰে; macOS আৰু Windows হোস্ট সমৰ্থিত নহয়।
- **Eval লাইচেঞ্চ** — মুল বক্সটো Windows Server 2022-ৰ এটা মূল্যায়ন কপিৰ সৈতে আহে। Microsoft-ৰ মূল্যায়ন চৰ্ত অনুসৰি সক্ৰিয়কৰণৰ সময় সীমা থাকে।
- **কোনো synced ফোল্ডাৰ নাই** — `rsync`, `smb`, আৰু `nfs` সকলো [Vagrantfile](Vagrantfile)-ত নিষ্ক্ৰিয়। (rsync-ৰ বাবে provisioning চলাৰ আগতে Windows-ত ইনষ্টল কৰিব লাগে; Linux হোস্টত SMB synced folder সমৰ্থিত নহয়; কণ্টেইনৰ ভিতৰত NFS-ত `no support in current kernel` সমস্যা দেখা যায়।)
- **কৰ্মদক্ষতা (Performance)** — Docker-লৈ nested KVM উপলব্ধ নাথাকিলে (উদাহৰণস্বৰূপে, KVM উন্মুক্ত নকৰা ক্ৰাউড VM-ত), guest-এ সাধাৰণ QEMU-লৈ ঘূৰি যায় আৰু বহু গুণে ধীৰ হয়।

## 🔧 সমস্যাৰ সমাধান

- লগত **`KVM acceleration is not available`** → হোস্টে `/dev/kvm` উন্মুক্ত কৰা নাই। BIOS-ত virtualization সক্ৰিয় আছে নে চাওক, `kvm` মডিউল লোড হৈছে নে চাওক (`lsmod | grep kvm`), আৰু হোস্টত `/dev/kvm` আছে নে চাওক। আৰম্ভণি script-এ স্বয়ংক্ৰিয়ভাৱে QEMU-লৈ ঘূৰি যায়; ডাঙৰ ধীৰগতি আশা কৰক।
- **Port 3389 / 2222 ইতিমধ্যে ব্যৱহৃত** → আন এটা RDP/SSH সেৱা হোস্টত সংযুক্ত হৈছে। বন্ধ কৰক, বা `docker-compose.yml`-ত host-side port mapping সলনি কৰক।
- **কণ্টেইনাৰ তৎক্ষণাৎ ওলাই যায়** → প্ৰায় সদায় এটা cgroup বা privilege সমস্যাৰ বাবে। `privileged: true` আৰু `cgroup: host` সংজ্ঞা আছে নে নিশ্চিত কৰক, তাৰপাছত `docker compose logs win10` পৰীক্ষা কৰক।
- **`vagrant up`-ত "Waiting for domain to get an IP address"ত অটকি থাকে** → libvirt-ৰ ডিফ'ল্ট NAT নেটৱৰ্ক চলি থকা নাই। কণ্টেইনাৰটো পুনৰ আৰম্ভ কৰক, বা তাৰ ভিতৰত `virsh net-start default` চলাওক।

## 📚 অধিক পঢ়া আৰু উৎস

- [Windows Vagrant Tutorial](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant image: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [Vagrant by HashiCorp](https://www.vagrantup.com/)
- [Windows Virtual Machine in a Linux Docker Container](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [GPU inside a container](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---