import { Provider } from 'react-redux';
import { RouterProvider } from 'react-router-dom';
import { useTitle } from '~shared/lib/dom';
import { router } from './routers';
import store from './store';
import './styles/app.scss';

function App() {
  useTitle();

  return (
    <Provider store={store}>
      <RouterProvider router={router} />
    </Provider>
  );
}

export default App;
