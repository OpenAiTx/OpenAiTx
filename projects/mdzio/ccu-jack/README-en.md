# CCU-Jack

CCU-Jack provides a simple and secure **REST** and **MQTT**-based access to the data points of the central unit (CCU) of the [home automation system](http://de.wikipedia.org/wiki/Hausautomation) HomeMatic by the company [eQ-3](http://www.eq-3.de/). It implements the [Very Easy Automation Protocol](https://github.com/mdzio/veap), which can be easily used by many programming languages, and the [MQTT protocol](https://de.wikipedia.org/wiki/MQTT), which is widely used in the Internet of Things. In addition, foreign devices can also be connected to the CCU using the mentioned protocols.

The following goals are pursued by CCU-Jack:

**CCU-Jack should enable other applications to easily access the data points of the CCU.** For example, accessing a CCU with HM, HM-Wired, and HM-IP devices requires a total of 9 network connections, partly as return channels and with different protocols. In addition, the network interfaces of the CCU are unencrypted, so they should not be opened in the CCU firewall. CCU-Jack standardizes access to all devices and system variables with a uniform protocol and over an encrypted connection.

**Furthermore, foreign devices (e.g., WLAN sockets) should be connected to the CCU and automated with it as simply as possible.** Connected foreign devices are presented on the CCU like original HM devices. They can be operated and monitored via the CCU’s web UI in the same way. In addition, they can be used without restrictions in CCU programs.

**Multiple CCUs and other automation devices with MQTT servers can be networked with each other via CCU-Jack and exchange value changes.** For this, CCU-Jack provides an MQTT bridge. CCUs can also be connected to an MQTT server in the cloud.

Functionally, CCU-Jack is an alternative to the [XML-API Add-On](https://github.com/jens-maus/XML-API). The XML-API Add-On has not been further developed for a long time and contains unresolved errors and security vulnerabilities. In addition, CCU-Jack can replace the combination of the two add-ons [hm2mqtt](https://github.com/owagner/hm2mqtt) and [Mosquitto](https://github.com/hobbyquaker/ccu-addon-mosquitto). The hm2mqtt add-on has also not been further developed for a long time.

Regarding the connection of foreign devices, CCU-Jack replaces many complicated and elaborate solutions while offering more functionality at the same time.

# User Manual

All information for users (e.g., installation, configuration) can be found in the [**User Manual**](https://github.com/mdzio/ccu-jack/wiki). This should be read before installation!

# Download

The officially released versions of CCU-Jack can be found on the right under [Releases](https://github.com/mdzio/ccu-jack/releases).

Pre-release versions that correspond to the latest development status can be found under [Actions](https://github.com/mdzio/ccu-jack/actions). Select a _workflow_ there, and then the download for all platforms is found under _Artifacts_. These versions already contain early new functionalities or bug fixes. However, they are not tested!

# CCU-Jack Environment

Other projects by others have emerged in connection with CCU-Jack:
* [CCU-Jack to HomeAssistant](https://github.com/kaistraube/ccujack_homeassistant) (Connection of HomeMatic CCU to HomeAssistant via CCU-Jack)
* [node-red-contrib-ccu-jack](https://github.com/ptweety/node-red-contrib-ccu-jack) (Connection of HomeMatic CCU to Node-RED via CCU-Jack)
* [ngx-ccu-jack-client](https://github.com/pottio/ngx-ccu-jack-client) (Integration of CCU-Jack into Angular applications)

# Development

## Building from Source

CCU-Jack is written in the [Go programming language](https://golang.org/). All distributions of CCU-Jack can be built very easily and quickly on all possible platforms (including Windows, Linux, MacOS). For this, clone the Git repository in any directory or copy the sources into it. Then open a command line in this directory and enter the following commands:
```
cd build
go run .
```
All distributions are then built in the main directory.

For development, the development environment [Visual Studio Code](https://code.visualstudio.com/) is recommended. Simply open the main directory. The necessary extensions will be automatically offered for installation.

## Contribution

Contributors are of course welcome. Whether for documentation, testing, support in the [HomeMatic forum](https://homematic-forum.de/forum/viewtopic.php?f=41&t=53553), debugging, or implementing new functionality. For code contributions, the license (GPL v3) must be observed. Code contributions should always be developed on a new branch separate from the `master` branch.

## Authors

* [Mathias Dz.](https://github.com/mdzio)
* [martgras](https://github.com/martgras) (Raspberry Pi 4, certificate handling)
* [twendt](https://github.com/twendt) (BIN-RPC for CUxD)
* [Theta Gamma](https://github.com/ThetaGamma) (Docker image)

## License and Disclaimer

License and disclaimer can be found in the file [LICENSE.txt](https://raw.githubusercontent.com/mdzio/ccu-jack/master/LICENSE.txt).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---