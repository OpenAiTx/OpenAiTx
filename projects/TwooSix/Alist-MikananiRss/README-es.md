<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  Obtenga automáticamente actualizaciones de series anime desde <a href="https://mikanani.me/">Mikan Project</a> u otras fuentes RSS relacionadas con anime y descárguelas fuera de línea a través de Alist en el disco en la nube correspondiente.
</p>  
<p align="center">
  Además, utilice ChatGPT para analizar el nombre del recurso y renombrarlo en un formato que Emby pueda reconocer.
</p>  

--- 

[Documentación de uso](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## Funciones
- Obtener automáticamente actualizaciones de series y descargarlas en el disco en la nube correspondiente
- Enviar notificaciones de actualización a través de canales como PushPlus, Telegram, etc.
- Renombrar automáticamente al formato reconocible por emby, también soporta remapeo personalizado de resultados de análisis automático para que el renombrado sea más preciso

## Preparativos 
1. Por favor, despliegue Alist siguiendo la documentación del proyecto [Alist](https://github.com/alist-org/alist) (versión >=3.42.0) y configure Aria2/qBittorrent para descargas fuera de línea
2. Regístrese en Mikan Project, suscríbase a series y obtenga el enlace de suscripción

Adicional: se ha adaptado para otras fuentes RSS, teóricamente soporta la mayoría de fuentes (relacionadas con anime), para fuentes RSS no soportadas, se agradecen los reportes (issues)

## Cómo usar
Para métodos de ejecución como Docker o ejecución desde código fuente, consulte la [Documentación de uso](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

Instalación y ejecución con pip
1. Asegúrese de que su versión de python sea 3.11 o superior
2. Instale con pip: `pip install alist-mikananirss`
3. Cree un archivo `config.yaml` en el directorio y rellénelo con la configuración siguiente (ejemplo completo de funciones en [Explicación de configuración](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
   ```yaml
   common:
     interval_time: 300
   
   alist:
     base_url: https://example.com # 修改为你的alist访问地址
     token: alist-xxx # 修改为你的alist token；可在"管理员后台->设置->其他"中找到
     downloader: qBittorrent # 或者 aria2
     download_path: Onedrive/Anime # 修改为你的下载路径(Alist中的路径)

   mikan:
     subscribe_url:
       - https://mikanani.me/RSS/MyBangumi?token=xxx # 修改为你的蜜柑订阅地址
       # - https://mikanani.me/RSS/MyBangumi?token=xxx2 # 多条RSS订阅链接情况
   
     filters:
       - 非合集 # 程序暂不支持合集等形式的重命名，若使用重命名功能推荐使用此过滤器
   ```
4. Ejecutar el código: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. Disfrutar


## Demostración del efecto de renombrado
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---