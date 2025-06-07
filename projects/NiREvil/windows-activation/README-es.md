# Activación instantánea de Windows 10 y 11: Solución en 40 segundos.

[![Readme](https://img.shields.io/badge/README_IN-فارسی-blue?logo=readme)](README-FA.md)  
[![Readme](https://img.shields.io/badge/README_IN-ENGLISH-blue?logo=readme)](README.md)

> Este repositorio contiene un método que puede activar Windows 10 y 11 en menos de 40 segundos. Ambos métodos son compatibles con las versiones Home, Home N, Home Single Language, Home Country Specific, Professional, Education y Enterprise de Windows.

## Método 1 (recomendado)  
### Activación instantánea de Windows usando (PowerShell)  
> [!TIP]
> Existen muchas formas de ejecutar PowerShell en Windows 10 y 11. [^1]

Una de las formas más rápidas de abrir PowerShell en Windows es mediante una búsqueda en el menú de inicio. Puedes seguir los siguientes pasos:

<br>

### Paso 1  
Todo lo que necesitas hacer es hacer clic en el icono de inicio o búsqueda y escribir "PowerShell" en el cuadro de búsqueda.  
> Otra forma sencilla: [^2]

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5a10538a-c8c2-4934-868b-fd8e910f1f9e" width="540px">
</p>  

---
<br>

### Paso 2  
A continuación, debes hacer clic en `Ejecutar como administrador` para iniciar PowerShell; en este caso, necesitamos ejecutarlo con **privilegios administrativos**.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1f25dd2a-16db-4053-a45c-aac6f8a9e470" width="540px">
</p>

---
<br>

### Paso 3  
Ahora, después de una breve pausa para permitir la ejecución, por favor `copia` esta línea:

```CSS
irm https://get.activated.win | iex
```

---
<br>

### Paso 4  
Ahora pégala (con clic derecho) y presiona la tecla enter. En la nueva ventana que se abre, hay varias opciones disponibles, de las cuales debemos seleccionar la opción `1` y esperar unos segundos para completar.  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/0c3689a1-1595-40b3-97e2-041dac423237" width="540px">
</p>

<br>

#### Felicidades,
tu Windows ha sido activado.  
Ahora puedes presionar la tecla enter para salir del CMD y cerrar PowerShell y comprobar el menú de activación de Windows [^3]

<br><br><br><br><br><br><br><br>

## Método 2  
### Activación instantánea de Windows usando CMD (Símbolo del sistema)

<br>

> [!NOTE]
> Recuerda **conectarte** a **Internet**
>
> VPN **no es necesario**

<br>

### Paso 1  
Primero, haz clic en el icono de inicio o búsqueda y escribe "CMD" en el cuadro de búsqueda. Después de ver la opción de símbolo del sistema, ejecútala como **administrador**  
> otras formas sencillas: [^2].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/88ac970a-f24b-4acc-82c0-f8e7c0b05249" width="480px">
</p>  

---
<br>

### La siguiente es la lista de CLAVES DE LICENCIA  

|            **Clave**           |  **Versión**   |
| :---------------------------: | :------------: |
| TX9XD-98N7V-6WMQ6-BX7FG-H8Q99 |      Home      |
| 3KHY7-WNT83-DGQKR-F7HPR-844BM |     Home N     |
| 7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH | Home sl [^4]   |
| PVMJN-6DFY6–9CCP6–7BKTT-D3WVR | Home cs [^5]   |
| W269N-WFGWX-YVC9B-4J6C9-T83GX | Professional   |
| MH37W-N47XK-V7XM9-C7227-GCQG9 | Professional N |
| NW6C2-QMPVW-D7KKK-3GKT6-VCFB2 |   Education    |
| 2WH4N-8QGBV-H22JP-CT43Q-MDWWJ |  Education N   |
| NPPR9-FWDCX-D2C8J-H872K-2YT43 |   Enterprise   |
| DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4 |  Enterprise N  |

![rainbow](https://github.com/NiREvil/vless/assets/126243832/1aca7f5d-6495-44b7-aced-072bae52f256)

<br>

### Paso 2  
Instala la clave de cliente KMS.

Utiliza este comando:

```CSS
slmgr /ipk tuclave
```

> [!NOTE]
> Por favor selecciona una de las **claves de licencia** de la lista que **coincida con tu versión de Windows** y reemplázala por la frase `tuclave` en el comando.

> [!TIP]
> Cómo comprobar la versión de Windows [^3].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/1b6401e6-7e63-4351-8a92-fa355dfc30cf" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/90037069-7ea3-44a8-a9fa-e296f5e8d47b" width="340px">
</p>  

---
<br>

### Paso 3  
Establece la dirección del servidor KMS.

Utiliza el comando:

```CSS
slmgr /skms kms8.msguides.com
```

para conectarte a mi servidor KMS.

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9d634454-1c59-47da-874e-bfe575288fe6" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/2d2e6cfb-4e85-483f-ae0a-c7157d22da36" width="340px">
</p>  

---  
<br>

### Paso 4  
Activa tu Windows.
El último paso es activar tu Windows usando el comando:

```CSS
slmgr /ato
```

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/5e495d42-6ce5-4884-9de2-96a56efb4343" width="480px">
</p>  

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/aecd9cfd-8c09-4433-b410-a62205a8d692" width="240px">
</p>  

---
<br>

### Paso 5  
Ahora verifica nuevamente el estado de la activación [^6].

<p align="left">
  <br><img src="https://github.com/user-attachments/assets/9ca70137-8e2e-4504-a52d-22f41d959bd7" width="480px">
</p>

#### Listo ✅  
tu Windows se ha activado correctamente.

<br>

**Sé curioso 🤍**

[![Telegram](https://img.shields.io/badge/TELEGRAM-blue.svg?logo=telegram)](https://t.me/F_NiREvil) [![Twitter](https://img.shields.io/badge/TWITTER-blue.svg?logo=x)](https://twitter.com/NiREvil_)

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/25423296/163456776-7f95b81a-f1ed-45f7-b7ab-8fa810d529fa.png">
  <source media="(prefers-color-scheme: light)" srcset="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
  <img alt="Muestra un sol ilustrado en modo claro y una luna con estrellas en modo oscuro." src="https://user-images.githubusercontent.com/25423296/163456779-a8556205-d0a5-45e2-ac17-42d089e3c3f8.png">
</picture>

<br>

[^1]: [10 maneras de ejecutar PowerShell en Windows](https://www.google.com/amp/s/www.minitool.com/news/open-windows-11-powershell.html%3famp)  

[^2]: Otra forma aún más sencilla de ejecutar PowerShell: **Haz clic derecho** en el menú de inicio para abrir el menú de acceso rápido y selecciona **Windows Terminal (admin)** en Windows 11 o **Windows PowerShell (admin)** en Windows 10 de la lista del menú.
[^3]: Para comprobar la versión de tu Windows: **Haz clic derecho** en el menú de inicio y selecciona la opción **sistema**. Tu versión de Windows se puede ver en la segunda sección bajo **Edición.** También puedes seguir los pasos del método 2 **copiando y pegando** los comandos. Copia los comandos y luego haz **clic derecho** en **cmd o powershell** para pegarlos.
[^4]: Versión Home Single Language.
[^5]: Versión Home Country Specific.
[^6]: Para ver el estado de activación de Windows debes ir a:  
***Configuración → Actualización y seguridad → menú de activación.***

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---