
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
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

# 💻 डॉकर कंटेनर में विंडोज
Vagrant VM, libvirt, और docker-compose की शक्ति का उपयोग करके अपने लिनक्स सिस्टम पर Windows OS (x64) को डिप्लॉय करने की एक अभिनव और कुशल विधि खोजें। ये तकनीकें मिलकर आपको Windows OS को कंटेनराइज़ करने में सक्षम बनाती हैं, जिससे आप किसी भी डॉकर कंटेनर की तरह ही Windows इंस्टेंस को प्रबंधित कर सकते हैं। मौजूदा वर्कफ़्लो में इसका सहज एकीकरण आपकी सुविधा को काफी बढ़ाता है और संसाधनों के आवंटन को अनुकूलित करता है।

⭐ **अगर यह प्रोजेक्ट आपके लिए उपयोगी रहा हो तो इसे स्टार करना न भूलें!**

## 📋 पूर्वापेक्षाएँ

सुनिश्चित करें कि आपका सिस्टम निम्नलिखित आवश्यकताओं को पूरा करता है:

- **डॉकर:** संस्करण 20 या उससे ऊपर [(डॉकर इंस्टॉल करें)](https://www.docker.com/)

- **होस्ट ओएस:** लिनक्स

- **वर्चुअलाइजेशन सक्षम:**
  - जाँचें:
    - `lscpu | grep -i Virtualization`
  - आउटपुट दर्शाता है:
    - `VT-x` → इंटेल वर्चुअलाइजेशन समर्थित और सक्षम है।
    - `AMD-V` → एएमडी वर्चुअलाइजेशन समर्थित और सक्षम है।
  - यदि वर्चुअलाइजेशन सक्षम नहीं है, तो इसे BIOS/UEFI सेटिंग्स में सक्षम करें।

- **`cgroup: host`** कंपोज़ फ़ाइल में आवश्यक है: libvirt और इसके द्वारा स्पॉन किए गए डेमॉन को पूर्ण cgroup एक्सेस की आवश्यकता होती है, अन्यथा कंटेनर cgroup v2 होस्ट पर शुरू होने में विफल रहता है।

## 🚀 परिनियोजन गाइड

1. पर्यावरण फ़ाइल `.env` बनाएँ/अपडेट करें
```
# Vagrant image settings
MEMORY=8000     # MiB (~8 GB)
CPU=4
DISK_SIZE=100   # GiB
```
2. `docker-compose.yml` बनाएँ
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
3. जब आप चाहते हैं कि आपका VM स्थायी रहे, तब `docker-compose.override.yml` बनाएँ
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
4. चलाएँ: `docker compose up -d`

> **पहली बार बूट होने में कुछ मिनट लग सकते हैं** — Vagrant बॉक्स पहले से ही इमेज में शामिल है, लेकिन VM को बूट होना और provisioning script (Chocolatey इंस्टॉल, डिस्क रिसाइज़, रजिस्ट्री ट्वीक) चलाना बाकी है। प्रगति देखने के लिए `docker compose logs -f` का उपयोग करें।

> जब आप सबकुछ हटाना चाहें तो `docker compose down -v` चलाएँ

![windows screenshot](https://github.com/vaggeliskls/windows-in-docker-container/blob/main/images/screen-1.png?raw=true )

## 🌐 एक्सेस  

### रिमोट डेस्कटॉप (RDP)  
डिबगिंग या टेस्टिंग के लिए, आप VM से **रिमोट डेस्कटॉप** पोर्ट `3389` के माध्यम से कनेक्ट कर सकते हैं।  

#### रिमोट डेस्कटॉप एक्सेस के लिए सॉफ़्टवेयर  
| OS       | सॉफ़्टवेयर |
|----------|----------------|
| **Linux**   | [`rdesktop`](https://github.com/rdesktop/rdesktop) → `rdesktop <ip>:3389` या [`Remmina`](https://remmina.org/) |
| **MacOS**   | [Microsoft Remote Desktop](https://apps.apple.com/us/app/microsoft-remote-desktop/id1295203466?mt=12) |
| **Windows** | बिल्ट-इन **Remote Desktop Connection** |

---

### SSH   
आप **administrator** या **Vagrant** यूज़र क्रेडेंशियल्स का उपयोग करके SSH के माध्यम से कनेक्ट कर सकते हैं।  

```bash
ssh <user>@<host> -p 2222
```

## 🔑 उपयोगकर्ता लॉगिन
Vagrant इमेज पर आधारित डिफ़ॉल्ट उपयोगकर्ता निम्नलिखित हैं:

1. व्यवस्थापक
    - उपयोगकर्ता नाम: Administrator
    - पासवर्ड: vagrant
2. उपयोगकर्ता
    - उपयोगकर्ता नाम: vagrant
    - पासवर्ड: vagrant

## ⚠️ सीमाएँ

- **केवल लिनक्स होस्ट** — यह `/dev/kvm` और libvirt पर निर्भर करता है; macOS और Windows होस्ट समर्थित नहीं हैं.
- **मूल्यांकन लाइसेंस** — बेस बॉक्स Windows Server 2022 की एक इवैल्युएशन कॉपी के साथ आता है। सक्रियता Microsoft के मूल्यांकन शर्तों के अनुसार समाप्त हो जाती है.
- **कोई सिंक्ड फोल्डर नहीं** — `rsync`, `smb`, और `nfs` सभी [Vagrantfile](Vagrantfile) में डिसेबल हैं (rsync को provisioning से पहले Windows साइड पर इंस्टॉल करना होगा; SMB सिंक्ड फोल्डर लिनक्स होस्ट के साथ समर्थित नहीं हैं; कंटेनर के अंदर NFS में `no support in current kernel` त्रुटि आती है).
- **प्रदर्शन** — यदि Docker को nested KVM उपलब्ध नहीं है (जैसे कि ऐसे क्लाउड VM पर जो KVM एक्सपोज़ नहीं करता), तो गेस्ट केवल QEMU पर निर्भर करता है और कई गुना धीमा चलता है.

## 🔧 समस्या निवारण

- लॉग में **`KVM acceleration is not available`** → होस्ट `/dev/kvm` को एक्सपोज़ नहीं कर रहा है। देखें कि BIOS में वर्चुअलाइजेशन सक्षम है, `kvm` मॉड्यूल लोडेड है (`lsmod | grep kvm`), और `/dev/kvm` होस्ट पर मौजूद है। स्टार्टअप स्क्रिप्ट अपने आप QEMU पर स्विच कर जाती है; प्रदर्शन में भारी गिरावट अपेक्षित है.
- **पोर्ट 3389 / 2222 पहले से उपयोग में है** → कोई अन्य RDP/SSH सेवा होस्ट पर बाइंड है। उसे रोकें, या `docker-compose.yml` में होस्ट-साइड पोर्ट मैपिंग बदलें.
- **कंटेनर तुरंत बंद हो जाता है** → लगभग हमेशा cgroup या विशेष अनुमति की समस्या होती है। पुष्टि करें कि `privileged: true` और `cgroup: host` सेट हैं, फिर `docker compose logs win10` जांचें.
- **`vagrant up` "Waiting for domain to get an IP address" पर अटका है** → libvirt का डिफ़ॉल्ट NAT नेटवर्क चल नहीं रहा है। कंटेनर को रीस्टार्ट करें, या उसके अंदर से `virsh net-start default` चलाएँ.

## 📚 आगे पढ़ने और संसाधन

- [Windows Vagrant ट्यूटोरियल](https://github.com/SecurityWeekly/vulhub-lab)
- [Vagrant इमेज: peru/windows-server-2022-standard-x64-eval](https://app.vagrantup.com/peru/boxes/windows-server-2022-standard-x64-eval)
- [HashiCorp द्वारा Vagrant](https://www.vagrantup.com/)
- [Linux Docker कंटेनर में Windows वर्चुअल मशीन](https://medium.com/axon-technologies/installing-a-windows-virtual-machine-in-a-linux-docker-container-c78e4c3f9ba1)
- [कंटेनर के अंदर GPU](https://docs.nvidia.com/datacenter/cloud-native/container-toolkit/latest/install-guide.html)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-16

---