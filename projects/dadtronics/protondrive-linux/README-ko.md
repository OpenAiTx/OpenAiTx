# rclone과 systemd를 사용하여 Linux에서 Proton Drive 마운트하기

이 가이드는 [`rclone`](https://rclone.org/)과 `systemd`를 사용하여 Linux 시스템에서 [Proton Drive](https://proton.me/drive)를 자동으로 마운트하는 과정을 설명합니다.

**Arch Linux**에서 테스트되었으며, 대부분의 Linux 배포판에서 약간의 조정으로 작동할 것입니다.

---

## 🔧 기능

- `systemd --user`를 통해 로그인 시 Proton Drive 마운트
- 호환성을 위해 `--vfs-cache-mode writes` 옵션을 사용하는 `rclone` 활용
- 로깅이 가능한 백그라운드 서비스 활성화
- `--allow-other` 마운트를 위한 FUSE 지원 추가

---

## 🚀 빠른 시작

### 1. ✅ 의존성 설치

#### `fuse3` 설치 (마운트에 필요):
```bash
sudo pacman -S fuse3
````
#### `rclone` 설치 (버전 1.64.0 이상이어야 함)

🔹 **옵션 1: 미리 컴파일된 바이너리 사용 (권장)**


```bash
curl -O https://downloads.rclone.org/rclone-current-linux-amd64.zip
unzip rclone-current-linux-amd64.zip
cd rclone-*-linux-amd64
sudo cp rclone /usr/local/bin/
sudo chmod +x /usr/local/bin/rclone
```
확인:


```bash
rclone version
# Must be v1.64.0 or higher
```

---

### 2. 🔐 Configure Proton Drive Remote

Run:

```bash
rclone config
```

프롬프트에 따라 진행하세요:

* `n` → 새 원격 저장소
* 이름: `proton`
* 유형: `protondrive`
* 요청 시 브라우저를 통해 로그인
* 수락하고 저장

---

### 3. 📜 설정 스크립트 실행

제공된 스크립트를 실행하세요:

```bash
chmod +x setup-proton-mount.sh
./setup-proton-mount.sh
```
스크립트는 다음을 수행합니다:

* 마운트 지점 생성: `~/ProtonDrive`
* systemd 사용자 서비스 작성
* `/etc/fuse.conf`에 `user_allow_other` 추가 (없을 경우)
* 사용자에게 `fuse` 그룹 추가 (필요한 경우)
* 마운트 서비스 활성화 및 시작

---

### 4. 🔁 재부팅 또는 로그아웃/로그인

스크립트가 사용자를 `fuse` 그룹에 추가한 경우, 변경 사항을 적용하려면 **로그아웃 후 다시 로그인**해야 합니다.

---

## 🔍 마운트 확인

Proton Drive가 마운트되었는지 확인하세요:


```bash
ls ~/ProtonDrive
```

systemd 서비스 확인:

```bash
systemctl --user status rclone-proton.mount.service
```

---

## 🔁 Remount

If unmounted the Proton Drive can be remounted by:

```bash
systemctl --user restart rclone-proton.mount.service
```

Proton Drive는 로그인할 때마다 자동으로 마운트된다는 점에 유의하세요.

## 🧼 제거

자동 마운트 설정을 제거하려면:

```bash
systemctl --user disable --now rclone-proton.mount.service
rm ~/.config/systemd/user/rclone-proton.mount.service
```

(Optional) 더 이상 마운트 지점이 필요하지 않은 경우 `~/ProtonDrive`를 제거하세요.

---

## 📁 파일

* `setup-proton-mount.sh` — 전체 설정 스크립트
* `~/.config/systemd/user/rclone-proton.mount.service` — systemd 유닛
* `~/ProtonDrive` — 마운트 위치
* `~/.cache/rclone/rclone-proton.log` — 로그 출력 (선택 사항)

---

## 📎 요구 사항

* Proton Drive 지원이 포함된 `rclone >= 1.64.0`
* `fuse3`
* Proton Drive 계정

---

## 🛟 문제 해결

마운트가 작동하지 않는 경우:

```bash
journalctl --user -u rclone-proton.mount.service
```

서비스를 수동으로 다시 시작하려면:

```bash
systemctl --user restart rclone-proton.mount.service
```

---

## 📚 참고 문헌

* [rclone Proton Drive 문서](https://rclone.org/protondrive/)
* [systemd 사용자 서비스](https://wiki.archlinux.org/title/Systemd/User)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-06

---