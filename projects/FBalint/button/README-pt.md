# Botão 3D Pressionável

Um componente de botão 3D realista construído com HTML, CSS e SVG que simula a sensação de pressionar um botão físico. O botão apresenta animações suaves, cores personalizáveis e interações responsivas.

Criado por [@BalintFerenczy](https://x.com/BalintFerenczy)

Inspirado pelo incrível trabalho em [Resend](https://resend.com/)

## Características

- **Aparência 3D realista** utilizando gráficos SVG em camadas
- **Animações suaves** com funções de easing personalizadas
- **Estados interativos** - efeitos ao passar o mouse e pressionar
- **Cores personalizáveis** por meio de variáveis CSS
- **Design responsivo** que se adapta ao tamanho do contêiner

## Demonstração
O botão responde às interações do usuário com três estados distintos:
- **Normal**: O botão em sua posição de repouso
- **Hover**: Movimento sutil para baixo quando o mouse passa sobre ele
- **Ativo**: Movimento significativo para baixo quando pressionado/clicado

## Uso

### Personalização

O botão pode ser facilmente personalizado usando propriedades personalizadas do CSS:

```css
.frame {
    /* Dimensões do botão */
    width: 400px; 
    height: 400px; 

    /* Distâncias de movimento */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Personalização de cor */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Configurações de transição */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Alterando o Texto do Botão

Basta modificar o conteúdo do texto:

```html
<p class="text">Clique em Mim!</p>
```

#### Alterando o Tamanho do Botão

Ajuste as dimensões do quadro:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licença

Este projeto é open source e está disponível sob a Licença MIT.

## Contribuição

Sinta-se à vontade para fazer um fork deste projeto e enviar pull requests para melhorias ou novos recursos!

## Autor

Criado por [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---