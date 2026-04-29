# <p align=center>synology-drive</p>

Synology Drive 客户端的非官方 RPM 包 <https://www.synology.com>。

由于 FlatHub 提供的包功能不完全，且通过 Alien 将 deb 转换为 rpm 需要大量操作。于是我决定自己制作一个干净且功能 100% 完整的 Synology Drive 客户端 RPM 包。

我包含了文件管理器 Nautilus 作为依赖，以便访问共享菜单并显示文件同步状态指示器（类似 Windows 或 Ubuntu）。\
我还包含了一个 GNOME shell 扩展作为依赖，以便显示托盘图标（KDE 原生支持）。\
我构建了第二个包，适用于不使用 GNOME 的用户。该包不包含上述两个依赖（如果需要可后续安装）。



## 安装
如果之前通过 Alien 或 Flatpak（即非我的仓库来源）安装过 Synology Drive 客户端，请确保先卸载。

如果喜欢该项目，欢迎给仓库点星以支持我，谢谢！

### 方法 1：从 COPR 仓库安装（推荐，便于更新）
页面链接：[COPR 包](https://copr.fedorainfracloud.org/coprs/emixampp/synology-drive/)。

1. `sudo dnf copr enable emixampp/synology-drive`
2. GNOME 桌面：`sudo dnf --refresh install synology-drive`
3. 其他桌面环境：`sudo dnf --refresh install synology-drive-noextra`

### 方法 2：本地构建包（无更新）
1. 安装构建工具：`sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. 可选，若想更改版本：
   1. 查阅 [发布说明](https://www.synology.com/en-global/releaseNote/SynologyDriveClient)，选择所需版本（>= 3.2.1-13271）
   2. 编辑 `synology-drive.spec` 或 `synology-drive-noextra.spec` 的前两行，视是否使用 GNOME 或其他桌面环境而定。
5. GNOME 桌面：
   1. `spectool -g -R synology-drive.spec`
   2. `rpmbuild -ba synology-drive.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.x86_64.rpm`
6. 其他桌面环境：
   1. `spectool -g -R synology-drive-noextra.spec`
   2. `rpmbuild -ba synology-drive-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.x86_64.rpm`
7. 清理构建目录：`rm -r ~/rpmbuild`
### 实验性：为 Aarch64/ARM64 处理器（例如 Apple Silicon，Qualcomm Snapdragon）本地构建软件包
1. 安装构建工具 ：`sudo dnf install rpm-build rpmdevtools`
2. `git clone https://github.com/EmixamPP/synology-drive.git`
3. `cd synology-drive`
4. 可选，如果您想更改版本：
   1. 查阅 [发行说明](https://www.synology.com/en-global/releaseNote/SynologyDriveClient) 并选择所需版本（>= 3.2.1-13271）
   2. 编辑 `synology-drive.spec` 或 `synology-drive-noextra.spec` 的前两行，具体取决于您使用的是 GNOME 还是其他桌面环境。
5. 对于 GNOME：
   1. `spectool -g -R synology-drive-aarch64.spec`
   2. `rpmbuild -ba synology-drive-aarch64.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-*.aarch64.rpm`
6. 对于其他桌面环境：
   1. `spectool -g -R synology-drive-aarch64-noextra.spec`
   2. `rpmbuild -ba synology-drive-aarch64-noextra.spec`
   3. `sudo dnf install ~/rpmbuild/RPMS/x86_64/synology-drive-noextra-*.aarch64.rpm`
7. 清理构建根目录 ：`rm -r ~/rpmbuild`
**注意**_**：此方案使用 FEX 模拟器。如果您使用的是 QEMU 模拟器，可能会出现问题，因为 binfmt_misc 只允许为 x86_64 二进制文件注册一个模拟器。

## 法律信息
请参阅 [LICENSE](https://github.com/EmixamPP/synology-drive/blob/main/LICENSE)。

本项目已获得 Synology Inc. 授权。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-29

---