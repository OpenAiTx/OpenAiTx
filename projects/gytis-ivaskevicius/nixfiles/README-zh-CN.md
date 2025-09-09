
# 一个非常棒的系统配置
[![用 nix 构建](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### 文件结构
1. `config` - 主要系统配置。`base-desktop.nix` 包含许多有用的默认设置。
2. `home-manager` - 包含大部分桌面配置。
3. `modules` - 一些自定义选项。
4. `overlays` - 包含美化和自定义软件包。美化软件包名称前缀为 `g-`。
5. `hosts` - 包含主机特定配置。
6. `flake.nix` - 超棒的 flake 配置；）


# ZFS 备忘单

## 创建池
```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```
- `autotrim` - 对非SSD存储应省略此项。  
- `ashift` - 需要研究。此设置依赖设备，许多驱动器会报告错误。  

## 设置分区


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

## NixOS 配置
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


## 离开实时安装程序前，请卸载并导出所有 ZFS 相关内容！！！
```bash
zpool export zroot
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---