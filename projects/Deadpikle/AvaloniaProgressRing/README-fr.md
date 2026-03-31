# Anneau de progression Avalonia

[![NuGet](https://img.shields.io/nuget/v/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/vpre/Deadpikle.AvaloniaProgressRing.svg?style=flat-square&label=nuget-pre)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/dt/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/github/issues/Deadpikle/AvaloniaProgressRing.svg?style=flat-square)](https://github.com/Deadpikle/AvaloniaProgressRing/issues/)


Ce projet est un anneau de progression simple pour Avalonia inspiré de l'anneau de progression de [ModernWpf](https://github.com/Kinnara/ModernWpf). Crédits à ModernWpf pour le code initial et le design ! La version v0.8.x fonctionne avec Avalonia 0.9.x, et la v0.9.x est compatible avec Avalonia 0.10.x. La v0.10.x est compatible avec Avalonia 11 Preview 2+ (0.10.7+ fonctionne avec Avalonia 11.1+). La v0.11.x est compatible avec Avalonia 12 Preview 1.

![GIF de l'anneau de progression](https://raw.githubusercontent.com/Deadpikle/AvaloniaProgressRing/develop/img/avalonia-60-fps.gif)

## Utilisation dans votre projet

Ajoutez `Deadpikle.AvaloniaProgressRing` à vos références NuGet, puis ajoutez ce qui suit à votre `App.xaml` dans `Application.Styles` :

```xml
<StyleInclude Source="avares://AvaloniaProgressRing/Styles/ProgressRing.xaml"/>
```

Dans votre `UserControl`, ajoutez ce qui suit :

```xml
<UserControl xmlns="https://github.com/avaloniaui"
             xmlns:progRing="clr-namespace:AvaloniaProgressRing;assembly=AvaloniaProgressRing">
    <progRing:ProgressRing Width="80" 
                           Height="80"
                           IsActive="True"
                           HorizontalAlignment="Left"
                           VerticalAlignment="Top"
                           Foreground="Green"
                           Margin="10,20,0,0"/>
</UserControl>
```

Assurez-vous de vous lier à `IsActive` pour afficher/masquer l’anneau de progression !

## Contribution

Toutes les contributions et améliorations sont les bienvenues ! Merci pour votre implication !

## Licence

MIT. Merci !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-31

---