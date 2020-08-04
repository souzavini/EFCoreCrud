import React from 'react'
import CardForm from '../../Components/CardForm'
import FormGroup from '../../Components/FormGroup'
import ProdutoTable from './produtoTable'
import ProdutoService from '../../Service/produtoService';
import { withRouter } from 'react-router-dom';


class Produto extends React.Component{

    constructor(){
        super();
        this.service = new ProdutoService();
    }
    
    state ={
        produtos: [],
    }


    prepararCadastro =()=>{
        this.props.history.push("/cadastro-produto")
    }

    obterTodos= () =>{
        this.service.obterProdutos()
        .then(response =>{
            this.setState({produtos: response.data})
        }).catch(error => {
            console.log("Erro");
        })
    }

componentDidMount(){
    this.obterTodos();
}

deletar = (id) => {
    this.service.deletar(id)
        .then(response => {
            this.obterTodos();
        }).catch(error => {
            console.log("Erro ao deletar");
        })
}

editar = (id) => {
    console.log("editar",id);
    
}


    render(){
        return(
            <div>
                <br></br>
                <button type="button" onClick={this.prepararCadastro} className="btn btn-primary" style={{position:'relative', left:'1175px'}}>Adicionar Produto</button>
                <CardForm legend="Produtos"> 
                    <br></br>
                    <FormGroup label="Obter Por Id:">
                    <input type="text" className="form-control" id="inputProduto" name="produto" placeholder="Digite o ID" onChange={e=> this.setState({nomeProduto: e.target.value})}/>
                    </FormGroup>
                </CardForm>
                <ProdutoTable Produtos={this.state.produtos} 
                deletar={this.deletar}
                editar={this.editar}/>
            </div>
        )
    }
}
export default withRouter(Produto);