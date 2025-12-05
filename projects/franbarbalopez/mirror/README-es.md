<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Mirror Logo">

<div align="center">
    <img alt="Última Versión en Packagist" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="Estado de Acciones de Pruebas en GitHub" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="Descargas Totales" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="Licencia" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

Mirror es un paquete elegante de suplantación de usuario para Laravel. Permite a los administradores iniciar sesión como otros usuarios sin problemas para solucionar problemas, brindar soporte o probar experiencias de usuario. Mirror maneja la integridad de la sesión con verificación criptográfica, expiración automática, soporte multi-guard, middleware flexible y eventos de ciclo de vida para el registro de auditoría. Perfecto para aplicaciones en producción que necesitan una suplantación de usuario confiable y segura.

## Características

- Integridad de sesión HMAC-SHA256 para prevenir manipulaciones
- Expiración TTL configurable
- Middleware para control de acceso y aplicación de TTL
- Soporte multi-guard
- Redirección de URL flexible
- Eventos de ciclo de vida para registro de auditoría

## Requisitos

- PHP 8.2+
- Laravel 11+

## Instalación

```bash
composer require franbarbalopez/mirror
```
Opcional - publicar el archivo de configuración:


```bash
php artisan vendor:publish --tag=mirror
```

## Inicio Rápido

### 1. Agregar Trait al Modelo de Usuario

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

**Importante:** Si no implementas `canImpersonate()`, todos pueden suplantar a todos. El trait devuelve `true` por defecto.

### 2. Comenzar a suplantar

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. Deja de suplantar identidad

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```

## Seguridad

Las sesiones de suplantación están protegidas con hashes HMAC-SHA256 usando la clave de tu aplicación. El hash cubre el ID del suplantador, el nombre del guardia, la hora de inicio y la URL de redirección. En cada llamada a `stop()`, Mirror verifica este hash; si alguien ha manipulado la sesión, lanza una excepción y borra todo.

Configura el TTL en `config/mirror.php` para que las sesiones expiren automáticamente después de un tiempo establecido.

## Referencia de la API

### Iniciar Suplantación

Por instancia de usuario:

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

Por clave primaria (funciona con int, UUID, ULID, etc.):

```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```

Por correo electrónico:

```php
Mirror::startByEmail('user@example.com');
```

### Detener la suplantación

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

Use `forceStop()` cuando necesite terminar la suplantación desde acciones de administrador o scripts de limpieza - omite la verificación de TTL pero aún lanza un error si la sesión ha sido manipulada.

### Comprobación del estado

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

Comprueba si la sesión de suplantación ha expirado y llama automáticamente a `stop()` si es necesario:

```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```

Bueno para proteger áreas administrativas sensibles donde deseas que las sesiones expiradas terminen de manera elegante. Ten en cuenta que cuando el TTL expira, este middleware finalizará la suplantación y redirigirá, así que asegúrate de que la limpieza de tu sesión esté configurada correctamente.

### `mirror.require`

Solo permite el acceso si se está suplantando activamente:

```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```

Útil para componentes de UI especiales que solo tienen sentido durante la suplantación, como un banner que muestra a quién estás suplantando.

### `mirror.prevent`

Bloquea el acceso mientras se está suplantando:

```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```

Protege acciones destructivas o configuraciones sensibles que solo deben ser accesibles como el usuario original, no mientras se está suplantando a otra persona.

## Autorización

El trait `Impersonatable` proporciona dos métodos que ambos retornan `true` por defecto. Sobrescríbelos para agregar tu propia lógica:

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

No necesitas el trait: Mirror buscará estos métodos en tu modelo de usuario independientemente:

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

## Redirección de URL

Puedes controlar a dónde van los usuarios al iniciar y detener la suplantación:

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
Si no especificas `leaveRedirectUrl`, se usará por defecto la URL actual donde se llamó a `start()`.

## Eventos

Mirror envía dos eventos a los que puedes suscribirte:

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

Ambos eventos contienen al suplantador, al usuario objetivo y el nombre del guardia. Útil para registros de auditoría o para activar flujos de trabajo.

Los eventos se envían **después de que la respuesta** se envía al cliente, asegurando que las operaciones críticas de suplantación se completen sin demora. Esto es especialmente importante para middleware como `mirror.ttl` que puede ejecutarse en cada solicitud.


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

## Rendimiento y Optimización

Mirror está optimizado para aplicaciones de alto rendimiento:

### Caché con Ámbito de Solicitud

El modelo de suplantación se almacena en caché dentro de una única solicitud para evitar consultas redundantes a la base de datos:

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```

Esto es particularmente beneficioso para middleware como `mirror.ttl` que se ejecutan en cada solicitud.

### Despacho Diferido de Eventos

Los eventos de suplantación se despachan después de que la respuesta se envía al cliente, asegurando que los escuchas de eventos no afecten el tiempo de respuesta. Esto mantiene rápido tu ciclo de solicitud mientras permite el registro de auditorías y otras tareas en segundo plano.

## Soporte Multi-Guard

Mirror detecta automáticamente qué guardia estás usando:

```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```

No necesitas especificar el guard manualmente: lo determina a partir del contexto de autenticación actual.

## Directivas de Blade

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

**@puedoPersonificar**

```blade
@canImpersonate
    <a href="{{ route('admin.users.index') }}">Manage Users</a>
@endcanImpersonate

{{-- With guard --}}
@canImpersonate('admin')
    <div>Admin tools</div>
@endcanImpersonate
```

**@puedeSerSuplantado**

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

## Licencia

MIT. Ver [LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md).

## Créditos

Desarrollado por [franbarbalopez](https://github.com/franbarbalopez).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-05

---