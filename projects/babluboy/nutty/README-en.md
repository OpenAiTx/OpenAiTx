
<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">Simplified Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">Traditional Chinese</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">Japanese</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">Korean</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">French</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">German</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Spanish</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italian</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Russian</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Portuguese</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Dutch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polish</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">Arabic</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">Persian</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Turkish</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Vietnamese</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Indonesian</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">Assamese</
      </div>
    </div>
  </details>
</div>

# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
A Network Utility

Author: Siddhartha Das

A simple application made for elementary OS to provide essential information on network related aspects. The information presented in as the following tabs.<br>
1. My Info: Provides basic and detailed information for the device network card<br>
2. Usage: Provides network data usage in two views - historical usage and current usage<br>
3. Speed: Check Upload and Download speeds and obtain route times to a host<br>
4. Ports: Provides information about active ports and the applications using them on the local device<br>
5. Devices: Monitors, alerts, and provides information about other devices connected to the network<br>

Check the Nutty website for more details on features, shortcuts, installation guides for Ubuntu and other supported distributions, etc.:<br>
https://babluboy.github.io/nutty/

## Building, Testing, and Installation from Source

You will need the following dependencies to build:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

And these dependencies to run:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Sometimes vnstat does not start after installation; use the appropriate init system command to start the vnstat daemon, i.e. `sudo systemctl enable vnstat`

Run `meson build` to configure the build environment and run `ninja test` to build

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
To install, use `sudo ninja install`, then run with `com.github.babluboy.nutty`


```
sudo ninja install
com.github.babluboy.nutty
```
To uninstall, go to the build directory and run

```
sudo ninja uninstall
```

### Installation from Deb package

To install Nutty from the `.deb` package, make sure you have installed all the above runtime dependencies of Nutty (no need for build dependencies). Then run the command below
```bash
sudo dpkg -i <deb-package-name>.deb
```
And to uninstall Nutty installed via `.deb` package run

```bash
sudo apt autoremove com.github.babluboy.nutty
```
If you want to directly build the `.deb` package of Nutty yourself then install the above build dependencies and then run

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---