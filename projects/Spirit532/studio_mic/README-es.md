# Micrófono de condensador simple y de alta calidad por menos de $100

Necesitaba un micrófono de buena calidad, pero todas las opciones disponibles eran un poco caras o simplemente no tenían buen rendimiento, así que decidí construir el mío propio.

La construcción del micrófono utiliza una cápsula clon RK12/CK12 ($40-50 en Aliexpress/Ebay/etc, busca "edge terminated capsule"), un cuerpo donante U87 ($15-30, también en Aliexpress, término de búsqueda "U87 mic"), y una placa de preamplificador personalizada ($20-30, este proyecto).

La placa es muy simple, pero de alto rendimiento: usa un amplificador operacional con entrada de FET dual en un solo paquete para convertir la impedancia de la cápsula y proporcionar una señal diferencial, mientras que la polarización la proporciona una bomba de carga con inversor hexagonal Schmitt ligeramente maldita.

Con la configuración que se muestra abajo, los resultados son, para el oído no audiófilo, perfectos. Prácticamente no hay ruido propio debido a la simplicidad del circuito y al rendimiento del amplificador operacional elegido, mucho rango dinámico y ninguna distorsión/"coloración" de la señal. Obtienes exactamente lo que la cápsula ve en el conector XLR.

#### Notas sobre la elección de componentes
  1. Puedes usar prácticamente cualquier amplificador operacional con entrada FET, **sin embargo** debes prestar mucha atención a la corriente en reposo. Este circuito usa un camino de alimentación de impedancia bastante alta, y el estándar de alimentación phantom no puede proporcionar mucha corriente inicialmente. El consumo total de energía de los dos amplificadores no debería superar ~7-8mA (3.5-4mA por cada uno).

  2. Lo mismo aplica para el inversor hexagonal en términos de consumo de energía, pero por lo demás cualquiera servirá. Puedes sustituir la pieza por cualquier clon 40106 de funcionalidad similar.
  
  3. Ten cuidado de comprar capacitores con alta tensión nominal donde se especifique, ¡esto es importante! Los capacitores cerámicos pierden capacitancia a voltajes más altos, así que se prefieren capacitores clase X7R con una tensión nominal de 100V o más (esto no resolverá explícitamente la reducción de capacitancia, pero ayudará). Todos los valores están disponibles fácilmente en tamaño 0805, así que no es un problema.

  4. Elige capacitores NP0/C0G para cerámicos si tu presupuesto lo permite. Mejorarán un poco el rendimiento, pero no mucho. (esto resolverá la reducción de capacitancia, pero a un costo significativo)
  
El diseño está licenciado bajo la licencia MIT. Si quieres construirlo, adelante. Si quieres venderlo, también adelante, pero solo menciona esta página o algo similar. Prácticamente nada de esto es realmente original y se ha hecho docenas de veces (por ejemplo DJJules/Sound Sleuth en Instructables, de cuyo circuito me inspiré), solo le di mi propio giro.

#### Nota importante sobre cuerpos donantes baratos
La mayoría de los cuerpos donantes baratos vienen pre-anodizados o incluso pre-pintados, incluyendo las superficies de contacto en puntos de separación (cubierta del circuito, jaula de cabeza, tuerca, separadores, etc), __asegúrate de lijarlos__ para exponer el metal, ¡o captarás mucho zumbido de la red eléctrica y otros ruidos eléctricos externos!


## Obtén la placa
Si no puedes fabricar o ensamblar la placa tú mismo... bueno, eh, buena suerte, pero la mayoría de las casas de montaje en China las harán por ti por muy poco dinero.
Tenía un enlace afiliado de PCBWay aquí, pero ya no recomendaría tratar con ellos.

## Esquemático
(también disponible en pdf o fuentes KiCad 7, ver archivos)

![Esquemático](https://raw.githubusercontent.com/Spirit532/studio_mic/main/sch_img.png)

## Renderizado de PCB
![Render](https://raw.githubusercontent.com/Spirit532/studio_mic/main/render.png)

## Placa ensamblada, versión casera de una sola capa (hecha en casa)
![Construcción](https://raw.githubusercontent.com/Spirit532/studio_mic/main/build.jpg)

## Cápsula montada en el cuerpo del donante
![Cápsula](https://raw.githubusercontent.com/Spirit532/studio_mic/main/capsule.png)

## Cuerpo del donante clon U87
![Donante](https://raw.githubusercontent.com/Spirit532/studio_mic/main/donor.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-05

---