# 매우 멋진 시스템 구성
[![built with nix](https://builtwithnix.org/badge.svg)](https://builtwithnix.org)

### 파일 구조
1. `config` - 메인 시스템 구성. `base-desktop.nix`에는 많은 유용한 기본값이 포함되어 있습니다.
2. `home-manager` - 대부분의 데스크탑 구성을 보관합니다.
3. `modules` - 몇 가지 사용자 정의 옵션.
4. `overlays` - 꾸며진(riced) 및 사용자 정의 패키지를 포함합니다. 꾸며진 패키지는 이름 접두사 `g-`를 가집니다.
5. `hosts` - 호스트별 구성을 포함합니다.
6. `flake.nix` - 멋진 flake 구성 ;)

# ZFS 치트시트

## 풀 생성


```bash
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot sdx2

# with two mirrored drives
zpool create -o ashift=12 -o autotrim=on -O compression=zstd -O acltype=posixacl -O xattr=sa -O atime=off -O mountpoint=legacy zroot mirror sdx2 sdy2
```
- `autotrim` - SSD가 아닌 저장장치에는 생략해야 합니다.
- `ashift` - 연구가 필요합니다. 이 설정은 장치별로 다르며, 많은 드라이브가 거짓 정보를 제공합니다.


## 파티션 설정

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

## NixOS 구성
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

## 라이브 설치 프로그램을 종료하기 전에 모든 ZFS 항목을 언마운트하고 내보내기!!!

```bash
zpool export zroot
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---