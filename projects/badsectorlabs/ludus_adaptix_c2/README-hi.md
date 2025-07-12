# Ansible Role: [Adaptix C2](https://adaptix-framework.gitbook.io/adaptix-framework) ([Ludus](https://ludus.cloud))

एक Ansible रोल जो [Adaptix Framework](https://adaptix-framework.gitbook.io/adaptix-framework) सर्वर और/या क्लाइंट तथा सभी [एक्सटेंशन](https://github.com/Adaptix-Framework/Extension-Kit) को एक डेबियन आधारित लिनक्स होस्ट पर इंस्टॉल करता है।

![Adaptix Framework](https://raw.githubusercontent.com/badsectorlabs/ludus_adaptix_c2/main/docs/adaptix.png)

## उपयोग

डिफ़ॉल्ट रूप से सर्वर पोर्ट `4321` और एंडपॉइंट `/endpoint` पर पासवर्ड `pass` के साथ सुनता है। कोई भी यूज़रनेम स्वीकार किया जाता है। आप इन्हें रोल वेरिएबल्स के माध्यम से बदल सकते हैं, नीचे देखें।

क्लाइंट मशीन पर, `adaptixclient` कमांड चलाएँ ताकि GUI शुरू हो सके, और फिर ऊपर दिए गए सेटिंग्स (जब तक वेरिएबल्स के ज़रिए बदला न गया हो) का उपयोग करके सर्वर में लॉग इन करें।

## आवश्यकताएँ

कोई नहीं।

## रोल वेरिएबल्स

उपलब्ध वेरिएबल्स नीचे सूचीबद्ध हैं, डिफ़ॉल्ट मानों के साथ (देखें `defaults/main.yml`):

    ludus_adaptix_c2_version: 3af8e10c8c2d7d48e3636f48b0f9c80da4d6015d # 0.5 2024-05-28
    ludus_adaptix_c2_install_server: false # इसे या नीचे वाले को true करें, अन्यथा रोल कुछ नहीं करेगा!
    ludus_adaptix_c2_install_client: false
    ludus_adaptix_c2_profile_url:
    ludus_adaptix_c2_profile_raw:
    ludus_adaptix_c2_server_args: # -debug यहाँ इस्तेमाल किया जा सकता है
    ludus_adaptix_c2_go_version: 1.24.3
    # नीचे दिए गए सभी विकल्प Adaptix GUI क्लाइंट्स के लिए हैं ताकि वे सर्वर से कनेक्ट हो सकें, न कि किसी c2 एजेंट के लिए
    ludus_adaptix_c2_port: 4321
    ludus_adaptix_c2_endpoint: /endpoint
    ludus_adaptix_c2_password: पास
    ludus_adaptix_c2_generate_certificate: सही
    ludus_adaptix_c2_common_name: लोकलहोस्ट
    ludus_adaptix_c2_organization_name: Adaptix C2
    ludus_adaptix_c2_subject_alt_name_array: "DNS:लोकलहोस्ट,DNS:127.0.0.1,DNS:::1"

## डिपेंडेंसीज़

कोई नहीं।

## उदाहरण प्लेबुक

```yaml
- hosts: adaptix_server_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_server: सही

- hosts: adaptix_client_host
  roles:
    - badsectorlabs.ludus_adaptix_c2
  vars:
    ludus_adaptix_c2_install_client: सही    
```
## उदाहरण लुडस रेंज कॉन्फ़िग

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
## लाइसेंस

GPLv3

## लेखक जानकारी

यह रोल [Bad Sector Labs](https://github.com/badsectorlabs) द्वारा [Ludus](https://ludus.cloud/) के लिए बनाया गया था।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---