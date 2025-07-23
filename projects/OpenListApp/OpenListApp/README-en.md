
# OpenList App
### A cross-platform client for AList and OpenList, currently built-in with OpenList server, no need for additional server connection, supports iOS, macOS, Windows, Android, Linux

### Built-in [DDNS-GO(MIT)](https://github.com/jeessy2/ddns-go), if the device **has a public IP**, you can use DDNS-GO for remote access, turning your phone into a remote server

### Built-in [GATEWAY-GO(MIT)](https://github.com/OpenIoTHub/gateway-go), if the device **does not have a public IP**, you can use GATEWAY-GO for remote access, turning your phone into a remote server

### Built via CI, this project does not provide an API server; servers are provided by upstream communities like OpenList
### The project provides two sets of UI: one is the original web interface loaded directly, the other is the native interface with core features already developed; currently, Linux defaults to native UI while others use web UI

### This project serves as a frontend reference based on the AList frontend project, released under the permissive [MIT](LICENSE) license, welcome to republish in app markets after renaming the package (especially iOS), but you must always declare that the project is developed based on this project (with this project's URL)

#### About compiling this project:
* You need to download related libraries from [OpenListLib](https://github.com/OpenListApp/OpenListLib/releases) for compilation

### QQ group: 251405953
![QQGroup.jpg](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/contact/QQGroup.jpg)
### Project Structure
* [openlist](/lib/main.dart) APP entry project
* [openlist_api](/openlist_api) Core API encapsulation
* [openlist_utils](/openlist_utils) Utilities
* [openlist_background_service](/openlist_background_service) openlist (AList) library encapsulation
* [openlist_global](/openlist_global) Global shared code
* [openlist_config](/openlist_config) Configuration files
* [openlist_native_ui](/openlist_native_ui) Native UI code
* [openlist_web_ui](/openlist_web_ui) Web UI code (currently default)

![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/android/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/macos/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/storages.png) ![files](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/ios/files.png) ![storages](https://raw.githubusercontent.com/OpenListApp/OpenListApp/main/assets/images/windows/storages.png)

### Notes:
* Initial users follow upstream default permissions, meaning default webdav is not enabled, please be aware
* Others

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---