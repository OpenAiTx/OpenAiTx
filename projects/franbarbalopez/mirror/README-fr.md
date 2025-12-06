<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Logo Mirror">

<div align="center">
    <img alt="Dernière version sur Packagist" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="Statut des tests GitHub Actions" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="Nombre total de téléchargements" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="Licence" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

Mirror est un package d'usurpation d'utilisateur élégant pour Laravel. Il permet aux administrateurs de se connecter facilement en tant qu'autres utilisateurs pour résoudre des problèmes, fournir du support ou tester l'expérience utilisateur. Mirror gère l'intégrité des sessions avec une vérification cryptographique, une expiration automatique, un support multi-gardes, un middleware flexible et des événements de cycle de vie pour la journalisation d'audit. Parfait pour les applications en production nécessitant une usurpation d'utilisateur fiable et sécurisée.

## Fonctionnalités

- Intégrité de session HMAC-SHA256 pour prévenir toute falsification
- Expiration TTL configurable
- Middleware pour le contrôle d'accès et l'application du TTL
- Support multi-gardes
- Redirection d'URL flexible
- Événements de cycle de vie pour la journalisation d'audit

## Exigences

- PHP 8.2+
- Laravel 11+

## Installation

```bash
composer require franbarbalopez/mirror
```
Optionnel - publier le fichier de configuration :


```bash
php artisan vendor:publish --tag=mirror
```

## Démarrage rapide

### 1. Ajouter un Trait au Modèle Utilisateur

```php
use Illuminate\Foundation\Auth\User as Authenticatable;
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

**Important :** Si vous n’implémentez pas `canImpersonate()`, tout le monde peut se faire passer pour n’importe qui. Le trait retourne `true` par défaut.

### 2. Commencer à usurper l’identité

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. Cessez d'usurper l'identité

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```

## Sécurité

Les sessions d'usurpation sont protégées par des hachages HMAC-SHA256 utilisant la clé de votre application. Le hachage couvre l'ID de l'usurpateur, le nom du garde, l'heure de début et l'URL de redirection. À chaque appel de `stop()`, Mirror vérifie ce hachage - si quelqu'un a altéré la session, il lance une exception et efface tout.

Configurez le TTL dans `config/mirror.php` pour expirer automatiquement les sessions après un temps défini.

## Référence API

### Démarrer une usurpation

Par instance utilisateur :

```php
Mirror::start($user);

// With redirect URLs
$redirectUrl = Mirror::start(
    user: $targetUser,
    leaveRedirectUrl: route('admin.users.index'),
    startRedirectUrl: route('dashboard')
);

return redirect($redirectUrl);
```

Par clé primaire (fonctionne avec int, UUID, ULID, etc.) :

```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```
Par courriel :


```php
Mirror::startByEmail('user@example.com');
```

### Arrêt de l'usurpation d'identité

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

Utilisez `forceStop()` lorsque vous devez mettre fin à l'usurpation depuis des actions d'administration ou des scripts de nettoyage - cela ignore la vérification TTL mais génère toujours une erreur si la session a été altérée.

### Vérification de l'état

```php
Mirror::isImpersonating(): bool
Mirror::getImpersonator(): ?Authenticatable
Mirror::impersonatorId(): int|string|null
Mirror::getLeaveRedirectUrl(): ?string
```

### Alias

```php
Mirror::as($user);           // same as start()
Mirror::leave();             // same as stop()
Mirror::impersonating();     // same as isImpersonating()
Mirror::impersonator();      // same as getImpersonator()
```

## Middleware

### `mirror.ttl`

Vérifie si la session d'usurpation a expiré et appelle automatiquement `stop()` si nécessaire :

```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```

Utile pour protéger les zones d'administration sensibles où vous souhaitez que les sessions expirées se terminent proprement. Notez que lorsque le TTL expire, ce middleware met fin à l'usurpation d'identité et redirige, assurez-vous donc que le nettoyage de votre session est correctement configuré.

### `mirror.require`

N'autorise l'accès que si une usurpation d'identité est active :

```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```
Utile pour les composants UI spéciaux qui n'ont de sens que lors de l'usurpation d'identité - comme une bannière indiquant qui vous usurpez.

### `mirror.prevent`

Bloque l'accès pendant l'usurpation d'identité :


```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```

Protège les actions destructrices ou les paramètres sensibles qui ne doivent être accessibles qu'en tant qu'utilisateur original, et non lors de l'usurpation d'identité d'une autre personne.

## Autorisation

