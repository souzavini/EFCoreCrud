import React from 'react'
import CardForm from '../../Components/CardForm'
import FormGroup from '../../Components/FormGroup'
import ProdutoTable from './produtoTable'
import { withRouter } from 'react-router-dom'
import ProdutoService from '../../Service/produtoService'


class CadastroProduto extends React.Component{

    constructor(){
        super();
        this.service = new ProdutoService();
    }

    state = {
        nomeProduto: '',
        quantidade: '',
        preco: ''
    }

    cadastrar = () =>{
        const produto = {
            nomeProduto: this.state.nomeProduto,
            quantidade:this.state.quantidade,
            precoUnitario: this.state.preco
        }

        this.service.cadastrar(produto)
        .then(response => {
            console.log("Sucesso")
            this.props.history.push('/produto')
        }).catch(erro => {
            console.log(erro.response)
        })
    }

    cancelar =()=>{
        this.props.history.push("/produto")
    }

    render(){
        return(
            <div>
               <div>
                <CardForm legend="Cadastro de Produto">
                    <FormGroup htmlfor="exampleInputEmail" label="Nome Produto">
                    <input type="text" className="form-control" id="inputProduto" name="produto" placeholder="Entre produto" onChange={e=> this.setState({nomeProduto: e.target.value})}/>
                    </FormGroup>
                    <FormGroup htmlfor="exampleInputEmail" label="Quantidade">
                    <input type="number" className="form-control" id="exampleInputEmail1" placeholder="Digite a quantidade" onChange={e=> this.setState({quantidade: e.target.value})}/>
                    </FormGroup>
                    <FormGroup htmlfor="exampleInputEmail" label="Preço produto">
                    <input type="number" className="form-control" id="exampleInputEmail1" placeholder="Digite o preço" onChange={e=> this.setState({preco: e.target.value})}/>
                    </FormGroup>
                    <button onClick={this.cadastrar} type="button" className="btn btn-info">Salvar </button>
                    <button type="button" onClick={this.cancelar} className="btn btn-danger"> Cancelar</button>

                </CardForm>
            </div>
            </div>
        )
    }
}
export default withRouter(CadastroProduto);