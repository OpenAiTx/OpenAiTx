<h1 align="center">iLO 风扇控制器</h1>

<p align="center">
  <img width="800" src="https://raw.githubusercontent.com/alex3025/ilo-fans-controller/main/screenshot.png" alt="网页截图">
  <br>
  <i>轻松管理您的惠普服务器风扇转速，随时随地！</i>
</p>

---

<h3 align="center"> 🎉 感谢超过 <code>1,000+</code> 次容器拉取！🎉 </h3>

> ℹ **注意：** v1.0.0 是该工具的**完全重写版本**，欢迎任何反馈！<br>
> 如果您发现任何漏洞或有建议，请[打开一个问题](https://github.com/alex3025/ilo-fans-controller/issues)。谢谢！😄

## 常见问题解答

### 它是如何工作的？🛠

该工具是一个**单一 PHP 脚本**，使用 `php-curl` 扩展**从 iLO REST API 获取当前服务器风扇转速**，并使用 `php-ssh2` 扩展通过[修补过的 iLO SSH 接口](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F) **设置风扇转速**。您还可以**创建自定义预设**，只需一键即可设置特定风扇配置，所有操作都通过使用 [Alpine.js](https://alpinejs.dev/) 和 [TailwindCSS](https://tailwindcss.com/) 制作的**简洁网页界面**完成。

### 我能用这款工具控制我的惠普服务器吗？🖥️

该工具需要一个**修补过的 iLO 固件**，该固件在 iLO SSH 接口暴露了一些用于控制风扇转速的命令。您可以在[这篇 Reddit 帖子](https://www.reddit.com/r/homelab/comments/sx3ldo/hp_ilo4_v277_unlocked_access_to_fan_controls/)了解更多关于该补丁的信息。

截至目前，该补丁（以及本工具）仅支持**配备 iLO 4 的 Gen8 和 Gen9 服务器**。

> 🚫 不支持配备 iLO 5/6/7 的 Gen10/11/12 服务器（且大概率永远不会支持）。

### 为什么选择 PHP？📄

我认为 PHP 非常适合这类需要做一些简单服务器端操作且易于部署的任务（只需安装了 PHP 的 Web 服务器即可）。

### 为什么开发这个工具？🤔

请查看我在 [r/homelab 的原始评论](https://www.reddit.com/r/homelab/comments/rcel73/comment/hnu3iyp/?utm_source=share&utm_medium=web2x&context=3)，了解这个工具背后的故事！

### 你喜欢这个项目吗？给我点披萨吧！🍕

如果您觉得这个工具有用，欢迎通过 [PayPal](https://paypal.me/alex3025) 或 [GitHub Sponsors](https://github.com/sponsors/alex3025) 赠送我一片（或整块）披萨以支持我的工作！非常感谢！🙏

---

## Getting started with Docker / Docker Compose

If you already have a Docker environment, you can be up and running in minutes using the following command (obviously you need to change the value):

```sh
docker run -d --name ilo-fans-controller --restart always \
    -p 8000:80 \
    -e ILO_HOST='your-ilo-address' \
    -e ILO_USERNAME='your-ilo-username' \
    -e ILO_PASSWORD='your-ilo-password' \
    ghcr.io/alex3025/ilo-fans-controller:latest
```
或者如果你愿意，也可以使用 `docker compose`，因为同时提供了 [docker-compose.yaml](https://github.com/alex3025/ilo-fans-controller/blob/main/docker-compose.yaml) 文件。

**请查看 [`config.inc.php`](https://github.com/alex3025/ilo-fans-controller/blob/main/config.inc.php) 了解所有可用的环境变量！**

---

> ⚠ **重要！** ⚠
>
> 再次提醒，该工具依赖于一个 **[已修补的 iLO 固件](#can-i-use-this-tool-with-my-hp-server-%EF%B8%8F)**，该固件在 iLO SSH 接口中开放了一些用于控制风扇速度的命令。
>
> **使用此工具必须安装此修补程序！**

## 手动安装

### 以下指南基于以下环境执行

* 一台 **HP ProLiant DL380e Gen8** 服务器
* **已修补的 iLO 4** 高级版 **v2.77**（2020年12月07日）
* 运行 **Ubuntu 22.04** 的 Proxmox 容器（LXC）
* **Apache 2** 和 **PHP 8.1**

### 环境准备

1. 更新系统：


    ```sh
    sudo apt-get update && sudo apt-get upgrade
    ```

2. 安装所需的软件包（`apache2`，`php`，`php-curl` 和 `php-ssh2`）：

    ```sh
    sudo apt-get install apache2 php php-curl php-ssh2
    ```

### 下载工具

1. 使用 `wget` 和 `tar` 下载并解压最新的源代码：

    ```sh
    wget -qL https://github.com/alex3025/ilo-fans-controller/archive/refs/heads/main.tar.gz -O - | tar -xz
    ```

2. 进入目录：

    ```sh
    cd ilo-fans-controller-main
    ```

### 配置和安装工具

1. 使用您喜欢的文本编辑器打开 `config.inc.php` 文件，并根据您的配置更改变量。

    > ℹ **注意：** 请记住，`$ILO_HOST` 是您的 iLO 接口的 IP 地址，而不是服务器本身的地址。

    > ℹ **注意：** 建议创建一个新的 iLO 用户，赋予访问 SSH 接口和 REST API（远程控制台访问）所需的最低权限。

    例如：

    ```php
    /*
    ILO ACCESS CREDENTIALS
    --------------
    These are used to connect to the iLO
    interface and manage the fan speeds.
    */

    $ILO_HOST = '192.168.1.69';
    $ILO_USERNAME = 'Administrator';
    $ILO_PASSWORD = 'AdministratorPassword1234';
    ```

2. 完成后，在您的网页服务器根目录（通常是 `/var/www/html/`）中创建一个新的子目录，并将 `config.inc.php`、`ilo-fans-controller.php` 和 `favicon.ico` 复制到该目录中：

    ```sh
    sudo mkdir /var/www/html/ilo-fans-controller
    sudo cp config.inc.php ilo-fans-controller.php favicon.ico /var/www/html/ilo-fans-controller/
    ```
    然后将 `ilo-fans-controller.php` 重命名为 `index.php`（以便在 URL 中无需指定文件名即可工作）：


    ```sh
    sudo mv /var/www/html/ilo-fans-controller/ilo-fans-controller.php /var/www/html/ilo-fans-controller/index.php
    ```

3. 就是这样！现在你可以通过 `http://<your-server-ip>/ilo-fans-controller/` （或者用于 API 请求的 `http://<your-server-ip>/ilo-fans-controller/index.php`）访问该工具。

> ℹ **注意：** 如果你安装此工具的 Web 服务器 **可以从你的网络外部访问**，请记得 **设置某种认证机制**（如基本认证），以防止 _凌晨2点未授权的风扇管理_。

---

## 故障排除

遇到问题时首先要做的是 **检查日志**。

> 如果你使用的是 Apache，PHP 错误记录在 `/var/log/apache2/error.log` 文件中。

如果你认为发现了一个漏洞，请[提交问题](https://github.com/alex3025/ilo-fans-controller/issues)，我会查看。

下面是一些常见问题及其解决方案。

### 预设未保存

如果在创建新预设时日志中出现以下错误：

```log
PHP Warning:  file_put_contents(presets.json): Failed to open stream: Permission denied in .../index.php on line X
```

这可能是因为 `presets.json` 文件对 Web 服务器用户不可写。<br>
为了解决此问题，请运行以下命令将文件所有者更改为 `www-data`（默认的 Apache 用户）：

```sh
sudo chown www-data:www-data /var/www/html/ilo-fans-controller/presets.json
```

---

## API 文档

该工具提供了一个简单的 API，可用于：

* 从 iLO 获取当前风扇转速
* 设置风扇转速
* 获取所有预设
* 创建预设

> 以下示例使用 cURL 演示如何使用 API，但您可以使用任何其他工具。

### 风扇 API

使用以下 API 时，您需要在 URL 末尾添加 `?api=fans`。

#### 获取风扇转速（`GET`）

<details>
<summary>JSON 结构（响应）</summary>

```jsonc
{
    "Fan 1": 85,
    "Fan 2": 48,
    "Fan 3": 69,
    "Fan 4": 18,
    "Fan 5": 44,
    "Fan 6": 96
}
```

</details>

<details>
<summary>cURL 示例</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=fans'
```

</details>

#### 设置风扇速度（`POST`）

<details>
<summary>JSON 结构示例</summary>

```jsonc
{
    "action": "fans",
    // You can use either an object or a single number value (that will be applied to all fans):
    // Example: `fans: { ... }` or `fans: 50`
    "fans": {
        "Fan 1": 40,
        "Fan 2": 23,
        "Fan 5": 70
        // ...
    }
}
```

</details>

<details>
<summary>cURL 示例</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "fans", "fans": 50}'
```
此命令将所有风扇设置为 50%。<br>
_我个人在服务器启动时使用此命令自动降低风扇速度。_
</details>

### 预设 API

使用以下 API 需要在 URL 末尾添加 `?api=preset`。

#### 获取所有预设（`GET`）

<details>
<summary>JSON 结构（响应）</summary>


```jsonc
[
    {
        "name": "Silent Mode",
        "speeds": [15]  // Like when setting the speeds, this number applies to all fans.
    },
    {
        "name": "Normal Mode",
        "speeds": [50]
    },
    {
        "name": "Turbo Mode",
        "speeds": [100]
    },
    {
        "name": "My Custom Preset",
        "speeds": [10, 10, 25, 30, 10, 15]  // Here you can see the different speeds for each fan.
    }
]
```

</details>

<details>
<summary>cURL 示例</summary>

```sh
curl 'http://<server ip>/ilo-fans-controller/index.php?api=presets'
```

</details>

#### 创建预设（`POST`）

<details>
<summary>JSON结构示例</summary>

```jsonc
{
    "action": "presets",
    // WARNING: The API will replace all the saved presets with the new data!
    // To add a preset you should get all the presets first and then add the new one to the existing array.
    "presets": [
        {
            "name": "Silent Mode",
            "speeds": [15]
        },
        {
            "name": "Normal Mode",
            "speeds": [50]
        },
        {
            "name": "Turbo Mode",
            "speeds": [100]
        },
        {
            "name": "My Custom Preset",
            "speeds": [10, 10, 25, 30, 10, 15]
        }
    ]
}
```

</details>

<details>
<summary>cURL 示例</summary>

```sh
curl -X POST 'http://<server ip>/ilo-fans-controller/index.php' \
    -H 'Content-Type: application/json' \
    -d '{"action": "presets", "presets": [{"My Custom Preset 1": [50], "My Custom Preset 2": [10, 20, 30, 30, 20, 10]}]}'
```

</details>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-10

---