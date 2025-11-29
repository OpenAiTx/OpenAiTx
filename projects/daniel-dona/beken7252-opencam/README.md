# Beken7252 OpenCam
RT-Thread alternative project for A9 cameras

# Updates
## 25/09/25
I have finished my MSc and now have a bit more free time, with many of these cameras still around. It's time to plan a first proper release for this project. I've been working on this for some weeks and right now I have an early version that boots, connects to Wi-Fi, reads and writes from SD card, supports MQTT and most importantly, works with at least 3 different camera sensors: GC0311, HI704 and GC0328. This include storing pictures and streaming using HTTP (with multipart/x-mixed-replace). 

It still needs additional testing for stability and improving the general state of the SDK and the project. 

Check [this ticket](https://github.com/daniel-dona/beken7252-opencam/issues/21) for a detailed plan for version 1.0.0.

## 20/11/2023
Last month, I was waiting for some additional A9 cameras to arrive, as I only had one, and I was concerned about ruining the PCB with this constant soldering and unsoldering of test wires.
Well, that didn't result as expected. I got like 12 different cameras as they were just like 3€ in Aliexpress, and I got:

~6 with a Beken chip

~3 with an unknown chip, that looks like some custom XRadio/Allwinner

~1 with other vendor that I don't remember

~1 with a chip with any markings

Yeah, the numbers don't sum up very well; the important thing is that I got more with the Beken chip... or is It? 

The chip is marked as BK7252, but the pinout is different. The chip that is documented and that we have at least a datasheet has 68 pints; this has 48 pins and the reference is BK7252UQN48. 

More here: https://github.com/daniel-dona/beken7252-opencam/wiki/BK7252-SoC-variations

I'm not going to work with this chip for the moment. I tried to upload a working code to this chip, and it is not working as expected. For sure, they removed some functionalities, or now they are muxed differently. Maybe memory regions for some registers are different, perhaps I'm stupid, and I uploaded the code wrong...

In any case, I think it is better to work first to have something working in the known chip, and then we can explore this new one. 

# Known SDKs
- FreeRTOS: https://github.com/YanMinge/beken_freertos_sdk_release
- RT-Thread: https://github.com/YangAlex66/bdk_rtt and https://github.com/biemster/bdk_rtt_v3

# Related sources and posts:
- [TODO]


# TODO

- Document variants for PCB and sensors
- Document pinouts for camera variants
- Document flashing procedure (and unbricking)
- Cleanup Beken SDK
- Migrate SDK code to more modern GCC and Scons
- Other (?)
