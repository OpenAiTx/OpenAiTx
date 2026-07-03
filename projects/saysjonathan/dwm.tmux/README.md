dwm.tmux
===
[dwm](http://dwm.suckless.org/)-inspired tiling pane and window manager for Tmux.

![](https://raw.githubusercontent.com/saysjonathan/dwm.tmux/master/screenshot.png)

## Dependencies
dwm.tmux requires tmux >= 3.2.

## Installation
### Via TPM (recommended)
Add to `~/.tmux.conf`:

```sh
set -g @plugin 'saysjonathan/dwm.tmux'
```

Reload and run `prefix-I` to fetch.

### Manual install (legacy)
To install, use the provided `Makefile`:

```sh
git clone https://github.com/saysjonathan/dwm.tmux.git
cd dwm.tmux
make
```

By default `dwm.tmux` uses `/usr/local` as its prefix. To change the prefix:

```sh
make PREFIX=$HOME
```

Ensure that `$PREFIX/bin` is in your `PATH`.

To use, source the `dwm.tmux` tmux config:

```sh
echo 'source-file /usr/local/lib/dwm.tmux' >> $HOME/.tmux.conf
```

## Usage
`dwm.tmux` defines the following command aliases, each with a default keybinding:

- `newpane` `Meta-n` Create a new pane and place it in the Main pane
- `newpanecurdir` `Meta-w` Create a new pane starting in the same directory and place it in the Main pane
- `killpane` `Meta-c` Close the current pane. If the pane is in the Main pane, close the pane and promote the first pane in the stack to the Main pane
- `movepane[0-9]` `Meta-Shift-[0-9]` Move the current pane to the specified window
- `nextpane` `Meta-j` Select the next pane (clockwise); swaps fullscreen pane in monocle mode
- `prevpane` `Meta-k` Select the previous pane (counterclockwise); swaps fullscreen pane in monocle mode
- `stackup` `Meta-J` Move focused pane up the stack
- `stackdown` `Meta-K` Move focused pane down the stack
- `rotateccw` `Meta-<` Rotate panes counterclockwise
- `rotatecw` `Meta->` Rotate panes clockwise
- `tile` `Meta-t` Return to tiled layout, exiting monocle if active
- `monocle` `Meta-Space` Toggle monocle mode (fullscreen current pane)
- `zoom` `Meta-Enter` Place selected pane in the Main pane
- `decmfact` `Meta-h` Decrease the main pane space factor
- `incmfact` `Meta-l` Increase the main pane space factor
- `window[0-9]` `Meta-[0-9]` Select the target window by ID
- `newwindow` `Meta-N` Create a new window starting in the same directory as the current pane
- `killwindow` `Meta-X` Delete the current active window
- `popup` `Meta-p` Display a floating pane popup in the current pane's directory
- `incpfact` `Meta-.` Increase the size of the focused pane in the stack, relative to the other panes
- `decpfact` `Meta-,` Decrease the size of the focused pane in the stack, relative to the other panes
- `resetpfact` `Meta-=` Reset the pfact of the focused pane

Additional keybindings for window cycling are also included:
- `Meta-[` Previous window
- `Meta-]` Next window

Also defined are global options to tweak behavior:

- `mfact` Main pane space factor, the size of the main pane as a percentage of total window size
- `killlast` If value is greater than `0`, kill pane even if it is the last pane in a window
- `monocle` Tracks active layout mode; 0 for tile, 1 for monocle. Set automatically but can be read to inspect current state.
- `pfact` Per-pane stack size factor, scale 1-9, default 5. Higher values give the pane more relative height in the stack

### Customizations
Keybindings and default values can be set in a configuration file. When using TPM, these must be set after the `run '~/.tmux/plugins/tpm/tpm'` line in `~/.tmux.conf`.

Examples:

```
setenv -g killlast 1 # kill pane even if it's the last
set-option -wg @mfact 60
set-option -wg @pfact 4
bind -n M-q killpane
bind -n M-w newpanecurdir
```

## Details

Similar to dwm, windows are always organized as follows:

```
 ====================================
|                 |        S1        |
|                 |==================
|      M(0)       |        S2        |
|                 |==================
|                 |        S3        |
 ====================================
```

A large Main pane is placed on the left side of the screen while a stack of smaller panes is placed on the right. The Main pane is always pane 0, while the stack of panes is numbered sequentially in ascending order.
