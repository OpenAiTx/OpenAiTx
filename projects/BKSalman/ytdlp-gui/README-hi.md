# ytdlp-gui
yt-dlp के लिए एक GUI जो Rust में लिखा गया है

- [इंस्टॉलेशन](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [अन्य वितरण](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [सोर्स से बिल्ड करें](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [कॉन्फ़िगरेशन](https://github.com/BKSalman/ytdlp-gui#configuration)
- [योगदान](https://github.com/BKSalman/ytdlp-gui#contribution)

# पूर्वावलोकन
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# इंस्टॉलेशन
## लिनक्स

### NixOS (Flake)
आप रिपॉजिटरी में मौजूद flake.nix का उपयोग कर सकते हैं

अपने `flake.nix` में:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

फिर आप इसे सामान्य पैकेज की तरह अपने home-manager या nixosConfiguration में जोड़ सकते हैं

### Fedora
रिलीज़ पेज से rpm पैकेज डाउनलोड करें और फिर इसे ``sudo dnf localinstall <rpm_package_name>`` के साथ इंस्टॉल करें

### Ubuntu
रिलीज़ पेज से deb पैकेज डाउनलोड करें और फिर इसे ``sudo apt install ./<deb_package_name>`` के साथ इंस्टॉल करें

### Arch

AUR में उपलब्ध [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### अन्य वितरण

#### 1- ``yt-dlp`` डाउनलोड करें
या तो

&nbsp; &nbsp; &nbsp; a- अपने वितरण के रिपॉजिटरी से

&nbsp; &nbsp; &nbsp; b- या [बाइनरी](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp) डाउनलोड करें, फिर इसे अपने bin डायरेक्टरी में स्थानांतरित करें, और `chmod +x <bin_file>` चलाकर इसे executable बनाएं

#### 2- अपने वितरण के रिपॉजिटरी से ``ffmpeg`` या ``ffmpeg-free`` डाउनलोड करें

#### 3- [रिलीज़ पेज](https://github.com/BKSalman/ytdlp-gui/releases) से ``ytdlp-gui`` बाइनरी डाउनलोड करें

## Windows
##### बस रिलीज़ पेज से zip फ़ाइल डाउनलोड करें, इसे एक सबफ़ोल्डर में निकालें और ``ytdlp-gui.exe`` शुरू करें

# सोर्स से बिल्ड करें
सोर्स से बिल्ड करने के लिए आपके पास `cargo` और `rustc` होना ज़रूरी है, आप इन्हें `rustup` (rust टूलचेन मैनेजर) के माध्यम से या अपने वितरण के रिपॉजिटरी से इंस्टॉल कर सकते हैं, जो भी आपको पसंद हो

उसके बाद निम्न कमांड चलाएं:
```bash
# रिपॉजिटरी को "ytdlp-gui" फ़ोल्डर में क्लोन करें
git clone https://github.com/BKSalman/ytdlp-gui
# फ़ोल्डर में जाएं
cd ytdlp-gui
# आप प्रोजेक्ट को इस कमांड से बिल्ड कर सकते हैं
cargo build
# या बेहतर प्रदर्शन के लिए रिलीज़ मोड में बिल्ड करें
cargo build -r
```
फिर बाइनरी `<project-root>/target/debug/ytdlp-gui` या `<project-root>/target/release/ytdlp-gui` में होगी

और आप इसे सीधे चला सकते हैं:
```bash
# प्रोजेक्ट रूट से
./target/release/ytdlp-gui
```

या cargo का उपयोग करके:
```bash
cargo r
# या रिलीज़ मोड के लिए
cargo r -r
```

# कॉन्फ़िगरेशन

v0.2.2+ के लिए एप्लिकेशन संबंधित प्लेटफ़ॉर्म/OS की डिफ़ॉल्ट कॉन्फ़िग फोल्डर में ``<config_dir>/ytdlp-gui/config.toml`` में कॉन्फ़िगरेशन सेव करता है

डिफ़ॉल्ट फ़ाइल इस प्रकार दिखती है:

```toml
# वैकल्पिक
# यह bin का डायरेक्टरी है, bin स्वयं नहीं
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) यदि सेट नहीं है तो कमांड होगा `yt-dlp <app_args>`

# वैकल्पिक
download_folder = "<some_cool_path>" # डिफ़ॉल्ट = "~/Videos"

[options]
video_resolution = "FullHD" # विकल्प: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # विकल्प: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # विकल्प: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" # विकल्प: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### नोट: गुणवत्ता/फॉर्मेट विकल्प डाउनलोड बटन दबाने पर स्वचालित रूप से सेव हो जाते हैं

# योगदान
सभी प्रकार के योगदान स्वागत योग्य हैं, चाहे वह Pull requests हों, Issues (बग रिपोर्ट/सुधार अनुरोध) हों

हालांकि, मैं उनका तुरंत जवाब नहीं दे सकता या अनुरोधित चीज़ें लागू नहीं कर पाऊंगा, क्योंकि मैं अन्य चीज़ों पर ध्यान केंद्रित कर रहा हूँ

लेकिन मैं अपनी पूरी कोशिश करूंगा 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---