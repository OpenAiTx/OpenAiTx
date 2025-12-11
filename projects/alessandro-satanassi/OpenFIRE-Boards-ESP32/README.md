## ... porting OpenFIRE-Boards for EPS32

Questo repository è un porting del progetto originale 'OpenFIRE-Boards' del TeamOpenFIRE, adattato per funzionare sul microcontrollore ESP32S3.
Salvo alcuni adattamenti e piccole modifiche, il codice rimane sostanzialmente fedele all'originale del TeamOpenFIRE.
Il codice di questo repository funziona anche sul microcontrollore RP2040.
Ogni volta che verranno apportate modifiche al progetto originale 'OpenFIRE-Boards' del TeamOpenFIRE, aggiornerò di conseguenza anche il codice di questo repository.
Ringrazio di cuore il TeamOpenFIRE per la creazione del progetto 'OpenFIRE-Boards': a loro vanno tutti i meriti e la mia piena gratitudine.
Questo è semplicemente un adattamento per il funzionamento su ESP32S3.


This repository is a porting of the original 'OpenFIRE-Boards' project by TeamOpenFIRE, adapted to work on the ESP32S3 microcontroller.
Apart from some adaptations and minor adjustments, the code remains largely faithful to the original by TeamOpenFIRE.
The code in this repository also works on the RP2040 microcontroller.
Whenever changes are made to the original 'OpenFIRE-Boards' project by TeamOpenFIRE, I will update the code in this repository accordingly.
I sincerely thank TeamOpenFIRE for creating the 'OpenFIRE-Boards' project; all credit and gratitude go to them for their work.
This is simply an adaptation to make it work on ESP32S3.

