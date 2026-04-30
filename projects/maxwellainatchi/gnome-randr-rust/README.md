# gnome-randr-rust

A reimplementation of `xrandr` for Gnome on Wayland, especially for systems that don't support `wlr-output-management-unstable-v1`  (e.g. Manjaro). Written ground-up in Rust for performance and fun. This is also my first project in rust, so any suggestions are welcome!

> [!NOTE]  
> I currently am not able to maintain this, as I no longer have access to a working Linux machine. If someone is interested in maintaining, please let me know!
>
> On Gnome 48+, try the [gdctl](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/doc/man/gdctl.rst) CLI that came with it, it's most likely to stay up to date.

(For non-Gnome compositors, see display configuration links at https://arewewaylandyet.com/)

## Installation

Installation requires `pkg-config` and `cargo`, part of the Rust toolchain. [Cargo/Rust installation instructions](https://doc.rust-lang.org/cargo/getting-started/installation.html).

To install this tool, run `cargo install gnome-randr`. A library is also exposed for use in other Rust programs.

## Method

`gnome-randr-rust` uses the `dbus` object `org.gnome.Mutter.DisplayConfig`. See https://wiki.gnome.org/Initiatives/Wayland/Gaps/DisplayConfig for the original proposal, although the specification listed there is somewhat out of date (checked via `dbus introspect` on Gnome shell 40.5). Gnome maintain the evolving XML file [here](https://gitlab.gnome.org/GNOME/mutter/-/blob/main/data/dbus-interfaces/org.gnome.Mutter.DisplayConfig.xml).

The `GetCurrentState` method is used to list information about the displays, while `ApplyMonitorsConfig` is used to modify the current configuration.

## Inspiration

This project was heavily inspired by `xrandr` (obviously) and also [`gnome-randr`](https://gitlab.com/Oschowa/gnome-randr/). Sadly, `gnome-randr.py` appears to be broken as of my gnome version (40.5) when trying to modify display configurations. 

`gnome-randr.py` is also slower than my rust reimplementation: querying the python script takes about 30ms on my 3-monitor system, while the rust implementation takes about 3ms (`xrandr` takes about 1.5ms, but is also displaying different information due to limitations in `xrandr`'s bridge.)
