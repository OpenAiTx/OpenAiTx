# netevent

Netevent is a tool which can be used to share linux event devices with other
machines (either via `/dev/uinput` or by implementing a client for the same
protocol with other means).

Originally it simply dumped device capabilities to stdout and afterwards
behaved like running `cat /dev/input/eventX` in one mode, and in the other
passed the parsed capabilities to `/dev/uinput` and then passing events
through.

Since managing this for multiple devices can become tedious when having more
than one destination (and since the original grab/toggle/hotkey mechanisms were
weird and literally targeted my personal use case), netevent2 now extends the
protocol to contain packets which can contain more than one device and can add
and remove devices on the fly.

The original `cat` like behavior (although currently without hotkey support)
is also available for debugging purposes (and the `create` mode supports both
protocol versions).

The main tool is now the `netevent daemon` which has a command socket (an
optionally abstract unix socket) via which one can add devices, outputs and
hotkeys on the fly. See the examples below.

## Compilation

* optionally: `./configure --prefix=/usr`
* `make`

You can still just run `make` as before. However, to support the usual
installation workflows, and to distinguish between systems with newer kernels
where `/dev/uinput` has been extended with a `UI_DEV_SETUP` `ioctl`, a
`./configure` script has been added to check for this and create a `config.h`
as well as a `config.mak` for PREFIX/BINDIR/... (all of which can be passed as
variables directly to `make` instead as well, along with the usual `DESTDIR`).

## Installation

* `make install` or `make DESTDIR=/my/staging/dir install`

Or: as previously, just put the `netevent` binary wherever.

## Usage

See the DAEMON COMMANDS section in netevent(1) for details on the commands used
in the setup scripts below.

### Examples

See the `examples/` directory. Read the setup-example below to see how to adapt
the hotkey lines to work with your devices.

#### Simple example setup: sharing keyboard & mouse with a machine via ssh:

Host side:

* Preparation: Make sure we can access event devices as a user

    Usually this means running something like `gpasswd -a myuser input`

* Step 1: Decide which /dev/input/eventXY devices to pass through.

    For consistent file names use something like:
    `/dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd`
    `/dev/input/by-id/usb-BestMouseEver-event-mouse`

* Step 2: Decide on a hotkey and find its event code:

    In the above example we want to use a key on the keyboard (unless you
    have an insane amount of mouse buttons...).
    `netevent` can be used to dump events in a readable way, run the `show`
    subcommand on the device and press the keys you want to use for hotkeys.
    If this is the same keyboard you're typing in the command with , prepend a
    sleep to avoid confusion when netevent picks up the release of the enter
    key.
    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```

* Step 3: Prepare a setup script for the daemon:

    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```

* Step 4: Run the netevent daemon:

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

You can now send additional commands to the daemon by connecting to the socket.
For example via `socat READLINE UNIX-CONNECT:netevent-command.sock`.
