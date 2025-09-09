
# A highly awesome system configuration
[![built with nix](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### File structure
1. `config` - Main system configuration. `base-desktop.nix` contains lots of useful defaults.
2. `home-manager` - Holds most of the desktop configuration.
3. `modules` - A couple of custom options.
4. `overlays` - Contains riced and custom packages. Riced packages have the name prefix `g-`.
5. `hosts` - Contains host specific configuration.
6. `flake.nix` - Kickass flake config ;)


# ZFS Cheatsheet

## Create pool
```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```

- `autotrim` - Should be omitted for non-SSD storage.
- `ashift` - Requires research. this setting is device-specific, and many drives will lie.


## Setup partitions
```bash
mkfs.vfat -n BOOT -F32 /dev/sdx1
parted /dev/sdx set 1 boot on

mkdir /mnt/{home,boot,nix}

zfs create -o encryption=on -o keyformat=passphrase zroot/locker
zfs create zroot/locker/home
zfs create zroot/locker/nix
zfs create zroot/locker/os

mount -t zfs zroot/locker/os /mnt
mount -t zfs zroot/locker/home /mnt/home
mount -t zfs zroot/locker/nix /mnt/nix
mount /dev/sdx1 /mnt/boot
```

## NixOS config
```nix
{
  # needed for zfs. 4 random bytes (in hex)
  networking.hostId = "12345678";

  # or nicer implementation
  networking.hostId = builtins.substring 0 8 (builtins.hashString "md5" config.networking.hostName);

  # nixos documentation recommends setting these to false
  boot = {
      zfs.forceImportAll = false;
      zfs.forceImportRoot = false;
  };
}
```


## unmount and export all zfs stuff before leaving the live installer!!!
```bash
zpool export zroot
```
