# netevent

Netevent 是一个工具，可以用来与其他机器共享 Linux 事件设备（通过 `/dev/uinput` 或者通过其他方式实现相同协议的客户端）。

最初它只是将设备功能输出到标准输出，然后在一种模式下表现得像运行 `cat /dev/input/eventX`，在另一种模式下将解析后的功能传递给 `/dev/uinput`，然后传递事件。

由于当有多个目标时管理多个设备会变得繁琐（并且原有的抓取/切换/热键机制很怪异，且字面上针对我的个人使用场景），netevent2 现在扩展了协议，可以包含多设备的数据包，并且可以动态添加和移除设备。

原始的类似 `cat` 的行为（尽管目前不支持热键）也可用于调试目的（`create` 模式支持两个协议版本）。

现在的主要工具是 `netevent 守护进程`，它有一个命令套接字（可选的抽象 unix 套接字），通过它可以动态添加设备、输出和热键。见下方示例。

## 编译

* 可选：`./configure --prefix=/usr`
* `make`

你仍然可以像以前一样直接运行 `make`。不过，为了支持常见的安装流程，并区分内核较新、`/dev/uinput` 增加了 `UI_DEV_SETUP` `ioctl` 的系统，添加了一个 `./configure` 脚本来检测此项并生成 `config.h` 以及 `config.mak`，用于 PREFIX/BINDIR/...（所有这些也可以作为变量直接传递给 `make`，以及常用的 `DESTDIR`）。

## 安装

* `make install` 或者 `make DESTDIR=/my/staging/dir install`


















或者：如前所述，只需将 `netevent` 二进制文件放置在任意位置。

## 使用方法

请参阅 netevent(1) 中的 DAEMON COMMANDS 部分，了解下面设置脚本中使用的命令详情。

### 示例

请查看 `examples/` 目录。阅读下面的 setup-example，了解如何调整热键行以适配您的设备。

#### 简单示例设置：通过 ssh 与另一台机器共享键盘和鼠标：

主机端：

* 准备工作：确保我们可以以用户身份访问事件设备

    通常这意味着运行类似 `gpasswd -a myuser input` 的命令

* 第一步：确定要传递的 /dev/input/eventXY 设备。

    为了文件名一致，可以使用类似以下路径：
    `/dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd`
    `/dev/input/by-id/usb-BestMouseEver-event-mouse`

* 第二步：选择一个热键并找到其事件代码：

    在上述示例中，我们希望使用键盘上的一个键（除非您拥有大量鼠标按钮...）。
    可以使用 `netevent` 以可读方式导出事件，运行设备上的 `show` 子命令，然后按下您想用作热键的键。
    如果您正在用同一键盘输入命令，请在运行前加一个 sleep，以避免 netevent 捕获回车键释放事件时产生混淆。







    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```

* 步骤 3：为守护进程准备一个安装脚本：

    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```

* 第4步：运行netevent守护进程：

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

您现在可以通过连接到套接字向守护进程发送其他命令。
例如通过`socat READLINE UNIX-CONNECT:netevent-command.sock`。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---