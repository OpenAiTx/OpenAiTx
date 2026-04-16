# gnome-gamma-tool

A command-line tool that let's you change gamma, contrast and brightness in GNOME and Cinnamon in a persistent manner by creating a color profile with the VCGT table.

## Disclaimer
**This only works with GNOME and Cinnamon**. Tested on Fedora with GNOME 42-48 and Cinnamon, it might not work with older/newer versions, albeit profiles already generated should continue to work.

This is rather hacky, color profiles were not meant to be used like that. But I think the use case is rare enough to justify this. After all, if your monitor doesn't let you change the gamma, isn't that a problem with the monitor?

See [How it works](#how-it-works) for a more detailed description.

**Note:** it's not possible to change the screen saturation or hue (due to VCGT limitations), but you can try using [gnome-saturation-extension](https://github.com/zb3/gnome-saturation-extension) (which has its drawbacks though).

## Usage
There's no need to install this, just clone this repository:
```
git clone https://github.com/zb3/gnome-gamma-tool
cd gnome-gamma-tool
```

**If** you're using Debian/Ubuntu, you might also need to install the `gir1.2-colord-1.0` package first:
```
sudo apt install gir1.2-colord-1.0
```
for OpenSUSE, you might need to install the `typelib-1_0-Colord-1_0` package instead:
```
sudo zypper install typelib-1_0-Colord-1_0
```
if you're using NixOS, check [this comment](https://github.com/zb3/gnome-gamma-tool/issues/28#issuecomment-3112277504)

Then you can invoke the tool like this:
```
./gnome-gamma-tool.py
```
(if this doesn't work, please open a new issue [here](https://github.com/zb3/gnome-gamma-tool/issues/new))

Once the new profile is installed, this tool can be safely removed.


### Adjusting screen gamma
The `-g` argument let's you specify the gamma correction factor. You can also use the `R:G:B` form to set it for individual channels.

For example:
```
./gnome-gamma-tool.py -g 0.8
```
or
```
./gnome-gamma-tool.py -g 0.8:0.8:0.8
```

### Adjusting contrast (or inverting colors)
You can also change the contrast using the `-c` parameter. `1` is the default value, while `-1` will effectively invert the colors. Make sure not to use the `0` value here as it will make your display all grey...

For example:
```
./gnome-gamma-tool.py -c -1
```

Note that it always starts from the initial state, hence the command above will undo any previous gamma adjustments, but you can combine different options:

```
./gnome-gamma-tool.py -g 0.8 -c 0.5
```

Per-channel settings work here too, so for instance it's possible to invert the blue channel while keeping red and green intact. Can you guess how this would look like? Give it a try:
```
./gnome-gamma-tool.py -c=1:1:-1
```
Was that what you expected? :)

### Changing color temperature
Color temperature can also be changed, use the `-t` option to specify the temperature. Values work just like in `redshift` where `6500` is the neutral value. Note that this doesn't prevent the night light feature from working, it's just that night light adjustments are made "on top of" what gnome-gamma-tool does.
```
./gnome-gamma-tool.py -t 5000
```

### Adjust brightness (kinda)
You can also adjust brightness with this tool, but it's not possible to increase the physical display brightness, it's only possible to decrease it by decreasing the maximum brightness value. Use the `-b` option to do that, it accepts values from `0` to `1`, where `1` is the neutral value:
```
./gnome-gamma-tool.py -b 0.7
```

There's another option here which let's you *increase* the *minimum* brightness value. It's the `-bm` option which also accepts values from `0` to `1`, this time `0` being the neutral value. After doing:
```
./gnome-gamma-tool.py -bm 0.3
```
the output value will never be smaller than `0.3` so black won't be black but actually grey, while white will still be white and colors in between will be multiplied accordingly. It's also possible to invert colors using the combination of `-b` and `-bm`:
```
./gnome-gamma-tool.py -b 0 -bm 1
```

And... that's not all, because these also work per individual channels, thanks to the `R:G:B` notation. This opens up new possibilities, like... making your screen more green (which you couldn't achieve with color temperature):
```
./gnome-gamma-tool.py -b 1:2:1
```
The above gets transformed into `0.5:1:0.5` first, and technically it makes your screen less red and less blue, but practically it makes the screen appear more green. What a useful feature, don't you think so?


