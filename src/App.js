import React,{ Component } from 'react';
import '../node_modules/bootswatch/dist/minty/bootstrap.css'
import Rotas from './Main/rotas';
import Navbar from './Components/navbar';

class App extends Component{
    
  
  render(){
    return(
      <div>
       <Navbar/>
    <div>      
    </div>
    <Rotas/>
    </div>
       
    );
  }
}

export default App;