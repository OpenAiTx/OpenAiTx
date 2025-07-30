<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=%E6%9C%80%E5%90%8E%E6%9B%B4%E6%96%B0&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>학습통 온라인 자동 출석 시스템 제3자 노드 접속 프로그램</b></div> 


자체 배포용으로 [학습통 온라인 자동 출석 시스템](https://cx.waadri.top/login)에 접속 가능한 제3자 노드입니다. 이 노드 프로그램은 주 시스템과 함께 사용해야 합니다!

---


## 🎃 오픈소스에 대하여
학습통이 빈번히 소스코드 내 인터페이스를 업데이트하는 ~~공식의 표적이 아닐까 의심되어~~ 모든 기능의 지속 사용을 보장하기 위해, 앞으로는 가장 기본적인 출석 코드만 공개하며, 완전한 기능은 자동 출석 시스템에서 공식 노드를 통해 체험해 주시기 바랍니다.


## ✨ 버전 차이

|          |                                    exe버전                                    |                                    Python버전                                     |                        Docker버전                         |
| :------: | :---------------------------------------------------------------------------: | :-----------------------------------------------------------------------------: | :-----------------------------------------------------: |
| 대상 사용자 |                             Windows 컴퓨터 사용 경험자                             |                              프로그래밍 경험자 또는 Linux 경험자                              |                  NAS 경험자 또는 Linux 경험자                   |
| 기능 차이 |                                       /                                       |                                        /                                        |                  amd64 및 arm64만 지원                  |
| 다운로드 링크 | [exe 다운로드 링크](https://cx-static.waadri.top/download/other-signin-node.exe) | [Python 다운로드 링크](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` |

## 🎉 구축 튜토리얼

설정 파일 예시:

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
### 실행 파일 버전 튜토리얼 (exe 버전)

1. 더블 클릭하여 실행하면, 최초 실행 시 현재 위치에 `node_config.yaml` 설정 파일이 생성됩니다.
2. `node_config.yaml` 파일 내의 `name`을 원하는 노드 이름으로 변경하고, uuid를 제외한 다른 옵션은 수정하거나 기본값을 유지할 수 있습니다.
3. 다시 더블 클릭하여 실행합니다.

### Python 버전 튜토리얼
1. `python3.10+` 환경을 설치합니다.
2. 다음 명령어를 사용하여 실행하면, 실행 중에 필요한 서드파티 라이브러리를 자동으로 감지하고 설치합니다.

```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. `node_config.yaml` 파일에서 `name`을 원하는 노드 이름으로 변경합니다. uuid를 제외한 다른 옵션은 자유롭게 수정하거나 기본값을 유지할 수 있습니다.  
4. 다시 실행합니다.  

### Docker 버전 튜토리얼  

전문가가 만든 이미지 `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` (오직 `amd64` 와 `arm64` 만 지원)  

이미지는 Github Action으로 빌드되었으며, 자세한 내용은 [빌드 스크립트](https://github.com/Misaka-1314/SignNode-AutoBuild)에서 확인할 수 있습니다.  

설정 파일이 있는 디렉터리에서 실행하며, 처음 실행 시 `node_config.yaml` 설정 파일이 생성됩니다.

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```

참고 Docker compose(필요에 따라 수정)
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
## 🎉 사용법
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

운영 시작 후 온라인 자동 출석 시스템에서 **기타 제3자 선택 노드**를 클릭하면 자동으로 선택 노드 목록이 팝업되며, 설정한 비밀번호를 입력하면 선택한 노드로 출석 모니터링을 사용할 수 있습니다.

+ 2024/11 현재 50개 이상의 노드가 시스템에 접속되어 있으며, 10여 개 노드가 개방되어 있으니 계속해서 적극적으로 노드 자원을 기여해 주시기 바랍니다.

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 주의사항
- 학습 및 교류 목적으로만 사용하며 불법 용도로 사용하지 마십시오
- 일부 인터페이스의 악용 방지 및 프로젝트 지속 가능성 보장을 위해 제3자 노드는 수동 출석 모드, 피싱 방지 출석 모드, 출석 정보 도용 모드를 지원하지 않으며, 인터페이스 4를 이용한 출석 모니터링을 지원하지 않습니다. 이외에도 제3자 노드는 노드 오프라인 시 자동 출석 노드 교체를 지원하지 않고, 7일 무출석 시 자동 출석 모니터링 중지 제한이 없습니다. 구체 제한사항은 출석 시스템 내 제3자 노드 사용 안내를 참고하십시오. 위 제한은 공식 업데이트로 인한 기능 장애 방지를 목적으로 하며, 가장 완전한 기능 체험을 원한다면 공식 노드를 이용해 출석 모니터링을 해 주시기 바랍니다.
- 노드 프로그램은 클라우드 서버 업체 IP 환경에 설치하지 마십시오. 그렇지 않으면 학습통 공식에서 IP 차단으로 출석 모니터링이 불가할 수 있으니, 4대 통신사 또는 교육망 네트워크 환경에 설치해 주십시오.
- 저작권 침해가 있을 경우 삭제 요청은 다음 연락처로 해 주십시오: [Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 특별 감사

+ 본 프로젝트의 미니프로그램 업로드 서버는 [로리캣 IDC](https://www.loricat.cn)에서 후원합니다!

+ 본 프로젝트의 CDN 가속 및 보안 보호는 [텐센트 EdgeOne](https://edgeone.ai/?from=github)에서 후원합니다!

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---