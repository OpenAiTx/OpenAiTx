<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=%E6%9C%80%E5%90%8E%E6%9B%B4%E6%96%B0&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>学习通在线自动签到系统第三方节点接入程序</b></div> 


用于自行部署可接入 [学习通在线自动签到系统](https://cx.waadri.top/login) 的第三方节点，该节点程序需配合主系统使用！

---


## 🎃 关于开源
由于~~怀疑被官方针对~~学习通频繁更新源码中的接口，为了确保所有功能可持续使用，此后将只发布最基础的签到代码，完整功能请登录自动签到系统使用官方节点进行体验


## ✨ 版本差异

|          |                                    exe版本                                    |                                    Python版                                     |                        Docker版                         |
| :------: | :---------------------------------------------------------------------------: | :-----------------------------------------------------------------------------: | :-----------------------------------------------------: |
| 适合人群 |                             有Windows电脑使用经历                             |                              有编程经验或Linux经验                              |                  有NAS经验或Linux经验                   |
| 功能差异 |                                       /                                       |                                        /                                        |                  仅支持 amd64 和 arm64                  |
| 下载链接 | [exe下载链接](https://cx-static.waadri.top/download/other-signin-node.exe) | [Python下载链接](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` |

## 🎉 搭建教程

配置文件展示：

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

### 可执行版教程（exe版）

1. 双击运行，首次运行会在当前位置生成 `node_config.yaml` 配置文件。
2. 将 `node_config.yaml` 中的 `name` 修改为你喜欢的节点名称，除uuid外的其它选项可自行修改也可保持默认。
3. 再次双击运行。

### Python版教程
1. 安装好 `python3.10+` 环境
2. 使用以下命令运行，运行后将自动检测并安装运行所需的第三方库
```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. 将 `node_config.yaml` 中的 `name` 修改为你喜欢的节点名称，除uuid外的其它选项可自行修改也可保持默认。  
4. 再次运行。  

### Docker版教程  

大神构建的镜像 `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node`（仅支持 `amd64` 和 `arm64`）  

镜像使用 Github Action 构建，详见 [构建脚本](https://github.com/Misaka-1314/SignNode-AutoBuild)  

将配置文件目录下运行，首次运行会生成 `node_config.yaml` 配置文件。

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```

参考 Docker compose（按需自行修改）
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

## 🎉 使用
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

运行上线后可在在线自动签到系统中点击 **其它第三方自选节点**，会自动弹出自选节点列表，选择并输入你设置的密码后即可使用所选节点进行签到监控。

+ 2024/11 目前已有超过50个节点接入了系统，有十余个节点开放使用，欢迎大家继续积极贡献节点资源。

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 注意事项
- 仅供学习交流，不要用于非法用途
- 为防止部分接口被恶意利用以及保证项目的可持续性，第三方节点不支持手动签到模式、反钓鱼签到模式和签到信息盗用模式，不支持使用接口4进行签到监控。除此以外第三方节点不支持节点离线后自动更换签到节点，且无7无签到自动停止签到监控的限制。具体限制以签到系统中的第三方节点使用须知说明为准，以上限制旨在防止官方更新导致功能失效，若要体验最完整的功能还请使用官方节点进行签到监控
- 节点程序不要搭建在云服务器厂商的IP环境下，否则可能会被学习通官方封禁IP地址导致无法进行签到监控，请在四大运营商或教育网的网络环境下搭建
- 如有侵权请联系我们删除：[Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 特别鸣谢

+ 本项目的小程序上传服务器 由 [萝莉猫 IDC](https://www.loricat.cn) 公益赞助！

+ 本项目的 CDN 加速和安全保护由 [腾讯 EdgeOne](https://edgeone.ai/?from=github) 赞助！

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---