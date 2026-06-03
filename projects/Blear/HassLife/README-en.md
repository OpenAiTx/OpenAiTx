## Introduction

**Communication QQ Group: 528735636**

Home Assistant component

[![hacs_badge](https://img.shields.io/badge/HACS-Custom-41BDF5.svg?style=for-the-badge)](https://github.com/hacs/integration)

This Home Assistant component enables Tmall Genie, Xiao Ai, and Xiaodu speakers to connect with devices on the HomeAssistant platform, controlling devices and querying reported device status.

Note: This plugin only handles control commands and device status reporting. Adding devices must be configured on the [HassLife](https://hass.blear.cn) platform.

## Installation

### 1. Install the plugin

##### Method 1: Install via HACS 【Recommended!】
>> Sidebar HACS -> Integrations -> Search hasslife and click download

##### Method 2: Manual download [Download plugin](https://gitee.com/blear/HassLife)
>> Download the `hasslife` folder and save it in the `<homeassistant config directory>/custom_components/` directory. If `custom_components` does not exist, create it yourself, then restart HomeAssistant.
- Where is the HomeAssistant config directory?

>> **Windows users:** `%APPDATA%\.homeassistant`

>> **Linux-based users:** You can find the `.homeassistant` folder by running the command `locate .homeassistant/configuration.yaml`, which is the config directory.

>> **Synology Docker users:** Go to Docker - Images - homeassistant - Advanced Settings - Volume, the path corresponding to `/config` is the config directory.


### 2. Configure the plugin
##### Method 1: Integration UI configuration
>> **Click Configuration on the HomeAssistant sidebar -> Integrations -> Add integration at the bottom right -> Search hasslife and click -> Enter registered hasslife account and password and submit. The plugin takes some time to start the first time, please wait patiently.**

If you encounter a message that this integration does not support UI configuration, and you came from the Home Assistant website link, please ensure you are running the latest version of Home Assistant.
You can manually add the account configuration and then restart HomeAssistant.

## Usage Steps：
	1. Register a HassLife account by opening https://hass.blear.cn, register and log in
	2. Install the plugin: after installation, restart HomeAssistant, then go to the Add Integration page, add the HassLife integration, and log in with the HassLife account.
	3. Continue back to the HassLife website page, if your plugin configuration is correct, the personal center page will show the plugin status as `Online`
	4. Click the device management menu, click the green `Add Homeassistant Device` button on the right, check the devices you want to add and submit
	5. Select the device you want to configure in the device list, click `Configure` and choose the smart speaker platform you want to connect to, then configure the device type and voice control name as needed
	6. Go to the corresponding platform skill binding page, bind your HassLife account, and you should see the added devices without any issues.

## Tmall Genie Configuration Example
* Install the latest version of the `Tmall Genie` APP
* Use your mobile browser to visit [HassLife https://hass.blear.cn](https://hass.blear.cn) and log in to your HassLife account
* Click to visit the `Tmall Genie Skill Entry` on the personal center page
* Click `Bind Platform Account`
* Log in to your HassLife account
* Confirm authorization, return to the Genie home tab, and you will see the added devices

## Xiaomi AI Speaker Configuration Example
* Enter the HassLife device list page, add the required devices, and configure the corresponding device types and names
* Install the latest version of the `Mi Home` APP
* Open the `Mi Home` APP
* Click the `Me` tab
* Click `Other Platform Devices`
* Click the `Add` button in the upper right corner
* Find `HassLife` and click it
* Click `Bind Account`
* Log in to your HassLife account
* Confirm authorization and synchronize devices

## Baidu Speaker Configuration Example
* Enter the HassLife device list page, add the required devices, and configure the corresponding device types and names
* Install the latest version of the `Baidu` APP
* Open the `Baidu` APP
* Click the `Plus` icon in the upper right corner
* Click `Add Device`
* Search for `HassLife` and click it
* Log in to your HassLife account
* Confirm authorization and synchronize devices

## Supported Devices and Attributes for Tmall Genie

Currently supported device types include: Light, Switch, Clothes Rack, Curtain, TV, Water Heater, Fan, Sensor, Air Conditioner, Binary Selector.

    Devices that support on/off status include: Light, Switch, Clothes Rack, Curtain, TV, Water Heater, Fan, Sensor, Air Conditioner, Binary Selector.
    
    Light support adjustment: color, brightness, color temperature
    
    Air conditioner supports mode switching: cooling, heating, ventilation, dehumidification, automatic, temperature adjustment. Fan speed supports: low, medium, high, automatic
    
    Clothes drying rack supports: drying rod control, switch control
    
    Curtain supports: opening and closing of curtains
    
    Fan supports: power control (turn on/off fan), speed control (1-100 levels (percentage speed), highest gear, resistance gear, medium-low gear, medium-high gear, high gear, super strong gear, breeze gear, automatic gear), left-right rotation / oscillation / swing



## Xiao Ai Assistant Supported Devices and Attributes

Currently supported device types: light, switch, curtain, fan, air conditioner.

    Device switch state supports devices: light, switch, curtain, fan, air conditioner.
    
    Light supports adjustment: color, brightness, color temperature
    
    Air conditioner supports mode switching: cooling, heating, ventilation, dehumidification, automatic, temperature adjustment. Fan speed supports: low, medium, high, automatic
    
    Curtain supports: opening and closing of curtains
    
    Fan supports: power control (turn on/off fan), speed control (1-100 levels (percentage speed), left-right rotation / oscillation / swing
   

    
## Xiaodu Speaker Supported Devices and Attributes

    Device switch state supports devices: light, switch, curtain, fan, air conditioner.
    
    Light supports adjustment: on/off
    
    Air conditioner supports mode switching: cooling, heating, ventilation, dehumidification, automatic, temperature adjustment. Fan speed supports: low, medium, high, automatic
    
    Curtain supports: opening and closing of curtains
    
    Fan supports: power control (turn on/off fan), speed control (1-10 levels)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---