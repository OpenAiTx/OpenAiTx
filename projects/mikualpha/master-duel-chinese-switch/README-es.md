<h1 align="center">Parche de Traducción al Chino de la Comunidad de Master Duel</h1>
<div align="center">

![GitHub releases](https://img.shields.io/github/v/release/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub license](https://img.shields.io/github/license/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub last commit](https://img.shields.io/github/last-commit/mikualpha/master-duel-chinese-switch?style=flat-square)
![GitHub Gist last commit](https://img.shields.io/github/gist/last-commit/de53fb59b1c63a8be98539e04aba5d42?style=flat-square&label=metadata%20version)
![GitHub download count](https://img.shields.io/github/downloads/mikualpha/master-duel-chinese-switch/total?style=flat-square)

[Dirección del proyecto original](https://gitee.com/fetiss/master-duel-chinese-switch) | [Página de lanzamiento original](https://www.bilibili.com/read/cv21869124) | [Fuente de API](https://ygocdb.com/)
  
</div>

Desde la versión de principios de mayo de 2023, MD modificó la forma de llamar a los archivos de caché, haciendo que el parche de traducción original dejara de funcionar, por lo que se realizaron modificaciones basadas en el proyecto original.

Este proyecto se basa en el trabajo de los autores [@叶lf](https://space.bilibili.com/23834819) / [@Timelic](https://space.bilibili.com/8664322), a quienes agradecemos. También agradecemos a [@拓王神](https://space.bilibili.com/483116312) por su apoyo en la parte de análisis de datos.

## Modo de uso
Diríjase a la [página de Releases](https://github.com/mikualpha/master-duel-chinese-switch/releases) para descargar `MDTR_vx.x.x.exe`, y consulte la página [Wiki](https://github.com/mikualpha/master-duel-chinese-switch/wiki) de este proyecto para su uso.

## Sobre el proyecto
Este proyecto es de código abierto bajo la licencia `AGPL-3.0`. Cualquier distribución o modificación debe cumplir con la [licencia de código abierto](https://www.chinasona.org/gnu/agpl-3.0-cn.html). La página de Release de este proyecto es la única fuente oficial de distribución; no existen grupos oficiales, no se publican archivos ejecutables en plataformas de terceros, ni se ofrecen compras, donaciones o recompensas a través de plataformas externas. Tenga cuidado con posibles virus o fraudes.

Si ocurre algún error o cierre inesperado, puede abrir un `issue`. **Se invita a los interesados a enviar PR~**

**Si considera que este proyecto le ha sido útil, por favor considere dar un `Star` al proyecto, ¡gracias!**

## Desarrollo relacionado
Este proyecto utiliza `UnityPy` para descompresión y `flet` para la interfaz. El entorno de compilación es `Python 3.10`.

<div align="center">
  <img src="https://raw.githubusercontent.com/mikualpha/master-duel-chinese-switch/master/./images/display.png" width="400">
</div>

#### Preparación

```
pip install -r requirements.txt
```

#### 开发

无界面

```
python3 index.py
```

interfaz flet

```
flet run interface.py
```

#### 打包

PowerShell:

```
./release.ps1
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-24

---