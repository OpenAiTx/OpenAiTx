# PicoLoader
This is an ODE-based modchip for the Nintendo GameCube to boot homebrew.\
Its price and functionality are very similar to [PicoBoot](https://github.com/webhdx/PicoBoot) but it has multiple advantages.

Join the [Discord server](https://discord.gg/YtA9aU3BKZ) to get support and discuss the mod!

## How does it work?
This mod works by emulating a disk drive during boot, executing a homebrew app, and afterwards re-enabling the disk drive.\
This is achieved using a flex PCB similar to FlippyDrive.
However, it is not a full optical drive emulator and only allows executing small homebrew apps (e.g. [swiss](https://github.com/emukidid/swiss-gc)) from flash just like PicoBoot.
To access files on an SD card, you need an SDGecko, SD2SP2, or similar adapter, which can be purchased separately.

## Features
- Open source
- You can keep the disk drive
- Simple to boot most homebrew apps using an [online converter](https://makeo.github.io/PicoLoader/converter/)
- No permanent modifications to the GameCube
- [3D printed plug](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl) for installs without a disk drive 
- Easy to remove
- Running Pico at 200Mhz for better compatibility with clone boards

#### Soldered Variant
- Cheap and easy to get components (Raspberry Pi Pico/Pico 2 + Flex PCB + Diode)
- Readily available
- No soldering directly to the GameCube
- Easy soldering
- Alternative install options: [Panasonic Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option), [low-profile](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)

#### Solderless Variant
- No soldering
- Easily replaceable flex PCB
- Pre-programmed with PicoLoader firmware and [Swiss](https://github.com/emukidid/swiss-gc)
> [!TIP]
> You can buy the solderless and normal variant from [store.makstech.io](https://store.makstech.io/).

## Planned Features
*cricket sound*

## Installation & Documentation
> [!IMPORTANT]
> Please follow the [installation instructions](https://makeo.github.io/PicoLoader/) in the wiki.\
> When not following the instructions, there is a chance of breaking the flex PCB during installation.

Get started by looking at the 📖[Wiki](https://github.com/makeo/PicoLoader/wiki/1.-Home)!

## Gallery

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## Special Thanks
- [silversteel](https://github.com/silverstee1) for his help, especially for making the flex PCBs and mounts
- [TeamOffBroadway](https://github.com/OffBroadway) for the amazing idea to use a flex PCB to intercept the drive signals
- [Extrems](https://github.com/Extrems), [emukidid](https://github.com/emukidid) and everyone involved in creating Swiss
- [novenary (9ary)](https://github.com/9ary) for gekkoboot

## Acknowledgements
The source of [gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) and [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr) is licensed under GPL-2.0 and available [here](https://github.com/makeo/cubeboot-tools)
