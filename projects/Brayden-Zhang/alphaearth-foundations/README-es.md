# Fundaciones AlphaEarth

Una implementación en PyTorch del modelo fundamental geoespacial AlphaEarth de Google DeepMind, que genera incrustaciones de la Tierra para la monitorización y análisis ambiental global.  
Acompañando al artículo hay un conjunto de datos global de incrustaciones desde 2017 hasta 2024, disponible a través de Earth Engine. El objetivo de estas incrustaciones es servir como una representación geoespacial altamente general para una gran cantidad de aplicaciones posteriores, sin necesidad de reentrenamiento.  

> [!NOTA]  
> Este modelo está en desarrollo y no fue entrenado con el conjunto de datos completo, es solo un marco que proporciona una base general para la arquitectura del artículo. El código está simplificado en comparación con la implementación real de DeepMind (en JAX).  

### Partes clave de la metodología

- **Soporte de Tiempo Continuo**: Primer enfoque de caracterización EO que soporta tiempo continuo, permitiendo interpolación y extrapolación temporal.  
- **Arquitectura de Precisión Espacio-Tiempo (STP)**: Codificador multiresolución con operadores espaciales (1/16L), temporales (1/8L) y de precisión (1/2L), diseñado para mantener representaciones localizadas mientras modela relaciones a larga distancia en tiempo y espacio.  
- **Incrustaciones von Mises-Fisher**: Incrustaciones de 64 bytes distribuidas en la esfera unitaria S^63, representación muy compacta.  


## Arquitectura

### Codificador de Precisión Espacio-Tiempo (STP)

El codificador STP procesa datos multitemporales y multisource mediante tres operadores simultáneos:  
- **Operador Espacio**: Autoatención espacial tipo ViT (resolución 1/16L)  
- **Operador Tiempo**: Autoatención axial temporal (resolución 1/8L)  
- **Operador Precisión**: Convoluciones 3x3 (resolución 1/2L)  

### Marco Maestro-Estudiante-Texto

1. **Modelo Maestro de Incrustación de Video**: Modelo principal con decodificadores implícitos  
2. **Modelo Estudiante de Incrustación de Video**: Comparte parámetros con el maestro para aprendizaje contrastivo  
3. **Modelo de Alineación de Texto**: Habilita aprendizaje contrastivo texto-imagen  


## Fuentes de Datos

El modelo se entrena con muchas fuentes de datos incluyendo:  
- **Óptico**: Sentinel-2, Landsat 8/9. *Nota: por simplicidad, mi implementación solo soporta Sentinel-2, pero debería ser relativamente sencillo añadir nuevos conjuntos de datos para el entrenamiento*  
- **Radar**: Sentinel-1, PALSAR2  
- **LiDAR**: GEDI  
- **Ambiental**: GLO-30, ERA5-Land, GRACE  
- **Anotado/Texto**: NLCD, Wikipedia  

## Instalación

```bash
# Clone the repository
git clone https://github.com/brayden-zhang/alphaearth-foundations.git
cd alphaearth-foundations

# Install dependencies
uv pip install -r requirements.txt

# Install the package 
uv pip install -e .
```
Cómo ejecutar un paso de entrenamiento:

```
python -m alphaearth.run_train
```

## Cita del artículo

```bibtex
@misc{brown2025alphaearthfoundationsembeddingfield,
      title={AlphaEarth Foundations: An embedding field model for accurate and efficient global mapping from sparse label data}, 
      author={Christopher F. Brown and Michal R. Kazmierski and Valerie J. Pasquarella and William J. Rucklidge and Masha Samsikova and Chenhui Zhang and Evan Shelhamer and Estefania Lahera and Olivia Wiles and Simon Ilyushchenko and Noel Gorelick and Lihui Lydia Zhang and Sophia Alj and Emily Schechter and Sean Askay and Oliver Guinan and Rebecca Moore and Alexis Boukouvalas and Pushmeet Kohli},
      year={2025},
      eprint={2507.22291},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2507.22291}, 
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-01

---