### If you have multiple displays
You can specify the display *index* using the `-d` option (the first one has index `0` but that's the default one so you don't need to use this argument in this case...). The order of displays is the same as in the `Settings -> Color` panel. Here comes the example:
```
./gnome-gamma-tool.py -d 1 -g 0.7
```

You can also apply changes to all displays using the `-a` option:
```
./gnome-gamma-tool.py -a -g 0.7
```

### Exporting to a file

If you just want to create an ICC profile with the proper VCGT table but without interacting with your current configuration, you can use the `-o`/`--out-file` argument. Note that it will not load your current profile, so the output will be a sRGB profile unless you use the `-i`/`--in-file` argument to specify the base profile.

You can then import and apply it using a tool like `colormgr`.

```
# Create myprofile.icc file
python3 ./gnome-gamma-tool.py --min-brightness 0.05 --brightness 0.95 --out-file myprofile.icc

# This command will print Device ID, save it
colormgr get-devices

# This command will print Profile ID, save it
colormgr import-profile myprofile.icc

# This command will affect colors immediately
colormgr device-add-profile $displayId $profileId

# This command will remove imported profile and revert colors to original state immediately.
colormgr delete-profile $profileId
```

## How it works

Mutter (GNOME's compositor) does not implement any Wayland protocols that could help, so tools like `gammastep` or `wl-gammactl` won't work. Mutter, however, exposes the `SetCrtcGamma` method via D-Bus, and that method really works. Yet it's not how gnome-gamma-tool achieves it's purpose because:
* the value is not saved anywhere so the effect is not persistent
* this method is already called by another daemon, so the effect is only temporary.

That method is normally called by the `gsd-color` daemon (indirectly), and currently there are two things that can affect its arguments:
* VCGT table of the currently enabled color profile (retrieved via colord)
* color temperature derived from the "night light" settings
(these two are combined together)

Now, it might seem that the obvious solution here is to patch `gsd-color` to also take other things (like a GSettings property) into account, so you could tweak the gamma via the `gsettings` command. This would also open the possibility of adding a GUI to the Display panel later.

Yet again, this is not how gnome-gamma-tool operates, because patching `gsd-color` only makes sense if this patch is to be merged upstream. Otherwise it's completely unacceptable for me (and probably for you too) to have to apply custom patches and rebuild parts of GNOME. That's why gnome-gamma-tool installs a color profile with the correct "VCGT" table set up.

`gsd-color` doesn't manage color profiles, it observes them using the API provided by colord. To make a profile recognized by `gsd-color`, these things must be done:
* color profiles must be enabled for a given device
* that profile needs to be installed (in the colord database)
* that profile must be associated with the device
* that profile must be enabled

All those steps are performed using the API exposed by colord via D-Bus. gnome-gamma-tool doesn't create the new profile from scratch (unless you specify `-o`/`--out-file`), but it clones the current one and only modifies the VCGT table. By default, the current profile is the one generated by `gsd-color` from EDID data.

`gsd-color` listens for device/profile changes using D-Bus signals so it picks up our profile change and then eventually calls `SetCrtcGamma`. That's it!

What is this "VCGT" then? The VCGT (Video Card Gamma Table) basically maps color channel (R, G and B) values. Like if a channel has value `X` then the VCGT specifies that this should be translated to `Y`. Of course not every input value has a VCGT entry, that table has just 256 entries and the values are interpolated (but this is not done by gnome-gamma-tool).

VCGT makes it possible to change gamma (via exponentiation), contrast and brightness, but it's not possible to change hue this way, because one channel can't affect any other.
