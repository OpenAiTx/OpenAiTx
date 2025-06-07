# PSFree 版本 1.5.1

PSFree 是一个针对 PS4 主机的漏洞利用工具集合。该仓库主要聚焦于 PS4，但我们也尽量使其能够移植到 PS5。

## 特性

- **自动检测：** 自动检测主机类型和固件版本（通过 [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)）。
- **WebKit 漏洞利用（PSFree）：** 通过主机的网页浏览器进行入口。
- **内核漏洞利用（Lapse）：** 权限提升至内核级别。
- **Payload 加载器：** 内核漏洞利用成功后，在 9020 端口监听 Payload。

## 漏洞适用范围

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## 本仓库支持情况

下表显示了本仓库_当前版本_已实现并测试通过的漏洞利用链所支持的固件版本。

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_注意：关于“漏洞适用范围”表中提到的其他固件，本仓库当前可能正在开发支持，或曾在历史版本中支持。请查阅 [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) 获取历史支持情况。_

## TODO 列表

- [ ] 某些游戏存在黑屏/存档问题
- [ ] [`lapse.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/lapse.mjs)：仅设置 JIT 权限位
- [ ] [`view.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/view.mjs)：当前假定为 PS4，需支持 PS5
- [ ] 增加 PS5 支持

## 版权与作者

AGPL-3.0-or-later（详见 [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)）。本仓库归属于 `anonymous` 组织。我们将匿名贡献者也称为“anonymous”。

## 鸣谢

- anonymous，提供 PS4 固件内核转储
- 其他**额外**贡献者请查阅相关文件。除非另有说明，所有内容均可归功于我们。

## 捐赠

（Monero/XMR）：**86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---