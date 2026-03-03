
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  Una colección de modificaciones, mejoras y recursos de ingeniería inversa para Creation Kit de Bethesda.
</p>

# Descripción
**CKPE**, una potente plataforma de código compartido, realiza numerosas correcciones y mejoras al editor Creation Kit de **Bethesda**, incluye soporte para juegos como **Skyrim Special Edition**, **Fallout 4**, **Starfield**, y es sucesor de los proyectos [SSE CKFixes](https://github.com/Nukem9/skyrimse-test), [SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest), [FO4 CKFixes](https://github.com/Perchik71/Fallout4Test), así como del [Parche Unicode para SSE CK 1.5.73](https://github.com/Perchik71/usse_test) que inició todo para el autor **perchik71**.  

Página [Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki)  

# Dependencias
[toml11](https://github.com/ToruNiina/toml11) por `ToruNiina` y otros  
[Zydis](https://github.com/zyantific/zydis.git) por `zyantifi` y otros  
[zipper](https://github.com/kuba--/zip.git) por `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) por `ebiggers` y otros  
[xbyak](https://github.com/herumi/xbyak.git) por `herumi` y otros    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) por `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) por `perchik71` *(recursivo)*

# Instalación
>[!IMPORTANTE]
>¿Versión normal o noavx2?  
>Verifica con Steam si tu CPU soporta avx2. Abre Steam, en la esquina izquierda pasa el cursor sobre el menú de ayuda, selecciona Información del sistema y busca AVX2.  
>Si es compatible, usa la versión normal  
>Si no es compatible, usa la versión noavx2  
### Instalación nueva
Descarga cualquier [juego compatible](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) e instala Creation Kit.  
Descarga la [última versión](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** para tu juego.  
Extrae todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.
### Actualización
Descarga la [última versión](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) de **CKPE** para tu juego.  
Extrae todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Acepta reemplazar todos los archivos.
### Compilación
Los usuarios regulares solo necesitan este método para acceder a funciones nuevas que aún no han sido lanzadas.  
Abre el proyecto en **`Visual Studio 2022`** o posterior. Compila el proyecto en modo **`Release`** o **`Release-NoAVX2`**.  
Luego mueve el resultado de la compilación al directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Si se solicita reemplazar archivos antiguos, acepta reemplazarlos todos.
### Automatizar compilaciones (Beta)
Descarga la [compilación más reciente](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) de **CKPE** para tu juego.  
Extrae todo el contenido en el directorio del juego, de modo que **ckpe_loader.exe** esté en la misma carpeta que **CreationKit.exe**.  
Errores posibles.

# Créditos
[Nukem9](https://github.com/Nukem9) (por funciones experimentales, hash, etc., muy útiles)  
[adzm](https://github.com/adzm) (Realmente aprecio tu trabajo, has [hecho](https://github.com/adzm/win32-custom-menubar-aero-theme) lo que yo mismo llevaba tiempo queriendo hacer)  
[yak3d](https://github.com/yak3d) (Por su contribución y desarrollo del flujo de trabajo y el soporte para la versión más reciente de Starfield)  
[DioKyrie-Git](https://github.com/DioKyrie-Git) (Por el diseño del readme)  

# Licencia
A partir de la v0.6 (commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)) el proyecto está licenciado bajo [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html). <br />
Las primeras versiones están licenciadas bajo [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) <br />
Copyright © 2023-2025 aka perchik71. Todos los derechos reservados. <br />
El archivo `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` contiene archivos propietarios y no licenciados; lo mismo aplica para los archivos en `d3dcompiler\*.*`. <br />
Las dependencias están bajo sus respectivas licencias. 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---