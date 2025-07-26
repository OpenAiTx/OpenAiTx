<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simule e visualize buracos negros de Schwarzschild, com base nos métodos descritos em Luminet (1979).

![Exemplo de gráfico de um buraco negro](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Instalação
`luminet` está disponível no PyPI:

```shell
pip install luminet
```

## 📖 [Documentação](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Uso

Todas as variáveis neste repositório estão em unidades naturais: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Para criar uma imagem:
```python
ax = bh.plot()          # Create image like above
```
Para amostrar fótons no disco de acreção:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Observe que a amostragem é tendenciosa em relação ao centro do buraco negro, pois é de lá que vem a maior parte da luminosidade.


## 📝 Contexto
Buracos negros de Schwarzschild possuem uma órbita estável mais interna em $6M$ e uma esfera de fótons em $3M$. Isso significa que o disco de acreção orbitando o buraco negro emite fótons em raios $r>6M$. Enquanto o periélio do fóton no espaço curvo permanecer maior que $3M$ (também chamado de esfera de fótons), o fóton não é capturado pelo buraco negro e pode, em teoria, ser visto de algum referencial do observador $(b, \alpha)$. A curvatura do espaço-tempo é mais facilmente interpretada como um efeito de lente entre o referencial do buraco negro $(r, \alpha)$ e o referencial do observador $(b, \alpha)$. Os primeiros são coordenadas polares 2D que abrangem a área do disco de acreção, e os últimos são coordenadas polares 2D que abrangem a "placa fotográfica" do referencial do observador. Pense nestes últimos como uma câmera CCD literal. O periélio da órbita do fóton e o raio no referencial do observador $b$ estão diretamente relacionados:

$$b^2 = \frac{P^3}{P-2M}$$

Isso torna muitas equações consideravelmente mais diretas.
Você pode notar que essa equação tem um quadrado no lado esquerdo, em contraste com Luminet (1979). O manuscrito original tem alguns erros de notação. Entrei em contato com o autor sobre isso, ao que ele gentilmente respondeu:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"Na época, eu ainda não tinha o hábito de reler cuidadosamente as provas. Felizmente, fiz os cálculos com as fórmulas corretas, senão a imagem não estaria certa!".

Apenas para você saber. Procurei ser diligente ao apontar onde este código difere do artigo.

A relação entre os ângulos de ambos os sistemas de coordenadas é trivial, mas a relação entre os raios nos dois referenciais é dada pela monstruosa Equação 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Aqui, $F$ é uma integral elíptica incompleta de Jacobi do primeiro tipo, $k$ e $Q$ são funções do periélio $P$, $\zeta$ são funções trigonométricas de $P$, e $\gamma$ satisfaz:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

No espaço-tempo curvo, normalmente há múltiplas órbitas de fótons que se originam da mesma coordenada e se projetam no referencial do observador (ver, por exemplo, lente gravitacional e cruz de Einstein). Órbitas de fótons que contornam o buraco negro e chegam ao referencial do observador são chamadas de imagens de "ordem superior" ou imagens "fantasmas". Neste caso, $\gamma$ satisfaz:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Esses fótons fantasmas são o que você vê na metade inferior da imagem acima, assim como o halo de luz quase invisível que se enrola finamente ao redor da esfera de fótons. Para inclinações menos próximas da linha de visão, essa imagem fantasma é menos pronunciada.

Este repositório usa `scipy.optimize.brentq` para resolver essas equações e fornece uma API conveniente para os conceitos apresentados em Luminet (1979). A classe `BlackHole` é a mais óbvia, mas também é educativo brincar, por exemplo, com a classe `Isoradial`: linhas no referencial do observador descrevendo fótons emitidos do mesmo raio no referencial do buraco negro. A classe `Isoredshift` fornece linhas de igual desvio para o vermelho no referencial do observador.

## 📕 Bibliografia
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---