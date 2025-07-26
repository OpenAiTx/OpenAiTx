<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simula e visualizza buchi neri di Schwarzschild, basandosi sui metodi descritti in Luminet (1979).

![Esempio di grafico di un buco nero](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Installazione
`luminet` è disponibile su PyPI:

```shell
pip install luminet
```

## 📖 [Documentazione](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Utilizzo

Tutte le variabili in questo repository sono espresse in unità naturali: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Per creare un'immagine:
```python
ax = bh.plot()          # Create image like above
```

Per campionare i fotoni sul disco di accrescimento:
```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Nota che il campionamento è orientato verso il centro del buco nero, poiché è da lì che proviene la maggior parte della luminosità.


## 📝 Contesto
I buchi neri di Schwarzschild hanno un'orbita interna stabile a $6M$, e una sfera dei fotoni a $3M$. Questo significa che
il disco di accrescimento che orbita attorno al buco nero emette fotoni a raggi $r>6M$. Finché il perielio del fotone nello spazio curvo rimane maggiore di $3M$ (chiamata anche sfera dei fotoni), il fotone non viene catturato dal buco nero e può teoricamente essere visto da qualche sistema di riferimento dell'osservatore $(b, \alpha)$. La curvatura dello spaziotempo è più facilmente interpretata come un effetto lente tra il sistema di riferimento del buco nero $(r, \alpha)$ e quello dell'osservatore $(b, \alpha)$. I primi sono coordinate polari 2D che coprono l'area del disco di accrescimento, i secondi sono coordinate polari 2D che coprono la "lastra fotografica" del sistema di riferimento dell'osservatore. Immagina questi ultimi come una vera e propria fotocamera CCD. Il perielio dell'orbita del fotone e il raggio nel sistema di riferimento dell'osservatore $b$ sono direttamente correlati:

$$b^2 = \frac{P^3}{P-2M}$$

Questo rende molte equazioni significativamente più semplici.
Potresti notare che questa equazione ha un quadrato sul lato sinistro, a differenza di Luminet (1979). Il manoscritto originale contiene alcuni errori di notazione. Ho contattato l'autore a riguardo, al che ha gentilmente risposto:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"All'epoca non avevo ancora l'abitudine di rileggere attentamente le bozze. Fortunatamente, ho comunque fatto i calcoli con le formule giuste, altrimenti l'immagine non sarebbe stata corretta!".

Solo per farti sapere. Ho cercato di essere diligente nel segnalare dove questo codice differisce dall'articolo.

La relazione tra gli angoli dei due sistemi di coordinate è banale, ma la relazione tra i raggi nei due sistemi di riferimento è data dalla mostruosa Equazione 13:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Qui, $F$ è un integrale ellittico incompleto di Jacobi di prima specie, $k$ e $Q$ sono una funzione del perielio $P$, $\zeta$ sono funzioni trigonometriche di $P$, e $\gamma$ soddisfa:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Nello spaziotempo curvo, di solito ci sono molteplici orbite di fotoni che originano dalla stessa coordinata e si proiettano nel sistema di riferimento dell'osservatore (vedi ad es. lensing gravitazionale e croci di Einstein). Le orbite dei fotoni che girano attorno al buco nero e raggiungono il sistema di riferimento dell'osservatore sono chiamate immagini "di ordine superiore", o immagini "fantasma". In questo caso, $\gamma$ soddisfa:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Questi fotoni fantasma sono quelli che vedi nella metà inferiore dell'immagine sopra, così come l'alone di luce appena visibile che avvolge sottilmente la sfera dei fotoni. Per inclinazioni meno di taglio, questa immagine fantasma è però meno evidente.

Questo repository utilizza `scipy.optimize.brentq` per risolvere queste equazioni, e fornisce una comoda API ai concetti presentati in Luminet (1979). La classe `BlackHole` è quella più ovvia, ma è anche istruttivo sperimentare ad esempio con la classe `Isoradial`: linee nel sistema di riferimento dell'osservatore che descrivono fotoni emessi dallo stesso raggio nel sistema di riferimento del buco nero. La classe `Isoredshift` fornisce linee di uguale redshift nel sistema di riferimento dell'osservatore.

## 📕 Bibliografia
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---