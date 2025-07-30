# Ventoy CPIO

An alternate ramdisk for [Ventoy](https://github.com/ventoy/Ventoy).

Docs are available [here](https://github.com/fnr1r/ventoy-meta/tree/main/docs)
and releases [here](https://github.com/fnr1r/ventoy-cpio/releases).

NOTE: This is just a small part of my attempt to add a sane(-ish) build system
to Ventoy. An index for all my Ventoy-related projects can be found
[here](https://github.com/fnr1r/ventoy-meta).

## Goal

Make a replacement ramdisk for Ventoy

- [?] with a sane(-er) build system
- [x] a bootable one
- [ ] a functionally identical one  
  (i.e. can do the same things as the upstream)
- [x] a smaller one

### Non-goals

- ❌ a binary-identical ramdisk to the official one
  - compiling identical binaries with the instructions given would be near
  impossible and is ultimately pointless
  - however, ramdisks built with this project should be reproducible

### Possible future changes

- Removing suffixes from binaries (they're just annoying and inconsistent)  
  (no upstream changes required)
- Splitting the ramdisks into x86 32-bit and 64-bit  
  (would require changes to grub)
- Cleaning up shell scripts in the ramdisk  
  (no upstream changes required)

## Progress

It boots, but some functionality might not work.

### ventoy.cpio

100%, since it's literally just xz-ing a bunch of files.

Size ratio:

- du - 1 (64 / 64)
- ls -l - 1 (62976 / 62976)

### ventoy_ARCH.cpio

~75%

All the tools are here (mostly), compiled in one way or another. Now all that's
left is optimization.

Size ratio (x86):

- du - 0.8540245566166439 (2504 / 2932)
- ls -l - 0.8624375107740045 (2561536 / 2970112)

Size ratio (arm64):

- du - 0.8159806295399516 (1348 / 1652)
- ls -l - 0.8159490600363857 (1377792 / 1688576)

Size ratio (mips64):

- du - 0.9816849816849817 (1072 / 1092)
- ls -l - 0.981642955484167 (1095168 / 1115648)

### vtloopex.cpio

TODO: add this

## Usage

### Building

```sh
docker compose build
```

```sh
docker compose up
```

Hint:

If you don't want to redownload archives every time you rebuild the container,
go to `docker/base/{dietlibc,musl,toolchains}`, look through the setup script
and manually `wget` the file.

You can also run this to enter the container:

```sh
docker run -it --rm \
  -v ".:/build" \
  ventoy-cpio-builder:latest \
  bash
```

### Setup

Once you have `ventoy*.cpio` files:

1. Mount the second partition on your Ventoy usb
1. !!! BACK UP THE ORIGINAL `ventoy*.cpio` FILES !!!
1. Copy the cpio you want to try out. (hint: if you don't know which one it is,
  then it's probably `ventoy_x86.cpio`)

## Mini TODO

- Build with an older version of Linux headers for compatibility

## Notes

- [In GCC terms](https://gcc.gnu.org/onlinedocs/gccint/Configure-Terms.html):
  - The build is assumed to be x86_64 *nix
  - The host (for ventoy installation tools) is assumed to be x86_64
  - The targets are x86_64, i386, aarch64 and mips64el