![Waveshare-esp32-s3-pico](https://github.com/user-attachments/assets/2ce848f3-f308-43cc-b753-3b1dac1647e4)

![YD-esp32-s3-wroom1-DevKitC-1-N16R8](https://github.com/user-attachments/assets/080baf9b-f050-4b3e-ba59-4fb4aa784909)


## ... segue la pagina originale del progetto
## ... follows the original project page

# OpenFIRE-Boards
Common repository of boards that are shared between OpenFIRE Firmware &amp; Desktop App

# OpenFIRE Shared Resources
This repository contains resources that can be shared between implementations of the microcontroller Firmware and Applications intended to interface with and configure them on a PC device.

## `OpenFIREshared.h`
The top half of this file defines the following that are common in both Firmware and App implementations:
 - Definitions of board names that the microcontroller will report on initial docking, as string literals.
 - Enums of pin function types, toggles, settings, I2C devices and their settings, and commands used in serial communication between firmware and app.
 - Presets for defined boards that are loaded on bootup, and referenced by apps that show default board layouts.

Below the preprocessor check for `OF_APP` are 'pretty' strings for supported boards and pin functions, and board layouts that are used only by Desktop Apps to graphically represent GPIO pins for defined boards - showing where they should be rendered relative to a center-bound board vector, and alternative layouts for boards that the app should present as options to the user, if any.

### `boardPresetsMap`
Supported boards should have a name that corresponds to the `OPENFIRE_BOARD` definition as defined at the top of the file, followed by a map of what function each GPIO should have as a default (this is loaded when `OF_Prefs::toggles[OF_Const::customPins]` is set as *true* in the board's current prefs). Each GPIO the microcontroller has should be represented here, with unmapped pins given `btnUnmapped` and pins that are either reserved or not exposed to the user to be given `unavailable`. RP2040 and RP235X-A boards should have thirty pins maximum - note that even if the `rpipico` only exposes around 26 pins, it still takes the hidden GPIO into consideration.

### `boardBoxPositions`
Like `boardPresetsMap`, for each supported `OPENFIRE_BOARD`, this presents a map of roughly *where* each pin should be located in a Desktop App's graphical board view represented as a sum of two values - the left being the relative position as an positive integer starting from 1, and the right being an enum value of which side of the board the pin elements should be positioned by. Adding `posLeft`, `posRight`, and `posMiddle` will place this GPIO in the respective side of the board view, and adding `posNothing` (literally 0) will inform the app not to show this pin at all, which should be used for `unavailable` pins in `boardPresetsMap`. The amount of values should match the amount of GPIO as defined in the presets map.

### `boardsAltPresets`
This is for optional alternative board presets, which are to be presented in a Board Layout view as a drop-down list of alt layout names. Each supported `OPENFIRE_BOARD` can be listed multiple times, one for each alt layout - the string after the board name indicating what label it should show in the interface, followed by a curly braced map of GPIO board functions indentically to `boardPresetsMap`; the same conventions and stipulations apply. This is primarily intended for matching the layout of adapter boards that use different suggested button mappings/wiring, such as `adafruitItsy`'s SAMCO 1.1 layout for those boards which has a different mapping from the default SAMCO 2.0 layout; also note that the current reference Desktop App supports exporting and importing custom layouts.

## `boardPics/` - Board Vectors and Pin Highlights
This is the repository of board vectors that Desktop Apps should use for Board Layout views to graphically represent the current board that's docked to the application. Board vectors should be exported as *Plain SVG* (or equivalent), and added to the `vectors.qrc` resource file, where the alias for each file should match the names as defined in `OpenFIREshared.h`'s `OPENFIRE_BOARD` string for the board.

The current reference Desktop App is capable of showing *highlighted pins* when the user hovers over a GPIO pin item in the interface. To do this, the SVGs will need to be modified with the following (using Inkscape as the primary interface example):
 1. If it's not already, group all of the image's existing board objects into its own group (name doesn't matter). Also make sure that the pin holes are actually transparent beneath and are not filled with a background color.
 2. Create a new group that's *below* the board group - again, name doesn't matter, but for ease of use you should call it something like `OF`
 3. Inside this newly made highlights group, create the highlight elements with no stroke, and basic single flat color fill (existing boards uses RGBA `ebe713`, or *R253/G231/B19*).
 4. Select the highlight element and go to the *Object Properties* tab (or equivalent that shows the *"ID"* line): each highlight element needs to have an ID named `OF_pinX` - where X == GPIO pin number, without a leading 0.
 5. While the element is highlighted, go to the *Fill and Stroke* tab (or equivalent that shows *"Opacity (%)"*) and set the Opacity to **0.0**.
 6. Once the placement, naming, and opacity of everything is satisfactory, save the file as a ***Plain SVG*** file inside of the `boardPics` directory. Make sure `vectors.qrc` has this board listed as an alias to the `OPENFIRE_BOARD` string you set for this microcontroller in `OpenFIREshared.h`!

> [!NOTE]
> This procedure should be done **only** for every *accessible* GPIO pin for the board (i.e. the pins that would be `unavailable` in the `boardPresetsMap` should not be added, as these will be hidden by the application).

Once this is finished, rebuild the application and test out the board picture; the easiest way being to use the *Help->View Compatible Boards* window, and hover the mouse cursor over the labels corresponding to the GPIO.

> [!NOTE]
> - If the board picture doesn't display at all, it's likely that the vector either isn't named appropriately or wasn't exported properly - double check that you followed Step 6 above correctly.
> - If the board picture displays, but highlights do not (or show up to the wrong pins), it's likely that you might need to manually edit some lines in the exported SVG in a text editor, such as Notepad. The technical requirements for vectors to work - and the things to check - are:
>   - That the `id="OF_pinX"` lines are *above* the `style="` line.
>   - That the `style="` line has `opacity:0` inside of it (preferably either `0` or `0.0`; whichever one it is doesn't matter, so long as it matches).
> Refer to the following example below (snippit from [`pico.svg`](https://raw.githubusercontent.com/alessandro-satanassi/OpenFIRE-Boards-ESP32/main/boardPics/pico.svg)) for the general ideal formatting of each highlight element:
> ```html
>   <g
>      id="OF">
>     <path
>        id="OF_pin1"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.7,47.4c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2,2.7-6.3,6.1-6.4c3.4,0,6.3,2.6,6.5,6" />
>     <path
>        id="OF_pin2"
>        style="opacity:0;fill:#ebe713;fill-opacity:1"
>        class="st10"
>        d="M19.8,88.1c0,3.4-2.9,6.2-6.3,6.2s-6.2-2.8-6.3-6.2c0-3.4,2.7-6.3,6.1-6.4,3.4,0,6.3,2.6,6.5,6" />
> ...
> ```


