## Antispam para Telegram

Inicialmente fue desarrollado para resolver el problema de los spammers en los chats de Vastrik.Club, pero también puede usarse en chats de otros forks, o simplemente en cualquier chat grande.

### Principio de funcionamiento
- Los usuarios del Club con bot vinculado se añaden automáticamente a la lista de confianza
- Al evento "usuario entró al chat" se emite un captcha sencillo
- Si el usuario ya está en la lista de confianza, se omiten todas las comprobaciones
- Si el usuario está en listas conocidas de spammers - fuera
- Si el mensaje tiene muchos emojis - fuera
- Si el mensaje contiene palabras que se disfrazan de rusas pero tienen letras inglesas dentro - fuera. Este aspecto está ajustado principalmente para chats en ruso y puede activarse con palabras normales de idiomas que usan cirílico, pero todos los casos conocidos ya están añadidos en pruebas.
- Si el mensaje contiene palabras prohibidas como "ganancias en la red" - fuera
- Luego el mensaje se limpia de emojis, puntuación, diacríticos y se procesa con ML. Si ML considera que es spam - fuera.
- Si el usuario envió varios mensajes normales, se añade a la lista de confianza - los spammers rara vez "se ganan la confianza" y usualmente se delatan en el primer o segundo mensaje
- El bot solo elimina mensajes automáticamente, los usuarios se baneán manualmente desde la administración para reducir daños por falsos positivos
- - Excepto la lista negra. Estos se banean inmediatamente, pero se puede desactivar
- Si alguien en el chat fue baneado no por el bot, llega una notificación a la administración; puede que el bot haya pasado spam y se debería añadir al dataset

### Comandos de administración
Todos los comandos se llaman como respuesta a otro mensaje
- /spam - añade el mensaje al dataset de spam
- /ham - añade el mensaje al dataset de no-spam
- /check - pasa el mensaje por todas las verificaciones

### Configuración
Creamos un chat de administración, recordamos el ID.
Variables de entorno:
- DOORMAN_BOT_API: Token del bot de Telegram. Obligatorio
- DOORMAN_ADMIN_CHAT: ID del chat de administración. Obligatorio
- DOORMAN_CLUB_SERVICE_TOKEN: Token de servicio para el Club, creado aquí: https://vas3k.club/apps/. Si la variable no está definida, se omite la aprobación automática de personas del Club.
- DOORMAN_CLUB_URL: URL base para forks del Club, por ejemplo https://rationalanswer.club/
- DOORMAN_BLACKLIST_AUTOBAN_DISABLE: Poner en true o 1 para que el bot no banee personas (no del Club, no aprobadas, de la lista negra) al entrar inmediatamente
- DOORMAN_LOW_CONFIDENCE_HAM_ENABLE: Poner en true o 1 para enviar a administración no-spam con baja confianza, útil para chats donde los spammers prueban la calidad del ML
- DOORMAN_CHANNELS_AUTOBAN_DISABLE: Poner en true o 1 para que el bot no banee mensajes de canales (excepto los vinculados al grupo actual)
- DOORMAN_APPROVE_BUTTON: Poner en true o 1 para añadir a cada mensaje eliminado la opción "es propio, conocido, habitual"
- DOORMAN_LOOKALIKE_AUTOBAN_DISABLE: Poner en true o 1 para que el bot no banee mensajes con palabras que simulan ser rusas
- DOORMAN_BUTTON_AUTOBAN_DISABLE: Poner en true o 1 para que el bot no banee mensajes que contienen botones
- DOORMAN_HIGH_CONFIDENCE_AUTOBAN_DISABLE: Poner en true o 1 para que el bot no banee mensajes donde el clasificador ML tiene alta confianza de spam
- DOORMAN_CHANNEL_AUTOBAN_EXCLUSION: Grupos separados por coma donde los canales no se banean

#### Gracias
- https://lols.bot/ por la lucha contra los spammers y la API para listas de bloqueo
- https://github.com/umputun/tg-spam/ por algunas ideas y tres cuartas partes del conjunto de datos

### Traducción
Si estás dispuesto a hacer el trabajo pesado de traducir todo el texto de este bot a otros idiomas, por favor avísame primero antes de lanzarte de cabeza y crear un PR.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---