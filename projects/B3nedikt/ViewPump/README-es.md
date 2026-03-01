[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

Inflado de vistas que puedes interceptar usando una API de interceptores pre/post-inflado.

## Comenzando

### Dependencia

Incluye las dependencias:

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### Uso

Define tu interceptor. A continuación se muestra un ejemplo algo arbitrario de un interceptor post-inflado que antepone texto en un TextView.

```java
public class TextUpdatingInterceptor implements Interceptor {

  @Override
  public InflateResult intercept(Chain chain) {
    InflateResult result = chain.proceed(chain.request());
    if (result.view() instanceof TextView) {
      // Do something to result.view()
      // You have access to result.context() and result.attrs()
      TextView textView = (TextView) result.view();
      textView.setText("[Prefix] " + textView.getText());
    }
    return result;
  }
}
```

A continuación se muestra un ejemplo de un interceptor de pre-inflado que devuelve un CustomTextView cuando se definió un TextView en el XML del diseño.

```java
public class CustomTextViewInterceptor implements Interceptor {

  @NotNull
  @Override
  public InflateResult intercept(Chain chain) {
    InflateRequest request = chain.request();
    View view = inflateView(
      request.getName(),
      request.getContext(),
      request.getAttrs()
    );

    if (view != null) {
      return new InflateResult(
        view,
        request.getName(),
        request.getContext(),
        request.getAttrs()
      );
    } else {
      return chain.proceed(request);
    }
  }

  @Nullable
  private View inflateView(String name, Context context, AttributeSet attrs) {
    if ("TextView".equals(name)) {
      return new CustomTextView(context, attrs);
    }
    return null;
  }
}
```

### Instalación

Agregue sus interceptores a `ViewPump.builder()`, en su clase `Application` en el método `#onCreate()` e inicialice el `ViewPump`. El orden de los interceptores es importante ya que forman la cadena de interceptores de solicitudes y resultados.

Un interceptor puede optar por devolver una vista instanciada programáticamente en lugar de permitir que ocurra la inflación predeterminada, en cuyo caso se omitirán los interceptores agregados después de él. Por esta razón, es mejor agregar sus interceptores post-inflación antes que los pre-inflación.

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### Inyectar en el Contexto

Agregue lo siguiente a su actividad base:

```java
public class MainActivity extends AppCompatActivity {

    private AppCompatDelegate appCompatDelegate = null;

    ...

    @NonNull
    @Override
    public AppCompatDelegate getDelegate() {
        if (appCompatDelegate == null) {
            appCompatDelegate = new ViewPumpAppCompatDelegate(
                    super.getDelegate(),
                    this
            );
        }
        return appCompatDelegate;
    }
}
```

Para ejemplos prácticos, vea mis bibliotecas [Restring](https://github.com/B3nedikt/restring) o [AppLocale](https://github.com/B3nedikt/AppLocale).

## Colaboradores

Esta biblioteca fue creada originalmente por:

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

Sin embargo, mi fork tiene casi todo el código cambiado y posee una API ligeramente diferente.

## Licencia

    Copyright 2017 InflationX & Contributors

    Licenciado bajo la Licencia Apache, Versión 2.0 (la "Licencia");
    no puede usar este archivo excepto en cumplimiento con la Licencia.
    Puede obtener una copia de la Licencia en

        http://www.apache.org/licenses/LICENSE-2.0

    A menos que la ley lo exija o se acuerde por escrito, el software
    distribuido bajo la Licencia se distribuye "TAL CUAL",
    SIN GARANTÍAS NI CONDICIONES DE NINGÚN TIPO, expresas o implícitas.
    Consulte la Licencia para conocer el lenguaje específico que rige los permisos y
    limitaciones bajo la Licencia.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---