Le trait `Impersonatable` fournit deux méthodes qui retournent toutes deux `true` par défaut. Surchargez-les pour ajouter votre propre logique :

```php
use Mirror\Concerns\Impersonatable;

class User extends Authenticatable
{
    use Impersonatable;

    public function canImpersonate(): bool
    {
        return $this->hasRole('admin');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->hasRole('super-admin');
    }
}
```

Vous n'avez pas besoin du trait - Mirror recherchera ces méthodes sur votre modèle utilisateur quoi qu'il arrive :

```php
class User extends Authenticatable
{
    public function canImpersonate(): bool
    {
        return $this->hasPermission('impersonate-users');
    }

    public function canBeImpersonated(): bool
    {
        return ! $this->is_system_account;
    }
}
```

## Redirection d’URL

Vous pouvez contrôler où les utilisateurs vont lorsqu’ils commencent et arrêtent l’usurpation d’identité :

```php
public function impersonate(User $user)
{
    $redirectUrl = Mirror::start(
        user: $user,
        leaveRedirectUrl: route('admin.users.index'),  // where to go when they stop
        startRedirectUrl: route('dashboard')            // where to go right now
    );

    return redirect($redirectUrl);
}

public function leave()
{
    Mirror::stop();

    return redirect(Mirror::getLeaveRedirectUrl());
}
```

Si vous ne spécifiez pas `leaveRedirectUrl`, il prend par défaut l'URL actuelle où `start()` a été appelé.

## Événements

Mirror déclenche deux événements auxquels vous pouvez vous abonner :

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

Les deux événements contiennent l'utilisateur usurpateur, l'utilisateur cible, et le nom du garde. Utile pour les journaux d'audit ou le déclenchement de workflows.

Les événements sont déclenchés **après que la réponse** a été envoyée au client, garantissant que les opérations critiques d'usurpation se terminent sans délai. Ceci est particulièrement important pour les middlewares comme `mirror.ttl` qui peuvent s'exécuter à chaque requête.

```php
use Mirror\Events\ImpersonationStarted;

Event::listen(ImpersonationStarted::class, function (ImpersonationStarted $event) {
    // Log the activity to your audit system of choice
    Log::info('User impersonation started', [
        'impersonator_id' => $event->impersonator->id,
        'impersonated_id' => $event->impersonated->id,
        'guard' => $event->guardName,
    ]);
});
```

## Performance et optimisation

Mirror est optimisé pour les applications à haute performance :

### Mise en cache à l’échelle de la requête

Le modèle d’usurpation est mis en cache au sein d’une seule requête pour éviter les requêtes redondantes à la base de données :

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```

Cela est particulièrement bénéfique pour les middlewares comme `mirror.ttl` qui s'exécutent à chaque requête.

### Diffusion différée des événements

Les événements d'usurpation d'identité sont diffusés après l'envoi de la réponse au client, garantissant que les écouteurs d'événements n'impactent pas le temps de réponse. Cela maintient votre cycle de requête rapide tout en permettant la journalisation d'audit et d'autres tâches en arrière-plan.

## Support Multi-Guard

Mirror détecte automatiquement quel garde vous utilisez :

```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```

Vous n'avez pas besoin de spécifier manuellement le garde - il le déduit du contexte d'authentification actuel.

## Directives Blade

**@impersonating**

```blade
@impersonating
    <div class="alert">
        You're impersonating {{ auth()->user()->name }}.
        <a href="{{ route('impersonation.leave') }}">Exit</a>
    </div>
@endimpersonating

{{-- Check specific guard --}}
@impersonating('admin')
    <div>Impersonating via admin guard</div>
@endimpersonating
```

**@peuxJeUsurper**

```blade
@canImpersonate
    <a href="{{ route('admin.users.index') }}">Manage Users</a>
@endcanImpersonate

{{-- With guard --}}
@canImpersonate('admin')
    <div>Admin tools</div>
@endcanImpersonate
```

**@peutÊtreUsurpé**

```blade
{{-- Check current user --}}
@canBeImpersonated
    <span>Available for support</span>
@endcanBeImpersonated

{{-- Check specific user --}}
@canBeImpersonated($user)
    <form method="POST" action="{{ route('impersonation.start', $user) }}">
        @csrf
        <button>Impersonate</button>
    </form>
@endcanBeImpersonated

{{-- With guard --}}
@canBeImpersonated($user, 'admin')
    <button>Login as this user</button>
@endcanBeImpersonated
```

## Licence

MIT. Voir [LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md).

## Crédits

Développé par [franbarbalopez](https://github.com/franbarbalopez).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-06

---