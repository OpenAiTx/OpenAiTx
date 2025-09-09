
# Une configuration système vraiment géniale
[![built with nix](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### Structure des fichiers
1. `config` - Configuration principale du système. `base-desktop.nix` contient beaucoup de paramètres par défaut utiles.
2. `home-manager` - Contient la majeure partie de la configuration du bureau.
3. `modules` - Quelques options personnalisées.
4. `overlays` - Contient des paquets personnalisés et "ricés". Les paquets "ricés" ont le préfixe `g-`.
5. `hosts` - Contient la configuration spécifique à l’hôte.
6. `flake.nix` - Configuration flake géniale ;)


# Fiche de référence ZFS

## Créer un pool
```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```

- `autotrim` - Doit être omis pour les stockages non-SSD.
- `ashift` - Nécessite des recherches. ce paramètre est spécifique à l'appareil, et de nombreux disques mentent.


## Configuration des partitions
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

## Configuration NixOS
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
## démonter et exporter tout le contenu zfs avant de quitter l'installateur live !!!


```bash
zpool export zroot
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---