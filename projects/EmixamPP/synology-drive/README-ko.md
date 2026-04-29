# <p align=center>synology-drive</p>

비공식 Synology Drive 클라이언트 RPM 패키지 <https://www.synology.com>.

FlatHub에서 제공하는 패키지가 100% 기능하지 않고 Alien으로 deb를 rpm으로 변환하는 방법이 많은 조작을 요구하기 때문에, 저는 직접 깨끗하고 100% 기능하는 Synology Drive 클라이언트용 RPM 패키지를 만들기로 결정했습니다.

공유 메뉴에 접근하고 파일 동기화 상태 표시기를 사용하기 위해 파일 탐색기 Nautilus를 의존성으로 포함시켰습니다 (Windows나 Ubuntu에서처럼).\
트레이 아이콘을 보기 위해 GNOME 셸 확장도 의존성으로 포함시켰습니다 (KDE에서는 기본적으로 작동).\
GNOME을 사용하지 않는 사용자용으로 두 가지 의존성이 없는 두 번째 패키지를 빌드했습니다 (나중에 원하면 설치할 수 있습니다).



## 설치
이전에 Alien 또는 Flatpak (즉, 제 저장소가 아닌 다른 출처)으로 Synology Drive 클라이언트를 설치한 경우, 반드시 제거했는지 확인하세요.

프로젝트가 마음에 들면, 저를 지원하기 위해 저장소에 별점을 주는 것을 망설이지 마세요, 감사합니다!

### 방법 1: COPR 저장소에서 설치 (업데이트를 받기에 권장)
페이지 링크 : [COPR 패키지](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/).

1. `sudo dnf copr enable emixampp/synology-drive`
2. GNOME용: `sudo dnf --refresh install synology-drive`
3. 다른 데스크탑 환경용: `sudo dnf --refresh install synology-drive-noextra`

### 방법 2: 로컬에서 패키지 빌드 (업데이트 없음)
1. 빌드 도구 설치 : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. 선택 사항, 버전을 변경하고 싶다면:
   1. [릴리즈 노트](https://www.synology.com/en-global/releaseNote/SynologyDriveClient)를 확인하고 원하는 버전(>= 3.2.1-13271)을 선택하세요.
   2. GNOME을 사용하는지 다른 데스크탑 환경인지에 따라 `synology-drive.spec` 또는 `synology-drive-noextra.spec`의 처음 두 줄을 편집하세요.
5. GNOME용:
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. 다른 데스크탑 환경용:
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. 빌드 루트 정리 : `rm -r ~/rpmbuild`
### 실험적: Aarch64/ARM64 프로세서(예: Apple Silicon, Qualcomm Snapdragon)용 패키지를 로컬에서 빌드하기
1. 빌드 도구 설치 : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. 선택 사항, 버전을 변경하려는 경우:
   1. [릴리스 노트](https://www.synology.com/en-global/releaseNote/SynologyDriveClient)를 참고하고 원하는 버전(>= 3.2.1-13271)을 선택하세요.
   2. GNOME 또는 다른 데스크탑 환경을 사용하는지에 따라 `synology-drive.spec` 또는 `synology-drive-noextra.spec`의 처음 두 줄을 편집하세요.
5. GNOME용:
   1. `spectool -g -R synology-drive-aarch64.spec`
   2. `rpmbuild -ba synology-drive-aarch64.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`
6. 기타 데스크탑 환경용:
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`
7. 빌드 루트 정리 : `rm -r ~/rpmbuild`
**주의**_**: 이 솔루션은 FEX 에뮬레이터를 사용합니다. QEMU 에뮬레이터를 사용하는 경우 binfmt_misc가 x86_64 바이너리에 대해 하나의 에뮬레이터만 등록할 수 있기 때문에 아마 작동하지 않을 수 있습니다.

## 법적 정보
[LICENSE](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE)를 참고하세요.

이 프로젝트는 Synology Inc.의 승인을 받았습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---