[![Maven Central](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump/badge.svg)](https://maven-badges.herokuapp.com/maven-central/dev.b3nedikt.viewpump/viewpump)
[![Documentation](https://javadoc.io/badge2/dev.b3nedikt.viewpump/viewpump/javadoc.svg)](https://javadoc.io/doc/dev.b3nedikt.viewpump/viewpump)

# ViewPump 4.0.15

Vous pouvez intercepter l'inflation des vues en utilisant une API d'intercepteurs avant/après inflation.

## Pour commencer

### Dépendance

Incluez les dépendances :

```groovy
dependencies {

    implementation 'androidx.appcompat:appcompat:1.5.1'

    implementation 'dev.b3nedikt.viewpump:viewpump:4.0.15'
}
```

### Utilisation

Définissez votre intercepteur. Voici un exemple quelque peu arbitraire d’un intercepteur post-inflation qui préfixe le texte dans un TextView.

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

Voici un exemple d'intercepteur avant inflation qui retourne un CustomTextView lorsqu'un TextView est défini dans le XML de mise en page.

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

### Installation

Ajoutez vos intercepteurs au `ViewPump.builder()`, dans votre classe `Application` dans la méthode `#onCreate()` et initialisez le `ViewPump`. L'ordre des intercepteurs est important car ils forment la chaîne d'interception des requêtes et des résultats.

Un intercepteur peut choisir de retourner une vue instanciée par programme plutôt que de laisser se produire l'inflation par défaut, auquel cas les intercepteurs ajoutés après lui seront ignorés. Pour cette raison, il est préférable d'ajouter vos intercepteurs post-inflation avant les intercepteurs pré-inflation.

```java
@Override
public void onCreate() {
    super.onCreate();

    ViewPump.init(new TextUpdatingInterceptor(), new CustomTextViewInterceptor());
    //....
}
```

### Injecter dans le contexte

Ajoutez ce qui suit à votre activité de base :

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

Pour des exemples pratiques, voyez mes bibliothèques [Restring](https://github.com/B3nedikt/restring) ou [AppLocale](https://github.com/B3nedikt/AppLocale).

## Collaborateurs

Cette bibliothèque a été initialement créée par :

- [@jbarr21](https://github.com/jbarr21)
- [@chrisjenx](https://github.com/chrisjenx)

Mon fork a cependant presque tout le code modifié et possède une API légèrement différente.

## Licence

    Copyright 2017 InflationX & Contributors

    Sous licence Apache, Version 2.0 (la "Licence");
    vous ne pouvez pas utiliser ce fichier sauf en conformité avec la Licence.
    Vous pouvez obtenir une copie de la Licence à

        http://www.apache.org/licenses/LICENSE-2.0

    Sauf exigence légale ou accord écrit, le logiciel distribué sous la Licence est distribué "TEL QUEL",
    SANS GARANTIES NI CONDITIONS D’AUCUNE SORTE, explicites ou implicites.
    Reportez-vous à la Licence pour les règles spécifiques régissant les autorisations et
    limitations sous la Licence.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-01

---