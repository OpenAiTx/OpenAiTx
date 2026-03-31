# Avalonia Progress Ring

[![NuGet](https://img.shields.io/nuget/v/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/vpre/Deadpikle.AvaloniaProgressRing.svg?style=flat-square&label=nuget-pre)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/nuget/dt/Deadpikle.AvaloniaProgressRing.svg?style=flat-square)](https://www.nuget.org/packages/Deadpikle.AvaloniaProgressRing/) [![NuGet](https://img.shields.io/github/issues/Deadpikle/AvaloniaProgressRing.svg?style=flat-square)](https://github.com/Deadpikle/AvaloniaProgressRing/issues/)


Este proyecto es un anillo de progreso simple para Avalonia basado en el anillo de progreso de [ModernWpf](https://github.com/Kinnara/ModernWpf). ¡Crédito a ModernWpf por el código y diseño inicial! La versión v0.8.x funciona en Avalonia 0.9.x, y la v0.9.x es compatible con Avalonia 0.10.x. La v0.10.x es compatible con Avalonia 11 Preview 2+ (las compilaciones 0.10.7+ funcionan en Avalonia 11.1+). La v0.11.x es compatible con Avalonia 12 Preview 1.

![Progress Ring GIF](https://raw.githubusercontent.com/Deadpikle/AvaloniaProgressRing/develop/img/avalonia-60-fps.gif)

## Uso en tu proyecto

Agrega `Deadpikle.AvaloniaProgressRing` a tus referencias de NuGet, luego añade lo siguiente a tu `App.xaml` en `Application.Styles`:

```xml
<StyleInclude Source="avares://AvaloniaProgressRing/Styles/ProgressRing.xaml"/>
```

En su `UserControl`, agregue lo siguiente:

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

¡Asegúrate de enlazar a `IsActive` para mostrar/ocultar el anillo de progreso!

## Contribuciones

¡Todas las contribuciones y mejoras son bienvenidas! ¡Gracias por tu participación!

## Licencia

MIT. ¡Gracias!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-31

---