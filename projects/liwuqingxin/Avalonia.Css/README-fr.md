<div align="left">
  <a href="https://github.com/microsoft/dotnet">
    <img src="https://img.shields.io/badge/-.NET-red">
  </a>
  <a href="https://avaloniaui.net/">
    <img src="https://img.shields.io/badge/Avalonia-8245A9">
  </a>
  <a href="https://dotnet.microsoft.com/zh-cn/languages/csharp">
    <img src="https://img.shields.io/badge/-C%23-yellow">
  </a>
  <a href="http://www.gnu.org/licenses/mit.en.html">
    <img src="https://img.shields.io/badge/License-MIT-green">
  </a>
</div>
<br/><br/>

![acss-brand](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/img/AcssText.svg)

Avalonia Css, ou Acss en abrégé, ne suit pas le CSS standard (Cascading Style Sheets). Il est conçu pour **séparer les définitions structurelles et visuelles** de l’interface Avalonia et permettre à Avalonia de **modifier rapidement les styles de manière dynamique**.

Oui, il suit un modèle similaire à **Html+CSS**.

# Promotion

J’ai récemment découvert une bibliothèque de contrôles Avalonia qui suit le style Ant Design — elle est remarquablement bien conçue. Après avoir parlé avec le développeur principal, nous avons convenu de nous soutenir mutuellement par une promotion croisée. Si cela vous intéresse, n’hésitez pas à la découvrir [ici](https://github.com/chinware/AtomUI).

![](https://github.com/chinware/AtomUI/blob/develop/resources/images/readme/AtomUIOSS.png)


![](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

Un grand merci à Jet Brains pour les [outils de développement gratuits](https://www.jetbrains.com/community/opensource/?utm_campaign=opensource&utm_content=approved&utm_medium=email&utm_source=newsletter&utm_term=jblogo#support).

# Fonctionnalités

- Séparation de la structure et du style
- Réutilisation de la structure
- Chargement dynamique
- Chargement à chaud
- Interception et filtrage
- Extensions comportementales  
- Extensions de syntaxe  
- Débogage de style  
- Dessin personnalisé  

# Documentation  

La documentation est disponible [ici](https://docs.en.avalonia.css.nlnet.net/documentation/readme). Notez que la documentation en anglais est traduite du chinois par DeepL. Si vous rencontrez un problème, vous êtes invités à la modifier sur GitHub.  

> Pour la documentation en chinois, veuillez consulter [ici](https://docs.avalonia.css.nlnet.net/documentation/readme).  

# Utilisation  

Veuillez consulter [ici](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss) pour l’utilisation d’Acss.  

# Contribution  

Nous espérons que davantage de partenaires intéressés pourront nous rejoindre pour créer Acss, le rendant plus dynamique et performant.  

Si vous souhaitez participer ou avez des idées, suggestions ou retours, veuillez envoyer un email à yangqi1990917@163.com.  

# Vitrine  

Nous proposons un thème Fluent pour les contrôles Avalonia propulsé par Acss. Plus d’informations sur le thème sont disponibles sur [Acss.Fluent](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss.fluent).  

Découvrez plus sur la vitrine Acss sur [bilibili](https://space.bilibili.com/1117754194/channel/seriesdetail?sid=3739599) ou [youtube](https://www.youtube.com/channel/UCYvEgvGj-JVYZrOrup3aoBQ).  

<br/>  

![fluent ui](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/./img/fluent-ui.png)  

# Pourquoi utiliser Acss  

> Thème = Structure + Styles  

Imaginez que nous disposons d’une bibliothèque de contrôles standard, où les fonctionnalités de ses contrôles dépendent de la structure interne de leurs templates. Si nous voulons modifier l’apparence des contrôles, nous devons généralement réécrire tous leurs ControlTheme. Cela signifie qu’il faut réécrire la structure du contrôle ainsi que les styles, voire les ressources. C’est un travail laborieux.  

Imaginez qu’avec le modèle Acss, nous extrayons les styles des thèmes standards des contrôles, ne conservant que la structure de base, le ControlTemplate. Toute bibliothèque peut se baser sur ces structures standards, définir sa propre bibliothèque Acss pour obtenir l’apparence souhaitée des contrôles. Les créateurs de ces bibliothèques n’ont pas à copier péniblement le code ControlTheme existant pour des modifications. Ils n’ont pas à se soucier de la validité du template du contrôle. La seule chose qui importe est d’ajuster les styles selon la conception UI !  

> Une concentration continue rend notre travail plus fluide, plus élégant et plus efficace.
Un autre cas est lorsque nous créons une nouvelle page, le flux de travail traditionnel implique généralement la mise en page, la population du contenu, l’écriture de la logique métier, les ajustements de style et la mise au point basée sur la conception UI.  
C’est typiquement le travail d’un développeur, nécessitant une attention continue jusqu’à la fin de la page.  
Maintenant, avec le modèle Acss, l’approche consisterait à ce que le personnel fonctionnel remplisse le contenu de la page, écrive la logique métier, puis le remette à ceux qui se concentrent sur le visuel pour harmoniser les styles visuels.  

# Packages que nous fournissons  

- **Nlnet.Avalonia.Css**. C’est le cœur d’Acss.  

- **Nlnet.Avalonia.Css.Controls**. Cette bibliothèque fournit des structures pures pour les contrôles d’Avalonia.Controls.  

- **Nlnet.Avalonia.Css.Fluent**. Cette bibliothèque offre une interface Fluent UI pour Avalonia.Controls, Nlnet.Avalonia.Senior et Nlnet.Avalonia.MessageBox.  

- **Nlnet.Avalonia.Css.Behaviors**. Cette bibliothèque fournit des comportements étendus pour Acss.  
- **Nlnet.Avalonia.Senior**. Cette bibliothèque propose des fonctionnalités avancées comme le **défilement fluide** et d’autres fonctionnalités avancées que Avalonia.Controls ne peut pas fournir.  
- **Nlnet.Avalonia.MessageBox**. Cela fournit un contrôle MessageBox qui peut suivre la norme WPF ou Avalonia.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---