# Fava Investor

Fava Investor tiene como objetivo ser un conjunto completo de informes, análisis y herramientas para
inversiones, para [Beancount](https://beancount.github.io/) y
[Fava](https://github.com/beancount/fava) (software para
[contabilidad de partida doble en texto plano](https://plaintextaccounting.org/)). Se desarrolla como una
colección de módulos, donde cada módulo ofrece un *plugin de Fava, una biblioteca de Beancount y
un comando de shell*.

### Módulos actuales:
- [Visualización, asignación de activos estructurada en árbol por clase](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/assetalloc_class#readme)
- Asignación de activos por cuenta
- [Recolección de pérdidas fiscales](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/tlh#readme)
- [Análisis de arrastre de efectivo](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/cashdrag#readme)
- [Resumidor](https://github.com/redstreet/fava_investor/tree/main/fava_investor/modules/summarizer#readme)
- [Minimizador de ganancias](https://github.com/redstreet/fava_investor/blob/main/fava_investor/modules/minimizegains#readme)

### Demostración
***Prueba la demo en vivo en
  [pythonanywhere](http://favainvestor.pythonanywhere.com/example-beancount-file/extension/Investor/)***.


#### Capturas de pantalla (fechadas):
![Captura de pantalla: TLH](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot.png)
![Captura de pantalla: Asignación de activos](https://raw.githubusercontent.com/redstreet/fava_investor/main/./screenshot-assetalloc.png)

### Utilidades

Fava Investor incluye `ticker-util`, que es una colección de utilidades para:
- descargar información de Yahoo para commodities (símbolos), y anotar tus
  declaraciones de commodities con metadatos
- descubrir relaciones entre símbolos en tu archivo Beancount, tales como símbolos equivalentes
  y sustancialmente idénticos, y grupos de socios para recolección de pérdidas fiscales, a partir de una
  especificación mínima e incompleta
- proporcionar ISIN y otra información identificativa de símbolos a tus importadores

Para más información, instala fava_investor vía pip, y luego consulta:
```
ticker-util --help
ticker-util relate --help
```


## Instalación
```bash
pip3 install fava-investor
```

O para instalar la versión más avanzada directamente desde git:
```bash
pip3 install git+https://github.com/redstreet/fava_investor
```
Consulte [#55](https://github.com/redstreet/fava_investor/issues/55) para la instalación en MacOS.

Tenga en cuenta que la última versión de Fava Investor es compatible con Beancount v2 y v3.

## Ejecutando Fava Investor
### Ejecutando en Fava:
Agregue esto a su fuente de beancount, y inicie fava como de costumbre:
```
2000-01-01 custom "fava-extension" "fava_investor" "{}"
```

Ahora debería ver un enlace 'Inversor' en la barra lateral de fava. Para más información sobre cómo
configurar la extensión, consulte el archivo `huge-example.beancount` incluido.

### Ejecución desde la Línea de Comandos:
La interfaz de línea de comandos (CLI) se accede usando el comando `investor`, que tiene
subcomandos para cada módulo. Por ejemplo:

```
investor assetalloc-class
investor tlh
investor --help
```
Tanto la CLI como la utilidad (`ticker-util`) usan [click](https://click.palletsprojects.com/en/8.1.x/).
[Ver aquí](https://click.palletsprojects.com/en/8.1.x/shell-completion/#enabling-completion)
para habilitar la finalización en shell en zsh, bash o fish, lo cual es altamente recomendado.

## ¿Problemas?
- Supervisa la terminal desde la que ejecutas fava para buscar salidas de error de
  fava_investor
- Incluye los mensajes de error que veas arriba al abrir reportes de errores o pedir ayuda

## Contribuir

Características, correcciones y mejoras son bienvenidas. Recuerda:
- No dudes en enviar solicitudes de extracción. Por favor incluye pruebas unitarias
- Para cambios grandes o que puedan necesitar discusión, por favor contacta y discute
  primero para ahorrar tiempo (abre un issue)
- Por favor aplana tus commits (de manera razonable)
- Usa [commits convencionales](https://www.conventionalcommits.org/en/v1.0.0/) para los mensajes de commit

¡Gracias por contribuir!

## Proyectos Relacionados
- [Fava Dashboards](https://github.com/andreasgerstmayr/fava-dashboards)
- [Fava Portfolio Returns](https://github.com/andreasgerstmayr/fava-portfolio-returns)
- [Beangrow](https://github.com/beancount/beangrow)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---