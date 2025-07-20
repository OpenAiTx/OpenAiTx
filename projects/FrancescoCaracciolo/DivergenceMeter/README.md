# DivergenceMeter
Analyzing real-world news, tries to estimate the current divergence value of the world in Steins;Gate terms.
<div id="divergence-meter" style="cursor: pointer;">
  <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 1" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 2" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 3" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 4" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 5" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
  <img alt="Digit 6" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="10%">
  <img alt="Digit 7" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="10%">
</div>

- [Website](https://divergence.nyarchlinux.moe)
- [API Documentation](https://divergence.nyarchlinux.moe/docs.html)
- [Features](#features)
- [Screenshots](#screenshots)
- [Worldline Calculation](#worldline-calculation)
- [Python Example](https://github.com/FrancescoCaracciolo/DivergenceMeter/blob/main/src/client/client.py)
- [Credits](#credits)

## Features

- <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/11.gif" width="5px" /> <img alt="Digit 0" class="digit" src="https://divergence.nyarchlinux.moe/images/12.gif" width="5px" /> The website can be visited at <a href="https://divergence.nyarchlinux.moe">https://divergence.nyarchlinux.moe</a>. 
- 🔄 **Auto Updated**: the counter updates itself every 15 minutes
- 🗞 **News Table**: see how our world news affect the timeline
- 📊 **Plot**: displaying the estimations of the worldline over time
- 🔉 **Sound**: Sound from the VN is played when the estimation of the worldline is changed
- 🪶 **Lite mode**: <a href="https://divergence.nyarchlinux.moe/lite.html">a lite mode is available</a>, not displaying the plot that takes resources
- 🛠 **Free & Public API**: Integrate our mesurements in your projects. Create custom widgets, real world divergence meter, apps and much more with it!  
The divergence counter refreshes automatically every 15 minutes. <a href="https://divergence.nyarchlinux.moe/docs.html">API Docs</a>
- ⏳ **Analysis interval**: every 15 minutes, the current world news are analyzed in order to estimate the current worldline divergence

## Screenshots
**Divergence Meter**
![image](https://github.com/user-attachments/assets/4dfacc07-6d5e-4e66-9450-ada057e17725)

**Worldline Status Report**
![image](https://github.com/user-attachments/assets/2ee7c178-d182-4075-a9be-5e298bf83dbb)

**Divergence Plot**
![image](https://github.com/user-attachments/assets/abe100b6-4d88-46de-838a-f2a8227be1aa)

## Worldline calculation
In Steins;Gate, the divergence is calculated using the difference in gravity value between worldlines.
Since I don't have the Reading Steiner (at least to my knowledge), and I have not travelled to any worldline yet, the worldline is **estimated** using 
world news. The news are taken from multiple RSS feeds featuring world news, science news and local news.

**Spoiler Alert**: The equations you are going to see are based on an interpretation on some equations given in Chaos;Head. The equations per-se are not a spoiler, but searching them might result in spoilers to the Chaos;Head Visual Novel. Also, some of these concepts might be lite spoilers to Steins;Gate VNs.

**Note**: some of the theories here are made up in a way that they are coherent with the SciAdv series.

#### Base Theory
**Assumption**: every event $e$ has an independent divergence $d$. It is the worldline in which event $e$ has the strongest attractor. Minor events do not have a proper attractor field, but they influence other worldlines.
For example, in Steins;Gate, the Sern dystopia has an independent divergence of 0. The nearest a worldline is to 0, the quicker it gets to that result.

#### News Analysis
Each news documents that an event $e$ happened. (The fact that a news has been published, can be considered by itself an event $e$).
Each news is categorized in an attractor field (for example $\alpha$, $\beta$,...) based on what is the most likely attractor field it beongs to. Also, to each news is given an impact $Im$, that states how impactful is a news for its attractor field, and a Field attraction $Fa$, that states how near it is to the center of the attraction field.

#### Independent Divergence Calculation
1. In order to calculate the independent divergence of an event $e$, we start from the $Ir2$ equation:

$$Ir2 = fun^{10}*int^{40}$$

That, form Chaos;Head, is the bases equation that causes the world to diverge.
In the VN, the meaning of this equation is not explained (except for the fact that Ir2 means "eyes are two"). Considering that it is related to the Dirac Sea, a possible explaination is the following:
- $Ir$ is the Information Rate of the Vacuum region. Higher information rate implies a more complex and dynamic vacuum structure.
- $fun$ is the Field Uniformity Number. A less uniform field could mean more gradients, potentials, and thus, more energy available for particle creation and interactions. 
- $int$ is the Interconnectedness of Dirac Sea states. This represents the degree to which the negative energy states within the Dirac Sea are linked or correlated. 

We can assume that the divergence $d$ is the result of a change in the vacuum's Information state, since also gravity is affected.
Therefore, we might assume that $d \propto Ir$. There exists some constant $k_1$ such that:

$$d = k_1 * Ir2$$

2. We substitute the given expression for $Ir2$ into our definition of $d$:

  $$d = k_1 \cdot (fun^{10} * int^{40})$$

3. Now, we assume the following relations:
    *   **Impact (`Im`) and Uniformity (`fun`):** A highly impactful news event ($Im$) would disrupt the local vacuum field, decreasing its uniformity ($fun$). We can model this as an inverse relationship:

        $$fun = \frac{C_f}{Im}$$

        Where $C_f$ is a constant.
    *   **Field Attraction ($Fa$) and Interconnectedness ($int$):** A strong attraction ($Fa$) towards the attractor center implies the event $e$ is creating efficient pathways within the Dirac Sea states along that direction, increasing local interconnectedness ($int$). We model this as a direct relationship:

        $$int = C_i \cdot Fa$$

        Where $C_i$ is a constant

4. We substitute the formulas above in the expression
    Substitute the expressions for $fun$ and $int$ (from step 3) into the formula for $d$ (from step 2):
   
    $$d = k_1 \cdot \left( \left( \frac{C_f}{Im} \right)^{10} \cdot (C_i \cdot Fa)^{40} \right)$$

5. In the end, we simplify the expression combining the constants:

    $$d = k_1 \cdot \left( \frac{C_f^{10}}{Im^{10}} \cdot C_i^{40} \cdot Fa^{40} \right)$$

    $$d = (k_1 \cdot C_f^{10} \cdot C_i^{40}) \cdot \frac{Fa^{40}}{Im^{10}}$$

6. We create a new constant, called Divergence Constant $K_d = k_1 \cdot C_f^{10} \cdot C_i^{40}$
    The final formula for calculating the independent divergence $d$ is:
   
    $$d = K_d \frac{Fa^{40}}{Im^{10}}$$

#### Worldline Update
In order to estimate the current worldline, we have to analyze news as soon as they arrive, and update the current divergence based on the independent divergence of those news.
For this purpose, a modified version of Weighted Online Gradient Descent is used.

$$d(t) = d(t-1) - Im * \eta \nabla L(d(t-1))$$

## Credits
- [Steins;Gate Wiki](https://steins-gate.fandom.com/wiki/Steins;Gate_Wiki) for some informations about divergence
- [LuqueDaniel/Divergence-Meter](https://github.com/LuqueDaniel/Divergence-Meter/tree/master) for images and gifs
- [SciAdv Series](https://wikipedia.org/wiki/Science_Adventure) for being peak

If you want to support the project, leave a ⭐️

Made with ❤️ by <a href="https://nyarchlinux.moe">Nyarch Linux</a> lead developer
