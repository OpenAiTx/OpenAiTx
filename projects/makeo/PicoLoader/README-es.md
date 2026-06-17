# PicoLoader
Este es un modchip basado en ODE para el Nintendo GameCube que permite arrancar homebrew.\
Su precio y funcionalidad son muy similares a [PicoBoot](https://github.com/webhdx/PicoBoot) pero tiene múltiples ventajas.

¡Únete al [servidor de Discord](https://discord.gg/YtA9aU3BKZ) para obtener soporte y discutir el mod!

## ¿Cómo funciona?
Este mod funciona emulando una unidad de disco durante el arranque, ejecutando una aplicación homebrew, y después reactivando la unidad de disco.\
Esto se logra usando una PCB flexible similar a FlippyDrive.
Sin embargo, no es un emulador completo de unidad óptica y solo permite ejecutar aplicaciones homebrew pequeñas (p.ej. [swiss](https://github.com/emukidid/swiss-gc)) desde memoria flash igual que PicoBoot.
Para acceder a archivos en una tarjeta SD, necesitas un SDGecko, SD2SP2, o un adaptador similar, que se puede comprar por separado.

## Características
- Código abierto
- Puedes conservar la unidad de disco
- Fácil para arrancar la mayoría de aplicaciones homebrew usando un [convertidor en línea](https://makeo.github.io/PicoLoader/converter/)
- Sin modificaciones permanentes al GameCube
- [Conector impreso en 3D](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl) para instalaciones sin unidad de disco
- Fácil de remover
- Pico funcionando a 200Mhz para mejor compatibilidad con placas clon

#### Variante con soldadura
- Componentes baratos y fáciles de conseguir (Raspberry Pi Pico/Pico 2 + PCB flexible + Diodo)
- Fácilmente disponible
- No es necesario soldar directamente al GameCube
- Soldadura sencilla
- Opciones alternativas de instalación: [Panasonic Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option), [perfil bajo](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)

#### Variante sin soldadura
- Sin soldadura
- PCB flexible fácilmente reemplazable
- Preprogramado con firmware PicoLoader y [Swiss](https://github.com/emukidid/swiss-gc)
> [!TIP]
> Puedes comprar la variante sin soldadura y la normal en [store.makstech.io](https://store.makstech.io/).

## Funciones planeadas
*sonido de grillos*

## Instalación y Documentación
> [!IMPORTANT]
> Por favor, siga las [instrucciones de instalación](https://makeo.github.io/PicoLoader/) en el wiki.\
> Al no seguir las instrucciones, existe la posibilidad de dañar la PCB flexible durante la instalación.

Comience mirando el 📖[Wiki](https://github.com/makeo/PicoLoader/wiki/1.-Home)!

## Galería

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## Agradecimientos especiales
- [silversteel](https://github.com/silverstee1) por su ayuda, especialmente por fabricar las PCBs flexibles y los soportes
- [TeamOffBroadway](https://github.com/OffBroadway) por la increíble idea de usar una PCB flexible para interceptar las señales del disco
- [Extrems](https://github.com/Extrems), [emukidid](https://github.com/emukidid) y todos los involucrados en la creación de Swiss
- [novenary (9ary)](https://github.com/9ary) por gekkoboot

## Reconocimientos
La fuente de [gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) y [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr) está bajo licencia GPL-2.0 y disponible [aquí](https://github.com/makeo/cubeboot-tools)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---