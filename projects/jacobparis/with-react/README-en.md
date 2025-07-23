# with-react

![GitHub Repo stars](https://img.shields.io/github/stars/jacobparis/with-react?style=social)
![npm](https://img.shields.io/npm/v/with-react?style=plastic)
![GitHub](https://img.shields.io/github/license/jacobparis/with-react?style=plastic)
![npm](https://img.shields.io/npm/dy/with-react?style=plastic)
![npm](https://img.shields.io/npm/dw/with-react?style=plastic)
![GitHub top language](https://img.shields.io/github/languages/top/jacobparis/with-react?style=plastic)

A collection of React components that wrap React hooks to provide a more composable API. Each component accepts a render prop that receives the hook's return value.

This enables a lot of features that previously violate the Rules of Hooks

## Conditional Hooks

```tsx
function UserProfile({ user, showDetails }) {
  return (
    <div>
      <h1>{user.name}</h1>

      <p>
        This is a really long description and there could be more markup
        or other components between here and the top of the component.
        Since hooks need to be declared at the top of the component function,
        instead of in the JSX, you may want to use WithState instead of useState
        just for colocation reasons.
      </p>

      {showDetails && (
        <WithState initialState={user.lastLogin}>
          {(lastLogin, setLastLogin) => (
            <div>
              Last login: {lastLogin}
              <button onClick={() => setLastLogin(new Date())}>
                Update
              </button>
            </div>
          )}
        </WithState>
      )}
    </div>
  )
}
```
## Hooks within loops

This is a special case of conditional hooks, but sometimes you're rendering a lot of items in a loop and it's not worth creating a custom component for them because they require too much data from the parent scope.

But then when you need to add some state to each one, React forces you to wrap it in a component. By using WithState, that component is provided for you and you can keep your list items owned by the parent.



```tsx
const items = ['apple', 'banana', 'orange']

function FruitList() {
  return (
    <ul>
      {items.map((item) => (
        <WithState key={item} initialState={0}>
          {(count, setCount) => (
            <li>
              {item}: {count}
              <button onClick={() => setCount(count + 1)}>+</button>
            </li>
          )}
        </WithState>
      ))}
    </ul>
  )
}
```
## Form Status

The `useFormStatus()` hook from react-dom treats any parent `<form>` like a context provider, and for that reason must be used in a child component of the form.

Avoid creating a component boundary by using `WithFormStatus` and getting the value inline.


```tsx
function SearchForm() {
  return (
    <form action="/search">
      <input name="q" />
      <WithFormStatus>
        {(status) => (
          <button disabled={status.pending}>
            {status.pending ? 'Submitting...' : 'Submit'}
          </button>
        )}
      </WithFormStatus>
    </form>
  )
}
```
## Promise Resolution

The `use()` hook can unwrap promises, but it must be used in a child of the suspense boundary it's meant to trigger. Since data is best fetched at the route level, these promises will almost always be naturally higher than the UI wheir their suspense boundary needs to be.

The WithUse component allows you to pass a promise and get its resolved value directly within it.

This use-case resembles [React Router's Await component](https://reactrouter.com/api/components/Await), which is a better name but I had to stick with the theme here.


```tsx
function UserDetails() {
  return (
    <div>
      <h1>User Details</h1>
      <Suspense fallback={<Spinner />}>
        <WithUse value={getUserPromise}>
          {(user) => (
            <div>
              <p>Name: {user.name}</p>
              <p>Email: {user.email}</p>
            </div>
          )}
        </WithUse>
      </Suspense>
    </div>
  )
}
```
## Available Components

WithState and WithFormStatus are the most useful
| Hook | Component |
|------|-----------|
| `useActionState` | `WithActionState` |
| `useCallback` | `WithCallback` |
| `useContext` | X |
| `useDeferredValue` | `WithDeferredValue` |
| `useEffect` | X |
| `useFormStatus` | `WithFormStatus` |
| `useId` | `WithId` |
| `useImperativeHandle` | X |
| `useInsertionEffect` | X |
| `useLayoutEffect` | X |
| `useMemo` | `WithMemo` |
| `useReducer` | `WithReducer` |
| `useRef` | X |
| `useState` | `WithState` |
| `useSyncExternalStore` | `WithSyncExternalStore` |
| `useTransition` | `WithTransition` |
| `use` | `WithUse` |



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---