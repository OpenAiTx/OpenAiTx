# <p align=center>synology-drive</p>

Unofficial RPM package of Synology Drive Client <https://www.synology.com>.

Since the package provided by FlatHub is not 100% functional and the method of converting deb to rpm by Alien requires a lot of manipulation. I decided to create myself a clean and 100% functional RPM package for Synology Drive Client.

I have include the file explorer Nautilus as dependency in order to have access to the share menu and to have the file sync status indicator (like on Windows or Ubuntu).\
I also have include a GNOME shell extension as dependency in order to see the tray icon (works natively with KDE).\
I have build a second package for user's which didn't use GNOME. It does not contain the two dependencies mentioned above (they can be installed later if you want).



## Installation
If you have previously installed Synology Drive Client with Alien or Flatpak (i.e. from another source than my repo), please ensure that they are uninstalled.

If you like the project, do not hesitate to star the repository to support me, thank you!

### Method 1: install from COPR repo (recommended to get updates)
Page link : [COPR package](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/).

1. `sudo dnf copr enable emixampp/synology-drive`
2. For GNOME: `sudo dnf --refresh install synology-drive`
3. For other desktop environments: `sudo dnf --refresh install synology-drive-noextra`

### Method 2: build the package locally (no update)
1. Install build tools : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. Optional, if you want to change the version:
   1. Consult the [release notes](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) and choose the desired version (>= 3.2.1-13271)
   2. Edit the two first lines of `synology-drive.spec` or `synology-drive-noextra.spec`, depending on whether you are running GNOME or another desktop environement. 
5. For GNOME:
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. For other desktop environments: 
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. Clean build root : `rm -r ~/rpmbuild`

### Experimental: build the package locally for Aarch64/ARM64 processors (e.g. Apple Silicon, Qualcomm Snapdragon)
1. Install build tools : `sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. Optional, if you want to change the version:
   1. Consult the [release notes](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) and choose the desired version (>= 3.2.1-13271)
   2. Edit the two first lines of `synology-drive.spec` or `synology-drive-noextra.spec`, depending on whether you are running GNOME or another desktop environement. 
5. For GNOME:
   1. `spectool -g -R synology-drive-aarch64.spec`
   2. `rpmbuild -ba synology-drive-aarch64.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`
6. For other desktop environments: 
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`
7. Clean build root : `rm -r ~/rpmbuild`
**Attention**_**: This solution uses the FEX emulator. If you are using the QEMU emulator it will probalby break because binfmt_misc allows only one emulator to register for x86_64 binaries.

## Legal information
Consult the [LICENSE](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE).

This project has been authorized by Synology Inc.
