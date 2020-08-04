import React from 'react'
import CardForm from '../../Components/CardForm'
import FormGroup from '../../Components/FormGroup'
import ProdutoTable from './produtoTable'
import { withRouter } from 'react-router-dom'
import ProdutoService from '../../Service/produtoService'


class EditarProduto extends React.Component{

    constructor(){
        super();
        this.service = new ProdutoService();
    }

    

    cancelar =()=>{
        this.props.history.push("/produto")
    }

    render(){
        return(
            <div>
               <div>
                <CardForm legend="Edição de Produto">
                    <FormGroup htmlfor="exampleInputEmail" label="Nome Produto">
                    <input type="text" className="form-control" id="inputProduto" name="produto" placeholder="Entre produto" onChange={e=> this.setState({nomeProduto: e.target.value})}/>
                    </FormGroup>
                    <FormGroup htmlfor="exampleInputEmail" label="Quantidade">
                    <input type="number" className="form-control" id="exampleInputEmail1" placeholder="Digite a quantidade" onChange={e=> this.setState({quantidade: e.target.value})}/>
                    </FormGroup>
                    <FormGroup htmlfor="exampleInputEmail" label="Preço produto">
                    <input type="number" className="form-control" id="exampleInputEmail1" placeholder="Digite o preço" onChange={e=> this.setState({preco: e.target.value})}/>
                    </FormGroup>
                    <button onClick={this.editar} type="button" className="btn btn-info">Salvar </button>
                    <button type="button" onClick={this.cancelar} className="btn btn-danger"> Cancelar</button>

                </CardForm>
            </div>
            </div>
        )
    }
}
export default withRouter(CadastroProduto);