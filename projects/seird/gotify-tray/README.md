# Gotify Tray


A tray notification application for receiving messages from a [Gotify server](https://github.com/gotify/server).


## Getting started


- [Download the latest release.](https://github.com/seird/gotify-tray/releases/latest)

- or, install via pip:
    ```shell
    $ pip install gotify-tray
    ```

- or, run from source:
    ```shell
    $ pip install -r requirements.txt
    $ python -m gotify_tray
    ```


## Features

- Receive gotify messages in the native notification area.
- Reconnect after wake from sleep or losing network connection.
- Disable notification banners for low priority messages.
- Manually delete received messages.
- Go through a history of all previously received messages.
- Receive missed messages after losing network connection.


## Images


### Main window

Default                                         |  Dark                                                      
:-------------------------------------------------:|:---------------------------------------------------------:
![main window default](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/main_default.png)            |  ![main window dark](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/main_dark.png)


### Notification banners

Windows 10                                         |  KDE                                                      |  MacOS 12
:-------------------------------------------------:|:---------------------------------------------------------:|:---------------------------------------------------------:
![notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/notification.png)            |  ![kde_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/kde_notification.png)      |  ![macos_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/macos_notification.png)
![notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/notification_centre.png)     |  ![kde_notification](https://raw.githubusercontent.com/seird/gotify-tray/develop/images/kde_notification_centre.png) |  


## Build instructions

See [BUILDING](https://raw.githubusercontent.com/seird/gotify-tray/develop/BUILDING.md).


## Requirements

- python >=3.10
