> [!IMPORTANT]
> If you are looking to root your echo, this project is now obselete; please use the solution documented [here](https://xdaforums.com/t/unlock-root-twrp-unbrick-amazon-echo-dot-2nd-gen-2016-biscuit.4761416/) instead. Thank you so much to everyone who made this possible, it's been so fun to work on this project! :)

# EchoCLI
A tethered root solution for your echo dot 2nd generation.
To start, run `main.py`
<br>

[<kbd> <br> How does this work? <br> </kbd>](https://dragon863.github.io/blog/echoroot.html)

## Notice
- Due to software updates being pushed constantly, I cannot guarantee that this will work for your echo. If you encounter any issues, feel free to contact me, and if you find a bug pull requests are welcome.
- It is **strongly** recommended that you run this on a linux machine, as I am unable to test it on Windows and there is no guarantee that Windows-specific bugs are not present

> **Warning**
> 
> **This is a TETHERED root solution** It is _recommended_ to block amazon's OTA servers (https://d1s31zyz7dcc2d.cloudfront.net and https://d1s31zyz7dcc2d.cloudfront.prod.ota-cloudfront.net) to prevent updates from corrupting or removing root on your device. I am not responsible for any damage to your device

## Features
- Rooted ADB shell over USB or Wi-Fi
- Record audio from device
- Use your Echo as an indicator for Home Assistant without internet
- Restore your device to factory configuration

## Install
- This project requires python 3.
- I recommend using linux for running this program. Please ensure you have disabled ModemManager if you have it installed.
Install requirements using `pip`:
```sh
pip install -r requirements.txt
```
- You will also require fastboot and ADB, there is a good guide on how to install these [here](https://wiki.lineageos.org/adb_fastboot_guide). After downloading these you can set the executable path in the config.json file.
- Please ensure that the micro USB cable you use to connect your echo dot is a data cable and not a power-only variant.

## Documentation
You can find how this tool works on [my website](https://dragon863.github.io/blog/echoroot.html).

Once you have rooted the device, a file called `preloader_no_hdr.bin` will be generated. To boot the device, you will need to install [mtkclient](https://github.com/bkerler/mtkclient), copy the file into its directory and run `python mtk plstage --ptype=kamakiri2 --preloader=preloader_no_hdr.bin`. Replace `python` with `python3` depending on the python version you have installed.

## Home assistant indicator 
When using the home assistant indicator feature, I would recommend using a raspberry pi zero w or other small SBC to run the python flask server, and boot the device. You can use crontab to make this happen automatically on boot using mtkclient.

## Bricked your echo?
Follow the guide [here](https://github.com/Dragon863/EchoCLI/blob/main/debrick.md) to use mtkclient for unbricking a rooted or partially rooted echo

## Thanks

This project would not have been possible without:
- [j10hx40r](https://forum.xda-developers.com/m/j10hx40r.11878441/) - For helping me with initially rooting my device, redesigning the patching system and showing me how to use fos_flags in combination and generally pointing me in the right direction when finding resources
- [xyzz's Amonet](https://github.com/xyzz/amonet) - This is the exploit I have adapted for this device, including the bootrom exploit
- [chaosmaster](https://github.com/chaosmaster) - Wrote lots of useful amonet code from which I used several snippets, including for fixing my GPT

## Contact me
- You can email me at dragon863.dev@gmail.com
- You can start a conversation on [XDA](https://forum.xda-developers.com/m/lemon86.12487447/)
