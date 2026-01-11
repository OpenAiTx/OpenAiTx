# STAnd aLONE TRAY [![Build][badge-build]][yaml-build] [![Lint][badge-lint]][yaml-lint]

[badge-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml/badge.svg
[yaml-build]: https://github.com/d3adb5/stalonetray/actions/workflows/build.yml
[badge-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml/badge.svg
[yaml-lint]: https://github.com/d3adb5/stalonetray/actions/workflows/lint.yml

Stalonetray is a STAnd-aLONE system TRAY (notification area) for Unix desktops
using the X11 windowing system. It has minimal default build and run-time
dependencies: the Xlib and libXinerama, though you could do away with the
latter by disabling a feature for even more minimalism. Stalonetray runs under
virtually any window manager.

To start using stalonetray, just copy `stalonetrayrc.sample` to
`~/.stalonetrayrc` or to `$XDG_CONFIG_HOME/stalonetrayrc`. It is well-commented
and should suffice for a quick start.

Note that some features are disabled by default and may not work out of the
box, depending on how stalonetray was built by the package maintainer. See the
"Building from source" section below if you want to compile it yourself with
the features you need.

## Maintenance status

This project was originally developed by [Roman Dubtsov (kolbusa)][gh-kolbusa]
and recently changed hands. Roman is still involved with, but no longer
actively maintains the project.

**To him goes all the credit for creating and maintaining this project for many
years. Thank you, Roman!**

[gh-kolbusa]: https://github.com/kolbusa

## Installation

Package managers are the most convenient way to install stalonetray. It is
packaged for several Linux distributions and BSD variants. On Debian and
Ubuntu, run:

```sh
sudo apt install stalonetray
```

On Fedora run:

```sh
sudo dnf install stalonetray
```

## Building from source

Stalonetray uses [Meson](https://mesonbuild.com/). Refer to the `meson.options`
file for available build options and their default values.

To build stalonetray using Meson, ensure necessary dependencies are installed
--- by default only Xlib and libXinerama development packages are required ---
and run the standard Meson build commands:

```sh
meson setup builddir
meson compile -C builddir stalonetray
```

This should build the `stalonetray` binary in the `builddir` directory.

To build stalonetray's documentation, you'll need `xsltproc` and DocBook
stylesheets installed first. Then build the `manpage` target:

```sh
meson compile -C builddir manpage
```

This creates the `stalonetray.1` file in the `builddir` directory.

Installation from source can be done with:

```sh
meson install -C builddir
```
