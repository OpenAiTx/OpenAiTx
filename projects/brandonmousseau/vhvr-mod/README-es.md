# VHVR-Mod  
Este es un mod experimental para el juego de PC Valheim que añade soporte nativo para VR usando Unity y SteamVR con OpenVR.  

Descarga el mod en [Nexus Mods](https://www.nexusmods.com/valheim/mods/847)!  

Consulta el registro de desarrollo del progreso en [YouTube](https://www.youtube.com/playlist?list=PL9EDvRwka57-swWbcOAq0lhIp5jSFPg-u).  

Únete al [Discord de Flatscreen to VR Modding](https://discord.gg/ZFSCSDe)  

## ¿Qué contiene este paquete?  
### Proyecto Unity  
Este proyecto existe principalmente como un generador de assets para producir los AssetBundles necesarios usados por el mod, así como una forma de construir las librerías SteamVR y Unity XR necesarias en el entorno adecuado.  

Se generan varios assets en el paquete de Unity, pero los más importantes incluyen:  
* Prefab SteamVR Player: Este prefab es una jerarquía de GameObjects de Unity que incluye todos los scripts necesarios para usar SteamVR correctamente. Incluye una cámara en la jerarquía que será reemplazada por la cámara principal del juego. La cámara está configurada para usar 3D estereoscópico mostrado en el HMD.  
* Assets de Unity y OpenVR: Son assets requeridos para arrancar correctamente el motor XR de Unity cuando el juego inicia.  
* Post-procesador gráfico [Amplify Occlusion](https://github.com/AmplifyCreations/AmplifyOcclusion): Usado como un sustituto de mayor rendimiento al efecto gráfico SSAO dentro del juego.  

### Proyecto ValheimVRMod en C#  
Este proyecto contiene la mayor parte del código del mod. Incluye clases/scripts de Unity MonoBehaviour que implementan la siguiente funcionalidad:  
* inicializar el motor XR de Unity/OpenVR  
* instanciar los prefabs de SteamVR desde los AssetBundles  
* reemplazar la cámara principal del juego con la cámara VR y posicionarla adecuadamente  
* traducir la GUI del juego a VR  
* implementar controles de movimiento (en progreso)  

### Requisitos  
Este mod requiere [BepInExPack Valheim](https://valheim.thunderstore.io/package/denikson/BepInExPack_Valheim/). BepInEx es un framework de mods para juegos Unity que permite a los modders inyectar su código en el runtime del juego. También incluye [Harmony](https://harmony.pardeike.net/articles/intro.html), que es una herramienta usada para parchear métodos existentes en librerías C#.  

Además, necesitas un HMD que soporte OpenVR/SteamVR.  

### Otra información  
Este es un mod experimental y casi con seguridad contendrá varios errores y fallos. Además, Valheim es actualmente un juego en acceso anticipado, por lo que existe una alta probabilidad de que se publiquen parches que rompan este mod. Por favor, ten paciencia mientras se trabajan las correcciones y siéntete libre de reportar cualquier problema que encuentres :)  

Como Valheim no fue hecho para VR, esta implementación no será tan cómoda como un juego diseñado para VR. Si la VR suele causarte mareos, probablemente este mod no sea para ti.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-12

---