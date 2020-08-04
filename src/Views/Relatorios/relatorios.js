import React from 'react'
import CardForm from '../../Components/CardForm'
import FormGroup from '../../Components/FormGroup'
import ProdutoTable from './produtoTable'


class Relatorio extends React.Component{

    prepararCadastro =()=>{
        this.props.history.push("/cadastro-produto")
    }


    render(){
        return(
            <div>
                <br></br>
                <button type="button" onClick={this.prepararCadastro} className="btn btn-primary" style={{position:'relative', left:'1175px'}}>Adicionar Produto</button>
                <CardForm legend="Relatorios"> 
                    <br></br>
                    <FormGroup label="Obter Por Id:">
                    <input type="text" className="form-control" id="inputProduto" name="produto" placeholder="Digite o ID" onChange={e=> this.setState({nomeProduto: e.target.value})}/>
                    </FormGroup>
                </CardForm>
                <ProdutoTable/>
            </div>
        )
    }
}
export default Produto;