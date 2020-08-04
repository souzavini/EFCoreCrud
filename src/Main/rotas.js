import React from 'react'
import { Route, Switch , HashRouter} from 'react-router-dom'
import Home from '../Views/home';
import Produto from '../Views/Produto/produto'
import CadastroProduto from '../Views/Produto/cadastroProduto';
import Venda from '../Views/Vendas/vendas';
import cadastroVendas from '../Views/Vendas/cadastroVendas';


function Rotas(){
    return(
        <HashRouter>
            <Switch>
            <Route path="/home" component={Home}/>
            <Route path="/produto" component={Produto}/>
            <Route path="/cadastro-produto" component={CadastroProduto}/>
            <Route path="/cadastro-vendas" component={cadastroVendas}/>
            <Route path="/vendas" component={Venda}/>
            </Switch>
        </HashRouter>
    )
}
export default Rotas;