# systemd Pilot

systemd Pilot es una aplicación de escritorio para gestionar servicios systemd en sistemas GNU/linux. se puede describir como una interfaz gráfica para systemctl. 

![image](https://github.com/user-attachments/assets/85ee68be-aa3e-4291-8435-ef9ee7b8b72f)


![Screenshot From 2024-12-31 11-26-27](https://github.com/user-attachments/assets/09a58f8c-7d2b-4bc3-87db-561221295b18)


![Screenshot From 2024-12-31 11-28-58](https://github.com/user-attachments/assets/1c5653ab-31bc-4fd1-b607-1240dd85f831)


![Screenshot From 2024-12-31 11-29-24](https://github.com/user-attachments/assets/b9eb7194-b3dc-4c17-8ecc-8946374a2ca1)

![Screenshot From 2024-12-31 11-29-41](https://github.com/user-attachments/assets/2715e99c-2a96-406b-9d55-4f3512bbc345)


## Características
- Listar servicios del sistema en la máquina local o en hosts remotos
- Desplegar rápidamente un nuevo servicio usando una plantilla
- Iniciar, Detener, Reiniciar servicios, mostrar estado
- Búsqueda fácil. Solo empieza a escribir y la app encontrará servicios relevantes
- Ligero y con bajo consumo de recursos del sistema (solo un script Python)
  
## Descarga
- Descarga desde la sección de [releases](https://github.com/mfat/systemd-pilot/releases) el paquete para tu distribución.
  
## Requisitos
Si prefieres ejecutar el script python directamente, aquí están los requisitos:

Módulos Python:
- PyGObject>=3.42.0
- paramiko>=3.0.0
- keyring>=24.0.0
- rich>=13.0.0
- PyYAML

Dependencias Debian:
- `sudo apt install 
    python3-gi 
    python3-gi-cairo 
    gir1.2-gtk-3.0 
    gir1.2-gtksource-4 
    python3-paramiko 
    python3-yaml 
    python3-keyring`
  
Dependencias para Fedora/RHEL:
- `sudo dnf install python3
      python3-gobject
      python3-paramiko
      python3-keyring
      python3-rich
      python3-cairo
      python3-gobject
      python3-dbus
      python3-secretstorage
      gtk4
      libadwaita
      gtksourceview4
      systemd`
  


## Apoya el desarrollo
Bitcoin:`bc1qqtsyf0ft85zshsnw25jgsxnqy45rfa867zqk4t`

Doge:`DRzNb8DycFD65H6oHNLuzyTzY1S5avPHHx`

  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-09

---