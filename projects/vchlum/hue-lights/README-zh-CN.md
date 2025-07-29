# 已废弃
此扩展已被废弃，但已发布新扩展 Smart Home 以取代它。请访问 https://github.com/vchlum/smart-home

# hue-lights
![截图](https://github.com/vchlum/hue-lights/blob/main/screenshot.png)

## Gnome Shell 扩展
hue-lights 是一个用于通过本地网络上的 Philips Hue 桥接器控制 Philips Hue 灯的 Gnome Shell 扩展。该扩展将灯分组到区域和房间中。可以控制灯的状态、亮度、颜色或色温。可以为区域或房间激活场景。支持控制多个桥接器。还可以设置在通知时闪烁的灯。

## Philips Hue 娱乐区域
此扩展支持娱乐区域。使用手机上的原始应用，可以创建娱乐区域。随后可以开始将灯与屏幕同步。同步功能需要在桥接配对时生成的特殊密钥。从版本 8 或更早版本升级需要移除并重新连接 Philips Hue 桥接器。请保持桥接器更新。该功能还需要 api 版本 1.22 或更高。

## Philips Hue HDMI 同步盒支持
此扩展允许在本地网络上控制 Philips Hue HDMI 同步盒。您可以启用/禁用同步，改变模式，调整强度，调整亮度，选择娱乐区域，并选择 HDMI 输入。

## 故障排除
 1. 如果升级时遇到任何问题，请尝试注销后重新登录。
 1. 如果问题仍然存在，请通过重置键重置此扩展："/org/gnome/shell/extensions/hue-lights/"。
    * 您可以运行：`dconf reset -f /org/gnome/shell/extensions/hue-lights/` 或使用 `dconf-editor`。
 1. 如果问题仍未解决，请在 GitHub 上提交问题。如果可以，请在设置中启用调试模式并附上日志文件。
    * 您可以这样获取日志文件：`journalctl -f /usr/bin/gnome-shell 2>&1 | grep -i hue > hue-lights.log`。

## 警告
该应用程序单独使用快速变化的灯光效果条件，或与屏幕上的某些内容结合使用，可能会触发此前未检测出的癫痫症状或癫痫发作，即使对无癫痫或发作病史的人群也是如此。

## 支持的 Gnome Shell 版本
此扩展支持 Gnome Shell 版本 45 及以上。

## 从 e.g.o 安装
https://extensions.gnome.org/extension/3737/hue-lights

## 手动安装

 1. `git clone https://github.com/vchlum/hue-lights.git`
 1. `cd hue-lights`
 1. `make build`
 1. `make install`
 1. 注销并重新登录
 1. `gnome-extensions enable hue-lights@chlumskyvaclav.gmail.com`

## 安装依赖
  - 仅在从源码安装时需要
  - `make`
  - `gnome-shell`（`gnome-extensions` 命令）
  - `glib-compile-resources`
  - `libglib2.0-dev-bin`
  - `gettext`
  - 推荐运行该扩展时安装
  - `avahi-tools`（用于在本地网络发现设备的 `avahi-browse` 命令）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---