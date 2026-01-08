<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Una colección de modificaciones, mejoras y recursos ingenierizados inversamente para Creation Kit de Bethesda.
</p>

# Descripción
**CKPE** es una plataforma potente de código compartido que realiza numerosas correcciones y mejoras al editor Creation Kit de **Bethesda**, incluye soporte del editor para juegos como **Skyrim Special Edition**, **Fallout 4**, **Starfield**, es sucesor de los proyectos [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), también [parche Unicode para SSE CK 1.5.73](https://github.com/Perchik71/usse_test) que inició todo para el autor **perchik71**.  

Página del [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dependencias
[toml11](https://github.com/ToruNiina/toml11) por `ToruNiina` y otros  
[Zydis](https://github.com/zyantific/zydis.git) por `zyantifi` y otros  
[zipper](https://github.com/kuba--/zip.git) por `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) por `ebiggers` y otros  
[xbyak](https://github.com/herumi/xbyak.git) por `herumi` y otros    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) por `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) por `perchik71` *(recursivo)*

# Instalación
### Instalación nueva
Descargue cualquier [juego soportado](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) e instale Creation Kit.  
Descargue la [última versión](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** para su juego.  
Extraiga todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.
### Actualización
Descargue la [última versión](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** para su juego.  
Extraiga todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Acepte reemplazar todos los archivos.
### Compilación
Los usuarios regulares solo necesitan este método para acceder a las funciones más recientes que aún no han sido lanzadas.  
Abra un proyecto en **`Visual Studio 2022`** o superior. Compile el proyecto en modo **`Release`** o **`Release-NoAVX2`**.  
Luego mueva la salida de la compilación al directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Si se le pide reemplazar archivos antiguos, acepte reemplazar todos.
### Automatizar compilaciones (Beta)
Descargue la [compilación del último commit](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) de **CKPE** para su juego.  
Extraiga todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Errores posibles.

# Créditos
[Nukem9](https://github.com/Nukem9) (por funciones experimentales, hash y demás, muy útil)  
[adzm](https://github.com/adzm) (realmente aprecio tu trabajo, has [hecho](https://github.com/adzm/win32-custom-menubar-aero-theme) lo que yo mismo quería hacer desde hace tiempo)  
[yak3d](https://github.com/yak3d) (por la contribución y desarrollo del flujo de trabajo y soporte para el más reciente Starfield)  
[Dio-Kyrie](https://github.com/Dio-Kyrie) (por el diseño del readme)  

# Licencia
A partir de la v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) el proyecto está licenciado bajo [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Las versiones anteriores están licenciadas bajo [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Todos los derechos reservados. <br />
El archivo `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contiene archivos propietarios y no licenciados; lo mismo aplica para los archivos en `d3dcompiler\*.*`. <br />
Las dependencias están bajo sus respectivas licencias. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-08

---