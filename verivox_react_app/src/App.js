import logo from './images/logo.png';
import './App.css';
import { Home } from './Components/Home/Home';
import { Products } from './Components/Products/Products';
import { Consumption } from './Components/Consumption/Consumption';
import { Navigation } from './Components/Navigation/Navigation';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { Image } from 'react-bootstrap';

function App() {
  return (
    <BrowserRouter className="page-container">
      <div className="container">
        <h6 className="m-1 d-flex justify-content-center">
          <Image src={logo} fluid />
        </h6>

        <Navigation />
        <div className="homebg">

          <Switch>
            <Route path='/' component={Home} exact />
            <Route path='/Products' component={Products} />
            <Route path='/Consumption' component={Consumption} exact />
          </Switch>
        </div>
      </div>
    </BrowserRouter>
  );
}

export default App;
