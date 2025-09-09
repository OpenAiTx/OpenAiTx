
# 非常に素晴らしいシステム構成
[![built with nix](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### ファイル構成
1. `config` - メインのシステム構成。`base-desktop.nix`には多くの便利なデフォルトが含まれています。
2. `home-manager` - デスクトップ構成の大部分を保持します。
3. `modules` - いくつかのカスタムオプション。
4. `overlays` - カスタムおよび調整済みパッケージを含みます。調整済みパッケージは名前に`g-`プレフィックスが付きます。
5. `hosts` - ホスト固有の構成を含みます。
6. `flake.nix` - 強力なflake設定 ;)


# ZFS チートシート

## プールの作成
```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```

- `autotrim` - 非SSDストレージでは省略する必要があります。
- `ashift` - 調査が必要です。この設定はデバイス固有で、多くのドライブは誤情報を示します。


## パーティションの設定
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

## NixOS 設定
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

## ライブインストーラーを離れる前に、すべてのZFS関連のマウント解除とエクスポートを行ってください!!!

```bash
zpool export zroot
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---