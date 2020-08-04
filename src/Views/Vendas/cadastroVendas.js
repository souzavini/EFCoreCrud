import React from 'react'
import CardForm from '../../Components/CardForm'
import FormGroup from '../../Components/FormGroup'
import { withRouter } from 'react-router-dom'
import ProdutoService from '../../Service/produtoService'


class CadastroVenda extends React.Component{

    constructor(){
        super();
        this.service = new ProdutoService();
    }

    state ={
        nomes: [],
        teste: ''
    }

    cadastrar = () =>{
        const produto = {
            data: this.state.data,
            quantidade:this.state.quantidade,
            teste: this.state.teste,
            vendedor: this.state.vendedor
        }

        console.log(produto);
    }

    obterNome= () =>{
        this.service.obterNome()
        .then(response =>{
            this.setState({nomes: response.data})
        }).catch(error => {
            console.log("Erro");
        })
    }

    componentDidMount(){
        this.obterNome();
    }


    cancelar =()=>{
        //this.props.history.push("/vendas")
        console.log(this.state.teste);
    }

    render(){
        return(
            <div>
               <div>
                <CardForm legend="Cadastro de Vendas">
                    <FormGroup htmlfor="exampleInputEmail" label="Data do Pedido">
                    <input type="date" className="form-control" id="inputProduto" name="produto" placeholder="Digite a data" onChange={e=> this.setState({data: e.target.value})}/>
                    </FormGroup>
                    <FormGroup htmlfor="exampleInputEmail" label="Quantidade">
                    <input type="number" className="form-control" id="exampleInputEmail1" placeholder="Digite a quantidade" onChange={e=> this.setState({quantidade: e.target.value})}/>
                    </FormGroup>
                    
                    <select onChange={e=> this.setState({teste: e.target.value})} >
                        {this.state.nomes.map(item=>
                          <option key={item.id} value={item.id} >{item.nomeProduto}</option>  
                            )};
                    </select>

                    <FormGroup htmlfor="exampleInputEmail" label="Escolha o vendedor">
                    <input type="text" className="form-control" id="exampleInputEmail1" placeholder="escolha o vendedor" onChange={e=> this.setState({vendedor: e.target.value})}/>
                    </FormGroup>
                    <button onClick={this.cadastrar} type="button" className="btn btn-info">Salvar </button>
                    <button type="button" onClick={this.cancelar} className="btn btn-danger"> Cancelar</button>

                </CardForm>
            </div>
            </div>
        )
    }
}
export default withRouter(CadastroVenda);