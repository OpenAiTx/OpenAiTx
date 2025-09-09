
# Una configuración de sistema altamente impresionante
[![construido con nix](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### Estructura de archivos
1. `config` - Configuración principal del sistema. `base-desktop.nix` contiene muchos valores predeterminados útiles.
2. `home-manager` - Contiene la mayor parte de la configuración del escritorio.
3. `modules` - Un par de opciones personalizadas.
4. `overlays` - Contiene paquetes personalizados y adaptados. Los paquetes adaptados tienen el prefijo de nombre `g-`.
5. `hosts` - Contiene configuración específica para cada host.
6. `flake.nix` - Configuración de flake impresionante ;)


# Hoja de referencia de ZFS

## Crear pool
```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```
- `autotrim` - Debe omitirse para almacenamiento que no sea SSD.  
- `ashift` - Requiere investigación. esta configuración es específica del dispositivo, y muchas unidades pueden engañar.  

## Configurar particiones


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

## Configuración de NixOS
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


## ¡Desmonte y exporte todo lo relacionado con ZFS antes de salir del instalador en vivo!!!
```bash
zpool export zroot
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---