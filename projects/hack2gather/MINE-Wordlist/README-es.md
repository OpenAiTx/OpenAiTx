# jerry-list

Una lista de palabras seleccionada y refinada mediante la caza de recompensas de bugs en el mundo real. Esta es mi colección personal que he estado usando de forma privada durante mucho tiempo y que ahora se publica públicamente para ayudar a la comunidad de seguridad.

---

## Qué es esto

jerry-list es la lista de palabras principal en este repositorio, cubriendo una amplia gama de rutas, parámetros, endpoints y patrones que han demostrado ser efectivos en la caza activa de recompensas de bugs. Cada entrada en esta lista ha sido moldeada por experiencia real de compromiso, no solo por generación automática o fuentes públicas recicladas. Esta es la lista que me ayudó a conseguir múltiples hallazgos P1 y P2 en varios programas.

También está en camino una lista privada de DNS. Esa lista es algo en lo que he confiado mucho para descubrir subdominios únicos que la mayoría de las herramientas convencionales y listas públicas de palabras pasan completamente por alto. Se publicará aquí una vez que esté limpia y lista para su lanzamiento.

---

## Contenidos

| Archivo | Descripción |
|---|---|
| jerry-list.txt | Lista principal para fuzzing de directorios, rutas y endpoints |
| jerry-dns.txt | Lista de palabras para subdominios DNS — próximamente |

---

## Uso

Funciona con cualquier herramienta estándar de fuzzing. Algunos ejemplos rápidos:

**ffuf**
```bash
ffuf -u https://target.com/FUZZ -w jerry-list.txt -mc 200,301,302,403,500
```

**gobuster**
```bash
gobuster dir -u https://target.com -w jerry-list.txt
```

**subfinder / fuerza bruta DNS (una vez que se obtiene la lista DNS)**
```bash
puredns brute target.com -w jerry-dns.txt
```

---

## Resultados

Estas listas de palabras han contribuido directamente a encontrar múltiples vulnerabilidades P1 y P2 a lo largo de mi trayectoria en bug bounty. La lista DNS en particular ha sido una de mis herramientas más constantes para descubrir subdominios únicos que conducen a hallazgos de alto impacto.

---

## Próximamente

- jerry-dns.txt — lanzamiento privado de lista de palabras DNS
- Posible lista de fuzzing de parámetros basada en parámetros observados reales

---

## Contribuciones

Esta es una lista personal, por lo que no estoy aceptando pull requests en este momento. Si encuentras algo útil o detectas un fallo usando esta lista, siéntete libre de dejar una estrella o contactarme.

---

## Descargo de responsabilidad

Estas listas de palabras están destinadas únicamente para pruebas de seguridad autorizadas y programas de bug bounty. Úsalas solo contra objetivos para los que tengas permiso explícito de prueba. El autor no se responsabiliza por ningún uso indebido.

---

## Autor

--**Jerry1319**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---