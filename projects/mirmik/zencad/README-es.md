ZenCad
======
Sistema CAD para programadores zen justos  

¿Qué es?
-----------
ZenCad - es un sistema para usar el núcleo de geometría oce en estilo de script de openscad.
Así que es la idea de openscad, lenguaje python y el poder de opencascade en uno.  

Manual e Información
----------------------
- Manual: [aquí](https://mirmik.github.io/zencad/).

- Artículos:  
	- habr: [Система скриптового 3д моделирования ZenCad](https://habr.com/ru/post/443140/)

- Chat de la comunidad (Telegram): [https://t.me/zencad](https://t.me/zencad)

Instalación
------------
### Instalar xcb
```
apt install libxcb*
```

### Común:
Zencad necesita *pythonocc* y *opencascade core* (OCCT). Después del primer lanzamiento
 (escriba los comandos `zencad` o `python3 -m zencad`)
se iniciará la utilidad de instalación de bibliotecas. Puede usarla para la instalación de *pythonocc* y *OCCT*. También puede instalar las bibliotecas manualmente.
```
apt install qt5-default
python3 -m pip install zencad[gui]
zencad 
# On first launch, Zenсad will ask you to download the required libraries. 
# After completing the necessary operations, close the installation utility and run the program again. 
zencad
```

### Instalación sin parte gráfica:
Instale zencad como biblioteca sin la parte gui:
```python3 -m pip install zencad```
```python3 -m zencad --install-occt-force```  
```python3 -m zencad --install-pythonocc-force```

### Para Windows:  
La versión de ZenCad para Windows necesita `vcredist` (Paquete redistribuible de Microsoft).  
Por favor, instala `vcredist 2015` para Python3.7 y también `vcredist 2019` para Python3.8 y posteriores.

Distribución independiente
--------------------------
ZenCad tiene una versión independiente para Windows.  
Versión preliminar para Windows en [releases](https://github.com/mirmik/zencad/releases).

Código fuente
---------------
Repositorio principal del proyecto:  
	[https://github.com/mirmik/zencad](https://github.com/mirmik/zencad)  
Repos relacionados:  
	[https://github.com/mirmik/zenframe](https://github.com/mirmik/zenframe)  
	[https://github.com/mirmik/evalcache](https://github.com/mirmik/evalcache)  

Hola Mundo
----------
```python
#!/usr/bin/env python3
#coding: utf-8

from zencad import *

modelo = box(200, center = True) - sphere(120) + sphere(60)

display(modelo)
show()
```
Result:  
![result.png](https://mirmik.github.io/zencad/images/generic/zencad-logo.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---