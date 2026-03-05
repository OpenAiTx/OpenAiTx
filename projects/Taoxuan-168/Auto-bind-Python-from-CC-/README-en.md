Auto bind Python from CC++
===================

> A simple, easy-to-use, and configurable project for automatically binding C/C++ code to Python code and generating whl packages

> This project is cloned from:
https://github.com/Neutree/c_cpp_project_framework
and the code compilation part remains consistent with the original repository

> The pybind11 automatic binding part references the code at:
https://github.com/sipeed/MaixPy/tree/main/components/maix


## Quick Start

* 1. Clone this repository, enter the /examples/demo directory
Use python project.py menuconfig to enter the graphical interface to configure the compilation toolchain and whether to package a whl file
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image.png)
> Where x86 corresponds to native compilation, arm64 corresponds to MaixCam2 compilation, and RISCV64 corresponds to MaiCam/Pro compilation
![alt text](https://raw.githubusercontent.com/Taoxuan-168/Auto-bind-Python-from-CC-/main/./assets/image-1.png)
* 2. Write a C/C++ function and an hpp header file, which need to be named after the whl package for easy automatic recognition:
```C++
namespace add::test
{
    int add(int a, int b) 
    {
        return a + b;
    }
}
```
Write @modul comments for the corresponding functions, followed by the function path:
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
The first line is the function introduction, @param is the parameter description, and @return is the return value description (optional)
If you only need to compile and package as a whl file, there is no need to modify main.cpp
You can start compiling and packaging the whl file by using python project build
After compiling and installing the whl, you can directly call it:
```Python
import add
add.test.add(1,1)
```
Note:
-   A header file represents a module name, indicating the module to import, for example add.hpp corresponds to import add, and its module name must start with add
-   Running cpp_bind_python.py directly can generate only the bound cpp file, adding the --doc DOC parameter can automatically generate documentation from comments

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-05

---