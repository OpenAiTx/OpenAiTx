<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Last%20Update&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>Chaoxing Online Automatic Sign-in System Third-party Node Access Program</b></div> 


For self-deployment of third-party nodes that can be accessed by the [Chaoxing Online Automatic Sign-in System](https://cx.waadri.top/login), this node program must be used in conjunction with the main system!

---


## 🎃 About Open Source
Due to ~~suspicions of being targeted by the official~~ frequent updates of interfaces in the Chaoxing source code, to ensure all functions remain sustainable, from now on only the most basic sign-in code will be released. For full features, please log in to the automatic sign-in system and use the official node for experience.


## ✨ Version Differences

|          |                                   exe Version                                  |                                   Python Version                                  |                        Docker Version                         |
| :------: | :---------------------------------------------------------------------------: | :-----------------------------------------------------------------------------: | :-----------------------------------------------------------: |
| Suitable |                             Users with Windows experience                      |                              Users with programming or Linux experience          |                  Users with NAS or Linux experience           |
| Features |                                       /                                       |                                        /                                        |                  Supports only amd64 and arm64                 |
| Download | [exe Download Link](https://cx-static.waadri.top/download/other-signin-node.exe) | [Python Download Link](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` |

## 🎉 Setup Tutorial

Configuration file display:

```yaml
# 配置文件修改时注意在单引号内填写，不熟悉yaml文件格式的用户可在 https://www.json.cn/yaml-editor/ 中进行编辑并确认无误后粘贴回配置文件
# 邮件功能配置区
email:
  # 用来发送邮件的邮箱地址如XXX@qq.com，未填写则不发送邮件
  address: ''
  # 用来发送邮件的邮箱密码，某些邮箱可能需要填写授权码
  password: ''
  # 是否使用tls或ssl加密连接，默认true为使用加密连接，如不使用请填false，需注意大小写
  use_tls: true
  # 发送邮件服务器的host主机名，如QQ邮箱的发送邮件服务器主机名为smtp.qq.com
  host: ''
  # 发送邮件服务器端口号，请注意上方配置使用tls的状态，两种状态下的端口号一般不同
  port: 465
  # 发件人名称，可自行填写想让接收方看到的发件人名称，不填写则接收方看到的名称为发送人邮件地址
  user: ''
# 节点名称、密码和人数配置区
node:
  # 节点名称，不能和已接入在线自动签到系统的其它第三方节点名称重复
  name: ''
  # 节点密码，设置后用户需要在网站中输入正确的密码才能使用该节点，留空则为不设置密码，此时任何人均可使用该节点进行签到
  password: ''
  # 限制节点使用人数，0为不限制使用人数
  limit: 0
# 是否开启用户频繁信息显示，关闭后当用户使用接口2或接口3出现“请勿频繁操作”提示后将不会在控制台展示此类信息，默认true为显示，不显示请填false，需注意大小写
show_frequently: true
# 是否开启夜间签到监控，当关闭时接口2和接口3将在每日23时至次日6时暂停使用上述接口用户的签到监控，可尽量避免夜间频繁请求导致接口出现频繁提示，此配置不影响接口1在夜间进行监控，默认true为开启夜间监控，如不开启请填false，需注意大小写
night_monitor: true
# 是否启用debug模式，启用后日志输出更加详细，方便排查问题，建议使用时出现问题且命令行中未展示问题详细信息时再启用，默认false为不输出，要输出debug日志请填true，需注意大小写
debug: false
# 节点uuid，第一次启动程序时会随机生成，请勿更改，否则无法匹配已经使用该节点启动监控的用户信息
uuid: XXX
```

### Executable Version Tutorial (exe version)

1. Double-click to run. The first run will generate a `node_config.yaml` configuration file in the current location.
2. Modify the `name` in `node_config.yaml` to your preferred node name. Other options except uuid can be modified or left as default.
3. Double-click to run again.

### Python Version Tutorial
1. Install the `python3.10+` environment
2. Run using the following command. It will automatically detect and install the required third-party libraries after running.
```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. Change the `name` in `node_config.yaml` to your preferred node name. Other options besides uuid can be modified or left as default.
4. Run again.

### Docker Version Tutorial

The image built by the expert `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` (supports only `amd64` and `arm64`)

The image is built using Github Action, see [build script](https://github.com/Misaka-1314/SignNode-AutoBuild) for details.

Run in the configuration file directory; the first run will generate the `node_config.yaml` configuration file.

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```

Refer to Docker compose (modify as needed)
```
networks:
    1panel-network:
        external: true
        
services:
    AutoSign:
        container_name: ChaoXing-AutoSign
        image: ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
        volumes:
            - ./data:/data
        networks:
            - 1panel-network
        restart: always
        env_file:
            - 1panel.env
```

## 🎉 Usage
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

After going online, you can click **Other Third-Party Custom Nodes** in the online automatic check-in system, and a list of custom nodes will automatically pop up. Select and enter the password you set to use the chosen node for check-in monitoring.

+ As of 2024/11, more than 50 nodes have been connected to the system, with over ten nodes open for use. Everyone is welcome to continue actively contributing node resources.

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 Notes
- For learning and communication only, do not use for illegal purposes
- To prevent some interfaces from being maliciously exploited and to ensure the sustainability of the project, third-party nodes do not support manual check-in mode, anti-phishing check-in mode, and check-in information theft mode, and do not support using interface 4 for check-in monitoring. Besides, third-party nodes do not support automatic switching of check-in nodes after a node goes offline, nor do they have the limitation of automatically stopping check-in monitoring after 7 days without check-in. Specific restrictions are subject to the third-party node usage instructions in the check-in system. These restrictions aim to prevent functionality failure due to official updates. To experience the most complete features, please use official nodes for check-in monitoring.
- Node programs should not be deployed under the IP environment of cloud server providers, otherwise the IP address may be blocked by the official platform, resulting in failure to perform check-in monitoring. Please deploy in the network environment of the four major telecom operators or the education network.
- If there is any infringement, please contact us for removal: [Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 Special Thanks

+ The mini program upload server of this project is kindly sponsored by [Lolicat IDC](https://www.loricat.cn)!

+ The CDN acceleration and security protection of this project are sponsored by [Tencent EdgeOne](https://edgeone.ai/?from=github)!

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---