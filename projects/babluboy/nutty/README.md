# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
A Network Utility

Author: Siddhartha Das

A simple application made for elementary OS to provide essential information on network related aspects. The information presented in as the following tabs.<br>
1. My Info: Provides basic and detailed information for the device network card<br>
2. Usage: Provides network data usage in two views - historical usage and current usage<br>
3. Speed: Check Upload and Download speeds and get route times to a host<br>
4. Ports: Provides information on active ports and application using them on the local device<br>
5. Devices: Monitors, alerts and provides information on the other devices connected on the network<br>

Check the Nutty website for details on features, shortcuts, installation guides for Ubuntu and other supported distros, etc. : <br>
https://babluboy.github.io/nutty/

## Building, Testing, and Installation from Source

You'll need the following dependencies to build:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

And these dependencies to execute:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

Sometimes vnstat is not started upon install, use the appropriate init system command to start vnstat daemon i.e. `sudo systemctl enable vnstat`

Run `meson build` to configure the build environment and run `ninja test` to build

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```

To install, use `sudo ninja install`, then execute with `com.github.babluboy.nutty`

```
sudo ninja install
com.github.babluboy.nutty
```

To uninstall ,go to the build directory and run
```
sudo ninja uninstall
```

### Installation from Deb package

To install Nutty from the `.deb` package make sure you have installed all the above execution dependencies of Nutty (no need build dependencies). Then run the below command
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
