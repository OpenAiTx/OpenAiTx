<center><div align="center">

<img src="https://avatars.githubusercontent.com/u/90495619?v=4" width="300" height="300" style="border-radius: 50%"></img>

<img alt="version" src="https://img.shields.io/github/last-commit/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=%E6%9C%80%E5%90%8E%E6%9B%B4%E6%96%B0&logo=velog&logoColor=BE95FF&color=7B68EE"/></img>
<img alt="stars" src="https://img.shields.io/github/stars/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Stars&logo=undertale&logoColor=orange&color=orange"/></img>
<img alt="forks" src="https://img.shields.io/github/forks/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Forks&logo=stackshare&logoColor=f92f60&color=f92f60"/></img>
<img alt="pr" src="https://img.shields.io/github/issues-pr-closed/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=PR&logo=addthis&logoColor=green&color=0AC18E"/></img>
<img alt="issues" src="https://img.shields.io/github/issues/WAADRI/ChaoXing_node_signin.svg?style=for-the-badge&label=Issues&logo=openbugbounty&logoColor=e38dff&color=e38dff"/></img>

</div></center>

<div align="center" style="font-weight:bold"><b>Sistema de inicio de sesión automático en línea de Xuexitong: programa de integración de nodo de terceros</b></div> 


Programa para desplegar por cuenta propia y conectar nodos de terceros al [Sistema de inicio de sesión automático en línea de Xuexitong](https://cx.waadri.top/login), ¡este programa de nodo debe usarse junto con el sistema principal!

---


## 🎃 Sobre el código abierto
Debido a que ~~se sospecha que es objetivo de la oficial~~ Xuexitong actualiza frecuentemente las interfaces en el código fuente, para asegurar la continuidad de todas las funciones, a partir de ahora solo se publicará el código básico de inicio de sesión, para funciones completas por favor inicie sesión en el sistema automático y use el nodo oficial para la experiencia


## ✨ Diferencias de versiones

|          |                                    Versión exe                                    |                                    Versión Python                                     |                        Versión Docker                         |
| :------: | :-------------------------------------------------------------------------------: | :----------------------------------------------------------------------------------: | :-----------------------------------------------------------: |
| Público  |                             Para usuarios con experiencia en Windows              |                              Para usuarios con experiencia en programación o Linux    |                  Para usuarios con experiencia en NAS o Linux |
| Funciones|                                       /                                         |                                        /                                            |                  Solo soporta amd64 y arm64                    |
| Enlaces  | [Enlace descarga exe](https://cx-static.waadri.top/download/other-signin-node.exe) | [Enlace descarga Python](https://cx-static.waadri.top/download/other-signin-node.py) | `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node`       |

## 🎉 Tutorial de instalación

Ejemplo de archivo de configuración:

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

### Tutorial de versión ejecutable (versión exe)

1. Haga doble clic para ejecutar, la primera vez que se ejecute se generará un archivo de configuración `node_config.yaml` en la ubicación actual.
2. Cambie el `name` en `node_config.yaml` al nombre de nodo que prefiera, las demás opciones excepto uuid pueden modificarse o mantenerse por defecto.
3. Haga doble clic para ejecutar nuevamente.

### Tutorial versión Python
1. Instale el entorno `python3.10+`
2. Ejecute con el siguiente comando, que detectará e instalará automáticamente las bibliotecas de terceros necesarias para la ejecución
```bash
wget -O "main.py" "https://cx-static.waadri.top/download/other-signin-node.py"
python3 main.py
```
3. Cambia el `name` en `node_config.yaml` al nombre del nodo que prefieras; las demás opciones, excepto el uuid, pueden modificarse o mantenerse por defecto.  
4. Ejecútalo nuevamente.  

### Tutorial versión Docker  

Imagen construida por expertos `ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node` (solo compatible con `amd64` y `arm64`)  

La imagen se construye usando Github Action, para más detalles consulta el [script de construcción](https://github.com/Misaka-1314/SignNode-AutoBuild)  

Ejecuta en el directorio del archivo de configuración, la primera ejecución generará el archivo de configuración `node_config.yaml`.

```bash
docker run -d \
    --name=sign-node \
    -v $(pwd):/data \
    --restart=always \
    --dns=223.5.5.5 --dns=114.114.114.114 \
    ccr.ccs.tencentyun.com/misaka-public/waadri-sign-node
```

Referencia Docker compose (modifique según sea necesario)
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

## 🎉 Uso
![image](https://github.com/user-attachments/assets/a1808fbb-735d-46e1-86a1-67e81a969b9a)

Después de poner en marcha, puedes hacer clic en **Otros nodos personalizados de terceros** en el sistema automático de registro en línea, aparecerá automáticamente una lista de nodos personalizados, selecciona e ingresa la contraseña que configuraste para usar el nodo seleccionado para monitoreo de registro.

+ En 2024/11, más de 50 nodos ya están conectados al sistema, y más de diez nodos están abiertos para uso, invitamos a todos a seguir contribuyendo activamente con recursos de nodos.

![image](https://github.com/user-attachments/assets/bb4aee50-8ec7-4946-bc4c-0b55ca4a590c)

### 🎃 Precauciones
- Solo para aprendizaje e intercambio, no usar para fines ilegales
- Para evitar el uso malintencionado de algunas interfaces y garantizar la sostenibilidad del proyecto, los nodos de terceros no soportan modo de registro manual, modo anti-phishing para registro y modo de robo de información de registro, no soportan usar la interfaz 4 para monitoreo de registro. Además, los nodos de terceros no soportan cambiar automáticamente el nodo de registro cuando el nodo está desconectado, y no tienen la limitación de detener automáticamente el monitoreo después de 7 sin registros. Las restricciones específicas se basan en las instrucciones de uso de nodos de terceros en el sistema de registro, estas restricciones están destinadas a prevenir fallos por actualizaciones oficiales; para una experiencia completa use los nodos oficiales para monitoreo.
- No instales el programa de nodo en IP de proveedores de servidores en la nube, de lo contrario la IP puede ser bloqueada por el sistema oficial causando la imposibilidad de monitoreo; instala en redes de los cuatro grandes operadores o redes educativas.
- Si hay violación de derechos por favor contáctanos para eliminar: [Email](https://raw.githubusercontent.com/WAADRI/ChaoXing_node_signin/main/mailto:WiFi86@qq.com)

## 🏆 Agradecimientos especiales

+ El servidor de subida del mini programa de este proyecto es patrocinado por [萝莉猫 IDC](https://www.loricat.cn) ¡de forma altruista!

+ La aceleración CDN y protección de seguridad de este proyecto son patrocinadas por [Tencent EdgeOne](https://edgeone.ai/?from=github)!

<img src="https://doc.micono.eu.org/image/ad/腾讯云 EdgeOne.png" width="200"></img>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---