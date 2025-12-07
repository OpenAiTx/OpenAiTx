<img src="https://raw.githubusercontent.com/franbarbalopez/mirror/master/art/logo.png" alt="Mirror Logo">

<div align="center">
    <img alt="Latest Version on Packagist" src="https://img.shields.io/packagist/v/franbarbalopez/mirror.svg">
    <img alt="GitHub Tests Action Status" src="https://img.shields.io/github/actions/workflow/status/franbarbalopez/mirror/tests.yml?label=tests">
    <img alt="Total Downloads" src="https://img.shields.io/packagist/dt/franbarbalopez/mirror.svg">
    <img alt="License" src="https://img.shields.io/packagist/l/franbarbalopez/mirror.svg">
</div>

# Mirror

Mirror 是一个优雅的 Laravel 用户冒充包。它允许管理员无缝登录为其他用户，以排查问题、提供支持或测试用户体验。Mirror 通过加密验证、自动过期、多守卫支持、灵活的中间件和生命周期事件来处理会话完整性，适合需要可靠且安全用户冒充的生产环境应用。

## 功能

- HMAC-SHA256 会话完整性防篡改
- 可配置的 TTL 过期时间
- 用于访问控制和 TTL 强制的中间件
- 多守卫支持
- 灵活的 URL 重定向
- 用于审计日志的生命周期事件

## 要求

- PHP 8.2+
- Laravel 11+

## 安装

```bash
composer require franbarbalopez/mirror
```
可选 - 发布配置文件：


```bash
php artisan vendor:publish --tag=mirror
```

## 快速开始

### 1. 向用户模型添加 Trait

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

**重要提示：** 如果不实现 `canImpersonate()`，则每个人都可以模拟每个人。该 trait 默认返回 `true`。

### 2. 开始模拟

```php
use Mirror\Facades\Mirror;

public function impersonate(User $user)
{
    Mirror::start($user);

    return redirect()->route('dashboard');
}
```

### 3. 停止冒充

```php
public function leave()
{
    Mirror::stop();

    return redirect()->route('admin.users.index');
}
```

## 安全性

模拟会话通过使用您的应用密钥的 HMAC-SHA256 哈希进行保护。哈希涵盖了模拟者 ID、守卫名称、开始时间和重定向 URL。在每次调用 `stop()` 时，Mirror 会验证此哈希——如果有人篡改了会话，它会抛出异常并清除所有内容。

在 `config/mirror.php` 中配置 TTL，以便在设定时间后自动过期会话。

## API 参考

### 开始模拟

通过用户实例：

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
通过主键（适用于 int、UUID、ULID 等）：


```php
Mirror::startByKey(123);

Mirror::startByKey('550e8400-e29b-41d4-a716-446655440000');
```
通过电子邮件发送：


```php
Mirror::startByEmail('user@example.com');
```

### 停止冒充

```php
Mirror::stop();

// Force stop - bypasses TTL check but still verifies integrity
Mirror::forceStop();
```

当需要结束管理员操作或清理脚本中的模拟身份时，使用 `forceStop()` —— 它会跳过 TTL 检查，但如果会话被篡改仍会抛出异常。

### 状态检查

```php
Mirror::isImpersonating(): bool
Mirror::getImpersonator(): ?Authenticatable
Mirror::impersonatorId(): int|string|null
Mirror::getLeaveRedirectUrl(): ?string
```

### 别名

```php
Mirror::as($user);           // same as start()
Mirror::leave();             // same as stop()
Mirror::impersonating();     // same as isImpersonating()
Mirror::impersonator();      // same as getImpersonator()
```

## 中间件

### `mirror.ttl`

检查模拟会话是否已过期，并在需要时自动调用 `stop()`：

```php
Route::middleware('mirror.ttl')->group(function () {
    Route::get('/admin/users', [UserController::class, 'index']);
    Route::get('/admin/users/{user}', [UserController::class, 'show']);
});
```
适用于保护敏感的管理区域，希望过期会话能优雅退出。请注意，当TTL过期时，该中间件将结束模拟并重定向，因此请确保正确设置会话清理。

### `mirror.require`

仅允许在主动模拟时访问：


```php
Route::middleware('mirror.require')->group(function () {
    Route::get('/impersonation/banner', function () {
        return view('impersonation.banner');
    });
});
```

适用于仅在模拟身份时才有意义的特殊 UI 组件——例如显示您正在模拟谁的横幅。

### `mirror.prevent`

在模拟身份时阻止访问：

```php
Route::middleware('mirror.prevent')->group(function () {
    Route::post('/admin/users/{user}/delete', [UserController::class, 'destroy']);
    Route::get('/admin/settings', [SettingsController::class, 'edit']);
});
```

保护破坏性操作或敏感设置，这些操作或设置应仅由原始用户访问，而非冒充他人时访问。

## 授权

`Impersonatable` 特性提供两个方法，默认均返回 `true`。重写它们以添加您自己的逻辑：

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

你不需要这个特质——Mirror 会直接在你的用户模型中查找这些方法：

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

## URL 重定向

您可以控制用户在开始和停止模拟时的去向：

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
如果你没有指定 `leaveRedirectUrl`，它默认是调用 `start()` 时的当前 URL。

## 事件

Mirror 会触发两个事件，你可以监听：

- `Mirror\Events\ImpersonationStarted`
- `Mirror\Events\ImpersonationStopped`

这两个事件都包含冒充者、目标用户和守卫名称。适用于审计日志或触发工作流。

事件在**响应发送给客户端之后**触发，确保关键的冒充操作无延迟完成。对于像 `mirror.ttl` 这样可能在每个请求中运行的中间件尤其重要。


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

## 性能与优化

Mirror 针对高性能应用进行了优化：

### 请求范围内缓存

冒充者模型在单个请求内被缓存，以避免重复的数据库查询：

```php
// This first call will query the database
$impersonator = Mirror::getImpersonator();

// Subsequent calls in the same request use the cached instance, therefore this one will not:
$impersonator = Mirror::getImpersonator();
```
这对于像 `mirror.ttl` 这样的中间件特别有益，它在每个请求中运行。

### 延迟事件分发

模拟事件在响应发送给客户端后分发，确保事件监听器不会影响响应时间。这样可以保持请求周期的快速，同时仍然允许审计日志记录和其他后台任务。

## 多守卫支持

Mirror 会自动检测您正在使用哪个守卫：


```php
Auth::guard('admin')->login($admin);

Mirror::start($user); // uses 'admin' guard

Mirror::stop(); // restores to 'admin' guard
```
你不需要手动指定守卫——它会根据当前的认证上下文自动识别。

## Blade 指令

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

**@canImpersonate**

```blade
@canImpersonate
    <a href="{{ route('admin.users.index') }}">Manage Users</a>
@endcanImpersonate

{{-- With guard --}}
@canImpersonate('admin')
    <div>Admin tools</div>
@endcanImpersonate
```

**@canBeImpersonated**

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

## 许可证

MIT。参见 [LICENSE.md](https://raw.githubusercontent.com/franbarbalopez/mirror/master/LICENSE.md)。

## 致谢

由 [franbarbalopez](https://github.com/franbarbalopez) 开发。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-07

---