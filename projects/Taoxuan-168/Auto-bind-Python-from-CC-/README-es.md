Auto bind Python from CC++
===================

> Un proyecto lo suficientemente simple, fácil de usar y configurable para enlazar automáticamente código C/C++ a código Python y generar paquetes whl.

> Este proyecto fue clonado de:
https://github.com/Neutree/c_cpp_project_framework
y la parte de compilación del código se mantiene igual que en el repositorio original.

> Código de referencia para la parte de enlace automático con pybind11:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Inicio rápido

* 1. Clona este repositorio, entra en el directorio /examples/demo
Usa python project.py menuconfig para entrar en la interfaz gráfica y configurar la cadena de herramientas de compilación y si se genera un archivo whl.
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Donde x86 corresponde a compilación en la máquina local, arm64 a compilación para MaixCam2, RISCV64 a compilación para MaiCam/Pro.
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Escribe una función en C/C++ y un archivo de encabezado hpp, que debe tener el mismo nombre que el paquete whl para facilitar el reconocimiento automático:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Escriba el comentario @modul correspondiente para la función, seguido de la ruta de la función:
```C++
namespace add::test
{
    /**
     * My function, add two integer.
     * @param a arg a, int type
     * @param b arg b, int type
     * @return int type, will a + b
     * @module add.test.add
     */
    int add(int a, int b);
}
```
La primera línea es la descripción de la función, @param es la descripción del parámetro, @return es la descripción del valor devuelto (puede estar vacío)  
Si solo necesita compilar y empaquetar en un archivo whl, no es necesario modificar main.cpp  
Use python project build para comenzar a compilar y empaquetar el archivo whl  
Después de compilar e instalar el whl, puede llamarlo directamente:
```Python
import add
add.test.add(1,1)
```
Nota:  
-   Un archivo de encabezado representa un nombre de módulo, indicando el módulo a importar, por ejemplo, add.hpp corresponde a import add, el nombre del módulo debe comenzar con add  
-   Ejecutar directamente cpp_bind_python.py puede generar solo el archivo cpp vinculado, agregar el parámetro --doc DOC puede generar automáticamente la documentación a partir de los comentarios  

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---